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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Nomina = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Vacaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_InfoUsu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Password = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Pagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_Pagos = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(452, 194)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosToolStripMenuItem, Me.Menu_Permisos, Me.Menu_Vacaciones, Me.UsuarioToolStripMenuItem, Me.Menu_Pagos})
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
        Me.Menu_Nomina.Size = New System.Drawing.Size(175, 22)
        Me.Menu_Nomina.Text = "Recibos de nomina"
        '
        'Menu_Permisos
        '
        Me.Menu_Permisos.Name = "Menu_Permisos"
        Me.Menu_Permisos.Size = New System.Drawing.Size(67, 20)
        Me.Menu_Permisos.Text = "Permisos"
        '
        'Menu_Vacaciones
        '
        Me.Menu_Vacaciones.Name = "Menu_Vacaciones"
        Me.Menu_Vacaciones.Size = New System.Drawing.Size(77, 20)
        Me.Menu_Vacaciones.Text = "Vacaciones"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_InfoUsu, Me.Menu_Password})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'Menu_InfoUsu
        '
        Me.Menu_InfoUsu.Name = "Menu_InfoUsu"
        Me.Menu_InfoUsu.Size = New System.Drawing.Size(165, 22)
        Me.Menu_InfoUsu.Text = "Información"
        '
        'Menu_Password
        '
        Me.Menu_Password.Name = "Menu_Password"
        Me.Menu_Password.Size = New System.Drawing.Size(165, 22)
        Me.Menu_Password.Text = "Editar contraseña"
        '
        'Menu_Pagos
        '
        Me.Menu_Pagos.Name = "Menu_Pagos"
        Me.Menu_Pagos.Size = New System.Drawing.Size(51, 20)
        Me.Menu_Pagos.Text = "Pagos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Reportes de Nomina:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(14, 48)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(450, 202)
        Me.DataGridView2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Información general:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pagos:"
        '
        'LB_Pagos
        '
        Me.LB_Pagos.FormattingEnabled = True
        Me.LB_Pagos.Location = New System.Drawing.Point(484, 48)
        Me.LB_Pagos.Name = "LB_Pagos"
        Me.LB_Pagos.Size = New System.Drawing.Size(263, 433)
        Me.LB_Pagos.TabIndex = 32
        '
        'EmpleadoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 501)
        Me.Controls.Add(Me.LB_Pagos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmpleadoForm"
        Me.Text = "Empleado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Nomina As ToolStripMenuItem
    Friend WithEvents Menu_Permisos As ToolStripMenuItem
    Friend WithEvents Menu_Vacaciones As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_InfoUsu As ToolStripMenuItem
    Friend WithEvents Menu_Password As ToolStripMenuItem
    Friend WithEvents Menu_Pagos As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LB_Pagos As ListBox
End Class
