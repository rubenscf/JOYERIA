Imports System.Security.Cryptography
Imports System.Text

Module Encriptacion
    Public Function _ObtieneMd5Hash(ByVal Seminario2015 As MD5, ByVal input As String) As String
        Dim data As Byte() = Seminario2015.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()

        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        Return sBuilder.ToString()
    End Function 'ObtieneHashmd5

    Public Function VerificaMd5Hash(ByVal Seminario2015 As MD5, ByVal input As String, ByVal hash As String) As Boolean
        Dim hashOfInput As String = _ObtieneMd5Hash(Seminario2015, input)
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If

    End Function 'VerificaHashMD5
End Module
