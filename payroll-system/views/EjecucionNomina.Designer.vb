<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EjecucionNomina
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
        Me.DgvReporteCalculo = New System.Windows.Forms.DataGridView()
        Me.BtnEjecutar = New System.Windows.Forms.Button()
        Me.BtnGenerarReporte = New System.Windows.Forms.Button()
        CType(Me.DgvReporteCalculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbEmpresas
        '
        Me.CbEmpresas.FormattingEnabled = True
        Me.CbEmpresas.Location = New System.Drawing.Point(12, 30)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Size = New System.Drawing.Size(168, 21)
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
        'DgvReporteCalculo
        '
        Me.DgvReporteCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporteCalculo.Location = New System.Drawing.Point(15, 74)
        Me.DgvReporteCalculo.Name = "DgvReporteCalculo"
        Me.DgvReporteCalculo.ReadOnly = True
        Me.DgvReporteCalculo.Size = New System.Drawing.Size(546, 242)
        Me.DgvReporteCalculo.TabIndex = 2
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(196, 28)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEjecutar.TabIndex = 3
        Me.BtnEjecutar.Text = "Calcular"
        Me.BtnEjecutar.UseVisualStyleBackColor = True
        '
        'BtnGenerarReporte
        '
        Me.BtnGenerarReporte.Location = New System.Drawing.Point(277, 28)
        Me.BtnGenerarReporte.Name = "BtnGenerarReporte"
        Me.BtnGenerarReporte.Size = New System.Drawing.Size(101, 23)
        Me.BtnGenerarReporte.TabIndex = 3
        Me.BtnGenerarReporte.Text = "Generar Reporte"
        Me.BtnGenerarReporte.UseVisualStyleBackColor = True
        '
        'EjecucionNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 328)
        Me.Controls.Add(Me.BtnGenerarReporte)
        Me.Controls.Add(Me.BtnEjecutar)
        Me.Controls.Add(Me.DgvReporteCalculo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbEmpresas)
        Me.Name = "EjecucionNomina"
        Me.Text = "EjecucionNomina"
        CType(Me.DgvReporteCalculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbEmpresas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvReporteCalculo As DataGridView
    Friend WithEvents BtnEjecutar As Button
    Friend WithEvents BtnGenerarReporte As Button
End Class
