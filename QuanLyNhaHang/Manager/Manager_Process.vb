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
    ''' <param name="comboBox"></param>
    ''' <param name="source"></param>
    ''' <param name="displayMember"></param>
    ''' <param name="valueMember"></param>
    ''' <remarks></remarks>
    Public Sub LoadComboBox(ByRef comboBox As ComboBox, ByVal source As Object, ByVal displayMember As String, ByVal valueMember As String)


        comboBox.DataSource = source
        comboBox.DisplayMember = displayMember
        comboBox.ValueMember = valueMember
    End Sub
End Module
