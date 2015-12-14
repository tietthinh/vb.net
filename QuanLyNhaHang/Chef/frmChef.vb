'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library

Public Class frmChef

    Dim db As New DatabaseConnection()
    Dim orderList As DataTable
    Dim cookList As DataTable
    Dim cantServeList As DataTable
    Dim materialList As DataTable

    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parameter As SqlClient.SqlParameter = New SqlClient.SqlParameter("@ThoiGian", SqlDbType.Char, 10, "TimeOrder")
        parameter.Value = 
        Try
            db.Open()
            db.Query("spDSDatMonTrongNgaySelect", parameter)
        Catch ex As Exception

        End Try
    End Sub
End Class