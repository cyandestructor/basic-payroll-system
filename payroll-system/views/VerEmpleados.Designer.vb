<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerEmpleados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbEmpleados = New System.Windows.Forms.ListBox()
        Me.BtnSeleccion = New System.Windows.Forms.Button()
        Me.CbEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbPuestos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        Me.BtnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleados"
        '
        'LbEmpleados
        '
        Me.LbEmpleados.FormattingEnabled = True
        Me.LbEmpleados.Location = New System.Drawing.Point(12, 25)
        Me.LbEmpleados.Name = "LbEmpleados"
        Me.LbEmpleados.Size = New System.Drawing.Size(215, 303)
        Me.LbEmpleados.TabIndex = 1
        '
        'BtnSeleccion
        '
        Me.BtnSeleccion.Location = New System.Drawing.Point(233, 25)
        Me.BtnSeleccion.Name = "BtnSeleccion"
        Me.BtnSeleccion.Size = New System.Drawing.Size(95, 23)
        Me.BtnSeleccion.TabIndex = 2
        Me.BtnSeleccion.Text = "Ver Selección"
        Me.BtnSeleccion.UseVisualStyleBackColor = True
        '
        'CbEmpresas
        '
        Me.CbEmpresas.FormattingEnabled = True
        Me.CbEmpresas.Location = New System.Drawing.Point(233, 71)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Size = New System.Drawing.Size(210, 21)
        Me.CbEmpresas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Empresa"
        '
        'CbDepartamentos
        '
        Me.CbDepartamentos.FormattingEnabled = True
        Me.CbDepartamentos.Location = New System.Drawing.Point(233, 115)
        Me.CbDepartamentos.Name = "CbDepartamentos"
        Me.CbDepartamentos.Size = New System.Drawing.Size(210, 21)
        Me.CbDepartamentos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Departamento"
        '
        'CbPuestos
        '
        Me.CbPuestos.FormattingEnabled = True
        Me.CbPuestos.Location = New System.Drawing.Point(233, 166)
        Me.CbPuestos.Name = "CbPuestos"
        Me.CbPuestos.Size = New System.Drawing.Size(210, 21)
        Me.CbPuestos.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Puesto"
        '
        'BtnAsignar
        '
        Me.BtnAsignar.Location = New System.Drawing.Point(233, 203)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(95, 23)
        Me.BtnAsignar.TabIndex = 2
        Me.BtnAsignar.Text = "Asignar Posición"
        Me.BtnAsignar.UseVisualStyleBackColor = True
        '
        'BtnEliminarEmpleado
        '
        Me.BtnEliminarEmpleado.Location = New System.Drawing.Point(233, 304)
        Me.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado"
        Me.BtnEliminarEmpleado.Size = New System.Drawing.Size(95, 23)
        Me.BtnEliminarEmpleado.TabIndex = 5
        Me.BtnEliminarEmpleado.Text = "Eliminar"
        Me.BtnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'VerEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 339)
        Me.Controls.Add(Me.BtnEliminarEmpleado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbPuestos)
        Me.Controls.Add(Me.CbDepartamentos)
        Me.Controls.Add(Me.CbEmpresas)
        Me.Controls.Add(Me.BtnAsignar)
        Me.Controls.Add(Me.BtnSeleccion)
        Me.Controls.Add(Me.LbEmpleados)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VerEmpleados"
        Me.Text = "VerEmpleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LbEmpleados As ListBox
    Friend WithEvents BtnSeleccion As Button
    Friend WithEvents CbEmpresas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbDepartamentos As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbPuestos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnAsignar As Button
    Friend WithEvents BtnEliminarEmpleado As Button
End Class
