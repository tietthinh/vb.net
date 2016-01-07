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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDSPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.colMaPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaNCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenNCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNgayLap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNgayGiaoDK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboNCC = New System.Windows.Forms.ComboBox()
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
        Me.colMaPN_CT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenSP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTenDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colThanhTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTimCT = New System.Windows.Forms.Button()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.cboDonVi = New System.Windows.Forms.ComboBox()
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
        Me.errPhieuNhap = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lstTimKiem = New System.Windows.Forms.ListView()
        Me.MaSPTimKiem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SanPham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SoLuongTon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sttPhieuNhap = New System.Windows.Forms.StatusStrip()
        Me.tslMaNV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslTenNV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTongTien = New System.Windows.Forms.TextBox()
        Me.txtTimPN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTimCT = New System.Windows.Forms.TextBox()
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDSChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sttPhieuNhap.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1339, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ PHIẾU NHẬP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDSPhieuNhap
        '
        Me.dgvDSPhieuNhap.AllowUserToAddRows = False
        Me.dgvDSPhieuNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDSPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvDSPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDSPhieuNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaPN, Me.colMaNV, Me.colHoTen, Me.colMaNCC, Me.colTenNCC, Me.colTongTien, Me.colNgayLap, Me.colNgayGiaoDK, Me.colTinhTrang})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDSPhieuNhap.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDSPhieuNhap.Location = New System.Drawing.Point(11, 350)
        Me.dgvDSPhieuNhap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap"
        Me.dgvDSPhieuNhap.ReadOnly = True
        Me.dgvDSPhieuNhap.RowHeadersVisible = False
        Me.dgvDSPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSPhieuNhap.Size = New System.Drawing.Size(455, 331)
        Me.dgvDSPhieuNhap.TabIndex = 1
        '
        'colMaPN
        '
        Me.colMaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaPN.DataPropertyName = "MaPN"
        Me.colMaPN.HeaderText = "Mã phiếu nhập"
        Me.colMaPN.Name = "colMaPN"
        Me.colMaPN.ReadOnly = True
        Me.colMaPN.Visible = False
        '
        'colMaNV
        '
        Me.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaNV.DataPropertyName = "MaNV"
        Me.colMaNV.HeaderText = "Mã nhân viên"
        Me.colMaNV.Name = "colMaNV"
        Me.colMaNV.ReadOnly = True
        Me.colMaNV.Visible = False
        '
        'colHoTen
        '
        Me.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colHoTen.DataPropertyName = "HoTen"
        Me.colHoTen.HeaderText = "Nhân viên"
        Me.colHoTen.Name = "colHoTen"
        Me.colHoTen.ReadOnly = True
        '
        'colMaNCC
        '
        Me.colMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaNCC.DataPropertyName = "MaNCC"
        Me.colMaNCC.HeaderText = "Mã nhà cung cấp"
        Me.colMaNCC.Name = "colMaNCC"
        Me.colMaNCC.ReadOnly = True
        Me.colMaNCC.Visible = False
        '
        'colTenNCC
        '
        Me.colTenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTenNCC.DataPropertyName = "TenNCC"
        Me.colTenNCC.HeaderText = "Nhà cung cấp"
        Me.colTenNCC.Name = "colTenNCC"
        Me.colTenNCC.ReadOnly = True
        '
        'colTongTien
        '
        Me.colTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTongTien.DataPropertyName = "TongTien"
        Me.colTongTien.HeaderText = "Tổng tiền"
        Me.colTongTien.Name = "colTongTien"
        Me.colTongTien.ReadOnly = True
        '
        'colNgayLap
        '
        Me.colNgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNgayLap.DataPropertyName = "NgayLap"
        Me.colNgayLap.HeaderText = "Ngày lập"
        Me.colNgayLap.Name = "colNgayLap"
        Me.colNgayLap.ReadOnly = True
        '
        'colNgayGiaoDK
        '
        Me.colNgayGiaoDK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNgayGiaoDK.DataPropertyName = "NgayGiaoDK"
        Me.colNgayGiaoDK.HeaderText = "Ngày giao"
        Me.colNgayGiaoDK.Name = "colNgayGiaoDK"
        Me.colNgayGiaoDK.ReadOnly = True
        '
        'colTinhTrang
        '
        Me.colTinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTinhTrang.DataPropertyName = "TinhTrang"
        Me.colTinhTrang.HeaderText = "Tình trạng"
        Me.colTinhTrang.Name = "colTinhTrang"
        Me.colTinhTrang.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 314)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(455, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DANH SÁCH PHIẾU NHẬP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboNCC
        '
        Me.cboNCC.FormattingEnabled = True
        Me.cboNCC.Location = New System.Drawing.Point(133, 76)
        Me.cboNCC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboNCC.Name = "cboNCC"
        Me.cboNCC.Size = New System.Drawing.Size(325, 21)
        Me.cboNCC.TabIndex = 42
        '
        'dtpNgayGiao
        '
        Me.dtpNgayGiao.CustomFormat = "dd/MM/yyyy  ss:mm:hh"
        Me.dtpNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayGiao.Location = New System.Drawing.Point(116, 153)
        Me.dtpNgayGiao.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpNgayGiao.Name = "dtpNgayGiao"
        Me.dtpNgayGiao.Size = New System.Drawing.Size(342, 20)
        Me.dtpNgayGiao.TabIndex = 41
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.CustomFormat = "dd/MM/yyyy   hh:mm:ss"
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLap.Location = New System.Drawing.Point(116, 194)
        Me.dtpNgayLap.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(342, 20)
        Me.dtpNgayLap.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 153)
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
        Me.Label5.Location = New System.Drawing.Point(19, 194)
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
        Me.Label7.Location = New System.Drawing.Point(19, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Nhà cung cấp"
        '
        'btnTimPN
        '
        Me.btnTimPN.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimPN.Location = New System.Drawing.Point(410, 233)
        Me.btnTimPN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimPN.Name = "btnTimPN"
        Me.btnTimPN.Size = New System.Drawing.Size(48, 27)
        Me.btnTimPN.TabIndex = 46
        Me.btnTimPN.Text = "Tìm"
        Me.btnTimPN.UseVisualStyleBackColor = True
        '
        'btnSuaPN
        '
        Me.btnSuaPN.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaPN.Location = New System.Drawing.Point(320, 273)
        Me.btnSuaPN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaPN.Name = "btnSuaPN"
        Me.btnSuaPN.Size = New System.Drawing.Size(85, 35)
        Me.btnSuaPN.TabIndex = 45
        Me.btnSuaPN.Text = "Hoàn thành"
        Me.btnSuaPN.UseVisualStyleBackColor = True
        '
        'btnXoaPN
        '
        Me.btnXoaPN.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaPN.Location = New System.Drawing.Point(195, 273)
        Me.btnXoaPN.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaPN.Name = "btnXoaPN"
        Me.btnXoaPN.Size = New System.Drawing.Size(85, 35)
        Me.btnXoaPN.TabIndex = 44
        Me.btnXoaPN.Text = "Xóa"
        Me.btnXoaPN.UseVisualStyleBackColor = True
        '
        'btnThemPN
        '
        Me.btnThemPN.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemPN.Location = New System.Drawing.Point(78, 274)
        Me.btnThemPN.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemPN.Name = "btnThemPN"
        Me.btnThemPN.Size = New System.Drawing.Size(80, 35)
        Me.btnThemPN.TabIndex = 43
        Me.btnThemPN.Text = "Lập phiếu"
        Me.btnThemPN.UseVisualStyleBackColor = True
        '
        'dgvDSChiTietPhieuNhap
        '
        Me.dgvDSChiTietPhieuNhap.AllowUserToAddRows = False
        Me.dgvDSChiTietPhieuNhap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDSChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDSChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDSChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSChiTietPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMaPN_CT, Me.colMaSP, Me.colTenSP, Me.colSoLuong, Me.colMaDV, Me.colTenDV, Me.colDonGia, Me.colThanhTien})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDSChiTietPhieuNhap.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDSChiTietPhieuNhap.Location = New System.Drawing.Point(470, 273)
        Me.dgvDSChiTietPhieuNhap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvDSChiTietPhieuNhap.Name = "dgvDSChiTietPhieuNhap"
        Me.dgvDSChiTietPhieuNhap.ReadOnly = True
        Me.dgvDSChiTietPhieuNhap.RowHeadersVisible = False
        Me.dgvDSChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSChiTietPhieuNhap.Size = New System.Drawing.Size(563, 408)
        Me.dgvDSChiTietPhieuNhap.TabIndex = 48
        '
        'colMaPN_CT
        '
        Me.colMaPN_CT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaPN_CT.DataPropertyName = "MaPN"
        Me.colMaPN_CT.HeaderText = "Mã phiếu nhập"
        Me.colMaPN_CT.Name = "colMaPN_CT"
        Me.colMaPN_CT.ReadOnly = True
        Me.colMaPN_CT.Visible = False
        '
        'colMaSP
        '
        Me.colMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMaSP.DataPropertyName = "MaSP"
        Me.colMaSP.HeaderText = "Mã sản phẩm"
        Me.colMaSP.Name = "colMaSP"
        Me.colMaSP.ReadOnly = True
        Me.colMaSP.Visible = False
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
        'colDonGia
        '
        Me.colDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDonGia.DataPropertyName = "DonGia"
        Me.colDonGia.HeaderText = "Đơn giá"
        Me.colDonGia.Name = "colDonGia"
        Me.colDonGia.ReadOnly = True
        '
        'colThanhTien
        '
        Me.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colThanhTien.DataPropertyName = "ThanhTien"
        Me.colThanhTien.HeaderText = "Thành tiền"
        Me.colThanhTien.Name = "colThanhTien"
        Me.colThanhTien.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(470, 239)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(563, 35)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "CHI TIẾT PHIẾU NHẬP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTimCT
        '
        Me.btnTimCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimCT.Location = New System.Drawing.Point(964, 162)
        Me.btnTimCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimCT.Name = "btnTimCT"
        Me.btnTimCT.Size = New System.Drawing.Size(65, 35)
        Me.btnTimCT.TabIndex = 66
        Me.btnTimCT.Text = "Tìm"
        Me.btnTimCT.UseVisualStyleBackColor = True
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(925, 129)
        Me.txtThanhTien.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(104, 20)
        Me.txtThanhTien.TabIndex = 65
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(731, 129)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(82, 20)
        Me.txtDonGia.TabIndex = 64
        '
        'cboDonVi
        '
        Me.cboDonVi.FormattingEnabled = True
        Me.cboDonVi.Location = New System.Drawing.Point(533, 128)
        Me.cboDonVi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboDonVi.Name = "cboDonVi"
        Me.cboDonVi.Size = New System.Drawing.Size(92, 21)
        Me.cboDonVi.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(835, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Thành tiền"
        '
        'btnSuaCT
        '
        Me.btnSuaCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaCT.Location = New System.Drawing.Point(831, 199)
        Me.btnSuaCT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuaCT.Name = "btnSuaCT"
        Me.btnSuaCT.Size = New System.Drawing.Size(65, 35)
        Me.btnSuaCT.TabIndex = 61
        Me.btnSuaCT.Text = "Sửa"
        Me.btnSuaCT.UseVisualStyleBackColor = True
        '
        'btnXoaCT
        '
        Me.btnXoaCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaCT.Location = New System.Drawing.Point(731, 199)
        Me.btnXoaCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnXoaCT.Name = "btnXoaCT"
        Me.btnXoaCT.Size = New System.Drawing.Size(65, 35)
        Me.btnXoaCT.TabIndex = 60
        Me.btnXoaCT.Text = "Xóa"
        Me.btnXoaCT.UseVisualStyleBackColor = True
        '
        'btnThemCT
        '
        Me.btnThemCT.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemCT.Location = New System.Drawing.Point(631, 199)
        Me.btnThemCT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnThemCT.Name = "btnThemCT"
        Me.btnThemCT.Size = New System.Drawing.Size(65, 35)
        Me.btnThemCT.TabIndex = 59
        Me.btnThemCT.Text = "Thêm"
        Me.btnThemCT.UseVisualStyleBackColor = True
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(925, 84)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(104, 20)
        Me.txtSoLuong.TabIndex = 58
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(598, 82)
        Me.txtTenSP.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.ReadOnly = True
        Me.txtTenSP.Size = New System.Drawing.Size(215, 20)
        Me.txtTenSP.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(652, 129)
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
        Me.Label11.Location = New System.Drawing.Point(466, 127)
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
        Me.Label12.Location = New System.Drawing.Point(835, 84)
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
        Me.Label13.Location = New System.Drawing.Point(466, 82)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Tên sản phẩm"
        '
        'txtTimLB
        '
        Me.txtTimLB.Location = New System.Drawing.Point(1095, 57)
        Me.txtTimLB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTimLB.Name = "txtTimLB"
        Me.txtTimLB.Size = New System.Drawing.Size(208, 20)
        Me.txtTimLB.TabIndex = 68
        '
        'btnTimLB
        '
        Me.btnTimLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimLB.Location = New System.Drawing.Point(1307, 55)
        Me.btnTimLB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTimLB.Name = "btnTimLB"
        Me.btnTimLB.Size = New System.Drawing.Size(47, 20)
        Me.btnTimLB.TabIndex = 69
        Me.btnTimLB.Text = "Tìm"
        Me.btnTimLB.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1034, 59)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Tìm kiếm"
        '
        'errPhieuNhap
        '
        Me.errPhieuNhap.ContainerControl = Me
        '
        'lstTimKiem
        '
        Me.lstTimKiem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MaSPTimKiem, Me.SanPham, Me.SoLuongTon})
        Me.lstTimKiem.FullRowSelect = True
        Me.lstTimKiem.Location = New System.Drawing.Point(1037, 84)
        Me.lstTimKiem.Name = "lstTimKiem"
        Me.lstTimKiem.Size = New System.Drawing.Size(313, 597)
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
        'sttPhieuNhap
        '
        Me.sttPhieuNhap.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslMaNV, Me.tslTenNV})
        Me.sttPhieuNhap.Location = New System.Drawing.Point(0, 684)
        Me.sttPhieuNhap.Name = "sttPhieuNhap"
        Me.sttPhieuNhap.Size = New System.Drawing.Size(1362, 22)
        Me.sttPhieuNhap.TabIndex = 72
        Me.sttPhieuNhap.Text = "StatusStrip1"
        '
        'tslMaNV
        '
        Me.tslMaNV.Name = "tslMaNV"
        Me.tslMaNV.Size = New System.Drawing.Size(79, 17)
        Me.tslMaNV.Text = "Mã nhân viên"
        '
        'tslTenNV
        '
        Me.tslTenNV.Name = "tslTenNV"
        Me.tslTenNV.Size = New System.Drawing.Size(82, 17)
        Me.tslTenNV.Text = "Tên nhân viên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Tổng tiền"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Tìm kiếm"
        '
        'txtTongTien
        '
        Me.txtTongTien.Location = New System.Drawing.Point(116, 114)
        Me.txtTongTien.Name = "txtTongTien"
        Me.txtTongTien.Size = New System.Drawing.Size(342, 20)
        Me.txtTongTien.TabIndex = 75
        '
        'txtTimPN
        '
        Me.txtTimPN.Location = New System.Drawing.Point(116, 237)
        Me.txtTimPN.Name = "txtTimPN"
        Me.txtTimPN.Size = New System.Drawing.Size(289, 20)
        Me.txtTimPN.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(466, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 20)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Tìm kiếm"
        '
        'txtTimCT
        '
        Me.txtTimCT.Location = New System.Drawing.Point(549, 171)
        Me.txtTimCT.Name = "txtTimCT"
        Me.txtTimCT.Size = New System.Drawing.Size(410, 20)
        Me.txtTimCT.TabIndex = 78
        '
        'FrmQLPhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 706)
        Me.Controls.Add(Me.txtTimCT)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTimPN)
        Me.Controls.Add(Me.txtTongTien)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sttPhieuNhap)
        Me.Controls.Add(Me.lstTimKiem)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnTimLB)
        Me.Controls.Add(Me.txtTimLB)
        Me.Controls.Add(Me.btnTimCT)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.cboDonVi)
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
        Me.Controls.Add(Me.cboNCC)
        Me.Controls.Add(Me.dtpNgayGiao)
        Me.Controls.Add(Me.dtpNgayLap)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDSPhieuNhap)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmQLPhieuNhap"
        Me.Text = "Thủ kho - Quản lý phiếu nhập"
        CType(Me.dgvDSPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDSChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sttPhieuNhap.ResumeLayout(False)
        Me.sttPhieuNhap.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDSPhieuNhap As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cboNCC As ComboBox
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
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents cboDonVi As ComboBox
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
    Friend WithEvents errPhieuNhap As ErrorProvider
    Friend WithEvents lstTimKiem As ListView
    Friend WithEvents MaSPTimKiem As ColumnHeader
    Friend WithEvents SanPham As ColumnHeader
    Friend WithEvents SoLuongTon As ColumnHeader
    Friend WithEvents sttPhieuNhap As StatusStrip
    Friend WithEvents tslMaNV As ToolStripStatusLabel
    Friend WithEvents tslTenNV As ToolStripStatusLabel
    Friend WithEvents txtTimPN As TextBox
    Friend WithEvents txtTongTien As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents colMaPN As DataGridViewTextBoxColumn
    Friend WithEvents colMaNV As DataGridViewTextBoxColumn
    Friend WithEvents colHoTen As DataGridViewTextBoxColumn
    Friend WithEvents colMaNCC As DataGridViewTextBoxColumn
    Friend WithEvents colTenNCC As DataGridViewTextBoxColumn
    Friend WithEvents colTongTien As DataGridViewTextBoxColumn
    Friend WithEvents colNgayLap As DataGridViewTextBoxColumn
    Friend WithEvents colNgayGiaoDK As DataGridViewTextBoxColumn
    Friend WithEvents colTinhTrang As DataGridViewTextBoxColumn
    Friend WithEvents colMaPN_CT As DataGridViewTextBoxColumn
    Friend WithEvents colMaSP As DataGridViewTextBoxColumn
    Friend WithEvents colTenSP As DataGridViewTextBoxColumn
    Friend WithEvents colSoLuong As DataGridViewTextBoxColumn
    Friend WithEvents colMaDV As DataGridViewTextBoxColumn
    Friend WithEvents colTenDV As DataGridViewTextBoxColumn
    Friend WithEvents colDonGia As DataGridViewTextBoxColumn
    Friend WithEvents colThanhTien As DataGridViewTextBoxColumn
    Friend WithEvents txtTimCT As TextBox
    Friend WithEvents Label15 As Label
End Class
