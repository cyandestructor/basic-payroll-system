USE bsc_payroll_sys_db;
GO

-- Sample data

EXEC RegistrarEmpresa
	@RFC_Empresa = 'APP050523P85',
	@Nom_Empresa = 'Appricot',
	@Reg_Patronal = 'Y6012345103',
	@Razon_Social = 'Soluciones informátias Appricot S.A. de C.V.',
	@Tel_Empresa = 8122509904,
	@Correo_Empresa = 'empresa@appricot.com',
	@Frec_Pago = 15,
	@Inicio_Ops = '2005-05-23',
	--Direccion
	@Calle = 'Zaragoza',
	@Numero = 1589,
	@Colonia = 'Centro',
	@Cod_Post = 67000,
	@Ciudad = 'Monterrey',
	@Estado = 'Nuevo León'

EXEC RegistrarEmpresa
	@RFC_Empresa = 'MAG060715P85',
	@Nom_Empresa = 'Magnesium',
	@Reg_Patronal = 'Y5012446143',
	@Razon_Social = 'Quimicos Industriales Magnesium S.A. de C.V.',
	@Tel_Empresa = 8122509904,
	@Correo_Empresa = 'empresa@magnesium.com',
	@Frec_Pago = 15,
	@Inicio_Ops = '2006-07-15',
	--Direccion
	@Calle = 'Eugenio Garza Sada',
	@Numero = 1729,
	@Colonia = 'Contry',
	@Cod_Post = 68100,
	@Ciudad = 'Monterrey',
	@Estado = 'Nuevo León'

EXEC RegistrarEmpresa
	@RFC_Empresa = 'SPR190407P85',
	@Nom_Empresa = 'SPrint',
	@Reg_Patronal = 'Y4514456243',
	@Razon_Social = 'Impresiones Graficas Sprint S.A. de C.V.',
	@Tel_Empresa = 8122509904,
	@Correo_Empresa = 'empresa@sprint.com',
	@Frec_Pago = 7,
	@Inicio_Ops = '2019-04-07',
	--Direccion
	@Calle = 'Revolución',
	@Numero = 1529,
	@Colonia = 'Contry',
	@Cod_Post = 68100,
	@Ciudad = 'Monterrey',
	@Estado = 'Nuevo León'

--SELECT * FROM Empresa;

EXEC RegistrarDepartamento @Nom_Dpto = 'Administración';
EXEC RegistrarDepartamento @Nom_Dpto = 'Recursos humanos';
EXEC RegistrarDepartamento @Nom_Dpto = 'Innovación';
EXEC RegistrarDepartamento @Nom_Dpto = 'Producción';
EXEC RegistrarDepartamento @Nom_Dpto = 'Ventas';
EXEC RegistrarDepartamento @Nom_Dpto = 'Investigación';

--SELECT * FROM Departamento;

EXEC RegistrarPuesto @Nom_Puesto = 'Asistente';
EXEC RegistrarPuesto @Nom_Puesto = 'Jefe';
EXEC RegistrarPuesto @Nom_Puesto = 'Director';
EXEC RegistrarPuesto @Nom_Puesto = 'Contador Junior';
EXEC RegistrarPuesto @Nom_Puesto = 'Asociado';
EXEC RegistrarPuesto @Nom_Puesto = 'Asesor';

--SELECT * FROM Puesto;

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

EXEC RegistrarEmpleado
	@Nom_Empleado = 'Mariel',
	@Apellido_Pat = 'Espinos',
	@Apellido_Mat = 'Ramos',
	@Fecha_Nac = '1995-12-10',
	@CURP_Empleado = 'MAER951210MNLNRN02',
	@RFC_Empleado = 'MAER9512108L8',
	@NSS_Empleado = 45064319302,
	@Tel_Empleado = 8183611208,
	@Correo_Empleado = 'mariel.ramos@gmail.com',
	@Banco_Empleado = 1,
	@Num_Cuenta = 82032371391,
	--Direccion
	@Calle = 'Macapa',
	@Numero = 154,
	@Colonia = 'Esperanza',
	@Cod_Post = 68459,
	@Ciudad = 'Guadalupe',
	@Estado = 'Nuevo León';

