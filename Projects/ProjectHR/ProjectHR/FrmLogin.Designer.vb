<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(103, 87)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(184, 87)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(103, 27)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(210, 20)
        Me.TxtUserName.TabIndex = 4
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(103, 53)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(210, 20)
        Me.TxtPassword.TabIndex = 5
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 135)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project HR Login "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
End Class
