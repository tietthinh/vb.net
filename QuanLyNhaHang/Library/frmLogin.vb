'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Login form for Employees
'           Returns value for Employee's identity and Employee's name
'               if dialog result is OK
'               else return null
'=====================================================================

Imports System.Drawing
Imports System.Windows.Forms

Public Class frmLogin
    'Fields:
    ''' <summary>
    ''' If Password Textbox is null then true, else false.
    ''' </summary>
    ''' <remarks></remarks>
    Private _IsPWNull As Boolean

    ''' <summary>
    ''' If Identity Textbox is null then true, else false.
    ''' </summary>
    ''' <remarks></remarks>
    Private _IsIDNull As Boolean

    Private _FormID As Integer

    ''' <summary>
    ''' Create a connected object for this form.
    ''' </summary>
    ''' <remarks></remarks>
    Private db As New DatabaseConnection()

    Public Sub New(ByVal formID As Integer)
        Me.InitializeComponent()

<<<<<<< HEAD
        _FormID = formID
=======
        user = _ReturnUser
>>>>>>> TietThinh-NhanVien
    End Sub

    'Events:
    '
    'Form's Events
    '
    'Load: Occur when the form loads
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets Username/Password for txtID's and txtPW's text when form loads.
        txtID.Text = "Username"
        txtPW.Text = "Password"

        'Sets font for these text.
        txtID.Font = New Font(txtID.Font, FontStyle.Italic)
        txtPW.Font = New Font(txtPW.Font, FontStyle.Italic)

        'Sets check null by true
        _IsPWNull = True
        _IsIDNull = True
    End Sub
    '
    'txtID's Events
    '
    'Enter: Occur when the txtID gets focused
    Private Sub txtID_Enter(sender As Object, e As EventArgs) Handles txtID.Enter
        'If txtID's text is null then clears text and changes font, sets _IsIDNull by false
        'then adds event TextChanged for txtID
        'else sets lblClearID's text by x
        If _IsIDNull = True Then
            txtID.Text = ""
            txtID.Font = New Font(txtID.Font, FontStyle.Regular)
            _IsIDNull = False
            AddHandler txtID.TextChanged, AddressOf txtID_TextChanged
        Else
            lblClearID.Text = "x"
        End If
    End Sub
    '
    'Leave: Occur when the txtID loses focused
    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        'If txtID's text is null then sets text by Username, __IsIDNull by true and changes font
        'then removes event TextChanged from txtID
        'Finally clears lblClearID's text
        If txtID.Text = "" Then
            RemoveHandler txtID.TextChanged, AddressOf txtID_TextChanged
            _IsIDNull = True
            txtID.Text = "Username"
            txtID.Font = New Font(txtID.Font, FontStyle.Italic)
        End If
        lblClearID.Text = ""
    End Sub
    '
    'TextChanged: Occur when txtID's text changes
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)
        'When clears all text in this textbox lblClearID's text is null
        'else lblClearID's text is x
        If txtID.Text = "" Then
            lblClearID.Text = ""
        Else
            lblClearID.Text = "x"
        End If
    End Sub
    '
    'txtPW's Events
    '
    'Enter: Occur when the txtPW gets focused
    Private Sub txtPW_Enter(sender As Object, e As EventArgs) Handles txtPW.Enter
        'If txtPW is null then clears text and changes font, sets _IsPWNull by false
        'then adds event TextChanged for txtPW
        'else sets lblSeePW's Image by eye picture
        If _IsPWNull = True Then
            txtPW.Text = ""
            txtPW.UseSystemPasswordChar = True
            txtPW.Font = New Font(txtPW.Font, FontStyle.Regular)
            _IsPWNull = False
            AddHandler txtPW.TextChanged, AddressOf txtPW_TextChanged
        Else
            lblSeePW.Image = My.Resources.eye
        End If
    End Sub
    '
    'Leave: Occur when the txtPW loses focused
    Private Sub txtPW_Leave(sender As Object, e As EventArgs) Handles txtPW.Leave
        'If txtPW's text is null then sets text by Password, _IsPWNull by true and changes font
        'then removes event TextChanged from txtPW
        'Finally clears lblSeePW's Image
        If txtPW.Text = "" Then
            RemoveHandler txtPW.TextChanged, AddressOf txtPW_TextChanged
            _IsPWNull = True
            txtPW.UseSystemPasswordChar = False
            txtPW.Font = New Font(txtPW.Font, FontStyle.Italic)
            txtPW.Text = "Password"
        End If
        lblSeePW.Image = Nothing
    End Sub
    '
    'TextChanged: Occur when txtPW's text changes
    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs)
        'If clears all text in this textbox lblSeePW's image is null
        'else lblSeePW's image is eye picture
        If txtPW.Text = "" Then
            lblSeePW.Image = Nothing
        Else
            lblSeePW.Image = My.Resources.eye
        End If
    End Sub
    '
    'btnLogin's Events
    '
    'Click: Occur when the btnLogin is clicked
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim notice As String = ""

        If db.CheckInvalidAccount(txtID.Text, txtPW.Text, _FormID, DatabaseConnection._User, notice) Then
            MessageBox.Show(notice, "", MessageBoxButtons.OK)

            db.Dispose()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show(notice, "", MessageBoxButtons.OK)
        End If
    End Sub
    '
    'lblClearID/lblSeePW's Events
    '
    'MouseHover: Occur when the poiter overs the lblClearID/lblSeePW
    Private Sub label_MouseHover(sender As Object, e As EventArgs) Handles lblSeePW.MouseHover, lblClearID.MouseHover
        'If lblClearID's text is not null or lblSeePW's image is not null
        'then changes the background color of these label whenever the pointer overs them
        Dim this As Label = CType(sender, Label)
        If this.Text <> "" Or this.Image IsNot Nothing Then
            this.BackColor = Color.LightGray
        End If
    End Sub
    '
    'MouseLeave: Occur when the pointer leaves the lblClearID/lblSeePW
    Private Sub label_MouseLeave(sender As Object, e As EventArgs) Handles lblSeePW.MouseLeave, lblClearID.MouseLeave
        'Sets these label's background color to default color
        CType(sender, Label).BackColor = SystemColors.Window
    End Sub
    '
    'lblClearID's Events
    '
    'Click: Occur when lblClearID is clicked
    Private Sub lblClearID_Click(sender As Object, e As EventArgs) Handles lblClearID.Click
        'If lblClearID's text is nothing then txtID get focused
        'else txtID's text and lblClearID's text are null
        If lblClearID.Text = "" Then
            txtID.Focus()
        Else
            txtID.Text = ""
            lblClearID.Text = ""
        End If
    End Sub
    '
    'lblSeePW's Events
    '
    'MouseDown: Occur when click lblSeePW
    Private Sub lblSeePW_MouseDown(sender As Object, e As MouseEventArgs) Handles lblSeePW.MouseDown
        'Show the text in this textbox
        txtPW.UseSystemPasswordChar = False
    End Sub
    '
    'MouseCaptureChanged: Occur when lblSeePW is no longer clicked
    Private Sub lblSeePW_MouseCaptureChanged(sender As Object, e As EventArgs) Handles lblSeePW.MouseCaptureChanged
        'Hide the text in this textbox
        txtPW.UseSystemPasswordChar = True
    End Sub
    '
    'Click: Occur when lblSeePW is clicked
    Private Sub lblSeePW_Click(sender As Object, e As EventArgs) Handles lblSeePW.Click
        'If lblSeePW's image is null then txtPW gets focused
        If lblSeePW.Image Is Nothing Then
            txtPW.Focus()
        End If
    End Sub
    '
    'btnCancel's Events
    '
    'Click: Occur when btnCancel is clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Sets this form's dialog by Dialog Cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        db.Dispose()
        db = Nothing
    End Sub
    '
    'txtSubID's Events
    '
    'Click: Occur when txtSubID is clicked
    Private Sub txtSubID_Click(sender As Object, e As EventArgs) Handles txtSubID.Click
        'Focus the txtID
        txtID.Focus()
    End Sub
    '
    'txtSubPW's Events
    '
    'Click: Occur when txtSubPW is clicked
    Private Sub txtSubPW_Click(sender As Object, e As EventArgs) Handles txtSubPW.Click
        'Focus txtPW
        txtPW.Focus()
    End Sub
End Class