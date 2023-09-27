Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic

Public Class Crypts
    Dim EncKey As String = "tigersoft"
    Dim B1() As Byte = System.Text.Encoding.UTF8.GetBytes(EncKey.Substring(0, 8))
    Dim IV() As Byte = {&H12, &H43, &HCD, &HAA, &HBA, &H10, &H99, &HAC}
    Dim des As New DESCryptoServiceProvider

    Dim enc As ICryptoTransform
    Dim desc As ICryptoTransform

    Public Function Encrypt(ByVal strText As String) As String
        Dim BA() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)

        If enc Is Nothing Then
            enc = des.CreateEncryptor(B1, IV)
        End If
        Using M1 As New MemoryStream
            Dim cs As New CryptoStream(M1, enc, CryptoStreamMode.Write)
            cs.Write(BA, 0, BA.Length)
            cs.Close()
            Return Convert.ToBase64String(M1.ToArray())
        End Using
    End Function

    Public Function Decrypt(ByVal strText As String, Optional ByVal EncKey As String = "tigersoft") As String

        If strText = "" Then
            Return strText
            Exit Function
        End If

        Dim BA() As Byte = Convert.FromBase64String(strText)
        If desc Is Nothing Then
            desc = des.CreateDecryptor(B1, IV)
        End If
        Using M1 As New MemoryStream
            Dim cs As New CryptoStream(M1, desc, CryptoStreamMode.Write)
            cs.Write(BA, 0, BA.Length)
            cs.Close()
            Return System.Text.Encoding.UTF8.GetString(M1.ToArray)
        End Using
    End Function

End Class

