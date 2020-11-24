USE bsc_payroll_sys_db;
GO

-- Sample data

INSERT
	INTO Empresa(
		RFC_Empresa,
		Nom_Empresa,
		Reg_Patronal,
		Tel_Empresa,
		Correo_Empresa,
		Frec_Pago,
		Inicio_Ops
		)
	VALUES(
		'APP4810391F2',
		'Appricot',
		12910139101,
		83611208,
		'contacto@appricot.com',
		15,
		CONVERT(DATE, GETDATE())
	);

INSERT
	INTO Empresa(
		RFC_Empresa,
		Nom_Empresa,
		Reg_Patronal,
		Tel_Empresa,
		Correo_Empresa,
		Frec_Pago,
		Inicio_Ops
		)
	VALUES(
		'EDF4820493G5',
		'Edificios Montana',
		11980532601,
		83631585,
		'contact@edifmontana.com',
		15,
		CONVERT(DATE, GETDATE())
	);

INSERT
	INTO Empresa(
		RFC_Empresa,
		Nom_Empresa,
		Reg_Patronal,
		Tel_Empresa,
		Correo_Empresa,
		Frec_Pago,
		Inicio_Ops
		)
	VALUES(
		'PAN6870492H4',
		'Productos Nacionales',
		329161298134,
		8232160981,
		'productos@pnacional.com',
		7,
		CONVERT(DATE, GETDATE())
	);

INSERT
	INTO Empresa(
		RFC_Empresa,
		Nom_Empresa,
		Reg_Patronal,
		Tel_Empresa,
		Correo_Empresa,
		Frec_Pago,
		Inicio_Ops
		)
	VALUES(
		'SRL4312321F2',
		'Strtup',
		149501491510,
		8564150844,
		'negocios@strtup.com',
		15,
		CONVERT(DATE, GETDATE())
	);

UPDATE Empresa SET Razon_Social = 'Soluciones de Software Appricot SA de CV' WHERE RFC_Empresa = 'APP4810391F2';
UPDATE Empresa SET Razon_Social = 'Edificios Montana SA de CV' WHERE RFC_Empresa = 'EDF4820493G5';
UPDATE Empresa SET Razon_Social = 'Productos Nacionales SA de CV' WHERE RFC_Empresa = 'PAN6870492H4';
UPDATE Empresa SET Razon_Social = 'Asesorias tecnologicas Strtup SA de CV' WHERE RFC_Empresa = 'SRL4312321F2';

--SELECT * FROM Empresa;

INSERT INTO Departamento (
	Nom_Dpto
)
VALUES (
	'Administracion'
);

INSERT INTO Departamento (
	Nom_Dpto
)
VALUES (
	'Recursos humanos'
);

INSERT INTO Departamento (
	Nom_Dpto
)
VALUES (
	'Innovacion'
);

INSERT INTO Departamento (
	Nom_Dpto
)
VALUES (
	'Produccion'
);

INSERT INTO Departamento (
	Nom_Dpto
)
VALUES (
	'Ventas'
);

INSERT INTO Departamento (
	Nom_Dpto
)
VALUES (
	'Investigacion'
);

--SELECT * FROM Departamento;

INSERT INTO Puesto (Nom_Puesto) VALUES ('Asistente');
INSERT INTO Puesto (Nom_Puesto) VALUES ('Jefe');
INSERT INTO Puesto (Nom_Puesto) VALUES ('Director');
INSERT INTO Puesto (Nom_Puesto) VALUES ('Contador Junior');
INSERT INTO Puesto (Nom_Puesto) VALUES ('Asociado');
INSERT INTO Puesto (Nom_Puesto) VALUES ('Asesor');

--SELECT * FROM Puesto;

INSERT INTO Domicilio (
	Calle,
	Numero,
	Colonia,
	Cod_Post,
	Ciudad,
	Estado
)
VALUES (
	'Morones Prieto',
	1589,
	'Centro',
	67000,
	'Guadalajara',
	'Jalisco'
);

INSERT INTO Domicilio (
	Calle,
	Numero,
	Colonia,
	Cod_Post,
	Ciudad,
	Estado
)
VALUES (
	'Morones Prieto',
	1596,
	'Centro',
	67000,
	'Guadalajara',
	'Jalisco'
);

INSERT INTO Domicilio (
	Calle,
	Numero,
	Colonia,
	Cod_Post,
	Ciudad,
	Estado
)
VALUES (
	'Mariano Garza',
	119,
	'Espinosa',
	67200,
	'Monterrey',
	'Nuevo Leon'
);

INSERT INTO Domicilio (
	Calle,
	Numero,
	Colonia,
	Cod_Post,
	Ciudad,
	Estado
)
VALUES (
	'Romo',
	189,
	'Independientes',
	68195,
	'Monterrey',
	'Nuevo Leon'
);

INSERT INTO Domicilio (
	Calle,
	Numero,
	Colonia,
	Cod_Post,
	Ciudad,
	Estado
)
VALUES (
	'Gaspar Fernandez',
	159,
	'Nopal',
	67130,
	'Guadalajara',
	'Jalisco'
);

--SELECT * FROM Domicilio;

INSERT INTO Banco (Nom_Banco) VALUES ('Banorte');
INSERT INTO Banco (Nom_Banco) VALUES ('Santander');
INSERT INTO Banco (Nom_Banco) VALUES ('BBVA');
INSERT INTO Banco (Nom_Banco) VALUES ('Citibanamex');
INSERT INTO Banco (Nom_Banco) VALUES ('Afirme');

--SELECT * FROM Banco;

EXEC RegistrarEmpleado
	@Nom_Empleado = 'Juan Ernesto',
	@Apellido_Pat = 'Gonzalez',
	@Apellido_Mat = 'Perez',
	@Fecha_Nac = '1990-11-9',
	@CURP_Empleado = 'GOPJ901109HASNRN02',
	@RFC_Empleado = 'GOPJ9011098L8',
	@NSS_Empleado = 12094329402,
	@Tel_Empleado = 8361120810,
	@Correo_Empleado = 'j.ernesto@gmail.com',
	@Banco_Empleado = 1,
	@Num_Cuenta = 89029381091,
	--Direccion
	@Calle = 'Amaranto',
	@Numero = 156,
	@Colonia = 'Mariano Escobedo',
	@Cod_Post = 67439,
	@Ciudad = 'Aguascalientes',
	@Estado = 'Aguascalientes';


-- Select tables

SELECT * FROM Empleado;
SELECT * FROM Usuario;

SELECT * FROM Domicilio;

SELECT * FROM Empresa;
SELECT * FROM Puesto;

SELECT * FROM Departamento;

SELECT * FROM [Employees Daily Salary];

SELECT * FROM Percepcion;
SELECT * FROM Deduccion;
SELECT * FROM Nomina;
SELECT * FROM Incidencia;

SELECT * FROM Empresa_Dpto;
SELECT * FROM Dpto_Puesto;
SELECT * FROM Empresa_Puesto;