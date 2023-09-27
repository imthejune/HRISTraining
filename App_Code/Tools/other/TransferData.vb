Imports System.Data
Imports Microsoft.VisualBasic
Imports Newtonsoft.Json

Public Class TransferData
    Dim app As HttpContext
    Dim resolveUrl As String = ""
    Dim sortData As SortedList
    Dim storage As modal.storage = New modal.storage()
    Dim LocalJson As CallBack
    Dim conn As connections

    Sub New(context As HttpContext, resUrl As String)

        app = context
        resolveUrl = resUrl
        conn = New connections

        sortData = New SortedList()
        LocalJson = New CallBack()
        LocalJson.context = app
    End Sub


    Public Sub Load()
        Try


            sortData = Change.context(app)

            Select Case sortData("process")
                Case "init"
                    InitLoad()
                    'Case "main"
                Case "transection"
                    StoreTransection()
                Case "master"
                    StoreMaster()
                Case "CheckProcess"
                    DataProcess()
                Case "StartProcess"
                    StartProcess()
                Case "ClearData"
                    ClearData()
            End Select

        Catch ex As Exception
            LocalJson.exception(ex)
            LocalJson.response()
        End Try

    End Sub
    Public Reports As modal.report
    'Public Property Eventlog As New List(Of modal.Eventlog)
    Public Enum Steps
        defaults = 0
        Plus = 1
        push = 2
        Empty = 3
    End Enum

    Public Enum trans
        Defaults = 0
        CopyToInsert = 1
        KeyToForeign = 2
    End Enum
    Sub ClearData()


        Try


            ' Dim cExecute As New connExecute
            'sqlstr = " truncate table TNM_Course"
            'sqlstr += " truncate table TNM_Expenses"
            'sqlstr += " truncate table TNM_FileType"
            'sqlstr += " truncate table TNM_GroupCourse"
            'sqlstr += " truncate table TNM_InstitueTrain"
            'sqlstr += " truncate table TNM_Organize"
            'sqlstr += " truncate table TNM_Patern_ReF"
            'sqlstr += " truncate table TNM_Professor"
            'sqlstr += " truncate table TNM_TmpPass"
            'sqlstr += " truncate table TNM_Type_Patern"
            'sqlstr += " truncate table TNM_TypeCourse"
            'sqlstr += " truncate table TNT_ftfy1text"
            'sqlstr += " truncate table TNT_Fyfp22"
            'sqlstr += " truncate table TNT_FyfpPerson"
            'sqlstr += " truncate table TNT_FyfpProfessor"
            'sqlstr += " truncate table TNT_FyfpQualification"
            'sqlstr += " truncate table TNT_FyfpSendPerson"
            'sqlstr += " truncate table TNT_FyfpTrain"
            'sqlstr += " truncate table TNT_FyfpTrainPerson"
            'sqlstr += " truncate table TNT_FyfpVt"
            'sqlstr += " truncate table TNT_FyfpVttopic"
            'sqlstr += " truncate table TNT_Patern_Course"
            'sqlstr += " truncate table TNT_Patern_Professor"
            'sqlstr += " truncate table TNT_PercentGrade"
            'sqlstr += " truncate table TNT_ProcessFyfp"
            'sqlstr += " truncate table TNT_ProcessSt"
            'sqlstr += " truncate table TNT_Qualifications"
            'sqlstr += " truncate table TNT_St22Cert"
            'sqlstr += " truncate table TNT_St22Person"
            'sqlstr += " truncate table TNT_stText"
            'sqlstr += " truncate table TNT_SubFyfp"
            'sqlstr += " truncate table TNT_TrainDay"
            'sqlstr += " truncate table TNT_TrainExpenses"
            'sqlstr += " truncate table TNT_TrainPerson"
            'sqlstr += " truncate table TNT_TrainPersonEvaluation"
            'sqlstr += " truncate table TNT_Vt"
            'sqlstr += " truncate table TNT_Vttopic"
            'cExecute.sqlStr = sqlstr
            'cExecute.cmdConnection()
            'cExecute.ExecuteNonQuery()
            'cExecute.Close()

        Catch ex As Exception

        End Try

    End Sub
    Sub StartProcess()

        Try


            For Each item As modal.Eventlog In Eventlog

                GanerateScript(item)

            Next



            LocalJson.classTodata(Of List(Of modal.Eventlog))(Eventlog)


        Catch ex As Exception
            LocalJson.exception(ex)

        End Try

        LocalJson.response()
    End Sub

    Sub GanerateScript(logger As modal.Eventlog)

        Dim dt As DataTable = New DataTable

        Dim str As String = ""
        Dim errors As String = ""
        Try

            ' Header & body : Request call
            sortData = Change.context(app)

            ' Modal storage
            storage = Clients.read(Of modal.storage)(path("storage"))

            Dim template = Clients.read(Of modal.template)(path(logger.Tablename))

            dt = Bases.read("To_" & logger.Tablename)

            If IsNothing(dt) Then
                str = ""
                Exit Try
            End If

            If dt.Rows.Count = 0 Then
                str = ""
                Exit Try
            End If

            Dim generateList As New ArrayList()

            Using exe As New connExecute(conn.BaseTo)
                exe.BeginTransaction()

                Try

                    For Each row In dt.Rows

                        Dim tablelog = logger.Transfer.FirstOrDefault(Function(x) x.newValue = row(template.ColumnTo.Name).ToString)

                        Dim reportLogger As New modal.report
                        reportLogger.Code = tablelog.Code
                        Try

                            str = ""

                            If Not IsNothing(template.ColumnTo) And template.ColumnTo.Type <> "Decimal" Then

                                Dim ifexists As String = "IF NOT EXISTS ( SELECT * FROM [{0}] WHERE {1}='{2}')"

                                str = String.Format(ifexists, template.TableTo, template.ColumnTo.Name, row(template.ColumnTo.Name).ToString)
                            End If


                            str &= " BEGIN  INSERT INTO [dbo].[{0}]({1}) VALUES ({2})  END"

                            Dim column As ArrayList = New ArrayList()
                            Dim values As ArrayList = New ArrayList()
                            Dim types As ArrayList = New ArrayList()
                            For Each col In dt.Columns

                                Dim columnName As String = col.ToString()

                                If template.Entraps.Contains(columnName) Then

                                    Dim matching = template.Matchings.Find(Function(x) x.Column = columnName)

                                    If IsNothing(matching) Then
                                        Continue For
                                    End If

                                    If Not matching.Option.Duplicate Then
                                        Continue For
                                    End If
                                End If

                                If columnName = "P_ID" Then
                                    Continue For
                                End If

                                column.Add(columnName)
                                types.Add(col.DataType().Name)

                                Select Case col.DataType().name
                                    Case "Double", "Decimal", "Int32"
                                        values.Add(Val(row(columnName) & ""))
                                    Case "Guid", "String"
                                        If row(columnName).ToString() <> "" Then
                                            values.Add("N'" & row(columnName).ToString() & "'")
                                        Else
                                            values.Add("NULL")
                                        End If
                                    Case "Boolean"
                                        values.Add(Val(columnName & ""))
                                    Case "DateTime"
                                        If row(columnName).ToString() <> "" Then
                                            values.Add("CAST(N'" & row(columnName).ToString & "' AS DateTime)")
                                        Else
                                            values.Add("NULL")
                                        End If
                                End Select

                            Next
                            str = String.Format(str, template.TableTo, String.Join(",", column.ToArray()), String.Join(",", values.ToArray()))

                            reportLogger.[Text] = str


                            exe.sqlStr = str
                            exe.cmdConnection()
                            exe.Transaction()
                            exe.ExecuteNonQuery()

                            reportLogger.Message = "Succeed :" & tablelog.newValue
                            reportLogger.succeed = 1

                        Catch ex As Exception

                            If ex.Message.IndexOf("Violation of PRIMARY KEY constraint") > -1 And ex.Message.IndexOf("Cannot insert duplicate key in object") > -1 Then

                                reportLogger.Message = "Succeed :" & tablelog.newValue
                                reportLogger.succeed = 1
                            Else
                                reportLogger.Message = ex.Message.ToString()
                                reportLogger.errors = 1

                            End If
                        End Try
                        logger.Report.Add(reportLogger)
                    Next

                    exe.Commit()

                Catch ex As Exception
                    exe.Rollback()
                End Try

            End Using

        Catch ex As Exception

        End Try


    End Sub

    Sub DataProcess()

        Try


            ' Header & body : Request call
            sortData = Change.context(app)

            ' Modal storage
            storage = Clients.read(Of modal.storage)(path("storage"))

            ' Use - Template transecion ?
            Dim template = getTemplate(sortData("code")) 'Clients.read(Of modal.template)(path(sortData("code")))

            If IsNothing(template) Then
                Exit Try
            End If

            FindAndInsert(template)

            Eventlog = Eventlog



            LocalJson.classTodata(Of List(Of modal.Eventlog))(Eventlog)


        Catch ex As Exception
            LocalJson.exception(ex)

        End Try

        LocalJson.response()

    End Sub

    Function FindAndInsert(template As modal.template, Optional oldkey As Object = Nothing, Optional sendKey As Object = Nothing) As Object

        Dim KeyRow As Object = New Object
        Dim dt As DataTable = New DataTable
        Dim dtFor As DataTable = New DataTable
        Dim dtTo As DataTable = New DataTable

        'Dim tablelog As New modal.Eventlog

        'tablelog.Tablename = template.Name
        'tablelog.Transfer = New List(Of modal.Transfer)

        Dim tablelog = Eventlog.FirstOrDefault(Function(x) x.Tablename = template.Name)

        If IsNothing(tablelog) Then
            tablelog = New modal.Eventlog
            tablelog.Tablename = template.Name
            tablelog.Transfer = New List(Of modal.Transfer)
        End If

        Try

            Bases.xConnect = conn.BaseFor
            If Not IsNothing(oldkey) Then

                Select Case oldkey.GetType.Name.ToLower
                    Case "guid"
                        KeyRow = oldkey.ToString
                    Case "decimal", "double"
                        KeyRow = oldkey
                    Case Else
                        KeyRow = oldkey
                End Select


                'If typeCase = trans.Defaults Then
                If IsNothing(sendKey) Then
                    Dim str$ = querys.WhereMasters(template.TableFor, template.ColumnFor.Name & "='" & KeyRow & "'")
                    dtFor = Bases.Secs.write(str, "Cyber_" & template.TableFor, Cases.Update)
                Else
                    Dim str$ = querys.WhereMasters(template.TableFor, template.SearchColumn & "='" & KeyRow & "'")
                    dtFor = Bases.Secs.write(str, "Cyber_" & template.TableFor, Cases.Update)
                End If


            Else
                ' ตารางที่ใช้ต้องการโอนข้อมูล จากที่ไหน
                dtFor = Bases.read(template.TableFor)
                KeyRow = New Guid().NewGuid.ToString
            End If


            ' ต้องการให้ข้อมูลไปที่ตารางไหน
            Bases.xConnect = conn.BaseTo

            dtTo = Bases.read("To_" & template.Name)

            If IsNothing(dtTo) Then
                dtTo = Bases.Secs.write(querys.Transection(template.TableTo), "To_" & template.Name, Cases.Update)
            End If


            For Each dr In dtFor.Rows
                Dim transferlog As New modal.Transfer
                transferlog.Code = Key.uuid()
                Dim drPlus As DataRow = dtTo.NewRow
                Dim pulls As Steps = Steps.defaults

                Try


                    For Each cl In dtFor.Columns

                        Dim steps As Steps = Steps.defaults
                        Dim ColumnName As String = cl.ToString

                        ' เช็คว่า foreign ของตาราง Master หรือเปล่า
                        Dim foreigns = template.Foreigns.Find(Function(x) x.Column = ColumnName)

                        If Not IsNothing(foreigns) Then

                            Dim keys = dr(ColumnName)


                            Select Case cl.DataType().Name.ToLower
                                Case "decimal", "double"
                                    keys = Val(keys & "")
                                Case "guid", "string"
                                    keys = Trim(keys)
                                Case Else
                                    keys = keys
                            End Select

                            drPlus(foreigns.ColumnTo) = FindAndInsert(getTemplate(foreigns.Refer), keys)
                            steps = Steps.defaults

                        End If

                        ' ตรวจสอบ Field ไม่ต้องการให้ จับคู่ Field ต่างๆ ที่ไม่ต้องการเอาข้อมูลจากของเก่า
                        Dim addition = template.Additions.Find(Function(x) x.Column = ColumnName)
                        If Not IsNothing(addition) Then

                            Dim strSelect As String = "{0} Like '%{1}'"

                            If Not String.IsNullOrEmpty(dr(addition.Column).ToString()) Then

                                strSelect = String.Format(strSelect, addition.ColumnTo, dr(addition.Column))

                                Dim drCheck() As DataRow = dtTo.Select(strSelect)

                                If drCheck.Length > 0 Then
                                    For Each r In drCheck
                                        KeyRow = r(template.ColumnTo.Name).ToString
                                    Next

                                    pulls = Steps.Plus
                                    Exit Try
                                End If
                            End If

                        End If

                        Dim matching = template.Matchings.Find(Function(x) x.Column = ColumnName)

                        If Not IsNothing(matching) Then

                            If matching.Option.Duplicate Then

                                drPlus(matching.ColumnTo) = dr(ColumnName)
                                steps = Steps.Plus

                            End If

                            If matching.Option.NotEmpty Then

                                If String.IsNullOrEmpty(dr(addition.Column).ToString()) Then

                                    Dim codes = "TF-" & Key.uuid(4)
                                    Dim strSelect As String = ""

                                    strSelect = String.Format("{0} Like '%{1}'", matching.ColumnTo, codes)

                                    Dim drCheck() As DataRow = dtTo.Select(strSelect)
                                    If drCheck.Length = 0 Then
                                        drPlus(matching.ColumnTo) = codes
                                    End If
                                Else
                                    drPlus(matching.ColumnTo) = dr(ColumnName)
                                End If

                                steps = Steps.Plus
                            End If

                            If matching.Option.Instead Then
                                drPlus(matching.ColumnTo) = sendKey
                                steps = Steps.Plus
                            End If

                            If matching.Option.Replaces Then
                                Dim newData As String = ""
                                Dim repl As String = String.Format(matching.Option.Format, dr(ColumnName))
                                If dr(ColumnName).ToString.Length <= 1 Then
                                    newData = "0" & repl
                                Else
                                    newData = repl
                                End If

                                drPlus(matching.ColumnTo) = newData
                                steps = Steps.Plus
                            End If


                        End If

                        Dim matchingTo = template.Matchings.Find(Function(x) x.Column = "M_" & ColumnName)

                        If Not IsNothing(matchingTo) Then
                            If matchingTo.Option.Calculators Then
                                If IsNothing(matchingTo.Option.Conditions) Then
                                    Continue For
                                End If

                                Select Case matchingTo.Option.Conditions.Type
                                    Case "multiply"

                                        drPlus(matchingTo.ColumnTo) = dr(ColumnName) * matchingTo.Option.Conditions.[Value]
                                        steps = Steps.Plus
                                End Select
                            End If
                        End If

                        ' Field ไม่ต้องการให้ อัปเดตค่า เก่า ไป ใหม่ หรือ อาจมี ตารางใหม่ ที่เกี่ยวข้องกับ Field นี้
                        If template.Entraps.Length > 0 Then
                            If template.Entraps.Contains(ColumnName) Then
                                steps = Steps.Plus
                            End If
                        End If

                        ' Field
                        Dim defaultvals = template.Defaultvals.Find(Function(x) x.Column = ColumnName)
                        If Not IsNothing(defaultvals) Then

                            drPlus(defaultvals.Column) = defaultvals.Value
                            steps = Steps.Plus
                        End If


                        If steps = Steps.defaults Then
                            If Not dtTo.Columns.Contains(ColumnName) Then Continue For
                            drPlus(ColumnName) = dr(ColumnName)
                        End If

                    Next

                    For Each item In template.Defaultvals
                        If drPlus.Table.Columns.Contains(item.Column) Then
                            drPlus(item.Column) = item.Value
                        End If
                    Next




                    If Not IsNothing(template.ColumnTo) And Not IsNothing(template.ColumnFor) Then

                        If pulls <> Steps.defaults Or IsNothing(oldkey) OrElse (Not IsNothing(oldkey) And (oldkey.GetType.Name = "Decimal" Or oldkey.GetType.Name = "Double")) Then
                            KeyRow = New Guid().NewGuid().ToString
                        End If

                        If template.ColumnTo.Type <> "Decimal" Then

                            drPlus(template.ColumnTo.Name) = KeyRow.ToString

                            transferlog.newValue = drPlus(template.ColumnTo.Name).ToString
                        End If

                        If dtFor.Columns.Contains(template.ColumnFor.Name) Then
                            transferlog.oldValue = dr(template.ColumnFor.Name)
                        Else
                            transferlog.oldValue = 0
                        End If
                    End If

                    If Not IsNothing(template.Transections) Then

                        For Each item In template.Transections

                            Select Case item.Type
                                Case trans.CopyToInsert, "CopyToInsert"
                                    drPlus(item.ColumnTo) = FindAndInsert(getTemplate(item.Refer), dr(item.Column), drPlus(item.ColumnSend))
                                    KeyRow = drPlus(item.ColumnTo)
                                Case trans.KeyToForeign, "KeyToForeign"
                                    FindAndInsert(getTemplate(item.Refer), dr(item.Column), drPlus(item.ColumnSend))
                            End Select

                        Next
                    End If

                    If pulls = Steps.defaults Then
                        dtTo.Rows.Add(drPlus)
                        tablelog.Transfer.Add(transferlog)
                    End If
                Catch ex As Exception
                    transferlog.Message = ex.Message
                End Try

            Next

        Catch ex As Exception
            KeyRow = ""
        End Try

        Bases.Secs.plus(dtTo, "To_" & template.Name, Cases.Update)

        Dim chkEvents = Eventlog.FirstOrDefault(Function(x) x.Tablename = template.Name)
        If IsNothing(chkEvents) Then
            Eventlog.Add(tablelog)

        End If

        Select Case KeyRow.GetType.Name.ToLower
            Case "decimal", "double"
                KeyRow = DBNull.Value
        End Select

        FindAndInsert = KeyRow
    End Function

    Function getTemplate(target) As Object
        Return Clients.read(Of modal.template)(path(target))
    End Function

    Sub StoreMaster()

        Dim dt As DataTable = New DataTable
        Dim dtCyber As DataTable = New DataTable

        Try

            Bases.Start()
            Eventlog = New List(Of modal.Eventlog)
            sortData = Change.context(app)
            storage = Clients.read(Of modal.storage)(path("storage"))

            Dim masters = storage.Master.Find(Function(x) x.Code = sortData("code"))




            Dim template = Clients.read(Of modal.template)(path(masters.Template))

            If IsNothing(template) Then
                Exit Try
            End If


            Bases.xConnect = conn.BaseFor

            '"cyber",
            dtCyber = Bases.Secs.write(querys.Transection(template.TableFor, ""), template.TableFor)

            LocalJson.data(String.Format("{0}", dtCyber.Rows.Count))

        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()

    End Sub
    Sub StoreTransection()

        Dim dt As DataTable = New DataTable
        Dim dtCyber As DataTable = New DataTable

        Try

            Bases.Start()
            Eventlog = New List(Of modal.Eventlog)
            sortData = Change.context(app)
            storage = Clients.read(Of modal.storage)(path("storage"))

            Dim transection = storage.Transection.Find(Function(x) x.Code = sortData("code"))

            If IsNothing(transection) Then

            End If
            transection = transection

            Dim template = Clients.read(Of modal.template)(path(transection.Template))

            If IsNothing(template) Then
                Exit Try
            End If


            Bases.xConnect = conn.BaseFor

            '"cyber",
            dtCyber = Bases.Secs.write(querys.Transection(template.TableFor, ""), template.TableFor)

            LocalJson.data(String.Format("{0}", dtCyber.Rows.Count))

        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()
    End Sub


    Sub InitLoad()

        Try

            storage = Clients.read(Of modal.storage)(path("storage"))

            storage = storage

            LocalJson.classTodata(Of modal.storage)(storage)


        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()

    End Sub

    Function path(p As String) As String
        Return HttpContext.Current.Server.MapPath(String.Format("{1}modal/{0}.json", p, resolveUrl))
    End Function

    Public Property Eventlog() As List(Of modal.Eventlog)

        Get
            Return HttpContext.Current.Session("transfer_temp")
        End Get
        Set(value As List(Of modal.Eventlog))
            HttpContext.Current.Session("transfer_temp") = value
        End Set

    End Property

    Public Class modal


        Public Class report

            <JsonProperty("code")>
            Public Property Code As String
            <JsonProperty("succeed")>
            Public Property succeed As Integer = 0

            <JsonProperty("errors")>
            Public Property errors As Integer = 0

            <JsonProperty("Message")>
            Public Property Message As String

            <JsonProperty("text")>
            Public Property [Text] As String
        End Class

        Public Class Transfer

            <JsonProperty("code")>
            Public Property Code As String

            <JsonProperty("oldValue")>
            Public Property oldValue As String

            <JsonProperty("newValue")>
            Public Property newValue As String

            <JsonProperty("message")>
            Public Property Message As String

        End Class

        Public Class Eventlog

            <JsonProperty("tablename")>
            Public Property Tablename As String

            <JsonProperty("transfer")>
            Public Property Transfer As New List(Of Transfer)

            <JsonProperty("report")>
            Public Property Report As New List(Of report)
        End Class

        Public Class Transections

            <JsonProperty("column")>
            Public Property Column As String

            <JsonProperty("columnTo")>
            Public Property ColumnTo As String

            <JsonProperty("columnSend")>
            Public Property ColumnSend As String

            <JsonProperty("refer")>
            Public Property Refer As String

            <JsonProperty("type")>
            Public Property Type As String
        End Class

        Public Class storage

            <JsonProperty("connection")>
            Public Property Connection As New Connection

            <JsonProperty("main")>
            Public Property Main As List(Of Fields)

            <JsonProperty("transection")>
            Public Property Transection As New List(Of Fields)

            <JsonProperty("master")>
            Public Property Master As New List(Of Fields)
        End Class
        Public Class Connection

            <JsonProperty("BaseTo")>
            Public Property BaseTo As String

            <JsonProperty("BaseFor")>
            Public Property BaseFor As String
        End Class
        Public Class Fields
            <JsonProperty("code")>
            Public Property Code As String

            <JsonProperty("template")>
            Public Property Template As String

            <JsonProperty("title")>
            Public Property Title As String

            <JsonProperty("status")>
            Public Property Status As Boolean
        End Class

        Public Class template

            <JsonProperty("name")>
            Public Property Name As String

            <JsonProperty("tableTo")>
            Public Property TableTo As String

            <JsonProperty("tableFor")>
            Public Property TableFor As String

            <JsonProperty("typeColumn")>
            Public Property TypeColumn As String

            <JsonProperty("searchColumn")>
            Public Property SearchColumn As String

            <JsonProperty("columnTo")>
            Public Property ColumnTo As New ColumnPropt

            <JsonProperty("columnFor")>
            Public Property ColumnFor As New ColumnPropt


            <JsonProperty("foreigns")>
            Public Property Foreigns As New List(Of Foreign)


            <JsonProperty("matchings")>
            Public Property Matchings As New List(Of Matching)


            <JsonProperty("entraps")>
            Public Property Entraps As String()

            <JsonProperty("additions")>
            Public Property Additions As New List(Of Addition)

            <JsonProperty("defaultvals")>
            Public Property Defaultvals As New List(Of Defaultval)

            <JsonProperty("transections")>
            Public Property Transections As New List(Of Transections)
        End Class

        Public Class Defaultval
            <JsonProperty("column")>
            Public Property Column As String

            <JsonProperty("value")>
            Public Property Value As String
        End Class
        Public Class Addition

            <JsonProperty("column")>
            Public Property Column As String

            <JsonProperty("columnTo")>
            Public Property ColumnTo As String

        End Class

        Public Class Matching

            <JsonProperty("column")>
            Public Property Column As String

            <JsonProperty("columnTo")>
            Public Property ColumnTo As String

            <JsonProperty("refer")>
            Public Property Refer As String

            <JsonProperty("option")>
            Public Property [Option] As New Options
        End Class

        Public Class Options
            <JsonProperty("duplicate")>
            Public Property Duplicate As Boolean = False
            <JsonProperty("instead")>
            Public Property Instead As Boolean = False

            <JsonProperty("replaces")>
            Public Property Replaces As Boolean = False

            <JsonProperty("format")>
            Public Property Format As String

            <JsonProperty("calculator")>
            Public Property Calculators As Boolean = False

            <JsonProperty("condition")>
            Public Property Conditions As New Condition

            <JsonProperty("NotEmpty")>
            Public Property NotEmpty As Boolean = False
        End Class

        Public Class Condition
            <JsonProperty("type")>
            Public Property Type As String

            <JsonProperty("value")>
            Public Property Value As Integer
        End Class

        Public Class Foreign

            <JsonProperty("column")>
            Public Property Column As String

            <JsonProperty("columnTo")>
            Public Property ColumnTo As String

            <JsonProperty("refer")>
            Public Property Refer As String

            <JsonProperty("type")>
            Public Property Type As String
        End Class

        Public Class ColumnPropt

            <JsonProperty("name")>
            Public Property Name As String

            <JsonProperty("Type")>
            Public Property Type As String
        End Class


    End Class


    Dim querys As New Query
    Structure Query

        Dim storage As modal.storage



        Public Function Transection(tb As String, Optional where As String = "") As String

            Dim w$ = " "

            If where <> "" Then
                w = String.Format("where {0}", where)
            End If


            str = ""
            str &= "SELECT  * FROM [dbo].[{0}] {1} "

            Transection = String.Format(str, tb, w)

        End Function
        Public Function WhereMasters(tb As String, Optional where As String = "") As String

            Dim w$ = " "

            If where <> "" Then
                w = String.Format("where {0}", where)
            End If

            str = ""
            str &= "SELECT * FROM  [dbo].[{0}] {1}"

            WhereMasters = String.Format(str, tb, w)

        End Function

        Public Function Masters(tb As String, Optional where As String = "") As String

            Dim w$ = " "

            If where <> "" Then
                w = String.Format("where {0}", where)
            End If

            str = ""
            str &= "SELECT * FROM  [dbo].[{0}] {1}"

            Masters = String.Format(str, tb, w)

        End Function

        Public Property str As String

        Public Function Jointable(table As String) As String

            str = "SELECT TOP 1 * FROM [{0}]"

            Jointable = String.Format(str, table)

        End Function

    End Structure
End Class
