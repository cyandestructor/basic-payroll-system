<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Per_Ded
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
        Me.CB_Empleado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Desc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_MontoFijo = New System.Windows.Forms.TextBox()
        Me.Txt_Porcentaje = New System.Windows.Forms.TextBox()
        Me.RB_Percepcion = New System.Windows.Forms.RadioButton()
        Me.RB_Deduccion = New System.Windows.Forms.RadioButton()
        Me.Btn_Generar = New System.Windows.Forms.Button()
        Me.Btn_VerLista = New System.Windows.Forms.Button()
        Me.Grid_Lista = New System.Windows.Forms.DataGridView()
        CType(Me.Grid_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'CB_Empleado
        '
        Me.CB_Empleado.FormattingEnabled = True
        Me.CB_Empleado.Location = New System.Drawing.Point(85, 20)
        Me.CB_Empleado.Name = "CB_Empleado"
        Me.CB_Empleado.Size = New System.Drawing.Size(254, 21)
        Me.CB_Empleado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion:"
        '
        'Txt_Desc
        '
        Me.Txt_Desc.Location = New System.Drawing.Point(85, 58)
        Me.Txt_Desc.Multiline = True
        Me.Txt_Desc.Name = "Txt_Desc"
        Me.Txt_Desc.Size = New System.Drawing.Size(254, 151)
        Me.Txt_Desc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monto fijo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Porcentaje:"
        '
        'Txt_MontoFijo
        '
        Me.Txt_MontoFijo.Location = New System.Drawing.Point(423, 55)
        Me.Txt_MontoFijo.Name = "Txt_MontoFijo"
        Me.Txt_MontoFijo.Size = New System.Drawing.Size(160, 20)
        Me.Txt_MontoFijo.TabIndex = 6
        '
        'Txt_Porcentaje
        '
        Me.Txt_Porcentaje.Location = New System.Drawing.Point(423, 87)
        Me.Txt_Porcentaje.Name = "Txt_Porcentaje"
        Me.Txt_Porcentaje.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Porcentaje.TabIndex = 7
        '
        'RB_Percepcion
        '
        Me.RB_Percepcion.AutoSize = True
        Me.RB_Percepcion.Location = New System.Drawing.Point(455, 122)
        Me.RB_Percepcion.Name = "RB_Percepcion"
        Me.RB_Percepcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RB_Percepcion.Size = New System.Drawing.Size(79, 18)
        Me.RB_Percepcion.TabIndex = 8
        Me.RB_Percepcion.TabStop = True
        Me.RB_Percepcion.Text = "Percepción"
        Me.RB_Percepcion.UseCompatibleTextRendering = True
        Me.RB_Percepcion.UseVisualStyleBackColor = True
        '
        'RB_Deduccion
        '
        Me.RB_Deduccion.AutoSize = True
        Me.RB_Deduccion.Location = New System.Drawing.Point(455, 145)
        Me.RB_Deduccion.Name = "RB_Deduccion"
        Me.RB_Deduccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RB_Deduccion.Size = New System.Drawing.Size(77, 17)
        Me.RB_Deduccion.TabIndex = 9
        Me.RB_Deduccion.TabStop = True
        Me.RB_Deduccion.Text = "Deducción"
        Me.RB_Deduccion.UseVisualStyleBackColor = True
        '
        'Btn_Generar
        '
        Me.Btn_Generar.Location = New System.Drawing.Point(359, 181)
        Me.Btn_Generar.Name = "Btn_Generar"
        Me.Btn_Generar.Size = New System.Drawing.Size(107, 28)
        Me.Btn_Generar.TabIndex = 10
        Me.Btn_Generar.Text = "Generar"
        Me.Btn_Generar.UseVisualStyleBackColor = True
        '
        'Btn_VerLista
        '
        Me.Btn_VerLista.Location = New System.Drawing.Point(476, 181)
        Me.Btn_VerLista.Name = "Btn_VerLista"
        Me.Btn_VerLista.Size = New System.Drawing.Size(107, 28)
        Me.Btn_VerLista.TabIndex = 11
        Me.Btn_VerLista.Text = "Ver Lista"
        Me.Btn_VerLista.UseVisualStyleBackColor = True
        '
        'Grid_Lista
        '
        Me.Grid_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Lista.Location = New System.Drawing.Point(16, 229)
        Me.Grid_Lista.Name = "Grid_Lista"
        Me.Grid_Lista.Size = New System.Drawing.Size(567, 202)
        Me.Grid_Lista.TabIndex = 36
        '
        'Per_Ded
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 450)
        Me.Controls.Add(Me.Grid_Lista)
        Me.Controls.Add(Me.Btn_VerLista)
        Me.Controls.Add(Me.Btn_Generar)
        Me.Controls.Add(Me.RB_Deduccion)
        Me.Controls.Add(Me.RB_Percepcion)
        Me.Controls.Add(Me.Txt_Porcentaje)
        Me.Controls.Add(Me.Txt_MontoFijo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_Empleado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Per_Ded"
        Me.Text = "Percepciones y Deducciones"
        CType(Me.Grid_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Empleado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Desc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_MontoFijo As TextBox
    Friend WithEvents Txt_Porcentaje As TextBox
    Friend WithEvents RB_Percepcion As RadioButton
    Friend WithEvents RB_Deduccion As RadioButton
    Friend WithEvents Btn_Generar As Button
    Friend WithEvents Btn_VerLista As Button
    Friend WithEvents Grid_Lista As DataGridView
End Class
