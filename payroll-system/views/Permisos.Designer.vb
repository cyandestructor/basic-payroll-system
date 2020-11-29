<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permisos
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
        Me.DTP_InicioPer = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FinPer = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Permiso = New System.Windows.Forms.TextBox()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMotivo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Día de inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Día de fin:"
        '
        'DTP_InicioPer
        '
        Me.DTP_InicioPer.Location = New System.Drawing.Point(88, 9)
        Me.DTP_InicioPer.Name = "DTP_InicioPer"
        Me.DTP_InicioPer.Size = New System.Drawing.Size(214, 20)
        Me.DTP_InicioPer.TabIndex = 2
        '
        'DTP_FinPer
        '
        Me.DTP_FinPer.Location = New System.Drawing.Point(88, 37)
        Me.DTP_FinPer.Name = "DTP_FinPer"
        Me.DTP_FinPer.Size = New System.Drawing.Size(214, 20)
        Me.DTP_FinPer.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'Txt_Permiso
        '
        Me.Txt_Permiso.Location = New System.Drawing.Point(12, 89)
        Me.Txt_Permiso.Name = "Txt_Permiso"
        Me.Txt_Permiso.Size = New System.Drawing.Size(290, 20)
        Me.Txt_Permiso.TabIndex = 5
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(227, 283)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ok.TabIndex = 6
        Me.Btn_Ok.Text = "Ok"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(146, 283)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 7
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Motivo:"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Location = New System.Drawing.Point(12, 145)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(290, 121)
        Me.TxtMotivo.TabIndex = 5
        '
        'Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 318)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.TxtMotivo)
        Me.Controls.Add(Me.Txt_Permiso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP_FinPer)
        Me.Controls.Add(Me.DTP_InicioPer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Permisos"
        Me.Text = "Permisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTP_InicioPer As DateTimePicker
    Friend WithEvents DTP_FinPer As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Permiso As TextBox
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMotivo As TextBox
End Class
