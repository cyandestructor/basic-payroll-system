Public Class Gerente
    Private _currentUser As Usuario
    Private Sub Menu_Puesto_Click(sender As Object, e As EventArgs) Handles Menu_Puesto.Click
        Dim formPuesto As New Opciones_puesto
        formPuesto.Show()
    End Sub
    Private Sub Menu_Departamento_Click(sender As Object, e As EventArgs) Handles Menu_Departamento.Click
        Dim formDeptos As New Opciones_Depa
        formDeptos.Show()
    End Sub
    Private Sub Menu_Empresa_Click(sender As Object, e As EventArgs) Handles Menu_Empresa.Click
        Dim formEmpresas As New Alta_empresa
        formEmpresas.Show()
    End Sub
    Private Sub Menu_Empleado_Click(sender As Object, e As EventArgs) Handles Menu_Empleado.Click
        Dim formEmpleado As New Alta_empleado
        formEmpleado.Show()
    End Sub
    Private Sub Menu_PD_Click(sender As Object, e As EventArgs) Handles Menu_PD.Click
        Dim formPercDeduc As New Per_Ded
        formPercDeduc.Show()
    End Sub
    Private Sub menuSolicitarPermiso_Click(sender As Object, e As EventArgs) Handles menuSolicitarPermiso.Click
        Dim formPermisos As New Permisos
        formPermisos.Show()
    End Sub
    Private Sub menuRevisarPermisos_Click(sender As Object, e As EventArgs) Handles menuRevisarPermisos.Click
        Dim formIncidencias As New RevisarIncidencias
        formIncidencias.Show()
    End Sub
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim formEmpleados As New VerEmpleados
        formEmpleados.Show()
    End Sub
    Private Sub Menu_Password_Click(sender As Object, e As EventArgs) Handles Menu_Password.Click
        Dim formSesion As New Login(True)
        formSesion.Show()
    End Sub
    Private Sub MenuAsignarGerentes_Click(sender As Object, e As EventArgs) Handles MenuAsignarGerentes.Click
        Dim formAsignacion As New AsignarGerentes
        formAsignacion.Show()
    End Sub
    Private Sub MenuCalcularNomina_Click(sender As Object, e As EventArgs) Handles MenuCalcularNomina.Click
        Dim formCalculoNomina As New EjecucionNomina
        formCalculoNomina.Show()
    End Sub
    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Dim formReportes As New VerReportes
        formReportes.Show()
    End Sub
    Private Sub Gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpYear.CustomFormat = "yyyy"
        _currentUser = AppController.GetInstance().CurrentUser
        UpdatePagos(Date.Now.Year)
    End Sub
    Private Sub UpdatePagos(ByVal year As Integer)
        Dim idEmpleado = _currentUser.ID
        Dim resumenDAO As New ResumenPagosDAO
        DgvResumen.DataSource = resumenDAO.Generar(idEmpleado, year)
    End Sub
    Private Sub BtnConsultarPagos_Click(sender As Object, e As EventArgs) Handles BtnConsultarPagos.Click
        Dim year = DtpYear.Value.Year
        UpdatePagos(year)
    End Sub
    Private Sub Menu_Nomina_Click(sender As Object, e As EventArgs) Handles Menu_Nomina.Click
        Dim formRecibo As New GenerarRecibosNomina
        formRecibo.Show()
    End Sub
    Private Sub MenuVacaciones_Click(sender As Object, e As EventArgs) Handles MenuVacaciones.Click
        Dim formVacaciones As New Vacaciones
        formVacaciones.Show()
    End Sub
End Class