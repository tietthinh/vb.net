Public Class FrmQLPhieuNhan
    Dim Connection As New Library.DatabaseConnection
    Private Sub btnThemPG_Click(sender As Object, e As EventArgs) Handles btnThemPG.Click
        errPhieuNhan.Clear()
        If cboMaPN.Text = "" Then
            errPhieuNhan.SetError(cboMaPN, "Chọn mã phiếu nhập!")
        End If
        If txtTongTien.Text = "" Then
            errPhieuNhan.SetError(txtTongTien, "Nhập tổng tiền!")
        Else
            If IsNumeric(txtTongTien.Text) = False Then
                errPhieuNhan.SetError(txtTongTien, "Chỉ được nhập số!")
            End If
        End If

        If errPhieuNhan.GetError(cboMaPN) = "" And errPhieuNhan.GetError(txtTongTien) = "" Then
            Dim _Name() As String = New String() {"@MaPN", "@MaNV", "@GhiChu"}
            Dim _Value() As Object = New Object() {cboMaPN.SelectedValue, "NV0001", txtGhiChu.Text}
            Connection.Update("spPhieuNhanInsert", Connection.CreateParameter(_Name, _Value))
            loadDSPhieuNhan()
        End If

    End Sub

    Private Sub btnTimPG_Click(sender As Object, e As EventArgs) Handles btnTimPG.Click
        errPhieuNhan.Clear()
        If txtTimPG.Text = "" Then
            errPhieuNhan.SetError(txtTimPG, "Nhập thông tin cần tìm!")
        End If
        If errPhieuNhan.GetError(txtTimPG) = "" Then

        End If
    End Sub

    Private Sub btnThemCT_Click(sender As Object, e As EventArgs) Handles btnThemCT.Click
        errPhieuNhan.Clear()
        If cboTenSP.Text = "" Then
            errPhieuNhan.SetError(cboTenSP, "Chọn tên sản phẩm!")
        End If
        If txtSoLuong.Text = "" Then
            errPhieuNhan.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errPhieuNhan.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
    End Sub

    Private Sub btnTimCT_Click(sender As Object, e As EventArgs) Handles btnTimCT.Click
        errPhieuNhan.Clear()
        errPhieuNhan.Clear()
        If cboTenSP.Text = "" And txtSoLuong.Text = "" Then
            errPhieuNhan.SetError(cboTenSP, "Chọn tên sản phẩm!")
            errPhieuNhan.SetError(txtSoLuong, "Nhập số lượng!")
        End If
        If txtSoLuong.Text = "" Then
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                errPhieuNhan.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
    End Sub

    Private Sub FrmQLPhieuNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tslMaNV.Text = frmWarehouseKeeper._CurrentUser.Identity
        tslTenNV.Text = frmWarehouseKeeper._CurrentUser.EmployeeName

        loadDSPhieuNhan()
        loadCTPhieuNhan()

        cboMaPN.DataSource = Connection.Query("Select MaPN From PhieuNhap Where TinhTrang = 0")
        cboMaPN.DisplayMember = "MaPN"
        cboMaPN.ValueMember = "MaPN"
    End Sub

    Private Sub loadDSPhieuNhan()
        Dim _dtDSPhieuNhan As DataTable = Connection.Query("spPhieuNhanSelect")
        dgvDanhSachPG.DataSource = _dtDSPhieuNhan
    End Sub

    Private Sub loadCTPhieuNhan()
        If dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString <> "" Then
            Dim _Name() As String = New String() {"@MaPG"}
            Dim _Value() As Object = New Object() {dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString}
            dgvChiTietPG.DataSource = Connection.Query("spChiTietPhieuNhanSelect", Connection.CreateParameter(_Name, _Value))
        End If
    End Sub

    Private Sub dgvDanhSachPG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachPG.CellClick
        If IsNothing(dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString()) = False Then
            loadCTPhieuNhan()
            txtTongTien.Text = dgvDanhSachPG.SelectedRows(0).Cells("colTongTien").Value.ToString()
            dtpNgayLap.Text = dgvDanhSachPG.SelectedRows(0).Cells("colNgayLap").Value.ToString()
            txtGhiChu.Text = dgvDanhSachPG.SelectedRows(0).Cells("colGhiChu").Value.ToString()
            cboMaPN.Text = dgvDanhSachPG.SelectedRows(0).Cells("colMaPN").Value.ToString()
        End If
    End Sub

    Private Sub btnXoaPG_Click(sender As Object, e As EventArgs) Handles btnXoaPG.Click
        If (MessageBox.Show("Bạn muốn xóa thông tin phiếu nhận này?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _Name() As String = New String() {"@MaPG"}
            Dim _Value() As Object = New Object() {dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString()}
            Connection.Update("spPhieuNhanDelete", Connection.CreateParameter(_Name, _Value))
            loadDSPhieuNhan()
        End If
    End Sub

    Private Sub btnSuaPG_Click(sender As Object, e As EventArgs) Handles btnSuaPG.Click
        errPhieuNhan.Clear()
        If cboMaPN.Text = "" Then
            errPhieuNhan.SetError(cboMaPN, "Chọn mã phiếu nhập!")
        End If
        If txtTongTien.Text = "" Then
            errPhieuNhan.SetError(txtTongTien, "Nhập tổng tiền!")
        Else
            If IsNumeric(txtTongTien.Text) = False Then
                errPhieuNhan.SetError(txtTongTien, "Chỉ được nhập số!")
            End If
        End If

        If errPhieuNhan.GetError(cboMaPN) = "" Then
            Dim _Name() As String = New String() {"@MaPG", "@MaPN", "@TongTien", "@GhiChu"}
            Dim _Value() As Object = New Object() {dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString(), cboMaPN.SelectedValue, txtTongTien.Text, txtGhiChu.Text}
            Connection.Update("spPhieuNhanUpdate", Connection.CreateParameter(_Name, _Value))
            loadDSPhieuNhan()
        End If
    End Sub

    Private Function timKiemPG(ByVal _colName As String) As Integer
        Dim _dt As DataTable = Connection.Query("spPhieuNhanSelect")
        Dim _dv As DataView = New DataView(_dt, _colName + "=" + "'" + txtTimPG.Text + "'", "MaPG Desc", DataViewRowState.CurrentRows)
        dgvDanhSachPG.DataSource = _dv
        If dgvDanhSachPG.Rows(0).Cells(0).Value() = "" Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class