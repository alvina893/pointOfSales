Imports MySql.Data.MySqlClient
Module dbconnection
    Public conn As New MySqlConnection
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public i As Integer

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;username=root;password=;port=3306;database=db_pos"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server not connected!", vbExclamation)
        End Try
        Return result
    End Function
End Module
