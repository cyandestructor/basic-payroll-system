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
    Public Function VerDepartamentos() As List(Of Departamento)
        Dim command As New SqlCommand("VerDepartamentos", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim departamentos As New List(Of Departamento)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim departamento As New Departamento With {
                .ID = reader.GetInt32(0),
                .Nombre = reader.GetString(1),
                .Activo = reader.GetBoolean(2)
            }
            departamentos.Add(departamento)
        End While

        reader.Close()
        connection.Close()

        Return departamentos
    End Function
    Public Function ObtenerDepartamento(ByVal idDepartamento As Integer) As Departamento
        Dim departamento As New Departamento

        Dim command As New SqlCommand("VerDepartamentos", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Dpto", idDepartamento)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            departamento.ID = reader.GetInt32(0)
            departamento.Nombre = reader.GetString(1)
            departamento.Activo = reader.GetBoolean(2)
        End If

        reader.Close()
        connection.Close()

        Return departamento
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
