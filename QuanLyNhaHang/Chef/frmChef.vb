'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library

Public Class frmChef

    Dim db As New DatabaseConnection()
    Dim orderList As DataTable
    Dim cookList As DataTable
    Dim cantServeList As DataTable
    Dim materialList As DataTable
    Dim currentDish As String

    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parameter As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ThoiGian", SqlDbType.Time, 10, "TimeOrder")
        parameter.Value = "12:25:31.4409220"
        Try
            db.Open()
            orderList = db.Query("Select DSDMTN.MaChuyen, DSDMTN.MaMon, DSDMTN.ThoiGian, DSDMTN.SoLuong, DSDMTN.GhiChu, MADU.TenMon From DanhSachDatMonTrongNgay DSDMTN, MonAnDoUong MADU Where DSDMTN.MaMon = MADU.MaMon")
        Catch ex As Exception
            Throw ex
        Finally
            db.Close()
        End Try
        Dim index As Integer = 1
        For Each row As DataRow In orderList.Rows
            Dim item As New ListViewItem(index)
            item.SubItems.Add(row(0))
            item.SubItems.Add(row(1))
            item.SubItems.Add(row("TenMon"))
            item.SubItems.Add(row(2).ToString())
            item.SubItems.Add(row(3))
            item.SubItems.Add(row(4).ToString())
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
        Dim index = ltvOrderList.SelectedItems(0).Index
        ltvOrderList.SelectedItems.Clear()
        ltvOrderList.Items(index).Selected = True
        If ltvOrderList.SelectedItems.Count > 0 Then
            ltbException.Items.Add(ltvOrderList.SelectedItems(0).SubItems("GhiChu").Text)
        End If
    End Sub
End Class