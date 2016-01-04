<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQLPhieuNhan
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDanhSachPG = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTimPG = New System.Windows.Forms.Button()
        Me.btnSuaPG = New System.Windows.Forms.Button()
        Me.btnXoaPG = New System.Windows.Forms.Button()
        Me.btnThemPG = New System.Windows.Forms.Button()
        Me.dgvChiTietPG = New System.Windows.Forms.DataGridView()
        Me.colMaPG_CT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaPN_CT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSuaCT = New System.Windows.Forms.Button()
        Me.btnXoaCT = New System.Windows.Forms.Button()
        Me.btnThemCT = New System.Windows.Forms.Button()
        Me.btnTimCT = New System.Windows.Forms.Button()
        Me.cboTenSP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboMaPN = New System.Windows.Forms.ComboBox()
        Me.errPhieuNhan = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslMaNV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslTenNV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTimPG = New System.Windows.Forms.TextBox()
        Me.txtTimCT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.colMaPG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNgayLap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDanhSachPG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChiTietPG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errPhieuNhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDanhSachPG
        '
        Me.dgvDanhSachPG.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDanhSachPG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDanhSachPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaPG, Me.colMaPN, Me.colMaNV, Me.colHoTen, Me.colTongTien, Me.colNgayLap, Me.colGhiChu})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDanhSachPG.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDanhSachPG.Location = New System.Drawing.Point(11, 369)
        Me.dgvDanhSachPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvDanhSachPG.Name = "dgvDanhSachPG"
        Me.dgvDanhSachPG.RowHeadersVisible = False
        Me.dgvDanhSachPG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachPG.Size = New System.Drawing.Size(560, 302)
        Me.dgvDanhSachPG.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1339, 66)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "QUẢN LÝ PHIẾU NHẬN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 333)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(560, 33)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DANH SÁCH PHIẾU NHẬN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(106, 222)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(466, 20)
        Me.txtGhiChu.TabIndex = 83
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(108, 131)
        Me.txtTongTien.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(464, 20)
        Me.txtTongTien.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Tổng tiền"
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.CustomFormat = "dddd,   dd/MM/yyyy   hh:mm:ss"
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLap.Location = New System.Drawing.Point(106, 179)
        Me.dtpNgayLap.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(466, 20)
        Me.dtpNgayLap.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Ghi Chú"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 180)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Ngày lập"
        '
        'btnTimPG
        '
        Me.btnTimPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimPG.Location = New System.Drawing.Point(516, 254)
        Me.btnTimPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimPG.Name = "btnTimPG"
        Me.btnTimPG.Size = New System.Drawing.Size(55, 31)
        Me.btnTimPG.TabIndex = 88
        Me.btnTimPG.Text = "Tìm"
        Me.btnTimPG.UseVisualStyleBackColor = True
        '
        'btnSuaPG
        '
        Me.btnSuaPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaPG.Location = New System.Drawing.Point(403, 289)
        Me.btnSuaPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaPG.Name = "btnSuaPG"
        Me.btnSuaPG.Size = New System.Drawing.Size(95, 39)
        Me.btnSuaPG.TabIndex = 87
        Me.btnSuaPG.Text = "Sửa"
        Me.btnSuaPG.UseVisualStyleBackColor = True
        '
        'btnXoaPG
        '
        Me.btnXoaPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaPG.Location = New System.Drawing.Point(242, 289)
        Me.btnXoaPG.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaPG.Name = "btnXoaPG"
        Me.btnXoaPG.Size = New System.Drawing.Size(95, 37)
        Me.btnXoaPG.TabIndex = 86
        Me.btnXoaPG.Text = "Xóa"
        Me.btnXoaPG.UseVisualStyleBackColor = True
        '
        'btnThemPG
        '
        Me.btnThemPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemPG.Location = New System.Drawing.Point(93, 291)
        Me.btnThemPG.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemPG.Name = "btnThemPG"
        Me.btnThemPG.Size = New System.Drawing.Size(95, 37)
        Me.btnThemPG.TabIndex = 85
        Me.btnThemPG.Text = "Thêm"
        Me.btnThemPG.UseVisualStyleBackColor = True
        '
        'dgvChiTietPG
        '
        Me.dgvChiTietPG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvChiTietPG.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChiTietPG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvChiTietPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietPG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaPG_CT, Me.colMaPN_CT, Me.colMaSP, Me.colTenSP, Me.colSoLuong, Me.colMaDV, Me.colTenDV})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvChiTietPG.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvChiTietPG.Location = New System.Drawing.Point(585, 289)
        Me.dgvChiTietPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvChiTietPG.Name = "dgvChiTietPG"
        Me.dgvChiTietPG.RowHeadersVisible = False
        Me.dgvChiTietPG.Size = New System.Drawing.Size(765, 380)
        Me.dgvChiTietPG.TabIndex = 90
        '
        'colMaPG_CT
        '
        Me.colMaPG_CT.DataPropertyName = "MaPG"
        Me.colMaPG_CT.HeaderText = "Mã phiếu nhận"
        Me.colMaPG_CT.Name = "colMaPG_CT"
        '
        'colMaPN_CT
        '
        Me.colMaPN_CT.DataPropertyName = "MaPN"
        Me.colMaPN_CT.HeaderText = "Mã phiếu nhập"
        Me.colMaPN_CT.Name = "colMaPN_CT"
        '
        'colMaSP
        '
        Me.colMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaSP.DataPropertyName = "MaSP"
        Me.colMaSP.HeaderText = "Mã sản phẩm"
        Me.colMaSP.Name = "colMaSP"
        Me.colMaSP.ReadOnly = True
        '
        'colTenSP
        '
        Me.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTenSP.DataPropertyName = "TenSP"
        Me.colTenSP.HeaderText = "Tên sản phẩm"
        Me.colTenSP.Name = "colTenSP"
        Me.colTenSP.ReadOnly = True
        '
        'colSoLuong
        '
        Me.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSoLuong.DataPropertyName = "SoLuong"
        Me.colSoLuong.HeaderText = "Số lượng"
        Me.colSoLuong.Name = "colSoLuong"
        Me.colSoLuong.ReadOnly = True
        '
        'colMaDV
        '
        Me.colMaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaDV.DataPropertyName = "MaDV"
        Me.colMaDV.HeaderText = "Mã đơn vị"
        Me.colMaDV.Name = "colMaDV"
        Me.colMaDV.ReadOnly = True
        '
        'colTenDV
        '
        Me.colTenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTenDV.DataPropertyName = "TenDV"
        Me.colTenDV.HeaderText = "Đơn vị"
        Me.colTenDV.Name = "colTenDV"
        Me.colTenDV.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(581, 259)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(769, 27)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "CHI TIẾT PHIẾU NHẬN"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(744, 131)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(555, 20)
        Me.txtSoLuong.TabIndex = 96
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(614, 129)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 20)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Số lượng"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(614, 87)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 20)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Tên sản phẩm"
        '
        'btnSuaCT
        '
        Me.btnSuaCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaCT.Location = New System.Drawing.Point(1116, 222)
        Me.btnSuaCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaCT.Name = "btnSuaCT"
        Me.btnSuaCT.Size = New System.Drawing.Size(95, 39)
        Me.btnSuaCT.TabIndex = 103
        Me.btnSuaCT.Text = "Sửa"
        Me.btnSuaCT.UseVisualStyleBackColor = True
        '
        'btnXoaCT
        '
        Me.btnXoaCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaCT.Location = New System.Drawing.Point(918, 222)
        Me.btnXoaCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaCT.Name = "btnXoaCT"
        Me.btnXoaCT.Size = New System.Drawing.Size(95, 39)
        Me.btnXoaCT.TabIndex = 102
        Me.btnXoaCT.Text = "Xóa"
        Me.btnXoaCT.UseVisualStyleBackColor = True
        '
        'btnThemCT
        '
        Me.btnThemCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemCT.Location = New System.Drawing.Point(726, 222)
        Me.btnThemCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemCT.Name = "btnThemCT"
        Me.btnThemCT.Size = New System.Drawing.Size(95, 39)
        Me.btnThemCT.TabIndex = 101
        Me.btnThemCT.Text = "Thêm"
        Me.btnThemCT.UseVisualStyleBackColor = True
        '
        'btnTimCT
        '
        Me.btnTimCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimCT.Location = New System.Drawing.Point(1236, 171)
        Me.btnTimCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimCT.Name = "btnTimCT"
        Me.btnTimCT.Size = New System.Drawing.Size(63, 32)
        Me.btnTimCT.TabIndex = 104
        Me.btnTimCT.Text = "Tìm"
        Me.btnTimCT.UseVisualStyleBackColor = True
        '
        'cboTenSP
        '
        Me.cboTenSP.FormattingEnabled = True
        Me.cboTenSP.Location = New System.Drawing.Point(744, 87)
        Me.cboTenSP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboTenSP.Name = "cboTenSP"
        Me.cboTenSP.Size = New System.Drawing.Size(555, 21)
        Me.cboTenSP.TabIndex = 105
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 88)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Mã phiếu nhập"
        '
        'cboMaPN
        '
        Me.cboMaPN.FormattingEnabled = True
        Me.cboMaPN.Location = New System.Drawing.Point(145, 87)
        Me.cboMaPN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboMaPN.Name = "cboMaPN"
        Me.cboMaPN.Size = New System.Drawing.Size(426, 21)
        Me.cboMaPN.TabIndex = 107
        '
        'errPhieuNhan
        '
        Me.errPhieuNhan.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslMaNV, Me.tslTenNV})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 674)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1362, 22)
        Me.StatusStrip1.TabIndex = 108
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslMaNV
        '
        Me.tslMaNV.Name = "tslMaNV"
        Me.tslMaNV.Size = New System.Drawing.Size(121, 17)
        Me.tslMaNV.Text = "ToolStripStatusLabel1"
        '
        'tslTenNV
        '
        Me.tslTenNV.Name = "tslTenNV"
        Me.tslTenNV.Size = New System.Drawing.Size(121, 17)
        Me.tslTenNV.Text = "ToolStripStatusLabel2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Tìm kiếm"
        '
        'txtTimPG
        '
        Me.txtTimPG.Location = New System.Drawing.Point(106, 261)
        Me.txtTimPG.Name = "txtTimPG"
        Me.txtTimPG.Size = New System.Drawing.Size(405, 20)
        Me.txtTimPG.TabIndex = 110
        '
        'txtTimCT
        '
        Me.txtTimCT.Location = New System.Drawing.Point(744, 179)
        Me.txtTimCT.Name = "txtTimCT"
        Me.txtTimCT.Size = New System.Drawing.Size(487, 20)
        Me.txtTimCT.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(614, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Tìm kiếm"
        '
        'colMaPG
        '
        Me.colMaPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaPG.DataPropertyName = "MaPG"
        Me.colMaPG.HeaderText = "Mã phiếu nhận"
        Me.colMaPG.Name = "colMaPG"
        Me.colMaPG.ReadOnly = True
        '
        'colMaPN
        '
        Me.colMaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaPN.DataPropertyName = "MaPN"
        Me.colMaPN.HeaderText = "Mã phiếu nhập"
        Me.colMaPN.Name = "colMaPN"
        Me.colMaPN.ReadOnly = True
        '
        'colMaNV
        '
        Me.colMaNV.DataPropertyName = "MaNV"
        Me.colMaNV.HeaderText = "Mã nhân viên"
        Me.colMaNV.Name = "colMaNV"
        '
        'colHoTen
        '
        Me.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colHoTen.DataPropertyName = "HoTen"
        Me.colHoTen.HeaderText = "Tên nhân viên"
        Me.colHoTen.Name = "colHoTen"
        Me.colHoTen.ReadOnly = True
        '
        'colTongTien
        '
        Me.colTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTongTien.DataPropertyName = "TongTien"
        Me.colTongTien.HeaderText = "Tổng tiền"
        Me.colTongTien.Name = "colTongTien"
        Me.colTongTien.ReadOnly = True
        '
        'colNgayLap
        '
        Me.colNgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNgayLap.DataPropertyName = "NgayLap"
        Me.colNgayLap.HeaderText = "Ngày lập"
        Me.colNgayLap.Name = "colNgayLap"
        Me.colNgayLap.ReadOnly = True
        '
        'colGhiChu
        '
        Me.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colGhiChu.DataPropertyName = "GhiChu"
        Me.colGhiChu.HeaderText = "Ghi chú"
        Me.colGhiChu.Name = "colGhiChu"
        Me.colGhiChu.ReadOnly = True
        '
        'FrmQLPhieuNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 696)
        Me.Controls.Add(Me.txtTimCT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTimPG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cboMaPN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboTenSP)
        Me.Controls.Add(Me.btnTimCT)
        Me.Controls.Add(Me.btnSuaCT)
        Me.Controls.Add(Me.btnXoaCT)
        Me.Controls.Add(Me.btnThemCT)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dgvChiTietPG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnTimPG)
        Me.Controls.Add(Me.btnSuaPG)
        Me.Controls.Add(Me.btnXoaPG)
        Me.Controls.Add(Me.btnThemPG)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtTongTien)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpNgayLap)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvDanhSachPG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmQLPhieuNhan"
        Me.Text = "Thủ kho - Quản lý phiếu nhận"
        CType(Me.dgvDanhSachPG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChiTietPG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errPhieuNhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSachPG As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents txtTongTien As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpNgayLap As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTimPG As Button
    Friend WithEvents btnSuaPG As Button
    Friend WithEvents btnXoaPG As Button
    Friend WithEvents btnThemPG As Button
    Friend WithEvents dgvChiTietPG As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSuaCT As Button
    Friend WithEvents btnXoaCT As Button
    Friend WithEvents btnThemCT As Button
    Friend WithEvents btnTimCT As Button
    Friend WithEvents cboTenSP As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboMaPN As ComboBox
    Friend WithEvents errPhieuNhan As ErrorProvider
    Friend WithEvents colMaPG_CT As DataGridViewTextBoxColumn
    Friend WithEvents colMaPN_CT As DataGridViewTextBoxColumn
    Friend WithEvents colMaSP As DataGridViewTextBoxColumn
    Friend WithEvents colTenSP As DataGridViewTextBoxColumn
    Friend WithEvents colSoLuong As DataGridViewTextBoxColumn
    Friend WithEvents colMaDV As DataGridViewTextBoxColumn
    Friend WithEvents colTenDV As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslMaNV As ToolStripStatusLabel
    Friend WithEvents tslTenNV As ToolStripStatusLabel
    Friend WithEvents txtTimCT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTimPG As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents colMaPG As DataGridViewTextBoxColumn
    Friend WithEvents colMaPN As DataGridViewTextBoxColumn
    Friend WithEvents colMaNV As DataGridViewTextBoxColumn
    Friend WithEvents colHoTen As DataGridViewTextBoxColumn
    Friend WithEvents colTongTien As DataGridViewTextBoxColumn
    Friend WithEvents colNgayLap As DataGridViewTextBoxColumn
    Friend WithEvents colGhiChu As DataGridViewTextBoxColumn
End Class
