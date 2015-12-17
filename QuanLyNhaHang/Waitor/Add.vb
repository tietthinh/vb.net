Imports Waitor.NhanVien
Imports Library

Public Class Add
    Dim a As frmNumPad
    Dim _Number As Integer = 0
    Private _ActiveTable As New Table
    Public Sub New(ByRef _Table As Table)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _ActiveTable = _Table
    End Sub
    Private Sub AddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Set form's start position in the screen.
        '' Định vị trí xuất hiện của Form.
        a = New frmNumPad(nudQuantity)
        a.StartPosition = FormStartPosition.Manual
        a.Location = New Point(600, 300)
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(810, 300)
        If (AppProvider._IsUpdate = True) Then
            ''Code failed!
            MessageBox.Show("is update")
            btnCancel.Enabled = True
            Dim row As DataGridViewRow = NhanVien.dgvList.SelectedRows.Item(0)
            nudQuantity.Value = row.Cells(2).Value
            txtNote.Text = row.Cells(3).Value.ToString
        End If
        Me.ShowDialog()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim _Order As New Order
        Dim _Name As String
        Dim _Id As String
        Dim _Quantity As Integer = Me.nudQuantity.Value
        Dim _Note As String = Me.txtNote.Text
        If (AppProvider._IsUpdate = False) Then
            Dim name As String = NhanVien.listMenu.SelectedItems(0).Text
            _Id = NhanVien.dgvList.Rows.Count + 1
            _Name = name
            NhanVien.dgvList.Rows.Add(_Id, _Name, _Quantity, _Note, "Chưa làm")

        Else
                ''Code failed!
                Dim index As Integer = NhanVien.dgvList.SelectedRows.Item(0).Index
            Dim row As DataGridViewRow = NhanVien.dgvList.SelectedRows.Item(0)
            nudQuantity.Value = row.Cells(2).Value
            txtNote.Text = row.Cells(3).Value
            Dim id As String = row.Cells(0).Value.ToString
            Dim name As String = row.Cells(1).Value.ToString
            NhanVien.dgvList.Rows(index).SetValues(id, name, _Quantity, _Note, "Đang Làm")
            _Id = id
            _Name = name
        End If
        _Order.Id = _Id
        _Order.Name = _Name
        _Order.Note = _Note
        _Order.Quantity = _Quantity
        _ActiveTable.AddOrder(_Order)
        Close()
    End Sub

    Private Sub nudQuantity_Enter(sender As Object, e As EventArgs) Handles nudQuantity.Enter
        a.Show()
        a.BringToFront()
    End Sub

    Private Sub nudQuantity_Leave(sender As Object, e As EventArgs) Handles nudQuantity.Leave
        a.Hide()
    End Sub

    Private Sub Add_FrmClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        a.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class