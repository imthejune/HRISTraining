Imports Telerik.Web.UI
Imports System.Data
Partial Class Master_MasterTopic22
    Inherits BasePage
    Dim dt As DataTable
    Dim da As New Mydata(adoconn)
    Dim GetMasterData As GetMasterData
    Dim id_GUID As String
    Dim cExecute As New connExecute
    Dim FormName As String = "MasterTopic22"
    Dim id_Sub As String
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
            Me.Title = "วัตถุประสงค์ 2-1"
            'Call Lang()
            Call GetData()
            'Call ChkMenu()
            '================ เก็บ Log ====================='
            InsertLogMenu("TN", FormName, "M", Sys.LoginWeb.UserName)
            '=============================================='
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
                    GridShowdata.MasterTableView.CommandItemSettings.ShowAddNewRecordButton = False
                    GridShowdata.MasterTableView.CommandItemSettings.ShowSaveChangesButton = False
                    GridShowdata.MasterTableView.CommandItemSettings.ShowCancelChangesButton = False
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("Vt_N"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("Vt_Name"), GridBoundColumn).ReadOnly = True
                ElseIf DataHelper.ToBoolean(ndr(0)("CkDel"), False) = False Then 'กรณีห้ามลบ  
                    TryCast(Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridBoundColumn).ReadOnly = True
                End If

                GridShowdata.Rebind()
            End If
        End If
    End Sub
    Sub Lang()
        If Sys.LoginWeb.Lang <> "T" Then
            TMsg.LoadLang("MasterDetail", Sys.Lang) ' โหลดภาษา และเปลี่ยนภาษา
            If TMsg.dT_Lang.Rows.Count > 0 Then
                Me.Title = Sys.TMsg.Label_Text("lblVt")
                Dim GridButton As GridButtonColumn = TryCast(GridShowdata.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn)
                GridButton.ConfirmText = Sys.TMsg.Label_Text("lblConfirm")
                GridButton.ConfirmTitle = Sys.TMsg.Label_Text("lblDelTitle")
                Me.GridShowdata.MasterTableView.GetColumn("Vt_N").HeaderText = Sys.TMsg.Label_Text("Vt_N")
                Me.GridShowdata.MasterTableView.GetColumn("Vt_Name").HeaderText = Sys.TMsg.Label_Text("Vt_Name")
                Me.GridShowdata.MasterTableView.GetColumn("DeleteColumn").HeaderText = Sys.TMsg.Label_Text("lblDelete")
                Me.GridShowdata.MasterTableView.CommandItemSettings.AddNewRecordText = Sys.TMsg.Label_Text("lblAdd")
                Me.GridShowdata.MasterTableView.CommandItemSettings.SaveChangesText = Sys.TMsg.Label_Text("lblSave")
                Me.GridShowdata.MasterTableView.CommandItemSettings.CancelChangesText = Sys.TMsg.Label_Text("lblCancel")
            End If
        End If
    End Sub

    Sub GetData()
        sqlstr = "select * from TNT_FyfpVttopic where GUID_fyfp_Sub = '" & Request.QueryString("id") & "' and Add_Status = 0"
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

            Try
                cExecute.BeginTransaction()
                For Each command As GridBatchEditingCommand In e.Commands
                    commandType = command.Type.ToString
                    Dim newValues As Hashtable = command.NewValues
                    Dim oldValues As Hashtable = command.OldValues

                    If command.Type = GridBatchEditingCommandType.Insert Then
                        id_GUID = Guid.NewGuid.ToString.Trim
                        id_Sub = Request.QueryString("id") & ""
                        Dim sql$ = "insert into TNT_FyfpVttopic (GUID_Vt,GUID_fyfp_Sub,Vt_N,Vt_Header,Vt_Name,Vt_Hour,Add_Status) values (?,?,?,?,?,?,?)"
                        cExecute.sqlStr = sql
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        cExecute.sqlParameter_Value("@p1", "NV", Trim(id_GUID))
                        cExecute.sqlParameter_Value("@p2", "NV", Trim(id_Sub))
                        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("Vt_N") & ""))
                        cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("Vt_Header") & ""))
                        cExecute.sqlParameter_Value("@p5", "NV", Trim(newValues("Vt_Name") & ""))
                        cExecute.sqlParameter_Value("@p6", "NV", Trim(newValues("Vt_Hour") & ""))
                        cExecute.sqlParameter_Value("@p7", "B", 0)
                        cExecute.ExecuteNonQuery()

                        'INSERT LOG===================================
                        InsertLogfile(FormName, "", Sys.TMsg.Insert & " " & Me.Title & ": " & Trim(newValues("Vt_Header")), "-", Trim(newValues("Vt_Name") & ""), "", "")
                        '=============================================
                    ElseIf command.Type = GridBatchEditingCommandType.Update Then

                        Dim id As String = command.Item.GetDataKeyValue("GUID_Vt").ToString()

                        Dim sql$ = "update TNT_FyfpVttopic set Vt_Header  = ? ,Vt_Name = ? ,Vt_N = ? ,Vt_Hour = ? where GUID_Vt ='" & id & "'"
                        cExecute.sqlStr = sql
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        cExecute.sqlParameter_Value("@p1", "NV", Trim(newValues("Vt_N") & ""))
                        cExecute.sqlParameter_Value("@p2", "NV", Trim(newValues("Vt_Header") & ""))
                        cExecute.sqlParameter_Value("@p3", "NV", Trim(newValues("Vt_Name") & ""))
                        cExecute.sqlParameter_Value("@p4", "NV", Trim(newValues("Vt_Hour") & ""))
                        cExecute.ExecuteNonQuery()

                        'INSERT LOG===================================
                        Dim dt As DataTable = TryCast(Session("MasterData"), DataTable)
                        Dim dr As DataRow = dt.AsEnumerable().Where(Function(c) c("Vt_ID").Equals(Guid.Parse(id))).[Single]()
                        If Not IsNothing(dr) Then
                            Utility.hasChange(FormName, "", dr("Vt_Header").ToString(), newValues("Vt_Header").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Vt_Header").HeaderText & " [ID:" & id & "]")
                            Utility.hasChange(FormName, "", dr("Vt_Name").ToString(), (newValues("Vt_Name") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Vt_Name").HeaderText & " [ID:" & id & "]")
                            Utility.hasChange(FormName, "", dr("Vt_Hour").ToString(), (newValues("Vt_Hour") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Vt_Hour").HeaderText & " [ID:" & id & "]")
                            Utility.hasChange(FormName, "", dr("Vt_N").ToString(), (newValues("Vt_N") & "").ToString(), VariableType.varText, Sys.TMsg.Update & " " & Me.GridShowdata.MasterTableView.GetColumn("Vt_N").HeaderText & " [ID:" & id & "]")
                        End If
                        '=============================================
                    ElseIf command.Type = GridBatchEditingCommandType.Delete Then
                        Dim id As String = command.Item.GetDataKeyValue("GUID_Vt").ToString()
                        cExecute.cmdConnection()
                        cExecute.Transaction()
                        Dim chk$ = cExecute.ExecuteScalar("select convert(varchar(50),GUID_Vt) from TNT_FyfpVttopic where GUID_Vt ='" & id & "'")
                        If chk <> "" Then
                            xMessageBoxRWM_ถูกใช้งานอยู่(RadWindowManager1)
                            Call GetData()
                            Exit Sub
                        Else
                            cExecute.ExecuteNonQuery("delete TNT_FyfpVttopic where GUID_Vt ='" & id & "'")

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

    Protected Sub GridShowdata_ItemDataBound(sender As Object, e As GridItemEventArgs) Handles GridShowdata.ItemDataBound
        If TypeOf e.Item Is IGridInsertItem Then

        ElseIf TypeOf e.Item Is GridEditableItem AndAlso e.Item.IsInEditMode Then

        ElseIf TypeOf e.Item Is GridDataItem Then
            Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
            'Dim dr As DataRowView = TryCast(e.Item.DataItem, DataRowView)
            'Dim b As Button = CType(e.Item.FindControl("hypSubject"), Button)
            'If dr("Add_Status") = False Then
            '    item.BackColor = Drawing.Color.PaleGreen
            'End If
        End If
    End Sub

    Protected Sub GridShowdata_NeedDataSource(sender As Object, e As GridNeedDataSourceEventArgs) Handles GridShowdata.NeedDataSource
        Me.GridShowdata.DataSource = Session("MasterData")
    End Sub
End Class
