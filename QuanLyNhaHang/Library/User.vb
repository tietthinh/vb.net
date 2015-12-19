'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Provides class User for Employee's Form to store 
'           necessary information.
'=====================================================================

Public Class User

    'Fields:
    ''' <summary>
    ''' Employee's Identity.
    ''' </summary>
    ''' <remarks></remarks>
    Dim _Identity As String

    ''' <summary>
    ''' Employee's Name.
    ''' </summary>
    ''' <remarks></remarks>
    Dim _EmployeeName As String

    'Properties:
    ''' <summary>
    ''' Gets Employee's Identity.
    ''' </summary>
    ''' <value></value>
    ''' <returns>Identity of Employee.</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Identity As String
        Get
            Return _Identity
        End Get
    End Property

    ''' <summary>
    ''' Gets Employee's Name.
    ''' </summary>
    ''' <value></value>
    ''' <returns>Name of Employee.</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property EmployeeName As String
        Get
            Return _EmployeeName
        End Get
    End Property

    'Constructors:
    ''' <summary>
    ''' Constructor gets two parameters to set value for User object.
    ''' </summary>
    ''' <param name="identity">Employee's Identity.</param>
    ''' <param name="name">Employee's Name.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal identity As String, ByVal name As String)
        _Identity = identity
        _EmployeeName = name
    End Sub
End Class
