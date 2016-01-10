﻿Imports System.Data.SqlClient
Imports Library
Imports Remote
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.ChannelServices
Imports System.Threading
Imports System.Net
Imports System.Configuration
Imports System.Runtime.Remoting.Channels.Http
Public Class frmCashier
    Dim db As New DatabaseConnection
    Private _MaHD As String
    Private _MaChuyenDau As String
    Private _MaChuyenCuoi As String
    Private _TongTien As Double
    Private _SelectedID As Integer = 0
    Private _ParameterInput() As SqlParameter = Nothing
    Private _ParameterOut() As SqlParameter = Nothing
    Private _ServerObject As ServerObject
    Private _Thread As Thread
    Private _Data As String = ""
    Public Function HD(ByVal _MaNV As String, ByVal _SoBan As Integer, ByVal _SLKhach As Integer, ByVal _GhiChu As String) As String
        Dim _HD As String = "spHoaDonInsert"
        _ParameterInput = {New SqlParameter("@MaNV", _MaNV), New SqlParameter("@SoBan", _SoBan), New SqlParameter("@SoLuongKhach", _SLKhach), New SqlParameter("@GhiChu", _GhiChu)}
        _ParameterOut = {New SqlParameter("@MaHD", SqlDbType.Char, 10)}
        Dim tb As DataTable = Nothing
        tb = db.Query(_HD, _ParameterOut, _ParameterInput)
        Dim _Return As String = _ParameterOut(0).SqlValue.ToString()
        Return _Return
    End Function


    Public Function VT_Ban(ByVal _MaChuyenDau As String, _MaChuyenCuoi As String) As DataTable
        Dim _DSDatMon = "spDSDatMonTrongNgaySelectThuNgan "
        _ParameterInput = {New SqlParameter("@MaChuyenDau", _MaChuyenDau), New SqlParameter("@MaChuyenCuoi", _MaChuyenCuoi)}
        Dim tb As DataTable = Nothing
        tb = db.Query(_DSDatMon, _ParameterInput)
        Return tb
    End Function

    Public Function GiaMoTMon(ByVal MaMon As String) As String
        Dim _Gia = "LayGiaTienMon"
        _ParameterInput = {New SqlParameter("@MaMon", MaMon)}
        Dim tb As DataTable = Nothing
        tb = db.Query(_Gia, _ParameterInput)
        Return Double.Parse(tb.Rows(0).Item(0).ToString)
    End Function
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub InitializeRemoteServer()
        Dim _Channel As String = "http://" + ConfigurationManager.AppSettings.Get("IP").ToString + ":" + ConfigurationManager.AppSettings.Get("Port").ToString + "/" + ConfigurationManager.AppSettings.Get("Domain").ToString
        RemotingConfiguration.RegisterWellKnownClientType(GetType(ServerObject), _Channel)
    End Sub
    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaDau.Width = 0
        MaCuoi.Width = 0
        Try
            ''Initiate connection
            Dim _Channel As New HttpChannel
            RegisterChannel(_Channel, True)
            InitializeRemoteServer()
            ''Start thread listening
            _ServerObject = New ServerObject()
            _Thread = New Thread(New ThreadStart(Sub() Process()))
            _Thread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Kết nối thất bại!", "Lỗi")
            Me.Close()
        End Try
    End Sub


    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        Try
            MessageBox.Show("Thanh toán thành công!", "Thông báo")
            Dim _ConfirmDialog As Integer = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel)
            If (_ConfirmDialog = 1) Then
                ltvBan.Items.RemoveAt(_SelectedID)
                For i As Integer = 0 To dgvChiTietHoaDon.Rows.Count - 2 Step 1
                    Dim _Query1 As String = "spChiTietHoaDonInsert"
                    _ParameterInput = {New SqlParameter("@MaHD", _MaHD),
                                       New SqlParameter("@MaMon", dgvChiTietHoaDon.Rows(i).Cells(0).Value.ToString()),
                                       New SqlParameter("@SoLuong", ConvertMoneyToDouble(dgvChiTietHoaDon.Rows(i).Cells(2).Value)),
                                       New SqlParameter("@GiaMotMon", ConvertMoneyToDouble(dgvChiTietHoaDon.Rows(i).Cells(3).Value)),
                                       New SqlParameter("@ThanhTien", ConvertMoneyToDouble(dgvChiTietHoaDon.Rows(i).Cells(4).Value)),
                                       New SqlParameter("@GhiChu", dgvChiTietHoaDon.Rows(i).Cells(5).Value.ToString())}
                    db.Query(_Query1, _ParameterInput)
                Next
                Dim _Query2 As String = "spHoaDonUpdate"
                _ParameterInput = {New SqlParameter("@MaHD", _MaHD), New SqlParameter("@TongTien", _TongTien), New SqlParameter("@TinhTrang", 1)}
                db.Query(_Query2, _ParameterInput)

                dgvChiTietHoaDon.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnGopBan_Click(sender As Object, e As EventArgs) Handles btnGopBan.Click
        Dim frm As New frmGross_detached
        frm.Show()
    End Sub

    Private Sub ltvBan_Click(sender As Object, e As EventArgs) Handles ltvBan.Click
        _TongTien = 0
        _MaHD = ltvBan.SelectedItems(0).SubItems(1).Text.ToString()
        _MaChuyenDau = ltvBan.SelectedItems(0).SubItems(2).Text.ToString()
        _MaChuyenCuoi = ltvBan.SelectedItems(0).SubItems(3).Text.ToString()
        dgvChiTietHoaDon.Rows.Clear()
        _SelectedID = ltvBan.SelectedItems(0).Index
        Dim vtBan As New DataTable
        vtBan = VT_Ban(_MaChuyenDau, _MaChuyenCuoi)
        For Each Rows As DataRow In vtBan.Rows
            dgvChiTietHoaDon.Rows.Add(Rows(0), Rows(1), Rows(2), GiaMoTMon(Rows(0)), Double.Parse(GiaMoTMon(Rows(0))) * Double.Parse(Rows(2)), Rows(3))
        Next
        If (dgvChiTietHoaDon.Rows.Count > 0) Then
            For i As Integer = 0 To dgvChiTietHoaDon.Rows.Count - 1
                _TongTien += dgvChiTietHoaDon.Rows(i).Cells("ThanhTien").Value
                lblTien.Text = _TongTien.ToString("#,### VND")
            Next
        End If
        btnThanhToan.Enabled = True
    End Sub
    Private Function ConvertMoneyToDouble(ByVal _Currency As String) As Long
        Dim _Convert As Long = Long.Parse(_Currency, Globalization.NumberStyles.Number)
        Return _Convert
    End Function

    Private Sub ltvBan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvBan.SelectedIndexChanged
        If (ltvBan.SelectedItems.Count = 0) Then
            btnThanhToan.Enabled = False
            btnGopBan.Enabled = False
        Else
            btnThanhToan.Enabled = True
            btnGopBan.Enabled = True
        End If
    End Sub
    Private Sub Process()
        While (True)
            Thread.Sleep(0)
            If (Me.IsAccessible = True) Then
                Me.Invoke(New MethodInvoker(Sub()
                                                Dim _Text As String = _ServerObject.GetHolder()
                                                Dim _Length As Integer = _Data.Length
                                                Dim _ReceiveData As String = _Text.Substring(_Length)
                                                ''Handles event here.
                                                If (_ReceiveData <> "" And _ReceiveData.Length > 2) Then
                                                    CheckWaitorToCashierSignal(_ReceiveData)
                                                End If
                                                ''
                                                _Data = _Text

                                            End Sub
                ))
            Else
                Exit While
            End If
        End While
    End Sub
    Private Sub CheckWaitorToCashierSignal(ByVal _MaMon As String)
        Dim _Array As List(Of String) = SplitData(_MaMon, "1")
        For Each _MaMonAn As String In _Array
            If (_MaMonAn <> "" And _MaMonAn.Length > 2) Then
                _MaChuyenDau = _MaMonAn.Split("_")(0).Trim
                _MaChuyenCuoi = _MaMonAn.Split("_")(1).Trim
                Dim _MaNhanVien As String = _MaMonAn.Split("_")(2)
                Dim _SoLuongKhach As Integer = _MaMonAn.Split("_")(3)
                ''TODO your code here
                Dim Query As String = "spHoaDonInsert "
                _ParameterInput = {New SqlParameter("@MaNV", _MaNhanVien),
                               New SqlParameter("@SoBan", Integer.Parse(_MaChuyenDau.Substring(0, 2))),
                               New SqlParameter("@SoLuongKhach", _SoLuongKhach),
                               New SqlParameter("@GhiChu", "")}
                _ParameterOut = {New SqlParameter("@MaHD", SqlDbType.Char, 10)}
                db.Query(Query, _ParameterOut, _ParameterInput)
                Dim _Item As ListViewItem = ltvBan.Items.Add(_MaChuyenDau.Substring(0, 2))
                _Item.SubItems.Add(_ParameterOut(0).SqlValue.ToString())
                _Item.SubItems.Add(_MaChuyenDau)
                _Item.SubItems.Add(_MaChuyenCuoi)
            End If
        Next
    End Sub
    Private Function SplitData(ByVal _ReceiveData As String, ByVal _Code As String) As List(Of String)
        Dim _ReceiveArray As New List(Of String)
        Dim _ReturnArray As New List(Of String)
        Dim j As Integer = 0
        For i As Integer = 0 To _ReceiveData.Split("*").Length - 2 Step 1
            _ReceiveArray.Add(_ReceiveData.Split("*")(i))
        Next
        For i As Integer = 0 To _ReceiveArray.Count - 1 Step 1
            Dim _Item As New String(_ReceiveArray(i).ToString)
            If (_Item <> "") Then
                If (_Code.Equals(_Item.Split("+")(0).Last.ToString) = True) Then
                    _ReturnArray.Add(_Item.Split("+")(1))
                    j += 1
                End If
            End If
        Next
        Return _ReturnArray
    End Function
End Class