Imports System.Data
Imports System.Net
Imports System.Web.Services
Imports System.Management
Imports System.IO
Imports Newtonsoft.Json
Imports CreateTable
Partial Class setting_endpoint_data_res
    Inherits System.Web.UI.Page

    Implements IHttpHandler

    Public Sub ProcessRequests(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim key As String = Page.RouteData.Values("key")
        Dim path As String = "~/setting/"


        Try
            Dim CreateTable As CreateTable = New CreateTable(context, ResolveUrl(path))
            Dim SetupConfigs As SetupConfig = New SetupConfig(context)
            Dim transferdata As TransferData = New TransferData(context, ResolveUrl(path))


            Select Case key
                Case "table"
                    CreateTable.Table()
                Case "transfer"
                    transferdata.Load()
                Case "setup-config"
                    SetupConfigs.Load()
            End Select

        Catch ex As Exception
            callbacks.exception(ex)
            callbacks.response()
        End Try

    End Sub

End Class
