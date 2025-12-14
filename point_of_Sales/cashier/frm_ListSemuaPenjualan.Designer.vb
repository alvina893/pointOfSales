<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListSemuaPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ListSemuaPenjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSemuaListPenjualan = New System.Windows.Forms.Button()
        Me.btnPickup = New System.Windows.Forms.Button()
        Me.btnPOS_Kasir = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_semuaPenjualan = New System.Windows.Forms.DataGridView()
        Me.colNmr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTglPembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDanaDiterima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMetodePembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cariPenjualan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_catatanPending = New System.Windows.Forms.RichTextBox()
        Me.lbl_alamatJualPending = New System.Windows.Forms.RichTextBox()
        Me.lbl_statusKirimPending = New System.Windows.Forms.Label()
        Me.lbl_kontakPending = New System.Windows.Forms.Label()
        Me.lbl_atasNamaPending = New System.Windows.Forms.Label()
        Me.lbl_jenisJualPending = New System.Windows.Forms.Label()
        Me.pnl_listDetail = New System.Windows.Forms.Panel()
        Me.dgv_tabelDetailPenjualan = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAjukanPengembalianKasir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_statusJualPending = New System.Windows.Forms.Label()
        Me.lbl_metodeJualPending = New System.Windows.Forms.Label()
        Me.lbl_totalJualPending = New System.Windows.Forms.Label()
        Me.lbl_tglJualPending = New System.Windows.Forms.Label()
        Me.lbl_noJualPending = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_semuaPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_listDetail.SuspendLayout()
        CType(Me.dgv_tabelDetailPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.closeBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(148, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1216, 69)
        Me.Panel2.TabIndex = 26
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(1157, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 22
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Kasir"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 749)
        Me.Panel1.TabIndex = 25
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(145, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(2, 768)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = resources.GetString("Label26.Text")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(13, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Inventory System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnLogout.MinimumSize = New System.Drawing.Size(142, 73)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(142, 73)
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
        Me.TableLayoutPanel1.Controls.Add(Me.btnSemuaListPenjualan, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPickup, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPOS_Kasir, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelivery, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 68)
        Me.TableLayoutPanel1.MaximumSize = New System.Drawing.Size(148, 280)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(148, 280)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(148, 280)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'btnSemuaListPenjualan
        '
        Me.btnSemuaListPenjualan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSemuaListPenjualan.FlatAppearance.BorderSize = 0
        Me.btnSemuaListPenjualan.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSemuaListPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSemuaListPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSemuaListPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSemuaListPenjualan.Location = New System.Drawing.Point(3, 213)
        Me.btnSemuaListPenjualan.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnSemuaListPenjualan.Name = "btnSemuaListPenjualan"
        Me.btnSemuaListPenjualan.Size = New System.Drawing.Size(142, 64)
        Me.btnSemuaListPenjualan.TabIndex = 26
        Me.btnSemuaListPenjualan.Text = "Barang Penjualan Bermasalah"
        Me.btnSemuaListPenjualan.UseVisualStyleBackColor = False
        '
        'btnPickup
        '
        Me.btnPickup.BackColor = System.Drawing.SystemColors.Window
        Me.btnPickup.FlatAppearance.BorderSize = 0
        Me.btnPickup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPickup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickup.Location = New System.Drawing.Point(3, 143)
        Me.btnPickup.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPickup.Name = "btnPickup"
        Me.btnPickup.Size = New System.Drawing.Size(142, 64)
        Me.btnPickup.TabIndex = 25
        Me.btnPickup.Text = "Pickup"
        Me.btnPickup.UseVisualStyleBackColor = False
        '
        'btnPOS_Kasir
        '
        Me.btnPOS_Kasir.BackColor = System.Drawing.SystemColors.Window
        Me.btnPOS_Kasir.FlatAppearance.BorderSize = 0
        Me.btnPOS_Kasir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPOS_Kasir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPOS_Kasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOS_Kasir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOS_Kasir.Location = New System.Drawing.Point(3, 3)
        Me.btnPOS_Kasir.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPOS_Kasir.Name = "btnPOS_Kasir"
        Me.btnPOS_Kasir.Size = New System.Drawing.Size(142, 64)
        Me.btnPOS_Kasir.TabIndex = 22
        Me.btnPOS_Kasir.Text = "Penjualan (Sales) In-Person"
        Me.btnPOS_Kasir.UseVisualStyleBackColor = False
        '
        'btnDelivery
        '
        Me.btnDelivery.FlatAppearance.BorderSize = 0
        Me.btnDelivery.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.Location = New System.Drawing.Point(3, 73)
        Me.btnDelivery.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(142, 64)
        Me.btnDelivery.TabIndex = 23
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 43)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "P O S"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(148, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1216, 680)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_semuaPenjualan)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1208, 635)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Master List Semua Penjualan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_semuaPenjualan
        '
        Me.dgv_semuaPenjualan.AllowUserToAddRows = False
        Me.dgv_semuaPenjualan.AllowUserToDeleteRows = False
        Me.dgv_semuaPenjualan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_semuaPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_semuaPenjualan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_semuaPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_semuaPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNmr, Me.colNoPenjualan, Me.colJenis, Me.colTglPembelian, Me.colTotalPenjualan, Me.colDanaDiterima, Me.colKembalian, Me.colMetodePembayaran, Me.colCatatan})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_semuaPenjualan.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_semuaPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_semuaPenjualan.Location = New System.Drawing.Point(3, 53)
        Me.dgv_semuaPenjualan.Name = "dgv_semuaPenjualan"
        Me.dgv_semuaPenjualan.ReadOnly = True
        Me.dgv_semuaPenjualan.RowHeadersVisible = False
        Me.dgv_semuaPenjualan.Size = New System.Drawing.Size(744, 579)
        Me.dgv_semuaPenjualan.TabIndex = 21
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
        'colNoPenjualan
        '
        Me.colNoPenjualan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNoPenjualan.HeaderText = "No. Penjualan"
        Me.colNoPenjualan.MinimumWidth = 154
        Me.colNoPenjualan.Name = "colNoPenjualan"
        Me.colNoPenjualan.ReadOnly = True
        '
        'colJenis
        '
        Me.colJenis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colJenis.HeaderText = "Jenis"
        Me.colJenis.Name = "colJenis"
        Me.colJenis.ReadOnly = True
        Me.colJenis.Visible = False
        '
        'colTglPembelian
        '
        Me.colTglPembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTglPembelian.HeaderText = "Tgl"
        Me.colTglPembelian.MinimumWidth = 85
        Me.colTglPembelian.Name = "colTglPembelian"
        Me.colTglPembelian.ReadOnly = True
        Me.colTglPembelian.Width = 85
        '
        'colTotalPenjualan
        '
        Me.colTotalPenjualan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTotalPenjualan.HeaderText = "Total"
        Me.colTotalPenjualan.MinimumWidth = 105
        Me.colTotalPenjualan.Name = "colTotalPenjualan"
        Me.colTotalPenjualan.ReadOnly = True
        '
        'colDanaDiterima
        '
        Me.colDanaDiterima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDanaDiterima.HeaderText = "Dana Diterima"
        Me.colDanaDiterima.Name = "colDanaDiterima"
        Me.colDanaDiterima.ReadOnly = True
        Me.colDanaDiterima.Visible = False
        '
        'colKembalian
        '
        Me.colKembalian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colKembalian.HeaderText = "Kembalian"
        Me.colKembalian.Name = "colKembalian"
        Me.colKembalian.ReadOnly = True
        Me.colKembalian.Visible = False
        '
        'colMetodePembayaran
        '
        Me.colMetodePembayaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMetodePembayaran.HeaderText = "Metode"
        Me.colMetodePembayaran.Name = "colMetodePembayaran"
        Me.colMetodePembayaran.ReadOnly = True
        Me.colMetodePembayaran.Width = 82
        '
        'colCatatan
        '
        Me.colCatatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCatatan.HeaderText = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.ReadOnly = True
        Me.colCatatan.Width = 84
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_cariPenjualan)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(744, 50)
        Me.Panel4.TabIndex = 22
        '
        'txt_cariPenjualan
        '
        Me.txt_cariPenjualan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_cariPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cariPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cariPenjualan.Location = New System.Drawing.Point(136, 12)
        Me.txt_cariPenjualan.Name = "txt_cariPenjualan"
        Me.txt_cariPenjualan.Size = New System.Drawing.Size(240, 26)
        Me.txt_cariPenjualan.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Search Penjualan:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Window
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_catatanPending)
        Me.Panel5.Controls.Add(Me.lbl_alamatJualPending)
        Me.Panel5.Controls.Add(Me.lbl_statusKirimPending)
        Me.Panel5.Controls.Add(Me.lbl_kontakPending)
        Me.Panel5.Controls.Add(Me.lbl_atasNamaPending)
        Me.Panel5.Controls.Add(Me.lbl_jenisJualPending)
        Me.Panel5.Controls.Add(Me.pnl_listDetail)
        Me.Panel5.Controls.Add(Me.lbl_statusJualPending)
        Me.Panel5.Controls.Add(Me.lbl_metodeJualPending)
        Me.Panel5.Controls.Add(Me.lbl_totalJualPending)
        Me.Panel5.Controls.Add(Me.lbl_tglJualPending)
        Me.Panel5.Controls.Add(Me.lbl_noJualPending)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(747, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(458, 629)
        Me.Panel5.TabIndex = 24
        '
        'lbl_catatanPending
        '
        Me.lbl_catatanPending.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_catatanPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_catatanPending.Location = New System.Drawing.Point(14, 189)
        Me.lbl_catatanPending.Name = "lbl_catatanPending"
        Me.lbl_catatanPending.ReadOnly = True
        Me.lbl_catatanPending.Size = New System.Drawing.Size(210, 42)
        Me.lbl_catatanPending.TabIndex = 46
        Me.lbl_catatanPending.Text = ""
        '
        'lbl_alamatJualPending
        '
        Me.lbl_alamatJualPending.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_alamatJualPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_alamatJualPending.Location = New System.Drawing.Point(244, 158)
        Me.lbl_alamatJualPending.Name = "lbl_alamatJualPending"
        Me.lbl_alamatJualPending.ReadOnly = True
        Me.lbl_alamatJualPending.Size = New System.Drawing.Size(200, 73)
        Me.lbl_alamatJualPending.TabIndex = 45
        Me.lbl_alamatJualPending.Text = ""
        '
        'lbl_statusKirimPending
        '
        Me.lbl_statusKirimPending.AutoSize = True
        Me.lbl_statusKirimPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusKirimPending.Location = New System.Drawing.Point(241, 128)
        Me.lbl_statusKirimPending.Name = "lbl_statusKirimPending"
        Me.lbl_statusKirimPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusKirimPending.TabIndex = 44
        Me.lbl_statusKirimPending.Text = "-"
        '
        'lbl_kontakPending
        '
        Me.lbl_kontakPending.AutoSize = True
        Me.lbl_kontakPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kontakPending.Location = New System.Drawing.Point(241, 98)
        Me.lbl_kontakPending.Name = "lbl_kontakPending"
        Me.lbl_kontakPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_kontakPending.TabIndex = 41
        Me.lbl_kontakPending.Text = "-"
        '
        'lbl_atasNamaPending
        '
        Me.lbl_atasNamaPending.AutoSize = True
        Me.lbl_atasNamaPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_atasNamaPending.Location = New System.Drawing.Point(241, 68)
        Me.lbl_atasNamaPending.Name = "lbl_atasNamaPending"
        Me.lbl_atasNamaPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_atasNamaPending.TabIndex = 40
        Me.lbl_atasNamaPending.Text = "-"
        '
        'lbl_jenisJualPending
        '
        Me.lbl_jenisJualPending.AutoSize = True
        Me.lbl_jenisJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jenisJualPending.Location = New System.Drawing.Point(241, 158)
        Me.lbl_jenisJualPending.Name = "lbl_jenisJualPending"
        Me.lbl_jenisJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_jenisJualPending.TabIndex = 39
        Me.lbl_jenisJualPending.Text = "-"
        '
        'pnl_listDetail
        '
        Me.pnl_listDetail.Controls.Add(Me.dgv_tabelDetailPenjualan)
        Me.pnl_listDetail.Controls.Add(Me.Label13)
        Me.pnl_listDetail.Controls.Add(Me.Label14)
        Me.pnl_listDetail.Controls.Add(Me.Label20)
        Me.pnl_listDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_listDetail.Location = New System.Drawing.Point(0, 227)
        Me.pnl_listDetail.Name = "pnl_listDetail"
        Me.pnl_listDetail.Size = New System.Drawing.Size(456, 400)
        Me.pnl_listDetail.TabIndex = 21
        '
        'dgv_tabelDetailPenjualan
        '
        Me.dgv_tabelDetailPenjualan.AllowUserToAddRows = False
        Me.dgv_tabelDetailPenjualan.AllowUserToDeleteRows = False
        Me.dgv_tabelDetailPenjualan.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_tabelDetailPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabelDetailPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colKodeBrg, Me.colNmaBrg, Me.colQty, Me.colSatuan, Me.colHarga, Me.colSubtotal, Me.colSupplierID, Me.colSupplierNama, Me.colAjukanPengembalianKasir})
        Me.dgv_tabelDetailPenjualan.Location = New System.Drawing.Point(0, 30)
        Me.dgv_tabelDetailPenjualan.Name = "dgv_tabelDetailPenjualan"
        Me.dgv_tabelDetailPenjualan.ReadOnly = True
        Me.dgv_tabelDetailPenjualan.RowHeadersVisible = False
        Me.dgv_tabelDetailPenjualan.Size = New System.Drawing.Size(456, 370)
        Me.dgv_tabelDetailPenjualan.TabIndex = 25
        '
        'colNo
        '
        Me.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNo.HeaderText = "#"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Width = 44
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
        Me.colNmaBrg.MinimumWidth = 150
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
        Me.colSatuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSatuan.HeaderText = "Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.ReadOnly = True
        Me.colSatuan.Width = 78
        '
        'colHarga
        '
        Me.colHarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHarga.HeaderText = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.ReadOnly = True
        Me.colHarga.Width = 72
        '
        'colSubtotal
        '
        Me.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.ReadOnly = True
        Me.colSubtotal.Width = 85
        '
        'colSupplierID
        '
        Me.colSupplierID.HeaderText = "Supplier ID"
        Me.colSupplierID.Name = "colSupplierID"
        Me.colSupplierID.ReadOnly = True
        '
        'colSupplierNama
        '
        Me.colSupplierNama.HeaderText = "Nama Supplier"
        Me.colSupplierNama.Name = "colSupplierNama"
        Me.colSupplierNama.ReadOnly = True
        '
        'colAjukanPengembalianKasir
        '
        Me.colAjukanPengembalianKasir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAjukanPengembalianKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colAjukanPengembalianKasir.HeaderText = "Aksi"
        Me.colAjukanPengembalianKasir.Name = "colAjukanPengembalianKasir"
        Me.colAjukanPengembalianKasir.ReadOnly = True
        Me.colAjukanPengembalianKasir.Text = "➕ Ajukan"
        Me.colAjukanPengembalianKasir.UseColumnTextForButtonValue = True
        Me.colAjukanPengembalianKasir.Width = 39
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(458, 1)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label14.Location = New System.Drawing.Point(1, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(454, 18)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Detail List Barang"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(0, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(458, 1)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = resources.GetString("Label20.Text")
        '
        'lbl_statusJualPending
        '
        Me.lbl_statusJualPending.AutoSize = True
        Me.lbl_statusJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusJualPending.Location = New System.Drawing.Point(11, 158)
        Me.lbl_statusJualPending.Name = "lbl_statusJualPending"
        Me.lbl_statusJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusJualPending.TabIndex = 31
        Me.lbl_statusJualPending.Text = "-"
        '
        'lbl_metodeJualPending
        '
        Me.lbl_metodeJualPending.AutoSize = True
        Me.lbl_metodeJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodeJualPending.Location = New System.Drawing.Point(11, 128)
        Me.lbl_metodeJualPending.Name = "lbl_metodeJualPending"
        Me.lbl_metodeJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_metodeJualPending.TabIndex = 30
        Me.lbl_metodeJualPending.Text = "-"
        '
        'lbl_totalJualPending
        '
        Me.lbl_totalJualPending.AutoSize = True
        Me.lbl_totalJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalJualPending.Location = New System.Drawing.Point(11, 98)
        Me.lbl_totalJualPending.Name = "lbl_totalJualPending"
        Me.lbl_totalJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalJualPending.TabIndex = 29
        Me.lbl_totalJualPending.Text = "-"
        '
        'lbl_tglJualPending
        '
        Me.lbl_tglJualPending.AutoSize = True
        Me.lbl_tglJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tglJualPending.Location = New System.Drawing.Point(11, 68)
        Me.lbl_tglJualPending.Name = "lbl_tglJualPending"
        Me.lbl_tglJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tglJualPending.TabIndex = 28
        Me.lbl_tglJualPending.Text = "-"
        '
        'lbl_noJualPending
        '
        Me.lbl_noJualPending.AutoSize = True
        Me.lbl_noJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noJualPending.Location = New System.Drawing.Point(11, 38)
        Me.lbl_noJualPending.Name = "lbl_noJualPending"
        Me.lbl_noJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_noJualPending.TabIndex = 27
        Me.lbl_noJualPending.Text = "-"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label24.Location = New System.Drawing.Point(-1, 3)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(455, 18)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "Informasi Penjualan"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(0, 26)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(458, 1)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = resources.GetString("Label28.Text")
        '
        'frm_ListSemuaPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 718)
        Me.Name = "frm_ListSemuaPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ListSemuaPenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_semuaPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_listDetail.ResumeLayout(False)
        CType(Me.dgv_tabelDetailPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSemuaListPenjualan As Button
    Friend WithEvents btnPickup As Button
    Friend WithEvents btnPOS_Kasir As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_semuaPenjualan As DataGridView
    Friend WithEvents colNmr As DataGridViewTextBoxColumn
    Friend WithEvents colNoPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colTglPembelian As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colDanaDiterima As DataGridViewTextBoxColumn
    Friend WithEvents colKembalian As DataGridViewTextBoxColumn
    Friend WithEvents colMetodePembayaran As DataGridViewTextBoxColumn
    Friend WithEvents colCatatan As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariPenjualan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_catatanPending As RichTextBox
    Friend WithEvents lbl_alamatJualPending As RichTextBox
    Friend WithEvents lbl_statusKirimPending As Label
    Friend WithEvents lbl_kontakPending As Label
    Friend WithEvents lbl_atasNamaPending As Label
    Friend WithEvents lbl_jenisJualPending As Label
    Friend WithEvents pnl_listDetail As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_statusJualPending As Label
    Friend WithEvents lbl_metodeJualPending As Label
    Friend WithEvents lbl_totalJualPending As Label
    Friend WithEvents lbl_tglJualPending As Label
    Friend WithEvents lbl_noJualPending As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents dgv_tabelDetailPenjualan As DataGridView
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrg As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrg As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierID As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierNama As DataGridViewTextBoxColumn
    Friend WithEvents colAjukanPengembalianKasir As DataGridViewButtonColumn
End Class
