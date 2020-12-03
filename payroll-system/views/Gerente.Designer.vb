<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente
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
        Me.Menu_PD = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSolicitarPermiso = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVacaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRevisarPermisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Password = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Puesto = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Departamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Empresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAsignarGerentes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuImpuestos = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCalcularNomina = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvResumen = New System.Windows.Forms.DataGridView()
        Me.DtpYear = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConsultarPagos = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosToolStripMenuItem, Me.Menu_Permisos, Me.UsuarioToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.VerToolStripMenuItem, Me.MenuCalcularNomina, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(758, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Nomina, Me.Menu_PD})
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.PermisosToolStripMenuItem.Text = "Generar"
        '
        'Menu_Nomina
        '
        Me.Menu_Nomina.Name = "Menu_Nomina"
        Me.Menu_Nomina.Size = New System.Drawing.Size(224, 22)
        Me.Menu_Nomina.Text = "Recibos de nomina"
        '
        'Menu_PD
        '
        Me.Menu_PD.Name = "Menu_PD"
        Me.Menu_PD.Size = New System.Drawing.Size(224, 22)
        Me.Menu_PD.Text = "Percepciones y Deducciones"
        '
        'Menu_Permisos
        '
        Me.Menu_Permisos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSolicitarPermiso, Me.MenuVacaciones, Me.menuRevisarPermisos})
        Me.Menu_Permisos.Name = "Menu_Permisos"
        Me.Menu_Permisos.Size = New System.Drawing.Size(67, 20)
        Me.Menu_Permisos.Text = "Permisos"
        '
        'menuSolicitarPermiso
        '
        Me.menuSolicitarPermiso.Name = "menuSolicitarPermiso"
        Me.menuSolicitarPermiso.Size = New System.Drawing.Size(132, 22)
        Me.menuSolicitarPermiso.Text = "Solicitar"
        '
        'MenuVacaciones
        '
        Me.MenuVacaciones.Name = "MenuVacaciones"
        Me.MenuVacaciones.Size = New System.Drawing.Size(132, 22)
        Me.MenuVacaciones.Text = "Vacaciones"
        '
        'menuRevisarPermisos
        '
        Me.menuRevisarPermisos.Name = "menuRevisarPermisos"
        Me.menuRevisarPermisos.Size = New System.Drawing.Size(132, 22)
        Me.menuRevisarPermisos.Text = "Revisar"
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
        Me.Menu_Password.Size = New System.Drawing.Size(165, 22)
        Me.Menu_Password.Text = "Editar contraseña"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Puesto, Me.Menu_Departamento, Me.Menu_Empresa, Me.Menu_Empleado, Me.MenuAsignarGerentes, Me.MenuImpuestos})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'Menu_Puesto
        '
        Me.Menu_Puesto.Name = "Menu_Puesto"
        Me.Menu_Puesto.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Puesto.Text = "Puesto"
        '
        'Menu_Departamento
        '
        Me.Menu_Departamento.Name = "Menu_Departamento"
        Me.Menu_Departamento.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Departamento.Text = "Departamento"
        '
        'Menu_Empresa
        '
        Me.Menu_Empresa.Name = "Menu_Empresa"
        Me.Menu_Empresa.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Empresa.Text = "Empresa"
        '
        'Menu_Empleado
        '
        Me.Menu_Empleado.Name = "Menu_Empleado"
        Me.Menu_Empleado.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Empleado.Text = "Empleado"
        '
        'MenuAsignarGerentes
        '
        Me.MenuAsignarGerentes.Name = "MenuAsignarGerentes"
        Me.MenuAsignarGerentes.Size = New System.Drawing.Size(180, 22)
        Me.MenuAsignarGerentes.Text = "Gerentes"
        '
        'MenuImpuestos
        '
        Me.MenuImpuestos.Name = "MenuImpuestos"
        Me.MenuImpuestos.Size = New System.Drawing.Size(180, 22)
        Me.MenuImpuestos.Text = "Impuestos"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'MenuCalcularNomina
        '
        Me.MenuCalcularNomina.Name = "MenuCalcularNomina"
        Me.MenuCalcularNomina.Size = New System.Drawing.Size(108, 20)
        Me.MenuCalcularNomina.Text = "Calcular Nomina"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Resumen de pagos"
        '
        'DgvResumen
        '
        Me.DgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResumen.Location = New System.Drawing.Point(12, 60)
        Me.DgvResumen.Name = "DgvResumen"
        Me.DgvResumen.ReadOnly = True
        Me.DgvResumen.Size = New System.Drawing.Size(734, 264)
        Me.DgvResumen.TabIndex = 37
        '
        'DtpYear
        '
        Me.DtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpYear.Location = New System.Drawing.Point(195, 32)
        Me.DtpYear.Name = "DtpYear"
        Me.DtpYear.Size = New System.Drawing.Size(88, 20)
        Me.DtpYear.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Año"
        '
        'BtnConsultarPagos
        '
        Me.BtnConsultarPagos.Location = New System.Drawing.Point(309, 29)
        Me.BtnConsultarPagos.Name = "BtnConsultarPagos"
        Me.BtnConsultarPagos.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultarPagos.TabIndex = 39
        Me.BtnConsultarPagos.Text = "Consultar"
        Me.BtnConsultarPagos.UseVisualStyleBackColor = True
        '
        'Gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 485)
        Me.Controls.Add(Me.BtnConsultarPagos)
        Me.Controls.Add(Me.DtpYear)
        Me.Controls.Add(Me.DgvResumen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Gerente"
        Me.Text = "Gerente"
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
    Friend WithEvents Menu_PD As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Puesto As ToolStripMenuItem
    Friend WithEvents Menu_Departamento As ToolStripMenuItem
    Friend WithEvents Menu_Empresa As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Menu_Empleado As ToolStripMenuItem
    Friend WithEvents menuSolicitarPermiso As ToolStripMenuItem
    Friend WithEvents menuRevisarPermisos As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAsignarGerentes As ToolStripMenuItem
    Friend WithEvents MenuCalcularNomina As ToolStripMenuItem
    Friend WithEvents MenuVacaciones As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvResumen As DataGridView
    Friend WithEvents DtpYear As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnConsultarPagos As Button
    Friend WithEvents MenuImpuestos As ToolStripMenuItem
End Class
