Public Class frmThemNhanVien

    Private isPWNull As Boolean
    Private isIDNull As Boolean
    Private isCPWNull As Boolean
    Private isHoTenNull As Boolean
    Private isCMNDNull As Boolean
    Private ep As New ErrorProvider()
    Private epCount As Integer

    Private db As New DatabaseConnection()

    Private Sub frmDangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Tên đăng nhập"
        txtPassword.Text = "Mật khẩu"
        txtConfirmPW.Text = "Nhập lại mật khẩu"
        txtHoTen.Text = "Họ tên"
        txtCMND.Text = "Chứng minh nhân dân"
        txtUsername.Font = New Font(txtUsername.Font, FontStyle.Italic)
        txtPassword.Font = New Font(txtPassword.Font, FontStyle.Italic)
        txtConfirmPW.Font = New Font(txtConfirmPW.Font, FontStyle.Italic)
        txtHoTen.Font = New Font(txtHoTen.Font, FontStyle.Italic)
        txtCMND.Font = New Font(txtCMND.Font, FontStyle.Italic)
        isPWNull = True
        isIDNull = True
        isCPWNull = True
        isHoTenNull = True
        isCMNDNull = True
        lblClearID.Visible = False
        lblSeePW.Visible = False
        lblSeeCPW.Visible = False
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If isIDNull = True Then
            txtUsername.Text = ""
            txtUsername.Font = New Font(txtUsername.Font, FontStyle.Regular)
            isIDNull = False
            AddHandler txtUsername.TextChanged, AddressOf txtUsername_TextChanged
        Else
            lblClearID.Visible = True
        End If
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            RemoveHandler txtUsername.TextChanged, AddressOf txtUsername_TextChanged
            isIDNull = True
            txtUsername.Text = "Tên đăng nhập"
            txtUsername.Font = New Font(txtUsername.Font, FontStyle.Italic)
        End If
        lblClearID.Visible = False
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If isPWNull = True Then
            txtPassword.Text = ""
            txtPassword.UseSystemPasswordChar = True
            txtPassword.Font = New Font(txtPassword.Font, FontStyle.Regular)
            isPWNull = False
            AddHandler txtPassword.TextChanged, AddressOf txtPassword_TextChanged
        Else
            lblSeePW.Visible = True
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            RemoveHandler txtPassword.TextChanged, AddressOf txtPassword_TextChanged
            isPWNull = True
            txtPassword.UseSystemPasswordChar = False
            txtPassword.Font = New Font(txtPassword.Font, FontStyle.Italic)
            txtPassword.Text = "Mật khẩu"
        End If
        lblSeePW.Visible = False
    End Sub

    Private Sub lblClear_MouseHover(sender As Object, e As EventArgs) Handles lblSeePW.MouseHover, lblClearID.MouseHover, lblSeeCPW.MouseHover
        CType(sender, Control).BackColor = Color.LightGray
    End Sub

    Private Sub lblClear_MouseLeave(sender As Object, e As EventArgs) Handles lblSeePW.MouseLeave, lblClearID.MouseLeave, lblSeeCPW.MouseLeave
        CType(sender, Control).BackColor = SystemColors.Window
    End Sub

    Private Sub lblClearID_Click(sender As Object, e As EventArgs) Handles lblClearID.Click
        txtUsername.Text = ""
        lblClearID.Visible = False
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)
        lblClearID.Visible = True
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)
        lblSeePW.Visible = True
    End Sub

    Private Sub txtConfirmPW_TextChanged(sender As Object, e As EventArgs)
        lblSeeCPW.Visible = True
    End Sub

    Private Sub EyePW_MouseDown(sender As Object, e As MouseEventArgs) Handles lblSeePW.MouseDown
        txtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub EyeCPW_MouseDown(sender As Object, e As MouseEventArgs) Handles lblSeeCPW.MouseDown
        txtConfirmPW.UseSystemPasswordChar = False
    End Sub

    Private Sub EyePW_MouseCaptureChanged(sender As Object, e As EventArgs) Handles lblSeePW.MouseCaptureChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub EyeCPW_MouseCaptureChanged(sender As Object, e As EventArgs) Handles lblSeeCPW.MouseCaptureChanged
        txtConfirmPW.UseSystemPasswordChar = True
    End Sub

    Private Sub txtConfirmPW_Enter(sender As Object, e As EventArgs) Handles txtConfirmPW.Enter
        If isCPWNull = True Then
            txtConfirmPW.Text = ""
            txtConfirmPW.UseSystemPasswordChar = True
            txtConfirmPW.Font = New Font(txtConfirmPW.Font, FontStyle.Regular)
            isCPWNull = False
            AddHandler txtConfirmPW.TextChanged, AddressOf txtConfirmPW_TextChanged
        Else
            lblSeeCPW.Visible = True
        End If
    End Sub

    Private Sub txtConfirmPW_Leave(sender As Object, e As EventArgs) Handles txtConfirmPW.Leave
        If txtConfirmPW.Text = "" Then
            RemoveHandler txtConfirmPW.TextChanged, AddressOf txtConfirmPW_TextChanged
            isCPWNull = True
            txtConfirmPW.UseSystemPasswordChar = False
            txtConfirmPW.Font = New Font(txtConfirmPW.Font, FontStyle.Italic)
            txtConfirmPW.Text = "Nhập lại mật khẩu"
        End If
        lblSeeCPW.Visible = False
    End Sub

    Private Sub txtHoTen_Enter(sender As Object, e As EventArgs) Handles txtHoTen.Enter
        If isHoTenNull = True Then
            txtHoTen.Text = ""
            txtHoTen.Font = New Font(txtHoTen.Font, FontStyle.Regular)
            isHoTenNull = False
        End If
    End Sub

    Private Sub txtHoTen_Leave(sender As Object, e As EventArgs) Handles txtHoTen.Leave
        If txtHoTen.Text = "" Then
            isHoTenNull = True
            txtHoTen.Font = New Font(txtHoTen.Font, FontStyle.Italic)
            txtHoTen.Text = "Họ tên"
        End If
    End Sub

    Private Sub txtCMND_Enter(sender As Object, e As EventArgs) Handles txtCMND.Enter
        If isCMNDNull = True Then
            txtCMND.Text = ""
            txtCMND.Font = New Font(txtCMND.Font, FontStyle.Regular)
            isCMNDNull = False
        End If
    End Sub

    Private Sub txtCMND_Leave(sender As Object, e As EventArgs) Handles txtCMND.Leave
        If txtCMND.Text = "" Then
            isCMNDNull = True
            txtCMND.Text = "Chứng minh nhân dân"
            txtCMND.Font = New Font(txtCMND.Font, FontStyle.Italic)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        epCount = 0
        Select Case db.CheckInfor(txtUsername.Text, txtPassword.Text, txtConfirmPW.Text, dpkNgaySinh.Value)
            Case 1
                ep.SetError(txtUsername, "Tên đăng nhập đã tồn tại")
                epCount += 1
            Case 2
                ep.SetError(txtConfirmPW, "Mật khẩu xác nhận không khớp")
                epCount += 1
            Case 3
                ep.SetError(dpkNgaySinh, "Ngày sinh phải trước ngày hiện tại")
                epCount += 1
        End Select
        If epCount > 0 Then
            Return
        End If
        ep.SetError(txtUsername, "")
        ep.SetError(txtConfirmPW, "")
        ep.SetError(dpkNgaySinh, "")
        Dim acc As New DataTable("Account")
        acc.Columns.Add("Username", GetType(String))
        acc.Columns.Add("Password", GetType(String))
        Dim row As DataRow = acc.NewRow()
        row("Username") = txtUsername.Text
        row("Password") = GetMd5Hash(txtPassword.Text, txtCMND.Text)
        acc.Rows.Add(row)
        db.Update(acc, "Account")
        Dim nv As DataTable = New DataTable("NhanVien")
        nv.Columns.Add("CMND", GetType(String))
        nv.Columns.Add("HoTen", GetType(String))
        nv.Columns.Add("NgaySinh", GetType(DateTime))
        nv.Columns.Add("GioiTinh", GetType(String))
        nv.Columns.Add("AccountID", GetType(Integer))
        nv.Columns.Add("TGBatDau", GetType(DateTime))
        nv.Columns.Add("TinhTrang", GetType(Boolean))
        nv.Columns.Add("LoaiNV", GetType(Integer))
        Dim temp As DataTable = db.Query("Select ID From Account Where Username = rtrim('" + txtUsername.Text + "')")
        row = nv.NewRow()
        row("CMND") = txtCMND.Text
        row("HoTen") = txtHoTen.Text
        row("NgaySinh") = dpkNgaySinh.Value
        Dim rowtemp As DataRow = temp.NewRow()
        rowtemp = temp.Rows(0)
        row("AccountID") = rowtemp("ID")
        rowtemp.Delete()
        temp.Dispose()
        row("TGBatDau") = Now
        row("TinhTrang") = True
        row("LoaiNV") = Rnd()
        temp = Nothing
        If (rdoNam.Checked = True) Then
            row("GioiTinh") = "Nam"
        Else
            row("GioiTinh") = "Nữ"
        End If
        nv.Rows.Add(row)
        db.Update(nv, "NhanVien")
        nv.Dispose()
        nv = Nothing
        If (MessageBox.Show("Đăng ký thành công", "", MessageBoxButtons.OK) = Windows.Forms.DialogResult.OK) Then
            btnReset.PerformClick()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtUsername.Focus()
        txtPassword.Text = ""
        txtPassword.Focus()
        txtConfirmPW.Text = ""
        txtConfirmPW.Focus()
        txtHoTen.Text = ""
        txtHoTen.Focus()
        txtCMND.Text = ""
        txtCMND.Focus()
        rdoNam.Checked = True
        dpkNgaySinh.Value = Now
        btnSubmit.Focus()
    End Sub
End Class