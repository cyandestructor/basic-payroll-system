Imports System.Data.SqlClient
Public Class ResumenPagosDAO
    Inherits DBConnection
    Public Function Generar(ByVal idEmpleado As Integer, ByVal year As Integer) As List(Of ResumenPagosRow)
        Dim command As New SqlCommand("VerResumenPagos", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@Year", year)
        Dim resumen As New List(Of ResumenPagosRow)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim row As New ResumenPagosRow With {
                .IDEmpleado = reader.GetInt32(0),
                .RFCEmpleado = reader.GetString(1),
                .NSSEmpleado = reader.GetInt64(2),
                .Year = reader.GetInt32(3),
                .Mes = reader.GetString(4),
                .ISR = reader.GetDouble(5),
                .IMSS = reader.GetDouble(6),
                .SueldoBruto = reader.GetDouble(7),
                .SueldoNeto = reader.GetDouble(8)
            }
            resumen.Add(row)
        End While

        reader.Close()
        connection.Close()

        Return resumen
    End Function
End Class
