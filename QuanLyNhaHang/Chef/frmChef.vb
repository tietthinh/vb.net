'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Form Chef
'=====================================================================

Imports Library

Public Class frmChef

    Dim db As New DatabaseConnection()
    Dim orderList As DataTable
    Dim exceptionList As DataTable
    Dim cantServeList As DataTable
    Dim materialList As DataTable

    Private Sub frmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class