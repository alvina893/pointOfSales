Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class frm_PopUpPengembalianBaru

    <DllImport("dwmapi.dll")>
    Private Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarInset As MARGINS) As Integer
    End Function

    <DllImport("dwmapi.dll")>
    Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
    End Function
    Structure MARGINS
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure

    Private Sub EnableShadow()
        Dim val As Integer = 2 ' DWMNCRP_ENABLED
        DwmSetWindowAttribute(Me.Handle, 2, val, 4)

        Dim m As New MARGINS With {
        .Left = 1,
        .Right = 1,
        .Top = 1,
        .Bottom = 1
    }
        DwmExtendFrameIntoClientArea(Me.Handle, m)
    End Sub

    Public noPenjualanSource As String
    Public kodeBarangSource As String
    Public qtySource As Integer

    Public Sub load_DataPengembalian(noPenjualan As String, kodeBarang As String, qty As Integer)
        noPenjualanSource = noPenjualan
        kodeBarangSource = kodeBarang
        qtySource = qty

        txt_noPenjualan.Text = noPenjualanSource
        txt_kodeBarang.Text = kodeBarangSource
        txt_qty.Text = qtySource

        load_Barang(kodeBarangSource, qtySource)
    End Sub

    Sub hitungSubTotal()
        Dim harga As Double
        Dim qty As Double

        Double.TryParse(txt_hargaBeli.Text, harga)
        Double.TryParse(txt_qty.Text, qty)

        txt_subTotal.Text = (harga * qty).ToString()
    End Sub

    Sub load_Barang(kodeBarang As String, qty As Integer)

        dgv_detailPengembalian.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String =
            "SELECT 
                kode_barang, nama_barang, kategori_barang, satuan_barang, 
                harga_beli, harga_barang, stok, min_stok, barcode,
                supplier_ID, nama_supplier
             FROM tblbarang
             WHERE kode_barang = @kode"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@kode", kodeBarang)
            dr = cmd.ExecuteReader

            If dr.Read() Then
                txt_IDSupplier.Text = dr("supplier_ID").ToString()
                txt_namaSupplier.Text = dr("nama_supplier").ToString()

                txt_kodeBarang.Text = dr("kode_barang").ToString()
                txt_namaBarang.Text = dr("nama_barang").ToString()
                txt_satuan.Text = dr("satuan_barang").ToString()
                txt_hargaBeli.Text = dr("harga_barang").ToString()
            End If

            txt_qty.Text = qty.ToString()

            hitungSubTotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub GenerateNoPengembalian()
        Dim prefix As String = "IM.RT"
        Dim newIncrement As Integer = 1
        Dim lastNo As String = ""
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Ambil nomor penjualan paling akhir untuk tanggal hari ini
            Dim query As String = " SELECT no_pengembalian FROM tblpengembalian WHERE DATE(tanggal) = CURDATE() ORDER BY pengembalian_ID DESC LIMIT 1 "
            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                lastNo = result.ToString()
            End If
        Catch ex As Exception
            MsgBox("Error cek nomor pengembalian: " & ex.Message)
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
        txt_kodeRetur.Text = $"{prefix}-{Date.Now:yyMMdd}-{newIncrement:0000}"
        txt_kodeRetur.ReadOnly = True
    End Sub

    Private Sub frm_PopUpPengembalianBaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()
        GenerateNoPengembalian()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Sub HitungTotalStok()
        Dim total As Integer = 0

        For Each row As DataGridViewRow In dgv_detailPengembalian.Rows
            If row.Cells("colQty").Value IsNot Nothing Then
                total += Convert.ToInt32(row.Cells("colQty").Value)
            End If
        Next

        txt_totalStokRetur.Text = total.ToString()
    End Sub

    Sub HitungTotalDana()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgv_detailPengembalian.Rows
            If row.Cells("colSubtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("colSubtotal").Value)
            End If
        Next

        txt_totalDanaRetur.Text = total.ToString()
    End Sub

    Sub hitungTotalPengembalian()
        Dim totalDana As Decimal = 0
        Dim totalQty As Integer = 0

        For Each row As DataGridViewRow In dgv_detailPengembalian.Rows
            ' Hitung subtotal
            If row.Cells("colSubtotal").Value IsNot Nothing Then
                totalDana += Convert.ToDecimal(row.Cells("colSubtotal").Value)
            End If

            ' Hitung quantity
            If row.Cells("colQty").Value IsNot Nothing Then
                totalQty += Convert.ToInt32(row.Cells("colQty").Value)
            End If
        Next
        txt_totalDanaRetur.Text = totalDana.ToString()
        txt_totalStokRetur.Text = totalQty.ToString()
    End Sub

    Private Sub btn_tmbhDetBeli_Click(sender As Object, e As EventArgs) Handles btn_tmbhDetBeli.Click
        ' VALIDASI
        If txt_qty.Text = "" Or Val(txt_qty.Text) <= 0 Then
            MsgBox("Masukkan jumlah pembelian!", vbExclamation)
            Exit Sub
        End If

        Dim kode = txt_kodeBarang.Text.Trim()
        Dim qty = Val(txt_qty.Text)
        Dim harga = Val(txt_hargaBeli.Text)
        Dim subtotal = qty * harga

        ' ==============================
        ' 2. INSERT MODE → barang baru
        ' ==============================

        dgv_detailPengembalian.Rows.Add(
        dgv_detailPengembalian.Rows.Count + 1,
        txt_kodeBarang.Text,
        txt_namaBarang.Text,
        txt_qty.Text,
        txt_satuan.Text,
        txt_hargaBeli.Text,
        (Val(txt_qty.Text) * Val(txt_hargaBeli.Text)).ToString()
    )
        hitungTotalPengembalian()

        ' Kosongkan input setelah tambah
        txt_kodeBarang.Text = ""
        txt_namaBarang.Clear()
        txt_qty.Clear()
        txt_satuan.Clear()
        txt_hargaBeli.Clear()
        txt_subTotal.Clear()
    End Sub

    Function ConvertToMySqlDecimal(value As String) As Decimal
        If String.IsNullOrWhiteSpace(value) Then Return 0

        ' Buang pemisah ribuan (.)
        value = value.Replace(".", "")

        ' Ganti koma decimal (,) -> titik (.)
        value = value.Replace(",", ".")

        Return Convert.ToDecimal(value, Globalization.CultureInfo.InvariantCulture)
    End Function
    Private Sub btn_simpanBeli_Click(sender As Object, e As EventArgs) Handles btn_simpanBeli.Click

        If dgv_detailPengembalian.Rows.Count = 0 Then
            MsgBox("Tidak ada barang untuk dikembalikan!")
            Exit Sub
        End If

        Dim returID As String = txt_kodeRetur.Text
        Dim totalDanaAkhir As Decimal = 0
        Dim totalStokAkhir As Integer = 0

        For Each row As DataGridViewRow In dgv_detailPengembalian.Rows
            totalDanaAkhir += Convert.ToDecimal(row.Cells("colSubtotal").Value)
            totalStokAkhir += Convert.ToInt32(row.Cells("colQty").Value)
        Next

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' ==== Main Table Query ====
            Dim sqlRetur As String =
            "INSERT INTO tblpengembalian (no_pengembalian, tanggal, metode_pengembalian, supplier_ID, nama_supplier, total_returDana, total_returStok) 
         VALUES (@no_pengembalian, @tgl, @metode, @supID, @supNama, @totalDana, @totalStok)"

            Using cmd As New MySqlCommand(sqlRetur, conn)
                cmd.Parameters.AddWithValue("@no_pengembalian", returID)
                cmd.Parameters.AddWithValue("@tgl", dtp_tglPengembalian.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@metode", "")
                cmd.Parameters.AddWithValue("@supID", txt_IDSupplier.Text)
                cmd.Parameters.AddWithValue("@supNama", txt_namaSupplier.Text)
                cmd.Parameters.AddWithValue("@totalDana", totalDanaAkhir)
                cmd.Parameters.AddWithValue("@totalStok", totalStokAkhir)
                cmd.ExecuteNonQuery()
            End Using

            ' ==== Detail Loop ====
            For Each row As DataGridViewRow In dgv_detailPengembalian.Rows
                If row.IsNewRow Then Continue For

                Dim sqlDetail As String =
                "INSERT INTO tbldetailpengembalian (no_pengembalian, kode_barang, nama_barang, qty, satuan, harga, subtotal)
             VALUES (@no_pengembalian, @kode, @nama, @qty, @satuan, @harga, @subtotal)"

                Using cmdDetail As New MySqlCommand(sqlDetail, conn)
                    cmdDetail.Parameters.AddWithValue("@no_pengembalian", returID)
                    cmdDetail.Parameters.AddWithValue("@kode", row.Cells("colKodeBrg").Value)
                    cmdDetail.Parameters.AddWithValue("@nama", row.Cells("colNmaBrg").Value)
                    cmdDetail.Parameters.AddWithValue("@qty", row.Cells("colQty").Value)
                    cmdDetail.Parameters.AddWithValue("@satuan", row.Cells("colSatuan").Value)
                    cmdDetail.Parameters.AddWithValue("@harga",
                        ConvertToMySqlDecimal(row.Cells("colHargaBli").Value.ToString()))
                    cmdDetail.Parameters.AddWithValue("@subtotal",
                        ConvertToMySqlDecimal(row.Cells("colSubtotal").Value.ToString()))
                    cmdDetail.ExecuteNonQuery()
                End Using

                ' ============================================
                ' UPDATE qty dan subtotal pada DETAIL PENJUALAN
                ' ============================================
                Dim sqlUpdateDetail As String =
                "UPDATE tbldetailpenjualan 
                 SET qty = qty - @qtyRetur,
                     subtotal = (qty * harga) 
                 WHERE no_penjualan = @no_penjualan 
                   AND kode_barang = @kode_barang"

                Using cmdUpdateDetail As New MySqlCommand(sqlUpdateDetail, conn)
                    cmdUpdateDetail.Parameters.AddWithValue("@qtyRetur", row.Cells("colQty").Value)
                    cmdUpdateDetail.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBrg").Value)
                    cmdUpdateDetail.Parameters.AddWithValue("@no_penjualan", noPenjualanSource)
                    cmdUpdateDetail.ExecuteNonQuery()
                End Using


                ' ============================================
                ' UPDATE total penjualan pada tblpenjualan
                ' ============================================
                Dim sqlUpdatePenjualan As String =
                "UPDATE tblpenjualan 
                 SET total_penjualan = total_penjualan - @totalRetur
                 WHERE no_penjualan = @no_penjualan"

                Using cmdUpdatePenjualan As New MySqlCommand(sqlUpdatePenjualan, conn)
                    cmdUpdatePenjualan.Parameters.AddWithValue("@totalRetur", totalDanaAkhir)
                    cmdUpdatePenjualan.Parameters.AddWithValue("@no_penjualan", noPenjualanSource)
                    cmdUpdatePenjualan.ExecuteNonQuery()
                End Using
            Next
            MsgBox("Data pengembalian berhasil disimpan!", vbInformation)

        Catch ex As Exception
            MsgBox("Gagal menyimpan pengembalian: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            GenerateNoPengembalian()
            Me.Close()
            frm_ListSemuaPenjualan.load_ListPenjualanSemua()
            dgv_detailPengembalian.Rows.Clear()
            frm_ManageStok.CekStokMenipis()
        End Try
    End Sub
    Private Sub btn_btlBeli_Click(sender As Object, e As EventArgs) Handles btn_btlBeli.Click
        Me.Close()
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        hitungSubTotal()
    End Sub
End Class