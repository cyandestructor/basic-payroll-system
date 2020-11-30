Imports System.IO
Public Class EjecucionNomina
    Private Sub EjecucionNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEmpresas()
    End Sub
    Private Sub UpdateEmpresas()
        Dim empresaDAO As New EmpresaDAO
        CbEmpresas.ValueMember = "RFC"
        CbEmpresas.DisplayMember = "Nombre"
        CbEmpresas.DataSource = empresaDAO.VerEmpresas()
    End Sub
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        GenerarNomina()
    End Sub
    Private Sub GenerarNomina()
        Dim idEmpresa = CbEmpresas.SelectedValue

        Dim empresaDAO As New EmpresaDAO
        Dim empresa = empresaDAO.ObtenerEmpresa(idEmpresa)

        Dim empleadoDAO As New EmpleadoDAO
        Dim empleadosEmpresa = empleadoDAO.VerEmpleadosEmpresa(idEmpresa)

        Dim nominaDAO As New NominaDAO
        For Each empleado As Empleado In empleadosEmpresa
            Dim today = Date.Now
            Dim nomina As New Nomina With {
                .IDEmpleado = empleado.ID,
                .InicioPeriodo = today.AddDays(-empresa.FrecuenciaPago),
                .FinPeriodo = today
            }
            nominaDAO.Generar(nomina)
        Next

        Dim reporteDAO As New ReporteCalculoNominaDAO
        DgvReporteCalculo.DataSource = reporteDAO.Generar(idEmpresa, Date.Now)
    End Sub
    Private Sub BtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtnGenerarReporte.Click
        Using sfd As New SaveFileDialog
            sfd.Filter = "CSV|*.csv|PDF|*.pdf"
            sfd.ValidateNames = True

            If sfd.ShowDialog() = DialogResult.OK Then
                GenerarReporteCalculoNomina(sfd.FileName)
            End If

        End Using
    End Sub
    Private Sub GenerarReporteCalculoNomina(ByVal filepath As String)
        Dim idEmpresa = CbEmpresas.SelectedValue
        Dim reporteDAO As New ReporteCalculoNominaDAO
        Dim reporte = reporteDAO.Generar(idEmpresa, Date.Now)

        Select Case Path.GetExtension(filepath).ToLower
            Case ".csv"
                If CSVReport.WriteReport(filepath, reporte) Then
                    MsgBox("Se ha guardado el reporte en " + filepath)
                Else
                    MsgBox("No se pudo guardar el reporte")
                End If
            Case ".pdf"
                CSVReport.WriteReportPDF(filepath, reporte)
                MsgBox("Se ha guardado el reporte en " + filepath)
            Case Else
                MsgBox("No se pudo guardar el reporte")
        End Select
    End Sub
End Class