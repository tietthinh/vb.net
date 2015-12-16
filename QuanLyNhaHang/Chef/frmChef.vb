'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library

Public Class frmChef

    Dim db As New DatabaseConnection()
    Dim orderList As DataTable
    Dim cookList As New DataTable()
    Dim cantServeList As New DataTable()
    Dim materialList As New DataTable()
    Dim currentDish As String
    Dim currentIndex As Integer

    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parameter As SqlClient.SqlParameter = New SqlClient.SqlParameter("@Time", SqlDbType.Char, 20)
        parameter.Value = "12:09:00"
        Try
            db.Open()
            orderList = db.Query("spDSDatMonTrongNgaySelect", parameter)
        Catch ex As Exception
            Throw ex
        Finally
            db.Close()
        End Try
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
        Dim quantity As Integer = 0
        If ltvOrderList.SelectedItems.Count > 0 Then
            currentDish = ltvOrderList.SelectedItems(0).SubItems("MaMon").Text
            For Each item As ListViewItem In ltvOrderList.Items
                If item.SubItems("MaMon").Text = currentDish Then
                    quantity += item.SubItems("SoLuong").Text
                    If item.SubItems("GhiChu").Text <> "" Then
                        item.BackColor = Color.Red
                    Else
                        item.Selected = True
                    End If
                End If
            Next
            txtTotalQuantity.Text = quantity.ToString()
        End If
    End Sub

    Private Sub ltvOrderList_DoubleClick(sender As Object, e As EventArgs) Handles ltvOrderList.DoubleClick
        ltbException.Items.Clear()
        ltvOrderList.SelectedItems.Clear()
        currentIndex = ltvOrderList.InsertionMark.NearestIndex(New Point(MousePosition.X, MousePosition.Y - 55))
        ltvOrderList.Items(currentIndex).Selected = True
        If ltvOrderList.SelectedItems.Count > 0 Then
            ltbException.Items.Add(ltvOrderList.SelectedItems(0).SubItems("GhiChu").Text)
        End If
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
    End Sub

    Private Sub dgvCookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCookList.CellContentClick
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim column As DataGridViewColumn = dgv.Columns(e.ColumnIndex)

        If TypeOf column Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim parameter(1) As SqlClient.SqlParameter
            parameter(0) = New SqlClient.SqlParameter("@MaChuyen", SqlDbType.Char, 10)
            parameter(0).Value = dgv.Rows(e.RowIndex).Cells("CookListTransID").Value
            parameter(1) = New SqlClient.SqlParameter("@TinhTrang", SqlDbType.Int, 2)
            parameter(1).Value = 3
            MessageBox.Show(dgv.Rows(e.RowIndex).Cells("CookListTransID").Value)
            db.Query("spDSDatMonTrongNgayUpdateTinhTrang", parameter)
            dgv.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
End Class