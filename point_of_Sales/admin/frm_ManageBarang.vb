Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.Barcode
Imports System.Drawing.Printing

Public Class frm_ManageBarang

    Dim supplierIdToName As New Dictionary(Of String, String)
    Dim supplierNameToId As New Dictionary(Of String, String)
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Private Sub frm_ManageBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        txt_barcodeValue.Focus()

        load_kategoriBarang()
        load_satuanBarang()
        load_Barang()
        load_supplier()
        load_barangMassal()
        LoadSupplierToCombo()
        headerSelectAll.Visible = False
        pic_barcodeBrng.Visible = False
        btn_printBarcodeBarang.Visible = False
        lblbarcode.Visible = False

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want
        dgv_Barang.RowTemplate.Height = 30
        dgv_barangUbahMassal.RowTemplate.Height = 30

        GenerateKodeBarang()
    End Sub

    Sub GenerateKodeBarang()
        Dim prefix As String = "IM-BRG-"
        Dim newIncrement As Integer = 1

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim query As String =
            "SELECT IFNULL(MAX(CAST(RIGHT(kode_barang,3) AS UNSIGNED)),0)
             FROM tblbarang
             WHERE kode_barang LIKE 'IM-BRG-%'"

            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()

            newIncrement = CInt(result) + 1

        Catch ex As Exception
            MsgBox("Error generate kode barang: " & ex.Message)
        Finally
            conn.Close()
        End Try

        txt_kodeBrg.Text = prefix & newIncrement.ToString("000")
        txt_kodeBrg.ReadOnly = True
    End Sub


    Sub LoadSupplierToCombo()
        cbo_filterbySupplier.Items.Clear()
        supplierNameToId.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT supplier_ID, nama_supplier FROM tblsupplier", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim id As String = dr("supplier_ID").ToString()
                Dim nama As String = dr("nama_supplier").ToString()

                cbo_filterbySupplier.Items.Add(nama)           ' Display name
                supplierNameToId(nama) = id              ' Store ID for later
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub load_supplier()
        cbo_IDSup.Items.Clear()
        supplierIdToName.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT supplier_ID, nama_supplier FROM tblsupplier", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim id As String = dr("supplier_ID").ToString()
                Dim nama As String = dr("nama_supplier").ToString()

                cbo_IDSup.Items.Add(id)           ' Display name
                supplierIdToName(id) = nama              ' Store ID for later
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub load_kategoriBarang()
        cbo_kategoriBrg.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * from `tblkategori`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cbo_kategoriBrg.Items.Add(dr.Item("nma_kategori").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub load_satuanBarang()
        cbo_satuanBrg.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * from `tblsatuan`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cbo_satuanBrg.Items.Add(dr.Item("nma_satuan").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub load_Barang()
        dgv_Barang.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `kode_barang`, `nama_barang`, `kategori_barang`, `satuan_barang`, `harga_beli`, `harga_barang`, `stok`, `min_stok`, `barcode`, `supplier_ID`, `nama_supplier` FROM `tblbarang`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_Barang.Rows.Add(dgv_Barang.Rows.Count + 1, dr.Item("kode_barang"), dr.Item("nama_barang"), dr.Item("kategori_barang"), dr.Item("satuan_barang"), dr.Item("harga_beli"), dr.Item("harga_barang"), dr.Item("stok"), dr.Item("min_stok"), dr.Item("barcode"), dr.Item("supplier_ID"), dr.Item("nama_supplier"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        txt_kodeBrg.Clear()
        txt_nmaBrg.Clear()
        cbo_kategoriBrg.SelectedIndex = -1
        cbo_satuanBrg.SelectedIndex = -1
        cbo_IDSup.SelectedIndex = -1
        txt_namaSup.Clear()
        txt_hrgaBrg.Clear()
        txt_hrgaBeli.Clear()
        txt_stok.Clear()
        txt_minStok.Clear()
        pic_barcodeBrng.Image = Nothing
        txt_cariBrg.Clear()
    End Sub

    Function cekBarangViaKode(kode As String) As Boolean
        Dim ada As Boolean = False

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tblbarang WHERE kode_barang=@kode", conn)
            cmd.Parameters.AddWithValue("@kode", kode)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            ada = (count > 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Return ada
    End Function

    Sub GenerateBarcodeFromKode()
        If txt_kodeBrg.Text = "" Then Exit Sub

        Dim gen As New MessagingToolkit.Barcode.BarcodeEncoder
        gen.BackColor = Color.White

        pic_barcodeBrng.Image =
        New Bitmap(gen.Encode(BarcodeFormat.Code128, txt_kodeBrg.Text))
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub txt_cariBrg_TextChanged(sender As Object, e As EventArgs) Handles txt_cariBrg.TextChanged
        dgv_Barang.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblbarang 
                        WHERE kode_barang LIKE '%" & txt_cariBrg.Text & "%' 
                        OR nama_barang LIKE '%" & txt_cariBrg.Text & "%' 
                        OR kategori_barang LIKE '%" & txt_cariBrg.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_Barang.Rows.Add(dgv_Barang.Rows.Count + 1, dr.Item("kode_barang"), dr.Item("nama_barang"), dr.Item("kategori_barang"), dr.Item("satuan_barang"), dr.Item("harga_beli"), dr.Item("harga_barang"), dr.Item("stok"), dr.Item("min_stok"), dr.Item("barcode"), dr.Item("supplier_ID"), dr.Item("nama_supplier"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub dgv_Barang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Barang.CellClick
        Try
            With dgv_Barang.Rows(e.RowIndex)
                txt_kodeBrg.Text = .Cells(1).Value.ToString()
                txt_nmaBrg.Text = .Cells(2).Value.ToString()
                cbo_kategoriBrg.Text = .Cells(3).Value.ToString()
                cbo_satuanBrg.Text = .Cells(4).Value.ToString()
                txt_hrgaBeli.Text = .Cells(5).Value.ToString()
                txt_hrgaBrg.Text = .Cells(6).Value.ToString()
                txt_stok.Text = .Cells(7).Value.ToString()
                txt_minStok.Text = .Cells(8).Value.ToString()
                pic_barcodeBrng.Text = .Cells(9).Value.ToString()
                txt_namaSup.Text = .Cells(11).Value.ToString()
                cbo_IDSup.Text = .Cells(10).Value.ToString()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        mainForm_Admin.Show()
        Me.Close()
    End Sub

    Private Sub txt_cariBrg_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cariBrg.MouseClick
        clear()
    End Sub

    Private Sub btnStokBarang_Click(sender As Object, e As EventArgs) Handles btnStokBarang.Click
        frm_ManageStok.Show()
        Me.Close()
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        frm_ManageUsers.Show()
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

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage

        Dim f12 As New Font("Calibri", 12, FontStyle.Bold)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)

        Dim left As Integer = 10
        Dim y As Integer = 10

        ' Judul kecil
        e.Graphics.DrawString("BARCODE", f12, Brushes.Black, left, y)
        y += 20

        ' Nama Barang bila ingin
        e.Graphics.DrawString(txt_nmaBrg.Text, f10, Brushes.Black, left, y)
        y += 15

        ' Gambar barcode
        Dim bc As Image = pic_barcodeBrng.Image
        e.Graphics.DrawImage(bc, left, y, bc.Width, bc.Height)

        'For i As Integer = 1 To banyakBarcode
        '    e.Graphics.DrawImage(pic_barcodeBrg.Image, left, y)
        '    y += pic_barcodeBrg.Image.Height + 20
        'Next
    End Sub

    Sub load_barangMassal()
        dgv_barangUbahMassal.Rows.Clear()
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
                     ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                dgv_barangUbahMassal.Rows.Add(dgv_barangUbahMassal.Rows.Count + 1,
                                             False,
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

            dgv_barangUbahMassal.Rows.Clear()

            Dim nomor As Integer = 1

            While dr.Read()
                Dim idx As Integer = dgv_barangUbahMassal.Rows.Add()
                With dgv_barangUbahMassal.Rows(idx)
                    .Cells("colNo").Value = nomor          ' Row Numbering
                    .Cells("colPilih").Value = False
                    .Cells("colKodeBarangLowStok").Value = dr("kode_barang").ToString()
                    .Cells("colNamaBarangLowStok").Value = dr("nama_barang").ToString()
                    .Cells("colSatuanBarangLowStok").Value = dr("satuan_barang").ToString()
                    .Cells("colHargaBeli").Value = dr("harga_beli").ToString()
                    .Cells("colHargaBarangLowStok").Value = dr("harga_barang").ToString()
                    .Cells("colStokBarangLowStok").Value = dr("stok").ToString()
                    .Cells("colMinStokBarangLowStok").Value = dr("min_stok").ToString()
                    .Cells("colSupplierIDLowStock").Value = dr("supplier_ID").ToString()
                    .Cells("colSupplierNamaLowStock").Value = dr("nama_supplier").ToString()
                    nomor += 1
                End With

            End While

            headerSelectAll.Visible = (dgv_barangUbahMassal.Rows.Count > 0)

        Catch ex As Exception
            MsgBox("Gagal memfilter data: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub cbo_filterbySupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_filterbySupplier.SelectedIndexChanged
        If cbo_filterbySupplier.SelectedIndex = -1 Then Exit Sub

        Dim selectedName = cbo_filterbySupplier.Text
        Dim id = supplierNameToId(selectedName)

        LoadBarangBySupplier(id)
    End Sub

    Private Sub btn_ResetFilter_Click(sender As Object, e As EventArgs) Handles btn_ResetFilter.Click
        ' Reset ComboBox
        cbo_filterbySupplier.SelectedIndex = -1

        ' Reload semua barang tanpa filter
        load_barangMassal()

        headerSelectAll.Visible = False
    End Sub

    Private Sub btnRestockSemua_Click(sender As Object, e As EventArgs) Handles btnRestockSemua.Click
        Dim popup As New frm_PopUpUbahHargaMassal(dgv_barangUbahMassal)
        popup.ShowDialog()
    End Sub

    Private Sub btn_tmbhKategori_Click_1(sender As Object, e As EventArgs) Handles btn_tmbhKategori.Click
        frm_tbhKategori.ShowDialog()
    End Sub

    Private Sub btn_tmbhSatuan_Click_1(sender As Object, e As EventArgs) Handles btn_tmbhSatuan.Click
        frm_tbhSatuan.ShowDialog()
    End Sub

    Private Sub cbo_IDSup_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbo_IDSup.SelectedIndexChanged
        If cbo_IDSup.SelectedIndex = -1 Then Exit Sub

        Dim id As String = cbo_IDSup.SelectedItem.ToString()

        If supplierIdToName.ContainsKey(id) Then
            txt_namaSup.Text = supplierIdToName(id)
        Else
            txt_namaSup.Clear()
        End If
    End Sub

    Private Sub btn_printBarcodeBarang_Click_1(sender As Object, e As EventArgs) Handles btn_printBarcodeBarang.Click
        If pic_barcodeBrng.Image Is Nothing Then
            MsgBox("Barcode belum dibuat!", vbExclamation)
            Exit Sub
        End If

        PD.DefaultPageSettings.PaperSize = New PaperSize("Custom", 300, 180)

        PPD.Document = PD
        PPD.Width = 600
        PPD.Height = 800

        PPD.ShowDialog()
    End Sub

    Private Sub btn_simpanBrg_Click_1(sender As Object, e As EventArgs) Handles btn_simpanBrg.Click
        Try
            If cekBarangViaKode(txt_kodeBrg.Text) Then
                MsgBox("Kode barang sudah terdaftar! Gunakan tombol UPDATE untuk mengubah data.", vbExclamation)
                Exit Sub
            End If

            conn.Open()
            'Dim FileSize As UInt32
            'Dim mstream As New System.IO.MemoryStream
            'pic_barcodeBrga.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Dim arrImage() As Byte = mstream.GetBuffer()
            'FileSize = mstream.Length
            'mstream.Close()

            cmd = New MySqlCommand("INSERT INTO `tblbarang`(`kode_barang`, `barcode_value`, `barcode_type`, `nama_barang`, `kategori_barang`, `satuan_barang`, `harga_beli`, `harga_barang`, `stok`, `min_stok`, `supplier_ID`, `nama_supplier`) VALUES (@kode_barang, @barcode_value, @barcode_type, @nama_barang, @kategori_barang, @satuan_barang, @harga_beli, @harga_barang, @stok, @min_stok, @supplier_ID, @nama_supplier)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_barang", txt_kodeBrg.Text)
            cmd.Parameters.AddWithValue("@barcode_value", txt_barcodeValue.Text)
            cmd.Parameters.AddWithValue("@barcode_type", cbo_tipeBarcode.Text)
            cmd.Parameters.AddWithValue("@nama_barang", txt_nmaBrg.Text)
            cmd.Parameters.AddWithValue("@kategori_barang", cbo_kategoriBrg.Text)
            cmd.Parameters.AddWithValue("@satuan_barang", cbo_satuanBrg.Text)
            cmd.Parameters.AddWithValue("@harga_beli", CDec(txt_hrgaBeli.Text))
            cmd.Parameters.AddWithValue("@harga_barang", CDec(txt_hrgaBrg.Text))
            cmd.Parameters.AddWithValue("@stok", txt_stok.Text)
            cmd.Parameters.AddWithValue("@min_stok", txt_minStok.Text)
            'cmd.Parameters.AddWithValue("@barcode", arrImage)
            cmd.Parameters.AddWithValue("@supplier_ID", cbo_IDSup.Text)
            cmd.Parameters.AddWithValue("@nama_supplier", txt_namaSup.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Barang baru berhasil disimpan!", vbInformation)
            Else
                MsgBox("Barang gagal disimpan!", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        load_Barang()
        frm_ManagePembelian.load_barang()
        GenerateKodeBarang()
    End Sub

    Private Sub btn_updateBrg_Click_1(sender As Object, e As EventArgs) Handles btn_updateBrg.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE `tblbarang` SET `nama_barang`=@nama_barang,`kategori_barang`=@kategori_barang,`satuan_barang`=@satuan_barang,`harga_beli`=@harga_beli,`harga_barang`=@harga_barang, `stok` =@stok, `min_stok`=@min_stok, `supplier_ID`=@supplier_ID, `nama_supplier`=@nama_supplier WHERE `kode_barang`=@kode_barang", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama_barang", txt_nmaBrg.Text)
            cmd.Parameters.AddWithValue("@kategori_barang", cbo_kategoriBrg.Text)
            cmd.Parameters.AddWithValue("@satuan_barang", cbo_satuanBrg.Text)
            cmd.Parameters.AddWithValue("@harga_beli", CDec(txt_hrgaBeli.Text))
            cmd.Parameters.AddWithValue("@harga_barang", CDec(txt_hrgaBrg.Text))
            cmd.Parameters.AddWithValue("@stok", txt_stok.Text)
            cmd.Parameters.AddWithValue("@min_stok", txt_minStok.Text)
            cmd.Parameters.AddWithValue("@supplier_ID", cbo_IDSup.Text)
            cmd.Parameters.AddWithValue("@nama_supplier", txt_namaSup.Text)

            cmd.Parameters.AddWithValue("@kode_barang", txt_kodeBrg.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Barang berhasil diupdate!", vbInformation)
            Else
                MsgBox("Barang gagal diupdate!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
        txt_cariBrg.Clear()
        load_Barang()
        frm_ManagePembelian.load_barang()
    End Sub

    Private Sub btn_clearBrg_Click_1(sender As Object, e As EventArgs) Handles btn_clearBrg.Click
        clear()
    End Sub

    Private Sub btn_delBrg_Click_1(sender As Object, e As EventArgs) Handles btn_delBrg.Click
        If MsgBox("Apakah anda yakin ingin menghapus barang ini?", vbExclamation + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New MySqlCommand("DELETE FROM `tblbarang` WHERE `kode_barang`=@kode_barang", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@kode_barang", txt_kodeBrg.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Barang berhasil dihapus!", vbInformation)
                Else
                    MsgBox("Barang gagal dihapus!", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            clear()
            txt_cariBrg.Clear()
            load_Barang()
            frm_ManagePembelian.load_barang()
        Else
            Return
        End If
    End Sub

    Private Sub cbo_tipeBarcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipeBarcode.SelectedIndexChanged
        pic_barcodeBrng.Image = Nothing
        txt_barcodeValue.Clear()

        Select Case cbo_tipeBarcode.Text

            Case "Generate Barcode Baru"
                txt_barcodeValue.Enabled = False
                pic_barcodeBrng.Visible = True
                btn_printBarcodeBarang.Visible = True
                lblbarcode.Visible = True

                ' Barcode diambil dari kode_barang
                GenerateBarcodeFromKode()

            Case "Barcode Kosong dari Roll"
                txt_barcodeValue.Enabled = True
                pic_barcodeBrng.Visible = False
                btn_printBarcodeBarang.Visible = False
                lblbarcode.Visible = False

                txt_barcodeValue.Focus()

            Case "Barcode Sudah Ada"
                txt_barcodeValue.Enabled = True
                pic_barcodeBrng.Visible = False
                btn_printBarcodeBarang.Visible = False
                lblbarcode.Visible = False

                txt_barcodeValue.Focus()
        End Select
    End Sub
End Class