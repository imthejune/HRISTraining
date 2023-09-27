Imports Microsoft.VisualBasic
Imports Telerik.Web.UI
Imports System.Web.UI.WebControls
Imports System

Public Class BasePage
    Inherits System.Web.UI.Page

#Region "Grid Methods"
    Protected Sub grid_ItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs)

        If (TypeOf e.Item Is GridPagerItem) Then

            Dim grid As RadGrid = CType(sender, RadGrid)
            Dim itemsPage() As String

            Dim pager As GridPagerItem = CType(e.Item, GridPagerItem)
            Dim lbl As Label = CType(pager.FindControl("ChangePageSizeLabel"), Label)
            lbl.Text = Sys.TMsg.แสดง

            'Me.RadGrid1.MasterTableView.PagerStyle.PagerTextFormat = Server.HtmlDecode("{4} <strong>{5}</strong> observations in <strong>{1}</strong> pages")
            Try
                itemsPage = Sys.TMsg.รายการหน้า.Split("_")
                grid.MasterTableView.PagerStyle.PagerTextFormat = Server.HtmlDecode("{4} <strong>{5}</strong> " & itemsPage(0) & " <strong>{1}</strong> " & itemsPage(1) & "")
            Catch ex As Exception
            End Try
        End If

        DoGridOnItemDataBound(sender, e)

    End Sub

    Protected Overridable Sub DoGridOnItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs)

    End Sub
#End Region
End Class
