Imports MySql.Data.MySqlClient

Public Class frm_DeliveryManage
    Private Sub btnPengembalian_Karyawan_Click(sender As Object, e As EventArgs) Handles btnPengembalian_Karyawan.Click
        mainForm_Employee.Show()
        Me.Close()
    End Sub

    Private Sub btnStok_Click(sender As Object, e As EventArgs) Handles btnStok.Click
        frm_StokBarang.Show()
        Me.Close()
    End Sub

    Private Sub btnPickup_Click(sender As Object, e As EventArgs) Handles btnPickup.Click
        frm_PickupManage.Show()
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

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Sub load_ListDeliveryLunasPacking()
        dgv_listDeliveryLunasPacking.Rows.Clear()

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String =
            "SELECT no_penjualan, jenis_penjualan, tanggal, total_penjualan, dana_diterima, kembalian, metode_pembayaran, catatan, atas_nama, kontak_penerima, alamat, status_pengiriman
             FROM tblpenjualan 
             WHERE status_penjualan = 'Lunas' AND jenis_penjualan = 'Delivery'
             ORDER BY tanggal DESC"

            Using cmd As New MySqlCommand(query, conn)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim tgl As Date = Date.Parse(dr("tanggal").ToString())

                        dgv_listDeliveryLunasPacking.Rows.Add(
                        dgv_listDeliveryLunasPacking.Rows.Count + 1,
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
    Private Sub frm_DeliveryManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_ListDeliveryLunasPacking()
        dgv_listDeliveryLunasPacking.RowTemplate.Height = 30
    End Sub

    Private Sub TampilkanDetailDeliveryLunas(noPenjualan As String)
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
                        lbl_noJualDeliveryLunas.Text = "No Penjualan: " & rd("no_penjualan").ToString()
                        lbl_tglJualDeliveryLunas.Text = "Tanggal: " & CDate(rd("tanggal")).ToString("dd MMM yyyy")
                        lbl_totalJualDeliveryLunas.Text = "Total: Rp. " & Format(CDec(rd("total_penjualan")), "N0")
                        lbl_metodeJualDeliveryLunas.Text = "Metode: " & rd("metode_pembayaran").ToString()
                        lbl_statusJualDeliveryLunas.Text = "Status: " & rd("status_penjualan").ToString()
                        lbl_catatanDeliveryLunas.Text = "Catatan: " & rd("catatan").ToString()

                        lbl_atasNamaDeliveryLunas.Text = "Atas Nama: " & rd("atas_nama").ToString()
                        lbl_kontakDeliveryLunas.Text = "Kontak: " & rd("kontak_penerima").ToString()
                        lbl_alamatJualDeliveryLunas.Text = "Alamat: " & rd("alamat").ToString()
                        lbl_statusKirimDeliveryLunas.Text = "Status Kirim: " & rd("status_pengiriman").ToString()
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

            rtb_detailPenjualanDeliveryLunas.Clear()

            Dim nomor As Integer = 1

            For Each row As DataRow In dt.Rows
                rtb_detailPenjualanDeliveryLunas.AppendText(
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

    Private Sub dgv_listDeliveryLunasPacking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listDeliveryLunasPacking.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idJualPending As String = dgv_listDeliveryLunasPacking.Rows(e.RowIndex).Cells("colNoPenjualan").Value.ToString()

        TampilkanDetailDeliveryLunas(idJualPending)
    End Sub

    Private Sub btn_updateLunasPenjualan_Click(sender As Object, e As EventArgs) Handles btn_updateLunasPenjualan.Click
        If dgv_listDeliveryLunasPacking.Rows.Count = 0 Then
            MsgBox("Tidak ada data penjualan!", vbExclamation)
            Exit Sub
        End If

        Dim baris As Integer = dgv_listDeliveryLunasPacking.CurrentRow.Index

        Dim formPopup As New frm_UpdateStatusPengiriman
        formPopup.AsalForm = "Delivery"
        formPopup.lbl_noPenjualanKirimLunas.Text = dgv_listDeliveryLunasPacking.Item("colNoPenjualan", baris).Value.ToString()
        formPopup.lbl_tanggalKirimLunas.Text = dgv_listDeliveryLunasPacking.Item("colTglPembelian", baris).Value.ToString()
        formPopup.lbl_atasNamaKirimLunas.Text = dgv_listDeliveryLunasPacking.Item("colAtasNama", baris).Value.ToString()
        formPopup.lbl_kontakKirimLunas.Text = dgv_listDeliveryLunasPacking.Item("colKontak", baris).Value.ToString()
        formPopup.lbl_alamatKirimLunas.Text = dgv_listDeliveryLunasPacking.Item("colAlamat", baris).Value.ToString()
        formPopup.ShowDialog()
    End Sub
End Class