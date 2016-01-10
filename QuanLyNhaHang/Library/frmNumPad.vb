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
    Dim _MaxValue As Double = 10000

    ''' <summary>
    ''' Enable dot button if true.
    ''' </summary>
    ''' <remarks></remarks>
    Dim _EnableDotButton As Boolean

    ''' <summary>
    ''' Control receives value from this form.
    ''' </summary>
    ''' <remarks></remarks>
    Private _Control As Control

    ''' <summary>
    ''' Value to receive dot value.
    ''' </summary>
    ''' <remarks></remarks>
    Private _TempValue As String = "0"

    'Constructors:
    ''' <summary>
    ''' Constructor gets a control to set value into that control. 
    ''' </summary>
    ''' <param name="control">Control's Property that receives value.</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef control As Control, Optional lock As Boolean = False)
        Me.InitializeComponent()

        _Control = control
        _EnableDotButton = lock
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

        btnDot.Enabled = _EnableDotButton
    End Sub
    '
    'Button's Event
    '
    'Click: Occur when the button is clicked
    '
    Public Sub Button_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, _
             btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDot.Click
        _SelectedButton = CType(sender, Button)

        Dim test As Double

        If _TempValue = "" Or (Double.TryParse(_TempValue, test) = True AndAlso test <= _MaxValue) Then
            _TempValue += _SelectedButton.Text
        ElseIf Double.TryParse(_TempValue, test) = True Then
            _TempValue = _MaxValue.ToString()
        Else
            _TempValue = _Control.Text
        End If
        _Control.Text = _TempValue
    End Sub
End Class