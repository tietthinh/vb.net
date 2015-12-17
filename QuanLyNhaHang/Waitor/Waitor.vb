﻿Imports System.Data.SqlClient
Imports Library

Public Class NhanVien

    Private path As String = My.Application.Info.DirectoryPath
    Private _Connection As New DatabaseConnection
    Dim _ActiveTable As New Table
    Dim _IsSelected As Boolean = False
    Dim _IsCommitted As Boolean = False
    Dim _PictureBoxEffect As PictureBox
    Dim _SelectedTable As PictureBox
    Dim _TransferCode() As String
    'Show content
    'Hiển thị nội dung
    Private Sub picTable01_Click(sender As Object, e As EventArgs) Handles picTable01.Click, picTable02.Click, picTable03.Click, picTable04.Click,
        picTable05.Click, picTable06.Click, picTable07.Click, picTable08.Click, picTable09.Click
        Dim _Number As String = "BÀN "
        _SelectedTable = CType(sender, PictureBox)
        If (_IsSelected = False) Then
            Dim a As Integer = MessageBox.Show("Vui lòng kiểm tra số bàn!" + vbCrLf + "Bạn đang chọn bàn số " + _SelectedTable.Name.Last, "Xác Nhận", MessageBoxButtons.OKCancel)
            If (a > 0) Then
                Select Case _SelectedTable.Name
                    Case picTable01.Name
                        _PictureBoxEffect = picTable01
                    Case picTable02.Name
                        _Number += "2"
                        _PictureBoxEffect = picTable02
                    Case picTable03.Name
                        _Number += "3"
                        _PictureBoxEffect = picTable03
                    Case picTable04.Name
                        _Number += "4"
                        _PictureBoxEffect = picTable04
                    Case picTable05.Name
                        _Number += "5"
                        _PictureBoxEffect = picTable05
                    Case picTable06.Name
                        _Number += "6"
                        _PictureBoxEffect = picTable06
                    Case picTable07.Name
                        _Number += "7"
                        _PictureBoxEffect = picTable07
                    Case picTable08.Name
                        _Number += "8"
                        _PictureBoxEffect = picTable08
                    Case picTable09.Name
                        _Number += "9"
                        _PictureBoxEffect = picTable09
                End Select
                _IsSelected = True
                _PictureBoxEffect.BackColor = Color.RoyalBlue
                lblTittle.Text = "DANH SÁCH MÓN ĂN BÀN " + _Number
                listMenu.Enabled = True
                _IsCommitted = False
            End If
        End If
    End Sub

    Private Sub LoadMenu()
        listMenu.Clear()
        Dim imgList As New ImageList
        Dim bow As String = IO.Path.Combine(path, "..\..\img\dishs.png")
        Dim dish As String = IO.Path.Combine(path, "..\..\img\glass.png")
        imgList.Images.Add(Image.FromFile(bow))
        imgList.Images.Add(Image.FromFile(dish))
        listMenu.LargeImageList = imgList
        Try
            _Connection.Open()
            Dim _Row As DataRow = Nothing
            Dim _Id As String = Nothing
            Dim _IdTemp() As String = Nothing
            ''Stored Procedure
            Dim _Query As String = "spMonAnDoUongSelect"
            Dim _Data As DataTable = Nothing
            Dim index As Integer = 0
            Dim _Parameter As New SqlClient.SqlParameter("@TinhTrang", 1)
            _Data = _Connection.Query(_Query, _Parameter)
            For Each _Row In _Data.Rows
                listMenu.Items.Add(_Row(1).ToString())
                listMenu.Items(index).SubItems.Add(_Row(0).ToString())
                If (_Row(0).ToString().Substring(0, 2) = "DA") Then
                    ''Set image
                    listMenu.Items(index).ImageIndex = 0
                Else
                    ''Set image
                    listMenu.Items(index).ImageIndex = 1
                End If
                index = index + 1
            Next
            _Parameter = New SqlClient.SqlParameter("@TinhTrang", 0)
            _Data = Nothing
            index = 0
            _Data = _Connection.Query(_Query, _Parameter)
            For Each _Row In _Data.Rows
                lstNotAvailable.Items.Add(_Row(1).ToString())
            Next
            _Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub listMenu_Click(sender As Object, e As EventArgs) Handles listMenu.Click
        AppProvider._IsUpdate = False
        Dim Add As New Add(_ActiveTable)
        Add.ShowDialog()
    End Sub

    Private Sub dtgList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellContentClick
        AppProvider._IsUpdate = True
        Dim add As New Add(_ActiveTable)
        add.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMenu()
    End Sub
    Private Sub LoadList(ByVal _Table As Table)
        If (_IsSelected) Then
            dgvList.Rows.Clear()
            For i As Integer = 0 To _Table.GetLength() - 1 Step 1
                dgvList.Rows.Add(_Table.GetOrder(i).Id, _Table.GetOrder(i).Name, _Table.GetOrder(i).Quantity, _Table.GetOrder(i).Note)
            Next
        End If
    End Sub

    Private Sub btnLamMon_Click(sender As Object, e As EventArgs) Handles btnLamMon.Click
        ''Commit the list to Chef

        If (dgvList.Rows.Count <> 0) Then
            Dim index As Integer = 0
            MessageBox.Show("Gửi danh sách thành công!", "Thông báo", MessageBoxButtons.OK)
            Dim _Row As DataGridViewRow
            Dim _Query As String = "spDSDatMonTrongNgayInsert"
            Dim _Parameter() As SqlParameter
            ''Insert
            For Each _Row In dgvList.Rows
                Dim a As String = listMenu.Items(index).SubItems(1).Text
                Dim b As Integer = dgvList.Item(2, index).Value
                Dim c As Integer = 1
                Dim d As String = dgvList.Item(3, index).Value
                Dim e1 As Integer = Integer.Parse(_SelectedTable.Name.Last())
                _Parameter = {New SqlParameter("@MaMon", a), New SqlParameter("@SoLuong", b), New SqlParameter("@TinhTrang", c), New SqlParameter("@GhiChu", d), New SqlParameter("@SoBan", e1), New SqlParameter("@MaMoi", AppProvider._TransferCode)}
                _Connection.Query(_Query, _Parameter)
                index += 1
                ''Return the _TransferCode
                ''_TransferCode(index) = _TransferCode
                ''
            Next
            ''
            '' Reload datagridview
            index = 0
            For Each _Row In dgvList.Rows
                dgvList.Item(5, index).Value = _TransferCode(index)
                index += 1
            Next
            ''
            _IsCommitted = True
        Else
            MessageBox.Show("Danh sách món ăn trống!", "Thông báo")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _IsSelected = False
        ''Commit the list to Cashier
        _PictureBoxEffect.BackColor = Color.White
        dgvList.Rows.Clear()
        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim a As Integer = MessageBox.Show("Vui lòng kiểm tra số bàn!" + vbCrLf + "Bạn đang chọn bàn số " + _SelectedTable.Name.Last, "Xác Nhận", MessageBoxButtons.OKCancel)
            If (a > 0) Then
                If (_IsCommitted = True) Then
                    ''Update status on database
                End If
                dgvList.Rows.RemoveAt(dgvList.SelectedRows.Item(0).Index)
            End If
        Catch
        End Try
    End Sub
End Class