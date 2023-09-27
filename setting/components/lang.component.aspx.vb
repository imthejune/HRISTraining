
Imports System.Data
Imports Newtonsoft.Json

Partial Class setting_components_lang_component
    Inherits System.Web.UI.Page

    Private Sub setting_components_lang_component_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not IsPostBack Then

            ' StartLoad()

        End If

    End Sub

    Function path(p As String) As String
        Return HttpContext.Current.Server.MapPath(ResolveUrl(String.Format("~/setting/local/{0}.json", p)))
    End Function

    Public Enum Process
        defaults = 0
        Plus = 1
    End Enum


    Sub StartLoad()

        Dim errors As String = ""
        Dim dtCyber As DataTable = New DataTable
        Dim dtHris As DataTable = New DataTable


        Try


            Bases.xConnect = "server=TG11519\SQLEXPRESS;uid=sa;pwd=tiger"


            Dim template = Clients.read(Of model.template)(path("Patern_Course"))

            If IsNothing(template) Then
                Exit Try
            End If

            dtCyber = Bases.Secs.write(querys.Transection("cyber", template.TableFor, ""), template.TableFor)

            dtHris = Bases.read("To_" & template.Name)

            If IsNothing(dtHris) Then
                dtHris = Bases.Secs.write(querys.Transection("tn_test01", template.TableTo, "top 1"), "To_" & template.Name)
                Bases.clear("To_" & template.Name)
            End If

            ' วนข้อมูลที่จะใช้ จาก ฐาน [Cyber] 
            For Each dr In dtCyber.Rows




            Next


        Catch ex As Exception
            errors = ex.Message
        End Try


    End Sub


    Dim querys As New Query
    Structure Query
        Public Function Transection(db As String, tb As String, Optional where As String = "") As String

            str = ""
            str &= "SELECT {2} * FROM  [{0}].[dbo].[{1}]"

            Transection = String.Format(str, db, tb, where)

        End Function
        Public Function WhereMasters(db As String, tb As String, where As String) As String

            str = ""
            str &= "SELECT {2} * FROM  [{0}].[dbo].[{1}] where {3}"

            WhereMasters = String.Format(str, db, tb, "", where)

        End Function

        Public Function Masters(db As String, tb As String) As String

            str = ""
            str &= "SELECT {2} * FROM  [{0}].[dbo].[{1}]"

            Masters = String.Format(str, db, tb, "")

        End Function

        Public Property str As String

        Public Function Jointable(table As String) As String

            str = "SELECT TOP 1 * FROM [{0}]"

            Jointable = String.Format(str, table)

        End Function

    End Structure

    Class model

        Public Class template

            <JsonProperty("name")>
            Public Property Name As String

            <JsonProperty("typeColumn")>
            Public Property TypeColumn As String

            <JsonProperty("tableTo")>
            Public Property TableTo As String

            <JsonProperty("tableFor")>
            Public Property TableFor As String

            <JsonProperty("createtable")>
            Public Property Createtable As String

            <JsonProperty("foreign")>
            Public Property Foreigns As New List(Of Foreign)

            <JsonProperty("matching")>
            Public Property Matching As New List(Of Matching)

            <JsonProperty("pull")>
            Public Property Pull As New List(Of Pull)

            <JsonProperty("identity")>
            Public Property Identity As New Identity

            <JsonProperty("entrap")>
            Public Property Entrap As String()

            <JsonProperty("jointable")>
            Public Property Jointable As New List(Of Jointable)

            <JsonProperty("addition")>
            Public Property Addition As New List(Of Addition)

        End Class

        Public Class Jointable

            <JsonProperty("field")>
            Public Property Field As String
            <JsonProperty("Ref")>
            Public Property Ref As String

        End Class
        Public Class Foreign

            <JsonProperty("Column")>
            Public Property Column As String

            <JsonProperty("ToColumn")>
            Public Property ToColumn As String

            <JsonProperty("Ref")>
            Public Property Ref As String
        End Class

        Public Class Matching

            <JsonProperty("oldColumn")>
            Public Property OldColumn As String

            <JsonProperty("newOldColumn")>
            Public Property newColumn As String

            <JsonProperty("duplicate")>
            Public Property Duplicate As Boolean
        End Class

        Public Class Pull

            <JsonProperty("field")>
            Public Property Field As String

            <JsonProperty("status")>
            Public Property Status As Boolean
        End Class

        Public Class Identity

            <JsonProperty("field")>
            Public Property Field As String

            <JsonProperty("type")>
            Public Property Type As String
        End Class

        Public Class Addition

            <JsonProperty("Column")>
            Public Property Column As String

            <JsonProperty("ToColumn")>
            Public Property ToColumn As String
        End Class

    End Class

