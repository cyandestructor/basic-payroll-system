Public Class Opciones_puesto
    Private Sub Opciones_puesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePuestos()
        UpdateEmpresas()
    End Sub
    Private Sub Cb_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Empresa.SelectedIndexChanged
        If Cb_Empresa.SelectedIndex <> -1 Then
            Dim selected = Cb_Empresa.SelectedValue
            Dim departamentoDAO As New DepartamentoDAO
            Cb_Depa.ValueMember = "ID"
            Cb_Depa.DisplayMember = "Nombre"
            Cb_Depa.DataSource = departamentoDAO.VerDepartamentosEmpresa(selected)
        End If
    End Sub
    Private Sub Btn_Registrar_Click(sender As Object, e As EventArgs) Handles Btn_Registrar.Click
        Dim puesto As New Puesto With {
            .Nombre = Txt_NomPuesto.Text
        }

        Dim puestoDAO As New PuestoDAO

        If (puestoDAO.Registrar(puesto)) Then
            MsgBox("Registro exitoso")
            UpdatePuestos()
        End If
    End Sub
    Private Sub BtnAsignarEmpDpto_Click(sender As Object, e As EventArgs) Handles BtnAsignarEmpDpto.Click
        Dim empresaDAO As New EmpresaDAO
        Dim departamentoDAO As New DepartamentoDAO

        Dim puestoSel = Integer.Parse(LB_Puesto.SelectedValue)
        Dim empresaSel = Cb_Empresa.SelectedValue
        Dim dptoSel = Integer.Parse(Cb_Depa.SelectedValue)

        Dim porcentSueld = Double.Parse(Txt_PorSueldo.Text) / 100

        If (departamentoDAO.AgregarPuesto(dptoSel, puestoSel, porcentSueld) And empresaDAO.AgregarPuesto(empresaSel, puestoSel)) Then
            MsgBox("Cambio exitoso")
            ClearAll()
        End If
    End Sub
    Public Sub UpdatePuestos()
        Dim puestoDAO As New PuestoDAO
        LB_Puesto.DisplayMember = "Nombre"
        LB_Puesto.ValueMember = "ID"
        LB_Puesto.DataSource = puestoDAO.VerPuestos()
        LB_Puesto.ClearSelected()
    End Sub
    Public Sub UpdateEmpresas()
        Dim empresaDAO As New EmpresaDAO
        Cb_Empresa.ValueMember = "RFC"
        Cb_Empresa.DisplayMember = "Nombre"
        Cb_Empresa.DataSource = empresaDAO.VerEmpresas()
    End Sub
    Private Sub LB_Puesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Puesto.SelectedIndexChanged
        If LB_Puesto.SelectedIndex <> -1 Then
            Txt_CodPuesto.Text = LB_Puesto.SelectedValue
            Txt_NomPuesto.Text = LB_Puesto.GetItemText(LB_Puesto.SelectedItem)
        Else
            Txt_CodPuesto.Text = ""
            Txt_NomPuesto.Text = ""
        End If
    End Sub
    Private Sub ClearAll()
        LB_Puesto.ClearSelected()
        Txt_PorSueldo.Text = ""
    End Sub
    Private Sub BtnEditarPuesto_Click(sender As Object, e As EventArgs) Handles BtnEditarPuesto.Click
        Dim puestoSel = Integer.Parse(Txt_CodPuesto.Text)
        Dim puesto As New Puesto With {
            .ID = puestoSel,
            .Nombre = Txt_NomPuesto.Text
        }

        Dim dptoSel = Integer.Parse(Cb_Depa.SelectedValue)
        Dim porcentSueld = Double.Parse(Txt_PorSueldo.Text) / 100

        Dim puestoDAO As New PuestoDAO
        Dim departamentoDAO As New DepartamentoDAO
        If (puestoDAO.Editar(puesto) And departamentoDAO.EditarPorcentSueldoPuesto(dptoSel, puestoSel, porcentSueld)) Then
            MsgBox("Edición exitosa")
            ClearAll()
            UpdatePuestos()
        End If
    End Sub
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub
End Class