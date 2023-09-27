Imports Microsoft.VisualBasic
Imports Newtonsoft.Json

Public Class connections
    Function path(p As String) As String
        Return HttpContext.Current.Server.MapPath(String.Format("{1}local/{0}.json", p, "~/setting/"))
    End Function

    Public Function BaseTo() As String

        Dim connStr As String = ""

        Try

            Dim connInfo = info()


            If String.IsNullOrEmpty(connInfo.BaseTo.servername) Then
                Exit Try
            End If

            connStr = "server={0};uid={1};pwd={2};database={3}"

            connStr = String.Format(connStr, connInfo.BaseTo.servername, connInfo.BaseTo.Username, connInfo.BaseTo.Password, connInfo.BaseTo.Database)

        Catch ex As Exception
            connStr = ""
        End Try

        BaseTo = connStr

    End Function

    Public Function BaseFor() As String
        Dim connStr As String = ""

        Try

            Dim connInfo = info()


            If String.IsNullOrEmpty(connInfo.BaseFor.servername) Then
                Exit Try
            End If

            connStr = "server={0};uid={1};pwd={2};database={3}"

            connStr = String.Format(connStr, connInfo.BaseFor.servername, connInfo.BaseFor.Username, connInfo.BaseFor.Password, connInfo.BaseFor.Database)

        Catch ex As Exception
            connStr = ""
        End Try

        BaseFor = connStr
    End Function

    Public Function info() As modal.connections

        Dim conn As New modal.connections

        Try

            conn = Clients.read(Of modal.connections)(path("config"))

            If String.IsNullOrEmpty(conn.BaseTo.servername) Then

                conn.BaseTo = New modal.BaseTo

                conn.BaseTo.servername = Sys.LoginWeb.ServerName
                conn.BaseTo.Username = Sys.LoginWeb.uid
                conn.BaseTo.Password = Sys.LoginWeb.pwd
                conn.BaseTo.Database = Sys.LoginWeb.DatabaseName

            End If


        Catch ex As Exception
            conn = Nothing
        End Try

        info = conn

    End Function

    Public Sub update(data As String)

        Try

            Dim indata = Change._To(Of modal.connections)(data)

            indata = indata

            Clients.write(path("config"), indata)

        Catch ex As Exception

        End Try

    End Sub

    Public Class modal


        Public Class connections

            <JsonProperty("BaseTo")>
            Public Property BaseTo As New BaseTo

            <JsonProperty("BaseFor")>
            Public Property BaseFor As New BaseTo

        End Class


        Public Class BaseTo

            <JsonProperty("servername")>
            Public Property servername As String

            <JsonProperty("username")>
            Public Property Username As String

            <JsonProperty("password")>
            Public Property Password As String

            <JsonProperty("database")>
            Public Property Database As String
        End Class

        Public Class storelist

            <JsonProperty("code")>
            Public Property Code As String

            <JsonProperty("server")>
            Public Property Server As String

            <JsonProperty("username")>
            Public Property Username As String

            <JsonProperty("password")>
            Public Property Password As String

            <JsonProperty("database")>
            Public Property Database As String

            <JsonProperty("type")>
            Public Property Type As String

            <JsonProperty("status")>
            Public Property Status As Boolean
        End Class
    End Class

End Class
