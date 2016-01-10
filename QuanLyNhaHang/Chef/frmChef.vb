'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library
<<<<<<< HEAD
Imports System.Data.SqlClient
Imports ServerHost
Imports System
Imports System.Threading
Imports Remote
Imports System.Runtime.Remoting.Channels.Http
Imports System.Runtime.Remoting.Channels.ChannelServices
Imports System.Configuration
Imports System.Runtime.Remoting

Public Class frmChef
    'Fields:
    ''' <summary>
    ''' Form Numpad.
    ''' </summary>
    ''' <remarks></remarks>
    Dim frmNumpad As frmNumPad

    ''' <summary>
    ''' Form Confirm.
    ''' </summary>
    ''' <remarks></remarks>
    Dim frmConfirm As frmConfirm

    ''' <summary>
    ''' DataTable contains data from Order Table in database.
    ''' </summary>
    ''' <remarks></remarks>
=======
Imports Remote
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.ChannelServices
Imports System.Threading
Public Class frmChef
    Private _ServerObject As ServerObject
    Private _Username As String
    Private _Thread As Thread
    Private _Data As String = ""
    Private _Logging As String = ""
    Dim db As New DatabaseConnection()
>>>>>>> TietThinh-NhanVien
    Dim orderList As DataTable

    ''' <summary>
    ''' DataTable contains data for DataGridView CookList.
    ''' </summary>
    ''' <remarks></remarks>
    Dim cookList As New DataTable()

    ''' <summary>
    ''' DataTable contains data for DataGridView CantServeList.
    ''' </summary>
    ''' <remarks></remarks>
    Dim cantServeList As New DataTable()

    ''' <summary>
    ''' DataTable contains data from Material Table in database.
    ''' </summary>
    ''' <remarks></remarks>
    Dim materialList As New DataTable()
<<<<<<< HEAD

    ''' <summary>
    ''' DataTable contains data for insert into Used Material Table in database.
    ''' </summary>
    ''' <remarks></remarks>
    Dim currentUsedMaterial As New DataTable()

    ''' <summary>
    ''' DataTable contains all cancelled dishes.
    ''' </summary>
    ''' <remarks></remarks>
    Dim cancelledDishList As New DataTable()

    ''' <summary>
    ''' DataTable contains all done dishes.
    ''' </summary>
    ''' <remarks></remarks>
    Dim doneDishList As New DataTable()

    ''' <summary>
    ''' Element is used to query from Material Table in database.
    ''' </summary>
    ''' <remarks></remarks>
    Dim currentDish As String

    ''' <summary>
    ''' Element is used to insert into Used Material Table in database.
    ''' </summary>
    ''' <remarks></remarks>
    Dim currentTotalQuantity As Integer

    ''' <summary>
    ''' Element is used to save the current row for DataGridView Material List's events.
    ''' </summary>
    ''' <remarks></remarks>
    Dim currentMaterialRow As Integer

    ''' <summary>
    ''' Current index of selected element in DataGridView Order List.
    ''' </summary>
    ''' <remarks></remarks>
    Dim currentOrderRowIndex As Integer

    Public Shared doneQuantity As Integer

    ''' <summary>
    ''' List of DataGridViewRow has exception.
    ''' </summary>
    ''' <remarks></remarks>
    Dim exceptionList As New List(Of DataGridViewRow)

    ''' <summary>
    ''' List of DishDetail for transfering to Waitor.
    ''' </summary>
    ''' <remarks></remarks>
    Dim dishOrderList As New List(Of DishDetail)

    Private _Thread As Thread

    Private _ServerObject As New ServerObject()

    Private Sub ChefListener(ByVal Inteval As Integer, ByVal SleepTime As Integer)
        Dim _Timer = New Timers.Timer
        _Timer.Start()
        While (True)
            If (Me.IsDisposed = False) Then
                Thread.Sleep(0)
                Try
                    Me.Invoke(New MethodInvoker(Sub()
                                                    Dim _ReceiveData As String = GetData()
                                                    If (_ReceiveData <> "" And _ReceiveData.Length > 2) Then
                                                        CheckWaitorToChefBartender(_ReceiveData)
                                                        CheckWaitorToChefBartenderConfirm(_ReceiveData)
                                                        CheckWarehouseToChefBartenderConfirm(_ReceiveData)
                                                    End If
                                                    If (_Timer.Interval >= Inteval) Then
                                                        MessageBox.Show("Timeout")
                                                        Thread.Sleep(SleepTime)
                                                        _Timer.Interval = Inteval
                                                        _Timer.Start()
                                                    End If
                                                End Sub
                                ))
                Catch e As Exception
                    Exit While
                End Try
            Else
                Exit While
            End If
        End While
    End Sub
