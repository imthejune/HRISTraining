Public Class StartupScript
    Dim Pages As Object

    Sub New(_Pages As Object)
        Pages = _Pages
    End Sub

    Public Sub Custom(func As String, Optional mdo As String = "")
        If mdo <> "" Then
            Send(mdo & "." & func & ";", mdo)
        Else
            Send(func)
        End If

    End Sub
    Public Sub Custom_sub(func As String, Optional mdo As String = "")
        Send(func, mdo)
    End Sub
    Public Sub modal(func As String)
        Send("$('" & func & "').modal();", "")
    End Sub

    Public Sub Privates(func As String, Optional mdo As String = "")
        Send(func, mdo)
    End Sub

    Public Sub warn(mes As String, Optional title As String = "warning")
        ScriptManager.RegisterStartupScript(Pages, [GetType](), "popup", "Is.warn('" & title & "','" & mes & "')", True)
    End Sub

    Public Sub okey(Optional title As String = "Good job", Optional text As String = "", Optional type As String = "success")

        Dim str As String = ""

        str = String.Format("title:'{0}',text:'{1}',type:'{2}'", title, text, type) 'String.Format("Is.Okey({ title:'{0}',text:'{1}',type:'{2}'})", title, text, type)

        ScriptManager.RegisterStartupScript(Pages, [GetType](), "Popup", "Is.Okey({" & str & "})", True)

    End Sub

    Public Sub Send(params As String, Optional name As String = "Null")
        ScriptManager.RegisterStartupScript(Pages, [GetType](), name, params, True)
    End Sub


End Class
