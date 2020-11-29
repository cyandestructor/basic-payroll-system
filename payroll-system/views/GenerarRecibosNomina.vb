Public Class GenerarRecibosNomina
    Private Sub BtnGenerarRecibo_Click(sender As Object, e As EventArgs) Handles BtnGenerarRecibo.Click
        Dim fechaPago = DtpFechaPago.Value
        Dim idEmpleado = AppController.GetInstance().CurrentUser.ID

        Dim reciboDAO As New ReciboNominaDAO
        Dim recibo = reciboDAO.GenerarRecibo(idEmpleado, fechaPago)
        If recibo IsNot Nothing Then
            GuardarReciboNomina(recibo)
        Else
            MsgBox("No hay un recibo correspondiente a esa fecha")
        End If
    End Sub
    Private Sub GuardarReciboNomina(ByVal recibo As ReciboNomina)
        Using sfd As New SaveFileDialog
            sfd.Filter = "PDF | *.pdf"
            sfd.ValidateNames = True
            If sfd.ShowDialog() = DialogResult.OK Then
                CrearReciboPDF(sfd.FileName, recibo)
            End If
        End Using
    End Sub
    Private Function CrearReciboPDF(ByVal filename As String, ByVal recibo As ReciboNomina) As Boolean
        Dim percepcionDAO As New PercepcionDAO
        Dim deduccionDAO As New DeduccionDAO

        Dim percepciones = percepcionDAO.VerDeNomina(recibo.DatosNomina.ID)
        Dim deducciones = deduccionDAO.VerDeNomina(recibo.DatosNomina.ID)

        Return False
    End Function
End Class