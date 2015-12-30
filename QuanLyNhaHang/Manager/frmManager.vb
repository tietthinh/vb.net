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
    'Khai báo các DataTable
    Dim _TableNhanVien As DataTable = Nothing
    Dim _TableHoaDon As DataTable = Nothing
    Dim _TableCTHoaDon As DataTable = Nothing
    Dim _TableMonAnDoUong As DataTable = Nothing
    Dim _TableCTMonAnDoUong As DataTable = Nothing
    Dim _TablePhieuNhap As DataTable = Nothing
    Dim _TablePhieuNhan As DataTable = Nothing
    Dim _TableCTPhieuNhap As DataTable = Nothing
    Dim _TableCTPhieuNhan As DataTable = Nothing
    Dim _TableChucVu As DataTable = Nothing
    Dim _TableLoaiDV As DataTable = Nothing
    'Khai bóa vị trí cell
    Dim _location As Integer

    'Khai báo mã Sản Phẩm
    Dim _MaSPCu As String = ""
    Dim _MaSPMoi As String = ""

    'Khai báo kết nối
    Private _connect As New DatabaseConnection()

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


    Dim _Query As String = ""
    Dim _ParameterInput As New SqlParameter


    '----------------------------------------------------------------------------------Bảng Nhân Viên---------------------------------------------------------

    ''' <summary>
    '''  Load dữ liệu bảng nhân viên
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            _TableNhanVien = LoadNV(dgvNhanVien)

            cboLoaiNV.Items.Insert(0, "Parttime")
            cboLoaiNV.Items.Insert(1, "Fulltime")
            cboLoaiNV.SelectedIndex = 0


            'ComboBox Khả Năng Vi Tính Nhân Viên
            cboKhaNang_NV.Items.Insert(0, "Word")
            cboKhaNang_NV.Items.Insert(1, "Excel")
            cboKhaNang_NV.Items.Insert(2, "Khác")
            cboKhaNang_NV.SelectedIndex = 0

            Dim _CoboBoxChucVu As New DataTable
            _CoboBoxChucVu = _connect.Query("Select distinct CV.TenChucVu, CV.MaChucVu From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu")

            LoadComboBox(cboTenChucVu, _CoboBoxChucVu, "TenChucVu", "MaChucVu")
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    'Thêm NhanVien
    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click, btnThem_KhaNangViTinh.Click
        Dim _KT As Boolean = True

        If txtTen.Text.Length = 0 Then

            ErrorProvider1.SetError(txtTen, "Bạn chưa nhập Tên Nhân Viên.")
            _KT = False
        Else
            ErrorProvider1.Clear()
        End If

        Dim _Cmnd As String = txtcmnd.Text

        If _Cmnd.Trim.Length = 0 Or _Cmnd.Trim.Length <> 9 Or IsNumeric(_Cmnd) = False Then

            ErrorProvider2.SetError(txtcmnd, "CMND của Nhân Viên phải là 9 số.")
            _KT = False
        Else
            ErrorProvider2.Clear()
        End If

        Dim _Tinhtrang As Boolean

        If rdoDaNghi.Checked = True Then
            _Tinhtrang = True
        End If
        If rdoDangLam.Checked = True Then
            _Tinhtrang = False
        End If

        Dim _Gioitinh As String = ""
        If rdoNam.Checked = True Then
            _Gioitinh = "Nam"
        End If
        If rdoNu.Checked = True Then
            _Gioitinh = "Nữ"
        End If

        Dim _LoaiNV As Boolean
        If cboLoaiNV.SelectedIndex.ToString = "Fulltime" Then
            _LoaiNV = True
        Else
            _LoaiNV = False
        End If
        Dim _Ngay As Boolean = True
        If dtpThoiGianBD.Value.ToString("yyyy-MM-dd") <= dtpNgaySinh.Value.ToString("yyyy-MM-dd") Then
            ErrorProvider3.SetError(dtpNgaySinh, "Ngày sinh phải nhỏ hơn thời gian bắt đầu!")
            ErrorProvider4.SetError(dtpThoiGianBD, "Ngày sinh phải nhỏ hơn thời gian bắt đầu!")
            _KT = False
            _Ngay = False
        Else
            ErrorProvider3.Clear()
            ErrorProvider4.Clear()


        End If

        Dim rowCount As Integer

        Try
            If _KT = False Then
                Return
            Else


                DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác thêm?", "Thông Báo", MessageBoxButtons.OKCancel)

                If DialogResult = Windows.Forms.DialogResult.OK Then

                    '_connect.Open()
                    '_query = "Insert into NhanVien(MaNV, TGBatDau, cmnd, HoTen, TinhTrang, NgaySinh, GioiTinh, LoaiNhanVien, MaChucVu) values('NV0031'," + "'" + dtpThoiGianBD.Value.ToString("yyyy-MM-dd") + "','" +
                    '    txtcmnd.Text.ToString + "', N'" + txtTen.Text.ToString + "','" + _tinhtrang + "','" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "','" + _gioitinh + "','" +
                    '    cboKhaNang_NV.SelectedIndex.ToString + "','" + cboTenChucVu.SelectedValue.ToString + "')"
                    '_connect.Query(_query)
                    '_connect.Close()

                    Dim _Name() As String = New String() {"@HoTen", "@CMND", "@TGBatDau", "@NgaySinh", "@GioiTinh", "@LoaiNhanVien", "@MaChucVu"}
                    Dim _Value() As String = New String() {txtTen.Text, txtcmnd.Text, dtpThoiGianBD.Value.ToString("yyyy-MM-dd"), dtpNgaySinh.Value.ToString("yyyy-MM-dd"), _
                                                           _Gioitinh, _LoaiNV, cboTenChucVu.SelectedValue}
                    _Query = "spNhanVienInsert"
                    rowCount = _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                Else
                    Return
                End If
            End If



            ReLoadNV(dgvNhanVien, _TableNhanVien)
        Catch ex As SqlException
            MessageBox.Show("Dữ liệu nhập sai!")
        End Try

        If rowCount > 0 Then
            MessageBox.Show("Thêm Thành Công", "Thông Báo")
        End If


    End Sub

    'Sửa NhanVien
    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click, btnSua_KhaNangViTinh.Click
        If (_location = 0) Then
            MessageBox.Show("Bạn chưa chọn Nhân Viên", "Thông Báo")

        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác sửa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then

                'dgvNhanVien.Items.Add(New ListViewItem(New String() {TxtMSSV.Text, txtTen.Text, TxtDT.Text, TxtLop.Text, TxtDC.Text}))
                Dim _Tinhtrang As String = ""

                If rdoDaNghi.Checked = True Then
                    _Tinhtrang = True
                End If
                If rdoDangLam.Checked = True Then
                    _Tinhtrang = False
                End If

                Dim _Gioitinh As String = ""
                If rdoNam.Checked = True Then
                    _Gioitinh = "Nam"
                End If
                If rdoNu.Checked = True Then
                    _Gioitinh = "Nữ"
                End If

                Dim _LoaiNV As Boolean
                If cboLoaiNV.SelectedIndex.ToString = "Fulltime" Then
                    _LoaiNV = True
                Else
                    _LoaiNV = False
                End If

                Try

                    _Query = "spNhanVienUpdate"
                    Dim _Name() As String = New String() {"@MaNV ", "@TenNV ", "@TGBatDau ", "@CMND ", "@TinhTrang ", "@GioiTinh ", "@NgaySinh ", "@LoaiNhanVien ", "@MaChucVu "}
                    Dim _Value() As String = New String() {txtMaNV.Text, txtTen.Text, dtpThoiGianBD.Value.ToString("yyyy-MM-dd"), txtcmnd.Text, _Tinhtrang, _Gioitinh, _
                                                           dtpNgaySinh.Value.ToString("yyyy-MM-dd"), _LoaiNV, cboTenChucVu.SelectedValue}

                    _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Catch ex As Exception
                    Throw ex
                End Try

                MessageBox.Show("Sửa thành công", "Thông báo")
                ReLoadNV(dgvNhanVien, _TableNhanVien)
                dgvNhanVien.Rows(_location).Selected = True
                dgvNhanVien.FirstDisplayedScrollingRowIndex = _location
            End If
        End If

        ''-------------------------------------------------------------------------------------Hien Thi dong da sua--------------------------------------------------------
    End Sub

    'Xóa NhanVien 
    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click, btnXoa_KhaNangViTinh.Click
        If (_location = 0) Then
            MessageBox.Show("Bạn chưa chọn Nhân Viên", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then

                'Dim _query As String = ""
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
                Dim _Word As String = txtMaNV.Text.ToString.Trim
                _Query = "Delete From NhanVien Where MaNV ='" + _Word + "'"
                _connect.Query(_Query)
                '_connect.Close()
                '_Query = "spNhanVienDelete"
                'Dim _Name() As String = New String() {"@MaNV"}
                'Dim _Value() As String = New String() {_Word}

                '_connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                txtMaNV.Text = ""
                txtTen.Text = ""
                txtcmnd.Text = ""
                txtTimKiem_NhanVien.Text = ""

                Dim kq As Boolean = False
                _TableNhanVien = _connect.Query("Delete From  NhanVien  Where MaNV='" + _Word + "'")
                For Each dt As DataRow In _TableNhanVien.Rows
                    If (_Word <> dt("MaNV").ToString.Trim) Then
                        kq = True
                    End If
                Next

                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")
                End If
                ReLoadNV(dgvNhanVien, _TableNhanVien)
                If _location = dgvNhanVien.Rows.Count Then
                    dgvNhanVien.Rows(_location - 1).Selected = True
                    dgvNhanVien.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvNhanVien.Rows(_location).Selected = True
                    dgvNhanVien.FirstDisplayedScrollingRowIndex = _location
                End If

            End If

        End If
    End Sub

    'Nhập lại thông tin Nhân Viên
    Private Sub btnNhapLaiNV_Click(sender As Object, e As EventArgs) Handles btnNhapLaiNV.Click
        txtMaNV.Text = ""
        txtTen.Text = ""
        txtcmnd.Text = ""
        txtTimKiem_NhanVien.Text = ""
        _location = 0
    End Sub

    'Tìm NhanVien
    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiemNV.Click
        Dim _Table As DataTable = Nothing
        If txtTimKiem_NhanVien.Text.Trim.Count = 0 Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        End If

        Dim _KQ As Boolean = False

        Dim _Word As String = txtTimKiem_NhanVien.Text.ToString

        'For Each dt As DataRow In _Table.Rows
        '    If (_Word = dt("MaNV").ToString.Trim) Then
        '        _KQ = True
        '        txtMaNV.Text = dt("MaNV").Value.ToString()
        '        txtcmnd.Text = dt("CMND").Value.ToString()
        '        dtpNgaySinh.Text = dt("NgaySinh").Value.ToString()
        '        Dim LoaiNV As String = ""
        '        cboKhaNang_NV.Text = dt("LoaiNhanVien").Value.ToString
        '        If LoaiNV = "True" Then
        '            cboKhaNang_NV.SelectedIndex = 1
        '        Else
        '            cboKhaNang_NV.SelectedIndex = 0
        '        End If
        '        txtTen.Text = dt("HoTen").Value.ToString()

        '        If GioiTinh.ToString = "Nam" Then
        '            rdoNam.Checked = True
        '        Else
        '            rdoNu.Checked = True
        '        End If

        '        If TinhTrang.ToString = "Đã Nghỉ" Then
        '            rdoDaNghi.Checked = True
        '        Else
        '            rdoDangLam.Checked = True
        '        End If

        '        cboKhaNang_NV.SelectedValue = dt("LoaiNhanVien").Value
        '        cboTenChucVu.SelectedValue = dt("MaChucVu").Value
        '        dtpNgaySinh.Value = dt("NgaySinh").Value.ToString

        '        If dt("GioiTinh").Value.ToString = "Nam" Then
        '            rdoNam.Checked = True

        '        Else
        '            rdoNu.Checked = True
        '        End If

        '        If dt("TinhTrang").Value.ToString = "Đã Nghỉ" Then
        '            rdoDaNghi.Checked = True

        '        Else
        '            rdoDangLam.Checked = True
        '        End If
        '    End If
        'Next

        If (_KQ = False) Then
            MessageBox.Show("Không tồn tại Nhân Viên", "Thông Báo")
        End If


        'query = "Delete From NhanVien Where TGBatDau ='" + txtTimKiem_NhanVien.Text.Trim + "' OR cmnd ='" +
        'txtTimKiem_NhanVien.Text.Trim + "'OR HoTen = N'" + txtTimKiem_NhanVien.Text.Trim + "' OR TinhTrang = '" + txtTimKiem_NhanVien.Text.Trim + "'OR NgaySinh = '" +
        'txtTimKiem_NhanVien.Text.Trim("yyyy-MM-dd") + "'OR GioiTinh = '" + txtTimKiem_NhanVien.Text.Trim + "'OR LoaiNhanVien = '" +
        'txtTimKiem_NhanVien.Text.Trim + "'OR MaChucVu = '" + txtTimKiem_NhanVien.Text.Trim + "'" + "Where MaNV ='" +
        'txtTimKiem_NhanVien.Text.Trim + "'"
        '_connect.query(query)
        '_connect.Close()

    End Sub

    'Chọn NhanVien
    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        'Dim row As DataRow = ds.Select("HoTen = " + dgvNhanVien(0, dgvNhanVien.CurrentCell.RowIndex).Value)(0)
        _location = e.RowIndex
        If e.RowIndex = dgvNhanVien.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then
            txtMaNV.Text = dgvNhanVien.Rows(e.RowIndex).Cells("MaNV").Value.ToString()
            txtcmnd.Text = dgvNhanVien.Rows(e.RowIndex).Cells("CMND").Value.ToString()
            dtpNgaySinh.Text = dgvNhanVien.Rows(e.RowIndex).Cells("NgaySinh").Value.ToString()
            Dim LoaiNV As String = ""
            cboKhaNang_NV.Text = dgvNhanVien.Rows(e.RowIndex).Cells("LoaiNhanVien").Value.ToString
            If LoaiNV = "True" Then
                cboKhaNang_NV.SelectedIndex = 1
            Else
                cboKhaNang_NV.SelectedIndex = 0
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

            cboKhaNang_NV.SelectedValue = dgvNhanVien.Rows(e.RowIndex).Cells("LoaiNhanVien").Value
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



    '--------------------------------------------------------------------Bảng Hóa Đơn------------------------------------------------------------------------------
    'Bảng hóa đơn
    'Load dữ liệu Hóa Đơn
    Private Sub HoaDon_Enter(sender As Object, e As EventArgs) Handles HoaDon.Enter
        'Load dữ liệu hóa đơn
        _TableHoaDon = LoadHoaDon(dgvHoaDon)

        'Load ComboBox DaThanhToan
        cboDaThanhToan_HoaDon.Items.Insert(0, "Đã Thanh Toán")
        cboDaThanhToan_HoaDon.Items.Insert(1, "Chưa Thanh Toán")
        cboDaThanhToan_HoaDon.SelectedIndex = 0


    End Sub

    'Chọn dữ liệu Hóa Đơn
    Private Sub dgvHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellClick
        dgvCTHoaDon.Rows.Clear()
        _location = dgvHoaDon.SelectedRows(0).Index
        If e.RowIndex = dgvHoaDon.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then
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
        gbxChiTietHoaDon.Enabled = True
        gbxDanhSachChiTietHoaDon.Enabled = True

        'Xóa giá trị trong textbox chi tiết hóa đơn
        txtMaHoaDon_CTHD.Text = ""
        txtTenMon_CTHD.Text = ""
        txtSoLuong_CTHD.Text = ""
        txtGiaMotMon_CTHD.Text = ""
        txtGhiChuCTHoaDon.Text = ""
        txtTongTien_CTHD.Text = ""
        txtTimKiem_CTHD.Text = ""

        'Load dữ liệu chi tiết hóa đơn
        _TableCTHoaDon = LoadCTHoaDon(dgvCTHoaDon, txtMaHoaDon_HoaDon.Text)
    End Sub

    'Xóa dữ liệu Hóa Đơn
    Private Sub btnXoa_HoaDon_Click(sender As Object, e As EventArgs) Handles btnXoa_HoaDon.Click
        If (_location = 0) Then
            MessageBox.Show("Bạn chưa chọn Hóa Đơn", "Thông Báo")
        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                Dim _Query As String = "spHoaDonDelete"
                Dim _Name() As String = New String() {"@MaHD"}
                Dim _Value() As String = New String() {txtMaHoaDon_HoaDon.Text}

                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaHoaDon_HoaDon.Text

                txtMaHoaDon_HoaDon.Text = ""
                txtSoBan_HoaDon.Text = ""
                txtMaHoaDonChung_HoaDon.Text = ""
                txtTenNV_HoaDon.Text = ""
                txtGhiChu_HoaDon.Text = ""
                txtTongTien_HoaDon.Text = ""
                txtTimKiem_HoaDon.Text = ""

                dgvHoaDon.Rows.Clear()
                Dim Table As New DataTable
                Dim kq As Boolean = True
                Table = _connect.Query("Select Rtrim (HD.MaHoaDon) as MaHoaDon, Rtrim (HD.MaHDChung) as MaHDChung From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV")
                For Each dt As DataRow In Table.Rows
                    If (_word = dt("MaHoaDon").ToString) Then
                        kq = False
                        Exit For
                    End If
                Next
                LoadHoaDon(dgvHoaDon)
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")
                End If
                If _location = dgvHoaDon.Rows.Count Then
                    dgvHoaDon.Rows(_location - 1).Selected = True
                    dgvHoaDon.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvHoaDon.Rows(_location).Selected = True
                    dgvHoaDon.FirstDisplayedScrollingRowIndex = _location
                End If
            End If
        End If
    End Sub
    'Tìm kiếm HoaDon
    Private Sub btnTimKiem_HoaDon_Click(sender As Object, e As EventArgs) Handles btnTimKiem_HoaDon.Click
        If txtTimKiem_CTHD.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_HoaDon, "Bạn chưa chọn giá trị.")

        End If
    End Sub

    'Bảng Chi Tiết Hóa Đơn
    'Tìm dữ liệu hóa đơn
    Private Sub btnTimKiem_CTHD_Click(sender As Object, e As EventArgs) Handles btnTimKiem_CTHD.Click
        If txtTimKiem_CTHD.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_CTHD, "Bạn chưa chọn Đơn Vị.")

        End If
    End Sub

    'Xóa dữ liệu ChiTietHoaDon
    Private Sub btnXoa_CTHoaDon_Click(sender As Object, e As EventArgs) Handles btnXoa_CTHoaDon.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Hóa Đơn", "Thông Báo")

        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                'Dim _Query As String = "spCTHoaDonDelete"
                '_connect.Update(_Query)

                Dim _word As String = txtMaHoaDon_HoaDon.Text
                _Query = "Delete From ChiTietHoaDon Where MaCT ='" + _word + "'"
                _connect.Query(_Query)

                txtMaHoaDon_CTHD.Text = ""
                txtTenMon_CTHD.Text = ""
                txtSoLuong_CTHD.Text = ""
                txtGiaMotMon_CTHD.Text = ""
                txtGhiChuCTHoaDon.Text = ""
                txtTongTien_CTHD.Text = ""
                txtTimKiem_CTHD.Text = ""

                LoadHoaDon(dgvHoaDon)
                Dim Table As New DataTable
                Dim kq As Boolean = False
                Table = _connect.Query("Select HD.MaHoaDon,HD.MaHDChung From HoaDon HD, NhanVien NV Where NV.MaNV = HD.MaNV ")
                For Each dt As DataRow In Table.Rows
                    If (_word = dt("MaHoaDon").ToString) Then
                        kq = True
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")

                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                End If
                If _location = dgvCTHoaDon.Rows.Count Then
                    dgvCTHoaDon.Rows(_location - 1).Selected = True
                    dgvCTHoaDon.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvCTHoaDon.Rows(_location).Selected = True
                    dgvCTHoaDon.FirstDisplayedScrollingRowIndex = _location
                End If
            End If

            End If
    End Sub

    'Chọn dữ liệu ChiTietHoaDon
    Private Sub dgvCTHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTHoaDon.CellClick
        If e.RowIndex = dgvCTHoaDon.Rows.Count Then
            Return
        End If

        _location = dgvHoaDon.SelectedRows(0).Index

        If e.RowIndex >= 0 Then
            txtMaHoaDon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("MaHoaDon").Value.ToString()
            txtTenMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("TenMon_CTHD").Value.ToString()
            txtSoLuong_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("SoLuong").Value.ToString()
            txtGiaMotMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GiaMotMon_CTHD").Value.ToString()
            txtGhiChuCTHoaDon.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GhiChu_CTHD").Value.ToString()
            txtTongTien_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("TongTien_CTHD").Value.ToString()
        End If
    End Sub


    '---------------------------------------------------------------Bảng Món Ăn Đồ Uống - Chi tiết món--------------------------------------------------------------
    'Load dữ liệu MonAnDoUong
    Private Sub MonAnDoUong_Enter(sender As Object, e As EventArgs) Handles MonAnDoUong.Enter

        'Load Bảng MonAnDoUong
        _TableMonAnDoUong = LoadMonAnDoUong(dgvMonAnDoUong)

        'Load ComboBox ThucDonMon
        cboThucDonMon_Mon.Items.Insert(0, "Có")
        cboThucDonMon_Mon.Items.Insert(1, "Không")
        cboThucDonMon_Mon.SelectedIndex = 0

        'Load ComboBox Loai
        cboLoai_MADU.Items.Insert(0, "Đồ Ăn")
        cboLoai_MADU.Items.Insert(1, "Đồ Uống")
        cboLoai_MADU.SelectedIndex = 0

        Dim _CoboBoxSanPham As New DataTable
        _CoboBoxSanPham = _connect.Query("Select MaSP, TenSP From SanPham ")

        LoadComboBox(cboTenSP_CTMon, _CoboBoxSanPham, "TenSP", "MaSP")

    End Sub

    'Thêm dữ liệu MonAnDoUong
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem_Mon.Click
        Dim _KT As Boolean = True

        If txtTenMon_Mon.Text.Length = 0 Then

            ErrorProvider1.SetError(txtTenMon_Mon, "Bạn chưa nhập Tên Món.")
            _KT = False
        Else
            ErrorProvider1.Clear()
        End If

        If txtGiaHienTai_Mon.Text.Length = 0 Then

            ErrorProvider2.SetError(txtGiaHienTai_Mon, "Bạn chưa nhập Giá Món.")
            _KT = False
        Else
            ErrorProvider2.Clear()
        End If

        Try

        Catch ex As Exception
            MessageBox.Show("Dữ liệu nhập sai!", "Thông Báo")
        End Try

        Dim rowCount As Integer

        Try
            If _KT = False Then
                Return
            Else

                DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác thêm?", "Thông Báo", MessageBoxButtons.OKCancel)

                If DialogResult = Windows.Forms.DialogResult.OK Then

                    Dim _Name() As String = New String() {"@TenMon", "@GiaTienHienTai", "@kt"}
                    Dim _Value() As String = New String() {txtTenMon_Mon.Text, Integer.Parse(txtGiaHienTai_Mon.Text.Replace(",", "").ToString()), cboThucDonMon_Mon.SelectedIndex}
                    _Query = "MonAnDoUongInsert"
                    rowCount = _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                Else
                    Return
                End If
            End If



            LoadMonAnDoUong(dgvMonAnDoUong)
        Catch ex As SqlException
            MessageBox.Show("Thêm thất bại", "Thông Báo")
        End Try

        If rowCount > 0 Then
            MessageBox.Show("Thêm Thành Công", "Thông Báo")
            txtTenMon_Mon.Text = ""
            txtGiaHienTai_Mon.Text = ""

        End If
        
    End Sub

    'Sua MonAnDoUong
    Private Sub btnSua_Mon_Click(sender As Object, e As EventArgs) Handles btnSua_Mon.Click
        If (_location = 0) Then
            MessageBox.Show("Bạn chưa chọn Món", "Thông Báo")

        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác sửa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then

                Dim _Query As String = "spMonAnDoUongUpdate"
                Dim _Name() As String = New String() {"@MaDA", "@TenMon", "@GiaTienHienTai", "@ThucDonMon"}
                Dim _Value() As String = New String() {txtMaMon_Mon.Text, txtTenMon_Mon.Text, Integer.Parse(txtGiaHienTai_Mon.Text.Replace(",", "").ToString()), cboThucDonMon_Mon.SelectedIndex.ToString}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                MessageBox.Show("Sửa thành công", "Thông báo")
                LoadMonAnDoUong(dgvMonAnDoUong)
                dgvNhanVien.Rows(_location).Selected = True
                dgvNhanVien.FirstDisplayedScrollingRowIndex = _location
            Else
                Return
            End If
        End If

    End Sub

    'Xoa MonAnDoUong
    Private Sub btnXoa_Mon_Click(sender As Object, e As EventArgs) Handles btnXoa_Mon.Click
        If (_location = 0) Then
            MessageBox.Show("Bạn chưa chọn Món", "Thông Báo")
        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then

                Dim _Query As String = "spMonAnDoUongDelete"
                Dim _Name() As String = New String() {"@MaDA"}
                Dim _Value() As String = New String() {txtMaMon_Mon.Text}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaMon_Mon.Text

                txtMaHoaDon_HoaDon.Text = ""
                txtSoBan_HoaDon.Text = ""
                txtMaHoaDonChung_HoaDon.Text = ""
                txtTenNV_HoaDon.Text = ""
                txtGhiChu_HoaDon.Text = ""
                txtTongTien_HoaDon.Text = ""
                txtTimKiem_HoaDon.Text = ""


                Dim Table As New DataTable
                Dim kq As Boolean = True
                Table = _connect.Query("Select MaMon From MonAnDoUong ")
                For Each dt As DataRow In Table.Rows
                    If (_word = dt("MaMon").ToString) Then
                        kq = False
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")

                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                End If
                LoadMonAnDoUong(dgvMonAnDoUong)
                If (_location = dgvMonAnDoUong.Rows.Count) Then
                    dgvMonAnDoUong.Rows(_location - 1).Selected = True
                    dgvMonAnDoUong.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvMonAnDoUong.Rows(_location).Selected = True
                    dgvMonAnDoUong.FirstDisplayedScrollingRowIndex = _location
                End If
            End If
        End If

    End Sub

    'Tìm kiếm MonAnDoUong
    Private Sub btnTimKiem_Mon_Click(sender As Object, e As EventArgs) Handles btnTimKiem_Mon.Click
        If txtTimKiem_Mon.Text = "Nhập thông tin cần tìm vào đây" Then
            ErrorProvider4.SetError(txtTimKiem_Mon, "Bạn chưa chọn Đơn Vị.")

        End If
    End Sub

    'Chọn dòng trong bảng MonAnDoUong
    Private Sub dgvMonAnDoUong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMonAnDoUong.CellClick
        'Hiển thị thông tin món trên textbox
        _location = dgvMonAnDoUong.SelectedRows(0).Index

        If e.RowIndex = dgvMonAnDoUong.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then

            txtMaMon_Mon.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("MaMon").Value.ToString()
            txtTenMon_Mon.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("TenMon").Value.ToString()
            txtGiaHienTai_Mon.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("GiaTienHienTai").Value
            cboThucDonMon_Mon.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("ThucDonMon").Value.ToString()
            cboLoai_MADU.Text = dgvMonAnDoUong.Rows(e.RowIndex).Cells("Loai").Value.ToString()

        End If

        txtTenMon_CTMon.Text = ""
        cboTenSP_CTMon.Text = ""
        txtSoLuong_CTMon.Text = ""
        cboDonVi_CTMon.Text = ""

        'Hiển thị bảng danh sách chi tiết món
        gbxThongTinChiTietMon.Enabled = True
        dgvCTMon.Rows.Clear()
        _TableCTMonAnDoUong = LoadCTMonAnDoUong(dgvCTMon, txtMaMon_Mon.Text.Trim)

        txtTenMon_CTHD.Text = ""
        cboTenSP_CTMon.Text = ""
        txtSoLuong_CTMon.Text = ""

        'Load ComboBox LoaiDonViTinh
        Dim _ComboBoxLoaiDonViTinh As New DataTable
        _ComboBoxLoaiDonViTinh = _connect.Query("Select LDVT.TenDV, LDVT.MaDV From LoaiDonViTinh LDVT")
        LoadComboBox(cboDonVi_CTMon, _ComboBoxLoaiDonViTinh, "TenDV", "MaDV")


    End Sub

    'Kiểm tra thông tin textbox

    Private Sub txtTenMon_Mon_TextChanged(sender As Object, e As EventArgs) Handles txtTenMon_Mon.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtTenMon_Mon_Leave(sender As Object, e As EventArgs) Handles txtTenMon_Mon.Leave
        If txtTenMon_Mon.Text = "" Then
            ErrorProvider1.SetError(txtTenMon_Mon, "Bạn chưa nhập Tên Món.")
        Else
            ErrorProvider1.Clear()
        End If

    End Sub

    Private Sub txtGiaHienTai_Mon_TextChanged(sender As Object, e As EventArgs) Handles txtGiaHienTai_Mon.TextChanged
        ErrorProvider2.Clear()
    End Sub

    Private Sub txtGiaHienTai_Mon_Leave(sender As Object, e As EventArgs) Handles txtGiaHienTai_Mon.Leave
        If txtGiaHienTai_Mon.Text = "" Then
            ErrorProvider2.SetError(txtGiaHienTai_Mon, "Bạn chưa nhập Giá Món.")
        Else
            ErrorProvider2.Clear()
        End If

    End Sub

    Private Sub txtTimKiem_Mon_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.TextChanged
        ErrorProvider4.Clear()
    End Sub

    'Thêm dữ liệu ChiTietMonAnDoUong
    Private Sub btnThem_CTMon_Click(sender As Object, e As EventArgs) Handles btnThem_CTMon.Click
        Dim _KT As Boolean = True



        If cboTenSP_CTMon.Text.Length = 0 Then

            ErrorProvider1.SetError(cboTenSP_CTMon, "Bạn chưa nhập Tên Sản Phẩm.")
            _KT = False
        Else
            ErrorProvider1.Clear()
        End If

        If txtSoLuong_CTMon.Text.Length = 0 Or IsNumeric(txtSoLuong_CTMon.Text) = False Then

            ErrorProvider2.SetError(txtSoLuong_CTMon, "Bạn chưa nhập Số Lượng.")
            _KT = False
        Else
            ErrorProvider2.Clear()
        End If

        If cboDonVi_CTMon.Text.Length = 0 Then
            ErrorProvider3.SetError(cboDonVi_CTMon, "Bạn chưa chọn Đơn Vị.")
            _KT = False
        Else
            ErrorProvider3.Clear()
        End If

        Dim _TDMon As Boolean
        If cboThucDonMon_Mon.SelectedItem.ToString = "Có" Then
            _TDMon = True
        Else
            _TDMon = False

        End If

        Dim rowCount As Integer

        Try
            If _KT = False Then
                Return
            Else

                DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác thêm?", "Thông Báo", MessageBoxButtons.OKCancel)

                If DialogResult = Windows.Forms.DialogResult.OK Then

                    Dim _Name() As String = New String() {"@MaMon", "@MaSP", "@SoLuong", "@MaDV"}
                    Dim _Value() As String = New String() {txtMaMon_Mon.Text.ToString.Trim, cboTenSP_CTMon.SelectedValue, Double.Parse(txtSoLuong_CTMon.Text), Integer.Parse(cboDonVi_CTMon.SelectedValue)}
                    _Query = "spCTLamMonInsert"
                    rowCount = _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Else
                    Return
                End If
            End If


            LoadCTMonAnDoUong(dgvCTMon, txtMaMon_Mon.Text)

        Catch ex As SqlException
            MessageBox.Show("Thêm thất bại!", "Thông Báo")
        End Try

        If rowCount > 0 Then
            MessageBox.Show("Thêm Thành Công", "Thông Báo")

            txtTenMon_CTHD.Text = ""
            cboTenSP_CTMon.Text = ""
            txtSoLuong_CTMon.Text = ""
        Else
            MessageBox.Show("Thêm Thất Bại", "Thông Báo")
            Return
        End If



        
        


    End Sub

    'Sửa dữ liệu ChiTietMonAnDoUong
    Private Sub btnSua_CTMon_Click(sender As Object, e As EventArgs) Handles btnSua_CTMon.Click
        _location = dgvCTMon.SelectedRows(0).Index
        If _location < 0 Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Món", "Thông Báo")
            Return
        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác sửa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                _MaSPMoi = cboTenSP_CTMon.SelectedValue

                Dim _Query As String = "spCTLamMonUpdate"
                Dim _Name() As String = New String() {"@MaMon", "@MaSPCu", "@MaSPMoi", "@SoLuong", "@MaDV"}
                Dim _Value() As String = New String() {txtMaMon_Mon.Text, _MaSPCu, _MaSPMoi, txtSoLuong_CTMon.Text, cboDonVi_CTMon.SelectedValue}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

            End If
            MessageBox.Show("Sửa thành công", "Thông báo")
            LoadCTMonAnDoUong(dgvCTMon, txtMaMon_Mon.Text)
            dgvCTMon.Rows(_location).Selected = True
            dgvCTMon.FirstDisplayedScrollingRowIndex = _location
        End If
       
    End Sub

    'Xóa dữ liệu ChiTIetMonAnDoUong
    Private Sub btnXoa_CTMon_Click(sender As Object, e As EventArgs) Handles btnXoa_CTMon.Click
        If (_location = 0) Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Món", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin chi tiết món?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then



                Dim _Query As String = "spCTLamMonDelete"
                Dim _Name() As String = New String() {"@MaMon", "@MaSP"}
                Dim _Value() As String = New String() {txtMaMon_Mon.Text.ToString.Trim, cboTenSP_CTMon.SelectedValue.ToString.Trim}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))


                Dim _word As String = txtMaMon_Mon.Text.ToString

                txtTenMon_CTMon.Text = ""
                cboTenSP_CTMon.Text = ""
                txtSoLuong_CTMon.Text = ""
                cboDonVi_CTMon.Text = ""


                Dim Table As New DataTable
                Dim kq As Boolean = True
                Table = _connect.Query("Select MaMon From ChiTietLamMon")
                For Each dt As DataRow In Table.Rows
                    If (_word = dt("MaMon").ToString) Then
                        kq = False
                    End If
                Next

                LoadCTMonAnDoUong(dgvCTMon, txtMaMon_Mon.Text)

                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")

                    If _location = dgvCTMon.Rows.Count Then
                        dgvCTMon.Rows(_location - 1).Selected = True
                        dgvCTMon.FirstDisplayedScrollingRowIndex = _location - 1
                    Else
                        dgvCTMon.Rows(_location).Selected = True
                        dgvCTMon.FirstDisplayedScrollingRowIndex = _location
                    End If
                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                    Return
                End If


            End If

        End If
    End Sub
   
    'Chọn ChiTietMonAnDoUong
    Private Sub dgvCTMon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTMon.CellClick
        _location = dgvCTMon.SelectedRows(0).Index

        If e.RowIndex = dgvCTMon.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then

            cboTenSP_CTMon.SelectedValue = dgvCTMon.Rows(e.RowIndex).Cells("MaSP_CTM").Value.ToString()
            txtSoLuong_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("SoLuong_CTMon").Value.ToString()
            cboDonVi_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("DonVi_CTMon").Value.ToString()
            txtMaMon_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("MaMon_CTM").Value.ToString()

            _MaSPCu = dgvCTMon.Rows(e.RowIndex).Cells("MaSP_CTM").Value.ToString()

        End If
    End Sub

    'Tim ChiTietMonAnDoUong
    Private Sub btnTim_CTMon_Click(sender As Object, e As EventArgs) Handles btnTim_CTMon.Click
        If txtTimKiem_CTMon.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_CTMon, "Bạn chưa chọn Đơn Vị.")

        End If
    End Sub




    '-------------------------------------------------------------------------------Bảng Phiếu Nhập--------------------------------------------------------------------
    'Load dữ liệu phiếu nhập
    Private Sub PhieuNhap_Enter(sender As Object, e As EventArgs) Handles PhieuNhap.Enter
        'Dim dsMonAnDoUong As DataTable

        _TablePhieuNhap = LoadPhieuNhap(dgvPhieuNhap)

        'Load ComboBox Tình Trạng
        cboTinhTrang_PhieuNhap.Items.Insert(0, "Hoàn Thành")
        cboTinhTrang_PhieuNhap.Items.Insert(1, "Chưa Hoàn Thành")
        cboTinhTrang_PhieuNhap.SelectedIndex = 0
    End Sub

    'Xóa dữ liệu phiếu nhập
    Private Sub btnXoa_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnXoa_PhieuNhap.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Phiếu Nhập", "Thông Báo")

        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then


                Dim _Query As String = "spPhieuNhapDelete"
                Dim _Name() As String = New String() {"@MaPN"}
                Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaPhieuNhap_PhieuNhap.Text
                txtMaPhieuNhap_PhieuNhap.Text = ""
                txtTenNV_PhieuNhap.Text = ""
                txtTenNCC_PhieuNhap.Text = ""
                dtpNgayLap_PhieuNhap.Text = ""
                dtpNgayGiaoDK_PhieuNhap.Text = ""
                cboTinhTrang_PhieuNhap.Text = ""
                txtTongTien_PhieuNhap.Text = ""

                Dim kq As Boolean = True

                For Each dt As DataRow In _TablePhieuNhap.Rows
                    If (_word = dt("MaPN").ToString.Trim) Then
                        kq = False
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")

                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                End If
                LoadPhieuNhap(dgvPhieuNhap)

                If _location = dgvPhieuNhap.Rows.Count Then
                    dgvPhieuNhap.Rows(_location - 1).Selected = True
                    dgvPhieuNhap.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvPhieuNhap.Rows(_location).Selected = True
                    dgvPhieuNhap.FirstDisplayedScrollingRowIndex = _location
                End If

            End If
        End If

    End Sub

    'Cập nhật tình trạng phiếu nhập
    Private Sub btnCapNhat_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnCapNhat_PhieuNhap.Click
        If _location < 0 Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

        Else
            Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
            Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
            Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 0}
            _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
            gpbDanhSachCTPhieuNhap.Enabled = True
            gpbThongTinPhieuNhap.Enabled = True
        End If


    End Sub

    'Hoàn thành phiếu nhập
    Private Sub btnHoanThanh_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnHoanThanh_PhieuNhap.Click
        If _location < 0 Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

        Else
            Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
            Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
            Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 1}
            _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
            gpbDanhSachCTPhieuNhap.Enabled = False
            gpbThongTinPhieuNhap.Enabled = False
        End If
    End Sub

    'Chọn dòng phiếu nhập
    Private Sub dgvPhieuNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuNhap.CellClick
        _location = dgvPhieuNhap.SelectedRows(0).Index

        If e.RowIndex = dgvPhieuNhap.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then
            txtMaPhieuNhap_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("MaPN_PhieuNhap").Value.ToString()
            txtTenNV_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TenNV_PhieuNhap").Value.ToString()
            txtTenNCC_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TenNCC_PhieuNhap").Value.ToString()
            dtpNgayLap_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("NgayLap_PhieuNhap").Value.ToString()
            dtpNgayGiaoDK_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("NgayGiaoDK_PhieuNhap").Value.ToString()
            cboTinhTrang_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TinhTrang_PhieuNhap").Value.ToString()
            txtTongTien_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TongTien_PhieuNhap").Value.ToString()

        End If

        gpbDanhSachCTPhieuNhap.Enabled = True
        dgvChiTietPhieuNhap.Rows.Clear()

        'Load chi tiết phiếu nhập
        _TableCTPhieuNhap = LoadCTPhieuNhap(dgvChiTietPhieuNhap, txtMaPhieuNhap_PhieuNhap.Text)
        'Load ComboBox đơn vị
        cboDonVi_CTPhieuNhap.Items.Insert(0, "Chai")
        cboDonVi_CTPhieuNhap.Items.Insert(1, "Lon")
        cboDonVi_CTPhieuNhap.Items.Insert(2, "Cái")
        cboDonVi_CTPhieuNhap.Items.Insert(3, "Kg")
        cboDonVi_CTPhieuNhap.Items.Insert(4, "ml")
        cboDonVi_CTPhieuNhap.Items.Insert(5, "Quả/Trái")
        cboDonVi_CTPhieuNhap.Items.Insert(6, "Ổ")
        cboDonVi_CTPhieuNhap.Items.Insert(7, "Hộp")
        cboDonVi_CTPhieuNhap.Items.Insert(8, "Hủ")
        cboDonVi_CTPhieuNhap.Items.Insert(9, "Bịch")
        cboDonVi_CTPhieuNhap.Items.Insert(10, "Con")
        cboDonVi_CTPhieuNhap.SelectedIndex = 0

    End Sub


    '--------------------------------------------------------------------------Bảng Chi Tiết Phiếu Nhập-----------------------------------------------------------------

    'Chọn dòng dữ liệu chi tiết phiếu nhập
    Private Sub dgvChiTietPhieuNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietPhieuNhap.CellClick
        _location = dgvChiTietPhieuNhap.SelectedRows(0).Index

        If e.RowIndex = dgvChiTietPhieuNhap.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then
            txtMaPhieuNhap_CTPhieuNhap.Text = dgvChiTietPhieuNhap.Rows(e.RowIndex).Cells("MaPN_CTPhieuNhap").Value.ToString()
            txtTenSP_CTPhieuNhap.Text = dgvChiTietPhieuNhap.Rows(e.RowIndex).Cells("TenSP_CTPhieuNhap").Value.ToString()
            txtSoLuong_CTPhieuNhap.Text = dgvChiTietPhieuNhap.Rows(e.RowIndex).Cells("SoLuong_CTPhieuNhap").Value.ToString()
            cboDonVi_CTPhieuNhap.Text = dgvChiTietPhieuNhap.Rows(e.RowIndex).Cells("TenDV_CTPhieuNhap").Value.ToString()
            txtDonGia_CTPhieuNhap.Text = dgvChiTietPhieuNhap.Rows(e.RowIndex).Cells("DonGia_CTPhieuNhap").Value.ToString()
            txtThanhTIen_CTPhieuNhap.Text = dgvChiTietPhieuNhap.Rows(e.RowIndex).Cells("ThanhTien_CTPhieuNhap").Value.ToString()
        End If

    End Sub

    'Xóa dữ liệu phiếu nhập
    Private Sub btnXoa_CTPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnXoa_CTPhieuNhap.Click
        If (_location = 0) Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Phiếu Nhập", "Thông Báo")

        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then


                Dim _Query As String = "spChiTietPhieuNhapDelete"
                Dim _Name() As String = New String() {"@MaPN", "@MaSP"}
                Dim _Value() As String = New String() {txtMaPhieuNhap_CTPhieuNhap.Text, txtMaSP_CTPhieuNhan.Text}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaPhieuNhap_CTPhieuNhap.Text

                txtMaPhieuNhap_CTPhieuNhap.Text = ""
                txtTenSP_CTPhieuNhap.Text = ""
                txtSoLuong_CTPhieuNhap.Text = ""
                cboDonVi_CTPhieuNhap.Text = ""
                txtDonGia_CTPhieuNhap.Text = ""
                txtThanhTIen_CTPhieuNhap.Text = ""

                LoadCTPhieuNhap(dgvChiTietPhieuNhap, _word)

                Dim kq As Boolean = False

                For Each dt As DataRow In _TableCTPhieuNhap.Rows
                    If (_word <> dt("MaPN").ToString.Trim) Then
                        kq = True
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")
                Else
                    MessageBox.Show("Xóa Thất Bại", "Thông Báo")
                End If

                If _location = dgvChiTietPhieuNhap.Rows.Count Then
                    dgvChiTietPhieuNhap.Rows(_location - 1).Selected = True
                    dgvChiTietPhieuNhap.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvChiTietPhieuNhap.Rows(_location).Selected = True
                    dgvChiTietPhieuNhap.FirstDisplayedScrollingRowIndex = _location
                End If

            End If
        End If
    End Sub

    'Cập nhật tình trạng chi tiết phiếu nhập
    Private Sub btnCapnhat_CTPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnCapnhat_CTPhieuNhap.Click
        If _location < 0 Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

        Else
            Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
            Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
            Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 0}
            _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
            gpbChiTietPhieuNhap.Enabled = True
        End If

    End Sub

    'Hoàn thành phiếu nhập
    Private Sub btnHoanThanh_CTPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnHoanThanh_CTPhieuNhap.Click
        If _location < 0 Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

        Else
            Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
            Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
            Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 1}
            _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
            gpbChiTietPhieuNhap.Enabled = False
        End If
    End Sub


    '-----------------------------------------------------------------------------Bảng Phiếu Nhận------------------------------------------------------------------
    'Load dữ liệu phiếu nhận-chi tiết phiếu nhận
    Private Sub PhieuNhan_Enter(sender As Object, e As EventArgs) Handles PhieuNhan.Enter

        'Load dữ liệu phiếu nhận
        _TablePhieuNhan = LoadPhieuNhan(dgvPhieuNhan)

    End Sub
    'Chọn dòng dữ liệu phiếu nhận
    Private Sub dgvPhieuNhan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuNhan.CellClick
        gpbChiTietPhieuNhan.Enabled = True

        _location = dgvPhieuNhan.SelectedRows(0).Index

        If e.RowIndex = dgvPhieuNhan.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then
            txtMaPhieuNhap_PhieuNhan.Text = dgvPhieuNhan.Rows(e.RowIndex).Cells("MaPN_PhieuNhan").Value.ToString()
            txtMaPhieuNhan_PhieuNhan.Text = dgvPhieuNhan.Rows(e.RowIndex).Cells("MaPhieuNhan_PhieuNhan").Value.ToString()
            txtTenNV_PhieuNhan.Text = dgvPhieuNhan.Rows(e.RowIndex).Cells("HoTen_PhieuNhan").Value.ToString()
            dtpNgayLap_PhieuNhan.Text = dgvPhieuNhan.Rows(e.RowIndex).Cells("NgayLap_PhieuNhan").Value.ToString()
            txtGhiChu_PhieuNhan.Text = dgvPhieuNhan.Rows(e.RowIndex).Cells("GhiChu_PhieuNhan").Value.ToString()
            txtTongTien_PhieuNhan.Text = dgvPhieuNhan.Rows(e.RowIndex).Cells("TongTien_PhieuNhan").Value.ToString()
        End If
        'Load dữ liệu chi tiết phiếu nhận
        _TableCTPhieuNhan = LoadCTPhieuNhan(dgvChiTietPhieuNhan, txtMaPhieuNhan_PhieuNhan.Text.Trim)

        'Load ComboBox đơn vị
        cboDonVi_ChiTietPhieuNhan.Items.Insert(0, "Chai")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(1, "Lon")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(2, "Cái")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(3, "Kg")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(4, "ml")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(5, "Quả/Trái")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(6, "Ổ")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(7, "Hộp")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(8, "Hủ")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(9, "Bịch")
        cboDonVi_ChiTietPhieuNhan.Items.Insert(10, "Con")
        cboDonVi_ChiTietPhieuNhan.SelectedIndex = 0
    End Sub
    'Xóa dữ liệu phiếu nhận
    Private Sub btnXoa_PhieuNhan_Click(sender As Object, e As EventArgs) Handles btnXoa_PhieuNhan.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Phiếu Nhận", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then

                Dim _Query As String = "spPhieuNhanDelete"
                Dim _Name() As String = New String() {"@MaPG"}
                Dim _Value() As String = New String() {txtMaPhieuNhan_PhieuNhan.Text}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaPhieuNhan_PhieuNhan.Text

                txtMaPhieuNhap_PhieuNhan.Text = ""
                txtMaPhieuNhan_PhieuNhan.Text = ""
                txtTenNV_PhieuNhan.Text = ""
                dtpNgayLap_PhieuNhan.Text = ""
                txtGhiChu_PhieuNhan.Text = ""
                txtTongTien_PhieuNhan.Text = ""

                Dim Table As New DataTable
                Dim kq As Boolean = True

                For Each dt As DataRow In _TablePhieuNhan.Rows
                    If (_word = dt("MaPG").ToString.Trim) Then
                        kq = False
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")
                    LoadPhieuNhan(dgvPhieuNhan)
                    If _location = dgvPhieuNhan.Rows.Count Then
                        dgvPhieuNhan.Rows(_location - 1).Selected = True
                        dgvPhieuNhan.FirstDisplayedScrollingRowIndex = _location - 1
                    Else
                        dgvPhieuNhan.Rows(_location).Selected = True
                        dgvPhieuNhan.FirstDisplayedScrollingRowIndex = _location
                    End If
                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                    Return
                End If

            End If
        End If
    End Sub



    '------------------------------------------------------------------------Bảng Chi Tiết Phiếu Nhận------------------------------------------------------------------
    'Chọn dòng dữ liệu chi tiết phiếu nhận
    Private Sub dgvChiTietPhieuNhan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietPhieuNhan.CellClick
        _location = dgvChiTietPhieuNhan.SelectedRows(0).Index

        If e.RowIndex = dgvChiTietPhieuNhan.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then
            txtMaPhieuNhap_ChiTietPhieuNhan.Text = dgvChiTietPhieuNhan.Rows(e.RowIndex).Cells("MaPhieuNhap_CTPhieuNhan").Value.ToString()
            txtMaPhieuNhan_ChiTietPhieuNhan.Text = dgvChiTietPhieuNhan.Rows(e.RowIndex).Cells("MaPhieuNhan_CTPhieuNhan").Value.ToString()
            txtTenSP_ChiTietPhieuNhan.Text = dgvChiTietPhieuNhan.Rows(e.RowIndex).Cells("TenSP_CTPhieuNhan").Value.ToString()
            txtSoLuong_ChiTietPhieuNhan.Text = dgvChiTietPhieuNhan.Rows(e.RowIndex).Cells("SoLuong_CTPhieuNhan").Value.ToString()
            cboDonVi_ChiTietPhieuNhan.Text = dgvChiTietPhieuNhan.Rows(e.RowIndex).Cells("TenDV_CTPhieuNhan").Value.ToString()
            txtMaSP_CTPhieuNhan.Text = dgvChiTietPhieuNhan.Rows(e.RowIndex).Cells("MaSP_CTPhieuNhan").Value.ToString()
        End If
    End Sub
    'Xóa dữ liệu chi tiết phiếu nhận
    Private Sub btnXoa_ChiTietPhieuNhan_Click(sender As Object, e As EventArgs) Handles btnXoa_ChiTietPhieuNhan.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Phiếu Nhận", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                Dim _Query As String = "spChiTietPhieuNhanDelete"
                Dim _Name() As String = New String() {"@MaPG", "@MaPN", "@MaSP"}
                Dim _Value() As String = New String() {txtMaPhieuNhan_ChiTietPhieuNhan.Text, txtMaPhieuNhap_ChiTietPhieuNhan.Text, txtMaSP_CTPhieuNhan.Text}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaPhieuNhap_ChiTietPhieuNhan.Text

                txtMaPhieuNhap_ChiTietPhieuNhan.Text = ""
                txtMaPhieuNhan_ChiTietPhieuNhan.Text = ""
                txtTenSP_ChiTietPhieuNhan.Text = ""
                txtSoLuong_ChiTietPhieuNhan.Text = ""
                cboDonVi_ChiTietPhieuNhan.Text = ""
                txtMaSP_CTPhieuNhan.Text = ""



                Dim Table As New DataTable
                Dim kq As Boolean = True

                For Each dt As DataRow In _TableCTPhieuNhan.Rows
                    If (_word = dt("MaPG").ToString.Trim) Then
                        kq = False
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")
                    LoadCTPhieuNhan(dgvChiTietPhieuNhan, _word)

                    If _location = dgvChiTietPhieuNhan.Rows.Count Then
                        dgvChiTietPhieuNhan.Rows(_location - 1).Selected = True
                        dgvChiTietPhieuNhan.FirstDisplayedScrollingRowIndex = _location - 1
                    Else
                        dgvChiTietPhieuNhan.Rows(_location).Selected = True
                        dgvChiTietPhieuNhan.FirstDisplayedScrollingRowIndex = _location
                    End If
                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                    Return
                End If

               

            End If
        End If

    End Sub



    '---------------------------------------------------------------------Bảng Chức Vụ - Loại Đơn Vị Tính--------------------------------------------------------
    'Load dữ liệu cho bảng
    Private Sub ChucVu_LoaiDonViTinh_Enter(sender As Object, e As EventArgs) Handles ChucVu_LoaiDonViTinh.Enter

        'Load Chức Vụ
        _TableChucVu = LoadChucVu(dgvChucVu)

        'Load Loại Đơn Vị Tính
        _TableLoaiDV = LoadLoaiDV(dgvLoaiDonVi)
        cboKieuGiaTri_LDVT.Items.Insert(0, "Số Nguyên")
        cboKieuGiaTri_LDVT.Items.Insert(1, "Số Thực")
        cboKieuGiaTri_LDVT.SelectedIndex = 0
    End Sub
    
    'Xóa loại đơn vị
    Private Sub btnXoa_LoaiDV_Click(sender As Object, e As EventArgs) Handles btnXoa_LoaiDV.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Phiếu Nhận", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                Dim _Query As String = "spLoaiDonViTinhDelete"
                Dim _Name() As String = New String() {"@MaDV"}
                Dim _Value() As String = New String() {txtMaDV_LoaiDonVi.Text.Trim}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaDV_LoaiDonVi.Text.Trim

                txtMaDV_LoaiDonVi.Text = ""
                txtTenDV_LoaiDonVi.Text = ""
                cboKieuGiaTri_LDVT.Text = ""


                Dim kq As Boolean = True

                For Each dt As DataRow In _TableLoaiDV.Rows
                    If (_word = dt("MaDV").ToString.Trim) Then
                        kq = False
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")
                    LoadLoaiDV(dgvLoaiDonVi)

                    If _location = dgvChiTietPhieuNhan.Rows.Count Then
                        dgvLoaiDonVi.Rows(_location - 1).Selected = True
                        dgvLoaiDonVi.FirstDisplayedScrollingRowIndex = _location - 1
                    Else
                        dgvLoaiDonVi.Rows(_location).Selected = True
                        dgvLoaiDonVi.FirstDisplayedScrollingRowIndex = _location
                    End If
                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                    Return
                End If

            End If
        End If
    End Sub

    'Sửa loại đơn vị
    Private Sub btnSua_LoaiDV_Click(sender As Object, e As EventArgs) Handles btnSua_LoaiDV.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Món", "Thông Báo")

        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác sửa?", "Thông Báo", MessageBoxButtons.OKCancel)
            Dim _KieuGiaTri As Boolean
            If cboKieuGiaTri_LDVT.SelectedIndex.ToString = "Số Thực" Then
                _KieuGiaTri = True
            Else
                _KieuGiaTri = False
            End If

            If DialogResult = Windows.Forms.DialogResult.OK Then
                Try
                    Dim _Name() As String = New String() {"@MaDV", "@TenDV", "@DoTangMacDinh", "@SoThuc"}
                    Dim _Value() As String = New String() {txtMaDV_LoaiDonVi.Text, txtTenDV_LoaiDonVi.Text, nbrDoTangMacDinh_LoaiDV.Value, _KieuGiaTri}
                    _Query = "spLoaiDonViTinhUpdate"
                    Dim rowCount As Integer
                    rowCount = _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                Catch ex As Exception
                    Throw ex
                End Try
                MessageBox.Show("Sửa thành công", "Thông báo")
                LoadLoaiDV(dgvLoaiDonVi)
                dgvNhanVien.Rows(_location).Selected = True
                dgvNhanVien.FirstDisplayedScrollingRowIndex = _location
            End If
        End If
       

    End Sub

    'Thêm loại đơn vị
    Private Sub btnThem_LoaiDV_Click(sender As Object, e As EventArgs) Handles btnThem_LoaiDV.Click
        Dim _KT As Boolean = True

            If txtTenDV_LoaiDonVi.Text.Length = 0 Then
            ErrorProvider1.SetError(txtTenDV_LoaiDonVi, "Bạn chưa nhập tên đơn vị")
                _KT = False
            Else
            ErrorProvider1.Clear()
            End If

            Dim _KieuGiaTri As Boolean
            If cboKieuGiaTri_LDVT.SelectedIndex.ToString = "Số Thực" Then
                _KieuGiaTri = True
            Else
                _KieuGiaTri = False
            End If



            Dim rowCount As Integer

            Try
                If _KT = False Then
                    Return
                Else


                    DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác thêm?", "Thông Báo", MessageBoxButtons.OKCancel)

                    If DialogResult = Windows.Forms.DialogResult.OK Then
                    _Query = "spLoaiDonViTinhInsert"
                    Dim _Name() As String = New String() {"@TenDV", "@SoThuc"}
                    Dim _Value() As String = New String() {txtTenDV_LoaiDonVi.Text.ToString.Trim, _KieuGiaTri}

                    rowCount = _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                    Else
                        Return
                    End If
                End If

                LoadLoaiDV(dgvLoaiDonVi)

            Catch ex As SqlException
                MessageBox.Show("Dữ liệu nhập sai!")
            End Try

            If rowCount > 0 Then
                MessageBox.Show("Thêm Thành Công", "Thông Báo")
            Else
                MessageBox.Show("Thêm Thất Bại", "Thông Báo")
            End If


    End Sub

    'Chọn loại đơn vị
    Private Sub dgvLoaiDonVi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiDonVi.CellClick
        _location = dgvLoaiDonVi.SelectedRows(0).Index

        txtMaDV_LoaiDonVi.Text = dgvLoaiDonVi.Rows(e.RowIndex).Cells("MaDV_LDVT").Value.ToString
        txtTenDV_LoaiDonVi.Text = dgvLoaiDonVi.Rows(e.RowIndex).Cells("TenDV_LDVT").Value.ToString
        nbrDoTangMacDinh_LoaiDV.Text = dgvLoaiDonVi.Rows(e.RowIndex).Cells("DoTangMacDinh_LDVT").Value.ToString
        Dim _KieuGT As String = dgvLoaiDonVi.Rows(e.RowIndex).Cells("SoThuc_LDVT").Value.ToString
        If _KieuGT = "Số Thực" Then
            cboKieuGiaTri_LDVT.SelectedIndex = 1
            nbrDoTangMacDinh_LoaiDV.Increment = 0.01
            nbrDoTangMacDinh_LoaiDV.DecimalPlaces = 2
        Else
            cboKieuGiaTri_LDVT.SelectedIndex = 0
            nbrDoTangMacDinh_LoaiDV.Increment = 1
            nbrDoTangMacDinh_LoaiDV.DecimalPlaces = 0
        End If

    End Sub


    'Chọn dữ liệu chức vụ
    Private Sub dgvChucVu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChucVu.CellClick
        _location = dgvLoaiDonVi.SelectedRows(0).Index

        txtMaCV_ChucVu.Text = dgvChucVu.Rows(e.RowIndex).Cells("MaChucVu_ChucVu").Value.ToString
        txtTenCV_ChucVu.Text = dgvChucVu.Rows(e.RowIndex).Cells("TenChucVu_ChucVu").Value.ToString
    End Sub

    'Thêm chức vụ
    Private Sub btnThem_ChucVu_Click(sender As Object, e As EventArgs) Handles btnThem_ChucVu.Click
        Dim _KT As Boolean = True

        If txtTenCV_ChucVu.Text.Trim.Length = 0 Then

            ErrorProvider1.SetError(txtTenCV_ChucVu, "Bạn chưa nhập tên chức vụ")
            _KT = False
        Else
            ErrorProvider1.Clear()
        End If

        Dim rowCount As Integer

        Try
            If _KT = False Then
                Return
            Else


                DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác thêm?", "Thông Báo", MessageBoxButtons.OKCancel)

                If DialogResult = Windows.Forms.DialogResult.OK Then

                    Dim _Name() As String = New String() {"@TenChucVu"}
                    Dim _Value() As String = New String() {txtTenCV_ChucVu.Text}
                    _Query = "spChucVuNhanVienInsert"
                    rowCount = _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                Else
                    Return
                End If
            End If

            LoadChucVu(dgvChucVu)

        Catch ex As SqlException
            MessageBox.Show("Dữ liệu nhập sai!")
        End Try

        If rowCount > 0 Then
            MessageBox.Show("Thêm Thành Công", "Thông Báo")
        Else
            MessageBox.Show("Thêm Thất Bại", "Thông Báo")
        End If
    End Sub

    'Sữa chức vụ
    Private Sub btnSua_ChucVu_Click(sender As Object, e As EventArgs) Handles btnSua_ChucVu.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Món", "Thông Báo")

        Else
            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác sửa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                Try
                    Dim _Name() As String = New String() {"@MaChucVu", "@TenChucVu"}
                    Dim _Value() As String = New String() {txtMaCV_ChucVu.Text, txtTenCV_ChucVu.Text}
                    _Query = "spChucVuNhanVienUpdate"
                    Dim rowCount As Integer
                    rowCount = _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                Catch ex As Exception
                    Throw ex
                End Try
                MessageBox.Show("Sửa thành công", "Thông báo")
                LoadChucVu(dgvChucVu)
                dgvNhanVien.Rows(_location).Selected = True
                dgvNhanVien.FirstDisplayedScrollingRowIndex = _location
            End If
        End If
    End Sub

    'Xoa chức vụ
    Private Sub btnXoa_ChucVu_Click(sender As Object, e As EventArgs) Handles btnXoa_ChucVu.Click
        If (_location < 0) Then
            MessageBox.Show("Bạn chưa chọn Chức Vụ", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                Dim _word As String = txtMaCV_ChucVu.Text.Trim
                Dim _Query As String = "spChucVuNhanVienDelete"
                Dim _Name() As String = New String() {"@MaChucVu"}
                Dim _Value() As String = New String() {_word}
                Dim _GetValue As SqlParameter = New SqlParameter
                Dim kq As Boolean = True

                _connect.Update(_Query, _GetValue, _connect.CreateParameter(_Name, _Value))

                Dim _return As Integer = _GetValue.Value

              

                If _return = 0 Then
                    MessageBox.Show("Mã chức vụ rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    kq = False
                End If


                Dim Table As New DataTable


                For Each dt As DataRow In _TableChucVu.Rows
                    If (_word = dt("MaChucVu").ToString.Trim) Then
                        kq = False
                    End If
                Next
                If (kq = True) Then
                    MessageBox.Show("Xóa Thành Công", "Thông Báo")
                    LoadChucVu(dgvChucVu)

                    If _location = dgvChucVu.Rows.Count Then
                        dgvChucVu.Rows(_location - 1).Selected = True
                        dgvChucVu.FirstDisplayedScrollingRowIndex = _location - 1
                    Else
                        dgvChucVu.Rows(_location).Selected = True
                        dgvChucVu.FirstDisplayedScrollingRowIndex = _location
                    End If
                    txtMaCV_ChucVu.Text = ""
                    txtTenCV_ChucVu.Text = ""
                Else
                    MessageBox.Show("Xóa thất bại", "Thông Báo")
                    Return
                End If
            End If

        End If
    End Sub


    'Tìm Kiếm
    Private Sub TextBoxSearch_Enter(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.Enter, txtTimKiem_CTHD.Enter, _
       txtTimKiem_CTMon.Enter, txtTim_CTPhieuNhap.Enter, txtTimKiem_HoaDon.Enter, txtTimKiem_NhanVien.Enter, txtTimKiem_PhieuNhap.Enter
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        textBox.Text = ""
    End Sub

    Private Sub TextBoxSearch_Leave(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.Leave
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        If textBox.Text = "" Then
            textBox.Text = "Nhập thông tin cần tìm vào đây"
            ErrorProvider4.Clear()
        End If

    End Sub

    'Đóng Form
    Private Sub frmManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _connect.Dispose()
    End Sub

End Class