End Class


#Region "Version - 2"

'Sub StartLoad()

'    Dim errors As String = ""
'    Dim dt As DataTable = New DataTable
'    Dim dtTemp As DataTable = New DataTable

'    Try

'        Bases.xConnect = "server=TG11519\SQLEXPRESS;uid=sa;pwd=tiger"


'        Dim template = Clients.read(Of model.template)(pathMatch("Patern_Course"))

'        If IsNothing(template) Then
'            Exit Try
'        End If

'        Dim str As String = "SELECT {2} * FROM  [{0}].[dbo].[{1}]"

'        dt = Bases.Secs.write(String.Format(str, "cyber", template.TableFor, ""), template.TableFor, Cases.Update)


'        '  dtTemp = Bases.read(template.Name)
'        '
'        'If IsNothing(dtTemp) Then
'        dtTemp = Bases.Secs.write(String.Format(str, "tn_test01", template.TableTo, "TOP 1"), "To_" & template.Name, Cases.Update)
'        ' End If


'        For Each dr In dt.Rows

'            Dim drPlus As DataRow = dtTemp.NewRow

'            For Each cl In dt.Columns
'                Dim proc As Process = Process.defaults

'                Dim ColumnName As String = cl.ToString


'                ' เช็คว่า foreign ของตาราง Master หรือเปล่า
'                Dim foreigns = template.Foreigns.Find(Function(x) x.Column = ColumnName)
'                If Not IsNothing(foreigns) Then

'                    Dim guids = New Guid().NewGuid.ToString

'                    Dim guidForeign = foreign(foreigns, dr(ColumnName), guids.ToString)

'                    drPlus(foreigns.ToColumn) = guidForeign.ToString
'                    proc = Process.Plus
'                End If

'                ' ชื่อ Field ที่ต้องการให้เอาข้อมูล จาก Field เก่า ไป Field ใหม่หรือใหม่ 
'                Dim pull = template.Pull.Find(Function(x) x.Field = ColumnName)
'                If Not IsNothing(pull) Then
'                    If pull.Status Then
'                        drPlus(pull.Field) = dr(ColumnName)
'                        proc = Process.Plus
'                    End If
'                End If

'                If proc = Process.defaults Then

'                    ' Field ไม่ต้องการให้ อัปเดตค่า เก่า ไป ใหม่ หรือ อาจมี ตารางใหม่ ที่เกี่ยวข้องกับ Field นี้
'                    If template.Entrap.Length > 0 Then
'                        If template.Entrap.Contains(ColumnName) Then
'                            Continue For
'                        Else
'                            If Not dtTemp.Columns.Contains(ColumnName) Then Continue For
'                            drPlus(ColumnName) = dr(ColumnName)
'                        End If
'                    Else
'                        If Not dtTemp.Columns.Contains(ColumnName) Then Continue For
'                        drPlus(ColumnName) = dr(ColumnName)
'                    End If
'                End If

'            Next

'            If Not IsNothing(template.Jointable) Then

'                For Each item In template.Jointable

'                    Dim guids = New Guid().NewGuid.ToString
'                    'Jointable
'                    guids = Jointable(item, dr, guids)

'                    If guids <> "" Then
'                        drPlus(item.Field) = guids
'                    End If
'                Next

'            End If

'            ' เช็คว่าที่ Field ที่เตรียมไว้ เป็น Type อะไร
'            If Not IsNothing(template.Identity) Then
'                If template.Identity.Type = "GUID" Then
'                    Dim guids = New Guid().NewGuid.ToString
'                    drPlus(template.Identity.Field) = guids
'                End If

'                dtTemp.Rows.Add(drPlus)
'            End If

'            Bases.Secs.plus(dtTemp, "To_" & template.Name, Cases.Update)

'        Next

'    Catch ex As Exception
'        errors = ex.Message
'    End Try

'    Dim ds As DataSet = New DataSet

'    ds = Bases.DataSet()

