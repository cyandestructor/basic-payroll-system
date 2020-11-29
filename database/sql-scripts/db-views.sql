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
		ED.ID_Empresa,
		ED.ID_Dpto,
		ED.Gerente_Dpto,
		DP.ID_Puesto,
		COALESCE((SELECT Count(0)
		FROM Empleado
		GROUP BY ID_Puesto, ID_Empresa, ID_Dpto
		HAVING ID_Puesto = DP.ID_Puesto
			AND ID_Empresa = ED.ID_Empresa
			AND ID_Dpto = DP.ID_Dpto), 0) AS Num_Empleados
	FROM
		Empresa_Dpto AS ED
		INNER JOIN Dpto_Puesto AS DP ON DP.ID_Dpto = ED.ID_Dpto;
GO

-- Reporte Headcounter parte 2

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Headcounter2')
	DROP VIEW Headcounter2;
GO

CREATE VIEW Headcounter2 AS
	SELECT
		ED.ID_Empresa,
		ED.ID_Dpto,
		ED.Gerente_Dpto,
		COALESCE((SELECT Count(0)
		FROM Empleado
		GROUP BY ID_Empresa, ID_Dpto
		HAVING ID_Empresa = ED.ID_Empresa
			AND ID_Dpto = ED.ID_Dpto), 0) AS Num_Empleados
	FROM
		Empresa_Dpto AS ED;
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Percepciones y Deducciones')
	DROP VIEW [Percepciones y Deducciones];
GO

CREATE VIEW [Percepciones y Deducciones] AS
	SELECT
		CONCAT(ID_Percep, 'P') AS ID,
		Desc_Percep AS Descripcion,
		Cant_Fija AS CantidadFija,
		Cant_Porcent AS CantidadPorcent,
		ID_Empleado AS Empleado,
		ID_Nomina AS Nomina,
		Fecha_Percep AS Fecha
	FROM
		Percepcion
	UNION
	SELECT
		CONCAT(ID_Deducc, 'D') AS ID,
		Desc_Deducc AS Descripcion,
		Cant_Fija AS CantidadFija,
		Cant_Porcent AS CantidadPorcent,
		ID_Empleado AS Empleado,
		ID_Nomina AS Nomina,
		Fecha_Deducc AS Fecha
	FROM
		Deduccion
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Total ISR')
	DROP VIEW [Total ISR];
GO

CREATE VIEW [Total ISR] AS
	SELECT
		E.ID_Empleado AS Empleado,
		YEAR(PD.Fecha) AS Año,
		MONTH(PD.Fecha) AS Mes,
		SUM(PD.CantidadFija) AS Total
	FROM
		[Percepciones y Deducciones] AS PD
		INNER JOIN Empleado AS E ON E.ID_Empleado = PD.Empleado
	WHERE
		PD.Descripcion LIKE '%ISR%'
	GROUP BY
		E.ID_Empleado,
		YEAR(PD.Fecha),
		MONTH(PD.Fecha)

GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Total IMSS')
	DROP VIEW [Total IMSS];
GO

CREATE VIEW [Total IMSS] AS
	SELECT
		E.ID_Empleado AS Empleado,
		YEAR(PD.Fecha) AS Año,
		MONTH(PD.Fecha) AS Mes,
		SUM(PD.CantidadFija) AS Total
	FROM
		[Percepciones y Deducciones] AS PD
		INNER JOIN Empleado AS E ON E.ID_Empleado = PD.Empleado
	WHERE
		PD.Descripcion LIKE '%IMSS%'
	GROUP BY
		E.ID_Empleado,
		YEAR(PD.Fecha),
		MONTH(PD.Fecha)

GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Total ISR Empresa')
	DROP VIEW [Total ISR Empresa];
GO

CREATE VIEW [Total ISR Empresa] AS
	SELECT
		E.ID_Empresa,
		E.ID_Dpto,
		ISR.Año,
		ISR.Mes,
		SUM(ISR.Total) AS Total
	FROM
		[Total ISR] AS ISR
		INNER JOIN Empleado AS E ON E.ID_Empleado = ISR.Empleado
	GROUP BY
		E.ID_Empresa,
		E.ID_Dpto,
		Año,
		Mes;
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Total IMSS Empresa')
	DROP VIEW [Total IMSS Empresa];
GO

CREATE VIEW [Total IMSS Empresa] AS
	SELECT
		E.ID_Empresa,
		E.ID_Dpto,
		IMSS.Año,
		IMSS.Mes,
		SUM(IMSS.Total) AS Total
	FROM
		[Total IMSS] AS IMSS
		INNER JOIN Empleado AS E ON E.ID_Empleado = IMSS.Empleado
	GROUP BY
		E.ID_Empresa,
		E.ID_Dpto,
		Año,
		Mes;
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Sueldos Empresa')
	DROP VIEW [Sueldos Empresa];
