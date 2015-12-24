Module WarehouseKeeper_Process

    Public Sub BindDataGridViewComboBox(ByRef dataGridViewCell As DataGridViewCell, ByRef sourceDataTable As DataTable)
        Dim comboboxCell As DataGridViewComboBoxCell = DirectCast(dataGridViewCell, DataGridViewComboBoxCell)
        comboboxCell.DataSource = sourceDataTable
        comboboxCell.DisplayMember = "Email"
        comboboxCell.ValueMember = "MaNCC"
    End Sub

    Public Sub BindDataGridViewComboBoxSDT(ByRef dataGridViewCell As DataGridViewCell, ByRef sourceDataTable As DataTable)
        Dim comboboxCell As DataGridViewComboBoxCell = DirectCast(dataGridViewCell, DataGridViewComboBoxCell)
        comboboxCell.DataSource = sourceDataTable
        comboboxCell.DisplayMember = "SDT"
        comboboxCell.ValueMember = "MaNCC"
    End Sub

End Module
