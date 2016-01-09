Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Channels.Http
Imports System.Runtime.Remoting.Channels.ChannelServices
Imports System.Threading
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Net

Public Module Service_Process
    Private _ServerObject As ServerObject
    Private _Thread As Thread
    Private _Data As String = ""
    Private _Logging As String = ""
    ''' <summary>
    ''' Kết nối đến tên miền. Thiêt lập tên miền trong App.config.
    ''' </summary>
    Private Sub InitializeRemoteServer()
        Dim _Channel As String = "http://" + ConfigurationManager.AppSettings.Get("IP").ToString + ":" + ConfigurationManager.AppSettings.Get("Port").ToString + "/" + ConfigurationManager.AppSettings.Get("Domain").ToString
        RemotingConfiguration.RegisterWellKnownClientType(GetType(ServerObject), _Channel)
    End Sub
    ''' <summary>
    ''' Kết nối Remote Service, bắt đầu lắng nghe dữ liệu
    ''' </summary>
    ''' <param name="_ThreadStart">Hàm lắng nghe cú pháp "(New ThreadStart(Sub() [Hàm_lắng_nghe]()))"</param>
    Public Sub StartService(_ThreadStart As ThreadStart)
        Try
            ''Initiate connection
            Dim _Channel As New HttpChannel
            RegisterChannel(_Channel, True)
            InitializeRemoteServer()
            ''Start thread listening
            _ServerObject = New ServerObject()
            _Thread = New Thread(_ThreadStart)
            _Thread.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Kết nối thất bại!", "Lỗi")
        End Try
    End Sub
    ''' <summary>
    ''' Lấy dữ liệu nhận được từ Remote Service.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetData() As String
        Dim _Text As String = _ServerObject.GetHolder()
        Dim _Length As Integer = _Data.Length
        Dim _ReceiveData As String = _Text.Substring(_Length)
        _Data = _Text
        '' For manager only
        _Logging += DateTime.Now.ToString() + _ReceiveData
        Return _ReceiveData
    End Function
    ''' <summary>
    ''' Gửi dữ liệu lên Remote Service
    ''' </summary>
    ''' <param name="Data"></param>
    Public Sub SendData(ByVal Data As String)
        _ServerObject.AddData(Data)
    End Sub
    ''' <summary>
    ''' Lọc dữ liệu cho từng loại 
    ''' </summary>
    ''' <param name="_ReceiveData">Dữ liệu cần xử lý.</param>
    ''' <param name="_Code">Mã tách.</param>
    ''' <returns></returns>
    Public Function DataFilter(ByVal _ReceiveData As String, ByVal _Code As String) As List(Of String)
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

    'Service listener for Chef. (Unique)
    'Private Sub ChefListener(ByVal Inteval As Integer, ByVal SleepTime As Integer)
    '    Dim _Timer = New Timers.Timer
    '    _Timer.Start()
    '    While (True)
    '        Thread.Sleep(0)
    '        If (Me.IsAccessible = True) Then
    '            Me.Invoke(New MethodInvoker(Sub()

    '                                            Dim _ReceiveData As String = GetData()
    '                                            If (_ReceiveData <> "" And _ReceiveData.Length > 2) Then
    '                                                CheckWaitorToChefBartender(_ReceiveData)
    '                                                CheckWaitorToChefBartenderConfirm(_ReceiveData)
    '                                                CheckWarehouseToChefBartenderConfirm(_ReceiveData)
    '                                            End If
    '                                            If (_Timer.Interval >= Inteval) Then
    '                                                Thread.Sleep(SleepTime)
    '                                                _Timer.Interval = 0
    '                                                _Timer.Start()
    '                                            End If
    '                                        End Sub
    '                        ))
    '        Else
    '            Exit While
    '        End If
    '    End While
    'End Sub



    'For Manager logging all service. Only add to Manager
    'Private Sub Waitor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Dim file As IO.StreamWriter
    '    Dim _LogData As String = ""
    '    Dim _Data() As String = {}
    '    _Data = _Logging.Split("-")
    '    For i As ULong = 0 To _Data.Count - 2 Step 1
    '        Select Case (_Data(i).Substring(0, 2))
    '            Case "1+"
    '                _LogData += "Waitor => ThuNgan " + _Data(i).Substring(2) + vbCrLf
    '            Case "2+"
    '                _LogData += "Waitor => Bep/PhaChe " + _Data(i).Substring(2) + vbCrLf
    '            Case "3+"
    '                _LogData += "QuanLy => Waitor " + _Data(i).Substring(2) + vbCrLf
    '            Case "4+"
    '                _LogData += "Bep/PhaChe => Waitor " + _Data(i).Substring(2) + vbCrLf
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



    Private Sub CheckWaitorToCashierSignal(ByVal Data As String)
        Dim _DataArray As List(Of String) = DataFilter(Data, 1)
        ''TODO your code here
    End Sub
    Private Sub CheckWaitorToChefBartender(ByVal Data As String)
        Dim _DataArray As List(Of String) = DataFilter(Data, 2)
        ''TODO your code from here
    End Sub
    Private Sub CheckWaitorToChefBartenderConfirm(ByVal Data As String)
        Dim _DataArray As List(Of String) = DataFilter(Data, 3)
        ''TODO your code from here
    End Sub
    Private Sub CheckChefBartenderToWarehouseSignal(ByVal Data As String)
        Dim _DataArray As List(Of String) = DataFilter(Data, 6)
        ''TODO your code here
    End Sub
    Private Sub CheckWarehouseToChefBartenderConfirm(ByVal Data As String)
        Dim _DataArray As List(Of String) = DataFilter(Data, 7)
        ''TODO your code from here
    End Sub

End Module
