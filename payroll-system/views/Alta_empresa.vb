Public Class Alta_empresa
    Private Sub Alta_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEmpresas()
        InitEventHandlers()
    End Sub
    Private Sub InitEventHandlers()
        AddHandler Txt_NomEmp.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler Txt_RS_Emp.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler Txt_Tel_Emp.KeyPress, AddressOf UtilityController.DigitOnly
        AddHandler Txt_RP_Emp.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler Txt_RFC_Emp.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler Txt_Pago_Emp.KeyPress, AddressOf UtilityController.DigitOnly

        AddHandler TxtCalle.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler TxtNumero.KeyPress, AddressOf UtilityController.DigitOnly
        AddHandler TxtColonia.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler TxtMunicipio.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler TxtEstado.KeyPress, AddressOf UtilityController.LetterDigitOnly
        AddHandler TxtCP.KeyPress, AddressOf UtilityController.DigitOnly
    End Sub
    Private Sub UpdateEmpresas()
        Dim empresaDAO As New EmpresaDAO

        LB_Empresa.ValueMember = "RFC"
        LB_Empresa.DisplayMember = "Nombre"
        LB_Empresa.DataSource = empresaDAO.VerEmpresas()
        LB_Empresa.ClearSelected()
    End Sub
    Private Sub Btn_AgregarEmp_Click(sender As Object, e As EventArgs) Handles Btn_AgregarEmp.Click
        If ValidarInfo() Then
            RegistrarEmpresa()
        Else
            MsgBox("La información es incorrecta o está incompleta")
        End If
    End Sub
    Private Sub RegistrarEmpresa()
        Dim empresa As New Empresa With {
            .RFC = Txt_RFC_Emp.Text,
            .Nombre = Txt_NomEmp.Text,
            .RegistroPatronal = Txt_RP_Emp.Text,
            .RazonSocial = Txt_RS_Emp.Text,
            .Telefono = Long.Parse(Txt_Tel_Emp.Text),
            .Correo = Txt_Correo_Emp.Text,
            .FrecuenciaPago = Integer.Parse(Txt_Pago_Emp.Text),
            .InicioOperaciones = DateTime_InicioOp.Value
        }
        Dim domicilio As New Domicilio With {
           .Calle = TxtCalle.Text,
           .Numero = Integer.Parse(TxtNumero.Text),
           .Colonia = TxtColonia.Text,
           .Ciudad = TxtMunicipio.Text,
           .Estado = TxtEstado.Text,
           .CodigoPostal = Integer.Parse(TxtCP.Text)
        }
        empresa.DomicilioFiscal = domicilio

        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.Registrar(empresa)) Then
            MsgBox("Registro exitoso")
            UpdateEmpresas()
        End If
    End Sub
    Private Sub LB_Empresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Empresa.SelectedIndexChanged
        Dim empresaDAO As New EmpresaDAO
        Dim domicilioDAO As New DomicilioDAO

        If LB_Empresa.SelectedIndex <> -1 Then
            Dim idEmpresa = LB_Empresa.SelectedValue
            Dim selEmpresa = empresaDAO.ObtenerEmpresa(idEmpresa)
            Dim domEmpresa = domicilioDAO.ObtenerDomicilio(selEmpresa.DomicilioFiscal.ID)

            Txt_NomEmp.Text = selEmpresa.Nombre
            Txt_RS_Emp.Text = selEmpresa.RazonSocial
            Txt_Tel_Emp.Text = selEmpresa.Telefono
            Txt_Correo_Emp.Text = selEmpresa.Correo
            Txt_RP_Emp.Text = selEmpresa.RegistroPatronal
            Txt_RFC_Emp.Text = selEmpresa.RFC
            DateTime_InicioOp.Value = selEmpresa.InicioOperaciones
            Txt_Pago_Emp.Text = selEmpresa.FrecuenciaPago

            TxtCalle.Text = domEmpresa.Calle
            TxtNumero.Text = domEmpresa.Numero
            TxtColonia.Text = domEmpresa.Colonia
            TxtMunicipio.Text = domEmpresa.Ciudad
            TxtEstado.Text = domEmpresa.Estado
            TxtCP.Text = domEmpresa.CodigoPostal
        Else
            Txt_NomEmp.Text = ""
            Txt_RS_Emp.Text = ""
            Txt_Tel_Emp.Text = ""
            Txt_Correo_Emp.Text = ""
            Txt_RP_Emp.Text = ""
            Txt_RFC_Emp.Text = ""
            DateTime_InicioOp.Value = Date.Now
            Txt_Pago_Emp.Text = ""

            TxtCalle.Text = ""
            TxtNumero.Text = ""
            TxtColonia.Text = ""
            TxtMunicipio.Text = ""
            TxtEstado.Text = ""
            TxtCP.Text = ""
        End If
    End Sub
    Private Sub BtnEditarEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEditarEmpresa.Click
        If ValidarInfo() And LB_Empresa.SelectedIndex <> -1 Then
            Dim result = MessageBox.Show("¿Desea editar la información?", "Edición", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                EditarEmpresa()
            End If
        Else
            MsgBox("La información es incorrecta o está incompleta")
        End If
    End Sub
    Private Sub EditarEmpresa()
        Dim idEmpresa = LB_Empresa.SelectedValue

        Dim empresa As New Empresa With {
            .RFC = idEmpresa,
            .Nombre = Txt_NomEmp.Text,
            .RegistroPatronal = Txt_RP_Emp.Text,
            .RazonSocial = Txt_RS_Emp.Text,
            .Telefono = Long.Parse(Txt_Tel_Emp.Text),
            .Correo = Txt_Correo_Emp.Text,
            .FrecuenciaPago = Integer.Parse(Txt_Pago_Emp.Text),
            .InicioOperaciones = DateTime_InicioOp.Value
        }

        Dim empresaDAO As New EmpresaDAO
        If (empresaDAO.Editar(empresa)) Then
            MsgBox("Edición exitosa")
            UpdateEmpresas()
        End If
    End Sub
    Private Function ValidarInfo() As Boolean
        Dim valid = True

        For Each c As Control In Me.Controls
            If c.GetType() = GetType(TextBox) Then
                If c.Text = "" Then
                    valid = False
                End If
            End If
        Next

        For Each c As Control In GpbDomicilio.Controls
            If c.GetType() = GetType(TextBox) Then
                If c.Text = "" Then
                    valid = False
                End If
            End If
        Next

        If DateTime_InicioOp.Value > Date.Now Then
            valid = False
        End If

        Return valid
    End Function
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub
End Class