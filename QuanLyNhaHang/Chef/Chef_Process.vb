'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Module provides some processes for Form Chef
'=====================================================================

Imports Library
Imports System.Data.SqlClient

Module Chef_Process
    ''' <summary>
    ''' Object connects/queries database. 
    ''' </summary>
    ''' <remarks>The object is used to query database.</remarks>
    Public db As New DatabaseConnection()

    ''' <summary>
    ''' Clears background color of rows in list view.
    ''' </summary>
    ''' <param name="listItem">List of items has background color.</param>
    ''' <param name="listView">List view contains these list items.</param>
    ''' <remarks></remarks>
    Public Sub ClearListViewItemBackColor(ByRef listItem As List(Of ListViewItem), ByRef listView As ListView)
        For i As Integer = 0 To listItem.Count - 1 Step 1
            listItem(i).BackColor = SystemColors.Window
            listItem.RemoveAt(i)
        Next
    End Sub

    ''' <summary>
    ''' Loads list material from Database into DataTable through list of transfer identities.
    ''' </summary>
    ''' <param name="_TransIDList">List of Transfer Identities.</param>
    ''' <returns>A table containts list of material matching the Identities.</returns>
    ''' <remarks></remarks>
    Public Function LoadOrder(ByVal _TransIDList As List(Of String)) As DataTable
        Dim parameter() As SqlClient.SqlParameter = db.CreateParameter(New String() {"@MaChuyen"}, _TransIDList.ToArray())
        Dim orderList As DataTable

        Try
            orderList = db.Query("spDSDatMonTrongNgaySelect", parameter)
        Catch ex As SqlException
            Throw ex
        End Try

        Return orderList
    End Function

    ''' <summary>
    ''' Binds data from DataTable into a Ordered ListView.
    ''' </summary>
    ''' <param name="destinationListView">Ordered ListView needs to be binded.</param>
    ''' <param name="sourceDataTable">DataTable is used to bind.</param>
    ''' <param name="columnsName">Name of all columns for ListView</param>
    ''' <remarks></remarks>
    Public Sub BindIntoOrderedListView(ByRef destinationListView As ListView, ByVal sourceDataTable As DataTable, _
                                        ByVal columnsName() As String)
        Dim index As Integer = 1
        For Each row As DataRow In sourceDataTable.Rows
            Dim item As New ListViewItem(index)

            item.SubItems(0).Name = "STT"

            For i As Integer = 0 To columnsName.Length - 1 Step 1
                item.SubItems.Add(row(columnsName(i)).ToString())
                item.SubItems(i + 1).Name = columnsName(i)
            Next

            destinationListView.Items.Add(item)
            index += 1
        Next
    End Sub

    ''' <summary>
    ''' Binds data from DataTable into ListView.
    ''' </summary>
    ''' <param name="destinationListView">ListView needs to be binded.</param>
    ''' <param name="sourceDataTable">DataTable is used to bind.</param>
    ''' <remarks></remarks>
    Public Sub BindIntoListView(ByRef destinationListView As ListView, sourceDataTable As DataTable)
        Dim columnsName() As String = GetAllColumnsName(sourceDataTable)

        destinationListView.Items.Clear()

        For Each row As DataRow In sourceDataTable.Rows
            Dim item As New ListViewItem(row(0).ToString())

            item.SubItems(0).Name = columnsName(0)

            For i As Integer = 1 To columnsName.Length - 1 Step 1
                item.SubItems.Add(row(columnsName(i)).ToString())
                item.SubItems(i).Name = columnsName(i)
            Next

            destinationListView.Items.Add(item)
        Next
    End Sub

    ''' <summary>
    ''' Loads list material from Database into DataTable.
    ''' </summary>
    ''' <param name="_DishID">Identity of Dish in Database.</param>
    ''' <returns>A table containts list of material matching the Identity.</returns>
    ''' <remarks></remarks>
    Public Function LoadMaterial(ByVal _DishID As Object) As DataTable
        Dim materialList As DataTable

        Try
            materialList = db.Query("spCTLamMonSelect", db.CreateParameter(New String() {"@MaMon"}, New Object() {_DishID}))
        Catch ex As SqlException
            Throw ex
        End Try

        Return materialList
    End Function

    ''' <summary>
    ''' Gets all name of columns of DataTable.
    ''' </summary>
    ''' <param name="sourceDataTable">DataTable needs to get columns' name.</param>
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
    ''' Adds total quantity for DataTable.
    ''' </summary>
    ''' <param name="sourceDataTable">Datatable supplies data.</param>
    ''' <param name="listRowName">All name of rows for new DataTable.</param>
    ''' <param name="totalQuantity">The total quantity for each row.</param>
    ''' <returns>A clone of source DataTable with total quantity in each row.</returns>
    ''' <remarks></remarks>
    Public Function AddTotalQuantity(ByVal sourceDataTable As DataTable, ByVal listRowName() As String, ByVal totalQuantity As Integer) As DataTable
        Dim destinationDataTable As New DataTable()

        For i As Integer = 0 To listRowName.Length - 1 Step 1
            destinationDataTable.Columns.Add(listRowName(i))
        Next

        Dim index As Integer = 0

        For Each row As DataRow In sourceDataTable.Rows
            Dim mlRow As DataRow = destinationDataTable.NewRow()
            mlRow(listRowName(0)) = row(listRowName(0))
            mlRow(listRowName(1)) = row(listRowName(1)) * totalQuantity
            mlRow(listRowName(2)) = row(listRowName(1))

            destinationDataTable.Rows.Add(mlRow)
        Next

        Return destinationDataTable
    End Function

    ''' <summary>
    ''' Appends data from a DataTable to other DataTable.
    ''' </summary>
    ''' <param name="destinationDataTable">DataTable needs to be appended.</param>
    ''' <param name="sourceDataTable">DataTable is used to append.</param>
    ''' <remarks></remarks>
    Public Sub AppendAllRowsDataTable(ByRef destinationDataTable As DataTable, ByVal sourceDataTable As DataTable)
        For Each row As DataRow In sourceDataTable.Rows
            Dim tRow As DataRow = destinationDataTable.NewRow()

            For index As Integer = 0 To sourceDataTable.Columns.Count - 1 Step 1
                tRow(index) = row(index)
            Next

            destinationDataTable.Rows.Add(tRow)
        Next
    End Sub

    Public Function GetCantServeList(ByVal sourceDataGridView As DataGridView, ByVal dishQuantity As Integer) As DataTable
        Dim cantServeList As DataTable = DirectCast(sourceDataGridView.DataSource, DataTable).Clone()
        Dim index As Integer = sourceDataGridView.SelectedRows.Count - 1

        While dishQuantity > 0
            Dim row As DataRow = cantServeList.NewRow()


        End While

        Return cantServeList
    End Function

End Module
