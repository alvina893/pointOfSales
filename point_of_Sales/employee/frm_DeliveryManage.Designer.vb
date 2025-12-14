<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DeliveryManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DeliveryManage))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPickup = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnPengembalian_Karyawan = New System.Windows.Forms.Button()
        Me.btnStok = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_listDeliveryLunasPacking = New System.Windows.Forms.DataGridView()
        Me.colNmr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTglPembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDanaDiterima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMetodePembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAtasNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKontak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatusKirim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cariPenjualan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_catatanDeliveryLunas = New System.Windows.Forms.RichTextBox()
        Me.lbl_alamatJualDeliveryLunas = New System.Windows.Forms.RichTextBox()
        Me.lbl_statusKirimDeliveryLunas = New System.Windows.Forms.Label()
        Me.lbl_kontakDeliveryLunas = New System.Windows.Forms.Label()
        Me.lbl_atasNamaDeliveryLunas = New System.Windows.Forms.Label()
        Me.pnl_listDetail = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rtb_detailPenjualanDeliveryLunas = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_statusJualDeliveryLunas = New System.Windows.Forms.Label()
        Me.lbl_metodeJualDeliveryLunas = New System.Windows.Forms.Label()
        Me.lbl_totalJualDeliveryLunas = New System.Windows.Forms.Label()
        Me.lbl_tglJualDeliveryLunas = New System.Windows.Forms.Label()
        Me.lbl_noJualDeliveryLunas = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_clearPenjualanPending = New System.Windows.Forms.Button()
        Me.btn_updateLunasPenjualan = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_listDeliveryLunasPacking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_listDetail.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(1218, 69)
        Me.Panel2.TabIndex = 32
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
        Me.Label2.Size = New System.Drawing.Size(118, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Karyawan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 768)
        Me.Panel1.TabIndex = 31
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnPickup, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelivery, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPengembalian_Karyawan, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStok, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 68)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(148, 282)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'btnPickup
        '
        Me.btnPickup.BackColor = System.Drawing.SystemColors.Window
        Me.btnPickup.FlatAppearance.BorderSize = 0
        Me.btnPickup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPickup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickup.Location = New System.Drawing.Point(3, 213)
        Me.btnPickup.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPickup.Name = "btnPickup"
        Me.btnPickup.Size = New System.Drawing.Size(142, 64)
        Me.btnPickup.TabIndex = 26
        Me.btnPickup.Text = "Pickup"
        Me.btnPickup.UseVisualStyleBackColor = False
        '
        'btnDelivery
        '
        Me.btnDelivery.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDelivery.FlatAppearance.BorderSize = 0
        Me.btnDelivery.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.Location = New System.Drawing.Point(3, 143)
        Me.btnDelivery.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(142, 64)
        Me.btnDelivery.TabIndex = 25
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = False
        '
        'btnPengembalian_Karyawan
        '
        Me.btnPengembalian_Karyawan.BackColor = System.Drawing.SystemColors.Window
        Me.btnPengembalian_Karyawan.FlatAppearance.BorderSize = 0
        Me.btnPengembalian_Karyawan.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPengembalian_Karyawan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPengembalian_Karyawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPengembalian_Karyawan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPengembalian_Karyawan.Location = New System.Drawing.Point(3, 3)
        Me.btnPengembalian_Karyawan.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnPengembalian_Karyawan.Name = "btnPengembalian_Karyawan"
        Me.btnPengembalian_Karyawan.Size = New System.Drawing.Size(142, 64)
        Me.btnPengembalian_Karyawan.TabIndex = 22
        Me.btnPengembalian_Karyawan.Text = "Pengembalian"
        Me.btnPengembalian_Karyawan.UseVisualStyleBackColor = False
        '
        'btnStok
        '
        Me.btnStok.BackColor = System.Drawing.SystemColors.Window
        Me.btnStok.FlatAppearance.BorderSize = 0
        Me.btnStok.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStok.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStok.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStok.Location = New System.Drawing.Point(3, 73)
        Me.btnStok.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnStok.Name = "btnStok"
        Me.btnStok.Size = New System.Drawing.Size(142, 64)
        Me.btnStok.TabIndex = 23
        Me.btnStok.Text = "Stok Barang"
        Me.btnStok.UseVisualStyleBackColor = False
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
        Me.TabControl1.Size = New System.Drawing.Size(1218, 699)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_listDeliveryLunasPacking)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "List Delivery"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_listDeliveryLunasPacking
        '
        Me.dgv_listDeliveryLunasPacking.AllowUserToAddRows = False
        Me.dgv_listDeliveryLunasPacking.AllowUserToDeleteRows = False
        Me.dgv_listDeliveryLunasPacking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_listDeliveryLunasPacking.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listDeliveryLunasPacking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listDeliveryLunasPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listDeliveryLunasPacking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNmr, Me.colNoPenjualan, Me.colJenis, Me.colTglPembelian, Me.colTotalPenjualan, Me.colDanaDiterima, Me.colKembalian, Me.colMetodePembayaran, Me.colCatatan, Me.colAtasNama, Me.colKontak, Me.colAlamat, Me.colStatusKirim})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listDeliveryLunasPacking.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listDeliveryLunasPacking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_listDeliveryLunasPacking.Location = New System.Drawing.Point(3, 53)
        Me.dgv_listDeliveryLunasPacking.Name = "dgv_listDeliveryLunasPacking"
        Me.dgv_listDeliveryLunasPacking.ReadOnly = True
        Me.dgv_listDeliveryLunasPacking.RowHeadersVisible = False
        Me.dgv_listDeliveryLunasPacking.Size = New System.Drawing.Size(812, 598)
        Me.dgv_listDeliveryLunasPacking.TabIndex = 21
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
        Me.colNoPenjualan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNoPenjualan.HeaderText = "No. Penjualan"
        Me.colNoPenjualan.MinimumWidth = 154
        Me.colNoPenjualan.Name = "colNoPenjualan"
        Me.colNoPenjualan.ReadOnly = True
        Me.colNoPenjualan.Width = 154
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
        Me.colMetodePembayaran.HeaderText = "Pembayaran"
        Me.colMetodePembayaran.Name = "colMetodePembayaran"
        Me.colMetodePembayaran.ReadOnly = True
        Me.colMetodePembayaran.Width = 115
        '
        'colCatatan
        '
        Me.colCatatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCatatan.HeaderText = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.ReadOnly = True
        Me.colCatatan.Width = 84
        '
        'colAtasNama
        '
        Me.colAtasNama.HeaderText = "Atas Nama"
        Me.colAtasNama.Name = "colAtasNama"
        Me.colAtasNama.ReadOnly = True
        '
        'colKontak
        '
        Me.colKontak.HeaderText = "Kontak"
        Me.colKontak.Name = "colKontak"
        Me.colKontak.ReadOnly = True
        '
        'colAlamat
        '
        Me.colAlamat.HeaderText = "Alamat"
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.ReadOnly = True
        '
        'colStatusKirim
        '
        Me.colStatusKirim.HeaderText = "Status Kirim"
        Me.colStatusKirim.Name = "colStatusKirim"
        Me.colStatusKirim.ReadOnly = True
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
        Me.Panel5.Controls.Add(Me.lbl_catatanDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_alamatJualDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_statusKirimDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_kontakDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_atasNamaDeliveryLunas)
        Me.Panel5.Controls.Add(Me.pnl_listDetail)
        Me.Panel5.Controls.Add(Me.lbl_statusJualDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_metodeJualDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_totalJualDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_tglJualDeliveryLunas)
        Me.Panel5.Controls.Add(Me.lbl_noJualDeliveryLunas)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(815, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(392, 648)
        Me.Panel5.TabIndex = 23
        '
        'lbl_catatanDeliveryLunas
        '
        Me.lbl_catatanDeliveryLunas.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_catatanDeliveryLunas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_catatanDeliveryLunas.Location = New System.Drawing.Point(14, 212)
        Me.lbl_catatanDeliveryLunas.Name = "lbl_catatanDeliveryLunas"
        Me.lbl_catatanDeliveryLunas.ReadOnly = True
        Me.lbl_catatanDeliveryLunas.Size = New System.Drawing.Size(178, 61)
        Me.lbl_catatanDeliveryLunas.TabIndex = 46
        Me.lbl_catatanDeliveryLunas.Text = ""
        '
        'lbl_alamatJualDeliveryLunas
        '
        Me.lbl_alamatJualDeliveryLunas.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_alamatJualDeliveryLunas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_alamatJualDeliveryLunas.Location = New System.Drawing.Point(200, 186)
        Me.lbl_alamatJualDeliveryLunas.Name = "lbl_alamatJualDeliveryLunas"
        Me.lbl_alamatJualDeliveryLunas.Size = New System.Drawing.Size(177, 87)
        Me.lbl_alamatJualDeliveryLunas.TabIndex = 45
        Me.lbl_alamatJualDeliveryLunas.Text = ""
        '
        'lbl_statusKirimDeliveryLunas
        '
        Me.lbl_statusKirimDeliveryLunas.AutoSize = True
        Me.lbl_statusKirimDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusKirimDeliveryLunas.Location = New System.Drawing.Point(197, 149)
        Me.lbl_statusKirimDeliveryLunas.Name = "lbl_statusKirimDeliveryLunas"
        Me.lbl_statusKirimDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusKirimDeliveryLunas.TabIndex = 44
        Me.lbl_statusKirimDeliveryLunas.Text = "-"
        '
        'lbl_kontakDeliveryLunas
        '
        Me.lbl_kontakDeliveryLunas.AutoSize = True
        Me.lbl_kontakDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kontakDeliveryLunas.Location = New System.Drawing.Point(197, 112)
        Me.lbl_kontakDeliveryLunas.Name = "lbl_kontakDeliveryLunas"
        Me.lbl_kontakDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_kontakDeliveryLunas.TabIndex = 41
        Me.lbl_kontakDeliveryLunas.Text = "-"
        '
        'lbl_atasNamaDeliveryLunas
        '
        Me.lbl_atasNamaDeliveryLunas.AutoSize = True
        Me.lbl_atasNamaDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_atasNamaDeliveryLunas.Location = New System.Drawing.Point(197, 73)
        Me.lbl_atasNamaDeliveryLunas.Name = "lbl_atasNamaDeliveryLunas"
        Me.lbl_atasNamaDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_atasNamaDeliveryLunas.TabIndex = 40
        Me.lbl_atasNamaDeliveryLunas.Text = "-"
        '
        'pnl_listDetail
        '
        Me.pnl_listDetail.Controls.Add(Me.Label13)
        Me.pnl_listDetail.Controls.Add(Me.rtb_detailPenjualanDeliveryLunas)
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
        'rtb_detailPenjualanDeliveryLunas
        '
        Me.rtb_detailPenjualanDeliveryLunas.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_detailPenjualanDeliveryLunas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_detailPenjualanDeliveryLunas.Location = New System.Drawing.Point(14, 39)
        Me.rtb_detailPenjualanDeliveryLunas.Name = "rtb_detailPenjualanDeliveryLunas"
        Me.rtb_detailPenjualanDeliveryLunas.ReadOnly = True
        Me.rtb_detailPenjualanDeliveryLunas.Size = New System.Drawing.Size(362, 270)
        Me.rtb_detailPenjualanDeliveryLunas.TabIndex = 32
        Me.rtb_detailPenjualanDeliveryLunas.Text = ""
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
        'lbl_statusJualDeliveryLunas
        '
        Me.lbl_statusJualDeliveryLunas.AutoSize = True
        Me.lbl_statusJualDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusJualDeliveryLunas.Location = New System.Drawing.Point(11, 186)
        Me.lbl_statusJualDeliveryLunas.Name = "lbl_statusJualDeliveryLunas"
        Me.lbl_statusJualDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusJualDeliveryLunas.TabIndex = 31
        Me.lbl_statusJualDeliveryLunas.Text = "-"
        '
        'lbl_metodeJualDeliveryLunas
        '
        Me.lbl_metodeJualDeliveryLunas.AutoSize = True
        Me.lbl_metodeJualDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodeJualDeliveryLunas.Location = New System.Drawing.Point(11, 149)
        Me.lbl_metodeJualDeliveryLunas.Name = "lbl_metodeJualDeliveryLunas"
        Me.lbl_metodeJualDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_metodeJualDeliveryLunas.TabIndex = 30
        Me.lbl_metodeJualDeliveryLunas.Text = "-"
        '
        'lbl_totalJualDeliveryLunas
        '
        Me.lbl_totalJualDeliveryLunas.AutoSize = True
        Me.lbl_totalJualDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalJualDeliveryLunas.Location = New System.Drawing.Point(11, 112)
        Me.lbl_totalJualDeliveryLunas.Name = "lbl_totalJualDeliveryLunas"
        Me.lbl_totalJualDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalJualDeliveryLunas.TabIndex = 29
        Me.lbl_totalJualDeliveryLunas.Text = "-"
        '
        'lbl_tglJualDeliveryLunas
        '
        Me.lbl_tglJualDeliveryLunas.AutoSize = True
        Me.lbl_tglJualDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tglJualDeliveryLunas.Location = New System.Drawing.Point(11, 75)
        Me.lbl_tglJualDeliveryLunas.Name = "lbl_tglJualDeliveryLunas"
        Me.lbl_tglJualDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tglJualDeliveryLunas.TabIndex = 28
        Me.lbl_tglJualDeliveryLunas.Text = "-"
        '
        'lbl_noJualDeliveryLunas
        '
        Me.lbl_noJualDeliveryLunas.AutoSize = True
        Me.lbl_noJualDeliveryLunas.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noJualDeliveryLunas.Location = New System.Drawing.Point(11, 38)
        Me.lbl_noJualDeliveryLunas.Name = "lbl_noJualDeliveryLunas"
        Me.lbl_noJualDeliveryLunas.Size = New System.Drawing.Size(13, 18)
        Me.lbl_noJualDeliveryLunas.TabIndex = 27
        Me.lbl_noJualDeliveryLunas.Text = "-"
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
        Me.btn_updateLunasPenjualan.Text = "Update ✏️"
        Me.btn_updateLunasPenjualan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateLunasPenjualan.UseVisualStyleBackColor = False
        '
        'frm_DeliveryManage
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
        Me.Name = "frm_DeliveryManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DeliveryManage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_listDeliveryLunasPacking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_listDetail.ResumeLayout(False)
        Me.pnl_listDetail.PerformLayout()
        Me.Panel6.ResumeLayout(False)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPickup As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnPengembalian_Karyawan As Button
    Friend WithEvents btnStok As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_listDeliveryLunasPacking As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariPenjualan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_statusKirimDeliveryLunas As Label
    Friend WithEvents lbl_kontakDeliveryLunas As Label
    Friend WithEvents lbl_atasNamaDeliveryLunas As Label
    Friend WithEvents pnl_listDetail As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents rtb_detailPenjualanDeliveryLunas As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_statusJualDeliveryLunas As Label
    Friend WithEvents lbl_metodeJualDeliveryLunas As Label
    Friend WithEvents lbl_totalJualDeliveryLunas As Label
    Friend WithEvents lbl_tglJualDeliveryLunas As Label
    Friend WithEvents lbl_noJualDeliveryLunas As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_clearPenjualanPending As Button
    Friend WithEvents btn_updateLunasPenjualan As Button
    Friend WithEvents colNmr As DataGridViewTextBoxColumn
    Friend WithEvents colNoPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colTglPembelian As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colDanaDiterima As DataGridViewTextBoxColumn
    Friend WithEvents colKembalian As DataGridViewTextBoxColumn
    Friend WithEvents colMetodePembayaran As DataGridViewTextBoxColumn
    Friend WithEvents colCatatan As DataGridViewTextBoxColumn
    Friend WithEvents colAtasNama As DataGridViewTextBoxColumn
    Friend WithEvents colKontak As DataGridViewTextBoxColumn
    Friend WithEvents colAlamat As DataGridViewTextBoxColumn
    Friend WithEvents colStatusKirim As DataGridViewTextBoxColumn
    Friend WithEvents lbl_alamatJualDeliveryLunas As RichTextBox
    Friend WithEvents lbl_catatanDeliveryLunas As RichTextBox
End Class