'    dtTemp = dtTemp

'End Sub

'Function Jointable(MDjoin As model.Jointable, drFor As DataRow, guids As String) As String

'    Dim dt As DataTable = New DataTable
'    Dim dtTemp As DataTable = New DataTable

'    Try

'        Dim template = Clients.read(Of model.template)(pathMatch(MDjoin.Ref))

'        If IsNothing(template) Then
'            guids = ""
'            Exit Try
'        End If

'        If IsNothing(drFor) Then
'            guids = ""
'            Exit Try
'        End If


'        dtTemp = Bases.read("To_" & template.Name)

'        If IsNothing(dtTemp) Then
'            dtTemp = Bases.Secs.write(querys.Masters("tn_test01", template.TableTo), "To_" & template.Name)
'        End If

'        Dim drItem As DataRow = dtTemp.NewRow()
'        Dim pulls As Process = Process.defaults
'        For Each item In drFor.Table.Columns

'            Dim proc As Process = Process.defaults
'            Dim columnName As String = item.ToString()

'            ' เช็คว่า foreign ของตาราง Master หรือเปล่า
'            Dim inForeigns = template.Foreigns.Find(Function(x) x.Column = columnName)
'            If Not IsNothing(inForeigns) Then

'                Dim guids_foreigns = New Guid().NewGuid.ToString

'                Dim guidForeign = foreign(inForeigns, drFor(columnName), guids_foreigns.ToString)

'                drItem(inForeigns.ToColumn) = guidForeign.ToString
'                proc = Process.Plus
'            End If


'            Dim addition = template.Addition.Find(Function(x) x.Column = columnName)

'            If Not IsNothing(addition) Then

'                Dim strSelect As String = "{0} Like '%{1}'"

'                Dim drCheck() As DataRow = dtTemp.Select(String.Format(strSelect, addition.ToColumn, drFor(addition.Column)))

'                If drCheck.Length > 0 Then

'                    For Each r In drCheck
'                        guids = r(template.Identity.Field).ToString
'                    Next

'                    pulls = Process.Plus
'                    Exit Try
'                End If

'            End If

'            Dim matching = template.Matching.Find(Function(x) x.OldColumn = columnName)

'            ' ชื่อ Field ระหว่าง ฐานเก่า กับ ฐานใหม่ ตาม modal ที่ออกแบบไว้
'            If Not IsNothing(matching) Then

'                Dim strSelect As String = "{0} Like '%{1}'"

'                Dim drCheck() As DataRow = dtTemp.Select(String.Format(strSelect, matching.newColumn, drFor(columnName)))

'                If drCheck.Length = 0 Then
'                    drItem(matching.newColumn) = drFor(columnName)
'                    proc = Process.Plus
'                End If

'            End If

'            ' ชื่อ Field ที่ต้องการให้เอาข้อมูล จาก Field เก่า ไป Field ใหม่หรือใหม่ 
'            Dim pull = template.Pull.Find(Function(x) x.Field = columnName)
'            If Not IsNothing(pull) Then
'                If pull.Status Then
'                    drItem(pull.Field) = drFor(columnName)
'                    proc = Process.Plus
'                End If
'            End If

'            ' Field ไม่ต้องการให้ อัปเดตค่า เก่า ไป ใหม่ หรือ อาจมี ตารางใหม่ ที่เกี่ยวข้องกับ Field นี้
'            If template.Entrap.Length > 0 Then
'                If template.Entrap.Contains(columnName) Then
'                    proc = Process.Plus
'                End If
'            End If


'            If proc = Process.defaults Then

'                If Not dtTemp.Columns.Contains(columnName) Then Continue For

'                drItem(columnName) = drFor(columnName)

'            End If
'        Next

'        If Not IsNothing(template.Identity) Then

'            ' เช็คว่าที่ Field ที่เตรียมไว้ เป็น Type อะไร
'            If template.Identity.Type = "GUID" Then
'                drItem(template.Identity.Field) = guids
'            End If
'            dtTemp.Rows.Add(drItem)
'        End If

'        Bases.Secs.plus(dtTemp, "To_" & template.Name, Cases.Update)

'        Bases.DataSet()

'    Catch ex As Exception
'        guids = ""
'    End Try

'    Jointable = guids.ToString()

'End Function

