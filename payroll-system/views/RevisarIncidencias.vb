Public Class RevisarIncidencias
    Private _currentUser As Usuario
    Private Sub RevisarIncidencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _currentUser = AppController.GetInstance().CurrentUser
        UpdateIncidencias()
        RbAutorizar.Checked = True
        ChkGoceSueldo.Checked = True
    End Sub
    Private Sub UpdateIncidencias()
        Dim incidenciaDAO As New IncidenciaDAO
        DgvIncidencias.DataSource = incidenciaDAO.VerIncidencias(True)
    End Sub
    Private Sub BtnRevisar_Click(sender As Object, e As EventArgs) Handles BtnRevisar.Click
        Dim selectedRows = DgvIncidencias.SelectedRows
        If selectedRows.Count > 0 Then
            For Each row As DataGridViewRow In selectedRows
                Dim idIncidencia = row.Cells(0).Value
                RevisarIncidencia(idIncidencia)
            Next
            If selectedRows.Count = 1 Then
                MsgBox("Se revisó una incidencia")
            Else
                MsgBox("Se revisaron " + selectedRows.Count.ToString() + " incidencias")
            End If
            UpdateIncidencias()
        Else
            MsgBox("No hay selección")
        End If
    End Sub
    Private Sub RevisarIncidencia(ByVal idIncidencia As Integer)
        Dim autorizado = RbAutorizar.Checked
        Dim goceSueldo = ChkGoceSueldo.Checked

        Dim incidencia As New Incidencia With {
            .ID = idIncidencia,
            .IDGerente = _currentUser.ID,
            .Estado = If(autorizado, 1, 2),
            .GoceSueldo = goceSueldo,
            .FechaRevision = Date.Now
        }

        Dim incidenciaDAO As New IncidenciaDAO
        incidenciaDAO.Revisar(incidencia)
    End Sub
End Class