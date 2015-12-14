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

    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parameter As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ThoiGian", SqlDbType.Time, 10, "TimeOrder")
        parameter.Value = "12:25:31.4409220"
        Try
            db.Open()
            orderList = db.Query("Select DSDMTN.*, MADU.TenMon From DanhSachDatMonTrongNgay DSDMTN, MonAnDoUong MADU Where DSDMTN.MaMon = MADU.MaMon")
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
            item.SubItems.Add(row(4))
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
    End Sub

    Private Sub ltvOrderList_Click(sender As Object, e As EventArgs) Handles ltvOrderList.Click
        Dim quantity As Integer = 0
        If ltvOrderList.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In ltvOrderList.Items
                If item.SubItems("MaMon").Text = ltvOrderList.SelectedItems(0).SubItems("MaMon").Text Then
                    quantity += item.SubItems("SoLuong").Text
                    item.Selected = True
                End If
            Next
            txtTotalQuantity.Text = quantity.ToString()
        End If
    End Sub
End Class