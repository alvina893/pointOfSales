<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class migrate
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
        Me.btnMigrate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMigrate
        '
        Me.btnMigrate.Location = New System.Drawing.Point(384, 163)
        Me.btnMigrate.Name = "btnMigrate"
        Me.btnMigrate.Size = New System.Drawing.Size(75, 23)
        Me.btnMigrate.TabIndex = 0
        Me.btnMigrate.Text = "Migrate"
        Me.btnMigrate.UseVisualStyleBackColor = True
        '
        'migrate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMigrate)
        Me.Name = "migrate"
        Me.Text = "migrate"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMigrate As Button
End Class
