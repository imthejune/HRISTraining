Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System

'''เอาไว้เข้ารหัส
Public Class Cipher

    Dim EncKey$

    Sub New(ByVal xKey24Bit$)
        EncKey = xKey24Bit
    End Sub

    Dim IV() As Byte = {&H12, &H43, &HCD, &HAA, &HBA, &H10, &H99, &HAC}

    ''' <summary>
    ''' เข้ารหัส
    ''' </summary>
    ''' <param name="strText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Encrypt(ByVal strText As String) As String
        'Dim B1() As Byte
        'Dim IV() As Byte = {&H12, &H43, &HCD, &HAA, &HBA, &H10, &H99, &HAC}
        'B1 = System.Text.Encoding.UTF8.GetBytes(Mid(EncKey, 1, 8))
        'Dim des As New DESCryptoServiceProvider
        'Dim BA() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
        'Dim M1 As New MemoryStream
        'Dim cs As New CryptoStream(M1, des.CreateEncryptor(B1, IV), CryptoStreamMode.Write)
        'cs.Write(BA, 0, BA.Length)
        'cs.FlushFinalBlock()
        'Return Convert.ToBase64String(M1.ToArray())

        'TripleDESCryptoServiceProvider---------------


        Dim B1() As Byte = System.Text.Encoding.UTF8.GetBytes(Mid(EncKey, 1, 24))
        Dim des As New TripleDESCryptoServiceProvider
        Dim BA() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
        Dim M1 As New MemoryStream
        Dim cs As New CryptoStream(M1, des.CreateEncryptor(B1, IV), CryptoStreamMode.Write)
        cs.Write(BA, 0, BA.Length)
        cs.FlushFinalBlock()
        Return Convert.ToBase64String(M1.ToArray())

    End Function

    ''' <summary>
    ''' ถอดรหัส
    ''' </summary>
    ''' <param name="strText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Decrypt(ByVal strText As String) As String
        'Dim B1() As Byte
        'Dim IV() As Byte = {&H12, &H43, &HCD, &HAA, &HBA, &H10, &H99, &HAC}
        'B1 = System.Text.Encoding.UTF8.GetBytes(Mid(EncKey, 1, 8))
        'Dim des As New DESCryptoServiceProvider
        'Dim BA() As Byte = Convert.FromBase64String(strText)
        'Dim M1 As New MemoryStream
        'Dim cs As New CryptoStream(M1, des.CreateDecryptor(B1, IV), CryptoStreamMode.Write)
        'cs.Write(BA, 0, BA.Length)
        'cs.FlushFinalBlock()
        'Dim En As System.Text.Encoding = System.Text.Encoding.UTF8
        'Return En.GetString(M1.ToArray)

        'TripleDESCryptoServiceProvider------------------------------
        Dim B1() As Byte = System.Text.Encoding.UTF8.GetBytes(Mid(EncKey, 1, 24))
        Dim des As New TripleDESCryptoServiceProvider
        Dim BA() As Byte = Convert.FromBase64String(strText)
        Dim M1 As New MemoryStream
        Dim cs As New CryptoStream(M1, des.CreateDecryptor(B1, IV), CryptoStreamMode.Write)
        cs.Write(BA, 0, BA.Length)
        cs.FlushFinalBlock()
        Return System.Text.Encoding.UTF8.GetString(M1.ToArray)
    End Function



End Class

'Public Class MySec
'    Public Function Encrypt(ByVal strText As String, ByVal secKey As String) As String
'        Dim byKey() As Byte = {}
'        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
'        byKey = System.Text.Encoding.UTF8.GetBytes(Mid(secKey, 1, 8))
'        Dim des As New DESCryptoServiceProvider
'        Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(strText)
'        Dim ms As New IO.MemoryStream
'        Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), _
'            CryptoStreamMode.Write)
'        cs.Write(inputByteArray, 0, inputByteArray.Length)
'        cs.FlushFinalBlock()
'        Return Convert.ToBase64String(ms.ToArray)
'    End Function

'    Public Function Decrypt(ByVal strText As String, ByVal secKey As String) As String
'        Dim byKey() As Byte = {}
'        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
'        Dim inputByteArray(strText.Length) As Byte

'        byKey = System.Text.Encoding.UTF8.GetBytes(Mid(secKey, 1, 8))
'        Dim des As New DESCryptoServiceProvider
'        inputByteArray = Convert.FromBase64String(strText)
'        Dim ms As New IO.MemoryStream
'        Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), _
'           CryptoStreamMode.Write)
'        cs.Write(inputByteArray, 0, inputByteArray.Length)
'        cs.FlushFinalBlock()
'        Dim EnC As System.Text.Encoding = System.Text.Encoding.UTF8
'        Return EnC.GetString(ms.ToArray)
'    End Function
'End Class


Public Class MyCrypt
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