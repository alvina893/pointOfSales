Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class migrate

    Public Function HashPassword(password As String, ByRef salt As String) As String
        ' Generate 16-byte salt
        Dim saltBytes(15) As Byte
        Using rng = New RNGCryptoServiceProvider()
            rng.GetBytes(saltBytes)
        End Using

        salt = Convert.ToBase64String(saltBytes)

        ' Hash with PBKDF2 (10.000 iterations)
        Using pbkdf2 As New Rfc2898DeriveBytes(password, saltBytes, 10000)
            Dim hashBytes = pbkdf2.GetBytes(32) ' 256-bit hash
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function


    ' ==============================
    '     MIGRASI PASSWORD
    ' ==============================
    Private Sub btnMigrate_Click(sender As Object, e As EventArgs) Handles btnMigrate.Click
        Try
            conn.Open()

            ' 1. Ambil semua user (plaintext password)
            Dim cmdSelect As New MySqlCommand("SELECT user_ID, password FROM tbluser", conn)
            Dim dr As MySqlDataReader = cmdSelect.ExecuteReader()

            Dim users As New List(Of Tuple(Of Integer, String))()

            While dr.Read()
                users.Add(New Tuple(Of Integer, String)(dr("user_ID"), dr("password").ToString()))
            End While
            dr.Close()

            ' 2. Migrasi satu per satu
            For Each u In users
                Dim id = u.Item1
                Dim plainPass = u.Item2

                Dim salt As String = ""
                Dim hash As String = HashPassword(plainPass, salt)

                Dim cmdUpdate As New MySqlCommand(
                "UPDATE tbluser 
                 SET password_hash=@h, password_salt=@s 
                 WHERE user_ID=@id", conn)

                cmdUpdate.Parameters.AddWithValue("@h", hash)
                cmdUpdate.Parameters.AddWithValue("@s", salt)
                cmdUpdate.Parameters.AddWithValue("@id", id)

                cmdUpdate.ExecuteNonQuery()
            Next

            MsgBox("Migrasi password selesai!", vbInformation)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub migrate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
End Class
