Imports MySql.Data.MySqlClient
Public Class frm_ManageStok

    Dim j As Integer

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

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        frm_ManageBarang.Show()
        Me.Close()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        mainForm_Admin.Show()
        Me.Close()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub frm_ManageStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        dgv_StokBarang.RowTemplate.Height = 30
        load_stock()
        load_lowStock()
        LoadSupplierToCombo()
        CekStokMenipis()
        headerSelectAll.Visible = False

        dgv_stokMenipisSaja.AutoGenerateColumns = False

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want
    End Sub

    Sub load_stock()
        dgv_StokBarang.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT 
                    `kode_barang`, 
                    `nama_barang`, 
                    `kategori_barang`, 
                    `satuan_barang`, 
                    `harga_barang`, 
                    `harga_beli`,
                    `stok`, 
                    `min_stok`, 
                    `supplier_ID`,
                    `nama_supplier`
                    FROM `tblbarang`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                dgv_StokBarang.Rows.Add(dgv_StokBarang.Rows.Count + 1,
                                        dr.Item("kode_barang"),
                                        dr.Item("nama_barang"),
                                        dr.Item("satuan_barang"),
                                        dr.Item("harga_beli"),
                                        dr.Item("harga_barang"),
                                        dr.Item("stok"),
                                        dr.Item("min_stok"),
                                        dr.Item("supplier_ID"),
                                        dr.Item("nama_supplier"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub load_lowStock()
        dgv_stokMenipisSaja.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT 
                    `kode_barang`, 
                    `nama_barang`, 
                    `satuan_barang`, 
                    `harga_beli`, 
                    `harga_barang`, 
                    `stok`, 
                    `min_stok`, 
                    `supplier_ID`, 
                    `nama_supplier`
                     FROM `tblbarang` 
                     WHERE stok <= min_stok 
                     ORDER BY stok ASC", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                dgv_stokMenipisSaja.Rows.Add(dgv_stokMenipisSaja.Rows.Count + 1,
                                             False,
                                             dr.Item("kode_barang"),
                                             dr.Item("nama_barang"),
                                             dr.Item("satuan_barang"),
                                             dr.Item("harga_beli"),
                                             dr.Item("harga_barang"),
                                             dr.Item("stok"),
                                             dr.Item("min_stok"),
                                             dr.Item("supplier_ID"),
                                             dr.Item("nama_supplier"),
                                             False)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        frm_ManageUsers.Show()
        Me.Close()
    End Sub

    Private Sub txt_cariBrg_TextChanged(sender As Object, e As EventArgs) Handles txt_cariBrg.TextChanged
        dgv_StokBarang.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblbarang 
                        WHERE kode_barang LIKE '%" & txt_cariBrg.Text & "%' 
                        OR nama_barang LIKE '%" & txt_cariBrg.Text & "%' 
                        OR kategori_barang LIKE '%" & txt_cariBrg.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_StokBarang.Rows.Add(dgv_StokBarang.Rows.Count + 1,
                                        dr.Item("kode_barang"),
                                        dr.Item("nama_barang"),
                                        dr.Item("kategori_barang"),
                                        dr.Item("satuan_barang"),
                                        dr.Item("harga_barang"),
                                        dr.Item("stok"),
                                        dr.Item("min_stok"),
                                        dr.Item("supplier_ID"),
                                        dr.Item("nama_supplier"))
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
                cmd = New MySqlCommand("UPDATE `tblbarang` SET `stok`=@stok, `min_stok`=@min_stok WHERE `kode_barang`=@kode_barang", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@stok", dgv_StokBarang.Rows(j).Cells(6).Value.ToString)
                cmd.Parameters.AddWithValue("@min_stok", dgv_StokBarang.Rows(j).Cells(7).Value.ToString)
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
        load_lowStock()
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

    Private Sub dgv_stokMenipisSaja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_stokMenipisSaja.CellContentClick
        If e.ColumnIndex = dgv_stokMenipisSaja.Columns("colAddLowStock").Index Then

            Dim kodeBarang As String = dgv_stokMenipisSaja.Rows(e.RowIndex).Cells("colKodeBarangLowStok").Value

            ' buka form pembelian + autofill
            Dim formPembelianBaru As New frm_PopUpPembelianBaru
            formPembelianBaru.load_Barang(kodeBarang)
            formPembelianBaru.ShowDialog()
        End If
    End Sub

    Dim supplierDict As New Dictionary(Of String, String)
    Sub LoadSupplierToCombo()
        cbo_filterbySupplier.Items.Clear()
        supplierDict.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT supplier_ID, nama_supplier FROM tblsupplier", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim id As String = dr("supplier_ID").ToString()
                Dim nama As String = dr("nama_supplier").ToString()

                cbo_filterbySupplier.Items.Add(nama)           ' Display name
                supplierDict(nama) = id              ' Store ID for later
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub AddCheckBoxColumn()
        Dim colName As String = "pilih"

        'cek biar nggak jadi double
        For Each col As DataGridViewColumn In dgv_stokMenipisSaja.Columns
            If col.Name = colName Then Exit Sub
        Next

        Dim chk As New DataGridViewCheckBoxColumn()
        chk.HeaderText = "Pilih"
        chk.Name = colName
        chk.Width = 60
        dgv_stokMenipisSaja.Columns.Insert(0, chk)
    End Sub

    Sub LoadBarangBySupplier(idSupplier As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String =
            "SELECT kode_barang, nama_barang, kategori_barang, satuan_barang, 
                    harga_beli, harga_barang, stok, min_stok, barcode, 
                    supplier_ID, nama_supplier 
             FROM tblbarang 
             WHERE stok <= min_stok AND supplier_ID = @id"

            Dim cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", idSupplier)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            dgv_stokMenipisSaja.Rows.Clear()

            Dim nomor As Integer = 1

            While dr.Read()
                Dim idx As Integer = dgv_stokMenipisSaja.Rows.Add()
                With dgv_stokMenipisSaja.Rows(idx)
                    .Cells("colNo").Value = nomor          ' Row Numbering
                    .Cells("colPilih").Value = False
                    .Cells("colKodeBarangLowStok").Value = dr("kode_barang").ToString()
                    .Cells("colNamaBarangLowStok").Value = dr("nama_barang").ToString()
                    .Cells("colSatuanBarangLowStok").Value = dr("satuan_barang").ToString()
                    .Cells("colHargaBeli").Value = dr("harga_beli").ToString()
                    .Cells("colHargaBarangLowStok").Value = dr("harga_beli").ToString()
                    .Cells("colStokBarangLowStok").Value = dr("stok").ToString()
                    .Cells("colMinStokBarangLowStok").Value = dr("min_stok").ToString()
                    .Cells("colSupplierIDLowStock").Value = dr("supplier_ID").ToString()
                    .Cells("colSupplierNamaLowStock").Value = dr("nama_supplier").ToString()
                    nomor += 1
                End With

            End While

            headerSelectAll.Visible = (dgv_stokMenipisSaja.Rows.Count > 0)

            If dgv_stokMenipisSaja.Columns.Contains("colPilih") Then
                dgv_stokMenipisSaja.Columns("colPilih").Visible = True

            End If

        Catch ex As Exception
            MsgBox("Gagal memfilter data: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub cbo_filterbySupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_filterbySupplier.SelectedIndexChanged
        If cbo_filterbySupplier.SelectedIndex = -1 Then Exit Sub

        Dim selectedName = cbo_filterbySupplier.Text
        Dim id = supplierDict(selectedName)

        LoadBarangBySupplier(id)
    End Sub

    Private Sub btn_ResetFilter_Click(sender As Object, e As EventArgs) Handles btn_ResetFilter.Click
        ' Reset ComboBox
        cbo_filterbySupplier.SelectedIndex = -1

        ' Reload semua barang tanpa filter
        load_lowStock()

        headerSelectAll.Visible = False

        ' Sembunyikan kolom Checkbox (optional)
        If dgv_stokMenipisSaja.Columns.Contains("colPilih") Then
            dgv_stokMenipisSaja.Columns("colPilih").Visible = False
        End If
    End Sub

    Private Sub cbo_selectAllLowStock_CheckedChanged(sender As Object, e As EventArgs) Handles cbo_selectAllLowStock.CheckedChanged
        For Each row As DataGridViewRow In dgv_stokMenipisSaja.Rows
            row.Cells("colPilih").Value = cbo_selectAllLowStock.Checked
        Next
    End Sub

    Private Sub btnRestockSemua_Click(sender As Object, e As EventArgs) Handles btnRestockSemua.Click
        Dim listBarang As New List(Of BarangRestock)

        For Each row As DataGridViewRow In dgv_stokMenipisSaja.Rows
            If CBool(row.Cells("colPilih").Value) = True Then

                Dim brg As New BarangRestock With {
                .kode = row.Cells("colKodeBarangLowStok").Value,
                .nama = row.Cells("colNamaBarangLowStok").Value,
                .satuan = row.Cells("colSatuanBarangLowStok").Value,
                .harga = row.Cells("colHargaBarangLowStok").Value,
                .supplierID = row.Cells("colSupplierIDLowStock").Value,
                .namaSupplier = row.Cells("colSupplierNamaLowStock").Value
            }

                listBarang.Add(brg)
            End If
        Next

        If listBarang.Count = 0 Then
            MsgBox("Tidak ada barang dipilih!", vbExclamation)
            Exit Sub
        End If

        ' VALIDASI SUPPLIER WAJIB SAMA
        Dim sup = listBarang(0).supplierID
        If listBarang.Any(Function(x) x.supplierID <> sup) Then
            MsgBox("Supplier harus sama!", vbCritical)
            Exit Sub
        End If

        Dim f As New frm_PopUpPembelianBaru
        f.LoadBarangRestock(listBarang)
        f.Show()
    End Sub
End Class