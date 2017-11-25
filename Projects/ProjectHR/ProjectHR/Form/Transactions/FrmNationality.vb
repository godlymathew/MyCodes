Imports System.ComponentModel
Imports System.Data.SqlClient
Imports BusinessLayer

Public Class FrmNationality

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        InsertNationality()
    End Sub

    Private Sub InsertNationality()

        Dim dataFunction As New DataFunctions()


        Dim paramCollection As New Dictionary(Of String, Object) From {
            {"Name", TxtNationality.Text},
            {"Active", ChbActive.Checked}
        }

        Dim sqlCon As New SqlConnection(Data.GetConnectionString)

        Dim Result As Boolean = dataFunction.ExecuteNonQuery(sqlCon,
                                                             "InsertNationality",
                                                             paramCollection)


        SelectNationality(sqlCon)



        'Using sqlCon = New SqlConnection(Data.GetConnectionString)
        '    Using SqlCom = New SqlCommand("InsertNationality", sqlCon)
        '        SqlCom.CommandType = CommandType.StoredProcedure
        '        SqlCom.Parameters.AddWithValue("@Name", TxtNationality.Text)
        '        SqlCom.Parameters.AddWithValue("@Active", ChbActive.Checked)
        '        If sqlCon.State = ConnectionState.Closed Then
        '            sqlCon.Open()
        '        End If
        '        Try
        '            SqlCom.ExecuteNonQuery()
        '            SelectNationality(sqlCon)
        '        Catch ex As Exception
        '            Utilities.MessageBox(ex.Message)
        '        End Try
        '    End Using
        'End Using
    End Sub

    Private Sub SelectNationality()
        SelectNationality(New SqlConnection(Data.GetConnectionString))
    End Sub

    Private Sub SelectNationality(ByRef sqlCon As SqlConnection)

        Dim dataFunction As New DataFunctions()

        Dim dataSet = dataFunction.ExecuteQuery(sqlCon, "SelectNationality", Nothing)



        If dataSet IsNot Nothing And dataSet.Tables.Count > 0 Then
            DGVNationality.DataSource = dataSet.Tables(0)
            DGVNationality.AutoResizeColumn(1)
            DGVNationality.Columns(0).ReadOnly = True
            DGVNationality.Columns(1).ReadOnly = True
        Else
            If Not String.IsNullOrEmpty(dataFunction.Exception) Then
                Utilities.MessageBox(dataFunction.Exception)
            End If
        End If



    End Sub

    Private Sub FrmNationality_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectNationality()
    End Sub
End Class