EXEC RegistrarEmpleado
	@Nom_Empleado = 'Enrique',
	@Apellido_Pat = 'Campos',
	@Apellido_Mat = 'Torres',
	@Fecha_Nac = '1997-10-31',
	@CURP_Empleado = 'ENCT971031HNLNRN02',
	@RFC_Empleado = 'ENCT9710318F8',
	@NSS_Empleado = 65234393670,
	@Tel_Empleado = 8122511208,
	@Correo_Empleado = 'ecampostorres@hotmail.com',
	@Banco_Empleado = 1,
	@Num_Cuenta = 92022351421,
	--Direccion
	@Calle = 'Ensenada',
	@Numero = 191,
	@Colonia = 'Bajas',
	@Cod_Post = 69659,
	@Ciudad = 'Escobedo',
	@Estado = 'Nuevo León';

EXEC RegistrarEmpleado
	@Nom_Empleado = 'Margarita',
	@Apellido_Pat = 'Mieles',
	@Apellido_Mat = 'Manzano',
	@Fecha_Nac = '2000-05-05',
	@CURP_Empleado = 'MAMM009505MNLNRN02',
	@RFC_Empleado = 'MAMM0005058G8',
	@NSS_Empleado = 61274093870,
	@Tel_Empleado = 8152541200,
	@Correo_Empleado = 'margarita-manz@outlook.com.mx',
	@Banco_Empleado = 1,
	@Num_Cuenta = 71228371921,
	--Direccion
	@Calle = 'República',
	@Numero = 200,
	@Colonia = 'Mexicanos',
	@Cod_Post = 65649,
	@Ciudad = 'Apodaca',
	@Estado = 'Nuevo León';

EXEC RegistrarEmpleado
	@Nom_Empleado = 'Lizeth',
	@Apellido_Pat = 'Duarte',
	@Apellido_Mat = 'Valdéz',
	@Fecha_Nac = '2000-12-10',
	@CURP_Empleado = 'LIDV001210MNLNDN02',
	@RFC_Empleado = 'LIDV0012108B8',
	@NSS_Empleado = 69284692871,
	@Tel_Empleado = 8122601401,
	@Correo_Empleado = 'liz101200@outlook.com.mx',
	@Banco_Empleado = 1,
	@Num_Cuenta = 71328272931,
	--Direccion
	@Calle = 'Mozart',
	@Numero = 156,
	@Colonia = 'Robles',
	@Cod_Post = 68629,
	@Ciudad = 'Apodaca',
	@Estado = 'Nuevo León';

-- Agregar departamentos a empresas
EXEC AgregarDptoEmpresa
	@ID_Empresa = 'APP050523P85',
	@ID_Dpto = 1,
	@Sueldo_Base = 500,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'APP050523P85',
	@ID_Dpto = 5,
	@Sueldo_Base = 400,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'APP050523P85',
	@ID_Dpto = 2,
	@Sueldo_Base = 450,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'MAG060715P85',
	@ID_Dpto = 1,
	@Sueldo_Base = 550,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'MAG060715P85',
	@ID_Dpto = 3,
	@Sueldo_Base = 550,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'MAG060715P85',
	@ID_Dpto = 4,
	@Sueldo_Base = 450,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'SPR190407P85',
	@ID_Dpto = 1,
	@Sueldo_Base = 450,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'SPR190407P85',
	@ID_Dpto = 2,
	@Sueldo_Base = 450,
	@Mode = 1

EXEC AgregarDptoEmpresa
	@ID_Empresa = 'SPR190407P85',
	@ID_Dpto = 4,
	@Sueldo_Base = 450,
	@Mode = 1

