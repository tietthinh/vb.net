'=====================================================================
'Name:      Dương Tấn Huỳnh Phong
'Project:   Restaurant Management
'Purpose:   Library provides methods to generate hash code
'=====================================================================

Imports System
Imports System.Security.Cryptography
Imports System.Text

Public Module MD5_Hash
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
End Module
