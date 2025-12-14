<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tbhKategori
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
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.btn_simpanKategori = New System.Windows.Forms.Button()
        Me.txt_kategoriBaru = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(308, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 7
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'btn_simpanKategori
        '
        Me.btn_simpanKategori.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_simpanKategori.FlatAppearance.BorderSize = 0
        Me.btn_simpanKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanKategori.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpanKategori.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanKategori.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanKategori.Location = New System.Drawing.Point(37, 138)
        Me.btn_simpanKategori.Name = "btn_simpanKategori"
        Me.btn_simpanKategori.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanKategori.Size = New System.Drawing.Size(320, 29)
        Me.btn_simpanKategori.TabIndex = 49
        Me.btn_simpanKategori.Text = "Save 💾"
        Me.btn_simpanKategori.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanKategori.UseVisualStyleBackColor = False
        '
        'txt_kategoriBaru
        '
        Me.txt_kategoriBaru.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_kategoriBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kategoriBaru.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kategoriBaru.Location = New System.Drawing.Point(37, 94)
        Me.txt_kategoriBaru.Name = "txt_kategoriBaru"
        Me.txt_kategoriBaru.Size = New System.Drawing.Size(320, 26)
        Me.txt_kategoriBaru.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Kategori Baru:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 23)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Management Barang"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(321, 2)
        Me.Label6.TabIndex = 51
        '
        'frm_tbhKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 199)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_simpanKategori)
        Me.Controls.Add(Me.txt_kategoriBaru)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.closeBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tbhKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_tbhKategori"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closeBtn As Button
    Friend WithEvents btn_simpanKategori As Button
    Friend WithEvents txt_kategoriBaru As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
