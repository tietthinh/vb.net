'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library
Imports System.Data.SqlClient

Public Class frmChef
    Dim frmNumpad As frmNumPad

    Dim orderList As DataTable
    Dim cookList As New DataTable()
    Dim cantServeList As New DataTable()
    Dim materialList As New DataTable()
    Dim currentUsedMaterial As New DataTable()

    Dim dishOrderList As New List(Of DishDetail)

    Dim currentDish As String

    Dim currentIndex As Integer
    Dim currentTotalQuantity As Integer
    Dim dishTotal As Integer
    Dim currentMaterialRow As Integer

    Dim exceptionList As New List(Of DataGridViewRow)

    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(New String() {"@MaChuyen"}, New Object() {"01-0001"})

        Try
            orderList = db.Query("spDSDatMonTrongNgaySelect", parameter)
        Catch ex As SqlException
            Throw ex
        End Try

        BindIntoOrderedDataGridView(dgvOrderList, orderList)

        cookList.Columns.Add(New DataColumn("TenMon"))
        cookList.Columns.Add(New DataColumn("SoLuong"))

        currentUsedMaterial.Columns.Add("MaSP")
        currentUsedMaterial.Columns.Add("SoLuong")
        currentUsedMaterial.Columns.Add("SoLuongMotMon")

        cantServeList = orderList.Clone()
    End Sub

    Private Sub dgvOrderList_Click(sender As Object, e As EventArgs) Handles dgvOrderList.Click
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
            End If
        End If

        If dgvOrderList.SelectedRows.Count > 0 Then
            materialList = LoadMaterial(currentDish)
            dgvMaterialList.DataSource = materialList

            txtTotalQuantity.Text = quantity.ToString()
        End If
    End Sub

    Private Sub btnCook_Click(sender As Object, e As EventArgs) Handles btnCook.Click
        If dgvOrderList.SelectedRows.Count > 0 Then
            currentTotalQuantity = 0

            Dim _DishDetail As New DishDetail()
            _DishDetail.DishID = dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value

            For Each row As DataGridViewRow In dgvOrderList.SelectedRows
                Dim dRow As DataRow = cookList.NewRow()

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

                dgvCantServeList.DataSource = cantServeList

                Dim dishDetail As DishDetail = GetFirstDetailByID(dishOrderList, dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value)
                If dishDetail IsNot Nothing Then
                    dishDetail.SubtractCantServe(cantServeQuantity)
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

        currentIndex = Nothing

        currentTotalQuantity = Nothing
    End Sub

    Private Sub dgvCookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCookList.CellContentClick
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim column As DataGridViewColumn = dgv.Columns(e.ColumnIndex)

        If TypeOf column Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim parameterName() As String = New String() {"@MaChuyen", "@TinhTrang"}
            Dim parameterValue() As Object = New Object() {dgv.Rows(e.RowIndex).Cells("CookListTransID").Value, 3}
            Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(parameterName, parameterValue)
            db.Update("spDSDatMonTrongNgayUpdateTinhTrang", parameter)
            dgv.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub dgvOrderList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvOrderList.MouseDoubleClick
        ltbException.Items.Clear()
        dgvOrderList.ClearSelection()

        currentTotalQuantity = 0
        currentIndex = dgvOrderList.HitTest(e.X, e.Y).RowIndex

        If currentIndex >= 0 Then
            dgvOrderList.Rows(currentIndex).Selected = True
        End If

        If dgvOrderList.SelectedRows.Count > 0 Then
            ltbException.Items.Add(dgvOrderList.SelectedRows(0).Cells("OrderNote").Value)

            currentTotalQuantity = Integer.Parse(dgvOrderList.SelectedRows(0).Cells("OrderQuantity").Value)

            materialList = LoadMaterial(dgvOrderList.SelectedRows(0).Cells("OrderDishID").Value)
            dgvMaterialList.DataSource = materialList

            currentUsedMaterial.Rows.Clear()
            currentUsedMaterial = AddTotalQuantity(materialList, GetAllColumnsName(currentUsedMaterial), currentTotalQuantity)
        End If
    End Sub

    Private Sub dgvOrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvOrderList.SelectionChanged
        If dgvOrderList.SelectedRows.Count <= 0 Then
            ClearListViewItemBackColor(exceptionList, dgvOrderList)

            ltbException.Items.Clear()
            materialList.Rows.Clear()

            dgvMaterialList.DataSource = materialList
        End If
    End Sub

    Private Sub dgvMaterialList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaterialList.CellClick
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

                frmNumpad = New frmNumPad(lblMaterialQuantity)
                frmNumpad.Show()
            End If
        End If
    End Sub

    Private Sub lblMaterialQuantity_TextChanged(sender As Object, e As EventArgs)
        Try
            dgvMaterialList.Rows(currentMaterialRow).Cells("MaterialQuantity").Value = lblMaterialQuantity.Text
        Catch ex As Exception
            dgvMaterialList.Rows(currentMaterialRow).Cells("MaterialQuantity").Value = Math.Round(Double.Parse(lblMaterialQuantity.Text))
        End Try
    End Sub

    Private Sub dgvOrderList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvOrderList.MouseClick
        Dim currentIndex As Integer = dgvOrderList.HitTest(e.X, e.Y).RowIndex

        If currentIndex < 0 Then
            dgvOrderList.ClearSelection()
        End If
    End Sub
End Class