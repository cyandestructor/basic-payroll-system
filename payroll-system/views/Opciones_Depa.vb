Public Class Opciones_Depa
    Private Sub Opciones_Depa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDepartamentos()
        UpdateEmpresas()
        AddHandler Txt_NombreDepa.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler Txt_Sueldo.KeyPress, AddressOf UtilityController.DecimalOnly
    End Sub
    Private Sub UpdateDepartamentos()
        Dim departamentoDAO As New DepartamentoDAO
        LB_Depa.ValueMember = "ID"
        LB_Depa.DisplayMember = "Nombre"
        LB_Depa.DataSource = departamentoDAO.VerDepartamentos()
        LB_Depa.ClearSelected()
    End Sub
    Private Sub UpdateEmpresas()
        Dim empresaDAO As New EmpresaDAO
        Cb_Empresa.ValueMember = "RFC"
        Cb_Empresa.DisplayMember = "Nombre"
        Cb_Empresa.DataSource = empresaDAO.VerEmpresas()
    End Sub
    Private Sub LB_Depa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Depa.SelectedIndexChanged
        If LB_Depa.SelectedIndex <> -1 Then
            Txt_CodigoDepa.Text = LB_Depa.SelectedValue
            Txt_NombreDepa.Text = LB_Depa.GetItemText(LB_Depa.SelectedItem)
        Else
            Txt_CodigoDepa.Text = ""
            Txt_NombreDepa.Text = ""
        End If
    End Sub
    Private Sub ClearAll()
        LB_Depa.ClearSelected()
        Txt_Sueldo.Text = ""
    End Sub
    Private Sub BtnRegistrarDpto_Click(sender As Object, e As EventArgs) Handles BtnRegistrarDpto.Click
        If Txt_NombreDepa.Text <> "" Then
            Dim departamento As New Departamento With {
                .Nombre = Txt_NombreDepa.Text
            }

            Dim departamentoDAO As New DepartamentoDAO
            If (departamentoDAO.Registrar(departamento)) Then
                MsgBox("Registro exitoso")
                ClearAll()
                UpdateDepartamentos()
            End If
        Else
            MsgBox("El nombre de departamento está vacío")
        End If
    End Sub
    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        If Cb_Empresa.SelectedIndex <> -1 And LB_Depa.SelectedIndex <> -1 Then
            If Txt_Sueldo.Text <> "" Then
                AgregarDepartamentoEmpresa()
            Else
                MsgBox("Agregue una cantidad de sueldo base")
            End If
        Else
            MsgBox("La selección está incompleta")
        End If
    End Sub
    Private Sub AgregarDepartamentoEmpresa()
        Dim idEmpresa = Cb_Empresa.SelectedValue
        Dim idDpto = Integer.Parse(Txt_CodigoDepa.Text)
        Dim sueldoBase = Double.Parse(Txt_Sueldo.Text)

        Dim nombreEmpresa = Cb_Empresa.GetItemText(Cb_Empresa.SelectedItem)
        Dim nombreDpto = Txt_NombreDepa.Text

        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.AgregarDepartamento(idEmpresa, idDpto, sueldoBase)) Then
            MsgBox("Se ha agregado " + nombreDpto + " a " + nombreEmpresa)
            ClearAll()
        End If
    End Sub
    Private Sub BtnEditarDpto_Click(sender As Object, e As EventArgs) Handles BtnEditarDpto.Click
        If Txt_CodigoDepa.Text <> "" And Txt_NombreDepa.Text <> "" Then
            EditarDepartamento()
        Else
            MsgBox("Complete la información para continuar")
        End If
    End Sub
    Private Sub EditarDepartamento()
        Dim departamento As New Departamento With {
            .Nombre = Txt_NombreDepa.Text,
            .ID = Integer.Parse(Txt_CodigoDepa.Text)
        }

        Dim departamentoDAO As New DepartamentoDAO
        If (departamentoDAO.Editar(departamento)) Then
            MsgBox("Edición exitosa")
            UpdateDepartamentos()
        End If
    End Sub
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub
End Class