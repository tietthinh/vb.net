'=====================================================================
'Name:      Lưu Thế Nguyên
'Project:   Restaurant Management
'Purpose:   Mangager Form 
'=====================================================================


Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Imports Library
Imports System.Globalization
Imports System.Exception

Public Class frmManager

    Dim _location As Integer
    Private _connect As New Library.DatabaseConnection()
    'Fields:
    ''' <summary>
    ''' If Password Textbox is null then true, else false.
    ''' </summary>
    ''' <remarks></remarks>
    Private _IsPWNull As Boolean

    ''' <summary>
    ''' If Identity Textbox is null then true, else false.
    ''' </summary>
    ''' <remarks></remarks>
    Private _IsIDNull As Boolean

    Private _ReturnUser As User

    'Bảng Nhân Viên
    ''' <summary>
    '''  Load dữ liệu bảng nhân viên
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadNV()
        dgvNhanVien.Rows.Clear()
        '_connect.query("Select MaNV, ")
        '_ParameterInput = {New SqlParameter("@MaMon", a), New SqlParameter("@SoLuong", b),_
        '                   New SqlParameter("@TinhTrang", c), New SqlParameter("@GhiChu", d), New SqlParameter("@SoBan", e1)}

        'Dim Connection As New Library.DatabaseConnection
        'Connection.Open()
        Dim Table As New DataTable
        Table = _connect.Query("Select NV.MaNV, NV.HoTen, NV.TGBatDau, NV.cmnd, NV.TinhTrang, NV.NgaySinh, NV.GioiTinh, NV.LoaiNhanVien, CV.TenChucVu, CV.MaChucVu  From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu ")
        'dgvNhanVien.DataSource = Table
        For Each dt As DataRow In Table.Rows
            Dim LoaiNV As String = ""
            If dt(7).ToString = "True" Then
                LoaiNV = "Fulltime"
            Else
                LoaiNV = "Parttime"
            End If
            Dim TinhTrangNV As String = ""
            If dt(4).ToString = "True" Then
                TinhTrangNV = "Đã Nghỉ"
            Else
                TinhTrangNV = "Đang Làm"
            End If

            dgvNhanVien.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2), dt(3).ToString, TinhTrangNV, dt(5), dt(6).ToString, LoaiNV, dt(8).ToString, dt(9).ToString})
        Next

        Dim table1 As New DataTable
        table1 = _connect.Query("Select distinct NV.LoaiNhanVien, NV.MaNV From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu")
        'cboLoaiNV.DataSource = table1
        'cboLoaiNV.DisplayMember = "LoaiNhanVien"
        'cboLoaiNV.ValueMember = "MaNV"

        cboLoaiNV.Items.Insert(0, "Parttime")
        cboLoaiNV.Items.Insert(1, "Fulltime")
        cboLoaiNV.SelectedIndex = 0


        Dim table2 As New DataTable
        table2 = _connect.Query("Select distinct CV.TenChucVu, CV.MaChucVu From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu")
        cboTenChucVu.DataSource = table2
        cboTenChucVu.DisplayMember = "TenChucVu"
        cboTenChucVu.ValueMember = "MaChucVu"

    End Sub
    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _connect.Open()
            LoadNV()
        Catch ex As SqlException
            _connect.Close()
            Throw ex
        End Try
    End Sub
    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click

        If txtTen.Text.Length = 0 Then

            ErrorProvider2.SetError(txtTen, "Bạn chưa nhập Tên Nhân Viên.")

        End If

        Dim _cmnd As String = txtcmnd.Text
        If _cmnd.Trim.Length = 0 Or _cmnd.Trim.Length <> 9 Or IsNumeric(_cmnd) = False Then

            ErrorProvider3.SetError(txtcmnd, "Thông tinh CMND của Nhân Viên phải là 9 số.")

        End If


        'dgvNhanVien.Items.Add(New ListViewItem(New String() {TxtMSSV.Text, txtTen.Text, TxtDT.Text, TxtLop.Text, TxtDC.Text}))
        Dim _tinhtrang As String = ""

        If rdoDaNghi.Checked = True Then
            _tinhtrang = True
        End If
        If rdoDangLam.Checked = True Then
            _tinhtrang = False
        End If

        Dim _gioitinh As String = ""
        If rdoNam.Checked = True Then
            _gioitinh = "Nam"
        End If
        If rdoNu.Checked = True Then
            _gioitinh = "Nữ"
        End If
        Dim _query As String = ""
        Try
            MessageBox.Show("Bạn muốn thực hiện thao tác thêm?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult.OK Then

                '_connect.Open()
                _query = "Insert into NhanVien(MaNV, TGBatDau, cmnd, HoTen, TinhTrang, NgaySinh, GioiTinh, LoaiNhanVien, MaChucVu) values('NV0031'," + "'" + dtpThoiGianBD.Value.ToString("yyyy-MM-dd") + "','" +
                    txtcmnd.Text.ToString + "', N'" + txtTen.Text.ToString + "','" + _tinhtrang + "','" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "','" + _gioitinh + "','" +
                    cboLoaiNV.SelectedIndex.ToString + "','" + cboTenChucVu.SelectedValue.ToString + "')"
                _connect.Query(_query)
                '_connect.Close()
            End If
        Catch ex As SqlException
            MessageBox.Show("Dữ liệu nhập sai!")
        End Try
        Dim count As Integer = dgvNhanVien.Rows.Count()
        LoadNV()
        Dim count2 As Integer = dgvNhanVien.Rows.Count()
        If count < count2 Then
            MessageBox.Show("Thêm Thành Công", "Thông Báo")
        End If

    End Sub
    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click

        MessageBox.Show("Bạn muốn thực hiện thao tác sửa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

        If DialogResult.OK Then

            Dim TEMP As Boolean = dgvNhanVien.Rows(0).Displayed

            If txtTen.Text.Length = 0 Then

                ErrorProvider2.SetError(txtTen, "Bạn chưa nhập Tên Nhân Viên.")

            End If
            Dim _cmnd As String = txtcmnd.Text
            If _cmnd.Trim.Length = 0 Then

                ErrorProvider3.SetError(txtcmnd, "Bạn chưa nhập CMND của Nhân Viên.")

            End If

            'dgvNhanVien.Items.Add(New ListViewItem(New String() {TxtMSSV.Text, txtTen.Text, TxtDT.Text, TxtLop.Text, TxtDC.Text}))
            Dim _tinhtrang As String = ""

            If rdoDaNghi.Checked = True Then
                _tinhtrang = True
            End If
            If rdoDangLam.Checked = True Then
                _tinhtrang = False
            End If

            Dim _gioitinh As String = ""
            If rdoNam.Checked = True Then
                _gioitinh = "Nam"
            End If
            If rdoNu.Checked = True Then
                _gioitinh = "Nữ"
            End If
            Dim _query As String = ""
            Try
                '_connect.Open()
                _query = "Update NhanVien Set TGBatDau='" +
                    dtpThoiGianBD.Value.ToString("yyyy-MM-dd") + "',cmnd ='" +
                txtcmnd.Text.ToString.Trim + "', HoTen = N'" + txtTen.Text.ToString.Trim + "', TinhTrang = '" + _tinhtrang + "', NgaySinh = '" +
                dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', GioiTinh = '" + _gioitinh + "', LoaiNhanVien = '" +
                cboLoaiNV.SelectedIndex.ToString + "', MaChucVu = '" + cboTenChucVu.SelectedValue.ToString.Trim + "'" + "Where MaNV ='" +
                 txtMaNV.Text.Trim + "'"
                _connect.Query(_query)
                '_connect.Close()
            Catch ex As Exception
                MessageBox.Show("Sửa thành công", "Thông báo")
                Throw ex
            End Try
        End If



        LoadNV()
        dgvNhanVien.Rows(_location).Selected = True
        ''-------------------------------------------------------------------------------------Hien Thi dong da sua--------------------------------------------------------
    End Sub
    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click
        MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

        If DialogResult.OK Then

            Dim _query As String = ""
            '_connect.Open()
            Dim _tinhtrang As String = ""




            If rdoDaNghi.Checked = True Then
                _tinhtrang = True
            End If
            If rdoDangLam.Checked = True Then
                _tinhtrang = False
            End If

            Dim _gioitinh As String = ""
            If rdoNam.Checked = True Then
                _gioitinh = "Nam"
            End If
            If rdoNu.Checked = True Then
                _gioitinh = "Nữ"
            End If
            Dim _word As String = txtMaNV.Text
            _query = "Delete From NhanVien Where MaNV ='" + _word + "'"
            _connect.Query(_query)
            '_connect.Close()

            txtMaNV.Text = ""
            txtTen.Text = ""
            txtcmnd.Text = ""
            txtTimKiem_NhanVien.Text = ""

            LoadNV()

            Dim Table As New DataTable
            Dim kq As Boolean = False
            Table = _connect.Query("Select NV.MaNV  From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu ")
            For Each dt As DataRow In Table.Rows
                If (_word <> dt("MaNV").ToString) Then
                    kq = True
                End If
            Next

            If (kq = True) Then
                MessageBox.Show("Xóa Thành Công", "Thông Báo")
            End If


        End If
    End Sub
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiemNV.Click

        If txtTimKiem_NhanVien.Text.Trim.Count = 0 Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        End If

        Dim kq As Boolean = False
        Dim Table As New DataTable

        Table = _connect.Query("Select NV.MaNV  From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu ")

        Dim _word As String = txtMaNV.Text

        For Each dt As DataRow In Table.Rows
            If (_word <> dt("MaNV").ToString) Then
                kq = True
            End If
        Next

        If (kq = True) Then
            MessageBox.Show("Xóa Thành Công", "Thông Báo")
        End If


        'query = "Delete From NhanVien Where TGBatDau ='" + txtTimKiem_NhanVien.Text.Trim + "' OR cmnd ='" +
        'txtTimKiem_NhanVien.Text.Trim + "'OR HoTen = N'" + txtTimKiem_NhanVien.Text.Trim + "' OR TinhTrang = '" + txtTimKiem_NhanVien.Text.Trim + "'OR NgaySinh = '" +
        'txtTimKiem_NhanVien.Text.Trim("yyyy-MM-dd") + "'OR GioiTinh = '" + txtTimKiem_NhanVien.Text.Trim + "'OR LoaiNhanVien = '" +
        'txtTimKiem_NhanVien.Text.Trim + "'OR MaChucVu = '" + txtTimKiem_NhanVien.Text.Trim + "'" + "Where MaNV ='" +
        'txtTimKiem_NhanVien.Text.Trim + "'"
        '_connect.query(query)
        '_connect.Close()

    End Sub
    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        Dim ds As DataTable
        'Dim row As DataRow = ds.Select("HoTen = " + dgvNhanVien(0, dgvNhanVien.CurrentCell.RowIndex).Value)(0)
        _location = e.RowIndex
        If e.RowIndex = dgvNhanVien.Rows.Count - 1 Then
            Return
        End If

        If e.RowIndex > 0 Then
            txtMaNV.Text = dgvNhanVien.Rows(e.RowIndex).Cells("MaNV").Value.ToString()
            txtcmnd.Text = dgvNhanVien.Rows(e.RowIndex).Cells("CMND").Value.ToString()
            dtpNgaySinh.Text = dgvNhanVien.Rows(e.RowIndex).Cells("NgaySinh").Value.ToString()
            Dim LoaiNV As String = ""
            cboLoaiNV.Text = dgvNhanVien.Rows(e.RowIndex).Cells("LoaiNhanVien").Value.ToString
            If LoaiNV = "True" Then
                cboLoaiNV.SelectedIndex = 1
            Else
                cboLoaiNV.SelectedIndex = 0
            End If
            txtTen.Text = dgvNhanVien.Rows(e.RowIndex).Cells("HoTen").Value.ToString()

            If GioiTinh.ToString = "Nam" Then
                rdoNam.Checked = True
            Else
                rdoNu.Checked = True
            End If

            If TinhTrang.ToString = "Đã Nghỉ" Then
                rdoDaNghi.Checked = True
            Else
                rdoDangLam.Checked = True
            End If

            cboLoaiNV.SelectedValue = dgvNhanVien.Rows(e.RowIndex).Cells("LoaiNhanVien").Value
            cboTenChucVu.SelectedValue = dgvNhanVien.Rows(e.RowIndex).Cells("MaChucVu").Value
            dtpNgaySinh.Value = dgvNhanVien.Rows(e.RowIndex).Cells("NgaySinh").Value.ToString

            If dgvNhanVien.Rows(e.RowIndex).Cells("GioiTinh").Value.ToString = "Nam" Then
                rdoNam.Checked = True

            Else
                rdoNu.Checked = True
            End If

            If dgvNhanVien.Rows(e.RowIndex).Cells("TinhTrang").Value.ToString = "Đã Nghỉ" Then
                rdoDaNghi.Checked = True

            Else
                rdoDangLam.Checked = True
            End If
        End If
    End Sub


    'Bảng Hóa Đơn
    ''' <summary>
    ''' Load du lieu bang Hoa Don
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub LoadHoaDon()

        Dim Table As New DataTable
        Table = _connect.Query("Select HD.MaHoaDon, HD.MaNV, NV.HoTen, HD.ThoiGian, HD.SoBan, HD.SoLuongKhach ,HD.MaHDChung, HD.TongTien, HD.GhiChu, HD.TinhTrang From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV ")


        For Each dt As DataRow In Table.Rows
            Dim _TinhTrang As String = ""
            If dt(9).ToString.Trim = "True" Then
                _TinhTrang = "Rồi"
            Else
                _TinhTrang = "Chưa"
            End If
            dgvHoaDon.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString, dt(6).ToString, Double.Parse(dt(7).ToString()).ToString("#,###"), dt(8).ToString, _TinhTrang})
        Next
        'For Each dt As DataGridViewRow In dgvHoaDon.Rows
        '    dt.Cells("TongTien").ToString("#,####")
        'Next


        Dim Table2 As New DataTable
        Table2 = _connect.Query("Select distinct HD.TinhTrang From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV ")
        cboDaThanhToan_HoaDon.DataSource = Table2
        cboDaThanhToan_HoaDon.DisplayMember = "TinhTrang"
        cboDaThanhToan_HoaDon.ValueMember = "TinhTrang"

    End Sub
    Private Sub HoaDon_Enter(sender As Object, e As EventArgs) Handles HoaDon.Enter
        LoadHoaDon()
        LoadCTHoaDon()
    End Sub
    Private Sub dgvHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellClick
        If e.RowIndex = dgvHoaDon.Rows.Count - 1 Then
            Return
        End If

        If e.RowIndex > 0 Then
            txtSoBan_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("SoBan").Value.ToString()
            txtSoLuongKhach_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("SoLuongKhach").Value.ToString()
            txtMaHoaDon_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("MaHoaDon_HD").Value.ToString()
            txtMaHoaDonChung_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("MaHoaDonChung_HD").Value.ToString()
            txtTenNV_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("TenNhanVien").Value.ToString()
            txtGhiChu_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("GhiChu").Value.ToString()
            cboDaThanhToan_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("DaThanhToan_HD").Value.ToString()
            dtpThoiGian_HoaDon.Value = dgvHoaDon.Rows(e.RowIndex).Cells("ThoiGian").Value.ToString()
            txtTongTien_HoaDon.Text = dgvHoaDon.Rows(e.RowIndex).Cells("TongTien").Value.ToString()
        End If

    End Sub
    Private Sub btnTimKiem_HoaDon_Click(sender As Object, e As EventArgs) Handles btnTimKiem_HoaDon.Click
        If txtTimKiem_CTHD.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_HoaDon, "Bạn chưa chọn giá trị.")

        End If
    End Sub
    Private Sub btnXoa_HoaDon_Click(sender As Object, e As EventArgs) Handles btnXoa_HoaDon.Click

        Dim _query As String = ""

        Dim _word As String = txtMaHoaDon_HoaDon.Text
        _query = "Delete From HoaDon Where MaHoaDon ='" + _word + "'"
        _connect.Query(_query)
        _connect.Close()
        txtMaHoaDon_HoaDon.Text = ""
        txtSoBan_HoaDon.Text = ""
        txtMaHoaDonChung_HoaDon.Text = ""
        txtTenNV_HoaDon.Text = ""
        txtGhiChu_HoaDon.Text = ""
        txtTongTien_HoaDon.Text = ""
        txtTimKiem_HoaDon.Text = ""

        LoadHoaDon()
        Dim Table As New DataTable
        Dim kq As Boolean = False
        Table = _connect.Query("Select HD.MaHoaDon,HD.MaHDChung From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV ")
        For Each dt As DataRow In Table.Rows
            If (_word <> dt("MaHoaDon").ToString) Then
                kq = True
            End If
        Next
        If (kq = True) Then
            MessageBox.Show("Xóa Thành Công", "Thông Báo")
        End If
        dgvHoaDon.Rows.Clear()

    End Sub
    'Bảng CT Hóa Đơn
    ''' <summary>
    ''' Load du lieu bang CT Hoa Don
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub LoadCTHoaDon()
        Dim Table1 As New DataTable
        Table1 = _connect.Query("Select CTHD.MaHoaDon, MADU.TenMon, CTHD.GiaMotMon, CTHD.GhiChu, CTHD.MaCT, CTHD.SoLuong, CTHD.ThanhTien, MADU.MaMon From ChiTietHoaDon CTHD, MonAnDoUong MADU Where MADU.MaMon = CTHD.MaMon")
        For Each dt As DataRow In Table1.Rows
            dgvCTHoaDon.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString, Double.Parse(dt(6).ToString).ToString("#,###"), dt(7).ToString})
        Next

    End Sub
    Private Sub btnTimKiem_CTHD_Click(sender As Object, e As EventArgs) Handles btnTimKiem_CTHD.Click
        If txtTimKiem_CTHD.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_CTHD, "Bạn chưa chọn Đơn Vị.")

        End If
    End Sub
    Private Sub btnTim_CTMon_Click(sender As Object, e As EventArgs) Handles btnTim_CTMon.Click
        If txtTimKiem_CTMon.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_CTMon, "Bạn chưa chọn Đơn Vị.")

        End If
    End Sub
    Private Sub btnXoa_CTHD_Click(sender As Object, e As EventArgs) Handles btnXoa_CTHD.Click
        Dim _query As String = ""
        _connect.Open()

        Dim _word As String = txtMaHoaDon_HoaDon.Text
        _query = "Delete From ChiTietHoaDon Where MaCT ='" + _word + "'"
        _connect.Query(_query)
        _connect.Close()
        MaHoaDon_CTHD.Text = ""
        txtTenMon_CTHD.Text = ""
        txtSoLuong_CTHD.Text = ""
        txtGiaMotMon_CTHD.Text = ""
        txtGhiChuCTHoaDon.Text = ""
        txtTongTien_CTHD.Text = ""
        txtTimKiem_CTHD.Text = ""

        LoadHoaDon()
        Dim Table As New DataTable
        Dim kq As Boolean = False
        Table = _connect.Query("Select HD.MaHoaDon,HD.MaHDChung From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV ")
        For Each dt As DataRow In Table.Rows
            If (_word <> dt("MaHoaDon").ToString) Then
                kq = True
            End If
        Next
        If (kq = True) Then
            MessageBox.Show("Xóa Thành Công", "Thông Báo")
        End If
        dgvHoaDon.Rows.Clear()
    End Sub
    Private Sub dgvCTHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTHoaDon.CellClick
        If e.RowIndex = dgvCTHoaDon.Rows.Count - 1 Then
            Return
        End If

        If e.RowIndex > 0 Then
            MaHoaDon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("MaHoaDon").Value.ToString()
            txtTenMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("TenMon_CTHD").Value.ToString()
            txtSoLuong_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("SoLuong").Value.ToString()
            txtGiaMotMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GiaMotMon_CTHD").Value.ToString()
            txtGhiChuCTHoaDon.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GhiChu_CTHD").Value.ToString()
            txtTongTien_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("TongTien_CTHD").Value.ToString()
        End If
    End Sub


    Private Sub LoadMonAnDoUong()
        Dim _Table As New DataTable
        _Table = _connect.Query("Select MaMon, TenMon, GiaTienHienTai, ThucDonMon From MonAnDoUong ")

           

        For Each dt As DataRow In _Table.Rows
            Dim arrayString() As String = New String(1) {}
            arrayString = Library.StringSplit(dt(0), 2)
            Dim _Loai As String = ""

            If arrayString(0) = "DA" Then
                _Loai = "Đồ Ăn"
            Else
                _Loai = "Đồ Uống"
            End If
            Dim _Thucdon As String = ""
            If dt(3).ToString = "True" Then
                _Thucdon = "Có"

            Else
                _Thucdon = "Không"
            End If

            dgvMonAnDoUong.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, Double.Parse(dt(2).ToString).ToString("#,###"), _Thucdon, _Loai})
        Next

        'Dim _Table1 As New DataTable
        '_Table1 = _connect.Query("Select distinct ThucDonMon From MonAnDoUong")
        'cboThucDonMon_Mon.DataSource = _Table1
        'cboThucDonMon_Mon.DisplayMember = "ThucDonMon"
        'cboThucDonMon_Mon.ValueMember = "ThucDonMon"

        cboThucDonMon_Mon.SelectedIndex = 0
    End Sub

    Private Sub LoadCTMonAnDoUong()
        Dim Table As New DataTable
        Table = _connect.Query("Select CTLM.MaMon, MADU.TenMon, CTLM.MaSP, SP.TenSP, CTLM.SoLuong, LDVT.TenDV, CTLM.MaDV From ChiTietLamMon CTLM, MonAnDoUong MADU, SanPham SP, LoaiDonViTinh LDVT Where CTLM.MaMon = MADU.MaMon and CTLM.MaSP = SP.MaSP and CTLM.MaDV = LDVT.MaDV")
        
        For Each dt As DataRow In Table.Rows
            dgvCTMon.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString, dt(6).ToString})
        Next
        Dim _Table1 As New DataTable
        _Table1 = _connect.Query("Select LDVT.TenDV, LDVT.MaDV From LoaiDonViTinh LDVT")
        cboDonVi_CTMon.DataSource = _Table1
        cboDonVi_CTMon.DisplayMember = "TenDV"
        cboDonVi_CTMon.ValueMember = "MaDV"
        cboDonVi_CTMon.SelectedIndex = 0

    End Sub

    'Bảng Món Ăn Đồ Uống
    Private Sub MonAnDoUong_Enter(sender As Object, e As EventArgs) Handles MonAnDoUong.Enter
        'Dim dsMonAnDoUong As DataTable
        'dsMonAnDoUong = _connect.Query("Select MaMon, TenMon, GiaTienHienTai, ThucDonMon From MonAnDoUong")
        'dgvMonAnDoUong.DataSource = dsMonAnDoUong

        LoadMonAnDoUong()
        LoadCTMonAnDoUong()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem_Mon.Click
        If txtTenMon_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtTenMon_Mon, "Bạn chưa nhập Tên Món.")

        End If

        If txtGiaHienTai_Mon.Text.Length = 0 Then

            ErrorProvider2.SetError(txtGiaHienTai_Mon, "Bạn chưa nhập Giá Món.")

        End If

        If cboThucDonMon_Mon.Text.Length = 0 Then

            ErrorProvider3.SetError(cboThucDonMon_Mon, "Bạn chưa chọn tình trạng cho thực đơn món.")

        End If

        Try

        Catch ex As Exception
            MessageBox.Show("Dữ liệu nhập sai!", "Thông Báo")
        End Try

        txtTenMon_Mon.Text = ""
        txtGiaHienTai_Mon.Text = ""


        'Dim count As Integer = dgvNhanVien.Rows.Count()
        'LoadNV()
        'Dim count2 As Integer = dgvNhanVien.Rows.Count()
        'If count < count2 Then
        '    MessageBox.Show("Thêm Thành Công", "Thông Báo")
        'End If
    End Sub
    Private Sub btnTimKiem_Mon_Click(sender As Object, e As EventArgs) Handles btnTimKiem_Mon.Click
        If txtTimKiem_Mon.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_Mon, "Bạn chưa chọn Đơn Vị.")

        End If
    End Sub
    Private Sub dgvMonAnDoUong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMonAnDoUong.CellClick
        If e.RowIndex = dgvMonAnDoUong.Rows.Count - 1 Then
            Return
        End If

        If e.RowIndex > 0 Then
            txtTenMon_Mon.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("TenMon").Value.ToString()
            txtGiaHienTai_Mon.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("GiaTienHienTai").Value
            cboThucDonMon_Mon.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("ThucDonMon").Value.ToString()
            cboLoai_MADU.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("Loai").Value.ToString()
        End If

    End Sub
    Private Sub dgvCTMon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTMon.CellClick
        If e.RowIndex = dgvCTMon.Rows.Count - 1 Then
            Return
        End If

        If e.RowIndex > 0 Then
            txtTenMon_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("TenMon_CTMon").Value.ToString()
            txtTenSP_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("TenSP_CTMon").Value.ToString()
            txtSoLuong_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("SoLuong_CTMon").Value.ToString()
            cboDonVi_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("DonVi_CTMon").Value.ToString()
        End If
    End Sub
    Private Sub btnThem_CTMon_Click(sender As Object, e As EventArgs) Handles btnThem_CTMon.Click
        If txtTenMon_CTMon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtTenMon_CTMon, "Bạn chưa nhập Tên Món.")

        End If

        If txtTenSP_CTMon.Text.Length = 0 Then

            ErrorProvider2.SetError(txtTenSP_CTMon, "Bạn chưa nhập Tên Sản Phẩm.")

        End If

        If txtSoLuong_CTMon.Text.Length = 0 Or IsNumeric(txtSoLuong_CTMon.Text) = False Then

            ErrorProvider3.SetError(txtSoLuong_CTMon, "Bạn chưa nhập Số Lượng.")

        End If

        If cboDonVi_CTMon.Text.Length = 0 Then
            ErrorProvider4.SetError(cboDonVi_CTMon, "Bạn chưa chọn Đơn Vị.")

        End If

        Dim _TDMon As Boolean
        If cboThucDonMon_Mon.SelectedItem.ToString = "Có" Then
            _TDMon = True
        Else
            _TDMon = False
        End If

        txtTenMon_CTHD.Text = ""
        txtTenSP_CTMon.Text = ""
        txtSoLuong_CTMon.Text = ""
    End Sub




    'Bảng Phiếu Nhập
    Private Sub PhieuNhap_Enter(sender As Object, e As EventArgs) Handles PhieuNhap.Enter
        'Dim dsMonAnDoUong As DataTable
        'dsMonAnDoUong = _connect.Query("Select MaMon, TenMon, GiaTienHienTai, ThucDonMon From MonAnDoUong")
        'dgvMonAnDoUong.DataSource = dsMonAnDoUong

        'LoadMonAnDoUong()
        'LoadCTMonAnDoUong()
    End Sub
    Private Sub btnThem_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnThem_PhieuNhap.Click

        If txtTenNV_PN.Text = "" Then
            ErrorProvider1.SetError(txtTenNV_PN, "Tên nhân viên không được để trống")
        End If

        If txtTenNCC_PN.Text = "" Then
            ErrorProvider1.SetError(txtTenNCC_PN, "Tên nhà cung cấp không được để trống")
        End If

        'Try

        'Catch ex As Exception
        '    MessageBox.Show("Dữ liệu nhập sai!", "Thông Báo")
        'End Try

        'Dim count As Integer = dgvPhieuNhap.Rows.Count()
        ''LoadNV()
        'Dim count2 As Integer = dgvPhieuNhap.Rows.Count()

        'If count < count2 Then
        '    MessageBox.Show("Thêm Thành Công", "Thông Báo")
        'End If

        txtMaPN_CTPN.Text = ""
        txtTenNV_PN.Text = ""
        txtTenNCC_PN.Text = ""
        txtTongTien_CTHD.Text = ""
    End Sub
    'Bảng Chi Tiết Phiếu Nhập
    Private Sub btnThongKe_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnThongKe_PhieuNhap.Click
        gpbDanhSachCTPN.Enabled = True
        gpbChiTietPhieuNhap.Enabled = True

    End Sub
    Private Sub btnThem_CTPN_Click(sender As Object, e As EventArgs) Handles btnThem_CTPN.Click

        If txtTenSP_CTPN.Text = "" Then
            MessageBox.Show(txtTenSP_CTPN, "Tên sản phẩm không được để trống")
        End If

        If txtSoLuong_CTHD.Text = "" Then
            MessageBox.Show(txtSoLuong_CTHD, "Số lượng không được để trống")
        End If

        If txtDonGia_CTPN.Text = "" Then
            MessageBox.Show(txtDonGia_CTPN, "Đơn giá không được để trống")
        End If

        If txtThanhTIen_CTPN.Text = "" Then
            MessageBox.Show(txtThanhTIen_CTPN, "Thành tiền không được để trống")
        End If

        'Try

        'Catch ex As Exception
        '    MessageBox.Show("Dữ liệu nhập sai!", "Thông Báo")
        'End Try

        'Dim count As Integer = dgvPhieuNhap.Rows.Count()
        ''LoadNV()
        'Dim count2 As Integer = dgvPhieuNhap.Rows.Count()

        'If count < count2 Then
        '    MessageBox.Show("Thêm Thành Công", "Thông Báo")
        'End If
        txtMaPN_CTPN.Text = ""
        txtTenSP_CTPN.Text = ""
        txtSoLuong_CTHD.Text = ""
        txtDonGia_CTPN.Text = ""
        txtThanhTIen_CTPN.Text = ""
    End Sub

    'Bảng Chức Vụ - LoạiNV
    Private Sub ChucVu_LoaiDonViTinh_Enter(sender As Object, e As EventArgs) Handles ChucVu_LoaiDonViTinh.Enter
        'Dim dsMonAnDoUong As DataTable
        'dsMonAnDoUong = _connect.Query("Select MaMon, TenMon, GiaTienHienTai, ThucDonMon From MonAnDoUong")
        'dgvMonAnDoUong.DataSource = dsMonAnDoUong

        'LoadMonAnDoUong()
        'LoadCTMonAnDoUong()
    End Sub
    Private Sub btnThem_LoaiDV_Click(sender As Object, e As EventArgs) Handles btnThem_LoaiDV.Click
        'Dim count As Integer = dgvNhanVien.Rows.Count()
        'LoadNV()
        'Dim count2 As Integer = dgvNhanVien.Rows.Count()
        'If count < count2 Then
        '    MessageBox.Show("Thêm Thành Công", "Thông Báo")
        'End If
        
    End Sub




    Private Sub TextBoxSearch_Enter(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.Enter, txtTimKiem_CTHD.Enter, _
       txtTimKiem_CTMon.Enter, txtTim_CTPN.Enter, txtTimKiem_HoaDon.Enter, txtTimKiem_NhanVien.Enter, txtTimKiem_PhieuNhap.Enter
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        textBox.Text = ""
    End Sub

    Private Sub TextBoxSearch_Leave(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.Leave
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        If textBox.Text = "" Then
            textBox.Text = "Nhập thông tin cần tìm vào đây"
        End If
    End Sub

    Private Sub frmManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _connect.Close()
        _connect.Dispose()
    End Sub
    
End Class
