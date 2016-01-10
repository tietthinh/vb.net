Imports Library
Imports Manager
Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Imports System.Globalization
Imports System.Exception
Imports Microsoft.Reporting.WinForms

Public Class rptThongKe

    Dim _Dt As DataTable
    Dim _DataReportViwe As QuanLyNhaHang
    Public Sub New(ByVal _DataTable As DataTable)
        InitializeComponent()
        _Dt = _DataTable
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _DataAccess As New DatabaseConnection()

        Dim _Data As DataTable = _Dt
        Me.ReportViewer1.RefreshReport()

        '_DataReportViwe.Tables("ThongKe").Rows.Clear()
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaHang.Report1.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Dim _NewDt As New ReportDataSource("MonHT", _Data)
        Me.ReportViewer1.LocalReport.DataSources.Add(_NewDt)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class