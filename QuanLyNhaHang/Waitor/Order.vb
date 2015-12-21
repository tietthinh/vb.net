Public Class Order
    Private _Id As String
    Private _Name As String
    Private _Quantity As Integer
    Private _Note As String

    Public Property Id() As String
        Get
            Return Me._Id
        End Get
        Set(value As String)
            Me._Id = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return Me._Name
        End Get
        Set(value As String)
            Me._Name = value
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return Me._Quantity
        End Get
        Set(value As Integer)
            Me._Quantity = value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return Me._Note
        End Get
        Set(value As String)
            Me._Note = value
        End Set
    End Property

End Class
