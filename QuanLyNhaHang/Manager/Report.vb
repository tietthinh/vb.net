Imports Library
Imports Manager
Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Imports System.Globalization
Imports System.Exception
Imports Microsoft.Reporting.WinForms
Public Class rptThongKe

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _DataAccess As New DatabaseConnection()
        Dim dt As Form = New frmManager()

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class