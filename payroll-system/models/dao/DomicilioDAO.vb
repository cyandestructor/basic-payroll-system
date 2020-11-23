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
End Class
