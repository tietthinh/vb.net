<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemNhanVien
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gptTTTK = New System.Windows.Forms.GroupBox()
        Me.lblSeeCPW = New System.Windows.Forms.Label()
        Me.lblSeePW = New System.Windows.Forms.Label()
        Me.lblClearID = New System.Windows.Forms.Label()
        Me.txtConfirmPW = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.gpbTTCN = New System.Windows.Forms.GroupBox()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.gptGT = New System.Windows.Forms.GroupBox()
        Me.rdoNam = New System.Windows.Forms.RadioButton()
        Me.rdoNu = New System.Windows.Forms.RadioButton()
        Me.dpkNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gptTTTK.SuspendLayout()
        Me.gpbTTCN.SuspendLayout()
        Me.gptGT.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(90, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(114, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Đăng ký"
        '
        'gptTTTK
        '
        Me.gptTTTK.Controls.Add(Me.lblSeeCPW)
        Me.gptTTTK.Controls.Add(Me.lblSeePW)
        Me.gptTTTK.Controls.Add(Me.lblClearID)
        Me.gptTTTK.Controls.Add(Me.txtConfirmPW)
        Me.gptTTTK.Controls.Add(Me.txtPassword)
        Me.gptTTTK.Controls.Add(Me.txtUsername)
        Me.gptTTTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gptTTTK.Location = New System.Drawing.Point(12, 55)
        Me.gptTTTK.Name = "gptTTTK"
        Me.gptTTTK.Size = New System.Drawing.Size(270, 170)
        Me.gptTTTK.TabIndex = 14
        Me.gptTTTK.TabStop = False
        Me.gptTTTK.Text = "Thông tin tài khoản"
        '
        'lblSeeCPW
        '
        Me.lblSeeCPW.BackColor = System.Drawing.SystemColors.Window
        Me.lblSeeCPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSeeCPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeeCPW.Image = Global.QuanLyNhaHang.My.Resources.Resources.eye
        Me.lblSeeCPW.Location = New System.Drawing.Point(227, 131)
        Me.lblSeeCPW.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSeeCPW.Name = "lblSeeCPW"
        Me.lblSeeCPW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeeCPW.Size = New System.Drawing.Size(14, 20)
        Me.lblSeeCPW.TabIndex = 20
        Me.lblSeeCPW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeePW
        '
        Me.lblSeePW.BackColor = System.Drawing.SystemColors.Window
        Me.lblSeePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSeePW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeePW.Image = Global.QuanLyNhaHang.My.Resources.Resources.eye
        Me.lblSeePW.Location = New System.Drawing.Point(227, 87)
        Me.lblSeePW.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSeePW.Name = "lblSeePW"
        Me.lblSeePW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeePW.Size = New System.Drawing.Size(14, 20)
        Me.lblSeePW.TabIndex = 18
        Me.lblSeePW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblClearID
        '
        Me.lblClearID.BackColor = System.Drawing.SystemColors.Window
        Me.lblClearID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClearID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearID.Location = New System.Drawing.Point(227, 41)
        Me.lblClearID.Margin = New System.Windows.Forms.Padding(3)
        Me.lblClearID.Name = "lblClearID"
        Me.lblClearID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblClearID.Size = New System.Drawing.Size(14, 20)
        Me.lblClearID.TabIndex = 19
        Me.lblClearID.Text = "x"
        Me.lblClearID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtConfirmPW
        '
        Me.txtConfirmPW.Location = New System.Drawing.Point(21, 128)
        Me.txtConfirmPW.Name = "txtConfirmPW"
        Me.txtConfirmPW.Size = New System.Drawing.Size(224, 26)
        Me.txtConfirmPW.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(21, 84)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(224, 26)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(21, 38)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(224, 26)
        Me.txtUsername.TabIndex = 1
        '
        'gpbTTCN
        '
        Me.gpbTTCN.Controls.Add(Me.lblNgaySinh)
        Me.gpbTTCN.Controls.Add(Me.gptGT)
        Me.gpbTTCN.Controls.Add(Me.dpkNgaySinh)
        Me.gpbTTCN.Controls.Add(Me.txtCMND)
        Me.gpbTTCN.Controls.Add(Me.txtHoTen)
        Me.gpbTTCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbTTCN.Location = New System.Drawing.Point(12, 243)
        Me.gpbTTCN.Name = "gpbTTCN"
        Me.gpbTTCN.Size = New System.Drawing.Size(270, 268)
        Me.gpbTTCN.TabIndex = 15
        Me.gpbTTCN.TabStop = False
        Me.gpbTTCN.Text = "Thông tin cá nhân"
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.Location = New System.Drawing.Point(26, 225)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(78, 20)
        Me.lblNgaySinh.TabIndex = 6
        Me.lblNgaySinh.Text = "Ngày sinh"
        '
        'gptGT
        '
        Me.gptGT.Controls.Add(Me.rdoNam)
        Me.gptGT.Controls.Add(Me.rdoNu)
        Me.gptGT.Location = New System.Drawing.Point(21, 133)
        Me.gptGT.Name = "gptGT"
        Me.gptGT.Size = New System.Drawing.Size(224, 68)
        Me.gptGT.TabIndex = 5
        Me.gptGT.TabStop = False
        Me.gptGT.Text = "Giới tính"
        '
        'rdoNam
        '
        Me.rdoNam.AutoSize = True
        Me.rdoNam.Checked = True
        Me.rdoNam.Location = New System.Drawing.Point(26, 38)
        Me.rdoNam.Name = "rdoNam"
        Me.rdoNam.Size = New System.Drawing.Size(60, 24)
        Me.rdoNam.TabIndex = 2
        Me.rdoNam.TabStop = True
        Me.rdoNam.Text = "Nam"
        Me.rdoNam.UseVisualStyleBackColor = True
        '
        'rdoNu
        '
        Me.rdoNu.AutoSize = True
        Me.rdoNu.Location = New System.Drawing.Point(140, 38)
        Me.rdoNu.Name = "rdoNu"
        Me.rdoNu.Size = New System.Drawing.Size(47, 24)
        Me.rdoNu.TabIndex = 3
        Me.rdoNu.Text = "Nữ"
        Me.rdoNu.UseVisualStyleBackColor = True
        '
        'dpkNgaySinh
        '
        Me.dpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpkNgaySinh.Location = New System.Drawing.Point(119, 220)
        Me.dpkNgaySinh.Name = "dpkNgaySinh"
        Me.dpkNgaySinh.Size = New System.Drawing.Size(120, 26)
        Me.dpkNgaySinh.TabIndex = 0
        '
        'txtCMND
        '
        Me.txtCMND.Location = New System.Drawing.Point(21, 92)
        Me.txtCMND.MaxLength = 9
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(224, 26)
        Me.txtCMND.TabIndex = 5
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(21, 44)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(224, 26)
        Me.txtHoTen.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(12, 537)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(127, 35)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Đăng ký"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(155, 537)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 35)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Nhập lại"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmDangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 587)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.gpbTTCN)
        Me.Controls.Add(Me.gptTTTK)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmDangKy"
        Me.Text = "Đăng ký"
        Me.gptTTTK.ResumeLayout(False)
        Me.gptTTTK.PerformLayout()
        Me.gpbTTCN.ResumeLayout(False)
        Me.gpbTTCN.PerformLayout()
        Me.gptGT.ResumeLayout(False)
        Me.gptGT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents gptTTTK As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmPW As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents gpbTTCN As System.Windows.Forms.GroupBox
    Friend WithEvents gptGT As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNam As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNu As System.Windows.Forms.RadioButton
    Friend WithEvents dpkNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCMND As System.Windows.Forms.TextBox
    Friend WithEvents txtHoTen As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblSeeCPW As System.Windows.Forms.Label
    Friend WithEvents lblSeePW As System.Windows.Forms.Label
    Friend WithEvents lblClearID As System.Windows.Forms.Label
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
End Class
