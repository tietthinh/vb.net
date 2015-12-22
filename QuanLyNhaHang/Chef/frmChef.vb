'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library
<<<<<<< HEAD
Imports Remote
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.ChannelServices
Imports System.Threading
=======
Imports System.Data.SqlClient

>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
Public Class frmChef
    Private _ServerObject As ServerObject
    Private _Username As String
    Private _Thread As Thread
    Private _Data As String = ""
    Private _Logging As String = ""
    Dim db As New DatabaseConnection()

    Dim frmNumpad As frmNumPad

    Dim orderList As DataTable
    Dim cookList As New DataTable()
    Dim cantServeList As New DataTable()
    Dim materialList As New DataTable()
    Dim currentUsedMaterial As New DataTable()

    Dim currentDish As String

    Dim currentIndex As Integer
    Dim currentTotalQuantity As Integer
    Dim dishTotal As Integer
    Dim currentMaterialRow As Integer

    Dim exceptionList As New List(Of ListViewItem)

    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
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
=======
        Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(New String() {"@MaChuyen"}, New Object() {"01-0001"})

>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
        Try
            orderList = db.Query("spDSDatMonTrongNgaySelect", parameter)
        Catch ex As SqlException
            Throw ex
<<<<<<< HEAD
        Finally
=======
>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
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

        currentUsedMaterial.Columns.Add("MaSP")
        currentUsedMaterial.Columns.Add("SoLuong")
        currentUsedMaterial.Columns.Add("SoLuongMotMon")

        cantServeList = orderList.Clone()
    End Sub

    Private Sub ltvOrderList_Click(sender As Object, e As EventArgs) Handles ltvOrderList.Click
        ClearListViewItemBackColor(exceptionList, ltvOrderList)
        currentTotalQuantity = 0

        Dim quantity As Integer = 0
        If ltvOrderList.SelectedItems.Count > 0 Then
            currentDish = ltvOrderList.SelectedItems(0).SubItems("MaMon").Text

            For Each item As ListViewItem In ltvOrderList.Items
                If item.SubItems("MaMon").Text = currentDish Then
                    quantity += item.SubItems("SoLuong").Text

                    If item.SubItems("GhiChu").Text <> "" Then
                        item.Selected = False
                        item.BackColor = Color.Red
                        exceptionList.Add(item)
                    Else
                        item.Selected = True
                        currentTotalQuantity += Integer.Parse(item.SubItems("SoLuong").Text)
                    End If
                End If
            Next

            materialList = LoadMaterial(ltvOrderList.SelectedItems(0).SubItems("MaMon").Text)
            dgvMaterialList.DataSource = materialList

            exceptionList.Reverse()

            currentUsedMaterial.Rows.Clear()
            currentUsedMaterial = CloneDataTable(materialList, GetAllColumnsName(currentUsedMaterial), currentTotalQuantity)

            txtTotalQuantity.Text = quantity.ToString()
        End If
    End Sub

    Private Sub ltvOrderList_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCook_Click(sender As Object, e As EventArgs) Handles btnCook.Click
        If ltvOrderList.SelectedItems.Count > 0 Then
            dishTotal = 0
            For Each item As ListViewItem In ltvOrderList.SelectedItems
                Dim row As DataRow = cookList.NewRow
                row("MaChuyen") = item.SubItems("MaChuyen").Text
                row("TenMon") = item.SubItems("TenMon").Text
                row("SoLuong") = item.SubItems("SoLuong").Text
                cookList.Rows.Add(row)

                dishTotal += row("SoLuong")
            Next
            dgvCookList.DataSource = cookList
<<<<<<< HEAD
=======

            Try
                db.Update("spSanPhamDaDungInsert", db.CreateParameter(New String() {"@DS"}, New Object() {currentUsedMaterial}))
            Catch ex As SqlException
                MessageBox.Show(ex.Number)
                MessageBox.Show(ex.Message)
                Throw ex
            End Try

>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
            For i As Integer = ltvOrderList.SelectedItems.Count - 1 To 0 Step -1
                orderList.Rows(ltvOrderList.SelectedItems(i).Index).Delete()
                ltvOrderList.SelectedItems(i).Remove()
            Next
            txtTotalQuantity.Text = ""
        End If
    End Sub

    Private Sub frmChef_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        db.Close()
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

<<<<<<< HEAD
=======
        currentTotalQuantity = Nothing
>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
    End Sub

    Private Sub dgvCookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCookList.CellContentClick
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim column As DataGridViewColumn = dgv.Columns(e.ColumnIndex)

        If TypeOf column Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
<<<<<<< HEAD
=======
            Dim parameterName() As String = New String() {"@MaChuyen", "@TinhTrang"}
            Dim parameterValue() As Object = New Object() {dgv.Rows(e.RowIndex).Cells("CookListTransID").Value, 3}
            Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(parameterName, parameterValue)
            db.Update("spDSDatMonTrongNgayUpdateTinhTrang", parameter)
>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
            dgv.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub ltvOrderList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ltvOrderList.MouseDoubleClick
        ltbException.Items.Clear()
        ltvOrderList.SelectedItems.Clear()
        currentTotalQuantity = 0

        currentIndex = ltvOrderList.InsertionMark.NearestIndex(New Point(e.X, e.Y))
        ltvOrderList.Items(currentIndex).Selected = True
        If ltvOrderList.SelectedItems.Count > 0 Then
            ltbException.Items.Add(ltvOrderList.SelectedItems(0).SubItems("GhiChu").Text)

            currentTotalQuantity = Integer.Parse(ltvOrderList.SelectedItems(0).SubItems("SoLuong").Text)

            materialList = LoadMaterial(ltvOrderList.SelectedItems(0).SubItems("MaMon").Text)
            dgvMaterialList.DataSource = materialList

            currentUsedMaterial.Rows.Clear()
            currentUsedMaterial = CloneDataTable(materialList, GetAllColumnsName(currentUsedMaterial), currentTotalQuantity)
        End If
    End Sub

    Private Sub ltvOrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvOrderList.SelectedIndexChanged
        If ltvOrderList.SelectedItems.Count <= 0 Then
            ClearListViewItemBackColor(exceptionList, ltvOrderList)

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

<<<<<<< HEAD
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
=======
    Private Sub lblMaterialQuantity_TextChanged(sender As Object, e As EventArgs)
        Try
            dgvMaterialList.Rows(currentMaterialRow).Cells("MaterialQuantity").Value = lblMaterialQuantity.Text
        Catch ex As Exception
            dgvMaterialList.Rows(currentMaterialRow).Cells("MaterialQuantity").Value = Math.Round(Double.Parse(lblMaterialQuantity.Text))
        End Try
>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
    End Sub
End Class