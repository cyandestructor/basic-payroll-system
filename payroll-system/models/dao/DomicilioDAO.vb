Imports System.Data.SqlClient
Public Class DomicilioDAO
    Inherits DBConnection
    Public Function Registrar(ByVal domicilio As Domicilio) As Boolean
        Dim command As New SqlCommand("RegistrarDomicilio", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Calle", domicilio.Calle)
        command.Parameters.AddWithValue("@Numero", domicilio.Numero)
        command.Parameters.AddWithValue("@Colonia", domicilio.Colonia)
        command.Parameters.AddWithValue("@Cod_Post", domicilio.CodigoPostal)
        command.Parameters.AddWithValue("@Ciudad", domicilio.Ciudad)
        command.Parameters.AddWithValue("@Estado", domicilio.Estado)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function Editar(ByVal domicilio As Domicilio) As Boolean
        Dim command As New SqlCommand("EditarDomicilio", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Domicilio", domicilio.ID)
        command.Parameters.AddWithValue("@Calle", domicilio.Calle)
        command.Parameters.AddWithValue("@Numero", domicilio.Numero)
        command.Parameters.AddWithValue("@Colonia", domicilio.Colonia)
        command.Parameters.AddWithValue("@Cod_Post", domicilio.CodigoPostal)
        command.Parameters.AddWithValue("@Ciudad", domicilio.Ciudad)
        command.Parameters.AddWithValue("@Estado", domicilio.Estado)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerDomicilios(Optional ByVal idDomicilio As Integer = Nothing) As List(Of Domicilio)
        Dim command As New SqlCommand("VerDomicilios", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim domicilios As New List(Of Domicilio)

        If (idDomicilio <> Nothing) Then
            command.Parameters.AddWithValue("@ID_Domicilio", idDomicilio)
        End If

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim domicilio As New Domicilio With {
                .ID = reader.GetInt32(0),
                .Calle = reader.GetString(1),
                .Numero = reader.GetInt32(2),
                .Colonia = reader.GetString(3),
                .CodigoPostal = reader.GetInt32(4),
                .Ciudad = reader.GetString(5),
                .Estado = reader.GetString(6)
            }
            domicilios.Add(domicilio)
        End While

        reader.Close()
        connection.Close()

        Return domicilios
    End Function
    Public Function ObtenerDomicilio(ByVal idDomicilio As Integer) As Domicilio
        Dim domicilio As New Domicilio

        Dim command As New SqlCommand("VerDomicilios", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Domicilio", idDomicilio)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            domicilio.ID = reader.GetInt32(0)
            domicilio.Calle = reader.GetString(1)
            domicilio.Numero = reader.GetInt32(2)
            domicilio.Colonia = reader.GetString(3)
            domicilio.CodigoPostal = reader.GetInt32(4)
            domicilio.Ciudad = reader.GetString(5)
            domicilio.Estado = reader.GetString(6)
        End If

        reader.Close()
        connection.Close()

        Return domicilio
    End Function
End Class
