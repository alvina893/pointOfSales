<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManagePenjualanDelivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManagePenjualanDelivery))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnPOS_Kasir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.colAtasNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKontak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatusKirim = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelDelivery = New System.Windows.Forms.Button()
        Me.pic_barcodePenjualanDelivery = New System.Windows.Forms.PictureBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cbo_statusDelivery = New System.Windows.Forms.ComboBox()
        Me.txt_alamatDelivery = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_kontakDelivery = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_atasNamaDelivery = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtJenisDelivery = New System.Windows.Forms.TextBox()
        Me.txt_noPenjualanDelivery = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_catatanDelivery = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_totalQtyDelivery = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbo_metodePembayaranDelivery = New System.Windows.Forms.ComboBox()
        Me.btn_simpanPenjualanDelivery = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbo_statusPenjualanDelivery = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_subTotalDelivery = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_hargaSatuanDelivery = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_QtyDelivery = New System.Windows.Forms.Label()
        Me.lbl_grandTotalDelivery = New System.Windows.Forms.Label()
        Me.lbl_noPenjualanDelivery = New System.Windows.Forms.Label()
        Me.txt_danaDiterimaDelivery = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_kembalianDelivery = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_satuanBrgDelivery = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_namaBrgDelivery = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_brgDelivery = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subTotalDelivery = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hrgaDelivery = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_qtyDelivery = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_tmbhDetBeliDelivery = New System.Windows.Forms.Button()
        Me.dgv_detailPenjualanDelivery = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_tglJualDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_penjualanDeliveryPacking = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoPenjualanPacking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl_catatanPacking = New System.Windows.Forms.RichTextBox()
        Me.lbl_alamatJualPacking = New System.Windows.Forms.RichTextBox()
        Me.lbl_statusKirimPacking = New System.Windows.Forms.Label()
        Me.lbl_kontakPacking = New System.Windows.Forms.Label()
        Me.lbl_atasNamaPacking = New System.Windows.Forms.Label()
        Me.lbl_jenisJualPacking = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.rtb_detailPenjualanPacking = New System.Windows.Forms.RichTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lbl_statusJualPacking = New System.Windows.Forms.Label()
        Me.lbl_metodeJualPacking = New System.Windows.Forms.Label()
        Me.lbl_totalJualPacking = New System.Windows.Forms.Label()
        Me.lbl_tglJualPacking = New System.Windows.Forms.Label()
        Me.lbl_noJualPacking = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_listPenjualanPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_listDetail.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_barcodePenjualanDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detailPenjualanDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_penjualanDeliveryPacking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(148, 768)
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
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelivery, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPOS_Kasir, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 68)
        Me.TableLayoutPanel1.MaximumSize = New System.Drawing.Size(148, 280)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(148, 280)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.btnSemuaListPenjualan.TabIndex = 27
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
        Me.btnPickup.TabIndex = 24
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
        Me.btnDelivery.Location = New System.Drawing.Point(3, 73)
        Me.btnDelivery.MinimumSize = New System.Drawing.Size(142, 64)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(142, 64)
        Me.btnDelivery.TabIndex = 23
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = False
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_listPenjualanPending)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Pembayaran Pending"
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
        Me.dgv_listPenjualanPending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNmr, Me.colNoPenjualan, Me.colJenis, Me.colTglPembelian, Me.colTotalPenjualan, Me.colDanaDiterima, Me.colKembalian, Me.colMetodePembayaran, Me.colCatatan, Me.colAtasNama, Me.colKontak, Me.colAlamat, Me.colStatusKirim})
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
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(815, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(392, 648)
        Me.Panel5.TabIndex = 23
        '
        'lbl_catatanPending
        '
        Me.lbl_catatanPending.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_catatanPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_catatanPending.Location = New System.Drawing.Point(12, 187)
        Me.lbl_catatanPending.Name = "lbl_catatanPending"
        Me.lbl_catatanPending.ReadOnly = True
        Me.lbl_catatanPending.Size = New System.Drawing.Size(178, 47)
        Me.lbl_catatanPending.TabIndex = 46
        Me.lbl_catatanPending.Text = ""
        '
        'lbl_alamatJualPending
        '
        Me.lbl_alamatJualPending.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_alamatJualPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_alamatJualPending.Location = New System.Drawing.Point(200, 158)
        Me.lbl_alamatJualPending.Name = "lbl_alamatJualPending"
        Me.lbl_alamatJualPending.ReadOnly = True
        Me.lbl_alamatJualPending.Size = New System.Drawing.Size(176, 76)
        Me.lbl_alamatJualPending.TabIndex = 45
        Me.lbl_alamatJualPending.Text = ""
        '
        'lbl_statusKirimPending
        '
        Me.lbl_statusKirimPending.AutoSize = True
        Me.lbl_statusKirimPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusKirimPending.Location = New System.Drawing.Point(197, 128)
        Me.lbl_statusKirimPending.Name = "lbl_statusKirimPending"
        Me.lbl_statusKirimPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusKirimPending.TabIndex = 44
        Me.lbl_statusKirimPending.Text = "-"
        '
        'lbl_kontakPending
        '
        Me.lbl_kontakPending.AutoSize = True
        Me.lbl_kontakPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kontakPending.Location = New System.Drawing.Point(197, 98)
        Me.lbl_kontakPending.Name = "lbl_kontakPending"
        Me.lbl_kontakPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_kontakPending.TabIndex = 41
        Me.lbl_kontakPending.Text = "-"
        '
        'lbl_atasNamaPending
        '
        Me.lbl_atasNamaPending.AutoSize = True
        Me.lbl_atasNamaPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_atasNamaPending.Location = New System.Drawing.Point(197, 68)
        Me.lbl_atasNamaPending.Name = "lbl_atasNamaPending"
        Me.lbl_atasNamaPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_atasNamaPending.TabIndex = 40
        Me.lbl_atasNamaPending.Text = "-"
        '
        'lbl_jenisJualPending
        '
        Me.lbl_jenisJualPending.AutoSize = True
        Me.lbl_jenisJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jenisJualPending.Location = New System.Drawing.Point(11, 250)
        Me.lbl_jenisJualPending.Name = "lbl_jenisJualPending"
        Me.lbl_jenisJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_jenisJualPending.TabIndex = 39
        Me.lbl_jenisJualPending.Text = "-"
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
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.txtJenisDelivery)
        Me.TabPage1.Controls.Add(Me.txt_noPenjualanDelivery)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.dtp_tglJualDelivery)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Penjualan DELIVERY Baru"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelDelivery)
        Me.GroupBox1.Controls.Add(Me.pic_barcodePenjualanDelivery)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.cbo_statusDelivery)
        Me.GroupBox1.Controls.Add(Me.txt_alamatDelivery)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txt_kontakDelivery)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txt_atasNamaDelivery)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 201)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'btnCancelDelivery
        '
        Me.btnCancelDelivery.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCancelDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelDelivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelDelivery.Location = New System.Drawing.Point(729, 41)
        Me.btnCancelDelivery.Name = "btnCancelDelivery"
        Me.btnCancelDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancelDelivery.Size = New System.Drawing.Size(81, 142)
        Me.btnCancelDelivery.TabIndex = 72
        Me.btnCancelDelivery.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "🗑️"
        Me.btnCancelDelivery.UseVisualStyleBackColor = False
        '
        'pic_barcodePenjualanDelivery
        '
        Me.pic_barcodePenjualanDelivery.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_barcodePenjualanDelivery.BackColor = System.Drawing.SystemColors.Window
        Me.pic_barcodePenjualanDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_barcodePenjualanDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_barcodePenjualanDelivery.Location = New System.Drawing.Point(479, 41)
        Me.pic_barcodePenjualanDelivery.Name = "pic_barcodePenjualanDelivery"
        Me.pic_barcodePenjualanDelivery.Size = New System.Drawing.Size(240, 142)
        Me.pic_barcodePenjualanDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barcodePenjualanDelivery.TabIndex = 71
        Me.pic_barcodePenjualanDelivery.TabStop = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(476, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 16)
        Me.Label34.TabIndex = 70
        Me.Label34.Text = "Barcode:"
        '
        'cbo_statusDelivery
        '
        Me.cbo_statusDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statusDelivery.FormattingEnabled = True
        Me.cbo_statusDelivery.Items.AddRange(New Object() {"Pending", "Packing", "Siap Diantar", "Selesai"})
        Me.cbo_statusDelivery.Location = New System.Drawing.Point(16, 157)
        Me.cbo_statusDelivery.Name = "cbo_statusDelivery"
        Me.cbo_statusDelivery.Size = New System.Drawing.Size(196, 26)
        Me.cbo_statusDelivery.TabIndex = 64
        '
        'txt_alamatDelivery
        '
        Me.txt_alamatDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_alamatDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_alamatDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamatDelivery.Location = New System.Drawing.Point(226, 41)
        Me.txt_alamatDelivery.Multiline = True
        Me.txt_alamatDelivery.Name = "txt_alamatDelivery"
        Me.txt_alamatDelivery.Size = New System.Drawing.Size(240, 142)
        Me.txt_alamatDelivery.TabIndex = 69
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(13, 138)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(97, 16)
        Me.Label33.TabIndex = 65
        Me.Label33.Text = "Status Delivery:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(223, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 16)
        Me.Label32.TabIndex = 68
        Me.Label32.Text = "Alamat:"
        '
        'txt_kontakDelivery
        '
        Me.txt_kontakDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kontakDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kontakDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kontakDelivery.Location = New System.Drawing.Point(16, 99)
        Me.txt_kontakDelivery.Name = "txt_kontakDelivery"
        Me.txt_kontakDelivery.Size = New System.Drawing.Size(196, 26)
        Me.txt_kontakDelivery.TabIndex = 67
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(13, 80)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(108, 16)
        Me.Label30.TabIndex = 66
        Me.Label30.Text = "Kontak Penerima:"
        '
        'txt_atasNamaDelivery
        '
        Me.txt_atasNamaDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_atasNamaDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_atasNamaDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_atasNamaDelivery.Location = New System.Drawing.Point(16, 41)
        Me.txt_atasNamaDelivery.Name = "txt_atasNamaDelivery"
        Me.txt_atasNamaDelivery.Size = New System.Drawing.Size(196, 26)
        Me.txt_atasNamaDelivery.TabIndex = 65
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(13, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 16)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "Atas Nama:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label31.Location = New System.Drawing.Point(664, 30)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(111, 18)
        Me.Label31.TabIndex = 42
        Me.Label31.Text = "Jenis Penjualan:"
        '
        'txtJenisDelivery
        '
        Me.txtJenisDelivery.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtJenisDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJenisDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisDelivery.Location = New System.Drawing.Point(668, 30)
        Me.txtJenisDelivery.Name = "txtJenisDelivery"
        Me.txtJenisDelivery.ReadOnly = True
        Me.txtJenisDelivery.Size = New System.Drawing.Size(175, 19)
        Me.txtJenisDelivery.TabIndex = 41
        Me.txtJenisDelivery.Text = "Delivery"
        Me.txtJenisDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_noPenjualanDelivery
        '
        Me.txt_noPenjualanDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_noPenjualanDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_noPenjualanDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noPenjualanDelivery.Location = New System.Drawing.Point(462, 25)
        Me.txt_noPenjualanDelivery.Name = "txt_noPenjualanDelivery"
        Me.txt_noPenjualanDelivery.ReadOnly = True
        Me.txt_noPenjualanDelivery.Size = New System.Drawing.Size(175, 26)
        Me.txt_noPenjualanDelivery.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Controls.Add(Me.txt_catatanDelivery)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lbl_totalQtyDelivery)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.cbo_metodePembayaranDelivery)
        Me.Panel3.Controls.Add(Me.btn_simpanPenjualanDelivery)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.cbo_statusPenjualanDelivery)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.lbl_subTotalDelivery)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lbl_hargaSatuanDelivery)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.lbl_QtyDelivery)
        Me.Panel3.Controls.Add(Me.lbl_grandTotalDelivery)
        Me.Panel3.Controls.Add(Me.lbl_noPenjualanDelivery)
        Me.Panel3.Controls.Add(Me.txt_danaDiterimaDelivery)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.lbl_kembalianDelivery)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(865, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 654)
        Me.Panel3.TabIndex = 39
        '
        'txt_catatanDelivery
        '
        Me.txt_catatanDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_catatanDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_catatanDelivery.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_catatanDelivery.Location = New System.Drawing.Point(143, 475)
        Me.txt_catatanDelivery.Multiline = True
        Me.txt_catatanDelivery.Name = "txt_catatanDelivery"
        Me.txt_catatanDelivery.Size = New System.Drawing.Size(180, 63)
        Me.txt_catatanDelivery.TabIndex = 66
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
        'lbl_totalQtyDelivery
        '
        Me.lbl_totalQtyDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_totalQtyDelivery.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbl_totalQtyDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_totalQtyDelivery.Location = New System.Drawing.Point(23, 98)
        Me.lbl_totalQtyDelivery.Name = "lbl_totalQtyDelivery"
        Me.lbl_totalQtyDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_totalQtyDelivery.Size = New System.Drawing.Size(295, 17)
        Me.lbl_totalQtyDelivery.TabIndex = 64
        Me.lbl_totalQtyDelivery.Text = "Total Barang:"
        Me.lbl_totalQtyDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'cbo_metodePembayaranDelivery
        '
        Me.cbo_metodePembayaranDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_metodePembayaranDelivery.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbo_metodePembayaranDelivery.FormattingEnabled = True
        Me.cbo_metodePembayaranDelivery.Items.AddRange(New Object() {"Tunai", "Non-Tunai"})
        Me.cbo_metodePembayaranDelivery.Location = New System.Drawing.Point(143, 378)
        Me.cbo_metodePembayaranDelivery.Name = "cbo_metodePembayaranDelivery"
        Me.cbo_metodePembayaranDelivery.Size = New System.Drawing.Size(180, 26)
        Me.cbo_metodePembayaranDelivery.TabIndex = 59
        '
        'btn_simpanPenjualanDelivery
        '
        Me.btn_simpanPenjualanDelivery.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_simpanPenjualanDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanPenjualanDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpanPenjualanDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanPenjualanDelivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanPenjualanDelivery.Location = New System.Drawing.Point(12, 599)
        Me.btn_simpanPenjualanDelivery.Name = "btn_simpanPenjualanDelivery"
        Me.btn_simpanPenjualanDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanPenjualanDelivery.Size = New System.Drawing.Size(325, 40)
        Me.btn_simpanPenjualanDelivery.TabIndex = 58
        Me.btn_simpanPenjualanDelivery.Text = "Konfirmasi 💸"
        Me.btn_simpanPenjualanDelivery.UseVisualStyleBackColor = False
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
        'cbo_statusPenjualanDelivery
        '
        Me.cbo_statusPenjualanDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statusPenjualanDelivery.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbo_statusPenjualanDelivery.FormattingEnabled = True
        Me.cbo_statusPenjualanDelivery.Items.AddRange(New Object() {"Lunas", "Pending"})
        Me.cbo_statusPenjualanDelivery.Location = New System.Drawing.Point(143, 428)
        Me.cbo_statusPenjualanDelivery.Name = "cbo_statusPenjualanDelivery"
        Me.cbo_statusPenjualanDelivery.Size = New System.Drawing.Size(180, 26)
        Me.cbo_statusPenjualanDelivery.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(37, 383)
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
        'lbl_subTotalDelivery
        '
        Me.lbl_subTotalDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_subTotalDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_subTotalDelivery.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_subTotalDelivery.Location = New System.Drawing.Point(143, 229)
        Me.lbl_subTotalDelivery.Name = "lbl_subTotalDelivery"
        Me.lbl_subTotalDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_subTotalDelivery.Size = New System.Drawing.Size(180, 27)
        Me.lbl_subTotalDelivery.TabIndex = 7
        Me.lbl_subTotalDelivery.Text = "00.00"
        Me.lbl_subTotalDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lbl_hargaSatuanDelivery
        '
        Me.lbl_hargaSatuanDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_hargaSatuanDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_hargaSatuanDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_hargaSatuanDelivery.Location = New System.Drawing.Point(143, 182)
        Me.lbl_hargaSatuanDelivery.Name = "lbl_hargaSatuanDelivery"
        Me.lbl_hargaSatuanDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_hargaSatuanDelivery.Size = New System.Drawing.Size(180, 27)
        Me.lbl_hargaSatuanDelivery.TabIndex = 5
        Me.lbl_hargaSatuanDelivery.Text = "00.00"
        Me.lbl_hargaSatuanDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lbl_QtyDelivery
        '
        Me.lbl_QtyDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_QtyDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_QtyDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_QtyDelivery.Location = New System.Drawing.Point(143, 145)
        Me.lbl_QtyDelivery.Name = "lbl_QtyDelivery"
        Me.lbl_QtyDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_QtyDelivery.Size = New System.Drawing.Size(180, 27)
        Me.lbl_QtyDelivery.TabIndex = 3
        Me.lbl_QtyDelivery.Text = "00"
        Me.lbl_QtyDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_grandTotalDelivery
        '
        Me.lbl_grandTotalDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_grandTotalDelivery.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandTotalDelivery.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_grandTotalDelivery.Location = New System.Drawing.Point(23, 62)
        Me.lbl_grandTotalDelivery.Name = "lbl_grandTotalDelivery"
        Me.lbl_grandTotalDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_grandTotalDelivery.Size = New System.Drawing.Size(300, 33)
        Me.lbl_grandTotalDelivery.TabIndex = 1
        Me.lbl_grandTotalDelivery.Text = "00.00"
        Me.lbl_grandTotalDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_noPenjualanDelivery
        '
        Me.lbl_noPenjualanDelivery.BackColor = System.Drawing.Color.Transparent
        Me.lbl_noPenjualanDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noPenjualanDelivery.Location = New System.Drawing.Point(3, 15)
        Me.lbl_noPenjualanDelivery.Name = "lbl_noPenjualanDelivery"
        Me.lbl_noPenjualanDelivery.Size = New System.Drawing.Size(339, 25)
        Me.lbl_noPenjualanDelivery.TabIndex = 0
        Me.lbl_noPenjualanDelivery.Text = "-"
        Me.lbl_noPenjualanDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_danaDiterimaDelivery
        '
        Me.txt_danaDiterimaDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_danaDiterimaDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_danaDiterimaDelivery.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_danaDiterimaDelivery.Location = New System.Drawing.Point(143, 281)
        Me.txt_danaDiterimaDelivery.Name = "txt_danaDiterimaDelivery"
        Me.txt_danaDiterimaDelivery.Size = New System.Drawing.Size(180, 25)
        Me.txt_danaDiterimaDelivery.TabIndex = 61
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label25.Location = New System.Drawing.Point(28, 285)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 16)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Dana Diterima:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(53, 339)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 16)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Kembalian:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_kembalianDelivery
        '
        Me.lbl_kembalianDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_kembalianDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_kembalianDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_kembalianDelivery.Location = New System.Drawing.Point(143, 330)
        Me.lbl_kembalianDelivery.Name = "lbl_kembalianDelivery"
        Me.lbl_kembalianDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_kembalianDelivery.Size = New System.Drawing.Size(180, 27)
        Me.lbl_kembalianDelivery.TabIndex = 56
        Me.lbl_kembalianDelivery.Text = "00.00"
        Me.lbl_kembalianDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_satuanBrgDelivery)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_namaBrgDelivery)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cbo_brgDelivery)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_subTotalDelivery)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_hrgaDelivery)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_qtyDelivery)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_tmbhDetBeliDelivery)
        Me.GroupBox2.Controls.Add(Me.dgv_detailPenjualanDelivery)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(816, 371)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'txt_satuanBrgDelivery
        '
        Me.txt_satuanBrgDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_satuanBrgDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuanBrgDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_satuanBrgDelivery.Location = New System.Drawing.Point(116, 153)
        Me.txt_satuanBrgDelivery.Name = "txt_satuanBrgDelivery"
        Me.txt_satuanBrgDelivery.ReadOnly = True
        Me.txt_satuanBrgDelivery.Size = New System.Drawing.Size(96, 26)
        Me.txt_satuanBrgDelivery.TabIndex = 63
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(519, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(275, 16)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "*Double klik barang jika ingin hapus barang itu"
        '
        'txt_namaBrgDelivery
        '
        Me.txt_namaBrgDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_namaBrgDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_namaBrgDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaBrgDelivery.Location = New System.Drawing.Point(16, 98)
        Me.txt_namaBrgDelivery.Name = "txt_namaBrgDelivery"
        Me.txt_namaBrgDelivery.ReadOnly = True
        Me.txt_namaBrgDelivery.Size = New System.Drawing.Size(196, 26)
        Me.txt_namaBrgDelivery.TabIndex = 61
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Nama Barang:"
        '
        'cbo_brgDelivery
        '
        Me.cbo_brgDelivery.FormattingEnabled = True
        Me.cbo_brgDelivery.Location = New System.Drawing.Point(16, 41)
        Me.cbo_brgDelivery.Name = "cbo_brgDelivery"
        Me.cbo_brgDelivery.Size = New System.Drawing.Size(196, 26)
        Me.cbo_brgDelivery.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(113, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Satuan:"
        '
        'txt_subTotalDelivery
        '
        Me.txt_subTotalDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_subTotalDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subTotalDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subTotalDelivery.Location = New System.Drawing.Point(16, 266)
        Me.txt_subTotalDelivery.Name = "txt_subTotalDelivery"
        Me.txt_subTotalDelivery.ReadOnly = True
        Me.txt_subTotalDelivery.Size = New System.Drawing.Size(196, 26)
        Me.txt_subTotalDelivery.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Subtotal:"
        '
        'txt_hrgaDelivery
        '
        Me.txt_hrgaDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaDelivery.Location = New System.Drawing.Point(16, 211)
        Me.txt_hrgaDelivery.Name = "txt_hrgaDelivery"
        Me.txt_hrgaDelivery.ReadOnly = True
        Me.txt_hrgaDelivery.Size = New System.Drawing.Size(196, 26)
        Me.txt_hrgaDelivery.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Harga per Satuan:"
        '
        'txt_qtyDelivery
        '
        Me.txt_qtyDelivery.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_qtyDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qtyDelivery.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtyDelivery.Location = New System.Drawing.Point(16, 153)
        Me.txt_qtyDelivery.Name = "txt_qtyDelivery"
        Me.txt_qtyDelivery.Size = New System.Drawing.Size(96, 26)
        Me.txt_qtyDelivery.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Kode Barang:"
        '
        'btn_tmbhDetBeliDelivery
        '
        Me.btn_tmbhDetBeliDelivery.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_tmbhDetBeliDelivery.FlatAppearance.BorderSize = 0
        Me.btn_tmbhDetBeliDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tmbhDetBeliDelivery.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_tmbhDetBeliDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_tmbhDetBeliDelivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetBeliDelivery.Location = New System.Drawing.Point(16, 318)
        Me.btn_tmbhDetBeliDelivery.Name = "btn_tmbhDetBeliDelivery"
        Me.btn_tmbhDetBeliDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhDetBeliDelivery.Size = New System.Drawing.Size(196, 29)
        Me.btn_tmbhDetBeliDelivery.TabIndex = 50
        Me.btn_tmbhDetBeliDelivery.Text = "➕ Tambah Barang"
        Me.btn_tmbhDetBeliDelivery.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetBeliDelivery.UseVisualStyleBackColor = False
        '
        'dgv_detailPenjualanDelivery
        '
        Me.dgv_detailPenjualanDelivery.AllowUserToAddRows = False
        Me.dgv_detailPenjualanDelivery.AllowUserToDeleteRows = False
        Me.dgv_detailPenjualanDelivery.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detailPenjualanDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detailPenjualanDelivery.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colKodeBrg, Me.colNmaBrg, Me.colQty, Me.colSatuan, Me.colHarga, Me.colSubtotal})
        Me.dgv_detailPenjualanDelivery.Location = New System.Drawing.Point(226, 41)
        Me.dgv_detailPenjualanDelivery.Name = "dgv_detailPenjualanDelivery"
        Me.dgv_detailPenjualanDelivery.ReadOnly = True
        Me.dgv_detailPenjualanDelivery.RowHeadersVisible = False
        Me.dgv_detailPenjualanDelivery.Size = New System.Drawing.Size(568, 306)
        Me.dgv_detailPenjualanDelivery.TabIndex = 0
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
        'dtp_tglJualDelivery
        '
        Me.dtp_tglJualDelivery.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_tglJualDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglJualDelivery.Location = New System.Drawing.Point(156, 25)
        Me.dtp_tglJualDelivery.Name = "dtp_tglJualDelivery"
        Me.dtp_tglJualDelivery.Size = New System.Drawing.Size(175, 25)
        Me.dtp_tglJualDelivery.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(18, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tanggal Penjualan:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label17.Location = New System.Drawing.Point(353, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 18)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "No. Penjualan:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(148, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1218, 699)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgv_penjualanDeliveryPacking)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 41)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Text = "Masih Dipacking"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgv_penjualanDeliveryPacking
        '
        Me.dgv_penjualanDeliveryPacking.AllowUserToAddRows = False
        Me.dgv_penjualanDeliveryPacking.AllowUserToDeleteRows = False
        Me.dgv_penjualanDeliveryPacking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_penjualanDeliveryPacking.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_penjualanDeliveryPacking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_penjualanDeliveryPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_penjualanDeliveryPacking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colNoPenjualanPacking, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_penjualanDeliveryPacking.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_penjualanDeliveryPacking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_penjualanDeliveryPacking.Location = New System.Drawing.Point(3, 53)
        Me.dgv_penjualanDeliveryPacking.Name = "dgv_penjualanDeliveryPacking"
        Me.dgv_penjualanDeliveryPacking.ReadOnly = True
        Me.dgv_penjualanDeliveryPacking.RowHeadersVisible = False
        Me.dgv_penjualanDeliveryPacking.Size = New System.Drawing.Size(812, 598)
        Me.dgv_penjualanDeliveryPacking.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 44
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 44
        '
        'colNoPenjualanPacking
        '
        Me.colNoPenjualanPacking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNoPenjualanPacking.HeaderText = "No. Penjualan"
        Me.colNoPenjualanPacking.MinimumWidth = 154
        Me.colNoPenjualanPacking.Name = "colNoPenjualanPacking"
        Me.colNoPenjualanPacking.ReadOnly = True
        Me.colNoPenjualanPacking.Width = 154
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jenis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tgl"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 85
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 85
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 105
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dana Diterima"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kembalian"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.HeaderText = "Metode"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 82
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Catatan"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 84
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Atas Nama"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Kontak"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Status Kirim"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Controls.Add(Me.Label35)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(812, 50)
        Me.Panel7.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(136, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 26)
        Me.TextBox1.TabIndex = 26
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(15, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 16)
        Me.Label35.TabIndex = 25
        Me.Label35.Text = "Search Penjualan:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Window
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lbl_catatanPacking)
        Me.Panel8.Controls.Add(Me.lbl_alamatJualPacking)
        Me.Panel8.Controls.Add(Me.lbl_statusKirimPacking)
        Me.Panel8.Controls.Add(Me.lbl_kontakPacking)
        Me.Panel8.Controls.Add(Me.lbl_atasNamaPacking)
        Me.Panel8.Controls.Add(Me.lbl_jenisJualPacking)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.lbl_statusJualPacking)
        Me.Panel8.Controls.Add(Me.lbl_metodeJualPacking)
        Me.Panel8.Controls.Add(Me.lbl_totalJualPacking)
        Me.Panel8.Controls.Add(Me.lbl_tglJualPacking)
        Me.Panel8.Controls.Add(Me.lbl_noJualPacking)
        Me.Panel8.Controls.Add(Me.Label50)
        Me.Panel8.Controls.Add(Me.Label51)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(815, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(392, 648)
        Me.Panel8.TabIndex = 26
        '
        'lbl_catatanPacking
        '
        Me.lbl_catatanPacking.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_catatanPacking.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_catatanPacking.Location = New System.Drawing.Point(14, 221)
        Me.lbl_catatanPacking.Name = "lbl_catatanPacking"
        Me.lbl_catatanPacking.ReadOnly = True
        Me.lbl_catatanPacking.Size = New System.Drawing.Size(178, 47)
        Me.lbl_catatanPacking.TabIndex = 46
        Me.lbl_catatanPacking.Text = ""
        '
        'lbl_alamatJualPacking
        '
        Me.lbl_alamatJualPacking.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_alamatJualPacking.Location = New System.Drawing.Point(200, 158)
        Me.lbl_alamatJualPacking.Name = "lbl_alamatJualPacking"
        Me.lbl_alamatJualPacking.ReadOnly = True
        Me.lbl_alamatJualPacking.Size = New System.Drawing.Size(176, 110)
        Me.lbl_alamatJualPacking.TabIndex = 45
        Me.lbl_alamatJualPacking.Text = ""
        '
        'lbl_statusKirimPacking
        '
        Me.lbl_statusKirimPacking.AutoSize = True
        Me.lbl_statusKirimPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusKirimPacking.Location = New System.Drawing.Point(197, 128)
        Me.lbl_statusKirimPacking.Name = "lbl_statusKirimPacking"
        Me.lbl_statusKirimPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusKirimPacking.TabIndex = 44
        Me.lbl_statusKirimPacking.Text = "-"
        '
        'lbl_kontakPacking
        '
        Me.lbl_kontakPacking.AutoSize = True
        Me.lbl_kontakPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kontakPacking.Location = New System.Drawing.Point(197, 98)
        Me.lbl_kontakPacking.Name = "lbl_kontakPacking"
        Me.lbl_kontakPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_kontakPacking.TabIndex = 41
        Me.lbl_kontakPacking.Text = "-"
        '
        'lbl_atasNamaPacking
        '
        Me.lbl_atasNamaPacking.AutoSize = True
        Me.lbl_atasNamaPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_atasNamaPacking.Location = New System.Drawing.Point(197, 68)
        Me.lbl_atasNamaPacking.Name = "lbl_atasNamaPacking"
        Me.lbl_atasNamaPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_atasNamaPacking.TabIndex = 40
        Me.lbl_atasNamaPacking.Text = "-"
        '
        'lbl_jenisJualPacking
        '
        Me.lbl_jenisJualPacking.AutoSize = True
        Me.lbl_jenisJualPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jenisJualPacking.Location = New System.Drawing.Point(11, 188)
        Me.lbl_jenisJualPacking.Name = "lbl_jenisJualPacking"
        Me.lbl_jenisJualPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_jenisJualPacking.TabIndex = 39
        Me.lbl_jenisJualPacking.Text = "-"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.rtb_detailPenjualanPacking)
        Me.Panel9.Controls.Add(Me.Label43)
        Me.Panel9.Controls.Add(Me.Label44)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 281)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(390, 318)
        Me.Panel9.TabIndex = 21
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(0, 1)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(390, 1)
        Me.Label42.TabIndex = 33
        Me.Label42.Text = resources.GetString("Label42.Text")
        '
        'rtb_detailPenjualanPacking
        '
        Me.rtb_detailPenjualanPacking.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_detailPenjualanPacking.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_detailPenjualanPacking.Location = New System.Drawing.Point(14, 42)
        Me.rtb_detailPenjualanPacking.Name = "rtb_detailPenjualanPacking"
        Me.rtb_detailPenjualanPacking.ReadOnly = True
        Me.rtb_detailPenjualanPacking.Size = New System.Drawing.Size(362, 270)
        Me.rtb_detailPenjualanPacking.TabIndex = 32
        Me.rtb_detailPenjualanPacking.Text = ""
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label43.Location = New System.Drawing.Point(131, 7)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(142, 18)
        Me.Label43.TabIndex = 30
        Me.Label43.Text = "Detail List Barang"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(0, 30)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(390, 1)
        Me.Label44.TabIndex = 31
        Me.Label44.Text = resources.GetString("Label44.Text")
        '
        'lbl_statusJualPacking
        '
        Me.lbl_statusJualPacking.AutoSize = True
        Me.lbl_statusJualPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusJualPacking.Location = New System.Drawing.Point(11, 158)
        Me.lbl_statusJualPacking.Name = "lbl_statusJualPacking"
        Me.lbl_statusJualPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusJualPacking.TabIndex = 31
        Me.lbl_statusJualPacking.Text = "-"
        '
        'lbl_metodeJualPacking
        '
        Me.lbl_metodeJualPacking.AutoSize = True
        Me.lbl_metodeJualPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodeJualPacking.Location = New System.Drawing.Point(11, 128)
        Me.lbl_metodeJualPacking.Name = "lbl_metodeJualPacking"
        Me.lbl_metodeJualPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_metodeJualPacking.TabIndex = 30
        Me.lbl_metodeJualPacking.Text = "-"
        '
        'lbl_totalJualPacking
        '
        Me.lbl_totalJualPacking.AutoSize = True
        Me.lbl_totalJualPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalJualPacking.Location = New System.Drawing.Point(11, 98)
        Me.lbl_totalJualPacking.Name = "lbl_totalJualPacking"
        Me.lbl_totalJualPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalJualPacking.TabIndex = 29
        Me.lbl_totalJualPacking.Text = "-"
        '
        'lbl_tglJualPacking
        '
        Me.lbl_tglJualPacking.AutoSize = True
        Me.lbl_tglJualPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tglJualPacking.Location = New System.Drawing.Point(11, 68)
        Me.lbl_tglJualPacking.Name = "lbl_tglJualPacking"
        Me.lbl_tglJualPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tglJualPacking.TabIndex = 28
        Me.lbl_tglJualPacking.Text = "-"
        '
        'lbl_noJualPacking
        '
        Me.lbl_noJualPacking.AutoSize = True
        Me.lbl_noJualPacking.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noJualPacking.Location = New System.Drawing.Point(11, 38)
        Me.lbl_noJualPacking.Name = "lbl_noJualPacking"
        Me.lbl_noJualPacking.Size = New System.Drawing.Size(13, 18)
        Me.lbl_noJualPacking.TabIndex = 27
        Me.lbl_noJualPacking.Text = "-"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label50.Location = New System.Drawing.Point(-1, 3)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(392, 18)
        Me.Label50.TabIndex = 26
        Me.Label50.Text = "Informasi Penjualan"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(0, 26)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(390, 1)
        Me.Label51.TabIndex = 25
        Me.Label51.Text = resources.GetString("Label51.Text")
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Button1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 599)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(390, 47)
        Me.Panel10.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(366, 29)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Clear 🧹"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_ManagePenjualanDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 718)
        Me.Name = "frm_ManagePenjualanDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ManagePenjualanDoP"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_listPenjualanPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_listDetail.ResumeLayout(False)
        Me.pnl_listDetail.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_barcodePenjualanDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detailPenjualanDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_penjualanDeliveryPacking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
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
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnPOS_Kasir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPickup As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_listPenjualanPending As DataGridView
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariPenjualan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_statusKirimPending As Label
    Friend WithEvents lbl_kontakPending As Label
    Friend WithEvents lbl_atasNamaPending As Label
    Friend WithEvents lbl_jenisJualPending As Label
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelDelivery As Button
    Friend WithEvents pic_barcodePenjualanDelivery As PictureBox
    Friend WithEvents Label34 As Label
    Friend WithEvents cbo_statusDelivery As ComboBox
    Friend WithEvents txt_alamatDelivery As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_kontakDelivery As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_atasNamaDelivery As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtJenisDelivery As TextBox
    Friend WithEvents txt_noPenjualanDelivery As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_catatanDelivery As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_totalQtyDelivery As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cbo_metodePembayaranDelivery As ComboBox
    Friend WithEvents btn_simpanPenjualanDelivery As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents cbo_statusPenjualanDelivery As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_subTotalDelivery As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_hargaSatuanDelivery As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_QtyDelivery As Label
    Friend WithEvents lbl_grandTotalDelivery As Label
    Friend WithEvents lbl_noPenjualanDelivery As Label
    Friend WithEvents txt_danaDiterimaDelivery As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_kembalianDelivery As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_satuanBrgDelivery As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_namaBrgDelivery As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbo_brgDelivery As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_subTotalDelivery As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hrgaDelivery As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_qtyDelivery As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_tmbhDetBeliDelivery As Button
    Friend WithEvents dgv_detailPenjualanDelivery As DataGridView
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrg As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrg As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents dtp_tglJualDelivery As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgv_penjualanDeliveryPacking As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl_statusKirimPacking As Label
    Friend WithEvents lbl_kontakPacking As Label
    Friend WithEvents lbl_atasNamaPacking As Label
    Friend WithEvents lbl_jenisJualPacking As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents rtb_detailPenjualanPacking As RichTextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents lbl_statusJualPacking As Label
    Friend WithEvents lbl_metodeJualPacking As Label
    Friend WithEvents lbl_totalJualPacking As Label
    Friend WithEvents lbl_tglJualPacking As Label
    Friend WithEvents lbl_noJualPacking As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colNoPenjualanPacking As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents btnSemuaListPenjualan As Button
    Friend WithEvents lbl_alamatJualPending As RichTextBox
    Friend WithEvents lbl_alamatJualPacking As RichTextBox
    Friend WithEvents lbl_catatanPending As RichTextBox
    Friend WithEvents lbl_catatanPacking As RichTextBox
End Class
