Imports Telerik.Web.UI
Imports System.Data
Imports System.IO

Partial Class Master_MasterFileType
    Inherits BasePage
    Dim dt As DataTable
    Dim da As New Mydata(adoconn)
    Dim GetMasterData As GetMasterData
    Dim id_GUID As String
    Dim FormName As String = "MasterFileType"
    Dim cExecute As New connExecute
    Dim temp As String = Server.MapPath("~/Uploads/")

    Property ProgramCode As String
        Get
            If ViewState("ProgramCode") Is Nothing Then
                Return Nothing
            End If
            Return ViewState("ProgramCode")
        End Get

        Set(ByVal Value As String)
            ViewState("ProgramCode") = Value
        End Set
    End Property
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTitle()
        If Not Page.IsPostBack Then
            Me.Title = "ประเภทเอกสาร"
            '================ เก็บ Log ====================='
            InsertLogMenu("TN", FormName, "M", Sys.LoginWeb.UserName)
            '=============================================='
            Call Lang()
            Call GetData()
            Call ChkMenu()
            ViewState("ckDel") = 0

        Else
            If Request.Form("__EVENTTARGET") = "AddItem" Then
                AddItem()
            End If
        End If
    End Sub
    Sub LoadTitle()
        TMsg.LoadTitle("WebTrainingCourseDetail", "Form", Sys.Lang)
        If TMsg.dT_Title.Rows.Count > 0 Then
            Me.Title = Sys.TMsg.Title_Text("WebTrainingCourseDetail")
            Me.ProgramCode = Sys.TMsg.Program_Code("WebTrainingCourseDetail")
            Sys.LoginWeb.MenuCode = ProgramCode
        End If
    End Sub
    Sub Lang()
        If Sys.LoginWeb.Lang <> "T" Then
            TMsg.LoadLang("MasterDetail", Sys.Lang) ' โหลดภาษา และเปลี่ยนภาษา
            If TMsg.dT_Lang.Rows.Count > 0 Then
                Me.Title = Sys.TMsg.Label_Text("lblFileType")
                Dim GridButton As GridButtonColumn = TryCast(GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn)
                GridButton.ConfirmText = Sys.TMsg.Label_Text("lblConfirm")
                GridButton.ConfirmTitle = Sys.TMsg.Label_Text("lblDelTitle")
                Me.GridShowdata.MasterTableView.GetColumn("TnameT").HeaderText = Sys.TMsg.Label_Text("TnameT")
                Me.GridShowdata.MasterTableView.GetColumn("TnameE").HeaderText = Sys.TMsg.Label_Text("TnameE")
                Me.GridShowdata.MasterTableView.GetColumn("TnameO").HeaderText = Sys.TMsg.Label_Text("TnameO")
                Me.GridShowdata.MasterTableView.GetColumn("chkCourse").HeaderText = Sys.TMsg.Label_Text("chkCourse")
                Me.GridShowdata.MasterTableView.GetColumn("chkPerson").HeaderText = Sys.TMsg.Label_Text("chkPerson")
                Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn").HeaderText = Sys.TMsg.Label_Text("lblDelete")
                'Me.GridShowdata.MasterTableView.CommandItemSettings.AddNewRecordText = Sys.TMsg.Label_Text("lblAdd")
                'Me.GridShowdata.MasterTableView.CommandItemSettings.SaveChangesText = Sys.TMsg.Label_Text("lblSave")
                'Me.GridShowdata.MasterTableView.CommandItemSettings.CancelChangesText = Sys.TMsg.Label_Text("lblCancel")
                ViewState("LangHeader") = Sys.TMsg.Label_Text("lblAdd") + "," + Sys.TMsg.Label_Text("lblSave") + "," + Sys.TMsg.Label_Text("lblCancel")
        End If
        End If
    End Sub
    Public Sub ChkMenu()
        Dim dtCkMeun As DataTable = HttpContext.Current.Session("dtCkMenuPerson")
        Dim ndr() As DataRow
        If dtCkMeun.Rows.Count > 0 Then
            ndr = dtCkMeun.Select(" Menu_Code = '" & ProgramCode & "' ")
            If ndr.Count > 0 Then

                'If (DataHelper.ToBoolean(ndr(0)("ckAdd"), False) = False And DataHelper.ToBoolean(ndr(0)("ckEdit"), False) = False) Then
                '    'Button1.Enabled = False  '== ปุ่มตกลง =='
                '    'If (Button1.Enabled = False) Then Button1.CssClass = "myButton2"
                'End If
                'กรณีลบได้อย่างเดียว -> set readonly
                If DataHelper.ToBoolean(ndr(0)("ckAdd"), False) = False AndAlso DataHelper.ToBoolean(ndr(0)("ckEdit"), False) = False Then
                    GridShowdata.MasterTableView.CommandItemSettings.ShowAddNewRecordButton = False
                    GridShowdata.MasterTableView.CommandItemSettings.ShowSaveChangesButton = False
                    GridShowdata.MasterTableView.CommandItemSettings.ShowCancelChangesButton = False
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("TnameT"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("TnameE"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("TnameO"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("chkCourse"), GridTemplateColumn).ReadOnly = True
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("chkPerson"), GridTemplateColumn).ReadOnly = True
                ElseIf DataHelper.ToBoolean(ndr(0)("CkDel"), False) = False Then 'กรณีห้ามลบ  
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridBoundColumn).ReadOnly = True
                End If

                GridShowdata.Rebind()
            End If
        End If
    End Sub
    Sub GetData()
        sqlstr = "select *,'U' as ins from TNM_FileType"
        sqlstr = String.Format(sqlstr, Sys.LoginWeb.Lang)
        dt = da.GetDataTable(sqlstr)

        If dt.Rows.Count > 0 Then
            Me.GridShowdata.DataSource = dt
            Me.GridShowdata.Rebind()
            Session("MasterData") = dt
        Else
            Me.GridShowdata.DataSource = New String() {}
            Me.GridShowdata.DataBind()
            Session("MasterData") = dt
        End If
    End Sub

    Protected Sub GridShowdata_BatchEditCommand(sender As Object, e As GridBatchEditingEventArgs) Handles GridShowdata.BatchEditCommand
        If e.Commands.Count > 0 Then
            Dim commandType As String = ""
            cExecute.BeginTransaction()
            Try
                'For Each command As GridBatchEditingCommand In e.Commands
                '    commandType = command.Type.ToString
                '    Dim newValues As Hashtable = command.NewValues
                '    Dim oldValues As Hashtable = command.OldValues
                '    Dim a As Boolean = newValues("chkCourse")
                '    Dim b As Boolean = newValues("chkPerson")

                '    If command.Type = GridBatchEditingCommandType.Insert Then
                '        id_GUID = Guid.NewGuid.ToString.Trim
                '        Dim sql$ = "insert into TNM_FileType (GUID_FileType,TnameT,TnameE,TnameO,chkCourse,chkPerson) values (?,?,?,?,?,?)"
                '        cExecute.sqlStr = sql
                '        cExecute.cmdConnection()
                '        cExecute.Transaction()
                '        cExecute.sqlParameter_Value("@p1", "NV", Trim(id_GUID))
                '        cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("TnameT") & ""))
                '        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("TnameE") & ""))
                '        cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("TnameO") & ""))
                '        cExecute.sqlParameter_Value("@p5", "B", a)
                '        cExecute.sqlParameter_Value("@p6", "B", b)
                '        cExecute.ExecuteNonQuery()
                '    ElseIf command.Type = GridBatchEditingCommandType.Update Then

                '        Dim id As String = command.Item.GetDataKeyValue("GUID_FileType").ToString()
                '        Dim sql$ = "update TNM_FileType set  TnameT  = ? , TnameE = ? , TnameO = ? ,chkCourse = ? ,chkPerson = ? where GUID_FileType ='" & id & "'"

                '        cExecute.sqlStr = sql
                '        cExecute.cmdConnection()
                '        cExecute.Transaction()
                '        cExecute.sqlParameter_Value("@p1", "NV", Trim(newValues("TnameT") & ""))
                '        cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("TnameE") & ""))
                '        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("TnameO") & ""))
                '        cExecute.sqlParameter_Value("@p4", "B", a)
                '        cExecute.sqlParameter_Value("@p5", "B", b)
                '        cExecute.ExecuteNonQuery()

                '    ElseIf command.Type = GridBatchEditingCommandType.Delete Then
                '        ' cExecute = New connExecute()
                '        Dim id As String = command.Item.GetDataKeyValue("GUID_FileType").ToString()
                '        cExecute.cmdConnection()
                '        cExecute.Transaction()
                '        Dim chk$ = cExecute.ExecuteScalar("select TOP(1) convert(varchar(50),ID) from TNT_File where GUID_FileType ='" & id & "'")
                '        If chk <> "" Then
                '            xMessageBoxRWM_ถูกใช้งานอยู่(RadWindowManager1)
                '            Call GetData()
                '            Exit Sub
                '        Else
                '            cExecute.ExecuteNonQuery("delete TNM_FileType where GUID_FileType ='" & id.ToString() & "" & "'")
                '        End If
                '    End If
                'Next
                '****************************************
                For Each command As GridBatchEditingCommand In e.Commands
                    commandType = command.Type.ToString
                    ViewState("file") = 0
                    If (command.Type = GridBatchEditingCommandType.Insert) Then
                        Dim newValues As Hashtable = command.NewValues
                        Dim oldValues As Hashtable = command.OldValues
                        '-----------------------------------------------------------------------------------------------------
                        ' Do nothing ....

                    ElseIf (command.Type = GridBatchEditingCommandType.Delete) Then
                        Dim id As String = command.Item.GetDataKeyValue("GUID_FileType").ToString()
                        Dim idf As String = command.Item.GetDataKeyValue("ID").ToString()
                        ChkFileUsing(temp, idf + "_")
                        If ViewState("file") = 1 Then
                            ViewState("ckDel") = 1
                            xMessageBoxRWM_ถูกใช้งานอยู่(RadWindowManager1)
                        Else
                            cExecute.cmdConnection()
                            cExecute.Transaction()
                            cExecute.ExecuteNonQuery("delete TNM_FileType where GUID_FileType ='" & id.ToString() & "" & "'")
                        End If

                        'INSERT LOG===================================
                        InsertLogfile(FormName, "", Sys.TMsg.Delete & " " & Me.Title, "-", id, "", "")
                        '=============================================
                        ElseIf (command.Type = GridBatchEditingCommandType.Update) Then
                            Dim newValues As Hashtable = command.NewValues
                            Dim oldValues As Hashtable = command.OldValues
                            Dim a As Boolean = newValues("chkCourse")
                            Dim b As Boolean = newValues("chkPerson")

                            Dim item As GridEditableItem = DirectCast(command.Item, GridEditableItem)
                            Dim id_GUID = item.GetDataKeyValue("GUID_FileType").ToString()
                            Dim chkIns = newValues("ins").ToString()
                            '-----------------------------------------------------------------------------------------------------

                            If chkIns = "I" Then

                                Dim sql$ = "insert into TNM_FileType (GUID_FileType,TnameT,TnameE,TnameO,chkCourse,chkPerson) values (?,?,?,?,?,?)"
                                cExecute.sqlStr = sql
                                cExecute.cmdConnection()
                                cExecute.Transaction()
                                cExecute.sqlParameter_Value("@p1", "NV", Trim(id_GUID))
                                cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("TnameT") & ""))
                                cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("TnameE") & ""))
                                cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("TnameO") & ""))
                                cExecute.sqlParameter_Value("@p5", "B", a)
                                cExecute.sqlParameter_Value("@p6", "B", b)
                                cExecute.ExecuteNonQuery()

                                'INSERT LOG===================================
                            InsertLogfile(FormName, "", Sys.TMsg.Insert & " " & Me.Title & ": " & Trim(newValues("TnameT")), "-", id_GUID, "", "")
                            InsertLogfile(FormName, "", Sys.TMsg.Insert & " " & Me.Title & ": " & Trim(newValues("TnameT")), "-", Trim(newValues("TnameT") & ""), "", "")
                                '=============================================
                            ElseIf chkIns = "U" Then
                                Dim sql$ = "update TNM_FileType set  TnameT  = ? , TnameE = ? , TnameO = ? ,chkCourse = ? ,chkPerson = ? where GUID_FileType ='" & id_GUID & "'"

                                cExecute.sqlStr = sql
                                cExecute.cmdConnection()
                                cExecute.Transaction()
                                cExecute.sqlParameter_Value("@p1", "NV", Trim(newValues("TnameT") & ""))
                                cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("TnameE") & ""))
                                cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("TnameO") & ""))
                                cExecute.sqlParameter_Value("@p4", "B", a)
                                cExecute.sqlParameter_Value("@p5", "B", b)
                                cExecute.ExecuteNonQuery()

                                'INSERT LOG===================================
                                Dim dt As DataTable = TryCast(Session("MasterData"), DataTable)
                                Dim dr As DataRow = dt.AsEnumerable().Where(Function(c) c("GUID_FileType").Equals(Guid.Parse(id_GUID))).[Single]()
                            If Not IsNothing(dr) Then

                                Utility.hasChange(FormName, "", dr("TnameT").ToString(), (newValues("TnameT") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("TnameT").HeaderText & " [ID:" & id_GUID & "]")
                                Utility.hasChange(FormName, "", dr("TnameE").ToString(), (newValues("TnameE") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("TnameE").HeaderText & " [ID:" & id_GUID & "]")
                                Utility.hasChange(FormName, "", dr("TnameO").ToString(), (newValues("TnameO") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("TnameO").HeaderText & " [ID:" & id_GUID & "]")
                                Utility.hasChange(FormName, "", dr("chkCourse"), a, VariableType.varBoolean, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("chkCourse").HeaderText & " [ID:" & id_GUID & "]")
                                Utility.hasChange(FormName, "", dr("chkPerson"), b, VariableType.varBoolean, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("chkPerson").HeaderText & " [ID:" & id_GUID & "]")

                            End If
                                '=============================================
                            End If
                        End If
                Next
                cExecute.Commit()
                If commandType = "Delete" Then
                    If ViewState("ckDel") = 0 Then
                        xMessageBoxRWM_ลบข้อมูลเสร็จเรียบร้อย(RadWindowManager1)
                    End If
                Else
                    xMessageBoxRWM_บันทึกสำเร็จ(RadWindowManager1)
                End If
                Call GetData()
            Catch ex As System.Exception
                cExecute.Rollback()
                xMessageBoxRWM(RadWindowManager1, 300, 120, ex.Message, Sys.TMsg.Warning)
            End Try
        End If
    End Sub


    Protected Sub GridShowdata_ItemCommand(sender As Object, e As GridCommandEventArgs) Handles GridShowdata.ItemCommand
        Dim f As String = e.CommandName.ToString()
        If f = "RebindGrid" Then
            Call GetData()
        End If

    End Sub

    Protected Sub GridShowdata_ItemCreated(sender As Object, e As GridItemEventArgs) Handles GridShowdata.ItemCreated
        If (e.Item.ItemType = GridItemType.CommandItem) Then
            Dim btnAdd As LinkButton = TryCast(e.Item.FindControl("LinkButton2"), LinkButton)
            Dim btnSave As LinkButton = TryCast(e.Item.FindControl("LinkButton3"), LinkButton)
            Dim btnCancel As LinkButton = TryCast(e.Item.FindControl("LinkButton1"), LinkButton)

            If Sys.LoginWeb.Lang <> "T" Then
                TMsg.LoadLang("WebTrainingCourse", Sys.Lang) ' โหลดภาษา และเปลี่ยนภาษา
                If TMsg.dT_Lang.Rows.Count > 0 Then

                    btnAdd.Text = Sys.TMsg.Label_Text("gexHeaderText_Master_Add")
                    btnSave.Text = Sys.TMsg.Label_Text("gexHeaderText_Master_Save")
                    btnCancel.Text = Sys.TMsg.Label_Text("gexHeaderText_Master_Cancel")
                End If
            End If
        End If
    End Sub

    Protected Sub GridShowdata_ItemDataBound(sender As Object, e As GridItemEventArgs) Handles GridShowdata.ItemDataBound
        'If TypeOf e.Item Is GridEditableItem AndAlso e.Item.IsInEditMode Then
        '    Dim editedItem As GridEditableItem = DirectCast(e.Item, GridEditableItem)
        '    Dim rcbctrlname As RadComboBox = TryCast(editedItem.FindControl("rcbExpenses1"), RadComboBox)

        '    Dim dr As DataRowView = CType(e.Item.DataItem, DataRowView)

        '    If Not IsNothing(Session("ComboExpenses")) Then
        '        rcbctrlname.DataSource = Session("ComboExpenses")
        '        rcbctrlname.DataBind()
        '    End If

        '    If Not IsNothing(dr) Then
        '        rcbctrlname.SelectedValue = dr("ExpensesID") & ""

        '    End If


        'ElseIf TypeOf e.Item Is GridDataItem Then
        '    Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
        '    Dim lblExpensesNo As Label = TryCast(item.FindControl("lblExpensesNo"), Label)
        '    Dim lblctrlname As Label = TryCast(item.FindControl("lblExpenses1"), Label)
        '    Dim rcb As RadComboBox = TryCast(item.FindControl("rcbExpenses1"), RadComboBox)
        '    Dim btnDelEx1 As RadButton = TryCast(item.FindControl("btnDelEx1"), RadButton)
        '    Dim dr As DataRowView = CType(e.Item.DataItem, DataRowView)
        '    If Not IsNothing(dr) Then
        '        lblctrlname.Text = Utility.GetMasterData(TryCast(Session("ComboExpenses"), DataTable), "ExpensesID", dr("ExpensesID") & "", "ExpensesTextT")
        '    End If
        '    If Sys.LoginWeb.Lang <> "T" Then
        '        btnDelEx1.ToolTip = Sys.TMsg.Label_Text("lblDelete")
        '    End If
        'End If
        If Sys.LoginWeb.Lang <> "T" Then
            Dim b2 As LinkButton
            Dim b3 As LinkButton
            Dim b1 As LinkButton
            Dim str() As String = ViewState("LangHeader").ToString.Split(",")
            For Each headerItem In GridShowdata.MasterTableView.GetItems(GridItemType.CommandItem)
                b2 = headerItem.FindControl("LinkButton2")
                b2.Text = str(0)
                b3 = headerItem.FindControl("LinkButton3")
                b3.Text = str(1)
                b1 = headerItem.FindControl("LinkButton1")
                b1.Text = str(2)
                Exit For
            Next
        End If
    End Sub

    Protected Sub GridShowdata_NeedDataSource(sender As Object, e As GridNeedDataSourceEventArgs) Handles GridShowdata.NeedDataSource
        Me.GridShowdata.DataSource = Session("MasterData")
    End Sub

    Private Sub AddItem() 'สร้างแถวข้อมูล insert
        Dim dt As DataTable = TryCast(Session("MasterData"), DataTable)
        Dim dr As DataRow

        dr = dt.NewRow()
        dr("GUID_FileType") = Guid.NewGuid.ToString.Trim
        dr("TnameT") = ""
        dr("TnameE") = ""
        dr("TnameO") = ""
        dr("chkCourse") = True
        dr("chkPerson") = True
        dr("ins") = "I"
        dt.Rows.InsertAt(dr, 0)
        Session("TNM_Professor") = dt

        Me.GridShowdata.DataSource = Session("MasterData")
        Me.GridShowdata.DataBind()
    End Sub

    Public Sub ChkFileUsing(ByVal SourcePath As String, name As String) 'เช็คไฟล์ที่ถูกใช้งานอยู่
        Dim SourceDir As DirectoryInfo = New DirectoryInfo(SourcePath)
        Dim pathIndex As Integer
        pathIndex = SourcePath.LastIndexOf("\")
        ' the source directory must exist, otherwise throw an exception

        If SourceDir.Exists Then
            'Dim SubDir As DirectoryInfo
            'For Each SubDir In SourceDir.GetDirectories()
            '    Console.WriteLine(SubDir.Name)
            '    rec(SubDir.FullName, name)
            'Next
            For Each childFile As FileInfo In SourceDir.GetFiles("*", SearchOption.AllDirectories).Where(Function(file) file.Name.ToLower().Contains(name.ToLower()))
                Console.WriteLine(childFile.Name)
                If childFile.Name.Substring(0, name.Length - 1) = name.Split("_")(0) Then
                    ViewState("file") = 1
                    Exit For
                End If
            Next
        End If

    End Sub
End Class
