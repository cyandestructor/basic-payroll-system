<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RevisarIncidencias
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
        Me.DgvIncidencias = New System.Windows.Forms.DataGridView()
        Me.RbAutorizar = New System.Windows.Forms.RadioButton()
        Me.RbRechazar = New System.Windows.Forms.RadioButton()
        Me.ChkGoceSueldo = New System.Windows.Forms.CheckBox()
        Me.BtnRevisar = New System.Windows.Forms.Button()
        CType(Me.DgvIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pendientes"
        '
        'DgvIncidencias
        '
        Me.DgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvIncidencias.Location = New System.Drawing.Point(12, 25)
        Me.DgvIncidencias.Name = "DgvIncidencias"
        Me.DgvIncidencias.ReadOnly = True
        Me.DgvIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvIncidencias.Size = New System.Drawing.Size(602, 150)
        Me.DgvIncidencias.TabIndex = 1
        '
        'RbAutorizar
        '
        Me.RbAutorizar.AutoSize = True
        Me.RbAutorizar.Location = New System.Drawing.Point(12, 194)
        Me.RbAutorizar.Name = "RbAutorizar"
        Me.RbAutorizar.Size = New System.Drawing.Size(66, 17)
        Me.RbAutorizar.TabIndex = 2
        Me.RbAutorizar.TabStop = True
        Me.RbAutorizar.Text = "Autorizar"
        Me.RbAutorizar.UseVisualStyleBackColor = True
        '
        'RbRechazar
        '
        Me.RbRechazar.AutoSize = True
        Me.RbRechazar.Location = New System.Drawing.Point(84, 194)
        Me.RbRechazar.Name = "RbRechazar"
        Me.RbRechazar.Size = New System.Drawing.Size(71, 17)
        Me.RbRechazar.TabIndex = 2
        Me.RbRechazar.TabStop = True
        Me.RbRechazar.Text = "Rechazar"
        Me.RbRechazar.UseVisualStyleBackColor = True
        '
        'ChkGoceSueldo
        '
        Me.ChkGoceSueldo.AutoSize = True
        Me.ChkGoceSueldo.Location = New System.Drawing.Point(161, 195)
        Me.ChkGoceSueldo.Name = "ChkGoceSueldo"
        Me.ChkGoceSueldo.Size = New System.Drawing.Size(85, 17)
        Me.ChkGoceSueldo.TabIndex = 3
        Me.ChkGoceSueldo.Text = "GoceSueldo"
        Me.ChkGoceSueldo.UseVisualStyleBackColor = True
        '
        'BtnRevisar
        '
        Me.BtnRevisar.Location = New System.Drawing.Point(271, 191)
        Me.BtnRevisar.Name = "BtnRevisar"
        Me.BtnRevisar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRevisar.TabIndex = 4
        Me.BtnRevisar.Text = "Revisar"
        Me.BtnRevisar.UseVisualStyleBackColor = True
        '
        'RevisarIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 245)
        Me.Controls.Add(Me.BtnRevisar)
        Me.Controls.Add(Me.ChkGoceSueldo)
        Me.Controls.Add(Me.RbRechazar)
        Me.Controls.Add(Me.RbAutorizar)
        Me.Controls.Add(Me.DgvIncidencias)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RevisarIncidencias"
        Me.Text = "RevisarIncidencias"
        CType(Me.DgvIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DgvIncidencias As DataGridView
    Friend WithEvents RbAutorizar As RadioButton
    Friend WithEvents RbRechazar As RadioButton
    Friend WithEvents ChkGoceSueldo As CheckBox
    Friend WithEvents BtnRevisar As Button
End Class
