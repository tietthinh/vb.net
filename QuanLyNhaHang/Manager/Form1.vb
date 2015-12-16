Public Class Form1
    Private _connect As New Library.DatabaseConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _connect.Open()
        _connect.Query()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblThoiGianBD.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtTongTien.TextChanged, TextBox4.TextChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpThoiGian.ValueChanged, DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpThoiGianBD.ValueChanged, dtpNgaySinh.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoaiNV.SelectedIndexChanged, cboTenChucVu.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblMaDatMon.Click

    End Sub

    Private Sub btnXoaDM_Click(sender As Object, e As EventArgs) Handles btnXoaDM.Click, btnTimKiemDatMon.Click, Button3.Click, Button2.Click

    End Sub

    Private Sub lblThoiGian_Click(sender As Object, e As EventArgs) Handles lblThoiGian.Click, Label3.Click

    End Sub

    Private Sub lblSoBanChung_Click(sender As Object, e As EventArgs) Handles lblSoBanChung.Click

    End Sub

    Private Sub lblTongTien_Click(sender As Object, e As EventArgs) Handles lblTongTien.Click, Label4.Click

    End Sub

    Private Sub lblSoLuongKhach_Click(sender As Object, e As EventArgs) Handles lblSoLuongKhach.Click, Label2.Click

    End Sub

    Private Sub lblGhiChu_Click(sender As Object, e As EventArgs) Handles lblGhiChu.Click, Label5.Click

    End Sub

    Private Sub lblTenNhanVien_Click(sender As Object, e As EventArgs) Handles lblTenNhanVien.Click, Label6.Click

    End Sub

    Private Sub txtMaDatMon_TextChanged(sender As Object, e As EventArgs) Handles txtMaDatMon.TextChanged

    End Sub

    Private Sub txtSoBanChung_TextChanged(sender As Object, e As EventArgs) Handles txtSoBanChung.TextChanged

    End Sub

    Private Sub txtSoLuongKhach_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuongKhach.TextChanged, TextBox2.TextChanged

    End Sub

    Private Sub txtTenNV_TextChanged(sender As Object, e As EventArgs) Handles txtTenNV.TextChanged, TextBox3.TextChanged

    End Sub

    Private Sub txtGhiChu_TextChanged(sender As Object, e As EventArgs) Handles txtGhiChu.TextChanged, txtTimKiemDatMon.TextChanged, TextBox1.TextChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDatMon.CellContentClick, DataGridView1.CellContentClick

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub dtgNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgNhanVien.CellContentClick

    End Sub

    Private Sub lblCMND_Click(sender As Object, e As EventArgs) Handles lblCMND.Click

    End Sub

    Private Sub lblLoaiNV_Click(sender As Object, e As EventArgs) Handles lblLoaiNV.Click

    End Sub

    Private Sub lblTenChucVu_Click(sender As Object, e As EventArgs) Handles lblTenChucVu.Click

    End Sub

    Private Sub lblNgaySinh_Click(sender As Object, e As EventArgs) Handles lblNgaySinh.Click

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiemNV.Click

    End Sub

    Private Sub txtMaNV_TextChanged(sender As Object, e As EventArgs) Handles txtMaNV.TextChanged

    End Sub

    Private Sub txtTen_TextChanged(sender As Object, e As EventArgs) Handles txtTen.TextChanged

    End Sub

    Private Sub txtcmnd_TextChanged(sender As Object, e As EventArgs) Handles txtcmnd.TextChanged

    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged

    End Sub

    Private Sub rdbNam_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNam.CheckedChanged

    End Sub

    Private Sub rdbNu_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNu.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub rdbDaNghi_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDaNghi.CheckedChanged

    End Sub

    Private Sub rdbDangLam_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDangLam.CheckedChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TbCtrNhanVien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TbCtrNhanVien.SelectedIndexChanged

    End Sub

    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click

    End Sub

    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click

    End Sub

    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click

    End Sub

    Private Sub lblHoTen_Click(sender As Object, e As EventArgs) Handles lblHoTen.Click

    End Sub

    Private Sub lblMaNV_Click(sender As Object, e As EventArgs) Handles lblMaNV.Click

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class
