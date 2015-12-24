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

    'Khai bóa vị trí cell
    Dim _location As Integer

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
    'Bảng Nhân Viên
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
            cboKhaNang_NV.Items.Insert(2, "Khac")
            cboKhaNang_NV.SelectedIndex = 0

            'Dim _Table2 As New DataTable
            '_Table2 = _connect.Query("Select distinct CV.TenChucVu, CV.MaChucVu From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu")
            'cboTenChucVu.DataSource = _Table2
            'cboTenChucVu.DisplayMember = "TenChucVu"
            'cboTenChucVu.ValueMember = "MaChucVu"

            'Dim _ComboBoxKhaNangViTinh As New DataTable
            '_ComboBoxKhaNangViTinh = _connect.Query("Select MaNV, TenPhanMem From KhaNangViTinhCuaNhanVien ")
            'LoadComboBox(cboKhaNang_NV, _ComboBoxKhaNangViTinh, "TenPhanMem", "MaNV")

            Dim _CoboBoxChucVu As New DataTable
            _CoboBoxChucVu = _connect.Query("Select distinct CV.TenChucVu, CV.MaChucVu From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu")

            LoadComboBox(cboTenChucVu, _CoboBoxChucVu, "TenChucVu", "MaChucVu")
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click
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
    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click
        DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác sửa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

        If DialogResult = Windows.Forms.DialogResult.OK Then

            Dim TEMP As Boolean = dgvNhanVien.Rows(0).Displayed

            If txtTen.Text.Length = 0 Then

                ErrorProvider2.SetError(txtTen, "Bạn chưa nhập Tên Nhân Viên.")

            End If
            Dim _Cmnd As String = txtcmnd.Text
            If _Cmnd.Trim.Length = 0 Then

                ErrorProvider3.SetError(txtcmnd, "Bạn chưa nhập CMND của Nhân Viên.")

            End If

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
                '_connect.Open()
                '_query = "Update NhanVien Set TGBatDau='" +
                '    dtpThoiGianBD.Value.ToString("yyyy-MM-dd") + "',cmnd ='" +
                'txtcmnd.Text.ToString.Trim + "', HoTen = N'" + txtTen.Text.ToString.Trim + "', TinhTrang = '" + _tinhtrang + "', NgaySinh = '" +
                'dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', GioiTinh = '" + _gioitinh + "', LoaiNhanVien = '" +
                'cboKhaNang_NV.SelectedIndex.ToString + "', MaChucVu = '" + cboTenChucVu.SelectedValue.ToString.Trim + "'" + "Where MaNV ='" +
                ' txtMaNV.Text.Trim + "'"

                _Query = "spNhanVienUpdate"
                Dim _Name() As String = New String() {"@MaNV ", "@TenNV ", "@TGBatDau ", "@CMND ", "@TinhTrang ", "@GioiTinh ", "@NgaySinh ", "@LoaiNhanVien ", "@MaChucVu "}
                Dim _Value() As String = New String() {txtMaNV.Text, txtTen.Text, dtpThoiGianBD.Value.ToString("yyyy-MM-dd"), txtcmnd.Text, _Tinhtrang, _Gioitinh, _
                                                       dtpNgaySinh.Value.ToString("yyyy-MM-dd"), _LoaiNV, cboTenChucVu.SelectedValue}

                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                '_connect.Close()
            Catch ex As Exception
                Throw ex
            End Try

            MessageBox.Show("Sửa thành công", "Thông báo")
            ReLoadNV(dgvNhanVien, _TableNhanVien)
            dgvNhanVien.Rows(_location).Selected = True
            dgvNhanVien.FirstDisplayedScrollingRowIndex = _location
        End If

        ''-------------------------------------------------------------------------------------Hien Thi dong da sua--------------------------------------------------------
    End Sub
    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click
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
            dgvNhanVien.Rows(_location - 1).Selected = True
            dgvNhanVien.FirstDisplayedScrollingRowIndex = _location - 1

        End If
    End Sub
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

    'Bảng Hóa Đơn

    Private Sub HoaDon_Enter(sender As Object, e As EventArgs) Handles HoaDon.Enter

        _TableHoaDon = LoadHoaDon(dgvHoaDon)


        LoadCTHoaDon(dgvCTHoaDon)

        'Load ComboBox
        cboDaThanhToan_HoaDon.Items.Insert(0, "Đã Thanh Toán")
        cboDaThanhToan_HoaDon.Items.Insert(1, "Chưa Thanh Toán")
        cboDaThanhToan_HoaDon.SelectedIndex = 0

    End Sub
    Private Sub dgvHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellClick
        If e.RowIndex = dgvHoaDon.Rows.Count Then
            Return
        End If
        _location = e.RowIndex
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
    Private Sub btnXoa_HoaDon_Click(sender As Object, e As EventArgs) Handles btnXoa_HoaDon.Click
        DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

        If DialogResult = Windows.Forms.DialogResult.OK Then

            dgvHoaDon.Rows.Clear()

            Dim _Query As String = "spHoaDonDelete"
            _connect.Update(_Query)

            Dim _word As String = txtMaHoaDon_HoaDon.Text
           
            txtMaHoaDon_HoaDon.Text = ""
            txtSoBan_HoaDon.Text = ""
            txtMaHoaDonChung_HoaDon.Text = ""
            txtTenNV_HoaDon.Text = ""
            txtGhiChu_HoaDon.Text = ""
            txtTongTien_HoaDon.Text = ""
            txtTimKiem_HoaDon.Text = ""

            ReLoadHoaDon(dgvHoaDon, _TableHoaDon)
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

            dgvNhanVien.Rows(_location - 1).Selected = True
            dgvNhanVien.FirstDisplayedScrollingRowIndex = _location - 1
        End If
    End Sub

    'Bảng Chi Tiết Hóa Đơn
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
    Private Sub btnXoa_CTHD_Click(sender As Object, e As EventArgs)
        DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

        If DialogResult = Windows.Forms.DialogResult.OK Then



            Dim _Query As String = "spCTHoaDonDelete"
            _connect.Update(_Query)

            dgvHoaDon.Rows.Clear()

            ' _connect.Open()

            Dim _word As String = txtMaHoaDon_HoaDon.Text
            _Query = "Delete From ChiTietHoaDon Where MaCT ='" + _word + "'"
            _connect.Query(_Query)
            '_connect.Close()
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
                If (_word <> dt("MaHoaDon").ToString) Then
                    kq = True
                End If
            Next
            If (kq = True) Then
                MessageBox.Show("Xóa Thành Công", "Thông Báo")
            End If
            dgvNhanVien.Rows(_location - 1).Selected = True
            dgvNhanVien.FirstDisplayedScrollingRowIndex = _location - 1
        End If

    End Sub
    Private Sub dgvCTHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTHoaDon.CellClick
        If e.RowIndex = dgvCTHoaDon.Rows.Count - 1 Then
            Return
        End If
        _location = e.RowIndex
        If e.RowIndex > 0 Then
            txtMaHoaDon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("MaHoaDon").Value.ToString()
            txtTenMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("TenMon_CTHD").Value.ToString()
            txtSoLuong_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("SoLuong").Value.ToString()
            txtGiaMotMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GiaMotMon_CTHD").Value.ToString()
            txtGhiChuCTHoaDon.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GhiChu_CTHD").Value.ToString()
            txtTongTien_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("TongTien_CTHD").Value.ToString()
        End If
    End Sub
    Private Sub btnTimKiem_HoaDon_Click(sender As Object, e As EventArgs) Handles btnTimKiem_HoaDon.Click
        If txtTimKiem_CTHD.Text.Length = 0 Then
            ErrorProvider4.SetError(txtTimKiem_HoaDon, "Bạn chưa chọn giá trị.")

        End If
    End Sub


    'Bảng Món Ăn Đồ Uống - Chi tiết món
    Private Sub MonAnDoUong_Enter(sender As Object, e As EventArgs) Handles MonAnDoUong.Enter

        'Load Bảng MonAnDoUong
        _TableMonAnDoUong = LoadMonAnDoUong(dgvMonAnDoUong)
        'Load ComboBox ThucDonMon

        cboThucDonMon_Mon.Items.Insert(0, "Có")
        cboThucDonMon_Mon.Items.Insert(1, "Không")
        cboThucDonMon_Mon.SelectedIndex = 0

        'Load Bảng CTMonAnDoUong 
        _TableCTMonAnDoUong = LoadCTMonAnDoUong(dgvMonAnDoUong)

        'Load ComboBox LoaiDonViTinh
        Dim _ComboBoxLoaiDonViTinh As New DataTable
        _ComboBoxLoaiDonViTinh = _connect.Query("Select LDVT.TenDV, LDVT.MaDV From LoaiDonViTinh LDVT")
        LoadComboBox(cboDonVi_CTMon, _ComboBoxLoaiDonViTinh, "TenDV", "MaDV")
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
        dgvNhanVien.Rows(_location - 1).Selected = True
        dgvNhanVien.FirstDisplayedScrollingRowIndex = _location - 1
    End Sub
    Private Sub btnXoa_CTMon_Click(sender As Object, e As EventArgs) Handles btnXoa_CTMon.Click
        DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

        If DialogResult = Windows.Forms.DialogResult.OK Then



            Dim _Query As String = "spCTLamMonDelete"
            Dim _Name() As String = New String() {"@MaMon ", "@MaSP "}
            Dim _Value() As String = New String() {txtMaMon_CTMon.Text, txtMaSP_CTMon.Text}
            _connect.Update(_Query)

            dgvHoaDon.Rows.Clear()


            Dim _word As String = txtMaHoaDon_HoaDon.Text

            txtTenMon_CTMon.Text = ""
            txtTenSP_CTMon.Text = ""
            txtSoLuong_CTMon.Text = ""
            cboDonVi_CTMon.Text = ""

            LoadCTMonAnDoUong(dgvCTMon)
            Dim Table As New DataTable
            Dim kq As Boolean = False
            Table = _connect.Query("Select MaMon From ChiTietHoaDon")
            For Each dt As DataRow In Table.Rows
                If (_word <> dt("MaMon").ToString) Then
                    kq = True
                End If
            Next
            If (kq = True) Then
                MessageBox.Show("Xóa Thành Công", "Thông Báo")
            End If
            dgvNhanVien.Rows(_location - 1).Selected = True
            dgvNhanVien.FirstDisplayedScrollingRowIndex = _location - 1
        End If

    End Sub

    Private Sub dgvCTMon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTMon.CellClick
        _location = e.RowIndex

        If e.RowIndex = dgvCTMon.Rows.Count Then
            Return
        End If

        If e.RowIndex > 0 Then
            txtTenMon_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("TenMon_CTMon").Value.ToString()
            txtTenSP_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("TenSP_CTMon").Value.ToString()
            txtSoLuong_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("SoLuong_CTMon").Value.ToString()
            cboDonVi_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("DonVi_CTMon").Value.ToString()
            txtMaMon_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("MaMon_CTM").Value.ToString()
            txtMaSP_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("MaSP_CTM").Value.ToString()
        End If
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
        _connect.Dispose()
    End Sub
End Class
