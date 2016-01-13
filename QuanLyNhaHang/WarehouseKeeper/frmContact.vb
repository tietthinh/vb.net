'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form for adding supplier's email that auto creates textbox
'           while pressing Tab key
'=====================================================================

Public Class frmContact

    'Fieds:
    '
    ''' <summary>
    ''' The current number of textboxs in this form.
    ''' </summary>
    ''' <remarks></remarks>
    Dim textBoxCount As Integer

    ''' <summary>
    ''' List of objects that return for other form. 
    ''' </summary>
    ''' <remarks></remarks>
    Public _ListObject(-1) As String

    'Properties:
    '
    ''' <summary>
    ''' Supplier's name to display in this form.
    ''' </summary>
    ''' <remarks></remarks>
    Public _SupplierName As String

    'Methods:
    '
    ''' <summary>
    ''' Change the original function of some Key.
    ''' </summary>
    ''' <param name="msg">Windows Message.</param>
    ''' <param name="keyData">Key pressed.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Tab Then
            For Each control As Control In Me.pnlContainer.Controls
                If control.Focused = True Then
                    AddTextBox()
                End If
            Next
            Return MyBase.ProcessCmdKey(msg, keyData)
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ''' <summary>
    ''' Create a textbox base on array of parameters.
    ''' </summary>
    ''' <param name="name">Name of textbox.</param>
    ''' <param name="x">X Coordinate.</param>
    ''' <param name="y">Y Coordinate.</param>
    ''' <param name="text">The default text for textbox.</param>
    ''' <returns>A textbox with name, coordinates and default text.</returns>
    ''' <remarks></remarks>
    Private Function CreateTextbox(ByVal name As String, ByVal x As Integer, ByVal y As Integer, ByVal text As String) As TextBox
        Dim textBox As New TextBox()
        textBox.Name = name
        textBox.Size = New Size(200, 27)
        textBox.Font = New Font("Roboto Condensed", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        textBox.Location = New Point(x, y)
        textBox.Enabled = True
        textBox.Visible = True
        textBox.Text = text
        Me.pnlContainer.Controls.Add(textBox)
        Return textBox
    End Function

    ''' <summary>
    ''' Add a textbox into this form.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddTextBox()
        Dim text As TextBox
        Dim x As Integer, y As Integer

        Me.pnlContainer.AutoSize = False
        x = Me.pnlContainer.Controls(textBoxCount - 1).Location.X
        y = Me.pnlContainer.Controls(textBoxCount - 1).Location.Y + _
            Me.pnlContainer.Controls(textBoxCount - 1).Height + 2
        text = Me.CreateTextbox("txtObject_" + (textBoxCount - 1).ToString(), x, y, "")
        textBoxCount += 1
    End Sub

    'Events:
    '
    'Form's events:
    '
    'Load: Occur when this form load
    '
    Private Sub frmLienLac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Change position of btnDone into center.
        Me.btnDone.Left = (Me.ClientSize.Width - Me.btnDone.Size.Width) / 2

        Me.lblSupplier.Text = _SupplierName
        'Sets textBoxCount by the current number of textbox in pnlContainer.
        textBoxCount = Me.pnlContainer.Controls.Count

        'Add event SizeChanged for pnlContainer.
        AddHandler Me.pnlContainer.SizeChanged, AddressOf pnlContainer_SizeChanged
    End Sub
    '
    'lblSupplier's events:
    '
    'SizeChanged: Occur when lblSupplier changed size
    '
    Private Sub lblSupplier_SizeChanged(sender As Object, e As EventArgs) Handles lblSupplier.SizeChanged
        'Change position of lblSupplier into center.
        Me.lblSupplier.Left = (Me.ClientSize.Width - Me.lblSupplier.Size.Width) / 2
    End Sub
    '
    'pnlContainer's events:
    '
    'ControlAdded: Occur when pnlContainer has a new control
    '
    Private Sub pnlContainer_ControlAdded(sender As Object, e As ControlEventArgs) Handles pnlContainer.ControlAdded
        'If the current number of textboxs is greater or equal than 5 then sets AutoScroll for pnlContainer
        'else increases size for pnlContainer.
        If textBoxCount >= 5 Then
            Me.pnlContainer.AutoScroll = True
        Else
            Me.pnlContainer.Size = New Size(Me.pnlContainer.Size.Width, Me.pnlContainer.Size.Height + _
                                            Me.pnlContainer.Controls(0).Height + 2)
        End If
    End Sub
    '
    'SizeChanged: Occur when pnlContainer changed size
    '
    Private Sub pnlContainer_SizeChanged(sender As Object, e As EventArgs)
        'Finds the btnDone in this form and gets this button's index.
        Dim x = Me.Controls.IndexOf(Me.Controls.Find("btnDone", True)(0))
        'Changes position of this button.
        Me.Controls(x).Location = New Point(Me.Controls(x).Location.X, Me.Controls(x).Location.Y + _
                                            Me.pnlContainer.Controls(0).Size.Height)

        'If the current number of textboxs is greater or equal 4 then removes this event for pnlContainer.
        If textBoxCount >= 4 Then
            RemoveHandler Me.pnlContainer.SizeChanged, AddressOf pnlContainer_SizeChanged
        End If
    End Sub
    '
    'btnDone's Events:
    '
    'Click: Occur when btnDone is Clicked
    '
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        For Each Control As Control In Me.pnlContainer.Controls
            If (Control.Name.Contains("txtObject_")) Then
                Dim i As Integer = _ListObject.Length

                Array.Resize(_ListObject, _ListObject.Length + 1)

                _ListObject(i) = Control.Text
            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class