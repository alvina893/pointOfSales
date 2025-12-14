<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManagePenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ManagePenjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtjenisPenjualan = New System.Windows.Forms.TextBox()
        Me.txt_noPenjualan = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_catatan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_totalQty = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_danaDiterimaLangsung = New System.Windows.Forms.TextBox()
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
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btn_tmbhDetJual = New System.Windows.Forms.Button()
        Me.dgv_detailPenjualan = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_tglJual = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCancelPickup = New System.Windows.Forms.Button()
        Me.pic_barcodePenjualanPickup = New System.Windows.Forms.PictureBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cbo_statusPickup = New System.Windows.Forms.ComboBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txt_kontakDeliveryPickup = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt_atasNamaDeliveryPickup = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtJenisDeliveryPickup = New System.Windows.Forms.TextBox()
        Me.txt_noPenjualanPickup = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txt_catatanPickup = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.lbl_totalQtyPickup = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.cbo_metodePembayaranPickup = New System.Windows.Forms.ComboBox()
        Me.btn_simpanPenjualanPickup = New System.Windows.Forms.Button()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.cbo_statusPenjualanPickup = New System.Windows.Forms.ComboBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.lbl_subTotalPickup = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.lbl_hargaSatuanPickup = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.lbl_QtyPickup = New System.Windows.Forms.Label()
        Me.lbl_grandTotalPickup = New System.Windows.Forms.Label()
        Me.lbl_noPenjualanPickup = New System.Windows.Forms.Label()
        Me.txt_danaDiterimaPickup = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.lbl_kembalianPickup = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_satuanBrgPickup = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txt_namaBrgPickup = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.cbo_brgPickup = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txt_subTotalPickup = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txt_hrgaPickup = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txt_qtyPickup = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.btn_tmbhDetBeliPickup = New System.Windows.Forms.Button()
        Me.dgv_detailPenjualanPickup = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBarangPickup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyPickup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuanPickup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaPickup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotalPickup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_tglJualPickup = New System.Windows.Forms.DateTimePicker()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancelDelivery = New System.Windows.Forms.Button()
        Me.pic_barcodePenjualanDelivery = New System.Windows.Forms.PictureBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cbo_statusDelivery = New System.Windows.Forms.ComboBox()
        Me.txt_alamatDelivery = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_kontakDelivery = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_atasNamaDelivery = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtJenisDelivery = New System.Windows.Forms.TextBox()
        Me.txt_noPenjualanDelivery = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txt_catatanDelivery = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.lbl_totalQtyDelivery = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cbo_metodePembayaranDelivery = New System.Windows.Forms.ComboBox()
        Me.btn_simpanPenjualanDelivery = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cbo_statusPenjualanDelivery = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.lbl_subTotalDelivery = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lbl_hargaSatuanDelivery = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.lbl_QtyDelivery = New System.Windows.Forms.Label()
        Me.lbl_grandTotalDelivery = New System.Windows.Forms.Label()
        Me.lbl_noPenjualanDelivery = New System.Windows.Forms.Label()
        Me.txt_danaDiterimaDelivery = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lbl_kembalianDelivery = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_satuanBrgDelivery = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_namaBrgDelivery = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cbo_brgDelivery = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_subTotalDelivery = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_hrgaDelivery = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_qtyDelivery = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.btn_tmbhDetBeliDelivery = New System.Windows.Forms.Button()
        Me.dgv_detailPenjualanDelivery = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBrgDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBrgDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQtyDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuanDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotalDelivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtp_tglJualDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_listPenjualan = New System.Windows.Forms.DataGridView()
        Me.colNmr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJenisPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDanaDiterima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMetodePembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cariPenjualan = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_jenisJual = New System.Windows.Forms.Label()
        Me.lbl_catatan = New System.Windows.Forms.Label()
        Me.lbl_kembalian = New System.Windows.Forms.Label()
        Me.lbl_danaDiterima = New System.Windows.Forms.Label()
        Me.pnl_listDetail = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtb_detailPenjualan = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_statusJual = New System.Windows.Forms.Label()
        Me.lbl_metodeJual = New System.Windows.Forms.Label()
        Me.lbl_totalJual = New System.Windows.Forms.Label()
        Me.lbl_tglJual = New System.Windows.Forms.Label()
        Me.lbl_noJual = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgv_listPenjualanPending = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoPenjualanPending = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTglPembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPenjualanPending = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_catatanPending = New System.Windows.Forms.RichTextBox()
        Me.lbl_alamatJualPending = New System.Windows.Forms.RichTextBox()
        Me.lbl_statusKirimPending = New System.Windows.Forms.Label()
        Me.lbl_kontakPending = New System.Windows.Forms.Label()
        Me.lbl_atasNamaPending = New System.Windows.Forms.Label()
        Me.lbl_jenisJualPending = New System.Windows.Forms.Label()
        Me.lbl_statusJualPending = New System.Windows.Forms.Label()
        Me.lbl_metodeJualPending = New System.Windows.Forms.Label()
        Me.lbl_totalJualPending = New System.Windows.Forms.Label()
        Me.lbl_tglJualPending = New System.Windows.Forms.Label()
        Me.lbl_noJualPending = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.rtb_detailPenjualanPending = New System.Windows.Forms.RichTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btn_clearPenjualanPending = New System.Windows.Forms.Button()
        Me.btn_updateLunasPenjualan = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_resetDanaKecil = New System.Windows.Forms.Button()
        Me.btn_konfirmasiUangKecil = New System.Windows.Forms.Button()
        Me.txt_danaUangKecil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_tglUangKecil = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detailPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pic_barcodePenjualanPickup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgv_detailPenjualanPickup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pic_barcodePenjualanDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_detailPenjualanDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_listPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnl_listDetail.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgv_listPenjualanPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel6.TabIndex = 2
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
        Me.btnPenjualan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
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
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Controls.Add(Me.btnKembali)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(148, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1218, 69)
        Me.Panel1.TabIndex = 25
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(1157, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 24
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtjenisPenjualan)
        Me.TabPage3.Controls.Add(Me.txt_noPenjualan)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.dtp_tglJual)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 41)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Penjualan Baru"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Controls.Add(Me.txt_catatan)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lbl_totalQty)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.txt_danaDiterimaLangsung)
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
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lbl_Qty)
        Me.Panel3.Controls.Add(Me.lbl_grandTotal)
        Me.Panel3.Controls.Add(Me.lbl_noPenjualan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(865, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 635)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(66, 479)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Catatan:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalQty
        '
        Me.lbl_totalQty.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_totalQty.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbl_totalQty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_totalQty.Location = New System.Drawing.Point(23, 88)
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
        'txt_danaDiterimaLangsung
        '
        Me.txt_danaDiterimaLangsung.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_danaDiterimaLangsung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_danaDiterimaLangsung.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_danaDiterimaLangsung.Location = New System.Drawing.Point(143, 278)
        Me.txt_danaDiterimaLangsung.Name = "txt_danaDiterimaLangsung"
        Me.txt_danaDiterimaLangsung.Size = New System.Drawing.Size(180, 25)
        Me.txt_danaDiterimaLangsung.TabIndex = 61
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
        Me.lbl_kembalianLangsung.Location = New System.Drawing.Point(143, 317)
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
        Me.lbl_subTotal.Location = New System.Drawing.Point(143, 219)
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
        Me.lbl_hargaSatuan.Location = New System.Drawing.Point(143, 172)
        Me.lbl_hargaSatuan.Name = "lbl_hargaSatuan"
        Me.lbl_hargaSatuan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_hargaSatuan.Size = New System.Drawing.Size(180, 27)
        Me.lbl_hargaSatuan.TabIndex = 5
        Me.lbl_hargaSatuan.Text = "00.00"
        Me.lbl_hargaSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(44, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Qty Barang:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Qty
        '
        Me.lbl_Qty.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_Qty.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Qty.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Qty.Location = New System.Drawing.Point(143, 135)
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
        Me.lbl_grandTotal.Location = New System.Drawing.Point(23, 52)
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
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_qty)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label29)
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 253)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 16)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Harga per Satuan:"
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
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 137)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 16)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Qty:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(13, 25)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 16)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "Kode Barang:"
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
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label30.Location = New System.Drawing.Point(19, 29)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(132, 18)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Tanggal Penjualan:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label31.Location = New System.Drawing.Point(359, 29)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(103, 18)
        Me.Label31.TabIndex = 37
        Me.Label31.Text = "No. Penjualan:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(148, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1218, 680)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox5)
        Me.TabPage5.Controls.Add(Me.Label65)
        Me.TabPage5.Controls.Add(Me.txtJenisDeliveryPickup)
        Me.TabPage5.Controls.Add(Me.txt_noPenjualanPickup)
        Me.TabPage5.Controls.Add(Me.Panel11)
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Controls.Add(Me.dtp_tglJualPickup)
        Me.TabPage5.Controls.Add(Me.Label82)
        Me.TabPage5.Controls.Add(Me.Label83)
        Me.TabPage5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.Location = New System.Drawing.Point(4, 41)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage5.TabIndex = 10
        Me.TabPage5.Text = "Pickup Baru"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnCancelPickup)
        Me.GroupBox5.Controls.Add(Me.pic_barcodePenjualanPickup)
        Me.GroupBox5.Controls.Add(Me.Label61)
        Me.GroupBox5.Controls.Add(Me.cbo_statusPickup)
        Me.GroupBox5.Controls.Add(Me.Label62)
        Me.GroupBox5.Controls.Add(Me.txt_kontakDeliveryPickup)
        Me.GroupBox5.Controls.Add(Me.Label63)
        Me.GroupBox5.Controls.Add(Me.txt_atasNamaDeliveryPickup)
        Me.GroupBox5.Controls.Add(Me.Label64)
        Me.GroupBox5.Location = New System.Drawing.Point(27, 438)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(816, 201)
        Me.GroupBox5.TabIndex = 43
        Me.GroupBox5.TabStop = False
        '
        'btnCancelPickup
        '
        Me.btnCancelPickup.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCancelPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPickup.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelPickup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelPickup.Location = New System.Drawing.Point(729, 41)
        Me.btnCancelPickup.Name = "btnCancelPickup"
        Me.btnCancelPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancelPickup.Size = New System.Drawing.Size(81, 142)
        Me.btnCancelPickup.TabIndex = 72
        Me.btnCancelPickup.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "🗑️"
        Me.btnCancelPickup.UseVisualStyleBackColor = False
        '
        'pic_barcodePenjualanPickup
        '
        Me.pic_barcodePenjualanPickup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_barcodePenjualanPickup.BackColor = System.Drawing.SystemColors.Window
        Me.pic_barcodePenjualanPickup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_barcodePenjualanPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_barcodePenjualanPickup.Location = New System.Drawing.Point(226, 41)
        Me.pic_barcodePenjualanPickup.Name = "pic_barcodePenjualanPickup"
        Me.pic_barcodePenjualanPickup.Size = New System.Drawing.Size(488, 142)
        Me.pic_barcodePenjualanPickup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barcodePenjualanPickup.TabIndex = 71
        Me.pic_barcodePenjualanPickup.TabStop = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(223, 22)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(58, 16)
        Me.Label61.TabIndex = 70
        Me.Label61.Text = "Barcode:"
        '
        'cbo_statusPickup
        '
        Me.cbo_statusPickup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statusPickup.FormattingEnabled = True
        Me.cbo_statusPickup.Items.AddRange(New Object() {"Pending", "Packing", "Siap Pickup", "Selesai"})
        Me.cbo_statusPickup.Location = New System.Drawing.Point(16, 157)
        Me.cbo_statusPickup.Name = "cbo_statusPickup"
        Me.cbo_statusPickup.Size = New System.Drawing.Size(196, 26)
        Me.cbo_statusPickup.TabIndex = 64
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(13, 138)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(88, 16)
        Me.Label62.TabIndex = 65
        Me.Label62.Text = "Status Pickup:"
        '
        'txt_kontakDeliveryPickup
        '
        Me.txt_kontakDeliveryPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kontakDeliveryPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kontakDeliveryPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kontakDeliveryPickup.Location = New System.Drawing.Point(16, 99)
        Me.txt_kontakDeliveryPickup.Name = "txt_kontakDeliveryPickup"
        Me.txt_kontakDeliveryPickup.Size = New System.Drawing.Size(196, 26)
        Me.txt_kontakDeliveryPickup.TabIndex = 67
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(13, 80)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(108, 16)
        Me.Label63.TabIndex = 66
        Me.Label63.Text = "Kontak Penerima:"
        '
        'txt_atasNamaDeliveryPickup
        '
        Me.txt_atasNamaDeliveryPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_atasNamaDeliveryPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_atasNamaDeliveryPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_atasNamaDeliveryPickup.Location = New System.Drawing.Point(16, 41)
        Me.txt_atasNamaDeliveryPickup.Name = "txt_atasNamaDeliveryPickup"
        Me.txt_atasNamaDeliveryPickup.Size = New System.Drawing.Size(196, 26)
        Me.txt_atasNamaDeliveryPickup.TabIndex = 65
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(13, 22)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(74, 16)
        Me.Label64.TabIndex = 64
        Me.Label64.Text = "Atas Nama:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label65.Location = New System.Drawing.Point(664, 30)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(111, 18)
        Me.Label65.TabIndex = 42
        Me.Label65.Text = "Jenis Penjualan:"
        '
        'txtJenisDeliveryPickup
        '
        Me.txtJenisDeliveryPickup.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtJenisDeliveryPickup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtJenisDeliveryPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisDeliveryPickup.Location = New System.Drawing.Point(668, 30)
        Me.txtJenisDeliveryPickup.Name = "txtJenisDeliveryPickup"
        Me.txtJenisDeliveryPickup.ReadOnly = True
        Me.txtJenisDeliveryPickup.Size = New System.Drawing.Size(175, 19)
        Me.txtJenisDeliveryPickup.TabIndex = 41
        Me.txtJenisDeliveryPickup.Text = "Pickup"
        Me.txtJenisDeliveryPickup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_noPenjualanPickup
        '
        Me.txt_noPenjualanPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_noPenjualanPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_noPenjualanPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noPenjualanPickup.Location = New System.Drawing.Point(462, 25)
        Me.txt_noPenjualanPickup.Name = "txt_noPenjualanPickup"
        Me.txt_noPenjualanPickup.ReadOnly = True
        Me.txt_noPenjualanPickup.Size = New System.Drawing.Size(175, 26)
        Me.txt_noPenjualanPickup.TabIndex = 38
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Window
        Me.Panel11.Controls.Add(Me.txt_catatanPickup)
        Me.Panel11.Controls.Add(Me.Label66)
        Me.Panel11.Controls.Add(Me.lbl_totalQtyPickup)
        Me.Panel11.Controls.Add(Me.Label67)
        Me.Panel11.Controls.Add(Me.cbo_metodePembayaranPickup)
        Me.Panel11.Controls.Add(Me.btn_simpanPenjualanPickup)
        Me.Panel11.Controls.Add(Me.Label68)
        Me.Panel11.Controls.Add(Me.cbo_statusPenjualanPickup)
        Me.Panel11.Controls.Add(Me.Label69)
        Me.Panel11.Controls.Add(Me.Label70)
        Me.Panel11.Controls.Add(Me.lbl_subTotalPickup)
        Me.Panel11.Controls.Add(Me.Label71)
        Me.Panel11.Controls.Add(Me.lbl_hargaSatuanPickup)
        Me.Panel11.Controls.Add(Me.Label72)
        Me.Panel11.Controls.Add(Me.lbl_QtyPickup)
        Me.Panel11.Controls.Add(Me.lbl_grandTotalPickup)
        Me.Panel11.Controls.Add(Me.lbl_noPenjualanPickup)
        Me.Panel11.Controls.Add(Me.txt_danaDiterimaPickup)
        Me.Panel11.Controls.Add(Me.Label73)
        Me.Panel11.Controls.Add(Me.Label74)
        Me.Panel11.Controls.Add(Me.lbl_kembalianPickup)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(865, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(345, 635)
        Me.Panel11.TabIndex = 39
        '
        'txt_catatanPickup
        '
        Me.txt_catatanPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_catatanPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_catatanPickup.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_catatanPickup.Location = New System.Drawing.Point(143, 475)
        Me.txt_catatanPickup.Multiline = True
        Me.txt_catatanPickup.Name = "txt_catatanPickup"
        Me.txt_catatanPickup.Size = New System.Drawing.Size(180, 63)
        Me.txt_catatanPickup.TabIndex = 66
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label66.Location = New System.Drawing.Point(66, 479)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(56, 16)
        Me.Label66.TabIndex = 65
        Me.Label66.Text = "Catatan:"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalQtyPickup
        '
        Me.lbl_totalQtyPickup.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_totalQtyPickup.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbl_totalQtyPickup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_totalQtyPickup.Location = New System.Drawing.Point(23, 88)
        Me.lbl_totalQtyPickup.Name = "lbl_totalQtyPickup"
        Me.lbl_totalQtyPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_totalQtyPickup.Size = New System.Drawing.Size(295, 17)
        Me.lbl_totalQtyPickup.TabIndex = 64
        Me.lbl_totalQtyPickup.Text = "Total Barang:"
        Me.lbl_totalQtyPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(12, 48)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(325, 2)
        Me.Label67.TabIndex = 24
        Me.Label67.Text = resources.GetString("Label67.Text")
        '
        'cbo_metodePembayaranPickup
        '
        Me.cbo_metodePembayaranPickup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_metodePembayaranPickup.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbo_metodePembayaranPickup.FormattingEnabled = True
        Me.cbo_metodePembayaranPickup.Items.AddRange(New Object() {"Tunai", "Non-Tunai"})
        Me.cbo_metodePembayaranPickup.Location = New System.Drawing.Point(143, 378)
        Me.cbo_metodePembayaranPickup.Name = "cbo_metodePembayaranPickup"
        Me.cbo_metodePembayaranPickup.Size = New System.Drawing.Size(180, 26)
        Me.cbo_metodePembayaranPickup.TabIndex = 59
        '
        'btn_simpanPenjualanPickup
        '
        Me.btn_simpanPenjualanPickup.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_simpanPenjualanPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanPenjualanPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpanPenjualanPickup.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanPenjualanPickup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanPenjualanPickup.Location = New System.Drawing.Point(12, 599)
        Me.btn_simpanPenjualanPickup.Name = "btn_simpanPenjualanPickup"
        Me.btn_simpanPenjualanPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanPenjualanPickup.Size = New System.Drawing.Size(325, 40)
        Me.btn_simpanPenjualanPickup.TabIndex = 58
        Me.btn_simpanPenjualanPickup.Text = "Konfirmasi 💸"
        Me.btn_simpanPenjualanPickup.UseVisualStyleBackColor = False
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label68.Location = New System.Drawing.Point(75, 433)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(48, 16)
        Me.Label68.TabIndex = 55
        Me.Label68.Text = "Status:"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbo_statusPenjualanPickup
        '
        Me.cbo_statusPenjualanPickup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statusPenjualanPickup.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbo_statusPenjualanPickup.FormattingEnabled = True
        Me.cbo_statusPenjualanPickup.Items.AddRange(New Object() {"Lunas", "Pending"})
        Me.cbo_statusPenjualanPickup.Location = New System.Drawing.Point(143, 428)
        Me.cbo_statusPenjualanPickup.Name = "cbo_statusPenjualanPickup"
        Me.cbo_statusPenjualanPickup.Size = New System.Drawing.Size(180, 26)
        Me.cbo_statusPenjualanPickup.TabIndex = 52
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label69.Location = New System.Drawing.Point(37, 383)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(83, 16)
        Me.Label69.TabIndex = 53
        Me.Label69.Text = "Pembayaran:"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label70.Location = New System.Drawing.Point(84, 238)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(41, 16)
        Me.Label70.TabIndex = 8
        Me.Label70.Text = "Total:"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subTotalPickup
        '
        Me.lbl_subTotalPickup.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_subTotalPickup.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_subTotalPickup.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_subTotalPickup.Location = New System.Drawing.Point(143, 219)
        Me.lbl_subTotalPickup.Name = "lbl_subTotalPickup"
        Me.lbl_subTotalPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_subTotalPickup.Size = New System.Drawing.Size(180, 27)
        Me.lbl_subTotalPickup.TabIndex = 7
        Me.lbl_subTotalPickup.Text = "00.00"
        Me.lbl_subTotalPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label71.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label71.Location = New System.Drawing.Point(31, 191)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(90, 16)
        Me.Label71.TabIndex = 6
        Me.Label71.Text = "Harga Satuan:"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_hargaSatuanPickup
        '
        Me.lbl_hargaSatuanPickup.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_hargaSatuanPickup.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_hargaSatuanPickup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_hargaSatuanPickup.Location = New System.Drawing.Point(143, 172)
        Me.lbl_hargaSatuanPickup.Name = "lbl_hargaSatuanPickup"
        Me.lbl_hargaSatuanPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_hargaSatuanPickup.Size = New System.Drawing.Size(180, 27)
        Me.lbl_hargaSatuanPickup.TabIndex = 5
        Me.lbl_hargaSatuanPickup.Text = "00.00"
        Me.lbl_hargaSatuanPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label72.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label72.Location = New System.Drawing.Point(44, 146)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(75, 16)
        Me.Label72.TabIndex = 4
        Me.Label72.Text = "Qty Barang:"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_QtyPickup
        '
        Me.lbl_QtyPickup.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_QtyPickup.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_QtyPickup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_QtyPickup.Location = New System.Drawing.Point(143, 135)
        Me.lbl_QtyPickup.Name = "lbl_QtyPickup"
        Me.lbl_QtyPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_QtyPickup.Size = New System.Drawing.Size(180, 27)
        Me.lbl_QtyPickup.TabIndex = 3
        Me.lbl_QtyPickup.Text = "00"
        Me.lbl_QtyPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_grandTotalPickup
        '
        Me.lbl_grandTotalPickup.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_grandTotalPickup.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandTotalPickup.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_grandTotalPickup.Location = New System.Drawing.Point(23, 52)
        Me.lbl_grandTotalPickup.Name = "lbl_grandTotalPickup"
        Me.lbl_grandTotalPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_grandTotalPickup.Size = New System.Drawing.Size(300, 33)
        Me.lbl_grandTotalPickup.TabIndex = 1
        Me.lbl_grandTotalPickup.Text = "00.00"
        Me.lbl_grandTotalPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_noPenjualanPickup
        '
        Me.lbl_noPenjualanPickup.BackColor = System.Drawing.Color.Transparent
        Me.lbl_noPenjualanPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noPenjualanPickup.Location = New System.Drawing.Point(3, 15)
        Me.lbl_noPenjualanPickup.Name = "lbl_noPenjualanPickup"
        Me.lbl_noPenjualanPickup.Size = New System.Drawing.Size(339, 25)
        Me.lbl_noPenjualanPickup.TabIndex = 0
        Me.lbl_noPenjualanPickup.Text = "-"
        Me.lbl_noPenjualanPickup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_danaDiterimaPickup
        '
        Me.txt_danaDiterimaPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_danaDiterimaPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_danaDiterimaPickup.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_danaDiterimaPickup.Location = New System.Drawing.Point(143, 281)
        Me.txt_danaDiterimaPickup.Name = "txt_danaDiterimaPickup"
        Me.txt_danaDiterimaPickup.Size = New System.Drawing.Size(180, 25)
        Me.txt_danaDiterimaPickup.TabIndex = 61
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label73.Location = New System.Drawing.Point(28, 285)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(93, 16)
        Me.Label73.TabIndex = 60
        Me.Label73.Text = "Dana Diterima:"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label74.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label74.Location = New System.Drawing.Point(53, 339)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(71, 16)
        Me.Label74.TabIndex = 57
        Me.Label74.Text = "Kembalian:"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_kembalianPickup
        '
        Me.lbl_kembalianPickup.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_kembalianPickup.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_kembalianPickup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_kembalianPickup.Location = New System.Drawing.Point(143, 320)
        Me.lbl_kembalianPickup.Name = "lbl_kembalianPickup"
        Me.lbl_kembalianPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_kembalianPickup.Size = New System.Drawing.Size(180, 27)
        Me.lbl_kembalianPickup.TabIndex = 56
        Me.lbl_kembalianPickup.Text = "00.00"
        Me.lbl_kembalianPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_satuanBrgPickup)
        Me.GroupBox6.Controls.Add(Me.Label75)
        Me.GroupBox6.Controls.Add(Me.txt_namaBrgPickup)
        Me.GroupBox6.Controls.Add(Me.Label76)
        Me.GroupBox6.Controls.Add(Me.cbo_brgPickup)
        Me.GroupBox6.Controls.Add(Me.Label77)
        Me.GroupBox6.Controls.Add(Me.txt_subTotalPickup)
        Me.GroupBox6.Controls.Add(Me.Label78)
        Me.GroupBox6.Controls.Add(Me.txt_hrgaPickup)
        Me.GroupBox6.Controls.Add(Me.Label79)
        Me.GroupBox6.Controls.Add(Me.txt_qtyPickup)
        Me.GroupBox6.Controls.Add(Me.Label80)
        Me.GroupBox6.Controls.Add(Me.Label81)
        Me.GroupBox6.Controls.Add(Me.btn_tmbhDetBeliPickup)
        Me.GroupBox6.Controls.Add(Me.dgv_detailPenjualanPickup)
        Me.GroupBox6.Location = New System.Drawing.Point(27, 61)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(816, 371)
        Me.GroupBox6.TabIndex = 38
        Me.GroupBox6.TabStop = False
        '
        'txt_satuanBrgPickup
        '
        Me.txt_satuanBrgPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_satuanBrgPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuanBrgPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_satuanBrgPickup.Location = New System.Drawing.Point(116, 153)
        Me.txt_satuanBrgPickup.Name = "txt_satuanBrgPickup"
        Me.txt_satuanBrgPickup.ReadOnly = True
        Me.txt_satuanBrgPickup.Size = New System.Drawing.Size(96, 26)
        Me.txt_satuanBrgPickup.TabIndex = 63
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(519, 22)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(275, 16)
        Me.Label75.TabIndex = 62
        Me.Label75.Text = "*Double klik barang jika ingin hapus barang itu"
        '
        'txt_namaBrgPickup
        '
        Me.txt_namaBrgPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_namaBrgPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_namaBrgPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaBrgPickup.Location = New System.Drawing.Point(16, 98)
        Me.txt_namaBrgPickup.Name = "txt_namaBrgPickup"
        Me.txt_namaBrgPickup.ReadOnly = True
        Me.txt_namaBrgPickup.Size = New System.Drawing.Size(196, 26)
        Me.txt_namaBrgPickup.TabIndex = 61
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(13, 79)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(89, 16)
        Me.Label76.TabIndex = 60
        Me.Label76.Text = "Nama Barang:"
        '
        'cbo_brgPickup
        '
        Me.cbo_brgPickup.FormattingEnabled = True
        Me.cbo_brgPickup.Location = New System.Drawing.Point(16, 41)
        Me.cbo_brgPickup.Name = "cbo_brgPickup"
        Me.cbo_brgPickup.Size = New System.Drawing.Size(196, 26)
        Me.cbo_brgPickup.TabIndex = 37
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(113, 134)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(52, 16)
        Me.Label77.TabIndex = 59
        Me.Label77.Text = "Satuan:"
        '
        'txt_subTotalPickup
        '
        Me.txt_subTotalPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_subTotalPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subTotalPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subTotalPickup.Location = New System.Drawing.Point(16, 266)
        Me.txt_subTotalPickup.Name = "txt_subTotalPickup"
        Me.txt_subTotalPickup.ReadOnly = True
        Me.txt_subTotalPickup.Size = New System.Drawing.Size(196, 26)
        Me.txt_subTotalPickup.TabIndex = 58
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(13, 247)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(59, 16)
        Me.Label78.TabIndex = 57
        Me.Label78.Text = "Subtotal:"
        '
        'txt_hrgaPickup
        '
        Me.txt_hrgaPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaPickup.Location = New System.Drawing.Point(16, 211)
        Me.txt_hrgaPickup.Name = "txt_hrgaPickup"
        Me.txt_hrgaPickup.ReadOnly = True
        Me.txt_hrgaPickup.Size = New System.Drawing.Size(196, 26)
        Me.txt_hrgaPickup.TabIndex = 56
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(13, 192)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(113, 16)
        Me.Label79.TabIndex = 55
        Me.Label79.Text = "Harga per Satuan:"
        '
        'txt_qtyPickup
        '
        Me.txt_qtyPickup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_qtyPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qtyPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtyPickup.Location = New System.Drawing.Point(16, 153)
        Me.txt_qtyPickup.Name = "txt_qtyPickup"
        Me.txt_qtyPickup.Size = New System.Drawing.Size(96, 26)
        Me.txt_qtyPickup.TabIndex = 54
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(13, 134)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(31, 16)
        Me.Label80.TabIndex = 53
        Me.Label80.Text = "Qty:"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(13, 22)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(84, 16)
        Me.Label81.TabIndex = 51
        Me.Label81.Text = "Kode Barang:"
        '
        'btn_tmbhDetBeliPickup
        '
        Me.btn_tmbhDetBeliPickup.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_tmbhDetBeliPickup.FlatAppearance.BorderSize = 0
        Me.btn_tmbhDetBeliPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tmbhDetBeliPickup.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_tmbhDetBeliPickup.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_tmbhDetBeliPickup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetBeliPickup.Location = New System.Drawing.Point(16, 318)
        Me.btn_tmbhDetBeliPickup.Name = "btn_tmbhDetBeliPickup"
        Me.btn_tmbhDetBeliPickup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhDetBeliPickup.Size = New System.Drawing.Size(196, 29)
        Me.btn_tmbhDetBeliPickup.TabIndex = 50
        Me.btn_tmbhDetBeliPickup.Text = "➕ Tambah Barang"
        Me.btn_tmbhDetBeliPickup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetBeliPickup.UseVisualStyleBackColor = False
        '
        'dgv_detailPenjualanPickup
        '
        Me.dgv_detailPenjualanPickup.AllowUserToAddRows = False
        Me.dgv_detailPenjualanPickup.AllowUserToDeleteRows = False
        Me.dgv_detailPenjualanPickup.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detailPenjualanPickup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detailPenjualanPickup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.colKodeBarang, Me.colNmaBarangPickup, Me.colQtyPickup, Me.colSatuanPickup, Me.colHargaPickup, Me.colSubtotalPickup})
        Me.dgv_detailPenjualanPickup.Location = New System.Drawing.Point(226, 41)
        Me.dgv_detailPenjualanPickup.Name = "dgv_detailPenjualanPickup"
        Me.dgv_detailPenjualanPickup.ReadOnly = True
        Me.dgv_detailPenjualanPickup.RowHeadersVisible = False
        Me.dgv_detailPenjualanPickup.Size = New System.Drawing.Size(568, 306)
        Me.dgv_detailPenjualanPickup.TabIndex = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "#"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 40
        '
        'colKodeBarang
        '
        Me.colKodeBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colKodeBarang.HeaderText = "Kode"
        Me.colKodeBarang.Name = "colKodeBarang"
        Me.colKodeBarang.ReadOnly = True
        Me.colKodeBarang.Width = 66
        '
        'colNmaBarangPickup
        '
        Me.colNmaBarangPickup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNmaBarangPickup.HeaderText = "Nama"
        Me.colNmaBarangPickup.Name = "colNmaBarangPickup"
        Me.colNmaBarangPickup.ReadOnly = True
        '
        'colQtyPickup
        '
        Me.colQtyPickup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colQtyPickup.HeaderText = "Qty"
        Me.colQtyPickup.Name = "colQtyPickup"
        Me.colQtyPickup.ReadOnly = True
        Me.colQtyPickup.Width = 57
        '
        'colSatuanPickup
        '
        Me.colSatuanPickup.HeaderText = "Satuan"
        Me.colSatuanPickup.Name = "colSatuanPickup"
        Me.colSatuanPickup.ReadOnly = True
        '
        'colHargaPickup
        '
        Me.colHargaPickup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaPickup.HeaderText = "Harga"
        Me.colHargaPickup.Name = "colHargaPickup"
        Me.colHargaPickup.ReadOnly = True
        Me.colHargaPickup.Width = 72
        '
        'colSubtotalPickup
        '
        Me.colSubtotalPickup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSubtotalPickup.HeaderText = "Subtotal"
        Me.colSubtotalPickup.Name = "colSubtotalPickup"
        Me.colSubtotalPickup.ReadOnly = True
        Me.colSubtotalPickup.Width = 85
        '
        'dtp_tglJualPickup
        '
        Me.dtp_tglJualPickup.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_tglJualPickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglJualPickup.Location = New System.Drawing.Point(156, 25)
        Me.dtp_tglJualPickup.Name = "dtp_tglJualPickup"
        Me.dtp_tglJualPickup.Size = New System.Drawing.Size(175, 25)
        Me.dtp_tglJualPickup.TabIndex = 32
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label82.Location = New System.Drawing.Point(18, 30)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(132, 18)
        Me.Label82.TabIndex = 30
        Me.Label82.Text = "Tanggal Penjualan:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label83.Location = New System.Drawing.Point(353, 30)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(103, 18)
        Me.Label83.TabIndex = 37
        Me.Label83.Text = "No. Penjualan:"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox3)
        Me.TabPage7.Controls.Add(Me.Label42)
        Me.TabPage7.Controls.Add(Me.txtJenisDelivery)
        Me.TabPage7.Controls.Add(Me.txt_noPenjualanDelivery)
        Me.TabPage7.Controls.Add(Me.Panel10)
        Me.TabPage7.Controls.Add(Me.GroupBox4)
        Me.TabPage7.Controls.Add(Me.dtp_tglJualDelivery)
        Me.TabPage7.Controls.Add(Me.Label59)
        Me.TabPage7.Controls.Add(Me.Label60)
        Me.TabPage7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage7.Location = New System.Drawing.Point(4, 41)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage7.TabIndex = 9
        Me.TabPage7.Text = "Delivery Baru"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancelDelivery)
        Me.GroupBox3.Controls.Add(Me.pic_barcodePenjualanDelivery)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.cbo_statusDelivery)
        Me.GroupBox3.Controls.Add(Me.txt_alamatDelivery)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.txt_kontakDelivery)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.txt_atasNamaDelivery)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 438)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(816, 201)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
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
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(476, 22)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(58, 16)
        Me.Label37.TabIndex = 70
        Me.Label37.Text = "Barcode:"
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
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(13, 138)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(97, 16)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Status Delivery:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(223, 22)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(52, 16)
        Me.Label39.TabIndex = 68
        Me.Label39.Text = "Alamat:"
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
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(13, 80)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(108, 16)
        Me.Label40.TabIndex = 66
        Me.Label40.Text = "Kontak Penerima:"
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
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(13, 22)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(74, 16)
        Me.Label41.TabIndex = 64
        Me.Label41.Text = "Atas Nama:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label42.Location = New System.Drawing.Point(664, 30)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(111, 18)
        Me.Label42.TabIndex = 42
        Me.Label42.Text = "Jenis Penjualan:"
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
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Window
        Me.Panel10.Controls.Add(Me.txt_catatanDelivery)
        Me.Panel10.Controls.Add(Me.Label43)
        Me.Panel10.Controls.Add(Me.lbl_totalQtyDelivery)
        Me.Panel10.Controls.Add(Me.Label44)
        Me.Panel10.Controls.Add(Me.cbo_metodePembayaranDelivery)
        Me.Panel10.Controls.Add(Me.btn_simpanPenjualanDelivery)
        Me.Panel10.Controls.Add(Me.Label45)
        Me.Panel10.Controls.Add(Me.cbo_statusPenjualanDelivery)
        Me.Panel10.Controls.Add(Me.Label46)
        Me.Panel10.Controls.Add(Me.Label47)
        Me.Panel10.Controls.Add(Me.lbl_subTotalDelivery)
        Me.Panel10.Controls.Add(Me.Label48)
        Me.Panel10.Controls.Add(Me.lbl_hargaSatuanDelivery)
        Me.Panel10.Controls.Add(Me.Label49)
        Me.Panel10.Controls.Add(Me.lbl_QtyDelivery)
        Me.Panel10.Controls.Add(Me.lbl_grandTotalDelivery)
        Me.Panel10.Controls.Add(Me.lbl_noPenjualanDelivery)
        Me.Panel10.Controls.Add(Me.txt_danaDiterimaDelivery)
        Me.Panel10.Controls.Add(Me.Label50)
        Me.Panel10.Controls.Add(Me.Label51)
        Me.Panel10.Controls.Add(Me.lbl_kembalianDelivery)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(865, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(345, 635)
        Me.Panel10.TabIndex = 39
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
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label43.Location = New System.Drawing.Point(66, 479)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(56, 16)
        Me.Label43.TabIndex = 65
        Me.Label43.Text = "Catatan:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalQtyDelivery
        '
        Me.lbl_totalQtyDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_totalQtyDelivery.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lbl_totalQtyDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_totalQtyDelivery.Location = New System.Drawing.Point(23, 88)
        Me.lbl_totalQtyDelivery.Name = "lbl_totalQtyDelivery"
        Me.lbl_totalQtyDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_totalQtyDelivery.Size = New System.Drawing.Size(295, 17)
        Me.lbl_totalQtyDelivery.TabIndex = 64
        Me.lbl_totalQtyDelivery.Text = "Total Barang:"
        Me.lbl_totalQtyDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(12, 48)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(325, 2)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = resources.GetString("Label44.Text")
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
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label45.Location = New System.Drawing.Point(75, 433)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 16)
        Me.Label45.TabIndex = 55
        Me.Label45.Text = "Status:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label46.Location = New System.Drawing.Point(37, 383)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(83, 16)
        Me.Label46.TabIndex = 53
        Me.Label46.Text = "Pembayaran:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(84, 238)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(41, 16)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "Total:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subTotalDelivery
        '
        Me.lbl_subTotalDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_subTotalDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_subTotalDelivery.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_subTotalDelivery.Location = New System.Drawing.Point(143, 219)
        Me.lbl_subTotalDelivery.Name = "lbl_subTotalDelivery"
        Me.lbl_subTotalDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_subTotalDelivery.Size = New System.Drawing.Size(180, 27)
        Me.lbl_subTotalDelivery.TabIndex = 7
        Me.lbl_subTotalDelivery.Text = "00.00"
        Me.lbl_subTotalDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(31, 191)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(90, 16)
        Me.Label48.TabIndex = 6
        Me.Label48.Text = "Harga Satuan:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_hargaSatuanDelivery
        '
        Me.lbl_hargaSatuanDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_hargaSatuanDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_hargaSatuanDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_hargaSatuanDelivery.Location = New System.Drawing.Point(143, 172)
        Me.lbl_hargaSatuanDelivery.Name = "lbl_hargaSatuanDelivery"
        Me.lbl_hargaSatuanDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_hargaSatuanDelivery.Size = New System.Drawing.Size(180, 27)
        Me.lbl_hargaSatuanDelivery.TabIndex = 5
        Me.lbl_hargaSatuanDelivery.Text = "00.00"
        Me.lbl_hargaSatuanDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(44, 146)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(75, 16)
        Me.Label49.TabIndex = 4
        Me.Label49.Text = "Qty Barang:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_QtyDelivery
        '
        Me.lbl_QtyDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_QtyDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_QtyDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_QtyDelivery.Location = New System.Drawing.Point(143, 135)
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
        Me.lbl_grandTotalDelivery.Location = New System.Drawing.Point(23, 52)
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
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label50.Location = New System.Drawing.Point(28, 285)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(93, 16)
        Me.Label50.TabIndex = 60
        Me.Label50.Text = "Dana Diterima:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label51.Location = New System.Drawing.Point(53, 339)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(71, 16)
        Me.Label51.TabIndex = 57
        Me.Label51.Text = "Kembalian:"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_kembalianDelivery
        '
        Me.lbl_kembalianDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_kembalianDelivery.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_kembalianDelivery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_kembalianDelivery.Location = New System.Drawing.Point(143, 320)
        Me.lbl_kembalianDelivery.Name = "lbl_kembalianDelivery"
        Me.lbl_kembalianDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_kembalianDelivery.Size = New System.Drawing.Size(180, 27)
        Me.lbl_kembalianDelivery.TabIndex = 56
        Me.lbl_kembalianDelivery.Text = "00.00"
        Me.lbl_kembalianDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_satuanBrgDelivery)
        Me.GroupBox4.Controls.Add(Me.Label52)
        Me.GroupBox4.Controls.Add(Me.txt_namaBrgDelivery)
        Me.GroupBox4.Controls.Add(Me.Label53)
        Me.GroupBox4.Controls.Add(Me.cbo_brgDelivery)
        Me.GroupBox4.Controls.Add(Me.Label54)
        Me.GroupBox4.Controls.Add(Me.txt_subTotalDelivery)
        Me.GroupBox4.Controls.Add(Me.Label55)
        Me.GroupBox4.Controls.Add(Me.txt_hrgaDelivery)
        Me.GroupBox4.Controls.Add(Me.Label56)
        Me.GroupBox4.Controls.Add(Me.txt_qtyDelivery)
        Me.GroupBox4.Controls.Add(Me.Label57)
        Me.GroupBox4.Controls.Add(Me.Label58)
        Me.GroupBox4.Controls.Add(Me.btn_tmbhDetBeliDelivery)
        Me.GroupBox4.Controls.Add(Me.dgv_detailPenjualanDelivery)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 61)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(816, 371)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
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
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(519, 22)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(275, 16)
        Me.Label52.TabIndex = 62
        Me.Label52.Text = "*Double klik barang jika ingin hapus barang itu"
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
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(13, 79)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(89, 16)
        Me.Label53.TabIndex = 60
        Me.Label53.Text = "Nama Barang:"
        '
        'cbo_brgDelivery
        '
        Me.cbo_brgDelivery.FormattingEnabled = True
        Me.cbo_brgDelivery.Location = New System.Drawing.Point(16, 41)
        Me.cbo_brgDelivery.Name = "cbo_brgDelivery"
        Me.cbo_brgDelivery.Size = New System.Drawing.Size(196, 26)
        Me.cbo_brgDelivery.TabIndex = 37
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(113, 134)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(52, 16)
        Me.Label54.TabIndex = 59
        Me.Label54.Text = "Satuan:"
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
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(13, 247)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(59, 16)
        Me.Label55.TabIndex = 57
        Me.Label55.Text = "Subtotal:"
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
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(13, 192)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(113, 16)
        Me.Label56.TabIndex = 55
        Me.Label56.Text = "Harga per Satuan:"
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
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(13, 134)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(31, 16)
        Me.Label57.TabIndex = 53
        Me.Label57.Text = "Qty:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(13, 22)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(84, 16)
        Me.Label58.TabIndex = 51
        Me.Label58.Text = "Kode Barang:"
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
        Me.dgv_detailPenjualanDelivery.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.colKodeBrgDelivery, Me.colNmaBrgDelivery, Me.colQtyDelivery, Me.colSatuanDelivery, Me.colHargaDelivery, Me.colSubtotalDelivery})
        Me.dgv_detailPenjualanDelivery.Location = New System.Drawing.Point(226, 41)
        Me.dgv_detailPenjualanDelivery.Name = "dgv_detailPenjualanDelivery"
        Me.dgv_detailPenjualanDelivery.ReadOnly = True
        Me.dgv_detailPenjualanDelivery.RowHeadersVisible = False
        Me.dgv_detailPenjualanDelivery.Size = New System.Drawing.Size(568, 306)
        Me.dgv_detailPenjualanDelivery.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'colKodeBrgDelivery
        '
        Me.colKodeBrgDelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colKodeBrgDelivery.HeaderText = "Kode"
        Me.colKodeBrgDelivery.Name = "colKodeBrgDelivery"
        Me.colKodeBrgDelivery.ReadOnly = True
        Me.colKodeBrgDelivery.Width = 66
        '
        'colNmaBrgDelivery
        '
        Me.colNmaBrgDelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNmaBrgDelivery.HeaderText = "Nama"
        Me.colNmaBrgDelivery.Name = "colNmaBrgDelivery"
        Me.colNmaBrgDelivery.ReadOnly = True
        '
        'colQtyDelivery
        '
        Me.colQtyDelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colQtyDelivery.HeaderText = "Qty"
        Me.colQtyDelivery.Name = "colQtyDelivery"
        Me.colQtyDelivery.ReadOnly = True
        Me.colQtyDelivery.Width = 57
        '
        'colSatuanDelivery
        '
        Me.colSatuanDelivery.HeaderText = "Satuan"
        Me.colSatuanDelivery.Name = "colSatuanDelivery"
        Me.colSatuanDelivery.ReadOnly = True
        '
        'colHargaDelivery
        '
        Me.colHargaDelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaDelivery.HeaderText = "Harga"
        Me.colHargaDelivery.Name = "colHargaDelivery"
        Me.colHargaDelivery.ReadOnly = True
        Me.colHargaDelivery.Width = 72
        '
        'colSubtotalDelivery
        '
        Me.colSubtotalDelivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSubtotalDelivery.HeaderText = "Subtotal"
        Me.colSubtotalDelivery.Name = "colSubtotalDelivery"
        Me.colSubtotalDelivery.ReadOnly = True
        Me.colSubtotalDelivery.Width = 85
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
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label59.Location = New System.Drawing.Point(18, 30)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(132, 18)
        Me.Label59.TabIndex = 30
        Me.Label59.Text = "Tanggal Penjualan:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label60.Location = New System.Drawing.Point(353, 30)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(103, 18)
        Me.Label60.TabIndex = 37
        Me.Label60.Text = "No. Penjualan:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_listPenjualan)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Semua Penjualan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_listPenjualan
        '
        Me.dgv_listPenjualan.AllowUserToAddRows = False
        Me.dgv_listPenjualan.AllowUserToDeleteRows = False
        Me.dgv_listPenjualan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_listPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listPenjualan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNmr, Me.colNoPenjualan, Me.colJenisPenjualan, Me.colTgl, Me.colTotalPenjualan, Me.colDanaDiterima, Me.colKembalian, Me.colMetodePembayaran, Me.colStatus, Me.colCatatan})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listPenjualan.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_listPenjualan.Location = New System.Drawing.Point(3, 53)
        Me.dgv_listPenjualan.Name = "dgv_listPenjualan"
        Me.dgv_listPenjualan.ReadOnly = True
        Me.dgv_listPenjualan.RowHeadersVisible = False
        Me.dgv_listPenjualan.Size = New System.Drawing.Size(854, 579)
        Me.dgv_listPenjualan.TabIndex = 22
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
        'colJenisPenjualan
        '
        Me.colJenisPenjualan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colJenisPenjualan.HeaderText = "Jenis"
        Me.colJenisPenjualan.Name = "colJenisPenjualan"
        Me.colJenisPenjualan.ReadOnly = True
        Me.colJenisPenjualan.Width = 64
        '
        'colTgl
        '
        Me.colTgl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTgl.HeaderText = "Tgl"
        Me.colTgl.Name = "colTgl"
        Me.colTgl.ReadOnly = True
        Me.colTgl.Width = 53
        '
        'colTotalPenjualan
        '
        Me.colTotalPenjualan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTotalPenjualan.HeaderText = "Total"
        Me.colTotalPenjualan.Name = "colTotalPenjualan"
        Me.colTotalPenjualan.ReadOnly = True
        Me.colTotalPenjualan.Width = 66
        '
        'colDanaDiterima
        '
        Me.colDanaDiterima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDanaDiterima.HeaderText = "Dana Diterima"
        Me.colDanaDiterima.Name = "colDanaDiterima"
        Me.colDanaDiterima.ReadOnly = True
        Me.colDanaDiterima.Width = 125
        '
        'colKembalian
        '
        Me.colKembalian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colKembalian.HeaderText = "Kembalian"
        Me.colKembalian.Name = "colKembalian"
        Me.colKembalian.ReadOnly = True
        Me.colKembalian.Width = 99
        '
        'colMetodePembayaran
        '
        Me.colMetodePembayaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMetodePembayaran.HeaderText = "Metode"
        Me.colMetodePembayaran.Name = "colMetodePembayaran"
        Me.colMetodePembayaran.ReadOnly = True
        Me.colMetodePembayaran.Width = 82
        '
        'colStatus
        '
        Me.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 74
        '
        'colCatatan
        '
        Me.colCatatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colCatatan.HeaderText = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txt_cariPenjualan)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(854, 50)
        Me.Panel4.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Search Penjualan:"
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Window
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_jenisJual)
        Me.Panel5.Controls.Add(Me.lbl_catatan)
        Me.Panel5.Controls.Add(Me.lbl_kembalian)
        Me.Panel5.Controls.Add(Me.lbl_danaDiterima)
        Me.Panel5.Controls.Add(Me.pnl_listDetail)
        Me.Panel5.Controls.Add(Me.lbl_statusJual)
        Me.Panel5.Controls.Add(Me.lbl_metodeJual)
        Me.Panel5.Controls.Add(Me.lbl_totalJual)
        Me.Panel5.Controls.Add(Me.lbl_tglJual)
        Me.Panel5.Controls.Add(Me.lbl_noJual)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(857, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(350, 629)
        Me.Panel5.TabIndex = 24
        '
        'lbl_jenisJual
        '
        Me.lbl_jenisJual.AutoSize = True
        Me.lbl_jenisJual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jenisJual.Location = New System.Drawing.Point(11, 260)
        Me.lbl_jenisJual.Name = "lbl_jenisJual"
        Me.lbl_jenisJual.Size = New System.Drawing.Size(13, 18)
        Me.lbl_jenisJual.TabIndex = 39
        Me.lbl_jenisJual.Text = "-"
        '
        'lbl_catatan
        '
        Me.lbl_catatan.AutoSize = True
        Me.lbl_catatan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_catatan.Location = New System.Drawing.Point(11, 232)
        Me.lbl_catatan.Name = "lbl_catatan"
        Me.lbl_catatan.Size = New System.Drawing.Size(13, 18)
        Me.lbl_catatan.TabIndex = 38
        Me.lbl_catatan.Text = "-"
        '
        'lbl_kembalian
        '
        Me.lbl_kembalian.AutoSize = True
        Me.lbl_kembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kembalian.Location = New System.Drawing.Point(11, 204)
        Me.lbl_kembalian.Name = "lbl_kembalian"
        Me.lbl_kembalian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_kembalian.TabIndex = 37
        Me.lbl_kembalian.Text = "-"
        '
        'lbl_danaDiterima
        '
        Me.lbl_danaDiterima.AutoSize = True
        Me.lbl_danaDiterima.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_danaDiterima.Location = New System.Drawing.Point(11, 176)
        Me.lbl_danaDiterima.Name = "lbl_danaDiterima"
        Me.lbl_danaDiterima.Size = New System.Drawing.Size(13, 18)
        Me.lbl_danaDiterima.TabIndex = 36
        Me.lbl_danaDiterima.Text = "-"
        '
        'pnl_listDetail
        '
        Me.pnl_listDetail.Controls.Add(Me.Label2)
        Me.pnl_listDetail.Controls.Add(Me.rtb_detailPenjualan)
        Me.pnl_listDetail.Controls.Add(Me.Label3)
        Me.pnl_listDetail.Controls.Add(Me.Label20)
        Me.pnl_listDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_listDetail.Location = New System.Drawing.Point(0, 289)
        Me.pnl_listDetail.Name = "pnl_listDetail"
        Me.pnl_listDetail.Size = New System.Drawing.Size(348, 338)
        Me.pnl_listDetail.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 1)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'rtb_detailPenjualan
        '
        Me.rtb_detailPenjualan.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_detailPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_detailPenjualan.Location = New System.Drawing.Point(14, 42)
        Me.rtb_detailPenjualan.Name = "rtb_detailPenjualan"
        Me.rtb_detailPenjualan.ReadOnly = True
        Me.rtb_detailPenjualan.Size = New System.Drawing.Size(322, 318)
        Me.rtb_detailPenjualan.TabIndex = 32
        Me.rtb_detailPenjualan.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(1, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(346, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Detail List Barang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lbl_statusJual
        '
        Me.lbl_statusJual.AutoSize = True
        Me.lbl_statusJual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusJual.Location = New System.Drawing.Point(11, 148)
        Me.lbl_statusJual.Name = "lbl_statusJual"
        Me.lbl_statusJual.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusJual.TabIndex = 31
        Me.lbl_statusJual.Text = "-"
        '
        'lbl_metodeJual
        '
        Me.lbl_metodeJual.AutoSize = True
        Me.lbl_metodeJual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodeJual.Location = New System.Drawing.Point(11, 120)
        Me.lbl_metodeJual.Name = "lbl_metodeJual"
        Me.lbl_metodeJual.Size = New System.Drawing.Size(13, 18)
        Me.lbl_metodeJual.TabIndex = 30
        Me.lbl_metodeJual.Text = "-"
        '
        'lbl_totalJual
        '
        Me.lbl_totalJual.AutoSize = True
        Me.lbl_totalJual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalJual.Location = New System.Drawing.Point(11, 92)
        Me.lbl_totalJual.Name = "lbl_totalJual"
        Me.lbl_totalJual.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalJual.TabIndex = 29
        Me.lbl_totalJual.Text = "-"
        '
        'lbl_tglJual
        '
        Me.lbl_tglJual.AutoSize = True
        Me.lbl_tglJual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tglJual.Location = New System.Drawing.Point(11, 64)
        Me.lbl_tglJual.Name = "lbl_tglJual"
        Me.lbl_tglJual.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tglJual.TabIndex = 28
        Me.lbl_tglJual.Text = "-"
        '
        'lbl_noJual
        '
        Me.lbl_noJual.AutoSize = True
        Me.lbl_noJual.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noJual.Location = New System.Drawing.Point(11, 36)
        Me.lbl_noJual.Name = "lbl_noJual"
        Me.lbl_noJual.Size = New System.Drawing.Size(13, 18)
        Me.lbl_noJual.TabIndex = 27
        Me.lbl_noJual.Text = "-"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label24.Location = New System.Drawing.Point(0, 3)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(348, 18)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "Informasi Penjualan"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(0, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(390, 1)
        Me.Label28.TabIndex = 25
        Me.Label28.Text = resources.GetString("Label28.Text")
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgv_listPenjualanPending)
        Me.TabPage4.Controls.Add(Me.Panel2)
        Me.TabPage4.Controls.Add(Me.Panel7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 41)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage4.TabIndex = 6
        Me.TabPage4.Text = "Penjualan PENDING"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgv_listPenjualanPending
        '
        Me.dgv_listPenjualanPending.AllowUserToAddRows = False
        Me.dgv_listPenjualanPending.AllowUserToDeleteRows = False
        Me.dgv_listPenjualanPending.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_listPenjualanPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listPenjualanPending.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_listPenjualanPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listPenjualanPending.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.colNoPenjualanPending, Me.colJenis, Me.colTglPembelian, Me.colTotalPenjualanPending, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listPenjualanPending.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_listPenjualanPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_listPenjualanPending.Location = New System.Drawing.Point(3, 53)
        Me.dgv_listPenjualanPending.Name = "dgv_listPenjualanPending"
        Me.dgv_listPenjualanPending.ReadOnly = True
        Me.dgv_listPenjualanPending.RowHeadersVisible = False
        Me.dgv_listPenjualanPending.Size = New System.Drawing.Size(812, 579)
        Me.dgv_listPenjualanPending.TabIndex = 21
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
        'colNoPenjualanPending
        '
        Me.colNoPenjualanPending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNoPenjualanPending.HeaderText = "No. Penjualan"
        Me.colNoPenjualanPending.MinimumWidth = 154
        Me.colNoPenjualanPending.Name = "colNoPenjualanPending"
        Me.colNoPenjualanPending.ReadOnly = True
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
        'colTotalPenjualanPending
        '
        Me.colTotalPenjualanPending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTotalPenjualanPending.HeaderText = "Total"
        Me.colTotalPenjualanPending.MinimumWidth = 105
        Me.colTotalPenjualanPending.Name = "colTotalPenjualanPending"
        Me.colTotalPenjualanPending.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dana Diterima"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kembalian"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Metode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 82
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "Catatan"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 84
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(812, 50)
        Me.Panel2.TabIndex = 22
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Search Penjualan:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.lbl_catatanPending)
        Me.Panel7.Controls.Add(Me.lbl_alamatJualPending)
        Me.Panel7.Controls.Add(Me.lbl_statusKirimPending)
        Me.Panel7.Controls.Add(Me.lbl_kontakPending)
        Me.Panel7.Controls.Add(Me.lbl_atasNamaPending)
        Me.Panel7.Controls.Add(Me.lbl_jenisJualPending)
        Me.Panel7.Controls.Add(Me.lbl_statusJualPending)
        Me.Panel7.Controls.Add(Me.lbl_metodeJualPending)
        Me.Panel7.Controls.Add(Me.lbl_totalJualPending)
        Me.Panel7.Controls.Add(Me.lbl_tglJualPending)
        Me.Panel7.Controls.Add(Me.lbl_noJualPending)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Label35)
        Me.Panel7.Controls.Add(Me.Label36)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(815, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(392, 629)
        Me.Panel7.TabIndex = 23
        '
        'lbl_catatanPending
        '
        Me.lbl_catatanPending.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_catatanPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_catatanPending.Location = New System.Drawing.Point(12, 188)
        Me.lbl_catatanPending.Name = "lbl_catatanPending"
        Me.lbl_catatanPending.ReadOnly = True
        Me.lbl_catatanPending.Size = New System.Drawing.Size(178, 47)
        Me.lbl_catatanPending.TabIndex = 57
        Me.lbl_catatanPending.Text = ""
        '
        'lbl_alamatJualPending
        '
        Me.lbl_alamatJualPending.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_alamatJualPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_alamatJualPending.Location = New System.Drawing.Point(200, 166)
        Me.lbl_alamatJualPending.Name = "lbl_alamatJualPending"
        Me.lbl_alamatJualPending.ReadOnly = True
        Me.lbl_alamatJualPending.Size = New System.Drawing.Size(176, 84)
        Me.lbl_alamatJualPending.TabIndex = 56
        Me.lbl_alamatJualPending.Text = ""
        '
        'lbl_statusKirimPending
        '
        Me.lbl_statusKirimPending.AutoSize = True
        Me.lbl_statusKirimPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusKirimPending.Location = New System.Drawing.Point(197, 127)
        Me.lbl_statusKirimPending.Name = "lbl_statusKirimPending"
        Me.lbl_statusKirimPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusKirimPending.TabIndex = 55
        Me.lbl_statusKirimPending.Text = "-"
        '
        'lbl_kontakPending
        '
        Me.lbl_kontakPending.AutoSize = True
        Me.lbl_kontakPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kontakPending.Location = New System.Drawing.Point(197, 97)
        Me.lbl_kontakPending.Name = "lbl_kontakPending"
        Me.lbl_kontakPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_kontakPending.TabIndex = 54
        Me.lbl_kontakPending.Text = "-"
        '
        'lbl_atasNamaPending
        '
        Me.lbl_atasNamaPending.AutoSize = True
        Me.lbl_atasNamaPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_atasNamaPending.Location = New System.Drawing.Point(197, 67)
        Me.lbl_atasNamaPending.Name = "lbl_atasNamaPending"
        Me.lbl_atasNamaPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_atasNamaPending.TabIndex = 53
        Me.lbl_atasNamaPending.Text = "-"
        '
        'lbl_jenisJualPending
        '
        Me.lbl_jenisJualPending.AutoSize = True
        Me.lbl_jenisJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jenisJualPending.Location = New System.Drawing.Point(11, 258)
        Me.lbl_jenisJualPending.Name = "lbl_jenisJualPending"
        Me.lbl_jenisJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_jenisJualPending.TabIndex = 52
        Me.lbl_jenisJualPending.Text = "-"
        '
        'lbl_statusJualPending
        '
        Me.lbl_statusJualPending.AutoSize = True
        Me.lbl_statusJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusJualPending.Location = New System.Drawing.Point(11, 156)
        Me.lbl_statusJualPending.Name = "lbl_statusJualPending"
        Me.lbl_statusJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusJualPending.TabIndex = 51
        Me.lbl_statusJualPending.Text = "-"
        '
        'lbl_metodeJualPending
        '
        Me.lbl_metodeJualPending.AutoSize = True
        Me.lbl_metodeJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodeJualPending.Location = New System.Drawing.Point(11, 127)
        Me.lbl_metodeJualPending.Name = "lbl_metodeJualPending"
        Me.lbl_metodeJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_metodeJualPending.TabIndex = 50
        Me.lbl_metodeJualPending.Text = "-"
        '
        'lbl_totalJualPending
        '
        Me.lbl_totalJualPending.AutoSize = True
        Me.lbl_totalJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalJualPending.Location = New System.Drawing.Point(11, 97)
        Me.lbl_totalJualPending.Name = "lbl_totalJualPending"
        Me.lbl_totalJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalJualPending.TabIndex = 49
        Me.lbl_totalJualPending.Text = "-"
        '
        'lbl_tglJualPending
        '
        Me.lbl_tglJualPending.AutoSize = True
        Me.lbl_tglJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tglJualPending.Location = New System.Drawing.Point(11, 67)
        Me.lbl_tglJualPending.Name = "lbl_tglJualPending"
        Me.lbl_tglJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tglJualPending.TabIndex = 48
        Me.lbl_tglJualPending.Text = "-"
        '
        'lbl_noJualPending
        '
        Me.lbl_noJualPending.AutoSize = True
        Me.lbl_noJualPending.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noJualPending.Location = New System.Drawing.Point(11, 37)
        Me.lbl_noJualPending.Name = "lbl_noJualPending"
        Me.lbl_noJualPending.Size = New System.Drawing.Size(13, 18)
        Me.lbl_noJualPending.TabIndex = 47
        Me.lbl_noJualPending.Text = "-"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label32)
        Me.Panel8.Controls.Add(Me.rtb_detailPenjualanPending)
        Me.Panel8.Controls.Add(Me.Label33)
        Me.Panel8.Controls.Add(Me.Label34)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 278)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(390, 302)
        Me.Panel8.TabIndex = 21
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(0, 1)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(390, 1)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = resources.GetString("Label32.Text")
        '
        'rtb_detailPenjualanPending
        '
        Me.rtb_detailPenjualanPending.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_detailPenjualanPending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_detailPenjualanPending.Location = New System.Drawing.Point(14, 42)
        Me.rtb_detailPenjualanPending.Name = "rtb_detailPenjualanPending"
        Me.rtb_detailPenjualanPending.ReadOnly = True
        Me.rtb_detailPenjualanPending.Size = New System.Drawing.Size(362, 270)
        Me.rtb_detailPenjualanPending.TabIndex = 32
        Me.rtb_detailPenjualanPending.Text = ""
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label33.Location = New System.Drawing.Point(131, 7)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(142, 18)
        Me.Label33.TabIndex = 30
        Me.Label33.Text = "Detail List Barang"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(0, 30)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(390, 1)
        Me.Label34.TabIndex = 31
        Me.Label34.Text = resources.GetString("Label34.Text")
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label35.Location = New System.Drawing.Point(-1, 3)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(392, 18)
        Me.Label35.TabIndex = 26
        Me.Label35.Text = "Informasi Penjualan"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(0, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(390, 1)
        Me.Label36.TabIndex = 25
        Me.Label36.Text = resources.GetString("Label36.Text")
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btn_clearPenjualanPending)
        Me.Panel9.Controls.Add(Me.btn_updateLunasPenjualan)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 580)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(390, 47)
        Me.Panel9.TabIndex = 35
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
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Uang Kecil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_resetDanaKecil)
        Me.GroupBox1.Controls.Add(Me.btn_konfirmasiUangKecil)
        Me.GroupBox1.Controls.Add(Me.txt_danaUangKecil)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_tglUangKecil)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 100)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dana Uang Kecil Hari Ini:"
        '
        'btn_resetDanaKecil
        '
        Me.btn_resetDanaKecil.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_resetDanaKecil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resetDanaKecil.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_resetDanaKecil.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_resetDanaKecil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_resetDanaKecil.Location = New System.Drawing.Point(841, 39)
        Me.btn_resetDanaKecil.Name = "btn_resetDanaKecil"
        Me.btn_resetDanaKecil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_resetDanaKecil.Size = New System.Drawing.Size(93, 30)
        Me.btn_resetDanaKecil.TabIndex = 62
        Me.btn_resetDanaKecil.Text = "Reset 🗑️"
        Me.btn_resetDanaKecil.UseVisualStyleBackColor = False
        '
        'btn_konfirmasiUangKecil
        '
        Me.btn_konfirmasiUangKecil.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_konfirmasiUangKecil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_konfirmasiUangKecil.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_konfirmasiUangKecil.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_konfirmasiUangKecil.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_konfirmasiUangKecil.Location = New System.Drawing.Point(724, 39)
        Me.btn_konfirmasiUangKecil.Name = "btn_konfirmasiUangKecil"
        Me.btn_konfirmasiUangKecil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_konfirmasiUangKecil.Size = New System.Drawing.Size(111, 30)
        Me.btn_konfirmasiUangKecil.TabIndex = 61
        Me.btn_konfirmasiUangKecil.Text = "Konfirmasi 💾"
        Me.btn_konfirmasiUangKecil.UseVisualStyleBackColor = False
        '
        'txt_danaUangKecil
        '
        Me.txt_danaUangKecil.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_danaUangKecil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_danaUangKecil.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_danaUangKecil.Location = New System.Drawing.Point(497, 41)
        Me.txt_danaUangKecil.Name = "txt_danaUangKecil"
        Me.txt_danaUangKecil.Size = New System.Drawing.Size(200, 26)
        Me.txt_danaUangKecil.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(322, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Jumlah Dana Uang Kecil:"
        '
        'dtp_tglUangKecil
        '
        Me.dtp_tglUangKecil.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtp_tglUangKecil.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.dtp_tglUangKecil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglUangKecil.Location = New System.Drawing.Point(90, 41)
        Me.dtp_tglUangKecil.Name = "dtp_tglUangKecil"
        Me.dtp_tglUangKecil.Size = New System.Drawing.Size(200, 26)
        Me.dtp_tglUangKecil.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(19, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Tanggal:"
        '
        'frm_ManagePenjualan
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
        Me.Name = "frm_ManagePenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ManagePenjualan"
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detailPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.pic_barcodePenjualanPickup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgv_detailPenjualanPickup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pic_barcodePenjualanDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_detailPenjualanDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_listPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnl_listDetail.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgv_listPenjualanPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents btnPembelian As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnStokBarang As Button
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnManageUser As Button
    Friend WithEvents btnPengembalian As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKembali As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtjenisPenjualan As TextBox
    Friend WithEvents txt_noPenjualan As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_catatan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_totalQty As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_danaDiterimaLangsung As TextBox
    Friend WithEvents cbo_metodePembayaran As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents btn_simpanPenjualan As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_kembalianLangsung As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbo_statusPenjualan As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_subTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_hargaSatuan As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_Qty As Label
    Friend WithEvents lbl_grandTotal As Label
    Friend WithEvents lbl_noPenjualan As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents txt_satuanBrg As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_namaBrg As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbo_brg As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hrga As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btn_tmbhDetJual As Button
    Friend WithEvents dgv_detailPenjualan As DataGridView
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrg As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrg As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents dtp_tglJual As DateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_listPenjualan As DataGridView
    Friend WithEvents colNmr As DataGridViewTextBoxColumn
    Friend WithEvents colNoPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colJenisPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colTgl As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPenjualan As DataGridViewTextBoxColumn
    Friend WithEvents colDanaDiterima As DataGridViewTextBoxColumn
    Friend WithEvents colKembalian As DataGridViewTextBoxColumn
    Friend WithEvents colMetodePembayaran As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colCatatan As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cariPenjualan As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_jenisJual As Label
    Friend WithEvents lbl_catatan As Label
    Friend WithEvents lbl_kembalian As Label
    Friend WithEvents lbl_danaDiterima As Label
    Friend WithEvents pnl_listDetail As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents rtb_detailPenjualan As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_statusJual As Label
    Friend WithEvents lbl_metodeJual As Label
    Friend WithEvents lbl_totalJual As Label
    Friend WithEvents lbl_tglJual As Label
    Friend WithEvents lbl_noJual As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_resetDanaKecil As Button
    Friend WithEvents btn_konfirmasiUangKecil As Button
    Friend WithEvents txt_danaUangKecil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_tglUangKecil As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgv_listPenjualanPending As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colNoPenjualanPending As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colTglPembelian As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPenjualanPending As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents rtb_detailPenjualanPending As RichTextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btn_clearPenjualanPending As Button
    Friend WithEvents btn_updateLunasPenjualan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_catatanPending As RichTextBox
    Friend WithEvents lbl_alamatJualPending As RichTextBox
    Friend WithEvents lbl_statusKirimPending As Label
    Friend WithEvents lbl_kontakPending As Label
    Friend WithEvents lbl_atasNamaPending As Label
    Friend WithEvents lbl_jenisJualPending As Label
    Friend WithEvents lbl_statusJualPending As Label
    Friend WithEvents lbl_metodeJualPending As Label
    Friend WithEvents lbl_totalJualPending As Label
    Friend WithEvents lbl_tglJualPending As Label
    Friend WithEvents lbl_noJualPending As Label
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCancelDelivery As Button
    Friend WithEvents pic_barcodePenjualanDelivery As PictureBox
    Friend WithEvents Label37 As Label
    Friend WithEvents cbo_statusDelivery As ComboBox
    Friend WithEvents txt_alamatDelivery As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents txt_kontakDelivery As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txt_atasNamaDelivery As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents txtJenisDelivery As TextBox
    Friend WithEvents txt_noPenjualanDelivery As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txt_catatanDelivery As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents lbl_totalQtyDelivery As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents cbo_metodePembayaranDelivery As ComboBox
    Friend WithEvents btn_simpanPenjualanDelivery As Button
    Friend WithEvents Label45 As Label
    Friend WithEvents cbo_statusPenjualanDelivery As ComboBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents lbl_subTotalDelivery As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents lbl_hargaSatuanDelivery As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents lbl_QtyDelivery As Label
    Friend WithEvents lbl_grandTotalDelivery As Label
    Friend WithEvents lbl_noPenjualanDelivery As Label
    Friend WithEvents txt_danaDiterimaDelivery As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents lbl_kembalianDelivery As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_satuanBrgDelivery As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txt_namaBrgDelivery As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents cbo_brgDelivery As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents txt_subTotalDelivery As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txt_hrgaDelivery As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents txt_qtyDelivery As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents btn_tmbhDetBeliDelivery As Button
    Friend WithEvents dgv_detailPenjualanDelivery As DataGridView
    Friend WithEvents dtp_tglJualDelivery As DateTimePicker
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCancelPickup As Button
    Friend WithEvents pic_barcodePenjualanPickup As PictureBox
    Friend WithEvents Label61 As Label
    Friend WithEvents cbo_statusPickup As ComboBox
    Friend WithEvents Label62 As Label
    Friend WithEvents txt_kontakDeliveryPickup As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents txt_atasNamaDeliveryPickup As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents txtJenisDeliveryPickup As TextBox
    Friend WithEvents txt_noPenjualanPickup As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txt_catatanPickup As TextBox
    Friend WithEvents Label66 As Label
    Friend WithEvents lbl_totalQtyPickup As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents cbo_metodePembayaranPickup As ComboBox
    Friend WithEvents btn_simpanPenjualanPickup As Button
    Friend WithEvents Label68 As Label
    Friend WithEvents cbo_statusPenjualanPickup As ComboBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents lbl_subTotalPickup As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents lbl_hargaSatuanPickup As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents lbl_QtyPickup As Label
    Friend WithEvents lbl_grandTotalPickup As Label
    Friend WithEvents lbl_noPenjualanPickup As Label
    Friend WithEvents txt_danaDiterimaPickup As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents lbl_kembalianPickup As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txt_satuanBrgPickup As TextBox
    Friend WithEvents Label75 As Label
    Friend WithEvents txt_namaBrgPickup As TextBox
    Friend WithEvents Label76 As Label
    Friend WithEvents cbo_brgPickup As ComboBox
    Friend WithEvents Label77 As Label
    Friend WithEvents txt_subTotalPickup As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents txt_hrgaPickup As TextBox
    Friend WithEvents Label79 As Label
    Friend WithEvents txt_qtyPickup As TextBox
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents btn_tmbhDetBeliPickup As Button
    Friend WithEvents dgv_detailPenjualanPickup As DataGridView
    Friend WithEvents dtp_tglJualPickup As DateTimePicker
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBarangPickup As DataGridViewTextBoxColumn
    Friend WithEvents colQtyPickup As DataGridViewTextBoxColumn
    Friend WithEvents colSatuanPickup As DataGridViewTextBoxColumn
    Friend WithEvents colHargaPickup As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotalPickup As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrgDelivery As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrgDelivery As DataGridViewTextBoxColumn
    Friend WithEvents colQtyDelivery As DataGridViewTextBoxColumn
    Friend WithEvents colSatuanDelivery As DataGridViewTextBoxColumn
    Friend WithEvents colHargaDelivery As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotalDelivery As DataGridViewTextBoxColumn
End Class