-- Agregar puesto a empresa

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'APP050523P85',
	@ID_Puesto = 1,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'APP050523P85',
	@ID_Puesto = 2,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'APP050523P85',
	@ID_Puesto = 3,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'MAG060715P85',
	@ID_Puesto = 1,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'MAG060715P85',
	@ID_Puesto = 5,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'MAG060715P85',
	@ID_Puesto = 6,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'SPR190407P85',
	@ID_Puesto = 1,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'SPR190407P85',
	@ID_Puesto = 2,
	@Mode = 1;

EXEC AgregarPuestoEmpresa
	@ID_Empresa = 'SPR190407P85',
	@ID_Puesto = 3,
	@Mode = 1;

-- Agregar puestos a departamentos

EXEC AgregarPuestoDpto
	@ID_Dpto = 5,
	@ID_Puesto = 1,
	@Porcent_Sueldo = 1.4,
	@Mode = 1;

EXEC AgregarPuestoDpto
	@ID_Dpto = 1,
	@ID_Puesto = 1,
	@Porcent_Sueldo = 1.0,
	@Mode = 1;

EXEC AgregarPuestoDpto
	@ID_Dpto = 2,
	@ID_Puesto = 2,
	@Porcent_Sueldo = 1.0,
	@Mode = 1;

EXEC AgregarPuestoDpto
	@ID_Dpto = 3,
	@ID_Puesto = 1,
	@Porcent_Sueldo = 1.25,
	@Mode = 1;

EXEC AgregarPuestoDpto
	@ID_Dpto = 4,
	@ID_Puesto = 2,
	@Porcent_Sueldo = 1.2,
	@Mode = 1;

EXEC AgregarPuestoDpto
	@ID_Dpto = 5,
	@ID_Puesto = 3,
	@Porcent_Sueldo = 1.3,
	@Mode = 1;

EXEC AgregarPuestoDpto
	@ID_Dpto = 1,
	@ID_Puesto = 3,
	@Porcent_Sueldo = 1.3,
	@Mode = 1;

-- Agregar empresa a empleado

EXEC AgregarEmpresaEmpleado
	@ID_Empleado = 1000,
	@RFC_Empresa = 'APP050523P85',
	@Fecha_Contrato = '2006-06-12';

EXEC AgregarEmpresaEmpleado
	@ID_Empleado = 1001,
	@RFC_Empresa = 'APP050523P85',
	@Fecha_Contrato = '2006-06-12';

EXEC AgregarEmpresaEmpleado
	@ID_Empleado = 1002,
	@RFC_Empresa = 'MAG060715P85',
	@Fecha_Contrato = '2006-06-12';

EXEC AgregarEmpresaEmpleado
	@ID_Empleado = 1003,
	@RFC_Empresa = 'MAG060715P85',
	@Fecha_Contrato = '2006-06-12';

EXEC AgregarEmpresaEmpleado
	@ID_Empleado = 1004,
	@RFC_Empresa = 'SPR190407P85',
	@Fecha_Contrato = '2006-06-12';

-- Agregar departamento y puesto a empleados

EXEC AsignarDptoEmpleado
	@ID_Empleado = 1000,
	@ID_Dpto = 5;

EXEC AsignarDptoEmpleado
	@ID_Empleado = 1001,
	@ID_Dpto = 5;

EXEC AsignarDptoEmpleado
	@ID_Empleado = 1002,
	@ID_Dpto = 3;

EXEC AsignarDptoEmpleado
	@ID_Empleado = 1003,
	@ID_Dpto = 1;

EXEC AsignarDptoEmpleado
	@ID_Empleado = 1004,
	@ID_Dpto = 4;

-- Asignar puesto a empleados

EXEC AsignarPuestoEmpleado
	@ID_Empleado = 1000,
	@ID_Puesto = 1;

EXEC AsignarPuestoEmpleado
	@ID_Empleado = 1001,
	@ID_Puesto = 3;

EXEC AsignarPuestoEmpleado
	@ID_Empleado = 1002,
	@ID_Puesto = 1;

EXEC AsignarPuestoEmpleado
	@ID_Empleado = 1003,
	@ID_Puesto = 1;

EXEC AsignarPuestoEmpleado
	@ID_Empleado = 1004,
	@ID_Puesto = 2;

