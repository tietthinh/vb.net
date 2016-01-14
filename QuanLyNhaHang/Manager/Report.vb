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
    Public Sub New(ByVal _DataTable As DataTable)
        InitializeComponent()
        _Dt = _DataTable
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dts As New DataSet("ThongKe")
        Dim data As New DataTable("ThongKeMonAnHoanThanh", "ThongKe")

        For i As Integer = 0 To _Dt.Columns.Count - 1 Step 1
            data.Columns.Add(_Dt.Columns(i).ToString())
        Next

        For Each row As DataRow In _Dt.Rows
            Dim dr As DataRow = data.NewRow()
            For i As Integer = 0 To row.ItemArray.Length - 1 Step 1
                dr(i) = row(i).ToString()
            Next

            data.Rows.Add(dr)
        Next

        '_DataReportViwe.Tables("ThongKe").Rows.Clear()
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Manager.Report1.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Dim _NewDt As New ReportDataSource("ThongKeMonAnHoanThanh", _Dt)
        Me.ReportViewer1.LocalReport.DataSources.Add(_NewDt)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class