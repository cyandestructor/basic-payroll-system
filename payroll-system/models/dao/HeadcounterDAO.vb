Imports System.Data.SqlClient
Public Class HeadcounterDAO
    Inherits DBConnection
    Public Function GenerarParaPuestos(ByVal idEmpresa As String, ByVal idDpto As Integer, ByVal year As Integer, ByVal mes As Integer) As List(Of Headcounter1Row)
        Dim command As New SqlCommand("VerHeadcounter1", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@Year", year)
        command.Parameters.AddWithValue("@Mes", mes)

        Dim reporte As New List(Of Headcounter1Row)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim row As New Headcounter1Row With {
                .Empresa = reader.GetString(0),
                .Departamento = reader.GetString(1),
                .Gerente = reader.GetString(2),
                .Puesto = reader.GetString(3),
                .CantidadEmpleados = reader.GetInt32(4)
            }
            reporte.Add(row)
        End While

        reader.Close()
        connection.Close()

        Return reporte
    End Function
    Public Function GenerarParaDepartamentos(ByVal idEmpresa As String, ByVal idDpto As Integer, ByVal year As Integer, ByVal mes As Integer) As List(Of Headcounter2Row)
        Dim command As New SqlCommand("VerHeadcounter2", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@Year", year)
        command.Parameters.AddWithValue("@Mes", mes)

        Dim reporte As New List(Of Headcounter2Row)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim row As New Headcounter2Row With {
                .Empresa = reader.GetString(0),
                .Departamento = reader.GetString(1),
                .Gerente = reader.GetString(2),
                .CantidadEmpleados = reader.GetInt32(3),
                .UltimaNomina = reader.GetDateTime(4)
            }
            reporte.Add(row)
        End While

        reader.Close()
        connection.Close()

        Return reporte
    End Function
End Class