-- Asignar gerente a empresa

EXEC AsignarGerenteEmpresa
	@RFC_Empresa = 'APP050523P85',
	@ID_Gerente = 1000;

EXEC AsignarGerenteEmpresa
	@RFC_Empresa = 'MAG060715P85',
	@ID_Gerente = 1003;

EXEC AsignarGerenteEmpresa
	@RFC_Empresa = 'SPR190407P85',
	@ID_Gerente = 1004;

-- Asignar gerente a departamento

EXEC AsignarGerenteDpto
	@ID_Empresa = 'APP050523P85',
	@ID_Dpto = 5,
	@ID_Gerente = 1001,
	@Cant_Bono = 100;

EXEC AsignarGerenteDpto
	@ID_Empresa = 'MAG060715P85',
	@ID_Dpto = 3,
	@ID_Gerente = 1002,
	@Cant_Bono = 300;

EXEC AsignarGerenteDpto
	@ID_Empresa = 'SPR190407P85',
	@ID_Dpto = 4,
	@ID_Gerente = 1004,
	@Cant_Bono = 200;

-- Generar percepciones/deducciones

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de puntualidad',
		@Cant_Fija = 300,
		@Cant_Porcent = 0,
		@ID_Empleado = 1000;

EXEC GenerarPercepcion
		@Desc_Percep = 'Prima dominical',
		@Cant_Fija = 300,
		@Cant_Porcent = 1,
		@ID_Empleado = 1000;

EXEC GenerarPercepcion
		@Desc_Percep = 'Empleado del mes',
		@Cant_Fija = 500,
		@Cant_Porcent = 0,
		@ID_Empleado = 1000;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de antiguedad',
		@Cant_Fija = 300,
		@Cant_Porcent = 0,
		@ID_Empleado = 1000;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de puntualidad',
		@Cant_Fija = 300,
		@Cant_Porcent = 0,
		@ID_Empleado = 1001;

EXEC GenerarPercepcion
		@Desc_Percep = 'Prima dominical',
		@Cant_Fija = 300,
		@Cant_Porcent = 1,
		@ID_Empleado = 1001;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de antiguedad',
		@Cant_Fija = 200,
		@Cant_Porcent = 0,
		@ID_Empleado = 1001;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de puntualidad',
		@Cant_Fija = 300,
		@Cant_Porcent = 0,
		@ID_Empleado = 1002;

EXEC GenerarPercepcion
		@Desc_Percep = 'Prima dominical',
		@Cant_Fija = 300,
		@Cant_Porcent = 1,
		@ID_Empleado = 1002;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de antiguedad',
		@Cant_Fija = 200,
		@Cant_Porcent = 0,
		@ID_Empleado = 1002;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de puntualidad',
		@Cant_Fija = 300,
		@Cant_Porcent = 0,
		@ID_Empleado = 1003;

EXEC GenerarPercepcion
		@Desc_Percep = 'Prima dominical',
		@Cant_Fija = 300,
		@Cant_Porcent = 1,
		@ID_Empleado = 1003;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de antiguedad',
		@Cant_Fija = 150,
		@Cant_Porcent = 0,
		@ID_Empleado = 1003;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de puntualidad',
		@Cant_Fija = 300,
		@Cant_Porcent = 0,
		@ID_Empleado = 1004;

EXEC GenerarPercepcion
		@Desc_Percep = 'Prima dominical',
		@Cant_Fija = 300,
		@Cant_Porcent = 1,
		@ID_Empleado = 1004;

EXEC GenerarPercepcion
		@Desc_Percep = 'Bono de antiguedad',
		@Cant_Fija = 200,
		@Cant_Porcent = 0,
		@ID_Empleado = 1004;

-- Deducciones

EXEC GenerarDeduccion
		@Desc_Deducc = 'INFONAVIT',
		@Cant_Fija = 1235.56,
		@Cant_Porcent = 0,
		@ID_Empleado = 1000;

