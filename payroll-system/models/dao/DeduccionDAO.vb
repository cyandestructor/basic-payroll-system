Imports System.Data.SqlClient
Public Class DeduccionDAO
    Inherits DBConnection
    Public Function Generar(ByVal deduccion As Deduccion) As Boolean
        Dim command As New SqlCommand("GenerarDeduccion", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Desc_Deducc", deduccion.Descripcion)
        command.Parameters.AddWithValue("@Cant_Fija", deduccion.CantidadFija)
        command.Parameters.AddWithValue("@Cant_Porcent", deduccion.CantidadPorcentual)
        command.Parameters.AddWithValue("@ID_Empleado", deduccion.IDEmpleado)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerTodas() As List(Of Deduccion)
        Dim command As New SqlCommand("VerDeducciones", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim deducciones As New List(Of Deduccion)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim deduccion As New Deduccion With {
                .ID = reader.GetInt32(0),
                .Descripcion = reader.GetString(1),
                .CantidadFija = reader.GetDouble(2),
                .CantidadPorcentual = reader.GetDouble(3),
                .IDEmpleado = reader.GetInt32(4),
                .Fecha = reader.GetDateTime(5)
            }
            deducciones.Add(deduccion)
        End While

        reader.Close()
        connection.Close()

        Return deducciones
    End Function
    Public Function VerDeEmpleado(ByVal idEmpleado As Integer, ByVal inicio As Date, ByVal fin As Date) As List(Of Deduccion)
        Dim command As New SqlCommand("VerDeduccionesEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@From", inicio)
        command.Parameters.AddWithValue("@To", fin)

        Dim deducciones As New List(Of Deduccion)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim deduccion As New Deduccion With {
                .ID = reader.GetInt32(0),
                .Descripcion = reader.GetString(1),
                .CantidadFija = reader.GetDouble(2),
                .CantidadPorcentual = reader.GetDouble(3),
                .IDEmpleado = idEmpleado,
                .Fecha = reader.GetDateTime(4)
            }
            deducciones.Add(deduccion)
        End While

        reader.Close()
        connection.Close()

        Return deducciones
    End Function
    Public Function VerDeNomina(ByVal idNomina As Integer) As List(Of Deduccion)
        Dim command As New SqlCommand("VerDeduccionesNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Nomina", idNomina)

        Dim deducciones As New List(Of Deduccion)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim deduccion As New Deduccion With {
                .ID = reader.GetInt32(0),
                .Descripcion = reader.GetString(1),
                .CantidadFija = reader.GetDouble(2),
                .CantidadPorcentual = reader.GetDouble(3),
                .Fecha = reader.GetDateTime(4)
            }
            deducciones.Add(deduccion)
        End While

        reader.Close()
        connection.Close()

        Return deducciones
    End Function
End Class