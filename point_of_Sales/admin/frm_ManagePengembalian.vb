Imports MessagingToolkit.Barcode.QRCode.Decoder
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports point_of_Sales.frm_ManagePembelian

Public Class frm_ManagePengembalian

    Private selectedIDRetur As String = ""

    Sub load_ListPengembalian()
        dgv_listPengembalian.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand(
                "SELECT 
                `no_pengembalian`, 
                `tanggal`, 
                `metode_pengembalian`, 
                `total_returDana`, 
                `total_returStok`, 
                `status_pengembalian`, 
                `supplier_ID`, 
                `nama_supplier` 
                FROM `tblpengembalian`
                WHERE status_pengembalian = 'Telah Diajukan'", conn)
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

    Sub load_ListPengembalianAll()
        dgv_allPengembalian.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand(
                "SELECT 
                `no_pengembalian`, 
                `tanggal`, 
                `metode_pengembalian`, 
                `total_returDana`, 
                `total_returStok`, 
                `status_pengembalian`, 
                `supplier_ID`, 
                `nama_supplier` 
                FROM `tblpengembalian`
                WHERE status_pengembalian != 'Telah Diajukan'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim tgl As DateTime = DateTime.Parse(dr("tanggal").ToString())
                dgv_allPengembalian.Rows.Add(
                dgv_allPengembalian.Rows.Count + 1,
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
    Private Sub frm_ManagePengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        load_ListPengembalian()
        load_ListPengembalianAll()

        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want

        dgv_listPengembalian.RowTemplate.Height = 30
    End Sub

    Sub clear()
        lbl_IDPengembalian.Text = ""
        lbl_tanggalPengembalian.Text = ""
        lbl_IDSupRetur.Text = ""
        lbl_nmaSup.Text = ""
        lbl_totalStokRetur.Text = ""
        lbl_totalDanaRetur.Text = ""
        rtb_detailPengembalian.Clear()
        lbl_statusPengembalian.Text = ""
        lbl_metodePengembalian.Text = ""
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

    Private Sub btnPembelian_Click(sender As Object, e As EventArgs) Handles btnPembelian.Click
        frm_ManagePembelian.Show()
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
    Private Sub btn_clearPembelian_Click(sender As Object, e As EventArgs)
        clear()
    End Sub
    Private Sub btn_btlRetur_Click(sender As Object, e As EventArgs)
        clear()
    End Sub
    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        frm_ManagePenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_listPengembalian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listPengembalian.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim baris As Integer = e.RowIndex
        selectedIDRetur = dgv_listPengembalian.Rows(baris).Cells("colIDPengembalian").Value.ToString()

        ' tampilkan detail ke richtextbox form utama
        TampilkanDetailPengembalian(selectedIDRetur)
    End Sub

    Private Sub btn_konfirmPengembalian_Click(sender As Object, e As EventArgs) Handles btn_konfirmPengembalian.Click
        If dgv_listPengembalian.Rows.Count = 0 Then
            MsgBox("Tidak ada data penjualan pending!", vbExclamation)
            Exit Sub
        End If

        If String.IsNullOrEmpty(selectedIDRetur) Then
            MsgBox("Pilih data pengembalian terlebih dahulu!", vbExclamation)
            Exit Sub
        End If

        Dim baris As Integer = dgv_listPengembalian.CurrentRow.Index

        If dgv_listPengembalian.Item("colStatusPengembalian", baris).Value.ToString() = "Konfirmasi" Then
            MsgBox("Pengembalian sudah dikonfirmasikan!", vbExclamation)
            Exit Sub
        End If

        Dim formPopupPengembalian As New frm_KonfirmasiPengembalian
        formPopupPengembalian.lbl_noPengembalianAjukan.Text = dgv_listPengembalian.Item("colIDPengembalian", baris).Value.ToString()
        formPopupPengembalian.lbl_totalDanaPengembalianAjukan.Text = dgv_listPengembalian.Item("colTotalRefund", baris).Value.ToString()
        formPopupPengembalian.lbl_totalStokPengembalianAjukan.Text = dgv_listPengembalian.Item("colTotalRetur", baris).Value.ToString()

        ' kirim rincian dari richtextbox
        formPopupPengembalian.rtb_rincianPengembalian.Text = rtb_detailPengembalian.Text

        formPopupPengembalian.ShowDialog()
    End Sub

    Private Sub btnTolakPengembalian_Click(sender As Object, e As EventArgs) Handles btnTolakPengembalian.Click
        ' Pastikan ada baris yang dipilih
        If dgv_listPengembalian.CurrentRow Is Nothing Then
            MsgBox("Pilih data pengembalian yang ingin ditolak!", vbExclamation)
            Exit Sub
        End If

        Dim noPengembalian As String =
            dgv_listPengembalian.CurrentRow.Cells("colIDPengembalian").Value.ToString()

        ' Konfirmasi
        If MsgBox("Yakin ingin menolak pengembalian ini?", vbYesNo + vbQuestion) = vbNo Then
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim sql As String =
                "UPDATE tblpengembalian 
             SET status_pengembalian='Batal',
                 metode_pengembalian='Batal',
                 total_returDana=0,
                 total_returStok=0
             WHERE no_pengembalian=@no"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@no", noPengembalian)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Pengembalian berhasil ditolak.", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal menolak pengembalian: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            ' Refresh tabel di form lain
            mainForm_Employee.load_ListPengembalian()
            load_ListPengembalian()
        End Try
    End Sub

    Private Sub txt_cariPengembalian_TextChanged_1(sender As Object, e As EventArgs) Handles txt_cariPengembalian.TextChanged
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
End Class