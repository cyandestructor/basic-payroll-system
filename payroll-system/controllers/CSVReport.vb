Imports System.IO
Imports System.Text
Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.DocumentObjectModel.Tables
Imports MigraDoc.Rendering
Public Class CSVReport
    Public Shared Function WriteReport(ByVal filePath As String, ByVal report As List(Of ReporteCalculoNomina)) As Boolean
        Try
            Using file As New StreamWriter(filePath, False)
                For Each record As ReporteCalculoNomina In report
                    Dim line As New StringBuilder
                    line.Append(record.IDNomina.ToString() + ",")
                    line.Append(record.IDEmpleado.ToString() + ",")
                    line.Append(record.NombreEmpleado + ",")
                    line.Append(record.Fecha.ToString("d") + ",")
                    line.Append(record.CantidadDeposito.ToString("n") + ",")
                    line.Append(record.Banco + ",")
                    line.Append(record.CuentaBancaria.ToString())
                    file.WriteLine(line.ToString())
                Next
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Sub WriteReportPDF(ByVal filePath As String, ByVal report As List(Of ReporteCalculoNomina))
        Dim pdf As New Document
        Dim section = pdf.AddSection()
        section.PageSetup.Orientation = Orientation.Landscape

        ' Create a table
        Dim reportTable As New Table
        reportTable.Borders.Width = 0.5

        reportTable.AddColumn(Unit.FromCentimeter(2))
        reportTable.AddColumn(Unit.FromCentimeter(2))
        reportTable.AddColumn(Unit.FromCentimeter(5))
        reportTable.AddColumn(Unit.FromCentimeter(3))
        reportTable.AddColumn(Unit.FromCentimeter(2))
        reportTable.AddColumn(Unit.FromCentimeter(3))
        reportTable.AddColumn(Unit.FromCentimeter(3))

        Dim header = reportTable.AddRow()
        header.Cells(0).AddParagraph("ID Nomina").Format.Font.Bold = True
        header.Cells(1).AddParagraph("ID Empleado").Format.Font.Bold = True
        header.Cells(2).AddParagraph("Empleado").Format.Font.Bold = True
        header.Cells(3).AddParagraph("Fecha").Format.Font.Bold = True
        header.Cells(4).AddParagraph("Cantidad").Format.Font.Bold = True
        header.Cells(5).AddParagraph("Banco").Format.Font.Bold = True
        header.Cells(6).AddParagraph("Cuenta").Format.Font.Bold = True

        ' Registers
        For Each register As ReporteCalculoNomina In report
            Dim row = reportTable.AddRow()

            row.Cells(0).AddParagraph(register.IDNomina.ToString)
            row.Cells(1).AddParagraph(register.IDEmpleado.ToString)
            row.Cells(2).AddParagraph(register.NombreEmpleado)
            row.Cells(3).AddParagraph(register.Fecha.ToString("d"))
            row.Cells(4).AddParagraph(register.CantidadDeposito.ToString("n"))
            row.Cells(5).AddParagraph(register.Banco)
            row.Cells(6).AddParagraph(register.CuentaBancaria.ToString)
        Next

        ' Add the table
        pdf.LastSection.Add(reportTable)

        ' Render the document
        Dim renderer As New PdfDocumentRenderer(True)
        renderer.Document = pdf
        renderer.RenderDocument()

        ' Save the document

        renderer.PdfDocument.Save(filePath)

    End Sub
End Class
