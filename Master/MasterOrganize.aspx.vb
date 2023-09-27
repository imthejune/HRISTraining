Imports Telerik.Web.UI
Imports System.Data
Partial Class Master_MasterOrganize
    Inherits BasePage
    Dim dt As DataTable
    Dim da As New Mydata(adoconn)
    Dim GetMasterData As GetMasterData
    Dim id_GUID As String
    Dim FormName As String = "MasterOrganize"
    Dim cExecute As New connExecute
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
            Me.Title = "หน่วยงานที่จัดฝึกอบรม"
            '================ เก็บ Log ====================='
            InsertLogMenu("TN", FormName, "M", Sys.LoginWeb.UserName)
            '=============================================='

            Call Lang()
            Call GetData()
            Call ChkMenu()
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
                Me.Title = Sys.TMsg.Label_Text("lblOrganize")
                Dim GridButton As GridButtonColumn = TryCast(GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn)
                GridButton.ConfirmText = Sys.TMsg.Label_Text("lblConfirm")
                GridButton.ConfirmTitle = Sys.TMsg.Label_Text("lblDelTitle")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_Code").HeaderText = Sys.TMsg.Label_Text("Organize_Code")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_NameT").HeaderText = Sys.TMsg.Label_Text("Organize_NameT")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_NameE").HeaderText = Sys.TMsg.Label_Text("Organize_NameE")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_NameO").HeaderText = Sys.TMsg.Label_Text("Organize_NameO")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_Tel").HeaderText = Sys.TMsg.Label_Text("Organize_Tel")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_Address").HeaderText = Sys.TMsg.Label_Text("Organize_Address")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_Detail").HeaderText = Sys.TMsg.Label_Text("Organize_Detail")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_Reason").HeaderText = Sys.TMsg.Label_Text("Organize_Reason")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_Fax").HeaderText = Sys.TMsg.Label_Text("Organize_Fax")
                Me.GridShowdata.MasterTableView.GetColumn("Organize_ConPerson").HeaderText = Sys.TMsg.Label_Text("Organize_ConPerson")
                Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn").HeaderText = Sys.TMsg.Label_Text("lblDelete")
                Me.GridShowdata.MasterTableView.CommandItemSettings.AddNewRecordText = Sys.TMsg.Label_Text("lblAdd")
                Me.GridShowdata.MasterTableView.CommandItemSettings.SaveChangesText = Sys.TMsg.Label_Text("lblSave")
                Me.GridShowdata.MasterTableView.CommandItemSettings.CancelChangesText = Sys.TMsg.Label_Text("lblCancel")
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
                    'GridShowdata.MasterTableView.CommandItemSettings.ShowAddNewRecordButton = False
                    'GridShowdata.MasterTableView.CommandItemSettings.ShowSaveChangesButton = False
                    'GridShowdata.MasterTableView.CommandItemSettings.ShowCancelChangesButton = False
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_Code"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_NameT"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_NameE"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_NameO"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_Tel"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_Address"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_Detail"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_Reason"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_Fax"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Organize_ConPerson"), GridBoundColumn).ReadOnly = True
                ElseIf DataHelper.ToBoolean(ndr(0)("CkDel"), False) = False Then 'กรณีห้ามลบ  
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridBoundColumn).ReadOnly = True
                End If

                GridShowdata.Rebind()
            End If
        End If
    End Sub
    Sub GetData()
        sqlstr = "select * from TNM_Organize"
        sqlstr = String.Format(sqlstr, Sys.LoginWeb.Lang)
        dt = da.GetDataTable(sqlstr)

        If dt.Rows.Count > 0 Then
            Me.GridShowdata.DataSource = dt
            Me.GridShowdata.Rebind()
            Session("MasterData") = dt
        Else
            Me.GridShowdata.DataSource = New String() {}
            Me.GridShowdata.DataBind()
            Session("MasterData") = New String() {}
        End If
    End Sub

    Protected Sub GridShowdata_BatchEditCommand(sender As Object, e As GridBatchEditingEventArgs) Handles GridShowdata.BatchEditCommand
        If e.Commands.Count > 0 Then
            Dim commandType As String = ""
            cExecute.BeginTransaction()
            Try
                For Each command As GridBatchEditingCommand In e.Commands
                    commandType = command.Type.ToString
                    Dim newValues As Hashtable = command.NewValues
                    Dim oldValues As Hashtable = command.OldValues
                    If command.Type = GridBatchEditingCommandType.Insert Then
                        id_GUID = Guid.NewGuid.ToString.Trim
                        Dim sql$ = "insert into TNM_Organize (GUID_Organize,Organize_NameT,Organize_NameE,Organize_Tel,Organize_Address,Organize_Detail,Organize_Reason,Organize_Fax,Organize_ConPerson,Organize_Code,Organize_NameO) "
                        sql += " values (?,?,?,?,?,?,?,?,?,?,?)"
                        cExecute.sqlStr = sql
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        cExecute.sqlParameter_Value("@p1", "NV", Trim(id_GUID))
                        cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("Organize_NameT") & ""))
                        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("Organize_NameE") & ""))
                        cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("Organize_Tel") & ""))
                        cExecute.sqlParameter_Value("@p5", "NV", Trim(newValues("Organize_Address") & ""))
                        cExecute.sqlParameter_Value("@p6", "NV", Trim(newValues("Organize_Detail") & ""))
                        cExecute.sqlParameter_Value("@p7", "NV", Trim(newValues("Organize_Reason") & ""))
                        cExecute.sqlParameter_Value("@p8", "NV", Trim(newValues("Organize_Fax") & ""))
                        cExecute.sqlParameter_Value("@p9", "NV", Trim(newValues("Organize_ConPerson") & ""))
                        cExecute.sqlParameter_Value("@p10", "NV", Trim(newValues("Organize_Code") & ""))
                        cExecute.sqlParameter_Value("@p11", "NV", Trim(newValues("Organize_NameO") & ""))
                        cExecute.ExecuteNonQuery()

                        'INSERT LOG===================================
                        InsertLogfile(FormName, "", Sys.TMsg.Insert & " " & Me.Title & ": " & Trim(newValues("Organize_Code")) & ":" & Trim(newValues("Organize_NameT") & ""), "-", id_GUID, "", "")
                        '=============================================
                    ElseIf command.Type = GridBatchEditingCommandType.Update Then

                        Dim id As String = command.Item.GetDataKeyValue("GUID_Organize").ToString()

                        Dim sql$ = "update TNM_Organize set  Organize_NameT = ? ,Organize_NameE = ? ,Organize_Tel = ? ,Organize_Address = ? ,Organize_Detail = ? ,Organize_Reason = ? "
                        sql += " ,Organize_Fax = ? ,Organize_ConPerson = ? ,Organize_Code = ? ,Organize_NameO = ? where GUID_Organize ='" & id & "'"

                        cExecute.sqlStr = sql
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        cExecute.sqlParameter_Value("@p1", "NV", Trim(newValues("Organize_NameT") & ""))
                        cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("Organize_NameE") & ""))
                        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("Organize_Tel") & ""))
                        cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("Organize_Address") & ""))
                        cExecute.sqlParameter_Value("@p5", "NV", Trim(newValues("Organize_Detail") & ""))
                        cExecute.sqlParameter_Value("@p6", "NV", Trim(newValues("Organize_Reason") & ""))
                        cExecute.sqlParameter_Value("@p7", "NV", Trim(newValues("Organize_Fax") & ""))
                        cExecute.sqlParameter_Value("@p8", "NV", Trim(newValues("Organize_ConPerson") & ""))
                        cExecute.sqlParameter_Value("@p9", "NV", Trim(newValues("Organize_Code") & ""))
                        cExecute.sqlParameter_Value("@p10", "NV", Trim(newValues("Organize_NameO") & ""))
                        cExecute.ExecuteNonQuery()

                        'INSERT LOG===================================
                        Try
                            Dim dt As DataTable = TryCast(Session("MasterData"), DataTable)
                            Dim dr As DataRow = dt.AsEnumerable().Where(Function(c) c("GUID_Organize").Equals(Guid.Parse(id))).[Single]()
                            If Not IsNothing(dr) Then
                                Utility.hasChange(FormName, "", dr("Organize_NameT").ToString(), newValues("Organize_NameT").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_NameT").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_NameE").ToString(), (newValues("Organize_NameE") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_NameE").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_Tel").ToString(), (newValues("Organize_Tel") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_Tel").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_Address").ToString(), (newValues("Organize_Address") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_Address").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_Detail").ToString(), (newValues("Organize_Detail") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_Detail").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_Reason").ToString(), (newValues("Organize_Reason") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_Reason").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_Fax").ToString(), (newValues("Organize_Fax") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_Fax").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_ConPerson").ToString(), (newValues("Organize_ConPerson") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_ConPerson").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_Code").ToString(), (newValues("Organize_Code") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_Code").HeaderText & " [ID:" & id & "]")
                                Utility.hasChange(FormName, "", dr("Organize_NameO").ToString(), (newValues("Organize_NameO") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Organize_NameO").HeaderText & " [ID:" & id & "]")
                            End If
                        Catch ex As Exception
                        End Try
                        '=============================================
                    ElseIf command.Type = GridBatchEditingCommandType.Delete Then
                        Dim id As String = command.Item.GetDataKeyValue("GUID_Organize").ToString()
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        Dim chk$ = cExecute.ExecuteScalar("select convert(varchar(50),Patern_ID) from TNT_Patern_Course where GUID_Organize ='" & id & "'")
                        If chk <> "" Then
                            xMessageBoxRWM_ถูกใช้งานอยู่(RadWindowManager1)
                            Exit Sub
                        Else
                            cExecute.ExecuteNonQuery("delete TNM_Organize where GUID_Organize ='" & id & "'")

                            'INSERT LOG===================================
                            InsertLogfile(FormName, "", Sys.TMsg.Delete & " " & Me.Title, "-", id, "", "")
                            '=============================================
                        End If
                    End If
                Next
                cExecute.Commit()
                If commandType = "Delete" Then
                    xMessageBoxRWM_ลบข้อมูลเสร็จเรียบร้อย(RadWindowManager1)
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

    Protected Sub GridShowdata_NeedDataSource(sender As Object, e As GridNeedDataSourceEventArgs) Handles GridShowdata.NeedDataSource
        Me.GridShowdata.DataSource = Session("MasterData")
    End Sub
End Class