=======
    Dim currentDish As String
    Dim currentIndex As Integer
    Dim exceptionList As New List(Of Integer)
>>>>>>> TietThinh-NhanVien

    'Events:
    '
    'Form's Events
    '
    'Load: Occur when the form first load.
    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD

        Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(New String() {"@MaChuyen"}, New Object() {"01-0001"})

=======
        ''*****Service Area********
        Try
            ''Initiate connection
            Dim _Channel As New Http.HttpChannel
            RegisterChannel(_Channel)
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
        ''*****Service Area********
        Dim parameter As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Time", SqlDbType.Char, 20)
        parameter.Value = "12:09:00"
>>>>>>> TietThinh-NhanVien
        Try
            orderList = db.Query("spDSDatMonTrongNgaySelect", parameter)
        Catch ex As Exception
            Throw ex
        End Try
<<<<<<< HEAD

        BindIntoOrderedDataGridView(dgvOrderList, orderList)

        'Creates columns for cookList
        cookList.Columns.Add(New DataColumn("MaMon"))
        cookList.Columns.Add(New DataColumn("TenMon"))
        cookList.Columns.Add(New DataColumn("SoLuong"))

        'Creates columns for currentUsedMaterial
        currentUsedMaterial.Columns.Add("MaSP")
        currentUsedMaterial.Columns.Add("SoLuong")
        currentUsedMaterial.Columns.Add("SoLuongMotMon")

        'Clones cantServeList from cookList
        cantServeList = cookList.Clone()

        'Creates columns for cancelledDishList
        cancelledDishList.Columns.Add(New DataColumn("MaMon"))
        cancelledDishList.Columns.Add(New DataColumn("SoLuong"))

        'Creates columns for doneDishList
        doneDishList.Columns.Add(New DataColumn("MaMon"))
        doneDishList.Columns.Add(New DataColumn("SoLuong"))

        AddHandler lblMaterialQuantity.TextChanged, AddressOf lblMaterialQuantity_TextChanged

        Try
            StartService(New ThreadStart(Sub() ChefListener(30000, 2000)))
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
=======
        Dim index As Integer = 1
        For Each row As DataRow In orderList.Rows
            Dim item As New ListViewItem(index)
            item.SubItems.Add(row("MaChuyen"))
            item.SubItems.Add(row("MaMon"))
            item.SubItems.Add(row("TenMon"))
            item.SubItems.Add(row("ThoiGian").ToString())
            item.SubItems.Add(row("SoLuong"))
            item.SubItems.Add(row("GhiChu").ToString())
            item.SubItems(0).Name = "STT"
            item.SubItems(1).Name = "MaChuyen"
            item.SubItems(2).Name = "MaMon"
            item.SubItems(3).Name = "TenMon"
            item.SubItems(4).Name = "ThoiGian"
            item.SubItems(5).Name = "SoLuong"
            item.SubItems(6).Name = "GhiChu"
            ltvOrderList.Items.Add(item)
            index += 1
        Next

        ltvOrderList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
        ltvOrderList.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)
        ltvOrderList.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent)
        ltvOrderList.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize)

        cookList.Columns.Add(New DataColumn(orderList.Columns("MaChuyen").ColumnName, orderList.Columns("MaChuyen").DataType))
        cookList.Columns.Add(New DataColumn(orderList.Columns("TenMon").ColumnName, orderList.Columns("TenMon").DataType))
        cookList.Columns.Add(New DataColumn(orderList.Columns("SoLuong").ColumnName, orderList.Columns("SoLuong").DataType))

        cantServeList = orderList.Clone()

    End Sub

    Private Sub ltvOrderList_Click(sender As Object, e As EventArgs) Handles ltvOrderList.Click
        For i As Integer = 0 To exceptionList.Count - 1 Step 1
            ltvOrderList.Items(exceptionList(i)).BackColor = SystemColors.Window
            exceptionList.RemoveAt(i)
        Next
        Dim quantity As Integer = 0
        If ltvOrderList.SelectedItems.Count > 0 Then
            currentDish = ltvOrderList.SelectedItems(0).SubItems("MaMon").Text
            For Each item As ListViewItem In ltvOrderList.Items
                If item.SubItems("MaMon").Text = currentDish Then
                    quantity += item.SubItems("SoLuong").Text
                    If item.SubItems("GhiChu").Text <> "" Then
                        item.BackColor = Color.Red
                        exceptionList.Add(item.Index)
                    Else
                        item.Selected = True
                    End If
                End If
            Next
            exceptionList.Reverse()
            txtTotalQuantity.Text = quantity.ToString()
        End If
