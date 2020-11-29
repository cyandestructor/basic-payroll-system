USE bsc_payroll_sys_db;
GO

CREATE TRIGGER TR_Empleado_Insert
ON Empleado
AFTER INSERT
AS
	INSERT INTO Usuario (ID_Usuario, Contrasena, Nivel_Usuario)
	SELECT ID_Empleado, CONVERT(VARCHAR(20),ID_Empleado), 1 FROM inserted;

	UPDATE Empleado
		SET
			Empleado.ID_Usuario = inserted.ID_Empleado
		FROM
			Empleado
			INNER JOIN inserted ON Empleado.ID_Empleado = inserted.ID_Empleado
		WHERE
			Empleado.ID_Empleado = inserted.ID_Empleado;
GO

IF (EXISTS(SELECT name FROM sysobjects WHERE type = 'TR' AND name = 'TR_Nomina_After_Insert'))
	DROP TRIGGER TR_Nomina_After_Insert;
GO

CREATE TRIGGER TR_Nomina_After_Insert
ON Nomina
AFTER INSERT
AS
	UPDATE Percepcion
		SET
			Percepcion.ID_Nomina = inserted.ID_Nomina
		FROM
			Percepcion
			INNER JOIN inserted ON Percepcion.ID_Empleado = inserted.ID_Empleado
		WHERE
			Percepcion.ID_Empleado = inserted.ID_Empleado
			AND (Percepcion.Fecha_Percep BETWEEN inserted.Inicio_Periodo AND inserted.Fin_Periodo)
			AND Percepcion.ID_Nomina IS NULL;

	UPDATE Deduccion
		SET
			Deduccion.ID_Nomina = inserted.ID_Nomina
		FROM
			Deduccion
			INNER JOIN inserted ON Deduccion.ID_Empleado = inserted.ID_Empleado
		WHERE
			Deduccion.ID_Empleado = inserted.ID_Empleado
			AND (Deduccion.Fecha_Deducc BETWEEN inserted.Inicio_Periodo AND inserted.Fin_Periodo)
			AND Deduccion.ID_Nomina IS NULL;
GO