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
        Me.dgvDanhSachPG = New System.Windows.Forms.DataGridView()
        Me.MaPG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.MaSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTienCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.erMaPN = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erTongTien = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erTenSP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erSoLuong = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvDanhSachPG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChiTietPG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erMaPN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erTongTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erTenSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSachPG
        '
        Me.dgvDanhSachPG.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvDanhSachPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPG, Me.MaPN, Me.HoTen, Me.TongTien, Me.NgayLap, Me.GhiChu})
        Me.dgvDanhSachPG.Location = New System.Drawing.Point(11, 352)
        Me.dgvDanhSachPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvDanhSachPG.Name = "dgvDanhSachPG"
        Me.dgvDanhSachPG.Size = New System.Drawing.Size(560, 386)
        Me.dgvDanhSachPG.TabIndex = 7
        '
        'MaPG
        '
        Me.MaPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaPG.DataPropertyName = "MaPG"
        Me.MaPG.HeaderText = "Mã phiếu nhận"
        Me.MaPG.Name = "MaPG"
        Me.MaPG.ReadOnly = True
        '
        'MaPN
        '
        Me.MaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaPN.DataPropertyName = "MaPN"
        Me.MaPN.HeaderText = "Mã phiếu nhập"
        Me.MaPN.Name = "MaPN"
        Me.MaPN.ReadOnly = True
        '
        'HoTen
        '
        Me.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoTen.DataPropertyName = "HoTen"
        Me.HoTen.HeaderText = "Tên nhân viên"
        Me.HoTen.Name = "HoTen"
        Me.HoTen.ReadOnly = True
        '
        'TongTien
        '
        Me.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TongTien.DataPropertyName = "TongTien"
        Me.TongTien.HeaderText = "Tổng tiền"
        Me.TongTien.Name = "TongTien"
        Me.TongTien.ReadOnly = True
        '
        'NgayLap
        '
        Me.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NgayLap.DataPropertyName = "NgayLap"
        Me.NgayLap.HeaderText = "Ngày lập"
        Me.NgayLap.Name = "NgayLap"
        Me.NgayLap.ReadOnly = True
        '
        'GhiChu
        '
        Me.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi chú"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1339, 71)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "QUẢN LÝ PHIẾU NHẬN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 323)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(560, 36)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DANH SÁCH PHIẾU NHẬN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(106, 239)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(466, 21)
        Me.txtGhiChu.TabIndex = 83
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(108, 141)
        Me.txtTongTien.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(464, 21)
        Me.txtTongTien.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 141)
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
        Me.dtpNgayLap.Location = New System.Drawing.Point(106, 193)
        Me.dtpNgayLap.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(466, 21)
        Me.dtpNgayLap.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 239)
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
        Me.Label5.Location = New System.Drawing.Point(14, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Ngày lập"
        '
        'btnTimPG
        '
        Me.btnTimPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimPG.Location = New System.Drawing.Point(472, 276)
        Me.btnTimPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimPG.Name = "btnTimPG"
        Me.btnTimPG.Size = New System.Drawing.Size(95, 42)
        Me.btnTimPG.TabIndex = 88
        Me.btnTimPG.Text = "Tìm"
        Me.btnTimPG.UseVisualStyleBackColor = True
        '
        'btnSuaPG
        '
        Me.btnSuaPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaPG.Location = New System.Drawing.Point(323, 276)
        Me.btnSuaPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaPG.Name = "btnSuaPG"
        Me.btnSuaPG.Size = New System.Drawing.Size(95, 42)
        Me.btnSuaPG.TabIndex = 87
        Me.btnSuaPG.Text = "Sửa"
        Me.btnSuaPG.UseVisualStyleBackColor = True
        '
        'btnXoaPG
        '
        Me.btnXoaPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaPG.Location = New System.Drawing.Point(162, 276)
        Me.btnXoaPG.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaPG.Name = "btnXoaPG"
        Me.btnXoaPG.Size = New System.Drawing.Size(95, 40)
        Me.btnXoaPG.TabIndex = 86
        Me.btnXoaPG.Text = "Xóa"
        Me.btnXoaPG.UseVisualStyleBackColor = True
        '
        'btnThemPG
        '
        Me.btnThemPG.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemPG.Location = New System.Drawing.Point(13, 278)
        Me.btnThemPG.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemPG.Name = "btnThemPG"
        Me.btnThemPG.Size = New System.Drawing.Size(95, 40)
        Me.btnThemPG.TabIndex = 85
        Me.btnThemPG.Text = "Thêm"
        Me.btnThemPG.UseVisualStyleBackColor = True
        '
        'dgvChiTietPG
        '
        Me.dgvChiTietPG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvChiTietPG.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvChiTietPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietPG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSP, Me.TenSP, Me.SoLuong, Me.TenDV, Me.DonGia, Me.TongTienCT})
        Me.dgvChiTietPG.Location = New System.Drawing.Point(585, 296)
        Me.dgvChiTietPG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvChiTietPG.Name = "dgvChiTietPG"
        Me.dgvChiTietPG.Size = New System.Drawing.Size(765, 442)
        Me.dgvChiTietPG.TabIndex = 90
        '
        'MaSP
        '
        Me.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaSP.DataPropertyName = "MaSP"
        Me.MaSP.HeaderText = "Mã sản phẩm"
        Me.MaSP.Name = "MaSP"
        Me.MaSP.ReadOnly = True
        '
        'TenSP
        '
        Me.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenSP.DataPropertyName = "TenSP"
        Me.TenSP.HeaderText = "Tên sản phẩm"
        Me.TenSP.Name = "TenSP"
        Me.TenSP.ReadOnly = True
        '
        'SoLuong
        '
        Me.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SoLuong.DataPropertyName = "SoLuong"
        Me.SoLuong.HeaderText = "Số lượng"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.ReadOnly = True
        '
        'TenDV
        '
        Me.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenDV.DataPropertyName = "TenDV"
        Me.TenDV.HeaderText = "Đơn vị"
        Me.TenDV.Name = "TenDV"
        Me.TenDV.ReadOnly = True
        '
        'DonGia
        '
        Me.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DonGia.DataPropertyName = "DonGia"
        Me.DonGia.HeaderText = "Đơn giá"
        Me.DonGia.Name = "DonGia"
        Me.DonGia.ReadOnly = True
        '
        'TongTienCT
        '
        Me.TongTienCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TongTienCT.DataPropertyName = "TongTien"
        Me.TongTienCT.HeaderText = "Tổng tiền"
        Me.TongTienCT.Name = "TongTienCT"
        Me.TongTienCT.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(581, 264)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(769, 29)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "CHI TIẾT PHIẾU NHẬN"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(744, 141)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(555, 21)
        Me.txtSoLuong.TabIndex = 96
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(620, 141)
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
        Me.Label15.Location = New System.Drawing.Point(614, 94)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 20)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Tên sản phẩm"
        '
        'btnSuaCT
        '
        Me.btnSuaCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaCT.Location = New System.Drawing.Point(1032, 194)
        Me.btnSuaCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaCT.Name = "btnSuaCT"
        Me.btnSuaCT.Size = New System.Drawing.Size(95, 42)
        Me.btnSuaCT.TabIndex = 103
        Me.btnSuaCT.Text = "Sửa"
        Me.btnSuaCT.UseVisualStyleBackColor = True
        '
        'btnXoaCT
        '
        Me.btnXoaCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaCT.Location = New System.Drawing.Point(834, 194)
        Me.btnXoaCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaCT.Name = "btnXoaCT"
        Me.btnXoaCT.Size = New System.Drawing.Size(95, 42)
        Me.btnXoaCT.TabIndex = 102
        Me.btnXoaCT.Text = "Xóa"
        Me.btnXoaCT.UseVisualStyleBackColor = True
        '
        'btnThemCT
        '
        Me.btnThemCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemCT.Location = New System.Drawing.Point(642, 194)
        Me.btnThemCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemCT.Name = "btnThemCT"
        Me.btnThemCT.Size = New System.Drawing.Size(95, 42)
        Me.btnThemCT.TabIndex = 101
        Me.btnThemCT.Text = "Thêm"
        Me.btnThemCT.UseVisualStyleBackColor = True
        '
        'btnTimCT
        '
        Me.btnTimCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimCT.Location = New System.Drawing.Point(1204, 194)
        Me.btnTimCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimCT.Name = "btnTimCT"
        Me.btnTimCT.Size = New System.Drawing.Size(95, 42)
        Me.btnTimCT.TabIndex = 104
        Me.btnTimCT.Text = "Tìm"
        Me.btnTimCT.UseVisualStyleBackColor = True
        '
        'cboTenSP
        '
        Me.cboTenSP.FormattingEnabled = True
        Me.cboTenSP.Location = New System.Drawing.Point(744, 94)
        Me.cboTenSP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboTenSP.Name = "cboTenSP"
        Me.cboTenSP.Size = New System.Drawing.Size(555, 22)
        Me.cboTenSP.TabIndex = 105
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Mã phiếu nhập"
        '
        'cboMaPN
        '
        Me.cboMaPN.FormattingEnabled = True
        Me.cboMaPN.Location = New System.Drawing.Point(145, 94)
        Me.cboMaPN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboMaPN.Name = "cboMaPN"
        Me.cboMaPN.Size = New System.Drawing.Size(426, 22)
        Me.cboMaPN.TabIndex = 107
        '
        'erMaPN
        '
        Me.erMaPN.ContainerControl = Me
        '
        'erTongTien
        '
        Me.erTongTien.ContainerControl = Me
        '
        'erTenSP
        '
        Me.erTenSP.ContainerControl = Me
        '
        'erSoLuong
        '
        Me.erSoLuong.ContainerControl = Me
        '
        'FrmQLPhieuNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 750)
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
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmQLPhieuNhan"
        Me.Text = "Thủ kho - Quản lý phiếu nhận"
        CType(Me.dgvDanhSachPG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChiTietPG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erMaPN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erTongTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erTenSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erSoLuong, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents erMaPN As ErrorProvider
    Friend WithEvents erTongTien As ErrorProvider
    Friend WithEvents erTenSP As ErrorProvider
    Friend WithEvents erSoLuong As ErrorProvider
    Friend WithEvents MaPG As DataGridViewTextBoxColumn
    Friend WithEvents MaPN As DataGridViewTextBoxColumn
    Friend WithEvents HoTen As DataGridViewTextBoxColumn
    Friend WithEvents TongTien As DataGridViewTextBoxColumn
    Friend WithEvents NgayLap As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
    Friend WithEvents MaSP As DataGridViewTextBoxColumn
    Friend WithEvents TenSP As DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As DataGridViewTextBoxColumn
    Friend WithEvents TenDV As DataGridViewTextBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents TongTienCT As DataGridViewTextBoxColumn
End Class
