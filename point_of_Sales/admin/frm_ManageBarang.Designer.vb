<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManageBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManageBarang))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPenjualan = New System.Windows.Forms.Button()
        Me.btnPembelian = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnStokBarang = New System.Windows.Forms.Button()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.btnPengembalian = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKembali = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_Barang = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHrgaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cariBrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_barangUbahMassal = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colKodeBarangLowStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNamaBarangLowStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuanBarangLowStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaBarangLowStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStokBarangLowStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMinStokBarangLowStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierIDLowStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierNamaLowStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headerSelectAll = New System.Windows.Forms.Panel()
        Me.btnRestockSemua = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_ResetFilter = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbo_filterbySupplier = New System.Windows.Forms.ComboBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_barcodeValue = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_namaSup = New System.Windows.Forms.TextBox()
        Me.cbo_IDSup = New System.Windows.Forms.ComboBox()
        Me.cbo_tipeBarcode = New System.Windows.Forms.ComboBox()
        Me.txt_hrgaBeli = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_printBarcodeBarang = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_minStok = New System.Windows.Forms.TextBox()
        Me.txt_stok = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_tmbhSatuan = New System.Windows.Forms.Button()
        Me.btn_tmbhKategori = New System.Windows.Forms.Button()
        Me.btn_delBrg = New System.Windows.Forms.Button()
        Me.btn_clearBrg = New System.Windows.Forms.Button()
        Me.btn_updateBrg = New System.Windows.Forms.Button()
        Me.btn_simpanBrg = New System.Windows.Forms.Button()
        Me.pic_barcodeBrng = New System.Windows.Forms.PictureBox()
        Me.lblbarcode = New System.Windows.Forms.Label()
        Me.cbo_satuanBrg = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_kategoriBrg = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_hrgaBrg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nmaBrg = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_kodeBrg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_barangUbahMassal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerSelectAll.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pic_barcodeBrng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(148, 749)
        Me.Panel2.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel6.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(148, 749)
        Me.Panel6.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(146, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(2, 768)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = resources.GetString("Label14.Text")
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(13, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Inventory System"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnLogout, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 693)
        Me.TableLayoutPanel2.MinimumSize = New System.Drawing.Size(142, 73)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(142, 73)
        Me.TableLayoutPanel2.TabIndex = 22
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(3, 3)
        Me.btnLogout.MinimumSize = New System.Drawing.Size(142, 67)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(142, 67)
        Me.btnLogout.TabIndex = 27
        Me.btnLogout.Text = "🔙 Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnPenjualan, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPembelian, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSupplier, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStokBarang, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBarang, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnManageUser, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPengembalian, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 68)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(148, 441)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'btnPenjualan
        '
        Me.btnPenjualan.BackColor = System.Drawing.SystemColors.Window
        Me.btnPenjualan.FlatAppearance.BorderSize = 0
        Me.btnPenjualan.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenjualan.Location = New System.Drawing.Point(3, 251)
        Me.btnPenjualan.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(142, 64)
        Me.btnPenjualan.TabIndex = 29
        Me.btnPenjualan.Text = "Penjualan (Sales)"
        Me.btnPenjualan.UseVisualStyleBackColor = False
        '
        'btnPembelian
        '
        Me.btnPembelian.FlatAppearance.BorderSize = 0
        Me.btnPembelian.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPembelian.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembelian.Location = New System.Drawing.Point(3, 189)
        Me.btnPembelian.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPembelian.Name = "btnPembelian"
        Me.btnPembelian.Size = New System.Drawing.Size(142, 64)
        Me.btnPembelian.TabIndex = 25
        Me.btnPembelian.Text = "Pembelian (Purchase)"
        Me.btnPembelian.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Location = New System.Drawing.Point(3, 127)
        Me.btnSupplier.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(142, 64)
        Me.btnSupplier.TabIndex = 24
        Me.btnSupplier.Text = "Supplier"
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'btnStokBarang
        '
        Me.btnStokBarang.FlatAppearance.BorderSize = 0
        Me.btnStokBarang.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStokBarang.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnStokBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStokBarang.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStokBarang.Location = New System.Drawing.Point(3, 65)
        Me.btnStokBarang.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnStokBarang.Name = "btnStokBarang"
        Me.btnStokBarang.Size = New System.Drawing.Size(142, 64)
        Me.btnStokBarang.TabIndex = 23
        Me.btnStokBarang.Text = "Stok Barang (Inventaris)"
        Me.btnStokBarang.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBarang.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.Location = New System.Drawing.Point(3, 3)
        Me.btnBarang.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(142, 64)
        Me.btnBarang.TabIndex = 22
        Me.btnBarang.Text = "Barang"
        Me.btnBarang.UseVisualStyleBackColor = False
        '
        'btnManageUser
        '
        Me.btnManageUser.FlatAppearance.BorderSize = 0
        Me.btnManageUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnManageUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUser.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUser.Location = New System.Drawing.Point(3, 375)
        Me.btnManageUser.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Size = New System.Drawing.Size(142, 64)
        Me.btnManageUser.TabIndex = 26
        Me.btnManageUser.Text = "Pengguna (Users)"
        Me.btnManageUser.UseVisualStyleBackColor = True
        '
        'btnPengembalian
        '
        Me.btnPengembalian.FlatAppearance.BorderSize = 0
        Me.btnPengembalian.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPengembalian.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengembalian.Location = New System.Drawing.Point(3, 313)
        Me.btnPengembalian.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPengembalian.Name = "btnPengembalian"
        Me.btnPengembalian.Size = New System.Drawing.Size(142, 64)
        Me.btnPengembalian.TabIndex = 25
        Me.btnPengembalian.Text = "Pengembalian (Retur)"
        Me.btnPengembalian.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label13.Location = New System.Drawing.Point(13, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 43)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "P O S"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.btnKembali)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(148, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1218, 69)
        Me.Panel1.TabIndex = 24
        '
        'btnKembali
        '
        Me.btnKembali.AutoSize = True
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKembali.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnKembali.Location = New System.Drawing.Point(27, 23)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(26, 23)
        Me.btnKembali.TabIndex = 23
        Me.btnKembali.Text = "<"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(59, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 29)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Administrator"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(148, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(904, 680)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_Barang)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(896, 635)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List Barang"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_Barang
        '
        Me.dgv_Barang.AllowUserToAddRows = False
        Me.dgv_Barang.AllowUserToDeleteRows = False
        Me.dgv_Barang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_Barang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Barang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Barang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.colHrgaBeli, Me.Column6, Me.Column7, Me.Column10, Me.Column8, Me.Column11, Me.Column9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Barang.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Barang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Barang.Location = New System.Drawing.Point(0, 50)
        Me.dgv_Barang.Name = "dgv_Barang"
        Me.dgv_Barang.ReadOnly = True
        Me.dgv_Barang.RowHeadersVisible = False
        Me.dgv_Barang.Size = New System.Drawing.Size(896, 585)
        Me.dgv_Barang.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 44
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Kode Barang"
        Me.Column2.MinimumWidth = 117
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 117
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "Nama"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "Kategori"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 86
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "Satuan"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 78
        '
        'colHrgaBeli
        '
        Me.colHrgaBeli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colHrgaBeli.HeaderText = "Harga Beli"
        Me.colHrgaBeli.Name = "colHrgaBeli"
        Me.colHrgaBeli.ReadOnly = True
        Me.colHrgaBeli.Width = 98
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "Harga Jual"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 101
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column7.HeaderText = "Stok"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 61
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column10.HeaderText = "Min Stok"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 88
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "Barcode"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Visible = False
        Me.Column8.Width = 86
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column11.HeaderText = "Supplier ID"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 103
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.HeaderText = "Nama Supplier"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 126
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_cariBrg)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(896, 50)
        Me.Panel4.TabIndex = 17
        '
        'txt_cariBrg
        '
        Me.txt_cariBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_cariBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cariBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cariBrg.Location = New System.Drawing.Point(114, 11)
        Me.txt_cariBrg.Name = "txt_cariBrg"
        Me.txt_cariBrg.Size = New System.Drawing.Size(240, 26)
        Me.txt_cariBrg.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Search Barang:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_barangUbahMassal)
        Me.TabPage2.Controls.Add(Me.headerSelectAll)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(896, 654)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Penetapan Harga Massal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_barangUbahMassal
        '
        Me.dgv_barangUbahMassal.AllowUserToAddRows = False
        Me.dgv_barangUbahMassal.AllowUserToDeleteRows = False
        Me.dgv_barangUbahMassal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_barangUbahMassal.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_barangUbahMassal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_barangUbahMassal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barangUbahMassal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colPilih, Me.colKodeBarangLowStok, Me.colNamaBarangLowStok, Me.colSatuanBarangLowStok, Me.colHargaBeli, Me.colHargaBarangLowStok, Me.colStokBarangLowStok, Me.colMinStokBarangLowStok, Me.colSupplierIDLowStock, Me.colSupplierNamaLowStock})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_barangUbahMassal.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_barangUbahMassal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_barangUbahMassal.Location = New System.Drawing.Point(3, 88)
        Me.dgv_barangUbahMassal.Name = "dgv_barangUbahMassal"
        Me.dgv_barangUbahMassal.RowHeadersVisible = False
        Me.dgv_barangUbahMassal.Size = New System.Drawing.Size(890, 563)
        Me.dgv_barangUbahMassal.TabIndex = 30
        '
        'colNo
        '
        Me.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNo.HeaderText = "#"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Width = 44
        '
        'colPilih
        '
        Me.colPilih.HeaderText = "[  ]"
        Me.colPilih.MinimumWidth = 40
        Me.colPilih.Name = "colPilih"
        Me.colPilih.Visible = False
        Me.colPilih.Width = 40
        '
        'colKodeBarangLowStok
        '
        Me.colKodeBarangLowStok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colKodeBarangLowStok.HeaderText = "Kode Barang"
        Me.colKodeBarangLowStok.MinimumWidth = 117
        Me.colKodeBarangLowStok.Name = "colKodeBarangLowStok"
        Me.colKodeBarangLowStok.ReadOnly = True
        Me.colKodeBarangLowStok.Width = 117
        '
        'colNamaBarangLowStok
        '
        Me.colNamaBarangLowStok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNamaBarangLowStok.HeaderText = "Nama"
        Me.colNamaBarangLowStok.Name = "colNamaBarangLowStok"
        Me.colNamaBarangLowStok.ReadOnly = True
        '
        'colSatuanBarangLowStok
        '
        Me.colSatuanBarangLowStok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSatuanBarangLowStok.HeaderText = "Satuan"
        Me.colSatuanBarangLowStok.Name = "colSatuanBarangLowStok"
        Me.colSatuanBarangLowStok.ReadOnly = True
        Me.colSatuanBarangLowStok.Width = 78
        '
        'colHargaBeli
        '
        Me.colHargaBeli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaBeli.HeaderText = "Harga Beli"
        Me.colHargaBeli.Name = "colHargaBeli"
        Me.colHargaBeli.Width = 98
        '
        'colHargaBarangLowStok
        '
        Me.colHargaBarangLowStok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaBarangLowStok.HeaderText = "Harga Jual"
        Me.colHargaBarangLowStok.Name = "colHargaBarangLowStok"
        Me.colHargaBarangLowStok.ReadOnly = True
        Me.colHargaBarangLowStok.Width = 101
        '
        'colStokBarangLowStok
        '
        Me.colStokBarangLowStok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStokBarangLowStok.HeaderText = "Stok"
        Me.colStokBarangLowStok.Name = "colStokBarangLowStok"
        Me.colStokBarangLowStok.Visible = False
        '
        'colMinStokBarangLowStok
        '
        Me.colMinStokBarangLowStok.HeaderText = "Min Stok"
        Me.colMinStokBarangLowStok.Name = "colMinStokBarangLowStok"
        Me.colMinStokBarangLowStok.ReadOnly = True
        Me.colMinStokBarangLowStok.Visible = False
        '
        'colSupplierIDLowStock
        '
        Me.colSupplierIDLowStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierIDLowStock.HeaderText = "Supplier ID"
        Me.colSupplierIDLowStock.Name = "colSupplierIDLowStock"
        Me.colSupplierIDLowStock.ReadOnly = True
        Me.colSupplierIDLowStock.Visible = False
        '
        'colSupplierNamaLowStock
        '
        Me.colSupplierNamaLowStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierNamaLowStock.HeaderText = "Nama Supplier"
        Me.colSupplierNamaLowStock.Name = "colSupplierNamaLowStock"
        Me.colSupplierNamaLowStock.Width = 126
        '
        'headerSelectAll
        '
        Me.headerSelectAll.Controls.Add(Me.btnRestockSemua)
        Me.headerSelectAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerSelectAll.Location = New System.Drawing.Point(3, 53)
        Me.headerSelectAll.Name = "headerSelectAll"
        Me.headerSelectAll.Size = New System.Drawing.Size(890, 35)
        Me.headerSelectAll.TabIndex = 34
        '
        'btnRestockSemua
        '
        Me.btnRestockSemua.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnRestockSemua.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRestockSemua.Location = New System.Drawing.Point(9, 4)
        Me.btnRestockSemua.Name = "btnRestockSemua"
        Me.btnRestockSemua.Size = New System.Drawing.Size(157, 26)
        Me.btnRestockSemua.TabIndex = 30
        Me.btnRestockSemua.Text = "✏️ Ubah Massal"
        Me.btnRestockSemua.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_ResetFilter)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.cbo_filterbySupplier)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(890, 50)
        Me.Panel5.TabIndex = 31
        '
        'btn_ResetFilter
        '
        Me.btn_ResetFilter.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_ResetFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ResetFilter.Location = New System.Drawing.Point(1113, 12)
        Me.btn_ResetFilter.Name = "btn_ResetFilter"
        Me.btn_ResetFilter.Size = New System.Drawing.Size(75, 26)
        Me.btn_ResetFilter.TabIndex = 29
        Me.btn_ResetFilter.Text = "Reset"
        Me.btn_ResetFilter.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 16)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Filter by Supplier:"
        '
        'cbo_filterbySupplier
        '
        Me.cbo_filterbySupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_filterbySupplier.FormattingEnabled = True
        Me.cbo_filterbySupplier.Location = New System.Drawing.Point(130, 12)
        Me.cbo_filterbySupplier.Name = "cbo_filterbySupplier"
        Me.cbo_filterbySupplier.Size = New System.Drawing.Size(200, 26)
        Me.cbo_filterbySupplier.TabIndex = 27
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(1305, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 6
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_barcodeValue)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txt_namaSup)
        Me.Panel3.Controls.Add(Me.cbo_IDSup)
        Me.Panel3.Controls.Add(Me.cbo_tipeBarcode)
        Me.Panel3.Controls.Add(Me.txt_hrgaBeli)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.btn_printBarcodeBarang)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txt_minStok)
        Me.Panel3.Controls.Add(Me.txt_stok)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.btn_tmbhSatuan)
        Me.Panel3.Controls.Add(Me.btn_tmbhKategori)
        Me.Panel3.Controls.Add(Me.btn_delBrg)
        Me.Panel3.Controls.Add(Me.btn_clearBrg)
        Me.Panel3.Controls.Add(Me.btn_updateBrg)
        Me.Panel3.Controls.Add(Me.btn_simpanBrg)
        Me.Panel3.Controls.Add(Me.pic_barcodeBrng)
        Me.Panel3.Controls.Add(Me.lblbarcode)
        Me.Panel3.Controls.Add(Me.cbo_satuanBrg)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbo_kategoriBrg)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txt_hrgaBrg)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_nmaBrg)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txt_kodeBrg)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1052, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(314, 680)
        Me.Panel3.TabIndex = 26
        '
        'txt_barcodeValue
        '
        Me.txt_barcodeValue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_barcodeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_barcodeValue.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barcodeValue.Location = New System.Drawing.Point(15, 112)
        Me.txt_barcodeValue.Name = "txt_barcodeValue"
        Me.txt_barcodeValue.Size = New System.Drawing.Size(283, 26)
        Me.txt_barcodeValue.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(159, 482)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Nama Supplier:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 16)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "No. Barcode:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 482)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "ID Supplier:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Tipe Barcode:"
        '
        'txt_namaSup
        '
        Me.txt_namaSup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_namaSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_namaSup.Enabled = False
        Me.txt_namaSup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaSup.Location = New System.Drawing.Point(162, 501)
        Me.txt_namaSup.Name = "txt_namaSup"
        Me.txt_namaSup.ReadOnly = True
        Me.txt_namaSup.Size = New System.Drawing.Size(138, 26)
        Me.txt_namaSup.TabIndex = 60
        '
        'cbo_IDSup
        '
        Me.cbo_IDSup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_IDSup.FormattingEnabled = True
        Me.cbo_IDSup.Location = New System.Drawing.Point(15, 500)
        Me.cbo_IDSup.Name = "cbo_IDSup"
        Me.cbo_IDSup.Size = New System.Drawing.Size(138, 26)
        Me.cbo_IDSup.TabIndex = 59
        '
        'cbo_tipeBarcode
        '
        Me.cbo_tipeBarcode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipeBarcode.FormattingEnabled = True
        Me.cbo_tipeBarcode.Items.AddRange(New Object() {"Generate Barcode Baru", "Barcode Kosong dari Roll", "Barcode Sudah Ada"})
        Me.cbo_tipeBarcode.Location = New System.Drawing.Point(15, 166)
        Me.cbo_tipeBarcode.Name = "cbo_tipeBarcode"
        Me.cbo_tipeBarcode.Size = New System.Drawing.Size(285, 26)
        Me.cbo_tipeBarcode.TabIndex = 63
        '
        'txt_hrgaBeli
        '
        Me.txt_hrgaBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaBeli.Location = New System.Drawing.Point(15, 389)
        Me.txt_hrgaBeli.Name = "txt_hrgaBeli"
        Me.txt_hrgaBeli.Size = New System.Drawing.Size(138, 26)
        Me.txt_hrgaBeli.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Harga Beli:"
        '
        'btn_printBarcodeBarang
        '
        Me.btn_printBarcodeBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_printBarcodeBarang.FlatAppearance.BorderSize = 0
        Me.btn_printBarcodeBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_printBarcodeBarang.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.btn_printBarcodeBarang.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_printBarcodeBarang.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_printBarcodeBarang.Location = New System.Drawing.Point(252, 556)
        Me.btn_printBarcodeBarang.Name = "btn_printBarcodeBarang"
        Me.btn_printBarcodeBarang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_printBarcodeBarang.Size = New System.Drawing.Size(48, 46)
        Me.btn_printBarcodeBarang.TabIndex = 56
        Me.btn_printBarcodeBarang.Text = "Print 🖨️"
        Me.btn_printBarcodeBarang.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(159, 426)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 16)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Min Stok:"
        '
        'txt_minStok
        '
        Me.txt_minStok.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_minStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_minStok.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_minStok.Location = New System.Drawing.Point(162, 445)
        Me.txt_minStok.Name = "txt_minStok"
        Me.txt_minStok.Size = New System.Drawing.Size(138, 26)
        Me.txt_minStok.TabIndex = 54
        '
        'txt_stok
        '
        Me.txt_stok.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_stok.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stok.Location = New System.Drawing.Point(15, 445)
        Me.txt_stok.Name = "txt_stok"
        Me.txt_stok.Size = New System.Drawing.Size(138, 26)
        Me.txt_stok.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 426)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 52
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
        Me.btn_tmbhSatuan.Location = New System.Drawing.Point(253, 341)
        Me.btn_tmbhSatuan.Name = "btn_tmbhSatuan"
        Me.btn_tmbhSatuan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhSatuan.Size = New System.Drawing.Size(48, 26)
        Me.btn_tmbhSatuan.TabIndex = 49
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
        Me.btn_tmbhKategori.Location = New System.Drawing.Point(252, 285)
        Me.btn_tmbhKategori.Name = "btn_tmbhKategori"
        Me.btn_tmbhKategori.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhKategori.Size = New System.Drawing.Size(48, 26)
        Me.btn_tmbhKategori.TabIndex = 48
        Me.btn_tmbhKategori.Text = "➕"
        Me.btn_tmbhKategori.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhKategori.UseVisualStyleBackColor = False
        '
        'btn_delBrg
        '
        Me.btn_delBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_delBrg.FlatAppearance.BorderSize = 0
        Me.btn_delBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delBrg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delBrg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delBrg.Location = New System.Drawing.Point(164, 660)
        Me.btn_delBrg.Name = "btn_delBrg"
        Me.btn_delBrg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_delBrg.Size = New System.Drawing.Size(138, 26)
        Me.btn_delBrg.TabIndex = 47
        Me.btn_delBrg.Text = "Delete 🗑️"
        Me.btn_delBrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delBrg.UseVisualStyleBackColor = False
        '
        'btn_clearBrg
        '
        Me.btn_clearBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_clearBrg.FlatAppearance.BorderSize = 0
        Me.btn_clearBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearBrg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clearBrg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearBrg.Location = New System.Drawing.Point(17, 660)
        Me.btn_clearBrg.Name = "btn_clearBrg"
        Me.btn_clearBrg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_clearBrg.Size = New System.Drawing.Size(138, 26)
        Me.btn_clearBrg.TabIndex = 46
        Me.btn_clearBrg.Text = "Clear 🧹"
        Me.btn_clearBrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearBrg.UseVisualStyleBackColor = False
        '
        'btn_updateBrg
        '
        Me.btn_updateBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btn_updateBrg.FlatAppearance.BorderSize = 0
        Me.btn_updateBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateBrg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_updateBrg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateBrg.Location = New System.Drawing.Point(164, 626)
        Me.btn_updateBrg.Name = "btn_updateBrg"
        Me.btn_updateBrg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_updateBrg.Size = New System.Drawing.Size(138, 26)
        Me.btn_updateBrg.TabIndex = 45
        Me.btn_updateBrg.Text = "Update ✏️"
        Me.btn_updateBrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateBrg.UseVisualStyleBackColor = False
        '
        'btn_simpanBrg
        '
        Me.btn_simpanBrg.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_simpanBrg.FlatAppearance.BorderSize = 0
        Me.btn_simpanBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpanBrg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanBrg.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanBrg.Location = New System.Drawing.Point(17, 626)
        Me.btn_simpanBrg.Name = "btn_simpanBrg"
        Me.btn_simpanBrg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanBrg.Size = New System.Drawing.Size(138, 26)
        Me.btn_simpanBrg.TabIndex = 44
        Me.btn_simpanBrg.Text = "Simpan 💾"
        Me.btn_simpanBrg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanBrg.UseVisualStyleBackColor = False
        '
        'pic_barcodeBrng
        '
        Me.pic_barcodeBrng.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_barcodeBrng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_barcodeBrng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_barcodeBrng.Location = New System.Drawing.Point(15, 547)
        Me.pic_barcodeBrng.Name = "pic_barcodeBrng"
        Me.pic_barcodeBrng.Size = New System.Drawing.Size(231, 46)
        Me.pic_barcodeBrng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barcodeBrng.TabIndex = 42
        Me.pic_barcodeBrng.TabStop = False
        '
        'lblbarcode
        '
        Me.lblbarcode.AutoSize = True
        Me.lblbarcode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbarcode.Location = New System.Drawing.Point(12, 537)
        Me.lblbarcode.Name = "lblbarcode"
        Me.lblbarcode.Size = New System.Drawing.Size(58, 16)
        Me.lblbarcode.TabIndex = 40
        Me.lblbarcode.Text = "Barcode:"
        '
        'cbo_satuanBrg
        '
        Me.cbo_satuanBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_satuanBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_satuanBrg.FormattingEnabled = True
        Me.cbo_satuanBrg.Location = New System.Drawing.Point(15, 333)
        Me.cbo_satuanBrg.Name = "cbo_satuanBrg"
        Me.cbo_satuanBrg.Size = New System.Drawing.Size(231, 26)
        Me.cbo_satuanBrg.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Satuan:"
        '
        'cbo_kategoriBrg
        '
        Me.cbo_kategoriBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kategoriBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_kategoriBrg.FormattingEnabled = True
        Me.cbo_kategoriBrg.Location = New System.Drawing.Point(15, 277)
        Me.cbo_kategoriBrg.Name = "cbo_kategoriBrg"
        Me.cbo_kategoriBrg.Size = New System.Drawing.Size(231, 26)
        Me.cbo_kategoriBrg.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Kategori:"
        '
        'txt_hrgaBrg
        '
        Me.txt_hrgaBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaBrg.Location = New System.Drawing.Point(162, 389)
        Me.txt_hrgaBrg.Name = "txt_hrgaBrg"
        Me.txt_hrgaBrg.Size = New System.Drawing.Size(138, 26)
        Me.txt_hrgaBrg.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Harga Jual:"
        '
        'txt_nmaBrg
        '
        Me.txt_nmaBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_nmaBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nmaBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nmaBrg.Location = New System.Drawing.Point(15, 221)
        Me.txt_nmaBrg.Name = "txt_nmaBrg"
        Me.txt_nmaBrg.Size = New System.Drawing.Size(285, 26)
        Me.txt_nmaBrg.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Nama Barang:"
        '
        'txt_kodeBrg
        '
        Me.txt_kodeBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kodeBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kodeBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kodeBrg.Location = New System.Drawing.Point(15, 55)
        Me.txt_kodeBrg.Name = "txt_kodeBrg"
        Me.txt_kodeBrg.Size = New System.Drawing.Size(285, 26)
        Me.txt_kodeBrg.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Kode Barang:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 1)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Management Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_ManageBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 718)
        Me.Name = "frm_ManageBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ManageBarang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_barangUbahMassal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerSelectAll.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pic_barcodeBrng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPengembalian As Button
    Friend WithEvents btnPembelian As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnStokBarang As Button
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnManageUser As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv_Barang As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariBrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnKembali As Label
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents colHrgaBeli As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_barangUbahMassal As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_ResetFilter As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents cbo_filterbySupplier As ComboBox
    Friend WithEvents headerSelectAll As Panel
    Friend WithEvents btnRestockSemua As Button
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colPilih As DataGridViewCheckBoxColumn
    Friend WithEvents colKodeBarangLowStok As DataGridViewTextBoxColumn
    Friend WithEvents colNamaBarangLowStok As DataGridViewTextBoxColumn
    Friend WithEvents colSatuanBarangLowStok As DataGridViewTextBoxColumn
    Friend WithEvents colHargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents colHargaBarangLowStok As DataGridViewTextBoxColumn
    Friend WithEvents colStokBarangLowStok As DataGridViewTextBoxColumn
    Friend WithEvents colMinStokBarangLowStok As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierIDLowStock As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierNamaLowStock As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_tipeBarcode As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_namaSup As TextBox
    Friend WithEvents cbo_IDSup As ComboBox
    Friend WithEvents txt_hrgaBeli As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_printBarcodeBarang As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_minStok As TextBox
    Friend WithEvents txt_stok As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_tmbhSatuan As Button
    Friend WithEvents btn_tmbhKategori As Button
    Friend WithEvents btn_delBrg As Button
    Friend WithEvents btn_clearBrg As Button
    Friend WithEvents btn_updateBrg As Button
    Friend WithEvents btn_simpanBrg As Button
    Friend WithEvents pic_barcodeBrng As PictureBox
    Friend WithEvents lblbarcode As Label
    Friend WithEvents cbo_satuanBrg As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_kategoriBrg As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_hrgaBrg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nmaBrg As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_kodeBrg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_barcodeValue As TextBox
    Friend WithEvents Label20 As Label
End Class
