'=====================================================================
'Name:      Lưu Thế Nguyên
'Project:   Restaurant Management
'Purpose:   Mangager Form 
'=====================================================================


Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Public Class Form1
    Private _connect As New Library.DatabaseConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _connect.Open()
        '_connect.Query("Select MaNV, ")
        '_ParameterInput = {New SqlParameter("@MaMon", a), New SqlParameter("@SoLuong", b),_
        '                   New SqlParameter("@TinhTrang", c), New SqlParameter("@GhiChu", d), New SqlParameter("@SoBan", e1)}

        'Dim Connection As New Library.DatabaseConnection
        'Connection.Open()
        Dim Table As New DataTable
        Table = _connect.Query("Select NV.MaNV, NV.HoTen, NV.TGBatDau, NV.cmnd, NV.TinhTrang, NV.NgaySinh, NV.GioiTinh, NV.LoaiNhanVien, CV.TenChucVu  From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu ")
        dgvNhanVien.DataSource = Table
        _connect.Close()
    End Sub


    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiemNV.Click
        If txtTimKiem_NhanVien.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân Viên.")

        End If
    End Sub


    Private Sub HoaDon_Enter(sender As Object, e As EventArgs) Handles HoaDon.Enter
        _connect.Open()
        Dim Table As New DataTable
        Table = _connect.Query("Select HD.MaHDChung, HD.SoBan, HD.SoLuongKhach, NV.HoTen, HD.MaNV, HD.GhiChu, HD.TinhTrang, HD.ThoiGian, HD.TongTien From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV ")
        dgvHoaDon.DataSource = Table
        dgvHoaDon.Columns("TongTien").DefaultCellStyle.Format = "#,###"

        Dim Table1 As New DataTable
        Table1 = _connect.Query("Select CTHD.MaHoaDon, CTHD.GiaMotMon, CTHD.GhiChu, CTHD.MaCT, MADU.TenMon, CTHD.SoLuong, CTHD.ThanhTien From ChiTietHoaDon CTHD, MonAnDoUong MADU Where MADU.MaMon = CTHD.MaMon")
        dgvCTHoaDon.DataSource = Table1
        dgvCTHoaDon.Columns("TongTien_CTHD").DefaultCellStyle.Format = "#,###"
        dgvCTHoaDon.Columns("GiaMotMon_CTHD").DefaultCellStyle.Format = "#,###"
        _connect.Close()
    End Sub

    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click
        If txtMaNV.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân Viên.")

        End If

        If txtTen.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Tên Nhân Viên.")

        End If

        If txtcmnd.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập CMND của Nhân Viên.")

        End If

    End Sub


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem_Mon.Click
        If txtTenMon_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân Viên.")

        End If

        If txtGiaHienTai_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Tên Nhân Viên.")

        End If

        If txtThucDonMon_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập CMND của Nhân Viên.")

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnThem_CTMon.Click
        If txtTenMon_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân Viên.")

        End If

        If txtGiaHienTai_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Tên Nhân Viên.")

        End If

        If txtThucDonMon_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập CMND của Nhân Viên.")

        End If
    End Sub

    Private Sub MonAnDoUong_Enter(sender As Object, e As EventArgs) Handles MonAnDoUong.Enter
        _connect.Open()

        Dim Table As New DataTable
        Table = _connect.Query("Select TenMon, GiaTienHienTai  From MonAnDoUong ")
        dgvMonAnDoUong.DataSource = Table


        'Table = _connect.Query("Select MaNCC, TenNCC, ChietKhau, DiaChi, GhiChu From NhaCungCap NCC")
        'dgvMonAnDoUong.DataSource = Table
        'Email.DataSource = _connect.Query("Select NCC.MaNCC, NE.Email From NhaCungCap NCC, NhaCungCap_Email NE where NCC.MaNCC = NE.MaNCC")
        'Email.DisplayMember = "Email"
        'Email.ValueMember = "MaNCC"

        ThucDonMon.DataSource = _connect.Query("Select distinct ThucDonMon From MonAnDoUong ")
        'Dim ThucDonMon As DataGridViewComboBoxColumn = dgvMonAnDoUong.Columns("ThucDonMon")
        ThucDonMon.DisplayMember = "ThucDonMon"
        ThucDonMon.ValueMember = "ThucDonMon"

        Dim Table1 As New DataTable
        Table1 = _connect.Query("Select MADU.MaMon, MADU.TenMon, SP.TenSP, CTLM.SoLuong, LDV.TenDV  From ChiTietLamMon CTLM, MonAnDoUong MADU, SanPham SP, LoaiDonViTinh LDV Where MADU.MaMon = CTLM.MaMon AND SP.MaSP = CTLM.MaSP AND LDV.MaDV = CTLM.MaDV")
        dgvCTMon.DataSource = Table1

        Dim Table2 As New DataTable
        Table2 = _connect.Query("Select MADU.TenMon, MHT.SoLuongMon, MHT.NgayLamMon, MHT.MaMon  From LuuTruDanhSachMonAnNhaBepHoanThanh MHT, MonAnDoUong MADU Where MADU.MaMon = MHT.MaMon")
        dgvMonAnNhaBepHoanThanh.DataSource = Table2


        Dim Table3 As New DataTable
        Table3 = _connect.Query("Select MADU.TenMon, MKHT.SoLuongMon, MKHT.NgayLamMon, MADU.MaMon From LuuTruDanhSachMonAnSoLuongKHoanThanh MKHT, MonAnDoUong MADU Where MADU.MaMon = MKHT.MaMon")
        dgvMonAnNhaBepKhongHoanThanh.DataSource = Table3

        _connect.Close()
    End Sub

    Private Sub dgvMonAnDoUong_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMonAnDoUong.CellContentClick

    End Sub

    Private Sub MonAnDoUong_Click(sender As Object, e As EventArgs) Handles MonAnDoUong.Click

    End Sub

    Private Sub dgvNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellContentClick
        Dim ds As DataTable
        Dim row As DataRow = ds.Select("HoTen = " + dgvNhanVien(0, dgvNhanVien.CurrentCell.RowIndex).Value)(0)
        txtTen.Text = row("HoTen")
        txtMaNV.Text = row("MSSV")
        txtcmnd.Text = row("CMND")
        dtpNgaySinh.Text = row("NgaySinh")
        cboLoaiNV.Text = row("Loai")
    End Sub
End Class
