﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManager
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMaNV = New System.Windows.Forms.Label()
        Me.lblHoTen = New System.Windows.Forms.Label()
        Me.lblThoiGianBD = New System.Windows.Forms.Label()
        Me.btnThemNV = New System.Windows.Forms.Button()
        Me.btnSuaNV = New System.Windows.Forms.Button()
        Me.btnXoaNV = New System.Windows.Forms.Button()
        Me.TbCtrQuanLy = New System.Windows.Forms.TabControl()
        Me.NhanVien = New System.Windows.Forms.TabPage()
        Me.txtTimKiem_NhanVien = New System.Windows.Forms.TextBox()
        Me.btnTimKiemNV = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoDangLam = New System.Windows.Forms.RadioButton()
        Me.rdoDaNghi = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoNu = New System.Windows.Forms.RadioButton()
        Me.rdoNam = New System.Windows.Forms.RadioButton()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.dtpThoiGianBD = New System.Windows.Forms.DateTimePicker()
        Me.cboTenChucVu = New System.Windows.Forms.ComboBox()
        Me.cboLoaiNV = New System.Windows.Forms.ComboBox()
        Me.txtcmnd = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.lblNgaySinh = New System.Windows.Forms.Label()
        Me.lblTenChucVu = New System.Windows.Forms.Label()
        Me.lblLoaiNV = New System.Windows.Forms.Label()
        Me.lblCMND = New System.Windows.Forms.Label()
        Me.dgvNhanVien = New System.Windows.Forms.DataGridView()
        Me.MaNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThoiGianBatDau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiNhanVien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenChucVu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaChucVu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoaDon = New System.Windows.Forms.TabPage()
        Me.gbxChiTietHoaDon = New System.Windows.Forms.GroupBox()
        Me.dgvCTHoaDon = New System.Windows.Forms.DataGridView()
        Me.MaHoaDon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMon_CTHD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaMotMon_CTHD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaChiTiet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu_CTHD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien_CTHD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaMon_CTHD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiem_CTHD = New System.Windows.Forms.TextBox()
        Me.txtGhiChuCTHoaDon = New System.Windows.Forms.TextBox()
        Me.txtGiaMotMon_CTHD = New System.Windows.Forms.TextBox()
        Me.txtSoLuong_CTHD = New System.Windows.Forms.TextBox()
        Me.btnTimKiem_CTHD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaHoaDon_CTHD = New System.Windows.Forms.TextBox()
        Me.txtTongTien_CTHD = New System.Windows.Forms.TextBox()
        Me.txtTenMon_CTHD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnXoa_CTHD = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbxHoaDon = New System.Windows.Forms.GroupBox()
        Me.cboDaThanhToan_HoaDon = New System.Windows.Forms.ComboBox()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.MaHoaDon_HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNV_HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhanVien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThoiGian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongKhach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaHoaDonChung_HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaThanhToan_HD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiem_HoaDon = New System.Windows.Forms.TextBox()
        Me.lblTenNhanVien = New System.Windows.Forms.Label()
        Me.btnTimKiem_HoaDon = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblMaDatMon = New System.Windows.Forms.Label()
        Me.txtTongTien_HoaDon = New System.Windows.Forms.TextBox()
        Me.lblSoBan = New System.Windows.Forms.Label()
        Me.btnXoa_HoaDon = New System.Windows.Forms.Button()
        Me.lblGhiChu = New System.Windows.Forms.Label()
        Me.lblTongTien = New System.Windows.Forms.Label()
        Me.txtTenNV_HoaDon = New System.Windows.Forms.TextBox()
        Me.txtMaHoaDonChung_HoaDon = New System.Windows.Forms.TextBox()
        Me.txtSoLuongKhach_HoaDon = New System.Windows.Forms.TextBox()
        Me.dtpThoiGian_HoaDon = New System.Windows.Forms.DateTimePicker()
        Me.lblThoiGian = New System.Windows.Forms.Label()
        Me.lblSoLuongKhach = New System.Windows.Forms.Label()
        Me.txtGhiChu_HoaDon = New System.Windows.Forms.TextBox()
        Me.txtMaHoaDon_HoaDon = New System.Windows.Forms.TextBox()
        Me.txtSoBan_HoaDon = New System.Windows.Forms.TextBox()
        Me.MonAnDoUong = New System.Windows.Forms.TabPage()
        Me.gbxThongTinChiTietMon = New System.Windows.Forms.GroupBox()
        Me.cboDonVi_CTMon = New System.Windows.Forms.ComboBox()
        Me.dgvCTMon = New System.Windows.Forms.DataGridView()
        Me.MaMon_CTM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMon_CTMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSP_CTM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSP_CTMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong_CTMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonVi_CTMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaDonVi_MKHT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiem_CTMon = New System.Windows.Forms.TextBox()
        Me.btnTim_CTMon = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnXoa_CTMon = New System.Windows.Forms.Button()
        Me.btnSua_CTMon = New System.Windows.Forms.Button()
        Me.btnThem_CTMon = New System.Windows.Forms.Button()
        Me.txtSoLuong_CTMon = New System.Windows.Forms.TextBox()
        Me.txtTenMon_CTMon = New System.Windows.Forms.TextBox()
        Me.txtTenSP_CTMon = New System.Windows.Forms.TextBox()
        Me.gbxThongTinChiTietHoaDon = New System.Windows.Forms.GroupBox()
        Me.cboLoai_MADU = New System.Windows.Forms.ComboBox()
        Me.cboThucDonMon_Mon = New System.Windows.Forms.ComboBox()
        Me.dgvMonAnDoUong = New System.Windows.Forms.DataGridView()
        Me.MaMon_MADU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaTienHienTai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThucDonMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Loai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiem_Mon = New System.Windows.Forms.TextBox()
        Me.btnTimKiem_Mon = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnXoa_Mon = New System.Windows.Forms.Button()
        Me.btnSua_Mon = New System.Windows.Forms.Button()
        Me.btnThem_Mon = New System.Windows.Forms.Button()
        Me.txtTenMon_Mon = New System.Windows.Forms.TextBox()
        Me.txtGiaHienTai_Mon = New System.Windows.Forms.TextBox()
        Me.PhieuNhap = New System.Windows.Forms.TabPage()
        Me.gpbChiTietPhieuNhap = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnSua_CTPN = New System.Windows.Forms.Button()
        Me.btnXoa_CTPN = New System.Windows.Forms.Button()
        Me.btnThem_CTPN = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtThanhTIen_CTPN = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDonGia_CTPN = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSoLuong_CTPN = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTenSP_CTPN = New System.Windows.Forms.TextBox()
        Me.txtMaPN_CTPN = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.MaPN_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNCC_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNCC_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNV_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNV_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayLap_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayGiaoDK_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinhTrang_PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTimKiem_PhieuNhap = New System.Windows.Forms.Button()
        Me.txtTimKiem_PhieuNhap = New System.Windows.Forms.TextBox()
        Me.gpbDanhSachCTPN = New System.Windows.Forms.GroupBox()
        Me.dgvChiTietPhieuNhap = New System.Windows.Forms.DataGridView()
        Me.MaPN_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSP_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSP_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaDV_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDV_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThanhTien_CTPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTim_CTPN = New System.Windows.Forms.Button()
        Me.txtTim_CTPN = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnThongKe_PhieuNhap = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpNgayGiaoDK = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.btnThem_PhieuNhap = New System.Windows.Forms.Button()
        Me.btnXoa_PhieuNhap = New System.Windows.Forms.Button()
        Me.btnSua_PhieuNhap = New System.Windows.Forms.Button()
        Me.cboTinhTrang_PhieuNhap = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtTenNV_PN = New System.Windows.Forms.TextBox()
        Me.txtTenNCC_PN = New System.Windows.Forms.TextBox()
        Me.txtTongTien_PhieuNhap = New System.Windows.Forms.TextBox()
        Me.ChucVu_LoaiDonViTinh = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dgvChucVu = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnXoa_ChucVu = New System.Windows.Forms.Button()
        Me.btnSua_ChucVu = New System.Windows.Forms.Button()
        Me.btnThem_ChucVu = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dgvChucVuNV = New System.Windows.Forms.DataGridView()
        Me.MaDV_LDVT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDV_LDVT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoTangMacDinh_LDVT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnSua_LoaiDV = New System.Windows.Forms.Button()
        Me.btnXoa_LoaiDV = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnThem_LoaiDV = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboDonVi_CTPN = New System.Windows.Forms.ComboBox()
        Me.TbCtrQuanLy.SuspendLayout()
        Me.NhanVien.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HoaDon.SuspendLayout()
        Me.gbxChiTietHoaDon.SuspendLayout()
        CType(Me.dgvCTHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxHoaDon.SuspendLayout()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MonAnDoUong.SuspendLayout()
        Me.gbxThongTinChiTietMon.SuspendLayout()
        CType(Me.dgvCTMon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxThongTinChiTietHoaDon.SuspendLayout()
        CType(Me.dgvMonAnDoUong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhieuNhap.SuspendLayout()
        Me.gpbChiTietPhieuNhap.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDanhSachCTPN.SuspendLayout()
        CType(Me.dgvChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.ChucVu_LoaiDonViTinh.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvChucVu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgvChucVuNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(589, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ"
        '
        'lblMaNV
        '
        Me.lblMaNV.AutoSize = True
        Me.lblMaNV.Location = New System.Drawing.Point(21, 29)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.Size = New System.Drawing.Size(41, 15)
        Me.lblMaNV.TabIndex = 1
        Me.lblMaNV.Text = "MaNV"
        '
        'lblHoTen
        '
        Me.lblHoTen.AutoSize = True
        Me.lblHoTen.Location = New System.Drawing.Point(21, 65)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(46, 15)
        Me.lblHoTen.TabIndex = 1
        Me.lblHoTen.Text = "Họ Tên"
        '
        'lblThoiGianBD
        '
        Me.lblThoiGianBD.AutoSize = True
        Me.lblThoiGianBD.Location = New System.Drawing.Point(363, 130)
        Me.lblThoiGianBD.Name = "lblThoiGianBD"
        Me.lblThoiGianBD.Size = New System.Drawing.Size(105, 15)
        Me.lblThoiGianBD.TabIndex = 1
        Me.lblThoiGianBD.Text = "Thời Gian Bắt Đầu"
        '
        'btnThemNV
        '
        Me.btnThemNV.Location = New System.Drawing.Point(894, 50)
        Me.btnThemNV.Name = "btnThemNV"
        Me.btnThemNV.Size = New System.Drawing.Size(114, 52)
        Me.btnThemNV.TabIndex = 0
        Me.btnThemNV.Text = "Thêm"
        Me.btnThemNV.UseVisualStyleBackColor = True
        '
        'btnSuaNV
        '
        Me.btnSuaNV.Location = New System.Drawing.Point(1039, 48)
        Me.btnSuaNV.Name = "btnSuaNV"
        Me.btnSuaNV.Size = New System.Drawing.Size(114, 52)
        Me.btnSuaNV.TabIndex = 1
        Me.btnSuaNV.Text = "Sửa"
        Me.btnSuaNV.UseVisualStyleBackColor = True
        '
        'btnXoaNV
        '
        Me.btnXoaNV.Location = New System.Drawing.Point(1186, 48)
        Me.btnXoaNV.Name = "btnXoaNV"
        Me.btnXoaNV.Size = New System.Drawing.Size(114, 52)
        Me.btnXoaNV.TabIndex = 2
        Me.btnXoaNV.Text = "Xóa"
        Me.btnXoaNV.UseVisualStyleBackColor = True
        '
        'TbCtrQuanLy
        '
        Me.TbCtrQuanLy.Controls.Add(Me.NhanVien)
        Me.TbCtrQuanLy.Controls.Add(Me.HoaDon)
        Me.TbCtrQuanLy.Controls.Add(Me.MonAnDoUong)
        Me.TbCtrQuanLy.Controls.Add(Me.PhieuNhap)
        Me.TbCtrQuanLy.Controls.Add(Me.ChucVu_LoaiDonViTinh)
        Me.TbCtrQuanLy.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCtrQuanLy.Location = New System.Drawing.Point(10, 59)
        Me.TbCtrQuanLy.Name = "TbCtrQuanLy"
        Me.TbCtrQuanLy.SelectedIndex = 0
        Me.TbCtrQuanLy.Size = New System.Drawing.Size(1348, 654)
        Me.TbCtrQuanLy.TabIndex = 0
        '
        'NhanVien
        '
        Me.NhanVien.Controls.Add(Me.txtTimKiem_NhanVien)
        Me.NhanVien.Controls.Add(Me.btnTimKiemNV)
        Me.NhanVien.Controls.Add(Me.GroupBox1)
        Me.NhanVien.Controls.Add(Me.dgvNhanVien)
        Me.NhanVien.Controls.Add(Me.btnXoaNV)
        Me.NhanVien.Controls.Add(Me.btnSuaNV)
        Me.NhanVien.Controls.Add(Me.btnThemNV)
        Me.NhanVien.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NhanVien.Location = New System.Drawing.Point(4, 24)
        Me.NhanVien.Name = "NhanVien"
        Me.NhanVien.Padding = New System.Windows.Forms.Padding(3)
        Me.NhanVien.Size = New System.Drawing.Size(1340, 626)
        Me.NhanVien.TabIndex = 0
        Me.NhanVien.Text = "Nhân Viên"
        Me.NhanVien.UseVisualStyleBackColor = True
        '
        'txtTimKiem_NhanVien
        '
        Me.txtTimKiem_NhanVien.Location = New System.Drawing.Point(1052, 154)
        Me.txtTimKiem_NhanVien.Name = "txtTimKiem_NhanVien"
        Me.txtTimKiem_NhanVien.Size = New System.Drawing.Size(220, 22)
        Me.txtTimKiem_NhanVien.TabIndex = 4
        Me.txtTimKiem_NhanVien.Text = "Nhập thông tin cần tìm vào đây"
        '
        'btnTimKiemNV
        '
        Me.btnTimKiemNV.Location = New System.Drawing.Point(913, 144)
        Me.btnTimKiemNV.Name = "btnTimKiemNV"
        Me.btnTimKiemNV.Size = New System.Drawing.Size(121, 38)
        Me.btnTimKiemNV.TabIndex = 3
        Me.btnTimKiemNV.Text = "Tìm Kiếm"
        Me.btnTimKiemNV.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpNgaySinh)
        Me.GroupBox1.Controls.Add(Me.dtpThoiGianBD)
        Me.GroupBox1.Controls.Add(Me.cboTenChucVu)
        Me.GroupBox1.Controls.Add(Me.cboLoaiNV)
        Me.GroupBox1.Controls.Add(Me.txtcmnd)
        Me.GroupBox1.Controls.Add(Me.txtMaNV)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Controls.Add(Me.lblMaNV)
        Me.GroupBox1.Controls.Add(Me.lblNgaySinh)
        Me.GroupBox1.Controls.Add(Me.lblTenChucVu)
        Me.GroupBox1.Controls.Add(Me.lblLoaiNV)
        Me.GroupBox1.Controls.Add(Me.lblHoTen)
        Me.GroupBox1.Controls.Add(Me.lblCMND)
        Me.GroupBox1.Controls.Add(Me.lblThoiGianBD)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 174)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Nhân Viên"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoDangLam)
        Me.GroupBox3.Controls.Add(Me.rdoDaNghi)
        Me.GroupBox3.Location = New System.Drawing.Point(610, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 47)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tình Trạng"
        '
        'rdoDangLam
        '
        Me.rdoDangLam.AutoSize = True
        Me.rdoDangLam.Location = New System.Drawing.Point(98, 20)
        Me.rdoDangLam.Name = "rdoDangLam"
        Me.rdoDangLam.Size = New System.Drawing.Size(81, 19)
        Me.rdoDangLam.TabIndex = 1
        Me.rdoDangLam.Text = "Đang Làm"
        Me.rdoDangLam.UseVisualStyleBackColor = True
        '
        'rdoDaNghi
        '
        Me.rdoDaNghi.AutoSize = True
        Me.rdoDaNghi.Checked = True
        Me.rdoDaNghi.Location = New System.Drawing.Point(13, 20)
        Me.rdoDaNghi.Name = "rdoDaNghi"
        Me.rdoDaNghi.Size = New System.Drawing.Size(69, 19)
        Me.rdoDaNghi.TabIndex = 0
        Me.rdoDaNghi.TabStop = True
        Me.rdoDaNghi.Text = "Đã Nghỉ"
        Me.rdoDaNghi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoNu)
        Me.GroupBox2.Controls.Add(Me.rdoNam)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 47)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Giới Tính"
        '
        'rdoNu
        '
        Me.rdoNu.AutoSize = True
        Me.rdoNu.Location = New System.Drawing.Point(98, 20)
        Me.rdoNu.Name = "rdoNu"
        Me.rdoNu.Size = New System.Drawing.Size(41, 19)
        Me.rdoNu.TabIndex = 1
        Me.rdoNu.Text = "Nữ"
        Me.rdoNu.UseVisualStyleBackColor = True
        '
        'rdoNam
        '
        Me.rdoNam.AutoSize = True
        Me.rdoNam.Checked = True
        Me.rdoNam.Location = New System.Drawing.Point(13, 20)
        Me.rdoNam.Name = "rdoNam"
        Me.rdoNam.Size = New System.Drawing.Size(52, 19)
        Me.rdoNam.TabIndex = 0
        Me.rdoNam.TabStop = True
        Me.rdoNam.Text = "Nam"
        Me.rdoNam.UseVisualStyleBackColor = True
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(102, 132)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(220, 22)
        Me.dtpNgaySinh.TabIndex = 3
        '
        'dtpThoiGianBD
        '
        Me.dtpThoiGianBD.CustomFormat = "dd/MM/yyyy"
        Me.dtpThoiGianBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThoiGianBD.Location = New System.Drawing.Point(498, 124)
        Me.dtpThoiGianBD.Name = "dtpThoiGianBD"
        Me.dtpThoiGianBD.Size = New System.Drawing.Size(220, 22)
        Me.dtpThoiGianBD.TabIndex = 6
        '
        'cboTenChucVu
        '
        Me.cboTenChucVu.FormattingEnabled = True
        Me.cboTenChucVu.Location = New System.Drawing.Point(679, 91)
        Me.cboTenChucVu.Name = "cboTenChucVu"
        Me.cboTenChucVu.Size = New System.Drawing.Size(126, 23)
        Me.cboTenChucVu.TabIndex = 5
        '
        'cboLoaiNV
        '
        Me.cboLoaiNV.FormattingEnabled = True
        Me.cboLoaiNV.Location = New System.Drawing.Point(429, 91)
        Me.cboLoaiNV.Name = "cboLoaiNV"
        Me.cboLoaiNV.Size = New System.Drawing.Size(126, 23)
        Me.cboLoaiNV.TabIndex = 4
        '
        'txtcmnd
        '
        Me.txtcmnd.Location = New System.Drawing.Point(102, 94)
        Me.txtcmnd.Name = "txtcmnd"
        Me.txtcmnd.Size = New System.Drawing.Size(220, 22)
        Me.txtcmnd.TabIndex = 2
        '
        'txtMaNV
        '
        Me.txtMaNV.Enabled = False
        Me.txtMaNV.Location = New System.Drawing.Point(102, 26)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(220, 22)
        Me.txtMaNV.TabIndex = 0
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(102, 60)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(220, 22)
        Me.txtTen.TabIndex = 1
        '
        'lblNgaySinh
        '
        Me.lblNgaySinh.AutoSize = True
        Me.lblNgaySinh.Location = New System.Drawing.Point(23, 137)
        Me.lblNgaySinh.Name = "lblNgaySinh"
        Me.lblNgaySinh.Size = New System.Drawing.Size(63, 15)
        Me.lblNgaySinh.TabIndex = 1
        Me.lblNgaySinh.Text = "Ngày Sinh"
        '
        'lblTenChucVu
        '
        Me.lblTenChucVu.AutoSize = True
        Me.lblTenChucVu.Location = New System.Drawing.Point(581, 94)
        Me.lblTenChucVu.Name = "lblTenChucVu"
        Me.lblTenChucVu.Size = New System.Drawing.Size(76, 15)
        Me.lblTenChucVu.TabIndex = 1
        Me.lblTenChucVu.Text = "Tên Chức Vụ"
        '
        'lblLoaiNV
        '
        Me.lblLoaiNV.AutoSize = True
        Me.lblLoaiNV.Location = New System.Drawing.Point(363, 94)
        Me.lblLoaiNV.Name = "lblLoaiNV"
        Me.lblLoaiNV.Size = New System.Drawing.Size(50, 15)
        Me.lblLoaiNV.TabIndex = 1
        Me.lblLoaiNV.Text = "Loại NV"
        '
        'lblCMND
        '
        Me.lblCMND.AutoSize = True
        Me.lblCMND.Location = New System.Drawing.Point(21, 99)
        Me.lblCMND.Name = "lblCMND"
        Me.lblCMND.Size = New System.Drawing.Size(42, 15)
        Me.lblCMND.TabIndex = 1
        Me.lblCMND.Text = "CMND"
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhanVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNV, Me.HoTen, Me.ThoiGianBatDau, Me.CMND, Me.TinhTrang, Me.NgaySinh, Me.GioiTinh, Me.LoaiNhanVien, Me.TenChucVu, Me.MaChucVu})
        Me.dgvNhanVien.Location = New System.Drawing.Point(46, 202)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.RowTemplate.Height = 24
        Me.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNhanVien.Size = New System.Drawing.Size(1245, 418)
        Me.dgvNhanVien.TabIndex = 5
        '
        'MaNV
        '
        Me.MaNV.DataPropertyName = "MaNV"
        Me.MaNV.HeaderText = "MaNV"
        Me.MaNV.Name = "MaNV"
        Me.MaNV.ReadOnly = True
        Me.MaNV.Visible = False
        '
        'HoTen
        '
        Me.HoTen.DataPropertyName = "HoTen"
        Me.HoTen.HeaderText = "Họ Tên"
        Me.HoTen.Name = "HoTen"
        Me.HoTen.ReadOnly = True
        Me.HoTen.Width = 220
        '
        'ThoiGianBatDau
        '
        Me.ThoiGianBatDau.DataPropertyName = "TGBatDau"
        Me.ThoiGianBatDau.HeaderText = "Thời Gian Bắt Đầu"
        Me.ThoiGianBatDau.Name = "ThoiGianBatDau"
        Me.ThoiGianBatDau.ReadOnly = True
        Me.ThoiGianBatDau.Width = 200
        '
        'CMND
        '
        Me.CMND.DataPropertyName = "CMND"
        Me.CMND.HeaderText = "CMND"
        Me.CMND.Name = "CMND"
        Me.CMND.ReadOnly = True
        Me.CMND.Width = 150
        '
        'TinhTrang
        '
        Me.TinhTrang.DataPropertyName = "TinhTrang"
        Me.TinhTrang.HeaderText = "Tình Trạng"
        Me.TinhTrang.Name = "TinhTrang"
        Me.TinhTrang.ReadOnly = True
        Me.TinhTrang.Width = 120
        '
        'NgaySinh
        '
        Me.NgaySinh.DataPropertyName = "NgaySinh"
        Me.NgaySinh.HeaderText = "Ngày Sinh"
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.ReadOnly = True
        Me.NgaySinh.Width = 150
        '
        'GioiTinh
        '
        Me.GioiTinh.DataPropertyName = "GioiTinh"
        Me.GioiTinh.HeaderText = "Giới Tính"
        Me.GioiTinh.Name = "GioiTinh"
        Me.GioiTinh.ReadOnly = True
        '
        'LoaiNhanVien
        '
        Me.LoaiNhanVien.DataPropertyName = "LoaiNhanVien"
        Me.LoaiNhanVien.HeaderText = "Loại Nhân Viên"
        Me.LoaiNhanVien.Name = "LoaiNhanVien"
        Me.LoaiNhanVien.ReadOnly = True
        '
        'TenChucVu
        '
        Me.TenChucVu.DataPropertyName = "TenChucVu"
        Me.TenChucVu.HeaderText = "Tên Chức Vụ"
        Me.TenChucVu.Name = "TenChucVu"
        Me.TenChucVu.ReadOnly = True
        Me.TenChucVu.Width = 145
        '
        'MaChucVu
        '
        Me.MaChucVu.DataPropertyName = "MaChucVu"
        Me.MaChucVu.HeaderText = "Mã Chức Vụ"
        Me.MaChucVu.Name = "MaChucVu"
        Me.MaChucVu.ReadOnly = True
        Me.MaChucVu.Visible = False
        '
        'HoaDon
        '
        Me.HoaDon.Controls.Add(Me.gbxChiTietHoaDon)
        Me.HoaDon.Controls.Add(Me.gbxHoaDon)
        Me.HoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoaDon.Location = New System.Drawing.Point(4, 24)
        Me.HoaDon.Name = "HoaDon"
        Me.HoaDon.Padding = New System.Windows.Forms.Padding(3)
        Me.HoaDon.Size = New System.Drawing.Size(1340, 626)
        Me.HoaDon.TabIndex = 1
        Me.HoaDon.Text = "Hóa Đơn"
        Me.HoaDon.UseVisualStyleBackColor = True
        '
        'gbxChiTietHoaDon
        '
        Me.gbxChiTietHoaDon.Controls.Add(Me.dgvCTHoaDon)
        Me.gbxChiTietHoaDon.Controls.Add(Me.txtTimKiem_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.txtGhiChuCTHoaDon)
        Me.gbxChiTietHoaDon.Controls.Add(Me.txtGiaMotMon_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.txtSoLuong_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.btnTimKiem_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.Label2)
        Me.gbxChiTietHoaDon.Controls.Add(Me.Label6)
        Me.gbxChiTietHoaDon.Controls.Add(Me.MaHoaDon_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.txtTongTien_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.txtTenMon_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.Label4)
        Me.gbxChiTietHoaDon.Controls.Add(Me.Label3)
        Me.gbxChiTietHoaDon.Controls.Add(Me.Label8)
        Me.gbxChiTietHoaDon.Controls.Add(Me.btnXoa_CTHD)
        Me.gbxChiTietHoaDon.Controls.Add(Me.Label5)
        Me.gbxChiTietHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxChiTietHoaDon.Location = New System.Drawing.Point(6, 339)
        Me.gbxChiTietHoaDon.Name = "gbxChiTietHoaDon"
        Me.gbxChiTietHoaDon.Size = New System.Drawing.Size(1328, 269)
        Me.gbxChiTietHoaDon.TabIndex = 6
        Me.gbxChiTietHoaDon.TabStop = False
        Me.gbxChiTietHoaDon.Text = "Thông Tin Chi Tiết Hóa Đơn"
        '
        'dgvCTHoaDon
        '
        Me.dgvCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCTHoaDon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaHoaDon, Me.TenMon_CTHD, Me.GiaMotMon_CTHD, Me.MaChiTiet, Me.GhiChu_CTHD, Me.SoLuong, Me.TongTien_CTHD, Me.MaMon_CTHD})
        Me.dgvCTHoaDon.Location = New System.Drawing.Point(395, 55)
        Me.dgvCTHoaDon.Name = "dgvCTHoaDon"
        Me.dgvCTHoaDon.RowTemplate.Height = 24
        Me.dgvCTHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCTHoaDon.Size = New System.Drawing.Size(867, 198)
        Me.dgvCTHoaDon.TabIndex = 10
        '
        'MaHoaDon
        '
        Me.MaHoaDon.DataPropertyName = "MaHoaDon"
        Me.MaHoaDon.HeaderText = "Mã Hóa Đơn"
        Me.MaHoaDon.Name = "MaHoaDon"
        Me.MaHoaDon.ReadOnly = True
        Me.MaHoaDon.Visible = False
        Me.MaHoaDon.Width = 120
        '
        'TenMon_CTHD
        '
        Me.TenMon_CTHD.DataPropertyName = "TenMon"
        Me.TenMon_CTHD.HeaderText = "Tên Món"
        Me.TenMon_CTHD.Name = "TenMon_CTHD"
        Me.TenMon_CTHD.ReadOnly = True
        Me.TenMon_CTHD.Width = 200
        '
        'GiaMotMon_CTHD
        '
        Me.GiaMotMon_CTHD.DataPropertyName = "GiaMotMon"
        Me.GiaMotMon_CTHD.HeaderText = "Giá Một Món"
        Me.GiaMotMon_CTHD.Name = "GiaMotMon_CTHD"
        Me.GiaMotMon_CTHD.ReadOnly = True
        Me.GiaMotMon_CTHD.Width = 140
        '
        'MaChiTiet
        '
        Me.MaChiTiet.DataPropertyName = "MaCT"
        Me.MaChiTiet.HeaderText = "Mã Chi Tiết"
        Me.MaChiTiet.Name = "MaChiTiet"
        Me.MaChiTiet.ReadOnly = True
        Me.MaChiTiet.Visible = False
        '
        'GhiChu_CTHD
        '
        Me.GhiChu_CTHD.DataPropertyName = "GhiChu"
        Me.GhiChu_CTHD.HeaderText = "Ghi Chú"
        Me.GhiChu_CTHD.Name = "GhiChu_CTHD"
        Me.GhiChu_CTHD.ReadOnly = True
        Me.GhiChu_CTHD.Width = 198
        '
        'SoLuong
        '
        Me.SoLuong.DataPropertyName = "SoLuong"
        Me.SoLuong.HeaderText = "Số Lượng"
        Me.SoLuong.Name = "SoLuong"
        Me.SoLuong.ReadOnly = True
        Me.SoLuong.Width = 120
        '
        'TongTien_CTHD
        '
        Me.TongTien_CTHD.DataPropertyName = "ThanhTien"
        Me.TongTien_CTHD.HeaderText = "Tổng Tiền"
        Me.TongTien_CTHD.Name = "TongTien_CTHD"
        Me.TongTien_CTHD.ReadOnly = True
        Me.TongTien_CTHD.Width = 166
        '
        'MaMon_CTHD
        '
        Me.MaMon_CTHD.DataPropertyName = "MaMon"
        Me.MaMon_CTHD.HeaderText = "Mã Món"
        Me.MaMon_CTHD.Name = "MaMon_CTHD"
        Me.MaMon_CTHD.ReadOnly = True
        Me.MaMon_CTHD.Visible = False
        '
        'txtTimKiem_CTHD
        '
        Me.txtTimKiem_CTHD.Location = New System.Drawing.Point(596, 20)
        Me.txtTimKiem_CTHD.Name = "txtTimKiem_CTHD"
        Me.txtTimKiem_CTHD.Size = New System.Drawing.Size(189, 21)
        Me.txtTimKiem_CTHD.TabIndex = 8
        Me.txtTimKiem_CTHD.Text = "Nhập thông tin cần tìm vào đây"
        '
        'txtGhiChuCTHoaDon
        '
        Me.txtGhiChuCTHoaDon.Location = New System.Drawing.Point(118, 185)
        Me.txtGhiChuCTHoaDon.Name = "txtGhiChuCTHoaDon"
        Me.txtGhiChuCTHoaDon.Size = New System.Drawing.Size(174, 21)
        Me.txtGhiChuCTHoaDon.TabIndex = 4
        '
        'txtGiaMotMon_CTHD
        '
        Me.txtGiaMotMon_CTHD.Location = New System.Drawing.Point(118, 152)
        Me.txtGiaMotMon_CTHD.Name = "txtGiaMotMon_CTHD"
        Me.txtGiaMotMon_CTHD.Size = New System.Drawing.Size(174, 21)
        Me.txtGiaMotMon_CTHD.TabIndex = 3
        '
        'txtSoLuong_CTHD
        '
        Me.txtSoLuong_CTHD.Location = New System.Drawing.Point(118, 124)
        Me.txtSoLuong_CTHD.Name = "txtSoLuong_CTHD"
        Me.txtSoLuong_CTHD.Size = New System.Drawing.Size(174, 21)
        Me.txtSoLuong_CTHD.TabIndex = 2
        '
        'btnTimKiem_CTHD
        '
        Me.btnTimKiem_CTHD.Location = New System.Drawing.Point(456, 14)
        Me.btnTimKiem_CTHD.Name = "btnTimKiem_CTHD"
        Me.btnTimKiem_CTHD.Size = New System.Drawing.Size(122, 35)
        Me.btnTimKiem_CTHD.TabIndex = 7
        Me.btnTimKiem_CTHD.Text = "Tìm Kiếm"
        Me.btnTimKiem_CTHD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Hóa Đơn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tên Món"
        '
        'MaHoaDon_CTHD
        '
        Me.MaHoaDon_CTHD.Enabled = False
        Me.MaHoaDon_CTHD.Location = New System.Drawing.Point(118, 61)
        Me.MaHoaDon_CTHD.Name = "MaHoaDon_CTHD"
        Me.MaHoaDon_CTHD.Size = New System.Drawing.Size(112, 21)
        Me.MaHoaDon_CTHD.TabIndex = 0
        '
        'txtTongTien_CTHD
        '
        Me.txtTongTien_CTHD.Location = New System.Drawing.Point(163, 223)
        Me.txtTongTien_CTHD.Name = "txtTongTien_CTHD"
        Me.txtTongTien_CTHD.Size = New System.Drawing.Size(144, 21)
        Me.txtTongTien_CTHD.TabIndex = 6
        '
        'txtTenMon_CTHD
        '
        Me.txtTenMon_CTHD.Location = New System.Drawing.Point(118, 94)
        Me.txtTenMon_CTHD.Name = "txtTenMon_CTHD"
        Me.txtTenMon_CTHD.Size = New System.Drawing.Size(174, 21)
        Me.txtTenMon_CTHD.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tổng Tiền"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Giá Một Món"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ghi Chú"
        '
        'btnXoa_CTHD
        '
        Me.btnXoa_CTHD.Location = New System.Drawing.Point(830, 14)
        Me.btnXoa_CTHD.Name = "btnXoa_CTHD"
        Me.btnXoa_CTHD.Size = New System.Drawing.Size(109, 35)
        Me.btnXoa_CTHD.TabIndex = 9
        Me.btnXoa_CTHD.Text = "Xóa"
        Me.btnXoa_CTHD.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Số Lượng"
        '
        'gbxHoaDon
        '
        Me.gbxHoaDon.Controls.Add(Me.cboDaThanhToan_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.dgvHoaDon)
        Me.gbxHoaDon.Controls.Add(Me.txtTimKiem_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.lblTenNhanVien)
        Me.gbxHoaDon.Controls.Add(Me.btnTimKiem_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.Label7)
        Me.gbxHoaDon.Controls.Add(Me.Label17)
        Me.gbxHoaDon.Controls.Add(Me.lblMaDatMon)
        Me.gbxHoaDon.Controls.Add(Me.txtTongTien_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.lblSoBan)
        Me.gbxHoaDon.Controls.Add(Me.btnXoa_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.lblGhiChu)
        Me.gbxHoaDon.Controls.Add(Me.lblTongTien)
        Me.gbxHoaDon.Controls.Add(Me.txtTenNV_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.txtMaHoaDonChung_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.txtSoLuongKhach_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.dtpThoiGian_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.lblThoiGian)
        Me.gbxHoaDon.Controls.Add(Me.lblSoLuongKhach)
        Me.gbxHoaDon.Controls.Add(Me.txtGhiChu_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.txtMaHoaDon_HoaDon)
        Me.gbxHoaDon.Controls.Add(Me.txtSoBan_HoaDon)
        Me.gbxHoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxHoaDon.Location = New System.Drawing.Point(6, 6)
        Me.gbxHoaDon.Name = "gbxHoaDon"
        Me.gbxHoaDon.Size = New System.Drawing.Size(1328, 316)
        Me.gbxHoaDon.TabIndex = 5
        Me.gbxHoaDon.TabStop = False
        Me.gbxHoaDon.Text = "Thông Tin Hoá Đơn"
        '
        'cboDaThanhToan_HoaDon
        '
        Me.cboDaThanhToan_HoaDon.FormattingEnabled = True
        Me.cboDaThanhToan_HoaDon.Location = New System.Drawing.Point(146, 148)
        Me.cboDaThanhToan_HoaDon.Name = "cboDaThanhToan_HoaDon"
        Me.cboDaThanhToan_HoaDon.Size = New System.Drawing.Size(112, 23)
        Me.cboDaThanhToan_HoaDon.TabIndex = 12
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaHoaDon_HD, Me.MaNV_HD, Me.TenNhanVien, Me.ThoiGian, Me.SoBan, Me.SoLuongKhach, Me.MaHoaDonChung_HD, Me.TongTien, Me.GhiChu, Me.DaThanhToan_HD})
        Me.dgvHoaDon.Location = New System.Drawing.Point(374, 58)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.RowTemplate.Height = 24
        Me.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHoaDon.Size = New System.Drawing.Size(888, 252)
        Me.dgvHoaDon.TabIndex = 11
        '
        'MaHoaDon_HD
        '
        Me.MaHoaDon_HD.DataPropertyName = "MaHoaDon"
        Me.MaHoaDon_HD.HeaderText = "Mã Hóa Đơn"
        Me.MaHoaDon_HD.Name = "MaHoaDon_HD"
        Me.MaHoaDon_HD.ReadOnly = True
        Me.MaHoaDon_HD.Visible = False
        '
        'MaNV_HD
        '
        Me.MaNV_HD.DataPropertyName = "MaNV"
        Me.MaNV_HD.HeaderText = "Mã Nhân Viên"
        Me.MaNV_HD.Name = "MaNV_HD"
        Me.MaNV_HD.ReadOnly = True
        Me.MaNV_HD.Visible = False
        '
        'TenNhanVien
        '
        Me.TenNhanVien.DataPropertyName = "HoTen"
        Me.TenNhanVien.HeaderText = "Tên Nhân Viên"
        Me.TenNhanVien.Name = "TenNhanVien"
        Me.TenNhanVien.ReadOnly = True
        '
        'ThoiGian
        '
        Me.ThoiGian.DataPropertyName = "ThoiGian"
        Me.ThoiGian.HeaderText = "Thời Gian"
        Me.ThoiGian.Name = "ThoiGian"
        Me.ThoiGian.ReadOnly = True
        Me.ThoiGian.Width = 120
        '
        'SoBan
        '
        Me.SoBan.DataPropertyName = "SoBan"
        Me.SoBan.HeaderText = "Số Bàn"
        Me.SoBan.Name = "SoBan"
        Me.SoBan.ReadOnly = True
        Me.SoBan.Width = 80
        '
        'SoLuongKhach
        '
        Me.SoLuongKhach.DataPropertyName = "SoLuongKhach"
        Me.SoLuongKhach.HeaderText = "Số Lượng Khách"
        Me.SoLuongKhach.Name = "SoLuongKhach"
        Me.SoLuongKhach.ReadOnly = True
        '
        'MaHoaDonChung_HD
        '
        Me.MaHoaDonChung_HD.DataPropertyName = "MaHDChung"
        Me.MaHoaDonChung_HD.HeaderText = "Mã Hóa Đơn Chung"
        Me.MaHoaDonChung_HD.Name = "MaHoaDonChung_HD"
        Me.MaHoaDonChung_HD.ReadOnly = True
        '
        'TongTien
        '
        Me.TongTien.DataPropertyName = "TongTien"
        Me.TongTien.HeaderText = "Tổng Tiền"
        Me.TongTien.Name = "TongTien"
        Me.TongTien.ReadOnly = True
        Me.TongTien.Width = 125
        '
        'GhiChu
        '
        Me.GhiChu.DataPropertyName = "GhiChu"
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        Me.GhiChu.Width = 120
        '
        'DaThanhToan_HD
        '
        Me.DaThanhToan_HD.DataPropertyName = "TinhTrang"
        Me.DaThanhToan_HD.HeaderText = "Đã Thanh Toán"
        Me.DaThanhToan_HD.Name = "DaThanhToan_HD"
        Me.DaThanhToan_HD.ReadOnly = True
        '
        'txtTimKiem_HoaDon
        '
        Me.txtTimKiem_HoaDon.Location = New System.Drawing.Point(596, 22)
        Me.txtTimKiem_HoaDon.Name = "txtTimKiem_HoaDon"
        Me.txtTimKiem_HoaDon.Size = New System.Drawing.Size(189, 21)
        Me.txtTimKiem_HoaDon.TabIndex = 9
        Me.txtTimKiem_HoaDon.Text = "Nhập thông tin cần tìm vào đây"
        '
        'lblTenNhanVien
        '
        Me.lblTenNhanVien.AutoSize = True
        Me.lblTenNhanVien.Location = New System.Drawing.Point(12, 180)
        Me.lblTenNhanVien.Name = "lblTenNhanVien"
        Me.lblTenNhanVien.Size = New System.Drawing.Size(88, 15)
        Me.lblTenNhanVien.TabIndex = 0
        Me.lblTenNhanVien.Text = "Tên Nhân Viên"
        '
        'btnTimKiem_HoaDon
        '
        Me.btnTimKiem_HoaDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem_HoaDon.Location = New System.Drawing.Point(456, 15)
        Me.btnTimKiem_HoaDon.Name = "btnTimKiem_HoaDon"
        Me.btnTimKiem_HoaDon.Size = New System.Drawing.Size(122, 38)
        Me.btnTimKiem_HoaDon.TabIndex = 8
        Me.btnTimKiem_HoaDon.Text = "Tìm Kiếm"
        Me.btnTimKiem_HoaDon.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Mã Hóa Đơn Chung"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Đã Thanh Toán"
        '
        'lblMaDatMon
        '
        Me.lblMaDatMon.AutoSize = True
        Me.lblMaDatMon.Location = New System.Drawing.Point(12, 35)
        Me.lblMaDatMon.Name = "lblMaDatMon"
        Me.lblMaDatMon.Size = New System.Drawing.Size(77, 15)
        Me.lblMaDatMon.TabIndex = 0
        Me.lblMaDatMon.Text = "Mã Hóa Đơn"
        '
        'txtTongTien_HoaDon
        '
        Me.txtTongTien_HoaDon.Location = New System.Drawing.Point(163, 277)
        Me.txtTongTien_HoaDon.Name = "txtTongTien_HoaDon"
        Me.txtTongTien_HoaDon.Size = New System.Drawing.Size(144, 21)
        Me.txtTongTien_HoaDon.TabIndex = 7
        '
        'lblSoBan
        '
        Me.lblSoBan.AutoSize = True
        Me.lblSoBan.Location = New System.Drawing.Point(12, 65)
        Me.lblSoBan.Name = "lblSoBan"
        Me.lblSoBan.Size = New System.Drawing.Size(47, 15)
        Me.lblSoBan.TabIndex = 0
        Me.lblSoBan.Text = "Số Bàn"
        '
        'btnXoa_HoaDon
        '
        Me.btnXoa_HoaDon.Location = New System.Drawing.Point(830, 14)
        Me.btnXoa_HoaDon.Name = "btnXoa_HoaDon"
        Me.btnXoa_HoaDon.Size = New System.Drawing.Size(109, 38)
        Me.btnXoa_HoaDon.TabIndex = 10
        Me.btnXoa_HoaDon.Text = "Xóa"
        Me.btnXoa_HoaDon.UseVisualStyleBackColor = True
        '
        'lblGhiChu
        '
        Me.lblGhiChu.AutoSize = True
        Me.lblGhiChu.Location = New System.Drawing.Point(12, 210)
        Me.lblGhiChu.Name = "lblGhiChu"
        Me.lblGhiChu.Size = New System.Drawing.Size(51, 15)
        Me.lblGhiChu.TabIndex = 0
        Me.lblGhiChu.Text = "Ghi Chú"
        '
        'lblTongTien
        '
        Me.lblTongTien.AutoSize = True
        Me.lblTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTongTien.Location = New System.Drawing.Point(30, 274)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(98, 24)
        Me.lblTongTien.TabIndex = 0
        Me.lblTongTien.Text = "Tổng Tiền"
        '
        'txtTenNV_HoaDon
        '
        Me.txtTenNV_HoaDon.Location = New System.Drawing.Point(118, 177)
        Me.txtTenNV_HoaDon.Name = "txtTenNV_HoaDon"
        Me.txtTenNV_HoaDon.Size = New System.Drawing.Size(174, 21)
        Me.txtTenNV_HoaDon.TabIndex = 4
        '
        'txtMaHoaDonChung_HoaDon
        '
        Me.txtMaHoaDonChung_HoaDon.Location = New System.Drawing.Point(146, 121)
        Me.txtMaHoaDonChung_HoaDon.Name = "txtMaHoaDonChung_HoaDon"
        Me.txtMaHoaDonChung_HoaDon.Size = New System.Drawing.Size(112, 21)
        Me.txtMaHoaDonChung_HoaDon.TabIndex = 3
        '
        'txtSoLuongKhach_HoaDon
        '
        Me.txtSoLuongKhach_HoaDon.Location = New System.Drawing.Point(146, 91)
        Me.txtSoLuongKhach_HoaDon.Name = "txtSoLuongKhach_HoaDon"
        Me.txtSoLuongKhach_HoaDon.Size = New System.Drawing.Size(112, 21)
        Me.txtSoLuongKhach_HoaDon.TabIndex = 2
        '
        'dtpThoiGian_HoaDon
        '
        Me.dtpThoiGian_HoaDon.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.dtpThoiGian_HoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpThoiGian_HoaDon.Location = New System.Drawing.Point(118, 237)
        Me.dtpThoiGian_HoaDon.Name = "dtpThoiGian_HoaDon"
        Me.dtpThoiGian_HoaDon.Size = New System.Drawing.Size(174, 21)
        Me.dtpThoiGian_HoaDon.TabIndex = 6
        '
        'lblThoiGian
        '
        Me.lblThoiGian.AutoSize = True
        Me.lblThoiGian.Location = New System.Drawing.Point(12, 242)
        Me.lblThoiGian.Name = "lblThoiGian"
        Me.lblThoiGian.Size = New System.Drawing.Size(60, 15)
        Me.lblThoiGian.TabIndex = 0
        Me.lblThoiGian.Text = "Thời Gian"
        '
        'lblSoLuongKhach
        '
        Me.lblSoLuongKhach.AutoSize = True
        Me.lblSoLuongKhach.Location = New System.Drawing.Point(12, 91)
        Me.lblSoLuongKhach.Name = "lblSoLuongKhach"
        Me.lblSoLuongKhach.Size = New System.Drawing.Size(98, 15)
        Me.lblSoLuongKhach.TabIndex = 0
        Me.lblSoLuongKhach.Text = "Số Lượng Khách"
        '
        'txtGhiChu_HoaDon
        '
        Me.txtGhiChu_HoaDon.Location = New System.Drawing.Point(118, 207)
        Me.txtGhiChu_HoaDon.Name = "txtGhiChu_HoaDon"
        Me.txtGhiChu_HoaDon.Size = New System.Drawing.Size(174, 21)
        Me.txtGhiChu_HoaDon.TabIndex = 5
        '
        'txtMaHoaDon_HoaDon
        '
        Me.txtMaHoaDon_HoaDon.Enabled = False
        Me.txtMaHoaDon_HoaDon.Location = New System.Drawing.Point(146, 32)
        Me.txtMaHoaDon_HoaDon.Name = "txtMaHoaDon_HoaDon"
        Me.txtMaHoaDon_HoaDon.Size = New System.Drawing.Size(112, 21)
        Me.txtMaHoaDon_HoaDon.TabIndex = 0
        '
        'txtSoBan_HoaDon
        '
        Me.txtSoBan_HoaDon.Location = New System.Drawing.Point(146, 62)
        Me.txtSoBan_HoaDon.Name = "txtSoBan_HoaDon"
        Me.txtSoBan_HoaDon.Size = New System.Drawing.Size(112, 21)
        Me.txtSoBan_HoaDon.TabIndex = 1
        '
        'MonAnDoUong
        '
        Me.MonAnDoUong.Controls.Add(Me.gbxThongTinChiTietMon)
        Me.MonAnDoUong.Controls.Add(Me.gbxThongTinChiTietHoaDon)
        Me.MonAnDoUong.Location = New System.Drawing.Point(4, 24)
        Me.MonAnDoUong.Name = "MonAnDoUong"
        Me.MonAnDoUong.Size = New System.Drawing.Size(1340, 626)
        Me.MonAnDoUong.TabIndex = 0
        Me.MonAnDoUong.Text = "Món Ăn Đồ Uống"
        Me.MonAnDoUong.UseVisualStyleBackColor = True
        '
        'gbxThongTinChiTietMon
        '
        Me.gbxThongTinChiTietMon.Controls.Add(Me.cboDonVi_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.dgvCTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.txtTimKiem_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.btnTim_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.Label16)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.Label10)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.Label14)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.Label15)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.btnXoa_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.btnSua_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.btnThem_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.txtSoLuong_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.txtTenMon_CTMon)
        Me.gbxThongTinChiTietMon.Controls.Add(Me.txtTenSP_CTMon)
        Me.gbxThongTinChiTietMon.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxThongTinChiTietMon.Location = New System.Drawing.Point(21, 321)
        Me.gbxThongTinChiTietMon.Name = "gbxThongTinChiTietMon"
        Me.gbxThongTinChiTietMon.Size = New System.Drawing.Size(1300, 289)
        Me.gbxThongTinChiTietMon.TabIndex = 6
        Me.gbxThongTinChiTietMon.TabStop = False
        Me.gbxThongTinChiTietMon.Text = "Thông Tin Chi Tiết Món"
        '
        'cboDonVi_CTMon
        '
        Me.cboDonVi_CTMon.FormattingEnabled = True
        Me.cboDonVi_CTMon.Location = New System.Drawing.Point(401, 163)
        Me.cboDonVi_CTMon.Name = "cboDonVi_CTMon"
        Me.cboDonVi_CTMon.Size = New System.Drawing.Size(126, 23)
        Me.cboDonVi_CTMon.TabIndex = 9
        '
        'dgvCTMon
        '
        Me.dgvCTMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCTMon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMon_CTM, Me.TenMon_CTMon, Me.MaSP_CTM, Me.TenSP_CTMon, Me.SoLuong_CTMon, Me.DonVi_CTMon, Me.MaDonVi_MKHT})
        Me.dgvCTMon.Location = New System.Drawing.Point(647, 41)
        Me.dgvCTMon.Name = "dgvCTMon"
        Me.dgvCTMon.RowTemplate.Height = 24
        Me.dgvCTMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCTMon.Size = New System.Drawing.Size(540, 227)
        Me.dgvCTMon.TabIndex = 9
        '
        'MaMon_CTM
        '
        Me.MaMon_CTM.DataPropertyName = "MaMon"
        Me.MaMon_CTM.HeaderText = "Mã Món"
        Me.MaMon_CTM.Name = "MaMon_CTM"
        Me.MaMon_CTM.ReadOnly = True
        Me.MaMon_CTM.Visible = False
        '
        'TenMon_CTMon
        '
        Me.TenMon_CTMon.DataPropertyName = "TenMon"
        Me.TenMon_CTMon.HeaderText = "Tên Món"
        Me.TenMon_CTMon.Name = "TenMon_CTMon"
        Me.TenMon_CTMon.ReadOnly = True
        Me.TenMon_CTMon.Width = 180
        '
        'MaSP_CTM
        '
        Me.MaSP_CTM.DataPropertyName = "MaSP"
        Me.MaSP_CTM.HeaderText = "Mã Sản Phẩm"
        Me.MaSP_CTM.Name = "MaSP_CTM"
        Me.MaSP_CTM.ReadOnly = True
        Me.MaSP_CTM.Visible = False
        '
        'TenSP_CTMon
        '
        Me.TenSP_CTMon.DataPropertyName = "TenSP"
        Me.TenSP_CTMon.HeaderText = "Tên Sản Phẩm"
        Me.TenSP_CTMon.Name = "TenSP_CTMon"
        Me.TenSP_CTMon.ReadOnly = True
        '
        'SoLuong_CTMon
        '
        Me.SoLuong_CTMon.DataPropertyName = "SoLuong"
        Me.SoLuong_CTMon.HeaderText = "Số Lượng"
        Me.SoLuong_CTMon.Name = "SoLuong_CTMon"
        Me.SoLuong_CTMon.ReadOnly = True
        '
        'DonVi_CTMon
        '
        Me.DonVi_CTMon.DataPropertyName = "TenDV"
        Me.DonVi_CTMon.HeaderText = "Đơn Vị"
        Me.DonVi_CTMon.Name = "DonVi_CTMon"
        Me.DonVi_CTMon.ReadOnly = True
        '
        'MaDonVi_MKHT
        '
        Me.MaDonVi_MKHT.DataPropertyName = "MaDV"
        Me.MaDonVi_MKHT.HeaderText = "Mã Đơn Vị"
        Me.MaDonVi_MKHT.Name = "MaDonVi_MKHT"
        Me.MaDonVi_MKHT.ReadOnly = True
        Me.MaDonVi_MKHT.Visible = False
        '
        'txtTimKiem_CTMon
        '
        Me.txtTimKiem_CTMon.Location = New System.Drawing.Point(383, 222)
        Me.txtTimKiem_CTMon.Name = "txtTimKiem_CTMon"
        Me.txtTimKiem_CTMon.Size = New System.Drawing.Size(187, 22)
        Me.txtTimKiem_CTMon.TabIndex = 8
        Me.txtTimKiem_CTMon.Text = "Nhập thông tin cần tìm vào đây"
        '
        'btnTim_CTMon
        '
        Me.btnTim_CTMon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim_CTMon.Location = New System.Drawing.Point(259, 218)
        Me.btnTim_CTMon.Name = "btnTim_CTMon"
        Me.btnTim_CTMon.Size = New System.Drawing.Size(104, 32)
        Me.btnTim_CTMon.TabIndex = 7
        Me.btnTim_CTMon.Text = "Tìm Kiếm"
        Me.btnTim_CTMon.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(291, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Đơn Vị"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(291, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Số Lượng"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(291, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tên Món"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(291, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Tên Sản Phẩm"
        '
        'btnXoa_CTMon
        '
        Me.btnXoa_CTMon.Location = New System.Drawing.Point(114, 144)
        Me.btnXoa_CTMon.Name = "btnXoa_CTMon"
        Me.btnXoa_CTMon.Size = New System.Drawing.Size(95, 37)
        Me.btnXoa_CTMon.TabIndex = 6
        Me.btnXoa_CTMon.Text = "Xóa"
        Me.btnXoa_CTMon.UseVisualStyleBackColor = True
        '
        'btnSua_CTMon
        '
        Me.btnSua_CTMon.Location = New System.Drawing.Point(114, 90)
        Me.btnSua_CTMon.Name = "btnSua_CTMon"
        Me.btnSua_CTMon.Size = New System.Drawing.Size(95, 37)
        Me.btnSua_CTMon.TabIndex = 5
        Me.btnSua_CTMon.Text = "Sửa"
        Me.btnSua_CTMon.UseVisualStyleBackColor = True
        '
        'btnThem_CTMon
        '
        Me.btnThem_CTMon.Location = New System.Drawing.Point(114, 38)
        Me.btnThem_CTMon.Name = "btnThem_CTMon"
        Me.btnThem_CTMon.Size = New System.Drawing.Size(95, 37)
        Me.btnThem_CTMon.TabIndex = 4
        Me.btnThem_CTMon.Text = "Thêm"
        Me.btnThem_CTMon.UseVisualStyleBackColor = True
        '
        'txtSoLuong_CTMon
        '
        Me.txtSoLuong_CTMon.Location = New System.Drawing.Point(400, 124)
        Me.txtSoLuong_CTMon.Name = "txtSoLuong_CTMon"
        Me.txtSoLuong_CTMon.Size = New System.Drawing.Size(179, 22)
        Me.txtSoLuong_CTMon.TabIndex = 2
        '
        'txtTenMon_CTMon
        '
        Me.txtTenMon_CTMon.Location = New System.Drawing.Point(400, 46)
        Me.txtTenMon_CTMon.Name = "txtTenMon_CTMon"
        Me.txtTenMon_CTMon.Size = New System.Drawing.Size(179, 22)
        Me.txtTenMon_CTMon.TabIndex = 0
        '
        'txtTenSP_CTMon
        '
        Me.txtTenSP_CTMon.Location = New System.Drawing.Point(400, 87)
        Me.txtTenSP_CTMon.Name = "txtTenSP_CTMon"
        Me.txtTenSP_CTMon.Size = New System.Drawing.Size(179, 22)
        Me.txtTenSP_CTMon.TabIndex = 1
        '
        'gbxThongTinChiTietHoaDon
        '
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.cboLoai_MADU)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.cboThucDonMon_Mon)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.dgvMonAnDoUong)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.txtTimKiem_Mon)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.btnTimKiem_Mon)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.Label11)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.Label18)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.Label12)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.Label13)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.btnXoa_Mon)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.btnSua_Mon)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.btnThem_Mon)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.txtTenMon_Mon)
        Me.gbxThongTinChiTietHoaDon.Controls.Add(Me.txtGiaHienTai_Mon)
        Me.gbxThongTinChiTietHoaDon.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxThongTinChiTietHoaDon.Location = New System.Drawing.Point(21, 14)
        Me.gbxThongTinChiTietHoaDon.Name = "gbxThongTinChiTietHoaDon"
        Me.gbxThongTinChiTietHoaDon.Size = New System.Drawing.Size(1300, 276)
        Me.gbxThongTinChiTietHoaDon.TabIndex = 6
        Me.gbxThongTinChiTietHoaDon.TabStop = False
        Me.gbxThongTinChiTietHoaDon.Text = "Thông Tin Món"
        '
        'cboLoai_MADU
        '
        Me.cboLoai_MADU.FormattingEnabled = True
        Me.cboLoai_MADU.Location = New System.Drawing.Point(401, 94)
        Me.cboLoai_MADU.Name = "cboLoai_MADU"
        Me.cboLoai_MADU.Size = New System.Drawing.Size(121, 23)
        Me.cboLoai_MADU.TabIndex = 10
        '
        'cboThucDonMon_Mon
        '
        Me.cboThucDonMon_Mon.FormattingEnabled = True
        Me.cboThucDonMon_Mon.Items.AddRange(New Object() {"Có", "Không"})
        Me.cboThucDonMon_Mon.Location = New System.Drawing.Point(400, 170)
        Me.cboThucDonMon_Mon.Name = "cboThucDonMon_Mon"
        Me.cboThucDonMon_Mon.Size = New System.Drawing.Size(126, 23)
        Me.cboThucDonMon_Mon.TabIndex = 9
        '
        'dgvMonAnDoUong
        '
        Me.dgvMonAnDoUong.AllowUserToOrderColumns = True
        Me.dgvMonAnDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonAnDoUong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMon_MADU, Me.TenMon, Me.GiaTienHienTai, Me.ThucDonMon, Me.Loai})
        Me.dgvMonAnDoUong.Location = New System.Drawing.Point(632, 40)
        Me.dgvMonAnDoUong.Name = "dgvMonAnDoUong"
        Me.dgvMonAnDoUong.RowTemplate.Height = 24
        Me.dgvMonAnDoUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMonAnDoUong.Size = New System.Drawing.Size(625, 206)
        Me.dgvMonAnDoUong.TabIndex = 8
        '
        'MaMon_MADU
        '
        Me.MaMon_MADU.DataPropertyName = "MaMon"
        Me.MaMon_MADU.HeaderText = "Mã Món"
        Me.MaMon_MADU.Name = "MaMon_MADU"
        Me.MaMon_MADU.ReadOnly = True
        Me.MaMon_MADU.Visible = False
        '
        'TenMon
        '
        Me.TenMon.DataPropertyName = "TenMon"
        Me.TenMon.HeaderText = "Tên Món"
        Me.TenMon.Name = "TenMon"
        Me.TenMon.ReadOnly = True
        Me.TenMon.Width = 200
        '
        'GiaTienHienTai
        '
        Me.GiaTienHienTai.DataPropertyName = "GiaTienHienTai"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.GiaTienHienTai.DefaultCellStyle = DataGridViewCellStyle1
        Me.GiaTienHienTai.HeaderText = "Giá Tiền Hiện Tại"
        Me.GiaTienHienTai.Name = "GiaTienHienTai"
        Me.GiaTienHienTai.ReadOnly = True
        Me.GiaTienHienTai.Width = 145
        '
        'ThucDonMon
        '
        Me.ThucDonMon.HeaderText = "Thực Đơn Món"
        Me.ThucDonMon.Name = "ThucDonMon"
        Me.ThucDonMon.ReadOnly = True
        Me.ThucDonMon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ThucDonMon.Width = 120
        '
        'Loai
        '
        Me.Loai.HeaderText = "Loại"
        Me.Loai.Name = "Loai"
        Me.Loai.ReadOnly = True
        '
        'txtTimKiem_Mon
        '
        Me.txtTimKiem_Mon.Location = New System.Drawing.Point(383, 218)
        Me.txtTimKiem_Mon.Name = "txtTimKiem_Mon"
        Me.txtTimKiem_Mon.Size = New System.Drawing.Size(187, 22)
        Me.txtTimKiem_Mon.TabIndex = 7
        Me.txtTimKiem_Mon.Text = "Nhập thông tin cần tìm vào đây"
        '
        'btnTimKiem_Mon
        '
        Me.btnTimKiem_Mon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem_Mon.Location = New System.Drawing.Point(259, 214)
        Me.btnTimKiem_Mon.Name = "btnTimKiem_Mon"
        Me.btnTimKiem_Mon.Size = New System.Drawing.Size(104, 32)
        Me.btnTimKiem_Mon.TabIndex = 6
        Me.btnTimKiem_Mon.Text = "Tìm Kiếm"
        Me.btnTimKiem_Mon.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(291, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Thực Đơn Món"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(291, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 15)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Loại"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(291, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Tên Món"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(291, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Giá Hiện Tại"
        '
        'btnXoa_Mon
        '
        Me.btnXoa_Mon.Location = New System.Drawing.Point(114, 162)
        Me.btnXoa_Mon.Name = "btnXoa_Mon"
        Me.btnXoa_Mon.Size = New System.Drawing.Size(95, 37)
        Me.btnXoa_Mon.TabIndex = 5
        Me.btnXoa_Mon.Text = "Xóa"
        Me.btnXoa_Mon.UseVisualStyleBackColor = True
        '
        'btnSua_Mon
        '
        Me.btnSua_Mon.Location = New System.Drawing.Point(114, 110)
        Me.btnSua_Mon.Name = "btnSua_Mon"
        Me.btnSua_Mon.Size = New System.Drawing.Size(95, 37)
        Me.btnSua_Mon.TabIndex = 4
        Me.btnSua_Mon.Text = "Sửa"
        Me.btnSua_Mon.UseVisualStyleBackColor = True
        '
        'btnThem_Mon
        '
        Me.btnThem_Mon.Location = New System.Drawing.Point(114, 60)
        Me.btnThem_Mon.Name = "btnThem_Mon"
        Me.btnThem_Mon.Size = New System.Drawing.Size(95, 37)
        Me.btnThem_Mon.TabIndex = 3
        Me.btnThem_Mon.Text = "Thêm"
        Me.btnThem_Mon.UseVisualStyleBackColor = True
        '
        'txtTenMon_Mon
        '
        Me.txtTenMon_Mon.Location = New System.Drawing.Point(400, 60)
        Me.txtTenMon_Mon.Name = "txtTenMon_Mon"
        Me.txtTenMon_Mon.Size = New System.Drawing.Size(179, 22)
        Me.txtTenMon_Mon.TabIndex = 0
        '
        'txtGiaHienTai_Mon
        '
        Me.txtGiaHienTai_Mon.Location = New System.Drawing.Point(400, 133)
        Me.txtGiaHienTai_Mon.Name = "txtGiaHienTai_Mon"
        Me.txtGiaHienTai_Mon.Size = New System.Drawing.Size(179, 22)
        Me.txtGiaHienTai_Mon.TabIndex = 1
        '
        'PhieuNhap
        '
        Me.PhieuNhap.Controls.Add(Me.gpbChiTietPhieuNhap)
        Me.PhieuNhap.Controls.Add(Me.GroupBox6)
        Me.PhieuNhap.Controls.Add(Me.gpbDanhSachCTPN)
        Me.PhieuNhap.Controls.Add(Me.GroupBox4)
        Me.PhieuNhap.Location = New System.Drawing.Point(4, 24)
        Me.PhieuNhap.Name = "PhieuNhap"
        Me.PhieuNhap.Padding = New System.Windows.Forms.Padding(3)
        Me.PhieuNhap.Size = New System.Drawing.Size(1340, 626)
        Me.PhieuNhap.TabIndex = 3
        Me.PhieuNhap.Text = "Phiếu Nhập"
        Me.PhieuNhap.UseVisualStyleBackColor = True
        '
        'gpbChiTietPhieuNhap
        '
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.Label31)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.btnSua_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.btnXoa_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.btnThem_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.Label29)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.Label28)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.txtThanhTIen_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.cboDonVi_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.Label26)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.txtDonGia_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.Label27)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.txtSoLuong_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.Label21)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.txtTenSP_CTPN)
        Me.gpbChiTietPhieuNhap.Controls.Add(Me.txtMaPN_CTPN)
        Me.gpbChiTietPhieuNhap.Enabled = False
        Me.gpbChiTietPhieuNhap.Location = New System.Drawing.Point(16, 334)
        Me.gpbChiTietPhieuNhap.Name = "gpbChiTietPhieuNhap"
        Me.gpbChiTietPhieuNhap.Size = New System.Drawing.Size(498, 252)
        Me.gpbChiTietPhieuNhap.TabIndex = 11
        Me.gpbChiTietPhieuNhap.TabStop = False
        Me.gpbChiTietPhieuNhap.Text = "Thông Tin Chi Tiết Phiếu Nhập"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(25, 185)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(108, 24)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Thành Tiền"
        '
        'btnSua_CTPN
        '
        Me.btnSua_CTPN.Location = New System.Drawing.Point(386, 101)
        Me.btnSua_CTPN.Name = "btnSua_CTPN"
        Me.btnSua_CTPN.Size = New System.Drawing.Size(95, 37)
        Me.btnSua_CTPN.TabIndex = 4
        Me.btnSua_CTPN.Text = "Sửa"
        Me.btnSua_CTPN.UseVisualStyleBackColor = True
        '
        'btnXoa_CTPN
        '
        Me.btnXoa_CTPN.Location = New System.Drawing.Point(386, 157)
        Me.btnXoa_CTPN.Name = "btnXoa_CTPN"
        Me.btnXoa_CTPN.Size = New System.Drawing.Size(95, 37)
        Me.btnXoa_CTPN.TabIndex = 5
        Me.btnXoa_CTPN.Text = "Xóa"
        Me.btnXoa_CTPN.UseVisualStyleBackColor = True
        '
        'btnThem_CTPN
        '
        Me.btnThem_CTPN.Location = New System.Drawing.Point(386, 50)
        Me.btnThem_CTPN.Name = "btnThem_CTPN"
        Me.btnThem_CTPN.Size = New System.Drawing.Size(95, 37)
        Me.btnThem_CTPN.TabIndex = 3
        Me.btnThem_CTPN.Text = "Thêm"
        Me.btnThem_CTPN.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(13, 157)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 15)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Đơn Giá"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 127)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 15)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Đơn Vị"
        '
        'txtThanhTIen_CTPN
        '
        Me.txtThanhTIen_CTPN.Location = New System.Drawing.Point(150, 185)
        Me.txtThanhTIen_CTPN.Name = "txtThanhTIen_CTPN"
        Me.txtThanhTIen_CTPN.Size = New System.Drawing.Size(179, 22)
        Me.txtThanhTIen_CTPN.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(13, 96)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 15)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Số Lượng"
        '
        'txtDonGia_CTPN
        '
        Me.txtDonGia_CTPN.Location = New System.Drawing.Point(150, 154)
        Me.txtDonGia_CTPN.Name = "txtDonGia_CTPN"
        Me.txtDonGia_CTPN.Size = New System.Drawing.Size(179, 22)
        Me.txtDonGia_CTPN.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 34)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 15)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Mã Phiếu Nhập"
        '
        'txtSoLuong_CTPN
        '
        Me.txtSoLuong_CTPN.Location = New System.Drawing.Point(150, 93)
        Me.txtSoLuong_CTPN.Name = "txtSoLuong_CTPN"
        Me.txtSoLuong_CTPN.Size = New System.Drawing.Size(179, 22)
        Me.txtSoLuong_CTPN.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Tên Sản Phẩm"
        '
        'txtTenSP_CTPN
        '
        Me.txtTenSP_CTPN.Location = New System.Drawing.Point(150, 62)
        Me.txtTenSP_CTPN.Name = "txtTenSP_CTPN"
        Me.txtTenSP_CTPN.Size = New System.Drawing.Size(179, 22)
        Me.txtTenSP_CTPN.TabIndex = 1
        '
        'txtMaPN_CTPN
        '
        Me.txtMaPN_CTPN.Location = New System.Drawing.Point(150, 31)
        Me.txtMaPN_CTPN.Name = "txtMaPN_CTPN"
        Me.txtMaPN_CTPN.Size = New System.Drawing.Size(179, 22)
        Me.txtMaPN_CTPN.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvPhieuNhap)
        Me.GroupBox6.Controls.Add(Me.btnTimKiem_PhieuNhap)
        Me.GroupBox6.Controls.Add(Me.txtTimKiem_PhieuNhap)
        Me.GroupBox6.Location = New System.Drawing.Point(529, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(788, 279)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Danh Sách Phiếu Nhập"
        '
        'dgvPhieuNhap
        '
        Me.dgvPhieuNhap.AllowUserToOrderColumns = True
        Me.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPN_PN, Me.MaNCC_PN, Me.TenNCC_PN, Me.MaNV_PN, Me.TenNV_PN, Me.NgayLap_PN, Me.NgayGiaoDK_PN, Me.TongTien_PN, Me.TinhTrang_PN})
        Me.dgvPhieuNhap.Location = New System.Drawing.Point(6, 49)
        Me.dgvPhieuNhap.Name = "dgvPhieuNhap"
        Me.dgvPhieuNhap.RowTemplate.Height = 24
        Me.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhieuNhap.Size = New System.Drawing.Size(774, 214)
        Me.dgvPhieuNhap.TabIndex = 8
        '
        'MaPN_PN
        '
        Me.MaPN_PN.DataPropertyName = "MaPN"
        Me.MaPN_PN.HeaderText = "Mã Phiếu Nhập"
        Me.MaPN_PN.Name = "MaPN_PN"
        Me.MaPN_PN.ReadOnly = True
        Me.MaPN_PN.Visible = False
        '
        'MaNCC_PN
        '
        Me.MaNCC_PN.DataPropertyName = "MaNCC"
        Me.MaNCC_PN.HeaderText = "Mã Nhà Cung Cấp"
        Me.MaNCC_PN.Name = "MaNCC_PN"
        Me.MaNCC_PN.ReadOnly = True
        Me.MaNCC_PN.Visible = False
        '
        'TenNCC_PN
        '
        Me.TenNCC_PN.HeaderText = "Tên Nhà Cung Cấp"
        Me.TenNCC_PN.Name = "TenNCC_PN"
        '
        'MaNV_PN
        '
        Me.MaNV_PN.DataPropertyName = "MaNV"
        Me.MaNV_PN.HeaderText = "Mã Nhân Viên"
        Me.MaNV_PN.Name = "MaNV_PN"
        Me.MaNV_PN.ReadOnly = True
        Me.MaNV_PN.Visible = False
        '
        'TenNV_PN
        '
        Me.TenNV_PN.HeaderText = "Tên Nhân Viên"
        Me.TenNV_PN.Name = "TenNV_PN"
        '
        'NgayLap_PN
        '
        Me.NgayLap_PN.DataPropertyName = "NgayLap"
        Me.NgayLap_PN.HeaderText = "Ngày Lập"
        Me.NgayLap_PN.Name = "NgayLap_PN"
        Me.NgayLap_PN.ReadOnly = True
        Me.NgayLap_PN.Width = 150
        '
        'NgayGiaoDK_PN
        '
        Me.NgayGiaoDK_PN.DataPropertyName = "NgayGiaoDK"
        Me.NgayGiaoDK_PN.HeaderText = "Ngày Giao DK"
        Me.NgayGiaoDK_PN.Name = "NgayGiaoDK_PN"
        Me.NgayGiaoDK_PN.ReadOnly = True
        Me.NgayGiaoDK_PN.Width = 150
        '
        'TongTien_PN
        '
        Me.TongTien_PN.DataPropertyName = "TongTien"
        Me.TongTien_PN.HeaderText = "Tổng Tiền"
        Me.TongTien_PN.Name = "TongTien_PN"
        Me.TongTien_PN.ReadOnly = True
        Me.TongTien_PN.Width = 130
        '
        'TinhTrang_PN
        '
        Me.TinhTrang_PN.DataPropertyName = "TinhTrang"
        Me.TinhTrang_PN.HeaderText = "Tình Trạng"
        Me.TinhTrang_PN.Name = "TinhTrang_PN"
        Me.TinhTrang_PN.ReadOnly = True
        '
        'btnTimKiem_PhieuNhap
        '
        Me.btnTimKiem_PhieuNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem_PhieuNhap.Location = New System.Drawing.Point(79, 15)
        Me.btnTimKiem_PhieuNhap.Name = "btnTimKiem_PhieuNhap"
        Me.btnTimKiem_PhieuNhap.Size = New System.Drawing.Size(104, 32)
        Me.btnTimKiem_PhieuNhap.TabIndex = 6
        Me.btnTimKiem_PhieuNhap.Text = "Tìm Kiếm"
        Me.btnTimKiem_PhieuNhap.UseVisualStyleBackColor = True
        '
        'txtTimKiem_PhieuNhap
        '
        Me.txtTimKiem_PhieuNhap.Location = New System.Drawing.Point(189, 19)
        Me.txtTimKiem_PhieuNhap.Name = "txtTimKiem_PhieuNhap"
        Me.txtTimKiem_PhieuNhap.Size = New System.Drawing.Size(187, 22)
        Me.txtTimKiem_PhieuNhap.TabIndex = 7
        Me.txtTimKiem_PhieuNhap.Text = "Nhập thông tin cần tìm vào đây"
        '
        'gpbDanhSachCTPN
        '
        Me.gpbDanhSachCTPN.Controls.Add(Me.dgvChiTietPhieuNhap)
        Me.gpbDanhSachCTPN.Controls.Add(Me.btnTim_CTPN)
        Me.gpbDanhSachCTPN.Controls.Add(Me.txtTim_CTPN)
        Me.gpbDanhSachCTPN.Enabled = False
        Me.gpbDanhSachCTPN.Location = New System.Drawing.Point(529, 317)
        Me.gpbDanhSachCTPN.Name = "gpbDanhSachCTPN"
        Me.gpbDanhSachCTPN.Size = New System.Drawing.Size(788, 286)
        Me.gpbDanhSachCTPN.TabIndex = 9
        Me.gpbDanhSachCTPN.TabStop = False
        Me.gpbDanhSachCTPN.Text = "Danh Sách Chi Tiết Phiếu Nhập"
        '
        'dgvChiTietPhieuNhap
        '
        Me.dgvChiTietPhieuNhap.AllowUserToOrderColumns = True
        Me.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietPhieuNhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPN_CTPN, Me.MaSP_CTPN, Me.TenSP_CTPN, Me.SoLuong_CTPN, Me.MaDV_CTPN, Me.TenDV_CTPN, Me.DonGia_CTPN, Me.ThanhTien_CTPN})
        Me.dgvChiTietPhieuNhap.Location = New System.Drawing.Point(6, 55)
        Me.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap"
        Me.dgvChiTietPhieuNhap.RowTemplate.Height = 24
        Me.dgvChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChiTietPhieuNhap.Size = New System.Drawing.Size(774, 214)
        Me.dgvChiTietPhieuNhap.TabIndex = 8
        '
        'MaPN_CTPN
        '
        Me.MaPN_CTPN.DataPropertyName = "MaPN"
        Me.MaPN_CTPN.HeaderText = "Mã Phiếu Nhập"
        Me.MaPN_CTPN.Name = "MaPN_CTPN"
        Me.MaPN_CTPN.ReadOnly = True
        Me.MaPN_CTPN.Visible = False
        '
        'MaSP_CTPN
        '
        Me.MaSP_CTPN.DataPropertyName = "MaSP"
        Me.MaSP_CTPN.HeaderText = "Mả Sản Phẩm"
        Me.MaSP_CTPN.Name = "MaSP_CTPN"
        Me.MaSP_CTPN.ReadOnly = True
        Me.MaSP_CTPN.Visible = False
        '
        'TenSP_CTPN
        '
        Me.TenSP_CTPN.DataPropertyName = "TeSP"
        Me.TenSP_CTPN.HeaderText = "Tên Sản Phẩm"
        Me.TenSP_CTPN.Name = "TenSP_CTPN"
        Me.TenSP_CTPN.ReadOnly = True
        Me.TenSP_CTPN.Width = 200
        '
        'SoLuong_CTPN
        '
        Me.SoLuong_CTPN.DataPropertyName = "SoLuong"
        Me.SoLuong_CTPN.HeaderText = "Số Lượng"
        Me.SoLuong_CTPN.Name = "SoLuong_CTPN"
        Me.SoLuong_CTPN.ReadOnly = True
        Me.SoLuong_CTPN.Width = 130
        '
        'MaDV_CTPN
        '
        Me.MaDV_CTPN.DataPropertyName = "MaDV"
        Me.MaDV_CTPN.HeaderText = "Mã Đơn Vị"
        Me.MaDV_CTPN.Name = "MaDV_CTPN"
        Me.MaDV_CTPN.ReadOnly = True
        Me.MaDV_CTPN.Visible = False
        Me.MaDV_CTPN.Width = 150
        '
        'TenDV_CTPN
        '
        Me.TenDV_CTPN.DataPropertyName = "TenDV"
        Me.TenDV_CTPN.HeaderText = "Tên Đơn Vị"
        Me.TenDV_CTPN.Name = "TenDV_CTPN"
        Me.TenDV_CTPN.ReadOnly = True
        Me.TenDV_CTPN.Width = 120
        '
        'DonGia_CTPN
        '
        Me.DonGia_CTPN.DataPropertyName = "DonGia"
        Me.DonGia_CTPN.HeaderText = "Đơn Giá"
        Me.DonGia_CTPN.Name = "DonGia_CTPN"
        Me.DonGia_CTPN.ReadOnly = True
        Me.DonGia_CTPN.Width = 140
        '
        'ThanhTien_CTPN
        '
        Me.ThanhTien_CTPN.DataPropertyName = "ThanhTien"
        Me.ThanhTien_CTPN.HeaderText = "Thành Tiền"
        Me.ThanhTien_CTPN.Name = "ThanhTien_CTPN"
        Me.ThanhTien_CTPN.ReadOnly = True
        Me.ThanhTien_CTPN.Width = 140
        '
        'btnTim_CTPN
        '
        Me.btnTim_CTPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim_CTPN.Location = New System.Drawing.Point(79, 21)
        Me.btnTim_CTPN.Name = "btnTim_CTPN"
        Me.btnTim_CTPN.Size = New System.Drawing.Size(104, 32)
        Me.btnTim_CTPN.TabIndex = 6
        Me.btnTim_CTPN.Text = "Tìm Kiếm"
        Me.btnTim_CTPN.UseVisualStyleBackColor = True
        '
        'txtTim_CTPN
        '
        Me.txtTim_CTPN.Location = New System.Drawing.Point(189, 25)
        Me.txtTim_CTPN.Name = "txtTim_CTPN"
        Me.txtTim_CTPN.Size = New System.Drawing.Size(187, 22)
        Me.txtTim_CTPN.TabIndex = 7
        Me.txtTim_CTPN.Text = "Nhập thông tin cần tìm vào đây"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnThongKe_PhieuNhap)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.dtpNgayGiaoDK)
        Me.GroupBox4.Controls.Add(Me.dtpNgayLap)
        Me.GroupBox4.Controls.Add(Me.btnThem_PhieuNhap)
        Me.GroupBox4.Controls.Add(Me.btnXoa_PhieuNhap)
        Me.GroupBox4.Controls.Add(Me.btnSua_PhieuNhap)
        Me.GroupBox4.Controls.Add(Me.cboTinhTrang_PhieuNhap)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.txtTenNV_PN)
        Me.GroupBox4.Controls.Add(Me.txtTenNCC_PN)
        Me.GroupBox4.Controls.Add(Me.txtTongTien_PhieuNhap)
        Me.GroupBox4.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(16, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(498, 243)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông Tin Phiếu Nhập"
        '
        'btnThongKe_PhieuNhap
        '
        Me.btnThongKe_PhieuNhap.Location = New System.Drawing.Point(386, 187)
        Me.btnThongKe_PhieuNhap.Name = "btnThongKe_PhieuNhap"
        Me.btnThongKe_PhieuNhap.Size = New System.Drawing.Size(95, 37)
        Me.btnThongKe_PhieuNhap.TabIndex = 3
        Me.btnThongKe_PhieuNhap.Text = "Chi Tiết"
        Me.btnThongKe_PhieuNhap.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(25, 206)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 24)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Tổng Tiền"
        '
        'dtpNgayGiaoDK
        '
        Me.dtpNgayGiaoDK.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayGiaoDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayGiaoDK.Location = New System.Drawing.Point(150, 147)
        Me.dtpNgayGiaoDK.Name = "dtpNgayGiaoDK"
        Me.dtpNgayGiaoDK.Size = New System.Drawing.Size(200, 22)
        Me.dtpNgayGiaoDK.TabIndex = 10
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgayLap.Location = New System.Drawing.Point(150, 114)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(200, 22)
        Me.dtpNgayLap.TabIndex = 10
        '
        'btnThem_PhieuNhap
        '
        Me.btnThem_PhieuNhap.Location = New System.Drawing.Point(386, 24)
        Me.btnThem_PhieuNhap.Name = "btnThem_PhieuNhap"
        Me.btnThem_PhieuNhap.Size = New System.Drawing.Size(95, 37)
        Me.btnThem_PhieuNhap.TabIndex = 3
        Me.btnThem_PhieuNhap.Text = "Thêm"
        Me.btnThem_PhieuNhap.UseVisualStyleBackColor = True
        '
        'btnXoa_PhieuNhap
        '
        Me.btnXoa_PhieuNhap.Location = New System.Drawing.Point(386, 131)
        Me.btnXoa_PhieuNhap.Name = "btnXoa_PhieuNhap"
        Me.btnXoa_PhieuNhap.Size = New System.Drawing.Size(95, 37)
        Me.btnXoa_PhieuNhap.TabIndex = 5
        Me.btnXoa_PhieuNhap.Text = "Xóa"
        Me.btnXoa_PhieuNhap.UseVisualStyleBackColor = True
        '
        'btnSua_PhieuNhap
        '
        Me.btnSua_PhieuNhap.Location = New System.Drawing.Point(386, 75)
        Me.btnSua_PhieuNhap.Name = "btnSua_PhieuNhap"
        Me.btnSua_PhieuNhap.Size = New System.Drawing.Size(95, 37)
        Me.btnSua_PhieuNhap.TabIndex = 4
        Me.btnSua_PhieuNhap.Text = "Sửa"
        Me.btnSua_PhieuNhap.UseVisualStyleBackColor = True
        '
        'cboTinhTrang_PhieuNhap
        '
        Me.cboTinhTrang_PhieuNhap.FormattingEnabled = True
        Me.cboTinhTrang_PhieuNhap.Location = New System.Drawing.Point(150, 176)
        Me.cboTinhTrang_PhieuNhap.Name = "cboTinhTrang_PhieuNhap"
        Me.cboTinhTrang_PhieuNhap.Size = New System.Drawing.Size(126, 23)
        Me.cboTinhTrang_PhieuNhap.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tình Trạng"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(91, 15)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Mã Phiếu Nhập"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Tên Nhà Cung Cấp"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 153)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 15)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Ngày Giao DK"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Ngày Lập"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 55)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 15)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Tên Nhân Viên"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(150, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 22)
        Me.TextBox2.TabIndex = 0
        '
        'txtTenNV_PN
        '
        Me.txtTenNV_PN.Location = New System.Drawing.Point(150, 52)
        Me.txtTenNV_PN.Name = "txtTenNV_PN"
        Me.txtTenNV_PN.Size = New System.Drawing.Size(179, 22)
        Me.txtTenNV_PN.TabIndex = 1
        '
        'txtTenNCC_PN
        '
        Me.txtTenNCC_PN.Location = New System.Drawing.Point(150, 83)
        Me.txtTenNCC_PN.Name = "txtTenNCC_PN"
        Me.txtTenNCC_PN.Size = New System.Drawing.Size(179, 22)
        Me.txtTenNCC_PN.TabIndex = 0
        '
        'txtTongTien_PhieuNhap
        '
        Me.txtTongTien_PhieuNhap.Location = New System.Drawing.Point(150, 208)
        Me.txtTongTien_PhieuNhap.Name = "txtTongTien_PhieuNhap"
        Me.txtTongTien_PhieuNhap.Size = New System.Drawing.Size(179, 22)
        Me.txtTongTien_PhieuNhap.TabIndex = 1
        '
        'ChucVu_LoaiDonViTinh
        '
        Me.ChucVu_LoaiDonViTinh.Controls.Add(Me.GroupBox11)
        Me.ChucVu_LoaiDonViTinh.Controls.Add(Me.GroupBox10)
        Me.ChucVu_LoaiDonViTinh.Location = New System.Drawing.Point(4, 24)
        Me.ChucVu_LoaiDonViTinh.Name = "ChucVu_LoaiDonViTinh"
        Me.ChucVu_LoaiDonViTinh.Padding = New System.Windows.Forms.Padding(3)
        Me.ChucVu_LoaiDonViTinh.Size = New System.Drawing.Size(1340, 626)
        Me.ChucVu_LoaiDonViTinh.TabIndex = 4
        Me.ChucVu_LoaiDonViTinh.Text = "Chức Vụ - Loại Đơn Vị Tính"
        Me.ChucVu_LoaiDonViTinh.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.GroupBox9)
        Me.GroupBox11.Controls.Add(Me.GroupBox8)
        Me.GroupBox11.Location = New System.Drawing.Point(691, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(628, 606)
        Me.GroupBox11.TabIndex = 2
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Chức Vụ Nhân Viên"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dgvChucVu)
        Me.GroupBox9.Location = New System.Drawing.Point(57, 159)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(510, 422)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Danh Sách Thông Tin Chức Vụ"
        '
        'dgvChucVu
        '
        Me.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChucVu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvChucVu.Location = New System.Drawing.Point(6, 21)
        Me.dgvChucVu.Name = "dgvChucVu"
        Me.dgvChucVu.Size = New System.Drawing.Size(496, 395)
        Me.dgvChucVu.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã Đơn Vị"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên Đơn Vị"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Độ Tăng Mặc Định"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnXoa_ChucVu)
        Me.GroupBox8.Controls.Add(Me.btnSua_ChucVu)
        Me.GroupBox8.Controls.Add(Me.btnThem_ChucVu)
        Me.GroupBox8.Controls.Add(Me.TextBox6)
        Me.GroupBox8.Controls.Add(Me.TextBox7)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Controls.Add(Me.Label36)
        Me.GroupBox8.Location = New System.Drawing.Point(75, 24)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(474, 129)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Thông Tin Chức Vụ"
        '
        'btnXoa_ChucVu
        '
        Me.btnXoa_ChucVu.Location = New System.Drawing.Point(325, 89)
        Me.btnXoa_ChucVu.Name = "btnXoa_ChucVu"
        Me.btnXoa_ChucVu.Size = New System.Drawing.Size(102, 34)
        Me.btnXoa_ChucVu.TabIndex = 2
        Me.btnXoa_ChucVu.Text = "Xóa"
        Me.btnXoa_ChucVu.UseVisualStyleBackColor = True
        '
        'btnSua_ChucVu
        '
        Me.btnSua_ChucVu.Location = New System.Drawing.Point(184, 89)
        Me.btnSua_ChucVu.Name = "btnSua_ChucVu"
        Me.btnSua_ChucVu.Size = New System.Drawing.Size(102, 34)
        Me.btnSua_ChucVu.TabIndex = 2
        Me.btnSua_ChucVu.Text = "Sửa"
        Me.btnSua_ChucVu.UseVisualStyleBackColor = True
        '
        'btnThem_ChucVu
        '
        Me.btnThem_ChucVu.Location = New System.Drawing.Point(43, 89)
        Me.btnThem_ChucVu.Name = "btnThem_ChucVu"
        Me.btnThem_ChucVu.Size = New System.Drawing.Size(102, 34)
        Me.btnThem_ChucVu.TabIndex = 2
        Me.btnThem_ChucVu.Text = "Them"
        Me.btnThem_ChucVu.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(139, 21)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(174, 22)
        Me.TextBox6.TabIndex = 1
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(139, 58)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(174, 22)
        Me.TextBox7.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(17, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(73, 15)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Mã Chức Vụ"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(17, 61)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(76, 15)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Tên Chức Vụ"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GroupBox7)
        Me.GroupBox10.Controls.Add(Me.GroupBox5)
        Me.GroupBox10.Location = New System.Drawing.Point(16, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(621, 606)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Loại Đơn Vị Tính"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dgvChucVuNV)
        Me.GroupBox7.Location = New System.Drawing.Point(52, 159)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(510, 436)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Danh Sách Thông Tin Loại Đơn Vị"
        '
        'dgvChucVuNV
        '
        Me.dgvChucVuNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChucVuNV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDV_LDVT, Me.TenDV_LDVT, Me.DoTangMacDinh_LDVT})
        Me.dgvChucVuNV.Location = New System.Drawing.Point(6, 21)
        Me.dgvChucVuNV.Name = "dgvChucVuNV"
        Me.dgvChucVuNV.Size = New System.Drawing.Size(496, 409)
        Me.dgvChucVuNV.TabIndex = 2
        '
        'MaDV_LDVT
        '
        Me.MaDV_LDVT.HeaderText = "Mã Đơn Vị"
        Me.MaDV_LDVT.Name = "MaDV_LDVT"
        Me.MaDV_LDVT.ReadOnly = True
        Me.MaDV_LDVT.Width = 150
        '
        'TenDV_LDVT
        '
        Me.TenDV_LDVT.HeaderText = "Tên Đơn Vị"
        Me.TenDV_LDVT.Name = "TenDV_LDVT"
        Me.TenDV_LDVT.ReadOnly = True
        Me.TenDV_LDVT.Width = 150
        '
        'DoTangMacDinh_LDVT
        '
        Me.DoTangMacDinh_LDVT.HeaderText = "Độ Tăng Mặc Định"
        Me.DoTangMacDinh_LDVT.Name = "DoTangMacDinh_LDVT"
        Me.DoTangMacDinh_LDVT.ReadOnly = True
        Me.DoTangMacDinh_LDVT.Width = 150
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSua_LoaiDV)
        Me.GroupBox5.Controls.Add(Me.btnXoa_LoaiDV)
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.btnThem_LoaiDV)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Location = New System.Drawing.Point(70, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(474, 129)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Thông Tin Loại Đơn Vị"
        '
        'btnSua_LoaiDV
        '
        Me.btnSua_LoaiDV.Location = New System.Drawing.Point(346, 51)
        Me.btnSua_LoaiDV.Name = "btnSua_LoaiDV"
        Me.btnSua_LoaiDV.Size = New System.Drawing.Size(102, 34)
        Me.btnSua_LoaiDV.TabIndex = 2
        Me.btnSua_LoaiDV.Text = "Sửa"
        Me.btnSua_LoaiDV.UseVisualStyleBackColor = True
        '
        'btnXoa_LoaiDV
        '
        Me.btnXoa_LoaiDV.Location = New System.Drawing.Point(346, 89)
        Me.btnXoa_LoaiDV.Name = "btnXoa_LoaiDV"
        Me.btnXoa_LoaiDV.Size = New System.Drawing.Size(102, 34)
        Me.btnXoa_LoaiDV.TabIndex = 2
        Me.btnXoa_LoaiDV.Text = "Xóa"
        Me.btnXoa_LoaiDV.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(139, 93)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(174, 22)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(139, 21)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(174, 22)
        Me.TextBox4.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(17, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 15)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Mã Đơn Vị"
        '
        'btnThem_LoaiDV
        '
        Me.btnThem_LoaiDV.Location = New System.Drawing.Point(346, 14)
        Me.btnThem_LoaiDV.Name = "btnThem_LoaiDV"
        Me.btnThem_LoaiDV.Size = New System.Drawing.Size(102, 34)
        Me.btnThem_LoaiDV.TabIndex = 2
        Me.btnThem_LoaiDV.Text = "Thêm"
        Me.btnThem_LoaiDV.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(17, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(107, 15)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Độ Tăng Mặc Định"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(17, 61)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 15)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Tên Đơn Vị"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'cboDonVi_CTPN
        '
        Me.cboDonVi_CTPN.FormattingEnabled = True
        Me.cboDonVi_CTPN.Location = New System.Drawing.Point(150, 124)
        Me.cboDonVi_CTPN.Name = "cboDonVi_CTPN"
        Me.cboDonVi_CTPN.Size = New System.Drawing.Size(126, 23)
        Me.cboDonVi_CTPN.TabIndex = 9
        '
        'frmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1362, 730)
        Me.Controls.Add(Me.TbCtrQuanLy)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TbCtrQuanLy.ResumeLayout(False)
        Me.NhanVien.ResumeLayout(False)
        Me.NhanVien.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HoaDon.ResumeLayout(False)
        Me.gbxChiTietHoaDon.ResumeLayout(False)
        Me.gbxChiTietHoaDon.PerformLayout()
        CType(Me.dgvCTHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxHoaDon.ResumeLayout(False)
        Me.gbxHoaDon.PerformLayout()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MonAnDoUong.ResumeLayout(False)
        Me.gbxThongTinChiTietMon.ResumeLayout(False)
        Me.gbxThongTinChiTietMon.PerformLayout()
        CType(Me.dgvCTMon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxThongTinChiTietHoaDon.ResumeLayout(False)
        Me.gbxThongTinChiTietHoaDon.PerformLayout()
        CType(Me.dgvMonAnDoUong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhieuNhap.ResumeLayout(False)
        Me.gpbChiTietPhieuNhap.ResumeLayout(False)
        Me.gpbChiTietPhieuNhap.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDanhSachCTPN.ResumeLayout(False)
        Me.gpbDanhSachCTPN.PerformLayout()
        CType(Me.dgvChiTietPhieuNhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ChucVu_LoaiDonViTinh.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgvChucVu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.dgvChucVuNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMaNV As System.Windows.Forms.Label
    Friend WithEvents lblHoTen As System.Windows.Forms.Label
    Friend WithEvents lblThoiGianBD As System.Windows.Forms.Label
    Friend WithEvents btnThemNV As System.Windows.Forms.Button
    Friend WithEvents btnSuaNV As System.Windows.Forms.Button
    Friend WithEvents btnXoaNV As System.Windows.Forms.Button
    Friend WithEvents TbCtrQuanLy As System.Windows.Forms.TabControl
    Friend WithEvents NhanVien As System.Windows.Forms.TabPage
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtcmnd As System.Windows.Forms.TextBox
    Friend WithEvents lblCMND As System.Windows.Forms.Label
    Friend WithEvents lblNgaySinh As System.Windows.Forms.Label
    Friend WithEvents lblLoaiNV As System.Windows.Forms.Label
    Friend WithEvents lblTenChucVu As System.Windows.Forms.Label
    Friend WithEvents dtpThoiGianBD As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboLoaiNV As System.Windows.Forms.ComboBox
    Friend WithEvents dgvNhanVien As System.Windows.Forms.DataGridView
    Friend WithEvents txtTimKiem_NhanVien As System.Windows.Forms.TextBox
    Friend WithEvents btnTimKiemNV As System.Windows.Forms.Button
    Friend WithEvents dtpNgaySinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoDangLam As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDaNghi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNu As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNam As System.Windows.Forms.RadioButton
    Friend WithEvents cboTenChucVu As System.Windows.Forms.ComboBox
    Friend WithEvents HoaDon As System.Windows.Forms.TabPage
    Friend WithEvents btnTimKiem_HoaDon As System.Windows.Forms.Button
    Friend WithEvents btnXoa_HoaDon As System.Windows.Forms.Button
    Friend WithEvents dgvHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents dtpThoiGian_HoaDon As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTimKiem_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChu_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLuongKhach_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtSoBan_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents lblTenNhanVien As System.Windows.Forms.Label
    Friend WithEvents lblGhiChu As System.Windows.Forms.Label
    Friend WithEvents lblSoLuongKhach As System.Windows.Forms.Label
    Friend WithEvents lblTongTien As System.Windows.Forms.Label
    Friend WithEvents lblSoBan As System.Windows.Forms.Label
    Friend WithEvents lblThoiGian As System.Windows.Forms.Label
    Friend WithEvents lblMaDatMon As System.Windows.Forms.Label
    Friend WithEvents MonAnDoUong As System.Windows.Forms.TabPage
    Friend WithEvents gbxHoaDon As System.Windows.Forms.GroupBox
    Friend WithEvents gbxChiTietHoaDon As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCTHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents txtSoLuong_CTHD As System.Windows.Forms.TextBox
    Friend WithEvents btnTimKiem_CTHD As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MaHoaDon_CTHD As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien_CTHD As System.Windows.Forms.TextBox
    Friend WithEvents txtTenMon_CTHD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnXoa_CTHD As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTimKiem_CTHD As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChuCTHoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaMotMon_CTHD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbxThongTinChiTietHoaDon As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMonAnDoUong As System.Windows.Forms.DataGridView
    Friend WithEvents txtTimKiem_Mon As System.Windows.Forms.TextBox
    Friend WithEvents btnTimKiem_Mon As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnThem_Mon As System.Windows.Forms.Button
    Friend WithEvents txtTenMon_Mon As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaHienTai_Mon As System.Windows.Forms.TextBox
    Friend WithEvents btnXoa_Mon As System.Windows.Forms.Button
    Friend WithEvents btnSua_Mon As System.Windows.Forms.Button
    Friend WithEvents txtMaHoaDonChung_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHoaDon_HoaDon As System.Windows.Forms.TextBox
    Friend WithEvents gbxThongTinChiTietMon As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCTMon As System.Windows.Forms.DataGridView
    Friend WithEvents txtTimKiem_CTMon As System.Windows.Forms.TextBox
    Friend WithEvents btnTim_CTMon As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnXoa_CTMon As System.Windows.Forms.Button
    Friend WithEvents btnSua_CTMon As System.Windows.Forms.Button
    Friend WithEvents btnThem_CTMon As System.Windows.Forms.Button
    Friend WithEvents txtSoLuong_CTMon As System.Windows.Forms.TextBox
    Friend WithEvents txtTenMon_CTMon As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP_CTMon As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboThucDonMon_Mon As System.Windows.Forms.ComboBox
    Friend WithEvents cboDonVi_CTMon As System.Windows.Forms.ComboBox
    Friend WithEvents cboDaThanhToan_HoaDon As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider4 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboLoai_MADU As System.Windows.Forms.ComboBox
    Friend WithEvents PhieuNhap As System.Windows.Forms.TabPage
    Friend WithEvents gpbDanhSachCTPN As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPhieuNhap As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTinhTrang_PhieuNhap As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimKiem_PhieuNhap As System.Windows.Forms.TextBox
    Friend WithEvents btnTimKiem_PhieuNhap As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnXoa_PhieuNhap As System.Windows.Forms.Button
    Friend WithEvents btnSua_PhieuNhap As System.Windows.Forms.Button
    Friend WithEvents btnThem_PhieuNhap As System.Windows.Forms.Button
    Friend WithEvents txtTenNCC_PN As System.Windows.Forms.TextBox
    Friend WithEvents txtTongTien_PhieuNhap As System.Windows.Forms.TextBox
    Friend WithEvents MaMon_CTM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMon_CTMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSP_CTM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSP_CTMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuong_CTMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonVi_CTMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaDonVi_MKHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaMon_MADU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiaTienHienTai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThucDonMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Loai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoTen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThoiGianBatDau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgaySinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioiTinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoaiNhanVien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenChucVu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaChucVu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnThongKe_PhieuNhap As System.Windows.Forms.Button
    Friend WithEvents dtpNgayLap As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents gpbChiTietPhieuNhap As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNV_PN As System.Windows.Forms.TextBox
    Friend WithEvents MaHoaDon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMon_CTHD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiaMotMon_CTHD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaChiTiet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GhiChu_CTHD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TongTien_CTHD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaMon_CTHD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaHoaDon_HD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaNV_HD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenNhanVien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThoiGian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoBan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuongKhach As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaHoaDonChung_HD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TongTien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DaThanhToan_HD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnSua_CTPN As System.Windows.Forms.Button
    Friend WithEvents btnXoa_CTPN As System.Windows.Forms.Button
    Friend WithEvents btnThem_CTPN As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtSoLuong_CTPN As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTenSP_CTPN As System.Windows.Forms.TextBox
    Friend WithEvents txtMaPN_CTPN As System.Windows.Forms.TextBox
    Friend WithEvents dgvChiTietPhieuNhap As System.Windows.Forms.DataGridView
    Friend WithEvents btnTim_CTPN As System.Windows.Forms.Button
    Friend WithEvents txtTim_CTPN As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtThanhTIen_CTPN As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia_CTPN As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents MaPN_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaNCC_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenNCC_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaNV_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenNV_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayLap_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayGiaoDK_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TongTien_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinhTrang_PN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaPN_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaSP_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSP_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuong_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaDV_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenDV_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGia_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThanhTien_CTPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChucVu_LoaiDonViTinh As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents dgvChucVuNV As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btnXoa_ChucVu As System.Windows.Forms.Button
    Friend WithEvents btnSua_ChucVu As System.Windows.Forms.Button
    Friend WithEvents btnThem_ChucVu As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvChucVu As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSua_LoaiDV As System.Windows.Forms.Button
    Friend WithEvents btnXoa_LoaiDV As System.Windows.Forms.Button
    Friend WithEvents btnThem_LoaiDV As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaDV_LDVT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenDV_LDVT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoTangMacDinh_LDVT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpNgayGiaoDK As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboDonVi_CTPN As System.Windows.Forms.ComboBox

End Class
