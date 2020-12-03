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
        If CbEmpresas.SelectedIndex <> -1 Then
            GenerarNomina()
        Else
            MsgBox("Seleccione una empresa para continuar")
        End If
    End Sub
    Private Sub GenerarNomina()
        Dim nominaDAO As New NominaDAO
        Dim empresaDAO As New EmpresaDAO

        Dim idEmpresa = CbEmpresas.SelectedValue
        Dim empresa = empresaDAO.ObtenerEmpresa(idEmpresa)

        Dim fecha = nominaDAO.UltimoPagoEmpresa(idEmpresa)
        fecha = If(fecha = Date.MinValue, Date.Now, fecha.AddDays(empresa.FrecuenciaPago))

        Dim empleadoDAO As New EmpleadoDAO
        Dim empleadosEmpresa = empleadoDAO.VerEmpleadosEmpresa(idEmpresa)

        For Each empleado As Empleado In empleadosEmpresa
            Dim nomina As New Nomina With {
                .IDEmpleado = empleado.ID,
                .InicioPeriodo = fecha.AddDays(-empresa.FrecuenciaPago - 1),
                .FinPeriodo = fecha,
                .FechaGeneracion = fecha
            }
            nominaDAO.Generar(nomina)
        Next

        Dim reporteDAO As New ReporteCalculoNominaDAO
        DgvReporteCalculo.DataSource = reporteDAO.Generar(idEmpresa, fecha)
    End Sub
    Private Sub BtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtnGenerarReporte.Click
        If CbEmpresas.SelectedIndex <> -1 Then
            Using sfd As New SaveFileDialog
                sfd.Filter = "CSV|*.csv|PDF|*.pdf"
                sfd.ValidateNames = True

                If sfd.ShowDialog() = DialogResult.OK Then
                    GenerarReporteCalculoNomina(sfd.FileName)
                End If

            End Using
        Else
            MsgBox("Seleccione una empresa para continuar")
        End If
    End Sub
    Private Sub GenerarReporteCalculoNomina(ByVal filepath As String)
        Dim idEmpresa = CbEmpresas.SelectedValue
        Dim fecha = DtpFechaNomina.Value
        Dim reporteDAO As New ReporteCalculoNominaDAO
        Dim reporte = reporteDAO.Generar(idEmpresa, fecha)

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