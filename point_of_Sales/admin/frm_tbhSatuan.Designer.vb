<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tbhSatuan
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.btn_simpanSatuan = New System.Windows.Forms.Button()
        Me.txt_satuanBaru = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 2.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(321, 2)
        Me.Label6.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 23)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Management Barang"
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.Maroon
        Me.closeBtn.Location = New System.Drawing.Point(308, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(49, 30)
        Me.closeBtn.TabIndex = 52
        Me.closeBtn.Text = "| X |"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'btn_simpanSatuan
        '
        Me.btn_simpanSatuan.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_simpanSatuan.FlatAppearance.BorderSize = 0
        Me.btn_simpanSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpanSatuan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpanSatuan.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_simpanSatuan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanSatuan.Location = New System.Drawing.Point(37, 138)
        Me.btn_simpanSatuan.Name = "btn_simpanSatuan"
        Me.btn_simpanSatuan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_simpanSatuan.Size = New System.Drawing.Size(320, 29)
        Me.btn_simpanSatuan.TabIndex = 57
        Me.btn_simpanSatuan.Text = "Save 💾"
        Me.btn_simpanSatuan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_simpanSatuan.UseVisualStyleBackColor = False
        '
        'txt_satuanBaru
        '
        Me.txt_satuanBaru.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_satuanBaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_satuanBaru.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_satuanBaru.Location = New System.Drawing.Point(37, 94)
        Me.txt_satuanBaru.Name = "txt_satuanBaru"
        Me.txt_satuanBaru.Size = New System.Drawing.Size(320, 26)
        Me.txt_satuanBaru.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Satuan Baru:"
        '
        'frm_tbhSatuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 199)
        Me.Controls.Add(Me.btn_simpanSatuan)
        Me.Controls.Add(Me.txt_satuanBaru)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_tbhSatuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_tbhSatuan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents btn_simpanSatuan As Button
    Friend WithEvents txt_satuanBaru As TextBox
    Friend WithEvents Label10 As Label
End Class
