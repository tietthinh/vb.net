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

        ''' <summary>
        ''' Sets value for transfer's identity and quantity.
        ''' </summary>
        ''' <param name="transID">Transfer's Identity.</param>
        ''' <param name="quantity">The number of dishes.</param>
        ''' <remarks></remarks>
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
    End Structure

    Public Class DishDetail
        Private _DishID As String
        Private _TotalQuantity As Integer = 0
        Private _TransDetail(-1) As TransferDetail

        ''' <summary>
        ''' Gets or Sets the current Dish's Identity
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DishID As String
            Get
                Return _DishID
            End Get
            Set(value As String)
                _DishID = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the current total quantity.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TotalQuantity As Integer
            Get
                Return _TotalQuantity
            End Get
            Set(value As Integer)
                _TotalQuantity = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the current transfer detail.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TransDetail As TransferDetail()
            Get
                Return _TransDetail
            End Get
            Set(value As TransferDetail())
                _TransDetail = value
            End Set
        End Property

        ''' <summary>
        ''' Add new element for _TransDetail.
        ''' </summary>
        ''' <param name="transID">Transfer's Identity.</param>
        ''' <param name="quantity">The number of dishes.</param>
        ''' <remarks></remarks>
        Public Sub Add(ByVal transID As String, ByVal quantity As Integer)
            _TotalQuantity += quantity

            Array.Resize(_TransDetail, _TransDetail.Length + 1)

            _TransDetail(_TransDetail.Length - 1).Add(transID, quantity)
        End Sub

        ''' <summary>
        ''' Add new element.
        ''' </summary>
        ''' <param name="dishID">Dish's Identity.</param>
        ''' <param name="transID">Transfer's Identity.</param>
        ''' <param name="quantity">The number of dishes.</param>
        ''' <remarks></remarks>
        Public Sub Add(ByVal dishID As String, ByVal transID As String, ByVal quantity As Integer)
            _DishID = dishID
            _TotalQuantity += quantity

            Array.Resize(_TransDetail, _TransDetail.Length + 1)

            _TransDetail(_TransDetail.Length - 1).Add(transID, quantity)
        End Sub

        ''' <summary>
        ''' Subtracts the number of dishes of first element in TransDetail.
        ''' </summary>
        ''' <param name="quantity">The number of dishes is done.</param>
        ''' <returns>A list of TransferDetail that is done.</returns>
        ''' <remarks></remarks>
        Public Function Subtract(ByVal quantity As Integer) As TransferDetail()
            If _TransDetail.Length > 0 Then
                Dim _TransferDetail(-1) As TransferDetail
                Dim i As Integer = 0

                'If quantity < first element's quantity then decreases the current quantity by quantity
                'If quantity >= first element's quantity then adds the first element into _TransferDetail
                'deletes the first element after that and repeats until quantity = 0
                While quantity > 0
                    Dim value As Integer = Me._TransDetail(i).Quantity

                    If value > quantity Then
                        'Decreases the current quantity
                        Me._TransDetail(i).Quantity -= quantity

                        quantity = 0
                    Else
                        Array.Resize(_TransferDetail, _TransferDetail.Length + 1)

                        'Clones data from first element of _TransDetail into _TrasferDetail
                        _TransferDetail(_TransferDetail.Length - 1).TransID = Me._TransDetail(i).TransID
                        _TransferDetail(_TransferDetail.Length - 1).Quantity = Me._TransDetail(i).Quantity

                        'Resize the _TransDetail to delete the current first element
                        Array.Copy(_TransDetail, 1, _TransDetail, 0, _TransDetail.Length - 1)
                        Array.Resize(_TransDetail, _TransDetail.Length - 1)

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

        ''' <summary>
        ''' Removes the dishes cannot serve.
        ''' </summary>
        ''' <param name="quantity">The number of dishes cannot serve.</param>
        ''' <remarks></remarks>
        Public Sub SubtractCantServe(ByVal quantity As Integer)
            If _TransDetail.Length > 0 Then
                While quantity > 0
                    Dim currentQuantity As Integer = _TransDetail(_TransDetail.Length - 1).Quantity - quantity

                    'If currentQuantity > 0, means the quantity cannot serve is greater than 
                    'the number of dishes of current row, then sets the number of dishes of current row by 0
                    'If currentQuantity <= 0, means the quantity cannot serve is less than equal
                    'the number of dishes of current row, then decreases the number of elements by 1 and sets quantity by 
                    'currentQuantity
                    If currentQuantity > 0 Then
                        _TransDetail(_TransDetail.Length - 1).Quantity = currentQuantity

                        _TotalQuantity -= quantity
                        quantity = 0
                    Else
                        _TotalQuantity -= _TransDetail(_TransDetail.Length - 1).Quantity

                        Array.Resize(_TransDetail, _TransDetail.Length - 1)

                        quantity = currentQuantity * -1
                    End If
                End While
            End If
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
        'Load data from source datatable onto destination DataGridView
        destinationDataGridView.DataSource = sourceDataTable

        Dim index As Integer = 1

        'Sets ordered for each row in destination DataGridView
        For Each row As DataGridViewRow In destinationDataGridView.Rows
            row.Cells("Ordered").Value = index

            index += 1
        Next

        'Clears all selected rows in destination DataGridView
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
        'Creates array listName has the elements equal the number of columns in source datatable
        Dim listName(sourceDataTable.Columns.Count - 1) As String

        'Sets value for each element in listName by each column's name in source datatable
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

        'Creates columns for destination datatable
        For i As Integer = 0 To listRowName.Length - 1 Step 1
            destinationDataTable.Columns.Add(listRowName(i))
        Next

        Dim index As Integer = 0

        'Clones data from source datatable into destination datatable
        For Each row As DataRow In sourceDataTable.Rows
            'Creates new row from destination datatable
            Dim mlRow As DataRow = destinationDataTable.NewRow()

            'Clones data from row in source datatable into the new row with a column contains total quantity value
            mlRow(listRowName(0)) = row(listRowName(0))
            'The column contains total quantity
            mlRow(listRowName(1)) = row(listRowName(1)) * totalQuantity
            mlRow(listRowName(2)) = row(listRowName(1))

            'Adds the new row into destination datatable
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
            'Creates new row from destination datatable
            Dim tRow As DataRow = destinationDataTable.NewRow()

            'Clones data from a row of source datatable into the new row
            For index As Integer = 0 To sourceDataTable.Columns.Count - 1 Step 1
                tRow(index) = row(index)
            Next

            'Adds the new row into destination datatable
            destinationDataTable.Rows.Add(tRow)
        Next
    End Sub

    ''' <summary>
    ''' Groups all records with similar name in DataTable.
    ''' </summary>
    ''' <param name="sourceDataTable">DataTable contains dish list.</param>
    ''' <remarks></remarks>
    Public Sub GroupDish(ByRef sourceDataTable As DataTable)
        For i As Integer = sourceDataTable.Rows.Count - 1 To 1 Step -1
            For j As Integer = i - 1 To 0 Step -1
                'If the row at i has the name similar to the row at j 
                'then increases the quantity at row j equal the quantity of row at i
                'Deletes the row at i and end loop after that
                If sourceDataTable.Rows(i)("TenMon") = sourceDataTable(j)("TenMon") Then
                    'Increases the quantity at row j equal the quantity of row at i
                    sourceDataTable.Rows(j)("SoLuong") = _
                        Integer.Parse(sourceDataTable.Rows(j)("SoLuong")) + Integer.Parse(sourceDataTable.Rows(i)("SoLuong"))

                    'Deletes the row at i
                    sourceDataTable.Rows(i).Delete()

                    Exit For
                End If
            Next
        Next
    End Sub

    ''' <summary>
    ''' Clones a DataRow.
    ''' </summary>
    ''' <param name="sourceRow">Row is used to clone.</param>
    ''' <param name="sourceDataTable">DataTable contains the clone row.</param>
    ''' <returns>A row has values from source Row and fits with source DataTable.</returns>
    ''' <remarks></remarks>
    Public Function CloneDataRow(ByVal sourceRow As DataRow, ByVal sourceDataTable As DataTable) As DataRow
        'Creates new row from source datatable
        Dim row As DataRow = sourceDataTable.NewRow()

        'Clones data from source row
        For i As Integer = 0 To sourceRow.ItemArray.Length - 1 Step 1
            row(i) = sourceRow(i).ToString()
        Next

        Return row
    End Function

    ''' <summary>
    ''' Gets list dishes cannot serve from a DataGridView.
    ''' </summary>
    ''' <param name="sourceDataTable">DataTable contains list dishes.</param>
    ''' <param name="dishQuantity">The quantity of dish cannot serve.</param>
    ''' <returns>A DataTable has list dishes cannot serve.</returns>
    ''' <remarks></remarks>
    Public Function GetCantServeList(ByRef sourceDataTable As DataTable, ByVal dishQuantity As Integer) As DataTable
        'Clones source datatable
        Dim cantServeList As DataTable = sourceDataTable.Clone()
        Dim index As Integer = sourceDataTable.Rows.Count - 1

        While dishQuantity > 0
            Dim row As DataRow = cantServeList.NewRow()
            Dim currentQuantity As Integer = sourceDataTable.Rows(index)("SoLuong") - dishQuantity

            'If currentQuantity > 0, means the number of dishes cannot serve less than the number of dishes in 
            'the current row, then clones and adds the current row into clone datatable
            'If currentQuantity <= 0, means the number of dishes cannot serve greater than equal the number of dishes
            'in the current row, then clones and adds the current row into clone datatable, deletes it after that and
            'sets the number of dishes by the currentQuantity and repeats until dishQuantity = 0
            If currentQuantity > 0 Then
                'Sets the quantity of current row by currentQuantity
                sourceDataTable.Rows(index)("SoLuong") = currentQuantity

                'Clones data of row in source datatable
                row = CloneDataRow(sourceDataTable.Rows(index), cantServeList)
                'Sets quantity for row SoLuong
                row("SoLuong") = currentQuantity

                'Adds the new row into clone datatable
                cantServeList.Rows.Add(row)

                dishQuantity = 0
            Else
                'Clones data of row in source datatable
                row = CloneDataRow(sourceDataTable.Rows(index), cantServeList)

                'Delete current row
                sourceDataTable.Rows(index).Delete()

                'Adds the new row into clone datatable
                cantServeList.Rows.Add(row)

                dishQuantity = currentQuantity * -1
                index -= 1
            End If
        End While

        Return cantServeList
    End Function

    ''' <summary>
    ''' Gets the first element in List of DishDetail by dish's identity.
    ''' </summary>
    ''' <param name="sourceDetailList">Source List DishDetail.</param>
    ''' <param name="dishID">Dish's identity.</param>
    ''' <returns>The first element in List of DishDetail matchs with dish's identity.</returns>
    ''' <remarks></remarks>
    Public Function GetFirstDetailByID(ByVal sourceDetailList As List(Of DishDetail), ByVal dishID As String) As DishDetail
        For Each detail As DishDetail In sourceDetailList
            If detail.DishID = dishID Then
                Return detail
            End If
        Next

        Return Nothing
    End Function

    Public Function CreateParameterWithArray(ByVal listParameterName() As String, ByVal listParameterArrayValue(,) As Object) As SqlParameter()
        Dim parameter(listParameterArrayValue.Length - 1) As SqlParameter

        For i As Integer = 0 To listParameterName.Length - 1 Step 1
            For j As Integer = 0 To parameter.Length - 1 Step 1
                parameter(j) = New SqlParameter(listParameterName(i), listParameterArrayValue(j, i))
            Next
        Next

        Return parameter
    End Function
End Module
