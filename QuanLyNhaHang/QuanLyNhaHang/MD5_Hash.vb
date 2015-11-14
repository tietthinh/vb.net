Imports System
Imports System.Security.Cryptography
Imports System.Text

Public Module MD5_Hash
    Function GetMd5Hash(ByVal password As String, ByVal cmnd As String) As String

        Dim md5Hash As MD5 = MD5.Create()

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
        Dim temp As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(cmnd))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
            sBuilder.Append(temp(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash
End Module
