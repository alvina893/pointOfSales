Imports MySql.Data.MySqlClient

Public Class frm_PickupManage
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin ingin logout?", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
            loginForm.Show()
        Else
            Return
        End If
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        frm_DeliveryManage.Show()
        Me.Close()
    End Sub

    Private Sub btnStok_Click(sender As Object, e As EventArgs) Handles btnStok.Click
        frm_StokBarang.Show()
        Me.Close()
    End Sub

    Private Sub btnPOS_Kasir_Click(sender As Object, e As EventArgs) Handles btnPOS_Kasir.Click
        mainForm_Employee.Show()
        Me.Close()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub txt_cariPenjualanPickupPacking_TextChanged(sender As Object, e As EventArgs) Handles txt_cariPenjualanPickupPacking.TextChanged
        dgv_listPickupPacking.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("
                SELECT * FROM tblpenjualan
                WHERE status_pengiriman = 'Packing' AND jenis_penjualan = 'Pickup'
                AND (
                    LOWER(no_penjualan) LIKE LOWER(@keyword)
                    OR LOWER(tanggal) LIKE LOWER(@keyword)
                    OR LOWER(atas_nama) LIKE LOWER(@keyword)
                    OR LOWER(metode_pembayaran) LIKE LOWER(@keyword)
                )
                ", conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & txt_cariPenjualanPickupPacking.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                Dim tgl As Date = Date.Parse(dr("tanggal").ToString())
                dgv_listPickupPacking.Rows.Add(
                dgv_listPickupPacking.Rows.Count + 1,
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
                dr("status_pengiriman").ToString()
            )
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub load_ListPickupLunasPacking()
        dgv_listPickupPacking.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, catatan, atas_nama, kontak_penerima, status_pengiriman
             FROM tblpenjualan 
             WHERE status_penjualan = 'Lunas' AND jenis_penjualan = 'Pickup'
             ORDER BY tanggal DESC"

            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim tgl As Date = Date.Parse(dr("tanggal").ToString())

                        dgv_listPickupPacking.Rows.Add(
                        dgv_listPickupPacking.Rows.Count + 1,
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

    Private Sub frm_PickupManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_ListPickupLunasPacking()
    End Sub

    Private Sub btn_updateLunasPenjualan_Click(sender As Object, e As EventArgs) Handles btn_updateLunasPenjualan.Click
        If dgv_listPickupPacking.Rows.Count = 0 Then
            MsgBox("Tidak ada data penjualan!", vbExclamation)
            Exit Sub
        End If

        Dim baris As Integer = dgv_listPickupPacking.CurrentRow.Index

        Dim formPopup As New frm_UpdateStatusPengiriman
        formPopup.AsalForm = "Pickup"
        formPopup.lbl_noPenjualanKirimLunas.Text = dgv_listPickupPacking.Item("colNoPenjualan", baris).Value.ToString()
        formPopup.lbl_tanggalKirimLunas.Text = dgv_listPickupPacking.Item("colTglPembelian", baris).Value.ToString()
        formPopup.lbl_atasNamaKirimLunas.Text = dgv_listPickupPacking.Item("colAtasNama", baris).Value.ToString()
        formPopup.lbl_kontakKirimLunas.Text = dgv_listPickupPacking.Item("colKontak", baris).Value.ToString()
        formPopup.lbl_alamatKirimLunas.Text = ""
        formPopup.lblalamat.Text = ""
        formPopup.ShowDialog()
    End Sub

    Private Sub TampilkanDetailPickupLunas(noPenjualan As String)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' === TAMPILKAN HEADER PENJUALAN ===
            Dim queryHeader As String =
        "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, metode_pembayaran, status_penjualan, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
         FROM tblpenjualan
         WHERE status_penjualan = 'Lunas' AND no_penjualan = @noPenjualan"

            Using cmd As New MySqlCommand(queryHeader, conn)
                cmd.Parameters.AddWithValue("@noPenjualan", noPenjualan)

                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        lbl_noJualPending.Text = "No Penjualan: " & rd("no_penjualan").ToString()
                        lbl_tglJualPending.Text = "Tanggal: " & CDate(rd("tanggal")).ToString("dd MMM yyyy")
                        lbl_totalJualPending.Text = "Total: Rp. " & Format(CDec(rd("total_penjualan")), "N0")
                        lbl_metodeJualPending.Text = "Metode: " & rd("metode_pembayaran").ToString()
                        lbl_statusJualPending.Text = "Status: " & rd("status_penjualan").ToString()
                        lbl_catatanPending.Text = "Catatan: " & rd("catatan").ToString()

                        lbl_atasNamaPending.Text = "Atas Nama: " & rd("atas_nama").ToString()
                        lbl_kontakPending.Text = "Kontak: " & rd("kontak_penerima").ToString()
                        lbl_statusKirimPending.Text = "Status Kirim: " & rd("status_pengiriman").ToString()
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
    Private Sub dgv_listPickupPacking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listPickupPacking.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idJualPending As String = dgv_listPickupPacking.Rows(e.RowIndex).Cells("colNoPenjualan").Value.ToString()

        TampilkanDetailPickupLunas(idJualPending)
    End Sub
End Class