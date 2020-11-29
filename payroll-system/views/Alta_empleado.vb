Public Class Alta_empleado
    Private Sub Alta_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bancoDAO As New BancoDAO
        Cb_Banco.ValueMember = "ID"
        Cb_Banco.DisplayMember = "Nombre"
        Cb_Banco.DataSource = bancoDAO.VerBancos()
    End Sub
End Class