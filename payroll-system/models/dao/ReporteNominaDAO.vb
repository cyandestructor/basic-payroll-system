Imports System.Data.SqlClient
Public Class ReporteNominaDAO
    Inherits DBConnection
    Public Function Generar(ByVal idEmpresa As String, ByVal idDpto As Integer, ByVal year As Integer, ByVal mes As Integer) As List(Of ReporteNominaRow)
        Dim command As New SqlCommand("GenReporteNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@Year", year)
        command.Parameters.AddWithValue("@Mes", mes)

        Dim reporte As New List(Of ReporteNominaRow)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim row As New ReporteNominaRow With {
                .Empresa = reader.GetString(0),
                .Departamento = reader.GetString(1),
                .Gerente = reader.GetString(2),
                .Year = reader.GetInt32(3),
                .Mes = reader.GetString(4),
                .SueldoBruto = reader.GetDouble(5),
                .SueldoNeto = reader.GetDouble(6),
                .ISR = reader.GetDouble(7),
                .IMSS = reader.GetDouble(8)
            }
            reporte.Add(row)
        End While

        reader.Close()
        connection.Close()

        Return reporte
    End Function
End Class
