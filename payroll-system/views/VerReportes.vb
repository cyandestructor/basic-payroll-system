Public Class VerReportes
    Private Sub VerReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEmpresas()
        DtpYearMonth.CustomFormat = "MM'/'yyyy"
    End Sub
    Private Sub UpdateEmpresas()
        Dim empresaDAO As New EmpresaDAO
        CbEmpresas.ValueMember = "RFC"
        CbEmpresas.DisplayMember = "Nombre"
        CbEmpresas.DataSource = empresaDAO.VerEmpresas()
    End Sub
    Private Sub CbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbEmpresas.SelectedIndexChanged
        If CbEmpresas.SelectedIndex <> -1 Then
            Dim idEmpresa = CbEmpresas.SelectedValue

            Dim departamentoDAO As New DepartamentoDAO
            CbDepartamentos.ValueMember = "ID"
            CbDepartamentos.DisplayMember = "Nombre"
            Dim departamentos = departamentoDAO.VerDepartamentosEmpresa(idEmpresa)
            CbDepartamentos.DataSource = If(departamentos.Count, departamentos, Nothing)
        Else
            CbDepartamentos.DataSource = Nothing
        End If
    End Sub
    Private Sub BtnRNG_Click(sender As Object, e As EventArgs) Handles BtnRNG.Click
        If CbEmpresas.SelectedIndex <> -1 Then
            Dim idEmpresa = CbEmpresas.SelectedValue
            Dim yearMonth = DtpYearMonth.Value

            Dim reporteDAO As New ReporteNominaGeneralDAO
            DgvReporte.DataSource = reporteDAO.Generar(idEmpresa, yearMonth.Year, yearMonth.Month)
        Else
            MsgBox("Seleccione una empresa para continuar")
        End If
    End Sub
    Private Sub BtnRN_Click(sender As Object, e As EventArgs) Handles BtnRN.Click
        If CbEmpresas.SelectedIndex <> -1 And CbDepartamentos.SelectedIndex <> -1 Then
            Dim idEmpresa = CbEmpresas.SelectedValue
            Dim idDpto = CbDepartamentos.SelectedValue
            Dim yearMonth = DtpYearMonth.Value

            Dim reporteDAO As New ReporteNominaDAO
            DgvReporte.DataSource = reporteDAO.Generar(idEmpresa, idDpto, yearMonth.Year, yearMonth.Month)
        Else
            MsgBox("Seleccione una empresa y un departamento para continuar")
        End If
    End Sub
    Private Sub BtnHD_Click(sender As Object, e As EventArgs) Handles BtnHD.Click
        If CbEmpresas.SelectedIndex <> -1 And CbDepartamentos.SelectedIndex <> -1 Then
            Dim idEmpresa = CbEmpresas.SelectedValue
            Dim idDpto = CbDepartamentos.SelectedValue
            Dim yearMonth = DtpYearMonth.Value

            Dim reporteDAO As New HeadcounterDAO
            DgvReporte.DataSource = reporteDAO.GenerarParaDepartamentos(idEmpresa, idDpto, yearMonth.Year, yearMonth.Month)
        Else
            MsgBox("Seleccione una empresa y un departamento para continuar")
        End If
    End Sub
    Private Sub BtnHP_Click(sender As Object, e As EventArgs) Handles BtnHP.Click
        If CbEmpresas.SelectedIndex <> -1 And CbDepartamentos.SelectedIndex <> -1 Then
            Dim idEmpresa = CbEmpresas.SelectedValue
            Dim idDpto = CbDepartamentos.SelectedValue
            Dim yearMonth = DtpYearMonth.Value

            Dim reporteDAO As New HeadcounterDAO
            DgvReporte.DataSource = reporteDAO.GenerarParaPuestos(idEmpresa, idDpto, yearMonth.Year, yearMonth.Month)
        Else
            MsgBox("Seleccione una empresa y un departamento para continuar")
        End If
    End Sub
End Class