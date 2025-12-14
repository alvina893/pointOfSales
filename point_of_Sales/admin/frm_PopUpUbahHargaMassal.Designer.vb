<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_PopUpUbahHargaMassal
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rb_tertentuMassal = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.txt_massalTertentu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_massalMargin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rb_marginMassal = New System.Windows.Forms.RadioButton()
        Me.txt_massalMarkup = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rb_markupMassal = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_tetapkanMassal = New System.Windows.Forms.Button()
        Me.ToolTipMassal = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_barangUbahMassal = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSimpanUbahMassal = New System.Windows.Forms.Button()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSatuanBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHargaJualBaru = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStokBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMinStokBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupplierNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_barangUbahMassal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Sebesar:"
        '
        'rb_tertentuMassal
        '
        Me.rb_tertentuMassal.AutoSize = True
        Me.rb_tertentuMassal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_tertentuMassal.Location = New System.Drawing.Point(51, 277)
        Me.rb_tertentuMassal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rb_tertentuMassal.Name = "rb_tertentuMassal"
        Me.rb_tertentuMassal.Size = New System.Drawing.Size(220, 22)
        Me.rb_tertentuMassal.TabIndex = 78
        Me.rb_tertentuMassal.TabStop = True
        Me.rb_tertentuMassal.Text = "Set semua ke harga tertentu:"
        Me.rb_tertentuMassal.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 19)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Pilih Mode Perubahan Harga"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 60)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(873, 2)
        Me.Label6.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 23)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Penetapan Harga Jual Massal"
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(844, 17)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(57, 32)
        Me.closeBtn.TabIndex = 74
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'txt_massalTertentu
        '
        Me.txt_massalTertentu.Location = New System.Drawing.Point(138, 305)
        Me.txt_massalTertentu.Name = "txt_massalTertentu"
        Me.txt_massalTertentu.Size = New System.Drawing.Size(148, 27)
        Me.txt_massalTertentu.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(292, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 18)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "%"
        '
        'txt_massalMargin
        '
        Me.txt_massalMargin.Location = New System.Drawing.Point(138, 147)
        Me.txt_massalMargin.Name = "txt_massalMargin"
        Me.txt_massalMargin.Size = New System.Drawing.Size(148, 27)
        Me.txt_massalMargin.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Sebesar:"
        '
        'rb_marginMassal
        '
        Me.rb_marginMassal.AutoSize = True
        Me.rb_marginMassal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_marginMassal.Location = New System.Drawing.Point(51, 119)
        Me.rb_marginMassal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rb_marginMassal.Name = "rb_marginMassal"
        Me.rb_marginMassal.Size = New System.Drawing.Size(221, 22)
        Me.rb_marginMassal.TabIndex = 82
        Me.rb_marginMassal.TabStop = True
        Me.rb_marginMassal.Text = "Margin berdasarkan harga beli"
        Me.rb_marginMassal.UseVisualStyleBackColor = True
        '
        'txt_massalMarkup
        '
        Me.txt_massalMarkup.Location = New System.Drawing.Point(138, 224)
        Me.txt_massalMarkup.Name = "txt_massalMarkup"
        Me.txt_massalMarkup.Size = New System.Drawing.Size(148, 27)
        Me.txt_massalMarkup.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Sebesar:"
        '
        'rb_markupMassal
        '
        Me.rb_markupMassal.AutoSize = True
        Me.rb_markupMassal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_markupMassal.Location = New System.Drawing.Point(51, 196)
        Me.rb_markupMassal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rb_markupMassal.Name = "rb_markupMassal"
        Me.rb_markupMassal.Size = New System.Drawing.Size(128, 22)
        Me.rb_markupMassal.TabIndex = 86
        Me.rb_markupMassal.TabStop = True
        Me.rb_markupMassal.Text = "Markup nominal"
        Me.rb_markupMassal.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(410, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 14)
        Me.Label11.TabIndex = 91
        '
        'btn_tetapkanMassal
        '
        Me.btn_tetapkanMassal.BackColor = System.Drawing.SystemColors.Window
        Me.btn_tetapkanMassal.FlatAppearance.BorderSize = 0
        Me.btn_tetapkanMassal.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btn_tetapkanMassal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_tetapkanMassal.Location = New System.Drawing.Point(42, 360)
        Me.btn_tetapkanMassal.Name = "btn_tetapkanMassal"
        Me.btn_tetapkanMassal.Size = New System.Drawing.Size(160, 30)
        Me.btn_tetapkanMassal.TabIndex = 92
        Me.btn_tetapkanMassal.Text = "Tetapkan ke Harga"
        Me.btn_tetapkanMassal.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_barangUbahMassal)
        Me.Panel1.Location = New System.Drawing.Point(436, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 277)
        Me.Panel1.TabIndex = 93
        '
        'dgv_barangUbahMassal
        '
        Me.dgv_barangUbahMassal.AllowUserToAddRows = False
        Me.dgv_barangUbahMassal.AllowUserToDeleteRows = False
        Me.dgv_barangUbahMassal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_barangUbahMassal.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_barangUbahMassal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_barangUbahMassal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barangUbahMassal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colPilih, Me.colKodeBarang, Me.colNamaBarang, Me.colSatuanBarang, Me.colHargaBeli, Me.colHargaBarang, Me.colHargaJualBaru, Me.colStokBarang, Me.colMinStokBarang, Me.colSupplierID, Me.colSupplierNama})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_barangUbahMassal.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_barangUbahMassal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_barangUbahMassal.Location = New System.Drawing.Point(0, 0)
        Me.dgv_barangUbahMassal.Name = "dgv_barangUbahMassal"
        Me.dgv_barangUbahMassal.RowHeadersVisible = False
        Me.dgv_barangUbahMassal.Size = New System.Drawing.Size(465, 277)
        Me.dgv_barangUbahMassal.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(432, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 18)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Preview Perubahan Harga:"
        '
        'btnSimpanUbahMassal
        '
        Me.btnSimpanUbahMassal.BackColor = System.Drawing.SystemColors.Window
        Me.btnSimpanUbahMassal.FlatAppearance.BorderSize = 0
        Me.btnSimpanUbahMassal.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnSimpanUbahMassal.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnSimpanUbahMassal.Location = New System.Drawing.Point(208, 360)
        Me.btnSimpanUbahMassal.Name = "btnSimpanUbahMassal"
        Me.btnSimpanUbahMassal.Size = New System.Drawing.Size(160, 30)
        Me.btnSimpanUbahMassal.TabIndex = 95
        Me.btnSimpanUbahMassal.Text = "Simpan Ubah Massal"
        Me.btnSimpanUbahMassal.UseVisualStyleBackColor = False
        '
        'colNo
        '
        Me.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNo.HeaderText = "#"
        Me.colNo.Name = "colNo"
        Me.colNo.Visible = False
        Me.colNo.Width = 27
        '
        'colPilih
        '
        Me.colPilih.HeaderText = "[  ]"
        Me.colPilih.MinimumWidth = 40
        Me.colPilih.Name = "colPilih"
        Me.colPilih.Visible = False
        Me.colPilih.Width = 40
        '
        'colKodeBarang
        '
        Me.colKodeBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colKodeBarang.HeaderText = "Kode"
        Me.colKodeBarang.MinimumWidth = 100
        Me.colKodeBarang.Name = "colKodeBarang"
        '
        'colNamaBarang
        '
        Me.colNamaBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colNamaBarang.HeaderText = "Nama"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.Width = 75
        '
        'colSatuanBarang
        '
        Me.colSatuanBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSatuanBarang.HeaderText = "Satuan"
        Me.colSatuanBarang.Name = "colSatuanBarang"
        Me.colSatuanBarang.Visible = False
        Me.colSatuanBarang.Width = 82
        '
        'colHargaBeli
        '
        Me.colHargaBeli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaBeli.HeaderText = "Harga Beli"
        Me.colHargaBeli.Name = "colHargaBeli"
        Me.colHargaBeli.Width = 106
        '
        'colHargaBarang
        '
        Me.colHargaBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaBarang.HeaderText = "Harga Jual"
        Me.colHargaBarang.Name = "colHargaBarang"
        Me.colHargaBarang.Width = 109
        '
        'colHargaJualBaru
        '
        Me.colHargaJualBaru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHargaJualBaru.HeaderText = "Harga Jual Baru"
        Me.colHargaJualBaru.Name = "colHargaJualBaru"
        Me.colHargaJualBaru.Width = 105
        '
        'colStokBarang
        '
        Me.colStokBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStokBarang.HeaderText = "Stok"
        Me.colStokBarang.Name = "colStokBarang"
        Me.colStokBarang.Visible = False
        Me.colStokBarang.Width = 65
        '
        'colMinStokBarang
        '
        Me.colMinStokBarang.HeaderText = "Min Stok"
        Me.colMinStokBarang.Name = "colMinStokBarang"
        Me.colMinStokBarang.Visible = False
        '
        'colSupplierID
        '
        Me.colSupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierID.HeaderText = "Supplier ID"
        Me.colSupplierID.Name = "colSupplierID"
        Me.colSupplierID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSupplierID.Visible = False
        Me.colSupplierID.Width = 105
        '
        'colSupplierNama
        '
        Me.colSupplierNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSupplierNama.HeaderText = "Nama Supplier"
        Me.colSupplierNama.Name = "colSupplierNama"
        Me.colSupplierNama.Visible = False
        Me.colSupplierNama.Width = 126
        '
        'frm_PopUpUbahHargaMassal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 450)
        Me.Controls.Add(Me.btnSimpanUbahMassal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_tetapkanMassal)
        Me.Controls.Add(Me.txt_massalMarkup)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rb_markupMassal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_massalMargin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rb_marginMassal)
        Me.Controls.Add(Me.txt_massalTertentu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rb_tertentuMassal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Label11)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frm_PopUpUbahHargaMassal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_PopUpUbahHargaMassal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_barangUbahMassal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents rb_tertentuMassal As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents txt_massalTertentu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_massalMargin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rb_marginMassal As RadioButton
    Friend WithEvents txt_massalMarkup As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rb_markupMassal As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_tetapkanMassal As Button
    Friend WithEvents ToolTipMassal As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_barangUbahMassal As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSimpanUbahMassal As Button
    Friend WithEvents colNo As DataGridViewTextBoxColumn
    Friend WithEvents colPilih As DataGridViewCheckBoxColumn
    Friend WithEvents colKodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents colNamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents colSatuanBarang As DataGridViewTextBoxColumn
    Friend WithEvents colHargaBeli As DataGridViewTextBoxColumn
    Friend WithEvents colHargaBarang As DataGridViewTextBoxColumn
    Friend WithEvents colHargaJualBaru As DataGridViewTextBoxColumn
    Friend WithEvents colStokBarang As DataGridViewTextBoxColumn
    Friend WithEvents colMinStokBarang As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierID As DataGridViewTextBoxColumn
    Friend WithEvents colSupplierNama As DataGridViewTextBoxColumn
End Class
