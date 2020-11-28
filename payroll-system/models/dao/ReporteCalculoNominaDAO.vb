Imports System.Data.SqlClient
Public Class ReporteCalculoNominaDAO
    Inherits DBConnection
    Public Function Generar(ByVal idEmpleado As Integer, ByVal fecha As Date) As ReporteCalculoNomina
        Dim command As New SqlCommand("VerReporteCalculoNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@Fecha", fecha)

        Dim reporte As New ReporteCalculoNomina

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            reporte.IDNomina = reader.GetInt32(0)
            reporte.IDEmpleado = reader.GetInt32(1)
            reporte.NombreEmpleado = reader.GetString(2)
            reporte.Fecha = reader.GetDateTime(3)
            reporte.CantidadDeposito = reader.GetDouble(4)
            reporte.Banco = reader.GetString(5)
            reporte.CuentaBancaria = reader.GetInt64(6)
        End If

        reader.Close()
        connection.Close()

        Return reporte
    End Function
End Class
