Public Class Impuestos
    Private Sub Impuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each c As Control In Me.Controls
            If c.GetType() = GetType(TextBox) Then
                AddHandler c.KeyPress, AddressOf UtilityController.DecimalOnly
            End If
        Next
    End Sub
    Private Function Validar() As Boolean
        For Each c As Control In Me.Controls
            If c.GetType() = GetType(TextBox) Then
                If c.Text = "" Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Private Sub ClearAll()
        For Each c As Control In Me.Controls
            If c.GetType() = GetType(TextBox) Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub TxtModificar_Click(sender As Object, e As EventArgs) Handles TxtModificar.Click
        If Validar() Then
            Dim cantISR = Double.Parse(TxtCantISR.Text)
            Dim porcentISR = Double.Parse(TxtPorcISR.Text) / 100
            Dim cantIMSS = Double.Parse(TxtCantIMSS.Text)
            Dim porcentIMSS = Double.Parse(TxtPorcIMSS.Text) / 100

            Dim nominaDAO As New NominaDAO
            If nominaDAO.ModificarImpuestos(cantISR, porcentISR, cantIMSS, porcentIMSS) Then
                MsgBox("Modificación exitosa")
                ClearAll()
            End If
        Else
            MsgBox("Complete la información para continuar")
        End If
    End Sub
End Class