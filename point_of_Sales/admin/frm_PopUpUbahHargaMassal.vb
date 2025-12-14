Imports System.Runtime.InteropServices
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MessagingToolkit.Barcode.Common
Imports MessagingToolkit.Barcode.QRCode.Decoder
Imports MySql.Data.MySqlClient

Public Class frm_PopUpUbahHargaMassal

    Private modeUbah As String = ""
    Private tertentuMassal As Decimal = 0
    Private marginMassal As Decimal = 0
    Private markupMassal As Decimal = 0

    Private sourceGrid As DataGridView

    Public Sub New(grid As DataGridView)
        InitializeComponent()
        sourceGrid = grid
    End Sub

    Private Sub LoadDataFromMain()
        dgv_barangUbahMassal.Rows.Clear()

        For Each r As DataGridViewRow In sourceGrid.Rows
            Dim idx = dgv_barangUbahMassal.Rows.Add()
            With dgv_barangUbahMassal.Rows(idx)
                .Cells("colNo").Value = r.Cells("colNo").Value
                .Cells("colPilih").Value = False
                .Cells("colKodeBarang").Value = r.Cells("colKodeBarangLowStok").Value
                .Cells("colNamaBarang").Value = r.Cells("colNamaBarangLowStok").Value
                .Cells("colSatuanBarang").Value = r.Cells("colSatuanBarangLowStok").Value
                .Cells("colHargaBeli").Value = r.Cells("colHargaBeli").Value
                .Cells("colHargaBarang").Value = r.Cells("colHargaBarangLowStok").Value
                .Cells("colHargaJualBaru").Value = 0
                .Cells("colStokBarang").Value = r.Cells("colStokBarangLowStok").Value
                .Cells("colMinStokBarang").Value = r.Cells("colMinStokBarangLowStok").Value
                .Cells("colSupplierID").Value = r.Cells("colSupplierIDLowStock").Value
                .Cells("colSupplierNama").Value = r.Cells("colSupplierNamaLowStock").Value
            End With
        Next
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
    Private Sub frm_PopUpUbahHargaMassal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableShadow()
        dbconn()
        LoadDataFromMain()
    End Sub

    Private Sub rb_tertentuMassal_MouseHover(sender As Object, e As EventArgs) Handles rb_tertentuMassal.MouseHover
        ToolTipMassal.SetToolTip(rb_tertentuMassal,
                                 "Contoh tetapkan harga tertentu:

    harga awal: 10.000

    harga yang ditetapkan: 15.000
    → harga baru: 15.000")
    End Sub

    Private Sub rb_marginMassal_MouseHover(sender As Object, e As EventArgs) Handles rb_marginMassal.MouseHover
        ToolTipMassal.SetToolTip(rb_marginMassal,
                                 "Contoh berdasarkan margin:

    harga_beli = 8.000

    margin = 25%
    → harga_jual = 10.000")
    End Sub

    Private Sub rb_markupMassal_MouseHover(sender As Object, e As EventArgs) Handles rb_markupMassal.MouseHover
        ToolTipMassal.SetToolTip(rb_markupMassal,
                                 "Contoh markup nominal:

    harga_beli = 7.000

    markup = 2.000
    → harga_jual = 9.000")
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub btn_tetapkanMassal_Click(sender As Object, e As EventArgs) Handles btn_tetapkanMassal.Click

        Dim hargaJualTetap As Decimal = 0
        Decimal.TryParse(txt_massalTertentu.Text, hargaJualTetap)

        For Each row As DataGridViewRow In dgv_barangUbahMassal.Rows

            Dim hargaBeli As Decimal = CDec(row.Cells("colHargaBeli").Value)
            Dim hargaJual As Decimal = CDec(row.Cells("colHargaBarang").Value)

            Select Case modeUbah
                Case "margin"
                    row.Cells("colHargaJualBaru").Value = hargaBeli * (1 + marginMassal / 100)

                Case "markup"
                    row.Cells("colHargaJualBaru").Value = hargaBeli + markupMassal

                Case "tertentu"
                    row.Cells("colHargaJualBaru").Value = hargaJualTetap
            End Select
        Next

    End Sub

    Private Sub ResetMode()

        For Each row As DataGridViewRow In dgv_barangUbahMassal.Rows
            If Not row.IsNewRow Then
                row.Cells("colHargaJualBaru").Value = Nothing   ' or ""
            End If
        Next

        If rb_markupMassal.Checked = True Then
            rb_marginMassal.Checked = False
            txt_massalMargin.Clear()

            rb_tertentuMassal.Checked = False
            txt_massalTertentu.Clear()
        End If

        If rb_marginMassal.Checked = True Then
            rb_markupMassal.Checked = False
            txt_massalMarkup.Clear()

            rb_tertentuMassal.Checked = False
            txt_massalTertentu.Clear()
        End If

        If rb_tertentuMassal.Checked = True Then
            rb_markupMassal.Checked = False
            txt_massalMarkup.Clear()

            rb_marginMassal.Checked = False
            txt_massalMargin.Clear()
        End If
    End Sub


    Private Sub rb_tertentuMassal_CheckedChanged(sender As Object, e As EventArgs) Handles rb_tertentuMassal.CheckedChanged
        If rb_tertentuMassal.Checked Then
            ResetMode()
            rb_tertentuMassal.Checked = True
            modeUbah = "tertentu"
        End If
    End Sub

    Private Sub rb_marginMassal_CheckedChanged(sender As Object, e As EventArgs) Handles rb_marginMassal.CheckedChanged
        If rb_marginMassal.Checked Then
            ResetMode()
            rb_marginMassal.Checked = True
            modeUbah = "margin"
        End If
    End Sub

    Private Sub rb_markupMassal_CheckedChanged(sender As Object, e As EventArgs) Handles rb_markupMassal.CheckedChanged
        If rb_markupMassal.Checked Then
            ResetMode()
            rb_markupMassal.Checked = True
            modeUbah = "markup"
        End If
    End Sub

    Private Sub txt_massalTertentu_TextChanged(sender As Object, e As EventArgs) Handles txt_massalTertentu.TextChanged
        Decimal.TryParse(txt_massalTertentu.Text, tertentuMassal)
    End Sub

    Private Sub txt_massalMargin_TextChanged(sender As Object, e As EventArgs) Handles txt_massalMargin.TextChanged
        Decimal.TryParse(txt_massalMargin.Text, marginMassal)
    End Sub

    Private Sub txt_massalMarkup_TextChanged(sender As Object, e As EventArgs) Handles txt_massalMarkup.TextChanged
        Decimal.TryParse(txt_massalMarkup.Text, markupMassal)
    End Sub

    Private Sub btnSimpanUbahMassal_Click(sender As Object, e As EventArgs) Handles btnSimpanUbahMassal.Click
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim queryUpdate As String =
            "UPDATE tblbarang 
         SET harga_barang = @hargaBaru
         WHERE kode_barang = @kode"

            Dim queryHistory As String =
            "INSERT INTO tblhargajualhistory
         (kode_barang, harga_lama, harga_baru, mode_perubahan, nilai_perubahan)
         VALUES (@kode, @hargaLama, @hargaBaru, @mode, @nilai)"

            For Each row As DataGridViewRow In dgv_barangUbahMassal.Rows

                If row.IsNewRow Then Continue For
                If row.Cells("colHargaJualBaru").Value Is Nothing OrElse
                   row.Cells("colHargaJualBaru").Value.ToString() = "" Then Continue For

                ' --- Nilai-nilai yang dibutuhkan ---
                Dim kodeBarang As String = row.Cells("colKodeBarang").Value.ToString()
                Dim hargaLama As Decimal = CDec(row.Cells("colHargaBarang").Value)
                Dim hargaBaru As Decimal = CDec(row.Cells("colHargaJualBaru").Value)

                ' -------------------------------------------
                ' 1) UPDATE harga barang
                ' -------------------------------------------
                Dim cmdUpdate As New MySqlCommand(queryUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@hargaBaru", hargaBaru)
                cmdUpdate.Parameters.AddWithValue("@kode", kodeBarang)
                cmdUpdate.ExecuteNonQuery()

                ' -------------------------------------------
                ' 2) INSERT ke tabel history harga
                ' -------------------------------------------
                Dim selisih As Decimal = hargaBaru - hargaLama

                Dim cmdHist As New MySqlCommand(queryHistory, conn)
                cmdHist.Parameters.AddWithValue("@kode", kodeBarang)
                cmdHist.Parameters.AddWithValue("@hargaLama", hargaLama)
                cmdHist.Parameters.AddWithValue("@hargaBaru", hargaBaru)
                cmdHist.Parameters.AddWithValue("@mode", modeUbah)
                cmdHist.Parameters.AddWithValue("@nilai", selisih)

                cmdHist.ExecuteNonQuery()

            Next

            MsgBox("Harga barang berhasil diperbarui & history tersimpan!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Gagal menyimpan: " & ex.Message)
        Finally
            conn.Close()
            frm_ManageBarang.load_Barang()
            frm_ManageBarang.load_barangMassal()
            Me.Close()
            LoadDataFromMain()
        End Try
    End Sub
End Class