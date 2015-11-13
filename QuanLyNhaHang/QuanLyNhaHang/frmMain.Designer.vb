<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mspMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFunction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mspMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mspMenu
        '
        Me.mspMenu.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mspMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSystem, Me.tsmFunction})
        Me.mspMenu.Location = New System.Drawing.Point(0, 0)
        Me.mspMenu.Name = "mspMenu"
        Me.mspMenu.Size = New System.Drawing.Size(796, 29)
        Me.mspMenu.TabIndex = 0
        '
        'tsmSystem
        '
        Me.tsmSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmLogin, Me.tsmLogout, Me.tsmExit})
        Me.tsmSystem.Name = "tsmSystem"
        Me.tsmSystem.Size = New System.Drawing.Size(86, 25)
        Me.tsmSystem.Text = "Hệ thống"
        '
        'tsmLogin
        '
        Me.tsmLogin.Name = "tsmLogin"
        Me.tsmLogin.Size = New System.Drawing.Size(156, 26)
        Me.tsmLogin.Text = "Đăng nhập"
        '
        'tsmLogout
        '
        Me.tsmLogout.Name = "tsmLogout"
        Me.tsmLogout.Size = New System.Drawing.Size(156, 26)
        Me.tsmLogout.Text = "Đăng xuất"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(156, 26)
        Me.tsmExit.Text = "Thoát"
        '
        'tsmFunction
        '
        Me.tsmFunction.Name = "tsmFunction"
        Me.tsmFunction.Size = New System.Drawing.Size(96, 25)
        Me.tsmFunction.Text = "Chức năng"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 261)
        Me.Controls.Add(Me.mspMenu)
        Me.MainMenuStrip = Me.mspMenu
        Me.Name = "frmMain"
        Me.Text = "Màn hình chính"
        Me.mspMenu.ResumeLayout(False)
        Me.mspMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mspMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFunction As System.Windows.Forms.ToolStripMenuItem

End Class
