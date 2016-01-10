'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library
Imports System.Data.SqlClient
Imports ServerHost
Imports System
Imports System.Threading
Imports Remote
Imports System.Runtime.Remoting.Channels.Http
Imports System.Runtime.Remoting.Channels.ChannelServices
Imports System.Configuration
Imports System.Runtime.Remoting
Imports Remote.Service_Process

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
                                                        MessageBox.Show("Fuck")
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

    'Events:
    '
    'Form's Events
    '
    'Load: Occur when the form first load.
    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(New String() {"@MaChuyen"}, New Object() {"01-0001"})

        Try
            orderList = db.Query("spDSDatMonTrongNgaySelect", parameter)
        Catch ex As SqlException
            Throw ex
        End Try

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
    End Sub
    '
    'FormClosing: Occur while the form is closing.
    Private Sub frmChef_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Bạn có muốn đóng chương trình không?", "", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
            Exit Sub
        End If

        Me.IsAccessible = False

        GetCancelledDish(cancelledDishList, cantServeList)
        db.Update("spDanhSachMonAnKhongHoanThanhInsert", db.CreateParameter(New String() {"@DS"}, New Object() {cancelledDishList}))

        GroupDish(doneDishList)
        db.Update("spDanhSachMonAnHoanThanhInsert", db.CreateParameter(New String() {"@DS"}, New Object() {doneDishList}))

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

        cancelledDishList.Dispose()
        cancelledDishList = Nothing

        doneDishList.Dispose()
        doneDishList = Nothing

        If frmConfirm IsNot Nothing Then
            frmConfirm.Dispose()
            frmConfirm = Nothing
        End If

        If frmNumpad IsNot Nothing Then
            frmNumpad.Dispose()
            frmNumpad = Nothing
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

            txtTotalQuantity.Text = quantity
        End If
    End Sub
    '
    'SelectedIndexChanged: Occur when change selected row in dgvOrderList.
    Private Sub dgvOrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvOrderList.SelectionChanged
        'If there are no selected rows then clears all background color, list exception and material
        If dgvOrderList.SelectedRows.Count <= 0 Then
            ClearListViewItemBackColor(exceptionList, dgvOrderList)

            ltbException.Items.Clear()
            materialList.Rows.Clear()

            dgvMaterialList.DataSource = materialList
        End If
    End Sub
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
    End Sub
End Class