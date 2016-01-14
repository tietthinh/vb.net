Imports Library
Imports Remote
Module WarehouseKeeper_Process

    ''' <summary>
    ''' Bind data from DataTable into each cell of DataGridView ComboBox Column.
    ''' </summary>
    ''' <param name="dataGridViewCell">ComboBox Cell of DataGridView wanting to bind.</param>
    ''' <param name="sourceDataTable">DataTable used to bind.</param>
    ''' <param name="displayMember">The showing value for User.</param>
    ''' <param name="valueMember">The hidden value for query Database.</param>
    ''' <remarks></remarks>
    Public Sub BindDataGridViewComboBox(ByRef dataGridViewCell As DataGridViewCell, ByRef sourceDataTable As DataTable,
                                        ByVal displayMember As String, ByVal valueMember As String, ByVal IdentifyVendor As Object, ByVal value As String)
        Dim comboboxCell As DataGridViewComboBoxCell = DirectCast(dataGridViewCell, DataGridViewComboBoxCell)
        If sourceDataTable.Rows.Count = 0 Then
            sourceDataTable.Rows.Add(New Object() {IdentifyVendor, value})
        End If
        comboboxCell.DataSource = sourceDataTable

        comboboxCell.DisplayMember = displayMember
        comboboxCell.ValueMember = valueMember
    End Sub

    ''' <summary>
    ''' Append email from array into datatable.
    ''' </summary>
    ''' <param name="destinationDataTable">DataTable contains data.</param>
    ''' <param name="sourceList">Array has list values.</param>
    ''' <remarks></remarks>
    Public Sub AppendEmail(ByRef destinationDataTable As DataTable, ByVal sourceList() As String)
        Dim id As String = destinationDataTable.Rows(0)("MaNCC")

        For i As Integer = 0 To sourceList.Length - 1 Step 1
            Dim row As DataRow = destinationDataTable.NewRow()

            row("MaNCC") = id
            row("Email") = sourceList(i)

            destinationDataTable.Rows.Add(row)
        Next
    End Sub

    ''' <summary>
    ''' Append email from array into datatable.
    ''' </summary>
    ''' <param name="destinationDataTable">DataTable contains data.</param>
    ''' <param name="sourceList">Array has list values.</param>
    ''' <remarks></remarks>
    Public Sub AppendPhone(ByRef destinationDataTable As DataTable, ByVal sourceList() As String)
        Dim id As String = destinationDataTable.Rows(0)("MaNCC")

        For i As Integer = 0 To sourceList.Length - 1 Step 1
            Dim row As DataRow = destinationDataTable.NewRow()

            row("MaNCC") = id
            row("SDT") = sourceList(i)

            destinationDataTable.Rows.Add(row)
        Next
    End Sub
    Public Sub CheckChefBartenderToWarehouseSignal(ByVal Data As String)
        Dim _DataArray As List(Of String) = DataFilter(Data, 6)
        ''TODO your code here
        For Each item As String In _DataArray
            Dim lst As New ListViewItem
            lst = frmWarehouseKeeper.lstGui.Items.Add(item)
        Next
    End Sub
End Module
