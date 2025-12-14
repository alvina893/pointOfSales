Imports System.Drawing.Printing
Imports System.IO
Imports MessagingToolkit.Barcode
Imports MySql.Data.MySqlClient

Public Class frm_ManagePenjualanDelivery

    Public Class BarangInfo
        Public Property ID As String
        Public Property Satuan As String
        Public Property Nama As String
        Public Property Harga As String

    End Class

    Public barangDict As New Dictionary(Of String, BarangInfo)

    Private totalPenjualanDelivery As Decimal = 0

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

    Private Sub btnPOS_Kasir_Click(sender As Object, e As EventArgs) Handles btnPOS_Kasir.Click
        mainForm_Cashier.Show()
        Me.Hide()
    End Sub

    Private Sub txt_noPenjualan_TextChanged(sender As Object, e As EventArgs) Handles txt_noPenjualanDelivery.TextChanged
        lbl_noPenjualanDelivery.Text = "No Penjualan: " & txt_noPenjualanDelivery.Text


        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White

        Try
            pic_barcodePenjualanDelivery.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_noPenjualanDelivery.Text))

        Catch ex As Exception
            pic_barcodePenjualanDelivery.Image = Nothing
        End Try
    End Sub

    Sub load_ListPenjualanPending()
        dgv_listPenjualanPending.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
             FROM tblpenjualan 
             WHERE status_penjualan = 'Pending' AND jenis_penjualan = 'Delivery'
             ORDER BY tanggal DESC"

            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim tgl As Date = Date.Parse(dr("tanggal").ToString())

                        dgv_listPenjualanPending.Rows.Add(
                        dgv_listPenjualanPending.Rows.Count + 1,
                        dr("no_penjualan").ToString(),
                        dr("jenis_penjualan").ToString(),
                        tgl.ToString("dd/MM/yyyy"),
                        "Rp. " & Format(CDec(dr("total_penjualan")), "N0"),
                        "Rp. " & Format(CDec(dr("dana_diterima")), "N0"),
                        "Rp. " & Format(CDec(dr("kembalian")), "N0"),
                        dr("metode_pembayaran").ToString(),
                        dr("catatan").ToString(),
                        dr("atas_nama").ToString(),
                        dr("kontak_penerima").ToString(),
                        dr("alamat").ToString(),
                        dr("status_pengiriman").ToString()
                    )
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal memuat data penjualan pending: " & ex.Message, vbExclamation)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub load_ListPenjualanDeliveryPacking()
        dgv_penjualanDeliveryPacking.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
             FROM tblpenjualan 
             WHERE status_pengiriman = 'Packing' AND jenis_penjualan = 'Delivery'
             ORDER BY tanggal DESC"

            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim tgl As Date = Date.Parse(dr("tanggal").ToString())

                        dgv_penjualanDeliveryPacking.Rows.Add(
                        dgv_penjualanDeliveryPacking.Rows.Count + 1,
                        dr("no_penjualan").ToString(),
                        dr("jenis_penjualan").ToString(),
                        tgl.ToString("dd/MM/yyyy"),
                        "Rp. " & Format(CDec(dr("total_penjualan")), "N0"),
                        "Rp. " & Format(CDec(dr("dana_diterima")), "N0"),
                        "Rp. " & Format(CDec(dr("kembalian")), "N0"),
                        dr("metode_pembayaran").ToString(),
                        dr("catatan").ToString(),
                        dr("atas_nama").ToString(),
                        dr("kontak_penerima").ToString(),
                        dr("alamat").ToString(),
                        dr("status_pengiriman").ToString()
                    )
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal memuat data penjualan pending: " & ex.Message, vbExclamation)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub frm_ManagePenjualanDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_listPenjualanPending.RowTemplate.Height = 30
        dgv_penjualanDeliveryPacking.RowTemplate.Height = 30

        dbconn()
        load_barang()
        GenerateNoPenjualan()
        load_ListPenjualanPending()
        load_ListPenjualanDeliveryPacking()
    End Sub

    Sub GenerateNoPenjualan()
        Dim prefix As String = "IM"
        Dim newIncrement As Integer = 1
        Dim lastNo As String = ""
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Ambil nomor penjualan paling akhir untuk tanggal hari ini
            Dim query As String = " SELECT no_penjualan FROM tblpenjualan WHERE DATE(tanggal) = CURDATE() ORDER BY penjualan_ID DESC LIMIT 1 "
            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                lastNo = result.ToString()
            End If
        Catch ex As Exception
            MsgBox("Error cek nomor penjualan: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' Jika sudah ada nomor sebelumnya → naikkan increment
        If lastNo <> "" Then
            Dim parts() = lastNo.Split("-"c)
            Dim lastIncrement As String = parts(parts.Length - 1)
            If IsNumeric(lastIncrement) Then
                newIncrement = CInt(lastIncrement) + 1
            End If
        End If
        ' Format final: IM-YYMMDD-XXXX
        txt_noPenjualanDelivery.Text = $"{prefix}-{Date.Now:yyMMdd}-{newIncrement:0000}"
        txt_noPenjualanDelivery.ReadOnly = True
    End Sub

    Sub load_barang()
        cbo_brgDelivery.Items.Clear()
        barangDict.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT kode_barang, nama_barang, satuan_barang, harga_barang FROM tblbarang", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                Dim kode As String = dr("kode_barang").ToString()
                Dim nama As String = dr("nama_barang").ToString()
                Dim satuan As String = dr("satuan_barang").ToString()
                Dim harga As Decimal = Convert.ToDecimal(dr("harga_barang"))
                Dim hargaFormatted As String = harga.ToString("N0")

                cbo_brgDelivery.Items.Add(kode)

                barangDict(kode) = New BarangInfo With {
                .ID = kode,
                .Nama = nama,
                .Satuan = satuan,
                .Harga = hargaFormatted
            }
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Function BersihkanAngka(input As String) As Decimal
        If String.IsNullOrWhiteSpace(input) Then Return 0
        input = input.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim()
        Dim hasil As Decimal
        Decimal.TryParse(input, hasil)
        Return hasil
    End Function

    Sub hitungSubtotal()
        Dim harga As Decimal
        Dim qty As Decimal

        harga = BersihkanAngka(txt_hrgaDelivery.Text)
        Decimal.TryParse(txt_qtyDelivery.Text, qty)

        Dim subtotal As Decimal = harga * qty

        'Format textbox
        txt_hrgaDelivery.Text = harga.ToString("N0")
        txt_subTotalDelivery.Text = subtotal.ToString("N0")
    End Sub

    Private Sub cbo_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_brgDelivery.SelectedIndexChanged
        If cbo_brgDelivery.SelectedIndex <> -1 Then
            Dim id As String = cbo_brgDelivery.Text

            If barangDict.ContainsKey(id) Then
                txt_namaBrgDelivery.Text = barangDict(id).Nama
                txt_satuanBrgDelivery.Text = barangDict(id).Satuan
                txt_hrgaDelivery.Text = barangDict(id).Harga
            End If
        End If
        hitungSubtotal()
    End Sub

    Function hitungTotalPenjualan() As Decimal
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgv_detailPenjualanDelivery.Rows
            If row.IsNewRow Then Continue For

            Dim cellValue = row.Cells("colSubtotal").Value
            If cellValue Is Nothing OrElse IsDBNull(cellValue) Then
                Continue For
            End If

            Dim decVal As Decimal
            If Decimal.TryParse(cellValue.ToString(), decVal) Then
                total += decVal
            End If
        Next

        Return total
    End Function

    Function HitungTotalQty() As Integer
        Dim totalQty As Integer = 0

        For Each row As DataGridViewRow In dgv_detailPenjualanDelivery.Rows
            totalQty += Convert.ToInt32(row.Cells("colQty").Value)
        Next

        Return totalQty
    End Function

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub btn_tmbhDetBeli_Click(sender As Object, e As EventArgs) Handles btn_tmbhDetBeliDelivery.Click
        ' VALIDASI INPUT
        If cbo_brgDelivery.SelectedIndex = -1 Or txt_qtyDelivery.Text = "" Or txt_hrgaDelivery.Text = "" Then
            MessageBox.Show("Lengkapi data barang")
            Exit Sub
        End If

        ' AMBIL DATA BARANG
        Dim info As BarangInfo = barangDict(cbo_brgDelivery.Text)
        Dim barangID As String = info.ID
        Dim satuan As String = info.Satuan
        Dim namaBar As String = info.Nama

        Dim qty As Integer = Integer.Parse(txt_qtyDelivery.Text)
        Dim harga As Decimal = BersihkanAngka(txt_hrgaDelivery.Text)
        Dim subtotal As Decimal = qty * harga

        ' ==============================
        ' VALIDASI STOK SEBELUM TAMBAH
        ' ==============================
        Dim stokSaatIni As Integer = GetStokBarang(barangID)

        Dim qtySudahAda As Integer = 0
        For Each r As DataGridViewRow In dgv_detailPenjualanDelivery.Rows
            If r.IsNewRow Then Continue For
            If r.Cells("colKodeBrg").Value.ToString() = barangID Then
                qtySudahAda += Convert.ToInt32(r.Cells("colQty").Value)
            End If
        Next

        Dim totalQtySetelahTambah = qtySudahAda + qty

        If totalQtySetelahTambah > stokSaatIni Then
            MessageBox.Show(
            "Stok tidak mencukupi!" & vbCrLf &
            "Barang: " & namaBar & vbCrLf &
            "Stok: " & stokSaatIni & vbCrLf &
            "Sudah diambil: " & qtySudahAda & vbCrLf &
            "Mau tambah: " & qty,
            "STOK HABIS",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Exit Sub
        End If

        ' TAMBAH KE GRID
        dgv_detailPenjualanDelivery.Rows.Add(
        Nothing,
        barangID,
        namaBar,
        qty,
        satuan,
        harga,
        subtotal
    )

        ' UPDATE LABEL & RESET INPUT
        lbl_hargaSatuanDelivery.Text = Format(harga, "Rp #,##0")
        lbl_subTotalDelivery.Text = Format(subtotal, "Rp #,##0")

        lbl_QtyDelivery.Text = qty.ToString()
        lbl_hargaSatuanDelivery.Text = harga.ToString("N0")
        lbl_subTotalDelivery.Text = subtotal.ToString("N0")

        Dim totalBaru As Decimal = hitungTotalPenjualan()
        Dim qtyBaru As Integer = HitungTotalQty()

        lbl_grandTotalDelivery.Text = totalBaru.ToString("N0")
        lbl_totalQtyDelivery.Text = "Total Barang: " & qtyBaru.ToString()

        cbo_brgDelivery.SelectedIndex = -1
        txt_qtyDelivery.Clear()
        txt_satuanBrgDelivery.Clear()
        txt_hrgaDelivery.Clear()
        txt_subTotalDelivery.Clear()
        txt_namaBrgDelivery.Clear()
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qtyDelivery.TextChanged
        hitungSubtotal()
    End Sub

    Private Sub cbo_statusPenjualan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_statusPenjualanDelivery.SelectedIndexChanged
        If cbo_statusPenjualanDelivery.Text = "Pending" Then
            txt_danaDiterimaDelivery.Text = 0
            txt_danaDiterimaDelivery.ReadOnly = True
            lbl_kembalianDelivery.Text = 0
            cbo_statusDelivery.Text = "Pending"
            cbo_metodePembayaranDelivery.SelectedIndex = -1

        ElseIf cbo_statusPenjualanDelivery.Text = "Lunas" Then
            txt_danaDiterimaDelivery.ReadOnly = False
            cbo_statusDelivery.Text = "Packing"
        End If
    End Sub

    Private Sub txt_danaDiterima_TextChanged(sender As Object, e As EventArgs) Handles txt_danaDiterimaDelivery.TextChanged
        Dim dana As Decimal
        Dim total As Decimal

        If Not Decimal.TryParse(txt_danaDiterimaDelivery.Text, dana) Then
            lbl_kembalianDelivery.Text = "Rp 0"
            cbo_statusPenjualanDelivery.SelectedIndex = -1
            cbo_statusPenjualanDelivery.Enabled = True
            Exit Sub
        End If

        Decimal.TryParse(lbl_grandTotalDelivery.Text, total)

        Dim kembalian As Decimal = dana - total

        lbl_kembalianDelivery.Text = "Rp " & kembalian.ToString("#,##0")

        If kembalian >= 0 Then
            cbo_statusPenjualanDelivery.Text = "Lunas"
            cbo_statusPenjualanDelivery.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_statusPenjualanDelivery.Enabled = True
            cbo_statusPenjualanDelivery.Cursor = Cursors.Default
            cbo_statusPenjualanDelivery.Focus()
        Else
            cbo_statusPenjualanDelivery.Text = ""
            cbo_statusPenjualanDelivery.Enabled = True
        End If
    End Sub

    Private Sub dgv_detailPenjualan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detailPenjualanDelivery.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        If MessageBox.Show("Hapus item ini?", "Hapus", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dgv_detailPenjualanDelivery.Rows.RemoveAt(e.RowIndex)
            lbl_grandTotalDelivery.Text = hitungTotalPenjualan().ToString("N0")
            lbl_totalQtyDelivery.Text = "Total Barang: " & HitungTotalQty().ToString()
            lbl_QtyDelivery.Text = "00"
            lbl_hargaSatuanDelivery.Text = "00.00"
            lbl_subTotalDelivery.Text = "00.00"
            txt_danaDiterimaDelivery.Clear()
        End If
    End Sub

    Private Sub txt_danaDiterima_Leave(sender As Object, e As EventArgs) Handles txt_danaDiterimaDelivery.Leave
        Dim nilai As Decimal

        'Hapus titik atau format lama sebelum parsing
        Decimal.TryParse(txt_danaDiterimaDelivery.Text.Replace(".", "").Replace(",", ""), nilai)

        'Format jadi nominal uang
        txt_danaDiterimaDelivery.Text = nilai.ToString("N0")
    End Sub

    Private Sub txt_danaDiterima_Enter(sender As Object, e As EventArgs) Handles txt_danaDiterimaDelivery.Enter
        txt_danaDiterimaDelivery.Text = txt_danaDiterimaDelivery.Text.Replace(".", "").Replace(",", "")
    End Sub

    Sub clear()
        cbo_brgDelivery.SelectedIndex = -1
        txt_namaBrgDelivery.Text = ""
        txt_qtyDelivery.Text = ""
        txt_satuanBrgDelivery.Text = ""
        txt_hrgaDelivery.Text = ""
        txt_subTotalDelivery.Text = ""
        dgv_detailPenjualanDelivery.Rows.Clear()
        lbl_grandTotalDelivery.Text = "00.00"
        lbl_totalQtyDelivery.Text = "Total Barang:"
        lbl_QtyDelivery.Text = "00"
        lbl_hargaSatuanDelivery.Text = "00.00"
        lbl_subTotalDelivery.Text = "00.00"
        cbo_metodePembayaranDelivery.SelectedIndex = -1
        txt_danaDiterimaDelivery.Text = ""
        lbl_kembalianDelivery.Text = "00.00"
        cbo_statusPenjualanDelivery.SelectedIndex = -1
        txt_catatanDelivery.Text = ""
        lbl_noJualPending.Text = ""
        lbl_tglJualPending.Text = ""
        lbl_totalJualPending.Text = ""
        lbl_metodeJualPending.Text = ""
        lbl_statusJualPending.Text = ""
        rtb_detailPenjualan.Text = ""
        cbo_statusDelivery.SelectedIndex = -1
        txt_atasNamaDelivery.Text = ""
        txt_alamatDelivery.Text = ""
        txt_kontakDelivery.Text = ""
        lbl_jenisJualPending.Text = ""
        lbl_catatanPending.Text = ""
        lbl_atasNamaPending.Text = ""
        lbl_kontakPending.Text = ""
        lbl_statusKirimPending.Text = ""
        lbl_alamatJualPending.Text = ""
    End Sub
    Private Function GetStokBarang(kode As String) As Integer
        Dim stok As Integer = 0
        Dim sql As String = "SELECT stok FROM tblbarang WHERE kode_barang=@kode"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@kode", kode)

            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                stok = Convert.ToInt32(result)
            End If
        End Using

        conn.Close()
        Return stok
    End Function

    Private Sub btn_simpanPenjualan_Click(sender As Object, e As EventArgs) Handles btn_simpanPenjualanDelivery.Click
        If dgv_detailPenjualanDelivery.Rows.Count = 0 Then
            MsgBox("Tidak ada barang yang dibeli!")
            Exit Sub
        End If

        Dim totalBelanja As Decimal = CDec(lbl_grandTotalDelivery.Text)
        Dim danaDiterima As Decimal = 0

        ' Cek apakah input kosong atau bukan angka
        If String.IsNullOrWhiteSpace(txt_danaDiterimaDelivery.Text) OrElse Not Decimal.TryParse(txt_danaDiterimaDelivery.Text, danaDiterima) Then
            MsgBox("Masukkan nominal dana yang diterima!", vbExclamation)
            Exit Sub
        End If

        ' Cek jika status lunas tapi dana kurang
        If cbo_statusPenjualanDelivery.Text = "Lunas" AndAlso danaDiterima < totalBelanja Then
            MsgBox("Dana yang diterima kurang dari total belanja!", vbCritical)
            Exit Sub
        End If

        ' === VALIDASI STOK SEBELUM SIMPAN ===
        For Each row As DataGridViewRow In dgv_detailPenjualanDelivery.Rows
            If row.IsNewRow Then Continue For

            Dim kodeBarang As String = row.Cells("colKodeBrg").Value.ToString()
            Dim qtyBeli As Integer = Convert.ToInt32(row.Cells("colQty").Value)
            Dim stokSaatIni As Integer = GetStokBarang(kodeBarang)

            If qtyBeli > stokSaatIni Then
                MsgBox("Stok untuk barang '" & row.Cells("colNmaBrg").Value.ToString() &
               "' tidak mencukupi!" & vbCrLf &
               "Stok: " & stokSaatIni & ", Diminta: " & qtyBeli, vbCritical)

                Exit Sub ' ---> Hentikan proses simpan
            End If
        Next

        Dim penjualanID As String = txt_noPenjualanDelivery.Text
        Dim transaction As MySqlTransaction = Nothing

        Try
            conn.Open()
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcodePenjualanDelivery.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()
            transaction = conn.BeginTransaction()

            Dim sqlPenjualan As String =
        "INSERT INTO tblpenjualan (tanggal, no_penjualan, jenis_penjualan, total_penjualan, dana_diterima, kembalian, metode_pembayaran, status_penjualan, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman, barcode_pengiriman)" &
        "VALUES (@tanggal, @no_penjualan, @jenis_penjualan, @total_penjualan, @dana_diterima, @kembalian, @metode_pembayaran, @status_penjualan, @catatan, @atas_nama, @kontak_penerima, @alamat, @status_pengiriman, @barcode_pengiriman)"

            cmd = New MySqlCommand(sqlPenjualan, conn, transaction)
            cmd.Parameters.AddWithValue("@tanggal", dtp_tglJualDelivery.Value)
            cmd.Parameters.AddWithValue("@no_penjualan", txt_noPenjualanDelivery.Text)
            cmd.Parameters.AddWithValue("@jenis_penjualan", txtJenisDelivery.Text)
            cmd.Parameters.AddWithValue("@total_penjualan", BersihkanAngka(lbl_grandTotalDelivery.Text))
            cmd.Parameters.AddWithValue("@dana_diterima", BersihkanAngka(txt_danaDiterimaDelivery.Text))
            cmd.Parameters.AddWithValue("@kembalian", BersihkanAngka(lbl_kembalianDelivery.Text))
            cmd.Parameters.AddWithValue("@metode_pembayaran", cbo_metodePembayaranDelivery.Text)
            cmd.Parameters.AddWithValue("@status_penjualan", cbo_statusPenjualanDelivery.Text)
            cmd.Parameters.AddWithValue("@catatan", txt_catatanDelivery.Text)
            cmd.Parameters.AddWithValue("@atas_nama", txt_atasNamaDelivery.Text)
            cmd.Parameters.AddWithValue("@kontak_penerima", txt_kontakDelivery.Text)
            cmd.Parameters.AddWithValue("@alamat", txt_alamatDelivery.Text)
            cmd.Parameters.AddWithValue("@status_pengiriman", cbo_statusDelivery.Text)
            cmd.Parameters.AddWithValue("@barcode_pengiriman", arrImage)
            cmd.ExecuteNonQuery()


            For Each row As DataGridViewRow In dgv_detailPenjualanDelivery.Rows

                If row.IsNewRow Then Continue For

                Dim sqlDetail As String =
        "INSERT INTO tbldetailpenjualan (no_penjualan, kode_barang, nama_barang, qty, satuan, harga, subtotal) " &
        "VALUES (@no_penjualan, @kode_barang, @nama_barang, @qty, @satuan, @harga, @subtotal)"

                Dim cmdDetail As New MySqlCommand(sqlDetail, conn, transaction)
                cmdDetail.Parameters.AddWithValue("@no_penjualan", penjualanID)
                cmdDetail.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBrg").Value)
                cmdDetail.Parameters.AddWithValue("@nama_barang", row.Cells("colNmaBrg").Value)
                cmdDetail.Parameters.AddWithValue("@qty", row.Cells("colQty").Value)
                cmdDetail.Parameters.AddWithValue("@satuan", row.Cells("colSatuan").Value)
                cmdDetail.Parameters.AddWithValue("@harga", Convert.ToDecimal(row.Cells("colHarga").Value))
                cmdDetail.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(row.Cells("colSubtotal").Value))
                cmdDetail.ExecuteNonQuery()

                ' update stok
                Dim sqlUpdateStok As String =
        "UPDATE tblbarang SET stok = stok - @qty WHERE kode_barang = @kode_barang"

                Dim cmdStok As New MySqlCommand(sqlUpdateStok, conn, transaction)
                cmdStok.Parameters.AddWithValue("@qty", row.Cells("colQty").Value)
                cmdStok.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBrg").Value)
                cmdStok.ExecuteNonQuery()

            Next

            transaction.Commit()
            MsgBox("Sukses!", vbInformation)
            changelongpaper()
            PD.DefaultPageSettings.PaperSize = New PaperSize("Custom", 280, longpaper)

            PPD.Document = PD
            PPD.ShowDialog() ' → preview sebelum print
        Catch ex As Exception
            Try
                transaction.Rollback()
            Catch
            End Try
            MsgBox("Gagal menyimpan transaksi: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            dgv_detailPenjualanDelivery.Rows.Clear()
            clear()
            cbo_statusDelivery.Text = "Pending"

            load_barang()
            frm_ManageStok.load_stock()
            frm_ManageStok.CekStokMenipis()
            frm_ManageBarang.load_Barang()
            load_ListPenjualanPending()
            load_ListPenjualanDeliveryPacking()
            GenerateNoPenjualan()
            frm_ManagePenjualanPickup.GenerateNoPenjualan()
            mainForm_Cashier.GenerateNoPenjualan()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancelDelivery.Click
        clear()
    End Sub

    Private Sub txt_cariPenjualan_TextChanged(sender As Object, e As EventArgs) Handles txt_cariPenjualan.TextChanged
        dgv_listPenjualanPending.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("
                SELECT * FROM tblpenjualan
                WHERE status_penjualan = 'Pending' AND jenis_penjualan = 'Delivery'
                AND (
                    LOWER(no_penjualan) LIKE LOWER(@keyword)
                    OR LOWER(tanggal) LIKE LOWER(@keyword)
                    OR LOWER(atas_nama) LIKE LOWER(@keyword)
                    OR LOWER(metode_pembayaran) LIKE LOWER(@keyword)
                )
                ", conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & txt_cariPenjualan.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                Dim tgl As Date = Date.Parse(dr("tanggal").ToString())
                dgv_listPenjualanPending.Rows.Add(
                dgv_listPenjualanPending.Rows.Count + 1,
                dr("no_penjualan").ToString(),
                dr("jenis_penjualan").ToString(),
                tgl.ToString("dd/MM/yyyy"),
                "Rp. " & Format(CDec(dr("total_penjualan")), "N0"),
                "Rp. " & Format(CDec(dr("dana_diterima")), "N0"),
                "Rp. " & Format(CDec(dr("kembalian")), "N0"),
                dr("metode_pembayaran").ToString(),
                dr("catatan").ToString(),
                dr("atas_nama").ToString(),
                dr("kontak_penerima").ToString(),
                dr("alamat").ToString(),
                dr("status_pengiriman").ToString()
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnPickup_Click(sender As Object, e As EventArgs) Handles btnPickup.Click
        frm_ManagePenjualanPickup.Show()
        Me.Hide()
    End Sub

    Private Sub TampilkanDetailPenjualanPending(noPenjualan As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' === TAMPILKAN HEADER PENJUALAN ===
            Dim queryHeader As String =
        "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, metode_pembayaran, status_penjualan, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
         FROM tblpenjualan
         WHERE status_penjualan = 'Pending' AND no_penjualan = @noPenjualan"

            Using cmd As New MySqlCommand(queryHeader, conn)
                cmd.Parameters.AddWithValue("@noPenjualan", noPenjualan)

                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        lbl_noJualPending.Text = "No Penjualan: " & rd("no_penjualan").ToString()
                        lbl_jenisJualPending.Text = "Jenis Penjualan: " & rd("jenis_penjualan").ToString()
                        lbl_tglJualPending.Text = "Tanggal: " & CDate(rd("tanggal")).ToString("dd MMM yyyy")
                        lbl_totalJualPending.Text = "Total: Rp. " & Format(CDec(rd("total_penjualan")), "N0")
                        lbl_metodeJualPending.Text = "Metode: " & rd("metode_pembayaran").ToString()
                        lbl_statusJualPending.Text = "Status: " & rd("status_penjualan").ToString()
                        lbl_catatanPending.Text = "Catatan: " & rd("catatan").ToString()

                        lbl_atasNamaPending.Text = "Atas Nama: " & rd("atas_nama").ToString()
                        lbl_kontakPending.Text = "Kontak: " & rd("kontak_penerima").ToString()
                        lbl_alamatJualPending.Text = "Alamat: " & rd("alamat").ToString()
                        lbl_statusKirimPending.Text = "Status Kirim: " & rd("status_pengiriman").ToString()
                    Else
                        MsgBox("Data penjualan Pending tidak ditemukan!", vbExclamation)
                        Exit Sub
                    End If
                End Using
            End Using

            ' === TAMPILKAN DETAIL ITEM ===
            Dim queryDetail As String =
        "SELECT nama_barang, qty, satuan, harga, subtotal
         FROM tbldetailpenjualan
         WHERE no_penjualan = @noPenjualan"

            Dim da As New MySqlDataAdapter(queryDetail, conn)
            da.SelectCommand.Parameters.AddWithValue("@noPenjualan", noPenjualan)

            Dim dt As New DataTable()
            da.Fill(dt)

            rtb_detailPenjualan.Clear()

            Dim nomor As Integer = 1

            For Each row As DataRow In dt.Rows
                rtb_detailPenjualan.AppendText(
                nomor & ". " & row("nama_barang").ToString() & vbCrLf &
                "   Qty      : " & row("qty").ToString() & " " & row("satuan").ToString() & vbCrLf &
                "   Harga    : Rp. " & Format(CDec(row("harga")), "N0") & vbCrLf &
                "   Subtotal : Rp. " & Format(CDec(row("subtotal")), "N0") & vbCrLf &
                "----------------------------------------" & vbCrLf
            )
                nomor += 1
            Next

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub TampilkanDetailPenjualanPacking(noPenjualan As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' === TAMPILKAN HEADER PENJUALAN ===
            Dim queryHeader As String =
        "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, metode_pembayaran, status_penjualan, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
         FROM tblpenjualan
         WHERE status_pengiriman = 'Packing' AND no_penjualan = @noPenjualan"

            Using cmd As New MySqlCommand(queryHeader, conn)
                cmd.Parameters.AddWithValue("@noPenjualan", noPenjualan)

                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        lbl_noJualPacking.Text = "No Penjualan: " & rd("no_penjualan").ToString()
                        lbl_jenisJualPacking.Text = "Jenis Penjualan: " & rd("jenis_penjualan").ToString()
                        lbl_tglJualPacking.Text = "Tanggal: " & CDate(rd("tanggal")).ToString("dd MMM yyyy")
                        lbl_totalJualPacking.Text = "Total: Rp. " & Format(CDec(rd("total_penjualan")), "N0")
                        lbl_metodeJualPacking.Text = "Metode: " & rd("metode_pembayaran").ToString()
                        lbl_statusJualPacking.Text = "Status: " & rd("status_penjualan").ToString()
                        lbl_catatanPacking.Text = "Catatan: " & rd("catatan").ToString()

                        lbl_atasNamaPacking.Text = "Atas Nama: " & rd("atas_nama").ToString()
                        lbl_kontakPacking.Text = "Kontak: " & rd("kontak_penerima").ToString()
                        lbl_alamatJualPacking.Text = "Alamat: " & rd("alamat").ToString()
                        lbl_statusKirimPacking.Text = "Status Kirim: " & rd("status_pengiriman").ToString()
                    Else
                        MsgBox("Data penjualan Packing tidak ditemukan!", vbExclamation)
                        Exit Sub
                    End If
                End Using
            End Using

            ' === TAMPILKAN DETAIL ITEM ===
            Dim queryDetail As String =
        "SELECT nama_barang, qty, satuan, harga, subtotal
         FROM tbldetailpenjualan
         WHERE no_penjualan = @noPenjualan"

            Dim da As New MySqlDataAdapter(queryDetail, conn)
            da.SelectCommand.Parameters.AddWithValue("@noPenjualan", noPenjualan)

            Dim dt As New DataTable()
            da.Fill(dt)

            rtb_detailPenjualanPacking.Clear()

            Dim nomor As Integer = 1

            For Each row As DataRow In dt.Rows
                rtb_detailPenjualanPacking.AppendText(
                nomor & ". " & row("nama_barang").ToString() & vbCrLf &
                "   Qty      : " & row("qty").ToString() & " " & row("satuan").ToString() & vbCrLf &
                "   Harga    : Rp. " & Format(CDec(row("harga")), "N0") & vbCrLf &
                "   Subtotal : Rp. " & Format(CDec(row("subtotal")), "N0") & vbCrLf &
                "----------------------------------------" & vbCrLf
            )
                nomor += 1
            Next

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub dgv_listPenjualanPending_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listPenjualanPending.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idJualPending As String = dgv_listPenjualanPending.Rows(e.RowIndex).Cells("colNoPenjualan").Value.ToString()

        TampilkanDetailPenjualanPending(idJualPending)
    End Sub

    Private Sub btn_updateLunasPenjualan_Click(sender As Object, e As EventArgs) Handles btn_updateLunasPenjualan.Click
        If dgv_listPenjualanPending.Rows.Count = 0 Then
            MsgBox("Tidak ada data penjualan pending!", vbExclamation)
            Exit Sub
        End If

        Dim baris As Integer = dgv_listPenjualanPending.CurrentRow.Index

        Dim formPopup As New frm_UpdateStatusPengiriman
        formPopup.lbl_noPenjualanKirimLunas.Text = dgv_listPenjualanPending.Item("colNoPenjualan", baris).Value.ToString()

        formPopup.ShowDialog()
    End Sub

    Private Sub btn_clearPenjualanPending_Click(sender As Object, e As EventArgs) Handles btn_clearPenjualanPending.Click
        clear()
    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgv_detailPenjualanDelivery.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f12 As New Font("Calibri", 12, FontStyle.Bold)
        Dim leftmargin As Integer = 5
        Dim y As Integer = 5
        Dim xItem As Integer = leftmargin
        Dim xQty As Integer = 120
        Dim xHarga As Integer = 170
        Dim xSubtotal As Integer = 240

        ' Header toko
        e.Graphics.DrawString("TOKO IM", f12, Brushes.Black, leftmargin, y)
        y += 20
        e.Graphics.DrawString("Tanjung Uma", f10, Brushes.Black, leftmargin, y)
        y += 20
        e.Graphics.DrawString("Batam", f10, Brushes.Black, leftmargin, y)
        y += 20
        ' Info Transaksi
        e.Graphics.DrawString("No: " & txt_noPenjualanDelivery.Text, f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("Tanggal: " & dtp_tglJualDelivery.Value.ToString("dd/MM/yyyy HH:mm"), f10, Brushes.Black, leftmargin, y)
        y += 18

        e.Graphics.DrawString("====================================", f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Jenis: " & txtJenisDelivery.Text, f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("Atas Nama: " & txt_atasNamaDelivery.Text, f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("Kontak: " & txt_kontakDelivery.Text, f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("Alamat: " & txt_alamatDelivery.Text, f10, Brushes.Black, leftmargin, y)
        y += 18

        e.Graphics.DrawString("====================================", f10, Brushes.Black, leftmargin, y)
        y += 25

        ' Header kolom
        e.Graphics.DrawString("Item", f10, Brushes.Black, xItem, y)
        e.Graphics.DrawString("Qty", f10, Brushes.Black, xQty, y)
        e.Graphics.DrawString("Harga", f10, Brushes.Black, xHarga, y)
        e.Graphics.DrawString("Subtotal", f10, Brushes.Black, xSubtotal, y)
        y += 20

        For Each row As DataGridViewRow In dgv_detailPenjualanDelivery.Rows
            If row.IsNewRow Then Continue For

            Dim nama = row.Cells("colNmaBrg").Value.ToString()
            Dim qty = row.Cells("colQty").Value.ToString()
            Dim harga = CDec(row.Cells("colHarga").Value).ToString("N0")
            Dim subtotal = CDec(row.Cells("colSubtotal").Value).ToString("N0")

            ' Nama barang (full baris)
            e.Graphics.DrawString(nama, f10, Brushes.Black, xItem, y)
            y += 15

            ' Baris Qty – Harga – Subtotal yang rata kolom
            e.Graphics.DrawString(qty, f10, Brushes.Black, xQty, y)
            e.Graphics.DrawString(harga, f10, Brushes.Black, xHarga, y)
            e.Graphics.DrawString(subtotal, f10, Brushes.Black, xSubtotal, y)
            y += 25
        Next

        e.Graphics.DrawString("====================================", f10, Brushes.Black, leftmargin, y)
        y += 25

        ' Total pembayaran
        e.Graphics.DrawString("Total: Rp " & Format(CDec(lbl_grandTotalDelivery.Text.Replace("Rp ", "").Replace(",", "")), "N0"), f12, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Bayar: Rp " & txt_danaDiterimaDelivery.Text, f10, Brushes.Black, leftmargin, y)
        y += 20

        e.Graphics.DrawString("Kembali: Rp " & lbl_kembalianDelivery.Text, f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Terima kasih!", f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString(cbo_statusPenjualanDelivery.Text, f12, Brushes.Black, leftmargin, y)
        y += 20

        e.Graphics.DrawImage(pic_barcodePenjualanDelivery.Image, leftmargin, y)
        y += pic_barcodePenjualanDelivery.Image.Height + 10
    End Sub

    Private Sub dgv_penjualanDeliveryPacking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_penjualanDeliveryPacking.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idJualPacking As String = dgv_penjualanDeliveryPacking.Rows(e.RowIndex).Cells("colNoPenjualanPacking").Value.ToString()

        TampilkanDetailPenjualanPacking(idJualPacking)
    End Sub

    Private Sub btnSemuaListPenjualan_Click(sender As Object, e As EventArgs) Handles btnSemuaListPenjualan.Click
        frm_ListSemuaPenjualan.Show()
        Me.Hide()
    End Sub
End Class