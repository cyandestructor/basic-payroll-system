USE bsc_payroll_sys_db;
GO

-- PROCEDIMIENTOS DE EMPLEADO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'RegistrarEmpleado')
	DROP PROCEDURE RegistrarEmpleado;
GO

CREATE PROCEDURE RegistrarEmpleado
	@Nom_Empleado		VARCHAR(40),
	@Apellido_Pat		VARCHAR(20),
	@Apellido_Mat		VARCHAR(20),
	@Fecha_Nac			DATE,
	@CURP_Empleado		VARCHAR(18),
	@RFC_Empleado		VARCHAR(13),
	@NSS_Empleado		BIGINT,
	@Tel_Empleado		BIGINT,
	@Correo_Empleado	VARCHAR(50),
	@Banco_Empleado		INT,
	@Num_Cuenta			BIGINT,
	--Direccion
	@Calle				VARCHAR(30),
	@Numero				INT,
	@Colonia			VARCHAR(30),
	@Cod_Post			INT,
	@Ciudad				VARCHAR(30),
	@Estado				VARCHAR(30)
AS

	EXEC RegistrarDomicilio
		@Calle = @Calle,
		@Numero = @Numero,
		@Colonia = @Colonia,
		@Cod_Post = @Cod_Post,
		@Ciudad = @Ciudad,
		@Estado = @Estado;

	INSERT INTO Empleado (
		Nom_Empleado,
		Apellido_Pat,
		Apellido_Mat,
		Fecha_Nac,
		CURP_Empleado,
		RFC_Empleado,
		NSS_Empleado,
		Tel_Empleado,
		Correo_Empleado,
		Banco_Empleado,
		Num_Cuenta,
		Dom_Empleado
	)
	VALUES (
		@Nom_Empleado,
		@Apellido_Pat,
		@Apellido_Mat,
		@Fecha_Nac,
		@CURP_Empleado,
		@RFC_Empleado,
		@NSS_Empleado,
		@Tel_Empleado,
		@Correo_Empleado,
		@Banco_Empleado,
		@Num_Cuenta,
		IDENT_CURRENT('Domicilio')	--ADD THE LAST INSERTED REGISTER
	);

	DECLARE @CurrentEmployee INT;
	SET @CurrentEmployee = IDENT_CURRENT('Empleado');

	INSERT INTO Usuario (
		ID_Usuario,
		Contrasena,
		Nivel_Usuario
	)
	VALUES (
		@CurrentEmployee,
		CONVERT(VARCHAR(20), @CurrentEmployee),
		1
	);

GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'EditarEmpleado')
	DROP PROCEDURE EditarEmpleado;
GO

CREATE PROCEDURE EditarEmpleado
	@ID_Empleado		INT,
	@Nom_Empleado		VARCHAR(40),
	@Apellido_Pat		VARCHAR(20),
	@Apellido_Mat		VARCHAR(20),
	@Fecha_Nac			DATE,
	@CURP_Empleado		VARCHAR(18),
	@RFC_Empleado		VARCHAR(13),
	@NSS_Empleado		BIGINT,
	@Tel_Empleado		BIGINT,
	@Correo_Empleado	VARCHAR(50),
	@Banco_Empleado		INT,
	@Num_Cuenta			BIGINT
AS
	UPDATE Empleado
		SET Nom_Empleado = @Nom_Empleado,
			Apellido_Pat = @Apellido_Pat,
			Apellido_Mat = @Apellido_Mat,
			Fecha_Nac = @Fecha_Nac,
			CURP_Empleado = @CURP_Empleado,
			RFC_Empleado = @RFC_Empleado,
			NSS_Empleado = @NSS_Empleado,
			Tel_Empleado = @Tel_Empleado,
			Correo_Empleado = @Correo_Empleado,
			Banco_Empleado = @Banco_Empleado,
			Num_Cuenta = @Num_Cuenta
		WHERE ID_Empleado = @ID_Empleado;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AgregarEmpresaEmpleado')
	DROP PROCEDURE AgregarEmpresaEmpleado;
GO

CREATE PROCEDURE AgregarEmpresaEmpleado
	@ID_Empleado		INT,
	@RFC_Empresa		VARCHAR(12),
	@Fecha_Contrato		DATE
AS
	UPDATE Empleado
		SET
			ID_Empresa = @RFC_Empresa,
			Fecha_Contrato = @Fecha_Contrato
		WHERE
			ID_Empleado = @ID_Empleado;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AsignarDptoEmpleado')
	DROP PROCEDURE AsignarDptoEmpleado;
