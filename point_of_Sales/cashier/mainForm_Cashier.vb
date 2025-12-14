Imports System.Drawing.Printing
Imports MessagingToolkit.Barcode.QRCode.Decoder
Imports MySql.Data.MySqlClient
Public Class mainForm_Cashier
    Public Class BarangInfo
        Public Property ID As String
        Public Property Satuan As String
        Public Property Nama As String
        Public Property Harga As String

    End Class

    Public barangDict As New Dictionary(Of String, BarangInfo)

    Private totalPenjualan As Decimal = 0

    Function hitungTotalPenjualan() As Decimal
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgv_detailPenjualan.Rows
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

    Function BersihkanAngka(input As String) As Decimal
        If String.IsNullOrWhiteSpace(input) Then Return 0
        input = input.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim()
        Dim hasil As Decimal
        Decimal.TryParse(input, hasil)
        Return hasil
    End Function

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Sub load_barang()
        cbo_brg.Items.Clear()
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

                cbo_brg.Items.Add(kode)

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

    Sub load_ListPenjualanPending()
        dgv_listPenjualanPending.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, catatan
             FROM tblpenjualan 
             WHERE status_penjualan = 'Pending' AND jenis_penjualan = 'Langsung (In-Person)'
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
                        dr("catatan").ToString()
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
        txt_noPenjualan.Text = $"{prefix}-{Date.Now:yyMMdd}-{newIncrement:0000}"
        txt_noPenjualan.ReadOnly = True
    End Sub

    Sub clear()
        cbo_brg.SelectedIndex = -1
        txt_namaBrg.Text = ""
        txt_qty.Text = ""
        txt_satuanBrg.Text = ""
        txt_hrga.Text = ""
        txt_subTotal.Text = ""
        dgv_detailPenjualan.Rows.Clear()
        lbl_grandTotal.Text = "00.00"
        lbl_totalQty.Text = "Total Barang:"
        lbl_Qty.Text = "00"
        lbl_hargaSatuan.Text = "00.00"
        lbl_subTotal.Text = "00.00"
        cbo_metodePembayaran.SelectedIndex = -1
        txt_danaDiterima.Text = ""
        lbl_kembalianLangsung.Text = "00.00"
        cbo_statusPenjualan.SelectedIndex = -1
        txt_catatan.Text = ""
        lbl_noJualPending.Text = ""
        lbl_tglJualPending.Text = ""
        lbl_totalJualPending.Text = ""
        lbl_metodeJualPending.Text = ""
        lbl_statusJualPending.Text = ""
        rtb_detailPenjualan.Text = ""
        lbl_kembalianPending.Text = ""
        lbl_danaDiterimaPending.Text = ""
        lbl_catatanPending.Text = ""
        lbl_statusJualPending.Text = ""
        lbl_jenisJualPending.Text = ""
    End Sub

    Private Sub TampilkanDetailPenjualanPending(noPenjualan As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' === TAMPILKAN HEADER PENJUALAN ===
            Dim queryHeader As String =
        "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, status_penjualan, catatan
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
                        lbl_danaDiterimaPending.Text = "Dana Diterima: Rp. " & Format(CDec(rd("dana_diterima")), "N0")
                        lbl_kembalianPending.Text = "Kembalian: Rp. " & Format(CDec(rd("kembalian")), "N0")
                        lbl_metodeJualPending.Text = "Metode: " & rd("metode_pembayaran").ToString()
                        lbl_statusJualPending.Text = "Status: " & rd("status_penjualan").ToString()
                        lbl_catatanPending.Text = "Catatan: " & rd("catatan").ToString()
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

    Private Sub mainForm_Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_listPenjualanPending.RowTemplate.Height = 30

        dbconn()

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want

        load_barang()
        GenerateNoPenjualan()
        load_ListPenjualanPending()

        lbl_grandTotal.TextAlign = ContentAlignment.MiddleRight
        lbl_Qty.TextAlign = ContentAlignment.MiddleRight
        lbl_totalQty.TextAlign = ContentAlignment.MiddleRight
        lbl_hargaSatuan.TextAlign = ContentAlignment.MiddleRight
        lbl_subTotal.TextAlign = ContentAlignment.MiddleRight
        lbl_kembalianLangsung.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin ingin logout?", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
            loginForm.Show()
        Else
            Return
        End If
    End Sub

    Private Sub cbo_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_brg.SelectedIndexChanged
        If cbo_brg.SelectedIndex <> -1 Then
            Dim id As String = cbo_brg.Text

            If barangDict.ContainsKey(id) Then
                txt_namaBrg.Text = barangDict(id).Nama
                txt_satuanBrg.Text = barangDict(id).Satuan
                txt_hrga.Text = barangDict(id).Harga
            End If
        End If
        hitungSubtotal()
    End Sub

    Private Sub closeBtn_Click_1(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        hitungSubtotal()
    End Sub

    Sub hitungSubtotal()
        Dim harga As Decimal
        Dim qty As Decimal

        harga = BersihkanAngka(txt_hrga.Text)
        Decimal.TryParse(txt_qty.Text, qty)

        Dim subtotal As Decimal = harga * qty

        'Format textbox
        txt_hrga.Text = harga.ToString("N0")
        txt_subTotal.Text = subtotal.ToString("N0")
    End Sub

    Function HitungTotalQty() As Integer
        Dim totalQty As Integer = 0

        For Each row As DataGridViewRow In dgv_detailPenjualan.Rows
            totalQty += Convert.ToInt32(row.Cells("colQty").Value)
        Next

        Return totalQty
    End Function

    Private Sub btn_tmbhDetJual_Click(sender As Object, e As EventArgs) Handles btn_tmbhDetJual.Click
        ' VALIDASI INPUT
        If cbo_brg.SelectedIndex = -1 Or txt_qty.Text = "" Or txt_hrga.Text = "" Then
            MessageBox.Show("Lengkapi data barang")
            Exit Sub
        End If

        ' AMBIL DATA BARANG
        Dim info As BarangInfo = barangDict(cbo_brg.Text)
        Dim barangID As String = info.ID
        Dim satuan As String = info.Satuan
        Dim namaBar As String = info.Nama

        Dim qty As Integer = Integer.Parse(txt_qty.Text)
        Dim harga As Decimal = BersihkanAngka(txt_hrga.Text)
        Dim subtotal As Decimal = qty * harga

        ' ==============================
        ' VALIDASI STOK SEBELUM TAMBAH
        ' ==============================
        Dim stokSaatIni As Integer = GetStokBarang(barangID)

        Dim qtySudahAda As Integer = 0
        For Each r As DataGridViewRow In dgv_detailPenjualan.Rows
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
        dgv_detailPenjualan.Rows.Add(
        Nothing,
        barangID,
        namaBar,
        qty,
        satuan,
        harga,
        subtotal
    )

        ' UPDATE LABEL & RESET INPUT
        lbl_hargaSatuan.Text = Format(harga, "Rp #,##0")
        lbl_subTotal.Text = Format(subtotal, "Rp #,##0")

        lbl_Qty.Text = qty.ToString()
        lbl_hargaSatuan.Text = harga.ToString("N0")
        lbl_subTotal.Text = subtotal.ToString("N0")

        Dim totalBaru As Decimal = hitungTotalPenjualan()
        Dim qtyBaru As Integer = HitungTotalQty()

        lbl_grandTotal.Text = totalBaru.ToString("N0")
        lbl_totalQty.Text = "Total Barang: " & qtyBaru.ToString()

        cbo_brg.SelectedIndex = -1
        txt_qty.Clear()
        txt_satuanBrg.Clear()
        txt_hrga.Clear()
        txt_subTotal.Clear()
        txt_namaBrg.Clear()
    End Sub

    Private Sub dgv_detailPenjualan_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv_detailPenjualan.RowPostPaint
        dgv_detailPenjualan.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub dgv_detailPenjualan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detailPenjualan.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        If MessageBox.Show("Hapus item ini?", "Hapus", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dgv_detailPenjualan.Rows.RemoveAt(e.RowIndex)
            lbl_grandTotal.Text = hitungTotalPenjualan().ToString("N0")
            lbl_totalQty.Text = "Total Barang: " & HitungTotalQty().ToString()
            lbl_Qty.Text = "00"
            lbl_hargaSatuan.Text = "00.00"
            lbl_subTotal.Text = "00.00"
            txt_danaDiterima.Clear()
        End If
    End Sub

    Private Sub txt_danaDiterima_TextChanged(sender As Object, e As EventArgs) Handles txt_danaDiterima.TextChanged
        Dim dana As Decimal
        Dim total As Decimal

        If Not Decimal.TryParse(txt_danaDiterima.Text, dana) Then
            lbl_kembalianLangsung.Text = "Rp 0"
            cbo_statusPenjualan.SelectedIndex = -1
            cbo_statusPenjualan.Enabled = True
            Exit Sub
        End If

        Decimal.TryParse(lbl_grandTotal.Text, total)

        Dim kembalian As Decimal = dana - total

        lbl_kembalianLangsung.Text = "Rp " & kembalian.ToString("#,##0")

        If kembalian >= 0 Then
            cbo_statusPenjualan.Text = "Lunas"
            cbo_statusPenjualan.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_statusPenjualan.Enabled = True
            cbo_statusPenjualan.Cursor = Cursors.Default
            cbo_statusPenjualan.Focus()
        Else
            cbo_statusPenjualan.Text = ""
            cbo_statusPenjualan.Enabled = True
        End If
    End Sub

    Private Sub cbo_statusPenjualan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_statusPenjualan.SelectedIndexChanged
        If cbo_statusPenjualan.Text = "Pending" Then
            txt_danaDiterima.Text = 00.00
            txt_danaDiterima.ReadOnly = True
            lbl_kembalianLangsung.Text = 00.00
            cbo_metodePembayaran.SelectedIndex = -1

        ElseIf cbo_statusPenjualan.Text = "Lunas" Then
            txt_danaDiterima.ReadOnly = False
        End If
    End Sub

    Private Sub txt_danaDiterima_Leave(sender As Object, e As EventArgs) Handles txt_danaDiterima.Leave
        Dim nilai As Decimal

        'Hapus titik atau format lama sebelum parsing
        Decimal.TryParse(txt_danaDiterima.Text.Replace(".", "").Replace(",", ""), nilai)

        'Format jadi nominal uang
        txt_danaDiterima.Text = nilai.ToString("N0")
    End Sub

    Private Sub txt_danaDiterima_Enter(sender As Object, e As EventArgs) Handles txt_danaDiterima.Enter
        txt_danaDiterima.Text = txt_danaDiterima.Text.Replace(".", "").Replace(",", "")
    End Sub

    Private Sub txt_noPenjualanPickup_TextChanged(sender As Object, e As EventArgs) Handles txt_noPenjualan.TextChanged
        lbl_noPenjualan.Text = "No Penjualan: " & txt_noPenjualan.Text
    End Sub

    Private Sub btn_simpanPenjualan_Click(sender As Object, e As EventArgs) Handles btn_simpanPenjualan.Click
        If dgv_detailPenjualan.Rows.Count = 0 Then
            MsgBox("Tidak ada barang yang dibeli!")
            Exit Sub
        End If

        Dim totalBelanja As Decimal = CDec(lbl_grandTotal.Text)
        Dim danaDiterima As Decimal = 0

        ' Cek apakah input kosong atau bukan angka
        If String.IsNullOrWhiteSpace(txt_danaDiterima.Text) OrElse Not Decimal.TryParse(txt_danaDiterima.Text, danaDiterima) Then
            MsgBox("Masukkan nominal dana yang diterima!", vbExclamation)
            Exit Sub
        End If

        ' Cek jika status lunas tapi dana kurang
        If cbo_statusPenjualan.Text = "Lunas" AndAlso danaDiterima < totalBelanja Then
            MsgBox("Dana yang diterima kurang dari total belanja!", vbCritical)
            Exit Sub
        End If

        ' === VALIDASI STOK SEBELUM SIMPAN ===
        For Each row As DataGridViewRow In dgv_detailPenjualan.Rows
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

        Dim penjualanID As String = txt_noPenjualan.Text
        Dim transaction As MySqlTransaction = Nothing

        Try
            conn.Open()
            transaction = conn.BeginTransaction()

            Dim sqlPenjualan As String =
        "INSERT INTO tblpenjualan (tanggal, no_penjualan, jenis_penjualan, total_penjualan, dana_diterima, kembalian, metode_pembayaran, status_penjualan, catatan)" &
        "VALUES (@tanggal, @no_penjualan, @jenis_penjualan, @total_penjualan, @dana_diterima, @kembalian, @metode_pembayaran, @status_penjualan, @catatan)"

            cmd = New MySqlCommand(sqlPenjualan, conn, transaction)
            cmd.Parameters.AddWithValue("@tanggal", dtp_tglJual.Value)
            cmd.Parameters.AddWithValue("@no_penjualan", txt_noPenjualan.Text)
            cmd.Parameters.AddWithValue("@jenis_penjualan", txtjenisPenjualan.Text)
            cmd.Parameters.AddWithValue("@total_penjualan", BersihkanAngka(lbl_grandTotal.Text))
            cmd.Parameters.AddWithValue("@dana_diterima", BersihkanAngka(txt_danaDiterima.Text))
            cmd.Parameters.AddWithValue("@kembalian", BersihkanAngka(lbl_kembalianLangsung.Text))
            cmd.Parameters.AddWithValue("@metode_pembayaran", cbo_metodePembayaran.Text)
            cmd.Parameters.AddWithValue("@status_penjualan", cbo_statusPenjualan.Text)
            cmd.Parameters.AddWithValue("@catatan", txt_catatan.Text)
            cmd.ExecuteNonQuery()


            For Each row As DataGridViewRow In dgv_detailPenjualan.Rows

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
            dgv_detailPenjualan.Rows.Clear()
            clear()

            load_barang()
            frm_ManageStok.load_stock()
            frm_ManageStok.CekStokMenipis()
            frm_ManageBarang.load_Barang()
            load_ListPenjualanPending()
            GenerateNoPenjualan()
            frm_ManagePenjualanDelivery.GenerateNoPenjualan()
            frm_ManagePenjualanPickup.GenerateNoPenjualan()
        End Try
    End Sub

    Private Sub dgv_listPenjualanPending_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listPenjualanPending.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idJualPending As String = dgv_listPenjualanPending.Rows(e.RowIndex).Cells("colNoPenjualan").Value.ToString()

        TampilkanDetailPenjualanPending(idJualPending)
    End Sub

    Private Sub btn_clearPenjualanPending_Click(sender As Object, e As EventArgs) Handles btn_clearPenjualanPending.Click
        clear()
    End Sub

    Private Sub btn_updateLunasPenjualan_Click(sender As Object, e As EventArgs) Handles btn_updateLunasPenjualan.Click
        If dgv_listPenjualanPending.Rows.Count = 0 Then
            MsgBox("Tidak ada data penjualan pending!", vbExclamation)
            Exit Sub
        End If

        Dim baris As Integer = dgv_listPenjualanPending.CurrentRow.Index

        Dim formPopup As New frm_UpdateLunas_DanaDiterima
        formPopup.lbl_noPenjualanPENDING.Text = dgv_listPenjualanPending.Item("colNoPenjualan", baris).Value.ToString()
        formPopup.lbl_totalPENDING.Text = dgv_listPenjualanPending.Item("colTotalPenjualan", baris).Value.ToString()

        formPopup.ShowDialog()
    End Sub

    Private Sub txt_cariPenjualan_TextChanged(sender As Object, e As EventArgs) Handles txt_cariPenjualan.TextChanged
        dgv_listPenjualanPending.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("
                SELECT * FROM tblpenjualan
                WHERE status_penjualan = 'Pending' AND jenis_penjualan = 'Langsung (In-Person)'
                AND (
                    LOWER(no_penjualan) LIKE LOWER(@keyword)
                    OR LOWER(tanggal) LIKE LOWER(@keyword)
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
                dr("catatan").ToString()
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnDeliveryPickup_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        frm_ManagePenjualanDelivery.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    Private Sub btnPickup_Click(sender As Object, e As EventArgs) Handles btnPickup.Click
        frm_ManagePenjualanPickup.Show()
        Me.Hide()
    End Sub
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgv_detailPenjualan.Rows.Count
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
        e.Graphics.DrawString("No: " & txt_noPenjualan.Text, f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("Tanggal: " & dtp_tglJual.Value.ToString("dd/MM/yyyy HH:mm"), f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("====================================", f10, Brushes.Black, leftmargin, y)
        y += 25

        ' Header kolom
        e.Graphics.DrawString("Item", f10, Brushes.Black, xItem, y)
        e.Graphics.DrawString("Qty", f10, Brushes.Black, xQty, y)
        e.Graphics.DrawString("Harga", f10, Brushes.Black, xHarga, y)
        e.Graphics.DrawString("Subtotal", f10, Brushes.Black, xSubtotal, y)
        y += 20

        For Each row As DataGridViewRow In dgv_detailPenjualan.Rows
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
        e.Graphics.DrawString("Total: Rp " & Format(CDec(lbl_grandTotal.Text.Replace("Rp ", "").Replace(",", "")), "N0"), f12, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Bayar: Rp " & txt_danaDiterima.Text, f10, Brushes.Black, leftmargin, y)
        y += 20

        e.Graphics.DrawString("Kembali: Rp " & lbl_kembalianLangsung.Text, f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Terima kasih!", f10, Brushes.Black, leftmargin, y)
    End Sub

    Private Sub btnSemuaListPenjualan_Click(sender As Object, e As EventArgs) Handles btnSemuaListPenjualan.Click
        frm_ListSemuaPenjualan.Show()
        Me.Hide()
    End Sub
End Class