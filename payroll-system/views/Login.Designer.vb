<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.Btn_Ingresar = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.LblNuevaPassword = New System.Windows.Forms.Label()
        Me.TxtNuevaPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(104, 30)
        Me.Txt_User.MaxLength = 8
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(295, 20)
        Me.Txt_User.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña: "
        '
        'Txt_Password
        '
        Me.Txt_Password.Location = New System.Drawing.Point(104, 67)
        Me.Txt_Password.MaxLength = 20
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Password.Size = New System.Drawing.Size(295, 20)
        Me.Txt_Password.TabIndex = 3
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.Location = New System.Drawing.Point(276, 142)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.Size = New System.Drawing.Size(123, 24)
        Me.Btn_Ingresar.TabIndex = 5
        Me.Btn_Ingresar.Text = "Ingresar"
        Me.Btn_Ingresar.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(30, 142)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(123, 24)
        Me.Btn_Edit.TabIndex = 6
        Me.Btn_Edit.Text = "Editar"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        Me.Btn_Edit.Visible = False
        '
        'LblNuevaPassword
        '
        Me.LblNuevaPassword.AutoSize = True
        Me.LblNuevaPassword.Location = New System.Drawing.Point(43, 105)
        Me.LblNuevaPassword.Name = "LblNuevaPassword"
        Me.LblNuevaPassword.Size = New System.Drawing.Size(42, 13)
        Me.LblNuevaPassword.TabIndex = 2
        Me.LblNuevaPassword.Text = "Nueva:"
        Me.LblNuevaPassword.Visible = False
        '
        'TxtNuevaPassword
        '
        Me.TxtNuevaPassword.Location = New System.Drawing.Point(104, 102)
        Me.TxtNuevaPassword.MaxLength = 20
        Me.TxtNuevaPassword.Name = "TxtNuevaPassword"
        Me.TxtNuevaPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNuevaPassword.Size = New System.Drawing.Size(295, 20)
        Me.TxtNuevaPassword.TabIndex = 4
        Me.TxtNuevaPassword.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 198)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Btn_Ingresar)
        Me.Controls.Add(Me.TxtNuevaPassword)
        Me.Controls.Add(Me.LblNuevaPassword)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_User)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Btn_Ingresar As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents LblNuevaPassword As Label
    Friend WithEvents TxtNuevaPassword As TextBox
End Class
