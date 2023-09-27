
Partial Class Form_Setting_WebTransfer
    Inherits System.Web.UI.Page

    Private Sub Form_Setting_WebTransfer_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then
            StartLoad()
        End If

    End Sub


    Sub StartLoad()

        Try
            Sys.LoginWeb = New User
            Call LoadRegisty()

        Catch ex As Exception

        End Try
    End Sub

End Class
