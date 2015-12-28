'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library
Imports System.Data.SqlClient

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

        cookList.Columns.Add(New DataColumn("MaMon"))
        cookList.Columns.Add(New DataColumn("TenMon"))
        cookList.Columns.Add(New DataColumn("SoLuong"))

        currentUsedMaterial.Columns.Add("MaSP")
        currentUsedMaterial.Columns.Add("SoLuong")
        currentUsedMaterial.Columns.Add("SoLuongMotMon")

        cantServeList = orderList.Clone()
    End Sub
    '
    'FormClosing: Occur while the form is closing.
    Private Sub frmChef_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            ltbException.Items.Add(dgvOrderList.SelectedRows(0).Cells("OrderNote").Value)

            currentTotalQuantity = Integer.Parse(dgvOrderList.SelectedRows(0).Cells("OrderQuantity").Value)

            materialList = LoadMaterial(dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value)
            dgvMaterialList.DataSource = materialList

            currentUsedMaterial.Rows.Clear()
            currentUsedMaterial = AddTotalQuantity(materialList, GetAllColumnsName(currentUsedMaterial), currentTotalQuantity)
        End If
    End Sub
    '
    'DoubleClick: Occur when double click a row in dgvOrderList
    Private Sub dgvOrderList_DoubleClick(sender As Object, e As EventArgs) Handles dgvOrderList.DoubleClick
        ClearListViewItemBackColor(exceptionList, dgvOrderList)

        Dim quantity As Integer = 0
        Dim exceptionRow As Integer = 0, nonExeptionRow As Integer = 0

        If dgvOrderList.SelectedRows.Count > 0 Then
            currentDish = dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value

            dgvOrderList.ClearSelection()

            For Each row As DataGridViewRow In dgvOrderList.Rows
                If row.Cells("OrderDishID").Value = currentDish Then
                    quantity += row.Cells("OrderQuantity").Value

                    If row.Cells("OrderNote").Value.ToString() <> "" Then
                        row.DefaultCellStyle.BackColor = Color.Red

                        exceptionRow += 1

                        exceptionList.Add(row)
                    Else
                        row.Selected = True

                        nonExeptionRow += 1
                    End If
                End If
            Next

            If nonExeptionRow = 0 And exceptionRow <> 0 Then
                exceptionList(0).Selected = True

                For i As Integer = 1 To exceptionList.Count - 1 Step 1
                    If exceptionList(i).Cells("OrderDishID").Value = currentDish And _
                        exceptionList(i).Cells("OrderNote").Value = exceptionList(0).Cells("OrderNote").Value Then

                        exceptionList(i).Selected = True
                    End If
                Next

                ltbException.Items.Add(exceptionList(0).Cells("OrderNote").Value)
            End If

            materialList = LoadMaterial(currentDish)
            dgvMaterialList.DataSource = materialList

            txtTotalQuantity.Text = quantity.ToString()
        End If
    End Sub
    '
    'SelectedIndexChanged: Occur when change selected row in dgvOrderList.
    Private Sub dgvOrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvOrderList.SelectionChanged
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

        If currentIndex < 0 Then
            dgvOrderList.ClearSelection()
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
            _DishDetail.DishID = dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value

            For Each row As DataGridViewRow In dgvOrderList.SelectedRows
                Dim dRow As DataRow = cookList.NewRow()

                dRow("MaMon") = row.Cells("OrderDishID").Value
                dRow("TenMon") = row.Cells("OrderDishName").Value
                dRow("SoLuong") = row.Cells("OrderQuantity").Value

                _DishDetail.Add(row.Cells("OrderTransID").Value, row.Cells("OrderQuantity").Value)

                cookList.Rows.Add(dRow)

                currentTotalQuantity += dRow("SoLuong")
            Next

            dishOrderList.Add(_DishDetail)

            currentUsedMaterial.Rows.Clear()
            currentUsedMaterial = AddTotalQuantity(materialList, GetAllColumnsName(currentUsedMaterial), currentTotalQuantity)

            Try
                db.Update("spSanPhamDaDungInsert", db.CreateParameter(New String() {"@DS"}, New Object() {currentUsedMaterial}))
            Catch ex As SqlException When ex.Number = 50001
                Dim cantServeQuantity As Integer = Integer.Parse(ex.Message)
                cantServeList = GetCantServeList(cookList, cantServeQuantity)

                GroupDish(cantServeList)
                dgvCantServeList.DataSource = cantServeList

                Dim dishDetail As DishDetail = GetFirstDetailByID(dishOrderList, dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value)
                If dishDetail IsNot Nothing Then
                    dishDetail.SubtractCantServe(cantServeQuantity)

                    If dishDetail.TransDetail.Length = 0 Then
                        dishOrderList.Remove(dishDetail)
                    End If
                End If
            Catch ex As SqlException
                Throw ex
            End Try

            GroupDish(cookList)
            dgvCookList.DataSource = cookList

            For Each row As DataGridViewRow In dgvOrderList.SelectedRows
                orderList.Rows(row.Index).Delete()
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

            frmConfirm = New frmConfirm(dgv.Rows(e.RowIndex).Cells("CookListQuantity").Value)

            result = frmConfirm.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                Dim dishDetail As DishDetail = GetFirstDetailByID(dishOrderList, dgv.Rows(e.RowIndex).Cells("CookListDishID").Value)
                Dim transDetail() As TransferDetail = dishDetail.Subtract(doneQuantity)
                If transDetail IsNot Nothing Then
                    Dim listTransID(transDetail.Length - 1) As String

                    For i As Integer = 0 To transDetail.Length - 1 Step 1
                        listTransID(i) = transDetail(i).TransID
                    Next

                    For i As Integer = 0 To listTransID.Length - 1 Step 1
                        Dim parameterName() As String = New String() {"@MaChuyen", "@TinhTrang"}
                        Dim parameterValue() As Object = New Object() {listTransID(i), 3}
                        Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(parameterName, parameterValue)

                        db.Update("spDSDatMonTrongNgayUpdateTinhTrang", parameter)

                        Array.Resize(parameterName, 0)
                        Array.Resize(parameterValue, 0)
                        Array.Resize(parameter, 0)
                    Next

                    dgv.Rows(e.RowIndex).Cells("CookListQuantity").Value -= frmChef.doneQuantity
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
                    dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value += dgv.Rows(e.RowIndex).Cells("DefaultIncrease").Value
                Else
                    Dim i As Double = dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value - dgv.Rows(e.RowIndex).Cells("DefaultIncrease").Value
                    If i >= 0 Then
                        dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value = i
                    Else
                        dgv.Rows(e.RowIndex).Cells("MaterialQuantity").Value = 0
                    End If
                End If

            ElseIf TypeOf column Is DataGridViewTextBoxColumn AndAlso e.RowIndex >= 0 And column.Name = "MaterialQuantity" Then
                currentMaterialRow = e.RowIndex

                AddHandler lblMaterialQuantity.TextChanged, AddressOf lblMaterialQuantity_TextChanged

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