USE bsc_payroll_sys_db;
GO

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

IF EXISTS(SELECT name FROM sysobjects WHERE type = 'P' AND name = 'AgregarDptoEmpleado')
	DROP PROCEDURE AgregarDptoEmpleado;
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