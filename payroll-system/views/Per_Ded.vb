Public Class Per_Ded
    Private Sub Per_Ded_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleadoDAO As New EmpleadoDAO
        CB_Empleado.ValueMember = "ID"
        CB_Empleado.DisplayMember = "NombreCompleto"
        CB_Empleado.DataSource = empleadoDAO.VerEmpleados()

        RB_Percepcion.Checked = True

        InitEventHandlers()
    End Sub
    Private Sub InitEventHandlers()
        AddHandler Txt_MontoFijo.KeyPress, AddressOf UtilityController.DecimalOnly
        AddHandler Txt_Porcentaje.KeyPress, AddressOf UtilityController.DecimalOnly
    End Sub
    Private Function Validar() As Boolean
        Dim valido = True

        If CB_Empleado.SelectedIndex = -1 Then
            valido = False
        End If

        If Txt_Desc.Text = "" Or Txt_MontoFijo.Text = "" Or Txt_Porcentaje.Text = "" Then
            valido = False
        End If

        Return valido
    End Function
    Private Sub Btn_Generar_Click(sender As Object, e As EventArgs) Handles Btn_Generar.Click
        If Validar() Then
            If RB_Percepcion.Checked Then
                GenerarPercepcion()
            ElseIf RB_Deduccion.Checked Then
                GenerarDeduccion()
            End If
        Else
            MsgBox("La información no está completa")
        End If
    End Sub
    Private Sub GenerarPercepcion()
        Dim idEmpleado = CB_Empleado.SelectedValue

        Dim percepcion As New Percepcion With {
            .Descripcion = Txt_Desc.Text,
            .CantidadFija = Double.Parse(Txt_MontoFijo.Text),
            .CantidadPorcentual = Double.Parse(Txt_Porcentaje.Text) / 100,
            .IDEmpleado = idEmpleado
        }

        Dim percepcionDAO As New PercepcionDAO
        If percepcionDAO.Generar(percepcion) Then
            MsgBox("Se generó la percepción exitosamente")
            ClearAll()
        End If
    End Sub
    Private Sub GenerarDeduccion()
        Dim idEmpleado = CB_Empleado.SelectedValue

        Dim deduccion As New Deduccion With {
            .Descripcion = Txt_Desc.Text,
            .CantidadFija = Double.Parse(Txt_MontoFijo.Text),
            .CantidadPorcentual = Double.Parse(Txt_Porcentaje.Text) / 100,
            .IDEmpleado = idEmpleado
        }

        Dim deduccionDAO As New DeduccionDAO
        If deduccionDAO.Generar(deduccion) Then
            MsgBox("Se generó la deducción exitosamente")
            ClearAll()
        End If
    End Sub
    Private Sub ClearAll()
        Txt_Desc.Text = ""
        Txt_MontoFijo.Text = ""
        Txt_Porcentaje.Text = ""
    End Sub
    Private Sub Btn_VerLista_Click(sender As Object, e As EventArgs) Handles Btn_VerLista.Click
        If RB_Percepcion.Checked Then
            VerPercepciones()
        ElseIf RB_Deduccion.Checked Then
            VerDeducciones()
        End If
    End Sub
    Private Sub VerPercepciones()
        Dim percepcionDAO As New PercepcionDAO
        Grid_Lista.DataSource = percepcionDAO.VerTodas()
    End Sub
    Private Sub VerDeducciones()
        Dim deduccionDAO As New DeduccionDAO
        Grid_Lista.DataSource = deduccionDAO.VerTodas()
    End Sub
End Class