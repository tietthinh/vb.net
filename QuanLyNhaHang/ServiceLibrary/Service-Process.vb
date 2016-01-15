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
    Private _ConnectStatus As Boolean = False
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
        ''Initiate connection
        Try
            Dim _Channel As New HttpChannel
            RegisterChannel(_Channel, True)
            InitializeRemoteServer()
            _ServerObject = New ServerObject
            _Thread = New Thread(_ThreadStart)
            _Thread.Start()
            _ConnectStatus = True
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại!", "Lỗi")
        End Try
    End Sub
    ''' <summary>
    ''' Lấy dữ liệu nhận được từ Remote Service.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetData() As String
        Dim _ReceiveData As String = ""
        Dim _Text As String = _ServerObject.GetHolder()
        Dim _Length As Integer = _Data.Length
        _ReceiveData = _Text.Substring(_Length)
        _Data = _Text
        Return _ReceiveData
    End Function
    ''' <summary>
    ''' Gửi dữ liệu lên Remote Service
    ''' </summary>
    ''' <param name="Data"></param>
    Public Sub SendData(ByVal Data As String)
        _ServerObject.AddData(Data)
        '' For manager only
        _Logging += DateTime.Now.ToString() + " $" + Data + "^"
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
    ''' <summary>
    ''' Ghi lại dữ liệu đã gửi/nhận
    ''' </summary>
    Public Sub Logging()
        Dim file As IO.StreamWriter
        Dim _LogData As String = ""
        Dim _Data() As String = Nothing
        _Data = _Logging.Split("^")
        If (_Data.Length > 2) Then
            For i As ULong = 0 To _Data.Length - 2 Step 1
                Select Case (_Data(i).Split("$")(1).Substring(0, 2))
                    Case "1+"
                        _LogData += "Waitor => ThuNgan " + _Data(i).Substring(2)
                        _LogData = _LogData.Replace("$1+", " ")
                    Case "2+"
                        _LogData += "Waitor => Bep/PhaChe " + _Data(i).Substring(2)
                        _LogData = _LogData.Replace("$2+", " ")
                    Case "3+"
                        _LogData += "QuanLy => Waitor " + _Data(i).Substring(2)
                        _LogData = _LogData.Replace("$3+", " ")
                    Case "4+"
                        _LogData += "Bep/PhaChe => Waitor " + _Data(i).Substring(2)
                        _LogData = _LogData.Replace("$4+", " ")
                    Case "5+"
                        _LogData += "Bep/PhaChe => ThuKho" + _Data(i).Substring(2)
                        _LogData = _LogData.Replace("$5+", " ")
                    Case "6+"
                        _LogData += "ThuKho => Bep/PhaChe " + _Data(i).Substring(2)
                        _LogData = _LogData.Replace("$6+", " ")
                End Select
            Next
        End If
        _LogData = _LogData.Replace("*", vbCrLf)
        file = My.Computer.FileSystem.OpenTextFileWriter("Path", True)
        file.Write(_LogData)
        file.Close()
    End Sub
End Module
