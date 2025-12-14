<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_KonfirmasiPengembalian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_noPengembalianAjukan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_totalDanaPengembalianAjukan = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_totalStokPengembalianAjukan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtb_rincianPengembalian = New System.Windows.Forms.RichTextBox()
        Me.cbo_metodeRetur = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_konfirmPengembalian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "No. Pengembalian:"
        '
        'lbl_noPengembalianAjukan
        '
        Me.lbl_noPengembalianAjukan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_noPengembalianAjukan.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_noPengembalianAjukan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_noPengembalianAjukan.Location = New System.Drawing.Point(30, 90)
        Me.lbl_noPengembalianAjukan.Name = "lbl_noPengembalianAjukan"
        Me.lbl_noPengembalianAjukan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_noPengembalianAjukan.Size = New System.Drawing.Size(320, 27)
        Me.lbl_noPengembalianAjukan.TabIndex = 69
        Me.lbl_noPengembalianAjukan.Text = "0000"
        Me.lbl_noPengembalianAjukan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Total Dana Pengembalian:"
        '
        'lbl_totalDanaPengembalianAjukan
        '
        Me.lbl_totalDanaPengembalianAjukan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_totalDanaPengembalianAjukan.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_totalDanaPengembalianAjukan.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_totalDanaPengembalianAjukan.Location = New System.Drawing.Point(30, 157)
        Me.lbl_totalDanaPengembalianAjukan.Name = "lbl_totalDanaPengembalianAjukan"
        Me.lbl_totalDanaPengembalianAjukan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_totalDanaPengembalianAjukan.Size = New System.Drawing.Size(320, 27)
        Me.lbl_totalDanaPengembalianAjukan.TabIndex = 67
        Me.lbl_totalDanaPengembalianAjukan.Text = "00.00"
        Me.lbl_totalDanaPengembalianAjukan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(742, 2)
        Me.Label6.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 23)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Konfirmasi Pengembalian"
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(723, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 64
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Total Stok Pengembalian:"
        '
        'lbl_totalStokPengembalianAjukan
        '
        Me.lbl_totalStokPengembalianAjukan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_totalStokPengembalianAjukan.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_totalStokPengembalianAjukan.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_totalStokPengembalianAjukan.Location = New System.Drawing.Point(443, 157)
        Me.lbl_totalStokPengembalianAjukan.Name = "lbl_totalStokPengembalianAjukan"
        Me.lbl_totalStokPengembalianAjukan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_totalStokPengembalianAjukan.Size = New System.Drawing.Size(320, 27)
        Me.lbl_totalStokPengembalianAjukan.TabIndex = 71
        Me.lbl_totalStokPengembalianAjukan.Text = "00.00"
        Me.lbl_totalStokPengembalianAjukan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Rincian Pengembalian:"
        '
        'rtb_rincianPengembalian
        '
        Me.rtb_rincianPengembalian.BackColor = System.Drawing.SystemColors.Control
        Me.rtb_rincianPengembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_rincianPengembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_rincianPengembalian.Location = New System.Drawing.Point(35, 225)
        Me.rtb_rincianPengembalian.Name = "rtb_rincianPengembalian"
        Me.rtb_rincianPengembalian.Size = New System.Drawing.Size(363, 355)
        Me.rtb_rincianPengembalian.TabIndex = 76
        Me.rtb_rincianPengembalian.Text = ""
        '
        'cbo_metodeRetur
        '
        Me.cbo_metodeRetur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_metodeRetur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_metodeRetur.FormattingEnabled = True
        Me.cbo_metodeRetur.Items.AddRange(New Object() {"Tukar Guling (Barang)", "Refund (Dana)"})
        Me.cbo_metodeRetur.Location = New System.Drawing.Point(448, 225)
        Me.cbo_metodeRetur.Name = "cbo_metodeRetur"
        Me.cbo_metodeRetur.Size = New System.Drawing.Size(246, 26)
        Me.cbo_metodeRetur.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(445, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Metode Pengembalian:"
        '
        'btn_konfirmPengembalian
        '
        Me.btn_konfirmPengembalian.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_konfirmPengembalian.FlatAppearance.BorderSize = 0
        Me.btn_konfirmPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_konfirmPengembalian.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_konfirmPengembalian.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_konfirmPengembalian.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_konfirmPengembalian.Location = New System.Drawing.Point(448, 269)
        Me.btn_konfirmPengembalian.Name = "btn_konfirmPengembalian"
        Me.btn_konfirmPengembalian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_konfirmPengembalian.Size = New System.Drawing.Size(246, 29)
        Me.btn_konfirmPengembalian.TabIndex = 79
        Me.btn_konfirmPengembalian.Text = "Konfirmasi 💾"
        Me.btn_konfirmPengembalian.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_konfirmPengembalian.UseVisualStyleBackColor = False
        '
        'frm_KonfirmasiPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 600)
        Me.Controls.Add(Me.btn_konfirmPengembalian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbo_metodeRetur)
        Me.Controls.Add(Me.rtb_rincianPengembalian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_totalStokPengembalianAjukan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_noPengembalianAjukan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_totalDanaPengembalianAjukan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_KonfirmasiPengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_konfirmasiPengembalian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_noPengembalianAjukan As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_totalDanaPengembalianAjukan As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_totalStokPengembalianAjukan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rtb_rincianPengembalian As RichTextBox
    Friend WithEvents cbo_metodeRetur As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_konfirmPengembalian As Button
End Class
