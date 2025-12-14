Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frm_tbhSatuan

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

    Private Sub frm_tbhSatuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()
    End Sub
    Private Sub btn_simpanSatuan_Click(sender As Object, e As EventArgs) Handles btn_simpanSatuan.Click

        If String.IsNullOrWhiteSpace(txt_satuanBaru.Text) Then
            MsgBox("Nama satuan baru tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO tblsatuan(nma_satuan) VALUES (@nma_satuan)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nma_satuan", txt_satuanBaru.Text.Trim())

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Satuan baru berhasil disimpan!", vbInformation)
            Else
                MsgBox("Satuan gagal disimpan!", vbExclamation)
            End If

            txt_satuanBaru.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        Me.Close()
        frm_ManageBarang.load_satuanBarang()
        frm_PopUpBarangBaru.load_satuanBarang()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class