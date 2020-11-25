USE bsc_payroll_sys_db;
GO

SELECT * FROM sysobjects WHERE type = 'F'

ALTER TABLE Empresa
	DROP CONSTRAINT FK_Gerente_Empresa,
		CONSTRAINT FK_Domicilio_Fiscal_Empresa;

ALTER TABLE Empleado
	DROP CONSTRAINT FK_Domicilio_Empleado,
		CONSTRAINT FK_Banco_Empleado,
		CONSTRAINT FK_Empresa_Empleado,
		CONSTRAINT FK_Departamento_Empleado,
		CONSTRAINT FK_Puesto_Empleado,
		CONSTRAINT FK_Usuario_Empleado;

ALTER TABLE Percepcion
	DROP CONSTRAINT FK_Empleado_Percepcion;

ALTER TABLE Incidencia
	DROP CONSTRAINT FK_Solicitante_Incidencia,
		CONSTRAINT FK_Gerente_Incidencia;

ALTER TABLE Deduccion
	DROP CONSTRAINT FK_Empleado_Deduccion;

ALTER TABLE Nomina
	DROP CONSTRAINT FK_Empleado_Nomina;

DROP TABLE Empresa_Dpto;

DROP TABLE Dpto_Puesto;

DROP TABLE Empresa_Puesto;

TRUNCATE TABLE Empresa;
TRUNCATE TABLE Empleado;
TRUNCATE TABLE Usuario;
TRUNCATE TABLE Departamento;
TRUNCATE TABLE Puesto;
TRUNCATE TABLE Domicilio;