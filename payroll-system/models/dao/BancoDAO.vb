Imports System.Data.SqlClient
Public Class BancoDAO
    Inherits DBConnection
    Public Function VerBancos() As List(Of Banco)
        Dim command As New SqlCommand("VerBancos", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim bancos As New List(Of Banco)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim banco As New Banco With {
                .ID = reader.GetInt32(0),
                .Nombre = reader.GetString(1)
            }
            bancos.Add(banco)
        End While

        reader.Close()
        connection.Close()

        Return bancos
    End Function
    Public Function ObtenerBanco(ByVal idBanco As Integer) As Banco
        Dim banco As New Banco

        Dim command As New SqlCommand("VerBancos", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Banco", idBanco)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            banco.ID = reader.GetInt32(0)
            banco.Nombre = reader.GetString(1)
        End If

        reader.Close()
        connection.Close()

        Return banco
    End Function
End Class
