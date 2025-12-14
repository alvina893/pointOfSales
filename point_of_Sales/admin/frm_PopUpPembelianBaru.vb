Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frm_PopUpPembelianBaru

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

    Private Sub frm_PopUpPembelianBaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()
        GenerateNoPembelian()
    End Sub

    Sub hitungSubtotal()
        Dim harga As Double
        Dim qty As Double

        Double.TryParse(txt_hargaBeli.Text, harga)
        Double.TryParse(txt_qty.Text, qty)

        txt_subTotal.Text = (harga * qty).ToString()
    End Sub

    Sub load_Barang(kodeBarang As String)

        dgv_detailPembelian.Rows.Clear()

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
                txt_hargaBeli.Text = dr("harga_beli").ToString()
            End If
            hitungSubtotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub GenerateNoPembelian()
        Dim prefix As String = "IM.PC"
        Dim newIncrement As Integer = 1
        Dim lastNo As String = ""
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Ambil nomor penjualan paling akhir untuk tanggal hari ini
            Dim query As String = " SELECT no_pembelian FROM tblpembelian WHERE DATE(tanggal) = CURDATE() ORDER BY pembelian_ID DESC LIMIT 1 "
            Dim cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                lastNo = result.ToString()
            End If
        Catch ex As Exception
            MsgBox("Error cek nomor pembelian: " & ex.Message)
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
        txt_kodeBeli.Text = $"{prefix}-{Date.Now:yyMMdd}-{newIncrement:0000}"
        txt_kodeBeli.ReadOnly = True
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        hitungSubtotal()
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
        ' 1. UPDATE MODE → jika row yang dipilih punya kode sama
        ' ==============================
        If dgv_detailPembelian.CurrentRow IsNot Nothing AndAlso
       dgv_detailPembelian.CurrentRow.Cells("colKodeBrg").Value.ToString() = kode Then

            Dim row = dgv_detailPembelian.CurrentRow

            row.Cells("colQty").Value = qty
            row.Cells("colHargaBli").Value = harga
            row.Cells("colSubtotal").Value = subtotal

            hitungTotalPembelian()
            Exit Sub
        End If

        ' ==============================
        ' 2. INSERT MODE → barang baru
        ' ==============================

        dgv_detailPembelian.Rows.Add(
        dgv_detailPembelian.Rows.Count + 1,
        txt_kodeBarang.Text,
        txt_namaBarang.Text,
        txt_qty.Text,
        txt_satuan.Text,
        txt_hargaBeli.Text,
        (Val(txt_qty.Text) * Val(txt_hargaBeli.Text)).ToString()
    )
        hitungTotalPembelian()

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
        If txt_kodeBeli.Text = "" Then
            MsgBox("Input kode pembelian terlebih dahulu!")
            Exit Sub
        End If

        If dgv_detailPembelian.Rows.Count = 0 Then
            MsgBox("Tidak ada barang yang dibeli!")
            Exit Sub
        End If

        Dim pembelianID As String = txt_kodeBeli.Text
        Dim totalAkhir As Decimal = 0

        For Each row As DataGridViewRow In dgv_detailPembelian.Rows
            totalAkhir += Convert.ToDecimal(row.Cells("colSubtotal").Value)
        Next

        Try
            conn.Open()

            Dim sqlPembelian As String =
            "INSERT INTO tblpembelian (no_pembelian, tanggal, supplier_ID, nama_supplier, total) " &
            "VALUES (@no_pembelian, @tanggal, @supplier_ID, @nama_supplier, @total)"

            cmd = New MySqlCommand(sqlPembelian, conn)
            cmd.Parameters.AddWithValue("@no_pembelian", txt_kodeBeli.Text)
            cmd.Parameters.AddWithValue("@tanggal", dtp_tglBeli.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@supplier_ID", txt_IDSupplier.Text)
            cmd.Parameters.AddWithValue("@nama_supplier", txt_namaSupplier.Text)
            cmd.Parameters.AddWithValue("@total", totalAkhir)
            cmd.ExecuteNonQuery()


            For Each row As DataGridViewRow In dgv_detailPembelian.Rows

                If row.Cells("colKodeBrg").Value Is Nothing Or row.Cells("colQty").Value Is Nothing Or row.Cells("colHargaBli").Value Is Nothing Or row.Cells("colSubtotal").Value Is Nothing Then

                    MsgBox("Terdapat item kosong pada daftar pembelian, harap periksa kembali!", vbExclamation)
                    Exit Sub
                End If

                Dim sqlDetail As String =
        "INSERT INTO tbldetailpembelian (no_pembelian, kode_barang, nama_barang, qty, satuan, harga_beli, subtotal) " &
        "VALUES (@no_pembelian, @kode_barang, @nama_barang, @qty, @satuan, @harga_beli, @subtotal)"

                Dim cmdDetail As New MySqlCommand(sqlDetail, conn)
                cmdDetail.Parameters.AddWithValue("@no_pembelian", pembelianID)
                cmdDetail.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBrg").Value)
                cmdDetail.Parameters.AddWithValue("@nama_barang", row.Cells("colNmaBrg").Value)
                cmdDetail.Parameters.AddWithValue("@qty", row.Cells("colQty").Value)
                cmdDetail.Parameters.AddWithValue("@satuan", row.Cells("colSatuan").Value)
                cmdDetail.Parameters.AddWithValue("@harga_beli",
                        ConvertToMySqlDecimal(row.Cells("colHargaBli").Value.ToString()))
                cmdDetail.Parameters.AddWithValue("@subtotal",
                        ConvertToMySqlDecimal(row.Cells("colSubtotal").Value.ToString()))
                cmdDetail.ExecuteNonQuery()

                ' === UPDATE STOK BARANG ===
                Dim sqlUpdateStok As String = "UPDATE tblbarang SET stok = stok + @qty WHERE kode_barang = @kode_barang"

                Dim cmdStok As New MySqlCommand(sqlUpdateStok, conn)
                cmdStok.Parameters.AddWithValue("@qty", row.Cells("colQty").Value)
                cmdStok.Parameters.AddWithValue("@kode_barang", row.Cells("colKodeBrg").Value)
                cmdStok.ExecuteNonQuery()
            Next

            MsgBox("Pembelian berhasil disimpan!", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal menyimpan pembelian: " & ex.Message)
        Finally
            conn.Close()
            frm_ManageStok.load_lowStock()
            frm_ManageStok.load_stock()
            frm_ManageStok.CekStokMenipis()
            frm_ManageBarang.load_Barang()
            dgv_detailPembelian.Rows.Clear()
            GenerateNoPembelian()
            frm_ManageStok.headerSelectAll.Visible = False
            frm_ManageStok.cbo_filterbySupplier.SelectedIndex = -1
            Me.Close()
        End Try
    End Sub
    Sub hitungTotalPembelian()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgv_detailPembelian.Rows
            If row.Cells("colSubtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("colSubtotal").Value)
            End If
        Next

        txt_totalBeli.Text = total.ToString()
    End Sub

    Public Sub LoadBarangRestock(listBarang As List(Of BarangRestock))

        dgv_detailPembelian.Rows.Clear()

        If listBarang.Count = 0 Then Exit Sub

        ' Set Supplier hanya sekali (dari barang pertama)
        txt_IDSupplier.Text = listBarang(0).supplierID
        txt_namaSupplier.Text = listBarang(0).namaSupplier

        For Each item In listBarang
            dgv_detailPembelian.Rows.Add(
            dgv_detailPembelian.Rows.Count + 1,
            item.kode,
            item.nama,
            0,                  ' Qty masih kosong (kasir isi sendiri)
            item.satuan,
            item.harga,
            0                   ' subtotal = 0 dulu
        )
        Next
    End Sub

    Private Sub dgv_detailPembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detailPembelian.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row = dgv_detailPembelian.Rows(e.RowIndex)

        txt_kodeBarang.Text = row.Cells("colKodeBrg").Value.ToString()
        txt_namaBarang.Text = row.Cells("colNmaBrg").Value.ToString()
        txt_satuan.Text = row.Cells("colSatuan").Value.ToString()
        txt_hargaBeli.Text = row.Cells("colHargaBli").Value.ToString()

        ' qty kosong → default 0
        txt_qty.Text = If(row.Cells("colQty").Value Is Nothing, "0", row.Cells("colQty").Value.ToString())

        ' hitung subtotal di textbox (otomatis)
        hitungSubtotal()
    End Sub

    Private Sub btn_btlBeli_Click(sender As Object, e As EventArgs) Handles btn_btlBeli.Click
        Me.Close()
    End Sub
End Class