Imports Library
Imports System.Data.SqlClient
Public Class frmGross_detached
    Dim db As New DatabaseConnection
    Private _ParameterInput() As SqlParameter = Nothing
    Private _ParameterOutput() As SqlParameter = Nothing
    Dim _HDGoc As String
    Dim _HDGop As String
    Dim _HDTach As String
    Dim _TinhTrang As String
    Private _MaHD As String
    Private _ThanhTien As String
    Private Sub ltvChiTietBan_Click(sender As Object, e As EventArgs) Handles ltvChiTietBan.Click
        Try

        Catch ex As Exception

        End Try
        btnGopBan.Enabled = True
        btnTachBan.Enabled = True

    End Sub

    Private Sub frmGross_detached_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Row As ListViewItem In frmCashier.ltvBan.Items
            Dim _Item As ListViewItem = ltvChiTietBan.Items.Add(Row.Text)
            _Item.SubItems.Add(Row.SubItems(1))
        Next
        KTTinhTrang()

    End Sub

    Private Sub btnGopBan_Click(sender As Object, e As EventArgs) Handles btnGopBan.Click
        If (ltvChiTietBan.SelectedItems.Count > 1) Then
            Dim _Gop = "usp_GopHoaDon"
            _HDGoc = ltvChiTietBan.SelectedItems(0).SubItems(1).Text.ToString()
            For i As Integer = 1 To ltvChiTietBan.SelectedItems.Count - 1 Step 1
                _HDGop = ltvChiTietBan.SelectedItems(i).SubItems(1).Text.ToString()
                _ParameterInput = {New SqlParameter("@MaHD", _HDGoc), New SqlParameter("@MaHDGop", _HDGop)}
                db.Query(_Gop, _ParameterInput)
            Next
            MessageBox.Show("Gộp bàn thành công", "Thông báo")
        Else
            MessageBox.Show("Vui lòng chọn 2 bàn trở lên.", "Thông báo")
        End If
    End Sub

    Private Sub btnTachBan_Click(sender As Object, e As EventArgs) Handles btnTachBan.Click

        If (ltvChiTietBan.SelectedItems.Count > 1) Then
            Dim _Tach = "usp_TachHoaDon"
            _HDTach = ltvChiTietBan.SelectedItems(0).SubItems(1).Text.ToString()
            For i As Integer = 1 To ltvChiTietBan.SelectedItems.Count - 1 Step 1
                _HDTach = ltvChiTietBan.SelectedItems(i).SubItems(1).Text.ToString()
                _ParameterInput = {New SqlParameter("@MaHD", _HDTach)}
                db.Query(_Tach, _ParameterInput)
            Next
            MessageBox.Show("Tách bàn thành công", "Thông báo")
        Else
            MessageBox.Show("Vui lòng chọn 2 bàn trở lên.", "Thông báo")
        End If
    End Sub

    Private Sub ltvChiTietBan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvChiTietBan.SelectedIndexChanged
        If (ltvChiTietBan.SelectedItems.Count = 0) Then
            btnGopBan.Enabled = False
            btnTachBan.Enabled = False
            btnThoat.Enabled = False
        Else
            btnGopBan.Enabled = True
            btnTachBan.Enabled = True
            btnThoat.Enabled = True
        End If
    End Sub

    Private Sub KTTinhTrang()
        Dim _KTThanhToan = "usp_LayTinhTrangHoaDon "
        _ParameterInput = {New SqlParameter("@MaHD", _MaHD)}
        _ParameterOutput = {New SqlParameter("@TinhTrang", SqlDbType.Char, 10)}
    End Sub
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim _ConfirmDialog As Integer = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel)
        If (_ConfirmDialog = 1) Then
            Close()
            MessageBox.Show("Thoát thành công", "Thông báo")
        End If
    End Sub
End Class