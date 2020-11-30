Public Class UtilityController
    Public Shared Sub DigitOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Shared Sub DecimalOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And (e.KeyChar <> ".") Then
            e.Handled = True
        End If

        If (e.KeyChar = ".") And (CType(sender, TextBox).Text.IndexOf(".") > -1) Then
            e.Handled = True
        End If
    End Sub
    Public Shared Sub LetterOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Shared Sub LetterDigitOnly(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
