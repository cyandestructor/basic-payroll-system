CREATE DATABASE bsc_payroll_sys_db;
USE bsc_payroll_sys_db;

-- Tablas primas

CREATE TABLE Empresa(
	RFC_Empresa		VARCHAR(12) NOT NULL,
	Nom_Empresa		VARCHAR(60),
	Reg_Patronal	VARCHAR(11),
	Razon_Social	VARCHAR(80),
	Dom_Fiscal		INT,
	Tel_Empresa		BIGINT,
	Correo_Empresa	VARCHAR(50),
	Frec_Pago		TINYINT,
	Inicio_Ops		DATE,
	Gerente_Empresa	INT,
	Inicio_Gestion	DATE,
	Activo			BIT DEFAULT 1

	CONSTRAINT PK_Empresa
		PRIMARY KEY (RFC_Empresa)
);

CREATE TABLE Usuario(
	ID_Usuario		INT NOT NULL,
	Contrasena		VARCHAR(20),
	Nivel_Usuario	TINYINT,

	CONSTRAINT PK_Usuario
		PRIMARY KEY (ID_Usuario)
);

CREATE TABLE Empleado(
	ID_Empleado		INT NOT NULL IDENTITY(1000, 1),
	Nom_Empleado	VARCHAR(40),
	Apellido_Pat	VARCHAR(20),
	Apellido_Mat	VARCHAR(20),
	Fecha_Nac		DATE,
	CURP_Empleado	VARCHAR(18),
	RFC_Empleado	VARCHAR(13),
	NSS_Empleado	BIGINT,
	Dom_Empleado	INT,
	Tel_Empleado	BIGINT,
	Correo_Empleado	VARCHAR(50),
	Banco_Empleado	INT,
	Num_Cuenta		BIGINT,
	ID_Empresa		VARCHAR(12),
	Fecha_Contrato	DATE,
	ID_Dpto			INT,
	Fecha_Incorp	DATE,
	ID_Puesto		INT,
	Fecha_Obt		DATE,
	ID_Usuario		INT,
	Activo			BIT DEFAULT 1

	CONSTRAINT PK_Empleado
		PRIMARY KEY (ID_Empleado)
);

CREATE TABLE Departamento(
	ID_Dpto			INT NOT NULL IDENTITY,
	Nom_Dpto		VARCHAR(30),
	Activo			BIT DEFAULT 1

	CONSTRAINT PK_Departamento
		PRIMARY KEY (ID_Dpto)
);

CREATE TABLE Puesto(
	ID_Puesto		INT NOT NULL IDENTITY,
	Nom_Puesto		VARCHAR(20),
	Activo			BIT DEFAULT 1

	CONSTRAINT PK_Puesto
		PRIMARY KEY (ID_Puesto)
);

CREATE TABLE Percepcion(
	ID_Percep		INT NOT NULL IDENTITY(100, 1),
	Desc_Percep		VARCHAR(100),
	Cant_Fija		FLOAT,
	Cant_Porcent	FLOAT,
	ID_Empleado		INT NOT NULL,
	Fecha_Percep	DATE,
	ID_Nomina		INT

	CONSTRAINT PK_Percepcion
		PRIMARY KEY (ID_Percep)
);

CREATE TABLE Deduccion(
	ID_Deducc		INT NOT NULL IDENTITY(100, 1),
	Desc_Deducc		VARCHAR(100),
	Cant_Fija		FLOAT,
	Cant_Porcent	FLOAT,
	ID_Empleado		INT NOT NULL,
	Fecha_Deducc	DATE,
	ID_Nomina		INT

	CONSTRAINT PK_Deduccion
		PRIMARY KEY (ID_Deducc)
);

CREATE TABLE Nomina(
	ID_Nomina		INT NOT NULL IDENTITY(1000, 1),
	Sueldo_Bruto	FLOAT,
	Sueldo_Neto		FLOAT,
	ID_Empleado		INT NOT NULL,
	Inicio_Periodo	DATE,
	Fin_Periodo		DATE,
	Fecha_Gen	DATETIME DEFAULT GETDATE()

	CONSTRAINT PK_Nomina
		PRIMARY KEY (ID_Nomina)
);

CREATE TABLE Incidencia(
	ID_Inciden		INT NOT NULL IDENTITY,
	Desc_Inciden	VARCHAR(100),
	Inicio_Inciden	DATE,
	Fin_Inciden		DATE,
	ID_Solicitante	INT NOT NULL,
	Fecha_Solicitud	DATE,
	Motiv_Solicitud	VARCHAR(255),
	ID_Gerente		INT,
	Fecha_Revision	DATE,
	Est_Autoriza	TINYINT,
	Goce_Sueldo		BIT,

	CONSTRAINT PK_Incidencia
		PRIMARY KEY (ID_Inciden)
);

-- Tablas de relaciones

