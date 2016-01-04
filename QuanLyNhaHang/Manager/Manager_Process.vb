Module Manager_Process
    Dim _Table As DataTable = Nothing
    Dim _Query As String = ""
    Dim _ParameterInput As New SqlClient.SqlParameter
    Private _Connect As New Library.DatabaseConnection()
    Dim _Stt As Integer = 1

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
    ''' <param name="displayMember">giá trị hiển thị</param>
    ''' <param name="valueMember">giá trị phần tử hiển thị</param>
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
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString, dt(6).ToString, Double.Parse(dt(7).ToString()).ToString("#,###VND"), dt(8).ToString, _TinhTrang})
        Next

        Return _Table
    End Function
    Public Sub ReLoadHoaDon(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

            sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Chi Tiết Hóa Đơn
    Function LoadCTHoaDon(ByRef sourceDataGridView As DataGridView, ByVal Text As String) As DataTable
        Dim _Table As New DataTable
        Dim _Name() As String = New String() {"@MaHD"}
        Dim _Value() As String = New String() {Text}
        Dim _Query As String = "spChiTietHoaDonSelect"
        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))
        For Each dt As DataRow In _Table.Rows
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, Double.Parse(dt(3).ToString).ToString("#,###"), Double.Parse(dt(4).ToString).ToString("#,###VND"), Double.Parse(dt(5).ToString).ToString("#,###VND"), dt(6).ToString})
        Next
        Return _Table
    End Function
    Public Sub ReLoadCTHoaDon(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Món Ăn Đồ Uống
    Public Function LoadMonAnDoUong(ByRef sourceDataGridView As DataGridView) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        Dim _Query As String = "spMonAnDoUongSelectAll"
        _Table = _Connect.Query(_Query)


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
    Public Function LoadCTMonAnDoUong(ByRef sourceDataGridView As DataGridView, ByVal Text As String) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        Dim _Name() As String = New String() {"@MaMon"}
        Dim _Value() As String = New String() {Text}
        Dim _Query As String = "spCTLamMonSelectQuanLy"
        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))
        For Each dt As DataRow In _Table.Rows
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString})
        Next

        Return _Table

    End Function
    Public Sub ReLoadCTMonAnDoUong(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Phiếu Nhập
    Public Function LoadPhieuNhap(ByRef sourceDataGridView As DataGridView) As DataTable
        sourceDataGridView.Rows.Clear()
        _Stt = 1
        Dim _Table As New DataTable
        Dim _Query As String = "spPhieuNhapSelect"

        'Khai báo tên tình trạng phiếu nhập
        Dim _TinhTrangPN As String = ""

        
            _Table = _Connect.Query(_Query)

        For Each dt As DataRow In _Table.Rows
            If dt(7).ToString.Trim = 1 Then
                _TinhTrangPN = "Đã Khóa"
            Else
                _TinhTrangPN = "Đang Mở"
            End If
            sourceDataGridView.Rows.Add(New String() {_Stt, dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5), dt(6), _TinhTrangPN, dt(8).ToString})
            _Stt = _Stt + 1
        Next

            Return _Table

    End Function
    Public Sub ReLoadPhieuNhap(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Chi Tiết Phiếu Nhập
    Public Function LoadCTPhieuNhap(ByRef sourceDataGridView As DataGridView, ByVal Text As String) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        Dim _Query As String = "spChiTietPhieuNhapSelect"
        Dim _Name() As String = New String() {"@MaPN"}
        Dim _Value() As String = New String() {Text}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))

        For Each dt As DataRow In _Table.Rows
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, Double.Parse(dt(3).ToString).ToString("#,###"), dt(4).ToString, dt(5).ToString, Double.Parse(dt(6).ToString).ToString("#,###VND"), Double.Parse(dt(7).ToString).ToString("#,### VND")})
        Next

        Return _Table

    End Function
    Public Sub ReLoadCTPhieuNhap(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Phiếu Nhận
    Public Function LoadPhieuNhan(ByRef sourceDataGridView As DataGridView) As DataTable
        sourceDataGridView.Rows.Clear()
        _Stt = 1
        Dim _Table As New DataTable
        Dim _Query As String = "spPhieuNhanSelect"


        _Table = _Connect.Query(_Query)
        For Each dt As DataRow In _Table.Rows
            sourceDataGridView.Rows.Add(New String() {_Stt, dt(0).ToString, dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4), Double.Parse(dt(5).ToString).ToString("#,###"), dt(6).ToString})
            _Stt = _Stt + 1
        Next

        Return _Table

    End Function
    Public Sub ReLoadPhieuNhan(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Chi Tiết Phiếu Nhận
    Public Function LoadCTPhieuNhan(ByRef sourceDataGridView As DataGridView, ByVal Text As String) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        Dim _Query As String = "spChiTietPhieuNhanSelect"
        Dim _Name() As String = New String() {"@MaPG"}
        Dim _Value() As String = New String() {Text}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))
        For Each dt As DataRow In _Table.Rows
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString, dt(2).ToString, dt(3).ToString, dt(4).ToString, dt(5).ToString(), dt(6).ToString()})
        Next

        Return _Table

    End Function
    Public Sub ReLoadCTPhieuNhan(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Chức Vụ
    Public Function LoadChucVu(ByRef sourceDataGridView As DataGridView) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        Dim _Query As String = "spChucVuNhanVienSelect"

        _Table = _Connect.Query(_Query)
        For Each dt As DataRow In _Table.Rows
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString})
        Next

        Return _Table

    End Function
    Public Sub ReLoadChucVu(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Loại Đơn Vị Tính
    Public Function LoadLoaiDV(ByRef sourceDataGridView As DataGridView) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        Dim _Query As String = "spLoaiDonViTinhSelect"
        Dim _Sothuc As String = ""
        _Table = _Connect.Query(_Query)

        For Each dt As DataRow In _Table.Rows
            If dt(3) = True Then
                _Sothuc = "Số Thực"
            Else
                _Sothuc = "Số Nguyên"
            End If
            sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString(), _Sothuc})
        Next

        Return _Table

    End Function
    Public Sub ReLoadLoaiDV(ByRef sourceDataGridView As DataGridView, ByVal dataSource As DataTable)
        sourceDataGridView.Rows.Clear()

        sourceDataGridView.DataSource = dataSource

    End Sub

    'Load Thống Kê Món Hoàn Thành Theo Năm
    Public Function ThongKeNamMonHT(ByRef sourceDataGridView As DataGridView, ByVal nam As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnHoanThanhTheoNam"
        Dim _Name() As String = New String() {"@Nam"}
        Dim _Value() As String = New String() {nam}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))

        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Năm nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next
        End If
        Return _Table

    End Function
    'Load Thống Kê Món Hoàn Thành Theo Quý
    Public Function ThongKeQuyMonHT(ByRef sourceDataGridView As DataGridView, ByVal quy As Object, ByVal nam As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnHoanThanhTheoQuy"
        Dim _Name() As String = New String() {"@Quy", "@Nam"}
        Dim _Value() As String = New String() {quy, nam}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))

        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Năm nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next
        End If
        Return _Table

    End Function
    'Load Thống Kê Món Hoàn Thành Theo Tháng
    Public Function ThongKeThangMonHT(ByRef sourceDataGridView As DataGridView, ByVal thang As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnHoanThanhTheoThang"
        Dim _Name() As String = New String() {"@Thang"}
        Dim _Value() As String = New String() {thang}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))
        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Tháng nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next

            Return _Table
        End If
    End Function
    'Load Thống Kê Món Hoàn Thành Theo Ngày
    Public Function ThongKeNgayMonHT(ByRef sourceDataGridView As DataGridView, ByVal ngay As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnHoanThanhTheoNgay"
        Dim _Name() As String = New String() {"@Ngay"}
        Dim _Value() As String = New String() {ngay}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))


        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Ngày nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next
        End If
        Return _Table

    End Function



    'Load Thống Kê Món Không Hoàn Thành Theo Năm
    Public Function ThongKeNamMonKHT(ByRef sourceDataGridView As DataGridView, ByVal nam As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnKhongHoanThanhTheoNam"
        Dim _Name() As String = New String() {"@Nam"}
        Dim _Value() As String = New String() {nam}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))
        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Năm nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next
        End If

        Return _Table

    End Function
    'Load Thống Kê Món Không Hoàn Thành Theo Quý
    Public Function ThongKeQuyMonKHT(ByRef sourceDataGridView As DataGridView, ByVal quy As Object, ByVal nam As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnKhongHoanThanhTheoQuy"
        Dim _Name() As String = New String() {"@Quy", "@Nam"}
        Dim _Value() As String = New String() {quy, nam}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))

        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Quý nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next
        End If
        Return _Table

    End Function
    'Load Thống Kê Món Không Hoàn Thành Theo Tháng
    Public Function ThongKeThangMonKHT(ByRef sourceDataGridView As DataGridView, ByVal thang As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnKhongHoanThanhTheoThang"
        Dim _Name() As String = New String() {"@Thang"}
        Dim _Value() As String = New String() {thang}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))


        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Tháng nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next
        End If
        Return _Table

    End Function
    'Load Thống Kê Món Không Hoàn Thành Theo Ngày
    Public Function ThongKeNgayMonKHT(ByRef sourceDataGridView As DataGridView, ByVal ngay As Object) As DataTable
        sourceDataGridView.Rows.Clear()

        Dim _Table As New DataTable
        _Query = "usp_ThongKeMonAnKhongHoanThanhTheoNgay"
        Dim _Name() As String = New String() {"@Ngay"}
        Dim _Value() As String = New String() {ngay}

        _Table = _Connect.Query(_Query, _Connect.CreateParameter(_Name, _Value))


        If _Table.Rows.Count = 0 Then
            MessageBox.Show("Ngày nhập không tồn tại", "Thông Báo")
        Else
            For Each dt As DataRow In _Table.Rows
                sourceDataGridView.Rows.Add(New String() {dt(0).ToString(), dt(1).ToString(), dt(2).ToString()})
            Next
        End If
        Return _Table

    End Function
End Module
