Imports System.Data.SqlClient
Imports Library
Imports Remote
Public Module Waitor_Process
    Public _Connection As New DatabaseConnection
    Private _ParameterInput() As SqlParameter
    Private _ParameterOutput() As SqlParameter
<<<<<<< HEAD

    Public Sub SaveTable(_PreviousTable As PictureBox, _Index As Integer, _ListTable As List(Of Table))
        ''Save
        'If existed
        If (Waitor.dgvList.Rows.Count > 0 And CheckExistedTable(_PreviousTable, _Index, _ListTable) = True) Then
            Dim _Order As New Order
            Dim _ContinuesPosition As Integer = _ListTable(_Index).GetLength
            For i As Integer = _ContinuesPosition To Waitor.dgvList.Rows.Count - 1 Step 1
                _Order = New Order
                _Order.STT = Waitor.dgvList.Rows(i).Cells(0).Value.ToString
                _Order.TenMon = Waitor.dgvList.Rows(i).Cells(1).Value.ToString
                _Order.SoLuong = Waitor.dgvList.Rows(i).Cells(2).Value.ToString
                _Order.GhiChu = Waitor.dgvList.Rows(i).Cells(3).Value.ToString
                _Order.TinhTrang = Waitor.dgvList.Rows(i).Cells(4).Value.ToString
                _Order.MaChuyen = Waitor.dgvList.Rows(i).Cells(5).Value.ToString
                _Order.MaMon = Waitor.dgvList.Rows(i).Cells(6).Value.ToString
                _ListTable(_Index).Add(_Order)
            Next
            Waitor.dgvList.Rows.Clear()
        End If
        'If not existed
        If (Waitor.dgvList.Rows.Count > 0 And CheckExistedTable(_PreviousTable, _Index, _ListTable) = False) Then
            Dim _Table As New Table
            _Table.TableNumber = Integer.Parse(_PreviousTable.Name.Last.ToString())
            Dim _Order As New Order
            For i As Integer = 0 To Waitor.dgvList.Rows.Count - 1 Step 1
                _Order = New Order
                _Order.STT = Waitor.dgvList.Rows(i).Cells(0).Value.ToString
                _Order.TenMon = Waitor.dgvList.Rows(i).Cells(1).Value.ToString
                _Order.SoLuong = Waitor.dgvList.Rows(i).Cells(2).Value.ToString
                _Order.GhiChu = Waitor.dgvList.Rows(i).Cells(3).Value.ToString
                _Order.TinhTrang = Waitor.dgvList.Rows(i).Cells(4).Value.ToString
                _Order.MaChuyen = Waitor.dgvList.Rows(i).Cells(5).Value.ToString
                _Order.MaMon = Waitor.dgvList.Rows(i).Cells(6).Value.ToString
                _Table.Add(_Order)
            Next
            _ListTable.Add(_Table)
            Waitor.dgvList.Rows.Clear()
        End If
    End Sub

    Public Sub LoadTable(_SelectedTable As PictureBox, _Index As Integer, _ListTable As List(Of Table))
        ''Load
        If (CheckExistedTable(_SelectedTable, _Index, _ListTable) = True) Then
            Waitor.dgvList.Rows.Clear()
            For i As Integer = 0 To _ListTable(_Index).GetLength - 1 Step 1
                Waitor.dgvList.Rows.Add(_ListTable(_Index).GetOrder(i).STT,
                                 _ListTable(_Index).GetOrder(i).TenMon,
                                  _ListTable(_Index).GetOrder(i).SoLuong,
                                  _ListTable(_Index).GetOrder(i).GhiChu,
                                  _ListTable(_Index).GetOrder(i).TinhTrang,
                                  _ListTable(_Index).GetOrder(i).MaChuyen,
                                  _ListTable(_Index).GetOrder(i).MaMon)
            Next
        End If
    End Sub
=======
>>>>>>> TietThinh-NhanVien
    ''' <summary>
    ''' Cập nhật tình trạng bàn.
    ''' </summary>
    ''' <param name="_TinhTrang">1:Bàn đã đặt. 0:Bàn đang trống</param>
    ''' <param name="SelectedTable">Bàn.</param>
<<<<<<< HEAD
    ''' 
