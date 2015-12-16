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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblThoiGianBD.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtTongTien_HoaDon.TextChanged, txtTongTien_CTHD.TextChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpThoiGian_HoaDon.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpThoiGianBD.ValueChanged, dtpNgaySinh.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoaiNV.SelectedIndexChanged, cboTenChucVu.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblMaDatMon.Click, Label7.Click

    End Sub

    Private Sub btnXoaDM_Click(sender As Object, e As EventArgs) Handles btnXoa_HoaDon.Click, btnTimKiem_HoaDon.Click, btnTimKiem_CTHD.Click, btnXoa_CTHD.Click

    End Sub

    Private Sub lblThoiGian_Click(sender As Object, e As EventArgs) Handles lblThoiGian.Click

    End Sub

    Private Sub lblSoBanChung_Click(sender As Object, e As EventArgs) Handles lblSoBan.Click

    End Sub

    Private Sub lblTongTien_Click(sender As Object, e As EventArgs) Handles lblTongTien.Click, Label4.Click

    End Sub

    Private Sub lblSoLuongKhach_Click(sender As Object, e As EventArgs) Handles lblSoLuongKhach.Click, Label2.Click

    End Sub

    Private Sub lblGhiChu_Click(sender As Object, e As EventArgs) Handles lblGhiChu.Click, Label5.Click, Label9.Click, Label8.Click, Label3.Click

    End Sub

    Private Sub lblTenNhanVien_Click(sender As Object, e As EventArgs) Handles lblTenNhanVien.Click, Label6.Click

    End Sub

    Private Sub txtMaDatMon_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSoBanChung_TextChanged(sender As Object, e As EventArgs) Handles txtSoBanChung_HoaDon.TextChanged, txtMaHoaDon_HoaDon.TextChanged

    End Sub

    Private Sub txtSoLuongKhach_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuongKhach_HoaDon.TextChanged, MaHoaDon_CTHD.TextChanged, txtMaHoaDonChung_HoaDon.TextChanged

    End Sub

    Private Sub txtTenNV_TextChanged(sender As Object, e As EventArgs) Handles txtTenNV_HoaDon.TextChanged, txtMaMon_CTHD.TextChanged

    End Sub

    Private Sub txtGhiChu_TextChanged(sender As Object, e As EventArgs) Handles txtGhiChu_HoaDon.TextChanged, txtTimKiem_HoaDon.TextChanged, txtSoLuong_CTHD.TextChanged, txtMaCT_CTHoaDon.TextChanged, txtGhiChuCTHoaDon.TextChanged, txtTimKiem_CTHD.TextChanged, txtGiaMotMon_CTHD.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellContentClick, dgvCTHoaDon.CellContentClick

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles DatMon.Click
        _connect.Open()
        Dim Table As New DataTable
        Table = _connect.Query("Select HD.MaHDChung, HD.SoBan, HD.SoLuongKhach, NV.TenNV, HD.GhiChu, HD.TinhTrang, HD.ThoiGian, HD.TongTien From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV ")
        dgvHoaDon.DataSource = Table
        dgvHoaDon.Columns("TongTien").DefaultCellStyle.Format = "#,###"

        Dim Table1 As New DataTable
        Table1 = _connect.Query("Select HD.MaHDChung, HD.SoBan, HD.SoLuongKhach, NV.TenNV, HD.GhiChu, HD.TinhTrang, HD.ThoiGian, HD.TongTien From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV")
        dgvCTHoaDon.DataSource = Table1
        dgvCTHoaDon.Columns("TongTien").DefaultCellStyle.Format = "#,###"

        _connect.Close()
    End Sub

    Private Sub dtgNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellContentClick

    End Sub

    Private Sub lblCMND_Click(sender As Object, e As EventArgs) Handles lblCMND.Click

    End Sub

    Private Sub lblLoaiNV_Click(sender As Object, e As EventArgs) Handles lblLoaiNV.Click

    End Sub

    Private Sub lblTenChucVu_Click(sender As Object, e As EventArgs) Handles lblTenChucVu.Click

    End Sub

    Private Sub lblNgaySinh_Click(sender As Object, e As EventArgs) Handles lblNgaySinh.Click

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiemNV.Click
        If txtTimKiem_NhanVien.Text.Length = 0 Then

            ErrorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân Viên.")

        End If
    End Sub

    Private Sub txtMaNV_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTen_TextChanged(sender As Object, e As EventArgs) Handles txtTen.TextChanged, txtMaNV.TextChanged

    End Sub

    Private Sub txtcmnd_TextChanged(sender As Object, e As EventArgs) Handles txtcmnd.TextChanged

    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem_NhanVien.TextChanged

    End Sub

    Private Sub rdbNam_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNam.CheckedChanged

    End Sub

    Private Sub rdbNu_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNu.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub rdbDaNghi_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDaNghi.CheckedChanged

    End Sub

    Private Sub rdbDangLam_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDangLam.CheckedChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles NhanVien.Click

    End Sub

    Private Sub TbCtrNhanVien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TbCtrQuanLy.SelectedIndexChanged

    End Sub

    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click

    End Sub

    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click

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

    Private Sub lblHoTen_Click(sender As Object, e As EventArgs) Handles lblHoTen.Click

    End Sub

    Private Sub lblMaNV_Click(sender As Object, e As EventArgs) Handles lblMaNV.Click

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles gbxChiTietHoaDon.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles gbxHoaDon.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles gbxThongTinChiTietHoaDon.Enter, gbxThongTinChiTietMon.Enter

    End Sub

    Private Sub dgvMonAnDoUong_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMonAnDoUong.CellContentClick, DataGridView3.CellContentClick
        

       
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

    Private Sub MonAnDoUong_Click(sender As Object, e As EventArgs) Handles MonAnDoUong.Click
        _connect.Open()

        Dim Table As New DataTable
        Table = _connect.Query("Select MADU.TenMon, MADU.GiaTienHienTai, MADU.ThucDonMon  From MonAnDoUong MADU")
        dgvHoaDon.DataSource = Table

        'Dim Table2 As New DataTable
        'Table2 = Connection.Query("Select MaNCC, TenNCC, ChietKhau, DiaChi, GhiChu From NhaCungCap NCC")
        'dgvDSNhaCungCap.DataSource = Table2
        'Email.DataSource = Connection.Query("Select NCC.MaNCC, NE.Email From NhaCungCap NCC, NhaCungCap_Email NE where NCC.MaNCC = NE.MaNCC")
        'Email.DisplayMember = "Email"
        'Email.ValueMember = "MaNCC"

        Dim Table1 As New DataTable
        Table1 = _connect.Query("Select MADU.TenMon, SP.TenSP, CTLM.SoLuong, LDV.TenDV  From ChiTietLamMon CTLM, MonAnDoUong MADU, SanPham SP, LoaiDonVi LDV Where MADU.MaMon = CTLM.MaMon AND SP.MaSP = CTLM.MaSP AND LDV.MaDV = CTLM.MaDV")
        dgvHoaDon.DataSource = Table1

        Dim Table2 As New DataTable
        Table1 = _connect.Query("Select MADU.TenMon, MHT.SoLuongMon, MHT.NgayLamMon  From LuuTruDanhSachMonAnNhaBepHoanThanh MHT, MonAnDoUong MADU Where MADU.MaMon = MHT.MaMon")
        dgvHoaDon.DataSource = Table1


        Dim Table3 As New DataTable
        Table1 = _connect.Query("Select MADU.TenMon, MKHT.SoLuongMon, MKHT.NgayLamMon From LuuTruDanhSachMonAnSoLuongKHoanThanh MKHT, MonAnDoUong MADU Where MADU.MaMon = MKHT.MaMon")
        dgvHoaDon.DataSource = Table1

        _connect.Close()
    End Sub
End Class
