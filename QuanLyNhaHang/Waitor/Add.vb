<<<<<<< HEAD
﻿Public Class Add
    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Set form's start position in the screen.
        '' Định vị trí xuất hiện của Form.
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(800, 300)
        Me.ShowDialog()
    End Sub
=======
﻿
Imports Library
Imports System.Data.SqlClient

Public Class Add
    Dim frmNumpad As frmNumPad
    Dim _Number As Integer = 0
    Private _Connection As New DatabaseConnection

    Private Sub AddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Set form's start position in the screen.
        '' Định vị trí xuất hiện của Form.
        frmNumpad = New frmNumPad(nudQuantity)
        frmNumpad.StartPosition = FormStartPosition.Manual
        frmNumpad.Location = New Point(600, 300)
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(810, 300)
        If (AppProvider._IsUpdate = True) Then
            ''Code failed!
            MessageBox.Show("is update")
            Dim row As DataGridViewRow = NhanVien.dgvList.SelectedRows.Item(0)
            nudQuantity.Value = row.Cells(2).Value
            txtNote.Text = row.Cells(3).Value.ToString
        End If
        Me.ShowDialog()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim _Name As String = ""
        Dim _Id As String = ""
        Dim _Quantity As Integer = Me.nudQuantity.Value
        Dim _Note As String = Me.txtNote.Text
        If (AppProvider._IsUpdate = False) Then
            Dim _Code As String = AppProvider._SelectedItem
            Dim name As String = NhanVien.lstMenu.SelectedItems(0).Text
            _Id = NhanVien.dgvList.Rows.Count + 1
            _Name = name
            NhanVien.dgvList.Rows.Add(_Id, _Name, _Quantity, _Note, "Chưa làm", Nothing, _Code)
        Else
            ''Is update
            Dim _Index As Integer = NhanVien.dgvList.SelectedRows.Item(0).Index
            Dim _Row As DataGridViewRow = NhanVien.dgvList.SelectedRows.Item(0)
            Dim _Code As String = _Row.Cells(5).Value
            nudQuantity.Value = _Row.Cells(2).Value
            txtNote.Text = _Row.Cells(3).Value
            Dim id As String = _Row.Cells(0).Value.ToString
            Dim name As String = _Row.Cells(1).Value.ToString
            If (AppProvider._IsCommitted = True) Then
                ''Update to Database
                Dim _Query As String = "spDSDatMonTrongNgayUpdateSLGhiChu"
                Dim _ParameterInput() As SqlParameter
                _ParameterInput = {New SqlParameter("@MaChuyen ", _Code), New SqlParameter("@SoLuong", Integer.Parse(nudQuantity.Value)), New SqlParameter("@GhiChu", txtNote.Text)}
                _Connection.Query(_Query, _ParameterInput)
                _Id = id
                _Name = name
            End If
            NhanVien.dgvList.Rows(_Index).SetValues(id, name, _Quantity, _Note)
        End If
        Close()
    End Sub

    Private Sub nudQuantity_Enter(sender As Object, e As EventArgs) Handles nudQuantity.Enter
        frmNumpad.Show()
        frmNumpad.BringToFront()
    End Sub

    Private Sub nudQuantity_Leave(sender As Object, e As EventArgs) Handles nudQuantity.Leave
        frmNumpad.Hide()
    End Sub

    Private Sub Add_FrmClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmNumpad.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtNote_GotFocus(sender As Object, e As EventArgs) Handles txtNote.GotFocus
        Process.Start("osk")
        txtNote.Focus()
    End Sub
    Private Sub txtNote_LostFocus(sender As Object, e As EventArgs) Handles txtNote.LostFocus
        For Each proc As Process In Process.GetProcessesByName("osk")
            proc.Kill()
        Next
    End Sub
>>>>>>> dc5d22baf6e808a874f7b923c1327adcd307ff6f
End Class