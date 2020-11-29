Imports System.Data.SqlClient
Public Class ReporteNominaGeneralDAO
    Inherits DBConnection
    Public Function Generar(ByVal idEmpresa As String, Optional ByVal year As Integer = -1, Optional ByVal mes As Integer = -1) As List(Of ReporteNominaGeneral)
        Dim command As New SqlCommand("VerReporteNominaGeneral", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        If (year <> -1 And mes <> -1) Then
            command.Parameters.AddWithValue("@Year", year)
            command.Parameters.AddWithValue("@Mes", mes)
        End If

        Dim reporte As New List(Of ReporteNominaGeneral)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim row As New ReporteNominaGeneral With {
                .Departamento = GetStringSafe(reader, 0),
                .Puesto = GetStringSafe(reader, 1),
                .Empleado = reader.GetString(2),
                .FechaIngreso = GetDateSafe(reader, 3),
                .FechaNacimiento = reader.GetDateTime(4),
                .SueldoDiario = GetDoubleSafe(reader, 5)
            }
            reporte.Add(row)
        End While

        reader.Close()
        connection.Close()

        Return reporte
    End Function
End Class
