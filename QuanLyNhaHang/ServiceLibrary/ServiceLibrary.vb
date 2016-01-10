Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Collections

Public Class ServerObject : Inherits MarshalByRefObject
<<<<<<< HEAD
    Private _Holder As String = ""
=======
    Private _Holder As String = "+++"
>>>>>>> TietThinh-NhanVien
    ''Constructor
    Public Sub New()

    End Sub
    Public Sub AddData(ByVal _Data As String)
        If (_Data <> Nothing) Then
            ''For logging
            _Holder += _Data
        End If
    End Sub
    Public Function GetHolder() As String
        Return Me._Holder
    End Function
    Public Function GetObjectType() As Type
        Return Me.GetType
    End Function
    Protected Overrides Sub Finalize()

    End Sub
End Class