Public Class FrmQLPhieuNhan
    Private Sub btnThemPG_Click(sender As Object, e As EventArgs) Handles btnThemPG.Click
        erMaPN.Clear()
        erTongTien.Clear()
        If cboMaPN.Text = "" Then
            erMaPN.SetError(cboMaPN, "Chọn mã phiếu nhập!")
        End If
        If txtTongTien.Text = "" Then
            erTongTien.SetError(txtTongTien, "Nhập tổng tiền!")
        Else
            If IsNumeric(txtTongTien.Text) = False Then
                erTongTien.SetError(txtTongTien, "Chỉ được nhập số!")
            End If
        End If
    End Sub

    Private Sub btnTimPG_Click(sender As Object, e As EventArgs) Handles btnTimPG.Click
        erMaPN.Clear()
        erTongTien.Clear()
        If cboMaPN.Text = "" And txtTongTien.Text = "" Then
            erMaPN.SetError(cboMaPN, "Chọn mã phiếu nhập!")
            erTongTien.SetError(txtTongTien, "Nhập tổng tiền!")
        End If
        If txtTongTien.Text = "" Then
        Else
            If IsNumeric(txtTongTien.Text) = False Then
                erTongTien.SetError(txtTongTien, "Chỉ được nhập số!")
            End If
        End If
    End Sub

    Private Sub btnThemCT_Click(sender As Object, e As EventArgs) Handles btnThemCT.Click
        erTenSP.Clear()
        erSoLuong.Clear()
        If cboTenSP.Text = "" Then
            erTenSP.SetError(cboTenSP, "Chọn tên sản phẩm!")
        End If
        If txtSoLuong.Text = "" Then
            erSoLuong.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                erSoLuong.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
    End Sub

    Private Sub btnTimCT_Click(sender As Object, e As EventArgs) Handles btnTimCT.Click
        erTenSP.Clear()
        erSoLuong.Clear()
        If cboTenSP.Text = "" And txtSoLuong.Text = "" Then
            erTenSP.SetError(cboTenSP, "Chọn tên sản phẩm!")
            erSoLuong.SetError(txtSoLuong, "Nhập số lượng!")
        End If
        If txtSoLuong.Text = "" Then
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                erSoLuong.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
    End Sub

    Private Sub FrmQLPhieuNhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connection As New Library.DatabaseConnection
        Dim Table As New DataTable
        Table = Connection.Query("Select PN.MaPG, PN.MaPN, NV.HoTen, PN.TongTien, PN.NgayLap, PN.GhiChu From PhieuNhan PN, NhanVien NV Where PN.MaNV = NV.MaNV")
        dgvDanhSachPG.DataSource = Table

        Dim Table1 As New DataTable
        Table1 = Connection.Query("Select CT.MaSP, SP.TenSP, CT.SoLuong, DV.TenDV, CTN.DonGia, CTN.TongTien From ChiTietPhieuNhan CT, SanPham SP, LoaiDonViTinh DV, ChiTietPhieuNhap CTN Where CT.MaSP = SP.MaSP and CT.MAPN = CTN.MaPN and CTN.MaDV = DV.MaDV")
        dgvChiTietPG.DataSource = Table1
    End Sub
End Class