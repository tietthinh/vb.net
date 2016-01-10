'=====================================================================
'Name:      Lưu Thế Nguyên
'Project:   Restaurant Management
'Purpose:   Mangager Form 
'=====================================================================


Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Imports Library
Imports Remote
Imports System.Globalization
Imports System.Exception
Imports Microsoft.Reporting.WinForms
Imports System.Threading

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
    Dim _TableMonHT As DataTable = Nothing
    Dim _TableMonKHT As DataTable = Nothing
    Dim _TableThongKe As DataTable = Nothing
    Dim _TableThongKeNguyenLieu As DataTable = Nothing
    Dim _TableThongKeKhach_Mon As DataTable = Nothing
    Dim _TableThongKeKhach_Ban As DataTable = Nothing
    Dim _TableThongKeKhach_NhanVien As DataTable = Nothing
    Dim _TableThongKeDoanhThu As DataTable = Nothing


    Private Table As DataTable
    Private AbilityComputer As DataTable
    Private _LoaiNhanVienColumnIndex As Integer
    Private _TinhTrangNhanVienColumnIndex As Integer
    'Khai báo form Report
    Dim _Report As rptThongKe


    'Khai bóa vị trí cell
    Dim _location As Integer

    'Khai báo kiểm tra chọn cột
    Dim _Null As Boolean

    'Khai báo tình trạng
    Dim _TinhTrangPN As String = ""

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

    Private _CurrentUser As User = Nothing

    Dim _Query As String = ""
    Dim _ParameterInput As New SqlParameter


    '----------------------------------------------------------------------------------Bảng Nhân Viên---------------------------------------------------------


    Private Sub Listener()
        While (True)
            Thread.Sleep(0)
            If (Me.IsAccessible = True) Then
                Me.Invoke(New MethodInvoker(Sub()
                                                Dim _ReceiveData As String = GetData()
                                                ''Handles event here.

                                                ''
                                            End Sub
                ))
            Else
                Exit While
            End If
        End While
    End Sub

    ''' <summary>
    '''  Load dữ liệu bảng nhân viên
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
     Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTenPhanMem.SelectedIndex = 0
        Dim _CoboBoxChucVu As New DataTable
        _CoboBoxChucVu = _connect.Query("Select distinct CV.TenChucVu, CV.MaChucVu From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu")

        LoadComboBox(cboTenChucVu, _CoboBoxChucVu, "TenChucVu", "MaChucVu")
        _LoaiNhanVienColumnIndex = LoaiNhanVien.Index
        _TinhTrangNhanVienColumnIndex = TinhTrang.Index
        _TableNhanVien = LoadNV(dgvNhanVien)
        'LoadComboBox(cboTenChucVu, "spChucVuNhanVienSelect", "TenChucVu", "MaChucVu")
    End Sub
    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click
        Dim _ErrorCheck As Boolean = False
        If ErrorProvider2.GetError(txtTen) = "Bạn chưa nhập Tên Nhân Viên." Then
            _ErrorCheck = True
        End If

        If ErrorProvider1.GetError(txtcmnd) = "Chứng minh nhân dân phải 9 hoặc 12 số" Then
            _ErrorCheck = True
        End If

        If txtTen.Text.Trim.Length = 0 Then
            _ErrorCheck = True
        End If

        If txtcmnd.Text.Length <> 9 And txtcmnd.Text.Length <> 12 Then
            _ErrorCheck = True
        End If

        If _ErrorCheck Then
            MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        'dgvNhanVien.Items.Add(New ListViewItem(New String() {TxtMSSV.Text, txtTen.Text, TxtDT.Text, TxtLop.Text, TxtDC.Text}))

        Dim _query As String = ""
        Try
            Dim Result As Integer = MessageBox.Show("Bạn muốn thực hiện thao tác thêm?", "Thông Báo", MessageBoxButtons.OKCancel)

            If Result = DialogResult.OK Then
                _query = "spNhanVienInsert"
                Dim _Name() As String = New String() {"@HoTen", "@CMND", "@TinhTrang", "@TGBatDau", "@NgaySinh", "@GioiTinh", "@LoaiNhanVien", "@MaChucVu"}
                Dim _CheckStatus As Boolean = True
                If rdoDangLam.Checked Then
                    _CheckStatus = True
                Else
                    _CheckStatus = False
                End If

                Dim _Sex As String = ""
                If rdoNam.Checked Then
                    _Sex = "Nam"
                Else
                    _Sex = "Nữ"
                End If

                Dim _JobType As Boolean = True
                If rdoFullTime.Checked Then
                    _JobType = True
                Else
                    _JobType = False
                End If

                Dim _Value() As String = New String() {txtTen.Text, txtcmnd.Text, _CheckStatus, dtpThoiGianBD.Value, dtpNgaySinh.Value, _Sex, _JobType, cboTenChucVu.SelectedValue}
                _connect.Update(_query, _connect.CreateParameter(_Name, _Value))
                LoadNV(dgvNhanVien)
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.ToString)
            MessageBox.Show("Thêm thất bại")
        End Try


    End Sub
    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click

        Dim _ErrorCheck As Boolean = False
        If ErrorProvider2.GetError(txtTen) = "Bạn chưa nhập Tên Nhân Viên." Then
            _ErrorCheck = True
        End If

        If ErrorProvider1.GetError(txtcmnd) = "Chứng minh nhân dân phải 9 hoặc 12 số" Then
            _ErrorCheck = True
        End If

        If txtTen.Text.Trim.Length = 0 Then
            _ErrorCheck = True
        End If

        If txtcmnd.Text.Length <> 9 And txtcmnd.Text.Length <> 12 Then
            _ErrorCheck = True
        End If

        If _ErrorCheck Then
            MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        Dim Result As Integer = MessageBox.Show("Bạn muốn thực hiện thao tác sửa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

        If Result = DialogResult.OK Then
            Dim _CheckStatus As Boolean = True
            If rdoDangLam.Checked Then
                _CheckStatus = True
            Else
                _CheckStatus = False
            End If

            Dim _Sex As String = ""
            If rdoNam.Checked Then
                _Sex = "Nam"
            Else
                _Sex = "Nữ"
            End If

            Dim _JobType As Boolean = True
            If rdoFullTime.Checked Then
                _JobType = True
            Else
                _JobType = False
            End If

            Dim _ReturnValue As SqlParameter = New SqlParameter()
            Dim _Query = "spNhanVienUpdate"
            Dim _Name() As String = New String() {"@MaNV", "@TenNV", "@TGBatDau", "@CMND", "@TinhTrang", "@GioiTinh", "@NgaySinh", "@LoaiNhanVien", "@MaChucVu"}
            Dim _Value() As String = New String() {txtMaNV.Text, txtTen.Text, dtpThoiGianBD.Value, txtcmnd.Text, _CheckStatus, _Sex, dtpNgaySinh.Value, _JobType, cboTenChucVu.SelectedValue}
            Try
                _connect.Update(_Query, _ReturnValue, _connect.CreateParameter(_Name, _Value))
                Dim _ValueGet As Integer = _ReturnValue.Value
                If _ValueGet = 1 Then
                    MessageBox.Show("Chứng minh nhân dân không thể thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            dgvNhanVien.FirstDisplayedScrollingRowIndex = _location
        End If



        LoadNV(dgvNhanVien)
        dgvNhanVien.Rows(_location).Selected = True
        ''-------------------------------------------------------------------------------------Hien Thi dong da sua--------------------------------------------------------
    End Sub
    'Xóa NhanVien 
    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click
        If txtMaNV.Text = "" And txtTen.Text = "" And txtcmnd.Text = "" Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Phiếu Nhận", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa thông tin nhân viên?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then

                Dim _Word As String = txtMaNV.Text.ToString.Trim
                '_Query = "Delete From NhanVien Where MaNV ='" + _Word + "'"
                '_connect.Query(_Query)
                '_connect.Close()
                _Query = "spNhanVienDelete"
                Dim _Name() As String = New String() {"@MaNV"}
                Dim _Value() As String = New String() {_Word}

                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

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
                    dgvNhanVien.Rows(0).Selected = False
                    dgvNhanVien.Rows(_location - 1).Selected = True
                    dgvNhanVien.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvNhanVien.Rows(0).Selected = False
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
    Private Sub btnTimKiemNV_Click(sender As Object, e As EventArgs) Handles btnTimKiemNV.Click

        If txtTimKiem_NhanVien.Text.Trim.Count = 0 Or txtTimKiem_NhanVien.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableNhanVien.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_NhanVien.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableNhanVien.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableNhanVien.Columns.Count - 1 Step 1
                    If _TableNhanVien.Rows(i).Item(j).ToString.Contains(_Word) Then
                        Dim _LoaiNV As String = ""
                        If _TableNhanVien.Rows(i).Item(7).ToString = "True" Then
                            _LoaiNV = "Fulltime"
                        Else
                            _LoaiNV = "Parttime"
                        End If
                        Dim TinhTrangNV As String = ""
                        If _TableNhanVien.Rows(i).Item(4).ToString = "True" Then
                            TinhTrangNV = "Đã Nghỉ"
                        Else
                            TinhTrangNV = "Đang Làm"
                        End If


                        _TableResult.Rows.Add(_TableNhanVien.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then
                dgvNhanVien.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvNhanVien.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại nhân viên với dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
        End If

    End Sub

    'Chọn NhanVien
    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        'Dim row As DataRow = ds.Select("HoTen = " + dgvNhanVien(0, dgvNhanVien.CurrentCell.RowIndex).Value)(0)
        _location = e.RowIndex
        Dim _Check As Boolean = True

        If e.RowIndex >= 0 Then
            txtMaNV.Text = dgvNhanVien.Rows(e.RowIndex).Cells("MaNV").Value.ToString()
            txtcmnd.Text = dgvNhanVien.Rows(e.RowIndex).Cells("CMND").Value.ToString().Trim()
            dtpNgaySinh.Value = dgvNhanVien.Rows(e.RowIndex).Cells("NgaySinh").Value
            txtTen.Text = dgvNhanVien.Rows(e.RowIndex).Cells("HoTen").Value.ToString()
            _Check = dgvNhanVien.Rows(e.RowIndex).Cells("TinhTrang").Value
            Dim cmbAbility As DataGridViewComboBoxCell = dgvNhanVien.Rows(e.RowIndex).Cells("KhaNangViTinh_NV")

            cboKhaNang_NV.DataSource = cmbAbility.DataSource
            cboKhaNang_NV.DisplayMember = "TenPhanMem"
            cboKhaNang_NV.ValueMember = "TenPhanMem"

            If _Check = True Then
                rdoDangLam.Checked = _Check
            Else
                rdoDaNghi.Checked = True
            End If
            If GioiTinh.ToString = "Nam" Then
                rdoNam.Checked = True
            Else
                rdoNu.Checked = True
            End If

            _Check = dgvNhanVien.Rows(e.RowIndex).Cells("LoaiNhanVien").Value
            If _Check = True Then
                rdoFullTime.Checked = _Check
            Else
                rdoPartTime.Checked = True
            End If


            cboTenChucVu.SelectedValue = dgvNhanVien.Rows(e.RowIndex).Cells("MaChucVu").Value
            dtpNgaySinh.Value = dgvNhanVien.Rows(e.RowIndex).Cells("NgaySinh").Value.ToString

            If dgvNhanVien.Rows(e.RowIndex).Cells("GioiTinh").Value.ToString = "Nam" Then
                rdoNam.Checked = True

            Else
                rdoNu.Checked = True
            End If

        End If
    End Sub

    'Thêm Khả năng Vi Tính
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim _TenPhanMem As String
        If (dgvNhanVien.SelectedRows.Count > 0) Then
            If (txtPhanMem_NV.Enabled = False) Then
                _TenPhanMem = cboTenPhanMem.SelectedItem
            Else
                _TenPhanMem = txtPhanMem_NV.Text
                If (_TenPhanMem.Trim = "") Then
                    MessageBox.Show("Tên phần mềm đang để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If
            End If

            Dim _MaNhanVien As String = dgvNhanVien.SelectedRows(0).Cells("MaNV").Value
            Dim _Name() As String = New String() {"@MaNV", "@TenPM"}
            Dim _Value() As String = New String() {_MaNhanVien, _TenPhanMem}
            Dim _ReturnValue As SqlParameter = New SqlParameter()
            Try
                _connect.Update("spKhaNangViTinhCuaNhanVienInsert", _ReturnValue, _connect.CreateParameter(_Name, _Value))
                If (_ReturnValue.Value = 1) Then
                    MessageBox.Show("Tên phần mềm nhân viên đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Return
                End If

                LoadNV(dgvNhanVien)
            Catch ex As Exception
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Chưa chọn nhân viên để thêm khả năng vi tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Xóa Khả năng Vi Tính
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (dgvNhanVien.SelectedRows.Count > 0) Then
            Dim _MaNhanVien As String = dgvNhanVien.SelectedRows(0).Cells("MaNV").Value
            Dim _TenPhanMem As String = cboKhaNang_NV.SelectedValue
            Dim _Name() As String = New String() {"@MaNV", "@TenPM"}
            Dim _Value() As String = New String() {_MaNhanVien, _TenPhanMem}
            Try
                _connect.Update("spKhaNangViTinhCuaNhanVienDelete", _connect.CreateParameter(_Name, _Value))
                LoadNV(dgvNhanVien)
            Catch ex As Exception
                MessageBox.Show("Cập nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Chưa chọn nhân viên để cập nhập khả năng vi tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Sửa Khả năng Vi Tính
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (dgvNhanVien.SelectedRows.Count > 0) Then
            Dim _TenPhanMemCu As String
            If (cboKhaNang_NV.SelectedIndex >= 0) Then
                _TenPhanMemCu = cboKhaNang_NV.SelectedValue
                Dim _TenPhanMem As String
                If (txtPhanMem_NV.Enabled = False) Then
                    _TenPhanMem = cboKhaNang_NV.SelectedItem
                Else
                    _TenPhanMem = txtPhanMem_NV.Text
                    If (_TenPhanMem.Trim = "") Then
                        MessageBox.Show("Tên phần mềm đang để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Return
                    End If
                End If

                Dim _MaNhanVien As String = dgvNhanVien.SelectedRows(0).Cells("MaNV").Value
                Dim _Name() As String = New String() {"@MaNV", "@TenPMCu", "@TenPMMoi"}
                Dim _Value() As String = New String() {_MaNhanVien, _TenPhanMemCu, _TenPhanMem}
                Try
                    _connect.Update("spKhaNangViTinhCuaNhanVienUpdate", _connect.CreateParameter(_Name, _Value))
                    LoadNV(dgvNhanVien)
                Catch ex As Exception
                    MessageBox.Show("Cập nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Chưa chọn khả năng vi tính muốn cập nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            MessageBox.Show("Chưa chọn nhân viên để xóa khả năng vi tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    'Thay đổi radiobutton khi chọn dòng trong datagridview
    Private Sub dgvNhanVien_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvNhanVien.CellMouseUp
        If (e.ColumnIndex = _LoaiNhanVienColumnIndex And e.RowIndex <> -1) Then
            dgvNhanVien.EndEdit()
            Dim _checkBoxDataGridview As Boolean
            _checkBoxDataGridview = dgvNhanVien.SelectedRows(0).Cells("LoaiNhanVien").Value
            If (_checkBoxDataGridview) Then
                rdoFullTime.Checked = True
            Else
                rdoPartTime.Checked = True
            End If
        End If

        If (e.ColumnIndex = _TinhTrangNhanVienColumnIndex And e.RowIndex <> -1) Then
            dgvNhanVien.EndEdit()
            Dim _checkBoxDataGridview As Boolean
            _checkBoxDataGridview = dgvNhanVien.SelectedRows(0).Cells("TinhTrang").Value
            If (_checkBoxDataGridview) Then
                rdoDangLam.Checked = True
            Else
                rdoDaNghi.Checked = True
            End If
        End If

    End Sub

    'Kiểm tra cmnd có phải là số
    Private Sub txtcmnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcmnd.KeyPress
        'Asc 48 - 57 code for number
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Kiểm tra thông tin đã nhập vào textbo cmnd sau khi người dùng rời đi
    Private Sub txtcmnd_Leave(sender As Object, e As EventArgs) Handles txtcmnd.Leave
        If txtcmnd.Text.Length <> 9 And txtcmnd.Text.Length <> 12 Then
            ErrorProvider1.SetError(txtcmnd, "Chứng minh nhân dân phải 9 hoặc 12 số")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub
    'Kiểm tra thông tin đã nhập vào textbo tên sau khi người dùng rời đi
    Private Sub txtTen_Leave(sender As Object, e As EventArgs) Handles txtTen.Leave
        If txtTen.Text.Trim.Length = 0 Then
            ErrorProvider2.SetError(txtTen, "Bạn chưa nhập Tên Nhân Viên.")
        Else
            ErrorProvider2.Clear()
        End If
    End Sub

    Private Sub cboTenPhanMem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenPhanMem.SelectedIndexChanged
        If (cboTenPhanMem.SelectedItem = "Khác") Then
            txtPhanMem_NV.Enabled = True
        Else
            txtPhanMem_NV.Enabled = False
            txtPhanMem_NV.Clear()
        End If
    End Sub

    '--------------------------------------------------------------------Bảng Hóa Đơn------------------------------------------------------------------------------
    'Bảng hóa đơn

    'Kiem tra du lieu textbox

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

        'Load dữ liệu chi tiết hóa đơn
        _TableCTHoaDon = LoadCTHoaDon(dgvCTHoaDon, txtMaHoaDon_HoaDon.Text)
        'dgvCTHoaDon.Rows(0).Selected = False
    End Sub

    'Xóa dữ liệu Hóa Đơn
    Private Sub btnXoa_HoaDon_Click(sender As Object, e As EventArgs) Handles btnXoa_HoaDon.Click
        If txtMaHoaDon_HoaDon.Text = "" And txtSoBan_HoaDon.Text = "" And txtMaHoaDonChung_HoaDon.Text = "" _
           And txtTenNV_HoaDon.Text = "" And txtGhiChu_HoaDon.Text = "" And txtTongTien_HoaDon.Text = "" Then
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
                    dgvHoaDon.Rows(0).Selected = False
                    dgvHoaDon.Rows(_location - 1).Selected = True
                    dgvHoaDon.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvHoaDon.Rows(0).Selected = False
                    dgvHoaDon.Rows(_location).Selected = True
                    dgvHoaDon.FirstDisplayedScrollingRowIndex = _location
                End If
            End If
        End If
    End Sub

    'Tìm kiếm HoaDon
    Private Sub btnTimKiem_HoaDon_Click(sender As Object, e As EventArgs) Handles btnTimKiem_HoaDon.Click

        If txtTimKiem_HoaDon.Text.Trim.Count = 0 Or txtTimKiem_HoaDon.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else
            dgvHoaDon.Rows.Clear()
            Dim _TableResult As New DataTable
            _TableResult = _TableHoaDon.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_HoaDon.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableHoaDon.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableHoaDon.Columns.Count - 1 Step 1
                    If _TableHoaDon.Rows(i).Item(j).ToString.Contains(_Word) Then


                        _TableResult.Rows.Add(_TableHoaDon.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then
                dgvHoaDon.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvHoaDon.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
        End If
    End Sub

    'Bảng Chi Tiết Hóa Đơn
    'Tìm dữ liệu hóa đơn
    Private Sub btnTimKiem_CTHD_Click(sender As Object, e As EventArgs) Handles btnTimKiem_CTHD.Click
    
        If txtTimKiem_CTHD.Text.Trim.Count = 0 Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableCTHoaDon.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_CTHD.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableCTHoaDon.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableCTHoaDon.Columns.Count - 1 Step 1
                    If _TableCTHoaDon.Rows(i).Item(j).ToString.Contains(_Word) Then


                        _TableResult.Rows.Add(_TableCTHoaDon.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then
                dgvCTHoaDon.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvCTHoaDon.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
        End If
    End Sub

    'Xóa dữ liệu ChiTietHoaDon
    Private Sub btnXoa_CTHoaDon_Click(sender As Object, e As EventArgs) Handles btnXoa_CTHoaDon.Click
        If txtMaHoaDon_CTHD.Text = "" And txtTenMon_CTHD.Text = "" And txtSoLuong_CTHD.Text = "" And txtGiaMotMon_CTHD.Text = "" _
          And txtGhiChuCTHoaDon.Text = "" And txtTongTien_CTHD.Text = "" Then
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
                    dgvCTHoaDon.Rows(0).Selected = False
                    dgvCTHoaDon.Rows(_location - 1).Selected = True
                    dgvCTHoaDon.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvCTHoaDon.Rows(0).Selected = False
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
            txtMaHoaDon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("MaHoaDon_CTHoaDon").Value.ToString()
            txtTenMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("TenMon_CTHoaDon").Value.ToString()
            txtSoLuong_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("SoLuong_CTHoaDon").Value.ToString()
            txtGiaMotMon_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GiaMotMon_CTHoaDon").Value.ToString()
            txtGhiChuCTHoaDon.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("GhiChu_CTHoaDon").Value.ToString()
            txtTongTien_CTHD.Text = dgvCTHoaDon.Rows(e.RowIndex).Cells("ThanhTien_CTHoaDon").Value.ToString()
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

        If txtGiaHienTai_Mon.Text.Trim.Length = 0 Or IsNumeric(txtGiaHienTai_Mon.Text.Trim) = False Then

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

    'Sửa MonAnDoUong
    Private Sub btnSua_Mon_Click(sender As Object, e As EventArgs) Handles btnSua_Mon.Click
        If txtMaHoaDon_HoaDon.Text = "" And txtSoBan_HoaDon.Text = "" And txtMaHoaDonChung_HoaDon.Text = "" _
            And txtTenNV_HoaDon.Text = "" And txtGhiChu_HoaDon.Text = "" And txtTongTien_HoaDon.Text = "" Then
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

    'Xóa MonAnDoUong
    Private Sub btnXoa_Mon_Click(sender As Object, e As EventArgs) Handles btnXoa_Mon.Click
        If txtMaHoaDon_HoaDon.Text = "" And txtSoBan_HoaDon.Text = "" And txtMaHoaDonChung_HoaDon.Text = "" _
           And txtTenNV_HoaDon.Text = "" And txtGhiChu_HoaDon.Text = "" And txtTongTien_HoaDon.Text = "" Then
            MessageBox.Show("Bạn chưa chọn Món", "Thông Báo")
        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then

                Dim _Query As String = "spMonAnDoUongDelete"
                Dim _Name() As String = New String() {"@MaDA"}
                Dim _Value() As String = New String() {txtMaMon_Mon.Text}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))

                Dim _word As String = txtMaMon_Mon.Text

                txtTenMon_Mon.Text = ""
                txtGiaHienTai_Mon.Text = ""


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
                    dgvMonAnDoUong.Rows(0).Selected = False
                    dgvMonAnDoUong.Rows(_location - 1).Selected = True
                    dgvMonAnDoUong.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvMonAnDoUong.Rows(0).Selected = False
                    dgvMonAnDoUong.Rows(_location).Selected = True
                    dgvMonAnDoUong.FirstDisplayedScrollingRowIndex = _location
                End If
            End If
        End If

    End Sub

    'Tìm kiếm MonAnDoUong
    Private Sub btnTimKiem_Mon_Click(sender As Object, e As EventArgs) Handles btnTimKiem_Mon.Click

        If txtTimKiem_Mon.Text.Trim.Count = 0 Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableMonAnDoUong.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_Mon.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableMonAnDoUong.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableMonAnDoUong.Columns.Count - 1 Step 1
                    If _TableMonAnDoUong.Rows(i).Item(j).ToString.Contains(_Word) Then


                        _TableResult.Rows.Add(_TableMonAnDoUong.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then
                dgvMonAnDoUong.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvMonAnDoUong.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
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

        Dim _CoboBoxSanPham As New DataTable
        _CoboBoxSanPham = _connect.Query("Select MaSP, TenSP From SanPham ")

        LoadComboBox(cboTenSP_CTMon, _CoboBoxSanPham, "TenSP", "MaSP")

    End Sub

    'Làm trống textbox
    Private Sub btnNhapLai_Mon_Click(sender As Object, e As EventArgs) Handles btnNhapLai_Mon.Click
        txtTenMon_Mon.Text = ""
        txtGiaHienTai_Mon.Text = ""
        cboLoai_MADU.SelectedIndex = 0
        cboThucDonMon_Mon.SelectedIndex = 0
    End Sub

    'Kiểm tra thông tin textbox bảng MonAnDoUong

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
        If txtGiaHienTai_Mon.Text.Trim = "" Or IsNumeric(txtGiaHienTai_Mon.Text.Trim) = False Then

            ErrorProvider2.SetError(txtGiaHienTai_Mon, "Bạn chưa nhập Giá Món.")
        Else
            ErrorProvider2.Clear()
        End If

    End Sub

    Private Sub txtTimKiem_Mon_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.TextChanged
        ErrorProvider4.Clear()
    End Sub

    'Kiểm tra thông tin textbox ChiTietMonAnDoUong
    Private Sub cboTenSP_CTMon_TextChanged(sender As Object, e As EventArgs) Handles cboTenSP_CTMon.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub cboTenSP_CTMon_Leave(sender As Object, e As EventArgs) Handles cboTenSP_CTMon.Leave
        If cboTenSP_CTMon.Text.Trim.Length = 0 Then
            ErrorProvider1.SetError(cboTenSP_CTMon, "Bạn chưa nhập Tên Sản Phẩm.")
        End If
    End Sub

    Private Sub txtSoLuong_CTMon_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuong_CTMon.TextChanged
        ErrorProvider2.Clear()
    End Sub

    Private Sub txtSoLuong_CTMon_Leave(sender As Object, e As EventArgs) Handles txtSoLuong_CTMon.Leave
        If txtSoLuong_CTMon.Text.Trim.Length = 0 Or IsNumeric(txtSoLuong_CTMon.Text.Trim) = False Then
            ErrorProvider2.SetError(txtSoLuong_CTMon, "Bạn chưa nhập Số Lượng.")
        End If
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

        If txtSoLuong_CTMon.Text.Length = 0 Or IsNumeric(txtSoLuong_CTMon.Text.Trim) = False Then

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

        If txtTenMon_CTMon.Text = "" And txtSoLuong_CTMon.Text = "" Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Món", "Thông Báo")

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
            dgvCTMon.Rows(0).Selected = False
            dgvCTMon.Rows(_location).Selected = True
            dgvCTMon.FirstDisplayedScrollingRowIndex = _location
        End If

    End Sub

    'Xóa dữ liệu ChiTIetMonAnDoUong
    Private Sub btnXoa_CTMon_Click(sender As Object, e As EventArgs) Handles btnXoa_CTMon.Click
        If txtTenMon_CTMon.Text = "" And txtSoLuong_CTMon.Text = "" Then
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
                        dgvCTMon.Rows(0).Selected = False
                        dgvCTMon.Rows(_location - 1).Selected = True
                        dgvCTMon.FirstDisplayedScrollingRowIndex = _location - 1
                    Else
                        dgvCTMon.Rows(0).Selected = False
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

            cboTenSP_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("TenSP_CTMonAn").Value.ToString()
            txtSoLuong_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("SoLuong_CTMonAn").Value.ToString()
            cboDonVi_CTMon.Text = dgvCTMon.Rows(e.RowIndex).Cells("TenDV_CTMonAn").Value.ToString()

            _MaSPCu = dgvCTMon.Rows(e.RowIndex).Cells("MaSP_CTMonAn").Value.ToString()

        End If
    End Sub

    'Tim ChiTietMonAnDoUong
    Private Sub btnTim_CTMon_Click(sender As Object, e As EventArgs) Handles btnTim_CTMon.Click
      
        If txtTimKiem_CTMon.Text.Trim.Count = 0 Or txtTimKiem_CTMon.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableCTMonAnDoUong.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_CTMon.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableCTMonAnDoUong.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableCTMonAnDoUong.Columns.Count - 1 Step 1
                    If _TableCTMonAnDoUong.Rows(i).Item(j).ToString.Contains(_Word) Then


                        _TableResult.Rows.Add(_TableCTMonAnDoUong.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then
                dgvCTMon.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvCTMon.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
        End If
    End Sub

    'Làm trống textbox

    Private Sub btnNhapLai_CTMon_Click(sender As Object, e As EventArgs) Handles btnNhapLai_CTMon.Click
        txtTenMon_CTMon.Text = ""
        txtSoLuong_CTMon.Text = ""
        cboTenSP_CTMon.SelectedIndex = 0
        cboDonVi_CTMon.SelectedIndex = 0
    End Sub




    '-------------------------------------------------------------------------------Bảng Phiếu Nhập--------------------------------------------------------------------
    'Load dữ liệu phiếu nhập
    Private Sub PhieuNhap_Enter(sender As Object, e As EventArgs) Handles PhieuNhap.Enter
        'Dim dsMonAnDoUong As DataTable

        _TablePhieuNhap = LoadPhieuNhap(dgvPhieuNhap)

        'Load ComboBox Tình Trạng
        cboTinhTrang_PhieuNhap.Items.Insert(0, "Đang Mở")
        cboTinhTrang_PhieuNhap.Items.Insert(1, "Đã Khóa")
        cboTinhTrang_PhieuNhap.SelectedIndex = 0
    End Sub

    'Xóa dữ liệu phiếu nhập
    Private Sub btnXoa_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnXoa_PhieuNhap.Click
        If txtMaPhieuNhap_PhieuNhap.Text = "" And txtTenNV_PhieuNhap.Text = "" And txtTenNCC_PhieuNhap.Text = "" And txtTongTien_PhieuNhap.Text = "" Then
            _Null = True
        Else
            _Null = False

        End If
        If _Null = True Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

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
                    dgvPhieuNhap.Rows(0).Selected = False
                    dgvPhieuNhap.Rows(_location - 1).Selected = True
                    dgvPhieuNhap.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvPhieuNhap.Rows(0).Selected = False
                    dgvPhieuNhap.Rows(_location).Selected = True
                    dgvPhieuNhap.FirstDisplayedScrollingRowIndex = _location
                End If

            End If
        End If

    End Sub

    'Cập nhật tình trạng phiếu nhập
    Private Sub btnMo_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnMo_PhieuNhap.Click
        DialogResult = MessageBox.Show("Khi mở phiếu nhập thì thông tin có thể bị thay đổi làm thay đổi số lượngs ản phẩm tồn trong kho. Bạn có chắc muốn mở phiếu nhập?", "Thông Báo", MessageBoxButtons.OKCancel)
        If DialogResult = Windows.Forms.DialogResult.OK Then


            If txtMaPhieuNhap_PhieuNhap.Text = "" And txtTenNV_PhieuNhap.Text = "" And txtTenNCC_PhieuNhap.Text = "" And txtTongTien_PhieuNhap.Text = "" Then
                _Null = True
            Else
                _Null = False

            End If
            If _Null = True Then
                MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

            Else
                Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
                Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
                Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 0}
                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
                dgvPhieuNhap.Enabled = True
                gpbThongTinPhieuNhap.Enabled = True
                cboTinhTrang_PhieuNhap.SelectedIndex = 0
                LoadPhieuNhap(dgvPhieuNhap)

                dgvPhieuNhap.Rows(0).Selected = False
                dgvPhieuNhap.Rows(_location).Selected = True
                dgvPhieuNhap.FirstDisplayedScrollingRowIndex = _location

            End If

        Else
            Return
        End If
    End Sub

    'Hoàn thành phiếu nhập
    Private Sub btnKhoa_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnKhoa_PhieuNhap.Click
        If txtMaPhieuNhap_PhieuNhap.Text = "" And txtTenNV_PhieuNhap.Text = "" And txtTenNCC_PhieuNhap.Text = "" And txtTongTien_PhieuNhap.Text = "" Then
            _Null = True
        Else
            _Null = False

        End If
        If _Null = True Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

        Else
            Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
            Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
            Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 1}
            _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
            gpbDanhSachCTPhieuNhap.Enabled = False
            LoadPhieuNhap(dgvPhieuNhap)

            'hiển thị dòng đã chọn
            gpbThongTinPhieuNhap.Enabled = False
            cboTinhTrang_PhieuNhap.SelectedIndex = 1

            dgvPhieuNhap.Rows(0).Selected = False
            dgvPhieuNhap.Rows(_location).Selected = True
            dgvPhieuNhap.FirstDisplayedScrollingRowIndex = _location
        End If
    End Sub

    'Chọn dòng phiếu nhập
    Private Sub dgvPhieuNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuNhap.CellClick
        _location = dgvPhieuNhap.SelectedRows(0).Index


        If e.RowIndex = dgvPhieuNhap.Rows.Count Then
            Return
        End If

        If e.RowIndex >= 0 Then
            txtMaPhieuNhap_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("MaPN_PNhap").Value.ToString()
            txtTenNV_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TenNV_PNhap").Value.ToString()
            txtTenNCC_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TenNCC_PNhap").Value.ToString()
            dtpNgayLap_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("NgayLap_PNhap").Value.ToString()
            dtpNgayGiaoDK_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("NgayGiaoDK_PNhap").Value.ToString()
            cboTinhTrang_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TinhTrang_PNhap").Value.ToString()
            txtTongTien_PhieuNhap.Text = dgvPhieuNhap.Rows(e.RowIndex).Cells("TongTien_PNhap").Value.ToString()


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
        'Làm trống textbox Chi Tiết Phiếu Nhập
        txtMaPhieuNhap_CTPhieuNhap.Text = ""
        txtTenSP_CTPhieuNhap.Text = ""
        txtSoLuong_CTPhieuNhap.Text = ""
        txtDonGia_CTPhieuNhap.Text = ""
        txtThanhTIen_CTPhieuNhap.Text = ""
    End Sub

    'Tìm phiếu nhập
    Private Sub btnTimKiem_PhieuNhap_Click(sender As Object, e As EventArgs) Handles btnTimKiem_PhieuNhap.Click
        If txtTimKiem_PhieuNhap.Text.Trim.Count = 0 Or txtTimKiem_PhieuNhap.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TablePhieuNhap.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_PhieuNhap.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TablePhieuNhap.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TablePhieuNhap.Columns.Count - 1 Step 1
                    If _TablePhieuNhap.Rows(i).Item(j).ToString.Contains(_Word) Then


                        _TableResult.Rows.Add(_TablePhieuNhap.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then

                dgvPhieuNhap.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvPhieuNhap.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
        End If
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

    'Xóa dữ liệu chi tiết phiếu nhập
    Private Sub btnXoa_CTPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnXoa_CTPhieuNhap.Click
        If txtMaPhieuNhap_CTPhieuNhap.Text = "" And txtTenSP_CTPhieuNhap.Text = "" And txtSoLuong_CTPhieuNhap.Text = "" And _
            txtDonGia_CTPhieuNhap.Text = "" And txtThanhTIen_CTPhieuNhap.Text = "" Then
            _Null = True
        Else
            _Null = False

        End If
        If _Null = True Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

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
                cboDonVi_CTPhieuNhap.SelectedIndex = 0
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

                'Hiển thị lại dòng đã chọn
                If _location = dgvChiTietPhieuNhap.Rows.Count Then
                    dgvChiTietPhieuNhap.Rows(0).Selected = False
                    dgvChiTietPhieuNhap.Rows(_location - 1).Selected = True
                    dgvChiTietPhieuNhap.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvChiTietPhieuNhap.Rows(0).Selected = False
                    dgvChiTietPhieuNhap.Rows(_location).Selected = True
                    dgvChiTietPhieuNhap.FirstDisplayedScrollingRowIndex = _location
                End If

            End If
        End If
    End Sub

    'Cập nhật tình trạng chi tiết phiếu nhập
    Private Sub btnMo_CTPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnMo_CTPhieuNhap.Click
        If txtMaPhieuNhap_CTPhieuNhap.Text = "" And txtTenSP_CTPhieuNhap.Text = "" And txtSoLuong_CTPhieuNhap.Text = "" And _
             txtDonGia_CTPhieuNhap.Text = "" And txtThanhTIen_CTPhieuNhap.Text = "" Then
            _Null = True
        Else
            _Null = False

        End If
        If _Null = True Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

        Else
            Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
            Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
            Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 0}
            _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
            gpbChiTietPhieuNhap.Enabled = True

            'Hiển thị lại dòng đã chọn
            dgvChiTietPhieuNhap.Rows(0).Selected = False
            dgvChiTietPhieuNhap.Rows(_location).Selected = True
            dgvChiTietPhieuNhap.FirstDisplayedScrollingRowIndex = _location
        End If

    End Sub

    'Hoàn thành chi tiết phiếu nhập
    Private Sub btnKhoa_CTPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnKhoa_CTPhieuNhap.Click
        If txtMaPhieuNhap_CTPhieuNhap.Text = "" And txtTenSP_CTPhieuNhap.Text = "" And txtSoLuong_CTPhieuNhap.Text = "" And _
            txtDonGia_CTPhieuNhap.Text = "" And txtThanhTIen_CTPhieuNhap.Text = "" Then
            _Null = True
        Else
            _Null = False

        End If
        If _Null = True Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

        Else
            Dim _Query As String = "usp_CapNhapTinhTrangPhieuNhap"
            Dim _Name() As String = New String() {"@MaPN", "@TinhTrang"}
            Dim _Value() As String = New String() {txtMaPhieuNhap_PhieuNhap.Text, 1}
            _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))
            gpbChiTietPhieuNhap.Enabled = False

            'Hiển thị lại dòng đã chọn
            dgvChiTietPhieuNhap.Rows(0).Selected = False
            dgvChiTietPhieuNhap.Rows(_location).Selected = True
            dgvChiTietPhieuNhap.FirstDisplayedScrollingRowIndex = _location
        End If
    End Sub

    'Hoàn thành chi tiết phiếu nhập
    Private Sub btnTim_CTPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnTim_CTPhieuNhap.Click
        If txtTim_CTPhieuNhap.Text.Trim.Count = 0 Or txtTim_CTPhieuNhap.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableCTPhieuNhap.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTim_CTPhieuNhap.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableCTPhieuNhap.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableCTPhieuNhap.Columns.Count - 1 Step 1
                    If _TableCTPhieuNhap.Rows(i).Item(j).ToString.Contains(_Word) Then

                        _TableResult.Rows.Add(_TableCTPhieuNhap.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then

                dgvChiTietPhieuNhap.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvChiTietPhieuNhap.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
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
        If txtMaPhieuNhap_PhieuNhan.Text = "" And txtMaPhieuNhan_PhieuNhan.Text = "" And txtTenNV_PhieuNhan.Text = "" _
            And txtGhiChu_PhieuNhan.Text = "" And txtTongTien_PhieuNhan.Text = "" Then
            _Null = True
        Else
            _Null = False

        End If
        If _Null = True Then
            MessageBox.Show("Bạn chưa chọn thông tin", "Thông Báo")

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

    'Tìm phiếu nhận
    Private Sub btnTim_PhieuNhan_Click(sender As Object, e As EventArgs) Handles btnTim_PhieuNhan.Click
        If txtTim_PhieuNhan.Text.Trim.Count = 0 Or txtTim_PhieuNhan.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TablePhieuNhan.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTim_PhieuNhan.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TablePhieuNhan.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TablePhieuNhan.Columns.Count - 1 Step 1
                    If _TablePhieuNhan.Rows(i).Item(j).ToString.Contains(_Word) Then

                        _TableResult.Rows.Add(_TablePhieuNhan.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then

                dgvPhieuNhan.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvPhieuNhan.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
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
        If txtMaPhieuNhap_ChiTietPhieuNhan.Text = "" And txtMaPhieuNhan_ChiTietPhieuNhan.Text = "" And txtTenSP_ChiTietPhieuNhan.Text = "" _
           And txtSoLuong_ChiTietPhieuNhan.Text = "" And txtMaSP_CTPhieuNhan.Text = "" Then
            _Null = True
        Else
            _Null = False

        End If
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
                    dgvChiTietPhieuNhan.Rows(0).Selected = False
                    dgvChiTietPhieuNhan.Rows(_location - 1).Selected = True
                    dgvChiTietPhieuNhan.FirstDisplayedScrollingRowIndex = _location - 1
                Else
                    dgvChiTietPhieuNhan.Rows(0).Selected = False
                    dgvChiTietPhieuNhan.Rows(_location).Selected = True
                    dgvChiTietPhieuNhan.FirstDisplayedScrollingRowIndex = _location
                End If
            Else
                MessageBox.Show("Xóa thất bại", "Thông Báo")
                Return
            End If
        End If

    End Sub

    'Tìm chi tiết phiếu nhận
    Private Sub btnTimChiTietPhieuNhan_Click(sender As Object, e As EventArgs) Handles btnTimChiTietPhieuNhan.Click
        If txtTim_ChiTietPhieuNhan.Text.Trim.Count = 0 Or txtTim_ChiTietPhieuNhan.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableCTPhieuNhan.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTim_ChiTietPhieuNhan.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableCTPhieuNhan.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableCTPhieuNhan.Columns.Count - 1 Step 1
                    If _TableCTPhieuNhan.Rows(i).Item(j).ToString.Contains(_Word) Then

                        _TableResult.Rows.Add(_TableCTPhieuNhan.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then

                dgvChiTietPhieuNhan.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvChiTietPhieuNhan.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
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

    'Kiểm tra dữ liệu trong textbox LoaiDonViTinh
    Private Sub txtTenDV_LoaiDonVi_TextChanged(sender As Object, e As EventArgs) Handles txtTenDV_LoaiDonVi.TextChanged
        ErrorProvider1.Clear()
    End Sub
    Private Sub txtTenDV_LoaiDonVi_Leave(sender As Object, e As EventArgs) Handles txtTenDV_LoaiDonVi.Leave
        If txtTenDV_LoaiDonVi.Text.Length = 0 Then
            ErrorProvider1.SetError(txtTenDV_LoaiDonVi, "Bạn chưa nhập tên đơn vị")
        End If
    End Sub

    'Xóa loại đơn vị
    Private Sub btnXoa_LoaiDV_Click(sender As Object, e As EventArgs) Handles btnXoa_LoaiDV.Click
        If txtMaDV_LoaiDonVi.Text = "" And txtTenDV_LoaiDonVi.Text = "" Then
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
                cboKieuGiaTri_LDVT.SelectedIndex = 0


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
                        dgvLoaiDonVi.Rows(0).Selected = False
                        dgvLoaiDonVi.FirstDisplayedScrollingRowIndex = _location - 1
                    Else
                        dgvLoaiDonVi.Rows(0).Selected = False
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
        If txtMaDV_LoaiDonVi.Text = "" And txtTenDV_LoaiDonVi.Text = "" Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Phiếu Nhận", "Thông Báo")

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
                dgvLoaiDonVi.Rows(0).Selected = False
                dgvLoaiDonVi.Rows(_location).Selected = True
                dgvLoaiDonVi.FirstDisplayedScrollingRowIndex = _location
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

        'Hiển thị dòng đã chọn
        dgvLoaiDonVi.Rows(0).Selected = False
        dgvLoaiDonVi.Rows(_location).Selected = True
        dgvLoaiDonVi.FirstDisplayedScrollingRowIndex = _location

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

    'Tìm đơn vị
    Private Sub btnTimKiem_LoaiDonVi_Click(sender As Object, e As EventArgs) Handles btnTimKiem_LoaiDonVi.Click
        If txtTimKiem_LoaiDonVi.Text.Trim.Count = 0 Or txtTimKiem_LoaiDonVi.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableLoaiDV.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_LoaiDonVi.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableLoaiDV.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableLoaiDV.Columns.Count - 1 Step 1
                    If _TableLoaiDV.Rows(i).Item(j).ToString.Contains(_Word) Then


                        _TableResult.Rows.Add(_TableLoaiDV.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then
                dgvLoaiDonVi.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvLoaiDonVi.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
        End If
    End Sub

    'Làm trống textbox
    Private Sub btnNhapLai_LoaiDonVi_Click(sender As Object, e As EventArgs) Handles btnNhapLai_LoaiDonVi.Click
        txtMaDV_LoaiDonVi.Text = ""
        txtTenDV_LoaiDonVi.Text = ""
        cboKieuGiaTri_LDVT.SelectedIndex = 0
    End Sub


    'Kiểm tra dữ liệu trong textbox ChucVu
    Private Sub txtTenCV_ChucVu_TextChanged(sender As Object, e As EventArgs) Handles txtTenCV_ChucVu.TextChanged
        ErrorProvider1.Clear()
    End Sub
    Private Sub txtTenCV_ChucVu_Leave(sender As Object, e As EventArgs) Handles txtTenCV_ChucVu.Leave
        If txtTenCV_ChucVu.Text.Trim.Length = 0 Then

            ErrorProvider1.SetError(txtTenCV_ChucVu, "Bạn chưa nhập tên chức vụ")

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

        dgvChucVu.Rows(0).Selected = False
        dgvChucVu.Rows(_location).Selected = True
        dgvChucVu.FirstDisplayedScrollingRowIndex = _location
    End Sub

    'Sữa chức vụ
    Private Sub btnSua_ChucVu_Click(sender As Object, e As EventArgs) Handles btnSua_ChucVu.Click
        If txtMaCV_ChucVu.Text = "" And txtTenCV_ChucVu.Text = "" Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Phiếu Nhận", "Thông Báo")

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
                dgvChucVu.Rows(0).Selected = False
                dgvChucVu.Rows(_location).Selected = True
                dgvChucVu.FirstDisplayedScrollingRowIndex = _location
            End If
        End If
    End Sub

    'Xóa chức vụ
    Private Sub btnXoa_ChucVu_Click(sender As Object, e As EventArgs) Handles btnXoa_ChucVu.Click
        If txtMaCV_ChucVu.Text = "" And txtTenCV_ChucVu.Text = "" Then
            MessageBox.Show("Bạn chưa chọn Chi Tiết Phiếu Nhận", "Thông Báo")

        Else

            DialogResult = MessageBox.Show("Bạn muốn thực hiện thao tác xóa?", "Thông Báo", MessageBoxButtons.OKCancel)

            If DialogResult = Windows.Forms.DialogResult.OK Then
                Dim _word As String = txtMaCV_ChucVu.Text.Trim
                Dim _Query As String = "spChucVuNhanVienDelete"
                Dim _Name() As String = New String() {"@MaChucVu"}
                Dim _Value() As String = New String() {_word}

                Dim kq As Boolean = True

                _connect.Update(_Query, _connect.CreateParameter(_Name, _Value))


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
                dgvChucVu.Rows(0).Selected = False
                dgvChucVu.Rows(_location).Selected = True
                dgvChucVu.FirstDisplayedScrollingRowIndex = _location
            End If

        End If
    End Sub

    'Làm trống textbox

    Private Sub btnNhapLai_ChucVuNV_Click(sender As Object, e As EventArgs) Handles btnNhapLai_ChucVuNV.Click
        txtMaCV_ChucVu.Text = ""
        txtTenCV_ChucVu.Text = ""
    End Sub

    'Tìm chức vụ
    Private Sub btnTimKiem_MaChucVu_Click(sender As Object, e As EventArgs) Handles btnTimKiem_MaChucVu.Click
        If txtTimKiem_ChucVu.Text.Trim.Count = 0 Or txtTimKiem_ChucVu.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            MessageBox.Show("Chưa có thông tin tim kiếm", "Thông Báo")
        Else

            Dim _TableResult As New DataTable
            _TableResult = _TableChucVu.Clone()
            Dim _KQ As Boolean = False

            Dim _Word As String = txtTimKiem_ChucVu.Text.ToString.Trim
            Dim temp As Integer = 0

            For i As Integer = 0 To _TableChucVu.Rows.Count - 1 Step 1
                For j As Integer = 0 To _TableChucVu.Columns.Count - 1 Step 1
                    If _TableChucVu.Rows(i).Item(j).ToString.Contains(_Word) Then


                        _TableResult.Rows.Add(_TableChucVu.Rows(i).ItemArray)
                        _KQ = True
                        _location = temp
                        temp = temp + 1
                    End If
                Next
            Next
            If _KQ = True Then
                dgvChucVu.Rows.Clear()
                For Each Row As DataRow In _TableResult.Rows
                    dgvChucVu.Rows.Add(Row.ItemArray)
                Next
            Else
                MessageBox.Show("Không tồn tại dữ liệu tìm kiếm đã nhập", "Thông Báo")
            End If
        End If
    End Sub

    '----------------------------------------------------------------------------------Thống Kê Món Ăn----------------------------------------------------------------------

    'Món Hoàn Thành

    'Thống Kê Theo Năm Món Hoàn Thành
    Private Sub btnThongKeNam_MonHT_Click(sender As Object, e As EventArgs) Handles btnThongKeNam_MonHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeNamMonHT(dgvMonHT, nbrNam_TKNam_MonHT.Value.ToString)
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Năm"
    End Sub

    ''Thống Kê Theo Quý Món Hoàn Thành
    Private Sub bntThongKeQuy_MonHT_Click(sender As Object, e As EventArgs) Handles bntThongKeQuy_MonHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeQuyMonHT(dgvMonHT, nbrQuy_TKQuy_MonHT.Value.ToString, nbrNam_TKNam_MonHT.Value.ToString)
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Quý"
    End Sub

    'Thống Kê Theo Tháng Món Hoàn Thành
    Private Sub bntThongKeThang_MonHT_Click(sender As Object, e As EventArgs) Handles bntThongKeThang_MonHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeThangMonHT(dgvMonHT, nbrThang_TKThang_MonHT.Value.ToString, nbrNam_TKThang_MonHT.Value.ToString)
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Tháng"
    End Sub

    'Thống Kê Theo Ngày Món Hoàn Thành
    Private Sub bntThongKeNgay_MonHT_Click(sender As Object, e As EventArgs) Handles bntThongKeNgay_MonHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeNgayMonHT(dgvMonHT, dtpNgay_MonHT.Value.ToString("yyyy/MM/dd"))
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Ngày"
    End Sub

    'Báo Cáo Món Hoàn Thành
    Private Sub btnBaoCao_MonHT_Click(sender As Object, e As EventArgs) Handles btnBaoCao_MonHT.Click
        'For i As Integer = 0 To _TableThongKe.Rows.Count - 1   
        '    With _TableThongKe.Rows(i)
        '        _DataReportViwe.Tables("ThongKe").Rows.Add(
        '    End With
        'Next

        _Report = New rptThongKe(_TableThongKe)
        _Report.Show()

    End Sub


    'Món Không Hoàn Thành
    'Thống Kê Theo Năm Món Không Hoàn Thành
    Private Sub bntThongKeNam_MonKHT_Click_1(sender As Object, e As EventArgs) Handles bntThongKeNam_MonKHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeNamMonKHT(dgvMonKHT, nbrNam_TKNam_MonKHT.Value.ToString)
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Năm"
    End Sub

    'Thống Kê Theo Quý Món Không Hoàn Thành
    Private Sub bntThongKeQuy_MonKHT_Click_1(sender As Object, e As EventArgs) Handles bntThongKeQuy_MonKHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeQuyMonKHT(dgvMonKHT, nbrQuy_TKQuy_MonKHT.Value.ToString, nbrNam_TKNam_MonKHT.Value.ToString)
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Quý"
    End Sub

    'Thống Kê Theo Tháng Món Không Hoàn Thành
    Private Sub bntThongKeThang_MonKHT_Click_1(sender As Object, e As EventArgs) Handles bntThongKeThang_MonKHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeThangMonKHT(dgvMonKHT, nbrThang_TKThang_MonKHT.Value.ToString, nbrNam_TKThang_MonKHT.Value.ToString)
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Tháng"
    End Sub

    'Thống Kê Theo Ngày Món Không Hoàn Thành
    Private Sub bntThongKeNgay_MonKHT_Click_1(sender As Object, e As EventArgs) Handles bntThongKeNgay_MonKHT.Click
        _TableThongKe = Nothing
        _TableThongKe = ThongKeNgayMonKHT(dgvMonKHT, dtpNgay_MonKHT.Value.ToString("yyyy/MM/dd"))
        gpbThongKeHT.Text = "Thông Tin Thống Kê Theo Ngày"
    End Sub

    'Báo Cáo Món Không Hoàn Thành
    Private Sub btnBaoCao_MonKHT_Click_1(sender As Object, e As EventArgs) Handles btnBaoCao_MonKHT.Click

    End Sub


    '-----------------------------------------------------------------------Thống Kê Nguyên Liệu Sử Dụng---------------------------------------------------------------------

    '-------------------------------------------------------------------------------------------Thống Kê Nguyên Liệu---------------------------------------------------------
    'Thống Kê Theo Năm Nguyên Liệu Sử Dụng
    Private Sub btnThongKeNam_NL_Click(sender As Object, e As EventArgs) Handles btnThongKeNam_NL.Click
        _TableThongKeNguyenLieu = Nothing
        _TableThongKeNguyenLieu = ThongKeNamNguyenLieu(dgvNguyenLieu, nbrNam_ThongKeNam_NL.Value.ToString)
        gpbNguyenLieu.Text = "Thông Tin Thống Kê Theo Năm"
    End Sub

    'Thống Kê Theo Quý Nguyên Liệu Sử Dụng
    Private Sub btnThongKeQuy_NL_Click(sender As Object, e As EventArgs) Handles btnThongKeQuy_NL.Click
        _TableThongKeNguyenLieu = Nothing
        _TableThongKeNguyenLieu = ThongKeQuyNguyenLieu(dgvNguyenLieu, nbrQuy_ThongKeQuy_NL.Value.ToString, nbrNam_ThongKeQuy_NL.Value.ToString)
        gpbNguyenLieu.Text = "Thông Tin Thống Kê Theo Quý"
    End Sub

    'Thống Kê Theo Tháng Nguyên Liệu Sử Dụng
    Private Sub btnThongKeThang_NL_Click(sender As Object, e As EventArgs) Handles btnThongKeThang_NL.Click
        _TableThongKeNguyenLieu = Nothing
        _TableThongKeNguyenLieu = ThongKeThangNguyenLieu(dgvNguyenLieu, nbrThang_ThongKeThang_NL.Value.ToString, nbrNam_ThongKeThang_NL.Value.ToString)
        gpbNguyenLieu.Text = "Thông Tin Thống Kê Theo Tháng"
    End Sub

    'Thống Kê Theo Ngày Nguyên Liệu Sử Dụng
    Private Sub btnThongKeNgay_NL_Click(sender As Object, e As EventArgs) Handles btnThongKeNgay_NL.Click
        _TableThongKeNguyenLieu = Nothing
        _TableThongKeNguyenLieu = ThongKeNgayNguyenLieu(dgvNguyenLieu, dtpNgay_ThongKeNgay_NL.Value.ToString("yyyy/MM/dd"))
        gpbNguyenLieu.Text = "Thông Tin Thống Kê Theo Ngày"
    End Sub

    'Báo Cáo Nguyên Liệu Sử Dụng
    Private Sub btnBaoCao_NL_Click(sender As Object, e As EventArgs) Handles btnBaoCao_NL.Click

    End Sub

    '------------------------------------------------------------------------------------Thống Kê Khách Theo Bàn-------------------------------------------------------------
    'Thống Kê Theo Năm Khách Theo Bàn
    Private Sub btnThongKeNam_Khach_Ban_Click(sender As Object, e As EventArgs) Handles btnThongKeNam_Khach_Ban.Click
        _TableThongKeKhach_Ban = Nothing
        _TableThongKeKhach_Ban = ThongKeNamKhach_Ban(dgvKhach_Ban, nbrNam_ThongKeNam_Khach_Ban.Value.ToString)
        gpbKhach_Ban.Text = "Thông Tin Thống Kê Theo Năm"
    End Sub

    'Thống Kê Theo Quý Khách Theo Bàn
    Private Sub btnThongKeQuy_Khach_Ban_Click(sender As Object, e As EventArgs) Handles btnThongKeQuy_Khach_Ban.Click
        _TableThongKeKhach_Ban = Nothing
        _TableThongKeKhach_Ban = ThongKeQuyKhach_Ban(dgvKhach_Ban, nbrQuy_ThongKeQuy_Khach_Ban.Value.ToString, nbrNam_ThongKeQuy_Khach_Ban.Value.ToString)
        gpbKhach_Ban.Text = "Thông Tin Thống Kê Theo Quý"
    End Sub

    'Thống Kê Theo Tháng Khách Theo Bàn
    Private Sub btnThongKeThang_Khach_Ban_Click(sender As Object, e As EventArgs) Handles btnThongKeThang_Khach_Ban.Click
        _TableThongKeKhach_Ban = Nothing
        _TableThongKeKhach_Ban = ThongKeThangKhach_Ban(dgvKhach_Ban, nbrThang_ThongKeThang_Khach_Ban.Value.ToString, nbrNam_ThongKeThang_Khach_Ban.Value.ToString)
        gpbKhach_Ban.Text = "Thông Tin Thống Kê Theo Tháng"
    End Sub

    'Thống Kê Theo Ngày Khách Theo Bàn
    Private Sub btnThongKeNgay_Khach_Ban_Click(sender As Object, e As EventArgs) Handles btnThongKeNgay_Khach_Ban.Click
        _TableThongKeKhach_Ban = Nothing
        _TableThongKeKhach_Ban = ThongKeNgayKhach_Ban(dgvKhach_Ban, dtpNgay_ThongKeNgay_Khach_Ban.Value)
        gpbKhach_Ban.Text = "Thông Tin Thống Kê Theo Ngày"
    End Sub

    'Báo Cáo Khách Theo Bàn
    Private Sub btnBaoCao_Khach_Ban_Click(sender As Object, e As EventArgs) Handles btnBaoCao_Khach_Ban.Click

    End Sub


    '------------------------------------------------------------------------------------Thống Kê Khách Theo Nhân Viên---------------------------------------------------------
    Private Sub btnThongKeTuan_Khach_NhanVien_Click(sender As Object, e As EventArgs) Handles btnThongKeTuan_Khach_NhanVien.Click
        _TableThongKeKhach_NhanVien = Nothing
        _TableThongKeKhach_NhanVien = ThongKeTuanKhach_NhanVien(dgvKhach_NhanVien, dtpNgay_Khach_NV.Value.ToString("yyyy/MM/dd"))
    End Sub

    Private Sub btnBaoCao_Khach_NhanVien_Click(sender As Object, e As EventArgs) Handles btnBaoCao_Khach_NhanVien.Click

    End Sub

    '--------------------------------------------------------------------------------Thống Kê Khách Hàng Theo Món Ăn Đồ Uống-------------------------------------------------

    'Thống Kê Theo Năm Khách Hàng Theo Món Ăn Đồ Uống
    Private Sub btnThongKeNam_Khach_Mon_Click(sender As Object, e As EventArgs) Handles btnThongKeNam_Khach_Mon.Click
        _TableThongKeKhach_Mon = Nothing
        _TableThongKeKhach_Mon = ThongKeNamKhach_Mon(dgvKhach_Mon, nbrNam_ThongKeNam_Khach_Mon.Value.ToString)
        gpbKhach_Mon.Text = "Thông Tin Thống Kê Theo Năm"
    End Sub

    'Thống Kê Theo Quý Khách Hàng Theo Món Ăn Đồ Uống
    Private Sub btnThongKeQuy_Khach_Mon_Click(sender As Object, e As EventArgs) Handles btnThongKeQuy_Khach_Mon.Click
        _TableThongKeKhach_Mon = Nothing
        _TableThongKeKhach_Mon = ThongKeQuyKhach_Mon(dgvKhach_Mon, nbrQuy_ThongKeQuy_Khach_Mon.Value.ToString, nbrNam_ThongKeQuy_Khach_Mon.Value.ToString)
        gpbKhach_Mon.Text = "Thông Tin Thống Kê Theo Quý"
    End Sub

    'Thống Kê Theo Tháng Khách Hàng Theo Món Ăn Đồ Uống
    Private Sub btnThongKeThang_Khach_Mon_Click(sender As Object, e As EventArgs) Handles btnThongKeThang_Khach_Mon.Click
        _TableThongKeKhach_Mon = Nothing
        _TableThongKeKhach_Mon = ThongKeThangKhach_Mon(dgvKhach_Mon, nbrThang_ThongKeThang_Khach_Mon.Value.ToString, nbrNam_ThongKeThang_Khach_Mon.Value.ToString)
        gpbKhach_Mon.Text = "Thông Tin Thống Kê Theo Tháng"
    End Sub

    'Báo Cáo Khách Hàng Theo Món Ăn Đồ Uống
    Private Sub btnBaoCao_Khach_Mon_Click(sender As Object, e As EventArgs) Handles btnBaoCao_Khach_Mon.Click

    End Sub


    '-------------------------------------------------------------------------------------Thống Kê Doanh Thu----------------------------------------------------------------------

    'Thống Kê Theo Năm Doanh Thu
    Private Sub btnThongKeNam_DoanhThu_Click(sender As Object, e As EventArgs) Handles btnThongKeNam_DoanhThu.Click
        _TableThongKeDoanhThu = Nothing
        _TableThongKeDoanhThu = ThongKeNamDoanhThu(dgvDoanhThu, nbrNam_ThongKeNam_DoanhThu.Value.ToString)
        gpbThongKeDoanhThu.Text = "Thông Tin Thống Kê Theo Năm"
    End Sub

    'Thống Kê Theo Quý Doanh Thu
    Private Sub btnThongKeThang_DoanhThu_Click(sender As Object, e As EventArgs) Handles btnThongKeThang_DoanhThu.Click
        _TableThongKeDoanhThu = Nothing
        _TableThongKeDoanhThu = ThongKeThangDoanhThu(dgvDoanhThu, nbrThang_ThongKeThang_DoanhThu.Value.ToString, nbrNam_ThongKeThang_DoanhThu.Value.ToString)
        gpbThongKeDoanhThu.Text = "Thông Tin Thống Kê Theo Tháng"
    End Sub

    'Thống Kê Theo Thang Doanh Thu
    Private Sub btnThongKeQuy_DoanhThu_Click(sender As Object, e As EventArgs) Handles btnThongKeQuy_DoanhThu.Click
        _TableThongKeDoanhThu = Nothing
        _TableThongKeDoanhThu = ThongKeQuyDoanhThu(dgvDoanhThu, nbrQuy_ThongKeQuy_DoanhThu.Value.ToString, nbrNam_ThongKeQuy_DoanhThu.Value.ToString)
        gpbThongKeDoanhThu.Text = "Thông Tin Thống Kê Theo Quý"
    End Sub

    'Báo Cáo Doanh Thu
    Private Sub btnBaoCao_DoanhThu_Click(sender As Object, e As EventArgs) Handles btnBaoCao_DoanhThu.Click

    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'Tìm Kiếm
    Private Sub TextBoxSearch_Enter(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.Enter, txtTimKiem_CTHD.Enter, _
       txtTimKiem_CTMon.Enter, txtTim_CTPhieuNhap.Enter, txtTimKiem_HoaDon.Enter, txtTimKiem_NhanVien.Enter, txtTimKiem_PhieuNhap.Enter, _
       txtTimKiem_ChucVu.Enter, txtTimKiem_LoaiDonVi.Enter, txtTim_PhieuNhan.Enter, txtTim_ChiTietPhieuNhan.Enter, txtTimKiem_LoaiDonVi.Leave, txtTimKiem_ChucVu.Enter

        Dim textBox As TextBox = DirectCast(sender, TextBox)

        If textBox.Text.Trim = "Nhập thông tin cần tìm vào đây" Then
            textBox.Text = ""
        Else
            Return
        End If


    End Sub


    Private Sub TextBoxSearch_Leave(sender As Object, e As EventArgs) Handles txtTimKiem_Mon.Leave, txtTimKiem_CTHD.Leave, _
       txtTimKiem_CTMon.Leave, txtTim_CTPhieuNhap.Leave, txtTimKiem_HoaDon.Leave, txtTimKiem_NhanVien.Leave, txtTimKiem_PhieuNhap.Leave, _
       txtTimKiem_ChucVu.Leave, txtTimKiem_LoaiDonVi.Leave, txtTim_PhieuNhan.Leave, txtTim_ChiTietPhieuNhan.Leave, txtTimKiem_LoaiDonVi.Leave, txtTimKiem_ChucVu.Leave
        Dim textBox As TextBox = DirectCast(sender, TextBox)

        If textBox.Text.Trim = "" Then
            textBox.Text = "Nhập thông tin cần tìm vào đây"
            ErrorProvider4.Clear()
        End If

    End Sub

    'Đóng Form
    Private Sub frmManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _connect.Dispose()
    End Sub

End Class
