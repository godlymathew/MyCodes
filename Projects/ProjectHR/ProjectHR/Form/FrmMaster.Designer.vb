<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaster
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AppMainMenu = New System.Windows.Forms.MenuStrip()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(864, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AppMainMenu
        '
        Me.AppMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.AppMainMenu.Name = "AppMainMenu"
        Me.AppMainMenu.Size = New System.Drawing.Size(864, 24)
        Me.AppMainMenu.TabIndex = 2
        Me.AppMainMenu.Text = "MenuStrip1"
        '
        'FrmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 467)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AppMainMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AppMainMenu
        Me.Name = "FrmMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AppMainMenu As MenuStrip
End Class
