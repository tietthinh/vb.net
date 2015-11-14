Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmLogin As New frmDangNhap()
        Dim result As DialogResult = frmLogin.ShowDialog()
        If result = Windows.Forms.DialogResult.Cancel Then
            Me.Close()
        Else
        End If
        tsmLogout.Visible = True
        tsmLogin.Visible = False
        tsmFunction.Visible = False
    End Sub
End Class
