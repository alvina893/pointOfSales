Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class frm_ManagePenjualan
    Private Sub frm_ManagePenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want

        dgv_listPenjualan.RowTemplate.Height = 30
        GenerateNoPenjualan()
        CekDanaHariIni()
        load_barang()
        load_ListPenjualanPending()
        load_ListPenjualan()
        cbo_statusPickup.Text = "Pending"
        cbo_statusDelivery.Text = "Pending"
    End Sub

    Sub load_ListPenjualan()
        dgv_listPenjualan.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, status_penjualan, catatan
             FROM tblpenjualan"

            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim tgl As Date = Date.Parse(dr("tanggal").ToString())
                        dgv_listPenjualan.Rows.Add(
                        dgv_listPenjualan.Rows.Count + 1,
                        dr("no_penjualan").ToString(),
                        dr("jenis_penjualan").ToString(),
                        tgl.ToString("dd/MM/yyyy"),
                        "Rp. " & Format(CDec(dr("total_penjualan")), "N0"),
                        "Rp. " & Format(CDec(dr("dana_diterima")), "N0"),
                        "Rp. " & Format(CDec(dr("kembalian")), "N0"),
                        dr("metode_pembayaran").ToString(),
                        dr("status_penjualan").ToString(),
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

    Sub load_ListPenjualanPending()
        dgv_listPenjualanPending.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, catatan
             FROM tblpenjualan 
             WHERE status_penjualan = 'Pending'
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

    Private Sub TampilkanDetailPenjualan(noPenjualan As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' === TAMPILKAN HEADER PENJUALAN ===
            Dim queryHeader As String =
        "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, status_penjualan, catatan
         FROM tblpenjualan
         WHERE no_penjualan = @noPenjualan"

            Using cmd As New MySqlCommand(queryHeader, conn)
                cmd.Parameters.AddWithValue("@noPenjualan", noPenjualan)

                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        lbl_noJual.Text = "No Penjualan: " & rd("no_penjualan").ToString()
                        lbl_jenisJual.Text = "Jenis Penjualan: " & rd("jenis_penjualan").ToString()
                        lbl_tglJual.Text = "Tanggal: " & CDate(rd("tanggal")).ToString("dd MMM yyyy")
                        lbl_totalJual.Text = "Total: Rp. " & Format(CDec(rd("total_penjualan")), "N0")
                        lbl_danaDiterima.Text = "Dana Diterima: Rp. " & Format(CDec(rd("dana_diterima")), "N0")
                        lbl_kembalian.Text = "Kembalian: Rp. " & Format(CDec(rd("kembalian")), "N0")
                        lbl_metodeJual.Text = "Metode: " & rd("metode_pembayaran").ToString()
                        lbl_statusJual.Text = "Status: " & rd("status_penjualan").ToString()
                        lbl_catatan.Text = "Catatan: " & rd("catatan").ToString()
                    Else
                        MsgBox("Data penjualan tidak ditemukan!", vbExclamation)
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

    Sub CekDanaHariIni()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "SELECT dana_uangKecil 
                             FROM tbluangkecil 
                             WHERE tanggal = CURDATE() LIMIT 1"

            Using cmd As New MySqlCommand(sql, conn)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    ' Sudah ada dana untuk hari ini
                    txt_danaUangKecil.Text = CDec(result).ToString("N0")
                    txt_danaUangKecil.ReadOnly = True
                    btn_konfirmasiUangKecil.Enabled = False
                Else
                    ' Belum ada dana hari ini
                    txt_danaUangKecil.ReadOnly = False
                    txt_danaUangKecil.Clear()
                    btn_konfirmasiUangKecil.Enabled = True
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btnStokBarang_Click(sender As Object, e As EventArgs) Handles btnStokBarang.Click
        frm_ManageStok.Show()
        Me.Close()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        frm_ManageSupplier.Show()
        Me.Close()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        frm_ManageBarang.Show()
        Me.Close()
    End Sub

    Private Sub btnPembelian_Click(sender As Object, e As EventArgs) Handles btnPembelian.Click
        frm_ManagePembelian.Show()
        Me.Close()
    End Sub

    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        frm_ManagePengembalian.Show()
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

    Private Sub btn_konfirmasiUangKecil_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txt_danaUangKecil.Text) Then
            MsgBox("Dana uang kecil tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "INSERT INTO tbluangkecil (tanggal, dana_uangKecil) VALUES (@tanggal, @dana)"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@tanggal", dtp_tglUangKecil.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@dana", txt_danaUangKecil.Text.Replace(".", "").Replace(",", ""))

                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Berhasil disimpan!", vbInformation)

                    ' Setelah simpan → kunci input
                    txt_danaUangKecil.Text = CDec(txt_danaUangKecil.Text.Replace(".", "").Replace(",", "")).ToString("N0")
                    txt_danaUangKecil.ReadOnly = True
                    btn_konfirmasiUangKecil.Enabled = False
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_resetDanaKecil_Click(sender As Object, e As EventArgs)

        Dim result = MsgBox("Yakin reset dana uang kecil untuk hari ini?", vbQuestion + vbYesNo, "Konfirmasi Reset")

        If result = vbNo Then Exit Sub

        Try
            conn.Open()
            cmd = New MySqlCommand("DELETE FROM tbluangkecil WHERE DATE(tanggal) = @tanggal", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@tanggal", dtp_tglUangKecil.Value.Date)

            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Dana uang kecil berhasil direset!", vbInformation)

                ' Reset tampilan
                txt_danaUangKecil.Clear()
                txt_danaUangKecil.ReadOnly = False
                btn_konfirmasiUangKecil.Enabled = True
            Else
                MsgBox("Tidak ada data untuk tanggal ini.", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub txt_cariPenjualan_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Class BarangInfo
        Public Property ID As String
        Public Property Satuan As String
        Public Property Nama As String
        Public Property Harga As String

    End Class

    Public barangDict As New Dictionary(Of String, BarangInfo)
    Private totalPenjualan As Decimal = 0
    Dim WithEvents PD_Langsung As New PrintDocument
    Dim WithEvents PD_Delivery As New PrintDocument
    Dim WithEvents PD_Pickup As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Sub load_barang()
        cbo_brg.Items.Clear()
        cbo_brgDelivery.Items.Clear()
        cbo_brgPickup.Items.Clear()
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
                cbo_brgDelivery.Items.Add(kode)
                cbo_brgPickup.Items.Add(kode)

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

        txt_noPenjualanPickup.Text = $"{prefix}-{Date.Now:yyMMdd}-{newIncrement:0000}"
        txt_noPenjualanPickup.ReadOnly = True

        txt_noPenjualanDelivery.Text = $"{prefix}-{Date.Now:yyMMdd}-{newIncrement:0000}"
        txt_noPenjualanDelivery.ReadOnly = True
    End Sub

    Function BersihkanAngka(input As String) As Decimal
        If String.IsNullOrWhiteSpace(input) Then Return 0
        input = input.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim()
        Dim hasil As Decimal
        Decimal.TryParse(input, hasil)
        Return hasil
    End Function

    Sub hitungSubtotal()
        '================= LANGSUNG =================
        Dim harga As Decimal
        Dim qty As Decimal
        harga = BersihkanAngka(txt_hrga.Text)
        Decimal.TryParse(txt_qty.Text, qty)
        Dim subtotal As Decimal = harga * qty
        'Format textbox
        txt_hrga.Text = harga.ToString("N0")
        txt_subTotal.Text = subtotal.ToString("N0")

        '================= DELIVERY =================
        Dim hargaDelivery As Decimal
        Dim qtyDelivery As Decimal
        hargaDelivery = BersihkanAngka(txt_hrgaDelivery.Text)
        Decimal.TryParse(txt_qtyDelivery.Text, qtyDelivery)
        Dim subtotalDelivery As Decimal = hargaDelivery * qtyDelivery
        txt_hrgaDelivery.Text = hargaDelivery.ToString("N0")
        txt_subTotalDelivery.Text = subtotalDelivery.ToString("N0")

        '================= PICKUP =================
        Dim hargaPickup As Decimal
        Dim qtyPickup As Decimal
        hargaPickup = BersihkanAngka(txt_hrgaPickup.Text)
        Decimal.TryParse(txt_qtyPickup.Text, qtyPickup)
        Dim subtotalPickup As Decimal = hargaPickup * qtyPickup
        txt_hrgaPickup.Text = hargaPickup.ToString("N0")
        txt_subTotalPickup.Text = subtotalPickup.ToString("N0")
    End Sub

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

    Function hitungTotalPenjualanDelivery() As Decimal
        Dim totalDelivery As Decimal = 0
        For Each row As DataGridViewRow In dgv_detailPenjualanDelivery.Rows
            If row.IsNewRow Then Continue For

            Dim cellValue = row.Cells("colSubtotalDelivery").Value
            If cellValue Is Nothing OrElse IsDBNull(cellValue) Then
                Continue For
            End If

            Dim decVal As Decimal
            If Decimal.TryParse(cellValue.ToString(), decVal) Then
                totalDelivery += decVal
            End If
        Next
        Return totalDelivery
    End Function

    Function hitungTotalPenjualanPickup() As Decimal
        Dim totalPickup As Decimal = 0
        For Each row As DataGridViewRow In dgv_detailPenjualanPickup.Rows
            If row.IsNewRow Then Continue For

            Dim cellValue = row.Cells("colSubtotalPickup").Value
            If cellValue Is Nothing OrElse IsDBNull(cellValue) Then
                Continue For
            End If

            Dim decVal As Decimal
            If Decimal.TryParse(cellValue.ToString(), decVal) Then
                totalPickup += decVal
            End If
        Next
        Return totalPickup
    End Function

    Function HitungTotalQty() As Integer
        Dim totalQty As Integer = 0
        For Each row As DataGridViewRow In dgv_detailPenjualan.Rows
            totalQty += Convert.ToInt32(row.Cells("colQty").Value)
        Next
        Return totalQty
    End Function

    Function HitungTotalQtyDelivery() As Integer
        Dim totalQtyDelivery As Integer = 0
        For Each row As DataGridViewRow In dgv_detailPenjualanDelivery.Rows
            totalQtyDelivery += Convert.ToInt32(row.Cells("colQtyDelivery").Value)
        Next
        Return totalQtyDelivery
    End Function

    Function HitungTotalQtyPickup() As Integer
        Dim totalQtyPickup As Integer = 0

        For Each row As DataGridViewRow In dgv_detailPenjualanPickup.Rows
            totalQtyPickup += Convert.ToInt32(row.Cells("colQtyPickup").Value)
        Next
        Return totalQtyPickup
    End Function

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
        txt_danaDiterimaLangsung.Text = ""
        lbl_kembalianLangsung.Text = "00.00"
        cbo_statusPenjualan.SelectedIndex = -1
        txt_catatan.Text = ""

        cbo_brgPickup.SelectedIndex = -1
        txt_namaBrgPickup.Text = ""
        txt_qtyPickup.Text = ""
        txt_satuanBrgPickup.Text = ""
        txt_hrgaPickup.Text = ""
        txt_subTotalPickup.Text = ""
        dgv_detailPenjualanPickup.Rows.Clear()
        lbl_grandTotalPickup.Text = "00.00"
        lbl_totalQtyPickup.Text = "Total Barang:"
        lbl_QtyPickup.Text = "00"
        lbl_hargaSatuanPickup.Text = "00.00"
        lbl_subTotalPickup.Text = "00.00"
        cbo_metodePembayaranPickup.SelectedIndex = -1
        txt_danaDiterimaPickup.Text = ""
        lbl_kembalianPickup.Text = "00.00"
        cbo_statusPenjualanPickup.SelectedIndex = -1
        txt_catatanPickup.Text = ""
        cbo_statusPickup.SelectedIndex = -1
        txt_atasNamaDeliveryPickup.Text = ""
        txt_kontakDeliveryPickup.Text = ""

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
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        hitungSubtotal()
    End Sub

    Private Sub txt_noPenjualan_TextChanged(sender As Object, e As EventArgs) Handles txt_noPenjualan.TextChanged
        lbl_noPenjualan.Text = "No Penjualan: " & txt_noPenjualan.Text
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
            txt_danaDiterimaLangsung.Clear()
        End If
    End Sub

    Private Sub txt_danaDiterima_TextChanged(sender As Object, e As EventArgs) Handles txt_danaDiterimaLangsung.TextChanged
        Dim dana As Decimal
        Dim total As Decimal

        If Not Decimal.TryParse(txt_danaDiterimaLangsung.Text, dana) Then
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
            txt_danaDiterimaLangsung.Text = 00.00
            txt_danaDiterimaLangsung.ReadOnly = True
            lbl_kembalianLangsung.Text = 00.00
            cbo_metodePembayaran.SelectedIndex = -1

        ElseIf cbo_statusPenjualan.Text = "Lunas" Then
            txt_danaDiterimaLangsung.ReadOnly = False
        End If
    End Sub

    Private Sub txt_danaDiterima_Leave(sender As Object, e As EventArgs) Handles txt_danaDiterimaLangsung.Leave
        Dim nilai As Decimal

        'Hapus titik atau format lama sebelum parsing
        Decimal.TryParse(txt_danaDiterimaLangsung.Text.Replace(".", "").Replace(",", ""), nilai)

        'Format jadi nominal uang
        txt_danaDiterimaLangsung.Text = nilai.ToString("N0")
    End Sub

    Private Sub txt_danaDiterima_Enter(sender As Object, e As EventArgs) Handles txt_danaDiterimaLangsung.Enter
        txt_danaDiterimaLangsung.Text = txt_danaDiterimaLangsung.Text.Replace(".", "").Replace(",", "")
    End Sub

    Sub changelongpaper()
        Dim rowcount As Integer = dgv_detailPenjualan.Rows.Cast(Of DataGridViewRow)().
                              Where(Function(r) Not r.IsNewRow).Count()

        longpaper = (rowcount * 25) + 260
    End Sub

    Sub changelongpaperDelivery()
        Dim rowcount As Integer = dgv_detailPenjualanDelivery.Rows.Cast(Of DataGridViewRow)().
                              Where(Function(r) Not r.IsNewRow).Count()

        longpaper = (rowcount * 25) + 260
    End Sub

    Sub changelongpaperPickup()
        Dim rowcount As Integer = dgv_detailPenjualanPickup.Rows.Cast(Of DataGridViewRow)().
                              Where(Function(r) Not r.IsNewRow).Count()

        longpaper = (rowcount * 25) + 260
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD_Langsung.PrintPage
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

        e.Graphics.DrawString("Bayar: Rp " & txt_danaDiterimaLangsung.Text, f10, Brushes.Black, leftmargin, y)
        y += 20

        e.Graphics.DrawString("Kembali: Rp " & lbl_kembalianLangsung.Text, f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Terima kasih!", f10, Brushes.Black, leftmargin, y)
    End Sub
    Private Sub btn_simpanPenjualan_Click(sender As Object, e As EventArgs) Handles btn_simpanPenjualan.Click
        If dgv_detailPenjualan.Rows.Count = 0 Then
            MsgBox("Tidak ada barang yang dibeli!")
            Exit Sub
        End If

        Dim totalBelanja As Decimal = CDec(lbl_grandTotal.Text)
        Dim danaDiterima As Decimal = 0

        ' Cek apakah input kosong atau bukan angka
        If String.IsNullOrWhiteSpace(txt_danaDiterimaLangsung.Text) OrElse Not Decimal.TryParse(txt_danaDiterimaLangsung.Text, danaDiterima) Then
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
            cmd.Parameters.AddWithValue("@dana_diterima", BersihkanAngka(txt_danaDiterimaLangsung.Text))
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
            PD_Langsung.DefaultPageSettings.PaperSize = New PaperSize("Custom", 280, longpaper)

            PPD.Document = PD_Langsung
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
            load_ListPenjualan()
            frm_ManageStok.load_stock()
            frm_ManageStok.CekStokMenipis()
            frm_ManageBarang.load_Barang()
            load_ListPenjualanPending()
            GenerateNoPenjualan()
            frm_ManagePenjualanDelivery.GenerateNoPenjualan()
            frm_ManagePenjualanPickup.GenerateNoPenjualan()
        End Try
    End Sub

    Private Sub dgv_listPenjualan_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listPenjualan.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idJualPending As String = dgv_listPenjualan.Rows(e.RowIndex).Cells("colNoPenjualan").Value.ToString()

        TampilkanDetailPenjualan(idJualPending)
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

            rtb_detailPenjualanPending.Clear()

            Dim nomor As Integer = 1

            For Each row As DataRow In dt.Rows
                rtb_detailPenjualanPending.AppendText(
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

        Dim idJualPending As String = dgv_listPenjualanPending.Rows(e.RowIndex).Cells("colNoPenjualanPending").Value.ToString()

        TampilkanDetailPenjualanPending(idJualPending)
    End Sub

    Private Sub btn_updateLunasPenjualan_Click(sender As Object, e As EventArgs) Handles btn_updateLunasPenjualan.Click
        If dgv_listPenjualanPending.Rows.Count = 0 Then
            MsgBox("Tidak ada data penjualan pending!", vbExclamation)
            Exit Sub
        End If

        Dim baris As Integer = dgv_listPenjualanPending.CurrentRow.Index

        Dim formPopup As New frm_UpdateLunas_DanaDiterima
        formPopup.lbl_noPenjualanPENDING.Text = dgv_listPenjualanPending.Item("colNoPenjualanPending", baris).Value.ToString()
        formPopup.lbl_totalPENDING.Text = dgv_listPenjualanPending.Item("colTotalPenjualanPending", baris).Value.ToString()

        formPopup.ShowDialog()
    End Sub

    Private Sub btn_tmbhDetBeli_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btn_tmbhDetBeliDelivery_Click(sender As Object, e As EventArgs) Handles btn_tmbhDetBeliDelivery.Click
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
            If r.Cells("colKodeBrgDelivery").Value.ToString() = barangID Then
                qtySudahAda += Convert.ToInt32(r.Cells("colQtyDelivery").Value)
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

        Dim totalBaru As Decimal = hitungTotalPenjualanDelivery()
        Dim qtyBaru As Integer = HitungTotalQtyDelivery()

        lbl_grandTotalDelivery.Text = totalBaru.ToString("N0")
        lbl_totalQtyDelivery.Text = "Total Barang: " & qtyBaru.ToString()

        cbo_brgDelivery.SelectedIndex = -1
        txt_qtyDelivery.Clear()
        txt_satuanBrgDelivery.Clear()
        txt_hrgaDelivery.Clear()
        txt_subTotalDelivery.Clear()
        txt_namaBrgDelivery.Clear()
    End Sub

    Private Sub btn_tmbhDetBeliPickup_Click(sender As Object, e As EventArgs) Handles btn_tmbhDetBeliPickup.Click
        ' VALIDASI INPUT
        If cbo_brgPickup.SelectedIndex = -1 Or txt_qtyPickup.Text = "" Or txt_hrgaPickup.Text = "" Then
            MessageBox.Show("Lengkapi data barang")
            Exit Sub
        End If

        ' AMBIL DATA BARANG
        Dim info As BarangInfo = barangDict(cbo_brgPickup.Text)
        Dim barangID As String = info.ID
        Dim satuan As String = info.Satuan
        Dim namaBar As String = info.Nama

        Dim qty As Integer = Integer.Parse(txt_qtyPickup.Text)
        Dim harga As Decimal = BersihkanAngka(txt_hrgaPickup.Text)
        Dim subtotal As Decimal = qty * harga

        ' ==============================
        ' VALIDASI STOK SEBELUM TAMBAH
        ' ==============================
        Dim stokSaatIni As Integer = GetStokBarang(barangID)

        Dim qtySudahAda As Integer = 0
        For Each r As DataGridViewRow In dgv_detailPenjualanPickup.Rows
            If r.IsNewRow Then Continue For
            If r.Cells("colKodeBarang").Value.ToString() = barangID Then
                qtySudahAda += Convert.ToInt32(r.Cells("colQtyPickup").Value)
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
        dgv_detailPenjualanPickup.Rows.Add(
        Nothing,
        barangID,
        namaBar,
        qty,
        satuan,
        harga,
        subtotal
    )

        ' UPDATE LABEL & RESET INPUT
        lbl_hargaSatuanPickup.Text = Format(harga, "Rp #,##0")
        lbl_subTotalPickup.Text = Format(subtotal, "Rp #,##0")

        lbl_QtyPickup.Text = qty.ToString()
        lbl_hargaSatuanPickup.Text = harga.ToString("N0")
        lbl_subTotalPickup.Text = subtotal.ToString("N0")

        Dim totalBaru As Decimal = hitungTotalPenjualanPickup()
        Dim qtyBaru As Integer = HitungTotalQtyPickup()

        lbl_grandTotalPickup.Text = totalBaru.ToString("N0")
        lbl_totalQtyPickup.Text = "Total Barang: " & qtyBaru.ToString()

        cbo_brgPickup.SelectedIndex = -1
        txt_qtyPickup.Clear()
        txt_satuanBrgPickup.Clear()
        txt_hrgaPickup.Clear()
        txt_subTotalPickup.Clear()
        txt_namaBrgPickup.Clear()
    End Sub

    Private Sub cbo_brgPickup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_brgPickup.SelectedIndexChanged
        If cbo_brgPickup.SelectedIndex <> -1 Then
            Dim id As String = cbo_brgPickup.Text

            If barangDict.ContainsKey(id) Then
                txt_namaBrgPickup.Text = barangDict(id).Nama
                txt_satuanBrgPickup.Text = barangDict(id).Satuan
                txt_hrgaPickup.Text = barangDict(id).Harga
            End If
        End If
        hitungSubtotal()
    End Sub

    Private Sub cbo_brgDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_brgDelivery.SelectedIndexChanged
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

    Private Sub txt_noPenjualanDelivery_TextChanged(sender As Object, e As EventArgs) Handles txt_noPenjualanDelivery.TextChanged
        lbl_noPenjualanDelivery.Text = "No Penjualan: " & txt_noPenjualanDelivery.Text


        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White

        Try
            pic_barcodePenjualanDelivery.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_noPenjualanDelivery.Text))

        Catch ex As Exception
            pic_barcodePenjualanDelivery.Image = Nothing
        End Try
    End Sub

    Private Sub txt_noPenjualanPickup_TextChanged(sender As Object, e As EventArgs) Handles txt_noPenjualanPickup.TextChanged
        lbl_noPenjualanPickup.Text = "No Penjualan: " & txt_noPenjualanPickup.Text


        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White

        Try
            pic_barcodePenjualanPickup.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_noPenjualanPickup.Text))

        Catch ex As Exception
            pic_barcodePenjualanPickup.Image = Nothing
        End Try
    End Sub

    Private Sub dgv_detailPenjualanPickup_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detailPenjualanPickup.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        If MessageBox.Show("Hapus item ini?", "Hapus", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dgv_detailPenjualanPickup.Rows.RemoveAt(e.RowIndex)
            lbl_grandTotalPickup.Text = hitungTotalPenjualanPickup().ToString("N0")
            lbl_totalQtyPickup.Text = "Total Barang: " & HitungTotalQtyPickup().ToString()
            lbl_QtyPickup.Text = "00"
            lbl_hargaSatuanPickup.Text = "00.00"
            lbl_subTotalPickup.Text = "00.00"
            txt_danaDiterimaPickup.Clear()
        End If
    End Sub

    Private Sub dgv_detailPenjualanDelivery_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detailPenjualanDelivery.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        If MessageBox.Show("Hapus item ini?", "Hapus", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dgv_detailPenjualanDelivery.Rows.RemoveAt(e.RowIndex)
            lbl_grandTotalDelivery.Text = hitungTotalPenjualanDelivery().ToString("N0")
            lbl_totalQtyDelivery.Text = "Total Barang: " & HitungTotalQtyDelivery().ToString()
            lbl_QtyDelivery.Text = "00"
            lbl_hargaSatuanDelivery.Text = "00.00"
            lbl_subTotalDelivery.Text = "00.00"
            txt_danaDiterimaDelivery.Clear()
        End If
    End Sub

    Private Sub PD_Delivery_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD_Delivery.PrintPage
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
        y += 25

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

            Dim nama = row.Cells("colNmaBrgDelivery").Value.ToString()
            Dim qty = row.Cells("colQtyDelivery").Value.ToString()
            Dim harga = CDec(row.Cells("colHargaDelivery").Value).ToString("N0")
            Dim subtotal = CDec(row.Cells("colSubtotalDelivery").Value).ToString("N0")

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

    Private Sub btn_simpanPenjualanDelivery_Click(sender As Object, e As EventArgs) Handles btn_simpanPenjualanDelivery.Click
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

            Dim kodeBarang As String = row.Cells("colKodeBrgDelivery").Value.ToString()
            Dim qtyBeli As Integer = Convert.ToInt32(row.Cells("colQtyDelivery").Value)
            Dim stokSaatIni As Integer = GetStokBarang(kodeBarang)

            If qtyBeli > stokSaatIni Then
                MsgBox("Stok untuk barang '" & row.Cells("colNmaBrgDelivery").Value.ToString() &
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
                cmdDetail.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBrgDelivery").Value)
                cmdDetail.Parameters.AddWithValue("@nama_barang", row.Cells("colNmaBrgDelivery").Value)
                cmdDetail.Parameters.AddWithValue("@qty", row.Cells("colQtyDelivery").Value)
                cmdDetail.Parameters.AddWithValue("@satuan", row.Cells("colSatuanDelivery").Value)
                cmdDetail.Parameters.AddWithValue("@harga", Convert.ToDecimal(row.Cells("colHargaDelivery").Value))
                cmdDetail.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(row.Cells("colSubtotalDelivery").Value))
                cmdDetail.ExecuteNonQuery()

                ' update stok
                Dim sqlUpdateStok As String =
        "UPDATE tblbarang SET stok = stok - @qty WHERE kode_barang = @kode_barang"

                Dim cmdStok As New MySqlCommand(sqlUpdateStok, conn, transaction)
                cmdStok.Parameters.AddWithValue("@qty", row.Cells("colQtyDelivery").Value)
                cmdStok.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBrgDelivery").Value)
                cmdStok.ExecuteNonQuery()

            Next

            transaction.Commit()
            MsgBox("Sukses!", vbInformation)
            changelongpaper()
            PD_Delivery.DefaultPageSettings.PaperSize = New PaperSize("Custom", 280, longpaper)

            PPD.Document = PD_Delivery
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
            load_ListPenjualan()
            GenerateNoPenjualan()
            frm_ManagePenjualanPickup.GenerateNoPenjualan()
            mainForm_Cashier.GenerateNoPenjualan()
        End Try
    End Sub

    Private Sub PD_Pickup_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD_Pickup.PrintPage
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

        e.Graphics.DrawString("Jenis: " & txtJenisDeliveryPickup.Text, f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("Atas Nama: " & txt_atasNamaDeliveryPickup.Text, f10, Brushes.Black, leftmargin, y)
        y += 18
        e.Graphics.DrawString("Kontak: " & txt_kontakDeliveryPickup.Text, f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("====================================", f10, Brushes.Black, leftmargin, y)
        y += 25

        ' Header kolom
        e.Graphics.DrawString("Item", f10, Brushes.Black, xItem, y)
        e.Graphics.DrawString("Qty", f10, Brushes.Black, xQty, y)
        e.Graphics.DrawString("Harga", f10, Brushes.Black, xHarga, y)
        e.Graphics.DrawString("Subtotal", f10, Brushes.Black, xSubtotal, y)
        y += 20

        For Each row As DataGridViewRow In dgv_detailPenjualanPickup.Rows
            If row.IsNewRow Then Continue For

            Dim nama = row.Cells("colNmaBarangPickup").Value.ToString()
            Dim qty = row.Cells("colQtyPickup").Value.ToString()
            Dim harga = CDec(row.Cells("colHargaPickup").Value).ToString("N0")
            Dim subtotal = CDec(row.Cells("colSubtotalPickup").Value).ToString("N0")

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
        e.Graphics.DrawString("Total: Rp " & Format(CDec(lbl_grandTotalPickup.Text.Replace("Rp ", "").Replace(",", "")), "N0"), f12, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Bayar: Rp " & txt_danaDiterimaPickup.Text, f10, Brushes.Black, leftmargin, y)
        y += 20

        e.Graphics.DrawString("Kembali: Rp " & lbl_kembalianPickup.Text, f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString("Terima kasih!", f10, Brushes.Black, leftmargin, y)
        y += 25

        e.Graphics.DrawString(cbo_statusPenjualanPickup.Text, f12, Brushes.Black, leftmargin, y)
        y += 20

        e.Graphics.DrawImage(pic_barcodePenjualanPickup.Image, leftmargin, y)
        y += pic_barcodePenjualanPickup.Image.Height + 10
    End Sub
    Private Sub btn_simpanPenjualanPickup_Click(sender As Object, e As EventArgs) Handles btn_simpanPenjualanPickup.Click
        If dgv_detailPenjualanPickup.Rows.Count = 0 Then
            MsgBox("Tidak ada barang yang dibeli!")
            Exit Sub
        End If

        Dim totalBelanja As Decimal = CDec(lbl_grandTotalPickup.Text)
        Dim danaDiterima As Decimal = 0

        ' Cek apakah input kosong atau bukan angka
        If String.IsNullOrWhiteSpace(txt_danaDiterimaPickup.Text) OrElse Not Decimal.TryParse(txt_danaDiterimaPickup.Text, danaDiterima) Then
            MsgBox("Masukkan nominal dana yang diterima!", vbExclamation)
            Exit Sub
        End If

        ' Cek jika status lunas tapi dana kurang
        If cbo_statusPenjualanPickup.Text = "Lunas" AndAlso danaDiterima < totalBelanja Then
            MsgBox("Dana yang diterima kurang dari total belanja!", vbCritical)
            Exit Sub
        End If

        ' === VALIDASI STOK SEBELUM SIMPAN ===
        For Each row As DataGridViewRow In dgv_detailPenjualanPickup.Rows
            If row.IsNewRow Then Continue For

            Dim kodeBarang As String = row.Cells("colKodeBarang").Value.ToString()
            Dim qtyBeli As Integer = Convert.ToInt32(row.Cells("colQtyPickup").Value)
            Dim stokSaatIni As Integer = GetStokBarang(kodeBarang)

            If qtyBeli > stokSaatIni Then
                MsgBox("Stok untuk barang '" & row.Cells("colNmaBarangPickup").Value.ToString() &
               "' tidak mencukupi!" & vbCrLf &
               "Stok: " & stokSaatIni & ", Diminta: " & qtyBeli, vbCritical)

                Exit Sub ' ---> Hentikan proses simpan
            End If
        Next

        Dim penjualanID As String = txt_noPenjualanPickup.Text
        Dim transaction As MySqlTransaction = Nothing

        Try
            conn.Open()
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcodePenjualanPickup.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()
            transaction = conn.BeginTransaction()

            Dim sqlPenjualan As String =
        "INSERT INTO tblpenjualan (tanggal, no_penjualan, jenis_penjualan, total_penjualan, dana_diterima, kembalian, metode_pembayaran, status_penjualan, catatan, atas_nama, kontak_penerima, status_pengiriman, barcode_pengiriman)" &
        "VALUES (@tanggal, @no_penjualan, @jenis_penjualan, @total_penjualan, @dana_diterima, @kembalian, @metode_pembayaran, @status_penjualan, @catatan, @atas_nama, @kontak_penerima, @status_pengiriman, @barcode_pengiriman)"

            cmd = New MySqlCommand(sqlPenjualan, conn, transaction)
            cmd.Parameters.AddWithValue("@tanggal", dtp_tglJualPickup.Value)
            cmd.Parameters.AddWithValue("@no_penjualan", txt_noPenjualanPickup.Text)
            cmd.Parameters.AddWithValue("@jenis_penjualan", txtJenisDeliveryPickup.Text)
            cmd.Parameters.AddWithValue("@total_penjualan", BersihkanAngka(lbl_grandTotalPickup.Text))
            cmd.Parameters.AddWithValue("@dana_diterima", BersihkanAngka(txt_danaDiterimaPickup.Text))
            cmd.Parameters.AddWithValue("@kembalian", BersihkanAngka(lbl_kembalianPickup.Text))
            cmd.Parameters.AddWithValue("@metode_pembayaran", cbo_metodePembayaranPickup.Text)
            cmd.Parameters.AddWithValue("@status_penjualan", cbo_statusPenjualanPickup.Text)
            cmd.Parameters.AddWithValue("@catatan", txt_catatanPickup.Text)
            cmd.Parameters.AddWithValue("@atas_nama", txt_atasNamaDeliveryPickup.Text)
            cmd.Parameters.AddWithValue("@kontak_penerima", txt_kontakDeliveryPickup.Text)
            cmd.Parameters.AddWithValue("@status_pengiriman", cbo_statusPickup.Text)
            cmd.Parameters.AddWithValue("@barcode_pengiriman", arrImage)
            cmd.ExecuteNonQuery()


            For Each row As DataGridViewRow In dgv_detailPenjualanPickup.Rows

                If row.IsNewRow Then Continue For

                Dim sqlDetail As String =
        "INSERT INTO tbldetailpenjualan (no_penjualan, kode_barang, nama_barang, qty, satuan, harga, subtotal) " &
        "VALUES (@no_penjualan, @kode_barang, @nama_barang, @qty, @satuan, @harga, @subtotal)"

                Dim cmdDetail As New MySqlCommand(sqlDetail, conn, transaction)
                cmdDetail.Parameters.AddWithValue("@no_penjualan", penjualanID)
                cmdDetail.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBarang").Value)
                cmdDetail.Parameters.AddWithValue("@nama_barang", row.Cells("colNmaBarangPickup").Value)
                cmdDetail.Parameters.AddWithValue("@qty", row.Cells("colQtyPickup").Value)
                cmdDetail.Parameters.AddWithValue("@satuan", row.Cells("colSatuanPickup").Value)
                cmdDetail.Parameters.AddWithValue("@harga", Convert.ToDecimal(row.Cells("colHargaPickup").Value))
                cmdDetail.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(row.Cells("colSubtotalPickup").Value))
                cmdDetail.ExecuteNonQuery()

                ' update stok
                Dim sqlUpdateStok As String =
        "UPDATE tblbarang SET stok = stok - @qty WHERE kode_barang = @kode_barang"

                Dim cmdStok As New MySqlCommand(sqlUpdateStok, conn, transaction)
                cmdStok.Parameters.AddWithValue("@qty", row.Cells("colQtyPickup").Value)
                cmdStok.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBarang").Value)
                cmdStok.ExecuteNonQuery()

            Next

            transaction.Commit()
            MsgBox("Sukses!", vbInformation)
            changelongpaper()
            PD_Pickup.DefaultPageSettings.PaperSize = New PaperSize("Custom", 280, longpaper)

            PPD.Document = PD_Pickup
            PPD.ShowDialog() ' → preview sebelum print
        Catch ex As Exception
            Try
                transaction.Rollback()
            Catch
            End Try
            MsgBox("Gagal menyimpan transaksi: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            dgv_detailPenjualanPickup.Rows.Clear()
            clear()

            cbo_statusPickup.Text = "Pending"

            load_barang()
            frm_ManageStok.load_stock()
            frm_ManageStok.CekStokMenipis()
            frm_ManageBarang.load_Barang()
            load_ListPenjualanPending()
            load_ListPenjualan()
            GenerateNoPenjualan()
            frm_ManagePenjualanDelivery.GenerateNoPenjualan()
            mainForm_Cashier.GenerateNoPenjualan()
        End Try
    End Sub

    Private Sub btnCancelPickup_Click(sender As Object, e As EventArgs) Handles btnCancelPickup.Click
        clear()
    End Sub

    Private Sub btnCancelDelivery_Click(sender As Object, e As EventArgs) Handles btnCancelDelivery.Click
        clear()
    End Sub

    Private Sub txt_qtyPickup_TextChanged(sender As Object, e As EventArgs) Handles txt_qtyPickup.TextChanged
        hitungSubtotal()
    End Sub

    Private Sub txt_qtyDelivery_TextChanged(sender As Object, e As EventArgs) Handles txt_qtyDelivery.TextChanged
        hitungSubtotal()
    End Sub

    Private Sub txt_danaDiterimaPickup_TextChanged(sender As Object, e As EventArgs) Handles txt_danaDiterimaPickup.TextChanged
        Dim dana As Decimal
        Dim total As Decimal

        If Not Decimal.TryParse(txt_danaDiterimaPickup.Text, dana) Then
            lbl_kembalianPickup.Text = "Rp 0"
            cbo_statusPenjualanPickup.SelectedIndex = -1
            cbo_statusPenjualanPickup.Enabled = True
            Exit Sub
        End If

        Decimal.TryParse(lbl_grandTotalPickup.Text, total)

        Dim kembalian As Decimal = dana - total

        lbl_kembalianPickup.Text = "Rp " & kembalian.ToString("#,##0")

        If kembalian >= 0 Then
            cbo_statusPenjualanPickup.Text = "Lunas"
            cbo_statusPenjualanPickup.DropDownStyle = ComboBoxStyle.DropDownList
            cbo_statusPenjualanPickup.Enabled = True
            cbo_statusPenjualanPickup.Cursor = Cursors.Default
            cbo_statusPenjualanPickup.Focus()
        Else
            cbo_statusPenjualanPickup.Text = ""
            cbo_statusPenjualanPickup.Enabled = True
        End If
    End Sub

    Private Sub txt_danaDiterimaPickup_Enter(sender As Object, e As EventArgs) Handles txt_danaDiterimaPickup.Enter
        txt_danaDiterimaPickup.Text = txt_danaDiterimaPickup.Text.Replace(".", "").Replace(",", "")
    End Sub

    Private Sub txt_danaDiterimaPickup_Leave(sender As Object, e As EventArgs) Handles txt_danaDiterimaPickup.Leave
        Dim nilai As Decimal

        'Hapus titik atau format lama sebelum parsing
        Decimal.TryParse(txt_danaDiterimaPickup.Text.Replace(".", "").Replace(",", ""), nilai)

        'Format jadi nominal uang
        txt_danaDiterimaPickup.Text = nilai.ToString("N0")
    End Sub

    Private Sub cbo_statusPenjualanPickup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_statusPenjualanPickup.SelectedIndexChanged
        If cbo_statusPenjualanPickup.Text = "Pending" Then
            txt_danaDiterimaPickup.Text = 00.00
            txt_danaDiterimaPickup.ReadOnly = True
            lbl_kembalianPickup.Text = 00.00
            cbo_statusPickup.Text = "Pending"
            cbo_metodePembayaranPickup.SelectedIndex = -1

        ElseIf cbo_statusPenjualanPickup.Text = "Lunas" Then
            txt_danaDiterimaPickup.ReadOnly = False
            cbo_statusPickup.Text = "Packing"
        End If
    End Sub

    Private Sub txt_danaDiterimaDelivery_TextChanged(sender As Object, e As EventArgs) Handles txt_danaDiterimaDelivery.TextChanged
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

    Private Sub txt_danaDiterimaDelivery_Leave(sender As Object, e As EventArgs) Handles txt_danaDiterimaDelivery.Leave
        Dim nilai As Decimal

        'Hapus titik atau format lama sebelum parsing
        Decimal.TryParse(txt_danaDiterimaDelivery.Text.Replace(".", "").Replace(",", ""), nilai)

        'Format jadi nominal uang
        txt_danaDiterimaDelivery.Text = nilai.ToString("N0")
    End Sub

    Private Sub txt_danaDiterimaDelivery_Enter(sender As Object, e As EventArgs) Handles txt_danaDiterimaDelivery.Enter
        txt_danaDiterimaDelivery.Text = txt_danaDiterimaDelivery.Text.Replace(".", "").Replace(",", "")
    End Sub

    Private Sub cbo_statusPenjualanDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_statusPenjualanDelivery.SelectedIndexChanged
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

    Private Sub dgv_detailPenjualanDelivery_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv_detailPenjualanDelivery.RowPostPaint
        dgv_detailPenjualanDelivery.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub dgv_detailPenjualanPickup_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv_detailPenjualanPickup.RowPostPaint
        dgv_detailPenjualanPickup.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub dgv_detailPenjualan_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv_detailPenjualan.RowPostPaint
        dgv_detailPenjualan.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
    End Sub
End Class