'Function foreign(foreigns As model.Foreign, id As Object, guids As String) As String
'    Dim dt As DataTable = New DataTable
'    Dim dtTemp As DataTable = New DataTable
'    '  Dim proc As Process = Process.defaults
'    Try

'        Dim template = Clients.read(Of model.template)(pathMatch(foreigns.Ref))

'        If IsNothing(template) Then
'            Exit Try
'        End If

'        dt = Bases.Secs.write(querys.WhereMasters("cyber", template.TableFor, foreigns.Column & "='" & id & "'"), "Cyber_" & template.TableFor, Cases.Update)

'        dtTemp = Bases.read("To_" & template.Name)

'        If IsNothing(dtTemp) Then
'            dtTemp = Bases.Secs.write(querys.Masters("tn_test01", template.TableTo), "To_" & template.Name)
'        End If

'        Dim drItem As DataRow = dtTemp.NewRow

'        If IsNothing(dt) Then
'            Exit Try
'        End If

'        For Each dr In dt.Rows
'            Dim pulls As Process = Process.defaults

'            For Each cl In dt.Columns
'                Dim proc As Process = Process.defaults

'                Dim columnName As String = cl.ToString()

'                ' เช็คว่า foreign ของตาราง Master หรือเปล่า
'                Dim inForeigns = template.Foreigns.Find(Function(x) x.Column = columnName)
'                If Not IsNothing(inForeigns) Then

'                    Dim guids_foreigns = New Guid().NewGuid.ToString

'                    Dim guidForeign = foreign(inForeigns, dr(columnName), guids_foreigns.ToString)

'                    drItem(inForeigns.ToColumn) = guidForeign.ToString
'                    proc = Process.Plus
'                End If

'                Dim addition = template.Addition.Find(Function(x) x.Column = columnName)

'                If Not IsNothing(addition) Then

'                    Dim strSelect As String = "{0} Like '%{1}'"

'                    Dim drCheck() As DataRow = dtTemp.Select(String.Format(strSelect, addition.ToColumn, dr(addition.Column)))

'                    If drCheck.Length > 0 Then

'                        For Each r In drCheck
'                            guids = r(template.Identity.Field).ToString
'                        Next

'                        pulls = Process.Plus
'                        Exit Try
'                    End If

'                End If

'                Dim matching = template.Matching.Find(Function(x) x.OldColumn = columnName)

'                ' ชื่อ Field ระหว่าง ฐานเก่า กับ ฐานใหม่ ตาม modal ที่ออกแบบไว้
'                If Not IsNothing(matching) Then

'                    Dim strSelect As String = "{0} Like '%{1}'"

'                    Dim drCheck() As DataRow = dtTemp.Select(String.Format(strSelect, matching.newColumn, dr(columnName)))

'                    If drCheck.Length = 0 Then

'                        'For Each r In drCheck
'                        '    guids = r(template.Identity.Field)
'                        'Next
'                        drItem(matching.newColumn) = dr(columnName)
'                        proc = Process.Plus
'                    End If

'                End If



'                ' ชื่อ Field ที่ต้องการให้เอาข้อมูล จาก Field เก่า ไป Field ใหม่หรือใหม่ 
'                Dim pull = template.Pull.Find(Function(x) x.Field = columnName)
'                If Not IsNothing(pull) Then
'                    If pull.Status Then
'                        drItem(pull.Field) = dr(columnName)
'                        proc = Process.Plus
'                    End If
'                End If

'                ' Field ไม่ต้องการให้ อัปเดตค่า เก่า ไป ใหม่ หรือ อาจมี ตารางใหม่ ที่เกี่ยวข้องกับ Field นี้
'                If template.Entrap.Length > 0 Then
'                    If template.Entrap.Contains(columnName) Then
'                        proc = Process.Plus
'                    End If
'                End If


'                If proc = Process.defaults Then

'                    If Not dtTemp.Columns.Contains(columnName) Then Continue For

'                    drItem(columnName) = dr(columnName)

'                End If

'            Next


'            If Not IsNothing(template.Identity) Then

'                ' เช็คว่าที่ Field ที่เตรียมไว้ เป็น Type อะไร
'                If template.Identity.Type = "GUID" Then
'                    drItem(template.Identity.Field) = guids
'                End If
'                dtTemp.Rows.Add(drItem)
'            End If


'        Next

