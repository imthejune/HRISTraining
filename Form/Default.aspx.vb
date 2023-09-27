Imports System.Data
Imports System.Data.SqlClient
Imports Telerik.Web.UI

Partial Class _Default
    Inherits System.Web.UI.Page
    Private Const ItemsPerRequest As Integer = 10
    Public conDB As String = sqlcon
    Dim da_tmp As New Mydata(1, conDB)
    Dim sqlstr As String = ""
    Dim ds_tmp As DataSet
    Dim dt As DataTable
    Dim da As New Mydata(adoconn)
    Dim cExecute As New connExecute
    Dim GetMasterData As GetMasterData

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then

        End If
    End Sub
    Protected Sub RadGrid2_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs)
        TryCast(sender, RadGrid).DataSource = GetDataPerson()
    End Sub
    'Protected Sub RadGrid1_NeedDataSource(sender As Object, e As GridNeedDataSourceEventArgs) Handles RadGrid1.NeedDataSource
    '    RadGrid1.DataSource = CType(Session("DataRial"), DataSet).Tables("rial")
    'End Sub
    Function GetDataPerson() As DataTable


        sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY T_Person.t_id) AS NumberRow, T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, T_Person.t_ticket "
        sqlstr += " FROM T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product WHERE IsDelete != 0"


        Dim dt As DataTable
        dt = da.GetDataTable(sqlstr)

        Session("DataRial") = dt

        Return dt
    End Function


    'Protected Sub RadBtnSearch2_Click(sender As Object, e As EventArgs) Handles RadBtnSearch2.Click  'ปุ่มค้นหา Grid 2
    '    'ds_tmp = New DataSet()

    '    Dim wh_ As String = ""
    '    Dim dr_ As DataRow()


    '    If RadTextSearch2.Text <> "" Then
    '        If RadCom_search.SelectedValue = "1" Then
    '            wh_ = "t_ticket = '" & RadTextSearch2.Text & "' "
    '        ElseIf RadCom_search.SelectedValue = "2" Then
    '            wh_ = "productName LIKE '%" & RadTextSearch2.Text & "%' "
    '        ElseIf RadCom_search.SelectedValue = "3" Then
    '            wh_ = "t_company LIKE '%" & RadTextSearch2.Text & "%' "
    '        End If
    '    End If


    '    'If RadTextSearch2.Text <> "" Then
    '    '    wh_ = "t_ticket = '" & RadTextSearch2.Text & "' "
    '    'End If


    '    dt = Session("DataRial")
    '    dr_ = dt.Select(wh_)


    '    If dr_.Length > 0 Then
    '        RadGrid2.DataSource = dr_.CopyToDataTable
    '    Else
    '        RadGrid2.DataSource = New String() {}
    '    End If

    '    RadGrid2.DataBind()

    '----------------end--------------

    'If dr_.Length > 0 Then
    '    Session("DataRial") = dr_.CopyToDataTable
    'Else
    '    Session("DataRial") = New String() {}
    'End If

    'sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY T_Person.t_id) AS NumberRow, T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, T_Person.t_ticket "
    'sqlstr += " FROM T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product WHERE IsDelete != 0 "
    'sqlstr += wh_
    'dt = da.GetDataTable(sqlstr)
    'Session("DataRial") = dt


    'dt = New DataTable()
    'If RadTextSearch2.Text = "" Then
    '    'ds_tmp = New DataSet
    '    dt = New DataTable
    '    sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY T_Person.t_id) AS NumberRow, T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, T_Person.t_ticket "
    '    sqlstr += " FROM T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product WHERE IsDelete != 0 ORDER BY t_id DESC"
    '    dt = da.GetDataTable(sqlstr)
    '    Session("DataRial") = dt

    '    Call GetDataTable2()
    '    Exit Sub
    'End If
    ''ds_tmp = New DataSet
    'dt = New DataTable
    'sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY T_Person.t_id) AS NumberRow, T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, T_Person.t_ticket "
    'sqlstr += " FROM T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product WHERE IsDelete != 0 AND T_Person.t_ticket = '" & RadTextSearch2.Text & "' "
    'dt = da.GetDataTable(sqlstr)
    'Session("DataRial") = dt

    'Call GetDataTable2()
    'End Sub

    'Sub GetDataTable2()

    '    If Not IsNothing(Session("DataRial")) Then
    '        RadGrid2.DataSource = Session("DataRial")
    '        RadGrid2.DataBind()
    '    Else
    '        RadGrid2.DataSource = New String() {}
    '        RadGrid2.DataBind()
    '    End If

    'End Sub
    Protected Sub combo_product_ItemsRequested(sender As Object, e As RadComboBoxItemsRequestedEventArgs)

        Dim comboBox As RadComboBox = DirectCast(sender, RadComboBox)
        Dim ItemsPerRequest As Integer = 10
        comboBox.Items.Clear()
        comboBox.Text = ""

        'ds_tmp = New DataSet
        'ds_tmp = GetDataProductName(e.Text)
        'Dim data As DataTable = GetDataProductName(e.Text).Tables("productName")

        dt = New DataTable
        dt = GetDataProductName(e.Text)
        Dim data As DataTable = GetDataProductName(e.Text)

        Dim itemOffset As Integer = e.NumberOfItems
        Dim endOffset As Integer = Math.Min(itemOffset + ItemsPerRequest, data.Rows.Count)
        e.EndOfItems = endOffset = data.Rows.Count

        For i As Integer = itemOffset To endOffset - 1
            Dim item As New RadComboBoxItem(data.Rows(i)("productName").ToString(), data.Rows(i)("id_product").ToString())
            'comboBox.Items.Add(item)
            Dim items As New RadComboBoxItem()

            items.Value = data.Rows(i)("id_product").ToString()

            items.Attributes.Add("id_product", items.Text)
            ' items.ImageUrl = Server.MapPath("~/Images/" & data.Rows(i)("productName").ToString() & ".png")
            items.Text = "/img_product/" & data.Rows(i)("productImg").ToString() & ".png"
            items.Attributes.Add("productImages", items.Text)

            items.Text = data.Rows(i)("productName").ToString()
            items.Attributes.Add("productName", items.Text)

            comboBox.Items.Add(items)
            comboBox.DataBind()

        Next

        '   e.Message = GetStatusMessage(endOffset, data.Rows.Count)

    End Sub
    Function GetDataProductName(txt As String) As DataTable

        Dim dt As DataTable = New DataTable()


        Try
            'ds_tmp.Tables("productName").Clear()
        Catch ex As Exception
        End Try
        If Not String.IsNullOrEmpty(txt) Then
            sqlstr = "select id_product,productName,productImg from SCM_Product where productName LIKE '%" + txt + "%'"
        Else
            sqlstr = "select id_product,productName,productImg from SCM_Product order by productName asc"

        End If

        'da_tmp.GetDataset(ds_tmp, sqlstr, "productName")
        'Session("name") = ds_tmp
        'Return ds_tmp

        dt = da.GetDataTable(sqlstr)
        Session("name") = dt
        Return dt

    End Function
    Protected Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        ClientScript.RegisterStartupScript(Me.GetType(), "myclose", "CheckRep();", True)
        If txt_name.Text = "" Then
            WinMessageBox.RadAlert("ตรวจสอบ ชื่อ-นามสกุล", 220, 1, "แจ้งเตือน", Nothing)
            Exit Sub
        End If

        If txt_company.Text = "" Then
            WinMessageBox.RadAlert("ตรวจสอบชื่อบริษัท", 200, 1, "แจ้งเตือน", Nothing)
            Exit Sub
        End If

        If txt_address.Text = "" Then
            WinMessageBox.RadAlert("ตรวจสอบที่อยู่", 200, 1, "แจ้งเตือน", Nothing)
            Exit Sub
        End If

        If txt_tel.Text = "" Then
            WinMessageBox.RadAlert("ตรวจสอบเบอร์โทรศัพท์", 200, 1, "แจ้งเตือน", Nothing)
            Exit Sub
        End If

        If txt_email.Text = "" Then
            WinMessageBox.RadAlert("ตรวจสอบ E-mail", 200, 1, "แจ้งเตือน", Nothing)
            Exit Sub
        End If

        If txt_email.Text <> "" Then
            Dim Email As String = txt_email.Text.Trim()
            Dim EmailValid As String = "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"

            If Regex.IsMatch(Email, EmailValid) Then

            Else
                ' Invalid email address
                WinMessageBox.RadAlert("ตรวจสอบ E-mail", 200, 1, "แจ้งเตือน", Nothing)
                Exit Sub
            End If
        End If

        If combo_product.Text = "" Then
            WinMessageBox.RadAlert("โปรดเลือกเครื่องสินค้า", 200, 1, "แจ้งเตือน", Nothing)
            Exit Sub
        End If

        insertPerson()
        GetDataPerson()
        'GetDataTable2()


        'RadGrid2.DataSource = GetDataPerson()
        'RadGrid2.DataBind()

    End Sub
    Sub insertPerson()

        'Dim cExecute = New connExecute(conDB)
        Dim cExecute As New connExecute

        Dim ticket As String = Date.Now.ToString("yyyyMMddmmss")
        Dim Del As Integer = 1

        Try
            Dim cmdsqlStr As String
            cExecute.BeginTransaction()
            cmdsqlStr = " INSERT INTO T_Person (t_name, t_address, t_email, t_tel, t_company, t_product_id, t_ticket, IsDelete) " &
                        " VALUES (?,?,?,?,?,?,?,?)"
            cExecute.sqlStr = cmdsqlStr
            cExecute.cmdConnection()
            cExecute.sqlParameter_Value("@p1", "NV", Me.txt_name.Text) 'Name
            cExecute.sqlParameter_Value("@p2", "NV", Me.txt_address.Text) 'Address
            cExecute.sqlParameter_Value("@p3", "NV", Me.txt_email.Text) 'Email
            cExecute.sqlParameter_Value("@p4", "NV", Me.txt_tel.Text) 'Tel
            cExecute.sqlParameter_Value("@p5", "NV", Me.txt_company.Text) 'Company
            cExecute.sqlParameter_Value("@p6", "NV", Me.combo_product.SelectedValue.ToString) 'id_product
            cExecute.sqlParameter_Value("@p7", "NV", ticket)
            cExecute.sqlParameter_Value("@p8", "NV", Del)

            cExecute.Transaction()
            cExecute.ExecuteNonQuery()
            cExecute.Commit()
            WinMessageBox.RadAlert("บันทึกสำเร็จ", 200, 1, "แจ้งเตือน", Nothing)
        Catch ex As Exception
            cExecute.Rollback()
        End Try
    End Sub

    'Private Sub btntestrepot_Click(sender As Object, e As EventArgs) Handles btntestreport.Click
    Protected Sub btntestreport_Click(sender As Object, e As EventArgs)
        Dim btn As RadButton = CType(sender, RadButton)
        Dim Ticket As String = btn.CommandArgument
        Dim open As New OpenReport(Me)


        Dim MenuReport As String = Request.QueryString("MenuReport")
        Dim WH As String = Request.QueryString("Ticket")



        MenuReport = "Report1"
        WH = Ticket


        open.MenuReport = MenuReport
        open.WH = Ticket

        open.Open()
    End Sub

    Protected Sub btntestreportall_Click(sender As Object, e As EventArgs)
        Dim btn As RadButton = CType(sender, RadButton)
        Dim Ticket As String = btn.CommandArgument
        Dim open As New OpenReport(Me)


        Dim MenuReport As String = Request.QueryString("MenuReport")




        MenuReport = "Report2"



        open.MenuReport = MenuReport


        open.Open()
    End Sub
    Protected Sub BtnDel_Click(sender As Object, e As EventArgs)

        'Dim cExecute = New connExecute(conDB)
        Dim cExecute As New connExecute



        Dim btn As RadButton = TryCast(sender, RadButton)
        Dim Ticket As String = btn.CommandArgument
        Dim Del As Integer = 0
        Select Case btn.ID

            Case "btnRadConfirm"
                'Label12.Text = "The <strong>RadConfirm Ticket</strong> submitted the page at: " + Ticket
                Try
                    Dim cmdsqlStr As String
                    cExecute.BeginTransaction()

                    'cmdsqlStr = "DELETE FROM T_Person WHERE t_ticket = (?) "
                    'cExecute.sqlStr = cmdsqlStr
                    'cExecute.cmdConnection()
                    'cExecute.sqlParameter_Value("@p1", "NV", Ticket) 'Ticket

                    cmdsqlStr = "UPDATE T_Person SET IsDelete = (?) WHERE t_ticket = (?) "
                    cExecute.sqlStr = cmdsqlStr
                    cExecute.cmdConnection()
                    cExecute.sqlParameter_Value("@p1", "I", Del)
                    cExecute.sqlParameter_Value("@p2", "NV", Ticket)

                    cExecute.Transaction()
                    cExecute.ExecuteNonQuery()
                    cExecute.Commit()
                    WinMessageBox.RadAlert("ลบข้อมูลสำเร็จ", 200, 1, "แจ้งเตือน", Nothing)
                Catch ex As Exception
                    cExecute.Rollback()
                End Try
                Exit Select

        End Select
        GetDataPerson()
        'GetDataTable2()
    End Sub

    'Protected Sub RadCom_search_SelectedIndexChanged(sender As Object, e As RadComboBoxSelectedIndexChangedEventArgs) Handles RadCom_search.SelectedIndexChanged
    '    dt = New DataTable
    '    If RadCom_search.SelectedValue = "1" Then
    '        RadTextSearch2.EmptyMessage = " -- โปรดกรอก Ticket Code -- "
    '    ElseIf RadCom_search.SelectedValue = "2" Then
    '        RadTextSearch2.EmptyMessage = " -- โปรดกรอก Product Name -- "
    '    ElseIf RadCom_search.SelectedValue = "3" Then
    '        RadTextSearch2.EmptyMessage = " -- โปรดกรอก Company Name -- "
    '    End If
    'End Sub

    '---------------end--------------

