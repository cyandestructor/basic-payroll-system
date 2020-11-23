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
End Class
