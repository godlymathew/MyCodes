Public Class FrmMaster
    Private FormCollection As List(Of String)
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Utilities.MessageBox("This is a sample project")
    End Sub

    Private Sub FrmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCollection = New List(Of String)
    End Sub

    Private Sub NationalitiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NationalitiesToolStripMenuItem.Click
        If Not IsFormExist("FrmNationality") Then
            Dim frm As New FrmNationality With {
                .MdiParent = Me,
                .StartPosition = FormStartPosition.CenterParent
            }
            frm.Show()
        End If

    End Sub

    Private Sub FrmMaster_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Function IsFormExist(ByVal frmName As String) As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = frmName Then
                f.Activate()
                f.Show()
                f.WindowState = FormWindowState.Normal
                Return True
            End If
        Next
        Return False
    End Function
End Class