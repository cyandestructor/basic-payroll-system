<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacaciones
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
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Txt_Permiso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_FinV = New System.Windows.Forms.DateTimePicker()
        Me.DTP_InicioV = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(148, 244)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 15
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(229, 244)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ok.TabIndex = 14
        Me.Btn_Ok.Text = "Ok"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'Txt_Permiso
        '
        Me.Txt_Permiso.Location = New System.Drawing.Point(14, 93)
        Me.Txt_Permiso.Multiline = True
        Me.Txt_Permiso.Name = "Txt_Permiso"
        Me.Txt_Permiso.Size = New System.Drawing.Size(290, 145)
        Me.Txt_Permiso.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Descripción:"
        '
        'DTP_FinV
        '
        Me.DTP_FinV.Location = New System.Drawing.Point(90, 41)
        Me.DTP_FinV.Name = "DTP_FinV"
        Me.DTP_FinV.Size = New System.Drawing.Size(214, 20)
        Me.DTP_FinV.TabIndex = 11
        '
        'DTP_InicioV
        '
        Me.DTP_InicioV.Location = New System.Drawing.Point(90, 13)
        Me.DTP_InicioV.Name = "DTP_InicioV"
        Me.DTP_InicioV.Size = New System.Drawing.Size(214, 20)
        Me.DTP_InicioV.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Día de fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Día de inicio:"
        '
        'Vacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 278)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.Txt_Permiso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP_FinV)
        Me.Controls.Add(Me.DTP_InicioV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Vacaciones"
        Me.Text = "Vacaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents Txt_Permiso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DTP_FinV As DateTimePicker
    Friend WithEvents DTP_InicioV As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
