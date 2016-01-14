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
        If _Dt.Rows.Count > 0 Then
            Dim tableName As String = ""
            Dim reportName As String = ""

            Select Case _Dt.TableName
                Case "TK_MonHT"
                    tableName = "ThongKeMonAnHoanThanh"
                    reportName = "TK_MonHT"
                Case "TK_MonKHT"
                    tableName = "ThongKeMonAnKhongHoanThanh"
                    reportName = "TK_MonKHT"
                Case "TK_NL"
                    tableName = "ThongKeNguyenLieu"
                    reportName = "TK_NL"
                Case "TK_Khach_Ban"
                    tableName = "ThongKeKhachTheoBan"
                    reportName = "TK_Khach_Ban"
                Case "TK_Khach_NhanVien"
                    tableName = "ThongKeKhachTheoNhanVien"
                    reportName = "TK_Khach_NhanVien"
                Case "TK_Khach_Mon"
                    tableName = "ThongKeKhachTheoMon"
                    reportName = "TK_Khach_Mon"
                Case "TK_DoanhThu"
                    tableName = "ThongKeDoanhThu"
                    reportName = "TK_DoanhThu"
            End Select

            Dim dts As New DataSet("ThongKe")
            Dim data As New DataTable(tableName, "ThongKe")

            For i As Integer = 0 To _Dt.Columns.Count - 1 Step 1
                data.Columns.Add(_Dt.Columns(i).ToString().Trim())
            Next

            For Each row As DataRow In _Dt.Rows
                Dim dr As DataRow = data.NewRow()
                For i As Integer = 0 To row.ItemArray.Length - 1 Step 1
                    dr(i) = row(i).ToString().Trim()
                Next

                data.Rows.Add(dr)
            Next

            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Manager." & reportName & ".rdlc"
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Dim _NewDt As New ReportDataSource(tableName, _Dt)
            Me.ReportViewer1.LocalReport.DataSources.Add(_NewDt)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

End Class