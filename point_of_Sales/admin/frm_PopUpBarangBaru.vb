Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frm_PopUpBarangBaru

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

    Dim supplierDict As New Dictionary(Of String, String)

    Sub load_supplier()
        cbo_nmaSup.Items.Clear()
        supplierDict.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT supplier_ID, nama_supplier FROM tblsupplier", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim id As String = dr("supplier_ID").ToString()
                Dim nama As String = dr("nama_supplier").ToString()

                cbo_nmaSup.Items.Add(nama)           ' Display name
                supplierDict(nama) = id              ' Store ID for later
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

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
    Private Sub frm_PopUpBarangBaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()

        load_kategoriBarang()
        load_satuanBarang()
        load_supplier()
    End Sub

    Private Sub btn_tmbhKategori_Click(sender As Object, e As EventArgs) Handles btn_tmbhKategori.Click
        Using fSatuan As New frm_tbhKategori
            fSatuan.ShowDialog(Me)  ' Me = form Tambah Barang sebagai parent
        End Using
    End Sub

    Private Sub btn_tmbhSatuan_Click(sender As Object, e As EventArgs) Handles btn_tmbhSatuan.Click
        Using fSatuan As New frm_tbhSatuan
            fSatuan.ShowDialog(Me)  ' Me = form Tambah Barang sebagai parent
        End Using
    End Sub

    Private Sub txt_kodeBrg_TextChanged(sender As Object, e As EventArgs) Handles txt_kodeBrg.TextChanged
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White

        Try
            pic_barcodeBrg.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, txt_kodeBrg.Text))

        Catch ex As Exception
            pic_barcodeBrg.Image = Nothing
        End Try
    End Sub

    Private Sub cbo_nmaSup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_nmaSup.SelectedIndexChanged
        Dim nama As String = cbo_nmaSup.Text

        If supplierDict.ContainsKey(nama) Then
            txt_IDSup.Text = supplierDict(nama)
        End If
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

    Sub clear()
        txt_kodeBrg.Clear()
        txt_nmaBrg.Clear()
        cbo_kategoriBrg.SelectedIndex = -1
        cbo_satuanBrg.SelectedIndex = -1
        cbo_nmaSup.SelectedIndex = -1
        txt_IDSup.Clear()
        txt_hrgaBrg.Clear()
        txt_hrgaBeli.Clear()
        txt_stok.Clear()
        txt_minStok.Clear()
        pic_barcodeBrg.Image = Nothing
    End Sub

    Private Sub btn_simpanBrg_Click(sender As Object, e As EventArgs) Handles btn_simpanBrg.Click
        Try
            If cekBarangViaKode(txt_kodeBrg.Text) Then
                MsgBox("Kode barang sudah terdaftar! Gunakan tombol UPDATE untuk mengubah data.", vbExclamation)
                Exit Sub
            End If

            conn.Open()
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_barcodeBrg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()

            cmd = New MySqlCommand("INSERT INTO `tblbarang`(`kode_barang`, `nama_barang`, `kategori_barang`, `satuan_barang`, `harga_beli`, `harga_barang`, `stok`, `min_stok`, `barcode`, `supplier_ID`, `nama_supplier`) VALUES (@kode_barang, @nama_barang, @kategori_barang, @satuan_barang, @harga_beli, @harga_barang, @stok, @min_stok, @barcode, @supplier_ID, @nama_supplier)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_barang", txt_kodeBrg.Text)
            cmd.Parameters.AddWithValue("@nama_barang", txt_nmaBrg.Text)
            cmd.Parameters.AddWithValue("@kategori_barang", cbo_kategoriBrg.Text)
            cmd.Parameters.AddWithValue("@satuan_barang", cbo_satuanBrg.Text)
            cmd.Parameters.AddWithValue("@harga_beli", CDec(txt_hrgaBeli.Text))
            cmd.Parameters.AddWithValue("@harga_barang", CDec(txt_hrgaBrg.Text))
            cmd.Parameters.AddWithValue("@stok", txt_stok.Text)
            cmd.Parameters.AddWithValue("@min_stok", txt_minStok.Text)
            cmd.Parameters.AddWithValue("@barcode", arrImage)
            cmd.Parameters.AddWithValue("@supplier_ID", txt_IDSup.Text)
            cmd.Parameters.AddWithValue("@nama_supplier", cbo_nmaSup.Text)


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
        frm_ManagePembelian.load_barang()
        Me.Close()
    End Sub

    Private Sub btn_delBrg_Click(sender As Object, e As EventArgs) Handles btn_delBrg.Click
        Me.Close()
    End Sub
End Class