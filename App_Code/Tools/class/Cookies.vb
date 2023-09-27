Imports Microsoft.VisualBasic


Public Class Cookie

    Public item As items
    Public err As String
    Dim req As HttpResponse
    Dim reqName As String

    Sub New(req As HttpResponse)
        Me.req = req
    End Sub

    Sub plus(key As String, value As Object)

        Dim newCookie As HttpCookie = New HttpCookie(reqName)
        newCookie(key) = value
        newCookie.Expires = DateTime.Now.AddDays(1D)
        req.Cookies.Add(newCookie)

    End Sub

    Sub Add()
        Dim newCookie As HttpCookie = New HttpCookie(reqName)
        'newCookie("id") = item.id
        'newCookie("user") = item.user
        'newCookie("Theme") = item.theme
        newCookie.Expires = DateTime.Now.AddDays(-1D)
        req.Cookies.Add(newCookie)
    End Sub

    Sub Remove()
        Dim delCookie As HttpCookie
        delCookie = New HttpCookie(reqName)
        delCookie.Expires = DateTime.Now.AddDays(-1D)
        req.Cookies.Add(delCookie)
    End Sub
    Function Commit() As String

        Me.reqName = reqName & item.id & item.user

        If Not IsNothing(req.Cookies(reqName)) Then
            Remove()
        End If

        Add()

        Commit = item.theme
    End Function

    Public Structure items
        Public id As String
        Public user As String
        Public theme As String
        Public dates As String
        Public requestid As String

        Public Sub New(_id As String, _user As String, _theme As String, _dates As String)
            Me.id = _id
            Me.user = _user
            Me.theme = _theme
            Me.dates = _dates
        End Sub
    End Structure
End Class

