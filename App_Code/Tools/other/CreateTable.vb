Imports System.Data
Imports Microsoft.VisualBasic
Imports Newtonsoft.Json

Public Class CreateTable
    Dim conn As connections
    Dim app As HttpContext
    Dim resolveUrl As String = ""
    Dim tempTable As New List(Of Model.ListTable)
    Sub New(context As HttpContext, resUrl As String)

        app = context
        resolveUrl = resUrl
        conn = New connections
    End Sub

    Public Sub Table()

        Dim LocalJson = New CallBack()
        Dim dt As New DataTable

        LocalJson.context = app

        Dim listData As New SortedList

        Try


            listData = Change.context(app)

            Select Case listData("process")
                Case "load"
                    Loading()
                Case "createScript"
                    createScript()
            End Select

        Catch ex As Exception
            LocalJson.exception(ex)
            LocalJson.response()
        End Try


    End Sub

    Public Sub createScript()
        Dim LocalJson = New CallBack()
        Dim dt As New DataTable

        LocalJson.context = app

        Dim cnn As New connExecute()


        Try


            Dim InJson = Clients.read(Of List(Of Model.Tables))(path("Json-Create-table"))
            Dim ss$ = ""
            Bases.xConnect = conn.BaseTo
            Bases.Secs.write(querys.checkTable, "checkTable", Cases.Update)


            For Each item In InJson

                Dim srItem = Bases.findIndex("checkTable", String.Format("TABLE_NAME:='{0}'", item.Table))

                If IsNothing(srItem) Then
                    Dim chkTable As New Model.ListTable

                    querys.str = querys.Create(item)

                    Using exe As New connExecute()

                        Try
                            chkTable.Keyuuid = item.Keyuuid
                            chkTable.Table = item.Table

                            exe.ExecuteNonQuery(querys.str)

                            chkTable.Status = True
                        Catch ex As Exception
                            chkTable.Status = False
                        End Try


                        tempTable.Add(chkTable)
                    End Using
                End If

            Next


            LocalJson.classTodata(Of List(Of Model.ListTable))(tempTable)
        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()
    End Sub

    Function path(p As String) As String
        Return HttpContext.Current.Server.MapPath(String.Format("{1}local/{0}.json", p, resolveUrl))
    End Function

    Public Sub Loading()
        Dim LocalJson = New CallBack()
        Dim dt As New DataTable

        LocalJson.context = app

        Try

            ' Dim path As String = app.Server.MapPath(ResolveUrl("~/setting/local/Json-Create-table.json"))

            Dim InJson = Clients.read(Of List(Of Model.Tables))(path("Json-Create-table"))


            Bases.Secs.write(querys.checkTable, "checkTable", Cases.Update)


            For Each item In InJson
                Dim chkTable As New Model.ListTable
                Dim srItem = Bases.findIndex("checkTable", String.Format("TABLE_NAME:='{0}'", item.Table))

                If IsNothing(srItem) Then
                    chkTable.Keyuuid = item.Keyuuid
                    chkTable.Table = item.Table
                    chkTable.Status = False

                Else
                    chkTable.Keyuuid = item.Keyuuid
                    chkTable.Table = item.Table
                    chkTable.Status = True
                End If
                tempTable.Add(chkTable)
            Next

            LocalJson.classTodata(Of List(Of Model.ListTable))(tempTable)
        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()

    End Sub


    Dim querys As New Query

    Structure Query

        Public Property str As String

        Public Function checkTable() As String

            str = ""
            str &= " SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES"

            checkTable = str
        End Function



        Public Function Create(item As Model.Tables) As String

            str = " CREATE TABLE [dbo].[{0}]({1} {2}) ON [PRIMARY] "


            Dim column As String = ""

            For Each c In item.Column
                column &= String.Format(" [{0}] {1} ,", c.Name, typeColumn(c))
            Next

            Dim primary As String = ""

            If Not IsNothing(item.Primary) AndAlso item.Primary.Length > 0 Then

                Dim key$ = ""

                primary = "CONSTRAINT [PK_{0}] PRIMARY KEY CLUSTERED  ([{1}] ASC ) ON [PRIMARY]"

                For Each p In item.Primary

                    If key <> "" Then
                        key &= ","
                    End If

                    key &= p
                Next


                primary = String.Format(primary, item.Table, key)

            End If


            Create = String.Format(str, item.Table, column, primary)

        End Function

        Public Function typeColumn(target As Model.Column) As String

            Dim typeText As String = ""

            Dim IsNotNull = "null"

            If target.Able = False Then
                IsNotNull = "IDENTITY(1,1) NOT NULL"
            End If


            Select Case (target.Type)
                Case "numeric"
                    typeText = String.Format("[{0}]({1},{2}) {3}", target.Type, target.Numeric, IIf(Val(target.Scale & "") <> 0, target.Scale, 0), IsNotNull)
                Case "nvarchar", "nchar", "varchar"
                    typeText = String.Format("[{0}]({1}) {2}", target.Type, target.Character, IsNotNull)
                Case "bit", "uniqueidentifier", "float", "int", "datetime"

                    If target.Type.ToLower = "uniqueidentifier" And target.Able = False Then
                        typeText = String.Format("[{0}] NOT NULL", target.Type)
                    Else
                        typeText = String.Format("[{0}] {1}", target.Type, IsNotNull)
                    End If

                Case Else
                    typeText = String.Format("[{0}]", target.Type, IsNotNull)
            End Select


            typeColumn = typeText

        End Function

    End Structure

    Class Model

        Class ListTable
            <JsonProperty("keyuuid")>
            Public Property Keyuuid As String

            <JsonProperty("table")>
            Public Property Table As String

            <JsonProperty("status")>
            Public Property Status As Boolean
        End Class

        Public Class Column

            <JsonProperty("Order")>
            Public Property Order As Integer

            <JsonProperty("Name")>
            Public Property Name As String

            <JsonProperty("Type")>
            Public Property Type As String

            <JsonProperty("Character")>
            Public Property Character As Object

            <JsonProperty("Numeric")>
            Public Property Numeric As Object

            <JsonProperty("DateTime")>
            Public Property DateTime As String

            <JsonProperty("Able")>
            Public Property Able As Boolean

            <JsonProperty("Scale")>
            Public Property Scale As Object
        End Class

        Public Class Tables

            <JsonProperty("keyuuid")>
            Public Property Keyuuid As String

            <JsonProperty("table")>
            Public Property Table As String

            <JsonProperty("column")>
            Public Property Column As New List(Of Column)

            <JsonProperty("primary")>
            Public Property Primary As String()

            <JsonProperty("status")>
            Public Property Status As Boolean
        End Class

    End Class


End Class
