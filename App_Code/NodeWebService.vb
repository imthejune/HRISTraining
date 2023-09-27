Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports Telerik.Web.UI
Imports System.Data
Imports System.Collections

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class NodeWebService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function GetNodes(ByVal node As RadTreeNodeData, ByVal context As IDictionary) As IEnumerable

        Dim da As New Mydata(DatabaseType.SQLServer)
        Dim sql As String = "select Name =  PersonCode+' - '+ FnameT +' '+LnameT,PersonID  from PNT_Person where Cmb1ID = " & 1 & " order by PersonCode "
        Dim dt As DataTable = da.GetDataTable(sql)


        'Dim numberOfNodes As Integer = CInt(Fix(If(context("NumberOfNodes"), 100)))

        Dim nodes As New List(Of NodeData)()
        For Each row As DataRow In dt.Rows
            Dim nodeData As New NodeData()
            nodeData.Text = row("Name").ToString()

            node.Text = row("Name").ToString()
            node.Value = row("PersonID").ToString()

            nodes.Add(nodeData)
        Next

        Return nodes
    End Function

    Friend Class NodeData
        'INSTANT VB NOTE: The variable text was renamed since Visual Basic does not allow class members with the same name:
        Private text_Renamed As String

        Public Property Text() As String
            Get
                Return text_Renamed
            End Get
            Set(ByVal value As String)
                text_Renamed = value
            End Set
        End Property
    End Class

End Class