'        Bases.Secs.plus(dtTemp, "To_" & template.Name, Cases.Update)

'    Catch ex As Exception
'        Throw New Exception(" foreigns : " & ex.Message)
'    End Try



'    foreign = guids

'End Function

'Dim querys As New Query

'Structure Query
'    Public Function WhereMasters(db As String, tb As String, where As String) As String

'        str = ""
'        str &= "SELECT {2} * FROM  [{0}].[dbo].[{1}] where {3}"

'        WhereMasters = String.Format(str, db, tb, "", where)

'    End Function

'    Public Function Masters(db As String, tb As String) As String

'        str = ""
'        str &= "SELECT {2} * FROM  [{0}].[dbo].[{1}]"

'        Masters = String.Format(str, db, tb, "")

'    End Function

'    Public Property str As String

'    Public Function Jointable(table As String) As String

'        str = "SELECT TOP 1 * FROM [{0}]"

'        Jointable = String.Format(str, table)

'    End Function

'End Structure

'Class model

'    Public Class template

'        <JsonProperty("name")>
'        Public Property Name As String

'        <JsonProperty("tableTo")>
'        Public Property TableTo As String

'        <JsonProperty("tableFor")>
'        Public Property TableFor As String

'        <JsonProperty("createtable")>
'        Public Property Createtable As String

'        <JsonProperty("foreign")>
'        Public Property Foreigns As New List(Of Foreign)

'        <JsonProperty("matching")>
'        Public Property Matching As New List(Of Matching)

'        <JsonProperty("pull")>
'        Public Property Pull As New List(Of Pull)

'        <JsonProperty("identity")>
'        Public Property Identity As New Identity

'        <JsonProperty("entrap")>
'        Public Property Entrap As String()

'        <JsonProperty("jointable")>
'        Public Property Jointable As New List(Of Jointable)

'        <JsonProperty("addition")>
'        Public Property Addition As New List(Of Addition)

'    End Class

'    Public Class Jointable

'        <JsonProperty("field")>
'        Public Property Field As String
'        <JsonProperty("Ref")>
'        Public Property Ref As String
'        '<JsonProperty("column")>
'        'Public Property Column As String

'        '<JsonProperty("foreign")>
'        'Public Property Foreign As String

'        '<JsonProperty("tablename")>
'        'Public Property Tablename As String

'        '<JsonProperty("byTable")>
'        'Public Property ByTable As String

'        '<JsonProperty("twain")>
'        'Public Property Twain As New List(Of Twain)
'    End Class
'    Public Class Foreign

'        <JsonProperty("Column")>
'        Public Property Column As String

'        <JsonProperty("ToColumn")>
'        Public Property ToColumn As String

'        <JsonProperty("Ref")>
'        Public Property Ref As String
'    End Class

'    Public Class Matching

'        <JsonProperty("oldColumn")>
'        Public Property OldColumn As String

'        <JsonProperty("newOldColumn")>
'        Public Property newColumn As String

'        <JsonProperty("duplicate")>
'        Public Property Duplicate As Boolean
'    End Class

'    Public Class Pull

'        <JsonProperty("field")>
'        Public Property Field As String

'        <JsonProperty("status")>
'        Public Property Status As Boolean
'    End Class

'    Public Class Identity

'        <JsonProperty("field")>
'        Public Property Field As String

'        <JsonProperty("type")>
'        Public Property Type As String
'    End Class

'    'Public Class Twain

'    '    <JsonProperty("field")>
'    '    Public Property Field As String

'    '    <JsonProperty("match")>
'    '    Public Property Match As String
'    'End Class

'    Public Class Addition

'        <JsonProperty("Column")>
'        Public Property Column As String

'        <JsonProperty("ToColumn")>
'        Public Property ToColumn As String
'    End Class

'    '    "addition" [
'    '    {
'    '        "Column": "TN_Type_PaternName",
'    '        "ToColumn":"Type_PaternNameT"
'    '    }
'    ']

'End Class


#End Region

#Region "Version - 1"


'Sub StartLoad()

'    Dim ss As String = ""
'    Try



'        Bases.xConnect = "server=TG11519\SQLEXPRESS;uid=sa;pwd=tiger"

'        Dim dt As DataTable = New DataTable
'        Dim dtTemp As DataTable = New DataTable


'        Dim path As String = HttpContext.Current.Server.MapPath(ResolveUrl("~/setting/local/patern_1-template.json"))

