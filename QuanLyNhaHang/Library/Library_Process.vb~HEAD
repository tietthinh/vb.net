'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Library provides methods to generate hash code
'=====================================================================

Imports System
Imports System.Security.Cryptography
Imports System.Text

Public Module Library_Process

    ''' <summary>
    ''' Gets MD5 Hash code from two parameters.
    ''' </summary>
    ''' <param name="password">First parameter (for Form Login is Employee's Password).</param>
    ''' <param name="identity">Second parameter (for Form Login is Employee's Identity).</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetMd5Hash(ByVal password As String, ByVal identity As String) As String

        Dim md5Hash As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim _Password As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
        Dim _Identity As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(identity))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To _Password.Length - 1
            sBuilder.Append(_Password(i).ToString("x2"))
            sBuilder.Append(_Identity(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function

    ''' <summary>
    ''' Split the string into two strings based on key word.
    ''' </summary>
    ''' <param name="_String">The splited string.</param>
    ''' <param name="_KeyWord">The key word to split the string.</param>
    ''' <returns>Array of String.</returns>
    ''' <remarks></remarks>
    Public Function StringSplit(ByVal _String As String, ByVal _KeyWord As Object) As String()
        'If type of key word is string then split based on key word
        If TypeOf _KeyWord Is String Then
            Return _String.Split(_KeyWord)
        End If
        'If type of key word is integer then split the string into two strings
        'with first string has the number of characters equal key word
        'else return null
        If TypeOf _KeyWord Is Integer Then
            Dim _StringArray(1) As String
            _StringArray(0) = _String.Substring(0, _KeyWord - 1)
            _StringArray(1) = _String.Substring(_KeyWord)
            Return _StringArray
        Else
            Return Nothing
        End If
    End Function
End Module
