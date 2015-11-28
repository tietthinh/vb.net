Public Class DatabaseConnection
    Private _Connecter As New SqlClient.SqlConnection()
    Private Shared _Address As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Environment.CurrentDirectory + "\QuanLyQuanAn.mdf;Integrated Security=True"

    Public Property Connecter() As SqlClient.SqlConnection
        Get
            Return _Connecter
        End Get
        Set(value As SqlClient.SqlConnection)
            _Connecter = value
        End Set
    End Property

    Public Sub New()
        _Connecter.ConnectionString = _Address
    End Sub

    Public Function Open() As Boolean
        Try
            _Connecter.Open()
        Catch
            Return False
        End Try
        Return True
    End Function
    Public Function Close() As Boolean
        Try
            _Connecter.Close()
        Catch
            Return False
        End Try
        Return True
    End Function
    Public Function Query(Optional _query = "Select * From Account") As DataTable
        Dim temp As New DataTable()
        Dim cmd As New SqlClient.SqlCommand(_query, Connecter)
        Dim adt As New SqlClient.SqlDataAdapter(cmd)
        adt.Fill(temp)
        cmd.Dispose()
        cmd = Nothing
        adt.Dispose()
        adt = Nothing
        Return temp
    End Function
    Public Sub Update(ByVal table As DataTable, ByVal tableName As String)
        Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        cmd.Connection = Me.Connecter
        cmd.CommandText = "Select * From " + tableName
        Dim adt As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
        adt.SelectCommand = cmd
        Dim builder As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(adt)
        adt.Update(table)
        Me.Close()
    End Sub

    Public Function CheckInfor(ByVal userName As String, ByVal pass As String, ByVal confirmPass As String, _
                               ByVal dateTime As DateTime) As Integer
        Dim temp As New DataTable()
        Me.Open()
        temp = Me.Query()
        For Each row As DataRow In temp.Rows
            If (userName = row("Username")) Then
                Return 1
            End If
        Next
        If (confirmPass <> pass) Then
            Return 2
        End If
        If (dateTime > Now) Then
            Return 3
        End If
        Return -1
    End Function
End Class