#Region "New Grid"


    Protected Sub RadGrid1_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGrid1.NeedDataSource
        TryCast(sender, RadGrid).DataSource = GetDataPerson()
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

                    'If GetMasterData.Field6 <> "" Then
                    '    i += 1
                    '    exe.sqlParameter_Value("@p" & i, "B", newValues(GetMasterData.Field6))
                    'End If

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

    'Protected Sub RadGrid1_DataBound(sender As Object, e As EventArgs) Handles RadGrid1.DataBound
    '    Dim footerItem As GridFooterItem = DirectCast(RadGrid1.MasterTableView.GetItems(GridItemType.Footer)(0), GridFooterItem)
    '    footerItem("f1").Text = "Total = " & DirectCast(DirectCast(sender, Telerik.Web.UI.RadGrid).DataSource, System.Data.DataTable).DefaultView.Count
    'End Sub

    'Protected Sub RadGrid1_ItemDataBound(sender As Object, e As GridItemEventArgs) Handles RadGrid1.ItemDataBound
    '    If TypeOf e.Item Is GridDataItem Then
    '        Dim item As GridDataItem = DirectCast(e.Item, GridDataItem)
    '        '== ต้องใช้ แต่บังไว้ก
    '        TryCast(RadGrid1.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn).ConfirmText = Sys.TMsg.คุณต้องการที่จะลบข้อมูลใช่หรือไม่
    '        TryCast(RadGrid1.MasterTableView.GetColumn("DeleteColumn"), GridButtonColumn).ConfirmTitle = Sys.TMsg.คำเตือน
    '    End If
    'End Sub

    'Protected Sub RadGrid1_NeedDataSource(sender As Object, e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGrid1.NeedDataSource
    '    Dim daUnit As New Mydata(adoconn)
    '    Dim sqlstr As String
    '    sqlstr = GetMasterData.PkID & "," & GetMasterData.Field1

    '    If GetMasterData.Field2 <> "" Then
    '        sqlstr &= "," & GetMasterData.Field2
    '    End If

    '    If GetMasterData.Field3 <> "" Then
    '        sqlstr &= "," & GetMasterData.Field3
    '    End If

    '    If GetMasterData.Field4 <> "" Then
    '        sqlstr &= "," & GetMasterData.Field4
    '    End If

    '    If GetMasterData.Field5 <> "" Then
    '        sqlstr &= "," & GetMasterData.Field5
    '    End If

    '    If GetMasterData.Field6 <> "" Then
    '        sqlstr &= "," & GetMasterData.Field6
    '    End If

    '    TryCast(sender, RadGrid).DataSource = daUnit.GetDataTable("select " & sqlstr & " from " & GetMasterData.TableName)
    'End Sub

