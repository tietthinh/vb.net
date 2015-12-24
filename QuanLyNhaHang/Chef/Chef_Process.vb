'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Module provides some processes for Form Chef
'=====================================================================

Imports Library
Imports System.Data.SqlClient

Module Chef_Process

    ''' <summary>
    ''' Clear background color of rows in list view.
    ''' </summary>
    ''' <param name="listItem">List of items which has background color.</param>
    ''' <param name="listView">List view contains these list items.</param>
    ''' <remarks></remarks>
    Public Sub ClearListViewItemBackColor(ByRef listItem As List(Of ListViewItem), ByRef listView As ListView)
        For i As Integer = 0 To listItem.Count - 1 Step 1
            listItem(i).BackColor = SystemColors.Window
            listItem.RemoveAt(i)
        Next
    End Sub

    Public Function LoadOrder(ByVal _TransIDList As List(Of String)) As DataTable

    End Function

    ''' <summary>
    ''' Load list material from Database into DataTable.
    ''' </summary>
    ''' <param name="_DishID">Identity of Dish in Database.</param>
    ''' <returns>A table containts list of material matching the Identity.</returns>
    ''' <remarks></remarks>
    Public Function LoadMaterial(ByVal _DishID As Object) As DataTable
        Dim db As New DatabaseConnection()
        Dim materialList As DataTable

        Try
            materialList = db.Query("spCTLamMonSelect", db.CreateParameter(New String() {"@MaMon"}, New Object() {_DishID}))
        Catch ex As SqlException
            Throw ex
        End Try

        db.Dispose()

        Return materialList
    End Function

    ''' <summary>
    ''' Gets all name of columns of DataTable.
    ''' </summary>
    ''' <param name="sourceDataTable">DataTable wanting to get columns' name.</param>
    ''' <returns>A array of string contains all columns' name.</returns>
    ''' <remarks></remarks>
    Public Function GetAllColumnsName(ByVal sourceDataTable As DataTable) As String()
        Dim listName(sourceDataTable.Columns.Count - 1) As String

        For index As Integer = 0 To listName.Length - 1 Step 1
            listName(index) = sourceDataTable.Columns(index).ColumnName
        Next

        Return listName
    End Function

    ''' <summary>
    ''' Clone a DataTable to other DataTable.
    ''' </summary>
    ''' <param name="sourceDataTable">Datatable wanting to clone.</param>
    ''' <param name="listRowName"></param>
    ''' <param name="totalQuantity"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CloneDataTable(ByVal sourceDataTable As DataTable, ByVal listRowName As String(), ByVal totalQuantity As Integer) As DataTable
        Dim destinationDataTable As New DataTable()

        For i As Integer = 0 To listRowName.Length - 1 Step 1
            destinationDataTable.Columns.Add(listRowName(i))
        Next

        Dim index As Integer = 0

        For Each row As DataRow In sourceDataTable.Rows
            Dim mlRow As DataRow = destinationDataTable.NewRow()
            mlRow(listRowName(0)) = row(listRowName(0))
            mlRow(listRowName(2)) = row(listRowName(1))
            mlRow(listRowName(1)) = row(listRowName(1)) * totalQuantity

            destinationDataTable.Rows.Add(mlRow)
        Next

        Return destinationDataTable
    End Function


End Module
