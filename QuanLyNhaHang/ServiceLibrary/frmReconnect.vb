Imports System.Timers

Public Class frmReconnect
    Private Sub frmReconnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Countdown.Start()
    End Sub
    Private Sub Timer_Done(sender As Object, e As EventArgs) Handles Countdown.Tick
        Threading.Thread.Sleep(2000)
        Close()
    End Sub
End Class