'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Module provides some processes for Form Chef
'=====================================================================

Module Chef_Process
    Public Sub ClearListViewItemBackColor(ByRef listIndex As List(Of Integer), ByRef listView As ListView)
        For i As Integer = 0 To listIndex.Count - 1 Step 1
            listView.Items(listIndex(i)).BackColor = SystemColors.Window
            listIndex.RemoveAt(i)
        Next
    End Sub
End Module
