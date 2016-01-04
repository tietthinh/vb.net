<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashier
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTien = New System.Windows.Forms.Label()
        Me.btnGopBan = New System.Windows.Forms.Button()
        Me.btnThanhToan = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ltvBan = New System.Windows.Forms.ListView()
        Me.Table = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaHoaDon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaDau = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaCuoi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvChiTietHoaDon = New System.Windows.Forms.DataGridView()
        Me.IDMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvChiTietHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Roboto Condensed", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(-2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1365, 90)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thu Ngân"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTien
        '
        Me.lblTien.AutoSize = True
        Me.lblTien.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTien.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTien.Location = New System.Drawing.Point(407, 639)
        Me.lblTien.Name = "lblTien"
        Me.lblTien.Size = New System.Drawing.Size(0, 33)
        Me.lblTien.TabIndex = 3
        '
        'btnGopBan
        '
        Me.btnGopBan.BackColor = System.Drawing.SystemColors.Control
        Me.btnGopBan.Enabled = False
        Me.btnGopBan.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGopBan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGopBan.Location = New System.Drawing.Point(1171, 186)
        Me.btnGopBan.Name = "btnGopBan"
        Me.btnGopBan.Size = New System.Drawing.Size(170, 50)
        Me.btnGopBan.TabIndex = 6
        Me.btnGopBan.Text = "Gộp/Tách Bàn"
        Me.btnGopBan.UseVisualStyleBackColor = False
        '
        'btnThanhToan
        '
        Me.btnThanhToan.BackColor = System.Drawing.SystemColors.Control
        Me.btnThanhToan.Enabled = False
        Me.btnThanhToan.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanhToan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnThanhToan.Location = New System.Drawing.Point(1171, 270)
        Me.btnThanhToan.Name = "btnThanhToan"
        Me.btnThanhToan.Size = New System.Drawing.Size(170, 50)
        Me.btnThanhToan.TabIndex = 7
        Me.btnThanhToan.Text = "Thanh Toán"
        Me.btnThanhToan.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssUserName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 694)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssUserName
        '
        Me.tssUserName.Name = "tssUserName"
        Me.tssUserName.Size = New System.Drawing.Size(0, 17)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Danh sách bàn"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ltvBan
        '
        Me.ltvBan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ltvBan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Table, Me.MaHoaDon, Me.MaDau, Me.MaCuoi})
        Me.ltvBan.FullRowSelect = True
        Me.ltvBan.GridLines = True
        Me.ltvBan.Location = New System.Drawing.Point(6, 160)
        Me.ltvBan.Name = "ltvBan"
        Me.ltvBan.Size = New System.Drawing.Size(170, 512)
        Me.ltvBan.TabIndex = 12
        Me.ltvBan.UseCompatibleStateImageBehavior = False
        Me.ltvBan.View = System.Windows.Forms.View.Details
        '
        'Table
        '
        Me.Table.Text = "Vị trí bàn"
        Me.Table.Width = 73
        '
        'MaHoaDon
        '
        Me.MaHoaDon.Text = "Mã hóa đơn"
        Me.MaHoaDon.Width = 94
        '
        'MaDau
        '
        Me.MaDau.Width = 0
        '
        'MaCuoi
        '
        Me.MaCuoi.Width = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(456, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(487, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Danh sách chi tiết hóa đơn"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvChiTietHoaDon
        '
        Me.dgvChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietHoaDon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMon, Me.TenMon, Me.SoLuong, Me.GiaMon, Me.ThanhTien, Me.GhiChu})
        Me.dgvChiTietHoaDon.GridColor = System.Drawing.Color.Black
        Me.dgvChiTietHoaDon.Location = New System.Drawing.Point(211, 160)
        Me.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon"
        Me.dgvChiTietHoaDon.Size = New System.Drawing.Size(925, 419)
        Me.dgvChiTietHoaDon.TabIndex = 14
        '
        'IDMon
        '
        Me.IDMon.DataPropertyName = "MaMon"
        Me.IDMon.HeaderText = "Mã món"
        Me.IDMon.Name = "IDMon"
        '
        'TenMon
        '
        Me.TenMon.DataPropertyName = "TenMon"
        Me.TenMon.HeaderText = "Tên món"
        Me.TenMon.Name = "TenMon"
        '
        'SoLuong
        '
        Me.SoLuong.DataPropertyName = "SoLuong"
        Me.SoLuong.HeaderText = "Số lượng"
        Me.SoLuong.Name = "SoLuong"
        '
        'GiaMon
        '
        Me.GiaMon.DataPropertyName = "GiaTienHienTai"
        Me.GiaMon.HeaderText = "Giá một món"
        Me.GiaMon.Name = "GiaMon"
        '
        'ThanhTien
        '
        Me.ThanhTien.DataPropertyName = "ThanhTien"
        Me.ThanhTien.HeaderText = "Thành tiền"
        Me.ThanhTien.Name = "ThanhTien"
        '
        'GhiChu
        '
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi chú"
        Me.GhiChu.Name = "GhiChu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(222, 639)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 33)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tổng tiền:"
        '
        'frmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1362, 716)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvChiTietHoaDon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ltvBan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnThanhToan)
        Me.Controls.Add(Me.btnGopBan)
        Me.Controls.Add(Me.lblTien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCashier"
        Me.Text = "Thu ngân"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvChiTietHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTien As System.Windows.Forms.Label
    Friend WithEvents btnGopBan As System.Windows.Forms.Button
    Friend WithEvents btnThanhToan As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssUserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ltvBan As System.Windows.Forms.ListView
    Friend WithEvents Table As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvChiTietHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IDMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiaMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaHoaDon As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaDau As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaCuoi As System.Windows.Forms.ColumnHeader
End Class
