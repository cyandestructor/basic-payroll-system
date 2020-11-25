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