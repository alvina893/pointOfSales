<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PopUpPembelianBaru
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_tglBeli = New System.Windows.Forms.DateTimePicker()
        Me.txt_namaSupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_IDSupplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_kodeBeli = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_kodeBarang = New System.Windows.Forms.TextBox()
        Me.txt_satuan = New System.Windows.Forms.TextBox()
        Me.txt_namaBarang = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hargaBeli = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_tmbhDetBeli = New System.Windows.Forms.Button()
        Me.dgv_detailPembelian = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaBli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_btlBeli = New System.Windows.Forms.Button()
        Me.btn_simpanBeli = New System.Windows.Forms.Button()
        Me.txt_totalBeli = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detailPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtp_tglBeli)
        Me.GroupBox1.Controls.Add(Me.txt_namaSupplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_IDSupplier)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_kodeBeli)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 88)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rincian Pembelian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Tgl. Pembelian:"
        '
        'dtp_tglBeli
        '
        Me.dtp_tglBeli.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_tglBeli.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglBeli.Location = New System.Drawing.Point(19, 46)
        Me.dtp_tglBeli.Name = "dtp_tglBeli"
        Me.dtp_tglBeli.Size = New System.Drawing.Size(180, 25)
        Me.dtp_tglBeli.TabIndex = 40
        '
        'txt_namaSupplier
        '
        Me.txt_namaSupplier.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_namaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_namaSupplier.Enabled = False
        Me.txt_namaSupplier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaSupplier.Location = New System.Drawing.Point(427, 46)
        Me.txt_namaSupplier.Name = "txt_namaSupplier"
        Me.txt_namaSupplier.ReadOnly = True
        Me.txt_namaSupplier.Size = New System.Drawing.Size(180, 26)
        Me.txt_namaSupplier.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nama Supplier:"
        '
        'txt_IDSupplier
        '
        Me.txt_IDSupplier.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_IDSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_IDSupplier.Enabled = False
        Me.txt_IDSupplier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDSupplier.Location = New System.Drawing.Point(631, 46)
        Me.txt_IDSupplier.Name = "txt_IDSupplier"
        Me.txt_IDSupplier.ReadOnly = True
        Me.txt_IDSupplier.Size = New System.Drawing.Size(180, 26)
        Me.txt_IDSupplier.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(628, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ID Supplier:"
        '
        'txt_kodeBeli
        '
        Me.txt_kodeBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kodeBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kodeBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kodeBeli.Location = New System.Drawing.Point(223, 46)
        Me.txt_kodeBeli.Name = "txt_kodeBeli"
        Me.txt_kodeBeli.Size = New System.Drawing.Size(180, 26)
        Me.txt_kodeBeli.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(220, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 16)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Kode Pembelian:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(828, 2)
        Me.Label6.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 23)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Pembelian Baru"
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(806, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 65
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_kodeBarang)
        Me.GroupBox2.Controls.Add(Me.txt_satuan)
        Me.GroupBox2.Controls.Add(Me.txt_namaBarang)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_subTotal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_hargaBeli)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_qty)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_tmbhDetBeli)
        Me.GroupBox2.Controls.Add(Me.dgv_detailPembelian)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(827, 369)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Barang"
        '
        'txt_kodeBarang
        '
        Me.txt_kodeBarang.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kodeBarang.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kodeBarang.Location = New System.Drawing.Point(21, 51)
        Me.txt_kodeBarang.Name = "txt_kodeBarang"
        Me.txt_kodeBarang.Size = New System.Drawing.Size(229, 26)
        Me.txt_kodeBarang.TabIndex = 42
        '
        'txt_satuan
        '
        Me.txt_satuan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_satuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_satuan.Location = New System.Drawing.Point(140, 161)
        Me.txt_satuan.Name = "txt_satuan"
        Me.txt_satuan.Size = New System.Drawing.Size(110, 26)
        Me.txt_satuan.TabIndex = 96
        '
        'txt_namaBarang
        '
        Me.txt_namaBarang.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_namaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_namaBarang.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaBarang.Location = New System.Drawing.Point(21, 106)
        Me.txt_namaBarang.Name = "txt_namaBarang"
        Me.txt_namaBarang.ReadOnly = True
        Me.txt_namaBarang.Size = New System.Drawing.Size(229, 26)
        Me.txt_namaBarang.TabIndex = 95
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 16)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Nama Barang:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(138, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Satuan:"
        '
        'txt_subTotal
        '
        Me.txt_subTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_subTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subTotal.Location = New System.Drawing.Point(21, 271)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.ReadOnly = True
        Me.txt_subTotal.Size = New System.Drawing.Size(229, 26)
        Me.txt_subTotal.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Subtotal:"
        '
        'txt_hargaBeli
        '
        Me.txt_hargaBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hargaBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hargaBeli.Location = New System.Drawing.Point(21, 216)
        Me.txt_hargaBeli.Name = "txt_hargaBeli"
        Me.txt_hargaBeli.Size = New System.Drawing.Size(229, 26)
        Me.txt_hargaBeli.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 16)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Harga Beli per Satuan:"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(21, 161)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(110, 26)
        Me.txt_qty.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Kode Barang:"
        '
        'btn_tmbhDetBeli
        '
        Me.btn_tmbhDetBeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_tmbhDetBeli.FlatAppearance.BorderSize = 0
        Me.btn_tmbhDetBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tmbhDetBeli.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_tmbhDetBeli.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_tmbhDetBeli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetBeli.Location = New System.Drawing.Point(21, 319)
        Me.btn_tmbhDetBeli.Name = "btn_tmbhDetBeli"
        Me.btn_tmbhDetBeli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhDetBeli.Size = New System.Drawing.Size(229, 29)
        Me.btn_tmbhDetBeli.TabIndex = 85
        Me.btn_tmbhDetBeli.Text = "➕ Masukkan ke List"
        Me.btn_tmbhDetBeli.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetBeli.UseVisualStyleBackColor = False
        '
        'dgv_detailPembelian
        '
        Me.dgv_detailPembelian.AllowUserToAddRows = False
        Me.dgv_detailPembelian.AllowUserToDeleteRows = False
        Me.dgv_detailPembelian.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detailPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colKodeBrg, Me.colNmaBrg, Me.colQty, Me.colSatuan, Me.colHargaBli, Me.colSubtotal})
        Me.dgv_detailPembelian.Location = New System.Drawing.Point(267, 32)
        Me.dgv_detailPembelian.Name = "dgv_detailPembelian"
        Me.dgv_detailPembelian.ReadOnly = True
        Me.dgv_detailPembelian.RowHeadersVisible = False
        Me.dgv_detailPembelian.Size = New System.Drawing.Size(543, 316)
        Me.dgv_detailPembelian.TabIndex = 83
        '
        'colNo
        '
        Me.colNo.HeaderText = "#"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Width = 40
        '
        'colKodeBrg
        '
        Me.colKodeBrg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colKodeBrg.HeaderText = "Kode Barang"
        Me.colKodeBrg.Name = "colKodeBrg"
        Me.colKodeBrg.ReadOnly = True
        Me.colKodeBrg.Width = 117
        '
        'colNmaBrg
        '
        Me.colNmaBrg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNmaBrg.HeaderText = "Nama Barang"
        Me.colNmaBrg.MinimumWidth = 157
        Me.colNmaBrg.Name = "colNmaBrg"
        Me.colNmaBrg.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colQty.HeaderText = "Qty"
        Me.colQty.MinimumWidth = 40
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 57
        '
        'colSatuan
        '
        Me.colSatuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSatuan.HeaderText = "Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.ReadOnly = True
        Me.colSatuan.Width = 78
        '
        'colHargaBli
        '
        Me.colHargaBli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaBli.HeaderText = "Harga Beli"
        Me.colHargaBli.Name = "colHargaBli"
        Me.colHargaBli.ReadOnly = True
        Me.colHargaBli.Width = 98
        '
        'colSubtotal
        '
        Me.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.ReadOnly = True
        Me.colSubtotal.Width = 85
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_btlBeli)
        Me.GroupBox3.Controls.Add(Me.btn_simpanBeli)
        Me.GroupBox3.Controls.Add(Me.txt_totalBeli)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 557)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(827, 72)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'btn_btlBeli
        '
        Me.btn_btlBeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_btlBeli.FlatAppearance.BorderSize = 0
        Me.btn_btlBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_btlBeli.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_btlBeli.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_btlBeli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_btlBeli.Location = New System.Drawing.Point(472, 26)
        Me.btn_btlBeli.Name = "btn_btlBeli"
        Me.btn_btlBeli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_btlBeli.Size = New System.Drawing.Size(93, 26)
        Me.btn_btlBeli.TabIndex = 61
        Me.btn_btlBeli.Text = "🗑️ Batal"
        Me.btn_btlBeli.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_btlBeli.UseVisualStyleBackColor = False
        '
        'btn_simpanBeli
        '
        Me.btn_simpanBeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_simpanBeli.FlatAppearance.BorderSize = 0
        Me.btn_simpanBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanBeli.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_simpanBeli.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanBeli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanBeli.Location = New System.Drawing.Point(373, 26)
        Me.btn_simpanBeli.Name = "btn_simpanBeli"
        Me.btn_simpanBeli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanBeli.Size = New System.Drawing.Size(93, 26)
        Me.btn_simpanBeli.TabIndex = 60
        Me.btn_simpanBeli.Text = "💾 Simpan"
        Me.btn_simpanBeli.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanBeli.UseVisualStyleBackColor = False
        '
        'txt_totalBeli
        '
        Me.txt_totalBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_totalBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_totalBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalBeli.Location = New System.Drawing.Point(134, 26)
        Me.txt_totalBeli.Name = "txt_totalBeli"
        Me.txt_totalBeli.ReadOnly = True
        Me.txt_totalBeli.Size = New System.Drawing.Size(229, 26)
        Me.txt_totalBeli.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Total Pembelian:"
        '
        'frm_PopUpPembelianBaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 653)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_PopUpPembelianBaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_PopUpPembelianBaru"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detailPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_IDSupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_kodeBeli As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_satuan As TextBox
    Friend WithEvents txt_namaBarang As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hargaBeli As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_detailPembelian As DataGridView
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrg As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrg As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As DataGridViewTextBoxColumn
    Friend WithEvents colHargaBli As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_btlBeli As Button
    Friend WithEvents btn_simpanBeli As Button
    Friend WithEvents txt_totalBeli As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_tmbhDetBeli As Button
    Friend WithEvents txt_namaSupplier As TextBox
    Friend WithEvents dtp_tglBeli As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_kodeBarang As TextBox
End Class
