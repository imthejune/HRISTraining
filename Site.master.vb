Imports System.Data
Imports Telerik.Web.UI

Partial Class Site
    Inherits System.Web.UI.MasterPage
    Dim ds As New DataSet
    Dim da As New Mydata(adoconn)
    Dim daCkMenu As New Mydata(DatabaseType.SQLServer)
    Dim dtCkMenu, dtCkReport As DataTable
    Dim daCkReport As New Mydata(DatabaseType.SQLServer)
    Dim ndr() As DataRow
    Dim dtByCompany, dtReportByCompany As DataTable
    Dim MenuName As String
    Dim DisplayName As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim str$ = "~/Form/WebWanning.aspx"

        If Not Page.IsPostBack Then
            Call Lang()
            Call BindCompanyLogin()

            If Sys.LoginWeb.UserID <> "" Then
                '== 20150506 เช็คสิทธิ User ที่ตั้งไว้ใน Company ว่า view ได้หรือไม่ =='
                'Call ChkApproveSecond()
                Call ChkMenu()
                Call ChkMenuReport()
            End If


            If Request.Url.ToString.ToLower.Contains("login.aspx") = False Then

                Try
                    If Val(Sys.LoginWeb.CompanyID) = 0 Then
                        Response.Redirect("~/Account/Login.aspx?mode=Logoff")
                    End If
                Catch ex As Exception

                End Try

            End If





            If IsNothing(Session("LOAD_MENU")) Then
                If Sys.LoginWeb.UserID <> "" Then
                    'Load Once Time
                    Session("LOAD_MENU") = "1"

                    '== 20150506 เช็คสิทธิ User ที่ตั้งไว้ใน Company ว่า view ได้หรือไม่ =='
                    'Call ChkApproveSecond()
                    Call ChkMenu()
                    Call ChkMenuReport()
                End If
            End If
        End If
        '==================================================================='

        Try
            '== เช็คกรณี Login จาก HRIS =='
            If Sys.LoginWeb.HRISLogin = 1 Then
                '== ถ้าไม่ได้มาจากการคลิกเข้าระบบที่ icon Personnel ให้แจ้งเตือน ==' 
                If Session("HRISModule") <> "HRISTime" Then
                    Response.Redirect(str)
                End If

                '== Start Token =='
                '== 20180320 กันกรณี ล็อคอิน ด้วย admin แล้วเข้า person เห็นพนักงาน 100 คน แล้วออกจากระบบที่ Login จากนั้นเข้าระบบด้วยพนง.ปกติ เห็นพนักงาน 2 คน เข้าระบบแล้วเข้า Person แท๊บเดิมที่เข้ากับ Admin จะต้องใช้งานไม่ได้ =='
                If Request.Url.ToString.ToLower.Contains("login.aspx") = False Then
                    sqlstr = "select tokenid from ADM_ckUserHRIS where personid = '" & Sys.LoginWeb.UserID & "' and SystemName = 'TN'"
                    Dim token$ = da.Executescalar(sqlstr)
                    If ViewState("tokenid") & "" <> "" AndAlso ViewState("tokenid") & "" <> token Then
                        Response.Redirect(str)
                        Exit Sub
                    Else

                        Dim ckFirstName As HttpCookie = Request.Cookies("TokenTime")
                        If (ckFirstName IsNot Nothing) Then
                            'Me.Label1.Text = "Cookies :" & Request.Cookies("token").Value
                            'Me.Label2.Text = "token :" & token
                            '== 20180321 กันกรณี ล็อคอิน ด้วย admin แล้วเข้า person แล้วออกจากระบบที่ Login จากนั้นเข้าระบบด้วยพนง.ปกติ เข้าระบบแล้วไม่กด icon เข้า Person แต่ไปใช้ Tab เดิม ต้องใช้งานไม่ได้ =='
                            If Request.Cookies("TokenTime").Value <> token Then
                                Response.Redirect(str)
                                Exit Sub
                            End If
                        End If
                        ViewState("tokenid") = token
                    End If
                End If
                '== End Start Token =='


                'CHAT,600427 ป้องกันกดปุ่ม Back จาก Explorer
                If Request.QueryString("mode") = "Logoff" Then
                    ScriptManager.RegisterStartupScript(Me, [GetType](), "myclose", "setTimeout(function(){window.open('', '_self', '');window.close();}, 100);", True)
                Else
                    '== ถ้าไม่ได้มาจากการคลิกเข้าระบบที่ icon Personnel ให้แจ้งเตือน ==' 
                    If Session("HRISModule") <> "HRISTime" Then
                        Response.Redirect(str)
                    End If
                End If
            End If
        Catch ex As Exception
            Response.Redirect(str)
        End Try


        '== 20160705 กันไว้อีกชั้น  เช็คสิทธิ กรณีเข้ารหัสพนักงานที่  >>มีสิทธิ<<  เข้าหน้าประวัติเพิ่มเติม แล้วก๊อบลิงค์ไว้ =='
        '== จากนั้นเข้าระบบด้วยรหัสพนักงานที่ ไม่มีสิทธิ   แล้วเอาลิงค์ที่ก๊อบมาแปะ ต้องเข้าไม่ได้ =='

        If Sys.LoginWeb.MenuCode <> "" Then
            If Session("dtCkMenuPerson") IsNot Nothing Then
                dtCkMenu = CType(Session("dtCkMenuPerson"), DataTable)
                ndr = dtCkMenu.Select("Menu_Code = '" & Trim(Sys.LoginWeb.MenuCode & "") & "'")
                If ndr.Length = 0 Then
                    Response.Redirect(str)
                End If
            End If

        End If

        '== 20160406 Na กรณีมาจากการคลิกอนุมัติที่หน้า HRISLogin ให้บังเมนู =='
        If Session("ClickApproveHRIS") <> 0 Then
            Me.RadMenu1.Visible = False
        Else
            Me.RadMenu1.Visible = True
        End If




    End Sub


    Sub BindCompanyLogin()

        '== บริษัทที่เข้าใช้งาน (เลือกจากหน้า Popup) =='
        sqlstr = String.Format("select ID_Company, Company_Code +' '+ Company_Name{0} as CompanyName From COM_Company where ID_Company = " & Val(Sys.LoginWeb.CompanyID) & "", Sys.LoginWeb.Lang)
        Dim dtCompany = da.GetDataTable(sqlstr)
        If Not IsNothing(dtCompany) AndAlso dtCompany.Rows.Count > 0 Then
            Me.lblCompany.Text = Sys.TMsg.บริษัทที่เข้าใช้งาน & " :"
            Me.lblCompanyName.Text = dtCompany.Rows(0)("CompanyName") & ""
        End If

    End Sub

    Private Sub ChkMenu()
        Dim i As Integer
        '== ปิดทุกเมนูก่อน =='
        Dim dtMenu As DataTable = CType(Session("ADM_Menu"), DataTable)
        If dtMenu.Rows.Count <> 0 Then
            For i = 0 To dtMenu.Rows.Count - 1
                SetMenu(dtMenu.Rows(i)("Menu_Code"), True)
            Next
        End If

        Dim dt As DataTable = Session("dtCkMenuPerson")

        '== แสดง-ซ้อน เมนูทุกบริษัทหรือรายบริษัท =='
        For i = 0 To dt.Rows.Count - 1
            MenuName = dt.Rows(i)("Menu_Code")

            Select Case Sys.LoginWeb.Lang
                Case "T" : DisplayName = dt.Rows(i)("Menu_NameT") & ""
                Case "E" : DisplayName = dt.Rows(i)("Menu_NameE") & ""
                Case "O" : DisplayName = dt.Rows(i)("Menu_NameO") & ""
                Case Else : DisplayName = ""
            End Select

            '= เช็คค่าว่าง
            If IsDBNull(dt.Rows(i)("ckView")) = False Then
                '= ถ้าเมนูนั้นมีการติ๊กตั้งค่า View เมนูถึงจะเปิด
                If dt.Rows(i)("ckView") = True Then
                    '==กันไว้กรณีตั้งค่าเมนูรวมบริษัทหรือรายบริษัท ให้ user ปกติเข้าได้เฉพาะหน้าที่ตัวเองมีสิทธิเท่านั้น =='
                    If Sys.LoginWeb.สิทธิ์ = UserType.User Or Sys.LoginWeb.สิทธิ์ = UserType.Supervisor Then
                        'แยก case เนื่องจากสิทธิ์ของ user ให้ดึงอัตโนมัติจาก Menu_Person  แต่ถ้าเป็น sup จะต้องเช็คจาก การมองเห็นเมนูอีกครั้ง
                        If Sys.LoginWeb.สิทธิ์ = UserType.User Then ndr = dt.Select(" Menu_Code = '" & MenuName & "' and Menu_Person = 1")
                        If Sys.LoginWeb.สิทธิ์ = UserType.Supervisor Then ndr = dt.Select(" Menu_Code = '" & MenuName & "' and Menu_Person = 1 and ID_User=" & Val(Sys.LoginWeb.UserGroupID))

                        If ndr.Length > 0 Then
                            SetMenu(MenuName, True, DisplayName)
                        End If
                    Else
                        SetMenu(MenuName, True, DisplayName)
                    End If
                End If
            Else
                '== 20170104 Chat เปลี่ยนภาษาเมนู =='
                If DisplayName <> "" Then
                    Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)
                    If IsNothing(menu.FindItemByValue(MenuName)) Then

                    Else
                        menu.FindItemByValue(MenuName).Text = DisplayName
                    End If
                End If
            End If
        Next


        Me.RadMenu1.FindItemByValue("TNM1_003").Visible = True
        '===================================================================================================='
        '== ถ้าเป็นพนักงานปกติไม่มีกรุ๊ป ให้บังเมนูออก ==='
        'If Sys.LoginWeb.สิทธิ์ = UserType.User OrElse Sys.LoginWeb.สิทธิ์ = UserType.Supervisor Then
        If Sys.LoginWeb.สิทธิ์ = UserType.User Then
            'Chat, 601226 : นิ้วบอกว่า สิทธิ์ user จะไม่มีการ default จะต้องกำหนดที่ company
            'Me.RadMenu1.FindItemByValue("TAM1").Visible = True 'เมนูข้อมูลการทำงาน
            'Me.RadMenu1.FindItemByValue("TAM1_004").Visible = True 'บันทึกใบลา
            'Me.RadMenu1.FindItemByValue("TAM1_004_01").Visible = True 'บันทึกใบลา
            'Me.RadMenu1.FindItemByValue("TAM1_004_03").Visible = True 'ตารางบันทึกใบลา
            'Me.RadMenu1.FindItemByValue("TAM1_005").Visible = True 'บันทึกการขอโอที
            'Me.RadMenu1.FindItemByValue("TAM1_005_04").Visible = True 'การขอโอทีแบบปกติ แต่ละบุคคล
            'Me.RadMenu1.FindItemByValue("TAM1_006").Visible = True 'บันทึกการตั้งกะงาน
            'Me.RadMenu1.FindItemByValue("TAM1_006_01").Visible = True 'การตั้งกะงานแต่ละคน
            'Me.RadMenu1.FindItemByValue("TAM1_007").Visible = True 'บันทึกการเพิ่มเวลา
            'Me.RadMenu1.FindItemByValue("TAM1_007_01").Visible = True 'บันทึกการเพิ่มเวลา
            ''----------------------------------- APPROVE SECOND -----------------------------------
            ''สำหรับกรณีที่มีการ set สิทธิ์เป็นผู้อนุมัติให้เห็นเมนู
            'Dim dtLeaveSecond = CType(Session("dtLeaveSecond"), DataTable)
            'If Not IsNothing(dtLeaveSecond) AndAlso dtLeaveSecond.Rows.Count > 0 Then
            '    Me.RadMenu1.FindItemByValue("TAM1_004_02").Visible = True 'อนุมัติใบลา
            'End If

            'Dim dtOvertimeSecond = CType(Session("dtOvertimeSecond"), DataTable)
            'If Not IsNothing(dtOvertimeSecond) AndAlso dtOvertimeSecond.Rows.Count > 0 Then
            '    Me.RadMenu1.FindItemByValue("TAM1_005_09").Visible = True 'อนุมัติโอทีแบบปกติ
            'End If

            'Dim dtTimeInOutSecond = CType(Session("dtTimeInOutSecond"), DataTable)
            'If Not IsNothing(dtTimeInOutSecond) AndAlso dtTimeInOutSecond.Rows.Count > 0 Then
            '    Me.RadMenu1.FindItemByValue("TAM1_007_02").Visible = True 'อนุมัติการเพิ่มเวลา
            'End If
        End If

    End Sub

    Sub ChkMenuReport()
        Dim i As Integer
        '== ปิดทุกเมนูก่อน =='
        Dim dtReport As DataTable = CType(Session("ADM_Report"), DataTable)
        If dtReport.Rows.Count <> 0 Then
            For i = 0 To dtReport.Rows.Count - 1
                Call SetMenu(dtReport.Rows(i)("Report_Code"), False)
            Next
        End If

        Dim dt As DataTable = Session("dtCkMenuReport")

        '== แสดง-ซ้อน เมนูทุกบริษัทหรือรายบริษัท =='
        For i = 0 To dt.Rows.Count - 1
            MenuName = dt.Rows(i)("Report_Code")

            If MenuName = "TAR_001_13" Then
                Dim x As String = ""
            End If

            Select Case Sys.LoginWeb.Lang
                Case "T" : DisplayName = dt.Rows(i)("Report_NameT") & ""
                Case "E" : DisplayName = dt.Rows(i)("Report_NameE") & ""
                Case "O" : DisplayName = dt.Rows(i)("Report_NameO") & ""
                Case Else : DisplayName = ""
            End Select

            '= เช็คค่าว่าง
            If IsDBNull(dt.Rows(i)("View_Report")) = False Then
                '= ถ้าเมนูนั้นมีการติ๊กตั้งค่า View เมนูถึงจะเปิด
                If dt.Rows(i)("View_Report") = True Then
                    '==กันไว้กรณีตั้งค่าเมนูรวมบริษัทหรือรายบริษัท ให้ user ปกติเข้าได้เฉพาะหน้าที่ตัวเองมีสิทธิเท่านั้น =='
                    If Sys.LoginWeb.สิทธิ์ = UserType.User Or Sys.LoginWeb.สิทธิ์ = UserType.Supervisor Then
                        'แยก case เนื่องจากสิทธิ์ของ user ให้ดึงอัตโนมัติจาก Menu_Person  แต่ถ้าเป็น sup จะต้องเช็คจาก การมองเห็นเมนูอีกครั้ง
                        If Sys.LoginWeb.สิทธิ์ = UserType.User Then ndr = dt.Select(" Report_Code = '" & MenuName & "' and Report_Person = 1")
                        If Sys.LoginWeb.สิทธิ์ = UserType.Supervisor Then ndr = dt.Select(" Report_Code = '" & MenuName & "' and Report_Person = 1 and ID_User=" & Val(Sys.LoginWeb.UserGroupID))

                        If ndr.Length > 0 Then
                            SetMenu(MenuName, True, DisplayName)
                        End If
                    Else
                        SetMenu(MenuName, True, DisplayName)
                    End If
                End If
            Else
                '== 20170104 Chat เปลี่ยนภาษาเมนู =='
                If DisplayName <> "" Then
                    Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)
                    If IsNothing(menu.FindItemByValue(MenuName)) Then

                    Else
                        menu.FindItemByValue(MenuName).Text = DisplayName
                    End If
                End If
            End If
        Next

        If Sys.LoginWeb.สิทธิ์ = UserType.User Or Sys.LoginWeb.สิทธิ์ = UserType.Supervisor Then
            '== 20171226 Chat เช็คหัวเมนู ถ้าติ๊กเมนูย่อย ก็จะแสดงหัวเมนูออกมาอัตโนมัติ =='
            If CkVisibleMenuReport("TAR_001_13") = True OrElse CkVisibleMenuReport("TAR_001_14") = True OrElse CkVisibleMenuReport("TAR_001_15") = True Then
                'Me.RadMenu1.FindItemByValue("TAR_001_13").Visible = True 'รายงานตรวจสอบข้อมูลดิบการลงเวลา แยกตามวันที่
                'Me.RadMenu1.FindItemByValue("TAR_001_14").Visible = True 'รายงานตรวจสอบข้อมูลดิบการลงเวลา แยกตามพนักงาน
                'Me.RadMenu1.FindItemByValue("TAR_001_15").Visible = True 'สถิติการลงเวลา
                Call CkVisibleMenu("TAM3", True) 'รายงาน
                'Call CkVisibleMenu("TAR_001", False) 'ซ่อนหัว รายงานข้อมูลดิบ
            End If

            If CkVisibleMenuReport("TAR_005_22") = True OrElse CkVisibleMenuReport("TAR_005_23") = True Then
                'Me.RadMenu1.FindItemByValue("TAR_005_22").Visible = True 'รายงานตรวจสอบข้อมูลหลังการประมวลผลวันทำงาน แยกตามวันที่
                'Me.RadMenu1.FindItemByValue("TAR_005_23").Visible = True 'รายงานตรวจสอบข้อมูลหลังการประมวลผลวันทำงาน แยกตามพนักงาน
                Call CkVisibleMenu("TAM3", True) 'รายงาน
                'Call CkVisibleMenu("TAR_005", False) 'ซ่อนหัว รายงานข้อมูลหลังการประมวลผลวันทำงาน
            End If

            If CkVisibleMenuReport("TAR_006_15") = True OrElse CkVisibleMenuReport("TAR_006_16") = True Then
                'Me.RadMenu1.FindItemByValue("TAR_006_15").Visible = True 'รายงานการทำโอที แยกตามพนักงาน
                'Me.RadMenu1.FindItemByValue("TAR_006_16").Visible = True 'รายงานแผน/การปฏิบัติงานล่วงเวลา
                Call CkVisibleMenu("TAM3", True) 'รายงาน
                ' Call CkVisibleMenu("TAR_006", False) 'ซ่อนหัว รายงานการทำโอที
            End If

            If CkVisibleMenuReport("TAR_007_08") = True Then
                'Me.RadMenu1.FindItemByValue("TAR_007_08").Visible = True 'รายงานข้อมูลหลังประมวลผลส่งระบบเงินเดือนแยกตามเดือน
                Call CkVisibleMenu("TAM3", True) 'รายงาน
                ' Call CkVisibleMenu("TAR_007", False) 'ซ่อนหัว รายงานสรุปส่งระบบเงินเดือน
            End If

            If CkVisibleMenuReport("TAR_011_11") = True OrElse CkVisibleMenuReport("TAR_011_12") = True OrElse CkVisibleMenuReport("TAR_011_13") = True Then
                'Me.RadMenu1.FindItemByValue("TAR_011_11").Visible = True 'รายงานตรวจสอบสิทธิ์การลา
                'Me.RadMenu1.FindItemByValue("TAR_011_12").Visible = True 'รายงานตรวจสอบประวัติการลา
                'Me.RadMenu1.FindItemByValue("TAR_011_13").Visible = True 'ตารางการลา
                Call CkVisibleMenu("TAM3", True) 'รายงาน
                ' Call CkVisibleMenu("TAR_011", False) 'ซ่อนหัว รายงานใบลางาน
            End If

            If CkVisibleMenuReport("TAR_016_11") = True Then
                'Me.RadMenu1.FindItemByValue("TAR_016_11").Visible = True 'รายงานวันหยุดประจำปี
                Call CkVisibleMenu("TAM3", True) 'รายงาน
                ' Call CkVisibleMenu("TAR_016", False) 'ซ่อนหัว รายงานการตั้งค่า
            End If



        End If

        'Chat, 601226 : นิ้วบอกว่า สิทธิ์ user จะไม่มีการ default จะต้องกำหนดที่ company
        'Report For User ========================================================
        'Me.RadMenu1.FindItemByValue("TAM3").Visible = True 'รายงาน
        'Me.RadMenu1.FindItemByValue("TAR_021").Visible = True 'รายงานตรวจสอบข้อมูลดิบการลงเวลา แยกตามวันที่
        'Me.RadMenu1.FindItemByValue("TAR_022").Visible = True 'รายงานตรวจสอบข้อมูลดิบการลงเวลา แยกตามพนักงาน
        'Me.RadMenu1.FindItemByValue("TAR_023").Visible = True 'ตรวจสอบข้อมูลหลังการประมวลผลวันทำงาน แยกตามวันที่
        'Me.RadMenu1.FindItemByValue("TAR_024").Visible = True 'ตรวจสอบข้อมูลหลังการประมวลผลวันทำงาน แยกตามพนักงาน
        'Me.RadMenu1.FindItemByValue("TAR_025").Visible = True 'ตรวจสอบสิทธิ์การลา
        'Me.RadMenu1.FindItemByValue("TAR_026").Visible = True 'ตรวจสอบประวัติการลา
        'Me.RadMenu1.FindItemByValue("TAR_027").Visible = True 'ตารางการลา
        'Me.RadMenu1.FindItemByValue("TAR_028").Visible = True 'การทำโอที แยกตามพนักงาน
        'Me.RadMenu1.FindItemByValue("TAR_029").Visible = True 'ข้อมูลหลังประมวลผลส่งระบบเงินเดือนแยกตามเดือน
        'Me.RadMenu1.FindItemByValue("TAR_030").Visible = True 'สถิติการลงเวลา
        'Me.RadMenu1.FindItemByValue("TAR_031").Visible = True 'รายงานแผน/การปฏิบัติงานล่วงเวลา
        'Me.RadMenu1.FindItemByValue("TAR_032").Visible = True 'รายงานวันหยุดประจำปี
    End Sub

    Private Sub SetMenu(ByVal MenuName As String, ByVal ckVisible As Boolean, Optional ByVal DisplayName As String = "")
        Try
            Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)
            If IsNothing(menu.FindItemByValue(MenuName)) Then
                Exit Sub
            End If

            menu.FindItemByValue(MenuName).Visible = ckVisible

            '== 20170104 Chat เปลี่ยนภาษาเมนู =='
            If DisplayName <> "" Then
                menu.FindItemByValue(MenuName).Text = DisplayName
            End If

            '== 20150507 Na เช็คหัวเมนู ถ้าติ๊กเมนูย่อย ก็จะแสดงหัวเมนูออกมาอัตโนมัติ =='
            Select Case MenuName
                Case "TNM1_001" To "TNM1_002"
                    Call CkVisibleMenu("TNM1", ckVisible) '[ข้อมูลการทำงาน]
                    '-----------------------------------------------------------------------
                    '######################################################################
                Case "TAM2_001" To "TAM2_015"
                    Call CkVisibleMenu("TAM2", ckVisible) '[การประมวลผล]
                    '-----------------------------------------------------------------------
                    '######################################################################
                Case "TNR1_001" To "TNR1_027"
                    Call CkVisibleMenu("TNR1", ckVisible) '[รายงาน]

                    Select Case MenuName
                        Case "TNR1_001_01" To "TNR1_001_02"
                            Call CkVisibleMenu("TNR1_001", ckVisible) 'รายงานการจัดทำแผนการฝึกอบรม แยกตามพนักงาน
                        Case "TNR1_006_01" To "TNR1_006_13"
                            Call CkVisibleMenu("TNR1_006", ckVisible) 'รายงานประวัติการฝึกอบรมประจำปี
                        Case "TNR1_007_01" To "TNR1_007_14"
                            Call CkVisibleMenu("TNR1_007", ckVisible) 'รายงานประวัติการฝึกอบรม แยกตามพนักงาน
                        Case "TNR1_015_01" To "TNR1_015_04"
                            Call CkVisibleMenu("TNR1_015", ckVisible) 'รายงานกำหนดให้พนักงานยืนยันการเข้าอบรม
                        Case "TNR1_018_01" To "TNR1_018_02"
                            Call CkVisibleMenu("TNR1_018", ckVisible) 'รายงานแนวทางการอบรม
                        Case "TNR1_019_01"
                            Call CkVisibleMenu("TNR1_019", ckVisible) 'รายงานส่วนเพิ่มเติมพิเศษ
                        Case "TNR1_020_01" To "TNR1_020_03"
                            Call CkVisibleMenu("TNR1_020", ckVisible) 'รายงานผลการประเมินวิทยากร
                        Case "TNR1_021_01" To "TNR1_021_06"
                            Call CkVisibleMenu("TNR1_021", ckVisible) 'รายงานการเสนอหลักสูตรการอบรมผ่านเว็บ
                        Case "TNR1_025_01" To "TNR1_025_03"
                            Call CkVisibleMenu("TNR1_025", ckVisible) 'งบประมาณฝ่าย
                        Case "TNR1_026_01" To "TNR1_026_08"
                            Call CkVisibleMenu("TNR1_026", ckVisible) 'รายงานการตั้งค่า
                    End Select
                    '----------------------------------------------------------------------
                    '######################################################################
                Case "TAM4_001" To "TAM4_010"
                    Call CkVisibleMenu("TAM4", ckVisible) '[กราฟวิเคราะห์]
                    '----------------------------------------------------------------------
                    '######################################################################
                Case "TAM5_001" To "TAM5_019"
                    Call CkVisibleMenu("TAM5", ckVisible) '[เครื่องมือ]
                    Select Case MenuName
                        Case "TAM5_005_01" To "TAM5_005_03"
                            Call CkVisibleMenu("TAM5_005", ckVisible) 'การโอนสิทธิ์พักร้อน
                    End Select
                    '----------------------------------------------------------------------
                    '######################################################################
                Case "TAM6_001" To "TAM6_012"
                    Call CkVisibleMenu("TAM6", ckVisible) '[การติดตั้งค่า]
                    Select Case MenuName
                        Case "TAM6_001_01" To "TAM6_001_07"
                            Call CkVisibleMenu("TAM6_001", ckVisible) 'การตั้งค่าบริษัท
                        Case "TAM6_005_01" To "TAM6_005_03"
                            Call CkVisibleMenu("TAM6_005", ckVisible) 'การตั้งค่าบริษัท
                    End Select
            End Select

        Catch ex As Exception
        End Try

    End Sub

    '== 20171226 Chat สำหรับ control แสดงเมนู
    Function CkVisibleMenuReport(ByVal MenuName As String) As Boolean
        Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)
        If IsNothing(menu.FindItemByValue(MenuName)) Then
            Return False
        Else
            If menu.FindItemByValue(MenuName).Visible = True Then
                Return True
            Else
                Return False
            End If
        End If
    End Function


    Sub CkVisibleMenu(ByVal MenuName As String, ByVal ckVisible As Boolean)
        Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)
        If IsNothing(menu.FindItemByValue(MenuName)) Then
            Exit Sub
        End If

        If ckVisible = True Then
            menu.FindItemByValue(MenuName).Visible = True
        Else
            menu.FindItemByValue(MenuName).Visible = False
        End If

    End Sub

    Protected Sub LinkButtonExit_Click(sender As Object, e As EventArgs) Handles LinkButtonExit.Click
        Try
            Try
                InsertLogfile("", "", "Logoff", "", "", "", "")
            Catch ex As Exception

            End Try
            If Sys.LoginWeb.HRISLogin = 1 Then
                Session("HRISModule") = Nothing
                Call ClearSession()

                'ScriptManager.RegisterStartupScript(Me, [GetType](), "myclose", "setTimeout(function(){window.open('', '_self', '');window.close();}, 100);", True)


                Response.Redirect("~/Account/Login.aspx?mode=Logoff")
            Else
                Call ClearSession()
                Response.Redirect("~/Account/Login.aspx")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChkApproveSecond()

        sqlstr = String.Format("select * From TAM_ApproveLeaveSecond where PersonSecondID = {0} ", Val(Sys.LoginWeb.UserID))
        Dim dtLeaveSecond = da.GetDataTable(sqlstr)
        Session("dtLeaveSecond") = dtLeaveSecond

        sqlstr = String.Format("select * From TAM_ApproveSecond where PersonSecondID = {0} ", Val(Sys.LoginWeb.UserID))
        Dim dtOvertimeSecond = da.GetDataTable(sqlstr)
        Session("dtOvertimeSecond") = dtOvertimeSecond

        sqlstr = String.Format("select * From TAM_ApproveTimeInoutSecond where PersonSecondID = {0} ", Val(Sys.LoginWeb.UserID))
        Dim dtTimeInOutSecond = da.GetDataTable(sqlstr)
        Session("dtTimeInOutSecond") = dtTimeInOutSecond

    End Sub


    Sub ClearSession()
        Session.Clear()
        Session.RemoveAll()
    End Sub

    Sub Lang()
        Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)

    End Sub

    Sub GetMenu(ByVal ckVisible As Boolean)
        Dim daMenu As New Mydata(DatabaseType.SQLServer)
        Dim dtMenu As DataTable
        Dim i As Integer
        Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)
        Dim menuCode As String = ""
        Dim menuName As String = ""
        dtMenu = daMenu.GetDataTable("select * from ADM_Menu where  Menu_Prog='TN' and FormName <> 'Menu' ")

        If dtMenu.Rows.Count <> 0 Then
            'For i = 0 To ds.Tables("Menu").Rows.Count - 1
            For i = 0 To dtMenu.Rows.Count - 1
                SetMenu(dtMenu.Rows(i)("Menu_Code"), ckVisible)
                If Sys.LoginWeb.Lang <> "T" Then
                    menuCode = dtMenu.Rows(i)("Menu_Code").ToString() & ""
                    menuName = dtMenu.Rows(i)("Menu_Name" & Sys.LoginWeb.Lang).ToString() & ""
                    menu.FindItemByValue(menuCode).Text = menuName
                End If
            Next
        End If

    End Sub

    Sub GetReport(ByVal ckVisible As Boolean)
        Dim daReport As New Mydata(DatabaseType.SQLServer)
        Dim dtReport As DataTable

        Dim i As Integer
        Dim menu As RadMenu = DirectCast(Me.Page.Master.FindControl("RadMenu1"), RadMenu)
        Dim menuCode As String = ""
        Dim menuName As String = ""
        dtReport = daReport.GetDataTable("select * from ADM_Report where  Report_Prog='TN' and FormName <> 'Menu' ")

        '-----
        If dtReport.Rows.Count <> 0 Then
            For i = 0 To dtReport.Rows.Count - 1
                Call SetMenu(dtReport.Rows(i)("Report_Code"), ckVisible)
                If Sys.LoginWeb.Lang <> "T" Then
                    menuCode = dtReport.Rows(i)("Report_Code").ToString() & ""
                    menuName = dtReport.Rows(i)("Report_Name" & Sys.LoginWeb.Lang).ToString() & ""
                    menu.FindItemByValue(menuCode).Text = menuName
                End If
            Next
        End If
    End Sub

End Class