GO

CREATE PROCEDURE AsignarDptoEmpleado
	@ID_Empleado	INT,
	@ID_Dpto		INT
AS
	UPDATE Empleado
		SET
			ID_Dpto = @ID_Dpto,
			Fecha_Incorp = CONVERT(DATE, GETDATE())
		WHERE
			ID_Empleado = @ID_Empleado;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AsignarPuestoEmpleado')
	DROP PROCEDURE AsignarPuestoEmpleado;
GO

CREATE PROCEDURE AsignarPuestoEmpleado
	@ID_Empleado	INT,
	@ID_Puesto		INT
AS
	UPDATE Empleado
		SET
			ID_Puesto = @ID_Puesto,
			Fecha_Obt = CONVERT(DATE, GETDATE())
		WHERE
			ID_Empleado = @ID_Empleado;
GO

-- PROCEDIMIENTOS DE EMPRESA

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'RegistrarEmpresa')
	DROP PROCEDURE RegistrarEmpresa;
GO

CREATE PROCEDURE RegistrarEmpresa
	@RFC_Empresa VARCHAR(12),
	@Nom_Empresa VARCHAR(60),
	@Reg_Patronal BIGINT,
	@Razon_Social VARCHAR(80),
	@Tel_Empresa BIGINT,
	@Correo_Empresa VARCHAR(50),
	@Frec_Pago TINYINT,
	@Inicio_Ops DATE,
	--Direccion
	@Calle				VARCHAR(30),
	@Numero				INT,
	@Colonia			VARCHAR(30),
	@Cod_Post			INT,
	@Ciudad				VARCHAR(30),
	@Estado				VARCHAR(30)
AS
	EXEC RegistrarDomicilio
		@Calle = @Calle,
		@Numero = @Numero,
		@Colonia = @Colonia,
		@Cod_Post = @Cod_Post,
		@Ciudad = @Ciudad,
		@Estado = @Estado;

	INSERT INTO Empresa (
		RFC_Empresa,
		Nom_Empresa,
		Reg_Patronal,
		Razon_Social,
		Dom_Fiscal,
		Tel_Empresa,
		Correo_Empresa,
		Frec_Pago,
		Inicio_Ops
	)
	VALUES (
		@RFC_Empresa,
		@Nom_Empresa,
		@Reg_Patronal,
		@Razon_Social,
		IDENT_CURRENT('Domicilio'), --ADD THE LAST INSERTED REGISTER
		@Tel_Empresa,
		@Correo_Empresa,
		@Frec_Pago,
		@Inicio_Ops
	);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'EditarEmpresa')
	DROP PROCEDURE EditarEmpresa;
GO

CREATE PROCEDURE EditarEmpresa
	@RFC_Empresa VARCHAR(12),
	@Nom_Empresa VARCHAR(60),
	@Reg_Patronal BIGINT,
	@Razon_Social VARCHAR(80),
	@Tel_Empresa BIGINT,
	@Correo_Empresa VARCHAR(50),
	@Frec_Pago TINYINT,
	@Inicio_Ops DATE
AS
	UPDATE Empresa
		SET Nom_Empresa = @Nom_Empresa,
			Reg_Patronal = @Reg_Patronal,
			Razon_Social = @Razon_Social,
			Tel_Empresa = @Tel_Empresa,
			Correo_Empresa = @Correo_Empresa,
			Frec_Pago = @Frec_Pago,
			Inicio_Ops = @Inicio_Ops
		WHERE RFC_Empresa = @RFC_Empresa;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AsignarGerenteEmpresa')
	DROP PROCEDURE AsignarGerenteEmpresa;
GO

CREATE PROCEDURE AsignarGerenteEmpresa
	@RFC_Empresa VARCHAR(12),
	@ID_Gerente INT
AS
	UPDATE Empresa
		SET Gerente_Empresa = @ID_Gerente,
			Inicio_Gestion = GETDATE()
		WHERE RFC_Empresa = @RFC_Empresa;

	UPDATE Usuario
		SET Nivel_Usuario = 3
		WHERE ID_Usuario = @ID_Gerente;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AgregarDptoEmpresa')
	DROP PROCEDURE AgregarDptoEmpresa;
GO

CREATE PROCEDURE AgregarDptoEmpresa
	@ID_Empresa			VARCHAR(12),
	@ID_Dpto			INT,
	@Sueldo_Base		FLOAT,
	@Mode				TINYINT