#End Region



#Region "Not Use"
    'Protected Sub RadSearch_Click(sender As Object, e As EventArgs) Handles RadSearch.Click  'ปุ่มค้นหา Grid 1
    '    ds_tmp = New DataSet()
    '    If RadText_search.Text = "" Then
    '        WinMessageBox.RadAlert("โปรดกรอก Ticket Code <br>" & "หรือ Serial Number <br>" & "ในตรวจสอบสถานะการซ่อม", 270, 1, "แจ้งเตือน", Nothing)
    '        Exit Sub
    '    End If
    '    If RadCom_search.SelectedValue = "1" Then
    '        Call selwhere(" WHERE SCT_Repair.ticket = '" & RadText_search.Text & "'")
    '    ElseIf RadCom_search.SelectedValue = "2" Then
    '        Call selwhere(" WHERE SCT_Machine.serial = '" & RadText_search.Text & "'")
    '    End If
    '    Call GetDataTable()
    'End Sub
    'Protected Sub BtnSearchAll_Click(sender As Object, e As EventArgs) Handles BtnSearchAll.Click  'ปุ่มค้นหาทั้งหมด Grid 1
    '    ds_tmp = New DataSet
    '    sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY SCT_Repair.ticket) AS NumberRow, SCT_Machine.id_Machine, SCT_Machine.id_Repair, SCT_Machine.serial,SCT_Machine.cause,SCT_Repair.ticket,SCM_Status.status "
    '    sqlstr += " FROM SCT_Machine LEFT JOIN SCT_Repair LEFT JOIN SCM_Status ON SCT_Repair.id_status = SCM_Status.id_status ON SCT_Machine.id_Repair = SCT_Repair.id_Repair ORDER BY ticket DESC"
    '    da_tmp.GetDataset(ds_tmp, sqlstr, "rial")
    '    Session("DataRial") = ds_tmp

    '    Call GetDataTable()
    'End Sub
    'Protected Sub RadBtnSearchAll2_Click(sender As Object, e As EventArgs) Handles RadBtnSearchAll2.Click  'ปุ่มค้นหาทั้งหมด Grid 2
    '    ds_tmp = New DataSet
    '    sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY T_Person.t_id) AS NumberRow, T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, T_Person.t_ticket "
    '    sqlstr += " FROM T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product WHERE IsDelete != 0 ORDER BY t_id DESC"
    '    da_tmp.GetDataset(ds_tmp, sqlstr, "rial")
    '    Session("DataRial") = ds_tmp

    '    Call GetDataTable2()
    'End Sub
    'Protected Sub BtnDel_Click(sender As Object, e As EventArgs) 'ปุ่มลบ Grid 2
    '    Dim cExecute = New connExecute(conDB)
    '    Dim btn As Button = CType(sender, Button)
    '    Dim Ticket As String = btn.CommandArgument
    '    Dim Del As Integer = 0

    '    'WinMessageBox.RadAlert(Ticket, 220, 1, "แจ้งเตือน", Nothing)

    '    Try
    '        Dim cmdsqlStr As String
    '        cExecute.BeginTransaction()

    '        'cmdsqlStr = "DELETE FROM T_Person WHERE t_ticket = (?) "
    '        'cExecute.sqlStr = cmdsqlStr
    '        'cExecute.cmdConnection()
    '        'cExecute.sqlParameter_Value("@p1", "NV", Ticket) 'Ticket

    '        cmdsqlStr = "UPDATE T_Person SET IsDelete = (?) WHERE t_ticket = (?) "
    '        cExecute.sqlStr = cmdsqlStr
    '        cExecute.cmdConnection()
    '        cExecute.sqlParameter_Value("@p1", "I", Del)
    '        cExecute.sqlParameter_Value("@p2", "NV", Ticket)

    '        cExecute.Transaction()
    '        cExecute.ExecuteNonQuery()
    '        cExecute.Commit()
    '        WinMessageBox.RadAlert("ลบข้อมูลสำเร็จ", 200, 1, "แจ้งเตือน", Nothing)
    '    Catch ex As Exception
    '        cExecute.Rollback()
    '    End Try
    'End Sub

    'Sub selwhere(Optional wh As String = "")
    '    'ds_tmp = New DataSet
    '    dt = New DataTable
    '    sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY SCT_Repair.ticket) AS NumberRow, SCT_Machine.id_Machine, SCT_Machine.id_Repair, SCT_Machine.serial,SCT_Machine.cause,SCT_Repair.ticket,SCM_Status.status "
    '    sqlstr += " FROM SCT_Machine LEFT JOIN SCT_Repair LEFT JOIN SCM_Status ON SCT_Repair.id_status = SCM_Status.id_status ON SCT_Machine.id_Repair = SCT_Repair.id_Repair   " & wh & "  ORDER BY ticket DESC"
    '    dt = da.GetDataTable(sqlstr, "rial")
    '    Session("DataRial") = dt

    'End Sub

    'Sub GetDataTable()

    '    If Not IsNothing(Session("DataRial")) Then
    '        RadGrid1.DataSource = Session("DataRial").Tables("rial")
    '        RadGrid1.DataBind()
    '    Else
    '        RadGrid1.DataSource = New String() {}
    '        RadGrid1.DataBind()
    '    End If

    'End Sub
#End Region

End Class
