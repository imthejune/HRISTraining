Imports System.IO
Imports Microsoft.VisualBasic
Imports Newtonsoft.Json


'Public Module Models

'    Public Class Client

'        <JsonProperty("code")>
'        Public Property Code As String

'        <JsonProperty("clientkey")>
'        Public Property Clientkey As String

'        <JsonProperty("clientname")>
'        Public Property Clientname As String

'        <JsonProperty("clientgroup")>
'        Public Property Clientgroup As Integer

'        <JsonProperty("clientid")>
'        Public Property ClientID As Integer

'        <JsonProperty("detect")>
'        Public Property Detect As New Detect

'        <JsonProperty("favorite")>
'        Public Property Favorite As New Favorite

'    End Class

'    Public Class Detect

'        <JsonProperty("status")>
'        Public Property Status As Boolean

'        <JsonProperty("show")>
'        Public Property Show As Boolean

'        <JsonProperty("localtion")>
'        Public Property Localtion As Boolean
'    End Class

'    Public Class Dashboard
'        Public Property title As String
'        Public Property name As String
'        Public Property path As String
'        Public Property width As String
'        Public Property classed As String
'        Public Property display As Boolean
'        Public Property sequence As Integer
'    End Class
'    Enum types
'        defaults = 0
'        extra = 1
'    End Enum

'    Public Class Bodys
'        Sub New(Optional page As Object = Nothing)
'            If Not IsNothing(page) Then
'                Me._url = page.ResolveUrl("~/data/")
'            Else
'                Me._url = ""
'            End If
'        End Sub

'        Public Sub url(Optional l As String = "", Optional types As types = types.defaults)

'            If types = types.extra Then
'                _url = ""
'            End If

'            If l <> "" Then
'                _url &= l
'            End If

'        End Sub
'        Public Property name As String = ""
'        Public Property modules As String = ""
'        Public Property process As String = ""
'        Public Property other As String = ""
'        Private _cookies As String
'        Public Property cookies() As String
'            Get

'                If Not IsNothing(HttpContext.Current.Request.Cookies("authorized")) Then
'                    _cookies = HttpContext.Current.Request.Cookies("authorized").Value
'                Else
'                    _cookies = ""
'                End If

'                Return _cookies
'            End Get
'            Set(ByVal Value As String)
'                _cookies = Value
'            End Set
'        End Property
'        Public Property _url() As String
'        Public Property err() As String

'    End Class


'    Public Class Favorite

'        <JsonProperty("code")>
'        Public Property Code As String

'        <JsonProperty("client")>
'        Public Property Client As String

'        <JsonProperty("item")>
'        Public Property Items As List(Of Item)

'        Public Class Item

'            <JsonProperty("key")>
'            Public Property Key As String

'            <JsonProperty("name")>
'            Public Property Name As String

'            <JsonProperty("type")>
'            Public Property Type As Integer

'            <JsonProperty("href")>
'            Public Property Href As String

'            <JsonProperty("code")>
'            Public Property Code As String
'        End Class
'    End Class

'    Public Class ImageUrl

'        '<JsonProperty("item")>
'        'Public Property Items As List(Of Item)


'        <JsonProperty("code")>
'        Public Property code As String
'        <JsonProperty("folder")>
'        Public Property folder As String

'        <JsonProperty("name")>
'        Public Property name As String

'        <JsonProperty("createdate")>
'        Public Property lastdate As String
'        <JsonProperty("status")>
'        Public Property status As Boolean

'        <JsonProperty("client")>
'        Public Property client As String

'    End Class


'    Class SetupCompany

'        Public Class section
'            <JsonProperty("code")>
'            Public Property Code As String

'            <JsonProperty("company")>
'            Public Property Company As String

'            <JsonProperty("item")>
'            Public Property Item As List(Of Item)

'        End Class

'        Public Class Propt

'            <JsonProperty("value")>
'            Public Property Value As String

'            <JsonProperty("type")>
'            Public Property Type As String

'            <JsonProperty("status")>
'            Public Property Status As Boolean

'            <JsonProperty("remark")>
'            Public Property Remark As String
'        End Class

'        Public Class Item

'            <JsonProperty("name")>
'            Public Property Name As String

'            <JsonProperty("process")>
'            Public Property Process As String

'            <JsonProperty("propt")>
'            Public Property Propt As Propt


'        End Class

'    End Class

'    Public Class Adminboard
'        <JsonProperty("code")>
'        Public Property Code As String

'        <JsonProperty("name")>
'        Public Property Name As String

'        <JsonProperty("title")>
'        Public Property Title As String

'        <JsonProperty("className")>
'        Public Property ClassName As String

'        <JsonProperty("position")>
'        Public Property Position As New Positions
'        <JsonProperty("status")>
'        Public Property Status As Boolean

'        <JsonProperty("remark")>
'        Public Property Remark As String

'        <JsonProperty("fileName")>
'        Public Property fileName As String


'        Public Class Positions
'            <JsonProperty("row")>
'            Public Property row As Integer
'            <JsonProperty("column")>
'            Public Property column As Integer

'            <JsonProperty("x")>
'            Public Property X As Integer

'            <JsonProperty("y")>
'            Public Property Y As Integer
'        End Class

'    End Class


'    Public Class Token
'        Public Property clientconde As String
'        Public Property clientkey As String
'    End Class

'End Module

'Public Class propt

'    Public Class objects
'        Public Property name As String
'        Public Property data As String
'        Public Property status As String
'        Public Property err As String
'    End Class
'    Public Class contacts
'        Public Property AmountPerson As String
'        Public Property StartDate As String
'        Public Property EndDate As String
'        Public Property ContractNo As String
'        Public Property NameSale As String
'        Public Property TelSale As String
'        Public Property EmailSale As String
'        Public Property AmountCompany As String
'        Public Property Project As String
'    End Class


'    Public Class example
'        <JsonProperty("item")>
'        Public Property Items As List(Of Item)
'        Public Class Item
'            <JsonProperty("code")>
'            Public Property code As String
'            <JsonProperty("folder")>
'            Public Property folder As String
'            <JsonProperty("name")>
'            Public Property name As String

'            <JsonProperty("createdate")>
'            Public Property createdate As String

'        End Class
'    End Class

'End Class



