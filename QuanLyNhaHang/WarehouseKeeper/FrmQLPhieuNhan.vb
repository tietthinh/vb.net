Imports System.Data.SqlClient

Public Class FrmQLPhieuNhan
    Dim Connection As New Library.DatabaseConnection


    Private Sub btnTimPG_Click(sender As Object, e As EventArgs) Handles btnTimPG.Click
        errPhieuNhan.Clear()
        If txtTimPG.Text = "" Then
            errPhieuNhan.SetError(txtTimPG, "Nhập thông tin cần tìm!")
        End If
        If errPhieuNhan.GetError(txtTimPG) = "" Then
            Dim temp As Integer = 0
            dgvDanhSachPG.ClearSelection()
            For i As Integer = 0 To dgvDanhSachPG.RowCount - 1
                For j As Integer = 0 To dgvDanhSachPG.ColumnCount - 1
                    Dim a As Integer = 0
                    If dgvDanhSachPG.Rows(i).Cells(j).Value.ToString.Trim.Contains(txtTimPG.Text) Then
                        temp = 1
                        dgvDanhSachPG.Rows(i).Selected() = True
                        dgvDanhSachPG.Select()
                    End If
                Next
            Next
            If temp = 0 Then
                MsgBox("Không tìm thấy")
            End If
        End If
    End Sub

    Private Sub btnTimCT_Click(sender As Object, e As EventArgs) Handles btnTimCT.Click
        errPhieuNhan.Clear()
        If txtTimCT.Text = "" Then
            errPhieuNhan.SetError(txtTimCT, "Nhập thông tin cần tìm!")
        End If
        If errPhieuNhan.GetError(txtTimCT) = "" Then
            Dim temp As Integer = 0
            dgvChiTietPG.ClearSelection()
            For i As Integer = 0 To dgvChiTietPG.RowCount - 1
                For j As Integer = 0 To dgvChiTietPG.ColumnCount - 1
                    If dgvChiTietPG.Rows(i).Cells(j).Value.ToString.Trim.Contains(txtTimCT.Text) Then
                        temp = 1
                        dgvChiTietPG.Rows(i).Selected = True
                        dgvChiTietPG.Select()
                    End If
                Next
            Next
            If temp = 0 Then
                MsgBox("Không tìm thấy")
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
        cboMaPN.Text = ""

        cboTenSP.DataSource = Connection.Query("Select MaSP, TenSP From SanPham")
        cboTenSP.DisplayMember = "TenSP"
        cboTenSP.ValueMember = "MaSP"

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
        errPhieuNhan.Clear()

        If IsNothing(dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString()) = False Then
            loadCTPhieuNhan()
            txtTongTien.Text = dgvDanhSachPG.SelectedRows(0).Cells("colTongTien").Value.ToString()
            dtpNgayLap.Text = dgvDanhSachPG.SelectedRows(0).Cells("colNgayLap").Value.ToString()
            txtGhiChu.Text = dgvDanhSachPG.SelectedRows(0).Cells("colGhiChu").Value.ToString()
        End If
    End Sub

    Private Sub btnXoaPG_Click(sender As Object, e As EventArgs) Handles btnXoaPG.Click
        errPhieuNhan.Clear()
        If (MessageBox.Show("Bạn muốn xóa thông tin phiếu nhận này?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _returnXoa As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaPG"}
            Dim _Value() As Object = New Object() {dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString()}
            Connection.Update("spPhieuNhanDelete", Connection.CreateParameter(_Name, _Value))
            loadDSPhieuNhan()
        End If
    End Sub

    Private Sub btnSuaPG_Click(sender As Object, e As EventArgs) Handles btnSuaPG.Click
        errPhieuNhan.Clear()
        If dgvDanhSachPG.SelectedRows(0).Cells(0).Value = "" Then
            errPhieuNhan.SetError(dgvDanhSachPG, "Chọn phiếu nhận cần sửa!")
        End If

        If errPhieuNhan.GetError(dgvDanhSachPG) = "" Then
            Dim _returnUpdate As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaPG", "@MaPN", "@GhiChu"}
            Dim _Value() As Object = New Object() {dgvDanhSachPG.SelectedRows(0).Cells("colMaPG").Value().ToString(), dgvDanhSachPG.SelectedRows(0).Cells("colMaPN").Value().ToString(), txtGhiChu.Text}
            Connection.Update("spPhieuNhanUpdate", _returnUpdate, Connection.CreateParameter(_Name, _Value))
            Dim _kq As Integer = _returnUpdate.Value
            If _kq = 1 Then
                MessageBox.Show("Phiếu nhận đã hoàn thành không thể cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
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

    Private Sub cboMaPN_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboMaPN.SelectionChangeCommitted
        errPhieuNhan.Clear()
        Dim _Name() As String = New String() {"@MaPN"}
        Dim _Value() As Object = New Object() {cboMaPN.SelectedValue.ToString}
        dgvChiTietPG.DataSource = Connection.Query("usp_LoadChiTietPhieuNhanSelect", Connection.CreateParameter(_Name, _Value))
    End Sub

    Private Sub btnXoaCT_Click(sender As Object, e As EventArgs) Handles btnXoaCT.Click
        errPhieuNhan.Clear()

        If (MessageBox.Show("Bạn muốn xóa chi tiết phiếu nhận này?", "Thông báo", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Dim _return As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaPG", "@MaPN", "@MaSP"}
            Dim _Value() As Object = New Object() {dgvChiTietPG.SelectedRows(0).Cells(0).Value().ToString(), dgvChiTietPG.SelectedRows(0).Cells(1).Value().ToString(), dgvChiTietPG.SelectedRows(0).Cells(2).Value().ToString()}
            Connection.Update("spChiTietPhieuNhanDelete", _return, Connection.CreateParameter(_Name, _Value))
            Dim kq As Integer = _return.Value
            If kq = 1 Then
                MessageBox.Show("Phiếu nhập đã hoàn thành không thể xóa chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            loadCTPhieuNhan()
        End If
    End Sub

    Private Sub btnSuaCT_Click(sender As Object, e As EventArgs) Handles btnSuaCT.Click
        errPhieuNhan.Clear()
        If txtSoLuong.Text = "" Then
            errPhieuNhan.SetError(txtSoLuong, "Nhập số lượng cần sửa")
        End If
        If errPhieuNhan.GetError(txtSoLuong) = "" Then
            Dim _returnSuaCT As SqlParameter = New SqlParameter
            Dim _Name() As String = New String() {"@MaPG", "@MaPN", "@MaSPCu", "@MaSPMoi", "@SoLuong"}
            Dim _Value() As Object = New Object() {dgvChiTietPG.SelectedRows(0).Cells(0).Value().ToString(), dgvChiTietPG.SelectedRows(0).Cells(1).Value().ToString(), dgvChiTietPG.SelectedRows(0).Cells(2).Value().ToString(), cboTenSP.SelectedValue, txtSoLuong.Text}
            Connection.Update("spChiTietPhieuNhanUpdate", _returnSuaCT, Connection.CreateParameter(_Name, _Value))
            Dim kq As Integer = _returnSuaCT.Value
            If kq = 1 Then
                MessageBox.Show("Phiếu nhập đã hoàn thành không thể xóa chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            loadCTPhieuNhan()
        End If
    End Sub

    Private Sub dgvChiTietPG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietPG.CellClick
        If dgvChiTietPG.SelectedRows(0).Cells("colMaPN_CT").Value.ToString <> "" Then
            cboTenSP.Text = dgvChiTietPG.SelectedRows(0).Cells("colTenSP").Value.ToString
            txtSoLuong.Text = dgvChiTietPG.SelectedRows(0).Cells("colSoLuong").Value.ToString
        Else
            txtSoLuong.Text = ""
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        errPhieuNhan.Clear()
        If cboMaPN.Text = "" Then
            errPhieuNhan.SetError(cboMaPN, "Chọn mã phiếu nhập!")
        End If

        If errPhieuNhan.GetError(cboMaPN) = "" Then
            Dim _Name() As String = New String() {"@MaPN", "@MaNV", "@GhiChu"}
            Dim _Value() As Object = New Object() {cboMaPN.SelectedValue, tslMaNV.Text, txtGhiChu.Text}
            Dim _ParameterOutPut() As SqlParameter = Nothing
            _ParameterOutPut = {New SqlParameter("@MaPG", SqlDbType.NChar, 10)}
            Try
                Connection.Query("spPhieuNhanInsert", _ParameterOutPut, Connection.CreateParameter(_Name, _Value))
            Catch ex As Exception
                MessageBox.Show("Tạo phiếu nhận thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
            Dim _MaPG As String = _ParameterOutPut(0).SqlValue.ToString
            For Each _ChiTietPG As DataGridViewRow In dgvChiTietPG.Rows
                Dim _NameParameter() As String = New String() {"@MaPG", "@MaSP", "@SoLuong", "@MaPN"}
                Dim _ValueParameter() As Object = New Object() {_MaPG, _ChiTietPG.Cells("colMaSP").Value.ToString(), _ChiTietPG.Cells("colSoLuong").Value.ToString(), _ChiTietPG.Cells("colMaPN_CT").Value.ToString()}
                Try
                    Connection.Update("spChiTietPhieuNhanInsert", Connection.CreateParameter(_NameParameter, _ValueParameter))
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    MessageBox.Show("Thêm chi tiết phiếu nhận thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            Next

            Dim _ParameterPG() As String = New String() {"@MaPG"}
            Dim _ValuePG() As Object = New Object() {_MaPG}
            Try
                Connection.Update("usp_TinhTongTienPhieuNhan", Connection.CreateParameter(_ParameterPG, _ValuePG))
            Catch ex As Exception
                MessageBox.Show("Tính tổng tiền thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
            loadDSPhieuNhan()
        End If
    End Sub

    Private Sub txtTongTien_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTongTien.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSoLuong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuong.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub
End Class