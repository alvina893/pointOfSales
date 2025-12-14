Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Text

Public Class frm_ManageUsers

    Public Function HashPassword(password As String, ByRef salt As String) As String
        ' Generate salt 16 byte
        Dim saltBytes(15) As Byte
        Using rng = New RNGCryptoServiceProvider()
            rng.GetBytes(saltBytes)
        End Using

        salt = Convert.ToBase64String(saltBytes)

        ' Derive key
        Using pbkdf2 As New Rfc2898DeriveBytes(password, saltBytes, 10000)
            Dim hashBytes = pbkdf2.GetBytes(32) ' 256-bit hash
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Public Function VerifyPassword(password As String, savedHash As String, savedSalt As String) As Boolean
        Dim saltBytes = Convert.FromBase64String(savedSalt)

        Using pbkdf2 As New Rfc2898DeriveBytes(password, saltBytes, 10000)
            Dim hashBytes = pbkdf2.GetBytes(32)
            Dim newHash = Convert.ToBase64String(hashBytes)

            Return newHash = savedHash
        End Using
    End Function


    Dim selectedUserID As Integer = -1

    Private Sub frm_ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        load_Users()

        dgv_Users.RowTemplate.Height = 30

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want
    End Sub

    Sub clear()
        txtName.Clear()
        txtPass.Clear()
        txtUsername.Clear()
        cboRole.SelectedIndex = -1
    End Sub

    Sub load_Users()
        dgv_Users.Rows.Clear()
        Try
            conn.Open()

            Dim sql As String =
            "SELECT user_ID, name, username, password_hash, password_salt, role
             FROM tbluser"

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            While dr.Read
                dgv_Users.Rows.Add(
                dgv_Users.Rows.Count + 1,
                dr("user_ID"),
                dr("name"),
                dr("username"),
                dr("password_hash"),
                dr("password_salt"),
                dr("role")
            )
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub btnRegisUser_Click(sender As Object, e As EventArgs) Handles btnRegisUser.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Or
       String.IsNullOrWhiteSpace(txtUsername.Text) Or
       String.IsNullOrWhiteSpace(txtPass.Text) Or
       String.IsNullOrWhiteSpace(cboRole.Text) Then

            MsgBox("Data user tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        Try
            conn.Open()

            ' --- 1. Generate password hash & salt ---
            Dim salt As String = ""
            Dim hash As String = HashPassword(txtPass.Text, salt)

            ' --- 2. Insert user baru ---
            Dim sql As String =
            "INSERT INTO tbluser(name, username, password_hash, password_salt, role) 
             VALUES (@name, @username, @hash, @salt, @role)"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@hash", hash)
            cmd.Parameters.AddWithValue("@salt", salt)
            cmd.Parameters.AddWithValue("@role", cboRole.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Pengguna (User) baru berhasil didaftar!", vbInformation)
            Else
                MsgBox("Pengguna (User) gagal didaftar!", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' --- 3. Bersihkan input + reload tabel ---
        clear()
        load_Users()
    End Sub



    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        mainForm_Admin.Show()
        Me.Close()
    End Sub

    Private Sub closeBtn_Click_1(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        frm_ManageBarang.Show()
        Me.Close()
    End Sub

    Private Sub btnStokBarang_Click(sender As Object, e As EventArgs) Handles btnStokBarang.Click
        frm_ManageStok.Show()
        Me.Close()
    End Sub

    Private Sub btn_clearUser_Click(sender As Object, e As EventArgs) Handles btn_clearUser.Click
        clear()
    End Sub

    Private Sub dgv_User_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Users.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_Users.Rows(e.RowIndex)

            selectedUserID = row.Cells(1).Value   ' ⬅ ambil USER_ID

            txtName.Text = row.Cells(2).Value.ToString()
            txtUsername.Text = row.Cells(3).Value.ToString()
            txtPass.Clear()
            cboRole.Text = row.Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub btn_editUser_Click(sender As Object, e As EventArgs) Handles btn_editUser.Click
        If selectedUserID = -1 Then
            MsgBox("Pilih user dahulu!", vbExclamation)
            Return
        End If

        Try
            conn.Open()

            Dim sql As String

            If txtPass.Text = "" Then
                ' -----------------------------
                ' UPDATE TANPA UBAH PASSWORD
                ' -----------------------------
                sql = "UPDATE tbluser SET name=@name, username=@username, role=@role WHERE user_ID=@id"
                cmd = New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@role", cboRole.Text)

            Else
                ' -----------------------------
                ' UPDATE DENGAN PASSWORD BARU
                ' -----------------------------
                Dim salt As String = ""
                Dim hash As String = HashPassword(txtPass.Text, salt)

                sql = "UPDATE tbluser SET name=@name, username=@username, 
                   password_hash=@hash, password_salt=@salt, role=@role 
                   WHERE user_ID=@id"

                cmd = New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@hash", hash)
                cmd.Parameters.AddWithValue("@salt", salt)
                cmd.Parameters.AddWithValue("@role", cboRole.Text)
            End If

            cmd.Parameters.AddWithValue("@id", selectedUserID)
            cmd.ExecuteNonQuery()

            MsgBox("User berhasil diupdate!", vbInformation)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        load_Users()
        clear()
    End Sub


    Private Sub btn_delUser_Click(sender As Object, e As EventArgs) Handles btn_delUser.Click
        If selectedUserID = -1 Then
            MessageBox.Show("Pilih user terlebih dahulu!")
            Return
        End If

        If MessageBox.Show("Yakin ingin menghapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            Dim query As String = "DELETE FROM tbluser WHERE user_id=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedUserID)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            MessageBox.Show("User berhasil dihapus!")

            load_Users()    ' refresh datagrid
            clear()   ' kosongkan input

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin ingin logout?", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
            loginForm.Show()
        Else
            Return
        End If
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        frm_ManageSupplier.Show()
        Me.Close()
    End Sub

    Private Sub btnPembelian_Click(sender As Object, e As EventArgs) Handles btnPembelian.Click
        frm_ManagePembelian.Show()
        Me.Hide()
    End Sub

    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        frm_ManagePengembalian.Show()
        Me.Hide()
    End Sub

    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        frm_ManagePenjualan.Show()
        Me.Hide()
    End Sub
End Class