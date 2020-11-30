Public Class Vacaciones
    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        If DTP_InicioV.Value < DTP_FinV.Value Then
            SolicitarVacaciones()
        Else
            MsgBox("La fecha de inicio no puede ser después de la de fin")
        End If
    End Sub
    Private Sub SolicitarVacaciones()
        Dim idEmpleado = AppController.GetInstance().CurrentUser.ID
        Dim incidenciaDAO As New IncidenciaDAO

        Dim inicio = DTP_InicioV.Value
        Dim fin = DTP_FinV.Value

        If incidenciaDAO.VerificarVacaciones(idEmpleado, Date.Now.Year) Then
            Dim incidencia As New Incidencia With {
                .Descripcion = "Vacaciones",
                .MotivoSolicitud = "Vacaciones Anuales",
                .IDSolicitante = idEmpleado,
                .FechaSolicitud = Date.Now,
                .Inicio = inicio,
                .Fin = fin
            }
            If incidenciaDAO.Generar(incidencia) Then
                MsgBox("Se han solicitado las vacaciones")
            End If
        Else
            MsgBox("Ya se solicitaron vacaciones este año")
        End If
    End Sub
    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub
End Class