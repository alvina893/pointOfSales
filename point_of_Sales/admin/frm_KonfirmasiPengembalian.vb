Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class frm_KonfirmasiPengembalian

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

    Private Sub frm_KonfirmasiPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub btn_konfirmPengembalian_Click(sender As Object, e As EventArgs) Handles btn_konfirmPengembalian.Click
        If cbo_metodeRetur.SelectedItem Is Nothing Then
            MsgBox("Pilih metode pengembalian!", vbExclamation)
            Exit Sub
        End If

        Dim metode As String = cbo_metodeRetur.SelectedItem.ToString()
        Dim totalDana As Decimal = CDec(lbl_totalDanaPengembalianAjukan.Text)
        Dim totalStok As Integer = CInt(lbl_totalStokPengembalianAjukan.Text)
        Dim noPengembalian As String = lbl_noPengembalianAjukan.Text
        Dim kodeBarang As String = lbl_noPengembalianAjukan.Text ' <-- ini harus ada label/variable kode barang

        ' Logika Metode
        If metode = "Refund (Dana)" Then
            totalStok = 0 ' Dana -> tidak menambah stok
        ElseIf metode = "Tukar Guling (Barang)" Then
            totalDana = 0 ' Barang -> tidak mengembalikan uang
        End If

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ' Update tabel pengembalian
            Dim sql As String =
            "UPDATE tblpengembalian
        SET metode_pengembalian=@metode, 
            total_returDana=@dana, 
            total_returStok=@stok,
            status_pengembalian='Konfirmasi'
        WHERE no_pengembalian=@no"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@metode", metode)
                cmd.Parameters.AddWithValue("@dana", totalDana)
                cmd.Parameters.AddWithValue("@stok", totalStok)
                cmd.Parameters.AddWithValue("@no", noPengembalian)
                cmd.ExecuteNonQuery()
            End Using

            ' Update stok hanya jika Tukar Guling
            If metode = "Tukar Guling (Barang)" Then
                Using updateCmd As New MySqlCommand("UPDATE tblbarang SET stok = stok + @qty WHERE kode_barang=@kode", conn)
                    updateCmd.Parameters.AddWithValue("@qty", totalStok)
                    updateCmd.Parameters.AddWithValue("@kode", kodeBarang)
                    updateCmd.ExecuteNonQuery()
                End Using
            End If

            MsgBox("Pengembalian berhasil dikonfirmasi!", vbInformation)
        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message, vbCritical)
        Finally
            conn.Close()
            Me.Close()
            mainForm_Employee.load_ListPengembalian()
            frm_ManagePengembalian.load_ListPengembalian()
        End Try
    End Sub
End Class