Imports System.Data.SqlClient
Imports Library
Imports Remote

Public Class frmChiTietMon

    Dim SelectedItem As String = Nothing
    Dim _MaMon As String = ""
    Private Connection As New DatabaseConnection()
    Private listArray As List(Of String)
    Private Sub lstGui_Click(sender As Object, e As EventArgs) Handles lstGui.Click
        _MaMon = lstGui.SelectedItems(0).Text
        SelectedItem = lstGui.SelectedItems(0).Index
        loadChiTietMon()
    End Sub

    Public Sub New(ByVal _listArray As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        listArray = _listArray
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        SendData("7+" + _MaMon + "*")
        lstGui.Items.RemoveAt(SelectedItem)
    End Sub

    Private Sub frmChiTietMon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMaMon()
        lstGui.Items(0).Selected = True
        cboDinhMuc.Items.Add("4")
        cboDinhMuc.Items.Add("10")
        cboDinhMuc.Items.Add("30")
        cboDinhMuc.Items.Add("50")
        cboDinhMuc.Items.Add("Khác")
        cboDinhMuc.SelectedIndex = 1
        txtDinhMuc.Text = cboDinhMuc.Text

        _MaMon = lstGui.SelectedItems(0).Text

    End Sub

    Private Sub loadChiTietMon()
        Dim _ReturnValue As SqlParameter = New SqlParameter
        Dim _Name() As String = New String() {"@MaMon", "@DinhMuc"}
        Dim _Value() As String = New String() {lstGui.SelectedItems(0).Text, txtDinhMuc.Text}
        dgvChiTietMon.DataSource = Connection.Query("usp_XemSanPhamTheoMaMon", Connection.CreateParameter(_Name, _Value))
    End Sub

    Private Sub cboDinhMuc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboDinhMuc.SelectionChangeCommitted
        If cboDinhMuc.Text = "Khác" Then
            txtDinhMuc.ReadOnly = False
        Else
            txtDinhMuc.ReadOnly = True
            txtDinhMuc.Text = cboDinhMuc.Text
        End If
    End Sub

    Private Sub txtDinhMuc_TextChanged(sender As Object, e As EventArgs) Handles txtDinhMuc.TextChanged
        loadChiTietMon()
    End Sub

    Private Sub loadMaMon()
        For i As Integer = 0 To listArray.Count() - 1 Step 1
            lstGui.Items.Add(listArray(i))
        Next
    End Sub

    Private Sub txtDinhMuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDinhMuc.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub
End Class