AS

	-- Mode 1 : Insert
	-- Mode 2: Edit Sueldo_Base
	-- Mode 3: Deactivate relationship

	IF (@Mode = 1)
		BEGIN
			INSERT INTO Empresa_Dpto (
				ID_Empresa,
				ID_Dpto,
				Sueldo_Base
			)
			VALUES (
				@ID_Empresa,
				@ID_Dpto,
				@Sueldo_Base
			);
		END

	IF (@Mode = 2)
		BEGIN
			Update Empresa_Dpto
				SET Sueldo_Base = @Sueldo_Base
				WHERE ID_Empresa = @ID_Empresa AND ID_Dpto = @ID_Dpto;
		END

	IF (@Mode = 3)
		BEGIN
			Update Empresa_Dpto
				SET Activo = 0
				WHERE ID_Empresa = @ID_Empresa AND ID_Dpto = @ID_Dpto;
		END

GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AgregarPuestoEmpresa')
	DROP PROCEDURE AgregarPuestoEmpresa;
GO

CREATE PROCEDURE AgregarPuestoEmpresa
	@ID_Empresa			VARCHAR(12),
	@ID_Puesto			INT,
	@Mode				TINYINT
AS

	-- Mode 1 : Insert
	-- Mode 2: Deactivate relationship

	IF (@Mode = 1)
		BEGIN
			INSERT INTO Empresa_Puesto(
				ID_Empresa,
				ID_Puesto
			)
			VALUES (
				@ID_Empresa,
				@ID_Puesto
			);
		END

	IF (@Mode = 2)
		BEGIN
			Update Empresa_Puesto
				SET Activo = 0
				WHERE ID_Empresa = @ID_Empresa AND ID_Puesto = @ID_Puesto;
		END

GO

-- PROCEDIMIENTOS DE DEPARTAMENTO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'RegistrarDepartamento')
	DROP PROCEDURE RegistrarDepartamento;
GO

CREATE PROCEDURE RegistrarDepartamento
	@Nom_Dpto		VARCHAR(30)
AS
	INSERT INTO Departamento (Nom_Dpto) VALUES (@Nom_Dpto);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'EditarDepartamento')
	DROP PROCEDURE EditarDepartamento;
GO

CREATE PROCEDURE EditarDepartamento
	@ID_Dpto		INT,
	@Nom_Dpto		VARCHAR(30)
AS
	UPDATE Departamento
		SET Nom_Dpto = @Nom_Dpto
		WHERE ID_Dpto = @ID_Dpto;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AsignarGerenteDpto')
	DROP PROCEDURE AsignarGerenteDpto;
GO

CREATE PROCEDURE AsignarGerenteDpto
	@ID_Empresa		VARCHAR(12),
	@ID_Dpto		INT,
	@ID_Gerente		INT,
	@Cant_Bono		FLOAT
AS
	UPDATE Empresa_Dpto
		SET Gerente_Dpto = @ID_Gerente,
			Inicio_Gestion = GETDATE(),
			Cant_Bono = @Cant_Bono
		WHERE ID_Empresa = @ID_Empresa AND ID_Dpto = @ID_Dpto;

	UPDATE Usuario
		SET Nivel_Usuario = 2
		WHERE ID_Usuario = @ID_Gerente;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AgregarPuestoDpto')
	DROP PROCEDURE AgregarPuestoDpto;
GO

CREATE PROCEDURE AgregarPuestoDpto
	@ID_Dpto		INT,
	@ID_Puesto		INT,
	@Porcent_Sueldo	FLOAT,
	@Mode			TINYINT
AS
	IF (@Mode = 1)
		BEGIN
			INSERT INTO Dpto_Puesto (
				ID_Dpto,
				ID_Puesto,
				Porcent_Sueldo
			)
			VALUES (
				@ID_Dpto,
				@ID_Puesto,
				@Porcent_Sueldo
			);
		END

	IF (@Mode = 2)
		BEGIN
			UPDATE Dpto_Puesto
				SET Porcent_Sueldo = @Porcent_Sueldo
				WHERE ID_Dpto = @ID_Dpto AND ID_Puesto = @ID_Puesto;
		END

	IF (@Mode = 3)
		BEGIN
			UPDATE Dpto_Puesto
				SET Activo = 0
				WHERE ID_Dpto = @ID_Dpto AND ID_Puesto = @ID_Puesto;
		END
