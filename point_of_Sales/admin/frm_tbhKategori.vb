Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frm_tbhKategori
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

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

    Private Sub frm_tbhKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        EnableShadow()
    End Sub

    Private Sub btn_simpanKategori_Click(sender As Object, e As EventArgs) Handles btn_simpanKategori.Click
        If String.IsNullOrWhiteSpace(txt_kategoriBaru.Text) Then
            MsgBox("Nama kategori baru tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tblkategori`(`nma_kategori`) VALUES (@nma_kategori)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nma_kategori", txt_kategoriBaru.Text)
            i = cmd.ExecuteNonQuery
            If 1 > 0 Then
                MsgBox("Kategori barang baru berhasil disimpan!", vbInformation)
            Else
                MsgBox("Kategori barang gagal disimpan!", vbExclamation)
            End If
            txt_kategoriBaru.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Me.Close()
        frm_ManageBarang.load_kategoriBarang()
        frm_PopUpBarangBaru.load_kategoriBarang()
    End Sub
End Class