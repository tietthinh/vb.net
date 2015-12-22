Public Class Table
    Private _TableOrder As New List(Of Order)
    Private _TableNumber As New Integer
    Public Property TableNumber() As Integer
        Get
            Return Me._TableNumber
        End Get
        Set(value As Integer)
            Me._TableNumber = value
        End Set
    End Property
    Public Sub Add(ByVal Order As Order)
        _TableOrder.Add(Order)
    End Sub
    Public Sub Update(ByVal Index As Integer, ByVal Order As Order)

    End Sub
    Public Sub Remove(ByVal Index As Integer)
        _TableOrder.RemoveAt(Index)
    End Sub
    Public Function GetOrder(ByVal Index As Integer) As Order
        Return _TableOrder(Index)
    End Function
    Public Function GetLength() As Integer
        Return _TableOrder.Count
    End Function
End Class
