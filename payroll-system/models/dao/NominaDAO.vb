Imports System.Data.SqlClient
Public Class NominaDAO
    Inherits DBConnection
    Public Function Generar(ByVal nomina As Nomina) As Boolean
        Dim command As New SqlCommand("GenerarNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", nomina.IDEmpleado)
        command.Parameters.AddWithValue("@Inicio_Periodo", nomina.InicioPeriodo)
        command.Parameters.AddWithValue("@Fin_Periodo", nomina.FinPeriodo)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerTodas() As List(Of Nomina)
        Dim command As New SqlCommand("VerNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim nominas As New List(Of Nomina)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim nomina As New Nomina With {
                .ID = reader.GetInt32(0),
                .SueldoBruto = reader.GetDouble(1),
                .SueldoNeto = reader.GetDouble(2),
                .IDEmpleado = reader.GetInt32(3),
                .InicioPeriodo = reader.GetDateTime(4),
                .FinPeriodo = reader.GetDateTime(5)
            }
            nominas.Add(nomina)
        End While

        reader.Close()
        connection.Close()

        Return nominas
    End Function
    Public Function VerDeEmpleado(ByVal idEmpleado As Integer, ByVal inicio As Date, ByVal fin As Date) As List(Of Nomina)
        Dim command As New SqlCommand("VerNominaEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@From", inicio)
        command.Parameters.AddWithValue("@To", fin)

        Dim nominas As New List(Of Nomina)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim nomina As New Nomina With {
                .ID = reader.GetInt32(0),
                .SueldoBruto = reader.GetDouble(1),
                .SueldoNeto = reader.GetDouble(2),
                .IDEmpleado = reader.GetInt32(3),
                .InicioPeriodo = reader.GetDateTime(4),
                .FinPeriodo = reader.GetDateTime(5)
            }
            nominas.Add(nomina)
        End While

        reader.Close()
        connection.Close()

        Return nominas
    End Function
End Class
