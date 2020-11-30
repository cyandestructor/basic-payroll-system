Public Class Login
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal edicion As Boolean)
        InitializeComponent()
        If edicion Then
            LblNuevaPassword.Visible = True
            TxtNuevaPassword.Visible = True
            Btn_Edit.Visible = True
            Btn_Ingresar.Visible = False
        End If
    End Sub
    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        If ValidateUser() Then
            Txt_User.Text = ""
            Txt_Password.Text = ""
            ' Show Main form
            Dim mainForm As New main
            mainForm.Show()
            Me.Hide()
        End If
    End Sub
    Public Function ValidateUser() As Boolean
        Dim usuario As String = Txt_User.Text
        Dim password As String = Txt_Password.Text

        Dim usuarioDAO As New UsuarioDAO

        If (usuario = "" Or password = "") Then
            MsgBox("Ingrese información para continuar")
        Else
            Dim usuarioInfo As Usuario = usuarioDAO.ObtenerUsuario(Integer.Parse(usuario), password)
            If (usuarioInfo Is Nothing) Then
                MsgBox("Información incorrecta. Intente de nuevo")
            Else
                MsgBox("Bienvenido")
                AppController.GetInstance().CurrentUser = usuarioInfo
                Return True
            End If
        End If

        Return False
    End Function
    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Dim idUsuario = Integer.Parse(Txt_User.Text)
        Dim password = Txt_Password.Text
        Dim nuevaPassword = TxtNuevaPassword.Text

        Dim usuarioDAO As New UsuarioDAO
        If usuarioDAO.CambiarPassword(idUsuario, password, nuevaPassword) Then
            MsgBox("Se ha cambiado la contraseña")
            Close()
        Else
            MsgBox("Información incorrecta, intente de nuevo")
        End If
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Txt_User.KeyPress, AddressOf UtilityController.DigitOnly
    End Sub
End Class