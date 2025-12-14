Imports MySql.Data.MySqlClient

Public Class frm_ManageSupplier

    Dim selectedSupplierID As Integer = -1

    Private Sub frm_ManageSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        dgv_Supplier.RowTemplate.Height = 30

        load_Supplier()

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want
    End Sub

    Sub load_Supplier()
        dgv_Supplier.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `supplier_ID`, `nama_supplier`, `kontak`, `alamat`, `catatan` FROM `tblsupplier`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_Supplier.Rows.Add(dgv_Supplier.Rows.Count + 1, dr.Item("supplier_ID"), dr.Item("nama_supplier"), dr.Item("kontak"), dr.Item("alamat"), dr.Item("catatan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        txt_nmaSup.Clear()
        txt_kontakSup.Clear()
        txt_alamatSup.Clear()
        txt_catatanSup.Clear()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        frm_ManageBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnStokBarang_Click(sender As Object, e As EventArgs) Handles btnStokBarang.Click
        frm_ManageStok.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        frm_ManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin ingin logout?", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
            loginForm.Show()
        Else
            Return
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        mainForm_Admin.Show()
        Me.Close()
    End Sub

    Private Sub btn_clearSup_Click(sender As Object, e As EventArgs) Handles btn_clearSup.Click
        clear()
    End Sub

    Private Sub btn_delSup_Click(sender As Object, e As EventArgs) Handles btn_delSup.Click
        If selectedSupplierID = -1 Then
            MessageBox.Show("Pilih user terlebih dahulu!")
            Return
        End If

        If MessageBox.Show("Yakin ingin menghapus supplier ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        Try
            Dim query As String = "DELETE FROM tblsupplier WHERE supplier_ID=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", selectedSupplierID)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            MessageBox.Show("Supplier berhasil dihapus!")

            load_Supplier()    ' refresh datagrid
            clear()   ' kosongkan input

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_updateSup_Click(sender As Object, e As EventArgs) Handles btn_updateSup.Click
        If String.IsNullOrWhiteSpace(txt_nmaSup.Text) Or String.IsNullOrWhiteSpace(txt_kontakSup.Text) Or String.IsNullOrWhiteSpace(txt_alamatSup.Text) Then
            MsgBox("Data supplier tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        If selectedSupplierID = -1 Then
            MessageBox.Show("Pilih supplier terlebih dahulu!")
            Return
        End If

        Try
            Dim query As String = "UPDATE `tblsupplier` SET `nama_supplier`=@nama_supplier, `kontak`=@kontak, `alamat`=@alamat, `catatan`=@catatan WHERE `supplier_ID`=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama_supplier", txt_nmaSup.Text)
                cmd.Parameters.AddWithValue("@kontak", txt_kontakSup.Text)
                cmd.Parameters.AddWithValue("@alamat", txt_alamatSup.Text)
                cmd.Parameters.AddWithValue("@catatan", txt_catatanSup.Text)
                cmd.Parameters.AddWithValue("@id", selectedSupplierID)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            MessageBox.Show("User berhasil diupdate!")
            load_Supplier()   ' reload datagrid
            clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Function cekSupplierviaNama(nama_supplier As String) As Boolean
        Dim ada As Boolean = False
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tblsupplier WHERE nama_supplier=@nama_supplier", conn)
            cmd.Parameters.AddWithValue("@nama_supplier", nama_supplier)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            ada = (count > 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return ada
    End Function


    Private Sub btn_simpanSup_Click(sender As Object, e As EventArgs) Handles btn_simpanSup.Click
        If String.IsNullOrWhiteSpace(txt_nmaSup.Text) Or String.IsNullOrWhiteSpace(txt_kontakSup.Text) Or String.IsNullOrWhiteSpace(txt_alamatSup.Text) Then
            MsgBox("Data supplier tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        If cekSupplierviaNama(txt_nmaSup.Text) Then
            MsgBox("Supplier sudah terdaftar! Gunakan tombol UPDATE untuk mengubah data.", vbExclamation)
            Exit Sub
        End If

        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tblsupplier`(`nama_supplier`, `kontak`, `alamat`, `catatan`) VALUES (@nama_supplier, @kontak, @alamat, @catatan)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama_supplier", txt_nmaSup.Text)
            cmd.Parameters.AddWithValue("@kontak", txt_kontakSup.Text)
            cmd.Parameters.AddWithValue("@alamat", txt_alamatSup.Text)
            cmd.Parameters.AddWithValue("@catatan", txt_catatanSup.Text)
            i = cmd.ExecuteNonQuery
            If 1 > 0 Then
                MsgBox("Supplier baru berhasil disimpan!", vbInformation)
            Else
                MsgBox("Supplier gagal disimpan!", vbExclamation)
            End If
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        load_Supplier()
    End Sub

    Private Sub dgv_Supplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Supplier.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_Supplier.Rows(e.RowIndex)

            selectedSupplierID = row.Cells(1).Value   ' ⬅ ambil Supplier_ID

            txt_nmaSup.Text = row.Cells(2).Value.ToString()
            txt_kontakSup.Text = row.Cells(3).Value.ToString()
            txt_alamatSup.Text = row.Cells(4).Value.ToString()
            txt_catatanSup.Text = row.Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub txt_cariSup_TextChanged(sender As Object, e As EventArgs) Handles txt_cariSup.TextChanged
        dgv_Supplier.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblsupplier WHERE nama_supplier LIKE '%" & txt_cariSup.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_Supplier.Rows.Add(dgv_Supplier.Rows.Count + 1, dr.Item("supplier_ID"), dr.Item("nama_supplier"), dr.Item("kontak"), dr.Item("alamat"), dr.Item("catatan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
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