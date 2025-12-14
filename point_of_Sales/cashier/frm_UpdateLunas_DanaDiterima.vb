Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frm_UpdateLunas_DanaDiterima

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

    Private Sub frm_UpdateLunas_DanaDiterima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub btn_updateJualPending_Click(sender As Object, e As EventArgs) Handles btn_updateJualPending.Click
        If txt_danaPENDING.Text.Trim() = "" Then
            MsgBox("Masukkan dana yang diterima!", vbExclamation)
            Exit Sub
        End If

        Dim cleanedTotal As String = lbl_totalPENDING.Text _
        .Replace("Rp", "") _
        .Replace(".", "") _
        .Replace(",", "") _
        .Replace(" ", "")

        Dim total As Decimal
        If Not Decimal.TryParse(cleanedTotal, total) Then
            MsgBox("Format total tidak valid!", vbCritical)
            Exit Sub
        End If

        Dim cleanedDana As String = txt_danaPENDING.Text _
        .Replace(".", "") _
        .Replace(",", "") _
        .Replace(" ", "")

        Dim danaDiterima As Decimal
        If Not Decimal.TryParse(cleanedDana, danaDiterima) Then
            MsgBox("Format input dana tidak valid!", vbCritical)
            Exit Sub
        End If

        Dim kembalian As Decimal = danaDiterima - total

        If kembalian < 0 Then
            MsgBox("Dana tidak cukup!", vbCritical)
            Exit Sub
        End If

        lbl_kembalianPENDING.Text = Format(kembalian, "N0")

        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "
                UPDATE tblpenjualan
                SET 
                    dana_diterima = @dana_diterima,
                    kembalian = @kembalian,
                    metode_pembayaran = @metode_pembayaran,
                    status_penjualan = 'Lunas',
                    status_pengiriman = CASE 
                        WHEN jenis_penjualan IN ('Delivery', 'Pickup') THEN 'Packing'
                        ELSE status_pengiriman
                    END
                WHERE no_penjualan = @no_penjualan"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@dana_diterima", danaDiterima)
                cmd.Parameters.AddWithValue("@kembalian", kembalian)
                cmd.Parameters.AddWithValue("@metode_pembayaran", cbo_metodePembayaran.Text)
                cmd.Parameters.AddWithValue("@no_penjualan", lbl_noPenjualanPENDING.Text)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Penjualan berhasil diperbarui menjadi LUNAS!", vbInformation)

            mainForm_Cashier.load_ListPenjualanPending()
            frm_ManagePenjualanDelivery.load_ListPenjualanPending()
            frm_ManagePenjualanPickup.load_ListPenjualanPending()

            frm_ManagePenjualanPickup.load_ListPenjualanPickupPacking()
            frm_ManagePenjualanDelivery.load_ListPenjualanDeliveryPacking()
            Me.Close()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            mainForm_Cashier.clear()
            Me.Close()
        End Try
    End Sub

    Private Sub txt_danaPENDING_TextChanged(sender As Object, e As EventArgs) Handles txt_danaPENDING.TextChanged
        If lbl_totalPENDING.Text = "" Then Exit Sub

        Dim cleanedTotal As String = lbl_totalPENDING.Text _
        .Replace("Rp", "") _
        .Replace(".", "") _
        .Replace(",", "") _
        .Replace(" ", "")

        Dim total As Decimal

        If Decimal.TryParse(cleanedTotal, total) Then

            Dim danaDiterima As Decimal = 0

            If Decimal.TryParse(txt_danaPENDING.Text.Replace(".", "").Replace(",", ""), danaDiterima) Then
                lbl_kembalianPENDING.Text = Format((danaDiterima - total), "N0")
            Else
                lbl_kembalianPENDING.Text = "0"
            End If

        End If
    End Sub
End Class