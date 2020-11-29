Imports System.Data.SqlClient
Public Class UsuarioDAO
    Inherits DBConnection
    Public Function CambiarPassword(ByVal idUsuario As Integer, ByVal oldPassword As String, ByVal newPassword As String) As Boolean
        Dim validUser As Boolean = True

        Dim command As New SqlCommand("EditarPasswordUsuario", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Usuario", idUsuario)
        command.Parameters.AddWithValue("@Old_Password", oldPassword)
        command.Parameters.AddWithValue("@New_Password", newPassword)

        Dim parameter As New SqlParameter
        parameter = command.Parameters.Add("@ValidUser", SqlDbType.Int)
        parameter.Direction = ParameterDirection.ReturnValue

        connection.Open()
        command.ExecuteNonQuery()

        If (parameter.Value = -1) Then
            validUser = False
        End If

        connection.Close()

        Return validUser
    End Function
    Public Function ObtenerUsuario(ByVal idUsuario As Integer, ByVal password As String) As Usuario
        Dim usuario As New Usuario

        Dim command As New SqlCommand("ObtenerInfoUsuario", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Usuario", idUsuario)
        command.Parameters.AddWithValue("@Password", password)

        Dim parameter As New SqlParameter
        parameter = command.Parameters.Add("@ValidUser", SqlDbType.Int)
        parameter.Direction = ParameterDirection.ReturnValue

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            usuario.ID = reader.GetInt32(0)
            usuario.Nivel = reader.GetByte(1)
        End If

        If (parameter.Value = -1) Then
            usuario = Nothing
        End If

        reader.Close()
        connection.Close()

        Return usuario
    End Function
End Class
