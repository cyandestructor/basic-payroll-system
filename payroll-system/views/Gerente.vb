Public Class Gerente
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
End Class