Imports MySql.Data.MySqlClient

Public Module Mod_Models
    Public Class BarangRestock
        Public Property kode As String
        Public Property nama As String
        Public Property satuan As String
        Public Property harga As Decimal
        Public Property supplierID As String
        Public Property namaSupplier As String
    End Class

    Public Function ExecuteScalar(sql As String) As Object
        Try
            Dim cmd As New MySqlCommand(sql, conn)
            Dim result = cmd.ExecuteScalar()
            If result Is Nothing OrElse IsDBNull(result) Then
                Return 0
            End If
            Return result
        Catch ex As Exception
            MsgBox("ExecuteScalar Error: " & ex.Message)
            Return 0
        End Try
    End Function
End Module