>>>>>>> TietThinh-NhanVien
    End Sub
    '
    'FormClosing: Occur while the form is closing.
    Private Sub frmChef_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Bạn có muốn đóng chương trình không?", "", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
            Exit Sub
        End If

<<<<<<< HEAD
        Me.IsAccessible = False

        GetCancelledDish(cancelledDishList, cantServeList)
        db.Update("spDanhSachMonAnKhongHoanThanhInsert", db.CreateParameter(New String() {"@DS"}, New Object() {cancelledDishList}))

        GroupDish(doneDishList)
        db.Update("spDanhSachMonAnHoanThanhInsert", db.CreateParameter(New String() {"@DS"}, New Object() {doneDishList}))

=======
    Private Sub ltvOrderList_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCook_Click(sender As Object, e As EventArgs) Handles btnCook.Click
        If ltvOrderList.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In ltvOrderList.SelectedItems
                Dim row As DataRow = cookList.NewRow
                row("MaChuyen") = item.SubItems("MaChuyen").Text
                row("TenMon") = item.SubItems("TenMon").Text
                row("SoLuong") = item.SubItems("SoLuong").Text
                cookList.Rows.Add(row)
            Next
            dgvCookList.DataSource = cookList
            For i As Integer = ltvOrderList.SelectedItems.Count - 1 To 0 Step -1
                orderList.Rows(ltvOrderList.SelectedItems(i).Index).Delete()
                ltvOrderList.SelectedItems(i).Remove()
            Next
            txtTotalQuantity.Text = ""
        End If
    End Sub

    Private Sub frmChef_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
>>>>>>> TietThinh-NhanVien
        db.Dispose()

        orderList.Dispose()
        orderList = Nothing

        cookList.Dispose()
        cookList = Nothing

        cantServeList.Dispose()
        cantServeList = Nothing

        materialList.Dispose()
        materialList = Nothing

        currentDish = ""
        currentDish = Nothing
<<<<<<< HEAD
=======
        currentIndex = Nothing
    End Sub
>>>>>>> TietThinh-NhanVien

        cancelledDishList.Dispose()
        cancelledDishList = Nothing

<<<<<<< HEAD
        doneDishList.Dispose()
        doneDishList = Nothing

        If frmConfirm IsNot Nothing Then
            frmConfirm.Dispose()
            frmConfirm = Nothing
        End If

        If frmNumpad IsNot Nothing Then
            frmNumpad.Dispose()
            frmNumpad = Nothing
