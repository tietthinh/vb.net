Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows(0).Cells("Column3").Value = "Xong"
    End Sub
End Class