GO

-- PROCEDIMIENTOS DE PUESTO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'RegistrarPuesto')
	DROP PROCEDURE RegistrarPuesto;
GO

CREATE PROCEDURE RegistrarPuesto
	@Nom_Puesto		VARCHAR(20)
AS
	INSERT INTO Puesto (Nom_Puesto) VALUES (@Nom_Puesto);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'EditarPuesto')
	DROP PROCEDURE EditarPuesto;
GO

CREATE PROCEDURE EditarPuesto
	@ID_Puesto		INT,
	@Nom_Puesto		VARCHAR(20)
AS
	UPDATE Puesto
		SET Nom_Puesto = @Nom_Puesto
		WHERE ID_Puesto = @ID_Puesto;
GO

-- PROCEDIMIENTOS DE PERCEPCIONES

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'GenerarPercepcion')
	DROP PROCEDURE GenerarPercepcion;
GO

CREATE PROCEDURE GenerarPercepcion
	@Desc_Percep	VARCHAR(100),
	@Cant_Fija		FLOAT,
	@Cant_Porcent	FLOAT,
	@ID_Empleado	INT
AS
	INSERT INTO Percepcion (
		Desc_Percep,
		Cant_Fija,
		Cant_Porcent,
		ID_Empleado,
		Fecha_Percep
	)
	VALUES (
		@Desc_Percep,
		@Cant_Fija,
		@Cant_Porcent,
		@ID_Empleado,
		GETDATE()
	);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'VerPercepciones')
	DROP PROCEDURE VerPercepciones;
GO

CREATE PROCEDURE VerPercepciones
AS
	SELECT
		ID_Percep,
		Desc_Percep,
		Cant_Fija,
		Cant_Porcent,
		ID_Empleado,
		Fecha_Percep
	FROM Percepcion;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'VerPercepcionesEmpleado')
	DROP PROCEDURE VerPercepcionesEmpleado;
GO

CREATE PROCEDURE VerPercepcionesEmpleado
	@ID_Empleado	INT,
	@From			DATE,
	@To				DATE
AS
	SELECT
		ID_Percep,
		Desc_Percep,
		Cant_Fija,
		Cant_Porcent,
		Fecha_Percep
	FROM Percepcion
	WHERE ID_Empleado = @ID_Empleado AND (Fecha_Percep BETWEEN @From AND @To);
GO

-- PROCEDIMIENTOS DE DEDUCCIONES

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'GenerarDeduccion')
	DROP PROCEDURE GenerarDeduccion;
GO

CREATE PROCEDURE GenerarDeduccion
	@Desc_Deducc	VARCHAR(100),
	@Cant_Fija		FLOAT,
	@Cant_Porcent	FLOAT,
	@ID_Empleado	INT
AS
	INSERT INTO Deduccion (
		Desc_Deducc,
		Cant_Fija,
		Cant_Porcent,
		ID_Empleado,
		Fecha_Deducc
	)
	VALUES (
		@Desc_Deducc,
		@Cant_Fija,
		@Cant_Porcent,
		@ID_Empleado,
		GETDATE()
	);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'VerDeducciones')
	DROP PROCEDURE VerDeducciones;
GO

CREATE PROCEDURE VerDeducciones
AS
	SELECT
		ID_Deducc,
		Desc_Deducc,
		Cant_Fija,
		Cant_Porcent,
		ID_Empleado,
		Fecha_Deducc
	FROM Deduccion;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'VerDeduccionesEmpleado')
	DROP PROCEDURE VerDeduccionesEmpleado;
GO

CREATE PROCEDURE VerDeduccionesEmpleado
	@ID_Empleado	INT,
	@From			DATE,
	@To				DATE
AS
	SELECT
		ID_Deducc,
		Desc_Deducc,
		Cant_Fija,
		Cant_Porcent,
		Fecha_Deducc
	FROM Deduccion
	WHERE ID_Empleado = @ID_Empleado AND (Fecha_Deducc BETWEEN @From AND @To);
GO

-- PROCEDIMIENTOS DE NOMINA

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'GenerarNomina')
	DROP PROCEDURE GenerarNomina;
GO

CREATE PROCEDURE GenerarNomina
	@ID_Empleado		INT,
	@Inicio_Periodo		DATE,
	@Fin_Periodo		DATE
