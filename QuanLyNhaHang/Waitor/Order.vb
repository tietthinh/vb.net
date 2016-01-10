Public Class Order
    Private _STT As String
    Private _TenMon As String
    Private _SoLuong As String
    Private _GhiChu As String
    Private _TinhTrang As String
    Private _MaChuyen As String
    Private _MaMon As String
    Public Property STT() As String
        Get
            Return Me._STT
        End Get
        Set(value As String)
            Me._STT = value
        End Set
    End Property
    Public Property TenMon() As String
        Get
            Return Me._TenMon
        End Get
        Set(value As String)
            Me._TenMon = value
        End Set
    End Property
    Public Property SoLuong() As String
        Get
            Return Me._SoLuong
        End Get
        Set(value As String)
            Me._SoLuong = value
        End Set
    End Property
    Public Property GhiChu() As String
        Get
            Return Me._GhiChu
        End Get
        Set(value As String)
            Me._GhiChu = value
        End Set
    End Property
    Public Property MaMon() As String
        Get
            Return Me._MaMon
        End Get
        Set(value As String)
            Me._MaMon = value
        End Set
    End Property
    Public Property TinhTrang() As String
        Get
            Return Me._TinhTrang
        End Get
        Set(value As String)
            Me._TinhTrang = value
        End Set
    End Property
    Public Property MaChuyen() As String
        Get
            Return Me._MaChuyen
        End Get
        Set(value As String)
            Me._MaChuyen = value
        End Set
    End Property
End Class
