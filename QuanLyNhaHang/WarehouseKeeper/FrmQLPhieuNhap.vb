Public Class FrmQLPhieuNhap
    Dim Connection As New Library.DatabaseConnection

    Private Sub btnThemPN_Click(sender As Object, e As EventArgs) Handles btnThemPN.Click
        errPhieuNhap.Clear()
        If cboNCC.Text = "" Then
            errPhieuNhap.SetError(cboNCC, "Chọn tên nhà cung cấp!")
        End If
        'Dim _Name() As String = New String() {"@MaNV", "@MaNCC", "@NgayGiaoDK"}
        'Dim _Value() As String = New String() {"NV0001", cboNCC.SelectedValue, dtpNgayGiao.Text}
        'Connection.Update("spPhieuNhapInsert", Connection.CreateParameter(_Name, _Value))
        'loadDSPhieuNhap()

    End Sub

    Private Sub btnTimPN_Click(sender As Object, e As EventArgs) Handles btnTimPN.Click
        errPhieuNhap.Clear()
        If cboNCC.Text = "" Then
            errPhieuNhap.SetError(cboNCC, "Chọn tên nhà cung cấp!")
        End If
    End Sub

    Private Sub btnTimCT_Click(sender As Object, e As EventArgs) Handles btnTimCT.Click
        errPhieuNhap.Clear()
        If txtTenSP.Text = "" And txtSoLuong.Text = "" And cbDonVi.Text = "" And txtDonGia.Text = "" And
            txtThanhTien.Text = "" Then
            errPhieuNhap.SetError(txtTenSP, "Nhập tên sản phẩm!")
            errPhieuNhap.SetError(txtSoLuong, "Nhập số lượng!")
            errPhieuNhap.SetError(cbDonVi, "Chọn đơn vị!")
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
        If cbDonVi.Text = "" Then
            errPhieuNhap.SetError(cbDonVi, "Chọn đơn vị!")
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

        If errPhieuNhap.GetError(txtTenSP) = "" And errPhieuNhap.GetError(txtSoLuong) = "" And errPhieuNhap.GetError(cbDonVi) = "" And
           errPhieuNhap.GetError(txtDonGia) = "" And errPhieuNhap.GetError(txtThanhTien) = "" Then
            'Dim _Name() As String = New String() {"@MaPN", "@MaSP", "@SoLuong", "@MaDV", "@DonGia", "@ThanhTien"}
            'Dim _Value() As String = New String() {dgvDSPhieuNhap.SelectedRows(0).Cells("colMaPN").Value(), lstTimKiem.Columns("MaSPTimKiem").Text}
            'Connection.Update("spChiTietPhieuNhapInsert", Connection.CreateParameter(_Name, _Value))
            'loadDSPhieuNhap()
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

        cboNCC.DataSource = Connection.Query("Select TenNCC From NhaCungCap")
        cboNCC.DisplayMember = "TenNCC"
        cboNCC.ValueMember = "MaNCC"

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
End Class