GO

CREATE VIEW [Sueldos Empresa] AS
	SELECT
		E.ID_Empresa AS Empresa,
		E.ID_Dpto AS Dpto,
		YEAR(N.Fecha_Gen) AS Año,
		MONTH(N.Fecha_Gen) AS Mes,
		SUM(N.Sueldo_Bruto) AS Sueldo_Bruto,
		SUM(N.Sueldo_Neto) AS Sueldo_Neto
	FROM
		Nomina AS N
		INNER JOIN Empleado AS E ON E.ID_Empleado = N.ID_Empleado
	GROUP BY
		E.ID_Empresa, E.ID_Dpto, YEAR(N.Fecha_Gen), MONTH(N.Fecha_Gen)
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Reporte Nomina')
	DROP VIEW [Reporte Nomina];
GO

CREATE VIEW [Reporte Nomina] AS
	SELECT
		ED.ID_Empresa AS Empresa,
		ED.ID_Dpto AS Departamento,
		ED.Gerente_Dpto AS Gerente,
		SE.Año AS Año,
		SE.Mes AS Mes,
		COALESCE(SE.Sueldo_Bruto, 0) AS Sueldo_Bruto,
		COALESCE(SE.Sueldo_Neto, 0) AS Sueldo_Neto,
		COALESCE(ISR.Total, 0) AS ISR,
		COALESCE(IMSS.Total, 0) AS IMSS
	FROM
		Empresa_Dpto AS ED
		INNER JOIN [Sueldos Empresa] AS SE ON SE.Empresa = ED.ID_Empresa AND SE.Dpto = ED.ID_Dpto
		LEFT JOIN [Total ISR Empresa] AS ISR ON ISR.ID_Empresa = ED.ID_Empresa
			AND ISR.ID_Dpto = ED.ID_Dpto
			AND SE.Año = ISR.Año
			AND SE.Mes = ISR.Mes
		LEFT JOIN [Total IMSS Empresa] AS IMSS ON IMSS.ID_Empresa = ED.ID_Empresa
			AND IMSS.ID_Dpto = ED.ID_Dpto
			AND SE.Año = IMSS.Año
			AND SE.Mes = IMSS.Mes
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Resumen Pagos')
	DROP VIEW [Resumen Pagos];
GO

CREATE VIEW [Resumen Pagos] AS
	SELECT
		E.ID_Empleado AS ID,
		E.RFC_Empleado AS RFC,
		E.NSS_Empleado AS NSS,
		YEAR(N.Fecha_Gen) AS AÑO,
		DATENAME(MONTH, N.Fecha_Gen) AS MES,
		COALESCE(SUM(ISR.Total), 0) AS ISR,
		COALESCE(SUM(IMSS.Total), 0) AS IMSS,
		SUM(N.Sueldo_Bruto) AS SUELDO,
		SUM(N.Sueldo_Neto) AS SUELDO_NETO
	FROM
		Nomina AS N
		INNER JOIN Empleado AS E ON E.ID_Empleado = N.ID_Empleado
		LEFT JOIN [Total ISR] AS ISR ON ISR.Empleado = E.ID_Empleado AND ISR.Año = YEAR(N.Fecha_Gen) AND ISR.Mes = MONTH(N.Fecha_Gen)
		LEFT JOIN [Total IMSS] AS IMSS ON IMSS.Empleado = E.ID_Empleado AND IMSS.Año = YEAR(N.Fecha_Gen) AND IMSS.Mes = MONTH(N.Fecha_Gen)
	GROUP BY
		E.ID_Empleado, E.RFC_Empleado, E.NSS_Empleado, YEAR(N.Fecha_Gen), DATENAME(MONTH, N.Fecha_Gen)
		
GO

IF EXISTS(SELECT name FROM sys.all_views WHERE name = 'Reporte Calculo Nomina')
	DROP VIEW [Reporte Calculo Nomina];
GO

CREATE VIEW [Reporte Calculo Nomina] AS
	SELECT
		E.ID_Empresa AS 'Empresa',
		N.ID_Nomina AS 'ID Nomina',
		E.ID_Empleado AS 'ID del Empleado',
		CONCAT(E.Nom_Empleado, ' ', E.Apellido_Pat, ' ', E.Apellido_Mat) AS 'Nombre del Empleado',
		CONVERT(DATE, N.Fecha_Gen) AS 'Fecha',
		N.Sueldo_Neto AS 'Cantidad a depositar',
		B.Nom_Banco AS 'Banco',
		E.Num_Cuenta AS 'Num. Cuenta'
	FROM
		Nomina AS N
		INNER JOIN Empleado AS E ON E.ID_Empleado = N.ID_Empleado
		INNER JOIN Banco AS B ON B.ID_Banco = E.Banco_Empleado;
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
		CONVERT(DATE, N.Fecha_Gen) AS 'Fecha de pago',
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