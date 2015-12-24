Public Class FrmQLPhieuNhap
    Private Sub btnThemPN_Click(sender As Object, e As EventArgs) Handles btnThemPN.Click
        erNCC.Clear()
        If cbNhaCC.Text = "" Then
            erNCC.SetError(cbNhaCC, "Chọn tên nhà cung cấp!")
        End If
    End Sub

    Private Sub btnTimPN_Click(sender As Object, e As EventArgs) Handles btnTimPN.Click
        erNCC.Clear()
        If cbNhaCC.Text = "" Then
            erNCC.SetError(cbNhaCC, "Chọn tên nhà cung cấp!")
        End If
    End Sub

    Private Sub btnTimCT_Click(sender As Object, e As EventArgs) Handles btnTimCT.Click
        erTenSP.Clear()
        erSoLuong.Clear()
        erDonVi.Clear()
        erDonGia.Clear()
        erTongTien.Clear()
        If txtTenSP.Text = "" And txtSoLuong.Text = "" And cbDonVi.Text = "" And txtDonGia.Text = "" And
            txtTongTien.Text = "" Then
            erTenSP.SetError(txtTenSP, "Nhập tên sản phẩm!")
            erSoLuong.SetError(txtSoLuong, "Nhập số lượng!")
            erDonVi.SetError(cbDonVi, "Chọn đơn vị!")
            erDonGia.SetError(txtDonGia, "Nhập đơn giá!")
            erTongTien.SetError(txtTongTien, "Nhập tổng tiền!")
        End If

        If txtSoLuong.Text = "" Then
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                erSoLuong.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If txtDonGia.Text = "" Then
        Else
            If IsNumeric(txtDonGia.Text) = False Then
                erDonGia.SetError(txtDonGia, "Chỉ được nhập số!")
            End If
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
        erDonVi.Clear()
        erDonGia.Clear()
        erTongTien.Clear()
        If txtTenSP.Text = "" Then
            erTenSP.SetError(txtTenSP, "Chọn tên sản phẩm!")
        End If
        If txtSoLuong.Text = "" Then
            erSoLuong.SetError(txtSoLuong, "Nhập số lượng!")
        Else
            If IsNumeric(txtSoLuong.Text) = False Then
                erSoLuong.SetError(txtSoLuong, "Chỉ được nhập số!")
            End If
        End If
        If cbDonVi.Text = "" Then
            erDonVi.SetError(cbDonVi, "Chọn đơn vị!")
        End If
        If txtDonGia.Text = "" Then
            erDonGia.SetError(txtDonGia, "Nhập đơn giá!")
        Else
            If IsNumeric(txtDonGia.Text) = False Then
                erDonGia.SetError(txtDonGia, "Chỉ được nhập số!")
            End If
        End If
        If txtTongTien.Text = "" Then
            erTongTien.SetError(txtTongTien, "Nhập tổng tiền!")
        Else
            If IsNumeric(txtTongTien.Text) = False Then
                erTongTien.SetError(txtTongTien, "Chỉ được nhập số!")
            End If
        End If
    End Sub

    Private Sub btnTimLB_Click(sender As Object, e As EventArgs) Handles btnTimLB.Click
        If txtTimLB.Text = "" Then
            erTimKiem.SetError(txtTimLB, "Nhập sản phẩm cần tìm!")
        End If
    End Sub

    Private Sub FrmQLPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connection As New Library.DatabaseConnection
        Dim Table As New DataTable
        Table = Connection.Query("Select PN.MaPN, NV.HoTen, NCC.TenNCC, PN.NgayLap, PN.NgayGiaoDK, PN.TinhTrang From PhieuNhap PN, NhaCungCap NCC, NhanVien NV Where PN.MaNV = NV.MaNV and PN.MaNCC=NCC.MaNCC")
        dgvDSPhieuNhap.DataSource = Table

        Dim Table1 As New DataTable
        Table1 = Connection.Query("Select SP.MaSP, SP.TenSP, CT.SoLuong, DV.TenDV, CT.DonGia, CT.TongTien From ChiTietPhieuNhap CT, SanPham SP, LoaiDonViTinh DV Where CT.MaSP = SP.MaSP and SP.MaDV = DV.MaDV")
        dgvDSChiTietPhieuNhap.DataSource = Table1
        dgvDSChiTietPhieuNhap.Columns("TongTien").DefaultCellStyle.Format = "#,###"
        dgvDSChiTietPhieuNhap.Columns("DonGia").DefaultCellStyle.Format = "#,###"

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
End Class