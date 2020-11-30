<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones_puesto
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
        Me.Txt_CodPuesto = New System.Windows.Forms.TextBox()
        Me.Txt_NomPuesto = New System.Windows.Forms.TextBox()
        Me.Btn_Registrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_PorSueldo = New System.Windows.Forms.TextBox()
        Me.Cb_Depa = New System.Windows.Forms.ComboBox()
        Me.BtnEliminarPuesto = New System.Windows.Forms.Button()
        Me.LB_Puesto = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cb_Empresa = New System.Windows.Forms.ComboBox()
        Me.BtnAsignarEmpDpto = New System.Windows.Forms.Button()
        Me.BtnEditarPuesto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del puesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código del puesto:"
        '
        'Txt_CodPuesto
        '
        Me.Txt_CodPuesto.Location = New System.Drawing.Point(160, 207)
        Me.Txt_CodPuesto.Name = "Txt_CodPuesto"
        Me.Txt_CodPuesto.ReadOnly = True
        Me.Txt_CodPuesto.Size = New System.Drawing.Size(305, 20)
        Me.Txt_CodPuesto.TabIndex = 2
        '
        'Txt_NomPuesto
        '
        Me.Txt_NomPuesto.Location = New System.Drawing.Point(160, 240)
        Me.Txt_NomPuesto.MaxLength = 20
        Me.Txt_NomPuesto.Name = "Txt_NomPuesto"
        Me.Txt_NomPuesto.Size = New System.Drawing.Size(305, 20)
        Me.Txt_NomPuesto.TabIndex = 3
        '
        'Btn_Registrar
        '
        Me.Btn_Registrar.Location = New System.Drawing.Point(369, 383)
        Me.Btn_Registrar.Name = "Btn_Registrar"
        Me.Btn_Registrar.Size = New System.Drawing.Size(96, 27)
        Me.Btn_Registrar.TabIndex = 4
        Me.Btn_Registrar.Text = "Registrar"
        Me.Btn_Registrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Departamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Porcentaje del sueldo:"
        '
        'Txt_PorSueldo
        '
        Me.Txt_PorSueldo.Location = New System.Drawing.Point(160, 341)
        Me.Txt_PorSueldo.Name = "Txt_PorSueldo"
        Me.Txt_PorSueldo.Size = New System.Drawing.Size(305, 20)
        Me.Txt_PorSueldo.TabIndex = 7
        '
        'Cb_Depa
        '
        Me.Cb_Depa.FormattingEnabled = True
        Me.Cb_Depa.Location = New System.Drawing.Point(160, 308)
        Me.Cb_Depa.Name = "Cb_Depa"
        Me.Cb_Depa.Size = New System.Drawing.Size(305, 21)
        Me.Cb_Depa.TabIndex = 8
        '
        'BtnEliminarPuesto
        '
        Me.BtnEliminarPuesto.Location = New System.Drawing.Point(61, 383)
        Me.BtnEliminarPuesto.Name = "BtnEliminarPuesto"
        Me.BtnEliminarPuesto.Size = New System.Drawing.Size(97, 27)
        Me.BtnEliminarPuesto.TabIndex = 30
        Me.BtnEliminarPuesto.Text = "Eliminar"
        Me.BtnEliminarPuesto.UseVisualStyleBackColor = True
        '
        'LB_Puesto
        '
        Me.LB_Puesto.FormattingEnabled = True
        Me.LB_Puesto.Location = New System.Drawing.Point(44, 27)
        Me.LB_Puesto.Name = "LB_Puesto"
        Me.LB_Puesto.Size = New System.Drawing.Size(420, 160)
        Me.LB_Puesto.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Empresa:"
        '
        'Cb_Empresa
        '
        Me.Cb_Empresa.FormattingEnabled = True
        Me.Cb_Empresa.Location = New System.Drawing.Point(160, 275)
        Me.Cb_Empresa.Name = "Cb_Empresa"
        Me.Cb_Empresa.Size = New System.Drawing.Size(305, 21)
        Me.Cb_Empresa.TabIndex = 32
        '
        'BtnAsignarEmpDpto
        '
        Me.BtnAsignarEmpDpto.Location = New System.Drawing.Point(267, 383)
        Me.BtnAsignarEmpDpto.Name = "BtnAsignarEmpDpto"
        Me.BtnAsignarEmpDpto.Size = New System.Drawing.Size(96, 27)
        Me.BtnAsignarEmpDpto.TabIndex = 4
        Me.BtnAsignarEmpDpto.Text = "Agregar"
        Me.BtnAsignarEmpDpto.UseVisualStyleBackColor = True
        '
        'BtnEditarPuesto
        '
        Me.BtnEditarPuesto.Location = New System.Drawing.Point(164, 383)
        Me.BtnEditarPuesto.Name = "BtnEditarPuesto"
        Me.BtnEditarPuesto.Size = New System.Drawing.Size(97, 27)
        Me.BtnEditarPuesto.TabIndex = 34
        Me.BtnEditarPuesto.Text = "Editar"
        Me.BtnEditarPuesto.UseVisualStyleBackColor = True
        '
        'Opciones_puesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 416)
        Me.Controls.Add(Me.BtnEditarPuesto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cb_Empresa)
        Me.Controls.Add(Me.LB_Puesto)
        Me.Controls.Add(Me.BtnEliminarPuesto)
        Me.Controls.Add(Me.Cb_Depa)
        Me.Controls.Add(Me.Txt_PorSueldo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAsignarEmpDpto)
        Me.Controls.Add(Me.Btn_Registrar)
        Me.Controls.Add(Me.Txt_NomPuesto)
        Me.Controls.Add(Me.Txt_CodPuesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Opciones_puesto"
        Me.Text = "Opciones de Puesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_CodPuesto As TextBox
    Friend WithEvents Txt_NomPuesto As TextBox
    Friend WithEvents Btn_Registrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_PorSueldo As TextBox
    Friend WithEvents Cb_Depa As ComboBox
    Friend WithEvents BtnEliminarPuesto As Button
    Friend WithEvents LB_Puesto As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cb_Empresa As ComboBox
    Friend WithEvents BtnAsignarEmpDpto As Button
    Friend WithEvents BtnEditarPuesto As Button
End Class
