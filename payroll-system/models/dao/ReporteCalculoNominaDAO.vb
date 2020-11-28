Imports System.Data.SqlClient
Public Class ReporteCalculoNominaDAO
    Inherits DBConnection
    Public Function Generar(ByVal idEmpresa As String, ByVal fecha As Date) As List(Of ReporteCalculoNomina)
        Dim command As New SqlCommand("VerReporteCalculoNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@Fecha", fecha)

        Dim reporte As New List(Of ReporteCalculoNomina)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim row As New ReporteCalculoNomina With {
                .IDNomina = reader.GetInt32(0),
                .IDEmpleado = reader.GetInt32(1),
                .NombreEmpleado = reader.GetString(2),
                .Fecha = reader.GetDateTime(3),
                .CantidadDeposito = reader.GetDouble(4),
                .Banco = reader.GetString(5),
                .CuentaBancaria = reader.GetInt64(6)
            }
            reporte.Add(row)
        End While

        reader.Close()
        connection.Close()

        Return reporte
    End Function
End Class
