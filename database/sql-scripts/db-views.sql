USE bsc_payroll_sys_db;
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Employees Position')
	DROP VIEW [Employees Position];
GO

CREATE VIEW [Employees Position] AS
	SELECT
		E.ID_Empleado AS 'ID Empleado',
		CONCAT(E.Nom_Empleado, ' ', E.Apellido_Pat, ' ', E.Apellido_Mat) AS 'Nombre Empleado',
		E.ID_Puesto AS 'ID Puesto',
		P.Nom_Puesto AS 'Nombre Puesto'
	FROM
		Empleado AS E
		INNER JOIN Puesto AS P ON E.ID_Puesto = P.ID_Puesto;
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Employees Department')
	DROP VIEW [Employees Department];
GO

CREATE VIEW [Employees Department] AS
	SELECT
		E.ID_Empleado AS 'ID Empleado',
		CONCAT(E.Nom_Empleado, ' ', E.Apellido_Pat, ' ', E.Apellido_Mat) AS 'Nombre Empleado',
		E.ID_Dpto AS 'ID Departamento',
		D.Nom_Dpto AS 'Nombre Departamento'
	FROM
		Empleado AS E
		INNER JOIN Departamento AS D ON E.ID_Dpto = D.ID_Dpto;
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Company Departments')
	DROP VIEW [Company Departments];
GO

CREATE VIEW [Company Departments] AS
	SELECT
		ED.ID_Emp_Dpto AS 'ID',
		E.RFC_Empresa AS 'RFC Empresa',
		E.Razon_Social AS 'Razon Social',
		E.Nom_Empresa AS 'Nombre Empresa',
		ED.ID_Dpto AS 'ID Departamento',
		D.Nom_Dpto AS 'Nombre Departamento',
		ED.Gerente_Dpto AS 'ID Gerente'
	FROM
		Empresa_Dpto AS ED
		INNER JOIN Empresa AS E ON ED.ID_Empresa = E.RFC_Empresa
		INNER JOIN Departamento AS D ON ED.ID_Dpto = D.ID_Dpto;
GO

-- Empleados con su sueldo diario

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Employees Daily Salary')
	DROP VIEW [Employees Daily Salary];
GO

CREATE VIEW [Employees Daily Salary] AS
	SELECT
		E.ID_Empleado AS 'ID',
		CONCAT(E.Nom_Empleado, ' ', E.Apellido_Pat, ' ', E.Apellido_Mat) AS 'Nombre Empleado',
		((SELECT Sueldo_Base
		FROM Empresa_Dpto AS ED
		WHERE ED.ID_Empresa = E.ID_Empresa
			AND ED.ID_Dpto = E.ID_Dpto) *
		(SELECT Porcent_sueldo
		FROM Dpto_Puesto AS DP
		WHERE DP.ID_Dpto = E.ID_Dpto
			AND DP.ID_Puesto = E.ID_Puesto)) AS 'Sueldo diario'
	FROM
		Empleado AS E
GO

-- Reporte nomina general

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Company Employees')
	DROP VIEW [Company Employees];
GO

CREATE VIEW [Company Employees] AS
	SELECT
		E.ID_Empresa AS 'ID Empresa',
		D.[Nombre Departamento] AS 'Departamento',
		P.[Nombre Puesto] AS 'Puesto',
		D.[Nombre Empleado] AS 'Nombre Empleado',
		E.Fecha_Contrato AS 'Fecha de ingreso',
		E.Fecha_Nac AS 'Fecha de nacimiento',
		(SELECT EDS.[Sueldo diario]
		FROM [Employees Daily Salary] AS EDS
		WHERE EDS.ID = E.ID_Empleado) AS 'Sueldo diario'
	FROM
		Empleado AS E
		INNER JOIN [Employees Department] AS D ON D.[ID Empleado] = E.ID_Empleado
		INNER JOIN [Employees Position] AS P ON P.[ID Empleado] = E.ID_Empleado;
GO

--SELECT * FROM [Company Employees];

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Departments Positions')
	DROP VIEW [Departments Positions];
GO