EXEC GenerarDeduccion
		@Desc_Deducc = 'Donacion',
		@Cant_Fija = 0,
		@Cant_Porcent = 0.30,
		@ID_Empleado = 1000;

EXEC GenerarDeduccion
		@Desc_Deducc = 'INFONAVIT',
		@Cant_Fija = 1135,
		@Cant_Porcent = 0,
		@ID_Empleado = 1001;

EXEC GenerarDeduccion
		@Desc_Deducc = 'INFONAVIT',
		@Cant_Fija = 1765.56,
		@Cant_Porcent = 0,
		@ID_Empleado = 1002;

EXEC GenerarDeduccion
		@Desc_Deducc = 'INFONAVIT',
		@Cant_Fija = 1335.96,
		@Cant_Porcent = 0,
		@ID_Empleado = 1003;

EXEC GenerarDeduccion
		@Desc_Deducc = 'INFONAVIT',
		@Cant_Fija = 1435.50,
		@Cant_Porcent = 0,
		@ID_Empleado = 1004;

EXEC GenerarDeduccion
		@Desc_Deducc = 'ISR',
		@Cant_Fija = 100,
		@Cant_Porcent = 0,
		@ID_Empleado = 1000;

EXEC GenerarDeduccion
		@Desc_Deducc = 'ISR',
		@Cant_Fija = 110,
		@Cant_Porcent = 0,
		@ID_Empleado = 1000;

EXEC GenerarDeduccion
		@Desc_Deducc = 'ISR',
		@Cant_Fija = 110,
		@Cant_Porcent = 0,
		@ID_Empleado = 1001;

EXEC GenerarDeduccion
		@Desc_Deducc = 'IMSS',
		@Cant_Fija = 150,
		@Cant_Porcent = 0,
		@ID_Empleado = 1000;

-- Generar nomina empleados

DECLARE @EndDate DATE = DATEADD(DAY, 15, '2020-11-23');

EXEC GenerarNomina
		@ID_Empleado = 1000,
		@Inicio_Periodo = '2020-11-23',
		@Fin_Periodo = @EndDate;

EXEC GenerarNomina
		@ID_Empleado = 1001,
		@Inicio_Periodo = '2020-11-23',
		@Fin_Periodo = @EndDate;

EXEC GenerarNomina
		@ID_Empleado = 1002,
		@Inicio_Periodo = '2020-11-23',
		@Fin_Periodo = @EndDate;

EXEC GenerarNomina
		@ID_Empleado = 1003,
		@Inicio_Periodo = '2020-11-23',
		@Fin_Periodo = @EndDate;

EXEC GenerarNomina
		@ID_Empleado = 1004,
		@Inicio_Periodo = '2020-11-23',
		@Fin_Periodo = @EndDate;

-- Select tables
SELECT * FROM Empleado;

SELECT * FROM Usuario;
SELECT * FROM Banco;

SELECT * FROM Domicilio;

SELECT * FROM Empresa;
SELECT * FROM Departamento;
SELECT * FROM Puesto;


SELECT * FROM [Company Employees];
SELECT * FROM [Company Departments];
SELECT * FROM [Departments Positions];
SELECT * FROM Headcounter2;
SELECT * FROM [Payroll Receipt];

SELECT * FROM [Employees Daily Salary];

SELECT * FROM Percepcion;
SELECT * FROM Deduccion;
SELECT * FROM Nomina;
SELECT * FROM Incidencia;

SELECT * FROM Empresa_Dpto;
SELECT * FROM Dpto_Puesto;
SELECT * FROM Empresa_Puesto;

EXEC VerHeadcounter1
	@ID_Empresa = 'APP050523P85',
	@ID_Dpto = 5,
	@Year = 2006,
	@Mes = 10;

EXEC VerHeadcounter2
	@ID_Empresa = 'APP050523P85',
	@ID_Dpto = 5,
	@Year = 2006,
	@Mes = 10;

EXEC VerReporteCalculoNomina
	@ID_Empresa = 'APP050523P85',
	@Fecha = '2020-11-26';