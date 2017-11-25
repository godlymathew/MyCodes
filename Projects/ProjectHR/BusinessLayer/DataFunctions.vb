Imports System.Data.SqlClient

Public Class DataFunctions
    Private _exception As String
    Public Property Exception() As String
        Get
            Return _exception
        End Get
        Set(ByVal value As String)
            _exception = value
        End Set
    End Property
    Public Function ExecuteQuery(sqlCon As SqlConnection,
                                 sqlCommandText As String,
                                 sqlParams As Dictionary(Of String, Object)) As DataSet


        Using SqlCom = New SqlCommand(sqlCommandText, sqlCon)
            SqlCom.CommandType = CommandType.StoredProcedure
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            If sqlParams IsNot Nothing Then
                For Each key As String In sqlParams.Keys
                    SqlCom.Parameters.AddWithValue("@" + key, sqlParams(key))
                Next
            End If
            Try
                Dim dataSet As New DataSet()
                Dim sqlAdapter As New SqlDataAdapter With {
                    .SelectCommand = SqlCom
                }
                sqlAdapter.Fill(dataSet)
                Return dataSet
            Catch ex As Exception
                Exception = ex.Message
            End Try
        End Using
        Return Nothing
    End Function

    Public Function ExecuteNonQuery(sqlCon As SqlConnection,
                                 sqlCommandText As String,
                                 sqlParams As Dictionary(Of String, Object)) As Boolean


        Using SqlCom = New SqlCommand(sqlCommandText, sqlCon)
            SqlCom.CommandType = CommandType.StoredProcedure
            If sqlCon.State = ConnectionState.Closed Then
                sqlCon.Open()
            End If
            If sqlParams IsNot Nothing Then
                For Each key As String In sqlParams.Keys
                    SqlCom.Parameters.AddWithValue("@" + key, sqlParams(key))
                Next
            End If
            Try
                SqlCom.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Exception = ex.Message
            End Try
        End Using
        Return False
    End Function
End Class
