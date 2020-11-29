Public Class Alta_empleado
    Private _selectedEmployee As Empleado
    Public Sub New()
        InitializeComponent()
        _selectedEmployee = Nothing
    End Sub
    Public Sub New(ByVal idEmpleado As Integer)
        InitializeComponent()
        Dim empleadoDAO As New EmpleadoDAO
        _selectedEmployee = empleadoDAO.ObtenerEmpleado(idEmpleado)
    End Sub
    Private Sub Alta_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bancoDAO As New BancoDAO
        Cb_Banco.ValueMember = "ID"
        Cb_Banco.DisplayMember = "Nombre"
        Cb_Banco.DataSource = bancoDAO.VerBancos()

        If _selectedEmployee IsNot Nothing Then
            FillInfo(_selectedEmployee)
        End If
    End Sub
    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim empleado As New Empleado With {
            .RFC = Txt_RFC.Text,
            .Nombre = Txt_NomUsu.Text,
            .ApellidoPaterno = Txt_AP.Text,
            .ApellidoMaterno = Txt_AM.Text,
            .CURP = Txt_CURP.Text,
            .Correo = Txt_CorreoUsu.Text,
            .FechaNacimiento = DateTime_NacimientoUsu.Value,
            .NSS = Long.Parse(Txt_NSS.Text),
            .Telefono = Long.Parse(Txt_TelUsu.Text),
            .Banco = New Banco With {.ID = Cb_Banco.SelectedValue},
            .CuentaBancaria = Long.Parse(Txt_Cuenta.Text)
        }
        Dim domicilio As New Domicilio With {
            .Calle = Txt_Calle.Text,
            .Numero = Integer.Parse(Txt_Num.Text),
            .Colonia = Txt_Col.Text,
            .Ciudad = TxtMunicipio.Text,
            .Estado = TxtEstado.Text,
            .CodigoPostal = Integer.Parse(Txt_CP.Text)
        }
        empleado.Domicilio = domicilio

        Dim empleadoDAO As New EmpleadoDAO
        Dim idEmpleado = empleadoDAO.Registrar(empleado)
        If idEmpleado <> 0 Then
            MsgBox("Registro exitoso para el usuario: " + idEmpleado.ToString())
            ClearAll()
        End If
    End Sub
    Private Sub ClearAll()
        Txt_CodUsu.Text = ""
        Txt_NomUsu.Text = ""
        Txt_AP.Text = ""
        Txt_AM.Text = ""
        DateTime_NacimientoUsu.Value = Date.Now
        Txt_CURP.Text = ""
        Txt_NSS.Text = ""
        Txt_RFC.Text = ""
        Txt_Cuenta.Text = ""
        Txt_CorreoUsu.Text = ""
        Txt_TelUsu.Text = ""

        Txt_Calle.Text = ""
        Txt_Num.Text = ""
        Txt_Col.Text = ""
        TxtMunicipio.Text = ""
        TxtEstado.Text = ""
        Txt_CP.Text = ""
    End Sub
    Public Sub FillInfo(ByVal empleado As Empleado)
        Txt_CodUsu.Text = empleado.ID
        Txt_NomUsu.Text = empleado.Nombre
        Txt_AP.Text = empleado.ApellidoPaterno
        Txt_AM.Text = empleado.ApellidoMaterno
        DateTime_NacimientoUsu.Value = empleado.FechaNacimiento
        Txt_CURP.Text = empleado.CURP
        Txt_NSS.Text = empleado.NSS
        Txt_RFC.Text = empleado.RFC
        Txt_Cuenta.Text = empleado.CuentaBancaria
        Txt_CorreoUsu.Text = empleado.Correo
        Txt_TelUsu.Text = empleado.Telefono

        Dim domicilioDAO As New DomicilioDAO
        Dim domicilio = domicilioDAO.ObtenerDomicilio(empleado.Domicilio.ID)

        Txt_Calle.Text = domicilio.Calle
        Txt_Num.Text = domicilio.Numero
        Txt_Col.Text = domicilio.Colonia
        TxtMunicipio.Text = domicilio.Ciudad
        TxtEstado.Text = domicilio.Estado
        Txt_CP.Text = domicilio.CodigoPostal

        Cb_Banco.SelectedValue = empleado.Banco.ID
    End Sub
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub
End Class