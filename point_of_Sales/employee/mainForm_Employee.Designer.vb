<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm_Employee))
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_totalStokRetur = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btn_btlRetur = New System.Windows.Forms.Button()
        Me.btn_simpanRetur = New System.Windows.Forms.Button()
        Me.txt_totalDanaRetur = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_satuanBrg = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_namaBrg = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_brg = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hrgaSatuan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_tmbhDetBeli = New System.Windows.Forms.Button()
        Me.dgv_detailPengembalian = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKodeBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaBrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_IDSup = New System.Windows.Forms.TextBox()
        Me.cbo_nmaSup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_kodeRetur = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtp_tglPengembalian = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_listPengembalian = New System.Windows.Forms.DataGridView()
        Me.colNmr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDPengembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTglPembelian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMetode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalRefund = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalRetur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatusPengembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDSupBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNmaSupBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cariPengembalian = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_statusPengembalian = New System.Windows.Forms.Label()
        Me.pnl_listDetail = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.rtb_detailPengembalian = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_metodePengembalian = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_totalStokRetur = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_totalDanaRetur = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_clearPembelian = New System.Windows.Forms.Button()
        Me.lbl_nmaSup = New System.Windows.Forms.Label()
        Me.lbl_IDPengembalian = New System.Windows.Forms.Label()
        Me.lbl_IDSupRetur = New System.Windows.Forms.Label()
        Me.lbl_tanggalPengembalian = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_detailPengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_listPengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnl_listDetail.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel2.TabIndex = 28
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
        Me.Panel1.Size = New System.Drawing.Size(148, 749)
        Me.Panel1.TabIndex = 27
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
        Me.btnDelivery.BackColor = System.Drawing.SystemColors.Window
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
        Me.btnPengembalian_Karyawan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
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
        Me.btnStok.UseVisualStyleBackColor = True
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
        Me.TabControl1.TabIndex = 33
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dtp_tglPengembalian)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ajukan Pengembalian"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_totalStokRetur)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.btn_btlRetur)
        Me.GroupBox3.Controls.Add(Me.btn_simpanRetur)
        Me.GroupBox3.Controls.Add(Me.txt_totalDanaRetur)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 563)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1158, 72)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Summary"
        '
        'txt_totalStokRetur
        '
        Me.txt_totalStokRetur.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_totalStokRetur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_totalStokRetur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalStokRetur.Location = New System.Drawing.Point(616, 26)
        Me.txt_totalStokRetur.Name = "txt_totalStokRetur"
        Me.txt_totalStokRetur.Size = New System.Drawing.Size(190, 26)
        Me.txt_totalStokRetur.TabIndex = 63
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(412, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(198, 16)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Total Pengembalian Stok Barang:"
        '
        'btn_btlRetur
        '
        Me.btn_btlRetur.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_btlRetur.FlatAppearance.BorderSize = 0
        Me.btn_btlRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_btlRetur.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_btlRetur.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_btlRetur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_btlRetur.Location = New System.Drawing.Point(974, 25)
        Me.btn_btlRetur.Name = "btn_btlRetur"
        Me.btn_btlRetur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_btlRetur.Size = New System.Drawing.Size(93, 26)
        Me.btn_btlRetur.TabIndex = 61
        Me.btn_btlRetur.Text = "🧹 Batal"
        Me.btn_btlRetur.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_btlRetur.UseVisualStyleBackColor = False
        '
        'btn_simpanRetur
        '
        Me.btn_simpanRetur.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_simpanRetur.FlatAppearance.BorderSize = 0
        Me.btn_simpanRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanRetur.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_simpanRetur.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanRetur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanRetur.Location = New System.Drawing.Point(875, 25)
        Me.btn_simpanRetur.Name = "btn_simpanRetur"
        Me.btn_simpanRetur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanRetur.Size = New System.Drawing.Size(93, 26)
        Me.btn_simpanRetur.TabIndex = 60
        Me.btn_simpanRetur.Text = "💾 Ajukan"
        Me.btn_simpanRetur.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanRetur.UseVisualStyleBackColor = False
        '
        'txt_totalDanaRetur
        '
        Me.txt_totalDanaRetur.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_totalDanaRetur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_totalDanaRetur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalDanaRetur.Location = New System.Drawing.Point(179, 26)
        Me.txt_totalDanaRetur.Name = "txt_totalDanaRetur"
        Me.txt_totalDanaRetur.ReadOnly = True
        Me.txt_totalDanaRetur.Size = New System.Drawing.Size(190, 26)
        Me.txt_totalDanaRetur.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Total Pengembalian Dana:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_satuanBrg)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_namaBrg)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cbo_brg)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_subTotal)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_hrgaSatuan)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_qty)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btn_tmbhDetBeli)
        Me.GroupBox2.Controls.Add(Me.dgv_detailPengembalian)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1158, 375)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Barang"
        '
        'txt_satuanBrg
        '
        Me.txt_satuanBrg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_satuanBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuanBrg.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_satuanBrg.Location = New System.Drawing.Point(134, 164)
        Me.txt_satuanBrg.Name = "txt_satuanBrg"
        Me.txt_satuanBrg.ReadOnly = True
        Me.txt_satuanBrg.Size = New System.Drawing.Size(113, 26)
        Me.txt_satuanBrg.TabIndex = 63
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(862, 35)
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
        Me.txt_namaBrg.Location = New System.Drawing.Point(18, 109)
        Me.txt_namaBrg.Name = "txt_namaBrg"
        Me.txt_namaBrg.ReadOnly = True
        Me.txt_namaBrg.Size = New System.Drawing.Size(229, 26)
        Me.txt_namaBrg.TabIndex = 61
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 16)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Nama Barang:"
        '
        'cbo_brg
        '
        Me.cbo_brg.FormattingEnabled = True
        Me.cbo_brg.Location = New System.Drawing.Point(18, 54)
        Me.cbo_brg.Name = "cbo_brg"
        Me.cbo_brg.Size = New System.Drawing.Size(229, 26)
        Me.cbo_brg.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(131, 145)
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
        Me.txt_subTotal.Location = New System.Drawing.Point(18, 274)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.ReadOnly = True
        Me.txt_subTotal.Size = New System.Drawing.Size(229, 26)
        Me.txt_subTotal.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Subtotal:"
        '
        'txt_hrgaSatuan
        '
        Me.txt_hrgaSatuan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_hrgaSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hrgaSatuan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hrgaSatuan.Location = New System.Drawing.Point(18, 219)
        Me.txt_hrgaSatuan.Name = "txt_hrgaSatuan"
        Me.txt_hrgaSatuan.ReadOnly = True
        Me.txt_hrgaSatuan.Size = New System.Drawing.Size(229, 26)
        Me.txt_hrgaSatuan.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Harga Barang per Satuan:"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(18, 164)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(113, 26)
        Me.txt_qty.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Qty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 35)
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
        Me.btn_tmbhDetBeli.Location = New System.Drawing.Point(18, 327)
        Me.btn_tmbhDetBeli.Name = "btn_tmbhDetBeli"
        Me.btn_tmbhDetBeli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_tmbhDetBeli.Size = New System.Drawing.Size(229, 29)
        Me.btn_tmbhDetBeli.TabIndex = 50
        Me.btn_tmbhDetBeli.Text = "➕ Tambah Barang"
        Me.btn_tmbhDetBeli.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_tmbhDetBeli.UseVisualStyleBackColor = False
        '
        'dgv_detailPengembalian
        '
        Me.dgv_detailPengembalian.AllowUserToAddRows = False
        Me.dgv_detailPengembalian.AllowUserToDeleteRows = False
        Me.dgv_detailPengembalian.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_detailPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detailPengembalian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colKodeBrg, Me.colNmaBrg, Me.colQty, Me.colSatuan, Me.colHarga, Me.colSubtotal})
        Me.dgv_detailPengembalian.Location = New System.Drawing.Point(267, 54)
        Me.dgv_detailPengembalian.Name = "dgv_detailPengembalian"
        Me.dgv_detailPengembalian.ReadOnly = True
        Me.dgv_detailPengembalian.RowHeadersVisible = False
        Me.dgv_detailPengembalian.Size = New System.Drawing.Size(870, 302)
        Me.dgv_detailPengembalian.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_IDSup)
        Me.GroupBox1.Controls.Add(Me.cbo_nmaSup)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_kodeRetur)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1158, 88)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rincian Pengembalian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Nama Supplier:"
        '
        'txt_IDSup
        '
        Me.txt_IDSup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_IDSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_IDSup.Enabled = False
        Me.txt_IDSup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDSup.Location = New System.Drawing.Point(688, 37)
        Me.txt_IDSup.Name = "txt_IDSup"
        Me.txt_IDSup.ReadOnly = True
        Me.txt_IDSup.Size = New System.Drawing.Size(200, 26)
        Me.txt_IDSup.TabIndex = 36
        '
        'cbo_nmaSup
        '
        Me.cbo_nmaSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_nmaSup.FormattingEnabled = True
        Me.cbo_nmaSup.Location = New System.Drawing.Point(386, 37)
        Me.cbo_nmaSup.Name = "cbo_nmaSup"
        Me.cbo_nmaSup.Size = New System.Drawing.Size(200, 26)
        Me.cbo_nmaSup.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(607, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "ID Supplier:"
        '
        'txt_kodeRetur
        '
        Me.txt_kodeRetur.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kodeRetur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kodeRetur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kodeRetur.Location = New System.Drawing.Point(57, 38)
        Me.txt_kodeRetur.Name = "txt_kodeRetur"
        Me.txt_kodeRetur.ReadOnly = True
        Me.txt_kodeRetur.Size = New System.Drawing.Size(200, 26)
        Me.txt_kodeRetur.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 16)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Kode:"
        '
        'dtp_tglPengembalian
        '
        Me.dtp_tglPengembalian.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dtp_tglPengembalian.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tglPengembalian.Location = New System.Drawing.Point(189, 20)
        Me.dtp_tglPengembalian.Name = "dtp_tglPengembalian"
        Me.dtp_tglPengembalian.Size = New System.Drawing.Size(200, 25)
        Me.dtp_tglPengembalian.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label12.Location = New System.Drawing.Point(24, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 18)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Tanggal Pengembalian:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_listPengembalian)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 635)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List Pengembalian yang Diajukan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_listPengembalian
        '
        Me.dgv_listPengembalian.AllowUserToAddRows = False
        Me.dgv_listPengembalian.AllowUserToDeleteRows = False
        Me.dgv_listPengembalian.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_listPengembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_listPengembalian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_listPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listPengembalian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNmr, Me.colIDPengembalian, Me.colTglPembelian, Me.colMetode, Me.colTotalRefund, Me.colTotalRetur, Me.colStatusPengembalian, Me.colIDSupBeli, Me.colNmaSupBeli})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_listPengembalian.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_listPengembalian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_listPengembalian.Location = New System.Drawing.Point(3, 53)
        Me.dgv_listPengembalian.Name = "dgv_listPengembalian"
        Me.dgv_listPengembalian.ReadOnly = True
        Me.dgv_listPengembalian.RowHeadersVisible = False
        Me.dgv_listPengembalian.Size = New System.Drawing.Size(812, 579)
        Me.dgv_listPengembalian.TabIndex = 18
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
        'colIDPengembalian
        '
        Me.colIDPengembalian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIDPengembalian.HeaderText = "No Pengembalian"
        Me.colIDPengembalian.MinimumWidth = 154
        Me.colIDPengembalian.Name = "colIDPengembalian"
        Me.colIDPengembalian.ReadOnly = True
        '
        'colTglPembelian
        '
        Me.colTglPembelian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTglPembelian.HeaderText = "Tanggal"
        Me.colTglPembelian.MinimumWidth = 85
        Me.colTglPembelian.Name = "colTglPembelian"
        Me.colTglPembelian.ReadOnly = True
        '
        'colMetode
        '
        Me.colMetode.HeaderText = "Metode"
        Me.colMetode.Name = "colMetode"
        Me.colMetode.ReadOnly = True
        '
        'colTotalRefund
        '
        Me.colTotalRefund.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTotalRefund.HeaderText = "Total Dana Refund"
        Me.colTotalRefund.MinimumWidth = 150
        Me.colTotalRefund.Name = "colTotalRefund"
        Me.colTotalRefund.ReadOnly = True
        '
        'colTotalRetur
        '
        Me.colTotalRetur.HeaderText = "Total Stok Retur"
        Me.colTotalRetur.MinimumWidth = 130
        Me.colTotalRetur.Name = "colTotalRetur"
        Me.colTotalRetur.ReadOnly = True
        Me.colTotalRetur.Width = 130
        '
        'colStatusPengembalian
        '
        Me.colStatusPengembalian.HeaderText = "Status"
        Me.colStatusPengembalian.Name = "colStatusPengembalian"
        Me.colStatusPengembalian.ReadOnly = True
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_cariPengembalian)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(812, 50)
        Me.Panel4.TabIndex = 19
        '
        'txt_cariPengembalian
        '
        Me.txt_cariPengembalian.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_cariPengembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cariPengembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cariPengembalian.Location = New System.Drawing.Point(157, 12)
        Me.txt_cariPengembalian.Name = "txt_cariPengembalian"
        Me.txt_cariPengembalian.Size = New System.Drawing.Size(240, 26)
        Me.txt_cariPengembalian.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Search Pengembalian:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbl_statusPengembalian)
        Me.Panel3.Controls.Add(Me.pnl_listDetail)
        Me.Panel3.Controls.Add(Me.lbl_metodePengembalian)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.lbl_totalStokRetur)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.lbl_totalDanaRetur)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.lbl_nmaSup)
        Me.Panel3.Controls.Add(Me.lbl_IDPengembalian)
        Me.Panel3.Controls.Add(Me.lbl_IDSupRetur)
        Me.Panel3.Controls.Add(Me.lbl_tanggalPengembalian)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(815, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 629)
        Me.Panel3.TabIndex = 20
        '
        'lbl_statusPengembalian
        '
        Me.lbl_statusPengembalian.AutoSize = True
        Me.lbl_statusPengembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusPengembalian.Location = New System.Drawing.Point(11, 238)
        Me.lbl_statusPengembalian.Name = "lbl_statusPengembalian"
        Me.lbl_statusPengembalian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_statusPengembalian.TabIndex = 46
        Me.lbl_statusPengembalian.Text = "-"
        '
        'pnl_listDetail
        '
        Me.pnl_listDetail.Controls.Add(Me.Label23)
        Me.pnl_listDetail.Controls.Add(Me.rtb_detailPengembalian)
        Me.pnl_listDetail.Controls.Add(Me.Label21)
        Me.pnl_listDetail.Controls.Add(Me.Label22)
        Me.pnl_listDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_listDetail.Location = New System.Drawing.Point(0, 249)
        Me.pnl_listDetail.Name = "pnl_listDetail"
        Me.pnl_listDetail.Size = New System.Drawing.Size(390, 331)
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
        'rtb_detailPengembalian
        '
        Me.rtb_detailPengembalian.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_detailPengembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_detailPengembalian.Location = New System.Drawing.Point(11, 38)
        Me.rtb_detailPengembalian.Name = "rtb_detailPengembalian"
        Me.rtb_detailPengembalian.ReadOnly = True
        Me.rtb_detailPengembalian.Size = New System.Drawing.Size(365, 285)
        Me.rtb_detailPengembalian.TabIndex = 32
        Me.rtb_detailPengembalian.Text = ""
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
        'lbl_metodePengembalian
        '
        Me.lbl_metodePengembalian.AutoSize = True
        Me.lbl_metodePengembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_metodePengembalian.Location = New System.Drawing.Point(11, 209)
        Me.lbl_metodePengembalian.Name = "lbl_metodePengembalian"
        Me.lbl_metodePengembalian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_metodePengembalian.TabIndex = 45
        Me.lbl_metodePengembalian.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label20.Location = New System.Drawing.Point(71, 3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(247, 18)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Informasi Pengembalian Barang"
        '
        'lbl_totalStokRetur
        '
        Me.lbl_totalStokRetur.AutoSize = True
        Me.lbl_totalStokRetur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalStokRetur.Location = New System.Drawing.Point(11, 180)
        Me.lbl_totalStokRetur.Name = "lbl_totalStokRetur"
        Me.lbl_totalStokRetur.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalStokRetur.TabIndex = 44
        Me.lbl_totalStokRetur.Text = "-"
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
        'lbl_totalDanaRetur
        '
        Me.lbl_totalDanaRetur.AutoSize = True
        Me.lbl_totalDanaRetur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalDanaRetur.Location = New System.Drawing.Point(11, 151)
        Me.lbl_totalDanaRetur.Name = "lbl_totalDanaRetur"
        Me.lbl_totalDanaRetur.Size = New System.Drawing.Size(13, 18)
        Me.lbl_totalDanaRetur.TabIndex = 43
        Me.lbl_totalDanaRetur.Text = "-"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_clearPembelian)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 580)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(390, 47)
        Me.Panel5.TabIndex = 35
        '
        'btn_clearPembelian
        '
        Me.btn_clearPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_clearPembelian.FlatAppearance.BorderSize = 0
        Me.btn_clearPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearPembelian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearPembelian.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clearPembelian.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearPembelian.Location = New System.Drawing.Point(10, 9)
        Me.btn_clearPembelian.Name = "btn_clearPembelian"
        Me.btn_clearPembelian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_clearPembelian.Size = New System.Drawing.Size(372, 29)
        Me.btn_clearPembelian.TabIndex = 49
        Me.btn_clearPembelian.Text = "Clear 🧹"
        Me.btn_clearPembelian.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clearPembelian.UseVisualStyleBackColor = False
        '
        'lbl_nmaSup
        '
        Me.lbl_nmaSup.AutoSize = True
        Me.lbl_nmaSup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nmaSup.Location = New System.Drawing.Point(11, 122)
        Me.lbl_nmaSup.Name = "lbl_nmaSup"
        Me.lbl_nmaSup.Size = New System.Drawing.Size(13, 18)
        Me.lbl_nmaSup.TabIndex = 42
        Me.lbl_nmaSup.Text = "-"
        '
        'lbl_IDPengembalian
        '
        Me.lbl_IDPengembalian.AutoSize = True
        Me.lbl_IDPengembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDPengembalian.Location = New System.Drawing.Point(11, 35)
        Me.lbl_IDPengembalian.Name = "lbl_IDPengembalian"
        Me.lbl_IDPengembalian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_IDPengembalian.TabIndex = 39
        Me.lbl_IDPengembalian.Text = "-"
        '
        'lbl_IDSupRetur
        '
        Me.lbl_IDSupRetur.AutoSize = True
        Me.lbl_IDSupRetur.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDSupRetur.Location = New System.Drawing.Point(11, 93)
        Me.lbl_IDSupRetur.Name = "lbl_IDSupRetur"
        Me.lbl_IDSupRetur.Size = New System.Drawing.Size(13, 18)
        Me.lbl_IDSupRetur.TabIndex = 41
        Me.lbl_IDSupRetur.Text = "-"
        '
        'lbl_tanggalPengembalian
        '
        Me.lbl_tanggalPengembalian.AutoSize = True
        Me.lbl_tanggalPengembalian.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggalPengembalian.Location = New System.Drawing.Point(11, 64)
        Me.lbl_tanggalPengembalian.Name = "lbl_tanggalPengembalian"
        Me.lbl_tanggalPengembalian.Size = New System.Drawing.Size(13, 18)
        Me.lbl_tanggalPengembalian.TabIndex = 40
        Me.lbl_tanggalPengembalian.Text = "-"
        '
        'mainForm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1364, 718)
        Me.Name = "mainForm_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm_Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_detailPengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_listPengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnl_listDetail.ResumeLayout(False)
        Me.pnl_listDetail.PerformLayout()
        Me.Panel5.ResumeLayout(False)
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
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnPengembalian_Karyawan As Button
    Friend WithEvents btnStok As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_totalStokRetur As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btn_btlRetur As Button
    Friend WithEvents btn_simpanRetur As Button
    Friend WithEvents txt_totalDanaRetur As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_satuanBrg As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_namaBrg As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbo_brg As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_subTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hrgaSatuan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_tmbhDetBeli As Button
    Friend WithEvents dgv_detailPengembalian As DataGridView
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colKodeBrg As DataGridViewTextBoxColumn
    Friend WithEvents colNmaBrg As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As DataGridViewTextBoxColumn
    Friend WithEvents colHarga As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_IDSup As TextBox
    Friend WithEvents cbo_nmaSup As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_kodeRetur As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dtp_tglPengembalian As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_listPengembalian As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cariPengembalian As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnl_listDetail As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents rtb_detailPengembalian As RichTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_clearPembelian As Button
    Friend WithEvents lbl_statusPengembalian As Label
    Friend WithEvents lbl_metodePengembalian As Label
    Friend WithEvents lbl_totalStokRetur As Label
    Friend WithEvents lbl_totalDanaRetur As Label
    Friend WithEvents lbl_nmaSup As Label
    Friend WithEvents lbl_IDPengembalian As Label
    Friend WithEvents lbl_IDSupRetur As Label
    Friend WithEvents lbl_tanggalPengembalian As Label
    Friend WithEvents btnPickup As Button
    Friend WithEvents colNmr As DataGridViewTextBoxColumn
    Friend WithEvents colIDPengembalian As DataGridViewTextBoxColumn
    Friend WithEvents colTglPembelian As DataGridViewTextBoxColumn
    Friend WithEvents colMetode As DataGridViewTextBoxColumn
    Friend WithEvents colTotalRefund As DataGridViewTextBoxColumn
    Friend WithEvents colTotalRetur As DataGridViewTextBoxColumn
    Friend WithEvents colStatusPengembalian As DataGridViewTextBoxColumn
    Friend WithEvents colIDSupBeli As DataGridViewTextBoxColumn
    Friend WithEvents colNmaSupBeli As DataGridViewTextBoxColumn
End Class
