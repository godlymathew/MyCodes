Public Class Utilities

    Public Shared Sub MessageBox(ByVal messsage As String)
        System.Windows.Forms.MessageBox.Show(messsage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub
End Class
