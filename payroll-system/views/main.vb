Public Class main
    Private _currentUser As Usuario
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _currentUser = AppController.GetInstance().CurrentUser
        If _currentUser.Nivel > 1 Then
            ShowPanelForm(New Gerente)
        Else
            ShowPanelForm(New EmpleadoForm)
        End If
    End Sub
    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub ShowPanelForm(ByVal target As Form)
        If pnlContainer.Controls.Count > 0 Then
            pnlContainer.Controls.RemoveAt(0)
        End If

        target.TopLevel = False
        target.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(target)
        pnlContainer.Tag = target
        target.Show()
    End Sub
End Class