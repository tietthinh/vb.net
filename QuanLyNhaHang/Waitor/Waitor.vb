Imports System.Data.SqlClient
Imports Library
Imports Remote
Imports System.Threading

Public Class Waitor
    Private _frmNumpad As frmNumPad
    Private _Connection As New DatabaseConnection
    Private _IsSelected As Boolean = False
    Private _PictureBoxEffect As PictureBox
    Private _SelectedTable As PictureBox
    Private _PreviousTable As New PictureBox
    Private _ServerObject As ServerObject
    Private _Thread As Thread
    Private _Data As String = ""
    Private _Logging As String = ""
    Private _CurrentUser As User = Nothing
    Private _ParameterInput() As SqlParameter
    Private _ParameterOutput() As SqlParameter
    Private _ListTable As New List(Of Table)
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub picTable01_Click(sender As Object, e As EventArgs) Handles picTable01.Click, picTable02.Click, picTable03.Click, picTable04.Click,
        picTable05.Click, picTable06.Click, picTable07.Click, picTable08.Click, picTable09.Click
        _SelectedTable = CType(sender, PictureBox)
        Dim _Index As Integer = 0
        SaveTable(_PreviousTable, _Index, _ListTable)
        LoadTable(_SelectedTable, _Index, _ListTable)
        Dim a As Integer = MessageBox.Show("Vui lòng kiểm tra số bàn!" + vbCrLf + "Bạn đang chọn bàn số " + _SelectedTable.Name.Last, "Xác Nhận", MessageBoxButtons.OKCancel)
        If (a = 1) Then
            _PreviousTable.BackColor = Color.White
            Dim _Number As String = "BÀN " + _SelectedTable.Name.Last
            _PictureBoxEffect = _SelectedTable
            _PreviousTable = _SelectedTable
            _PictureBoxEffect.BackColor = Color.RoyalBlue
            lblTittle.Text = "DANH SÁCH MÓN ĂN " + _Number
            lstMenu.Enabled = True
            _IsSelected = True
            AppProvider._IsCommitted = False
            UpdateTableStatus(1, _SelectedTable)
            LoadMenu()
        End If
    End Sub
    ''' <summary>
    ''' Check if clicked table is existed then return position of table in the array
    ''' </summary>
    ''' <param name="_table"></param>
    ''' <returns></returns>

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
        Dim _Login As New frmLogin()
        _Login.ShowDialog()
        _CurrentUser = DatabaseConnection._User
        If (_Login.DialogResult = 1) Then
            StartService(New ThreadStart(Sub() Listener()))
            Me.Text = "Nhân Viên " + _CurrentUser.EmployeeName.ToString
            LoadMenu()
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

            ''Send Chef/Bartender signal.
            Dim _Query2 As String = "spDemMonDaDat"
            Dim dataTable As DataTable = Nothing
            dataTable = _Connection.Query(_Query2)

            Dim _SoLuongMon As Integer = Integer.Parse(_Connection.Query(_Query2).Rows(0).Item(0).ToString)
            If (_SoLuongMon = 0) Then
                SendData("2+" + dgvList.Item(5, 0).Value + "*")
            End If
        Else
            MessageBox.Show("Danh sách món ăn trống!", "Thông báo")
        End If
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If (AppProvider._IsCommitted = True And _IsSelected = True) Then
            ''Commit the list to Cashier
            SendData("1+" + dgvList.Item(5, 0).Value.ToString.Trim + "_" + dgvList.Item(5, dgvList.RowCount - 1).Value.ToString.Trim + "_" + _CurrentUser.Identity.ToString.Trim + "_" + nudGuestCount.Value.ToString.Trim + "*")
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
    ''' <summary>
    ''' Hiển thị bàn phím số bên cạnh chức năng chọn số lượng khách.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub nudGuestCount_Enter(sender As Object, e As EventArgs) Handles nudGuestCount.Enter
        _frmNumpad = New frmNumPad(nudGuestCount)
        _frmNumpad.StartPosition = FormStartPosition.Manual
        _frmNumpad.Location = New Point(940, 380)
        _frmNumpad.Show()
        _frmNumpad.BringToFront()
    End Sub

    Private Sub nudGuestCount_Leave(sender As Object, e As EventArgs) Handles nudGuestCount.Leave
        _frmNumpad.Close()
    End Sub

    Private Sub Waitor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (_frmNumpad IsNot Nothing) Then
            _frmNumpad.Close()
        End If
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
    Private Sub btnUpdateTable_Click(sender As Object, e As EventArgs) Handles btnUpdateTable.Click
        If (_IsSelected = True) Then
            '' Update to Database
            UpdateTableStatus(0, _SelectedTable)
            ''
            _IsSelected = False
            lstMenu.Enabled = False
            MessageBox.Show("Thiết lập thành công!", "Thông báo", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Bàn chưa được chọn!", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Listener()
        While (True)
            Thread.Sleep(0)
            If (Me.IsAccessible = True) Then
                Me.Invoke(New MethodInvoker(Sub()
                                                Dim _ReceiveData As String = GetData()
                                                ''Handles event here.
                                                If (_ReceiveData <> "" And _ReceiveData.Length > 2) Then
                                                    CheckChefBartenderToWaitor(_ReceiveData.Substring(2))
                                                    CheckChefBartenderToWaitorConfirm(_ReceiveData.Substring(2))
                                                End If
                                                ''
                                            End Sub
                ))
            Else
                Exit While
            End If
        End While
    End Sub
End Class