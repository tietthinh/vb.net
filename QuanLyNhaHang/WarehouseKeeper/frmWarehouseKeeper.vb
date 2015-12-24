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
        errSP.Clear()
        If txtTenSanPham.Text = "" Then
            errSP.SetError(txtTenSanPham, "Tên sản phẩm khác rỗng!")
        End If
        If txtSoLuong.Text = "" Then
            errSP.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errSP.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cboDonVi.Text = "" Then
            errSP.SetError(cboDonVi, "Chọn đơn vị!")
        End If

        If errSP.GetError(txtTenSanPham) = "" And errSP.GetError(txtSoLuong) = "" And errSP.GetError(cboDonVi) = "" Then
            Dim _Query As String = "spSanPhamInsert"
            Dim _Name() As String = {("@TenSP"), ("@SoLuongTon"), ("@DonViTinh")}
            Dim _Value() As Object = {txtTenSanPham.Text, txtSoLuong.Text, cboDonVi.SelectedValue}
            Connection.Update(_Query, Connection.CreateParameter(_Name, _Value))

            loadDSSanPham()
        End If
    End Sub

    Private Sub btnTimSP_Click(sender As Object, e As EventArgs) Handles btnTimSP.Click
        errSP.Clear()

        If txtTimSP.Text = "" Then
            errSP.SetError(txtTimSP, "Nhập thông tin sản phẩm cần tìm!")
        End If
        If errSP.GetError(txtTimSP) = "" Then
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
        If txtTenNCC.Text = "" Then
            erNCC.SetError(txtTenNCC, "Tên nhà cung cấp khác rỗng!")
        End If
        If txtChietKhau.Text = "" Then
            erNCC.SetError(txtChietKhau, "Chọn chiết khấu!")
        Else
            If txtChietKhau.Text > 10 Then
                erNCC.SetError(txtChietKhau, "Chiết khấu bé hơn hoặc bằng 10!")
            End If
        End If
        If txtDiaChi.Text = "" Then
            erNCC.SetError(txtDiaChi, "Nhập địa chỉ!")
        End If
        If erNCC.GetError(txtTenNCC) = "" Then
            Dim _Name() As String = New String() {""}
        End If

        If erNCC.GetError(txtTenNCC) = "" And erNCC.GetError(txtChietKhau) = "" And erNCC.GetError(txtDiaChi) = "" Then
            dgvDSNhaCungCap.Rows.Clear()
            Dim _Name() As String = New String() {"@TenNCC", "@DiaChi", "@ChietKhau", "@GhiChu"}
            Dim _Value() As Object = New Object() {txtTenNCC.Text, txtDiaChi.Text, txtChietKhau.Text, txtGhiChu.Text}
            Connection.Update("spNhaCungCapInsert", Connection.CreateParameter(_Name, _Value))
            loadDSNCC()
        End If
    End Sub

    Private Sub btnTimNCC_Click(sender As Object, e As EventArgs) Handles btnTimNCC.Click
        erNCC.Clear()

        If txtTenNCC.Text = "" And txtChietKhau.Text = "" And txtDiaChi.Text = "" And cboEmail.Text = "" And cboDienThoai.Text = "" Then
            erNCC.SetError(txtTenNCC, "Nhập tên nhà cung cấp!")
            erNCC.SetError(txtChietKhau, "Chọn chiết khấu!")
            erNCC.SetError(txtDiaChi, "Nhập địa chỉ!")
        End If
    End Sub

    Private Sub frmWarehouseKeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadDSSanPham()

        loadDSNCC()

        Dim _dtDonVi As DataTable = Connection.Query("spLoaiDonViTinhSelect")
        cboDonVi.DataSource = _dtDonVi
        cboDonVi.DisplayMember = "TenDV"
        cboDonVi.ValueMember = "MaDV"

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
        Dim i As Integer = 0

        For Each row As DataRow In _dtDSNCC.Rows
            dgvDSNhaCungCap.Rows.Add(New String() {row("MaNCC").ToString, row("TenNCC").ToString, row("DiaChi").ToString, row("ChietKhau").ToString, row("GhiChu").ToString})
            Dim _Email As DataTable = New DataTable()
            Dim _Name() As String = New String() {"@MaNCC"}
            Dim _Value() As String = New String() {row(0).ToString()}
            _Email = Connection.Query("spNhaCungCap_EmailSelect ", Connection.CreateParameter(_Name, _Value))

            Dim _SDT As DataTable = New DataTable()
            Dim _NameSDT() As String = New String() {"@MaNCC"}
            Dim _ValueSDT() As String = New String() {row(0).ToString()}
            _SDT = Connection.Query("spNhaCungCap_DienThoaiSelect ", Connection.CreateParameter(_NameSDT, _ValueSDT))

            Dim cell As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()

            BindDataGridViewComboBox(cell, _Email)
            dgvDSNhaCungCap.Rows(i).Cells("colEmail") = cell

            Dim cellSDT As DataGridViewComboBoxCell = New DataGridViewComboBoxCell()
            BindDataGridViewComboBoxSDT(cellSDT, _SDT)
            dgvDSNhaCungCap.Rows(i).Cells("colSDT") = cellSDT
            i += 1

        Next
    End Sub

    Private Sub btnSuaSP_Click(sender As Object, e As EventArgs) Handles btnSuaSP.Click
        errSP.Clear()

        If txtTenSanPham.Text = "" Then
            errSP.SetError(txtTenSanPham, "Tên sản phẩm khác rỗng!")
        End If
        If txtSoLuong.Text = "" Then
            errSP.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errSP.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cboDonVi.Text = "" Then
            errSP.SetError(cboDonVi, "Chọn đơn vị!")
        End If

        If errSP.GetError(txtTenSanPham) = "" And errSP.GetError(txtSoLuong) = "" And errSP.GetError(cboDonVi) = "" Then
            Dim _Query As String = "spSanPhamUpdate"
            Dim _Name() As String = {("@MaSP"), ("@TenSP"), ("@SoLuong"), ("@MaDV")}
            Dim _Value() As Object = {dgvDSSanPham.SelectedRows(0).Cells(0).Value(), txtTenSanPham.Text, txtSoLuong.Text, cboDonVi.SelectedValue}
            Connection.Update(_Query, Connection.CreateParameter(_Name, _Value))

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
                Connection.Update(_Query, Connection.CreateParameter(_Name, _Value))
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
        If (MessageBox.Show("Bạn muốn xóa thông tin nhà cung cấp này!", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _Name() As String = New String() {"@MaNCC"}
            Dim _Value() As Object = {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value().ToString().Trim}
            Connection.Update("spNhaCungCapDelete", Connection.CreateParameter(_Name, _Value))
            dgvDSNhaCungCap.Rows.Clear()
            loadDSNCC()
        End If
    End Sub

    Private Sub dgvDSNhaCungCap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSNhaCungCap.CellClick
        rowIndex = e.RowIndex
        If IsNothing(dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value()) = False Then
            txtTenNCC.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colTenNCC").Value()
            txtChietKhau.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colChietKhau").Value()
            txtDiaChi.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colDiaChi").Value()
            txtGhiChu.Text = dgvDSNhaCungCap.SelectedRows(0).Cells("colGhiChu").Value()

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

    Private Sub txtTimSP_TextChanged(sender As Object, e As EventArgs) Handles txtTimSP.TextChanged
        If txtTimSP.Text = "" Then
            loadDSSanPham()
        End If
    End Sub

    Private Sub btnSuaNCC_Click(sender As Object, e As EventArgs) Handles btnSuaNCC.Click
        erNCC.Clear()
        If txtTenNCC.Text = "" And txtChietKhau.Text = "" And txtDiaChi.Text = "" Then
            erNCC.SetError(txtTenNCC, "Tên nhà cung cấp khác rỗng!")
            erNCC.SetError(txtChietKhau, "Chọn chiết khấu!")
            erNCC.SetError(txtDiaChi, "Nhập địa chỉ!")
        End If
        If txtChietKhau.Text = "" Then
        Else
            If txtChietKhau.Text > 10 Then
                erNCC.SetError(txtChietKhau, "Chiết khấu bé hơn hoặc bằng 10!")
            End If
        End If

        If erNCC.GetError(txtTenNCC) = "" And erNCC.GetError(txtChietKhau) = "" And erNCC.GetError(txtDiaChi) = "" Then
            Dim _Name() As String = New String() {"@MaNCC", "@TenNCC", "@DiaChi", "@ChietKhau", "@GhiChu"}
            Dim _Value() As Object = New Object() {dgvDSNhaCungCap.SelectedRows(0).Cells("colMaNCC").Value().ToString(), txtTenNCC.Text, txtDiaChi.Text, txtChietKhau.Text, txtGhiChu.Text}
            Connection.Update("spNhaCungCapUpdate", Connection.CreateParameter(_Name, _Value))
            dgvDSNhaCungCap.Rows.Clear()
            loadDSNCC()
        End If

    End Sub
End Class
