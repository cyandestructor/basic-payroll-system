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
        Me.Txt_DF_Emp = New System.Windows.Forms.TextBox()
        Me.Txt_RS_Emp = New System.Windows.Forms.TextBox()
        Me.Txt_NomEmp = New System.Windows.Forms.TextBox()
        Me.Btn_AgregarEmp = New System.Windows.Forms.Button()
        Me.DateTime_InicioOp = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.LB_Empresa = New System.Windows.Forms.ListBox()
        Me.Grid_Empresa = New System.Windows.Forms.DataGridView()
        CType(Me.Grid_Empresa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Location = New System.Drawing.Point(25, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio fiscal: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo electrónico:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Registro patronal: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "RFC:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha de inicio de operaciones: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Frecuencia de pago:"
        '
        'Txt_RFC_Emp
        '
        Me.Txt_RFC_Emp.Location = New System.Drawing.Point(124, 203)
        Me.Txt_RFC_Emp.Name = "Txt_RFC_Emp"
        Me.Txt_RFC_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_RFC_Emp.TabIndex = 9
        '
        'Txt_Pago_Emp
        '
        Me.Txt_Pago_Emp.Location = New System.Drawing.Point(136, 269)
        Me.Txt_Pago_Emp.Name = "Txt_Pago_Emp"
        Me.Txt_Pago_Emp.Size = New System.Drawing.Size(338, 20)
        Me.Txt_Pago_Emp.TabIndex = 11
        '
        'Txt_RP_Emp
        '
        Me.Txt_RP_Emp.Location = New System.Drawing.Point(124, 175)
        Me.Txt_RP_Emp.Name = "Txt_RP_Emp"
        Me.Txt_RP_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_RP_Emp.TabIndex = 12
        '
        'Txt_Correo_Emp
        '
        Me.Txt_Correo_Emp.Location = New System.Drawing.Point(124, 142)
        Me.Txt_Correo_Emp.Name = "Txt_Correo_Emp"
        Me.Txt_Correo_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_Correo_Emp.TabIndex = 13
        '
        'Txt_Tel_Emp
        '
        Me.Txt_Tel_Emp.Location = New System.Drawing.Point(124, 110)
        Me.Txt_Tel_Emp.Name = "Txt_Tel_Emp"
        Me.Txt_Tel_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_Tel_Emp.TabIndex = 14
        '
        'Txt_DF_Emp
        '
        Me.Txt_DF_Emp.Location = New System.Drawing.Point(124, 78)
        Me.Txt_DF_Emp.Name = "Txt_DF_Emp"
        Me.Txt_DF_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_DF_Emp.TabIndex = 15
        '
        'Txt_RS_Emp
        '
        Me.Txt_RS_Emp.Location = New System.Drawing.Point(124, 48)
        Me.Txt_RS_Emp.Name = "Txt_RS_Emp"
        Me.Txt_RS_Emp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_RS_Emp.TabIndex = 16
        '
        'Txt_NomEmp
        '
        Me.Txt_NomEmp.Location = New System.Drawing.Point(124, 19)
        Me.Txt_NomEmp.Name = "Txt_NomEmp"
        Me.Txt_NomEmp.Size = New System.Drawing.Size(350, 20)
        Me.Txt_NomEmp.TabIndex = 17
        '
        'Btn_AgregarEmp
        '
        Me.Btn_AgregarEmp.Location = New System.Drawing.Point(698, 549)
        Me.Btn_AgregarEmp.Name = "Btn_AgregarEmp"
        Me.Btn_AgregarEmp.Size = New System.Drawing.Size(87, 27)
        Me.Btn_AgregarEmp.TabIndex = 18
        Me.Btn_AgregarEmp.Text = "Agregar"
        Me.Btn_AgregarEmp.UseVisualStyleBackColor = True
        '
        'DateTime_InicioOp
        '
        Me.DateTime_InicioOp.Location = New System.Drawing.Point(192, 235)
        Me.DateTime_InicioOp.Name = "DateTime_InicioOp"
        Me.DateTime_InicioOp.Size = New System.Drawing.Size(282, 20)
        Me.DateTime_InicioOp.TabIndex = 19
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(595, 549)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(97, 27)
        Me.Btn_Cancelar.TabIndex = 30
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'LB_Empresa
        '
        Me.LB_Empresa.FormattingEnabled = True
        Me.LB_Empresa.Location = New System.Drawing.Point(494, 19)
        Me.LB_Empresa.Name = "LB_Empresa"
        Me.LB_Empresa.Size = New System.Drawing.Size(291, 264)
        Me.LB_Empresa.TabIndex = 31
        '
        'Grid_Empresa
        '
        Me.Grid_Empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Empresa.Location = New System.Drawing.Point(28, 307)
        Me.Grid_Empresa.Name = "Grid_Empresa"
        Me.Grid_Empresa.Size = New System.Drawing.Size(757, 221)
        Me.Grid_Empresa.TabIndex = 32
        '
        'Alta_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 600)
        Me.Controls.Add(Me.Grid_Empresa)
        Me.Controls.Add(Me.LB_Empresa)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.DateTime_InicioOp)
        Me.Controls.Add(Me.Btn_AgregarEmp)
        Me.Controls.Add(Me.Txt_NomEmp)
        Me.Controls.Add(Me.Txt_RS_Emp)
        Me.Controls.Add(Me.Txt_DF_Emp)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Alta_empresa"
        Me.Text = "Alta de Empresa"
        CType(Me.Grid_Empresa, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Txt_DF_Emp As TextBox
    Friend WithEvents Txt_RS_Emp As TextBox
    Friend WithEvents Txt_NomEmp As TextBox
    Friend WithEvents Btn_AgregarEmp As Button
    Friend WithEvents DateTime_InicioOp As DateTimePicker
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents LB_Empresa As ListBox
    Friend WithEvents Grid_Empresa As DataGridView
End Class
