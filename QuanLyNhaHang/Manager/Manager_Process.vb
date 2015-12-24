Module Manager_Process
    Dim _Table As DataTable = Nothing
    Dim _Query As String = ""
    Dim _ParameterInput As New SqlClient.SqlParameter
    Private _Connect As New Library.DatabaseConnection()

    ''' <summary>
    ''' Load DataGridview
    ''' </summary>
    ''' <param name="sourceDataGridView"></param>
    ''' <remarks></remarks>
    Public Function LoadNV(ByRef sourceDataGridView As DataGridView) As DataTable
        sourceDataGridView.Rows.Clear()

        _Query = "spNhanVienSelect"
        _Table = _Connect.Query(_Query)
        'Return _Table

        'Dim Table As New DataTable
        '_Table = _connect.Query("Select NV.MaNV, NV.HoTen, NV.TGBatDau, NV.cmnd, NV.TinhTrang, NV.NgaySinh, NV.GioiTinh, NV.LoaiNhanVien, CV.TenChucVu, CV.MaChucVu  From  NhanVien NV, ChucVuNhanVien CV Where CV.MaChucVu = NV.MaChucVu ")
        'dgvNhanVien.DataSource = Table
        For Each dt As DataRow In _Table.Rows
            Dim _LoaiNV As String = ""
            If dt(7).ToString = "True" Then
                _LoaiNV = "Fulltime"
            Else
                _LoaiNV = "Parttime"
            End If
            Dim TinhTrangNV As String = ""
            If dt(4).ToString = "True" Then
                TinhTrangNV = "Đã Nghỉ"
            Else
                TinhTrangNV = "Đang Làm"
            End If

            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2), dt(3).ToString, TinhTrangNV, dt(5), dt(6).ToString, _LoaiNV, dt(8).ToString, dt(9).ToString})
        Next

        Return _Table
    End Function

    Public Sub ReLoadNV(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        For Each dt As DataRow In _Table.Rows
            Dim _LoaiNV As String = ""
            If dt(7).ToString = "True" Then
                _LoaiNV = "Fulltime"
            Else
                _LoaiNV = "Parttime"
            End If
            Dim _TinhTrangNV As String = ""
            If dt(4).ToString = "True" Then
                _TinhTrangNV = "Đã Nghỉ"
            Else
                _TinhTrangNV = "Đang Làm"
            End If

            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2), dt(3).ToString, _TinhTrangNV, dt(5), dt(6).ToString, _LoaiNV, dt(8).ToString, dt(9).ToString})
        Next
    End Sub

    ''' <summary>
    ''' Load dữ liệu ComboBox
    ''' </summary>
    ''' <param name="comboBox">ComboBox load dữ liệu thông tin</param>
    ''' <param name="source">Dữ liệu ComboBox</param>
    ''' <param name="displayMember"></param>
    ''' <param name="valueMember"></param>
    ''' <remarks></remarks>
    Public Sub LoadComboBox(ByRef comboBox As ComboBox, ByVal source As Object, ByVal displayMember As String, ByVal valueMember As String)


        comboBox.DataSource = source
        comboBox.DisplayMember = displayMember
        comboBox.ValueMember = valueMember
    End Sub

    'Load Hóa Đơn
    Public Function LoadHoaDon(ByRef sourceDataGridView As DataGridView) As DataTable

        sourceDataGridView.Rows.Clear()

        _Query = "spHoaDonSelect"
        _Table = _Connect.Query(_Query)


        For Each dt As DataRow In _Table.Rows
            Dim _TinhTrang As String = ""
            If dt(9).ToString.Trim = "True" Then
                _TinhTrang = "Rồi"
            Else
                _TinhTrang = "Chưa"
            End If
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString, dt(6).ToString, Double.Parse(dt(7).ToString()).ToString("#,###"), dt(8).ToString, _TinhTrang})
        Next

        Return _Table
    End Function
    Public Sub ReLoadHoaDon(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

            sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Chi Tiết Hóa Đơn
    Function LoadCTHoaDon(ByRef sourceDataGridView As DataGridView) As DataTable
        Dim Table1 As New DataTable
        Table1 = _Connect.Query("Select CTHD.MaHoaDon, MADU.TenMon, CTHD.GiaMotMon, CTHD.MaCT, CTHD.GhiChu, CTHD.SoLuong, CTHD.ThanhTien, MADU.MaMon From ChiTietHoaDon CTHD, MonAnDoUong MADU Where MADU.MaMon = CTHD.MaMon")
        For Each dt As DataRow In Table1.Rows
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString, Double.Parse(dt(6).ToString).ToString("#,###"), dt(7).ToString})
        Next
        Return _Table
    End Function
    Public Sub ReLoadCTHoaDon(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Món Ăn Đồ Uống
    Public Function LoadMonAnDoUong(ByRef sourceDataGridView As DataGridView) As DataTable
        Dim _Table As New DataTable
        _Table = _Connect.Query("Select MaMon, TenMon, GiaTienHienTai, ThucDonMon From MonAnDoUong ")



        For Each dt As DataRow In _Table.Rows
            Dim arrayString() As String = New String(1) {}
            arrayString = Library.StringSplit(dt(0), 2)
            Dim _Loai As String = ""

            If arrayString(0) = "DA" Then
                _Loai = "Đồ Ăn"
            Else
                _Loai = "Đồ Uống"
            End If
            Dim _Thucdon As String = ""
            If dt(3).ToString = "True" Then
                _Thucdon = "Có"

            Else
                _Thucdon = "Không"
            End If

            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, Double.Parse(dt(2).ToString).ToString("#,###"), _Thucdon, _Loai})
        Next

        Return _Table
    End Function
    Public Sub ReLoadMonAnDoUong(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Chi Tiết Món Ăn Đồ Uống
    Public Function LoadCTMonAnDoUong(ByRef sourceDataGridView As DataGridView) As DataTable
        _Table = _Connect.Query("Select CTLM.MaMon, MADU.TenMon, CTLM.MaSP, SP.TenSP, CTLM.SoLuong, LDVT.TenDV, CTLM.MaDV From ChiTietLamMon CTLM, MonAnDoUong MADU, SanPham SP, LoaiDonViTinh LDVT Where CTLM.MaMon = MADU.MaMon and CTLM.MaSP = SP.MaSP and CTLM.MaDV = LDVT.MaDV")

        For Each dt As DataRow In _Table.Rows
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString, dt(6).ToString})
        Next
     
        Return _Table

    End Function
    Public Sub ReLoadCTMonAnDoUong(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

End Module
