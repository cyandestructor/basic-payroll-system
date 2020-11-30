Public Class EmpleadoForm
    Private _currentUser As Usuario
    Private Sub EmpleadoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpYear.CustomFormat = "yyyy"
        _currentUser = AppController.GetInstance().CurrentUser
        UpdatePagos(Date.Now.Year)
    End Sub
    Private Sub UpdatePagos(ByVal year As Integer)
        Dim idEmpleado = _currentUser.ID
        Dim resumenDAO As New ResumenPagosDAO
        DgvResumen.DataSource = resumenDAO.Generar(idEmpleado, year)
    End Sub
    Private Sub Menu_Nomina_Click(sender As Object, e As EventArgs) Handles Menu_Nomina.Click
        Dim formRecibo As New GenerarRecibosNomina
        formRecibo.Show()
    End Sub
    Private Sub MenuSolicitarPermiso_Click(sender As Object, e As EventArgs) Handles MenuSolicitarPermiso.Click
        Dim formPermisos As New Permisos
        formPermisos.Show()
    End Sub
    Private Sub MenuVacaciones_Click(sender As Object, e As EventArgs) Handles MenuVacaciones.Click
        Dim formVacaciones As New Vacaciones
        formVacaciones.Show()
    End Sub
    Private Sub Menu_Password_Click(sender As Object, e As EventArgs) Handles Menu_Password.Click
        Dim formSesion As New Login(True)
        formSesion.Show()
    End Sub
    Private Sub BtnConsultarPagos_Click(sender As Object, e As EventArgs) Handles BtnConsultarPagos.Click
        Dim year = DtpYear.Value.Year
        UpdatePagos(year)
    End Sub
End Class