USE bsc_payroll_sys_db;
GO

IF (EXISTS(SELECT name FROM sysobjects WHERE name = 'LASTPAYDATE' AND type = 'FN'))
	DROP FUNCTION LASTPAYDATE;
GO

CREATE FUNCTION LASTPAYDATE (
	@ID_Empleado	INT
)
RETURNS DATE
AS
	BEGIN
		DECLARE @LastPaydate DATE;

		SET @LastPaydate = (
			SELECT TOP 1
				Fecha_Gen
			FROM
				Nomina
			WHERE
				ID_Empleado = @ID_Empleado
			ORDER BY
				Fecha_Gen DESC
		);

		RETURN @LastPaydate;
	END
GO