Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Public Class mainForm_Employee

    Public Class BarangInfo
        Public Property ID As String
        Public Property Satuan As String
        Public Property Nama As String
        Public Property HargaBeli As String
        Public Property SupplierID As String
        Public Property SupplierNama As String
    End Class

    Dim supplierDict As New Dictionary(Of String, String)
    Public barangDict As New Dictionary(Of String, BarangInfo)
    Dim isProgrammaticChange As Boolean = False
    Dim supplierTerkunci As String = ""

    Sub load_ListPengembalian()
        dgv_listPengembalian.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT 
                `no_pengembalian`, 
                `tanggal`, 
                `metode_pengembalian`, 
                `total_returDana`, 
                `total_returStok`,
                `status_pengembalian`,
                `supplier_ID`, 
                `nama_supplier`  
                 FROM `tblpengembalian`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim tgl As DateTime = DateTime.Parse(dr("tanggal").ToString())
                dgv_listPengembalian.Rows.Add(
                dgv_listPengembalian.Rows.Count + 1,
                dr("no_pengembalian"),
                tgl.ToString("dd/MM/yyyy"),
                dr("metode_pengembalian"),
                dr("total_returDana"),
                dr("total_returStok"),
                dr("status_pengembalian"),
                dr("supplier_ID"),
                dr("nama_supplier")
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
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
        cbo_brg.SelectedIndex = -1
    End Sub
    Private Sub mainForm_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_supplier()
        load_barang()
        load_ListPengembalian()
        GenerateNoPengembalian()

        cbo_brg.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbo_brg.AutoCompleteSource = AutoCompleteSource.ListItems

        dgv_detailPengembalian.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_detailPengembalian.MultiSelect = False

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want

        dgv_listPengembalian.RowTemplate.Height = 30
    End Sub

    Sub clear()
        cbo_nmaSup.SelectedIndex = -1
        txt_IDSup.Clear()
        cbo_brg.SelectedIndex = -1
        cbo_brg.Text = ""
        txt_qty.Clear()
        txt_satuanBrg.Clear()
        txt_hrgaSatuan.Clear()
        txt_subTotal.Clear()
        txt_namaBrg.Clear()
        dgv_detailPengembalian.Rows.Clear()
        txt_totalDanaRetur.Text = ""
        txt_totalStokRetur.Text = ""
        cbo_nmaSup.Enabled = True        ' <-- enable kembali saat clear
        supplierTerkunci = ""            ' reset supplier terkunci
        GenerateNoPengembalian()
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
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin ingin logout?", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
            loginForm.Show()
        Else
            Return
        End If
    End Sub
    Sub hitungSubTotal()
        Dim harga As Double
        Dim qty As Double

        Double.TryParse(txt_hrgaSatuan.Text, harga)
        Double.TryParse(txt_qty.Text, qty)

        txt_subTotal.Text = (harga * qty).ToString()
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

    Private Sub ApplyCalculationBasedOnMethod()
        'If cbo_metodeRetur.SelectedItem = "Refund (Dana)" Then
        HitungTotalDana()
        'ElseIf cbo_metodeRetur.SelectedItem = "Tukar Guling (Barang)" Then
        HitungTotalStok()
        'End If
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
        If cbo_brg.SelectedIndex = -1 Or txt_qty.Text = "" Or txt_hrgaSatuan.Text = "" Then
            MessageBox.Show("Lengkapi data barang")
            Exit Sub
        End If

        ' ============================================
        ' KUNCI SUPPLIER SETELAH BARANG PERTAMA MASUK
        ' ============================================
        If dgv_detailPengembalian.Rows.Count = 0 Then
            ' BARANG PERTAMA → KUNCI SUPPLIER
            supplierTerkunci = cbo_nmaSup.Text
            If supplierTerkunci = "" Then
                MessageBox.Show("Pilih supplier terlebih dahulu!")
                Exit Sub
            End If

            ' disable combobox agar user tidak bisa ganti supplier
            cbo_nmaSup.Enabled = False
        Else
            ' BARANG KEDUA DAN SETERUSNYA → CEK SUPPLIER
            If cbo_nmaSup.Text <> supplierTerkunci Then
                MessageBox.Show("Supplier tidak boleh diganti. Semua barang harus dari supplier yang sama.")
                Exit Sub
            End If
        End If

        ' FILTER BARANG SESUAI SUPPLIER TERKUNCI
        FilterBarangBySupplier(supplierDict(supplierTerkunci)) ' pastikan pakai supplierID jika argumen butuh ID

        ' AMBIL DATA BARANG
        Dim info As BarangInfo = barangDict(cbo_brg.Text)
        Dim barangID As String = info.ID
        Dim satuan As String = info.Satuan
        Dim namaBar As String = info.Nama

        Dim qty As Integer = Integer.Parse(txt_qty.Text)
        Dim harga As Decimal = Decimal.Parse(txt_hrgaSatuan.Text)
        Dim subtotal As Decimal = qty * harga

        dgv_detailPengembalian.Rows.Add(
            Nothing,
            barangID,
            namaBar,
            qty,
            satuan,
            harga,
            subtotal
        )

        hitungTotalPengembalian()

        cbo_brg.SelectedIndex = -1
        txt_qty.Clear()
        txt_satuanBrg.Clear()
        txt_hrgaSatuan.Clear()
        txt_subTotal.Clear()
        txt_namaBrg.Clear()
    End Sub

    Private Sub btn_btlRetur_Click(sender As Object, e As EventArgs) Handles btn_btlRetur.Click
        clear()
    End Sub

    Private Sub btn_simpanRetur_Click(sender As Object, e As EventArgs) Handles btn_simpanRetur.Click
        If cbo_nmaSup.SelectedIndex = -1 Then
            MsgBox("Pilih supplier terlebih dahulu!")
            Exit Sub
        End If

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
                cmd.Parameters.AddWithValue("@supID", txt_IDSup.Text)
                cmd.Parameters.AddWithValue("@supNama", cbo_nmaSup.Text)
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
                    cmdDetail.Parameters.AddWithValue("@harga", row.Cells("colHarga").Value)
                    cmdDetail.Parameters.AddWithValue("@subtotal", row.Cells("colSubtotal").Value)
                    cmdDetail.ExecuteNonQuery()
                End Using

                ' Update stok
                Using updateCmd As New MySqlCommand("UPDATE tblbarang SET stok = stok - @qty WHERE kode_barang=@kode", conn)
                    updateCmd.Parameters.AddWithValue("@qty", row.Cells("colQty").Value)
                    updateCmd.Parameters.AddWithValue("@kode", row.Cells("colKodeBrg").Value)
                    updateCmd.ExecuteNonQuery()
                End Using
            Next

            MsgBox("Data pengembalian berhasil disimpan!", vbInformation)

        Catch ex As Exception
            MsgBox("Gagal menyimpan pengembalian: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            clear()
            GenerateNoPengembalian()
            load_ListPengembalian()

            dgv_detailPengembalian.Rows.Clear()
            frm_ManageStok.CekStokMenipis()
        End Try
    End Sub

    'Private Sub cbo_metodeRetur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_metodeRetur.SelectedIndexChanged
    '    If cbo_metodeRetur.SelectedItem Is Nothing Then Exit Sub

    '    Dim metode As String = cbo_metodeRetur.SelectedItem.ToString()

    '    If metode = "Refund (Dana)" Then
    '        'Aktifkan Total Dana'
    '        txt_totalDanaRetur.Enabled = True

    '        'Matikan dan reset Total Stok'
    '        txt_totalStokRetur.Text = "0"
    '        txt_totalStokRetur.Clear()
    '        txt_totalStokRetur.Enabled = False

    '        'Hanya subtotal yang dihitung'
    '        HitungTotalDana()

    '    ElseIf metode = "Tukar Guling (Barang)" Then

    '        'Aktifkan Total Stok'
    '        txt_totalStokRetur.Enabled = True

    '        'Matikan dan reset Total Dana'
    '        txt_totalDanaRetur.Text = "0"
    '        txt_totalDanaRetur.Clear()
    '        txt_totalDanaRetur.Enabled = False

    '        'Hanya stok QTY yang dihitung'
    '        HitungTotalStok()
    '    End If
    'End Sub

    Private Sub cbo_brg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_brg.SelectedIndexChanged
        If cbo_brg.SelectedIndex <> -1 Then
            Dim id As String = cbo_brg.Text

            If barangDict.ContainsKey(id) Then
                Dim info = barangDict(id)

                isProgrammaticChange = True ' hentikan handling user event pada supplier
                cbo_nmaSup.Text = info.SupplierNama
                txt_IDSup.Text = info.SupplierID
                isProgrammaticChange = False

                txt_namaBrg.Text = info.Nama
                txt_satuanBrg.Text = info.Satuan
                txt_hrgaSatuan.Text = info.HargaBeli
            End If
        End If
    End Sub

    Private Sub cbo_nmaSup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_nmaSup.SelectedIndexChanged
        If isProgrammaticChange Then
            Return ' abaikan event
        End If

        Dim nama As String = cbo_nmaSup.Text

        If supplierDict.ContainsKey(nama) Then
            txt_IDSup.Text = supplierDict(nama)
            FilterBarangBySupplier(txt_IDSup.Text)
        End If
        cbo_brg.SelectedIndex = -1
        txt_namaBrg.Clear()
        txt_qty.Clear()
        txt_hrgaSatuan.Clear()
        txt_subTotal.Clear()
        txt_satuanBrg.Clear()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub
    Private Sub dgv_detailPengembalian_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Exit Sub

        If MessageBox.Show("Hapus item ini?", "Hapus", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dgv_detailPengembalian.Rows.RemoveAt(e.RowIndex)
            hitungTotalPengembalian()
        End If
    End Sub

    Private Sub dgv_detailPengembalian_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        dgv_detailPengembalian.Rows(e.RowIndex).Cells(0).Value = (e.RowIndex + 1).ToString()
    End Sub
    Private Sub dgv_detailPengembalian_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        ApplyCalculationBasedOnMethod()
    End Sub
    Private Sub dgv_detailPengembalian_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ApplyCalculationBasedOnMethod()
    End Sub

    Private Sub TampilkanDetailPengembalian(idRetur As String)
        Try
            ' TAMPILKAN HEADER PEMBELIAN
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim queryHeader As String =
            "SELECT no_pengembalian, tanggal, metode_pengembalian, total_returDana, total_returStok, supplier_ID, nama_supplier, status_pengembalian 
             FROM tblpengembalian
             WHERE no_pengembalian = @no_pengembalian"

            Using cmd As New MySqlCommand(queryHeader, conn)
                cmd.Parameters.AddWithValue("@no_pengembalian", idRetur)
                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        lbl_IDPengembalian.Text = "No Pengembalian: " & rd("no_pengembalian").ToString()
                        lbl_tanggalPengembalian.Text = "Tanggal: " & rd("tanggal").ToString()
                        lbl_metodePengembalian.Text = "Metode: " & rd("metode_pengembalian").ToString()
                        lbl_IDSupRetur.Text = "ID Supplier: " & rd("supplier_ID").ToString()
                        lbl_nmaSup.Text = "Nama Supplier: " & rd("nama_supplier").ToString()
                        lbl_totalDanaRetur.Text = "Total Dana Refund: Rp. " & Format(CDec(rd("total_returDana")), "N0")
                        lbl_totalStokRetur.Text = "Total Stok Retur: " & Format(CInt(rd("total_returStok")), "N0")
                        lbl_statusPengembalian.Text = "Status Retur: " & rd("status_pengembalian").ToString()
                    End If
                End Using
            End Using

            Dim sqlDetail As String =
            "SELECT nama_barang, qty, satuan, harga, subtotal
             FROM tbldetailpengembalian 
             WHERE no_pengembalian = @no_pengembalian"

            Dim da As New MySqlDataAdapter(sqlDetail, conn)
            da.SelectCommand.Parameters.AddWithValue("@no_pengembalian", idRetur)

            Dim dt As New DataTable()
            da.Fill(dt)

            rtb_detailPengembalian.Clear()

            Dim nomor As Integer = 1

            For Each row As DataRow In dt.Rows
                rtb_detailPengembalian.AppendText(
                nomor & ". " & row("nama_barang").ToString() & vbCrLf &
                "   Qty      : " & row("qty").ToString() & " " & row("satuan").ToString() & vbCrLf &
                "   Harga    : " & Format(row("harga"), "N0") & vbCrLf &
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

    Private Sub dgv_listPengembalian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listPengembalian.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idRetur As String = dgv_listPengembalian.Rows(e.RowIndex).Cells("colIDPengembalian").Value.ToString()

        TampilkanDetailPengembalian(idRetur)
    End Sub

    Private Sub txt_cariPengembalian_TextChanged(sender As Object, e As EventArgs)
        dgv_listPengembalian.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM tblpengembalian 
                        WHERE no_pengembalian LIKE '%" & txt_cariPengembalian.Text & "%' 
                        OR tanggal LIKE '%" & txt_cariPengembalian.Text & "%' 
                        OR metode_pengembalian LIKE '%" & txt_cariPengembalian.Text & "%' 
                        OR status_pengembalian LIKE '%" & txt_cariPengembalian.Text & "%' 
                        OR nama_supplier LIKE '%" & txt_cariPengembalian.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim tgl As Date = Date.Parse(dr("tanggal").ToString())
                dgv_listPengembalian.Rows.Add(
                dgv_listPengembalian.Rows.Count + 1,
                dr("no_pengembalian"),
                tgl.ToString("dd/MM/yyyy"),
                dr("metode_pengembalian"),
                dr("total_returDana"),
                dr("total_returStok"),
                dr("status_pengembalian"),
                dr("supplier_ID"),
                dr("nama_supplier")
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        hitungSubTotal()
    End Sub

    Private Sub btnStok_Click(sender As Object, e As EventArgs) Handles btnStok.Click
        frm_StokBarang.Show()
        Me.Close()
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        frm_DeliveryManage.Show()
        Me.Close()
    End Sub

    Private Sub btnPickup_Click(sender As Object, e As EventArgs) Handles btnPickup.Click
        frm_PickupManage.Show()
        Me.Close()
    End Sub
End Class