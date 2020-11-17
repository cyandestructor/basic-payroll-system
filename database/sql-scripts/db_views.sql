USE bsc_payroll_sys_db;
GO

-- Reporte nomina general

IF EXISTS(SELECT * FROM sys.all_views WHERE name = 'Company Employees')
	DROP VIEW [Company Employees];
GO

CREATE VIEW [Company Employees] AS
	SELECT
		D.Nom_Dpto AS 'Departamento',
		P.Nom_Puesto  AS 'Puesto',
		CONCAT(E.Nom_Empleado, ' ', E.Apellido_Pat, ' ', E.Apellido_Pat) AS 'Empleado',
		E.Fecha_Contrato AS 'Fecha de Contrato',
		E.Fecha_Nac AS 'Fecha de Nacimiento',
		(ED.Sueldo_Base * DP.Porcent_Sueldo) AS 'Sueldo Diario'
	FROM
		Empleado AS E
		INNER JOIN Departamento AS D ON E.ID_Dpto = D.ID_Dpto
		INNER JOIN Puesto AS P ON E.ID_Puesto = P.ID_Puesto
		INNER JOIN Empresa_Dpto AS ED ON ED.ID_Dpto = D.ID_Dpto
		INNER JOIN Dpto_Puesto AS DP ON DP.ID_Dpto = D.ID_Dpto;
GO

--SELECT * FROM [Company Employees];

-- Reporte Headcounter parte 1

IF EXISTS(SELECT * FROM sys.all_views WHERE name = 'Employees Position')
	DROP VIEW [Employees Position];
GO

CREATE VIEW [Employees Position] AS
	SELECT
		Empresa.Nom_Empresa AS 'Empresa',
		D.Nom_Dpto AS 'Departamento',
		CONCAT(E.Nom_Empleado, ' ', E.Apellido_Pat, ' ', E.Apellido_Pat) AS 'Gerente',
		P.Nom_Puesto AS 'Puesto'
	FROM
		Empresa_Dpto AS ED
		INNER JOIN Empresa ON ED.ID_Empresa = Empresa.RFC_Empresa
		INNER JOIN Departamento AS D ON D.ID_Dpto = ED.ID_Dpto
		INNER JOIN Dpto_Puesto AS DP ON DP.ID_Dpto = D.ID_Dpto
		INNER JOIN Puesto AS P ON P.ID_Puesto = DP.ID_Puesto
		INNER JOIN Empleado AS E ON E.ID_Empleado = D.Gerente_Dpto;
GO

SELECT * FROM [Employees Position];