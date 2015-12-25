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
    ''' Structure constains two parameters for query database.
    ''' </summary>
    ''' <remarks></remarks>
    Public Structure TransferDetail
        Public TransID As String
        Public Quantity As Integer
        Private RealQuantity As Integer

        Public Sub Add(ByVal transID As String, ByVal quantity As Integer)
            Me.TransID = transID
            Me.Quantity = quantity
            Me.RealQuantity = quantity
        End Sub

        Public Sub UpdateRealQuantity(ByVal quantity As Integer)
            RealQuantity = quantity
        End Sub

        Public Function GetRealQuantity() As Integer
            Return RealQuantity
        End Function

        Public Sub Dispose()
            Me.Dispose()
        End Sub
    End Structure

    Public Class DishDetail
        Private _DishID As String
        Private _TotalQuantity As Integer = 0
        Private _TransDetail() As TransferDetail

        Public Property DishID As String
            Get
                Return _DishID
            End Get
            Set(value As String)
                _DishID = value
            End Set
        End Property
        Public Property TotalQuantity As Integer
            Get
                Return _TotalQuantity
            End Get
            Set(value As Integer)
                _TotalQuantity = value
            End Set
        End Property
        Public Property TransDetail As TransferDetail()
            Get
                Return _TransDetail
            End Get
            Set(value As TransferDetail())
                _TransDetail = value
            End Set
        End Property

        Public Sub Add(ByVal dishID As String, ByVal transID As String, ByVal quantity As Integer)
            _DishID = dishID
            _TotalQuantity += quantity

            ReDim _TransDetail(_TransDetail.Length)

            _TransDetail(_TransDetail.Length - 1).Add(transID, quantity)
        End Sub

        Public Function Subtract(ByVal quantity As Integer) As TransferDetail()
            If _TransDetail.Length > 0 Then
                Dim _TransferDetail(-1) As TransferDetail
                Dim i As Integer = 0

                While quantity > 0
                    Dim value As Integer = Me._TransDetail(i).Quantity

                    If value > quantity Then
                        Me._TransDetail(i).Quantity -= quantity
                        quantity = 0
                    Else
                        ReDim _TransferDetail(_TransferDetail.Length)

                        _TransferDetail(_TransferDetail.Length - 1).TransID = Me._TransDetail(i).TransID
                        _TransferDetail(_TransferDetail.Length - 1).Quantity = Me._TransDetail(i).Quantity

                        quantity -= value
                    End If
                End While

                If _TransferDetail.Length > 0 Then
                    Return _TransferDetail
                Else
                    Return Nothing
                End If
            End If

            Return Nothing
        End Function

        Public Sub Dispose()
            For i As Integer = _TransDetail.Length - 1 To 0 Step -1
                _TransDetail(i).Dispose()
            Next

            Me.Dispose()
        End Sub
    End Class

    ''' <summary>
    ''' Clears background color of rows in DataGridView.
    ''' </summary>
    ''' <param name="listRow">List of rows has background color.</param>
    ''' <param name="sourceDataGridView">DataGridView contains these list rows.</param>
    ''' <remarks></remarks>
    Public Sub ClearListViewItemBackColor(ByRef listRow As List(Of DataGridViewRow), ByRef sourceDataGridView As DataGridView)
        For i As Integer = listRow.Count - 1 To 0 Step -1
            listRow(i).DefaultCellStyle.BackColor = SystemColors.Window
            listRow.RemoveAt(i)
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
    ''' Binds data from DataTable into a Ordered DataGridView.
    ''' </summary>
    ''' <param name="destinationDataGridView">Ordered DataGridView needs to be binded.</param>
    ''' <param name="sourceDataTable">DataTable is used to bind.</param>
    ''' <remarks></remarks>
    Public Sub BindIntoOrderedDataGridView(ByRef destinationDataGridView As DataGridView, ByVal sourceDataTable As DataTable)
        destinationDataGridView.DataSource = sourceDataTable

        Dim index As Integer = 1

        For Each row As DataGridViewRow In destinationDataGridView.Rows
            row.Cells("Ordered").Value = index

            index += 1
        Next

        destinationDataGridView.ClearSelection()
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
    Public Sub AppendDataTable(ByRef destinationDataTable As DataTable, ByVal sourceDataTable As DataTable)
        For Each row As DataRow In sourceDataTable.Rows
            Dim tRow As DataRow = destinationDataTable.NewRow()

            For index As Integer = 0 To sourceDataTable.Columns.Count - 1 Step 1
                tRow(index) = row(index)
            Next

            destinationDataTable.Rows.Add(tRow)
        Next
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sourceDataGridView"></param>
    ''' <param name="dishQuantity"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetCantServeList(ByRef sourceDataGridView As DataGridView, ByVal dishQuantity As Integer) As DataTable
        Dim cantServeList As DataTable = DirectCast(sourceDataGridView.DataSource, DataTable).Clone()
        Dim index As Integer = sourceDataGridView.SelectedRows.Count - 1

        While dishQuantity > 0
            Dim row As DataRow = cantServeList.NewRow()


        End While

        Return cantServeList
    End Function

End Module
