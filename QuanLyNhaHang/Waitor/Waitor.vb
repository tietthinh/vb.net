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

    Private _Connection As New DatabaseConnection
    Private _IsSelected As Boolean = False
    Private _IsCommitted As Boolean = False
    Private _PictureBoxEffect As PictureBox
    Private _SelectedTable As PictureBox
    Private _ServerObject As ServerObject
    Private _Thread As Thread
    Private _Data As String = ""
    Private _Logging As String = ""
    Private _CurrentUser As User
    Public _ActiveTable As New Table
    'Show content
    'Hiển thị nội dung
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
            If (a > 0) Then
                Dim _Number As String = "BÀN " + _SelectedTable.Name.Last
                _PictureBoxEffect = _SelectedTable
                _IsSelected = True
                _PictureBoxEffect.BackColor = Color.RoyalBlue
                lblTittle.Text = "DANH SÁCH MÓN ĂN " + _Number
                lstMenu.Enabled = True
                _IsCommitted = False
                LoadMenu()
            End If
        End If
    End Sub
    Private Sub listMenu_Click(sender As Object, e As EventArgs) Handles lstMenu.Click
        AppProvider._IsUpdate = False
        Dim Add As New Add(_ActiveTable)
        Add.ShowDialog()
    End Sub

    Private Sub dtgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellContentClick
        AppProvider._IsUpdate = True
        Dim add As New Add(_ActiveTable)
        add.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Login As New frmLogin(_CurrentUser)
        _Login.ShowDialog()
        If (_Login.DialogResult = 1) Then
            ''**********************Service Initiate**********************
            Try
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
                MessageBox.Show("Connection to server failed", "Error Connection")
                Me.Close()
            End Try
            ''**********************Service Initiate**********************
            ''
            LoadMenu()
            MyBase.Show()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub btnLamMon_Click(sender As Object, e As EventArgs) Handles btnLamMon.Click
        ''Commit the list to Chef
        If (dgvList.Rows.Count <> 0) Then
            Dim index As Integer = 0
            MessageBox.Show("Gửi danh sách thành công!", "Thông báo", MessageBoxButtons.OK)
            Dim _Row As DataGridViewRow
            Dim _Query1 As String = "spDSDatMonTrongNgayInsert"
            Dim _ParameterInput() As SqlParameter
            Dim _ParameterOutput() As SqlParameter
            ''Insert
            For Each _Row In dgvList.Rows
                Dim _MaMon As String = lstMenu.Items(index).SubItems(1).Text
                Dim _SoLuong As Integer = dgvList.Item(2, index).Value
                Dim _TinhTrang As Integer = 1
                Dim _GhiChu As String = dgvList.Item(3, index).Value
                Dim _SoBan As Integer = Integer.Parse(_SelectedTable.Name.Last())
                ''Preparing for fixing update order list procedure.
                Dim _Code As String = dgvList.Item(5, index).Value
                ''
                _ParameterOutput = {New SqlParameter("@MaMoi", SqlDbType.Char, 10)}
                _ParameterInput = {New SqlParameter("@MaMon", _MaMon), New SqlParameter("@SoLuong", _SoLuong), New SqlParameter("@TinhTrang", _TinhTrang), New SqlParameter("@GhiChu", _GhiChu), New SqlParameter("@SoBan", _SoBan)}
                _Connection.Query(_Query1, _ParameterOutput, _ParameterInput)
                Dim _MaChuyen As String = _ParameterOutput(0).SqlValue.ToString
                dgvList.Item(5, index).Value = _MaChuyen
                index += 1
            Next
            _IsCommitted = True
        Else
            MessageBox.Show("Danh sách món ăn trống!", "Thông báo")
        End If
        Dim _Query2 As String = "spDemMonDaDat"
        Dim _SoLuongMon As Integer = Integer.Parse(_Connection.Query(_Query2).Rows(0).Item(0).ToString)
        For i As Integer = 0 To dgvList.Rows.Count - 1 Step 1
            If (dgvList.Item(4, i).Value = 1) Then
                _ServerObject.AddData(dgvList.Item(5, i).Value)
                Exit For
            End If
        Next
        If (_SoLuongMon = 0) Then
            _ServerObject.AddData("2+")
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If (_IsCommitted = True And _IsSelected = True) Then
            ''Commit the list to Cashier
            Dim _MaDau As String = dgvList.Item(5, 0).Value.ToString
            Dim _MaCuoi As String = dgvList.Item(5, dgvList.RowCount - 1).Value.ToString

            _ServerObject.AddData("1+" + _MaDau + "_" + _MaCuoi + +_CurrentUser.Identity + nudGuestCount.Value)
            ''
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
                If (a > 0) Then
                    If (_IsCommitted = True) Then
                        ''Update status on database
                        Dim _Code As String = dgvList.SelectedRows.Item(0).Cells(5).Value
                        Dim _Query As String = "spDSDatMonTrongNgayUpdateTinhTrang"
                        Dim _ParameterInput() As SqlParameter = {New SqlParameter("@MaChuyen", _Code), New SqlParameter("@TinhTrang", 4)}
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
            ' Await for stored procedure.
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
            _Connection.Open()
            Dim _Row As DataRow = Nothing
            Dim _Id As String = Nothing
            Dim _IdTemp() As String = Nothing
            ''Stored Procedure
            Dim _Query As String = "spMonAnDoUongSelect"
            Dim _DataTable As DataTable = Nothing
            Dim index As Integer = 0
            Dim _Parameter As New SqlClient.SqlParameter("@TinhTrang", 1)
            _DataTable = _Connection.Query(_Query, _Parameter)
            For Each _Row In _DataTable.Rows
                lstMenu.Items.Add(_Row(1).ToString())
                lstMenu.Items(index).SubItems.Add(_Row(0).ToString())
                If (_Row(0).ToString().Substring(0, 2) = "DA") Then
                    ''Set image
                    lstMenu.Items(index).ImageIndex = 0
                Else
                    ''Set image
                    lstMenu.Items(index).ImageIndex = 1
                End If
                index = index + 1
            Next
            _Parameter = New SqlClient.SqlParameter("@TinhTrang", 0)
            _Data = Nothing
            index = 0
            _DataTable = _Connection.Query(_Query, _Parameter)
            For Each _Row In _DataTable.Rows
                lstNotAvailable.Items.Add(_Row(1).ToString())
            Next
            _Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

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
                    '    CheckWaitorToCashierSignal(_ReceiveData.Substring(2))
                    'End If

                    'If (_ReceiveData.Substring(0, 2) = "2+") Then
                    '    CheckWaitorToChefSignal(_ReceiveData.Substring(2))
                    'End If

                    'If (_ReceiveData.Substring(0, 2) = "3+") Then
                    '    CheckWaitorToChefBartenderConfirmSignal(_ReceiveData)
                    'End If

                    'If (_ReceiveData.Substring(0, 2) = "4+") Then
                    '    CheckChefBartenderToWaitorSignal(_ReceiveData.Substring(2))
                    'End If

                    'If (_ReceiveData.Substring(0, 2) = "5+") Then
                    '    CheckChefBartenderToWaitorConfirmSignal(_ReceiveData)
                    'End If

                    'If (_ReceiveData.Substring(0, 2) = "6+") Then
                    '    CheckChefBartenderToWarehouseSignal(_ReceiveData)
                    'End If

                    'If (_ReceiveData.Substring(0, 2) = "7+1") Then
                    '    CheckWarehouseToChefBartenderSignal(_ReceiveData)
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

    Private Sub CheckWaitorToChefBartenderConfirmSignal(ByVal _MaChuyen As String)
        For Each _Row As DataRow In dgvList.Rows
            If (_Row(5).ToString = _MaChuyen) Then
                If (_Row(4).ToString = "Chưa làm") Then
                    _ServerObject.AddData("3+" + _MaChuyen + "1")
                    Exit For
                Else
                    _ServerObject.AddData("3+" + _MaChuyen + "0")
                    Exit For
                End If
            End If
        Next
    End Sub
    Private Sub CheckChefBartenderToWaitorSignal(ByVal _MaMon As String)
        Dim _Result As Boolean = False
        Dim _Order As String = ""
        If (_MaMon.Last = "2") Then
            LoadMenu()
        End If
        For i As Integer = 0 To dgvList.RowCount - 1 Step 1
            If (dgvList.Item(5, i).Value.ToString = _MaMon) Then
                _Result = True
                _Order = dgvList.Item(1, i).Value.ToString + dgvList.Item(3, i).Value.ToString
                Exit For
            End If
        Next
        If (_Result = True) Then
            If (_MaMon.Last = "1") Then
                MessageBox.Show("Món ăn " + _Order + " đã hoàn thành.", "Thông báo")
            Else
                MessageBox.Show("Món ăn " + _Order + " không thể làm.", "Thông báo")
            End If
        End If
    End Sub
    ''
    'Private Sub CheckWaitorToCashierSignal(ByVal _MaMon As String)
    '    Dim _MaDau As String = _MaMon.Split("_")(0)
    '    Dim _MaCuoi As String = _MaMon.Split("_")(1)
    '    Dim _SoLuongKhach As String = _MaMon.Split("_")(2)
    '    Dim _MaNhanVien As String = _MaMon.Split("_")(3)
    '    ''TODO your code here
    '    ''
    'End Sub
    Private Sub CheckWaitorToChefSignal(ByVal _MaMon() As String)

    End Sub
    'Private Sub CheckManagerToWaitorSignal(ByVal _MaMon As String)
    '    ''Call store procedure
    '    ''
    'End Sub
    'Private Sub CheckChefBartenderToWarehouseSignal(ByVal _MaMon As String)
    '    ''TODO your code here
    'End Sub
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

    ''Service listener for Chef. (Unique)
    Private Sub Process()
        While (True)
            If (Me.IsAccessible) Then
                Thread.Sleep(0)
                Dim _Length As Integer = _Data.Length
                Dim _ReceiveArray() As String = {}
                Dim _Timer = New Timers.Timer(2000)
                Dim j As Integer = 0
                Dim _Text As String = _ServerObject.GetHolder()
                _ReceiveArray = _Text.Substring(_Length).Split("-")
                If (_ReceiveArray(0) <> "" And _Text.Substring(_Length).Length > 2) Then
                    For i As Integer = 0 To _ReceiveArray.Count - 2 Step 1
                        Dim _Item As String = _ReceiveArray(i)
                        If (_Item.Substring(0, 2) = "2+") Then
                            _ReceiveArray(j) = _Item.Substring(2)
                            j += 1
                        End If
                    Next
                    ''TODO Your code here
                    CheckWaitorToChefSignal(_ReceiveArray)
                    ''
                    If (_Timer.Interval >= 60000) Then
                        Thread.Sleep(2000)
                    End If
                End If
                _Data = _Text
            Else
                Exit While
            End If
        End While
    End Sub
End Class