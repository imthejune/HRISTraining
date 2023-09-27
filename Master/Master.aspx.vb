Imports Telerik.Web.UI
Imports System.Data

Partial Class Master_Master
    'ทำให้ Grid ตรง page เป็นภาษาไทย และใส่ OnItemDataBound="grid_ItemDataBound" ที่ Grid
    Inherits BasePage

    Dim GetMasterData As GetMasterData

    Property MenuCode As String
        Get
            Return DataHelper.ToCharacter(Request.QueryString("MenuCode"))
        End Get
        Set(ByVal Value As String)
            ViewState("MenuCode") = Value
        End Set
    End Property


    '-- set ขนาด textbox ในการเพิ่มหรือแก้ไข --
    Protected Sub RadGrid1_PreRender(sender As Object, e As EventArgs) Handles RadGrid1.PreRender
        Dim gridcol As TextBox = Nothing
        Try
            gridcol = TryCast(Me.RadGrid1.MasterTableView.GetBatchColumnEditor("f1"), GridTextBoxColumnEditor).TextBoxControl
            gridcol.Width = Unit.Percentage(110)
        Catch ex As Exception
        End Try

        Try
            If GetMasterData.Field2 <> "" Then
                gridcol = TryCast(Me.RadGrid1.MasterTableView.GetBatchColumnEditor("f2"), GridTextBoxColumnEditor).TextBoxControl
                gridcol.Width = Unit.Percentage(110)
            End If
        Catch ex As Exception
        End Try

        Try
            If GetMasterData.Field3 <> "" Then
                gridcol = TryCast(Me.RadGrid1.MasterTableView.GetBatchColumnEditor("f3"), GridTextBoxColumnEditor).TextBoxControl
                gridcol.Width = Unit.Percentage(110)
            End If
        Catch ex As Exception
        End Try

        Try
            If GetMasterData.Field4 <> "" Then
                gridcol = TryCast(Me.RadGrid1.MasterTableView.GetBatchColumnEditor("f4"), GridTextBoxColumnEditor).TextBoxControl
                gridcol.Width = Unit.Percentage(110)
            End If
        Catch ex As Exception
        End Try
    End Sub
    '-------------------------------------

    Sub getSkin()
        Me.RadGrid1.Skin = Sys.LoginWeb.SkinGrid
        Me.RadWindowManager1.Skin = Sys.LoginWeb.SkinRadwindows
    End Sub

    Sub Lang()
        If Sys.LoginWeb.Lang <> "T" Then
            Me.RadGrid1.MasterTableView.CommandItemSettings.AddNewRecordText = Sys.TMsg.Insert
            Me.RadGrid1.MasterTableView.CommandItemSettings.SaveChangesText = Sys.TMsg.Save
            Me.RadGrid1.MasterTableView.CommandItemSettings.CancelChangesText = Sys.TMsg.Cancel
            Me.RadGrid1.Columns(6).HeaderText = Sys.TMsg.ลบ

        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Sys.ChkTimeOut(Me.Page)

        GetMasterData = Sys.ev1(Request.QueryString("tableName"))
        Me.Title = GetMasterData.FormName

        If Not IsPostBack Then
            Call getSkin()
            Call Lang()



            TryCast(RadGrid1.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn).ConfirmText = Sys.TMsg.คุณต้องการที่จะลบข้อมูลใช่หรือไม่
            TryCast(RadGrid1.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn).ConfirmTitle = Sys.TMsg.คำเตือน

            '====================================================='
            '== เช็คกรณี Login จาก HRIS =='
            If Sys.LoginWeb.HRISLogin = 1 Then
                '== ถ้าไม่ได้มาจากการคลิกเข้าระบบที่ icon Personnel ให้แจ้งเตือน ==' 
                If Session("HRISModule") <> "HRISTime" Then
                    Response.Redirect("~/Form/WebWanning.aspx")
                End If
            End If
            '================ เก็บ Log ====================='
            InsertLogMenu("PN", "WebMaster", "M", Sys.LoginWeb.UserName)
            '====================================================='



            '== Default 4 คอลัมภ์หน้า Popup เพิ่ม Master Table เป็น False ก่อน =='
            CType(Me.RadGrid1.Columns.FindByUniqueName("f1"), GridBoundColumn).ReadOnly = GetMasterData.ReadOnly1
            CType(Me.RadGrid1.Columns.FindByUniqueName("f2"), GridBoundColumn).ReadOnly = GetMasterData.ReadOnly2
            CType(Me.RadGrid1.Columns.FindByUniqueName("f3"), GridBoundColumn).ReadOnly = GetMasterData.ReadOnly3
            CType(Me.RadGrid1.Columns.FindByUniqueName("f4"), GridBoundColumn).ReadOnly = GetMasterData.ReadOnly4
            CType(Me.RadGrid1.Columns.FindByUniqueName("f5"), GridCheckBoxColumn).ReadOnly = GetMasterData.ReadOnly5
            CType(Me.RadGrid1.Columns.FindByUniqueName("f6"), GridCheckBoxColumn).ReadOnly = GetMasterData.ReadOnly6

            RadGrid1.MasterTableView.DataKeyNames = New String() {GetMasterData.PkID}

            'Add sort expression, which will sort against first column
            Dim sortExpr As New GridSortExpression()
            sortExpr.FieldName = GetMasterData.Field1
            sortExpr.SortOrder = GridSortOrder.Ascending
            RadGrid1.MasterTableView.SortExpressions.AddSortExpression(sortExpr)

            'เปลี่ยนสี sort
            'RadGrid1.SortingSettings.SortedBackColor = Color.FromName("#FFF6D6")

            CType(Me.RadGrid1.Columns.FindByUniqueName("f1"), GridBoundColumn).DataField = GetMasterData.Field1
            CType(Me.RadGrid1.Columns.FindByUniqueName("f1"), GridBoundColumn).HeaderText = GetMasterData.HeaderText1
            ViewState("FieldName") = GetMasterData.Field1
            ViewState("paraName") = "?"

            If GetMasterData.Field2 <> "" Then
                CType(Me.RadGrid1.Columns.FindByUniqueName("f2"), GridBoundColumn).DataField = GetMasterData.Field2
                CType(Me.RadGrid1.Columns.FindByUniqueName("f2"), GridBoundColumn).HeaderText = GetMasterData.HeaderText2
                ViewState("FieldName") &= "," & GetMasterData.Field2
                ViewState("paraName") &= "," & "?"
            Else
                CType(Me.RadGrid1.Columns.FindByUniqueName("f2"), GridBoundColumn).Visible = False
            End If

            If GetMasterData.Field3 <> "" Then
                CType(Me.RadGrid1.Columns.FindByUniqueName("f3"), GridBoundColumn).DataField = GetMasterData.Field3
                CType(Me.RadGrid1.Columns.FindByUniqueName("f3"), GridBoundColumn).HeaderText = GetMasterData.HeaderText3
                ViewState("FieldName") &= "," & GetMasterData.Field3
                ViewState("paraName") &= "," & "?"
            Else
                CType(Me.RadGrid1.Columns.FindByUniqueName("f3"), GridBoundColumn).Visible = False
            End If

            If GetMasterData.Field4 <> "" Then
                CType(Me.RadGrid1.Columns.FindByUniqueName("f4"), GridBoundColumn).DataField = GetMasterData.Field4
                CType(Me.RadGrid1.Columns.FindByUniqueName("f4"), GridBoundColumn).HeaderText = GetMasterData.HeaderText4
                ViewState("FieldName") &= "," & GetMasterData.Field4
                ViewState("paraName") &= "," & "?"
            Else
                CType(Me.RadGrid1.Columns.FindByUniqueName("f4"), GridBoundColumn).Visible = False
            End If

            If GetMasterData.Field5 <> "" Then
                CType(Me.RadGrid1.Columns.FindByUniqueName("f5"), GridCheckBoxColumn).DataField = GetMasterData.Field5
                CType(Me.RadGrid1.Columns.FindByUniqueName("f5"), GridCheckBoxColumn).HeaderText = GetMasterData.HeaderText5
                ViewState("FieldName") &= "," & GetMasterData.Field5
                ViewState("paraName") &= "," & "?"
                CType(Me.RadGrid1.Columns.FindByUniqueName("f5"), GridCheckBoxColumn).Visible = True
            Else
                CType(Me.RadGrid1.Columns.FindByUniqueName("f5"), GridCheckBoxColumn).Visible = False

            End If

            If GetMasterData.Field6 <> "" Then
                CType(Me.RadGrid1.Columns.FindByUniqueName("f6"), GridCheckBoxColumn).DataField = GetMasterData.Field6
                CType(Me.RadGrid1.Columns.FindByUniqueName("f6"), GridCheckBoxColumn).HeaderText = GetMasterData.HeaderText6
                ViewState("FieldName") &= "," & GetMasterData.Field6
                ViewState("paraName") &= "," & "?"
                CType(Me.RadGrid1.Columns.FindByUniqueName("f6"), GridCheckBoxColumn).Visible = True
            Else
                CType(Me.RadGrid1.Columns.FindByUniqueName("f6"), GridCheckBoxColumn).Visible = False

            End If


            If GetMasterData.Remark <> "" Then
                Me.lblNote.Text = GetMasterData.Remark
            End If

            Call ChkMenu()

        End If
    End Sub

    '***********************************************************************************************************************************************************
    '************ สิทธิ์เมนู *********************************************************************************************************************************
    '***********************************************************************************************************************************************************
    Public Sub ChkMenu()
        Dim dtCkMeun As DataTable = HttpContext.Current.Session("dtCkMenuPerson")
        Dim ndr() As DataRow
        If dtCkMeun.Rows.Count > 0 Then
            ndr = dtCkMeun.Select(" Menu_Code = '" & MenuCode & "' ")
            If ndr.Count > 0 Then
                '== ปุ่มเพิ่มข้อมูล =='
                Me.RadGrid1.MasterTableView.CommandItemSettings.ShowAddNewRecordButton = False
                Me.RadGrid1.MasterTableView.CommandItemSettings.ShowSaveChangesButton = False

                'กรณีมีการเช็ค add edit delete -> แสดงปุ่ม cancel
                If (DataHelper.ToBoolean(ndr(0)("ckAdd"), False) = True) Then
                    Me.RadGrid1.MasterTableView.CommandItemSettings.ShowAddNewRecordButton = True
                End If

                If (DataHelper.ToBoolean(ndr(0)("ckAdd"), False) = True OrElse DataHelper.ToBoolean(ndr(0)("ckEdit"), False) = True OrElse DataHelper.ToBoolean(ndr(0)("CkDel"), False) = True) Then
                    Me.RadGrid1.MasterTableView.CommandItemSettings.ShowSaveChangesButton = True
                End If

                'เช็คการซ่อนปุ่ม cancel
                If (DataHelper.ToBoolean(ndr(0)("ckAdd"), False) = False And DataHelper.ToBoolean(ndr(0)("ckEdit"), False) = False And DataHelper.ToBoolean(ndr(0)("CkDel"), False) = False) Then
                    Me.RadGrid1.MasterTableView.CommandItemDisplay = GridCommandItemDisplay.None
                End If

                'กรณีลบได้อย่างเดียว -> set readonly
                If DataHelper.ToBoolean(ndr(0)("ckAdd"), False) = False AndAlso DataHelper.ToBoolean(ndr(0)("ckEdit"), False) = False Then
                    TryCast(Me.RadGrid1.MasterTableView.GetColumn("f1"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.RadGrid1.MasterTableView.GetColumn("f2"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.RadGrid1.MasterTableView.GetColumn("f3"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.RadGrid1.MasterTableView.GetColumn("f4"), GridBoundColumn).ReadOnly = True
                    TryCast(Me.RadGrid1.MasterTableView.GetColumn("f5"), GridCheckBoxColumn).ReadOnly = True
                    TryCast(Me.RadGrid1.MasterTableView.GetColumn("f6"), GridCheckBoxColumn).ReadOnly = True
                End If

                If DataHelper.ToBoolean(ndr(0)("CkDel"), False) = False Then
                    RadGrid1.MasterTableView.GetColumn("DeleteColumn").Visible = False
                End If

                RadGrid1.Rebind()
            End If
        End If
    End Sub

    Protected Sub RadGrid1_BatchEditCommand(sender As Object, e As GridBatchEditingEventArgs) Handles RadGrid1.BatchEditCommand
        If e.Commands.Count > 0 Then
            Dim exe As New connExecute
            Dim commandType As String = ""
            For Each command As GridBatchEditingCommand In e.Commands
                commandType = command.Type.ToString
                Dim newValues As Hashtable = command.NewValues
                If command.Type = GridBatchEditingCommandType.Insert Then
                    Dim sql$ = "insert into  " & GetMasterData.TableName & " (" & ViewState("FieldName") & ")" & " values (" & ViewState("paraName") & ")"
                    exe.sqlStr = sql
                    exe.cmdConnection()

                    Dim i As Integer = 1
                    exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field1) & "")

                    If GetMasterData.Field2 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field2) & "")
                    End If

                    If GetMasterData.Field3 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field3) & "")
                    End If

                    If GetMasterData.Field4 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field4) & "")
                    End If

                    If GetMasterData.Field5 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "B", newValues(GetMasterData.Field5) & "")
                    End If

                    If GetMasterData.Field6 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "B", newValues(GetMasterData.Field6) & "")
                    End If

                    Try
                        exe.ExecuteNonQuery()
                    Catch ex As System.Exception
                    End Try

                ElseIf command.Type = GridBatchEditingCommandType.Update Then
                    Dim id = command.Item.GetDataKeyValue(GetMasterData.PkID)
                    Dim sql$ = "update " & GetMasterData.TableName & " set " & GetMasterData.Field1 & " =?"

                    If GetMasterData.Field2 <> "" Then
                        sql &= "," & GetMasterData.Field2 & "=? "
                    End If

                    If GetMasterData.Field3 <> "" Then
                        sql &= "," & GetMasterData.Field3 & "=? "
                    End If

                    If GetMasterData.Field4 <> "" Then
                        sql &= "," & GetMasterData.Field4 & "=? "
                    End If

                    If GetMasterData.Field5 <> "" Then
                        sql &= "," & GetMasterData.Field5 & "=? "
                    End If

                    If GetMasterData.Field6 <> "" Then
                        sql &= "," & GetMasterData.Field6 & "=? "
                    End If

                    sql &= " where " & GetMasterData.PkID & "=" & id
                    exe.sqlStr = sql
                    exe.cmdConnection()

                    Dim i As Integer = 1
                    exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field1) & "")

                    If GetMasterData.Field2 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field2) & "")
                    End If

                    If GetMasterData.Field3 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field3) & "")
                    End If

                    If GetMasterData.Field4 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "NV", newValues(GetMasterData.Field4) & "")
                    End If

                    If GetMasterData.Field5 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "B", newValues(GetMasterData.Field5))
                    End If

                    If GetMasterData.Field6 <> "" Then
                        i += 1
                        exe.sqlParameter_Value("@p" & i, "B", newValues(GetMasterData.Field6))
                    End If

                    Try
                        exe.ExecuteNonQuery()
                    Catch ex As System.Exception
                        'xMessageBoxRWM(Me.RadWindowManager1, 150, 100, ex.Message)
                    End Try

                ElseIf command.Type = GridBatchEditingCommandType.Delete Then
                    Dim id = command.Item.GetDataKeyValue(GetMasterData.PkID)
                    Try
                        For i = 0 To GetMasterData.CheckBeforeDeleteTable.Count - 1
                            Dim chk$ = exe.ExecuteScalar("select top 1 " & GetMasterData.CheckBeforeDeleteField(i) & " from " & GetMasterData.CheckBeforeDeleteTable(i) & " where " & GetMasterData.CheckBeforeDeleteField(i) & "='" & id & "'")
                            If chk <> "" Then
                                Me.xMessageBox(newValues(GetMasterData.Field1) & " : ถูกใช้งานอยู่", Me.RadWindowManager1)
                                e.Canceled = True
                                Exit Sub
                            End If
                        Next

                        exe.ExecuteNonQuery("delete " & GetMasterData.TableName & " where " & GetMasterData.PkID & "='" & id & "'")
                    Catch ex As System.Exception
                        xMessageBoxRWM(RadWindowManager1, Sys.TMsg.SaveNotComplete & ex.Message)
                    End Try

                End If
            Next

            If commandType = "Delete" Then
                xMessageBoxRWM_ลบข้อมูลสำเร็จ(RadWindowManager1)
            Else
                xMessageBoxRWM_บันทึกสำเร็จ(Me.RadWindowManager1)
            End If
        End If
    End Sub
    Protected Sub RadGrid1_DataBound(sender As Object, e As EventArgs) Handles RadGrid1.DataBound
        Dim footerItem As GridFooterItem = DirectCast(RadGrid1.MasterTableView.GetItems(GridItemType.Footer)(0), GridFooterItem)
        footerItem("f1").Text = "Total = " & DirectCast(DirectCast(sender, Telerik.Web.UI.RadGrid).DataSource, System.Data.DataTable).DefaultView.Count
    End Sub
    Protected Sub RadGrid1_ItemDataBound(sender As Object, e As GridItemEventArgs) Handles RadGrid1.ItemDataBound
        If TypeOf e.Item Is GridDataItem Then
            Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
            '== ต้องใช้ แต่บังไว้ก
            TryCast(RadGrid1.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn).ConfirmText = Sys.TMsg.คุณต้องการที่จะลบข้อมูลใช่หรือไม่
            TryCast(RadGrid1.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn).ConfirmTitle = Sys.TMsg.คำเตือน
        End If
    End Sub

    'Protected Sub RadGrid1_DeleteCommand(sender As Object, e As GridCommandEventArgs) Handles RadGrid1.DeleteCommand
    '    Dim Id$ = (DirectCast(e.Item, GridDataItem)).GetDataKeyValue(GetMasterData.PkID)

    '    Dim editableItem = (DirectCast(e.Item, GridEditableItem))
    '    Dim values As New Hashtable()
    '    editableItem.ExtractValues(values)

    '    Using exe As New connExecute
    '        Try
    '            For i = 0 To GetMasterData.CheckBeforeDeleteTable.Count - 1
    '                Dim chk$ = exe.ExecuteScalar("select top 1 " & GetMasterData.CheckBeforeDeleteField(i) & " from " & GetMasterData.CheckBeforeDeleteTable(i) & " where " & GetMasterData.CheckBeforeDeleteField(i) & "='" & Id & "'")
    '                If chk <> "" Then
    '                    Me.xMessageBox(values(GetMasterData.Field1) & " : ถูกใช้งานอยู่", Me.RadAjaxManager1)
    '                    e.Canceled = True
    '                    Exit Sub
    '                End If
    '            Next

    '            exe.ExecuteNonQuery("delete " & GetMasterData.TableName & " where " & GetMasterData.PkID & "='" & Id & "'")
    '            xMessageBoxRWM_ลบข้อมูลสำเร็จ(RadWindowManager1)
    '        Catch ex As System.Exception
    '            xMessageBoxRWM(RadWindowManager1, Sys.TMsg.SaveNotComplete & ex.Message, Me.RadAjaxManager1)
    '        End Try
    '    End Using
    'End Sub

    'Protected Sub RadGrid1_InsertCommand(sender As Object, e As GridCommandEventArgs) Handles RadGrid1.InsertCommand
    '    Dim editableItem = (DirectCast(e.Item, GridEditableItem))
    '    Dim values As New Hashtable()
    '    editableItem.ExtractValues(values)

    '    Dim f1$ = DirectCast(values(GetMasterData.Field1), String)
    '    Dim f2$ = DirectCast(values(GetMasterData.Field2), String)
    '    Dim f3$ = DirectCast(values(GetMasterData.Field3), String)
    '    Dim f4$ = DirectCast(values(GetMasterData.Field4), String)


    '    Using exe As New connExecute
    '        Dim sql$ = "insert into  " & GetMasterData.TableName & " (" & ViewState("FieldName") & ")" & " values (" & ViewState("paraName") & ")"
    '        exe.sqlStr = sql
    '        exe.cmdConnection()
    '        exe.sqlParameter_Value("@p1", "NV", f1 & "")

    '        If GetMasterData.Field2 <> "" Then
    '            exe.sqlParameter_Value("@p2", "NV", f2 & "")
    '        End If

    '        If GetMasterData.Field3 <> "" Then
    '            exe.sqlParameter_Value("@p3", "NV", f3 & "")
    '        End If

    '        If GetMasterData.Field4 <> "" Then
    '            exe.sqlParameter_Value("@p4", "NV", f4 & "")
    '        End If
    '        Try
    '            exe.ExecuteNonQuery()
    '            xMessageBoxRWM_บันทึกสำเร็จ(RadWindowManager1)
    '        Catch ex As System.Exception
    '            xMessageBoxRWM(RadWindowManager1, Sys.TMsg.SaveNotComplete, Me.RadAjaxManager1)
    '        End Try
    '    End Using

    'End Sub

    Protected Sub RadGrid1_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGrid1.NeedDataSource
        Dim daUnit As New Mydata(adoconn)
        Dim sqlstr As String
        sqlstr = GetMasterData.PkID & "," & GetMasterData.Field1

        If GetMasterData.Field2 <> "" Then
            sqlstr &= "," & GetMasterData.Field2
        End If

        If GetMasterData.Field3 <> "" Then
            sqlstr &= "," & GetMasterData.Field3
        End If

        If GetMasterData.Field4 <> "" Then
            sqlstr &= "," & GetMasterData.Field4
        End If

        If GetMasterData.Field5 <> "" Then
            sqlstr &= "," & GetMasterData.Field5
        End If

        If GetMasterData.Field6 <> "" Then
            sqlstr &= "," & GetMasterData.Field6
        End If

        TryCast(sender, RadGrid).DataSource = daUnit.GetDataTable("select " & sqlstr & " from " & GetMasterData.TableName)
    End Sub

    'Protected Sub RadGrid1_UpdateCommand(ByVal source As Object, ByVal e As GridCommandEventArgs) Handles RadGrid1.UpdateCommand
    '    Dim editableItem = (DirectCast(e.Item, GridEditableItem))
    '    Dim Id% = editableItem.GetDataKeyValue(GetMasterData.PkID)

    '    Dim values As New Hashtable()
    '    editableItem.ExtractValues(values)

    '    Dim f1$ = DirectCast(values(GetMasterData.Field1), String)
    '    Dim f2$ = DirectCast(values(GetMasterData.Field2), String)
    '    Dim f3$ = DirectCast(values(GetMasterData.Field3), String)
    '    Dim f4$ = DirectCast(values(GetMasterData.Field4), String)

    '    Using exe As New connExecute
    '        Dim sql$ = "update " & GetMasterData.TableName & " set " & GetMasterData.Field1 & " =?"

    '        If GetMasterData.Field2 <> "" Then
    '            sql &= "," & GetMasterData.Field2 & "=? "
    '        End If

    '        If GetMasterData.Field3 <> "" Then
    '            sql &= "," & GetMasterData.Field3 & "=? "
    '        End If

    '        If GetMasterData.Field4 <> "" Then
    '            sql &= "," & GetMasterData.Field4 & "=? "
    '        End If
    '        sql &= " where " & GetMasterData.PkID & "=" & Id
    '        exe.sqlStr = sql
    '        exe.cmdConnection()
    '        exe.sqlParameter_Value("@p1", "NV", f1 & "")

    '        If GetMasterData.Field2 <> "" Then
    '            exe.sqlParameter_Value("@p2", "NV", f2 & "")
    '        End If

    '        If GetMasterData.Field3 <> "" Then
    '            exe.sqlParameter_Value("@p3", "NV", f3 & "")
    '        End If

    '        If GetMasterData.Field4 <> "" Then
    '            exe.sqlParameter_Value("@p4", "NV", f4 & "")
    '        End If
    '        Try
    '            exe.ExecuteNonQuery()
    '            xMessageBoxRWM_บันทึกสำเร็จ(RadWindowManager1)
    '        Catch ex As System.Exception
    '            xMessageBoxRWM(RadWindowManager1, Sys.TMsg.SaveNotComplete & ex.Message, Me.RadAjaxManager1)
    '        End Try
    '    End Using
    'End Sub

    ''' <summary>
    ''' ต้องใช้คู่กับ telerik:RadWindowManager ID="RadWindowManager1" runat="server" 
    ''' </summary>
    ''' <remarks></remarks>
    'Private Sub ShowErrorMessage()
    '    RadAjaxManager1.ResponseScripts.Add(String.Format("window.radalert(""Please enter valid data!"")"))
    'End Sub

    'Protected Sub RadGrid1_ItemCreated(ByVal sender As Object, ByVal e As GridItemEventArgs) Handles RadGrid1.ItemCreated
    '    GetMasterData = Sys.ev1(Request.QueryString("tableName"))

    '    If TypeOf e.Item Is GridEditableItem AndAlso (e.Item.IsInEditMode) Then
    '        Dim editableItem As GridEditableItem = DirectCast(e.Item, GridEditableItem)
    '        SetupInputManager(editableItem)
    '    End If

    '    'If TypeOf e.Item Is GridDataItem Then
    '    '    Dim editableItem As GridDataItem = DirectCast(e.Item, GridDataItem)
    '    '    SetupInputManager(editableItem)
    '    'End If
    'End Sub

    'Private Sub SetupInputManager(ByVal editableItem As GridEditableItem)
    '    ' style and set ProductName column's textbox as required
    '    Dim textBox = (DirectCast(editableItem.EditManager.GetColumnEditor("f1"), GridTextBoxColumnEditor)).TextBoxControl
    '    Dim inputSetting As InputSetting = RadInputManager1.GetSettingByBehaviorID("RegExpBehavior1")
    '    inputSetting.TargetControls.Add(New TargetInput(textBox.UniqueID, True))
    '    inputSetting.InitializeOnClient = True
    '    inputSetting.Validation.IsRequired = True
    '    inputSetting.EmptyMessage = "..."
    '    inputSetting.ErrorMessage = "Please insert data."

    '    GetMasterData = Sys.ev1(Request.QueryString("tableName"))

    '    If GetMasterData.IsRequire2 = True Then
    '        textBox = (DirectCast(editableItem.EditManager.GetColumnEditor("f2"), GridTextBoxColumnEditor)).TextBoxControl
    '        inputSetting = RadInputManager1.GetSettingByBehaviorID("RegExpBehavior1")
    '        inputSetting.TargetControls.Add(New TargetInput(textBox.UniqueID, True))
    '        inputSetting.InitializeOnClient = True
    '        inputSetting.Validation.IsRequired = True
    '        inputSetting.EmptyMessage = ""
    '        inputSetting.ErrorMessage = "Please insert data."
    '    End If

    '    If GetMasterData.IsRequire3 = True Then
    '        textBox = (DirectCast(editableItem.EditManager.GetColumnEditor("f3"), GridTextBoxColumnEditor)).TextBoxControl
    '        inputSetting = RadInputManager1.GetSettingByBehaviorID("RegExpBehavior1")
    '        inputSetting.TargetControls.Add(New TargetInput(textBox.UniqueID, True))
    '        inputSetting.InitializeOnClient = True
    '        inputSetting.Validation.IsRequired = True
    '        inputSetting.EmptyMessage = ""
    '        inputSetting.ErrorMessage = "Please insert data."
    '    End If
    'End Sub
End Class





