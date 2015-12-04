Public Class Add
    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Set form's start position in the screen.
        '' Định vị trí xuất hiện của Form.
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(800, 300)
        Me.ShowDialog()
    End Sub
End Class