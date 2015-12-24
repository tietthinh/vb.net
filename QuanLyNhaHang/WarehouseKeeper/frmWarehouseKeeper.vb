Imports Library

Public Class frmWarehouseKeeper

    'Fields:
    ''' <summary>
    ''' Form for adding mail for Supplier.
    ''' </summary>
    ''' <remarks></remarks>
    Dim frmEmail As New frmContact()

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
        erTenSP.Clear()
        erSoLuong.Clear()
        erDonVi.Clear()
        If txtTenSanPham.Text = "" Then
            erTenSP.SetError(txtTenSanPham, "Tên sản phẩm khác rỗng!")
        End If
        If txtSoLuong.Text = "" Then
            erSoLuong.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                erSoLuong.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cboDonVi.Text = "" Then
            erDonVi.SetError(cboDonVi, "Chọn đơn vị!")
        End If

        If erTenSP.GetError(txtTenSanPham) = "" And erSoLuong.GetError(txtSoLuong) = "" And erDonVi.GetError(cboDonVi) = "" Then
            Dim _Query As String = "spSanPhamInsert"
            Dim _Name() As String = {("@TenSP"), ("@SoLuongTon"), ("@DonViTinh")}
            Dim _Value() As Object = {txtTenSanPham.Text, txtSoLuong.Text, cboDonVi.SelectedValue}
            Connection.Query(_Query, Connection.CreateParameter(_Name, _Value))

            loadDSSanPham()
        End If
    End Sub

    Private Sub btnTimSP_Click(sender As Object, e As EventArgs) Handles btnTimSP.Click
        erTenSP.Clear()
        erSoLuong.Clear()
        erDonVi.Clear()
        erTimSP.Clear()
        If txtTimSP.Text = "" Then
            erTimSP.SetError(txtTimSP, "Nhập thông tin sản phẩm cần tìm!")
        End If
        If erTimSP.GetError(txtTimSP) = "" Then
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
        erNCC.Clear()
        erChietKhau.Clear()
        erDiaChi.Clear()
        erEmail.Clear()
        erDienThoai.Clear()
        If txtTenNCC.Text = "" Then
            erNCC.SetError(txtTenNCC, "Tên nhà cung cấp khác rỗng!")
        End If
        If txtChietKhau.Text = "" Then
            erChietKhau.SetError(txtChietKhau, "Chọn chiết khấu!")
        End If
        If txtDiaChi.Text = "" Then
            erDiaChi.SetError(txtDiaChi, "Nhập địa chỉ!")
        End If
        If txtEmail.Text = "" Then
            erEmail.SetError(txtEmail, "Nhập email!")
        End If
        If txtDienThoai.Text = "" Then
            erDienThoai.SetError(txtDienThoai, "Nhập điện thoại!")
        Else
            If IsNumeric(txtDienThoai.Text) = False Then
                erDienThoai.SetError(txtDienThoai, "Điện thoại phải là số!")
            End If
        End If
        If erNCC.GetError(txtTenNCC) = "" And erChietKhau.GetError(txtChietKhau) = "" And erDiaChi.GetError(txtDiaChi) Then

        End If
    End Sub

    Private Sub btnTimNCC_Click(sender As Object, e As EventArgs) Handles btnTimNCC.Click
        erNCC.Clear()
        erChietKhau.Clear()
        erDiaChi.Clear()
        erEmail.Clear()
        erDienThoai.Clear()
        If txtTenNCC.Text = "" And txtChietKhau.Text = "" And txtDiaChi.Text = "" And txtEmail.Text = "" And txtDienThoai.Text = "" Then
            erNCC.SetError(txtTenNCC, "Nhập tên nhà cung cấp!")
            erChietKhau.SetError(txtChietKhau, "Chọn chiết khấu!")
            erDiaChi.SetError(txtDiaChi, "Nhập địa chỉ!")
            erEmail.SetError(txtEmail, "Nhập email!")
            erDienThoai.SetError(txtDienThoai, "Nhập điện thoại!")
        End If
        If txtDienThoai.Text = "" Then
        Else
            If IsNumeric(txtDienThoai.Text) = False Then
                erDienThoai.SetError(txtDienThoai, "Điện thoại phải là số!")
            End If
        End If
    End Sub

    Private Sub frmWarehouseKeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadDSSanPham()

        loadDSNCC()


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
            Dim _Value() As String = New String() {row.Cells(1).Value.ToString()}
            Dim _Phone As DataTable

            _Email = Connection.Query("spNhaCungCap_EmailSelect", Connection.CreateParameter(_Name, _Value))

            Dim cellMail As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()

            BindDataGridViewComboBox(cellMail, _Email, "Email", "MaNCC")
            row.Cells("colEmail") = cellMail

            _Phone = Connection.Query("spNhaCungCap_DienThoaiSelect", Connection.CreateParameter(_Name, _Value))

            Dim cellPhone As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()

            BindDataGridViewComboBox(cellPhone, _Phone, "SDT", "MaNCC")
            row.Cells("colSDT") = cellPhone

            cellMail.Dispose()
            cellPhone.Dispose()
            cellMail = Nothing
            cellPhone = Nothing
        Next
    End Sub

    Private Sub btnSuaSP_Click(sender As Object, e As EventArgs) Handles btnSuaSP.Click
        erTenSP.Clear()
        erSoLuong.Clear()
        erDonVi.Clear()
        If txtTenSanPham.Text = "" Then
            erTenSP.SetError(txtTenSanPham, "Tên sản phẩm khác rỗng!")
        End If
        If txtSoLuong.Text = "" Then
            erSoLuong.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                erSoLuong.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cboDonVi.Text = "" Then
            erDonVi.SetError(cboDonVi, "Chọn đơn vị!")
        End If

        If erTenSP.GetError(txtTenSanPham) = "" And erSoLuong.GetError(txtSoLuong) = "" And erDonVi.GetError(cboDonVi) = "" Then
            Dim _Query As String = "spSanPhamUpdate"
            Dim _Name() As String = {("@MaSP"), ("@TenSP"), ("@SoLuong"), ("@MaDV")}
            Dim _Value() As Object = {dgvDSSanPham.Rows(rowIndex).Cells(0).Value(), txtTenSanPham.Text, txtSoLuong.Text, cboDonVi.SelectedValue}
            Connection.Query(_Query, Connection.CreateParameter(_Name, _Value))

            loadDSSanPham()
        End If
    End Sub

    Public Sub dgvDSSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSSanPham.CellClick
        rowIndex = e.RowIndex
        If IsNothing((dgvDSSanPham.Rows(e.RowIndex).Cells(1).Value()).ToString()) = False Then
            txtTenSanPham.Text = (dgvDSSanPham.Rows(e.RowIndex).Cells(1).Value()).ToString
            txtSoLuong.Text = (dgvDSSanPham.Rows(e.RowIndex).Cells(2).Value()).ToString
            cboDonVi.SelectedValue = dgvDSSanPham.Rows(e.RowIndex).Cells(3).Value()
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

    Private Sub btnXoaNCC_Click(sender As Object, e As EventArgs) Handles btnXoaNCC.Click
        Dim _Query As String = "spNhaCungCap_EmailSelect"
        Dim _Name() As String = {"@MaNCC"}
        Dim _Value() As Object = {dgvDSNhaCungCap.Rows(0).Cells(0).Value().ToString()}
        colEmail.DataSource = Connection.Query(_Query, Connection.CreateParameter(_Name, _Value))
        colEmail.DisplayMember = "Email"
        colEmail.ValueMember = "MaNCC"
    End Sub
End Class
