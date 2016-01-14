
Public Class ClassProvider
    Private _Username As String
    Private _Id As String
    Public Property Username() As String
        Get
            Return Me._Username
        End Get
        Set(value As String)
            Me._Username = value
        End Set
    End Property

    Public Property Id As String
        Get
            Return Me._Id
        End Get
        Set(value As String)
            Me._Id = value
        End Set
    End Property
End Class
