Imports System.Data


Public Class CallBack
    Sub New()


    End Sub

    Private _foo As SortedList = New SortedList()

    Public Property foo() As SortedList
        Get
            Return _foo
        End Get
        Set(value As SortedList)
            _foo = value
        End Set
    End Property

    Private _status As Integer = 0
    Public Property status() As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property

    Public Function json() As String
        If Not foo.Contains("status") Then
            foo.Add("status", status)
        End If

        foo("status") = status

        Return Change._Tojson(foo, Cases.First)
    End Function

    Public Sub exception(err As Exception)

        If Not foo.Contains("data") Then
            foo.Add("data", "")
        End If

        status = 404
        foo("data") = err.Message

    End Sub

    Public Sub data(objs As Object)
        Try
            If Not foo.Contains("data") Then
                foo.Add("data", "")
            End If
            If Not IsNothing(objs) Then

                Select Case objs.GetType
                    Case GetType(DataTable)
                        foo("data") = Change._Tojson(DirectCast(objs, DataTable), Cases.First)
                    Case GetType(SortedList)
                        foo("data") = Change._Tojson(CType(objs, SortedList), Cases.First)
                    Case GetType(List(Of SortedList))
                        foo("data") = Change._Tojson(CType(objs, List(Of SortedList)))
                    Case GetType(List(Of Object))
                        foo("data") = Change._Tojson(CType(objs, List(Of Object)))
                    Case GetType(String)
                        foo("data") = objs
                    Case Else
                        foo("data") = "[]"
                End Select
                status = 200
            Else
                status = 404
                foo("data") = "object nothing "
            End If
        Catch ex As Exception
            exception(ex)
        End Try

    End Sub

    Public Sub classTodata(Of T As New)(objs As Object)
        Try

            If Not foo.Contains("data") Then
                foo.Add("data", "")
            End If

            If Not IsNothing(objs) Then

                Select Case objs.GetType
                    Case GetType(T)
                        foo("data") = Change._Tojson(CType(objs, T))
                End Select
                status = 200
            Else
                status = 404
                foo("data") = "object nothing "
            End If
        Catch ex As Exception
            exception(ex)
        End Try
    End Sub

    Private _context As HttpContext = Nothing
    Public Property context() As HttpContext
        Get
            Return _context
        End Get
        Set(value As HttpContext)
            _context = value
        End Set
    End Property

    Public Sub response(Optional app As HttpContext = Nothing)

        If IsNothing(app) Then
            app = context
        End If

        Dim json_ As String = ""

        Try


            If Not foo.Contains("status") Then
                foo.Add("status", status)
            End If

            foo("status") = status

            json_ = Change._Tojson(foo, Cases.First)

            If IsNothing(app) Then
                foo("status") = 401
            End If

        Catch ex As Exception
            foo("data") = ex.Message
            foo("status") = 401
        End Try

        app.Response.Clear()
        app.Response.Buffer = True
        app.Response.Charset = "utf-8"
        app.Response.ContentEncoding = System.Text.Encoding.UTF8
        app.Response.ContentType = "text/json"
        app.Response.AddHeader("content-length", json_.Length)
        app.Response.AddHeader("Access-Control-Allow-Origin", "*")
        app.Response.Write(json_)

    End Sub

End Class

