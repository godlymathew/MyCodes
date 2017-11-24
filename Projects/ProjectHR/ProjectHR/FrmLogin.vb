Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If String.IsNullOrEmpty(TxtUserName.Text) Or String.IsNullOrEmpty(TxtUserName.Text) Then
            Utilities.MessageBox("Username and Password are required.")
            Exit Sub
        End If

        Dim frmMain = New FrmMaster()
        frmMain.Show()
        frmMain.Text = "ProjectHR"
        Me.Hide()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Application.Exit()
    End Sub
End Class
