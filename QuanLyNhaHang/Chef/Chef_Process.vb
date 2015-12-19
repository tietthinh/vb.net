'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Module provides some processes for Form Chef
'=====================================================================

Module Chef_Process
    Public Sub ClearListViewItemBackColor(ByRef listItem As List(Of ListViewItem), ByRef listView As ListView)
        For i As Integer = 0 To listItem.Count - 1 Step 1
            listItem(i).BackColor = SystemColors.Window
            listItem.RemoveAt(i)
        Next
    End Sub


End Module
