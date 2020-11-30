Public Class VerEmpleados
    Private Sub VerEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEmpleados()
        UpdateEmpresas()
    End Sub
    Private Sub UpdateEmpleados()
        Dim empleadoDAO As New EmpleadoDAO
        LbEmpleados.ValueMember = "ID"
        LbEmpleados.DisplayMember = "NombreCompleto"
        LbEmpleados.DataSource = empleadoDAO.VerEmpleados()
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
    Private Sub CbDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDepartamentos.SelectedIndexChanged
        If CbDepartamentos.SelectedIndex <> -1 Then
            Dim idDepartamento = CbDepartamentos.SelectedValue

            Dim puestoDAO As New PuestoDAO
            CbPuestos.ValueMember = "ID"
            CbPuestos.DisplayMember = "Nombre"
            Dim puestos = puestoDAO.VerPuestosDepartamento(idDepartamento)
            CbPuestos.DataSource = If(puestos.Count, puestos, Nothing)
        Else
            CbPuestos.DataSource = Nothing
        End If
    End Sub
    Private Sub BtnAsignar_Click(sender As Object, e As EventArgs) Handles BtnAsignar.Click
        Dim empleadoSel = LbEmpleados.SelectedIndex
        Dim empresaSel = CbEmpresas.SelectedIndex
        Dim dptoSel = CbDepartamentos.SelectedIndex
        Dim puestoSel = CbPuestos.SelectedIndex

        If empleadoSel <> -1 And empresaSel <> -1 And dptoSel <> -1 And puestoSel <> -1 Then
            AsignarPosicion()
        Else
            MsgBox("Seleccione una empresa, un departamento y un puesto para el empleado")
        End If
    End Sub
    Private Sub AsignarPosicion()
        Dim idEmpleado = LbEmpleados.SelectedValue
        Dim idEmpresa = CbEmpresas.SelectedValue
        Dim idDpto = CbDepartamentos.SelectedValue
        Dim idPuesto = CbPuestos.SelectedValue

        AsignarEmpresa(idEmpleado, idEmpresa)
        AsignarDepartamento(idEmpleado, idDpto)
        AsignarPuesto(idEmpleado, idPuesto)

        MsgBox("Asignación exitosa")
        UpdateEmpleados()
    End Sub
    Private Sub AsignarEmpresa(ByVal idEmpleado As Integer, ByVal idEmpresa As String)
        Dim empleadoDAO As New EmpleadoDAO
        empleadoDAO.AgregarEmpresa(idEmpleado, idEmpresa, Date.Now)
    End Sub
    Private Sub AsignarDepartamento(ByVal idEmpleado As Integer, ByVal idDpto As Integer)
        Dim empleadoDAO As New EmpleadoDAO
        empleadoDAO.AsignarDepartamento(idEmpleado, idDpto)
    End Sub
    Private Sub AsignarPuesto(ByVal idEmpleado As Integer, ByVal idPuesto As Integer)
        Dim empleadoDAO As New EmpleadoDAO
        empleadoDAO.AsignarPuesto(idEmpleado, idPuesto)
    End Sub
    Private Sub BtnSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSeleccion.Click
        If LbEmpleados.SelectedIndex <> -1 Then
            Dim idEmpleado = LbEmpleados.SelectedValue
            Dim formVerInfo As New Alta_empleado(idEmpleado)
            formVerInfo.Show()
        Else
            MsgBox("Seleccione un empleado para continuar")
        End If
    End Sub
    Private Sub BtnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnEliminarEmpleado.Click
        If LbEmpleados.SelectedIndex <> -1 Then
            Dim idEmpleado = LbEmpleados.SelectedValue

            Dim result = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim empleadoDAO As New EmpleadoDAO
                empleadoDAO.Desactivar(idEmpleado)
                UpdateEmpleados()
                MsgBox("Se ha eliminado el registro")
            End If
        Else
            MsgBox("Seleccione un empleado para continuar")
        End If
    End Sub
End Class