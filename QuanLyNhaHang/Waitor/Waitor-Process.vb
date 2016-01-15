Imports System.Data.SqlClient
Imports Library
Imports Remote
Public Module Waitor_Process
    Public _Connection As New DatabaseConnection
    Private _ParameterInput() As SqlParameter
    Private _ParameterOutput() As SqlParameter


    Public Function SubmitDataToDataBase(ByVal _MaMon As String,
                                    ByVal _SoLuong As Integer,
                                    ByVal _GhiChu As String,
                                    ByVal _SoBan As Integer,
                                    ByVal _MaChuyen As String) As String
        Dim _Query1 As String = "spDSDatMonTrongNgayInsert"
        _ParameterInput = {
                    New SqlParameter("@MaMon", _MaMon),
                    New SqlParameter("@SoLuong", _SoLuong),
                    New SqlParameter("@TinhTrang", 1),
                    New SqlParameter("@GhiChu", _GhiChu),
                    New SqlParameter("@SoBan", _SoBan),
                    New SqlParameter("@MaChuyen", _MaChuyen)}
        _ParameterOutput = {New SqlParameter("@MaMoi", SqlDbType.Char, 20)}
        Try
            _Connection.Query(_Query1, _ParameterOutput, _ParameterInput)
        Catch e As Exception
            MessageBox.Show(e.Message)
        End Try
        Return _ParameterOutput(0).SqlValue.ToString()
    End Function
    Public Function Login(ByRef _CurrentUser As User) As Boolean
        Dim _Login As New frmLogin(EmployeeType.Waitor)
        _Login.ShowDialog()
        _CurrentUser = DatabaseConnection._User
        If (_Login.DialogResult = 1) Then
            Return True
        End If
        Return False
    End Function
    ''' <summary>
    ''' Tải lên danh sách bàn có sẵn.
    ''' </summary>
    Public Sub LoadAvaiableTable()
        Try
            frmWaitor.lstTable.Items.Clear()
            Dim _Query As String = "spBanSelect"
            Dim dt As DataTable = _Connection.Query(_Query)
            Dim imgList As New ImageList
            Dim table As Image = My.Resources.table
            imgList.Images.Add(table)
            imgList.ImageSize = New Size(177, 175)
            frmWaitor.lstTable.LargeImageList = imgList
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                frmWaitor.lstTable.Items.Add(Integer.Parse(dt.Rows(i).Item(0).ToString()))
                frmWaitor.lstTable.Items(i).ImageIndex = 0
            Next
        Catch e As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Lấy số lượng khách tối đa của bàn đã chọn
    ''' </summary>
    ''' <param name="_TableNumber"></param>
    Public Sub GetMaximumGuest(ByVal _TableNumber As Integer)
        Try
            Dim _Query As String = "usp_LaySoLuongKhachTranBan"
            _ParameterInput = {New SqlParameter("@SoBan", _TableNumber)}
            _ParameterOutput = {New SqlParameter("@SoLuongKhach", SqlDbType.Int)}
            _Connection.Query(_Query, _ParameterOutput, _ParameterInput)
            Dim _Result As Integer = Integer.Parse(_ParameterOutput(0).SqlValue.ToString())
            frmWaitor.nudGuestCount.Maximum = _Result
        Catch e As Exception
        End Try
    End Sub
    ''' <summary>
    ''' Tải lên danh sách món ăn.
    ''' </summary>
    Public Sub LoadMenu()
        frmWaitor.lstMenu.Clear()
        frmWaitor.lstNotAvailable.Clear()
        Dim imgList As New ImageList
        Dim dish As Image = My.Resources.dishs
        Dim glass As Image = My.Resources.glass
        imgList.Images.Add(dish)
        imgList.Images.Add(glass)
        frmWaitor.lstMenu.LargeImageList = imgList
        Try
            Dim _Row As DataRow = Nothing
            Dim _DataTable As DataTable = Nothing
            Dim index As Integer = 0
            _DataTable = GetMenuList(1)
            For Each _Row In _DataTable.Rows
                frmWaitor.lstMenu.Items.Add(_Row(1).ToString())
                frmWaitor.lstMenu.Items(index).SubItems.Add(_Row(0).ToString())
                ''Set image
                If (_Row(0).ToString().Substring(0, 2) = "DA") Then
                    frmWaitor.lstMenu.Items(index).ImageIndex = 0
                Else
                    frmWaitor.lstMenu.Items(index).ImageIndex = 1
                End If
                index = index + 1
            Next
            _DataTable.Clear()
            _DataTable = GetMenuList(0)
            For Each _Row In _DataTable.Rows
                frmWaitor.lstNotAvailable.Items.Add(_Row(1).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Lưu danh sách các món đang phục vụ vào danh sách bàn đang phục vụ
    ''' </summary>
    ''' <param name="_TableNumber">Số bàn</param>
    ''' <param name="_Index">Vị trí trong danh sách</param>
    ''' <param name="_ListTable">Danh sách đang phục vụ</param>
    Public Sub SaveTable(_TableNumber As Integer, _Index As Integer, _ListTable As List(Of Table))
        ''Save
        'If existed
        If (frmWaitor.dgvList.Rows.Count > 0 And CheckExistedTable(_TableNumber, _Index, _ListTable) = True) Then
            _ListTable.RemoveAt(_Index)
            Dim _Table As New Table
            _Table.TableNumber = _TableNumber
            Dim _Order As New Order
            For i As Integer = 0 To frmWaitor.dgvList.Rows.Count - 1 Step 1
                _Order = New Order
                _Order.STT = frmWaitor.dgvList.Rows(i).Cells(0).Value.ToString
                _Order.TenMon = frmWaitor.dgvList.Rows(i).Cells(1).Value.ToString
                _Order.SoLuong = frmWaitor.dgvList.Rows(i).Cells(2).Value.ToString
                _Order.GhiChu = frmWaitor.dgvList.Rows(i).Cells(3).Value.ToString
                _Order.TinhTrang = frmWaitor.dgvList.Rows(i).Cells(4).Value.ToString
                _Order.MaChuyen = frmWaitor.dgvList.Rows(i).Cells(5).Value.ToString
                _Order.MaMon = frmWaitor.dgvList.Rows(i).Cells(6).Value.ToString
                _Table.Add(_Order)
            Next
            _ListTable.Add(_Table)
        End If
        'If not existed
        If (frmWaitor.dgvList.Rows.Count > 0 And CheckExistedTable(_TableNumber, _Index, _ListTable) = False) Then
            Dim _Table As New Table
            _Table.TableNumber = _TableNumber
            Dim _Order As New Order
            For i As Integer = 0 To frmWaitor.dgvList.Rows.Count - 1 Step 1
                _Order = New Order
                _Order.STT = frmWaitor.dgvList.Rows(i).Cells(0).Value.ToString
                _Order.TenMon = frmWaitor.dgvList.Rows(i).Cells(1).Value.ToString
                _Order.SoLuong = frmWaitor.dgvList.Rows(i).Cells(2).Value.ToString
                _Order.GhiChu = frmWaitor.dgvList.Rows(i).Cells(3).Value.ToString
                _Order.TinhTrang = frmWaitor.dgvList.Rows(i).Cells(4).Value.ToString
                _Order.MaChuyen = frmWaitor.dgvList.Rows(i).Cells(5).Value.ToString
                _Order.MaMon = frmWaitor.dgvList.Rows(i).Cells(6).Value.ToString
                _Table.Add(_Order)
            Next
            _ListTable.Add(_Table)
        End If
    End Sub
    ''' <summary>
    ''' Tải lên danh sách món ăn của bàn đã phục vụ trước đó nếu có.
    ''' </summary>
    ''' <param name="_SelectedTable">Số bàn</param>
    ''' <param name="_Index">Vị trí trong danh sách</param>
    ''' <param name="_ListTable">Danh sách đang phục vụ</param>
    Public Sub LoadTable(_SelectedTable As Integer, _Index As Integer, _ListTable As List(Of Table))
        ''Load
        If (CheckExistedTable(_SelectedTable, _Index, _ListTable) = True) Then
            frmWaitor.dgvList.Rows.Clear()
            For i As Integer = 0 To _ListTable(_Index).GetLength - 1 Step 1
                frmWaitor.dgvList.Rows.Add(_ListTable(_Index).GetOrder(i).STT,
                                 _ListTable(_Index).GetOrder(i).TenMon,
                                  _ListTable(_Index).GetOrder(i).SoLuong,
                                  _ListTable(_Index).GetOrder(i).GhiChu,
                                  _ListTable(_Index).GetOrder(i).TinhTrang,
                                  _ListTable(_Index).GetOrder(i).MaChuyen,
                                  _ListTable(_Index).GetOrder(i).MaMon)
            Next
        End If
    End Sub
    ''' <summary>
    ''' Kiểm tra bàn hiện có sẵn trong danh sách đang phục vụ
    ''' </summary>
    ''' <param name="_Table">Bàn</param>
    ''' <param name="_Index">Vị trí bàn</param>
    ''' <param name="List">Danh sách bàn</param>
    ''' <returns></returns>
    Public Function CheckExistedTable(ByVal _Table As Integer, ByRef _Index As Integer, ByVal List As List(Of Table)) As Boolean
        For i As Integer = 0 To List.Count - 1 Step 1
            If (List(i).TableNumber = _Table) Then
                _Index = i
                Return True
            End If
        Next
        Return False
    End Function
    ''' <summary>
    ''' Lấy vị trí của bàn trong danh sách đang phục vụ.
    ''' </summary>
    ''' <param name="_Number">Số Bàn</param>
    ''' <param name="List">Danh sách đang phục vụ.</param>
    ''' <returns>Vị trí của bàn trong danh sách</returns>
    Public Function GetTableByNumber(ByVal _Number As Integer, ByVal List As List(Of Table)) As Integer
        For i As Integer = 0 To List.Count - 1 Step 1
            If (List(i).TableNumber = _Number) Then
                Return i
            End If
        Next
        Return -1
    End Function
    ''' <summary>
    ''' Đếm số lượng món ăn/thức uống còn chờ thực hiện trong CSDL
    ''' </summary>
    ''' <param name="_Type">Loại món ăn (Món Ăn, Thức Uống)</param>
    ''' <returns></returns>
    Public Function CountOrder(ByVal _Type As String) As Integer
        Dim _Query As String = "spDemMonDaDat"
        _ParameterInput = {New SqlParameter("@Ma", _Type)}
        _ParameterOutput = {New SqlParameter("@SoLuong", SqlDbType.Int)}
        _Connection.Query(_Query, _ParameterOutput, _ParameterInput)
        Dim Result As Integer = Integer.Parse(_ParameterOutput(0).SqlValue.ToString())
        Return Result
    End Function
    ''' <summary>
    ''' Cập nhật tình trạng bàn.
    ''' </summary>
    ''' <param name="_TinhTrang">1:Bàn đã đặt. 0:Bàn đang trống</param>
    ''' <param name="SelectedTable">Bàn.</param>
    ''' 
    Public Sub UpdateTableStatus(ByVal _TinhTrang As Integer, ByVal SelectedTable As Integer)
        Dim _Query1 As String = "usp_CapNhapTinhTrangBan"
        _ParameterInput = {New SqlParameter("@SoBan", Integer.Parse(SelectedTable)), New SqlParameter("@TinhTrang", _TinhTrang)}
        _Connection.Query(_Query1, _ParameterInput)
    End Sub
    ''' <summary>
    ''' Lấy danh sách món ăn.
    ''' </summary>
    ''' <param name="_TinhTrang">Tình trạng:    
    ''' 1.Có sẵn.
    ''' 0:Không có sẵn</param>
    ''' <returns>Trả ra danh sách món theo điều kiện.</returns>
    Public Function GetMenuList(ByVal _TinhTrang As Integer) As DataTable
        Dim _Query As String = "spMonAnDoUongSelect"
        Dim _Parameter As New SqlParameter("@TinhTrang", _TinhTrang)
        Return _Connection.Query(_Query, _Parameter)
    End Function

    ''' <summary>
    ''' Xác nhận tình trạng món được. Đầu bếp/Pha chế => Nhân Viên
    ''' </summary>
    ''' <param name="Data">Mảng dữ liệu</param>
    Public Sub CheckChefBartenderToWaitorConfirm(ByVal Data As String)
        Dim _Array As List(Of String) = DataFilter(Data, 5)
        Dim _MaMon As String = Nothing
        If (_Array IsNot Nothing) Then
            For Each _Item In _Array
                For Each _Row As DataRow In frmWaitor.dgvList.Rows
                    If (_Row(5).ToString = _Item) Then
                        If (_Row(4).ToString = "Chưa làm") Then
                            MessageBox.Show("Món " + _Row(1).ToString + " không thể làm bạn có muốn hủy không", "Thông báo")
                            _MaMon = New String(_Row(6).ToString.Substring(0, 2))
                            If (_MaMon = "DA") Then
                                SendData("3+" + _Item + "_1*")
                                Exit Sub
                            Else
                                SendData("9+" + _Item + "_1*")
                                Exit Sub
                            End If
                        End If
                    End If
                Next
                If (_MaMon = "DA") Then
                    SendData("3+" + _Item + "_*")
                    Exit Sub
                Else
                    SendData("9+" + _Item + "_1*")
                    Exit Sub
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' Kiểm tra mã đặt có trong danh sách đang phục vụ.
    ''' </summary>
    ''' <param name="Order">Mã đặt</param>
    ''' <param name="ListTable">Danh sách đang phục vụ</param>
    ''' <returns></returns>
    Private Function CheckOrderExist(ByVal Order As String, ByVal ListTable As List(Of Table)) As String
        For Each Table As Table In ListTable
            For i As Integer = 0 To Table.GetLength - 1 Step 1
                If (Table.GetOrder(i).MaChuyen = Order) Then
                    Return i + "*" + Table.TableNumber
                End If
            Next
        Next
        Return Nothing
    End Function
    ''' <summary>
    ''' Xác nhận món đã sẵn sàng/ bị hủy. Đầu bếp/Pha chế => Nhân Viên
    ''' </summary>
    ''' <param name="Data">Dữ liệu.</param>
    Public Sub CheckChefBartenderToWaitor(ByVal Data As String)
        Dim _Array As List(Of String) = DataFilter(Data, 4)
        If (_Array IsNot Nothing) Then
            For Each _Item In _Array
                Dim _Order As String = _Item.Split("_")(0)
                Dim _Result As String = _Item.Split("_")(1)
                Dim _Quantity As Integer = _Item.Split("_")(2)
                Dim _Status As String = CheckOrderExist(_Order, frmWaitor._ListTable)
                Dim _Index As Integer = -1
                Dim _Table As Integer = -1
                If (_Status Is Nothing) Then
                    Continue For
                Else
                    _Index = Integer.Parse(_Status.Split("*")(0).ToString())
                    _Table = Integer.Parse(_Status.Split("*")(1).ToString())
                    If (_Result = "1") Then
                        frmWaitor._ListTable(_Table).GetOrder(_Index).TinhTrang = "Hoàn Thành"
                        MessageBox.Show("Món ăn " + _Order + " ở bàn số " + _Table + " đã hoàn thành.", "Thông báo")
                    Else
                        LoadMenu()
                        MessageBox.Show("Món ăn " + _Order + " ở bàn số " + _Table + " không thể làm.", "Thông báo")
                    End If
                End If
            Next
        End If
    End Sub
End Module
