Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Public Class OpenReport
    Public WH As String = "" 'รับค่าการค้นหา 
    Public WHJoin As String = ""    'รับค่า การ Join เพิ่มกรณีเลือกเป็นประวัติการศึกษา
    Public MenuReport As String     'รับค่าชื่อรายงาน
    Public LangReport As String     'รับค่าภาษา
    Public GroupReport As String    'จัดกลุ่มรายงาน Tree ด้านซ้าย 
    Public GroupCm1_NewPageAfter As Boolean = False     'รับค่าขึ้นหน้าใหม่
    Public GroupOrderbyName As String   'รับค่า การจัดเรียง Group ตามที่เลือกใน Combo
    Public FindOrganize As String   'รับค่าค้นหารายงานหน่วยงาน ตามที่เลือกใน Combo
    Public CheckData As Boolean = False
    Public WHResign As String = "" 'แสดงพนักงานที่ลาออกไปแล้ว
    Public WHPerson As String = "" 'แสดงข้อมูลตามสิทธิ์
    Public WHReportCustom As String = ""  'รับข้อมูลจากหน้า WebReportTime
    Public CustomSQL_Select As String = "" 'รับข้อมูลจากหน้า WebReportTime
    Public CustomReportName As String = ""  'รับข้อมูลจากหน้า WebReportTime
    Public FixReportName As String = ""
    Public CheckCase As String = ""
    Public CheckGroup As String = "" 'จัดกลุ่มข้อมูล 0:No  , 1:Yes
    Public ShowDetail As String = "" 'แสดงรายละเอียด
    Public WHSelect As String = ""    'รับค่า select เพิ่มเติม
    Public selectyear As String = ""  'รับค่าปีมา ' big เพิ่ม 2021/12/22

    '=================================================================
    Public Text_1 As String = ""
    Public Text_2 As String = ""
    Public Text_3 As String = ""
    Public Text_4 As String = ""
    Public Text_5 As String = ""
    Public Text_6 As String = ""
    Public Text_7 As String = ""
    Public Text_8 As String = ""
    Public Text_9 As String = ""
    Public Text_10 As String = ""
    Public Text_11 As String = ""
    Public Text_12 As String = ""
    Public Text_13 As String = ""
    Public Text_14 As String = ""
    Public Text_15 As String = ""
    Public Text_16 As String = ""
    Public Text_17 As String = ""
    Public Text_18 As String = ""
    Public Text_19 As String = ""
    Public Text_20 As String = ""

    Public Check_1 As Boolean = False
    Public Check_2 As Boolean = False
    Public Check_3 As Boolean = False
    Public Check_4 As Boolean = False
    Public Check_5 As Boolean = False
    Public Check_6 As Boolean = False
    Public Check_7 As Boolean = False
    Public Check_8 As Boolean = False
    Public Check_9 As Boolean = False
    Public Check_10 As Boolean = False
    Public Check_11 As Boolean = False
    Public Check_12 As Boolean = False
    Public Check_13 As Boolean = False
    Public Check_14 As Boolean = False
    Public Check_15 As Boolean = False
    Public Check_16 As Boolean = False
    Public Check_17 As Boolean = False
    Public Check_18 As Boolean = False
    Public Check_19 As Boolean = False
    Public Check_20 As Boolean = False

    Public Day_1 As String = ""
    Public Day_2 As String = ""
    Public Day_3 As String = ""
    Public Day_4 As String = ""
    Public Day_5 As String = ""
    Public Day_6 As String = ""
    Public Day_7 As String = ""
    Public Day_8 As String = ""
    Public Day_9 As String = ""
    Public Day_10 As String = ""
    Public Day_11 As String = ""
    Public Day_12 As String = ""
    Public Day_13 As String = ""
    Public Day_14 As String = ""
    Public Day_15 As String = ""
    Public Day_16 As String = ""
    Public Day_17 As String = ""
    Public Day_18 As String = ""
    Public Day_19 As String = ""
    Public Day_20 As String = ""
    Public Day_21 As String = ""
    Public Day_22 As String = ""
    Public Day_23 As String = ""
    Public Day_24 As String = ""
    Public Day_25 As String = ""
    Public Day_26 As String = ""
    Public Day_27 As String = ""
    Public Day_28 As String = ""
    Public Day_29 As String = ""
    Public Day_30 As String = ""
    Public Day_31 As String = ""
  



    Dim Page As Page
    Public Sub New(xPage As Page)
        Page = xPage
    End Sub

    Public Sub Open()


        Dim showTop As String = "  "
        Dim SetConfig As New CLB_Training.CLB_Function
        SetConfig.SQL_Connection = Connection.sqlcon  '"server=Nena;database=CyberHRM_TigerNew;uid=sa;pwd=tiger" 'การติดต่อกับฐานข้อมูล

        SetConfig.ShowLang = LangReport 'รับการแสดงภาษาของรายงาน
        'SetConfig.ID_Company = Sys.LoginWeb.CompanyID  'รับรหัสบริษัท

        '600713, Chat Default OrderBy
        If GroupOrderbyName <> "" Then GroupOrderbyName = GroupOrderbyName & " , "


        Select Case MenuReport
            '##################################################  รายงานข้อมูลดิบ '##################################################

            Case "Report1"

                Dim report As New CLB_Training.Report1
                report.ConfigReport = SetConfig

                'sqlstr = "      SELECT		 GUID_Train,tbPersonTrain.*,Count(*) as CountTrain,SUM(TotalHour) as SumTotalHour, '' as CompanyName,"
                'sqlstr &= "                TrainDay_N, TrainDay_Date, TrainDay_End, TrainDay_Time, TrainDay_EndTime, PaternRefName, TotalHour, TypeCourseName"
                'sqlstr &= "                FROM TNT_TrainPerson"
                'sqlstr &= "		LEFT JOIN ("
                'sqlstr &= "					SELECT PersonID as SubPersonID , ( InitialName + Fname{0} + ' ' + Lname{0} ) as SubTrainName,PersonCode,InitialName,PrositionName,departName"
                'sqlstr &= "                FROM PNT_Person"
                'sqlstr &= "					LEFT JOIN ("
                'sqlstr &= "								SELECT        InitialID as SubInitialID, Initial{0} as InitialName"
                'sqlstr &= "                             FROM PNM_Initial"
                'sqlstr &= "							  ) as tbInitial ON PNT_Person.InitialID = tbInitial.SubInitialID"
                'sqlstr &= "					LEFT JOIN ("
                'sqlstr &= "								SELECT       PositionID as SubPositionID,PositionName{0} as PrositionName"
                'sqlstr &= "                             FROM PNM_Position"
                'sqlstr &= "								) as tbPosition ON PNT_Person.PositionID = tbPosition.SubPositionID"
                'sqlstr &= "					LEFT JOIN ("
                'sqlstr &= "								SELECT Cmb2ID as SubCmb2ID,Cmb2Name{0} as departName"
                'sqlstr &= "                             FROM PNM_Cmb2"
                'sqlstr &= "							  ) tbdepart ON PNT_Person.Cmb2ID = tbdepart.SubCmb2ID"
                'sqlstr &= "					) as tbPersonTrain ON TNT_TrainPerson.PersonID = tbPersonTrain.SubPersonID"
                'sqlstr &= "		INNER JOIN ("
                'sqlstr &= "					SELECT GUID_Train as SubGuidTrain,TrainDay_N,TrainDay_Date,TrainDay_End,TrainDay_Time,TrainDay_EndTime,PaternRefName,TrainDay_TotalHour / 60 as TotalHour,TypeCourseName"
                'sqlstr &= "                 FROM TNT_TrainDay"
                'sqlstr &= "					LEFT JOIN ("
                'sqlstr &= "								SELECT GUID_Patern as SubGuidPatern,PaternRefName,TypeCourseName"
                'sqlstr &= "                             FROM TNT_Patern_Course"
                'sqlstr &= "								LEFT JOIN	("
                'sqlstr &= "												SELECT GUID_Ref as SubGuidRef,PaternRef_Name{0} as PaternRefName"
                'sqlstr &= "                                             FROM TNM_Patern_ReF"
                'sqlstr &= "											) as tbPaternRef ON TNT_Patern_Course.GUID_Ref = tbPaternRef.SubGuidRef"
                'sqlstr &= "								LEFT JOIN	("
                'sqlstr &= "												SELECT GUID_Type as SubGuidType,Type_CourseName{0} as TypeCourseName"
                'sqlstr &= "                                             FROM TNM_TypeCourse"
                'sqlstr &= "											) as tbCourse ON TNT_Patern_Course.GUID_Type = tbCourse.SubGuidType"
                'sqlstr &= "								) as tbPaternCourse ON TNT_TrainDay.GUID_Patern = tbPaternCourse.SubGuidPatern"
                'sqlstr &= "					) as tbTrainDay ON TNT_TrainPerson.GUID_Train = tbTrainDay.SubGuidTrain"
                'sqlstr &= "                WHERE Tmp_status = 0"
                'sqlstr &= "		GROUP BY GUID_Train,SubPersonID,SubTrainName,PersonCode,InitialName,PrositionName,departName, TrainDay_N,TrainDay_Date,TrainDay_End,TrainDay_Time,TrainDay_EndTime,PaternRefName,TotalHour,TypeCourseName"


                'sqlstr = "Select SCT_Machine.id_Machine As MachineID, SCT_Repair.id_Repair As RepairID, SCM_Product.productName As Product, SCT_Machine.serial As Serial, SCT_Machine.cause As Cause, "
                'sqlstr += " SCT_Repair.name_Repair AS NameAddRepair, SCT_Repair.company As Company, SCT_Repair.tel As Tel, SCT_Repair.email As Email, SCT_Repair.add_Repair As AddRepairFrom, "
                'sqlstr += " SCT_Repair.CreateBy AS CreatRepair, SCT_Repair.CreateDate As CreateRepairDate, SCM_Product.productImg As ProductPic, SCM_Status.status As RepairStatus, "
                'sqlstr += " SCM_Delivery.delivery AS Delivery, SCT_Repair.ticket AS Ticket "
                'sqlstr += " From SCT_Machine INNER Join SCT_Repair On SCT_Machine.id_Repair = SCT_Repair.id_Repair LEFT Join SCM_Product On SCT_Machine.id_product = SCM_Product.id_product "
                'sqlstr += " Left Join SCM_Status  ON SCT_Repair.id_status = SCM_Status.id_status LEFT JOIN SCM_Delivery ON SCT_Repair.id_delivery = SCM_Delivery.id_delivery "
                'sqlstr += " WHERE SCT_Repair.ticket = '" & WH & "' "

                sqlstr = "SELECT T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, SCM_Product.productImg, T_Person.t_ticket, T_Person.IsDelete "
                sqlstr += " From T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product "
                sqlstr += " WHERE T_Person.t_ticket = '" & WH & "' "

                sqlstr = String.Format(sqlstr, LangReport)
                report.DataSource.SelectCommand = sqlstr
                'report.GroupNameTree = GroupReport
                report.DataSource.CommandTimeout = 3000
                'report.GroupCm1_NewPageAfter = GroupCm1_NewPageAfter 'ขึ้น 2021/07/07 bigเพิ่มขึ้นหน้าใหม่
                Page.Session("PrintReport" & MenuReport) = report
                MenuReport = "Report1"



            Case "Report2"

                Dim report As New CLB_Training.Report2
                Dim GroupCm1_NewPageAfter As Boolean = True
                report.ConfigReport = SetConfig

                sqlstr = "SELECT T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, SCM_Product.productImg, T_Person.t_ticket, T_Person.IsDelete "
                sqlstr += " From T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product "
                sqlstr += " WHERE IsDelete != 0"
                sqlstr += " GROUP BY T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, SCM_Product.productImg, T_Person.t_ticket, T_Person.IsDelete "

                sqlstr = String.Format(sqlstr, LangReport)
                report.DataSource.SelectCommand = sqlstr
                'report.GroupNameTree = GroupReport
                report.DataSource.CommandTimeout = 3000
                'report.GroupCm1_NewPageAfter = GroupCm1_NewPageAfter 'ขึ้น 2021/07/07 bigเพิ่มขึ้นหน้าใหม่
                Page.Session("PrintReport" & MenuReport) = report
                MenuReport = "Report2"

        End Select
        ScriptManager.RegisterStartupScript(Page, Page.GetType, "error" & (New Random).Next(1000), "window.open('PrintReport.aspx?menuId=" & MenuReport & "');", True)

        'ScriptManager.RegisterStartupScript(Page, Page.GetType, "error" & (New Random).Next(1000), "window.open('PrintReport.aspx?menuId=" & MenuReport & "');", True)
    End Sub
    Sub OpenRpt1(Menureport As String)

    End Sub

End Class
