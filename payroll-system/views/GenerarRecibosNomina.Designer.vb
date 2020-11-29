<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarRecibosNomina
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.BtnGenerarRecibo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DtpFechaPago
        '
        Me.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaPago.Location = New System.Drawing.Point(12, 26)
        Me.DtpFechaPago.Name = "DtpFechaPago"
        Me.DtpFechaPago.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaPago.TabIndex = 0
        '
        'BtnGenerarRecibo
        '
        Me.BtnGenerarRecibo.Location = New System.Drawing.Point(224, 23)
        Me.BtnGenerarRecibo.Name = "BtnGenerarRecibo"
        Me.BtnGenerarRecibo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerarRecibo.TabIndex = 1
        Me.BtnGenerarRecibo.Text = "Guardar"
        Me.BtnGenerarRecibo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha de Pago"
        '
        'GenerarRecibosNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 78)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGenerarRecibo)
        Me.Controls.Add(Me.DtpFechaPago)
        Me.Name = "GenerarRecibosNomina"
        Me.Text = "GenerarRecibosNomina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpFechaPago As DateTimePicker
    Friend WithEvents BtnGenerarRecibo As Button
    Friend WithEvents Label1 As Label
End Class
