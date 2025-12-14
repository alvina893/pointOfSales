Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class frm_ListSemuaPenjualan
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

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        frm_ManagePenjualanDelivery.Show()
        Me.Hide()
    End Sub

    Private Sub btnPickup_Click(sender As Object, e As EventArgs) Handles btnPickup.Click
        frm_ManagePenjualanPickup.Show()
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

    Sub load_ListPenjualanSemua()
        dgv_semuaPenjualan.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
             FROM tblpenjualan 
             ORDER BY tanggal DESC"

            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim tgl As Date = Date.Parse(dr("tanggal").ToString())

                        dgv_semuaPenjualan.Rows.Add(
                        dgv_semuaPenjualan.Rows.Count + 1,
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

    Private Sub frm_ListSemuaPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Me.MaximizeBox = False
        Me.Size = New Size(1366, 768)  ' choose any width you want
        dgv_semuaPenjualan.RowTemplate.Height = 30
        load_ListPenjualanSemua()
    End Sub
    Sub TampilkanDetailPenjualanSemua(noPenjualan As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' === TAMPILKAN HEADER PENJUALAN ===
            Dim queryHeader As String =
        "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, metode_pembayaran, status_penjualan, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
         FROM tblpenjualan
         WHERE no_penjualan = @noPenjualan"

            Using cmd As New MySqlCommand(queryHeader, conn)
                cmd.Parameters.AddWithValue("@noPenjualan", noPenjualan)

                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        lbl_noJualPending.Text = "No Penjualan: " & rd("no_penjualan").ToString()
                        lbl_jenisJualPending.Text = "Jenis: " & rd("jenis_penjualan").ToString()
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
                        MsgBox("Data penjualan tidak ditemukan!", vbExclamation)
                        Exit Sub
                    End If
                End Using
            End Using

            ' === TAMPILKAN DETAIL ITEM ===
            Dim queryDetail As String =
                "SELECT 
                    d.kode_barang,
                    d.nama_barang,
                    d.qty,
                    d.satuan,
                    d.harga,
                    d.subtotal,
                    b.supplier_ID,
                    s.nama_supplier
                 FROM tbldetailpenjualan d
                 JOIN tblbarang b ON d.kode_barang = b.kode_barang
                 JOIN tblsupplier s ON b.supplier_ID = s.supplier_ID
                 WHERE d.no_penjualan = @noPenjualan"

            Dim da As New MySqlDataAdapter(queryDetail, conn)
            da.SelectCommand.Parameters.AddWithValue("@noPenjualan", noPenjualan)

            Dim dt As New DataTable()
            da.Fill(dt)

            ' Bersihkan grid
            dgv_tabelDetailPenjualan.Rows.Clear()

            Dim nomor As Integer = 1

            For Each row As DataRow In dt.Rows
                dgv_tabelDetailPenjualan.Rows.Add(
                    nomor,
                    row("kode_barang").ToString(),
                    row("nama_barang").ToString(),
                    row("qty").ToString(),
                    row("satuan").ToString(),
                    Format(CDec(row("harga")), "N0"),
                    Format(CDec(row("subtotal")), "N0"),
                    row("supplier_ID"),
                    row("nama_supplier"),
                    False
                )
                nomor += 1
            Next

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub dgv_semuaPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_semuaPenjualan.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idJualSemua As String = dgv_semuaPenjualan.Rows(e.RowIndex).Cells("colNoPenjualan").Value.ToString()

        TampilkanDetailPenjualanSemua(idJualSemua)
    End Sub

    Private Sub dgv_tabelDetailPenjualan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tabelDetailPenjualan.CellContentClick
        If e.ColumnIndex = dgv_tabelDetailPenjualan.Columns("colAjukanPengembalianKasir").Index Then
            Dim kodeBarang As String = dgv_tabelDetailPenjualan.Rows(e.RowIndex).Cells("colKodeBrg").Value
            Dim qty As Integer = CInt(dgv_tabelDetailPenjualan.Rows(e.RowIndex).Cells("colQty").Value)
            Dim noPenjualan As String = lbl_noJualPending.Text.Replace("No Penjualan: ", "").Trim()

            ' buka form pembelian + autofill
            Dim frmPengembalian As New frm_PopUpPengembalianBaru
            frmPengembalian.load_DataPengembalian(noPenjualan, kodeBarang, qty)
            frmPengembalian.ShowDialog()
        End If
    End Sub

    Private Sub txt_cariPenjualan_TextChanged(sender As Object, e As EventArgs) Handles txt_cariPenjualan.TextChanged

    End Sub
End Class