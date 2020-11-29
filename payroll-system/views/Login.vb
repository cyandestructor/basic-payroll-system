Public Class Login
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
    Private Sub Txt_User_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_User.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class