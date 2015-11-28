Imports System.Drawing
Imports System.Windows.Forms

Public Class frmDangNhap

    Private isPWNull As Boolean
    Private isIDNull As Boolean
    Private db As New DatabaseConnection()

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = "Username"
        txtPW.Text = "Password"
        txtID.Font = New Font(txtID.Font, FontStyle.Italic)
        txtPW.Font = New Font(txtPW.Font, FontStyle.Italic)
        isPWNull = True
        isIDNull = True
        lblClearID.Visible = False
        lblSeePW.Visible = False
    End Sub

    Private Sub txtID_Enter(sender As Object, e As EventArgs) Handles txtID.Enter
        If isIDNull = True Then
            txtID.Text = ""
            txtID.Font = New Font(txtID.Font, FontStyle.Regular)
            isIDNull = False
            AddHandler txtID.TextChanged, AddressOf txtID_TextChanged
        Else
            lblClearID.Visible = True
        End If
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        If txtID.Text = "" Then
            RemoveHandler txtID.TextChanged, AddressOf txtID_TextChanged
            isIDNull = True
            txtID.Text = "Username"
            txtID.Font = New Font(txtID.Font, FontStyle.Italic)
        End If
        lblClearID.Visible = False
    End Sub

    Private Sub txtPW_Enter(sender As Object, e As EventArgs) Handles txtPW.Enter
        If isPWNull = True Then
            txtPW.Text = ""
            txtPW.UseSystemPasswordChar = True
            txtPW.Font = New Font(txtPW.Font, FontStyle.Regular)
            isPWNull = False
            AddHandler txtPW.TextChanged, AddressOf txtPW_TextChanged
        Else
            lblSeePW.Visible = True
        End If
    End Sub

    Private Sub txtPW_Leave(sender As Object, e As EventArgs) Handles txtPW.Leave
        If txtPW.Text = "" Then
            RemoveHandler txtPW.TextChanged, AddressOf txtPW_TextChanged
            isPWNull = True
            txtPW.UseSystemPasswordChar = False
            txtPW.Font = New Font(txtPW.Font, FontStyle.Italic)
            txtPW.Text = "Password"
        End If
        lblSeePW.Visible = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Dim account As DataTable = db.Query()
        'For Each row As DataRow In account.Rows
        '    If txtID.Text = row("Username") And GetMd5Hash(txtPW.Text) = row("Password") Then
        '        MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK)
        '        Me.DialogResult = Windows.Forms.DialogResult.OK
        '        Me.Close()
        '    End If
        'Next
    End Sub

    Private Sub lblClear_MouseHover(sender As Object, e As EventArgs) Handles lblSeePW.MouseHover, lblClearID.MouseHover
        CType(sender, Control).BackColor = Color.LightGray
    End Sub

    Private Sub lblClear_MouseLeave(sender As Object, e As EventArgs) Handles lblSeePW.MouseLeave, lblClearID.MouseLeave
        CType(sender, Control).BackColor = SystemColors.Window
    End Sub

    Private Sub lblClearID_Click(sender As Object, e As EventArgs) Handles lblClearID.Click
        txtID.Text = ""
        lblClearID.Visible = False
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)
        lblClearID.Visible = True
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs)
        lblSeePW.Visible = True
    End Sub

    Private Sub lblSeePW_MouseDown(sender As Object, e As MouseEventArgs) Handles lblSeePW.MouseDown
        txtPW.UseSystemPasswordChar = False
    End Sub

    Private Sub lblSeePW_MouseCaptureChanged(sender As Object, e As EventArgs) Handles lblSeePW.MouseCaptureChanged
        txtPW.UseSystemPasswordChar = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
