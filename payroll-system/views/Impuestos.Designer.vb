<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impuestos
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
        Me.TxtModificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCantISR = New System.Windows.Forms.TextBox()
        Me.TxtPorcISR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCantIMSS = New System.Windows.Forms.TextBox()
        Me.TxtPorcIMSS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtModificar
        '
        Me.TxtModificar.Location = New System.Drawing.Point(231, 48)
        Me.TxtModificar.Name = "TxtModificar"
        Me.TxtModificar.Size = New System.Drawing.Size(75, 23)
        Me.TxtModificar.TabIndex = 0
        Me.TxtModificar.Text = "Modificar"
        Me.TxtModificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISR"
        '
        'TxtCantISR
        '
        Me.TxtCantISR.Location = New System.Drawing.Point(43, 25)
        Me.TxtCantISR.Name = "TxtCantISR"
        Me.TxtCantISR.Size = New System.Drawing.Size(78, 20)
        Me.TxtCantISR.TabIndex = 2
        '
        'TxtPorcISR
        '
        Me.TxtPorcISR.Location = New System.Drawing.Point(43, 50)
        Me.TxtPorcISR.Name = "TxtPorcISR"
        Me.TxtPorcISR.Size = New System.Drawing.Size(78, 20)
        Me.TxtPorcISR.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IMSS"
        '
        'TxtCantIMSS
        '
        Me.TxtCantIMSS.Location = New System.Drawing.Point(136, 25)
        Me.TxtCantIMSS.Name = "TxtCantIMSS"
        Me.TxtCantIMSS.Size = New System.Drawing.Size(78, 20)
        Me.TxtCantIMSS.TabIndex = 2
        '
        'TxtPorcIMSS
        '
        Me.TxtPorcIMSS.Location = New System.Drawing.Point(136, 50)
        Me.TxtPorcIMSS.Name = "TxtPorcIMSS"
        Me.TxtPorcIMSS.Size = New System.Drawing.Size(78, 20)
        Me.TxtPorcIMSS.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "%"
        '
        'Impuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 93)
        Me.Controls.Add(Me.TxtPorcIMSS)
        Me.Controls.Add(Me.TxtPorcISR)
        Me.Controls.Add(Me.TxtCantIMSS)
        Me.Controls.Add(Me.TxtCantISR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtModificar)
        Me.Name = "Impuestos"
        Me.Text = "Impuestos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtModificar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCantISR As TextBox
    Friend WithEvents TxtPorcISR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCantIMSS As TextBox
    Friend WithEvents TxtPorcIMSS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
