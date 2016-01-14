'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Changes Employee's Password
'=====================================================================

Imports System.Drawing
Imports System.Windows.Forms

Public Class frmForgotPassword
    ''' <summary>
    ''' Create a connected object for this form.
    ''' </summary>
    ''' <remarks></remarks>
    Private db As New DatabaseConnection()

    Private Sub frmForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets default text for textbox when form loads.
        txtUsername.Text = "Username"
        txtPassword.Text = "Password"
        txtPasswordConfirm.Text = "Confirm Password"
        txtCMND.Text = "Personal Identity"

        'Sets font for these text.
        txtUsername.Font = New Font(txtUsername.Font, FontStyle.Italic)
        txtPassword.Font = New Font(txtPassword.Font, FontStyle.Italic)
        txtPasswordConfirm.Font = New Font(txtPasswordConfirm.Font, FontStyle.Italic)
        txtCMND.Font = New Font(txtCMND.Font, FontStyle.Italic)
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.Text = ""
        txtUsername.Font = New Font(txtUsername.Font, FontStyle.Regular)
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Font = New Font(txtUsername.Font, FontStyle.Italic)
            txtUsername.Text = "Username"
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.Text = ""
        txtPassword.Font = New Font(txtPassword.Font, FontStyle.Regular)
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Font = New Font(txtPassword.Font, FontStyle.Italic)
            txtPassword.UseSystemPasswordChar = False
            txtPassword.Text = "Password"
        End If
    End Sub

    Private Sub txtPasswordConfirm_Enter(sender As Object, e As EventArgs) Handles txtPasswordConfirm.Enter
        txtPasswordConfirm.Text = ""
        txtPasswordConfirm.Font = New Font(txtPasswordConfirm.Font, FontStyle.Regular)
        txtPasswordConfirm.UseSystemPasswordChar = True
    End Sub

    Private Sub txtPasswordConfirm_Leave(sender As Object, e As EventArgs) Handles txtPasswordConfirm.Leave
        If txtPasswordConfirm.Text = "" Then
            txtPasswordConfirm.Font = New Font(txtPasswordConfirm.Font, FontStyle.Italic)
            txtPasswordConfirm.UseSystemPasswordChar = False
            txtPasswordConfirm.Text = "Confirm Password"
        End If
    End Sub

    Private Sub txtCMND_Enter(sender As Object, e As EventArgs) Handles txtCMND.Enter
        txtCMND.Text = ""
        txtCMND.Font = New Font(txtCMND.Font, FontStyle.Regular)
    End Sub

    Private Sub txtCMND_Leave(sender As Object, e As EventArgs) Handles txtCMND.Leave
        If txtCMND.Text = "" Then
            txtCMND.Font = New Font(txtCMND.Font, FontStyle.Italic)
            txtCMND.Text = "Personal Identity"
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim errorCode As Integer = db.CheckInfor(txtPassword.Text, txtPasswordConfirm.Text, txtCMND.Text)

        Select Case errorCode
            Case 1
                MessageBox.Show("Mật khẩu xác nhận không giống với mật khẩu")

                Exit Sub
            Case 2
                MessageBox.Show("Mật khẩu phải dài tối thiểu 3 ký tự")

                Exit Sub
            Case 3
                MessageBox.Show("Chứng minh thư phải là 9 hoặc 12 ký tự")

                Exit Sub
        End Select

        db.Update("usp_CapNhapTaiKhoan", db.CreateParameter(New String() {"@cmnd", "@TenDN", "@MatKhau"}, _
                                                            New Object() {txtCMND.Text, txtUsername.Text, GetMd5Hash(txtPassword.Text, txtCMND.Text)}))
        MessageBox.Show("Đổi mật khẩu thành công")

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        db.Dispose()
        db = Nothing

        Me.Close()
    End Sub
End Class