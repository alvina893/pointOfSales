Imports MySql.Data.MySqlClient

Public Class frm_ManagePembelian
    Public Class BarangInfo
        Public Property ID As String
        Public Property Satuan As String
        Public Property Nama As String
        Public Property HargaBeli As String
        Public Property SupplierID As String
        Public Property SupplierNama As String

    End Class

    Dim supplierIdToName As New Dictionary(Of String, String)
    Public barangDict As New Dictionary(Of String, BarangInfo)
    Dim isProgrammaticChange As Boolean = False
    Dim supplierTerkunci As String = ""

    Private Sub frm_ManagePembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        dgv_listPembelian.RowTemplate.Height = 30
        dgv_detailPembelian.RowTemplate.Height = 30

        load_supplier()
        load_barang()
        load_ListPembelian()

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want

        cbo_brg.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbo_brg.AutoCompleteSource = AutoCompleteSource.ListItems

        dgv_detailPembelian.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_detailPembelian.MultiSelect = False

        GenerateNoPembelian()
    End Sub

    Sub clear()
        cbo_IDSup.SelectedIndex = -1
        cbo_IDSup.Enabled = True        ' <-- enable kembali saat clear
        supplierTerkunci = ""            ' reset supplier terkunci
        txt_NamaSupplier.Clear()
        cbo_brg.SelectedIndex = -1
        cbo_brg.Text = ""
        txt_qty.Clear()
        txt_satuanBrgBeli.Clear()
        txt_hrgaBeli.Clear()
        txt_subTotal.Clear()
        txt_namaBrg.Clear()
        lbl_IDPembelian.Text = ""
        lbl_tanggalPembelian.Text = ""
        lbl_IDSupBeli.Text = ""
        lbl_nmaSup.Text = ""
        lbl_totalPembelian.Text = ""
        rtb_detailPembelian.Clear()
        dgv_detailPembelian.Rows.Clear()
        txt_totalBeli.Text = ""
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

    Sub load_barang()
        cbo_brg.Items.Clear()
        barangDict.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT kode_barang, nama_barang, satuan_barang, harga_beli, supplier_ID, nama_supplier FROM tblbarang", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                Dim kode As String = dr("kode_barang").ToString()
                Dim nama As String = dr("nama_barang").ToString()
                Dim satuan As String = dr("satuan_barang").ToString()
                Dim hargaBeli As String = dr("harga_beli").ToString()
                Dim idSupplier As String = dr("supplier_ID").ToString()
                Dim nmaSupplier As String = dr("nama_supplier").ToString()

                cbo_brg.Items.Add(kode)

                barangDict(kode) = New BarangInfo With {
                .ID = kode,
                .Nama = nama,
                .Satuan = satuan,
                .HargaBeli = hargaBeli,
                .SupplierID = idSupplier,
                .SupplierNama = nmaSupplier
            }
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbo_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_brg.SelectedIndexChanged
        If cbo_brg.SelectedIndex <> -1 Then
            Dim id As String = cbo_brg.Text

            If barangDict.ContainsKey(id) Then
                Dim info = barangDict(id)

                isProgrammaticChange = True ' hentikan handling user event pada supplier
                cbo_IDSup.Text = info.SupplierID
                txt_NamaSupplier.Text = info.SupplierNama
                isProgrammaticChange = False

                txt_namaBrg.Text = info.Nama
                txt_satuanBrgBeli.Text = info.Satuan
                txt_hrgaBeli.Text = info.HargaBeli
            End If
        End If
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

    Sub load_ListPembelian()
        dgv_listPembelian.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `no_pembelian`, `tanggal`, `supplier_ID`, `nama_supplier`, `total` FROM `tblpembelian`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim tgl As DateTime = DateTime.Parse(dr("tanggal").ToString())
                dgv_listPembelian.Rows.Add(
                dgv_listPembelian.Rows.Count + 1,
                dr("no_pembelian"),
                tgl.ToString("dd/MM/yyyy"),
                dr("supplier_ID"),
                dr("nama_supplier"),
                dr("total")
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
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
    Private Sub cbo_nmaSup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_IDSup.SelectedIndexChanged
        If isProgrammaticChange Then
            Return ' abaikan event
        End If

        Dim id As String = cbo_IDSup.Text

        If supplierIdToName.ContainsKey(id) Then
            txt_NamaSupplier.Text = supplierIdToName(id)
            FilterBarangBySupplier(id)
        End If
        cbo_brg.SelectedIndex = -1
        txt_namaBrg.Clear()
        txt_qty.Clear()
        txt_hrgaBeli.Clear()
        txt_subTotal.Clear()
        txt_satuanBrgBeli.Clear()
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        mainForm_Admin.Show()
        Me.Close()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        frm_ManageBarang.Show()
        Me.Hide()
    End Sub

    Private Sub btnStokBarang_Click(sender As Object, e As EventArgs) Handles btnStokBarang.Click
        frm_ManageStok.Show()
        Me.Hide()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        frm_ManageSupplier.Show()
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

    Private Sub btn_simpanBeli_Click(sender As Object, e As EventArgs) Handles btn_simpanBeli.Click
        If txt_kodeBeli.Text = "" Then
            MsgBox("Input kode pembelian terlebih dahulu!")
            Exit Sub
        End If

        If cbo_IDSup.SelectedIndex = -1 Then
            MsgBox("Pilih supplier terlebih dahulu!")
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
            cmd.Parameters.AddWithValue("@supplier_ID", cbo_IDSup.Text)
            cmd.Parameters.AddWithValue("@nama_supplier", txt_NamaSupplier.Text)
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
                cmdDetail.Parameters.AddWithValue("@harga_beli", row.Cells("colHargaBli").Value)
                cmdDetail.Parameters.AddWithValue("@subtotal", row.Cells("colSubtotal").Value)
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
            load_ListPembelian()
            load_barang()
            frm_ManageStok.load_stock()
            frm_ManageStok.CekStokMenipis()
            frm_ManageBarang.load_Barang()
            clear()
            dgv_detailPembelian.Rows.Clear()
            GenerateNoPembelian()
        End Try
    End Sub

    Private Sub txt_hrgaBeli_TextChanged(sender As Object, e As EventArgs) Handles txt_hrgaBeli.TextChanged
        hitungSubtotal()
    End Sub

    Sub hitungSubtotal()
        Dim harga As Double
        Dim qty As Double

        Double.TryParse(txt_hrgaBeli.Text, harga)
        Double.TryParse(txt_qty.Text, qty)

        txt_subTotal.Text = (harga * qty).ToString()
    End Sub

    Sub FilterBarangBySupplier(supplierID As String)
        cbo_brg.Items.Clear()

        For Each kvp In barangDict
            Dim info As BarangInfo = kvp.Value

            If info.SupplierID = supplierID Then
                cbo_brg.Items.Add(info.ID)   ' hanya tampilkan barang milik supplier ini
            End If
        Next
    End Sub

    Private Sub btn_tmbhDetBeli_Click(sender As Object, e As EventArgs) Handles btn_tmbhDetBeli.Click
        ' VALIDASI INPUT
        If cbo_brg.SelectedIndex = -1 Or txt_qty.Text = "" Or txt_hrgaBeli.Text = "" Then
            MessageBox.Show("Lengkapi data barang")
            Exit Sub
        End If

        ' ============================================
        ' KUNCI SUPPLIER SETELAH BARANG PERTAMA MASUK
        ' ============================================
        If dgv_detailPembelian.Rows.Count = 0 Then
            ' BARANG PERTAMA → KUNCI SUPPLIER
            supplierTerkunci = cbo_IDSup.Text
            If supplierTerkunci = "" Then
                MessageBox.Show("Pilih supplier terlebih dahulu!")
                Exit Sub
            End If

            ' disable combobox agar user tidak bisa ganti supplier
            cbo_IDSup.Enabled = False
        Else
            ' BARANG KEDUA DAN SETERUSNYA → CEK SUPPLIER
            If cbo_IDSup.Text <> supplierTerkunci Then
                MessageBox.Show("Supplier tidak boleh diganti. Semua barang harus dari supplier yang sama.")
                Exit Sub
            End If
        End If

        ' FILTER BARANG SESUAI SUPPLIER TERKUNCI
        FilterBarangBySupplier(supplierTerkunci) ' pastikan pakai supplierID jika argumen butuh ID

        ' AMBIL DATA BARANG
        Dim info As BarangInfo = barangDict(cbo_brg.Text)
        Dim barangID As String = info.ID
        Dim satuan As String = info.Satuan
        Dim namaBar As String = info.Nama

        Dim qty As Integer = Integer.Parse(txt_qty.Text)
        Dim harga As Decimal = Decimal.Parse(txt_hrgaBeli.Text)
        Dim subtotal As Decimal = qty * harga

        dgv_detailPembelian.Rows.Add(
        Nothing,
        barangID,
        namaBar,
        qty,
        satuan,
        harga,
        subtotal
    )

        hitungTotalPembelian()

        cbo_brg.SelectedIndex = -1
        txt_qty.Clear()
        txt_satuanBrgBeli.Clear()
        txt_hrgaBeli.Clear()
        txt_subTotal.Clear()
        txt_namaBrg.Clear()
    End Sub


    Private Sub dgv_detailPembelian_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgv_detailPembelian.RowPostPaint
        dgv_detailPembelian.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
    End Sub

    Private Sub dgv_detailPembelian_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detailPembelian.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        If MessageBox.Show("Hapus item ini?", "Hapus", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dgv_detailPembelian.Rows.RemoveAt(e.RowIndex)
            hitungTotalPembelian()

            ' Jika setelah penghapusan list kosong, buka kembali supplier
            If dgv_detailPembelian.Rows.Count = 0 Then
                supplierTerkunci = ""
                cbo_IDSup.Enabled = True
                load_barang() ' opsional: reload agar cbo_brg kembalikan semua barang
            End If
        End If
    End Sub

    Private Sub btn_btlBeli_Click(sender As Object, e As EventArgs) Handles btn_btlBeli.Click
        clear()
        load_barang()
    End Sub

    Private Sub txt_cariBrg_TextChanged(sender As Object, e As EventArgs) Handles txt_cariBrg.TextChanged
        dgv_listPembelian.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblpembelian 
                        WHERE no_pembelian LIKE '%" & txt_cariBrg.Text & "%' 
                        OR tanggal LIKE '%" & txt_cariBrg.Text & "%' 
                        OR nama_supplier LIKE '%" & txt_cariBrg.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim tgl As Date = Date.Parse(dr("tanggal").ToString())
                dgv_listPembelian.Rows.Add(
                dgv_listPembelian.Rows.Count + 1,
                dr("no_pembelian"),
                tgl.ToString("dd/MM/yyyy"),
                dr("supplier_ID"),
                dr("nama_supplier"),
                dr("total")
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub TampilkanDetailPembelian(idBeli As String)
        Try

            ' TAMPILKAN HEADER PEMBELIAN
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim queryHeader As String =
            "SELECT no_pembelian, tanggal, supplier_ID, nama_supplier, total 
             FROM tblpembelian
             WHERE no_pembelian  = @no_pembelian"

            Using cmd As New MySqlCommand(queryHeader, conn)
                cmd.Parameters.AddWithValue("@no_pembelian", idBeli)
                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        lbl_IDPembelian.Text = "No Pembelian: " & rd("no_pembelian").ToString()
                        lbl_tanggalPembelian.Text = "Tanggal: " & rd("tanggal").ToString()
                        lbl_IDSupBeli.Text = "ID Supplier: " & rd("supplier_ID").ToString()
                        lbl_nmaSup.Text = "Nama Supplier: " & rd("nama_supplier").ToString()
                        lbl_totalPembelian.Text = "Total Pembelian: Rp. " & Format(CDec(rd("total")), "N0")
                    End If
                End Using
            End Using

            Dim sqlDetail As String =
            "SELECT nama_barang, qty, satuan, harga_beli, subtotal
             FROM tbldetailpembelian 
             WHERE no_pembelian = @no_pembelian"

            Dim da As New MySqlDataAdapter(sqlDetail, conn)
            da.SelectCommand.Parameters.AddWithValue("@no_pembelian", idBeli)

            Dim dt As New DataTable()
            da.Fill(dt)

            rtb_detailPembelian.Clear()

            Dim nomor As Integer = 1

            For Each row As DataRow In dt.Rows
                rtb_detailPembelian.AppendText(
                nomor & ". " & row("nama_barang").ToString() & vbCrLf &
                "   Qty      : " & row("qty").ToString() & " " & row("satuan").ToString() & vbCrLf &
                "   Harga    : " & Format(row("harga_beli"), "N0") & vbCrLf &
                "   Subtotal : " & Format(row("subtotal"), "N0") & vbCrLf &
                "----------------------------------------" & vbCrLf
            )
                nomor += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgv_listPembelian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listPembelian.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idBeli As String = dgv_listPembelian.Rows(e.RowIndex).Cells("colIDPembelian").Value.ToString()

        TampilkanDetailPembelian(idBeli)
    End Sub

    Private Sub btn_clearPembelian_Click(sender As Object, e As EventArgs) Handles btn_clearPembelian.Click
        clear()
    End Sub

    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        frm_ManagePengembalian.Show()
        Me.Hide()
    End Sub
    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        hitungSubtotal()
    End Sub

    Private Sub btnclearForm_Click(sender As Object, e As EventArgs)
        clear()
    End Sub

    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        frm_ManagePenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub btn_barangBaruBeli_Click(sender As Object, e As EventArgs) Handles btn_barangBaruBeli.Click
        frm_PopUpBarangBaru.ShowDialog()
    End Sub
End Class