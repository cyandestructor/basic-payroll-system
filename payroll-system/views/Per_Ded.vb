Public Class Per_Ded
    Private Sub Per_Ded_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateEmpresas()
        RB_Percepcion.Checked = True
        InitEventHandlers()
    End Sub
    Private Sub UpdateEmpresas()
        Dim empresaDAO As New EmpresaDAO
        CbEmpresas.ValueMember = "RFC"
        CbEmpresas.DisplayMember = "Nombre"
        CbEmpresas.DataSource = empresaDAO.VerEmpresas()
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
            Dim idEmpleado = CB_Empleado.SelectedValue
            If RB_Percepcion.Checked Then
                If GenerarPercepcion(idEmpleado) Then
                    MsgBox("Se generó la percepción exitosamente")
                    ClearAll()
                End If
            ElseIf RB_Deduccion.Checked Then
                If GenerarDeduccion(idEmpleado) Then
                    MsgBox("Se generó la deducción exitosamente")
                    ClearAll()
                End If
            End If
        Else
            MsgBox("La información no está completa")
        End If
    End Sub
    Private Function GenerarPercepcion(ByVal idEmpleado As Integer) As Boolean

        Dim fecha = DtpFecha.Value

        Dim percepcion As New Percepcion With {
            .Descripcion = Txt_Desc.Text,
            .CantidadFija = Double.Parse(Txt_MontoFijo.Text),
            .CantidadPorcentual = Double.Parse(Txt_Porcentaje.Text) / 100,
            .IDEmpleado = idEmpleado,
            .Fecha = fecha
        }

        Dim percepcionDAO As New PercepcionDAO
        If percepcionDAO.Generar(percepcion) Then
            Return True
        End If

        Return False
    End Function
    Private Function GenerarDeduccion(ByVal idEmpleado As Integer) As Boolean

        Dim fecha = DtpFecha.Value

        Dim deduccion As New Deduccion With {
            .Descripcion = Txt_Desc.Text,
            .CantidadFija = Double.Parse(Txt_MontoFijo.Text),
            .CantidadPorcentual = Double.Parse(Txt_Porcentaje.Text) / 100,
            .IDEmpleado = idEmpleado,
            .Fecha = fecha
        }

        Dim deduccionDAO As New DeduccionDAO
        If deduccionDAO.Generar(deduccion) Then
            Return True
        End If

        Return False
    End Function
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
    Private Sub CbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbEmpresas.SelectedIndexChanged
        If CbEmpresas.SelectedIndex <> -1 Then
            Dim empleadoDAO As New EmpleadoDAO
            CB_Empleado.ValueMember = "ID"
            CB_Empleado.DisplayMember = "NombreCompleto"
            CB_Empleado.DataSource = empleadoDAO.VerEmpleadosEmpresa(CbEmpresas.SelectedValue)
        Else
            CB_Empleado.DataSource = Nothing
        End If
    End Sub
    Private Sub BtnGenerarTodos_Click(sender As Object, e As EventArgs) Handles BtnGenerarTodos.Click
        If CbEmpresas.SelectedIndex <> -1 And Validar() Then
            Dim idEmpresa = CbEmpresas.SelectedValue
            If RB_Percepcion.Checked Then
                GenerarPercepcionGeneral(idEmpresa)
                MsgBox("Se generó una percepción para todos los empleados de la empresa")
                ClearAll()
            ElseIf RB_Deduccion.Checked Then
                GenerarDeduccionGeneral(idEmpresa)
                MsgBox("Se generó una deducción para todos los empleados de la empresa")
                ClearAll()
            End If
        Else
            MsgBox("La información está incompleta")
        End If
    End Sub
    Private Sub GenerarPercepcionGeneral(ByVal idEmpresa As String)
        Dim empleadoDAO As New EmpleadoDAO
        Dim empleados = empleadoDAO.VerEmpleadosEmpresa(idEmpresa)
        For Each empleado As Empleado In empleados
            GenerarPercepcion(empleado.ID)
        Next
    End Sub
    Private Sub GenerarDeduccionGeneral(ByVal idEmpresa As String)
        Dim empleadoDAO As New EmpleadoDAO
        Dim empleados = empleadoDAO.VerEmpleadosEmpresa(idEmpresa)
        For Each empleado As Empleado In empleados
            GenerarDeduccion(empleado.ID)
        Next
    End Sub
End Class