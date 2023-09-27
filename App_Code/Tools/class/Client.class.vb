Imports System.IO
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports Newtonsoft.Json

Public Class Client


    Private _url As String
    Public Property url() As String
        Get
            Dim res As Object
            Dim tempUrl As String = ""

            res = HttpContext.Current.Request.Url
            _url = res.Scheme & "://" & res.Authority

            Return _url
        End Get
        Set(ByVal Value As String)
            _url = Value
        End Set
    End Property


    Public Function gets(url As String) As String

        Dim WebSendToServer As New WebClient()

        Try

            WebSendToServer.Encoding = Encoding.UTF8
            '640621:Resolve -> The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf TrustAllCertificateCallback)
            callbacks.data(WebSendToServer.DownloadString(New Uri(url)))

        Catch ex As Exception
            callbacks.exception(ex)
        End Try

        gets = callbacks.json()

    End Function

    Private Function TrustAllCertificateCallback(sender As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean
        Throw New NotImplementedException()
    End Function

    'Public Function value(Of T As New)(st As Object) As T

    '    Dim WebSendToServer As New WebClient()
    '    Dim WebSend = ""
    '    Dim inp As Object = New Object

    '    Try

    '        WebSendToServer.Encoding = Encoding.UTF8


    '        '640621:Resolve -> The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
    '        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf TrustAllCertificateCallback)

    '        WebSend = WebSendToServer.UploadString(New Uri(url & st._url), Change._Tojson(st))

    '        inp = Change._To(Of propt.objects)(WebSend)

    '        If Not IsNothing(inp.data) Then
    '            inp = Change._To(Of T)(inp.data)
    '        End If


    '    Catch ex As Exception
    '        inp = Nothing
    '    End Try

    '    value = inp


    'End Function

    'Public Function posts(Of T As New)(path As String, Optional st As Object = Nothing) As T

    '    Dim WebSendToServer As New WebClient()
    '    Dim WebSend = ""
    '    Dim inp As Object = New Object

    '    Try

    '        WebSendToServer.Encoding = Encoding.UTF8

    '        If path.IndexOf("localhost:") > -1 Then
    '            WebSend = path
    '        Else
    '            If path.IndexOf(".res") > -1 Then
    '                WebSend = url & path & ".ashx"
    '            Else
    '                WebSend = url & path
    '            End If
    '        End If

    '        '640621:Resolve -> The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
    '        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf TrustAllCertificateCallback)

    '        WebSend = WebSendToServer.UploadString(New Uri(WebSend), Change._Tojson(st))

    '        inp = Change._To(Of propt.objects)(WebSend)

    '        If Not IsNothing(inp.data) Then
    '            inp = Change._To(Of T)(inp.data)
    '        End If


    '    Catch ex As Exception
    '        inp.err = ex.Message
    '        inp.status = "401"
    '    End Try

    '    posts = inp

    'End Function


    'Public Function PostToObj(path As String, Optional st As Object = Nothing) As propt.objects

    '    Dim WebSendToServer As New WebClient()
    '    Dim WebSend = ""
    '    Dim inp As Object = New Object

    '    Try

    '        WebSendToServer.Encoding = Encoding.UTF8

    '        If path.IndexOf("localhost:") > -1 Then
    '            WebSend = path
    '        Else

    '            If path.IndexOf(".res") > -1 Then
    '                WebSend = url & path & ".ashx"
    '            Else
    '                WebSend = url & path
    '            End If

    '        End If

    '        '640621:Resolve -> The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
    '        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf TrustAllCertificateCallback)
    '        WebSend = WebSendToServer.UploadString(New Uri(WebSend), Change._Tojson(st))

    '        inp = Change._To(Of propt.objects)(WebSend)

    '    Catch ex As Exception
    '        inp.err = ex.Message
    '        inp.status = "401"
    '    End Try

    '    PostToObj = inp


    'End Function

    Public Function posts(path As String, Optional st As Object = Nothing) As String

        Dim WebSendToServer As New WebClient()
        Dim WebSend = ""

        Try

            WebSendToServer.Encoding = Encoding.UTF8

            If path.IndexOf("localhost:") > -1 Then
                WebSend = path
            Else
                WebSend = url & path
            End If
            '640621:Resolve -> The underlying connection was closed: Could not establish trust relationship for the SSL/TLS secure channel
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf TrustAllCertificateCallback)
            WebSend = WebSendToServer.UploadString(New Uri(WebSend), Change._Tojson(st))

        Catch ex As Exception

            WebSend = ex.Message
        End Try

        posts = WebSend

    End Function

    Public Function readToencode(Of T As New)(filePath As String) As T
        Using reader As New StreamReader(filePath)
            Dim fileContents = reader.ReadToEnd()

            fileContents = key.Decrypt(fileContents)
            Return JsonConvert.DeserializeObject(Of T)(fileContents)
        End Using
    End Function

    Public Function read(Of T As New)(filePath As String) As T
        Try
            Using reader As New StreamReader(filePath)
                Dim fileContents = reader.ReadToEnd()
                Return JsonConvert.DeserializeObject(Of T)(fileContents)
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function read(filePath As String) As String
        Using reader As New StreamReader(filePath)
            Dim fileContents = reader.ReadToEnd()
            Return fileContents.ToString
        End Using
    End Function
    Public Function writeTodecode(filePath As String, objectToWrite As Object, Optional append As Boolean = False) As String
        Dim contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite)
        Try
            contentsToWriteToFile = key.Encrypt(contentsToWriteToFile)
            Using writer As New StreamWriter(filePath, append)

                Using jw As JsonTextWriter = New JsonTextWriter(writer)
                    jw.Formatting = Formatting.Indented
                    jw.IndentChar = " "c
                    jw.Indentation = 4
                    jw.WriteRaw(contentsToWriteToFile)
                End Using

            End Using

            Return "ok"
        Catch ex As Exception
            Throw New Exception("WriteToJsonFile : " & ex.Message)
        End Try

    End Function

    'Shared
    Public Function write(filePath As String, objectToWrite As Object, Optional append As Boolean = False) As String
        Dim contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite)
        Try

            Using writer As New StreamWriter(filePath, append)

                Using jw As JsonTextWriter = New JsonTextWriter(writer)
                    jw.Formatting = Formatting.Indented
                    jw.IndentChar = " "c
                    jw.Indentation = 4
                    jw.WriteRaw(contentsToWriteToFile)
                End Using

            End Using

            Return "ok"
        Catch ex As Exception
            Throw New Exception("WriteToJsonFile : " & ex.Message)
        End Try

    End Function

End Class
