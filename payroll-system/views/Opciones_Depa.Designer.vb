<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones_Depa
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
        Me.Txt_CodigoDepa = New System.Windows.Forms.TextBox()
        Me.Txt_NombreDepa = New System.Windows.Forms.TextBox()
        Me.Cb_Empresa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Sueldo = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.LB_Depa = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código del departamento: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del departamento:"
        '
        'Txt_CodigoDepa
        '
        Me.Txt_CodigoDepa.Location = New System.Drawing.Point(160, 208)
        Me.Txt_CodigoDepa.Name = "Txt_CodigoDepa"
        Me.Txt_CodigoDepa.Size = New System.Drawing.Size(301, 20)
        Me.Txt_CodigoDepa.TabIndex = 2
        '
        'Txt_NombreDepa
        '
        Me.Txt_NombreDepa.Location = New System.Drawing.Point(160, 243)
        Me.Txt_NombreDepa.Name = "Txt_NombreDepa"
        Me.Txt_NombreDepa.Size = New System.Drawing.Size(301, 20)
        Me.Txt_NombreDepa.TabIndex = 3
        '
        'Cb_Empresa
        '
        Me.Cb_Empresa.FormattingEnabled = True
        Me.Cb_Empresa.Location = New System.Drawing.Point(160, 279)
        Me.Cb_Empresa.Name = "Cb_Empresa"
        Me.Cb_Empresa.Size = New System.Drawing.Size(301, 21)
        Me.Cb_Empresa.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Empresa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sueldo base:"
        '
        'Txt_Sueldo
        '
        Me.Txt_Sueldo.Location = New System.Drawing.Point(161, 314)
        Me.Txt_Sueldo.Name = "Txt_Sueldo"
        Me.Txt_Sueldo.Size = New System.Drawing.Size(300, 20)
        Me.Txt_Sueldo.TabIndex = 7
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(373, 353)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(88, 27)
        Me.Btn_Agregar.TabIndex = 8
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(257, 353)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(97, 27)
        Me.Btn_Cancelar.TabIndex = 30
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'LB_Depa
        '
        Me.LB_Depa.FormattingEnabled = True
        Me.LB_Depa.Location = New System.Drawing.Point(25, 24)
        Me.LB_Depa.Name = "LB_Depa"
        Me.LB_Depa.Size = New System.Drawing.Size(435, 160)
        Me.LB_Depa.TabIndex = 9
        '
        'Opciones_Depa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 400)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.LB_Depa)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Sueldo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cb_Empresa)
        Me.Controls.Add(Me.Txt_NombreDepa)
        Me.Controls.Add(Me.Txt_CodigoDepa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Opciones_Depa"
        Me.Text = "Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_CodigoDepa As TextBox
    Friend WithEvents Txt_NombreDepa As TextBox
    Friend WithEvents Cb_Empresa As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Sueldo As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents LB_Depa As ListBox
End Class
