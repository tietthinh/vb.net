<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQLPhieuNhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDSPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.MaPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayGiaoDK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbNhaCC = New System.Windows.Forms.ComboBox()
        Me.dtpNgayGiao = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTimPN = New System.Windows.Forms.Button()
        Me.btnSuaPN = New System.Windows.Forms.Button()
        Me.btnXoaPN = New System.Windows.Forms.Button()
        Me.btnThemPN = New System.Windows.Forms.Button()
        Me.dgvDSChiTietPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.MaSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTimCT = New System.Windows.Forms.Button()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.cbDonVi = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSuaCT = New System.Windows.Forms.Button()
        Me.btnXoaCT = New System.Windows.Forms.Button()
        Me.btnThemCT = New System.Windows.Forms.Button()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTimLB = New System.Windows.Forms.TextBox()
        Me.btnTimLB = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.erNCC = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erSoLuong = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erDonVi = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erDonGia = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erTongTien = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erTimKiem = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erTenSP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lstTimKiem = New System.Windows.Forms.ListView()
        Me.MaSPTimKiem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SanPham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SoLuongTon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDSChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erNCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erSoLuong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erDonVi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erDonGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erTongTien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erTimKiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erTenSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1339, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ PHIẾU NHẬP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDSPhieuNhap
        '
        Me.dgvDSPhieuNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDSPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPN, Me.HoTen, Me.TenNCC, Me.NgayLap, Me.NgayGiaoDK, Me.TinhTrang})
        Me.dgvDSPhieuNhap.Location = New System.Drawing.Point(11, 321)
        Me.dgvDSPhieuNhap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap"
        Me.dgvDSPhieuNhap.Size = New System.Drawing.Size(455, 373)
        Me.dgvDSPhieuNhap.TabIndex = 1
        '
        'MaPN
        '
        Me.MaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaPN.DataPropertyName = "MaPN"
        Me.MaPN.HeaderText = "Mã phiếu nhập"
        Me.MaPN.Name = "MaPN"
        '
        'HoTen
        '
        Me.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoTen.DataPropertyName = "HoTen"
        Me.HoTen.HeaderText = "Tên nhân viên"
        Me.HoTen.Name = "HoTen"
        '
        'TenNCC
        '
        Me.TenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenNCC.DataPropertyName = "TenNCC"
        Me.TenNCC.HeaderText = "Nhà cung cấp"
        Me.TenNCC.Name = "TenNCC"
        '
        'NgayLap
        '
        Me.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NgayLap.DataPropertyName = "NgayLap"
        Me.NgayLap.HeaderText = "Ngày lập"
        Me.NgayLap.Name = "NgayLap"
        '
        'NgayGiaoDK
        '
        Me.NgayGiaoDK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NgayGiaoDK.DataPropertyName = "NgayGiaoDK"
        Me.NgayGiaoDK.HeaderText = "Ngày giao"
        Me.NgayGiaoDK.Name = "NgayGiaoDK"
        '
        'TinhTrang
        '
        Me.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TinhTrang.DataPropertyName = "TinhTrang"
        Me.TinhTrang.HeaderText = "Tình trạng"
        Me.TinhTrang.Name = "TinhTrang"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 282)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(448, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DANH SÁCH PHIẾU NHẬP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbNhaCC
        '
        Me.cbNhaCC.FormattingEnabled = True
        Me.cbNhaCC.Location = New System.Drawing.Point(146, 85)
        Me.cbNhaCC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbNhaCC.Name = "cbNhaCC"
        Me.cbNhaCC.Size = New System.Drawing.Size(314, 22)
        Me.cbNhaCC.TabIndex = 42
        '
        'dtpNgayGiao
        '
        Me.dtpNgayGiao.CustomFormat = "dddd  dd/MM/yyyy  ss:mm:hh"
        Me.dtpNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayGiao.Location = New System.Drawing.Point(116, 139)
        Me.dtpNgayGiao.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpNgayGiao.Name = "dtpNgayGiao"
        Me.dtpNgayGiao.Size = New System.Drawing.Size(342, 21)
        Me.dtpNgayGiao.TabIndex = 41
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.CustomFormat = "dddd    dd/MM/yyyy   hh:mm:ss"
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLap.Location = New System.Drawing.Point(116, 199)
        Me.dtpNgayLap.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(342, 21)
        Me.dtpNgayLap.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Ngày giao"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Ngày lập"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Nhà cung cấp"
        '
        'btnTimPN
        '
        Me.btnTimPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimPN.Location = New System.Drawing.Point(371, 239)
        Me.btnTimPN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimPN.Name = "btnTimPN"
        Me.btnTimPN.Size = New System.Drawing.Size(65, 38)
        Me.btnTimPN.TabIndex = 46
        Me.btnTimPN.Text = "Tìm"
        Me.btnTimPN.UseVisualStyleBackColor = True
        '
        'btnSuaPN
        '
        Me.btnSuaPN.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaPN.Location = New System.Drawing.Point(252, 239)
        Me.btnSuaPN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaPN.Name = "btnSuaPN"
        Me.btnSuaPN.Size = New System.Drawing.Size(65, 38)
        Me.btnSuaPN.TabIndex = 45
        Me.btnSuaPN.Text = "Sửa"
        Me.btnSuaPN.UseVisualStyleBackColor = True
        '
        'btnXoaPN
        '
        Me.btnXoaPN.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaPN.Location = New System.Drawing.Point(145, 239)
        Me.btnXoaPN.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaPN.Name = "btnXoaPN"
        Me.btnXoaPN.Size = New System.Drawing.Size(65, 38)
        Me.btnXoaPN.TabIndex = 44
        Me.btnXoaPN.Text = "Xóa"
        Me.btnXoaPN.UseVisualStyleBackColor = True
        '
        'btnThemPN
        '
        Me.btnThemPN.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemPN.Location = New System.Drawing.Point(42, 239)
        Me.btnThemPN.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemPN.Name = "btnThemPN"
        Me.btnThemPN.Size = New System.Drawing.Size(65, 38)
        Me.btnThemPN.TabIndex = 43
        Me.btnThemPN.Text = "Thêm"
        Me.btnThemPN.UseVisualStyleBackColor = True
        '
        'dgvDSChiTietPhieuNhap
        '
        Me.dgvDSChiTietPhieuNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDSChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvDSChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSChiTietPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSP, Me.TenSP, Me.SoLuong, Me.TenDV, Me.DonGia, Me.TongTien})
        Me.dgvDSChiTietPhieuNhap.Location = New System.Drawing.Point(470, 270)
        Me.dgvDSChiTietPhieuNhap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvDSChiTietPhieuNhap.Name = "dgvDSChiTietPhieuNhap"
        Me.dgvDSChiTietPhieuNhap.Size = New System.Drawing.Size(563, 424)
        Me.dgvDSChiTietPhieuNhap.TabIndex = 48
        '
        'MaSP
        '
        Me.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaSP.DataPropertyName = "MaSP"
        Me.MaSP.HeaderText = "Mã sản phẩm"
        Me.MaSP.Name = "MaSP"
        '
        'TenSP
        '
        Me.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenSP.DataPropertyName = "TenSP"
        Me.TenSP.HeaderText = "Tên sản phẩm"
        Me.TenSP.Name = "TenSP"
        '
        'SoLuong
        '
        Me.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SoLuong.DataPropertyName = "SoLuong"
        Me.SoLuong.HeaderText = "Số lượng"
        Me.SoLuong.Name = "SoLuong"
        '
        'TenDV
        '
        Me.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenDV.DataPropertyName = "TenDV"
        Me.TenDV.HeaderText = "Đơn vị"
        Me.TenDV.Name = "TenDV"
        '
        'DonGia
        '
        Me.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DonGia.DataPropertyName = "DonGia"
        Me.DonGia.HeaderText = "Đơn giá"
        Me.DonGia.Name = "DonGia"
        '
        'TongTien
        '
        Me.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TongTien.DataPropertyName = "TongTien"
        Me.TongTien.HeaderText = "Tổng tiền"
        Me.TongTien.Name = "TongTien"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(466, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(563, 38)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "CHI TIẾT PHIẾU NHẬP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTimCT
        '
        Me.btnTimCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimCT.Location = New System.Drawing.Point(896, 181)
        Me.btnTimCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimCT.Name = "btnTimCT"
        Me.btnTimCT.Size = New System.Drawing.Size(62, 38)
        Me.btnTimCT.TabIndex = 66
        Me.btnTimCT.Text = "Tìm"
        Me.btnTimCT.UseVisualStyleBackColor = True
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(925, 139)
        Me.txtTongTien.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(104, 21)
        Me.txtTongTien.TabIndex = 65
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(731, 139)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(82, 21)
        Me.txtDonGia.TabIndex = 64
        '
        'cbDonVi
        '
        Me.cbDonVi.FormattingEnabled = True
        Me.cbDonVi.Location = New System.Drawing.Point(533, 138)
        Me.cbDonVi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbDonVi.Name = "cbDonVi"
        Me.cbDonVi.Size = New System.Drawing.Size(92, 22)
        Me.cbDonVi.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(835, 139)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Tổng tiền"
        '
        'btnSuaCT
        '
        Me.btnSuaCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaCT.Location = New System.Drawing.Point(776, 182)
        Me.btnSuaCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaCT.Name = "btnSuaCT"
        Me.btnSuaCT.Size = New System.Drawing.Size(62, 40)
        Me.btnSuaCT.TabIndex = 61
        Me.btnSuaCT.Text = "Sửa"
        Me.btnSuaCT.UseVisualStyleBackColor = True
        '
        'btnXoaCT
        '
        Me.btnXoaCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaCT.Location = New System.Drawing.Point(656, 181)
        Me.btnXoaCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaCT.Name = "btnXoaCT"
        Me.btnXoaCT.Size = New System.Drawing.Size(62, 38)
        Me.btnXoaCT.TabIndex = 60
        Me.btnXoaCT.Text = "Xóa"
        Me.btnXoaCT.UseVisualStyleBackColor = True
        '
        'btnThemCT
        '
        Me.btnThemCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemCT.Location = New System.Drawing.Point(544, 183)
        Me.btnThemCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemCT.Name = "btnThemCT"
        Me.btnThemCT.Size = New System.Drawing.Size(62, 38)
        Me.btnThemCT.TabIndex = 59
        Me.btnThemCT.Text = "Thêm"
        Me.btnThemCT.UseVisualStyleBackColor = True
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(925, 90)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(104, 21)
        Me.txtSoLuong.TabIndex = 58
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(598, 88)
        Me.txtTenSP.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.ReadOnly = True
        Me.txtTenSP.Size = New System.Drawing.Size(215, 21)
        Me.txtTenSP.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(652, 139)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Đơn giá"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(466, 137)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 20)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Đơn vị"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(835, 90)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 20)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Số lượng"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(466, 88)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Tên sản phẩm"
        '
        'txtTimLB
        '
        Me.txtTimLB.Location = New System.Drawing.Point(1095, 61)
        Me.txtTimLB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTimLB.Name = "txtTimLB"
        Me.txtTimLB.Size = New System.Drawing.Size(208, 21)
        Me.txtTimLB.TabIndex = 68
        '
        'btnTimLB
        '
        Me.btnTimLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimLB.Location = New System.Drawing.Point(1307, 59)
        Me.btnTimLB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimLB.Name = "btnTimLB"
        Me.btnTimLB.Size = New System.Drawing.Size(47, 22)
        Me.btnTimLB.TabIndex = 69
        Me.btnTimLB.Text = "Tìm"
        Me.btnTimLB.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1034, 64)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Tìm kiếm"
        '
        'erNCC
        '
        Me.erNCC.ContainerControl = Me
        '
        'erSoLuong
        '
        Me.erSoLuong.ContainerControl = Me
        '
        'erDonVi
        '
        Me.erDonVi.ContainerControl = Me
        '
        'erDonGia
        '
        Me.erDonGia.ContainerControl = Me
        '
        'erTongTien
        '
        Me.erTongTien.ContainerControl = Me
        '
        'erTimKiem
        '
        Me.erTimKiem.ContainerControl = Me
        '
        'erTenSP
        '
        Me.erTenSP.ContainerControl = Me
        '
        'lstTimKiem
        '
        Me.lstTimKiem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MaSPTimKiem, Me.SanPham, Me.SoLuongTon})
        Me.lstTimKiem.Location = New System.Drawing.Point(1037, 90)
        Me.lstTimKiem.Name = "lstTimKiem"
        Me.lstTimKiem.Size = New System.Drawing.Size(313, 604)
        Me.lstTimKiem.TabIndex = 71
        Me.lstTimKiem.UseCompatibleStateImageBehavior = False
        Me.lstTimKiem.View = System.Windows.Forms.View.Details
        '
        'MaSPTimKiem
        '
        Me.MaSPTimKiem.Text = "Mã sản phẩm"
        Me.MaSPTimKiem.Width = 99
        '
        'SanPham
        '
        Me.SanPham.Text = "Sản phẩm"
        Me.SanPham.Width = 117
        '
        'SoLuongTon
        '
        Me.SoLuongTon.Text = "Số lượng tồn"
        Me.SoLuongTon.Width = 110
        '
        'FrmQLPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 706)
        Me.Controls.Add(Me.lstTimKiem)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnTimLB)
        Me.Controls.Add(Me.txtTimLB)
        Me.Controls.Add(Me.btnTimCT)
        Me.Controls.Add(Me.txtTongTien)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.cbDonVi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSuaCT)
        Me.Controls.Add(Me.btnXoaCT)
        Me.Controls.Add(Me.btnThemCT)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgvDSChiTietPhieuNhap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTimPN)
        Me.Controls.Add(Me.btnSuaPN)
        Me.Controls.Add(Me.btnXoaPN)
        Me.Controls.Add(Me.btnThemPN)
        Me.Controls.Add(Me.cbNhaCC)
        Me.Controls.Add(Me.dtpNgayGiao)
        Me.Controls.Add(Me.dtpNgayLap)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDSPhieuNhap)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmQLPhieuNhap"
        Me.Text = "Thủ kho - Quản lý phiếu nhập"
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDSChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erNCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erSoLuong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erDonVi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erDonGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erTongTien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erTimKiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erTenSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDSPhieuNhap As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbNhaCC As ComboBox
    Friend WithEvents dtpNgayGiao As DateTimePicker
    Friend WithEvents dtpNgayLap As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTimPN As Button
    Friend WithEvents btnSuaPN As Button
    Friend WithEvents btnXoaPN As Button
    Friend WithEvents btnThemPN As Button
    Friend WithEvents dgvDSChiTietPhieuNhap As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTimCT As Button
    Friend WithEvents txtTongTien As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents cbDonVi As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSuaCT As Button
    Friend WithEvents btnXoaCT As Button
    Friend WithEvents btnThemCT As Button
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTimLB As TextBox
    Friend WithEvents btnTimLB As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents erNCC As ErrorProvider
    Friend WithEvents erSoLuong As ErrorProvider
    Friend WithEvents erDonVi As ErrorProvider
    Friend WithEvents erDonGia As ErrorProvider
    Friend WithEvents erTongTien As ErrorProvider
    Friend WithEvents erTimKiem As ErrorProvider
    Friend WithEvents erTenSP As ErrorProvider
    Friend WithEvents MaPN As DataGridViewTextBoxColumn
    Friend WithEvents HoTen As DataGridViewTextBoxColumn
    Friend WithEvents TenNCC As DataGridViewTextBoxColumn
    Friend WithEvents NgayLap As DataGridViewTextBoxColumn
    Friend WithEvents NgayGiaoDK As DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As DataGridViewTextBoxColumn
    Friend WithEvents MaSP As DataGridViewTextBoxColumn
    Friend WithEvents TenSP As DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As DataGridViewTextBoxColumn
    Friend WithEvents TenDV As DataGridViewTextBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents TongTien As DataGridViewTextBoxColumn
    Friend WithEvents lstTimKiem As ListView
    Friend WithEvents MaSPTimKiem As ColumnHeader
    Friend WithEvents SanPham As ColumnHeader
    Friend WithEvents SoLuongTon As ColumnHeader
End Class
