Imports Library
Imports System.Windows

Public Class frmConfirm

    Dim _MaxValue As Integer

    Dim frmNumpad As frmNumPad

    Public Sub New(ByVal maxValue As Integer)
        Me.InitializeComponent()

        _MaxValue = maxValue
    End Sub

    'Events:
    '
    'Form's Events
    '
    'Load: Occur when the form first load.
    Private Sub frmConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Remove border to prevent resize this form
        Me.FormBorderStyle = FormBorderStyle.None

        nudQuantity.Maximum = Decimal.Parse(_MaxValue)
        nudQuantity.Minimum = 0
    End Sub
    '
    'FormClosing: Occur when the form is closing.
    Private Sub frmConfirm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmNumpad.Close()
        frmNumpad.Dispose()
        frmNumpad = Nothing
    End Sub
    '
    'nudQuantity's Events
    '
    'Enter: Occur when the nudQuantity gets focused.
    Private Sub nudQuantity_Enter(sender As Object, e As EventArgs) Handles nudQuantity.Enter
        frmNumpad = New frmNumPad(lblQuantity)
        frmNumpad.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height + 2)
        frmNumpad.Show()
    End Sub
    '
    'lblQuantity's Events
    '
    'TextChanged: Occur when changes the text of lblQuantity.
    Private Sub lblQuantity_TextChanged(sender As Object, e As EventArgs) Handles lblQuantity.TextChanged
        If IsNumeric(lblQuantity.Text) = True Then
            If Decimal.Parse(lblQuantity.Text) <= nudQuantity.Maximum Then
                nudQuantity.Value = Decimal.Parse(lblQuantity.Text)
            Else
                nudQuantity.Value = nudQuantity.Maximum
            End If
        End If
    End Sub
    '
    'btnCancel's Events
    '
    'Click: Occur when clicks the button Cancel.
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
    '
    'btnOK's Events
    '
    'Click: Occur when clicks the button OK.
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmBartender.doneQuantity = Integer.Parse(nudQuantity.Value)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class