CREATE VIEW [Departments Positions] AS
	SELECT
		DP.ID_Dpto_Puesto AS 'ID',
		DP.ID_Dpto AS 'ID Departamento',
		D.Nom_Dpto AS 'Nombre Departamento',
		DP.ID_Puesto AS 'ID Puesto',
		P.Nom_Puesto AS 'Nombre Puesto'
	FROM
		Dpto_Puesto AS DP
		INNER JOIN Departamento AS D ON D.ID_Dpto = DP.ID_Dpto
		INNER JOIN Puesto AS P ON P.ID_Puesto = DP.ID_Puesto;
GO

-- Reporte Headcounter parte 1

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Headcounter1')
	DROP VIEW Headcounter1;
GO

CREATE VIEW Headcounter1 AS
	SELECT
		CD.[RFC Empresa] AS 'RFC Empresa',
		CD.[Nombre Empresa] AS 'Empresa',
		CD.[ID Departamento] AS 'ID Departamento',
		CD.[Nombre Departamento] AS 'Departamento',
		CD.[ID Gerente] AS 'Gerente',
		DP.[Nombre Puesto] AS 'Puesto',
		(SELECT COUNT(ID_Empleado)
		FROM Empleado AS E
		WHERE E.ID_Empresa = CD.[RFC Empresa]
			AND E.ID_Dpto = CD.[ID Departamento]
			AND E.ID_Puesto = DP.[ID Puesto]) AS 'Total del puesto'
	FROM
		[Company Departments] AS CD
		INNER JOIN [Departments Positions] AS DP ON DP.[ID Departamento] = CD.[ID Departamento];
		
GO

-- Reporte Headcounter parte 2

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Headcounter2')
	DROP VIEW Headcounter2;
GO

CREATE VIEW Headcounter2 AS
	SELECT
		CD.[RFC Empresa] AS 'RFC Empresa',
		CD.[Nombre Empresa] AS 'Empresa',
		CD.[ID Departamento] AS 'ID Departamento',
		CD.[Nombre Departamento] AS 'Departamento',
		CD.[ID Gerente] AS 'Gerente',
		(SELECT COUNT(ID_Empleado)
		FROM Empleado AS E
		WHERE E.ID_Empresa = CD.[RFC Empresa]
			AND E.ID_Dpto = CD.[ID Departamento]) AS 'Total del puesto',
		(SELECT TOP 1 N.Fecha_Gen
		FROM Nomina AS N
		INNER JOIN Empleado AS E ON E.ID_Empleado = N.ID_Empleado
		WHERE ID_Dpto = CD.[ID Departamento]
		ORDER BY N.Fecha_Gen DESC) AS 'Ultima Nomina' 
	FROM
		[Company Departments] AS CD;
		
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Payroll Receipt')
	DROP VIEW [Payroll Receipt];
GO

CREATE VIEW [Payroll Receipt] AS
	SELECT
		C.RFC_Empresa AS 'RFC de Empresa',
		C.Razon_Social AS 'Razon Social Empresa',
		C.Reg_Patronal AS 'Reg. Patronal Empresa',
		E.ID_Empleado AS 'Numero de Empleado',
		EDS.[Nombre Empleado] AS 'Nombre Empleado',
		E.NSS_Empleado AS 'NSS',
		E.RFC_Empleado AS 'RFC Empleado',
		E.CURP_Empleado AS 'CURP',
		E.Fecha_Contrato AS 'Fecha de contrato',
		E.ID_Dpto AS 'Departamento',
		P.Nom_Puesto AS 'Puesto',
		N.ID_Nomina AS 'ID Nomina',
		N.Fecha_Gen AS 'Fecha de pago',
		N.Inicio_Periodo AS 'Inicio de periodo',
		N.Fin_Periodo AS 'Fin de periodo',
		(DATEDIFF(DAY, N.Inicio_Periodo, N.Fin_Periodo)) AS 'Dias de periodo',
		EDS.[Sueldo diario] AS 'Sueldo Diario'
	FROM
		Empleado AS E
		INNER JOIN Empresa AS C ON C.RFC_Empresa = E.ID_Empresa
		INNER JOIN Nomina AS N ON N.ID_Empleado = E.ID_Empleado
		INNER JOIN Puesto AS P ON P.ID_Puesto = E.ID_Puesto
		INNER JOIN [Employees Daily Salary] AS EDS ON EDS.ID = E.ID_Empleado;
GO