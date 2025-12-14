<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManageStok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManageStok))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKembali = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_StokBarang = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_updateStock = New System.Windows.Forms.Button()
        Me.txt_cariBrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rtf_notifStok = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_stokMenipisSaja = New System.Windows.Forms.DataGridView()
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
        Me.colAddLowStock = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.headerSelectAll = New System.Windows.Forms.Panel()
        Me.btnRestockSemua = New System.Windows.Forms.Button()
        Me.cbo_selectAllLowStock = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_ResetFilter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_filterbySupplier = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_StokBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_stokMenipisSaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerSelectAll.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Controls.Add(Me.btnKembali)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(148, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1218, 69)
        Me.Panel1.TabIndex = 26
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
        Me.Panel6.TabIndex = 27
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
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 676)
        Me.TableLayoutPanel2.MinimumSize = New System.Drawing.Size(142, 73)
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
        Me.btnPenjualan.TabIndex = 30
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
        Me.btnStokBarang.BackColor = System.Drawing.SystemColors.GradientActiveCaption
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
        Me.btnStokBarang.UseVisualStyleBackColor = False
        '
        'btnBarang
        '
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
        Me.btnBarang.UseVisualStyleBackColor = True
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
        Me.TabControl1.Size = New System.Drawing.Size(1218, 680)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_StokBarang)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stok Barang"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_StokBarang
        '
        Me.dgv_StokBarang.AllowUserToAddRows = False
        Me.dgv_StokBarang.AllowUserToDeleteRows = False
        Me.dgv_StokBarang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_StokBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_StokBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_StokBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_StokBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column6, Me.Column7, Me.Column10, Me.colSupplierID, Me.colSupplierNama})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_StokBarang.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_StokBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_StokBarang.Location = New System.Drawing.Point(0, 66)
        Me.dgv_StokBarang.Name = "dgv_StokBarang"
        Me.dgv_StokBarang.RowHeadersVisible = False
        Me.dgv_StokBarang.Size = New System.Drawing.Size(943, 569)
        Me.dgv_StokBarang.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 44
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Kode Barang"
        Me.Column2.MinimumWidth = 117
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 117
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Nama"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Satuan"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 78
        '
        'Column4
        '
        Me.Column4.HeaderText = "Harga Beli"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Harga Jual"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 93
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Stok"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 61
        '
        'Column10
        '
        Me.Column10.HeaderText = "Min Stok"
        Me.Column10.Name = "Column10"
        '
        'colSupplierID
        '
        Me.colSupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierID.HeaderText = "Supplier ID"
        Me.colSupplierID.Name = "colSupplierID"
        Me.colSupplierID.ReadOnly = True
        Me.colSupplierID.Width = 95
        '
        'colSupplierNama
        '
        Me.colSupplierNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierNama.HeaderText = "Nama Supplier"
        Me.colSupplierNama.Name = "colSupplierNama"
        Me.colSupplierNama.ReadOnly = True
        Me.colSupplierNama.Width = 115
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(943, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "*Double klik stok dan edit langsung"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_updateStock)
        Me.Panel4.Controls.Add(Me.txt_cariBrg)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(943, 50)
        Me.Panel4.TabIndex = 17
        '
        'btn_updateStock
        '
        Me.btn_updateStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_updateStock.FlatAppearance.BorderSize = 0
        Me.btn_updateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateStock.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_updateStock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_updateStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateStock.Location = New System.Drawing.Point(809, 11)
        Me.btn_updateStock.Name = "btn_updateStock"
        Me.btn_updateStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_updateStock.Size = New System.Drawing.Size(119, 26)
        Me.btn_updateStock.TabIndex = 49
        Me.btn_updateStock.Text = "Update Stock"
        Me.btn_updateStock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateStock.UseVisualStyleBackColor = False
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.rtf_notifStok)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(943, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 635)
        Me.Panel3.TabIndex = 18
        '
        'rtf_notifStok
        '
        Me.rtf_notifStok.BackColor = System.Drawing.SystemColors.Window
        Me.rtf_notifStok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtf_notifStok.Location = New System.Drawing.Point(13, 36)
        Me.rtf_notifStok.Name = "rtf_notifStok"
        Me.rtf_notifStok.Size = New System.Drawing.Size(240, 569)
        Me.rtf_notifStok.TabIndex = 26
        Me.rtf_notifStok.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 1)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(44, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notifikasi Stok Barang"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_stokMenipisSaja)
        Me.TabPage2.Controls.Add(Me.headerSelectAll)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Low Stock"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_stokMenipisSaja
        '
        Me.dgv_stokMenipisSaja.AllowUserToAddRows = False
        Me.dgv_stokMenipisSaja.AllowUserToDeleteRows = False
        Me.dgv_stokMenipisSaja.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_stokMenipisSaja.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_stokMenipisSaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_stokMenipisSaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_stokMenipisSaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colPilih, Me.colKodeBarangLowStok, Me.colNamaBarangLowStok, Me.colSatuanBarangLowStok, Me.colHargaBeli, Me.colHargaBarangLowStok, Me.colStokBarangLowStok, Me.colMinStokBarangLowStok, Me.colSupplierIDLowStock, Me.colSupplierNamaLowStock, Me.colAddLowStock})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_stokMenipisSaja.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_stokMenipisSaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_stokMenipisSaja.Location = New System.Drawing.Point(3, 88)
        Me.dgv_stokMenipisSaja.Name = "dgv_stokMenipisSaja"
        Me.dgv_stokMenipisSaja.RowHeadersVisible = False
        Me.dgv_stokMenipisSaja.Size = New System.Drawing.Size(1204, 544)
        Me.dgv_stokMenipisSaja.TabIndex = 27
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
        Me.colStokBarangLowStok.Width = 61
        '
        'colMinStokBarangLowStok
        '
        Me.colMinStokBarangLowStok.HeaderText = "Min Stok"
        Me.colMinStokBarangLowStok.Name = "colMinStokBarangLowStok"
        Me.colMinStokBarangLowStok.ReadOnly = True
        '
        'colSupplierIDLowStock
        '
        Me.colSupplierIDLowStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierIDLowStock.HeaderText = "Supplier ID"
        Me.colSupplierIDLowStock.Name = "colSupplierIDLowStock"
        Me.colSupplierIDLowStock.ReadOnly = True
        Me.colSupplierIDLowStock.Width = 103
        '
        'colSupplierNamaLowStock
        '
        Me.colSupplierNamaLowStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierNamaLowStock.HeaderText = "Nama Supplier"
        Me.colSupplierNamaLowStock.Name = "colSupplierNamaLowStock"
        Me.colSupplierNamaLowStock.Width = 126
        '
        'colAddLowStock
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.colAddLowStock.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAddLowStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colAddLowStock.HeaderText = "Aksi"
        Me.colAddLowStock.Name = "colAddLowStock"
        Me.colAddLowStock.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAddLowStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colAddLowStock.Text = "+ Restock"
        Me.colAddLowStock.UseColumnTextForButtonValue = True
        '
        'headerSelectAll
        '
        Me.headerSelectAll.Controls.Add(Me.btnRestockSemua)
        Me.headerSelectAll.Controls.Add(Me.cbo_selectAllLowStock)
        Me.headerSelectAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerSelectAll.Location = New System.Drawing.Point(3, 53)
        Me.headerSelectAll.Name = "headerSelectAll"
        Me.headerSelectAll.Size = New System.Drawing.Size(1204, 35)
        Me.headerSelectAll.TabIndex = 29
        '
        'btnRestockSemua
        '
        Me.btnRestockSemua.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnRestockSemua.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnRestockSemua.Location = New System.Drawing.Point(125, 4)
        Me.btnRestockSemua.Name = "btnRestockSemua"
        Me.btnRestockSemua.Size = New System.Drawing.Size(157, 26)
        Me.btnRestockSemua.TabIndex = 30
        Me.btnRestockSemua.Text = "➕ Restock Semua"
        Me.btnRestockSemua.UseVisualStyleBackColor = True
        '
        'cbo_selectAllLowStock
        '
        Me.cbo_selectAllLowStock.AutoSize = True
        Me.cbo_selectAllLowStock.Location = New System.Drawing.Point(18, 7)
        Me.cbo_selectAllLowStock.Name = "cbo_selectAllLowStock"
        Me.cbo_selectAllLowStock.Size = New System.Drawing.Size(99, 22)
        Me.cbo_selectAllLowStock.TabIndex = 0
        Me.cbo_selectAllLowStock.Text = "Pilih Semua"
        Me.cbo_selectAllLowStock.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_ResetFilter)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cbo_filterbySupplier)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 50)
        Me.Panel2.TabIndex = 28
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Filter by Supplier:"
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
        'frm_ManageStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 718)
        Me.Name = "frm_ManageStok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ManageStok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_StokBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_stokMenipisSaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerSelectAll.ResumeLayout(False)
        Me.headerSelectAll.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents closeBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKembali As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label14 As Label
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
    Friend WithEvents dgv_StokBarang As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariBrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_updateStock As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rtf_notifStok As RichTextBox
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_stokMenipisSaja As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbo_filterbySupplier As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_ResetFilter As Button
    Friend WithEvents headerSelectAll As Panel
    Friend WithEvents cbo_selectAllLowStock As CheckBox
    Friend WithEvents btnRestockSemua As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierID As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierNama As DataGridViewTextBoxColumn
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
    Friend WithEvents colAddLowStock As DataGridViewButtonColumn
End Class
