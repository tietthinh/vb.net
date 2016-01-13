Imports System.Data.SqlClient
Imports Library

Public Class frmWarehouseKeeper

    'Fields:
    ''' <summary>
    ''' Form for adding mail for Supplier.
    ''' </summary>
    ''' <remarks></remarks>
    Dim frmEmail As frmContact
    Dim frmDienThoai As frmContact
    Public _CurrentUser As User = Nothing
    Private Connection As New DatabaseConnection()
    Dim rowIndex As New Integer
    Dim listEmail(-1) As String
    Public Shared listPhone(-1) As String

    Private Sub btnPhieuNhan_Click(sender As Object, e As EventArgs) Handles btnPhieuNhan.Click
        Dim f = New FrmQLPhieuNhan()
        f.Show()
    End Sub

    Private Sub btnPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnPhieuNhap.Click
        Dim f = New FrmQLPhieuNhap()
        f.Show()
    End Sub

    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles btnThemSP.Click
        errMain.Clear()
        If txtTenSanPham.Text = "" Then
            errMain.SetError(txtTenSanPham, "Tên sản phẩm khác rỗng!")
        End If
        If txtSoLuong.Text = "" Then
            errMain.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errMain.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cboDonVi.Text = "" Then
            errMain.SetError(cboDonVi, "Chọn đơn vị!")
        End If

        If errMain.GetError(txtTenSanPham) = "" And errMain.GetError(txtSoLuong) = "" And errMain.GetError(cboDonVi) = "" Then
            Dim _Query As String = "spSanPhamInsert"
            Dim _Name() As String = {("@TenSP"), ("@SoLuongTon"), ("@DonViTinh")}
            Dim _Value() As Object = {txtTenSanPham.Text, txtSoLuong.Text, cboDonVi.SelectedValue}
            Connection.Update(_Query, Connection.CreateParameter(_Name, _Value))

            loadDSSanPham()
        End If
    End Sub

    Private Sub btnTimSP_Click(sender As Object, e As EventArgs) Handles btnTimSP.Click
        errMain.Clear()
        If txtTimSP.Text = "" Then
            errMain.SetError(txtTimSP, "Nhập thông tin sản phẩm cần tìm!")
        End If
        If errMain.GetError(txtTimSP) = "" Then
            Dim _colName As String = ""
            If IsNumeric(txtTimSP.Text) = True Then
                _colName = "SoLuongTon"
                timKiemSP(_colName)
            Else
                _colName = "TenDV"
                Dim kq As Integer = timKiemSP(_colName)
                If kq = 0 Then
                    _colName = "TenSP"
                    timKiemSP(_colName)
                End If
            End If
        Else
        End If
    End Sub

    Private Sub btnThemNCC_Click(sender As Object, e As EventArgs) Handles btnThemNCC.Click
        errMain.Clear()
        If txtTenNCC.Text = "" Then
            errMain.SetError(txtTenNCC, "Tên nhà cung cấp khác rỗng!")
        End If
        If txtChietKhau.Text = "" Then
            errMain.SetError(txtChietKhau, "Chọn chiết khấu!")
        Else
            If txtChietKhau.Text > 10 Then
                errMain.SetError(txtChietKhau, "Chiết khấu bé hơn hoặc bằng 10!")
            End If
        End If
        If txtDiaChi.Text = "" Then
            errMain.SetError(txtDiaChi, "Nhập địa chỉ!")
        End If

        If errMain.GetError(txtTenNCC) = "" And errMain.GetError(txtChietKhau) = "" And errMain.GetError(txtDiaChi) = "" Then
            Dim _Name() As String = New String() {"@TenNCC", "@DiaChi", "@ChietKhau", "@GhiChu"}
            Dim _Value() As Object = New Object() {txtTenNCC.Text, txtDiaChi.Text, txtChietKhau.Text, txtGhiChu.Text}
            Connection.Update("spNhaCungCapInsert", Connection.CreateParameter(_Name, _Value))
            loadDSNCC()
        End If
    End Sub

    Private Sub btnXoaNCC_Click(sender As Object, e As EventArgs) Handles btnXoaNCC.Click
        If (MessageBox.Show("Bạn chắc rằng muốn xóa thông tin nhà cung cấp này?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _Name() As String = {"@MaNCC"}
            Dim _Value() As Object = {dgvDSNhaCungCap.SelectedRows(0).Cells(0).Value.ToString.Trim}
            Try
                Connection.Update("spNhaCungCapDelete", Connection.CreateParameter(_Name, _Value))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            loadDSNCC()
        End If
    End Sub

    Private Sub btnSuaNCC_Click(sender As Object, e As EventArgs) Handles btnSuaNCC.Click
        errMain.Clear()
        If txtTenNCC.Text = "" Then
            errMain.SetError(txtTenNCC, "Tên nhà cung cấp khác rỗng!")
        End If
        If txtChietKhau.Text = "" Then
            errMain.SetError(txtChietKhau, "Chọn chiết khấu!")
        Else
            If txtChietKhau.Text > 10 Then
                errMain.SetError(txtChietKhau, "Chiết khấu bé hơn hoặc bằng 10!")
            End If
        End If
        If txtDiaChi.Text = "" Then
            errMain.SetError(txtDiaChi, "Nhập địa chỉ!")
        End If

        If errMain.GetError(txtTenNCC) = "" And errMain.GetError(txtChietKhau) = "" And errMain.GetError(txtDiaChi) = "" Then
            Dim _Name() As String = New String() {"@MaNCC", "@TenNCC", "@DiaChi", "@ChietKhau", "@GhiChu"}
            Dim _Value() As Object = New Object() {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value(), txtTenNCC.Text, txtDiaChi.Text, txtChietKhau.Text, txtGhiChu.Text}
            Connection.Update("spNhaCungCapUpdate", Connection.CreateParameter(_Name, _Value))
            loadDSNCC()
        End If
    End Sub

    Private Sub btnTimNCC_Click(sender As Object, e As EventArgs) Handles btnTimNCC.Click
        errMain.Clear()
        If txtTimNCC.Text = "" Then
            errMain.SetError(txtTimNCC, "Nhập thông tin cần tìm!")
        End If
        If errMain.GetError(txtTimNCC) = "" Then
            Dim temp As Integer = 0
            dgvDSNhaCungCap.ClearSelection()
            For i As Integer = 0 To dgvDSNhaCungCap.RowCount - 1
                For j As Integer = 0 To dgvDSNhaCungCap.ColumnCount - 1
                    If dgvDSNhaCungCap.Rows(i).Cells(j).Value.ToString.Trim.Contains(txtTimNCC.Text) Then
                        temp = 1
                        dgvDSNhaCungCap.Rows(i).Selected = True
                        dgvDSNhaCungCap.Select()
                    End If
                Next
            Next
            If temp = 0 Then
                MsgBox("Không tìm thấy")
            End If
        End If
    End Sub

    Private Sub frmWarehouseKeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Login As New frmLogin(EmployeeType.Waitor)
        _Login.ShowDialog()
        _CurrentUser = DatabaseConnection._User
        If (_Login.DialogResult = 1) Then
            loadDSSanPham()

            txtTenSanPham.Text = dgvDSSanPham.SelectedRows(0).Cells("colTenSP").Value.ToString
            txtSoLuong.Text = dgvDSSanPham.SelectedRows(0).Cells("colSoLuongTon").Value.ToString
            cboDonVi.Text = dgvDSSanPham.SelectedRows(0).Cells("colTenDV").Value.ToString

            loadDSNCC()

            txtTenNCC.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colTenNCC").Value().ToString
            txtChietKhau.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colChietKhau").Value().ToString
            txtDiaChi.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colDiaChi").Value().ToString
            txtGhiChu.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colGhiChu").Value().ToString
            Dim _cboEmail As DataGridViewComboBoxCell = dgvDSNhaCungCap.SelectedRows(0).Cells("colEmail")
            cboEmail.DataSource = _cboEmail.DataSource
            cboEmail.DisplayMember = "Email"
            cboEmail.ValueMember = "Email"

            Dim _cboDienThoai As DataGridViewComboBoxCell = dgvDSNhaCungCap.SelectedRows(0).Cells("colSDT")
            cboDienThoai.DataSource = _cboDienThoai.DataSource
            cboDienThoai.DisplayMember = "SDT"
            cboDienThoai.ValueMember = "SDT"

            Dim _dtDonVi As DataTable = Connection.Query("spLoaiDonViTinhSelect")
            cboDonVi.DataSource = _dtDonVi
            cboDonVi.DisplayMember = "TenDV"
            cboDonVi.ValueMember = "MaDV"

            tslMaNV.Text = _CurrentUser.Identity
            tslTenNV.Text = _CurrentUser.EmployeeName
        Else
            Me.Close()
        End If
    End Sub
    '
    'btnCong1's Events:
    '
    'Click: Occur when btnCong1 is clicked
    '
    Private Sub btnCong1_Click(sender As Object, e As EventArgs) Handles btnCong1.Click
        'If txtTenNCC's Text is not null then show the frmEmail with Supplier's name in that form.
        If txtTenNCC.Text <> "" Then
            frmEmail = New frmContact()
            frmEmail._SupplierName = txtTenNCC.Text
            Dim result As DialogResult = frmEmail.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                listEmail = frmEmail._ListObject

                Dim temp As DataTable = cboEmail.DataSource
                AppendEmail(temp, listEmail)
            End If
        End If
    End Sub

    Private Sub btnCong2_Click(sender As Object, e As EventArgs) Handles btnCong2.Click
        If txtTenNCC.Text <> "" Then
            frmDienThoai = New frmContact()
            frmDienThoai._SupplierName = txtTenNCC.Text
            Dim result As DialogResult = frmDienThoai.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                listPhone = frmDienThoai._ListObject

                Dim temp As DataTable = cboDienThoai.DataSource
                AppendPhone(temp, listPhone)
            End If
        End If
    End Sub

    Private Sub loadDSSanPham()
        Dim _dtDSSanPham As DataTable = Connection.Query("spSanPhamSelect")
        dgvDSSanPham.DataSource = _dtDSSanPham
    End Sub

    Private Sub loadDSNCC()
        Dim _dtDSNCC As DataTable = Connection.Query("spNhaCungCapSelect")

        dgvDSNhaCungCap.DataSource = _dtDSNCC

        For Each row As DataGridViewRow In dgvDSNhaCungCap.Rows
            Dim _Email As DataTable
            Dim _Name() As String = New String() {"@MaNCC"}
            Dim _Value() As String = New String() {row.Cells("colMaNCC").Value.ToString()}
            Dim _Phone As DataTable

            _Email = Connection.Query("spNhaCungCap_EmailSelect", Connection.CreateParameter(_Name, _Value))

            Dim cellMail As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()

            BindDataGridViewComboBox(cellMail, _Email, "Email", "MaNCC", row.Cells("colMaNCC").Value, "Không có")
            row.Cells("colEmail") = cellMail

            _Phone = Connection.Query("spNhaCungCap_DienThoaiSelect", Connection.CreateParameter(_Name, _Value))

            Dim cellPhone As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()

            BindDataGridViewComboBox(cellPhone, _Phone, "SDT", "MaNCC", row.Cells("colMaNCC").Value, "Không có")
            row.Cells("colSDT") = cellPhone

            cellMail.Dispose()
            cellPhone.Dispose()
            cellMail = Nothing
            cellPhone = Nothing
        Next
    End Sub

    Private Sub btnSuaSP_Click(sender As Object, e As EventArgs) Handles btnSuaSP.Click
        errMain.Clear()
        If txtTenSanPham.Text = "" Then
            errMain.SetError(txtTenSanPham, "Tên sản phẩm khác rỗng!")
        End If
        If txtSoLuong.Text = "" Then
            errMain.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errMain.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cboDonVi.Text = "" Then
            errMain.SetError(cboDonVi, "Chọn đơn vị!")
        End If

        If errMain.GetError(txtTenSanPham) = "" And errMain.GetError(txtSoLuong) = "" And errMain.GetError(cboDonVi) = "" Then
            Dim _Query As String = "spSanPhamUpdate"
            Dim _Name() As String = {("@MaSP"), ("@TenSP"), ("@SoLuong"), ("@MaDV")}
            Dim _Value() As Object = {dgvDSSanPham.SelectedRows(0).Cells("colMaSP").Value(), txtTenSanPham.Text, txtSoLuong.Text, cboDonVi.SelectedValue}
            Connection.Query(_Query, Connection.CreateParameter(_Name, _Value))

            loadDSSanPham()
        End If
    End Sub

    Public Sub dgvDSSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSSanPham.CellClick
        If dgvDSSanPham.SelectedRows(0).Cells("colMaSP").Value.ToString <> "" Then
            txtTenSanPham.Text = dgvDSSanPham.SelectedRows(0).Cells("colTenSP").Value.ToString
            txtSoLuong.Text = dgvDSSanPham.SelectedRows(0).Cells("colSoLuongTon").Value.ToString
            cboDonVi.Text = dgvDSSanPham.SelectedRows(0).Cells("colTenDV").Value.ToString
        Else
            txtTenSanPham.Text = ""
            txtSoLuong.Text = ""
            cboDonVi.Text = ""
        End If
    End Sub

    Private Sub btnXoaSP_Click(sender As Object, e As EventArgs) Handles btnXoaSP.Click
        If (MessageBox.Show("Bạn chắc rằng muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _Query As String = "spSanPhamDelete"
            Dim _Name() As String = {"@MaSP"}
            Dim _Value() As Object = {dgvDSSanPham.SelectedRows(0).Cells(0).Value.ToString.Trim}
            Try
                Connection.Query(_Query, Connection.CreateParameter(_Name, _Value))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            loadDSSanPham()
        End If
    End Sub

    Private Function timKiemSP(ByVal _colName As String) As Integer
        Dim _dt As DataTable = Connection.Query("spSanPhamSelect")
        Dim _dv As DataView = New DataView(_dt, _colName + "=" + "'" + txtTimSP.Text + "'", "SoLuongTon Desc", DataViewRowState.CurrentRows)
        dgvDSSanPham.DataSource = _dv
        If dgvDSSanPham.Rows(rowIndex).Cells(0).Value() = "" Then
            Return 0
        Else
            Return 1
        End If
    End Function

    Private Sub txtTimSP_TextChanged(sender As Object, e As EventArgs) Handles txtTimSP.TextChanged
        loadDSSanPham()
    End Sub

    Private Sub dgvDSNhaCungCap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSNhaCungCap.CellClick
        lblChietKhau.Text = "Chiết khấu"
        txtChietKhau.Text = ""
        btnHoanTat.Visible = False
        rowIndex = e.RowIndex
        If IsNothing(dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value()) = False Then
            txtTenNCC.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colTenNCC").Value().ToString
            txtChietKhau.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colChietKhau").Value().ToString
            txtDiaChi.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colDiaChi").Value().ToString
            txtGhiChu.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colGhiChu").Value().ToString

            Dim cmbEmail As DataGridViewComboBoxCell = dgvDSNhaCungCap.Rows(e.RowIndex).Cells("colEmail")
            cboEmail.DataSource = cmbEmail.DataSource
            cboEmail.DisplayMember = "Email"
            cboEmail.ValueMember = "Email"

            Dim cmbSDT As DataGridViewComboBoxCell = dgvDSNhaCungCap.Rows(e.RowIndex).Cells("colSDT")
            cboDienThoai.DataSource = cmbSDT.DataSource
            cboDienThoai.ValueMember = "SDT"
            cboDienThoai.DisplayMember = "SDT"
        Else
            txtTenNCC.Text = ""
            txtChietKhau.Text = ""
            txtDiaChi.Text = ""
            txtGhiChu.Text = ""

            cboEmail.DataSource = Nothing
            cboEmail.DisplayMember = Nothing
            cboEmail.ValueMember = Nothing

            cboDienThoai.DataSource = Nothing
            cboDienThoai.ValueMember = Nothing
            cboDienThoai.DisplayMember = Nothing
        End If
    End Sub

    Private Sub btnThemEmail_Click(sender As Object, e As EventArgs) Handles btnThemEmail.Click
        errMain.Clear()
        If cboEmail.Text = "" Then
            errMain.SetError(cboEmail, "Nhập email cần thêm")
        End If

        If errMain.GetError(cboEmail) = "" Then
            Dim _returnEmail As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaNCC", "@Email"}
            Dim _Value() As Object = {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value, cboEmail.Text}
            Connection.Update("spNhaCungCap_EmailInsert", _returnEmail, Connection.CreateParameter(_Name, _Value))
            Dim _kq As Integer = _returnEmail.Value
            If _kq = 1 Then
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Thao tác thành công!")
                loadDSNCC()
            End If
        End If
    End Sub

    Private Sub btnXoaEmail_Click(sender As Object, e As EventArgs) Handles btnXoaEmail.Click
        If (MessageBox.Show("Bạn chắc rằng muốn xóa email này?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _Name() As String = {"@MaNCC", "@Email"}
            Dim _Value() As Object = {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value.ToString.Trim, cboEmail.SelectedValue}
            Try
                Connection.Update("spNhaCungCap_EmailDelete", Connection.CreateParameter(_Name, _Value))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            loadDSNCC()
        End If
    End Sub

    Private Sub btnSuaEmail_Click(sender As Object, e As EventArgs) Handles btnSuaEmail.Click
        errMain.Clear()
        If cboEmail.Text = "" Then
            errMain.SetError(cboEmail, "Chọn email cần sửa")
        End If
        If dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value = "" Then
            errMain.SetError(dgvDSNhaCungCap, "Chọn nhà cung cấp cần cập nhật!")
        End If
        If errMain.GetError(cboEmail) = "" And errMain.GetError(dgvDSNhaCungCap) = "" Then
            lblChietKhau.Text = "Email mới"
            txtChietKhau.Text = "Nhập email mới vào đây!"
            btnHoanTat.Visible = True
        End If
    End Sub

    Private Sub btnHoanTat_Click(sender As Object, e As EventArgs) Handles btnHoanTat.Click
        If lblChietKhau.Text = "Email mới" Then
            Dim _returnSuaMail As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaNCC", "@EmailCu", "@EmailMoi"}
            Dim _Value() As Object = {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value, cboEmail.Text, txtChietKhau.Text}
            Connection.Update("spNhaCungCap_EmailUpdate", _returnSuaMail, Connection.CreateParameter(_Name, _Value))
            Dim _kq As Integer = _returnSuaMail.Value
            If _kq = 1 Then
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Thao tác thành công!")
                loadDSNCC()
                lblChietKhau.Text = "Chiết khấu"
                txtChietKhau.Text = ""
                btnHoanTat.Visible = False
            End If
        End If
        If lblChietKhau.Text = "SDT mới" Then
            Dim _returnSuaSDT As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaNCC", "@SDTCu", "@SDTMoi"}
            Dim _Value() As Object = {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value, cboDienThoai.Text, txtChietKhau.Text}
            Connection.Update("spNhaCungCap_DienThoaiUpdate", _returnSuaSDT, Connection.CreateParameter(_Name, _Value))
            Dim _kq As Integer = _returnSuaSDT.Value
            If _kq = 1 Then
                MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Thao tác thành công!")
                loadDSNCC()
                lblChietKhau.Text = "Chiết khấu"
                txtChietKhau.Text = ""
                btnHoanTat.Visible = False
            End If
        End If
    End Sub

    Private Sub btnSuaSDT_Click(sender As Object, e As EventArgs) Handles btnSuaSDT.Click
        errMain.Clear()
        If cboDienThoai.Text = "" Then
            errMain.SetError(cboDienThoai, "Chọn số điện thoại cần sửa!")
        End If
        If dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value = "" Then
            errMain.SetError(dgvDSNhaCungCap, "Chọn nhà cung cấp cần cập nhật!")
        End If
        If errMain.GetError(cboDienThoai) = "" And errMain.GetError(dgvDSNhaCungCap) = "" Then
            lblChietKhau.Text = "SDT mới"
            txtChietKhau.Text = "Nhập số điện thoại mới vào đây!"
            btnHoanTat.Visible = True
        End If
    End Sub

    Private Sub btnThemSDT_Click(sender As Object, e As EventArgs) Handles btnThemSDT.Click
        errMain.Clear()
        If cboDienThoai.Text = "" Then
            errMain.SetError(cboEmail, "Nhập email cần thêm")
        End If

        If errMain.GetError(txtTenSanPham) = "" And errMain.GetError(txtSoLuong) = "" And errMain.GetError(cboDonVi) = "" Then
            Dim _returnEmail As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaNCC", "@Email"}
            Dim _Value() As Object = {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value, cboEmail.Text}
            Connection.Update("spNhaCungCap_EmailInsert", _returnEmail, Connection.CreateParameter(_Name, _Value))
            Dim _kq As Integer = _returnEmail.Value
            If _kq = 1 Then
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox("Thao tác thành công!")
                loadDSNCC()
            End If
        End If
    End Sub
End Class