'        Dim inTemplate = Clients.read(Of Model.template)(path)


'        If IsNothing(inTemplate) Then
'            Exit Try
'        End If

'        Dim str As String = "SELECT {2} * FROM  [{0}].[dbo].[{1}]"


'        inTemplate = inTemplate

'        dt = Bases.Secs.write(String.Format(str, "cyber", inTemplate.second, ""), inTemplate.second, Cases.Update)

'        dtTemp = Bases.Secs.write(String.Format(str, "tn_test01", inTemplate.first, "TOP 1"), inTemplate.first, Cases.Update)

'        dtTemp.Clear()
'        Dim dtRef As DataTable = New DataTable

'        For Each dr In dt.Rows
'            Dim drPlus As DataRow = dtTemp.NewRow

'            For Each cl In dt.Columns
'                Dim cls As String = cl.ToString
'                Dim chk As Boolean = False

'                Dim inMasters = inTemplate.masters.Find(Function(x) x.ClFor = cls)

'                If Not IsNothing(inMasters) Then
'                    Dim guid = New Guid().NewGuid.ToString


'                    drPlus(inMasters.ClTo) = guid.ToString

'                    chk = True
'                End If

'                Dim inMatching = inTemplate.matching.Find(Function(x) x.ClFor = cls)

'                If Not IsNothing(inMatching) Then
'                    If dtTemp.Columns.Contains(inMatching.ClTo) Then
'                        drPlus(inMatching.ClTo) = dr(cls)
'                        chk = True
'                    End If
'                End If

'                Dim inEntrap = inTemplate.Entrap.Find(Function(x) x.Field = cls)
'                If Not IsNothing(inEntrap) Then
'                    chk = True
'                End If

'                If chk = False Then

'                    Dim inPull = inTemplate.Pull.Find(Function(x) x.Field = cls)
'                    If Not IsNothing(inPull) Then
'                        If inPull.status = True Then
'                            If dtTemp.Columns.Contains(inMatching.ClTo) Then
'                                drPlus(inMatching.ClTo) = dr(cls)
'                                chk = True
'                            End If
'                        End If
'                    Else
'                        If dtTemp.Columns.Contains(cls) Then
'                            drPlus(cls) = dr(cls)
'                        End If
'                    End If
'                End If
'            Next

'            If inTemplate.Jointable.Count > 0 Then
'                For Each item In inTemplate.Jointable
'                    Dim guids = New Guid().NewGuid.ToString

'                    If item.Foreign <> "" Then
'                        CreateRef(guids, item, dr, drPlus(item.Foreign).ToString)
'                    Else
'                        CreateRef(guids, item, dr, "")
'                    End If

'                    drPlus(item.column) = guids.ToString

'                    dtRef = Bases.read(item.Tablename)
'                Next
'            End If

'            For Each item In inTemplate.Identity
'                Dim guid = New Guid().NewGuid.ToString
'                drPlus(item.Field) = guid
'            Next

'            dtTemp.Rows.Add(drPlus)

'        Next

'        dtTemp = dtTemp

'        dtRef = dtRef

'        dt = dt

'    Catch ex As Exception
'        ss = ex.Message
'    End Try

'End Sub
'Sub CreateRef(guids As String, template As Model.Jointable, dr As DataRow, Optional foreign As String = "")
'    Dim dt As DataTable = New DataTable

'    Try

'        If template.byTable = "" Then

'            dt = Bases.read(template.Tablename)

'            If IsNothing(dt) Then
'                dt = Bases.Secs.write(querys.Jointable(template.Tablename), template.Tablename, Cases.Update)
'                dt.Clear()
'            End If


'            Dim drItem As DataRow = dt.NewRow()

'            For Each item In template.Twain

'                If dt.Columns.Contains(item.Match) Then
'                    drItem(item.Match) = dr(item.Field)
'                End If

'            Next

'            If dt.Columns.Contains(template.column) Then
'                drItem(template.column) = guids
'            End If

'            If Not IsNothing(template.Foreign) Then

'                If dt.Columns.Contains(template.Foreign) Then

'                    If foreign <> "" Then
'                        drItem(template.Foreign) = foreign
'                    End If
'                End If

'            End If

'            dt.Rows.Add(drItem)
'            dt.AcceptChanges()

