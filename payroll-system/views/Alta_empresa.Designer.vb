<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_empresa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_RFC_Emp = New System.Windows.Forms.TextBox()
        Me.Txt_Pago_Emp = New System.Windows.Forms.TextBox()
        Me.Txt_RP_Emp = New System.Windows.Forms.TextBox()
        Me.Txt_Correo_Emp = New System.Windows.Forms.TextBox()
        Me.Txt_Tel_Emp = New System.Windows.Forms.TextBox()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.Txt_RS_Emp = New System.Windows.Forms.TextBox()
        Me.Txt_NomEmp = New System.Windows.Forms.TextBox()
        Me.Btn_AgregarEmp = New System.Windows.Forms.Button()
        Me.DateTime_InicioOp = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.LB_Empresa = New System.Windows.Forms.ListBox()
        Me.GpbDomicilio = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtColonia = New System.Windows.Forms.TextBox()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.BtnEditarEmpresa = New System.Windows.Forms.Button()
        Me.BtnEliminarEmpresa = New System.Windows.Forms.Button()
        Me.GpbDomicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Razón social: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Calle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo electrónico:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Registro patronal: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "RFC:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha de inicio de operaciones: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Frecuencia de pago:"
        '
        'Txt_RFC_Emp
        '
        Me.Txt_RFC_Emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_RFC_Emp.Location = New System.Drawing.Point(124, 167)
        Me.Txt_RFC_Emp.MaxLength = 12
        Me.Txt_RFC_Emp.Name = "Txt_RFC_Emp"
        Me.Txt_RFC_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_RFC_Emp.TabIndex = 6
        '
        'Txt_Pago_Emp
        '
        Me.Txt_Pago_Emp.Location = New System.Drawing.Point(136, 233)
        Me.Txt_Pago_Emp.MaxLength = 3
        Me.Txt_Pago_Emp.Name = "Txt_Pago_Emp"
        Me.Txt_Pago_Emp.Size = New System.Drawing.Size(338, 20)
        Me.Txt_Pago_Emp.TabIndex = 8
        '
        'Txt_RP_Emp
        '
        Me.Txt_RP_Emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_RP_Emp.Location = New System.Drawing.Point(124, 139)
        Me.Txt_RP_Emp.MaxLength = 11
        Me.Txt_RP_Emp.Name = "Txt_RP_Emp"
        Me.Txt_RP_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_RP_Emp.TabIndex = 5
        '
        'Txt_Correo_Emp
        '
        Me.Txt_Correo_Emp.Location = New System.Drawing.Point(124, 106)
        Me.Txt_Correo_Emp.MaxLength = 50
        Me.Txt_Correo_Emp.Name = "Txt_Correo_Emp"
        Me.Txt_Correo_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_Correo_Emp.TabIndex = 4
        '
        'Txt_Tel_Emp
        '
        Me.Txt_Tel_Emp.Location = New System.Drawing.Point(124, 74)
        Me.Txt_Tel_Emp.MaxLength = 10
        Me.Txt_Tel_Emp.Name = "Txt_Tel_Emp"
        Me.Txt_Tel_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_Tel_Emp.TabIndex = 3
        '
        'TxtCalle
        '
        Me.TxtCalle.Location = New System.Drawing.Point(44, 33)
        Me.TxtCalle.MaxLength = 30
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(221, 20)
        Me.TxtCalle.TabIndex = 9
        '
        'Txt_RS_Emp
        '
        Me.Txt_RS_Emp.Location = New System.Drawing.Point(124, 48)
        Me.Txt_RS_Emp.MaxLength = 80
        Me.Txt_RS_Emp.Name = "Txt_RS_Emp"
        Me.Txt_RS_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_RS_Emp.TabIndex = 2
        '
        'Txt_NomEmp
        '
        Me.Txt_NomEmp.Location = New System.Drawing.Point(124, 19)
        Me.Txt_NomEmp.MaxLength = 60
        Me.Txt_NomEmp.Name = "Txt_NomEmp"
        Me.Txt_NomEmp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_NomEmp.TabIndex = 1
        '
        'Btn_AgregarEmp
        '
        Me.Btn_AgregarEmp.Location = New System.Drawing.Point(700, 391)
        Me.Btn_AgregarEmp.Name = "Btn_AgregarEmp"
        Me.Btn_AgregarEmp.Size = New System.Drawing.Size(87, 27)
        Me.Btn_AgregarEmp.TabIndex = 15
        Me.Btn_AgregarEmp.Text = "Registrar"
        Me.Btn_AgregarEmp.UseVisualStyleBackColor = True
        '
        'DateTime_InicioOp
        '
        Me.DateTime_InicioOp.Location = New System.Drawing.Point(192, 199)
        Me.DateTime_InicioOp.Name = "DateTime_InicioOp"
        Me.DateTime_InicioOp.Size = New System.Drawing.Size(282, 20)
        Me.DateTime_InicioOp.TabIndex = 7
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(494, 391)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(97, 27)
        Me.Btn_Cancelar.TabIndex = 17
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'LB_Empresa
        '
        Me.LB_Empresa.FormattingEnabled = True
        Me.LB_Empresa.Location = New System.Drawing.Point(494, 19)
        Me.LB_Empresa.Name = "LB_Empresa"
        Me.LB_Empresa.Size = New System.Drawing.Size(291, 238)
        Me.LB_Empresa.TabIndex = 19
        '
        'GpbDomicilio
        '
        Me.GpbDomicilio.Controls.Add(Me.Label12)
        Me.GpbDomicilio.Controls.Add(Me.Label11)
        Me.GpbDomicilio.Controls.Add(Me.Label14)
        Me.GpbDomicilio.Controls.Add(Me.Label10)
        Me.GpbDomicilio.Controls.Add(Me.Label13)
        Me.GpbDomicilio.Controls.Add(Me.Label3)
        Me.GpbDomicilio.Controls.Add(Me.TxtCP)
        Me.GpbDomicilio.Controls.Add(Me.TxtNumero)
        Me.GpbDomicilio.Controls.Add(Me.TxtEstado)
        Me.GpbDomicilio.Controls.Add(Me.TxtColonia)
        Me.GpbDomicilio.Controls.Add(Me.TxtMunicipio)
        Me.GpbDomicilio.Controls.Add(Me.TxtCalle)
        Me.GpbDomicilio.Location = New System.Drawing.Point(28, 272)
        Me.GpbDomicilio.Name = "GpbDomicilio"
        Me.GpbDomicilio.Size = New System.Drawing.Size(757, 100)
        Me.GpbDomicilio.TabIndex = 33
        Me.GpbDomicilio.TabStop = False
        Me.GpbDomicilio.Text = "Domicilio Fiscal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(281, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(435, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Colonia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(601, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "C.P."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(279, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Numero"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Municipio"
        '
        'TxtCP
        '
        Me.TxtCP.Location = New System.Drawing.Point(634, 59)
        Me.TxtCP.MaxLength = 8
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(100, 20)
        Me.TxtCP.TabIndex = 14
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(329, 33)
        Me.TxtNumero.MaxLength = 8
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(90, 20)
        Me.TxtNumero.TabIndex = 10
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(329, 59)
        Me.TxtEstado.MaxLength = 30
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(249, 20)
        Me.TxtEstado.TabIndex = 13
        '
        'TxtColonia
        '
        Me.TxtColonia.Location = New System.Drawing.Point(483, 33)
        Me.TxtColonia.MaxLength = 30
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(251, 20)
        Me.TxtColonia.TabIndex = 11
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.Location = New System.Drawing.Point(64, 59)
        Me.TxtMunicipio.MaxLength = 30
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Size = New System.Drawing.Size(201, 20)
        Me.TxtMunicipio.TabIndex = 12
        '
        'BtnEditarEmpresa
        '
        Me.BtnEditarEmpresa.Location = New System.Drawing.Point(597, 391)
        Me.BtnEditarEmpresa.Name = "BtnEditarEmpresa"
        Me.BtnEditarEmpresa.Size = New System.Drawing.Size(97, 27)
        Me.BtnEditarEmpresa.TabIndex = 16
        Me.BtnEditarEmpresa.Text = "Editar"
        Me.BtnEditarEmpresa.UseVisualStyleBackColor = True
        '
        'BtnEliminarEmpresa
        '
        Me.BtnEliminarEmpresa.Location = New System.Drawing.Point(391, 391)
        Me.BtnEliminarEmpresa.Name = "BtnEliminarEmpresa"
        Me.BtnEliminarEmpresa.Size = New System.Drawing.Size(97, 27)
        Me.BtnEliminarEmpresa.TabIndex = 18
        Me.BtnEliminarEmpresa.Text = "Eliminar"
        Me.BtnEliminarEmpresa.UseVisualStyleBackColor = True
        '
        'Alta_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 427)
        Me.Controls.Add(Me.LB_Empresa)
        Me.Controls.Add(Me.BtnEditarEmpresa)
        Me.Controls.Add(Me.BtnEliminarEmpresa)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.DateTime_InicioOp)
        Me.Controls.Add(Me.Btn_AgregarEmp)
        Me.Controls.Add(Me.Txt_NomEmp)
        Me.Controls.Add(Me.Txt_RS_Emp)
        Me.Controls.Add(Me.Txt_Tel_Emp)
        Me.Controls.Add(Me.Txt_Correo_Emp)
        Me.Controls.Add(Me.Txt_RP_Emp)
        Me.Controls.Add(Me.Txt_Pago_Emp)
        Me.Controls.Add(Me.Txt_RFC_Emp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GpbDomicilio)
        Me.Name = "Alta_empresa"
        Me.Text = "Alta de Empresa"
        Me.GpbDomicilio.ResumeLayout(False)
        Me.GpbDomicilio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_RFC_Emp As TextBox
    Friend WithEvents Txt_Pago_Emp As TextBox
    Friend WithEvents Txt_RP_Emp As TextBox
    Friend WithEvents Txt_Correo_Emp As TextBox
    Friend WithEvents Txt_Tel_Emp As TextBox
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents Txt_RS_Emp As TextBox
    Friend WithEvents Txt_NomEmp As TextBox
    Friend WithEvents Btn_AgregarEmp As Button
    Friend WithEvents DateTime_InicioOp As DateTimePicker
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents LB_Empresa As ListBox
    Friend WithEvents GpbDomicilio As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtColonia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtCP As TextBox
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents BtnEditarEmpresa As Button
    Friend WithEvents BtnEliminarEmpresa As Button
End Class
