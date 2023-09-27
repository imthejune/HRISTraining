Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports Telerik.Web.UI

Partial Class Account_Login
    Inherits System.Web.UI.Page
    Dim ds As New DataSet
    Dim da As New Mydata(adoconn)
    Dim arr As New Hashtable
    Dim personID As String = ""
    Dim personCode As String = ""
    Dim des As New MyCrypt
    Dim dr() As DataRow
    Dim dtGroupUser As DataTable
    Dim dtCkPerson As DataTable
    Dim dtToken As DataTable
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session.Clear()
            Session.RemoveAll()

            Sys.LoginWeb = New User
            Call LoadRegisty()

            '60-03-29,CHAT' ต้อง new หลัง load registry ถ้าใช้ da จาก public
            da = New Mydata(adoconn)
            prodata.pageGuid = Guid.NewGuid.ToString.Trim
            'Dim s As Object = ConfigurationManager.ConnectionStrings("TrainingConnectionString")
            'Call InsertMsg()

            Call loadCompany()
            Call ADD_Condition()

            '== คิวรีหา Path URL และ Pathweb =='
            Call GetHRISPathURL()
            Call GetSkin()

            Me.txtUser.Focus()

            If Not Directory.Exists(Server.MapPath("~\Uploads")) Then
                Directory.CreateDirectory(Server.MapPath("~\Uploads"))
            End If

            'If Not Directory.Exists(Server.MapPath("~\PersonPic")) Then
            '    Dim FolderName As String = Path.Combine(Server.MapPath("~/PersonPic"), "S")
            '    System.IO.Directory.CreateDirectory(FolderName)

            '    FolderName = Path.Combine(Server.MapPath("~/PersonPic"), "M")
            '    System.IO.Directory.CreateDirectory(FolderName)
            'End If

            'Me.txtUser.Attributes.Add("OnKeyPress", "return ForceEnterHandles(document.all('ctl00$ContentPlaceHolder1$txtPwd'),event)")
            'Me.txtPwd.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('ContentPlaceHolder1_sbmt').click();return false;}} else {return true}; ")

            '== 0 คือ ไม่ได้ล๊อคอินจาก HRISLogin , ถ้าเป็น 1 คือ ล็อคอินจาก HRISLogin =='
            Sys.LoginWeb.HRISLogin = 0

            'รับค่าแบบ(encrypt)
            If Request.QueryString("x") <> "" Then
                Session("HRISModule") = "HRISTime"
                Session("ClickApproveHRIS") = Val(Request.QueryString("a"))
                Dim c As New Cipher("123456789012345safdsaffdsasadfasdfsadf6")
                Dim xstr, xar() As String
                Try
                    'พี่ต่อเพิ่มไว้ .HtmlDecode
                    xstr = c.Decrypt(Server.HtmlDecode(Request.QueryString("x")))
                    xar = xstr.Split("|")
                    'user | password | companyid | ภาษา | CompanyIDUser = บริษัทที่ตัวเองอยู่
                    Me.txtUser.Value = xar(0) '"uid")
                    Me.txtPwd.Value = xar(1) '"pwd")
                    Me.DDLCompany.SelectedValue = xar(2) 'companyid
                   
                    Me.Combo_Lang.SelectedValue = xar(3)
                    Sys.LoginWeb.CompanyIDUser = xar(4)


                    If Session("ClickApproveHRIS") = 0 Then ' 20180423 ใส่ไว้ชั่วคราวไม่รู้ทำไม ตอนกดจาก link น๊ะ ไม่ส่ง Token มา


                        '== Start Token 20180319 กันกรณีก๊อปปี้ลิงค์ที่มี ตัวแปร X ติดมาแล้วเข้าระบบได้ วิธีเช็คคือ เอา TokenID xar(5) ไปค้นหาที่ ADM_ckUserHRIS ฟิวส์ TokenID =='
                        '== เช็คเวลาตอนเข้าระบบด้วย เพราะจะให้เข้าได้เฉพาะตอนที่เพิ่งกดจาก icon ถ้าไม่เช็คจะเข้าได้ทั้งวัน =='
                        Dim str$ = "~/Form/WebWanning.aspx"
                        sqlstr = "select * from ADM_ckUserHRIS where TokenID = '" & Trim(xar(5) & "") & "'  and  DATEDIFF(SECOND, CkTime, GETDATE()) < 10 "

                        dtToken = da.GetDataTable(sqlstr)

                        If dtToken.Rows.Count = 0 Then
                            'ไม่ให้เข้าระบบ
                            Response.Redirect(str)
                        End If
                        '== End Start Token 20180319 =='

                    End If
                   



                    Call sbmt_Click(Nothing, Nothing)
                Catch ex As Exception
                End Try
                Exit Sub
            End If

        End If

    End Sub

    Sub Ckcompanyname() '20220527 big เพิ่ม ชื่อบริษัท
        Dim dtcompanyname As DataTable
        sqlstr = "select * from COM_Company where ID_Company  = " & Val(Me.DDLCompany.SelectedValue & "") & " "
        dtcompanyname = da.GetDataTable(sqlstr)

        If Sys.LoginWeb.Lang & "" = "T" Then
            Sys.LoginWeb.CompanyName = dtcompanyname.Rows(0)("Company_NameT") & ""
        ElseIf Sys.LoginWeb.whPerson & "" = "E" Then
            Sys.LoginWeb.CompanyName = dtcompanyname.Rows(0)("Company_NameE") & ""
        Else
            Sys.LoginWeb.CompanyName = dtcompanyname.Rows(0)("Company_NameO") & ""
        End If
    End Sub

    Protected Sub sbmt_Click(sender As Object, e As EventArgs) Handles sbmt.Click
        Dim uid = txtUser.Value.Trim.Replace("'", "''").Replace(" ", "")
        Dim pwd = txtPwd.Value.Trim.Replace("'", "''").Replace(" ", "")

        Sys.LoginWeb.CompanyID = Val(Me.DDLCompany.SelectedValue & "")  'บริษัทที่ Login เข้ามา
        Sys.LoginWeb.Lang = Me.Combo_Lang.SelectedValue 'If(Me.RadioButton1.Checked = True, "T", "E")
        ' Call Ckcompanyname()
        Dim cSelect As New connExecute

        'cSelect.sqlStr = " SELECT  User2pwd, ADM_UserPws.ID_UserPws, ADM_UserPws.PersonID,ADM_UserPws.PwdEncrypt, PNT_Person.PersonCode, PNT_Person.FnameT, PNT_Person.LnameT, PNT_Person.FnameE,   PNT_Person.LnameE, ADM_UserPws.ID_User, ADM_UserPws.Pws,email ,PNT_Person.CompanyID , PNT_Person.CompanyID  FROM ADM_UserPws INNER JOIN  PNT_Person ON ADM_UserPws.PersonID = PNT_Person.PersonID Left join pnt_persondetail with(nolock) on pnt_person.personid = pnt_persondetail.personid  where PNT_Person.PersonCode = ? and PNT_Person.ChkDeletePerson=1 and PNT_Person.ResignStatus=1 "
        cSelect.sqlStr = "SELECT  User2pwd, ADM_UserPws.ID_UserPws, ADM_UserPws.PersonID, ADM_UserPws.PwdEncrypt, PNT_Person.PersonCode" & _
                        " , PNM_Initial.InitialT+' '+ PNT_Person.FnameT +' '+PNT_Person.LnameT AS FNameLName " & _
                        " , PNM_Initial.InitialT+' '+ PNT_Person.FnameT +' '+PNT_Person.LnameT AS PersonNameT " & _
                        " , PNM_Initial.InitialE+' '+ PNT_Person.FnameE +' '+PNT_Person.LnameE AS PersonNameE " & _
                        " , PNM_Position.PositionCode,  PNM_Position.PositionNameT,  PNM_Position.PositionNameE " & _
                        " , ADM_User.ID_GroupUser, ADM_UserPws.ID_User, ADM_UserPws.Pws, PNT_Person.CompanyID " & _
                        " FROM ADM_UserPws INNER JOIN  PNT_Person ON ADM_UserPws.PersonID = PNT_Person.PersonID Left join ADM_User ON ADM_UserPws.ID_User = ADM_User.ID_User Left join PNM_Initial with(nolock) on pnt_person.InitialID = PNM_Initial.InitialID Left JOIN  PNM_Position  with(nolock) ON  PNT_Person.PositionID =  PNM_Position.PositionID  where PNT_Person.PersonCode = ? and PNT_Person.ChkDeletePerson=1 and PNT_Person.ResignStatus=1  "

        If Request.QueryString("x") <> "" Then
            cSelect.sqlStr = cSelect.sqlStr & String.Format(" and PNT_Person.CompanyID = ? ", Sys.LoginWeb.Lang)
        End If


        cSelect.cmdConnection()
        cSelect.sqlParameter_Value("@p1", "NV", uid)
        cSelect.sqlParameter_Value("@p2", "NV", Sys.LoginWeb.CompanyIDUser)
        Dim dtUserID As DataTable = cSelect.GetDataTable
        'เข้ารหัส
        If dtUserID.Columns.Contains("PwdEncrypt") Then
            Dim des As New MyCrypt
            For Each dr As DataRow In dtUserID.Rows
                Try
                    If dr("PwdEncrypt") & "" <> "" Then
                        dr("pws") = des.Decrypt(dr("PwdEncrypt") & "")
                    End If
                Catch ex As Exception
                End Try
            Next
        End If
        'check password
        For i As Integer = 0 To dtUserID.Rows.Count - 1
            If pwd.Trim <> dtUserID.Rows(i)("pws") & "" Then
                dtUserID.Rows(i).Delete()
            End If
        Next
        dtUserID.AcceptChanges()

        Try
            '== ไอดีพนักงานที่ Login เข้ามา =='
            Sys.LoginWeb.UserID = Val(dtUserID.Rows(0)("PersonID") & "")
            Sys.LoginWeb.PersonCode = Trim(dtUserID.Rows(0)("PersonCode") & "")
            Sys.LoginWeb.FNameLName = Trim(dtUserID.Rows(0)("FNameLName") & "")
            Sys.LoginWeb.PersonNameT = dtUserID.Rows(0)("PersonNameT") & ""
            Sys.LoginWeb.PersonNameE = dtUserID.Rows(0)("PersonNameE") & ""
            Sys.LoginWeb.PositionName = dtUserID.Rows(0)("PositionNameT") & ""
            Sys.LoginWeb.PositionNameT = dtUserID.Rows(0)("PositionNameT") & ""
            Sys.LoginWeb.PositionNameE = dtUserID.Rows(0)("PositionNameE") & ""

            '== ไอดีของกรุ๊ปพนักงาน =='
            Sys.LoginWeb.UserGroupID = Val(dtUserID.Rows(0)("ID_User") & "")
            Sys.LoginWeb.GroupID = Val(dtUserID.Rows(0)("ID_GroupUser") & "")

        Catch ex As Exception
        End Try
        'End If
        GetHRISPathURL()

        'WebPerson พี่ต่อ
        Try
            Dim iduser As String = ""
            Try 'จำเป็นต้องมี try
                iduser = CStr(dtUserID.Rows(0)("ID_User") & "").Trim() 'หาว่าเป็น amin โดย iduser <> ""
            Catch ex As Exception
            End Try

            Dim dtCkCompany As DataTable = Nothing
            If iduser <> "" Then
                dtCkCompany = da.GetDataTable("select * from ADM_ckCompany with(nolock) where ID_User = " & iduser)
            End If

            'เคสกระทิงแดงต้อง กรณี เป็น admin ดูคนข้ามบริษัทฯ จะเก็บสิทธิ์ว่าสามารถดูคนบริษัทฯไหนได้บ้าง
            If Sys.LoginWeb.รายงานข้ามบริษัท = True AndAlso iduser <> "" Then
                Sys.LoginWeb.CkCompanyID = ""
                For Each dr1 As DataRow In dtCkCompany.Rows
                    If Sys.LoginWeb.CkCompanyID = "" Then
                        Sys.LoginWeb.CkCompanyID = dr1("id_company") & ""
                    Else
                        Sys.LoginWeb.CkCompanyID &= "," & dr1("id_company") & ""
                    End If
                Next

                If Sys.LoginWeb.CkCompanyID = "" Then
                    Sys.LoginWeb.CkCompanyID = Val(Me.DDLCompany.SelectedValue)
                End If
            End If
        Catch ex As Exception
        End Try



        If Sys.LoginWeb.UserID = "" Then
            Me.Label7.Visible = True
            Me.txtPwd.Focus()



            'If Sys.LoginWeb.UserGroupID = 0 Then
            '    Sys.LoginWeb.สิทธิ์ = UserType.User
            'Else
            '    If Sys.LoginWeb.GroupID = 0 Then
            '        Sys.LoginWeb.สิทธิ์ = UserType.User
            '    ElseIf Sys.LoginWeb.GroupID = 2 Then
            '        Sys.LoginWeb.สิทธิ์ = UserType.Admin
            '    ElseIf Sys.LoginWeb.GroupID = 5 Then
            '        Sys.LoginWeb.สิทธิ์ = UserType.HR
            '    Else
            '        Sys.LoginWeb.สิทธิ์ = UserType.Supervisor
            '    End If
            'End If


            'Sys.LoginWeb.Lang = If(Me.RadioButton1.Checked = True, "T", "E")

            Dim cookieLang As New HttpCookie("Lang")
            cookieLang.Expires = Now.AddDays(7)
            cookieLang.Value = Sys.LoginWeb.Lang
            Response.Cookies.Add(cookieLang)


            Sys.LoginWeb.SystemName = "TN"
            Sys.LoginWeb.UserName = uid 'ชื่อผู้ใช้ที่ Login เข้ามา

            Sys.TMsg = New Msg 'ไปทำการ new ในหน้า default.aspx
            Sys.LoadTableMasterWeb = New ConnLoadTableMaster

            'ส่งไป Check สิทธิ์ ว่ากรุ๊ป(สิทธิ์) ทำอะไรได้บ้าง
            '  Call SetUserPermission(Sys.LoginWeb.UserGroupID)

            Call SetUserPermission()

            If Session("ErorPwd") = "Y" Then

                '    xMessageBoxRWM_Pwdผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้(RadWindowManager1)
                Exit Sub

            End If
            Call Getlbl(Sys.LoginWeb.Lang)


            '== 20141126 เช็คสิทธิ User ที่ตั้งไว้ใน Company ว่า มองเห็นเมนู(View),เพิ่ม,ลบ,แก้ไข ได้หรือไม่ =='
            Call CkMenuPerson()
            '== 20150824 เช็คสิทธิ เช็คเมนูรายงานต่างๆ ==' 
            Call CkMenuReport()
            '== หากลุ่มการอนุมัติ ว่าตั้งเป็นอะไรอยู่ =='
            Call GetDrPerson()

            If Val(Sys.LoginWeb.UserGroupID) = 1 Or Val(Sys.LoginWeb.UserGroupID) = 0 Then 'เป็น admin ไม่ต้องตรวจสอบ
            Else
                Call CkProgram()
                If Sys.LoginWeb.UseTraining = False Then
                    xMessageBoxRWM_ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ(RadWindowManager1)
                    Exit Sub
                End If
            End If

            '== 20150611 เช็คว่ามีสิทธิเข้าบริษัทไหนได้บ้าง =='
            Call CkCompany()


        Else

            'If Sys.LoginWeb.UserGroupID = 0 Then
            '    Sys.LoginWeb.สิทธิ์ = UserType.User
            'Else
            '    If Sys.LoginWeb.GroupID = 0 Then
            '        Sys.LoginWeb.สิทธิ์ = UserType.User
            '    ElseIf Sys.LoginWeb.GroupID = 2 Then
            '        Sys.LoginWeb.สิทธิ์ = UserType.Admin
            '    ElseIf Sys.LoginWeb.GroupID = 5 Then
            '        Sys.LoginWeb.สิทธิ์ = UserType.HR
            '    Else
            '        Sys.LoginWeb.สิทธิ์ = UserType.Supervisor
            '    End If
            'End If


            ''Sys.LoginWeb.Lang = If(Me.RadioButton1.Checked = True, "T", "E")

            'Dim cookieLang As New HttpCookie("Lang")
            'cookieLang.Expires = Now.AddDays(7)
            'cookieLang.Value = Sys.LoginWeb.Lang
            'Response.Cookies.Add(cookieLang)


            'Sys.LoginWeb.SystemName = "TN"
            'Sys.LoginWeb.UserName = uid 'ชื่อผู้ใช้ที่ Login เข้ามา

            'Sys.TMsg = New Msg 'ไปทำการ new ในหน้า default.aspx
            'Sys.LoadTableMasterWeb = New ConnLoadTableMaster

            ''ส่งไป Check สิทธิ์ ว่ากรุ๊ป(สิทธิ์) ทำอะไรได้บ้าง
            'Call SetUserPermission(Sys.LoginWeb.UserGroupID)
            'Call Getlbl(Sys.LoginWeb.Lang)


            ''== 20141126 เช็คสิทธิ User ที่ตั้งไว้ใน Company ว่า มองเห็นเมนู(View),เพิ่ม,ลบ,แก้ไข ได้หรือไม่ =='
            'Call CkMenuPerson()
            ''== 20150824 เช็คสิทธิ เช็คเมนูรายงานต่างๆ ==' 
            'Call CkMenuReport()
            ''== หากลุ่มการอนุมัติ ว่าตั้งเป็นอะไรอยู่ =='
            'Call GetDrPerson()

            'If Val(Sys.LoginWeb.UserGroupID) = 1 Or Val(Sys.LoginWeb.UserGroupID) = 0 Then 'เป็น admin ไม่ต้องตรวจสอบ
            'Else
            '    Call CkProgram()
            '    If Sys.LoginWeb.UseTraining = False Then
            '        xMessageBoxRWM_ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ(RadWindowManager1)
            '        Exit Sub
            '    End If
            'End If

            ''== 20150611 เช็คว่ามีสิทธิเข้าบริษัทไหนได้บ้าง =='
            'Call CkCompany()

        End If

    End Sub

    Private Sub ADD_Condition()
        Me.Combo_Lang.Items.Clear()

        Me.Combo_Lang.Items.Add(New RadComboBoxItem("ภาษาไทย", "T".ToString()))
        Me.Combo_Lang.Items.Add(New RadComboBoxItem("ภาษาอังกฤษ", "E".ToString()))
        Me.Combo_Lang.Items.Add(New RadComboBoxItem("ภาษาอื่นๆ", "O".ToString()))

        Me.Combo_Lang.SelectedIndex = 0

    End Sub

    Sub CkSeeYourSelf()
        Dim dtSeeYourSelf As DataTable
        sqlstr = "select Personid from PNT_Person  " & Trim(Sys.LoginWeb.whPerson & "") & "  and (PNT_Person.Resignstatus=1  and PNT_Person.chkDeletePerson=1) and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID & "") & " and PNT_Person.PersonID = " & Val(Sys.LoginWeb.UserID & "") & " "
        dtSeeYourSelf = da.GetDataTable(sqlstr)
        If dtSeeYourSelf.Rows.Count <> 0 Then
            Sys.LoginWeb.SeeYourSelf = 0 'เห็นตัวเอง
        Else
            Sys.LoginWeb.SeeYourSelf = 1 'ไม่เห็นตัวเอง
        End If
    End Sub

    'Public Sub SetUserPermission(ByVal iduser As Integer)
    Public Sub SetUserPermission()
        Dim da_conFig As New Mydata(adoconn)
        Dim ds_conFig As New DataSet
        Dim des As New MyCrypt
        Dim ImportStatus$ = ""
        sqlstr = "SELECT * FROM  ADM_User Where Username ='" & Me.txtUser.Value & "'"
        da_conFig.GetDataset(ds_conFig, sqlstr, "ADM_User")

        'If ds_conFig.Tables("ADM_User").Rows.Count = 0 Then Exit Sub

        '== 20170131 Na เพิ่มการกรองคนที่โอนมาจากรีครูท ต้องผ่านการยืนยันจาก HR ที่ระบบ HRISLogin หน้าแจ้งเตือนพนักงานใหม่ =='

        ImportStatus = "  and (PNT_Person.ImportStatus = 'A' or PNT_Person.ImportStatus is null or PNT_Person.ImportStatus = null) "


        If ds_conFig.Tables("ADM_User").Rows.Count <> 0 Then

            Dim pwd = txtPwd.Value.Trim.Replace("'", "''").Replace(" ", "")
            'If ds_conFig.Tables("ADM_User").Columns.Contains("Pwd2") Then
            '  Dim des As New MyCrypt
            For Each dr As DataRow In ds_conFig.Tables("ADM_User").Rows
                Try
                    If dr("Pwd2") & "" <> "" Then

                        Session("ErorPwd") = Nothing

                        If pwd <> des.Decrypt(dr("Pwd2") & "") Then

                            Session("ErorPwd") = "Y"


                            Exit Sub

                        End If

                        Sys.LoginWeb.UserGroupID = dr("ID_GroupUser")
                        Sys.LoginWeb.UserID = dr("ID_User")
                    End If
                Catch ex As Exception
                End Try
            Next
            'End If


            Sys.LoginWeb.WH_Person = Trim(ds_conFig.Tables(0).Rows(0)("WH_Person") & "")

            If Trim(ds_conFig.Tables(0).Rows(0)("WH_Person") & "") <> "" Then
                Try
                    Sys.LoginWeb.WH_Person = des.Decrypt(Sys.LoginWeb.WH_Person)
                Catch ex As Exception
                End Try


                Sys.LoginWeb.whPerson = " Where " & Sys.LoginWeb.WH_Person & ImportStatus

                ''== 20160823 เช็คว่าเห็นตัวเองไหม ห้ามย้ายที่ =='
                Call CkSeeYourSelf()

                '== ถ้าไม่มีสิทธิเห็นตัวเอง =='
                If Sys.LoginWeb.SeeYourSelf = 1 Then
                    Sys.LoginWeb.whPerson = " Where (" & Sys.LoginWeb.WH_Person & " or (PNT_Person.PersonID = " & Val(Sys.LoginWeb.UserID & "") & ")) " & ImportStatus
                End If

                'ห้ามสลับที่
                Sys.LoginWeb.whPerson_NoResig = Sys.LoginWeb.whPerson & " and (PNT_Person.chkDeletePerson=1) and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & ""
                Sys.LoginWeb.whPersonDel = Sys.LoginWeb.whPerson & " and PNT_Person.chkDeletePerson = 0 and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & ""
                Sys.LoginWeb.whPerson &= " and (PNT_Person.Resignstatus=1 and PNT_Person.chkDeletePerson=1) and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & ""
                ' === 20150325 Na เพิ่มมาใหม่ ใช้หน้าประวัติพนักงานลาออก ==='
                Sys.LoginWeb.whPerson_Resign &= " Where " & Sys.LoginWeb.WH_Person & " and (PNT_Person.Resignstatus=0 and PNT_Person.chkDeletePerson=1) and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & ""
            Else
                Sys.LoginWeb.whPerson_NoResig = " Where (PNT_Person.chkDeletePerson=1) and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & "" & ImportStatus
                Sys.LoginWeb.whPersonDel = " Where  PNT_Person.chkDeletePerson = 0 and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & "" & ImportStatus
                Sys.LoginWeb.whPerson = " Where (PNT_Person.Resignstatus=1 and PNT_Person.chkDeletePerson=1 ) and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & "" & ImportStatus
                ' === 20150325 Na เพิ่มมาใหม่ ใช้หน้าประวัติพนักงานลาออก ==='
                Sys.LoginWeb.whPerson_Resign = " Where (PNT_Person.Resignstatus=0 and PNT_Person.chkDeletePerson=1 ) and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & "" & ImportStatus
            End If
        Else
            '== กรณีที่พนักงานไม่มี Group ==='
            Sys.LoginWeb.whPerson = " Where PNT_Person.Personid = " & Sys.LoginWeb.UserID & " and PNT_Person.CompanyID = " & Val(Sys.LoginWeb.CompanyID) & "" & ImportStatus
        End If

    End Sub

    Sub loadCompany()

        Dim da_conFig As New Mydata(adoconn)
        Dim dt_company As DataTable = da_conFig.GetDataTable("SELECT ID_Company,Company_Code, Company_NameT, Company_NameE, Company_Code + ' ' +  Company_NameT as cname  FROM COM_Company")
        Try
            Me.DDLCompany.DataSource = dt_company
            Me.DDLCompany.DataTextField = "cname"
            Me.DDLCompany.DataValueField = "ID_Company"
            Me.DDLCompany.DataBind()
            If dt_company.Rows.Count > 0 Then
                Me.DDLCompany.SelectedIndex = 0
            End If

        Catch ex As Exception
        Finally
        End Try

    End Sub

    Sub CkMenuPerson()
        Dim da As New Mydata(adoconn)
        Dim i As Integer
        Dim dt, dtCkMenuPerson, dtByCompany As DataTable

        'วิธีเช็คเมนู
        '1.เช็ค ADM_Menu(ทุกบริษัท)  
        '2.เช็ค ADM_CkMenuCompany(รายบริษัท)   
        '3.เช็คเมนูรายคน 'กรณี  พนักงานไม่มีกรุ๊ป เช็คที่ตาราง ADM_ckMenuPerson / พนักงานมีกรุ๊ป เช็คที่ตาราง ADM_ckMenu

        '== 20161219 Na เช็คเพิ่มการตั้งค่าเมนูทุกบริษัทหรือรายบริษัท ที่ตั้งค่าจาก HRISCompany >> เมนูข้อมูลการทำงาน >> กำหนดสิทธิ์การใช้ระบบ --'
        sqlstr = "select 0 as CkMenuDup,* from ADM_Menu where  Menu_Prog='TN' "
        dt = da.GetDataTable(sqlstr)
        Session("ADM_Menu") = dt
        If dt Is Nothing Then
            Exit Sub
        End If

        '==>>>>> กรณี มีการ ตั้งเมนู แยกกันตามบริษัทฯ ถ้ากรณีมีการตั้งแยกบริษัท จะอ่านจากการตั้งแยกบริษัท ถึงจะมาตั้งทุกบริษัทก็จะไม่มีผล
        'ต้องมี try เพราะบางที่ไม่ได้ update database
        Try
            sqlstr = " SELECT 0 as CkMenuDup, ADM_CkMenuCompany.ID_ckADM_Menu, ADM_CkMenuCompany.ID_User, ADM_CkMenuCompany.ID_Menu, ADM_CkMenuCompany.ckView, ADM_CkMenuCompany.ckAdd,  ADM_CkMenuCompany.ckEdit, ADM_CkMenuCompany.CkDel, ADM_Menu.Menu_Prog, ADM_Menu.Menu_Code, ADM_Menu.Menu_NameT, ADM_Menu.Menu_NameE, ADM_Menu.FormName FROM ADM_CkMenuCompany INNER JOIN  ADM_Menu ON ADM_CkMenuCompany.ID_Menu = ADM_Menu.ID_Menu  where ADM_CkMenuCompany.ID_User = " & Val(Sys.LoginWeb.CompanyID & "")
            dtByCompany = da.GetDataTable(sqlstr)

            'ถ้ามีการตั้งค่า เมนูตามบริษัทฯไว้
            If dtByCompany.Rows.Count > 0 Then
                For Each dr1 In dt.Rows
                    'เคลียร์ค่า
                    dr1("ckView") = False
                    'ตั้งค่า
                    For Each drMenu In dtByCompany.Select("id_menu=" & dr1("id_menu"))
                        dr1("ckView") = True
                        dr1("ckAdd") = drMenu("ckAdd")
                        dr1("ckEdit") = drMenu("ckEdit")
                        dr1("CkDel") = drMenu("CkDel")
                    Next

                Next
            End If

        Catch ex As Exception
        End Try

        '=== ได้ dt ชุดแรก =='
        If dt Is Nothing Then
            ' isNull = True
        Else
            '** กรณีชนกัน คือ พนักงานที่มีการตั้งค่ากลุ่มผู้ใช้ >>  ยึดจากกลุ่มผู้ใช้เป็นหลัก **'
            If Sys.LoginWeb.สิทธิ์ = UserType.User Then
                dtCkMenuPerson = da.GetDataTable(" SELECT 1 as CkMenuDup, ADM_Menu.Menu_Person, ADM_ckMenuPerson.ID_ckADM_Menu, ADM_ckMenuPerson.ID_User, ADM_ckMenuPerson.ID_Menu, ADM_ckMenuPerson.ckView, ADM_ckMenuPerson.ckAdd,  ADM_ckMenuPerson.ckEdit, ADM_ckMenuPerson.CkDel, ADM_Menu.Menu_Prog, ADM_Menu.Menu_Code, ADM_Menu.Menu_NameT, ADM_Menu.Menu_NameE, ADM_Menu.Menu_NameO, ADM_Menu.FormName FROM ADM_ckMenuPerson INNER JOIN  ADM_Menu ON ADM_ckMenuPerson.ID_Menu = ADM_Menu.ID_Menu where ADM_Menu.Menu_Prog = 'TN' and ADM_ckMenuPerson.ID_User = " & Sys.LoginWeb.UserID & " and ADM_Menu.FormName <> 'Menu'")
            Else
                dtCkMenuPerson = da.GetDataTable(" SELECT 1 as CkMenuDup, ADM_Menu.Menu_Person, ADM_ckMenu.ID_ckADM_Menu, ADM_ckMenu.ID_User, ADM_ckMenu.ID_Menu, ADM_ckMenu.ckView, ADM_ckMenu.ckAdd,  ADM_ckMenu.ckEdit, ADM_ckMenu.CkDel,  ADM_Menu.Menu_Prog, ADM_Menu.Menu_Code, ADM_Menu.Menu_NameT, ADM_Menu.Menu_NameE, ADM_Menu.Menu_NameO, ADM_Menu.FormName FROM ADM_ckMenu INNER JOIN  ADM_Menu ON ADM_ckMenu.ID_Menu = ADM_Menu.ID_Menu where ADM_Menu.Menu_Prog='TN' and adm_ckMenu.ID_User='" & Val(Sys.LoginWeb.UserGroupID) & "' and ADM_Menu.FormName <> 'Menu'")
            End If

            dt.Merge(dtCkMenuPerson)
            dt.AcceptChanges()

        End If

        '***************************************************************************************************************'      
        Dim dv As New DataView(dt)
        Dim distinctTable = dv.ToTable(True, "ID_Menu")
        'หาเมนูซ้ำ
        Dim dra() As DataRow
        For Each drdup In distinctTable.Rows
            dra = dt.Select("ID_Menu=" & drdup("ID_Menu"))
            If dra.Length > 1 Then
                For i = 0 To dra.Length - 1
                    '= ถ้าตั้งเมนูซ้ำกับรายบริษัท ยึดการตั้งค่าผู้ใช้หรือรายคน เป็นหลัก ='
                    If dra(i)("CkMenuDup") = 0 Then
                        dra(i).Delete()
                    End If
                Next
            End If
        Next

        dt.AcceptChanges()
        Session("dtCkMenuPerson") = dt

    End Sub

    Sub CkMenuReport()

        Dim dtReport, dtCkMenuReportPerson, dtReportByCompany As DataTable

        'วิธีเช็คเมนูรายงาน
        '1.เช็ค ADM_Report(ทุกบริษัท)  
        '2.เช็ค ADM_CkReportCompany(รายบริษัท)   
        '3.เช็คเมนูรายคน 'กรณี  พนักงานไม่มีกรุ๊ป เช็คที่ตาราง ADM_ckReportPerson / พนักงานมีกรุ๊ป เช็คที่ตาราง ADM_ckReport

        '== เมนูรายงาน =='
        sqlstr = "select 0 as CkMenuDup,* from ADM_Report where  Report_Prog='TN'"
        dtReport = da.GetDataTable(sqlstr)
        Session("ADM_Report") = dtReport
        If dtReport Is Nothing Then
            Exit Sub
        End If

        '==>>>>> กรณี มีการ ตั้งเมนูรายงาน แยกกันตามบริษัทฯ ถ้ากรณีมีการตั้งแยกบริษัท จะอ่านจากการตั้งแยกบริษัท ถึงจะมาตั้งทุกบริษัทก็จะไม่มีผล
        'ต้องมี try เพราะบางที่ไม่ได้ update database
        Try
            sqlstr = "  select 0 as CkMenuDup,* from ADM_ckReportCompany INNER JOIN  ADM_Report ON ADM_ckReportCompany.ID_Report = ADM_Report.ID_Report  where ADM_ckReportCompany.ID_User =  " & Val(Sys.LoginWeb.CompanyID & "")
            dtReportByCompany = da.GetDataTable(sqlstr)

            'ถ้ามีการตั้งค่า เมนูตามบริษัทฯไว้
            If dtReportByCompany.Rows.Count > 0 Then
                For Each dr1 In dtReport.Rows
                    'เคลียร์ค่า
                    dr1("View_Report") = False
                    'ตั้งค่า
                    For Each drMenu In dtReportByCompany.Select("ID_Report = " & dr1("ID_Report"))
                        dr1("View_Report") = True
                        dr1("Export_Report") = drMenu("Export_Report")
                        dr1("Print_Report") = drMenu("Print_Report")
                    Next

                Next
            End If

        Catch ex As Exception
        End Try

        '=== ได้ dt ชุดแรก =='
        If dtReport Is Nothing Then
            ' isNull = True
        Else

            '** กรณีชนกัน คือ พนักงานที่มีการตั้งค่ากลุ่มผู้ใช้ >>  ยึดจากกลุ่มผู้ใช้เป็นหลัก **
            If Sys.LoginWeb.สิทธิ์ = UserType.User Then
                dtCkMenuReportPerson = da.GetDataTable("SELECT 1 as CkMenuDup, ADM_Report.Report_Person,  ADM_ckReportPerson.ID_ckADM_Report, ADM_ckReportPerson.ID_User, ADM_ckReportPerson.ID_Report, ADM_ckReportPerson.View_Report,   ADM_ckReportPerson.Export_Report, ADM_ckReportPerson.Print_Report, ADM_Report.Report_Prog, ADM_Report.Report_Code,  ADM_Report.Report_NameT, ADM_Report.Report_NameE  FROM  ADM_ckReportPerson INNER JOIN   ADM_Report ON ADM_ckReportPerson.ID_Report = ADM_Report.ID_Report  where ADM_Report.Report_Prog='TN' and ADM_ckReportPerson.ID_User= " & Sys.LoginWeb.UserID & " and ADM_Report.FormName <> 'Menu'")
            Else
                dtCkMenuReportPerson = da.GetDataTable("SELECT 1 as CkMenuDup, ADM_Report.Report_Person, ADM_ckReport.ID_ckADM_Report, ADM_ckReport.ID_User, ADM_ckReport.ID_Report, ADM_ckReport.View_Report,   ADM_ckReport.Export_Report, ADM_ckReport.Print_Report, ADM_Report.Report_Prog, ADM_Report.Report_Code,  ADM_Report.Report_NameT, ADM_Report.Report_NameE FROM  ADM_ckReport INNER JOIN   ADM_Report ON ADM_ckReport.ID_Report = ADM_Report.ID_Report where ADM_Report.Report_Prog='TN' and adm_ckReport.ID_User='" & Val(Sys.LoginWeb.UserGroupID) & "' and ADM_Report.FormName <> 'Menu'")
            End If

            dtReport.Merge(dtCkMenuReportPerson)
            dtReport.AcceptChanges()

        End If


        '***************************************************************************************************************'      
        Dim dv As New DataView(dtReport)
        Dim distinctTable = dv.ToTable(True, "ID_Report")
        'หาเมนูรายงานซ้ำ
        Dim dra() As DataRow
        For Each drdup In distinctTable.Rows
            dra = dtReport.Select("ID_Report=" & drdup("ID_Report"))
            If dra.Length > 1 Then
                For i = 0 To dra.Length - 1
                    '= ถ้าตั้งเมนูซ้ำกับรายบริษัท ยึดการตั้งค่าผู้ใช้หรือรายคน เป็นหลัก ='
                    If dra(i)("CkMenuDup") = 0 Then
                        dra(i).Delete()
                    End If
                Next
            End If
        Next

        dtReport.AcceptChanges()
        Session("dtCkMenuReport") = dtReport

    End Sub
    Sub GetHRISPathURL()

        Dim dtHRISPathURL As DataTable
        sqlstr = "Select * From HRIS_Config "
        dtHRISPathURL = da.GetDataTable(sqlstr)
        If Not IsNothing(dtHRISPathURL) AndAlso dtHRISPathURL.Rows.Count <> 0 Then
            Sys.LoginWeb.Url = dtHRISPathURL.Rows(0)("HRISConfig_PathURL") & ""
            Sys.LoginWeb.Pathweb = dtHRISPathURL.Rows(0)("HRISConfig_PathServer") & "TrainingDoc"

            Session("HRISConfig_PathServertr") = dtHRISPathURL.Rows(0)("HRISConfig_PathServer") & ""
            Sys.LoginWeb.URL_HRISLogin = dtHRISPathURL.Rows(0)("URL_HRISLogin") & ""
            Sys.LoginWeb.URL_HRISCompany = dtHRISPathURL.Rows(0)("URL_HRISCompany") & ""
            Sys.LoginWeb.URL_HRISPerson = dtHRISPathURL.Rows(0)("URL_HRISPerson") & ""
            Sys.LoginWeb.URL_HRISTime = dtHRISPathURL.Rows(0)("URL_HRISTime") & ""
            Sys.LoginWeb.URL_HRISPayroll = dtHRISPathURL.Rows(0)("URL_HRISPayroll") & ""
        End If

    End Sub

    Sub CkProgram()
        sqlstr = "select * from ADM_ckProgram where userid=" & Sys.LoginWeb.UserGroupID & ""
        da.GetDataset(ds, sqlstr, "ckProgram")

        Try
            dr = ds.Tables("ckProgram").Select("Procode='ZVSA'") 'เห็นเงินเดือน 
            If dr.Length = 0 Then
                Sys.LoginWeb.VSA = False 'บังทั้ง Tab เงินเดือนเลย
            Else
                Sys.LoginWeb.VSA = True
            End If

            dr = ds.Tables("ckProgram").Select("Procode='ZESA'") 'แก้ไขเงินเดือน
            If dr.Length = 0 Then
                Sys.LoginWeb.ESA = False
            Else
                Sys.LoginWeb.ESA = True
            End If

            dr = ds.Tables("ckProgram").Select("ProCode='" & Sys.LoginWeb.SystemName & "'")  'เช็คว่าเข้าใช้งานระบบทะเบียนประวัติได้หรือไม่
            If dr.Length = 0 Then
                Sys.LoginWeb.UseTraining = False
            Else
                Sys.LoginWeb.UseTraining = True
            End If

            dr = ds.Tables("ckProgram").Select("ProCode='HRApprove'")  'เช็คว่าผู้ใช้มีสิทธิ์อนุมัติลำดับสุดท้ายไหม
            If dr.Length = 0 Then
                Sys.LoginWeb.HRApprove = False
            Else
                Sys.LoginWeb.HRApprove = True
            End If

        Catch ex As Exception
            xMessageBoxRWM(RadWindowManager1, 300, 120, ex.Message, Sys.TMsg.Warning)
        End Try

    End Sub
    Private Sub GetDrPerson()
        Dim dtxiCmb As DataTable
        '===== เช็คว่าการตั้งค่าใน Time มีการกำหนดกลุ่มการอนุมัติเป็นแบบไหน ========='
        sqlstr = " select TAM_SETUPCompany.ID_Company as companyid, company_code " & _
                 "      , DisplayToPopup " & _
                 " from TAM_SETUPCompany " & _
                 "  inner join com_company with(nolock) on TAM_SETUPCompany.ID_Company = com_company.ID_Company " & _
                 " where TAM_SETUPCompany.ID_Company = " & Val(Sys.LoginWeb.CompanyID) & " "
        dtxiCmb = da.GetDataTable(sqlstr)

        'OLD Standard
        'พวก approve timeout ทั้งหลายคือวันที่ กำหนด user คนแรกไม่อนุมัติภายใน กี่วัน จะกระเด้งไปที่ user ที่สองให้ approve แทน
        Try
            'UseApproveLevel ไว้ตรวจสอบโครงสร้าง table ถ้าเป็นลูกค้าๆ เก่า ๆ จะมีค่า เป็น false
            dtxiCmb.Columns.Add(New DataColumn("UseApproveLevel", GetType(Boolean)))

        Catch ex As Exception
        End Try

        If dtxiCmb.Rows.Count > 0 Then
            Dim dr As DataRow = dtxiCmb.Rows(0)

            Try
                'OLD Standard
                'ตรวจสอบโครงสร้าง table เฉยๆ ว่ามี table ที่ต้องใช้สำหรับการอนุมัติเป็นลำดับขั้นหรือยัง
                dr("UseApproveLevel") = True
                Sys.LoginWeb.CompanyCode = dtxiCmb.Rows(0)("company_code")


                Session("DrPerson") = dr
                'If dr("DisplayToPopup") = True Then' 202220506 สิทให้แก้ เนื่องจาก display ได้ค่าว่าง 
                If Convert.ToBoolean(Val(dr("DisplayToPopup") & "")) = True Then
                    Sys.LoginWeb.DisplayToPopup = 1
                End If
            Catch ex As Exception
                xMessageBoxRWM(RadWindowManager1, 300, 120, ex.Message, Sys.TMsg.Warning)
            End Try
        End If

    End Sub
    Sub CkCompany()
        Dim dtCkCompany As DataTable
        sqlstr = "select * from ADM_ckCompany with(nolock) where ID_User=" & Sys.LoginWeb.UserGroupID & ""
        dtCkCompany = da.GetDataTable(sqlstr)

        '== เช็ค ถ้าบริษัทที่ตัวเองสังกัดอยู่ ไม่ตรงกับ บริษัทที่จะเข้าใช้งาน =='
        If Sys.LoginWeb.CompanyID <> Me.DDLCompany.SelectedValue Then
            If Sys.LoginWeb.UserGroupID = "" Then
                'ไม่มีสิทธิ์ใช้งาน ใน Company นี้
                xMessageBoxRWM_คุณไม่มีสิทธิใช้งานบริษัทนี้(RadWindowManager1)
                Exit Sub
            Else
                Dim dra = dtCkCompany.Select("id_company=" & Val(Me.DDLCompany.SelectedValue))
                If dra.Length = 0 Then
                    'ไม่มีสิทธิ์ใช้งาน ใน Company นี้
                    xMessageBoxRWM_คุณไม่มีสิทธิใช้งานบริษัทนี้(RadWindowManager1)
                    Exit Sub
                Else
                    Sys.LoginWeb.CompanyID = Me.DDLCompany.SelectedValue   'บริษัทที่ Login เข้ามา
                    Call linkpage()
                End If
            End If
        Else
            Call linkpage()
        End If

    End Sub
    Sub linkpage()

        Try
            If Sys.LoginWeb.HRISLogin = 0 Then
                InsertLogfile("WebLogin", "", "Login", "", "", "", "")
            Else
                InsertLogfile("HRISLogin", "", "Login", "", "", "", "")
            End If

        Catch ex As Exception
        End Try

        Select Case Session("ClickApproveHRIS")
            Case Else
                Response.Redirect("~/Form/Start.aspx")
        End Select

    End Sub

    Sub InsertMsg()
        Insert("TEST_111", "ลบข้อมูลเสร็จเรียบร้อย", "Eลบข้อมูลเสร็จเรียบร้อย", "Oลบข้อมูลเสร็จเรียบร้อย")
    End Sub
End Class
