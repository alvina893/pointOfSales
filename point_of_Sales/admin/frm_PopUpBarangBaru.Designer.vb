<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PopUpBarangBaru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_IDSup = New System.Windows.Forms.TextBox()
        Me.cbo_nmaSup = New System.Windows.Forms.ComboBox()
        Me.txt_hrgaBeli = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_minStok = New System.Windows.Forms.TextBox()
        Me.txt_stok = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_tmbhSatuan = New System.Windows.Forms.Button()
        Me.btn_tmbhKategori = New System.Windows.Forms.Button()
        Me.pic_barcodeBrg = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_satuanBrg = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_kategoriBrg = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_hrgaBrg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nmaBrg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_kodeBrg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_delBrg = New System.Windows.Forms.Button()
        Me.btn_simpanBrg = New System.Windows.Forms.Button()
        CType(Me.pic_barcodeBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(495, 2)
        Me.Label6.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Tambah Barang BARU"
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(475, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 58
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(282, 445)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "ID Supplier:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(26, 445)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Nama Supplier:"
        '
        'txt_IDSup
        '
        Me.txt_IDSup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_IDSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_IDSup.Enabled = False
        Me.txt_IDSup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDSup.Location = New System.Drawing.Point(285, 464)
        Me.txt_IDSup.Name = "txt_IDSup"
        Me.txt_IDSup.ReadOnly = True
        Me.txt_IDSup.Size = New System.Drawing.Size(239, 26)
        Me.txt_IDSup.TabIndex = 84
        '
        'cbo_nmaSup
        '
        Me.cbo_nmaSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nmaSup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nmaSup.FormattingEnabled = True
        Me.cbo_nmaSup.Location = New System.Drawing.Point(30, 463)
        Me.cbo_nmaSup.Name = "cbo_nmaSup"
        Me.cbo_nmaSup.Size = New System.Drawing.Size(238, 26)
        Me.cbo_nmaSup.TabIndex = 83
        '
        'txt_hrgaBeli
        '
        Me.txt_hrgaBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaBeli.Location = New System.Drawing.Point(29, 266)
        Me.txt_hrgaBeli.Name = "txt_hrgaBeli"
        Me.txt_hrgaBeli.Size = New System.Drawing.Size(239, 26)
        Me.txt_hrgaBeli.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Harga Beli:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(282, 305)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 16)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Min Stok:"
        '
        'txt_minStok
        '
        Me.txt_minStok.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_minStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_minStok.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_minStok.Location = New System.Drawing.Point(285, 324)
        Me.txt_minStok.Name = "txt_minStok"
        Me.txt_minStok.Size = New System.Drawing.Size(239, 26)
        Me.txt_minStok.TabIndex = 79
        '
        'txt_stok
        '
        Me.txt_stok.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stok.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stok.Location = New System.Drawing.Point(29, 324)
        Me.txt_stok.Name = "txt_stok"
        Me.txt_stok.Size = New System.Drawing.Size(239, 26)
        Me.txt_stok.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Stok:"
        '
        'btn_tmbhSatuan
        '
        Me.btn_tmbhSatuan.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_tmbhSatuan.FlatAppearance.BorderSize = 0
        Me.btn_tmbhSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tmbhSatuan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tmbhSatuan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_tmbhSatuan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhSatuan.Location = New System.Drawing.Point(476, 208)
        Me.btn_tmbhSatuan.Name = "btn_tmbhSatuan"
        Me.btn_tmbhSatuan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhSatuan.Size = New System.Drawing.Size(48, 26)
        Me.btn_tmbhSatuan.TabIndex = 76
        Me.btn_tmbhSatuan.Text = "➕"
        Me.btn_tmbhSatuan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhSatuan.UseVisualStyleBackColor = False
        '
        'btn_tmbhKategori
        '
        Me.btn_tmbhKategori.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_tmbhKategori.FlatAppearance.BorderSize = 0
        Me.btn_tmbhKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tmbhKategori.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tmbhKategori.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_tmbhKategori.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhKategori.Location = New System.Drawing.Point(220, 208)
        Me.btn_tmbhKategori.Name = "btn_tmbhKategori"
        Me.btn_tmbhKategori.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhKategori.Size = New System.Drawing.Size(48, 26)
        Me.btn_tmbhKategori.TabIndex = 75
        Me.btn_tmbhKategori.Text = "➕"
        Me.btn_tmbhKategori.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhKategori.UseVisualStyleBackColor = False
        '
        'pic_barcodeBrg
        '
        Me.pic_barcodeBrg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_barcodeBrg.BackColor = System.Drawing.SystemColors.Window
        Me.pic_barcodeBrg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_barcodeBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_barcodeBrg.Location = New System.Drawing.Point(28, 382)
        Me.pic_barcodeBrg.Name = "pic_barcodeBrg"
        Me.pic_barcodeBrg.Size = New System.Drawing.Size(495, 50)
        Me.pic_barcodeBrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barcodeBrg.TabIndex = 74
        Me.pic_barcodeBrg.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Barcode:"
        '
        'cbo_satuanBrg
        '
        Me.cbo_satuanBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_satuanBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_satuanBrg.FormattingEnabled = True
        Me.cbo_satuanBrg.Location = New System.Drawing.Point(285, 208)
        Me.cbo_satuanBrg.Name = "cbo_satuanBrg"
        Me.cbo_satuanBrg.Size = New System.Drawing.Size(185, 26)
        Me.cbo_satuanBrg.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(282, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Satuan:"
        '
        'cbo_kategoriBrg
        '
        Me.cbo_kategoriBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kategoriBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_kategoriBrg.FormattingEnabled = True
        Me.cbo_kategoriBrg.Location = New System.Drawing.Point(29, 208)
        Me.cbo_kategoriBrg.Name = "cbo_kategoriBrg"
        Me.cbo_kategoriBrg.Size = New System.Drawing.Size(185, 26)
        Me.cbo_kategoriBrg.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Kategori:"
        '
        'txt_hrgaBrg
        '
        Me.txt_hrgaBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaBrg.Location = New System.Drawing.Point(285, 266)
        Me.txt_hrgaBrg.Name = "txt_hrgaBrg"
        Me.txt_hrgaBrg.Size = New System.Drawing.Size(239, 26)
        Me.txt_hrgaBrg.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(282, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Harga Jual:"
        '
        'txt_nmaBrg
        '
        Me.txt_nmaBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_nmaBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nmaBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nmaBrg.Location = New System.Drawing.Point(29, 152)
        Me.txt_nmaBrg.Name = "txt_nmaBrg"
        Me.txt_nmaBrg.Size = New System.Drawing.Size(495, 26)
        Me.txt_nmaBrg.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nama Barang:"
        '
        'txt_kodeBrg
        '
        Me.txt_kodeBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kodeBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kodeBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kodeBrg.Location = New System.Drawing.Point(29, 94)
        Me.txt_kodeBrg.Name = "txt_kodeBrg"
        Me.txt_kodeBrg.Size = New System.Drawing.Size(495, 26)
        Me.txt_kodeBrg.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Kode Barang:"
        '
        'btn_delBrg
        '
        Me.btn_delBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_delBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delBrg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delBrg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delBrg.Location = New System.Drawing.Point(285, 513)
        Me.btn_delBrg.Name = "btn_delBrg"
        Me.btn_delBrg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_delBrg.Size = New System.Drawing.Size(239, 29)
        Me.btn_delBrg.TabIndex = 88
        Me.btn_delBrg.Text = "Batal 🗑️"
        Me.btn_delBrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delBrg.UseVisualStyleBackColor = False
        '
        'btn_simpanBrg
        '
        Me.btn_simpanBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_simpanBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpanBrg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanBrg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanBrg.Location = New System.Drawing.Point(30, 513)
        Me.btn_simpanBrg.Name = "btn_simpanBrg"
        Me.btn_simpanBrg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanBrg.Size = New System.Drawing.Size(238, 29)
        Me.btn_simpanBrg.TabIndex = 87
        Me.btn_simpanBrg.Text = "Simpan 💾"
        Me.btn_simpanBrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanBrg.UseVisualStyleBackColor = False
        '
        'frm_PopUpBarangBaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 570)
        Me.Controls.Add(Me.btn_delBrg)
        Me.Controls.Add(Me.btn_simpanBrg)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_IDSup)
        Me.Controls.Add(Me.cbo_nmaSup)
        Me.Controls.Add(Me.txt_hrgaBeli)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_minStok)
        Me.Controls.Add(Me.txt_stok)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_tmbhSatuan)
        Me.Controls.Add(Me.btn_tmbhKategori)
        Me.Controls.Add(Me.pic_barcodeBrg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbo_satuanBrg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbo_kategoriBrg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_hrgaBrg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_nmaBrg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_kodeBrg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_PopUpBarangBaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_PopUpBarangBaru"
        CType(Me.pic_barcodeBrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_IDSup As TextBox
    Friend WithEvents cbo_nmaSup As ComboBox
    Friend WithEvents txt_hrgaBeli As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_minStok As TextBox
    Friend WithEvents txt_stok As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_tmbhSatuan As Button
    Friend WithEvents btn_tmbhKategori As Button
    Friend WithEvents pic_barcodeBrg As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_satuanBrg As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_kategoriBrg As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_hrgaBrg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nmaBrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_kodeBrg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_delBrg As Button
    Friend WithEvents btn_simpanBrg As Button
End Class
