Imports System.Data.SqlClient
Public Class PuestoDAO
    Inherits DBConnection
    Public Function Registrar(ByVal puesto As Puesto) As Boolean
        Dim command As New SqlCommand("RegistrarPuesto", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Nom_Puesto", puesto.Nombre)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function Editar(ByVal puesto As Puesto) As Boolean
        Dim command As New SqlCommand("EditarPuesto", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Puesto", puesto.ID)
        command.Parameters.AddWithValue("@Nom_Puesto", puesto.Nombre)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerPuestos() As List(Of Puesto)
        Dim command As New SqlCommand("VerPuestos", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim puestos As New List(Of Puesto)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim puesto As New Puesto With {
                .ID = reader.GetInt32(0),
                .Nombre = reader.GetString(1),
                .Activo = reader.GetBoolean(2)
            }
            puestos.Add(puesto)
        End While

        reader.Close()
        connection.Close()

        Return puestos
    End Function
    Public Function VerPuestosDepartamento(ByVal idDpto As Integer) As List(Of Puesto)
        Dim command As New SqlCommand("VerPuestos", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Dpto", idDpto)

        Dim puestos As New List(Of Puesto)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim puesto As New Puesto With {
                .ID = reader.GetInt32(0),
                .Nombre = reader.GetString(1),
                .Activo = reader.GetBoolean(2)
            }
            puestos.Add(puesto)
        End While

        reader.Close()
        connection.Close()

        Return puestos
    End Function
    Public Function ObtenerPuesto(ByVal idPuesto As Integer) As Puesto
        Dim puesto As New Puesto

        Dim command As New SqlCommand("VerPuestos", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Puesto", idPuesto)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            puesto.ID = reader.GetInt32(0)
            puesto.Nombre = reader.GetString(1)
            puesto.Activo = reader.GetBoolean(2)
        End If

        reader.Close()
        connection.Close()

        Return puesto
    End Function
End Class
