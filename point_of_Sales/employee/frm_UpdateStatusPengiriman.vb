Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices

Public Class frm_UpdateStatusPengiriman

    Public Property AsalForm As String = ""


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

    Private Sub frm_UpdateStatusPengiriman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()

        cbo_statuskirimPop.Items.Clear()

        If AsalForm = "Pickup" Then
            ' Jika popup dibuka dari PICKUP
            cbo_statuskirimPop.Items.Add("Siap Dipickup")
            cbo_statuskirimPop.Items.Add("Selesai")

        ElseIf AsalForm = "Delivery" Then
            ' Jika popup dibuka dari DELIVERY
            cbo_statuskirimPop.Items.Add("Siap Diantar")
            cbo_statuskirimPop.Items.Add("Selesai")
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub btn_updateStatusPengirimanPop_Click(sender As Object, e As EventArgs) Handles btn_updateStatusPengirimanPop.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "
                UPDATE tblpenjualan
                SET status_pengiriman = @status_pengiriman
                WHERE no_penjualan = @no_penjualan"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@status_pengiriman", cbo_statuskirimPop.Text)
                cmd.Parameters.AddWithValue("@no_penjualan", lbl_noPenjualanKirimLunas.Text)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Penjualan: " & lbl_noPenjualanKirimLunas.Text & "sudah " & cbo_statuskirimPop.Text, vbInformation)

            frm_DeliveryManage.load_ListDeliveryLunasPacking()
            frm_PickupManage.load_ListPickupLunasPacking()

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
End Class