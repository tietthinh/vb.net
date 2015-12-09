'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Numpad Form for Employee
'=====================================================================

Imports System.Windows.Forms.SendKeys
Imports System.Windows.Forms

Public Class frmNumPad

    'Fields:
    ''' <summary>
    ''' Last clicked Button.
    ''' </summary>
    ''' <remarks></remarks>
    Dim _SelectedButton As New Button()

    ''' <summary>
    ''' Maximum dish/material can be ordered/used.
    ''' </summary>
    ''' <remarks></remarks>
    Dim _MaxValue As Double = 1500

    ''' <summary>
    ''' Control receives value.
    ''' </summary>
    ''' <remarks></remarks>
    Public _Control As Control

    'Constructors:
    ''' <summary>
    ''' Constructor gets a control to set value into that control. 
    ''' </summary>
    ''' <param name="control">Control that receives value.</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef control As Control)
        Me.InitializeComponent()

        _Control = control
    End Sub

    'Events:
    '
    'Form's Event
    '
    'Load: Occur when the form loads
    '
    Private Sub NumPad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Remove border to prevent resize this form
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
    '
    'Button's Event
    '
    'Click: Occur when the button is clicked
    '
    Public Sub Button_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click,
             btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click,
             btnComma.Click, btnDot.Click
        _SelectedButton = CType(sender, Button)
        If _Control.Text = "" Or UShort.Parse(_Control.Text) <= _MaxValue Then
            _Control.Text += _SelectedButton.Text
        Else
            _Control.Text = _MaxValue.ToString()
        End If
    End Sub
End Class