Imports System.Data.SqlClient

Public Class FrmQLPhieuNhap
    Dim Connection As New Library.DatabaseConnection

    Private Sub btnThemPN_Click(sender As Object, e As EventArgs) Handles btnThemPN.Click
        errPhieuNhap.Clear()
        If cboNCC.Text = "" Then
            errPhieuNhap.SetError(cboNCC, "Chọn tên nhà cung cấp!")
        End If
        If errPhieuNhap.GetError(cboNCC) = "" Then
            Dim _Name() As String = New String() {"@MaNV", "@MaNCC", "@NgayGiaoDK"}
            Dim _Value() As Object = New Object() {tslMaNV.Text, cboNCC.SelectedValue.ToString, dtpNgayGiao.Value}
            Connection.Update("spPhieuNhapInsert", Connection.CreateParameter(_Name, _Value))
            loadDSPhieuNhap()
        End If

    End Sub

    Private Sub btnTimPN_Click(sender As Object, e As EventArgs) Handles btnTimPN.Click
        errPhieuNhap.Clear()
        If cboNCC.Text = "" Then
            errPhieuNhap.SetError(cboNCC, "Chọn tên nhà cung cấp!")
        End If
    End Sub

    Private Sub btnTimCT_Click(sender As Object, e As EventArgs) Handles btnTimCT.Click
        errPhieuNhap.Clear()
        If txtTenSP.Text = "" And txtSoLuong.Text = "" And cboDonVi.Text = "" And txtDonGia.Text = "" And
            txtThanhTien.Text = "" Then
            errPhieuNhap.SetError(txtTenSP, "Nhập tên sản phẩm!")
            errPhieuNhap.SetError(txtSoLuong, "Nhập số lượng!")
            errPhieuNhap.SetError(cboDonVi, "Chọn đơn vị!")
            errPhieuNhap.SetError(txtDonGia, "Nhập đơn giá!")
            errPhieuNhap.SetError(txtThanhTien, "Nhập tổng tiền!")
        End If

        If txtSoLuong.Text = "" Then
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errPhieuNhap.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If txtDonGia.Text = "" Then
        Else
            If IsNumeric(txtDonGia.Text) = False Then
                errPhieuNhap.SetError(txtDonGia, "Chỉ được nhập số!")
            End If
        End If
        If txtThanhTien.Text = "" Then
        Else
            If IsNumeric(txtThanhTien.Text) = False Then
                errPhieuNhap.SetError(txtThanhTien, "Chỉ được nhập số!")
            End If
        End If

    End Sub

    Private Sub btnThemCT_Click(sender As Object, e As EventArgs) Handles btnThemCT.Click
        errPhieuNhap.Clear()
        If txtTenSP.Text = "" Then
            errPhieuNhap.SetError(txtTenSP, "Chọn tên sản phẩm!")
        End If
        If txtSoLuong.Text = "" Then
            errPhieuNhap.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errPhieuNhap.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cboDonVi.Text = "" Then
            errPhieuNhap.SetError(cboDonVi, "Chọn đơn vị!")
        End If
        If txtDonGia.Text = "" Then
            errPhieuNhap.SetError(txtDonGia, "Nhập đơn giá!")
        Else
            If IsNumeric(txtDonGia.Text) = False Then
                errPhieuNhap.SetError(txtDonGia, "Chỉ được nhập số!")
            End If
        End If
        If txtThanhTien.Text = "" Then
            errPhieuNhap.SetError(txtThanhTien, "Nhập tổng tiền!")
        Else
            If IsNumeric(txtThanhTien.Text) = False Then
                errPhieuNhap.SetError(txtThanhTien, "Chỉ được nhập số!")
            End If
        End If

        If errPhieuNhap.GetError(txtTenSP) = "" And errPhieuNhap.GetError(txtSoLuong) = "" And errPhieuNhap.GetError(cboDonVi) = "" And
           errPhieuNhap.GetError(txtDonGia) = "" And errPhieuNhap.GetError(txtThanhTien) = "" Then
            Dim _ReturnValue As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaPN", "@MaSP", "@SoLuong", "@MaDV", "@DonGia", "@ThanhTien"}
            Dim _Value() As String = New String() {dgvDSPhieuNhap.SelectedRows(0).Cells("colMaPN").Value(), lstTimKiem.SelectedItems(0).Text, txtSoLuong.Text, cboDonVi.SelectedValue(), txtDonGia.Text, txtThanhTien.Text}
            Connection.Update("spChiTietPhieuNhapInsert", _ReturnValue, Connection.CreateParameter(_Name, _Value))
            Dim _kq As Integer = _ReturnValue.Value
            loadCTPhieuNhap()
            If _kq = 1 Then
                MessageBox.Show("Phiếu nhập đã hoàn thành không thể thêm vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            If _kq = 2 Then
                MessageBox.Show("Sản phẩm thêm vào phiếu nhập bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub btnTimLB_Click(sender As Object, e As EventArgs) Handles btnTimLB.Click
        If txtTimLB.Text = "" Then
            errPhieuNhap.SetError(txtTimLB, "Nhập sản phẩm cần tìm!")
        End If
    End Sub

    Private Sub FrmQLPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tslMaNV.Text = frmWarehouseKeeper._CurrentUser.Identity
        tslTenNV.Text = frmWarehouseKeeper._CurrentUser.EmployeeName
        loadDSPhieuNhap()
        loadCTPhieuNhap()
        loadDSSanPham()

        cboNCC.DataSource = Connection.Query("Select * From NhaCungCap")
        cboNCC.DisplayMember = "TenNCC"
        cboNCC.ValueMember = "MaNCC"

        cboDonVi.DataSource = Connection.Query("Select * From LoaiDonViTinh")
        cboDonVi.DisplayMember = "TenDV"
        cboDonVi.ValueMember = "MaDV"
    End Sub

    Private Sub loadDSPhieuNhap()
        Dim _dtDSPhieuNhap As DataTable = Connection.Query("spPhieuNhapSelect")
        dgvDSPhieuNhap.DataSource = _dtDSPhieuNhap
    End Sub

    Private Sub loadCTPhieuNhap()
        If dgvDSPhieuNhap.SelectedRows(0).Cells("colMaPN").Value().ToString <> "" Then
            Dim _Name() As String = New String() {"@MaPN"}
            Dim _Value() As Object = New Object() {dgvDSPhieuNhap.SelectedRows(0).Cells("colMaPN").Value().ToString}
            dgvDSChiTietPhieuNhap.DataSource = Connection.Query("spChiTietPhieuNhapSelect", Connection.CreateParameter(_Name, _Value))
            dgvDSChiTietPhieuNhap.Columns("colThanhTien").DefaultCellStyle.Format = "#,###"
            dgvDSChiTietPhieuNhap.Columns("colDonGia").DefaultCellStyle.Format = "#,###"
        End If
    End Sub

    Private Sub loadDSSanPham()
        Dim dt As New DataTable
        dt = Connection.Query("Select MaSP, TenSP, SoLuongTon From SanPham")
        For Each row As DataRow In dt.Rows
            Dim lst As New ListViewItem
            lst = lstTimKiem.Items.Add(row(0))
            For i As Integer = 1 To dt.Columns.Count - 1
                lst.SubItems.Add(row(i))
            Next
        Next
    End Sub

    Private Sub dgvDSPhieuNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSPhieuNhap.CellClick
        If IsNothing(dgvDSPhieuNhap.SelectedRows(0).Cells("colMaPN").Value().ToString()) = False Then
            loadCTPhieuNhap()
            cboNCC.Text = dgvDSPhieuNhap.SelectedRows(0).Cells("colTenNCC").Value.ToString()
            dtpNgayLap.Text = dgvDSPhieuNhap.SelectedRows(0).Cells("colNgayLap").Value.ToString()
            dtpNgayGiao.Text = dgvDSPhieuNhap.SelectedRows(0).Cells("colNgayGiaoDK").Value.ToString()
        End If
    End Sub

    Private Sub btnXoaPN_Click(sender As Object, e As EventArgs) Handles btnXoaPN.Click
        If (MessageBox.Show("Bạn muốn xóa thông tin phiếu nhập này?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _Name() As String = New String() {"@MaPN"}
            Dim _Value() As Object = New Object() {dgvDSPhieuNhap.SelectedRows(0).Cells("colMaPN").Value()}
            Connection.Update("spPhieuNhapDelete", Connection.CreateParameter(_Name, _Value))
            loadDSPhieuNhap()
        End If
    End Sub

    Private Sub btnSuaPN_Click(sender As Object, e As EventArgs) Handles btnSuaPN.Click
        errPhieuNhap.Clear()
        If cboNCC.Text = "" Then
            errPhieuNhap.SetError(cboNCC, "Chọn tên nhà cung cấp!")
        End If
        If txtTongTien.Text = "" Then
            errPhieuNhap.SetError(txtTongTien, "Nhập tổng tiền")
        End If
        If dtpNgayGiao.Text = "" Then
            errPhieuNhap.SetError(dtpNgayGiao, "Chọn ngày giao đăng ký!")
        End If
        If errPhieuNhap.GetError(cboNCC) = "" And errPhieuNhap.GetError(txtTongTien) = "" And errPhieuNhap.GetError(dtpNgayGiao) = "" Then
            Dim _Name() As String = New String() {"@MaPN", "@MaNCC", "@NgayGiaoDK", "@TongTien"}
            Dim _Value() As Object = New Object() {dgvDSPhieuNhap.SelectedRows(0).Cells("colMaPN").Value, cboNCC.SelectedValue.ToString, dtpNgayGiao.Value, txtTongTien.Text}
            Connection.Update("spPhieuNhapUpdate", Connection.CreateParameter(_Name, _Value))
            loadDSPhieuNhap()
        End If
    End Sub

    Private Sub dgvDSChiTietPhieuNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSChiTietPhieuNhap.CellClick
        If dgvDSChiTietPhieuNhap.SelectedRows(0).Cells(0).Value.ToString <> "" Then
            txtTenSP.Text = dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colTenSP").Value.ToString
            txtSoLuong.Text = dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colSoLuong").Value.ToString
            cboDonVi.Text = dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colTenDV").Value.ToString
            txtDonGia.Text = dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colDonGia").Value.ToString
            txtThanhTien.Text = dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colThanhTien").Value.ToString
        End If
    End Sub

    Private Sub lstTimKiem_MouseClick(sender As Object, e As MouseEventArgs) Handles lstTimKiem.MouseClick
        txtTimLB.Text = lstTimKiem.SelectedItems(0).SubItems(1).Text
        txtTenSP.Text = lstTimKiem.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub btnXoaCT_Click(sender As Object, e As EventArgs) Handles btnXoaCT.Click
        If MessageBox.Show("Bạn muốn xóa chi tiết này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            Dim _ReturnXoa As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaPN", "@MaSP"}
            Dim _Value() As String = New String() {dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colMaPN_CT").Value(), dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colMaSP").Value()}
            Connection.Update("spChiTietPhieuNhapDelete", _ReturnXoa, Connection.CreateParameter(_Name, _Value))
            Dim _kq As Integer = _ReturnXoa.Value
            loadCTPhieuNhap()
            If _kq = 1 Then
                MessageBox.Show("Phiếu nhập đã hoàn thành không thể xóa chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub btnSuaCT_Click(sender As Object, e As EventArgs) Handles btnSuaCT.Click
        Dim _Return As SqlParameter = New SqlParameter
        Dim _Name() As String = New String() {"@MaPN", "@MaSPCu", "@MaSPMoi", "@SoLuong", "@MaDV", "@DonGia", "@ThanhTien"}
        Dim _Value() As String = New String() {dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colMaPN_CT").Value().ToString, dgvDSChiTietPhieuNhap.SelectedRows(0).Cells("colMaSP").Value().ToString, lstTimKiem.SelectedItems(0).Text, txtSoLuong.Text, cboDonVi.SelectedValue, txtDonGia.Text, txtThanhTien.Text}
        Connection.Update("spChiTietPhieuNhapUpdate", _Return, Connection.CreateParameter(_Name, _Value))
        Dim _kq As Integer = _Return.Value
        loadCTPhieuNhap()
        If _kq = 1 Then
            MessageBox.Show("Phiếu nhập đã hoàn thành không thể cập nhật chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
End Class