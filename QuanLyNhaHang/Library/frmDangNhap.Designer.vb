<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.lblSeePW = New System.Windows.Forms.Label()
        Me.lblClearID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(5, 143)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(127, 35)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Đăng nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(134, 143)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 35)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Hủy"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(40, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(185, 31)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "ĐĂNG NHẬP"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(28, 63)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(213, 26)
        Me.txtID.TabIndex = 3
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(28, 105)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(213, 26)
        Me.txtPW.TabIndex = 4
        '
        'lblSeePW
        '
        Me.lblSeePW.BackColor = System.Drawing.SystemColors.Window
        Me.lblSeePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSeePW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeePW.Image = Global.Library.My.Resources.Resources.eye
        Me.lblSeePW.Location = New System.Drawing.Point(224, 108)
        Me.lblSeePW.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSeePW.Name = "lblSeePW"
        Me.lblSeePW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeePW.Size = New System.Drawing.Size(14, 20)
        Me.lblSeePW.TabIndex = 8
        Me.lblSeePW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblClearID
        '
        Me.lblClearID.BackColor = System.Drawing.SystemColors.Window
        Me.lblClearID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClearID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearID.Location = New System.Drawing.Point(224, 66)
        Me.lblClearID.Margin = New System.Windows.Forms.Padding(3)
        Me.lblClearID.Name = "lblClearID"
        Me.lblClearID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClearID.Size = New System.Drawing.Size(14, 20)
        Me.lblClearID.TabIndex = 9
        Me.lblClearID.Text = "x"
        Me.lblClearID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 184)
        Me.Controls.Add(Me.lblClearID)
        Me.Controls.Add(Me.lblSeePW)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmDangNhap"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents lblSeePW As System.Windows.Forms.Label
    Friend WithEvents lblClearID As System.Windows.Forms.Label

End Class
