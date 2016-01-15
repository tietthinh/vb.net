Imports System.Data.SqlClient
Imports Library
Imports Remote
Imports System.Threading

Public Class frmWaitor
    ''Field
    Private _frmNumpad As frmNumPad
    Private _Connection As New DatabaseConnection
    Private _IsSelected As Boolean = False
    Private _IsPaid As Boolean = False
    Public _SelectedTable As Integer = 0
    Private _PreviousTable As Integer = 0
    Private _Thread As Thread
    Private _Data As String = ""
    Private _Logging As String = ""
    Private _CurrentUser As User = Nothing
    Private _ParameterInput() As SqlParameter
    Private _ParameterOutput() As SqlParameter
    Public _ListTable As New List(Of Table)
    Private _Index As Integer = 0
    ''Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    ''Method
    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As EventArgs) Handles lstTable.MouseClick
        _SelectedTable = Integer.Parse(lstTable.SelectedItems(0).Text().ToString())
        SaveTable(_PreviousTable, _Index, _ListTable)
        Dim a As Integer = MessageBox.Show("Vui lòng kiểm tra số bàn!" + vbCrLf + "Bạn đang chọn bàn số " + _SelectedTable.ToString, "Xác Nhận", MessageBoxButtons.OKCancel)
        If (a = 1) Then
            dgvList.Rows.Clear()
            LoadTable(_SelectedTable, _Index, _ListTable)
            Dim _Number As String = "BÀN " + _SelectedTable.ToString
            _PreviousTable = _SelectedTable
            lstTable.SelectedItems(0).BackColor = Color.RoyalBlue
            lblTittle.Text = "DANH SÁCH MÓN ĂN " + _Number
            lstMenu.Enabled = True
            _IsSelected = True
            UpdateTableStatus(1, _SelectedTable)
            GetMaximumGuest(_SelectedTable)
            LoadMenu()
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
        If (Login(_CurrentUser) = True) Then
            Me.Text = "Nhân Viên " + _CurrentUser.EmployeeName
            LoadMenu()
            LoadAvaiableTable()
            StartService(New ThreadStart(Sub() Listener()))
        Else
            Me.Close()
        End If
    End Sub
    Private Sub btnLamMon_Click(sender As Object, e As EventArgs) Handles btnLamMon.Click
        SaveTable(_SelectedTable, _Index, _ListTable)
        Dim _SoLuongMonAn As Integer = CountOrder("DA")
        Dim _SoLuongThucUong As Integer = CountOrder("DU")
        ''Commit the list to Chef
        If (dgvList.Rows.Count <> 0) Then
            Dim index As Integer = 0
            Dim _Row As DataGridViewRow
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
            Dim _FoodFlag As Boolean = False
            Dim _DrinkFlag As Boolean = False
            For Each _Row In dgvList.Rows
                ''Preparing for fixing update order list procedure.
                Dim _MaChuyen As String = SubmitDataToDataBase(dgvList.Item(6, index).Value, dgvList.Item(2, index).Value, dgvList.Item(3, index).Value, _SelectedTable, dgvList.Item(5, index).Value.ToString.Trim)

                If (_MaChuyen IsNot Nothing) Then
                    dgvList.Item(5, index).Value = _MaChuyen
                End If
                'Send signal to Chef
                If (_SoLuongMonAn <> 0 And dgvList.Item(6, index).Value.ToString.Substring(0, 2) = "DA" And _FoodFlag = False) Then
                    SendData("2+" + dgvList.Item(5, index).Value.ToString.Trim + "*")
                    _FoodFlag = True
                End If
                'Send signal for Bartender
                If (_SoLuongThucUong <> 0 And dgvList.Item(6, index).Value.ToString.Substring(0, 2) = "DU" And _DrinkFlag = False) Then
                    SendData("8+" + dgvList.Item(5, index).Value.ToString.Trim + "*")
                    _DrinkFlag = True
                End If
                index += 1
            Next
            _ListTable(GetTableByNumber(_SelectedTable, _ListTable))._IsCommitted = True
            MessageBox.Show("Gửi danh sách thành công!", "Thông báo", MessageBoxButtons.OK)
            ''Send Chef/Bartender signal.
        Else
            MessageBox.Show("Danh sách món ăn trống!", "Thông báo")
        End If
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If (_ListTable(GetTableByNumber(_SelectedTable, _ListTable))._IsCommitted = True And _IsSelected = True) Then
            ''Commit the list to Cashier
            SendData("1+" + dgvList.Item(5, 0).Value.ToString.Trim + "_" + dgvList.Item(5, dgvList.RowCount - 1).Value.ToString.Trim + "_" + _CurrentUser.Identity + "_" + nudGuestCount.Value.ToString.Trim + "*")
            ''Remove effect & Clear list orders
            dgvList.Rows.Clear()
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK)
            _ListTable(GetTableByNumber(_SelectedTable, _ListTable))._IsPaid = True
            _ListTable(GetTableByNumber(_SelectedTable, _ListTable))._IsCommitted = False
            _ListTable.RemoveAt(GetTableByNumber(_SelectedTable, _ListTable))
        Else
            MessageBox.Show("Danh sách món ăn rỗng!", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub btnUpdateTable_Click(sender As Object, e As EventArgs) Handles btnUpdateTable.Click
        If (_IsPaid = False) Then
            MessageBox.Show("Bàn chưa được thanh toán!", "Thông báo", MessageBoxButtons.OK)
            Exit Sub
        End If
        If (_IsSelected = True) Then
            '' Update to Database
            UpdateTableStatus(0, _SelectedTable)
            ''
            _IsSelected = False
            lstMenu.Enabled = False
            lstTable.SelectedItems(0).BackColor = Color.White
            MessageBox.Show("Thiết lập thành công!", "Thông báo", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Bàn chưa được chọn!", "Thông báo", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (_IsSelected = True And dgvList.Rows.Count > 0) Then
            Try
                Dim a As Integer = MessageBox.Show("Vui lòng kiểm tra số bàn!" + vbCrLf + "Bạn đang chọn bàn số " + _SelectedTable, "Xác Nhận", MessageBoxButtons.OKCancel)
                If (a = 1) Then
                    If (1) Then
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
    Private Sub nudGuestCount_Enter(sender As Object, e As EventArgs)
        _frmNumpad = New frmNumPad(nudGuestCount)
        _frmNumpad.StartPosition = FormStartPosition.Manual
        _frmNumpad.Location = New Point(940, 380)
        _frmNumpad.Show()
        _frmNumpad.BringToFront()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim _cfrmDialog = MessageBox.Show("Vui lòng xác nhận đăng xuất hệ thống", "Thông báo", MessageBoxButtons.OKCancel)
        If (_cfrmDialog = DialogResult.OK) Then
            ''Sign out from system.
            'Clear current user info.
            'Show the Login form.

            '
            'Temporary hide the main form
            Me.Hide()
            '
            ''
            MessageBox.Show("Đăng xuất thành công.", "Thông báo")
        End If
    End Sub
    Private Sub nudGuestCount_Leave(sender As Object, e As EventArgs)
        _frmNumpad.Close()
    End Sub

    Private Sub Waitor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (_frmNumpad IsNot Nothing) Then
            _frmNumpad.Close()
        End If
    End Sub
    Private Sub nudGuestCount_Click(sender As Object, e As EventArgs)
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
    Private Sub Listener()
        Dim _Error As Boolean = False
        While (True)
            If (_Error = False) Then
                Thread.Sleep(0)
            Else
                Dim _Reconnect As New frmReconnect()
                _Reconnect.ShowDialog()
                _Error = False
            End If
            If (Me.IsDisposed = False) Then
                Try
                    Me.Invoke(New MethodInvoker(Sub()
                                                    Dim _ReceiveData As String = GetData()
                                                    ''Handles event here.
                                                    If (_ReceiveData <> "" And _ReceiveData.Length > 2) Then
                                                        LoadAvaiableTable()
                                                        CheckChefBartenderToWaitor(_ReceiveData)
                                                        CheckChefBartenderToWaitorConfirm(_ReceiveData)
                                                    End If
                                                End Sub
            ))
                Catch e As Exception
                    Dim _Result As Integer = MessageBox.Show("Mất kết nối, bạn có muốn tái kết nối không?", "Lỗi", MessageBoxButtons.YesNo)
                    If (_Result = DialogResult.Yes) Then
                        _Error = True
                    Else
                        Exit While
                        Me.Close()
                    End If
                    If (Me.IsDisposed = True) Then
                        Exit While
                    End If
                End Try
            Else
                Exit While
            End If
        End While
    End Sub
End Class