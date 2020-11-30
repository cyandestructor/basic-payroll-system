Public Class Permisos
    Private _currentUser As Usuario
    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _currentUser = AppController.GetInstance().CurrentUser
    End Sub
    Private Function Validar() As Boolean
        Dim valido = True

        If DTP_InicioPer.Value > DTP_FinPer.Value Then
            valido = False
        End If

        If Txt_Permiso.Text = "" Or TxtMotivo.Text = "" Then
            valido = False
        End If

        Return valido
    End Function
    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        If Validar() Then
            Dim incidencia As New Incidencia With {
                .IDSolicitante = _currentUser.ID,
                .Descripcion = Txt_Permiso.Text,
                .MotivoSolicitud = TxtMotivo.Text,
                .Inicio = DTP_InicioPer.Value,
                .Fin = DTP_FinPer.Value,
                .FechaSolicitud = Date.Now
            }

            Dim incidenciaDAO As New IncidenciaDAO
            If incidenciaDAO.Generar(incidencia) Then
                MsgBox("Se ha registrada la incidencia")
                ClearAll()
            End If
        Else
            MsgBox("La información está incorrecta o incompleta")
        End If
    End Sub
    Private Sub ClearAll()
        Txt_Permiso.Text = ""
        TxtMotivo.Text = ""
        DTP_InicioPer.Value = Date.Now
        DTP_FinPer.Value = Date.Now
    End Sub
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub
End Class