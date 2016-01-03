Imports Library

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
End Module
