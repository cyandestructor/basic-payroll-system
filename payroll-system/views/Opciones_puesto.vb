Public Class Opciones_puesto
    Private Sub Opciones_puesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdatePuestos()
        UpdateEmpresas()
        AddHandler Txt_NomPuesto.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler Txt_PorSueldo.KeyPress, AddressOf UtilityController.DecimalOnly
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
        If Txt_NomPuesto.Text <> "" Then
            Dim puesto As New Puesto With {
                .Nombre = Txt_NomPuesto.Text
            }

            Dim puestoDAO As New PuestoDAO

            If (puestoDAO.Registrar(puesto)) Then
                MsgBox("Registro exitoso")
                UpdatePuestos()
            End If
        Else
            MsgBox("Escriba un nombre de puesto para continuar")
        End If
    End Sub
    Private Sub BtnAsignarEmpDpto_Click(sender As Object, e As EventArgs) Handles BtnAsignarEmpDpto.Click
        If LB_Puesto.SelectedIndex <> -1 And Cb_Empresa.SelectedIndex <> -1 And Cb_Depa.SelectedIndex <> -1 Then
            If Txt_PorSueldo.Text <> "" Then
                AsignarEmpresaDptoPuesto()
            Else
                MsgBox("Agregue un porcentaje de sueldo para continuar")
            End If
        Else
            MsgBox("Seleccione un puesto, empresa y departamento para continuar")
        End If
    End Sub
    Private Sub AsignarEmpresaDptoPuesto()
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
        If LB_Puesto.SelectedIndex <> -1 And Cb_Depa.SelectedIndex <> -1 Then
            If Txt_NomPuesto.Text <> "" And Txt_PorSueldo.Text <> "" Then
                EditarPuesto()
            Else
                MsgBox("Escribe un nombre y un porcentaje de sueldo para continuar")
            End If
        Else
            MsgBox("Seleccione un puesto y un departamento para continuar")
        End If
    End Sub
    Private Sub EditarPuesto()
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
    Private Sub BtnEliminarPuesto_Click(sender As Object, e As EventArgs) Handles BtnEliminarPuesto.Click
        If LB_Puesto.SelectedIndex <> -1 Then
            Dim idPuesto = LB_Puesto.SelectedValue
            Dim puestoDAO As New PuestoDAO
            Dim result = MessageBox.Show("¿Quiere eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                puestoDAO.Desactivar(idPuesto)
                UpdatePuestos()
            End If
        Else
            MsgBox("Seleccione un puesto para continuar")
        End If
    End Sub
End Class