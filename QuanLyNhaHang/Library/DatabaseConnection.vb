﻿'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Library provides a connected object to connect database
'=====================================================================

Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Data.Common

Public Class DatabaseConnection
    ''' <summary>
    ''' Connecter for connecting to Sql Server.
    ''' </summary>
    ''' <remarks></remarks>
    Private _Connecter As New SqlConnection()

    ''' <summary>
    ''' Address of Database in Sql Server.
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared _Address As ConnectionStringSettings = _
        ConfigurationManager.ConnectionStrings("Restaurant Management")

    ''' <summary>
    ''' Gets or Sets the current connecter of Library.DatabaseConnection.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Connecter() As SqlConnection
        Get
            Return _Connecter
        End Get
        Set(value As SqlConnection)
            _Connecter = value
        End Set
    End Property

    ''' <summary>
    ''' Sets Database's address for Connecter.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _Connecter.ConnectionString = _Address.ConnectionString
    End Sub

    ''' <summary>
    ''' Open the current connection to Database. 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Open()
        Try
            _Connecter.Open()
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Close the current connection to Database.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Close()
        Try
            _Connecter.Close()
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Gets data from Database throught _Query.
    ''' </summary>
    ''' <param name="_Query">Query command for getting data. Default query command gets Account information.</param>
    ''' <returns>A table in Database with data match the query command.</returns>
    ''' <remarks></remarks>
    Public Function Query(ByVal _Query As String) As DataTable
        ' = "Select TenDN, MatKhau From TaiKhoanNhanVien"
        Dim result As New DataTable()
        Dim cmd As New SqlCommand(_Query, Connecter)
        Dim adt As New SqlDataAdapter(cmd)

        Try
            adt.Fill(result)
            Return result
        Catch ex As SqlException
            result.Dispose()
            result = Nothing
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            adt.Dispose()
            adt = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Gets data from Database throught _Query and list of parameters.
    ''' </summary>
    ''' <param name="_Query">Query command for execute Stored Procedure.</param>
    ''' <param name="parameter">List of parameters matching Stored Procedure's paremeters.</param>
    ''' <returns>A table in Database with data match the query command.</returns>
    ''' <remarks></remarks>
    Public Function Query(ByVal _Query As String, ByVal ParamArray parameter() As SqlParameter) As DataTable
        Dim result As New DataTable()
        Dim cmd As SqlCommand = _Connecter.CreateCommand()
        cmd.CommandText = _Query
        cmd.CommandType = CommandType.StoredProcedure

        If parameter IsNot Nothing And parameter.Length > 0 Then
            cmd.Parameters.AddRange(parameter)
        End If

        Dim adt As New SqlDataAdapter(cmd)

        Try
            adt.Fill(result)
            Return result
        Catch ex As SqlException
            result.Dispose()
            result = Nothing
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            adt.Dispose()
            adt = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Gets data from Database throught _Query and list of parameters.
    ''' </summary>
    ''' <param name="_Query">Query command for execute Stored Procedure.</param>
    ''' <param name="outParameter">List of output parameters from Stored Procedure.</param>
    ''' <param name="parameter">List of parameters matching Stored Procedure's paremeters.</param>
    ''' <returns>A table in Database with data match the query command.</returns>
    ''' <remarks></remarks>
    Public Function Query(ByVal _Query As String, ByRef outParameter() As SqlParameter, ByVal ParamArray parameter() As SqlParameter) As DataTable
        Dim result As New DataTable()
        Dim cmd As SqlCommand = _Connecter.CreateCommand()
        cmd.CommandText = _Query
        cmd.CommandType = CommandType.StoredProcedure

        If outParameter.Length > 0 Then
            For i As Integer = 0 To outParameter.Length - 1 Step 1
                outParameter(i).Direction = ParameterDirection.Output
            Next
        End If

        If parameter IsNot Nothing And parameter.Length > 0 Then
            cmd.Parameters.AddRange(parameter)
            cmd.Parameters.AddRange(outParameter)
        End If

        Dim adt As New SqlDataAdapter(cmd)

        Try
            adt.Fill(result)
            Return result
        Catch ex As SqlException
            result.Dispose()
            result = Nothing
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            adt.Dispose()
            adt = Nothing
        End Try
    End Function

    ''' <summary>
    ''' Insert/Delete/Update Database through Stored Procedure with _Query and list of parameters.
    ''' </summary>
    ''' <param name="_Query">Command for executing Stored Procedure.</param>
    ''' <param name="Parameter">List of parameters matching Stored Procedure's parameters.</param>
    ''' <returns>The number of inserted/deleted/updated rows.</returns>
    ''' <remarks></remarks>
    Public Function Update(ByVal _Query As String, ByVal ParamArray parameter() As SqlParameter) As Integer
        Dim cmd As SqlCommand = _Connecter.CreateCommand()
        Dim rowCount As Integer

        cmd.CommandText = _Query
        cmd.CommandType = CommandType.StoredProcedure

        If parameter IsNot Nothing And parameter.Length > 0 Then
            cmd.Parameters.AddRange(parameter)
        End If

        Try
            rowCount = cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
        End Try

        Return rowCount
    End Function

    ''' <summary>
    ''' Insert/Delete/Update Database from DataTable into Table in Database.
    ''' </summary>
    ''' <param name="table">Inserted/Deleted/Updated Data.</param>
    ''' <param name="tableName">Name of Table in Database.</param>
    ''' <remarks></remarks>
    Public Sub Update(ByVal table As DataTable, ByVal tableName As String)
        Dim cmd As New SqlCommand()
        Dim adt As New SqlDataAdapter()
        cmd.Connection = _Connecter
        cmd.CommandText = "Select * From " + tableName
        adt.SelectCommand = cmd
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adt)

        Try
            adt.Update(table)
        Catch ex As SqlException
            Throw ex
        Finally
            cmd.Dispose()
            adt.Dispose()
            builder.Dispose()
            cmd = Nothing
            adt = Nothing
            builder = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Create a list of parameters for Query command.
    ''' </summary>
    ''' <param name="listParameterName">List of parameters' name.</param>
    ''' <param name="listParameterValue">List of parameters' value.</param>
    ''' <returns>List of parameters.</returns>
    ''' <remarks></remarks>
    Public Function CreateParameter(ByVal listParameterName() As String, ByVal listParameterValue() As Object) As SqlParameter()
        Dim parameter(listParameterName.Length - 1) As SqlClient.SqlParameter
        For i As Integer = 0 To parameter.Length - 1 Step 1
            parameter(i) = New SqlParameter(listParameterName(i), listParameterValue(i))
        Next
        Return parameter
    End Function

    ''' <summary>
    ''' Check employee's information in form.
    ''' </summary>
    ''' <param name="username">Employee's Username.</param>
    ''' <param name="password">Employee's Password</param>
    ''' <param name="confirmPassword">Confirm password.</param>
    ''' <param name="birthday">Employee's Birthday.</param>
    ''' <returns>Error code.</returns>
    ''' <remarks>
    ''' -1 is no error. 1 is Username already existed. 2 is Confirm Password doesn't match Password.
    ''' 3 is birthday is greater than today.
    ''' </remarks>
    Public Function CheckInfor(ByVal username As String, ByVal password As String, ByVal confirmPassword As String, _
                               ByVal birthday As DateTime) As Integer
        Dim accountList As New DataTable()

        Try
            Open()
            accountList = Query("Select TenDN, MatKhau From TaiKhoanNhanVien")
        Catch ex As SqlException
            accountList.Dispose()
            accountList = Nothing
            Throw ex
        Finally
            Close()
        End Try

        For Each row As DataRow In accountList.Rows
            If username = row("TenDN") Then
                accountList.Dispose()
                accountList = Nothing
                Return 1
            End If
        Next

        If (confirmPassword <> password) Then
            accountList.Dispose()
            accountList = Nothing
            Return 2
        End If

        If (birthday > Now) Then
            accountList.Dispose()
            accountList = Nothing
            Return 3
        End If

        accountList.Dispose()
        accountList = Nothing
        Return -1
    End Function


    ''' <summary>
    ''' Check invalid account's information in Database.
    ''' </summary>
    ''' <param name="username">Employee's Username.</param>
    ''' <param name="password">Employee's Password.</param>
    ''' <returns>True if match, else false.</returns>
    ''' <remarks></remarks>
    Public Function CheckInvalidAccount(ByVal username As String, ByVal password As String, _
                                        ByRef user As User) As Boolean
        Dim accountList As New DataTable()

        Try
            Open()
            accountList = Query("Select TKNV.TenDN, TKNV.MatKhau, NV.cmnd, NV.MaNV, NV.HoTen " + _
                                "From TaiKhoanNhanVien TKNV, NhanVien NV " + _
                                "Where NV.MaNV = TKNV.MaNV")
        Catch ex As SqlException
            Throw ex
        Finally
            Close()
        End Try

        For Each row As DataRow In accountList.Rows
            If username = row("TenDN") And GetMd5Hash(password, row("cmnd").ToString().Trim()) = row("MatKhau") Then
                user = New User(row("MaNV"), row("HoTen"))
                accountList.Dispose()
                accountList = Nothing
                Return True
            End If
        Next

        accountList.Dispose()
        accountList = Nothing
        user = Nothing
        Return False
    End Function

    ''' <summary>
    ''' Release memory of DatabaseConnection.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Dispose()
        _Connecter.Dispose()
        _Connecter = Nothing
    End Sub

End Class
