<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadoForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Nomina = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Password = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnConsultarPagos = New System.Windows.Forms.Button()
        Me.DtpYear = New System.Windows.Forms.DateTimePicker()
        Me.DgvResumen = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuSolicitarPermiso = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVacaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosToolStripMenuItem, Me.Menu_Permisos, Me.UsuarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(759, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Nomina})
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.PermisosToolStripMenuItem.Text = "Generar"
        '
        'Menu_Nomina
        '
        Me.Menu_Nomina.Name = "Menu_Nomina"
        Me.Menu_Nomina.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Nomina.Text = "Recibos de nomina"
        '
        'Menu_Permisos
        '
        Me.Menu_Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSolicitarPermiso, Me.MenuVacaciones})
        Me.Menu_Permisos.Name = "Menu_Permisos"
        Me.Menu_Permisos.Size = New System.Drawing.Size(67, 20)
        Me.Menu_Permisos.Text = "Permisos"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Password})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'Menu_Password
        '
        Me.Menu_Password.Name = "Menu_Password"
        Me.Menu_Password.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Password.Text = "Editar contraseña"
        '
        'BtnConsultarPagos
        '
        Me.BtnConsultarPagos.Location = New System.Drawing.Point(309, 31)
        Me.BtnConsultarPagos.Name = "BtnConsultarPagos"
        Me.BtnConsultarPagos.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultarPagos.TabIndex = 44
        Me.BtnConsultarPagos.Text = "Consultar"
        Me.BtnConsultarPagos.UseVisualStyleBackColor = True
        '
        'DtpYear
        '
        Me.DtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpYear.Location = New System.Drawing.Point(195, 34)
        Me.DtpYear.Name = "DtpYear"
        Me.DtpYear.Size = New System.Drawing.Size(88, 20)
        Me.DtpYear.TabIndex = 43
        '
        'DgvResumen
        '
        Me.DgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResumen.Location = New System.Drawing.Point(12, 62)
        Me.DgvResumen.Name = "DgvResumen"
        Me.DgvResumen.ReadOnly = True
        Me.DgvResumen.Size = New System.Drawing.Size(734, 264)
        Me.DgvResumen.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Resumen de pagos"
        '
        'MenuSolicitarPermiso
        '
        Me.MenuSolicitarPermiso.Name = "MenuSolicitarPermiso"
        Me.MenuSolicitarPermiso.Size = New System.Drawing.Size(180, 22)
        Me.MenuSolicitarPermiso.Text = "Solicitar"
        '
        'MenuVacaciones
        '
        Me.MenuVacaciones.Name = "MenuVacaciones"
        Me.MenuVacaciones.Size = New System.Drawing.Size(180, 22)
        Me.MenuVacaciones.Text = "Vacaciones"
        '
        'EmpleadoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 501)
        Me.Controls.Add(Me.BtnConsultarPagos)
        Me.Controls.Add(Me.DtpYear)
        Me.Controls.Add(Me.DgvResumen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmpleadoForm"
        Me.Text = "Empleado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Nomina As ToolStripMenuItem
    Friend WithEvents Menu_Permisos As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Password As ToolStripMenuItem
    Friend WithEvents BtnConsultarPagos As Button
    Friend WithEvents DtpYear As DateTimePicker
    Friend WithEvents DgvResumen As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuSolicitarPermiso As ToolStripMenuItem
    Friend WithEvents MenuVacaciones As ToolStripMenuItem
End Class
