Imports MySql.Data.MySqlClient

Public Class mainForm_Admin
    Private Sub mainForm_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        LoadDashboard()

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want
    End Sub

    Private Sub LoadDashboard()
        Try
            conn.Open()

            lbl_jumlahBarang.Text = ExecuteQuery("SELECT COUNT(*) FROM tblbarang")
            lbl_barangMenipis.Text = ExecuteQuery("SELECT COUNT(*) FROM tblbarang WHERE stok < min_stok")
            lbl_jumlahSupplier.Text = ExecuteQuery("SELECT COUNT(*) FROM tblsupplier")
            lbl_jumlahPembelian.Text = ExecuteQuery("SELECT COUNT(*) FROM tblpembelian")
            lbl_totalDanaPembelian.Text = FormatCurrency(ExecuteQuery("SELECT SUM(total) FROM tblpembelian"))
            lbl_jumlahRetur.Text = ExecuteQuery("SELECT COUNT(*) FROM tblpengembalian")
            lbl_totalDanaRetur.Text = FormatCurrency(ExecuteQuery("SELECT SUM(total_returDana) FROM tblpengembalian"))
            lbl_totalStokRetur.Text = ExecuteQuery("SELECT SUM(total_returStok) FROM tblpengembalian")
            lbl_jumlahPenjualan.Text = ExecuteQuery("SELECT COUNT(*) FROM tblpenjualan")
            lbl_totalDanaPenjualan.Text = FormatCurrency(ExecuteQuery("SELECT SUM(total_penjualan) FROM tblpenjualan"))

            ' ===== Tambahan di sini =====

            ' Ambil dana uang kecil
            Dim danaUangKecil As Decimal = Convert.ToDecimal(ExecuteScalar("SELECT dana_uangKecil FROM tbluangkecil LIMIT 1"))

            ' Hitung total kembalian dari penjualan
            Dim totalKembalian As Decimal = Convert.ToDecimal(ExecuteScalar("SELECT IFNULL(SUM(kembalian), 0) FROM tblpenjualan"))

            ' Hitung sisa
            Dim sisa As Decimal = danaUangKecil - totalKembalian

            ' Tampilkan hasil
            lbl_sisaUangKecil.Text = FormatCurrency(sisa)

            ' =============================

        Catch ex As Exception
            MsgBox("Error loading dashboard: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function ExecuteQuery(sql As String) As Object
        Dim cmd As New MySqlCommand(sql, conn)
        Dim result = cmd.ExecuteScalar()
        If IsDBNull(result) Then Return 0
        Return result
    End Function


    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
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

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        frm_ManageSupplier.Show()
        Me.Hide()
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