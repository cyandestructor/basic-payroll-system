<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarGerentes
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
        Me.CbEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnGerenteEmpresa = New System.Windows.Forms.Button()
        Me.BtnGerenteDpto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBonoGerente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CbEmpresas
        '
        Me.CbEmpresas.FormattingEnabled = True
        Me.CbEmpresas.Location = New System.Drawing.Point(12, 30)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Size = New System.Drawing.Size(186, 21)
        Me.CbEmpresas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empresa"
        '
        'CbDepartamentos
        '
        Me.CbDepartamentos.FormattingEnabled = True
        Me.CbDepartamentos.Location = New System.Drawing.Point(12, 77)
        Me.CbDepartamentos.Name = "CbDepartamentos"
        Me.CbDepartamentos.Size = New System.Drawing.Size(186, 21)
        Me.CbDepartamentos.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Departamento"
        '
        'CbEmpleados
        '
        Me.CbEmpleados.FormattingEnabled = True
        Me.CbEmpleados.Location = New System.Drawing.Point(12, 129)
        Me.CbEmpleados.Name = "CbEmpleados"
        Me.CbEmpleados.Size = New System.Drawing.Size(186, 21)
        Me.CbEmpleados.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Empleado"
        '
        'BtnGerenteEmpresa
        '
        Me.BtnGerenteEmpresa.Location = New System.Drawing.Point(224, 28)
        Me.BtnGerenteEmpresa.Name = "BtnGerenteEmpresa"
        Me.BtnGerenteEmpresa.Size = New System.Drawing.Size(194, 23)
        Me.BtnGerenteEmpresa.TabIndex = 2
        Me.BtnGerenteEmpresa.Text = "Asignar Gerente de Empresa"
        Me.BtnGerenteEmpresa.UseVisualStyleBackColor = True
        '
        'BtnGerenteDpto
        '
        Me.BtnGerenteDpto.Location = New System.Drawing.Point(224, 75)
        Me.BtnGerenteDpto.Name = "BtnGerenteDpto"
        Me.BtnGerenteDpto.Size = New System.Drawing.Size(194, 23)
        Me.BtnGerenteDpto.TabIndex = 2
        Me.BtnGerenteDpto.Text = "Asignar Gerente de Departamento"
        Me.BtnGerenteDpto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bono"
        '
        'TxtBonoGerente
        '
        Me.TxtBonoGerente.Location = New System.Drawing.Point(224, 130)
        Me.TxtBonoGerente.Name = "TxtBonoGerente"
        Me.TxtBonoGerente.Size = New System.Drawing.Size(194, 20)
        Me.TxtBonoGerente.TabIndex = 4
        '
        'AsignarGerentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 183)
        Me.Controls.Add(Me.TxtBonoGerente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnGerenteDpto)
        Me.Controls.Add(Me.BtnGerenteEmpresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbEmpleados)
        Me.Controls.Add(Me.CbDepartamentos)
        Me.Controls.Add(Me.CbEmpresas)
        Me.Name = "AsignarGerentes"
        Me.Text = "AsignarGerentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbEmpresas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbDepartamentos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbEmpleados As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnGerenteEmpresa As Button
    Friend WithEvents BtnGerenteDpto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBonoGerente As TextBox
End Class