CREATE TABLE Empresa_Dpto(
	ID_Emp_Dpto		INT NOT NULL IDENTITY,
	ID_Empresa		VARCHAR(12),
	ID_Dpto			INT,
	Sueldo_Base		FLOAT,
	Gerente_Dpto	INT,
	Inicio_Gestion	DATE,
	Cant_Bono		FLOAT,
	Activo			BIT DEFAULT 1

	CONSTRAINT PK_EmpresaDpto
		PRIMARY KEY (ID_Emp_Dpto),
	CONSTRAINT FK_Empresa_ED
		FOREIGN KEY (ID_Empresa)
		REFERENCES Empresa(RFC_Empresa),
	CONSTRAINT FK_Departamento_ED
		FOREIGN KEY (ID_Dpto)
		REFERENCES Departamento(ID_Dpto),
	CONSTRAINT FK_GerenteDpto_ED
		FOREIGN KEY (Gerente_Dpto)
		REFERENCES Empleado(ID_Empleado)
);

CREATE TABLE Empresa_Puesto(
	ID_Emp_Puesto	INT NOT NULL IDENTITY,
	ID_Empresa		VARCHAR(12),
	ID_Puesto		INT,
	Activo			BIT DEFAULT 1

	CONSTRAINT PK_EmpresaPuesto
		PRIMARY KEY (ID_Emp_Puesto),
	CONSTRAINT FK_Empresa_EP
		FOREIGN KEY (ID_Empresa)
		REFERENCES Empresa(RFC_Empresa),
	CONSTRAINT FK_Puesto_EP
		FOREIGN KEY (ID_Puesto)
		REFERENCES Puesto(ID_Puesto)
);

CREATE TABLE Dpto_Puesto(
	ID_Dpto_Puesto	INT NOT NULL IDENTITY,
	ID_Dpto			INT,
	ID_Puesto		INT,
	Porcent_Sueldo	FLOAT,
	Activo			BIT DEFAULT 1

	CONSTRAINT PK_DptoPuesto
		PRIMARY KEY (ID_Dpto_Puesto),
	CONSTRAINT FK_Departamento_DP
		FOREIGN KEY (ID_Dpto)
		REFERENCES Departamento(ID_Dpto),
	CONSTRAINT FK_Puesto_DP
		FOREIGN KEY (ID_Puesto)
		REFERENCES Puesto(ID_Puesto)
);

-- Tablas de normalizacion

CREATE TABLE Domicilio(
	ID_Domicilio	INT NOT NULL IDENTITY,
	Calle			VARCHAR(30),
	Numero			INT,
	Colonia			VARCHAR(30),
	Cod_Post		INT,
	Ciudad			VARCHAR(30),
	Estado			VARCHAR(30),

	CONSTRAINT PK_Domicilio
		PRIMARY KEY (ID_Domicilio)
);

CREATE TABLE Banco(
	ID_Banco		INT NOT NULL IDENTITY,
	Nom_Banco		VARCHAR(30),

	CONSTRAINT PK_Banco
		PRIMARY KEY (ID_Banco)
);

-- Add Foreign Keys

ALTER TABLE Empresa
	ADD CONSTRAINT FK_Gerente_Empresa
			FOREIGN KEY (Gerente_Empresa)
			REFERENCES Empleado(ID_Empleado),
		CONSTRAINT FK_Domicilio_Fiscal_Empresa
			FOREIGN KEY (Dom_Fiscal)
			REFERENCES Domicilio(ID_Domicilio);

ALTER TABLE Empleado
	ADD CONSTRAINT FK_Domicilio_Empleado
			FOREIGN KEY (Dom_Empleado)
			REFERENCES Domicilio(ID_Domicilio),
		CONSTRAINT FK_Banco_Empleado
			FOREIGN KEY (Banco_Empleado)
			REFERENCES Banco(ID_Banco),
		CONSTRAINT FK_Empresa_Empleado
			FOREIGN KEY (ID_Empresa)
			REFERENCES Empresa(RFC_Empresa),
		CONSTRAINT FK_Departamento_Empleado
			FOREIGN KEY (ID_Dpto)
			REFERENCES Departamento(ID_Dpto),
		CONSTRAINT FK_Puesto_Empleado
			FOREIGN KEY (ID_Puesto)
			REFERENCES Puesto(ID_Puesto),
		CONSTRAINT FK_Usuario_Empleado
			FOREIGN KEY (ID_Usuario)
			REFERENCES Usuario(ID_Usuario);

ALTER TABLE Percepcion
	ADD CONSTRAINT FK_Empleado_Percepcion
			FOREIGN KEY (ID_Empleado)
			REFERENCES Empleado(ID_Empleado),
		CONSTRAINT FK_Nomina_Percepcion
			FOREIGN KEY (ID_Nomina)
			REFERENCES Nomina(ID_Nomina);

ALTER TABLE Incidencia
	ADD CONSTRAINT FK_Solicitante_Incidencia
			FOREIGN KEY (ID_Solicitante)
			REFERENCES Empleado(ID_Empleado),
		CONSTRAINT FK_Gerente_Incidencia
			FOREIGN KEY (ID_Gerente)
			REFERENCES Empleado(ID_Empleado);

ALTER TABLE Deduccion
	ADD CONSTRAINT FK_Empleado_Deduccion
			FOREIGN KEY (ID_Empleado)
			REFERENCES Empleado(ID_Empleado),
		CONSTRAINT FK_Nomina_Percepcion
			FOREIGN KEY (ID_Nomina)
			REFERENCES Nomina(ID_Nomina);

ALTER TABLE Nomina
	ADD CONSTRAINT FK_Empleado_Nomina
			FOREIGN KEY (ID_Empleado)
			REFERENCES Empleado(ID_Empleado);