=======
>>>>>>> TietThinh-NhanVien
    Public Sub UpdateTableStatus(ByVal _TinhTrang As Integer, ByVal SelectedTable As PictureBox)
        Dim _Query1 As String = "usp_CapNhapTinhTrangBan"
        _ParameterInput = {New SqlParameter("@SoBan", Integer.Parse(SelectedTable.Name.Last)), New SqlParameter("@TinhTrang", _TinhTrang)}
        _Connection.Query(_Query1, _ParameterInput)
    End Sub
    ''' <summary>
    ''' Lấy danh sách món ăn.
    ''' </summary>
    ''' <param name="_TinhTrang">Tình trạng:    
    ''' 1.Có sẵn.
    ''' 0:Không có sẵn</param>
    ''' <returns></returns>
    Public Function GetMenuList(ByVal _TinhTrang As Integer) As DataTable
        Dim _Query As String = "spMonAnDoUongSelect"
        Dim _Parameter As New SqlParameter("@TinhTrang", _TinhTrang)
        Return _Connection.Query(_Query, _Parameter)
    End Function
    ''' <summary>
    ''' Tải lên danh sách món ăn.
    ''' </summary>
    Public Sub LoadMenu()
        Waitor.lstMenu.Clear()
        Waitor.lstNotAvailable.Clear()
        Dim imgList As New ImageList
        Dim dish As Image = My.Resources.dishs
        Dim glass As Image = My.Resources.glass
        imgList.Images.Add(dish)
        imgList.Images.Add(glass)
        Waitor.lstMenu.LargeImageList = imgList
        Try
            Dim _Row As DataRow = Nothing
            Dim _DataTable As DataTable = Nothing
            Dim index As Integer = 0
            _DataTable = GetMenuList(1)
            For Each _Row In _DataTable.Rows
                Waitor.lstMenu.Items.Add(_Row(1).ToString())
                Waitor.lstMenu.Items(index).SubItems.Add(_Row(0).ToString())
                ''Set image
                If (_Row(0).ToString().Substring(0, 2) = "DA") Then
                    Waitor.lstMenu.Items(index).ImageIndex = 0
                Else
                    Waitor.lstMenu.Items(index).ImageIndex = 1
                End If
                index = index + 1
            Next
            _DataTable.Clear()
            _DataTable = GetMenuList(0)
            For Each _Row In _DataTable.Rows
                Waitor.lstNotAvailable.Items.Add(_Row(1).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Kiểm tra bàn hiện có sẵn trong danh sách đang phục vụ
    ''' </summary>
    ''' <param name="_Table">Bàn</param>
    ''' <param name="_Index">Vị trí bàn</param>
    ''' <param name="List">Danh sách bàn</param>
    ''' <returns></returns>
    Public Function CheckExistedTable(ByVal _Table As PictureBox, ByRef _Index As Integer, ByVal List As List(Of Table)) As Boolean
        For i As Integer = 0 To List.Count - 1 Step 1
            If (List(i).TableNumber = _Table.Name.Last.ToString) Then
                _Index = i
                Return True
            End If
        Next
        Return False
    End Function
    ''' <summary>
    ''' Search a table with table number 
    ''' </summary>
    ''' <param name="TableNumber">Tìm kiếm và trả về vị trí của bàn trong danh sách đang phục vụ.</param>
    ''' <returns>Position of table</returns>
    Public Function SearchTable(ByVal TableNumber As Integer, ByVal List As List(Of Table)) As Integer
        For i As Integer = 0 To List.Count - 1 Step 1
            If (List(i).TableNumber = TableNumber) Then
                Return (i + 1)
            End If
        Next
        Return -1
    End Function
    ''' <summary>
    ''' Xác nhận tình trạng món được. Đầu bếp/Pha chế => Nhân Viên
    ''' </summary>
    ''' <param name="Data">Mảng dữ liệu</param>
    Public Sub CheckChefBartenderToWaitorConfirm(ByVal Data As String)
        Dim _Array As List(Of String) = DataFilter(Data, 4)
        If (_Array IsNot Nothing) Then
            For Each _Item In _Array
                For Each _Row As DataRow In Waitor.dgvList.Rows
                    If (_Row(5).ToString = _Item) Then
                        If (_Row(4).ToString = "Chưa làm") Then
                            SendData("3+" + _Item + "_1*")
                            Exit Sub
                        End If
                    End If
                Next
                SendData("3+" + _Item + "_0*")
            Next
        End If
    End Sub
    ''' <summary>
    ''' Xác nhận món đã sẵn sàng/ bị hủy. Đầu bếp/Pha chế => Nhân Viên
    ''' </summary>
    ''' <param name="Data">Dữ liệu.</param>
    Public Sub CheckChefBartenderToWaitor(ByVal Data As String)
        Dim _Array As List(Of String) = DataFilter(Data, 4)
        If (_Array IsNot Nothing) Then
            For Each _Item In _Array
                Dim _Order As String = _Item.Split("_")(1)
                Dim _Result As String = _Item.Split("_")(2)
                Dim _Quantity As Integer = _Item.Split("_")(3)
                Dim _Index As Integer = 0
                For i As Integer = 0 To Waitor.dgvList.RowCount - 1 Step 1
                    If (Waitor.dgvList.Item(5, i).Value.ToString = _Order) Then
                        _Result = True
                        _Order = Waitor.dgvList.Item(1, i).Value.ToString + Waitor.dgvList.Item(3, i).Value.ToString
                        _Index = i
                        Exit For
                    End If
                Next
                If (_Result = "1") Then
                    Waitor.dgvList.Item(4, _Index).Value = "Hoàn thành"
                    MessageBox.Show("Món ăn " + _Order + " đã hoàn thành.", "Thông báo")
                Else
                    LoadMenu()
                    MessageBox.Show("Món ăn " + _Order + " không thể làm.", "Thông báo")
                End If
            Next
        End If
    End Sub
End Module