'            '  JoinTableItem(template, dt)
'        End If


'    Catch ex As Exception

'    End Try

'End Sub

'Sub JoinTableItem(template As Model.Jointable, dt As DataTable)


'    Dim str As String = "INSERT INTO [dbo].[{0}]({1}) VALUES ({2}) "


'    If template.Twain.Count > 0 Then

'        Dim column As String = ""
'        Dim values As String = ""

'        If dt.Columns.Contains(template.column) Then

'            column &= template.column & ""
'            values &= "'" & dt(0)(template.column).ToString & "'"

'        End If

'        If dt.Columns.Contains(template.Foreign) Then
'            If column <> "" Then
'                column &= ","
'            End If

'            If values <> "" Then
'                values &= ","
'            End If
'            If template.Foreign <> "" Then
'                column &= template.Foreign & ""
'                values &= "'" & dt(0)(template.Foreign).ToString & "'"
'            End If
'        End If


'        For Each item In template.Twain

'            If Not dt.Columns.Contains(item.Match) Then
'                Continue For
'            End If

'            If column <> "" Then
'                column &= ","
'            End If

'            If values <> "" Then
'                values &= ","
'            End If

'            column &= item.Match

'            For Each dr In dt.Rows

'                Select Case dr.GetType.ToString.ToLower
'                    Case "string"
'                        values &= "'" & dr(item.Match).ToString & "'"
'                    Case "integer"
'                        values &= "'" & dr(item.Match) & "'"
'                    Case Else
'                        values &= "'" & dr(item.Match).ToString & "'"
'                End Select

'            Next

'        Next

'        column = column
'        values = values
'        str = String.Format(str, template.Tablename, column, values)

'    End If

'    str = str

'    'Using exe As New connExecute()




'    'End Using




'End Sub

'Function CreateMaster(masters As Model.Master, dr As DataRow) As String

'    Dim guid = New Guid().NewGuid.ToString

'    Try





'    Catch ex As Exception

'    End Try


'End Function



'Class Model


'    Public Class template

'        <JsonProperty("template")>
'        Public Property Template As String

'        <JsonProperty("first")>
'        Public Property first As String

'        <JsonProperty("second")>
'        Public Property second As String

'        <JsonProperty("masters")>
'        Public Property masters As New List(Of Master)

'        <JsonProperty("matching")>
'        Public Property matching As New List(Of matching)

'        <JsonProperty("pull")>
'        Public Property Pull As New List(Of Pull)

'        <JsonProperty("identity")>
'        Public Property Identity As New List(Of Identity)

'        <JsonProperty("entrap")>
'        Public Property Entrap As New List(Of Entrap)

'        <JsonProperty("jointable")>
'        Public Property Jointable As New List(Of Jointable)
'    End Class



'    Public Class matching
'        <JsonProperty("clFor")>
'        Public Property ClFor As String
'        <JsonProperty("clTo")>
'        Public Property ClTo As String
'    End Class

'    Public Class Master

'        <JsonProperty("clFor")>
'        Public Property ClFor As String

'        <JsonProperty("tbFor")>
'        Public Property TbFor As String

'        <JsonProperty("tbTo")>
'        Public Property TbTo As String

'        <JsonProperty("clTo")>
'        Public Property ClTo As String
'    End Class

'    Public Class Pull

'        <JsonProperty("field")>
'        Public Property Field As String

'        <JsonProperty("status")>
'        Public Property status As Boolean
'    End Class

'    Public Class Identity

'        <JsonProperty("field")>
'        Public Property Field As String
'    End Class

'    Public Class Entrap

'        <JsonProperty("field")>
'        Public Property Field As String

'        <JsonProperty("match")>
'        Public Property Match As String
'    End Class
'    Public Class Jointable

'        <JsonProperty("column")>
'        Public Property column As String

'        <JsonProperty("foreign")>
'        Public Property Foreign As String

'        <JsonProperty("tablename")>
'        Public Property Tablename As String

'        <JsonProperty("byTable")>
'        Public Property byTable As String


'        <JsonProperty("twain")>
'        Public Property Twain As New List(Of Twain)
'    End Class
'    Public Class Twain

'        <JsonProperty("field")>
'        Public Property Field As String

'        <JsonProperty("match")>
'        Public Property Match As String
'    End Class


'End Class

#End Region