=======
        If TypeOf column Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim parameter(1) As SqlClient.SqlParameter
            parameter(0) = New SqlClient.SqlParameter("@MaChuyen", SqlDbType.Char, 10)
            parameter(0).Value = dgv.Rows(e.RowIndex).Cells("CookListTransID").Value
            parameter(1) = New SqlClient.SqlParameter("@TinhTrang", SqlDbType.Int, 2)
            parameter(1).Value = 3
            db.Query("spDSDatMonTrongNgayUpdateTinhTrang", parameter)
            dgv.Rows.RemoveAt(e.RowIndex)
>>>>>>> TietThinh-NhanVien
        End If

        exceptionList.Clear()
        exceptionList = Nothing

        dishOrderList.Clear()
        dishOrderList = Nothing

        currentUsedMaterial.Dispose()
        currentUsedMaterial = Nothing

        currentTotalQuantity = Nothing
    End Sub
    '
    'dgvOrderList's Events:
    '
    'Click: Occur when click a row in dgvOrderList.
    Private Sub dgvOrderList_Click(sender As Object, e As EventArgs) Handles dgvOrderList.Click
        ltbException.Items.Clear()
<<<<<<< HEAD

        currentTotalQuantity = 0

        If dgvOrderList.SelectedRows.Count > 0 Then
            currentOrderRowIndex = dgvOrderList.CurrentRow.Index

            'Adds the exception of dish into listbox Exception
            ltbException.Items.Add(dgvOrderList.SelectedRows(0).Cells("OrderNote").Value)

            'Sets current quantity by the dish's quantity
            currentTotalQuantity = Integer.Parse(dgvOrderList.SelectedRows(0).Cells("OrderQuantity").Value)

            'Loads list material from database through Dish's Identity
            materialList = LoadMaterial(dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value)
            dgvMaterialList.DataSource = materialList

            currentUsedMaterial.Rows.Clear()
            'Clones data from materialList with a column total quantity
            currentUsedMaterial = AddTotalQuantity(materialList, GetAllColumnsName(currentUsedMaterial), currentTotalQuantity)

            txtTotalQuantity.Text = currentTotalQuantity
=======
        ltvOrderList.SelectedItems.Clear()
        currentIndex = ltvOrderList.InsertionMark.NearestIndex(New Point(e.X, e.Y))
        ltvOrderList.Items(currentIndex).Selected = True
        If ltvOrderList.SelectedItems.Count > 0 Then
            ltbException.Items.Add(ltvOrderList.SelectedItems(0).SubItems("GhiChu").Text)
>>>>>>> TietThinh-NhanVien
        End If
    End Sub
    '
    'DoubleClick: Occur when double click a row in dgvOrderList
    Private Sub dgvOrderList_DoubleClick(sender As Object, e As EventArgs) Handles dgvOrderList.DoubleClick
        ClearListViewItemBackColor(exceptionList, dgvOrderList)

        If dgvOrderList.SelectedRows.Count > 0 Then
            Dim quantity As Integer = 0
            Dim exceptionRow As Integer = 0, nonExceptionRow As Integer = 0

            'Sets current dish by the current selected dishes' identity
            currentDish = dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value

            'Selects the similar dishes with current dish
            For Each row As DataGridViewRow In dgvOrderList.Rows
                If row.Cells("OrderDishID").Value = currentDish Then
                    quantity += row.Cells("OrderQuantity").Value

                    'If current row has note/exception then sets background color by red
                    'and adds into exceptionList
                    'else selects it
                    If row.Cells("OrderNote").Value.ToString() <> "" Then
                        row.DefaultCellStyle.BackColor = Color.Red

                        exceptionRow += 1

                        exceptionList.Add(row)
                    Else
                        row.Selected = True

                        nonExceptionRow += 1
                    End If
                End If
            Next

            'If nonExceptionRow is 0 and exceptionRow greater than 0, means there are only dishes have exception, then
            'selects the dishes has similar note with the current dish
            If nonExceptionRow = 0 And exceptionRow <> 0 Then
                For i As Integer = 0 To exceptionList.Count - 1 Step 1
                    If exceptionList(i).Cells("OrderDishID").Value = currentDish AndAlso _
                        exceptionList(i).Cells("OrderNote").Value = _
                        dgvOrderList.Rows(currentOrderRowIndex).Cells("OrderNote").Value Then

                        exceptionList(i).Selected = True
                    End If
                Next
            End If

            'Loads material for current dish
            materialList = LoadMaterial(currentDish)
            dgvMaterialList.DataSource = materialList

