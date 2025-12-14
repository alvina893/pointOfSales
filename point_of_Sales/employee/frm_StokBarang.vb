Imports MySql.Data.MySqlClient
Public Class frm_StokBarang

    Sub CekStokMenipis()
        rtf_notifStok.Clear()
        For i As Integer = 0 To dgv_StokBarang.Rows.Count - 1
            If dgv_StokBarang.Rows(i).IsNewRow Then Continue For

            Dim nama = dgv_StokBarang.Rows(i).Cells(2).Value
            Dim stok = dgv_StokBarang.Rows(i).Cells(6).Value
            Dim minStok = dgv_StokBarang.Rows(i).Cells(7).Value

            If nama Is Nothing Or stok Is Nothing Or minStok Is Nothing Then Continue For

            If Convert.ToInt32(stok) < Convert.ToInt32(minStok) Then

                ' tampilkan teks warna merah
                rtf_notifStok.SelectionColor = Color.Red
                rtf_notifStok.AppendText($"⚠ {nama} — Stok hanya {stok} (min {minStok}){vbCrLf}")

            Else
                ' tampilkan teks warna hijau untuk stok aman
                rtf_notifStok.SelectionColor = Color.Green
                rtf_notifStok.AppendText($"{nama} — Stok aman ({stok}){vbCrLf}")
            End If
        Next
    End Sub

    Sub load_stock()
        dgv_StokBarang.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `kode_barang`, `nama_barang`, `kategori_barang`, `satuan_barang`, `harga_barang`, `stok`, `min_stok` FROM `tblbarang`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                dgv_StokBarang.Rows.Add(dgv_StokBarang.Rows.Count + 1, dr.Item("kode_barang"), dr.Item("nama_barang"), dr.Item("kategori_barang"), dr.Item("satuan_barang"), dr.Item("harga_barang"), dr.Item("stok"), dr.Item("min_stok"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_updateStock_Click(sender As Object, e As EventArgs) Handles btn_updateStock.Click
        Try
            conn.Open()


            For j As Integer = 0 To dgv_StokBarang.Rows.Count - 1 Step +1
                cmd = New MySqlCommand("UPDATE `tblbarang` SET `stok`=@stok WHERE `kode_barang`=@kode_barang", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@stok", dgv_StokBarang.Rows(j).Cells(6).Value.ToString)
                cmd.Parameters.AddWithValue("@kode_barang", dgv_StokBarang.Rows(j).Cells(1).Value.ToString)
                i = cmd.ExecuteNonQuery
            Next
            If i > 0 Then
                MsgBox("Stok berhasil diupdate!", vbInformation)
            Else
                MsgBox("Stok gagal diupdate!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        load_stock()
        CekStokMenipis()
        frm_ManageStok.CekStokMenipis()
    End Sub

    Private Sub frm_StokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_stock()
        CekStokMenipis()
    End Sub

    Private Sub btnPengembalian_Karyawan_Click(sender As Object, e As EventArgs) Handles btnPengembalian_Karyawan.Click
        mainForm_Employee.Show()
        Me.Close()
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        frm_DeliveryManage.Show()
        Me.Close()
    End Sub

    Private Sub btnPickup_Click(sender As Object, e As EventArgs) Handles btnPickup.Click
        frm_PickupManage.Show()
        Me.Close()
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
End Class