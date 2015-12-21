<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.txtSubID = New System.Windows.Forms.TextBox()
        Me.lblClearID = New System.Windows.Forms.Label()
        Me.txtSubPW = New System.Windows.Forms.TextBox()
        Me.lblSeePW = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnCancel.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblTitle.Font = New System.Drawing.Font("Roboto Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(61, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(151, 33)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "ĐĂNG NHẬP"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(28, 63)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(197, 27)
        Me.txtID.TabIndex = 3
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(28, 105)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(197, 27)
        Me.txtPW.TabIndex = 4
        '
        'txtSubID
        '
        Me.txtSubID.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubID.Location = New System.Drawing.Point(224, 63)
        Me.txtSubID.Name = "txtSubID"
        Me.txtSubID.Size = New System.Drawing.Size(17, 27)
        Me.txtSubID.TabIndex = 3
        Me.txtSubID.TabStop = False
        '
        'lblClearID
        '
        Me.lblClearID.BackColor = System.Drawing.SystemColors.Window
        Me.lblClearID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClearID.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblClearID.Location = New System.Drawing.Point(223, 64)
        Me.lblClearID.Margin = New System.Windows.Forms.Padding(3)
        Me.lblClearID.Name = "lblClearID"
        Me.lblClearID.Padding = New System.Windows.Forms.Padding(1)
        Me.lblClearID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClearID.Size = New System.Drawing.Size(14, 24)
        Me.lblClearID.TabIndex = 9
        Me.lblClearID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSubPW
        '
        Me.txtSubPW.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubPW.Location = New System.Drawing.Point(224, 105)
        Me.txtSubPW.Name = "txtSubPW"
        Me.txtSubPW.Size = New System.Drawing.Size(17, 27)
        Me.txtSubPW.TabIndex = 10
        Me.txtSubPW.TabStop = False
        '
        'lblSeePW
        '
        Me.lblSeePW.BackColor = System.Drawing.SystemColors.Window
        Me.lblSeePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSeePW.Font = New System.Drawing.Font("Roboto Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeePW.Location = New System.Drawing.Point(221, 106)
        Me.lblSeePW.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSeePW.Name = "lblSeePW"
        Me.lblSeePW.Padding = New System.Windows.Forms.Padding(1)
        Me.lblSeePW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeePW.Size = New System.Drawing.Size(14, 24)
        Me.lblSeePW.TabIndex = 11
        Me.lblSeePW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 184)
        Me.Controls.Add(Me.lblSeePW)
        Me.Controls.Add(Me.txtSubPW)
        Me.Controls.Add(Me.lblClearID)
        Me.Controls.Add(Me.txtSubID)
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
    Friend WithEvents txtSubID As System.Windows.Forms.TextBox
    Friend WithEvents lblClearID As System.Windows.Forms.Label
    Friend WithEvents txtSubPW As System.Windows.Forms.TextBox
    Friend WithEvents lblSeePW As System.Windows.Forms.Label

End Class
