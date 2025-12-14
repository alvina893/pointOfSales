<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm_Admin))
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_totalStokRetur = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lbl_sisaUangKecil = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_totalDanaRetur = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lbl_totalDanaPenjualan = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlahPenjualan = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlahPembelian = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlahRetur = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlahSupplier = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lbl_totalDanaPembelian = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_barangMenipis = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlahBarang = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(1305, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 5
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 768)
        Me.Panel1.TabIndex = 0
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.btnPenjualan.TabIndex = 28
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
        Me.btnPembelian.Location = New System.Drawing.Point(3, 198)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Administrator"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(2, 768)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(148, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1218, 69)
        Me.Panel2.TabIndex = 23
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
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
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox11)
        Me.TabPage1.Controls.Add(Me.GroupBox12)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1210, 654)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dashboard"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_totalStokRetur)
        Me.GroupBox5.Location = New System.Drawing.Point(612, 232)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Stok Pengembalian"
        '
        'lbl_totalStokRetur
        '
        Me.lbl_totalStokRetur.AutoSize = True
        Me.lbl_totalStokRetur.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalStokRetur.Location = New System.Drawing.Point(11, 42)
        Me.lbl_totalStokRetur.Name = "lbl_totalStokRetur"
        Me.lbl_totalStokRetur.Size = New System.Drawing.Size(16, 19)
        Me.lbl_totalStokRetur.TabIndex = 0
        Me.lbl_totalStokRetur.Text = "-"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lbl_sisaUangKecil)
        Me.GroupBox10.Location = New System.Drawing.Point(906, 22)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox10.TabIndex = 10
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Sisa Uang Kecil Hari Ini:"
        '
        'lbl_sisaUangKecil
        '
        Me.lbl_sisaUangKecil.AutoSize = True
        Me.lbl_sisaUangKecil.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sisaUangKecil.Location = New System.Drawing.Point(11, 42)
        Me.lbl_sisaUangKecil.Name = "lbl_sisaUangKecil"
        Me.lbl_sisaUangKecil.Size = New System.Drawing.Size(16, 19)
        Me.lbl_sisaUangKecil.TabIndex = 0
        Me.lbl_sisaUangKecil.Text = "-"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_totalDanaRetur)
        Me.GroupBox6.Location = New System.Drawing.Point(612, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Total Dana Pengembalian"
        '
        'lbl_totalDanaRetur
        '
        Me.lbl_totalDanaRetur.AutoSize = True
        Me.lbl_totalDanaRetur.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalDanaRetur.Location = New System.Drawing.Point(11, 42)
        Me.lbl_totalDanaRetur.Name = "lbl_totalDanaRetur"
        Me.lbl_totalDanaRetur.Size = New System.Drawing.Size(16, 19)
        Me.lbl_totalDanaRetur.TabIndex = 0
        Me.lbl_totalDanaRetur.Text = "-"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lbl_totalDanaPenjualan)
        Me.GroupBox11.Location = New System.Drawing.Point(318, 22)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox11.TabIndex = 9
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Total Dana Penjualan"
        '
        'lbl_totalDanaPenjualan
        '
        Me.lbl_totalDanaPenjualan.AutoSize = True
        Me.lbl_totalDanaPenjualan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalDanaPenjualan.Location = New System.Drawing.Point(11, 42)
        Me.lbl_totalDanaPenjualan.Name = "lbl_totalDanaPenjualan"
        Me.lbl_totalDanaPenjualan.Size = New System.Drawing.Size(16, 19)
        Me.lbl_totalDanaPenjualan.TabIndex = 0
        Me.lbl_totalDanaPenjualan.Text = "-"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.lbl_jumlahPenjualan)
        Me.GroupBox12.Location = New System.Drawing.Point(318, 128)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox12.TabIndex = 8
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Jumlah Penjualan"
        '
        'lbl_jumlahPenjualan
        '
        Me.lbl_jumlahPenjualan.AutoSize = True
        Me.lbl_jumlahPenjualan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlahPenjualan.Location = New System.Drawing.Point(11, 42)
        Me.lbl_jumlahPenjualan.Name = "lbl_jumlahPenjualan"
        Me.lbl_jumlahPenjualan.Size = New System.Drawing.Size(16, 19)
        Me.lbl_jumlahPenjualan.TabIndex = 0
        Me.lbl_jumlahPenjualan.Text = "-"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_jumlahPembelian)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Jumlah Pembelian"
        '
        'lbl_jumlahPembelian
        '
        Me.lbl_jumlahPembelian.AutoSize = True
        Me.lbl_jumlahPembelian.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlahPembelian.Location = New System.Drawing.Point(11, 42)
        Me.lbl_jumlahPembelian.Name = "lbl_jumlahPembelian"
        Me.lbl_jumlahPembelian.Size = New System.Drawing.Size(16, 19)
        Me.lbl_jumlahPembelian.TabIndex = 0
        Me.lbl_jumlahPembelian.Text = "-"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lbl_jumlahRetur)
        Me.GroupBox7.Location = New System.Drawing.Point(612, 128)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Jumlah Pengembalian"
        '
        'lbl_jumlahRetur
        '
        Me.lbl_jumlahRetur.AutoSize = True
        Me.lbl_jumlahRetur.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlahRetur.Location = New System.Drawing.Point(11, 42)
        Me.lbl_jumlahRetur.Name = "lbl_jumlahRetur"
        Me.lbl_jumlahRetur.Size = New System.Drawing.Size(16, 19)
        Me.lbl_jumlahRetur.TabIndex = 0
        Me.lbl_jumlahRetur.Text = "-"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbl_jumlahSupplier)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Jumlah Supplier"
        '
        'lbl_jumlahSupplier
        '
        Me.lbl_jumlahSupplier.AutoSize = True
        Me.lbl_jumlahSupplier.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlahSupplier.Location = New System.Drawing.Point(11, 42)
        Me.lbl_jumlahSupplier.Name = "lbl_jumlahSupplier"
        Me.lbl_jumlahSupplier.Size = New System.Drawing.Size(16, 19)
        Me.lbl_jumlahSupplier.TabIndex = 0
        Me.lbl_jumlahSupplier.Text = "-"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lbl_totalDanaPembelian)
        Me.GroupBox8.Location = New System.Drawing.Point(24, 22)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Total Dana Pembelian"
        '
        'lbl_totalDanaPembelian
        '
        Me.lbl_totalDanaPembelian.AutoSize = True
        Me.lbl_totalDanaPembelian.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalDanaPembelian.Location = New System.Drawing.Point(11, 42)
        Me.lbl_totalDanaPembelian.Name = "lbl_totalDanaPembelian"
        Me.lbl_totalDanaPembelian.Size = New System.Drawing.Size(16, 19)
        Me.lbl_totalDanaPembelian.TabIndex = 0
        Me.lbl_totalDanaPembelian.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_barangMenipis)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 443)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jumlah Barang Stok Menipis"
        '
        'lbl_barangMenipis
        '
        Me.lbl_barangMenipis.AutoSize = True
        Me.lbl_barangMenipis.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_barangMenipis.Location = New System.Drawing.Point(11, 42)
        Me.lbl_barangMenipis.Name = "lbl_barangMenipis"
        Me.lbl_barangMenipis.Size = New System.Drawing.Size(16, 19)
        Me.lbl_barangMenipis.TabIndex = 0
        Me.lbl_barangMenipis.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_jumlahBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jumlah Barang"
        '
        'lbl_jumlahBarang
        '
        Me.lbl_jumlahBarang.AutoSize = True
        Me.lbl_jumlahBarang.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlahBarang.Location = New System.Drawing.Point(11, 42)
        Me.lbl_jumlahBarang.Name = "lbl_jumlahBarang"
        Me.lbl_jumlahBarang.Size = New System.Drawing.Size(16, 19)
        Me.lbl_jumlahBarang.TabIndex = 0
        Me.lbl_jumlahBarang.Text = "-"
        '
        'mainForm_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm_Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnManageUser As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnStokBarang As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPengembalian As Button
    Friend WithEvents btnPembelian As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_jumlahBarang As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_barangMenipis As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_jumlahSupplier As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_jumlahPembelian As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbl_totalStokRetur As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbl_totalDanaRetur As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbl_jumlahRetur As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lbl_totalDanaPembelian As Label
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents lbl_totalDanaPenjualan As Label
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents lbl_jumlahPenjualan As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lbl_sisaUangKecil As Label
End Class
