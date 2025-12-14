<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UpdateStatusPengiriman
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_noPenjualanKirimLunas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_atasNamaKirimLunas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_kontakKirimLunas = New System.Windows.Forms.Label()
        Me.lblalamat = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_tanggalKirimLunas = New System.Windows.Forms.Label()
        Me.lbl_alamatKirimLunas = New System.Windows.Forms.RichTextBox()
        Me.cbo_statuskirimPop = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_updateStatusPengirimanPop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(627, 2)
        Me.Label6.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Update Status Pengiriman"
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(601, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 58
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "No. Penjualan:"
        '
        'lbl_noPenjualanKirimLunas
        '
        Me.lbl_noPenjualanKirimLunas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_noPenjualanKirimLunas.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_noPenjualanKirimLunas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_noPenjualanKirimLunas.Location = New System.Drawing.Point(24, 101)
        Me.lbl_noPenjualanKirimLunas.Name = "lbl_noPenjualanKirimLunas"
        Me.lbl_noPenjualanKirimLunas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_noPenjualanKirimLunas.Size = New System.Drawing.Size(280, 27)
        Me.lbl_noPenjualanKirimLunas.TabIndex = 66
        Me.lbl_noPenjualanKirimLunas.Text = "00.00"
        Me.lbl_noPenjualanKirimLunas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Atas Nama:"
        '
        'lbl_atasNamaKirimLunas
        '
        Me.lbl_atasNamaKirimLunas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_atasNamaKirimLunas.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_atasNamaKirimLunas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_atasNamaKirimLunas.Location = New System.Drawing.Point(24, 164)
        Me.lbl_atasNamaKirimLunas.Name = "lbl_atasNamaKirimLunas"
        Me.lbl_atasNamaKirimLunas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_atasNamaKirimLunas.Size = New System.Drawing.Size(280, 27)
        Me.lbl_atasNamaKirimLunas.TabIndex = 68
        Me.lbl_atasNamaKirimLunas.Text = "00.00"
        Me.lbl_atasNamaKirimLunas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Kontak:"
        '
        'lbl_kontakKirimLunas
        '
        Me.lbl_kontakKirimLunas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_kontakKirimLunas.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_kontakKirimLunas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_kontakKirimLunas.Location = New System.Drawing.Point(24, 227)
        Me.lbl_kontakKirimLunas.Name = "lbl_kontakKirimLunas"
        Me.lbl_kontakKirimLunas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_kontakKirimLunas.Size = New System.Drawing.Size(280, 27)
        Me.lbl_kontakKirimLunas.TabIndex = 70
        Me.lbl_kontakKirimLunas.Text = "00.00"
        Me.lbl_kontakKirimLunas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblalamat
        '
        Me.lblalamat.AutoSize = True
        Me.lblalamat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalamat.Location = New System.Drawing.Point(26, 274)
        Me.lblalamat.Name = "lblalamat"
        Me.lblalamat.Size = New System.Drawing.Size(52, 16)
        Me.lblalamat.TabIndex = 73
        Me.lblalamat.Text = "Alamat:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(353, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Tanggal:"
        '
        'lbl_tanggalKirimLunas
        '
        Me.lbl_tanggalKirimLunas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_tanggalKirimLunas.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_tanggalKirimLunas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tanggalKirimLunas.Location = New System.Drawing.Point(351, 101)
        Me.lbl_tanggalKirimLunas.Name = "lbl_tanggalKirimLunas"
        Me.lbl_tanggalKirimLunas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_tanggalKirimLunas.Size = New System.Drawing.Size(280, 27)
        Me.lbl_tanggalKirimLunas.TabIndex = 74
        Me.lbl_tanggalKirimLunas.Text = "00.00"
        Me.lbl_tanggalKirimLunas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_alamatKirimLunas
        '
        Me.lbl_alamatKirimLunas.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_alamatKirimLunas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl_alamatKirimLunas.Location = New System.Drawing.Point(34, 293)
        Me.lbl_alamatKirimLunas.Name = "lbl_alamatKirimLunas"
        Me.lbl_alamatKirimLunas.ReadOnly = True
        Me.lbl_alamatKirimLunas.Size = New System.Drawing.Size(312, 96)
        Me.lbl_alamatKirimLunas.TabIndex = 76
        Me.lbl_alamatKirimLunas.Text = ""
        '
        'cbo_statuskirimPop
        '
        Me.cbo_statuskirimPop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_statuskirimPop.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_statuskirimPop.FormattingEnabled = True
        Me.cbo_statuskirimPop.Items.AddRange(New Object() {"Siap Dipickup", "Siap Diantar", "Selesai"})
        Me.cbo_statuskirimPop.Location = New System.Drawing.Point(356, 256)
        Me.cbo_statuskirimPop.Name = "cbo_statuskirimPop"
        Me.cbo_statuskirimPop.Size = New System.Drawing.Size(252, 26)
        Me.cbo_statuskirimPop.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Status Pengiriman:"
        '
        'btn_updateStatusPengirimanPop
        '
        Me.btn_updateStatusPengirimanPop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_updateStatusPengirimanPop.FlatAppearance.BorderSize = 0
        Me.btn_updateStatusPengirimanPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateStatusPengirimanPop.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateStatusPengirimanPop.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_updateStatusPengirimanPop.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateStatusPengirimanPop.Location = New System.Drawing.Point(356, 298)
        Me.btn_updateStatusPengirimanPop.Name = "btn_updateStatusPengirimanPop"
        Me.btn_updateStatusPengirimanPop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_updateStatusPengirimanPop.Size = New System.Drawing.Size(252, 29)
        Me.btn_updateStatusPengirimanPop.TabIndex = 79
        Me.btn_updateStatusPengirimanPop.Text = "Update ✏️"
        Me.btn_updateStatusPengirimanPop.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateStatusPengirimanPop.UseVisualStyleBackColor = False
        '
        'frm_UpdateStatusPengiriman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 423)
        Me.Controls.Add(Me.btn_updateStatusPengirimanPop)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_statuskirimPop)
        Me.Controls.Add(Me.lbl_alamatKirimLunas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_tanggalKirimLunas)
        Me.Controls.Add(Me.lblalamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_kontakKirimLunas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_atasNamaKirimLunas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_noPenjualanKirimLunas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_UpdateStatusPengiriman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_UpdateStatusPengiriman"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_noPenjualanKirimLunas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_atasNamaKirimLunas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_kontakKirimLunas As Label
    Friend WithEvents lblalamat As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_tanggalKirimLunas As Label
    Friend WithEvents lbl_alamatKirimLunas As RichTextBox
    Friend WithEvents cbo_statuskirimPop As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_updateStatusPengirimanPop As Button
End Class