<<<<<<< HEAD
            txtTotalQuantity.Text = quantity
        End If
    End Sub
    '
    'SelectedIndexChanged: Occur when change selected row in dgvOrderList.
    Private Sub dgvOrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvOrderList.SelectionChanged
        'If there are no selected rows then clears all background color, list exception and material
        If dgvOrderList.SelectedRows.Count <= 0 Then
            ClearListViewItemBackColor(exceptionList, dgvOrderList)

=======
    Private Sub ltvOrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvOrderList.SelectedIndexChanged
        If ltvOrderList.SelectedItems.Count <= 0 Then
            For i As Integer = 0 To exceptionList.Count - 1 Step 1
                ltvOrderList.Items(exceptionList(i)).BackColor = SystemColors.Window
                exceptionList.RemoveAt(i)
            Next
>>>>>>> TietThinh-NhanVien
            ltbException.Items.Clear()
        End If
    End Sub
<<<<<<< HEAD
    '
    'MouseClick: Occur when use mouse to click inside dgvOrderList.
    Private Sub dgvOrderList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvOrderList.MouseClick
        Dim currentIndex As Integer = dgvOrderList.HitTest(e.X, e.Y).RowIndex

        'If there are no selected rows in point then clears all current selected rows
        If currentIndex < 0 Then
            dgvOrderList.ClearSelection()

            txtTotalQuantity.Text = ""
        End If
    End Sub
    '
    'btnCook's Events:
    '
    'Click: Occur when click the button.
    Private Sub btnCook_Click(sender As Object, e As EventArgs) Handles btnCook.Click
        If dgvOrderList.SelectedRows.Count > 0 Then
            currentTotalQuantity = 0

            Dim _DishDetail As New DishDetail()
            'Creates new dish detail with the selected dish
            _DishDetail.DishID = dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value

            For Each row As DataGridViewRow In dgvOrderList.SelectedRows
                'Creates new row from cookList
                Dim dRow As DataRow = cookList.NewRow()

                'Clones data from row into dRow
                dRow("MaMon") = row.Cells("OrderDishID").Value
                dRow("TenMon") = row.Cells("OrderDishName").Value
                dRow("SoLuong") = row.Cells("OrderQuantity").Value

                'Adds new order into dish detail
                _DishDetail.Add(row.Cells("OrderTransID").Value, row.Cells("OrderQuantity").Value)

                'Adds dRow into cookList
                cookList.Rows.Add(dRow)

                'Increases current total quantity by quantity in dRow
                currentTotalQuantity += dRow("SoLuong")
            Next

            Dim dishDetail As DishDetail = GetFirstDetailByID(dishOrderList, dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value)

            If dishDetail IsNot Nothing Then
                'Adds all detail into dishDetail (an element in dishOrderList)
                For i As Integer = 0 To _DishDetail.TransDetail.Length - 1 Step 1
                    Array.Resize(dishDetail.TransDetail, dishDetail.TransDetail.Length + 1)

                    dishDetail.TransDetail(dishDetail.TransDetail.Length - 1).Add(_DishDetail.TransDetail(i).TransID, _DishDetail.TransDetail(i).Quantity)
                Next
            Else
                'Adds dish detail into List of order
                dishOrderList.Add(_DishDetail)
            End If

            currentUsedMaterial.Rows.Clear()
            'Adds list material with column total quantity into currentUsedMaterial
            currentUsedMaterial = AddTotalQuantity(materialList, GetAllColumnsName(currentUsedMaterial), currentTotalQuantity)

            Try
                db.Update("spSanPhamDaDungInsert", db.CreateParameter(New String() {"@DS"}, New Object() {currentUsedMaterial}))
            Catch ex As SqlException When ex.Number = 50001
                'Gets the number cannot serve
                Dim cantServeQuantity As Integer = Integer.Parse(ex.Message)

                'Gets dishes cannot serve
                Dim _TempCantServeList As DataTable = GetCantServeList(cookList, cantServeQuantity)

                'Adds those dishes into cantServeList
                AppendDataTable(cantServeList, _TempCantServeList)

                'Groups all dishes
                GroupDish(cantServeList)
                dgvCantServeList.DataSource = cantServeList

                'Gets the dish detail by id in dishOrderList
                dishDetail = GetFirstDetailByID(dishOrderList, dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value)

                'If exists the dish detail then subtracts and removes the dishes cannot serve
                If dishDetail IsNot Nothing Then
                    dishDetail.SubtractCantServe(cantServeQuantity)

                    If dishDetail.TransDetail.Length = 0 Then
                        dishOrderList.Remove(dishDetail)
                    End If
                End If
            Catch ex As SqlException
                Throw ex
            End Try

            'Groups all data in cookList
            GroupDish(cookList)
            dgvCookList.DataSource = cookList

            'Removes all selected rows in DataGridView OrderList
            For Each row As DataGridViewRow In dgvOrderList.SelectedRows
                orderList.Rows.RemoveAt(row.Index)
            Next

            txtTotalQuantity.Text = ""
        End If
    End Sub
    '
    'dgvCookList's Events:
    '
    'CellClick: Occur when click a cell in dgvCookList.
    Private Sub dgvCookList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCookList.CellClick
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim column As DataGridViewColumn = dgv.Columns(e.ColumnIndex)

        If TypeOf column Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult

            'Creates new form Confirm
            frmConfirm = New frmConfirm(dgv.Rows(e.RowIndex).Cells("CookListQuantity").Value, dgv.Rows(e.RowIndex).Cells("CookListDishName").Value)

            result = frmConfirm.ShowDialog()

            If result = System.Windows.Forms.DialogResult.OK Then
                'Gets the dish detail by id in dishOrderList
                Dim dishDetail As DishDetail = GetFirstDetailByID(dishOrderList, dgv.Rows(e.RowIndex).Cells("CookListDishID").Value)
                'Gets the dishes are done
                Dim transDetail() As TransferDetail = dishDetail.Subtract(doneQuantity)

                If transDetail IsNot Nothing Then
                    Dim listTransID(transDetail.Length - 1) As String

                    'Clones transfer's identity into listTransID
                    For i As Integer = 0 To transDetail.Length - 1 Step 1
                        listTransID(i) = transDetail(i).TransID
                    Next

                    'Update records in database
                    For i As Integer = 0 To listTransID.Length - 1 Step 1
                        Dim parameterName() As String = New String() {"@MaChuyen", "@TinhTrang"}
                        Dim parameterValue() As Object = New Object() {listTransID(i), 3}
                        Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(parameterName, parameterValue)

                        Try
                            db.Update("spDSDatMonTrongNgayUpdateTinhTrang", parameter)
                        Catch ex As SqlException
                            MessageBox.Show(ex.ToString())
                        End Try

                        Array.Resize(parameterName, 0)
                        Array.Resize(parameterValue, 0)
                        Array.Resize(parameter, 0)
                    Next

                    'Decreases the quantity of the current row
                    dgv.Rows(e.RowIndex).Cells("CookListQuantity").Value -= frmChef.doneQuantity

                    'Adds the done dishes into doneDishList
                    Dim dRow As DataRow = doneDishList.NewRow()

                    dRow("MaMon") = dgv.Rows(e.RowIndex).Cells("CookListDishID").Value
                    dRow("SoLuong") = frmChef.doneQuantity

                    doneDishList.Rows.Add(dRow)

                    'If the quantity of current row is 0 then removes it
                    If dgv.Rows(e.RowIndex).Cells("CookListQuantity").Value = 0 Then
                        dgv.Rows.RemoveAt(e.RowIndex)
                    End If
                End If
            End If
        End If
    End Sub
    '
    'dgvMaterialList's Events:
    '
    'CellClick: Occur when click a cell in dgvMaterialList.
    Private Sub dgvMaterialList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaterialList.CellClick
        If e.ColumnIndex >= 0 Then
            Dim dgv As DataGridView = DirectCast(sender, DataGridView)
            Dim column As DataGridViewColumn = dgv.Columns(e.ColumnIndex)

            If TypeOf column Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                If column.Name = "Increase" Then
                    'If click the button + then increases the quantity by default increase
                    dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value += dgv.Rows(e.RowIndex).Cells("DefaultIncrease").Value
                Else
                    'Else decreases the quantity by default increase
                    Dim i As Double = dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value - dgv.Rows(e.RowIndex).Cells("DefaultIncrease").Value

                    If i >= 0 Then
                        dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value = i
                    Else
                        dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value = 0
                    End If
                End If

            ElseIf TypeOf column Is DataGridViewTextBoxColumn AndAlso e.RowIndex >= 0 And column.Name = "MaterialQuantity" Then
                currentMaterialRow = e.RowIndex

                'If current row is material's quantity then show the form numpad
                frmNumpad = New frmNumPad(lblMaterialQuantity, dgv.Rows(e.RowIndex).Cells("IsDouble").Value)
                frmNumpad.Location = New Point(dgv.Location.X - frmNumpad.Width, dgv.Location.Y)
                frmNumpad.Show()
            End If
        End If
    End Sub
    '
    'SelectionChanged: Occur when select other cell in dgvMaterialList.
    Private Sub dgvMaterialList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMaterialList.SelectionChanged
        'If frmNumpad is showing then close and dispose it
        If frmNumpad IsNot Nothing Then
            frmNumpad.Focus()

            If frmNumpad.ContainsFocus = True Then
                frmNumpad.Close()
                frmNumpad.Dispose()
                frmNumpad = Nothing
            End If
        End If
    End Sub
    '
    'lblMaterialQuantity's Events:
    '
    'TextChanged: Occur when the text of lblMaterialQuantity changes value.
    Private Sub lblMaterialQuantity_TextChanged(sender As Object, e As EventArgs)
        Try
            Double.Parse(lblMaterialQuantity.Text)
            dgvMaterialList.Rows(currentMaterialRow).Cells("MaterialQuantity").Value = lblMaterialQuantity.Text
        Catch ex As FormatException
            lblMaterialQuantity.Text = lblMaterialQuantity.Text.Remove(lblMaterialQuantity.Text.Length - 1, 1)
        Catch ex As Exception
            dgvMaterialList.Rows(currentMaterialRow).Cells("MaterialQuantity").Value = Math.Round(Double.Parse(lblMaterialQuantity.Text))
        End Try
=======

    Private Sub btnSendWaitor_Click(sender As Object, e As EventArgs) Handles btnSendWaitor.Click
        _ServerObject.AddData("3_01-0005")
    End Sub
    Private Sub Process()
        While (True)
            Thread.Sleep(0)
            Dim _Text As String = _ServerObject.GetHolder()
            _Logging = _Text
            Dim _Length As Integer = _Data.Length
            Dim _ReceiveData As String = _Text.Substring(_Length)
            ''Handles event here.
            If (_ReceiveData <> "") Then
                ''Handle your data here
                MessageBox.Show(_ReceiveData)
                ''
            End If
            _Data = _Text
        End While
    End Sub
    Private Sub InitializeRemoteServer()
        RemotingConfiguration.RegisterWellKnownClientType(GetType(ServerObject), "http://192.168.145.1:12345/TransferData")
>>>>>>> TietThinh-NhanVien
    End Sub
End Class