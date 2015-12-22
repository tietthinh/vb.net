'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Module provides some processes for Form Chef
'=====================================================================

Imports Library

Module Chef_Process

    Public Sub ClearListViewItemBackColor(ByRef listItem As List(Of ListViewItem), ByRef listView As ListView)
        For i As Integer = 0 To listItem.Count - 1 Step 1
            listItem(i).BackColor = SystemColors.Window
            listItem.RemoveAt(i)
        Next
    End Sub

    Public Function LoadMaterial(ByVal _DishID As Object) As DataTable
        Dim db As New DatabaseConnection()
        Dim materialList As DataTable

        Try
<<<<<<< HEAD
            db.Open()
            materialList = db.Query("spCTLamMonSelect", db.CreateParameter(New String() {"@MaMon"}, New Object() {_DishID}))
        Catch ex As Exception
            Throw ex
        Finally
            db.Close()
=======
            materialList = db.Query("spCTLamMonSelect", db.CreateParameter(New String() {"@MaMon"}, New Object() {_DishID}))
        Catch ex As Exception
            Throw ex
>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
        End Try

        db.Dispose()

        Return materialList
    End Function

    Public Function GetAllColumnsName(ByVal sourceDataTable As DataTable) As String()
        Dim listName(sourceDataTable.Columns.Count - 1) As String

        For index As Integer = 0 To listName.Length - 1 Step 1
            listName(index) = sourceDataTable.Columns(index).ColumnName
        Next

        Return listName
    End Function

    Public Function CloneDataTable(ByVal sourceDataTable As DataTable, ByVal listRowName As String(), ByVal totalQuantity As Integer) As DataTable
        Dim destinationDataTable As New DataTable()

        For i As Integer = 0 To listRowName.Length - 1 Step 1
            destinationDataTable.Columns.Add(listRowName(i))
        Next

        Dim index As Integer = 0

        For Each row As DataRow In sourceDataTable.Rows
            Dim mlRow As DataRow = destinationDataTable.NewRow()
            mlRow("MaSP") = row("MaSP")
            mlRow("SoLuongMotMon") = row("SoLuong")
            mlRow("SoLuong") = row("SoLuong") * totalQuantity

            destinationDataTable.Rows.Add(mlRow)
        Next

        Return destinationDataTable
    End Function
<<<<<<< HEAD
=======


>>>>>>> 89f8d23eefdff0e048a53d2516a0bcd504778cbd
End Module
