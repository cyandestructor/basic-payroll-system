<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerReportes
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
        Me.DgvReporte = New System.Windows.Forms.DataGridView()
        Me.CbEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpYearMonth = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRNG = New System.Windows.Forms.Button()
        Me.BtnRN = New System.Windows.Forms.Button()
        Me.BtnHD = New System.Windows.Forms.Button()
        Me.BtnHP = New System.Windows.Forms.Button()
        CType(Me.DgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvReporte
        '
        Me.DgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporte.Location = New System.Drawing.Point(12, 104)
        Me.DgvReporte.Name = "DgvReporte"
        Me.DgvReporte.Size = New System.Drawing.Size(702, 299)
        Me.DgvReporte.TabIndex = 0
        '
        'CbEmpresas
        '
        Me.CbEmpresas.FormattingEnabled = True
        Me.CbEmpresas.Location = New System.Drawing.Point(12, 29)
        Me.CbEmpresas.Name = "CbEmpresas"
        Me.CbEmpresas.Size = New System.Drawing.Size(165, 21)
        Me.CbEmpresas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Resultados"
        '
        'DtpYearMonth
        '
        Me.DtpYearMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpYearMonth.Location = New System.Drawing.Point(354, 30)
        Me.DtpYearMonth.Name = "DtpYearMonth"
        Me.DtpYearMonth.Size = New System.Drawing.Size(115, 20)
        Me.DtpYearMonth.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mes/Año"
        '
        'CbDepartamentos
        '
        Me.CbDepartamentos.FormattingEnabled = True
        Me.CbDepartamentos.Location = New System.Drawing.Point(183, 29)
        Me.CbDepartamentos.Name = "CbDepartamentos"
        Me.CbDepartamentos.Size = New System.Drawing.Size(165, 21)
        Me.CbDepartamentos.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Departamento"
        '
        'BtnRNG
        '
        Me.BtnRNG.Location = New System.Drawing.Point(15, 56)
        Me.BtnRNG.Name = "BtnRNG"
        Me.BtnRNG.Size = New System.Drawing.Size(140, 23)
        Me.BtnRNG.TabIndex = 4
        Me.BtnRNG.Text = "Reporte Nómina General"
        Me.BtnRNG.UseVisualStyleBackColor = True
        '
        'BtnRN
        '
        Me.BtnRN.Location = New System.Drawing.Point(161, 56)
        Me.BtnRN.Name = "BtnRN"
        Me.BtnRN.Size = New System.Drawing.Size(140, 23)
        Me.BtnRN.TabIndex = 4
        Me.BtnRN.Text = "Reporte Nómina"
        Me.BtnRN.UseVisualStyleBackColor = True
        '
        'BtnHD
        '
        Me.BtnHD.Location = New System.Drawing.Point(307, 56)
        Me.BtnHD.Name = "BtnHD"
        Me.BtnHD.Size = New System.Drawing.Size(162, 23)
        Me.BtnHD.TabIndex = 4
        Me.BtnHD.Text = "Headcounter Departamentos"
        Me.BtnHD.UseVisualStyleBackColor = True
        '
        'BtnHP
        '
        Me.BtnHP.Location = New System.Drawing.Point(475, 56)
        Me.BtnHP.Name = "BtnHP"
        Me.BtnHP.Size = New System.Drawing.Size(140, 23)
        Me.BtnHP.TabIndex = 4
        Me.BtnHP.Text = "Headcounter Puestos"
        Me.BtnHP.UseVisualStyleBackColor = True
        '
        'VerReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 415)
        Me.Controls.Add(Me.BtnHD)
        Me.Controls.Add(Me.BtnHP)
        Me.Controls.Add(Me.BtnRN)
        Me.Controls.Add(Me.BtnRNG)
        Me.Controls.Add(Me.DtpYearMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbDepartamentos)
        Me.Controls.Add(Me.CbEmpresas)
        Me.Controls.Add(Me.DgvReporte)
        Me.Name = "VerReportes"
        Me.Text = "VerReportes"
        CType(Me.DgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvReporte As DataGridView
    Friend WithEvents CbEmpresas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpYearMonth As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents CbDepartamentos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRNG As Button
    Friend WithEvents BtnRN As Button
    Friend WithEvents BtnHD As Button
    Friend WithEvents BtnHP As Button
End Class
