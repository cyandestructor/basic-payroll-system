Imports System.IO
Imports System.Text
Public Class CSVReport
    Public Shared Function WriteReport(ByVal filePath As String, ByVal report As List(Of ReporteCalculoNomina)) As Boolean
        Try
            Using file As New StreamWriter(filePath, False)
                For Each record As ReporteCalculoNomina In report
                    Dim line As New StringBuilder
                    line.Append(record.IDNomina.ToString() + ",")
                    line.Append(record.IDEmpleado.ToString() + ",")
                    line.Append(record.NombreEmpleado.ToString() + ",")
                    line.Append(record.Fecha.ToString() + ",")
                    line.Append(record.CantidadDeposito.ToString() + ",")
                    line.Append(record.Banco.ToString() + ",")
                    line.Append(record.CuentaBancaria.ToString())
                    file.WriteLine(line.ToString())
                Next
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
