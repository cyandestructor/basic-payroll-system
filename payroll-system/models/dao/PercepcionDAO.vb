Imports System.Data.SqlClient
Public Class PercepcionDAO
    Inherits DBConnection
    Public Function Generar(ByVal percepcion As Percepcion) As Boolean
        Dim command As New SqlCommand("GenerarPercepcion", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Desc_Percep", percepcion.Descripcion)
        command.Parameters.AddWithValue("@Cant_Fija", percepcion.CantidadFija)
        command.Parameters.AddWithValue("@Cant_Porcent", percepcion.CantidadPorcentual)
        command.Parameters.AddWithValue("@ID_Empleado", percepcion.IDEmpleado)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerTodas() As List(Of Percepcion)
        Dim command As New SqlCommand("VerPercepciones", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim percepciones As New List(Of Percepcion)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim percepcion As New Percepcion With {
                .ID = reader.GetInt32(0),
                .Descripcion = reader.GetString(1),
                .CantidadFija = reader.GetDouble(2),
                .CantidadPorcentual = reader.GetDouble(3),
                .IDEmpleado = reader.GetInt32(4),
                .Fecha = reader.GetDateTime(5)
            }
            percepciones.Add(percepcion)
        End While

        reader.Close()
        connection.Close()

        Return percepciones
    End Function
    Public Function VerDeEmpleado(ByVal idEmpleado As Integer, ByVal inicio As Date, ByVal fin As Date) As List(Of Percepcion)
        Dim command As New SqlCommand("VerPercepcionesEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@From", inicio)
        command.Parameters.AddWithValue("@To", fin)

        Dim percepciones As New List(Of Percepcion)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim percepcion As New Percepcion With {
                .ID = reader.GetInt32(0),
                .Descripcion = reader.GetString(1),
                .CantidadFija = reader.GetDouble(2),
                .CantidadPorcentual = reader.GetDouble(3),
                .IDEmpleado = idEmpleado,
                .Fecha = reader.GetDateTime(4)
            }
            percepciones.Add(percepcion)
        End While

        reader.Close()
        connection.Close()

        Return percepciones
    End Function
    Public Function VerDeNomina(ByVal idNomina As Integer) As List(Of Percepcion)
        Dim command As New SqlCommand("VerPercepcionesNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Nomina", idNomina)

        Dim percepciones As New List(Of Percepcion)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim percepcion As New Percepcion With {
                .ID = reader.GetInt32(0),
                .Descripcion = reader.GetString(1),
                .CantidadFija = reader.GetDouble(2),
                .CantidadPorcentual = reader.GetDouble(3),
                .Fecha = reader.GetDateTime(4)
            }
            percepciones.Add(percepcion)
        End While

        reader.Close()
        connection.Close()

        Return percepciones
    End Function
End Class
