Imports Telerik.Web.UI
Imports System.Data
Partial Class Master_MasterGroup
    Inherits BasePage
    Dim dt As DataTable
    Dim da As New Mydata(adoconn)
    Dim GetMasterData As GetMasterData
    Dim id_GUID As String
    Dim FormName As String = "MasterGroup"
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
            Me.Title = "หมวด"
            '================ เก็บ Log ====================='
            InsertLogMenu("TN", FormName, "M", Sys.LoginWeb.UserName)
            '=============================================='
            Session.Remove("MasterData")
            Call Lang()
            Call GetData()
            Call ChkMenu()
        End If
    End Sub

    Sub LoadTitle()
        TMsg.LoadTitle("WebTrainingCourse", "Form", Sys.Lang)
        If TMsg.dT_Title.Rows.Count > 0 Then
            Me.Title = Sys.TMsg.Title_Text("WebTrainingCourse")
            Me.ProgramCode = Sys.TMsg.Program_Code("WebTrainingCourse")
            Sys.LoginWeb.MenuCode = ProgramCode
        End If
    End Sub
    Public Sub ChkMenu()
        Dim dtCkMeun As DataTable = HttpContext.Current.Session("dtCkMenuPerson")
        Dim ndr() As DataRow
        If dtCkMeun.Rows.Count > 0 Then
            ndr = dtCkMeun.Select(" Menu_Code = '" & ProgramCode & "' ")
            If ndr.Count > 0 Then

                'กรณีลบได้อย่างเดียว -> set readonly
                If DataHelper.ToBoolean(ndr(0)("ckAdd"), False) = False AndAlso DataHelper.ToBoolean(ndr(0)("ckEdit"), False) = False Then
                    'GridShowdata.MasterTableView.CommandItemSettings.ShowAddNewRecordButton = False
                    'GridShowdata.MasterTableView.CommandItemSettings.ShowSaveChangesButton = False
                    'GridShowdata.MasterTableView.CommandItemSettings.ShowCancelChangesButton = False
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Group_Code"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Group_NameT"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Group_NameE"), GridBoundColumn).ReadOnly = True
                    'TryCast(Me.GridShowdata.MasterTableView.GetColumn("Group_NameO"), GridBoundColumn).ReadOnly = True
                ElseIf DataHelper.ToBoolean(ndr(0)("CkDel"), False) = False Then 'กรณีห้ามลบ  
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridBoundColumn).ReadOnly = True
                End If

                GridShowdata.Rebind()
            End If
        End If
    End Sub
    Sub Lang()
        If Sys.LoginWeb.Lang <> "T" Then
            TMsg.LoadLang("MasterCourse", Sys.Lang) ' โหลดภาษา และเปลี่ยนภาษา
            If TMsg.dT_Lang.Rows.Count > 0 Then
                Me.Title = Sys.TMsg.Label_Text("lblGroup")
                Dim GridButton As GridButtonColumn = TryCast(GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn)
                GridButton.ConfirmText = Sys.TMsg.Label_Text("lblConfirm")
                GridButton.ConfirmTitle = Sys.TMsg.Label_Text("lblDelTitle")
                Me.GridShowdata.MasterTableView.GetColumn("Group_Code").HeaderText = Sys.TMsg.Label_Text("Group_Code")
                Me.GridShowdata.MasterTableView.GetColumn("Group_NameT").HeaderText = Sys.TMsg.Label_Text("Group_NameT")
                Me.GridShowdata.MasterTableView.GetColumn("Group_NameE").HeaderText = Sys.TMsg.Label_Text("Group_NameE")
                Me.GridShowdata.MasterTableView.GetColumn("Group_NameO").HeaderText = Sys.TMsg.Label_Text("Group_NameO")
                Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn").HeaderText = Sys.TMsg.Label_Text("lblDelete")
                Me.GridShowdata.MasterTableView.CommandItemSettings.AddNewRecordText = Sys.TMsg.Label_Text("lblAdd")
                Me.GridShowdata.MasterTableView.CommandItemSettings.SaveChangesText = Sys.TMsg.Label_Text("lblSave")
                Me.GridShowdata.MasterTableView.CommandItemSettings.CancelChangesText = Sys.TMsg.Label_Text("lblCancel")
            End If
        End If
    End Sub

    Sub GetData()
        sqlstr = "select * from TNM_GroupCourse where CompanyID = " & Sys.LoginWeb.CompanyID
        sqlstr = String.Format(sqlstr, Sys.LoginWeb.Lang)
        dt = da.GetDataTable(sqlstr)

        If dt.Rows.Count > 0 Then
            Me.GridShowdata.DataSource = dt
            Me.GridShowdata.DataBind()
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
            Try
                cExecute.BeginTransaction()
                For Each command As GridBatchEditingCommand In e.Commands
                    commandType = command.Type.ToString
                    Dim newValues As Hashtable = command.NewValues
                    Dim oldValues As Hashtable = command.OldValues

                    If command.Type = GridBatchEditingCommandType.Insert Then
                        id_GUID = Guid.NewGuid.ToString.Trim
                        Dim sql$ = "insert into TNM_GroupCourse (GUID_Group,Group_NameT,Group_Code,Group_NameE,Group_NameO,CompanyID) values (?,?,?,?,?,?)"
                        cExecute.sqlStr = sql
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        cExecute.sqlParameter_Value("@p1", "NV", Trim(id_GUID))
                        cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("Group_NameT")))
                        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("Group_Code") & ""))
                        cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("Group_NameE") & ""))
                        cExecute.sqlParameter_Value("@p5", "NV", Trim(newValues("Group_NameO") & ""))
                        cExecute.sqlParameter_Value("@p6", "I", Sys.LoginWeb.CompanyID)
                        cExecute.ExecuteNonQuery()

                        'INSERT LOG===================================
                        InsertLogfile(FormName, "", Sys.TMsg.Insert & " " & Me.Title & ": " & Trim(newValues("Group_Code")) & ":" & Trim(newValues("Group_NameT")), "-", id_GUID, "", "")
                        '=============================================
                    ElseIf command.Type = GridBatchEditingCommandType.Update Then

                        Dim id As String = command.Item.GetDataKeyValue("GUID_Group").ToString()
                        Dim sql$ = "update TNM_GroupCourse set  Group_NameT  = ? , Group_Code = ? , Group_NameE = ? , Group_NameO = ? where GUID_Group ='" & id & "'"

                        cExecute.sqlStr = sql
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        cExecute.sqlParameter_Value("@p1", "NV", Trim(newValues("Group_NameT") & ""))
                        cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("Group_Code") & ""))
                        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("Group_NameE") & ""))
                        cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("Group_NameO") & ""))
                        cExecute.ExecuteNonQuery()

                        'INSERT LOG===================================
                        Dim dt As DataTable = TryCast(Session("MasterData"), DataTable)
                        Dim dr As DataRow = dt.AsEnumerable().Where(Function(c) c("GUID_Group").Equals(Guid.Parse(id))).[Single]()
                        If Not IsNothing(dr) Then
                            Utility.hasChange(FormName, "", dr("Group_Code").ToString(), newValues("Group_Code").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Group_Code").HeaderText & " [ID:" & id & "]")
                            Utility.hasChange(FormName, "", dr("Group_NameT").ToString(), newValues("Group_NameT").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Group_NameT").HeaderText & " [ID:" & id & "]")
                            Utility.hasChange(FormName, "", dr("Group_NameE").ToString(), (newValues("Group_NameE") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Group_NameE").HeaderText & " [ID:" & id & "]")
                            Utility.hasChange(FormName, "", dr("Group_NameO").ToString(), (newValues("Group_NameO") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Group_NameO").HeaderText & " [ID:" & id & "]")
                        End If
                        '=============================================
                    ElseIf command.Type = GridBatchEditingCommandType.Delete Then
                        Dim id As String = command.Item.GetDataKeyValue("GUID_Group").ToString()
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        Dim chk$ = cExecute.ExecuteScalar("select convert(varchar(50),Course_ID) from TNM_Course where GUID_Group ='" & id & "'")
                        If chk <> "" Then
                            xMessageBoxRWM_ถูกใช้งานอยู่(RadWindowManager1)
                            Call GetData()
                            Exit Sub
                        Else
                            cExecute.ExecuteNonQuery("delete TNM_GroupCourse where GUID_Group ='" & id & "'")

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
