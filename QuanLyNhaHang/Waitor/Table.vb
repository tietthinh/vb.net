Public Class Table
    Private _ListOrder As New List(Of Order)

    Public Sub AddOrder(ByVal _Order As Order)
        _ListOrder.Add(_Order)
    End Sub
    Public Sub RemoveOrder(ByVal _Order As Order)
        _ListOrder.Remove(_Order)
    End Sub
    Public Function GetLength() As Integer
        Dim _Length = _ListOrder.Count
        Return _Length
    End Function
    Public Function GetOrder(ByVal _Index As Integer) As Order
        Return _ListOrder(_Index)
    End Function
End Class
