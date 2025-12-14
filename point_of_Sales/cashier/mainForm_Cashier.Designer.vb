<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm_Cashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm_Cashier))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btn_tmbhDetJual = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtjenisPenjualan = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_catatan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_totalQty = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_danaDiterima = New System.Windows.Forms.TextBox()
        Me.cbo_metodePembayaran = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btn_simpanPenjualan = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_kembalianLangsung = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbo_statusPenjualan = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_hargaSatuan = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_Qty = New System.Windows.Forms.Label()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.lbl_noPenjualan = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txt_satuanBrg = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_namaBrg = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_brg = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hrga = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_detailPenjualan = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_tglJual = New System.Windows.Forms.DateTimePicker()
        Me.txt_noPenjualan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_listPenjualanPending = New System.Windows.Forms.DataGridView()
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
        Me.lbl_jenisJualPending = New System.Windows.Forms.Label()
        Me.lbl_catatanPending = New System.Windows.Forms.Label()
        Me.lbl_kembalianPending = New System.Windows.Forms.Label()
        Me.lbl_danaDiterimaPending = New System.Windows.Forms.Label()
        Me.pnl_listDetail = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rtb_detailPenjualan = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_statusJualPending = New System.Windows.Forms.Label()
        Me.lbl_metodeJualPending = New System.Windows.Forms.Label()
        Me.lbl_totalJualPending = New System.Windows.Forms.Label()
        Me.lbl_tglJualPending = New System.Windows.Forms.Label()
        Me.lbl_noJualPending = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_clearPenjualanPending = New System.Windows.Forms.Button()
        Me.btn_updateLunasPenjualan = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detailPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_listPenjualanPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_listDetail.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(148, 768)
        Me.Panel1.TabIndex = 4
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 695)
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
        Me.btnSemuaListPenjualan.BackColor = System.Drawing.SystemColors.Window
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
        Me.btnPOS_Kasir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
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
        'btn_tmbhDetJual
        '
        Me.btn_tmbhDetJual.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_tmbhDetJual.FlatAppearance.BorderSize = 0
        Me.btn_tmbhDetJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tmbhDetJual.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_tmbhDetJual.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_tmbhDetJual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetJual.Location = New System.Drawing.Point(16, 370)
        Me.btn_tmbhDetJual.Name = "btn_tmbhDetJual"
        Me.btn_tmbhDetJual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhDetJual.Size = New System.Drawing.Size(196, 29)
        Me.btn_tmbhDetJual.TabIndex = 50
        Me.btn_tmbhDetJual.Text = "➕ Tambah Barang"
        Me.btn_tmbhDetJual.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetJual.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.closeBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(148, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1218, 69)
        Me.Panel2.TabIndex = 24
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
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtjenisPenjualan)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.dtp_tglJual)
        Me.TabPage1.Controls.Add(Me.txt_noPenjualan)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Penjualan Baru"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtjenisPenjualan
        '
        Me.txtjenisPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtjenisPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtjenisPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjenisPenjualan.Location = New System.Drawing.Point(668, 28)
        Me.txtjenisPenjualan.Name = "txtjenisPenjualan"
        Me.txtjenisPenjualan.ReadOnly = True
        Me.txtjenisPenjualan.Size = New System.Drawing.Size(175, 19)
        Me.txtjenisPenjualan.TabIndex = 41
        Me.txtjenisPenjualan.Text = "Langsung (In-Person)"
        Me.txtjenisPenjualan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Controls.Add(Me.txt_catatan)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lbl_totalQty)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.txt_danaDiterima)
        Me.Panel3.Controls.Add(Me.cbo_metodePembayaran)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.btn_simpanPenjualan)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.lbl_kembalianLangsung)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.cbo_statusPenjualan)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.lbl_subTotal)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lbl_hargaSatuan)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.lbl_Qty)
        Me.Panel3.Controls.Add(Me.lbl_grandTotal)
        Me.Panel3.Controls.Add(Me.lbl_noPenjualan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(865, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 654)
        Me.Panel3.TabIndex = 39
        '
        'txt_catatan
        '
        Me.txt_catatan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_catatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_catatan.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_catatan.Location = New System.Drawing.Point(143, 475)
        Me.txt_catatan.Multiline = True
        Me.txt_catatan.Name = "txt_catatan"
        Me.txt_catatan.Size = New System.Drawing.Size(180, 63)
        Me.txt_catatan.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(66, 479)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Catatan:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalQty
        '
        Me.lbl_totalQty.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_totalQty.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbl_totalQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_totalQty.Location = New System.Drawing.Point(23, 98)
        Me.lbl_totalQty.Name = "lbl_totalQty"
        Me.lbl_totalQty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_totalQty.Size = New System.Drawing.Size(295, 17)
        Me.lbl_totalQty.TabIndex = 64
        Me.lbl_totalQty.Text = "Total Barang:"
        Me.lbl_totalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(325, 2)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = resources.GetString("Label27.Text")
        '
        'txt_danaDiterima
        '
        Me.txt_danaDiterima.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_danaDiterima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_danaDiterima.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_danaDiterima.Location = New System.Drawing.Point(143, 278)
        Me.txt_danaDiterima.Name = "txt_danaDiterima"
        Me.txt_danaDiterima.Size = New System.Drawing.Size(180, 25)
        Me.txt_danaDiterima.TabIndex = 61
        '
        'cbo_metodePembayaran
        '
        Me.cbo_metodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_metodePembayaran.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbo_metodePembayaran.FormattingEnabled = True
        Me.cbo_metodePembayaran.Items.AddRange(New Object() {"Tunai", "Non-Tunai"})
        Me.cbo_metodePembayaran.Location = New System.Drawing.Point(143, 377)
        Me.cbo_metodePembayaran.Name = "cbo_metodePembayaran"
        Me.cbo_metodePembayaran.Size = New System.Drawing.Size(180, 26)
        Me.cbo_metodePembayaran.TabIndex = 59
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(28, 282)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 16)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Dana Diterima:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_simpanPenjualan
        '
        Me.btn_simpanPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_simpanPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpanPenjualan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanPenjualan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanPenjualan.Location = New System.Drawing.Point(12, 599)
        Me.btn_simpanPenjualan.Name = "btn_simpanPenjualan"
        Me.btn_simpanPenjualan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanPenjualan.Size = New System.Drawing.Size(325, 40)
        Me.btn_simpanPenjualan.TabIndex = 58
        Me.btn_simpanPenjualan.Text = "Konfirmasi 💸"
        Me.btn_simpanPenjualan.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(53, 336)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 16)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Kembalian:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_kembalianLangsung
        '
        Me.lbl_kembalianLangsung.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_kembalianLangsung.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_kembalianLangsung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_kembalianLangsung.Location = New System.Drawing.Point(143, 327)
        Me.lbl_kembalianLangsung.Name = "lbl_kembalianLangsung"
        Me.lbl_kembalianLangsung.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_kembalianLangsung.Size = New System.Drawing.Size(180, 27)
        Me.lbl_kembalianLangsung.TabIndex = 56
        Me.lbl_kembalianLangsung.Text = "00.00"
        Me.lbl_kembalianLangsung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label22.Location = New System.Drawing.Point(75, 433)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 16)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Status:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbo_statusPenjualan
        '
        Me.cbo_statusPenjualan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statusPenjualan.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbo_statusPenjualan.FormattingEnabled = True
        Me.cbo_statusPenjualan.Items.AddRange(New Object() {"Lunas", "Pending"})
        Me.cbo_statusPenjualan.Location = New System.Drawing.Point(143, 428)
        Me.cbo_statusPenjualan.Name = "cbo_statusPenjualan"
        Me.cbo_statusPenjualan.Size = New System.Drawing.Size(180, 26)
        Me.cbo_statusPenjualan.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(37, 382)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 16)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "Pembayaran:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(84, 238)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 16)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Total:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_subTotal.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_subTotal.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_subTotal.Location = New System.Drawing.Point(143, 229)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_subTotal.Size = New System.Drawing.Size(180, 27)
        Me.lbl_subTotal.TabIndex = 7
        Me.lbl_subTotal.Text = "00.00"
        Me.lbl_subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(31, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Harga Satuan:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_hargaSatuan
        '
        Me.lbl_hargaSatuan.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_hargaSatuan.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_hargaSatuan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_hargaSatuan.Location = New System.Drawing.Point(143, 182)
        Me.lbl_hargaSatuan.Name = "lbl_hargaSatuan"
        Me.lbl_hargaSatuan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_hargaSatuan.Size = New System.Drawing.Size(180, 27)
        Me.lbl_hargaSatuan.TabIndex = 5
        Me.lbl_hargaSatuan.Text = "00.00"
        Me.lbl_hargaSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(44, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Qty Barang:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Qty
        '
        Me.lbl_Qty.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_Qty.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Qty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Qty.Location = New System.Drawing.Point(143, 145)
        Me.lbl_Qty.Name = "lbl_Qty"
        Me.lbl_Qty.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Qty.Size = New System.Drawing.Size(180, 27)
        Me.lbl_Qty.TabIndex = 3
        Me.lbl_Qty.Text = "00"
        Me.lbl_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_grandTotal.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_grandTotal.Location = New System.Drawing.Point(23, 62)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_grandTotal.Size = New System.Drawing.Size(300, 33)
        Me.lbl_grandTotal.TabIndex = 1
        Me.lbl_grandTotal.Text = "00.00"
        Me.lbl_grandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_noPenjualan
        '
        Me.lbl_noPenjualan.BackColor = System.Drawing.Color.Transparent
        Me.lbl_noPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noPenjualan.Location = New System.Drawing.Point(3, 15)
        Me.lbl_noPenjualan.Name = "lbl_noPenjualan"
        Me.lbl_noPenjualan.Size = New System.Drawing.Size(339, 25)
        Me.lbl_noPenjualan.TabIndex = 0
        Me.lbl_noPenjualan.Text = "-"
        Me.lbl_noPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.txt_satuanBrg)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_namaBrg)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cbo_brg)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_subTotal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_hrga)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_qty)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_tmbhDetJual)
        Me.GroupBox2.Controls.Add(Me.dgv_detailPenjualan)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(816, 569)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(16, 499)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(196, 40)
        Me.btnCancel.TabIndex = 67
        Me.btnCancel.Text = "Cancel 🗑️"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txt_satuanBrg
        '
        Me.txt_satuanBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_satuanBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuanBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_satuanBrg.Location = New System.Drawing.Point(16, 214)
        Me.txt_satuanBrg.Name = "txt_satuanBrg"
        Me.txt_satuanBrg.ReadOnly = True
        Me.txt_satuanBrg.Size = New System.Drawing.Size(196, 26)
        Me.txt_satuanBrg.TabIndex = 63
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(519, 25)
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
        Me.txt_namaBrg.Location = New System.Drawing.Point(16, 101)
        Me.txt_namaBrg.Name = "txt_namaBrg"
        Me.txt_namaBrg.ReadOnly = True
        Me.txt_namaBrg.Size = New System.Drawing.Size(196, 26)
        Me.txt_namaBrg.TabIndex = 61
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Nama Barang:"
        '
        'cbo_brg
        '
        Me.cbo_brg.FormattingEnabled = True
        Me.cbo_brg.Location = New System.Drawing.Point(16, 44)
        Me.cbo_brg.Name = "cbo_brg"
        Me.cbo_brg.Size = New System.Drawing.Size(196, 26)
        Me.cbo_brg.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 195)
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
        Me.txt_subTotal.Location = New System.Drawing.Point(16, 327)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.ReadOnly = True
        Me.txt_subTotal.Size = New System.Drawing.Size(196, 26)
        Me.txt_subTotal.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Subtotal:"
        '
        'txt_hrga
        '
        Me.txt_hrga.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrga.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrga.Location = New System.Drawing.Point(16, 272)
        Me.txt_hrga.Name = "txt_hrga"
        Me.txt_hrga.ReadOnly = True
        Me.txt_hrga.Size = New System.Drawing.Size(196, 26)
        Me.txt_hrga.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Harga per Satuan:"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(16, 156)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(196, 26)
        Me.txt_qty.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Kode Barang:"
        '
        'dgv_detailPenjualan
        '
        Me.dgv_detailPenjualan.AllowUserToAddRows = False
        Me.dgv_detailPenjualan.AllowUserToDeleteRows = False
        Me.dgv_detailPenjualan.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detailPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detailPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colKodeBrg, Me.colNmaBrg, Me.colQty, Me.colSatuan, Me.colHarga, Me.colSubtotal})
        Me.dgv_detailPenjualan.Location = New System.Drawing.Point(226, 44)
        Me.dgv_detailPenjualan.Name = "dgv_detailPenjualan"
        Me.dgv_detailPenjualan.ReadOnly = True
        Me.dgv_detailPenjualan.RowHeadersVisible = False
        Me.dgv_detailPenjualan.Size = New System.Drawing.Size(568, 495)
        Me.dgv_detailPenjualan.TabIndex = 0
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
        Me.colKodeBrg.HeaderText = "Kode"
        Me.colKodeBrg.Name = "colKodeBrg"
        Me.colKodeBrg.ReadOnly = True
        Me.colKodeBrg.Width = 66
        '
        'colNmaBrg
        '
        Me.colNmaBrg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNmaBrg.HeaderText = "Nama"
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
        'dtp_tglJual
        '
        Me.dtp_tglJual.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_tglJual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglJual.Location = New System.Drawing.Point(157, 24)
        Me.dtp_tglJual.Name = "dtp_tglJual"
        Me.dtp_tglJual.Size = New System.Drawing.Size(175, 25)
        Me.dtp_tglJual.TabIndex = 32
        '
        'txt_noPenjualan
        '
        Me.txt_noPenjualan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_noPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_noPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noPenjualan.Location = New System.Drawing.Point(468, 24)
        Me.txt_noPenjualan.Name = "txt_noPenjualan"
        Me.txt_noPenjualan.ReadOnly = True
        Me.txt_noPenjualan.Size = New System.Drawing.Size(175, 26)
        Me.txt_noPenjualan.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(19, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tanggal Penjualan:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label17.Location = New System.Drawing.Point(359, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 18)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "No. Penjualan:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_listPenjualanPending)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List Penjualan PENDING"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_listPenjualanPending
        '
        Me.dgv_listPenjualanPending.AllowUserToAddRows = False
        Me.dgv_listPenjualanPending.AllowUserToDeleteRows = False
        Me.dgv_listPenjualanPending.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_listPenjualanPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listPenjualanPending.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listPenjualanPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listPenjualanPending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNmr, Me.colNoPenjualan, Me.colJenis, Me.colTglPembelian, Me.colTotalPenjualan, Me.colDanaDiterima, Me.colKembalian, Me.colMetodePembayaran, Me.colCatatan})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listPenjualanPending.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listPenjualanPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_listPenjualanPending.Location = New System.Drawing.Point(3, 53)
        Me.dgv_listPenjualanPending.Name = "dgv_listPenjualanPending"
        Me.dgv_listPenjualanPending.ReadOnly = True
        Me.dgv_listPenjualanPending.RowHeadersVisible = False
        Me.dgv_listPenjualanPending.Size = New System.Drawing.Size(812, 598)
        Me.dgv_listPenjualanPending.TabIndex = 21
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
        Me.Panel4.Size = New System.Drawing.Size(812, 50)
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
        Me.Panel5.Controls.Add(Me.lbl_jenisJualPending)
        Me.Panel5.Controls.Add(Me.lbl_catatanPending)
        Me.Panel5.Controls.Add(Me.lbl_kembalianPending)
        Me.Panel5.Controls.Add(Me.lbl_danaDiterimaPending)
        Me.Panel5.Controls.Add(Me.pnl_listDetail)
        Me.Panel5.Controls.Add(Me.lbl_statusJualPending)
        Me.Panel5.Controls.Add(Me.lbl_metodeJualPending)
        Me.Panel5.Controls.Add(Me.lbl_totalJualPending)
        Me.Panel5.Controls.Add(Me.lbl_tglJualPending)
        Me.Panel5.Controls.Add(Me.lbl_noJualPending)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(815, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(392, 648)
        Me.Panel5.TabIndex = 23
        '
        'lbl_jenisJualPending
        '
        Me.lbl_jenisJualPending.AutoSize = True
        Me.lbl_jenisJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jenisJualPending.Location = New System.Drawing.Point(11, 255)
        Me.lbl_jenisJualPending.Name = "lbl_jenisJualPending"
        Me.lbl_jenisJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_jenisJualPending.TabIndex = 39
        Me.lbl_jenisJualPending.Text = "-"
        '
        'lbl_catatanPending
        '
        Me.lbl_catatanPending.AutoSize = True
        Me.lbl_catatanPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_catatanPending.Location = New System.Drawing.Point(11, 228)
        Me.lbl_catatanPending.Name = "lbl_catatanPending"
        Me.lbl_catatanPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_catatanPending.TabIndex = 38
        Me.lbl_catatanPending.Text = "-"
        '
        'lbl_kembalianPending
        '
        Me.lbl_kembalianPending.AutoSize = True
        Me.lbl_kembalianPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kembalianPending.Location = New System.Drawing.Point(11, 201)
        Me.lbl_kembalianPending.Name = "lbl_kembalianPending"
        Me.lbl_kembalianPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_kembalianPending.TabIndex = 37
        Me.lbl_kembalianPending.Text = "-"
        '
        'lbl_danaDiterimaPending
        '
        Me.lbl_danaDiterimaPending.AutoSize = True
        Me.lbl_danaDiterimaPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_danaDiterimaPending.Location = New System.Drawing.Point(11, 174)
        Me.lbl_danaDiterimaPending.Name = "lbl_danaDiterimaPending"
        Me.lbl_danaDiterimaPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_danaDiterimaPending.TabIndex = 36
        Me.lbl_danaDiterimaPending.Text = "-"
        '
        'pnl_listDetail
        '
        Me.pnl_listDetail.Controls.Add(Me.Label13)
        Me.pnl_listDetail.Controls.Add(Me.rtb_detailPenjualan)
        Me.pnl_listDetail.Controls.Add(Me.Label14)
        Me.pnl_listDetail.Controls.Add(Me.Label20)
        Me.pnl_listDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_listDetail.Location = New System.Drawing.Point(0, 281)
        Me.pnl_listDetail.Name = "pnl_listDetail"
        Me.pnl_listDetail.Size = New System.Drawing.Size(390, 318)
        Me.pnl_listDetail.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(390, 1)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = resources.GetString("Label13.Text")
        '
        'rtb_detailPenjualan
        '
        Me.rtb_detailPenjualan.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_detailPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_detailPenjualan.Location = New System.Drawing.Point(14, 42)
        Me.rtb_detailPenjualan.Name = "rtb_detailPenjualan"
        Me.rtb_detailPenjualan.ReadOnly = True
        Me.rtb_detailPenjualan.Size = New System.Drawing.Size(362, 270)
        Me.rtb_detailPenjualan.TabIndex = 32
        Me.rtb_detailPenjualan.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label14.Location = New System.Drawing.Point(131, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 18)
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
        Me.Label20.Size = New System.Drawing.Size(390, 1)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = resources.GetString("Label20.Text")
        '
        'lbl_statusJualPending
        '
        Me.lbl_statusJualPending.AutoSize = True
        Me.lbl_statusJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusJualPending.Location = New System.Drawing.Point(11, 147)
        Me.lbl_statusJualPending.Name = "lbl_statusJualPending"
        Me.lbl_statusJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusJualPending.TabIndex = 31
        Me.lbl_statusJualPending.Text = "-"
        '
        'lbl_metodeJualPending
        '
        Me.lbl_metodeJualPending.AutoSize = True
        Me.lbl_metodeJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodeJualPending.Location = New System.Drawing.Point(11, 120)
        Me.lbl_metodeJualPending.Name = "lbl_metodeJualPending"
        Me.lbl_metodeJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_metodeJualPending.TabIndex = 30
        Me.lbl_metodeJualPending.Text = "-"
        '
        'lbl_totalJualPending
        '
        Me.lbl_totalJualPending.AutoSize = True
        Me.lbl_totalJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalJualPending.Location = New System.Drawing.Point(11, 93)
        Me.lbl_totalJualPending.Name = "lbl_totalJualPending"
        Me.lbl_totalJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalJualPending.TabIndex = 29
        Me.lbl_totalJualPending.Text = "-"
        '
        'lbl_tglJualPending
        '
        Me.lbl_tglJualPending.AutoSize = True
        Me.lbl_tglJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tglJualPending.Location = New System.Drawing.Point(11, 66)
        Me.lbl_tglJualPending.Name = "lbl_tglJualPending"
        Me.lbl_tglJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tglJualPending.TabIndex = 28
        Me.lbl_tglJualPending.Text = "-"
        '
        'lbl_noJualPending
        '
        Me.lbl_noJualPending.AutoSize = True
        Me.lbl_noJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noJualPending.Location = New System.Drawing.Point(11, 39)
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
        Me.Label24.Size = New System.Drawing.Size(392, 18)
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
        Me.Label28.Size = New System.Drawing.Size(390, 1)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = resources.GetString("Label28.Text")
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btn_clearPenjualanPending)
        Me.Panel6.Controls.Add(Me.btn_updateLunasPenjualan)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 599)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(390, 47)
        Me.Panel6.TabIndex = 35
        '
        'btn_clearPenjualanPending
        '
        Me.btn_clearPenjualanPending.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_clearPenjualanPending.FlatAppearance.BorderSize = 0
        Me.btn_clearPenjualanPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearPenjualanPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearPenjualanPending.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clearPenjualanPending.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearPenjualanPending.Location = New System.Drawing.Point(200, 9)
        Me.btn_clearPenjualanPending.Name = "btn_clearPenjualanPending"
        Me.btn_clearPenjualanPending.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_clearPenjualanPending.Size = New System.Drawing.Size(180, 29)
        Me.btn_clearPenjualanPending.TabIndex = 49
        Me.btn_clearPenjualanPending.Text = "Clear 🧹"
        Me.btn_clearPenjualanPending.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearPenjualanPending.UseVisualStyleBackColor = False
        '
        'btn_updateLunasPenjualan
        '
        Me.btn_updateLunasPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btn_updateLunasPenjualan.FlatAppearance.BorderSize = 0
        Me.btn_updateLunasPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateLunasPenjualan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateLunasPenjualan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_updateLunasPenjualan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateLunasPenjualan.Location = New System.Drawing.Point(12, 9)
        Me.btn_updateLunasPenjualan.Name = "btn_updateLunasPenjualan"
        Me.btn_updateLunasPenjualan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_updateLunasPenjualan.Size = New System.Drawing.Size(180, 29)
        Me.btn_updateLunasPenjualan.TabIndex = 48
        Me.btn_updateLunasPenjualan.Text = "Update Sudah Lunas ✏️"
        Me.btn_updateLunasPenjualan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateLunasPenjualan.UseVisualStyleBackColor = False
        '
        'mainForm_Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 718)
        Me.Name = "mainForm_Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm_Cashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detailPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_listPenjualanPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_listDetail.ResumeLayout(False)
        Me.pnl_listDetail.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPOS_Kasir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_satuanBrg As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_namaBrg As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbo_brg As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hrga As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_tmbhDetJual As Button
    Friend WithEvents dgv_detailPenjualan As DataGridView
    Friend WithEvents txt_noPenjualan As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtp_tglJual As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_noPenjualan As Label
    Friend WithEvents lbl_grandTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_Qty As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_hargaSatuan As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_subTotal As Label
    Friend WithEvents cbo_statusPenjualan As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_kembalianLangsung As Label
    Friend WithEvents btn_simpanPenjualan As Button
    Friend WithEvents cbo_metodePembayaran As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_danaDiterima As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_totalQty As Label
    Friend WithEvents txt_catatan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrg As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrg As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents dgv_listPenjualanPending As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariPenjualan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnl_listDetail As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents rtb_detailPenjualan As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_statusJualPending As Label
    Friend WithEvents lbl_metodeJualPending As Label
    Friend WithEvents lbl_totalJualPending As Label
    Friend WithEvents lbl_tglJualPending As Label
    Friend WithEvents lbl_noJualPending As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_clearPenjualanPending As Button
    Friend WithEvents btn_updateLunasPenjualan As Button
    Friend WithEvents lbl_kembalianPending As Label
    Friend WithEvents lbl_danaDiterimaPending As Label
    Friend WithEvents lbl_catatanPending As Label
    Friend WithEvents lbl_jenisJualPending As Label
    Friend WithEvents txtjenisPenjualan As TextBox
    Friend WithEvents btnDelivery As Button
    Friend WithEvents colNmr As DataGridViewTextBoxColumn
    Friend WithEvents colNoPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colTglPembelian As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colDanaDiterima As DataGridViewTextBoxColumn
    Friend WithEvents colKembalian As DataGridViewTextBoxColumn
    Friend WithEvents colMetodePembayaran As DataGridViewTextBoxColumn
    Friend WithEvents colCatatan As DataGridViewTextBoxColumn
    Friend WithEvents btnPickup As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSemuaListPenjualan As Button
End Class