AS

	DECLARE @SueldoDiario	FLOAT;
	SET @SueldoDiario = (SELECT 'Sueldo diario' FROM [Employees Daily Salary] AS EDS WHERE EDS.ID = @ID_Empleado);
	
	DECLARE @DiasPeriodo INT;
	SET @DiasPeriodo = DATEDIFF(DAY, @Inicio_Periodo, @Fin_Periodo);

	DECLARE @SueldoBruto FLOAT;
	SET @SueldoBruto = @SueldoDiario * @DiasPeriodo;

	-- GENERAR PERCEPCIONES BASE

	-- Sueldo diario
	EXEC GenerarPercepcion
		@Desc_Percep = 'Salario',
		@Cant_Fija = @SueldoBruto,
		@Cant_Porcent = 0,
		@ID_Empleado = @ID_Empleado; -- The second @ID_Empleado is a local parameter

	-- TODO: GENERAR DEDUCCIONES BASE

	DECLARE @TotalPercepFija	FLOAT;
	SET @TotalPercepFija =	(SELECT SUM(Cant_Fija)
							FROM Percepcion
							WHERE ID_Empleado = @ID_Empleado AND (Fecha_Percep BETWEEN @Inicio_Periodo AND @Fin_Periodo));

	DECLARE @TotalDeduccFija	FLOAT;
	SET @TotalDeduccFija =	(SELECT SUM(Cant_Fija)
							FROM Deduccion
							WHERE ID_Empleado = @ID_Empleado AND (Fecha_Deducc BETWEEN @Inicio_Periodo AND @Fin_Periodo));

	DECLARE @TotalPercepPorcent FLOAT;
	SET @TotalPercepPorcent = (SELECT SUM(T.TotalFijo)
								FROM
									(SELECT
										(@SueldoDiario * Cant_Porcent) AS TotalFijo
									FROM
										Percepcion
									WHERE
										ID_Empleado = @ID_Empleado AND (Fecha_Percep BETWEEN @Inicio_Periodo AND @Fin_Periodo)) AS T);

	DECLARE @TotalDeduccPorcent FLOAT;
	SET @TotalDeduccPorcent = (SELECT SUM(T.TotalFijo)
								FROM
									(SELECT
										(@SueldoDiario * Cant_Porcent) AS TotalFijo
									FROM
										Deduccion
									WHERE
										ID_Empleado = @ID_Empleado AND (Fecha_Deducc BETWEEN @Inicio_Periodo AND @Fin_Periodo)) AS T);

	INSERT INTO Nomina (
		ID_Empleado,
		Sueldo_Bruto,
		Sueldo_Neto,
		Inicio_Periodo,
		Fin_Periodo
	)
	VALUES (
		@ID_Empleado,
		@SueldoBruto,
		(@TotalPercepFija + @TotalPercepPorcent) - (@TotalDeduccFija + @TotalDeduccPorcent),
		@Inicio_Periodo,
		@Fin_Periodo
	);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'VerNomina')
	DROP PROCEDURE VerNomina;
GO

CREATE PROCEDURE VerNomina
AS
	SELECT
		ID_Nomina,
		Sueldo_Bruto,
		Sueldo_Neto,
		ID_Empleado,
		Inicio_Periodo,
		Fin_Periodo
	FROM Nomina;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'VerNominaEmpleado')
	DROP PROCEDURE VerNominaEmpleado;
GO

CREATE PROCEDURE VerNominaEmpleado
	@ID_Empleado	INT,
	@From			DATE,
	@To				DATE
AS
	SELECT
		ID_Nomina,
		Sueldo_Bruto,
		Sueldo_Neto,
		ID_Empleado,
		Inicio_Periodo,
		Fin_Periodo
	FROM Nomina
	WHERE
		ID_Empleado = @ID_Empleado
		AND Inicio_Periodo >= @From
		AND Fin_Periodo <= @To;
GO

-- PROCEDIMIENTOS DE INCIDENCIAS

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'GenerarIncidencia')
	DROP PROCEDURE GenerarIncidencia;
GO

CREATE PROCEDURE GenerarIncidencia
	@Desc_Inciden		VARCHAR(100),
	@Inicio_Inciden		DATE,
	@Fin_Inciden		DATE,
	@ID_Solicitante		INT,
	@Fecha_Solicitud	DATE,
	@Motiv_Solicitud	VARCHAR(255)
