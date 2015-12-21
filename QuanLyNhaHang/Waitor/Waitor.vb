Imports System.Data.SqlClient
Imports Library
Imports Remote
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.ChannelServices
Imports System.Threading
Imports System.Net
Imports System.Configuration

Public Class NhanVien
    Private _frmNumpad As frmNumPad
    Private _Connection As New DatabaseConnection
    Private _IsSelected As Boolean = False
    Private _PictureBoxEffect As PictureBox
    Private _SelectedTable As PictureBox
    Private _ServerObject As ServerObject
    Private _Thread As Thread
    Private _Data As String = ""
    Private _Logging As String = ""
    Private _CurrentUser As User = Nothing
    Private _ParameterInput() As SqlParameter
    Private _ParameterOutput() As SqlParameter
    Private _OrderHolder() As List(Of String)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub InitializeRemoteServer()
        Dim _Channel As String = "http://" + ConfigurationManager.AppSettings.Get("IP").ToString + ":" + ConfigurationManager.AppSettings.Get("Port").ToString + "/" + ConfigurationManager.AppSettings.Get("Domain").ToString
        RemotingConfiguration.RegisterWellKnownClientType(GetType(ServerObject), _Channel)
    End Sub
    Private Sub picTable01_Click(sender As Object, e As EventArgs) Handles picTable01.Click, picTable02.Click, picTable03.Click, picTable04.Click,
        picTable05.Click, picTable06.Click, picTable07.Click, picTable08.Click, picTable09.Click
        _SelectedTable = CType(sender, PictureBox)
        If (_IsSelected = False) Then
            Dim a As Integer = MessageBox.Show("Vui lòng kiểm tra số bàn!" + vbCrLf + "Bạn đang chọn bàn số " + _SelectedTable.Name.Last, "Xác Nhận", MessageBoxButtons.OKCancel)
            If (a = 1) Then
                Dim _Number As String = "BÀN " + _SelectedTable.Name.Last
                _PictureBoxEffect = _SelectedTable
                _PictureBoxEffect.BackColor = Color.RoyalBlue
                lblTittle.Text = "DANH SÁCH MÓN ĂN " + _Number
                lstMenu.Enabled = True
                _IsSelected = True
                AppProvider._IsCommitted = False
                UpdateTableStatus(1)
                LoadMenu()
            End If
        Else
            ''Multi-table saver
            Dim _ListOrder As List(Of String) = Nothing
            For i As Integer = 0 To dgvList.Rows.Count - 1 Step 1
                _ListOrder.Add(_SelectedTable.Name.Last)
                _ListOrder.Add(dgvList.Rows(i).Cells(0).Value.ToString())
                _ListOrder.Add(dgvList.Rows(i).Cells(1).Value.ToString())
                _ListOrder.Add(dgvList.Rows(i).Cells(2).Value.ToString())
                _ListOrder.Add(dgvList.Rows(i).Cells(3).Value.ToString())
                _ListOrder.Add(dgvList.Rows(i).Cells(4).Value.ToString())
                _ListOrder.Add(dgvList.Rows(i).Cells(5).Value.ToString())
                _ListOrder.Add(dgvList.Rows(i).Cells(6).Value.ToString())
                Array.Resize(_OrderHolder, _OrderHolder.Length + 1)
                _OrderHolder(_OrderHolder.Length - 1) = _ListOrder
            Next
            ''
        End If
    End Sub
    Private Sub listMenu_Click(sender As Object, e As EventArgs) Handles lstMenu.Click
        AppProvider._IsUpdate = False
        AppProvider._SelectedItem = lstMenu.SelectedItems(0).SubItems(1).Text.ToString
        Dim Add As New Add()
        Add.ShowDialog()
    End Sub
    Private Sub dtgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellContentClick
        AppProvider._IsUpdate = True
        Dim add As New Add()
        add.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _frmNumpad = New frmNumPad(nudGuestCount)
        _frmNumpad.StartPosition = FormStartPosition.Manual
        _frmNumpad.Location = New Point(940, 380)
        Dim _Login As New frmLogin(_CurrentUser)
        _Login.ShowDialog()
        If (_Login.DialogResult = 1) Then
            ''********************************************Service Initiate*******************************************
            Try
                Me.Text = "Nhân viên " + _CurrentUser.EmployeeName
                ''Initiate connection
                Dim _Channel As New Http.HttpChannel
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
            ''********************************************Service Initiate*******************************************
            LoadMenu()
            Me.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub btnLamMon_Click(sender As Object, e As EventArgs) Handles btnLamMon.Click
        ''Commit the list to Chef
        If (dgvList.Rows.Count <> 0) Then
            Dim index As Integer = 0
            Dim _Row As DataGridViewRow
            Dim _Query1 As String = "spDSDatMonTrongNgayInsert"
            ''Group
            For i As Integer = 0 To dgvList.Rows.Count - 2 Step 1
                Dim _Count As Integer = 0
                For j As Integer = dgvList.Rows.Count - 1 To i + 1 Step -1
                    If (dgvList.Item(6, i).Value = dgvList.Item(6, j).Value And dgvList.Item(3, i).Value = dgvList.Item(3, j).Value And dgvList.Item(4, i).Value = dgvList.Item(4, j).Value) Then
                        dgvList.Item(2, i).Value += dgvList.Item(2, j).Value
                        dgvList.Rows.RemoveAt(j)
                    End If
                Next
            Next
            ''Insert
            For Each _Row In dgvList.Rows
                ''Preparing for fixing update order list procedure.
                Dim _Code As String = dgvList.Item(5, index).Value
                If (_Code = Nothing) Then
                    _ParameterOutput = {New SqlParameter("@MaMoi", SqlDbType.Char, 10)}
                    _ParameterInput = {
                        New SqlParameter("@MaMon", dgvList.Item(6, index).Value),
                        New SqlParameter("@SoLuong", dgvList.Item(2, index).Value),
                        New SqlParameter("@TinhTrang", 1),
                        New SqlParameter("@GhiChu", dgvList.Item(3, index).Value),
                        New SqlParameter("@SoBan", Integer.Parse(_SelectedTable.Name.Last()))}
                    _Connection.Query(_Query1, _ParameterOutput, _ParameterInput)
                    dgvList.Item(5, index).Value = _ParameterOutput(0).SqlValue.ToString
                End If
                index += 1
            Next
            AppProvider._IsCommitted = True
            MessageBox.Show("Gửi danh sách thành công!", "Thông báo", MessageBoxButtons.OK)
            ''Counting on waiting order.
            Dim _Query2 As String = "spDemMonDaDat"
            For i As Integer = 0 To dgvList.Rows.Count - 1 Step 1
                If (dgvList.Item(4, i).Value = "Chưa làm") Then
                    _ServerObject.AddData(dgvList.Item(5, i).Value)
                    Exit For
                End If
            Next
            ''Send Chef/Bartender signal.
            Dim _SoLuongMon As Integer = Integer.Parse(_Connection.Query(_Query2).Rows(0).Item(0).ToString)
            If (_SoLuongMon = 0) Then
                _ServerObject.AddData("2+" + dgvList.Item(5, 0).Value)
            End If
        Else
            MessageBox.Show("Danh sách món ăn trống!", "Thông báo")
        End If
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If (AppProvider._IsCommitted = True And _IsSelected = True) Then
            ''Commit the list to Cashier
            _ServerObject.AddData("1+" + dgvList.Item(5, 0).Value.ToString + "_" + dgvList.Item(5, dgvList.RowCount - 1).Value.ToString + +_CurrentUser.Identity + nudGuestCount.Value)
            ''Remove Effect & Clear list orders
            _PictureBoxEffect.BackColor = Color.White
            dgvList.Rows.Clear()
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Danh sách món ăn rỗng!", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (_IsSelected = True And dgvList.Rows.Count > 0) Then
            Try
                Dim a As Integer = MessageBox.Show("Vui lòng kiểm tra số bàn!" + vbCrLf + "Bạn đang chọn bàn số " + _SelectedTable.Name.Last, "Xác Nhận", MessageBoxButtons.OKCancel)
                If (a = 1) Then
                    If (AppProvider._IsCommitted = True) Then
                        ''Update status on database
                        Dim _Query As String = "spDSDatMonTrongNgayUpdateTinhTrang"
                        _ParameterInput = {New SqlParameter("@MaChuyen", dgvList.SelectedRows.Item(0).Cells(5).Value), New SqlParameter("@TinhTrang", 4)}
                        _Connection.Query(_Query, _ParameterInput)
                    End If
                    dgvList.Rows.RemoveAt(dgvList.SelectedRows.Item(0).Index)
                End If
            Catch
            End Try
        Else
            MessageBox.Show("Danh sách món ăn rỗng!", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub btnUpdateTable_Click(sender As Object, e As EventArgs) Handles btnUpdateTable.Click
        If (_IsSelected = True) Then
            '' Update to Database
            UpdateTableStatus(0)
            ''
            _IsSelected = False
            lstMenu.Enabled = False
            MessageBox.Show("Thiết lập thành công!", "Thông báo", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Bàn chưa được chọn!", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub LoadMenu()
        lstMenu.Clear()
        lstNotAvailable.Clear()
        Dim imgList As New ImageList
        Dim dish As Image = My.Resources.dishs
        Dim glass As Image = My.Resources.glass
        imgList.Images.Add(dish)
        imgList.Images.Add(glass)
        lstMenu.LargeImageList = imgList
        Try
            Dim _Row As DataRow = Nothing
            Dim _DataTable As DataTable = Nothing
            Dim index As Integer = 0
            _DataTable = GetMenuList(1)
            For Each _Row In _DataTable.Rows
                lstMenu.Items.Add(_Row(1).ToString())
                lstMenu.Items(index).SubItems.Add(_Row(0).ToString())
                ''Set image
                If (_Row(0).ToString().Substring(0, 2) = "DA") Then
                    lstMenu.Items(index).ImageIndex = 0
                Else
                    lstMenu.Items(index).ImageIndex = 1
                End If
                index = index + 1
            Next
            _DataTable.Clear()
            _DataTable = GetMenuList(0)
            For Each _Row In _DataTable.Rows
                lstNotAvailable.Items.Add(_Row(1).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdateTableStatus(ByVal _TinhTrang As Integer)
        Dim _Query1 As String = "usp_CapNhapTinhTrangBan"
        _ParameterInput = {New SqlParameter("@SoBan", _SelectedTable.Name.Last), New SqlParameter("@TinhTrang", _TinhTrang)}
        _Connection.Query(_Query1, _ParameterInput)
    End Sub
    Private Function GetMenuList(ByVal _TinhTrang As Integer) As DataTable
        Dim _Query As String = "spMonAnDoUongSelect"
        Dim _Parameter As New SqlClient.SqlParameter("@TinhTrang", _TinhTrang)
        Return _Connection.Query(_Query, _Parameter)
    End Function
    Private Sub Processed()
        While (True)
            If (Me.IsAccessible) Then
                Thread.Sleep(0)
                Dim _Text As String = _ServerObject.GetHolder()
                Dim _Length As Integer = _Data.Length
                Dim _ReceiveData As String = _Text.Substring(_Length)
                ''Handles event here.
                If (_ReceiveData <> "" And _ReceiveData.Length > 2) Then

                    'If (_ReceiveData.Substring(0, 2) = "1+") Then
                    '    CheckWaitorToCashier(_ReceiveData)
                    'End If

                    If (_ReceiveData.Substring(0, 2) = "4+") Then
                        CheckChefBartenderToWaitor(_ReceiveData.Substring(2))
                    End If

                    If (_ReceiveData.Substring(0, 2) = "5+") Then
                        CheckChefBartenderToWaitorConfirm(_ReceiveData.Substring(2))
                    End If

                    'If (_ReceiveData.Substring(0, 2) = "6+") Then
                    '    CheckChefBartenderToWarehouse(_ReceiveData)
                    'End If

                End If
                ''
                _Data = _Text
                '' For manager only
                _Logging += DateTime.Now.ToString() + _ReceiveData
                ''
            Else
                Exit While
            End If
        End While
    End Sub
    Private Sub CheckChefBartenderToWaitorConfirm(ByVal _MaChuyen As String)
        For Each _Row As DataRow In dgvList.Rows
            If (_Row(5).ToString = _MaChuyen) Then
                If (_Row(4).ToString = "Chưa làm") Then
                    _ServerObject.AddData("3+" + _MaChuyen + "1")
                    Exit Sub
                End If
            End If
        Next
        _ServerObject.AddData("3+" + _MaChuyen + "0")
    End Sub

    Private Sub CheckChefBartenderToWaitor(ByVal _MaMon As String)
        Dim _Result As Boolean = False
        Dim _Order As String = ""
        Dim _Index As Integer
        If (_MaMon.Last = "2") Then
            LoadMenu()
        End If
        For i As Integer = 0 To dgvList.RowCount - 1 Step 1
            If (dgvList.Item(5, i).Value.ToString = _MaMon) Then
                _Result = True
                _Order = dgvList.Item(1, i).Value.ToString + dgvList.Item(3, i).Value.ToString
                _Index = i
                Exit For
            End If
        Next
        If (_Result = True) Then
            If (_MaMon.Last = "1") Then
                dgvList.Item(4, _Index).Value = "Hoàn thành"
                MessageBox.Show("Món ăn " + _Order + " đã hoàn thành.", "Thông báo")
            Else
                MessageBox.Show("Món ăn " + _Order + " không thể làm.", "Thông báo")
            End If
        End If
    End Sub
    ''=============================================== THIS SECTION FOR CHEF/BARTENDER==========================================================
    Private Sub CheckWaitorToChefBartender(ByVal _Data As String)
        Dim Data() As String = SplitData(_Data, 2)
        ''TODO your code from here
    End Sub
    Private Sub CheckWaitorToChefBartenderConfirm(ByVal _Data As String)
        Dim Data() As String = SplitData(_Data, 3)
        ''TODO your code from here
    End Sub
    Private Sub CheckWarehouseToChefBartenderConfirm(ByVal _MaChuyen As String)
        Dim Data() As String = SplitData(_Data, 7)
        ''TODO your code from here
    End Sub
    ''Service listener for Chef. (Unique)
    Private Sub Process()
        Dim _Timer = New Timers.Timer
        _Timer.Start()
        While (True)
            If (Me.IsAccessible) Then
                Thread.Sleep(0)
                Dim _Length As Integer = _Data.Length
                Dim _Text As String = _ServerObject.GetHolder()
                Dim _ReceiveData As String = _Text.Substring(_Length)
                If (_ReceiveData <> "" And _ReceiveData.Length > 2) Then
                    CheckWaitorToChefBartender(_Text.Substring(_Length))
                    CheckWaitorToChefBartenderConfirm(_Text.Substring(_Length))
                    CheckWarehouseToChefBartenderConfirm(_Text.Substring(_Length))
                End If
                If (_Timer.Interval >= 60000) Then
                    Thread.Sleep(2000)
                    _Timer.Interval = 0
                    _Timer.Start()
                End If
                _Data = _Text
            Else
                Exit While
            End If
        End While
    End Sub
    Private Function SplitData(ByVal _ReceiveData As String, ByVal _Code As String) As String()
        Dim _ReceiveArray() As String = {}
        Dim j As Integer = 0
        _ReceiveArray = _ReceiveData.Split("-")
        For i As Integer = 0 To _ReceiveArray.Count - 2 Step 1
            Dim _Item As String = _ReceiveArray(i)
            If (_Item.Substring(0, 2) = _Code + "+") Then
                _ReceiveArray(j) = _Item.Substring(2)
                j += 1
            End If
        Next
        Return _ReceiveArray
    End Function
    ''' <summary>
    ''' Hiển thị bàn phím số bên cạnh chức năng chọn số lượng khách.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub nudGuestCount_Enter(sender As Object, e As EventArgs) Handles nudGuestCount.Enter
        _frmNumpad.Show()
        _frmNumpad.BringToFront()
    End Sub

    Private Sub nudGuestCount_Leave(sender As Object, e As EventArgs) Handles nudGuestCount.Leave
        _frmNumpad.Hide()
    End Sub

    Private Sub NhanVien_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _frmNumpad.Close()
    End Sub

    Private Sub nudGuestCount_Click(sender As Object, e As EventArgs) Handles nudGuestCount.Click
        nudGuestCount_Enter(sender, e)
    End Sub

    Private Sub btn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDelete.MouseDown, btnLamMon.MouseDown, btnPay.MouseDown, btnUpdateTable.MouseDown
        Dim _Button As Button = CType(sender, Button)
        _Button.ForeColor = Color.Red
        _Button.BackColor = Color.Blue
    End Sub
    Private Sub btn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDelete.MouseUp, btnLamMon.MouseUp, btnPay.MouseUp, btnUpdateTable.MouseUp
        Dim _Button As Button = CType(sender, Button)
        _Button.ForeColor = Color.White
        _Button.BackColor = Color.Orange
    End Sub

    ''===================================================================================================================================

    Private Sub CheckWaitorToCashierSignal(ByVal _MaMon As String)
        Dim _DataArray() As String = SplitData(_MaMon, 1)
        For Each _String As String In _DataArray
            Dim _MaDau As String = _String.Split("_")(0)
            Dim _MaCuoi As String = _String.Split("_")(1)
            Dim _SoLuongKhach As String = _String.Split("_")(2)
            Dim _MaNhanVien As String = _String.Split("_")(3)
        Next
        ''TODO your code here
        ''
    End Sub

    'Private Sub CheckChefBartenderToWarehouseSignal(ByVal _MaMon As String)
    '    
    '    ''TODO your code here
    'End Sub
    '
    ''For Manager logging all service. Only add to Manager
    'Private Sub NhanVien_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Dim file As IO.StreamWriter
    '    Dim _LogData As String = ""
    '    Dim _Data() As String = {}
    '    _Data = _Logging.Split("-")
    '    For i As ULong = 0 To _Data.Count - 2 Step 1
    '        Select Case (_Data(i).Substring(0, 2))
    '            Case "1+"
    '                _LogData += "NhanVien => ThuNgan " + _Data(i).Substring(2) + vbCrLf
    '            Case "2+"
    '                _LogData += "NhanVien => Bep/PhaChe " + _Data(i).Substring(2) + vbCrLf
    '            Case "3+"
    '                _LogData += "QuanLy => NhanVien " + _Data(i).Substring(2) + vbCrLf
    '            Case "4+"
    '                _LogData += "Bep/PhaChe => NhanVien " + _Data(i).Substring(2) + vbCrLf
    '            Case "5+"
    '                _LogData += "Bep/PhaChe => ThuKho" + _Data(i).Substring(2) + vbCrLf
    '            Case "6+"
    '                _LogData += "ThuKho => Bep/PhaChe " + _Data(i).Substring(2) + vbCrLf
    '        End Select
    '    Next
    '    file = My.Computer.FileSystem.OpenTextFileWriter("Path", True)
    '    file.Write(_LogData)
    '    file.Close()
    'End Sub
End Class