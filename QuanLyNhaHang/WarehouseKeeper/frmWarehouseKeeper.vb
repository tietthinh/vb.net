Imports Library

Public Class frmWarehouseKeeper

    'Fields:
    ''' <summary>
    ''' Form for adding mail for Supplier.
    ''' </summary>
    ''' <remarks></remarks>
    Dim frmEmail As New frmContact()
    Dim frmDienThoai As New frmContact()
    Public _CurrentUser As User = Nothing
    Private Connection As New DatabaseConnection()
    Dim rowIndex As New Integer

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
            For i As Integer = 0 To dgvDSNhaCungCap.RowCount - 1
                For j As Integer = 0 To dgvDSNhaCungCap.ColumnCount - 1
                    If dgvDSNhaCungCap.Rows(i).Cells(j).Value.ToString = txtTimNCC.Text Then
                        MsgBox("Item found")
                        temp = 1
                        dgvDSNhaCungCap.CurrentCell = dgvDSNhaCungCap.Rows(i).Cells(j)
                    End If
                Next
            Next
            If temp = 0 Then
                MsgBox("Item not found")
            End If
        End If
    End Sub

    Private Sub frmWarehouseKeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Login As New frmLogin(EmployeeType.Waitor)
        _Login.ShowDialog()
        _CurrentUser = DatabaseConnection._User
        If (_Login.DialogResult = 1) Then
            loadDSSanPham()

            loadDSNCC()

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
            frmEmail._SupplierName = txtTenNCC.Text
            frmEmail.Show()
        End If
    End Sub

    Private Sub btnCong2_Click(sender As Object, e As EventArgs) Handles btnCong2.Click
        If txtTenNCC.Text <> "" Then
            frmDienThoai._SupplierName = txtTenNCC.Text
            frmDienThoai.Show()
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
        rowIndex = e.RowIndex
        If IsNothing(dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value()) = False Then
            txtTenNCC.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colTenNCC").Value().ToString
            txtChietKhau.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colChietKhau").Value().ToString
            txtDiaChi.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colDiaChi").Value().ToString
            txtGhiChu.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colGhiChu").Value().ToString

            Dim cmbEmail As DataGridViewComboBoxCell = dgvDSNhaCungCap.Rows(e.RowIndex).Cells("colEmail")
            cboEmail.DataSource = cmbEmail.DataSource
            cboEmail.DisplayMember = "Email"
            cboEmail.ValueMember = "MaNCC"

            Dim cmbSDT As DataGridViewComboBoxCell = dgvDSNhaCungCap.Rows(e.RowIndex).Cells("colSDT")
            cboDienThoai.DataSource = cmbSDT.DataSource
            cboDienThoai.ValueMember = "MaNCC"
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


End Class