AS
	INSERT INTO Incidencia (
		Desc_Inciden,
		Inicio_Inciden,
		Fin_Inciden,
		ID_Solicitante,
		Fecha_Solicitud,
		Motiv_Solicitud
	)
	VALUES (
		@Desc_Inciden,
		@Inicio_Inciden,
		@Fin_Inciden,
		@ID_Solicitante,
		@Fecha_Solicitud,
		@Motiv_Solicitud
	);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'RevisarIncidencia')
	DROP PROCEDURE RevisarIncidencia;
GO

CREATE PROCEDURE RevisarIncidencia
	@ID_Incidencia	INT,
	@ID_Gerente		INT,
	@Fecha_Revision	DATE,
	@Est_Autoriza	TINYINT,
	@Goce_Sueldo	BIT
AS
	UPDATE Incidencia
		SET ID_Gerente = @ID_Gerente,
			Fecha_Revision = @Fecha_Revision,
			Est_Autoriza = @Est_Autoriza,
			Goce_Sueldo = @Goce_Sueldo
		WHERE ID_Inciden = @ID_Incidencia;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'VerIncidencias')
	DROP PROCEDURE VerIncidencias;
GO

CREATE PROCEDURE VerIncidencias
	@UnauthorizedOnly	BIT
AS
	IF (@UnauthorizedOnly = 0)
		BEGIN
			SELECT
				-- TODO: ID
				Desc_Inciden,
				Inicio_Inciden,
				Fin_Inciden,
				ID_Solicitante,
				Fecha_Solicitud,
				Motiv_Solicitud,
				ID_Gerente,
				Fecha_Revision,
				Est_Autoriza,
				Goce_Sueldo
			FROM Incidencia;
		END
	ELSE
		BEGIN
			SELECT
				-- TODO: ID
				Desc_Inciden,
				Inicio_Inciden,
				Fin_Inciden,
				ID_Solicitante,
				Fecha_Solicitud,
				Motiv_Solicitud,
				ID_Gerente,
				Fecha_Revision,
				Est_Autoriza,
				Goce_Sueldo
			FROM Incidencia
			WHERE Est_Autoriza != 1;
		END
GO

-- PROCEDIMIENTOS DE DOMICILIO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'RegistrarDomicilio')
	DROP PROCEDURE RegistrarDomicilio;
GO

CREATE PROCEDURE RegistrarDomicilio
	@Calle				VARCHAR(30),
	@Numero				INT,
	@Colonia			VARCHAR(30),
	@Cod_Post			INT,
	@Ciudad				VARCHAR(30),
	@Estado				VARCHAR(30)
AS
	INSERT INTO Domicilio (
		Calle,
		Numero,
		Colonia,
		Cod_Post,
		Ciudad,
		Estado	
	)
	VALUES (
		@Calle,
		@Numero,
		@Colonia,
		@Cod_Post,
		@Ciudad,
		@Estado
	);
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'EditarDomicilio')
	DROP PROCEDURE EditarDomicilio;
GO

CREATE PROCEDURE EditarDomicilio
	@ID_Domicilio		INT,
	@Calle				VARCHAR(30),
	@Numero				INT,
	@Colonia			VARCHAR(30),
	@Cod_Post			INT,
	@Ciudad				VARCHAR(30),
	@Estado				VARCHAR(30)
AS
	UPDATE Domicilio
		SET Calle = @Calle,
			Numero = @Numero,
			Colonia = @Colonia,
			Cod_Post = @Cod_Post,
			Ciudad = @Ciudad,
			Estado = @Estado
		WHERE ID_Domicilio = @ID_Domicilio;
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'GenReporteNomina')
	DROP PROCEDURE GenReporteNomina;
GO

CREATE PROCEDURE GenReporteNomina

AS
	-- TODO
GO

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'GenReciboNomina')
	DROP PROCEDURE GenReciboNomina;
GO

CREATE PROCEDURE GenReciboNomina
	@ID_Empleado	INT,
	@Fecha_Pago		DATE
AS
	SELECT
		[RFC de Empresa],
		[Razon Social Empresa],
		[Reg. Patronal Empresa],
		[Numero de Empleado],
		[Nombre Empleado],
		[NSS],
		[RFC Empleado],
		[CURP],
		[Fecha de contrato],
		[Departamento],
		[Puesto],
		[ID Nomina],
		[Fecha de pago],
		[Inicio de periodo],
		[Fin de periodo],
		[Dias de periodo],
		[Sueldo Diario]
	FROM [Payroll Receipt]
	WHERE
		[Numero de Empleado] = @ID_Empleado AND [Fecha de pago] = @Fecha_Pago;
GO