Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.DocumentObjectModel.Tables
Imports MigraDoc.Rendering
Public Class PDFReceipt
    Private _document As Document
    Public Sub GenerateDocument(ByVal recibo As ReciboNomina, ByVal percepciones As List(Of Percepcion), ByVal deducciones As List(Of Deduccion))
        _document = New Document

        Dim empresa = recibo.DatosEmpresa
        Dim empleado = recibo.DatosEmpleado
        Dim nomina = recibo.DatosNomina

        ' First section
        Dim section1 = _document.AddSection()
        Dim title = section1.AddParagraph(empresa.RazonSocial)
        title.Format.Font.Size = Unit.FromPoint(30)
        Dim s1p1 = section1.AddParagraph("RFC: " + empresa.RFC + " Registro patronal: " + empresa.RegistroPatronal)
        section1.AddParagraph()
        Dim s1p2 = section1.AddParagraph("Fecha de pago: " + nomina.FechaGeneracion.ToString("d"))
        Dim s1p3 = section1.AddParagraph("Periodo de pago: " + nomina.InicioPeriodo.ToString("d") + " - " + nomina.FinPeriodo.ToString("d"))
        Dim s1p4 = section1.AddParagraph("Días del periodo: " + recibo.DiasPeriodo.ToString())
        section1.AddParagraph()

        ' Add the info table
        Dim infoTable = CreateInfoTable(recibo)
        _document.LastSection.Add(infoTable)

        section1.AddParagraph()
        section1.AddParagraph("Percepciones")

        ' Add the perceptions table
        Dim pTable = CreatePerceptionsTable(percepciones)
        _document.LastSection.Add(pTable)

        section1.AddParagraph()
        section1.AddParagraph("Deducciones")

        ' Add the deduction table
        Dim dTable = CreateDeductionsTable(deducciones)
        _document.LastSection.Add(dTable)

        section1.AddParagraph()
        section1.AddParagraph("Sueldo Bruto: " + nomina.SueldoBruto.ToString("n"))
        section1.AddParagraph("Sueldo Neto: " + nomina.SueldoNeto.ToString("n"))
        section1.AddParagraph("Total: " + recibo.SueldoEscrito + " PESOS MXN")

    End Sub
    Private Function CreateInfoTable(ByVal recibo As ReciboNomina) As Table
        Dim empresa = recibo.DatosEmpresa
        Dim empleado = recibo.DatosEmpleado
        Dim nomina = recibo.DatosNomina

        ' Info table

        Dim infoTable As New Table
        infoTable.Borders.Width = 0.5

        ' Columns

        Dim nomCol = infoTable.AddColumn(Unit.FromCentimeter(5))
        nomCol.Format.Alignment = ParagraphAlignment.Left

        Dim nssCol = infoTable.AddColumn(Unit.FromCentimeter(2.5))
        nssCol.Format.Alignment = ParagraphAlignment.Left

        Dim curpCol = infoTable.AddColumn(Unit.FromCentimeter(4.5))
        curpCol.Format.Alignment = ParagraphAlignment.Left

        Dim rfcCol = infoTable.AddColumn(Unit.FromCentimeter(4))
        rfcCol.Format.Alignment = ParagraphAlignment.Left

        ' Rows

        ' Header
        Dim header = infoTable.AddRow()

        Dim headerNom = header.Cells(0)
        headerNom.AddParagraph("Nombre")
        headerNom.Format.Font.Bold = True

        Dim headerNSS = header.Cells(1)
        headerNSS.AddParagraph("Número de seguro social")
        headerNSS.Format.Font.Bold = True

        Dim headerCURP = header.Cells(2)
        headerCURP.AddParagraph("CURP")
        headerCURP.Format.Font.Bold = True

        Dim headerRFC = header.Cells(3)
        headerRFC.AddParagraph("Registro Federal de Contribuyentes")
        headerRFC.Format.Font.Bold = True

        ' Header data
        Dim headerData = infoTable.AddRow()

        Dim headerDataNom = headerData.Cells(0)
        headerDataNom.AddParagraph(empleado.Nombre)

        Dim headerDataNSS = headerData.Cells(1)
        headerDataNSS.AddParagraph(empleado.NSS.ToString())

        Dim headerDataCURP = headerData.Cells(2)
        headerDataCURP.AddParagraph(empleado.CURP)

        Dim headerDataRFC = headerData.Cells(3)
        headerDataRFC.AddParagraph(empleado.RFC)

        Return infoTable
    End Function
    Private Function CreatePerceptionsTable(ByVal perceptions As List(Of Percepcion)) As Table
        Dim pTable As New Table
        pTable.Borders.Width = 0.5

        ' Header
        Dim idCol = pTable.AddColumn(Unit.FromCentimeter(3))
        Dim descCol = pTable.AddColumn(Unit.FromCentimeter(5))
        Dim fAmoutCol = pTable.AddColumn(Unit.FromCentimeter(3))
        Dim pAmountCol = pTable.AddColumn(Unit.FromCentimeter(2))
        Dim dateCol = pTable.AddColumn(Unit.FromCentimeter(3))

        Dim header = pTable.AddRow()

        Dim idHeader = header.Cells(0)
        idHeader.AddParagraph("ID")

        Dim descHeader = header.Cells(1)
        descHeader.AddParagraph("Descripción")

        Dim fAmountHeader = header.Cells(2)
        fAmountHeader.AddParagraph("Cantidad Fija")

        Dim pAmountHeader = header.Cells(3)
        pAmountHeader.AddParagraph("Cant. %")

        Dim dateHeader = header.Cells(4)
        dateHeader.AddParagraph("Fecha")

        ' Records
        Dim fTotal As Double = 0
        Dim pTotal As Double = 0
        For Each perception As Percepcion In perceptions
            Dim row = pTable.AddRow()

            Dim idCell = row.Cells(0)
            idCell.AddParagraph(perception.ID.ToString())

            Dim descCell = row.Cells(1)
            descCell.AddParagraph(perception.Descripcion)

            Dim fAmountCell = row.Cells(2)
            fAmountCell.AddParagraph(perception.CantidadFija.ToString("n"))
            fTotal += perception.CantidadFija

            Dim pAmountCell = row.Cells(3)
            pAmountCell.AddParagraph(perception.CantidadPorcentual.ToString("n"))
            pTotal += perception.CantidadPorcentual

            Dim dateCell = row.Cells(4)
            dateCell.AddParagraph(perception.Fecha.ToString("d"))
        Next

        ' Total Row

        Dim totalRow = pTable.AddRow()

        Dim totalCell = totalRow.Cells(1)
        totalCell.AddParagraph("Total:")

        Dim fTotalCell = totalRow.Cells(2)
        fTotalCell.AddParagraph(fTotal.ToString("n"))

        Dim pTotalCell = totalRow.Cells(3)
        pTotalCell.AddParagraph(pTotal.ToString("n"))

        Return pTable
    End Function
    Private Function CreateDeductionsTable(ByVal deductions As List(Of Deduccion)) As Table
        Dim dTable As New Table
        dTable.Borders.Width = 0.5

        ' Header
        Dim idCol = dTable.AddColumn(Unit.FromCentimeter(3))
        Dim descCol = dTable.AddColumn(Unit.FromCentimeter(5))
        Dim fAmoutCol = dTable.AddColumn(Unit.FromCentimeter(3))
        Dim pAmountCol = dTable.AddColumn(Unit.FromCentimeter(2))
        Dim dateCol = dTable.AddColumn(Unit.FromCentimeter(3))

        Dim header = dTable.AddRow()

        Dim idHeader = header.Cells(0)
        idHeader.AddParagraph("ID")

        Dim descHeader = header.Cells(1)
        descHeader.AddParagraph("Descripción")

        Dim fAmountHeader = header.Cells(2)
        fAmountHeader.AddParagraph("Cantidad Fija")

        Dim pAmountHeader = header.Cells(3)
        pAmountHeader.AddParagraph("Cant. %")

        Dim dateHeader = header.Cells(4)
        dateHeader.AddParagraph("Fecha")

        ' Records

        Dim fTotal As Double = 0
        Dim pTotal As Double = 0
        For Each deduction As Deduccion In deductions
            Dim row = dTable.AddRow()

            Dim idCell = row.Cells(0)
            idCell.AddParagraph(deduction.ID.ToString())

            Dim descCell = row.Cells(1)
            descCell.AddParagraph(deduction.Descripcion)

            Dim fAmountCell = row.Cells(2)
            fAmountCell.AddParagraph(deduction.CantidadFija.ToString("n"))
            fTotal += deduction.CantidadFija

            Dim pAmountCell = row.Cells(3)
            pAmountCell.AddParagraph(deduction.CantidadPorcentual.ToString("n"))
            pTotal += deduction.CantidadPorcentual

            Dim dateCell = row.Cells(4)
            dateCell.AddParagraph(deduction.Fecha.ToString("d"))
        Next

        ' Total Row

        Dim totalRow = dTable.AddRow()

        Dim totalCell = totalRow.Cells(1)
        totalCell.AddParagraph("Total:")

        Dim fTotalCell = totalRow.Cells(2)
        fTotalCell.AddParagraph(fTotal.ToString("n"))

        Dim pTotalCell = totalRow.Cells(3)
        pTotalCell.AddParagraph(pTotal.ToString("n"))

        Return dTable
    End Function
    Public Sub SaveToFile(ByVal filename As String, Optional ByVal openAtEnd As Boolean = False)
        ' Render the document
        Dim renderer As New PdfDocumentRenderer(True)
        renderer.Document = _document
        renderer.RenderDocument()

        ' Save the document
        renderer.PdfDocument.Save(filename)

        ' Open the file
        If openAtEnd Then
            Dim processInfo = New ProcessStartInfo
            processInfo.FileName = filename

            Process.Start(processInfo)
        End If
    End Sub
End Class
