Imports Library

Public Class AppProvider
    Public Shared _IsUpdate As Boolean
    Public Shared _IsCommitted As Boolean = False
    Public Shared _SelectedItem As String = ""
    Public Shared Function OrderStatus(ByVal _Id As Integer) As String
        If (_Id <> Nothing Or _Id <> Nothing) Then
            Select Case (_Id)
                Case 1
                    Return "Chưa làm"
                Case 2
                    Return "Đang làm"
                Case 3
                    Return "Đã xong"
                Case 4
                    Return "Đã hủy"
            End Select
        End If
        Return Nothing
    End Function
End Class
