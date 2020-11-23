Imports System.Data.SqlClient
Public Class DepartamentoDAO
    Inherits DBConnection
    Public Function Registrar(ByVal departamento As Departamento) As Boolean
        Dim command As New SqlCommand("RegistrarDepartamento", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Nom_Dpto", departamento.Nombre)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function Editar(ByVal departamento As Departamento) As Boolean
        Dim command As New SqlCommand("EditarDepartamento", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Dpto", departamento.ID)
        command.Parameters.AddWithValue("@Nom_Dpto", departamento.Nombre)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function AsignarGerente(ByVal idEmpresa As String, ByVal idDpto As Integer, ByVal idGerente As Integer, ByVal bono As Double) As Boolean
        Dim command As New SqlCommand("AsignarGerenteDpto", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@ID_Gerente", idGerente)
        command.Parameters.AddWithValue("@Cant_Bono", bono)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function AgregarPuesto(ByVal idDpto As Integer, ByVal idPuesto As Integer, ByVal porcentajeSueldo As Double) As Boolean
        Dim command As New SqlCommand("AgregarPuestoDpto", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@ID_Puesto", idPuesto)
        command.Parameters.AddWithValue("@Porcent_Sueldo", porcentajeSueldo)
        command.Parameters.AddWithValue("@Mode", 1)

        connection.Open()
        Command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function EditarPorcentSueldoPuesto(ByVal idDpto As Integer, ByVal idPuesto As Integer, ByVal porcentajeSueldo As Double) As Boolean
        Dim command As New SqlCommand("AgregarPuestoDpto", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@ID_Puesto", idPuesto)
        command.Parameters.AddWithValue("@Porcent_Sueldo", porcentajeSueldo)
        command.Parameters.AddWithValue("@Mode", 2)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
End Class
