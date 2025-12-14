<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManagePembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManagePembelian))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKembali = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_btlBeli = New System.Windows.Forms.Button()
        Me.btn_simpanBeli = New System.Windows.Forms.Button()
        Me.txt_totalBeli = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_barangBaruBeli = New System.Windows.Forms.Button()
        Me.txt_satuanBrgBeli = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_namaBrg = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_brg = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hrgaBeli = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NamaSupplier = New System.Windows.Forms.TextBox()
        Me.cbo_IDSup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_kodeBeli = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtp_tglBeli = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_listPembelian = New System.Windows.Forms.DataGridView()
        Me.colNmr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDPembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTglPembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDSupBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaSupBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cariBrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnl_listDetail = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.rtb_detailPembelian = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_totalPembelian = New System.Windows.Forms.Label()
        Me.lbl_nmaSup = New System.Windows.Forms.Label()
        Me.lbl_IDSupBeli = New System.Windows.Forms.Label()
        Me.lbl_tanggalPembelian = New System.Windows.Forms.Label()
        Me.lbl_IDPembelian = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_delPembelian = New System.Windows.Forms.Button()
        Me.btn_clearPembelian = New System.Windows.Forms.Button()
        Me.btn_updatePembelian = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detailPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_listPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnl_listDetail.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(1157, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 25
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.btnKembali)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(148, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1218, 69)
        Me.Panel1.TabIndex = 27
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.closeBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1218, 69)
        Me.Panel2.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(59, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Administrator"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel6.Size = New System.Drawing.Size(148, 768)
        Me.Panel6.TabIndex = 28
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
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 695)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(148, 73)
        Me.TableLayoutPanel2.TabIndex = 22
        '
        'btnLogout
        '
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(148, 460)
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
        Me.btnPenjualan.Location = New System.Drawing.Point(3, 263)
        Me.btnPenjualan.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(142, 64)
        Me.btnPenjualan.TabIndex = 39
        Me.btnPenjualan.Text = "Penjualan (Sales)"
        Me.btnPenjualan.UseVisualStyleBackColor = False
        '
        'btnPembelian
        '
        Me.btnPembelian.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPembelian.FlatAppearance.BorderSize = 0
        Me.btnPembelian.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPembelian.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembelian.Location = New System.Drawing.Point(3, 198)
        Me.btnPembelian.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPembelian.Name = "btnPembelian"
        Me.btnPembelian.Size = New System.Drawing.Size(142, 64)
        Me.btnPembelian.TabIndex = 25
        Me.btnPembelian.Text = "Pembelian (Purchase)"
        Me.btnPembelian.UseVisualStyleBackColor = False
        '
        'btnSupplier
        '
        Me.btnSupplier.FlatAppearance.BorderSize = 0
        Me.btnSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Location = New System.Drawing.Point(3, 133)
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
        Me.btnStokBarang.Location = New System.Drawing.Point(3, 68)
        Me.btnStokBarang.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnStokBarang.Name = "btnStokBarang"
        Me.btnStokBarang.Size = New System.Drawing.Size(142, 64)
        Me.btnStokBarang.TabIndex = 23
        Me.btnStokBarang.Text = "Stok Barang (Inventaris)"
        Me.btnStokBarang.UseVisualStyleBackColor = True
        '
        'btnBarang
        '
        Me.btnBarang.BackColor = System.Drawing.SystemColors.Window
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
        Me.btnManageUser.Location = New System.Drawing.Point(3, 393)
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
        Me.btnPengembalian.Location = New System.Drawing.Point(3, 328)
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
        Me.TabControl1.Size = New System.Drawing.Size(1218, 699)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dtp_tglBeli)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Simpan Pembelian Baru"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_btlBeli)
        Me.GroupBox3.Controls.Add(Me.btn_simpanBeli)
        Me.GroupBox3.Controls.Add(Me.txt_totalBeli)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 563)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1158, 72)
        Me.GroupBox3.TabIndex = 38
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_barangBaruBeli)
        Me.GroupBox2.Controls.Add(Me.txt_satuanBrgBeli)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_namaBrg)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cbo_brg)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_subTotal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_hrgaBeli)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_qty)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_tmbhDetBeli)
        Me.GroupBox2.Controls.Add(Me.dgv_detailPembelian)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1158, 375)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Barang"
        '
        'btn_barangBaruBeli
        '
        Me.btn_barangBaruBeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_barangBaruBeli.FlatAppearance.BorderSize = 0
        Me.btn_barangBaruBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_barangBaruBeli.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_barangBaruBeli.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_barangBaruBeli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_barangBaruBeli.Location = New System.Drawing.Point(267, 22)
        Me.btn_barangBaruBeli.Name = "btn_barangBaruBeli"
        Me.btn_barangBaruBeli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_barangBaruBeli.Size = New System.Drawing.Size(130, 29)
        Me.btn_barangBaruBeli.TabIndex = 67
        Me.btn_barangBaruBeli.Text = "➕ Barang Baru"
        Me.btn_barangBaruBeli.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_barangBaruBeli.UseVisualStyleBackColor = False
        '
        'txt_satuanBrgBeli
        '
        Me.txt_satuanBrgBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_satuanBrgBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuanBrgBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_satuanBrgBeli.Location = New System.Drawing.Point(137, 178)
        Me.txt_satuanBrgBeli.Name = "txt_satuanBrgBeli"
        Me.txt_satuanBrgBeli.Size = New System.Drawing.Size(110, 26)
        Me.txt_satuanBrgBeli.TabIndex = 66
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(862, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(275, 16)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "*Double klik barang jika ingin hapus barang itu"
        '
        'txt_namaBrg
        '
        Me.txt_namaBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_namaBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_namaBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaBrg.Location = New System.Drawing.Point(18, 123)
        Me.txt_namaBrg.Name = "txt_namaBrg"
        Me.txt_namaBrg.ReadOnly = True
        Me.txt_namaBrg.Size = New System.Drawing.Size(229, 26)
        Me.txt_namaBrg.TabIndex = 61
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Nama Barang:"
        '
        'cbo_brg
        '
        Me.cbo_brg.FormattingEnabled = True
        Me.cbo_brg.Location = New System.Drawing.Point(18, 68)
        Me.cbo_brg.Name = "cbo_brg"
        Me.cbo_brg.Size = New System.Drawing.Size(229, 26)
        Me.cbo_brg.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(135, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Satuan:"
        '
        'txt_subTotal
        '
        Me.txt_subTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_subTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subTotal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subTotal.Location = New System.Drawing.Point(18, 288)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.ReadOnly = True
        Me.txt_subTotal.Size = New System.Drawing.Size(229, 26)
        Me.txt_subTotal.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Subtotal:"
        '
        'txt_hrgaBeli
        '
        Me.txt_hrgaBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaBeli.Location = New System.Drawing.Point(18, 233)
        Me.txt_hrgaBeli.Name = "txt_hrgaBeli"
        Me.txt_hrgaBeli.Size = New System.Drawing.Size(229, 26)
        Me.txt_hrgaBeli.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Harga Beli per Satuan:"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(18, 178)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(110, 26)
        Me.txt_qty.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 51
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
        Me.btn_tmbhDetBeli.Location = New System.Drawing.Point(18, 330)
        Me.btn_tmbhDetBeli.Name = "btn_tmbhDetBeli"
        Me.btn_tmbhDetBeli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhDetBeli.Size = New System.Drawing.Size(229, 29)
        Me.btn_tmbhDetBeli.TabIndex = 50
        Me.btn_tmbhDetBeli.Text = "➕ Tambah ke List"
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
        Me.dgv_detailPembelian.Location = New System.Drawing.Point(267, 62)
        Me.dgv_detailPembelian.Name = "dgv_detailPembelian"
        Me.dgv_detailPembelian.ReadOnly = True
        Me.dgv_detailPembelian.RowHeadersVisible = False
        Me.dgv_detailPembelian.Size = New System.Drawing.Size(870, 297)
        Me.dgv_detailPembelian.TabIndex = 0
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
        Me.colNmaBrg.Name = "colNmaBrg"
        Me.colNmaBrg.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 57
        '
        'colSatuan
        '
        Me.colSatuan.HeaderText = "Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.ReadOnly = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_NamaSupplier)
        Me.GroupBox1.Controls.Add(Me.cbo_IDSup)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_kodeBeli)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1158, 88)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rincian Pembelian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ID Supplier:"
        '
        'txt_NamaSupplier
        '
        Me.txt_NamaSupplier.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_NamaSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NamaSupplier.Enabled = False
        Me.txt_NamaSupplier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NamaSupplier.Location = New System.Drawing.Point(768, 37)
        Me.txt_NamaSupplier.Name = "txt_NamaSupplier"
        Me.txt_NamaSupplier.ReadOnly = True
        Me.txt_NamaSupplier.Size = New System.Drawing.Size(200, 26)
        Me.txt_NamaSupplier.TabIndex = 36
        '
        'cbo_IDSup
        '
        Me.cbo_IDSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_IDSup.FormattingEnabled = True
        Me.cbo_IDSup.Location = New System.Drawing.Point(435, 37)
        Me.cbo_IDSup.Name = "cbo_IDSup"
        Me.cbo_IDSup.Size = New System.Drawing.Size(200, 26)
        Me.cbo_IDSup.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(666, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Nama Supplier:"
        '
        'txt_kodeBeli
        '
        Me.txt_kodeBeli.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kodeBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kodeBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kodeBeli.Location = New System.Drawing.Point(124, 37)
        Me.txt_kodeBeli.Name = "txt_kodeBeli"
        Me.txt_kodeBeli.Size = New System.Drawing.Size(200, 26)
        Me.txt_kodeBeli.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 16)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Kode Pembelian:"
        '
        'dtp_tglBeli
        '
        Me.dtp_tglBeli.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_tglBeli.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglBeli.Location = New System.Drawing.Point(165, 26)
        Me.dtp_tglBeli.Name = "dtp_tglBeli"
        Me.dtp_tglBeli.Size = New System.Drawing.Size(200, 25)
        Me.dtp_tglBeli.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(24, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tanggal Pembelian:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_listPembelian)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Master List Pembelian"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_listPembelian
        '
        Me.dgv_listPembelian.AllowUserToAddRows = False
        Me.dgv_listPembelian.AllowUserToDeleteRows = False
        Me.dgv_listPembelian.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_listPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listPembelian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_listPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNmr, Me.colIDPembelian, Me.colTglPembelian, Me.colIDSupBeli, Me.colNmaSupBeli, Me.colTotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listPembelian.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_listPembelian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_listPembelian.Location = New System.Drawing.Point(3, 53)
        Me.dgv_listPembelian.Name = "dgv_listPembelian"
        Me.dgv_listPembelian.ReadOnly = True
        Me.dgv_listPembelian.RowHeadersVisible = False
        Me.dgv_listPembelian.Size = New System.Drawing.Size(812, 598)
        Me.dgv_listPembelian.TabIndex = 18
        '
        'colNmr
        '
        Me.colNmr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNmr.HeaderText = "#"
        Me.colNmr.MinimumWidth = 44
        Me.colNmr.Name = "colNmr"
        Me.colNmr.ReadOnly = True
        Me.colNmr.Width = 44
        '
        'colIDPembelian
        '
        Me.colIDPembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIDPembelian.HeaderText = "Pembelian ID "
        Me.colIDPembelian.MinimumWidth = 154
        Me.colIDPembelian.Name = "colIDPembelian"
        Me.colIDPembelian.ReadOnly = True
        '
        'colTglPembelian
        '
        Me.colTglPembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTglPembelian.HeaderText = "Tanggal"
        Me.colTglPembelian.MinimumWidth = 85
        Me.colTglPembelian.Name = "colTglPembelian"
        Me.colTglPembelian.ReadOnly = True
        '
        'colIDSupBeli
        '
        Me.colIDSupBeli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIDSupBeli.HeaderText = "Supplier ID"
        Me.colIDSupBeli.MinimumWidth = 105
        Me.colIDSupBeli.Name = "colIDSupBeli"
        Me.colIDSupBeli.ReadOnly = True
        '
        'colNmaSupBeli
        '
        Me.colNmaSupBeli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNmaSupBeli.HeaderText = "Nama Supplier"
        Me.colNmaSupBeli.MinimumWidth = 115
        Me.colNmaSupBeli.Name = "colNmaSupBeli"
        Me.colNmaSupBeli.ReadOnly = True
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_cariBrg)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(812, 50)
        Me.Panel4.TabIndex = 19
        '
        'txt_cariBrg
        '
        Me.txt_cariBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_cariBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cariBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cariBrg.Location = New System.Drawing.Point(136, 12)
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
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Search Pembelian:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.pnl_listDetail)
        Me.Panel3.Controls.Add(Me.lbl_totalPembelian)
        Me.Panel3.Controls.Add(Me.lbl_nmaSup)
        Me.Panel3.Controls.Add(Me.lbl_IDSupBeli)
        Me.Panel3.Controls.Add(Me.lbl_tanggalPembelian)
        Me.Panel3.Controls.Add(Me.lbl_IDPembelian)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(815, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 648)
        Me.Panel3.TabIndex = 20
        '
        'pnl_listDetail
        '
        Me.pnl_listDetail.Controls.Add(Me.Label23)
        Me.pnl_listDetail.Controls.Add(Me.rtb_detailPembelian)
        Me.pnl_listDetail.Controls.Add(Me.Label21)
        Me.pnl_listDetail.Controls.Add(Me.Label22)
        Me.pnl_listDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_listDetail.Location = New System.Drawing.Point(0, 213)
        Me.pnl_listDetail.Name = "pnl_listDetail"
        Me.pnl_listDetail.Size = New System.Drawing.Size(390, 386)
        Me.pnl_listDetail.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(0, 1)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(390, 1)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = resources.GetString("Label23.Text")
        '
        'rtb_detailPembelian
        '
        Me.rtb_detailPembelian.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_detailPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_detailPembelian.Location = New System.Drawing.Point(14, 42)
        Me.rtb_detailPembelian.Name = "rtb_detailPembelian"
        Me.rtb_detailPembelian.ReadOnly = True
        Me.rtb_detailPembelian.Size = New System.Drawing.Size(362, 335)
        Me.rtb_detailPembelian.TabIndex = 32
        Me.rtb_detailPembelian.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label21.Location = New System.Drawing.Point(131, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(142, 18)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "Detail List Barang"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(0, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(390, 1)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = resources.GetString("Label22.Text")
        '
        'lbl_totalPembelian
        '
        Me.lbl_totalPembelian.AutoSize = True
        Me.lbl_totalPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPembelian.Location = New System.Drawing.Point(11, 178)
        Me.lbl_totalPembelian.Name = "lbl_totalPembelian"
        Me.lbl_totalPembelian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalPembelian.TabIndex = 31
        Me.lbl_totalPembelian.Text = "-"
        '
        'lbl_nmaSup
        '
        Me.lbl_nmaSup.AutoSize = True
        Me.lbl_nmaSup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nmaSup.Location = New System.Drawing.Point(11, 144)
        Me.lbl_nmaSup.Name = "lbl_nmaSup"
        Me.lbl_nmaSup.Size = New System.Drawing.Size(13, 18)
        Me.lbl_nmaSup.TabIndex = 30
        Me.lbl_nmaSup.Text = "-"
        '
        'lbl_IDSupBeli
        '
        Me.lbl_IDSupBeli.AutoSize = True
        Me.lbl_IDSupBeli.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDSupBeli.Location = New System.Drawing.Point(11, 110)
        Me.lbl_IDSupBeli.Name = "lbl_IDSupBeli"
        Me.lbl_IDSupBeli.Size = New System.Drawing.Size(13, 18)
        Me.lbl_IDSupBeli.TabIndex = 29
        Me.lbl_IDSupBeli.Text = "-"
        '
        'lbl_tanggalPembelian
        '
        Me.lbl_tanggalPembelian.AutoSize = True
        Me.lbl_tanggalPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggalPembelian.Location = New System.Drawing.Point(11, 76)
        Me.lbl_tanggalPembelian.Name = "lbl_tanggalPembelian"
        Me.lbl_tanggalPembelian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tanggalPembelian.TabIndex = 28
        Me.lbl_tanggalPembelian.Text = "-"
        '
        'lbl_IDPembelian
        '
        Me.lbl_IDPembelian.AutoSize = True
        Me.lbl_IDPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDPembelian.Location = New System.Drawing.Point(11, 42)
        Me.lbl_IDPembelian.Name = "lbl_IDPembelian"
        Me.lbl_IDPembelian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_IDPembelian.TabIndex = 27
        Me.lbl_IDPembelian.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label20.Location = New System.Drawing.Point(87, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(220, 18)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Informasi Pembelian Barang"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(0, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(390, 1)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = resources.GetString("Label19.Text")
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_delPembelian)
        Me.Panel5.Controls.Add(Me.btn_clearPembelian)
        Me.Panel5.Controls.Add(Me.btn_updatePembelian)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 599)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(390, 47)
        Me.Panel5.TabIndex = 35
        '
        'btn_delPembelian
        '
        Me.btn_delPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_delPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delPembelian.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delPembelian.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delPembelian.Location = New System.Drawing.Point(260, 9)
        Me.btn_delPembelian.Name = "btn_delPembelian"
        Me.btn_delPembelian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_delPembelian.Size = New System.Drawing.Size(115, 29)
        Me.btn_delPembelian.TabIndex = 50
        Me.btn_delPembelian.Text = "Delete 🗑️"
        Me.btn_delPembelian.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delPembelian.UseVisualStyleBackColor = False
        '
        'btn_clearPembelian
        '
        Me.btn_clearPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_clearPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearPembelian.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clearPembelian.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearPembelian.Location = New System.Drawing.Point(14, 9)
        Me.btn_clearPembelian.Name = "btn_clearPembelian"
        Me.btn_clearPembelian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_clearPembelian.Size = New System.Drawing.Size(115, 29)
        Me.btn_clearPembelian.TabIndex = 49
        Me.btn_clearPembelian.Text = "Clear 🧹"
        Me.btn_clearPembelian.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearPembelian.UseVisualStyleBackColor = False
        '
        'btn_updatePembelian
        '
        Me.btn_updatePembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btn_updatePembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updatePembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updatePembelian.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_updatePembelian.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updatePembelian.Location = New System.Drawing.Point(137, 9)
        Me.btn_updatePembelian.Name = "btn_updatePembelian"
        Me.btn_updatePembelian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_updatePembelian.Size = New System.Drawing.Size(115, 29)
        Me.btn_updatePembelian.TabIndex = 48
        Me.btn_updatePembelian.Text = "Update ✏️"
        Me.btn_updatePembelian.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updatePembelian.UseVisualStyleBackColor = False
        '
        'frm_ManagePembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 718)
        Me.Name = "frm_ManagePembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ManagePembelian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detailPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_listPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnl_listDetail.ResumeLayout(False)
        Me.pnl_listDetail.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents closeBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKembali As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_listPembelian As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariBrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_tglBeli As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_IDSup As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_NamaSupplier As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_detailPembelian As DataGridView
    Friend WithEvents btn_tmbhDetBeli As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hrgaBeli As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_totalBeli As TextBox
    Friend WithEvents btn_simpanBeli As Button
    Friend WithEvents btn_btlBeli As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents cbo_brg As ComboBox
    Friend WithEvents txt_namaBrg As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_kodeBeli As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrg As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrg As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As DataGridViewTextBoxColumn
    Friend WithEvents colHargaBli As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_IDPembelian As Label
    Friend WithEvents lbl_tanggalPembelian As Label
    Friend WithEvents lbl_IDSupBeli As Label
    Friend WithEvents lbl_nmaSup As Label
    Friend WithEvents lbl_totalPembelian As Label
    Friend WithEvents pnl_listDetail As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents rtb_detailPembelian As RichTextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_delPembelian As Button
    Friend WithEvents btn_clearPembelian As Button
    Friend WithEvents btn_updatePembelian As Button
    Friend WithEvents colNmr As DataGridViewTextBoxColumn
    Friend WithEvents colIDPembelian As DataGridViewTextBoxColumn
    Friend WithEvents colTglPembelian As DataGridViewTextBoxColumn
    Friend WithEvents colIDSupBeli As DataGridViewTextBoxColumn
    Friend WithEvents colNmaSupBeli As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents txt_satuanBrgBeli As TextBox
    Friend WithEvents btn_barangBaruBeli As Button
End Class
