Imports System.Data
Imports System

Public Class ConnLoadTableMaster


    ''' <summary>
    ''' หาพนักงานตาม ID พนักงาน
    ''' </summary>
    ''' <param name="xPersonID">ID</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PNT_PersonByID(ByVal xPersonID%) As DataTable
        Dim sqlStr$ = Sys.LoginWeb.sqlPersonName_Only & ",Email " & Sys.LoginWeb.sqlForm & _
                " Left join PNT_PersonDetail with(nolock) on PNT_Person.PersonID = PNT_PersonDetail.personid " & _
                " where pnt_person.personid = '" & xPersonID & "' " & Sys.LoginWeb.Wh

        Using da As New Mydata(adoconn)
            Return da.GetDataTable(sqlStr, "checkperson_personid")
        End Using
    End Function

    Public Function PNM_EmpType(ByVal ds_Table As DataSet) As DataSet
        Dim da_Table As New Mydata(adoconn)
        Dim dt As New DataTable

        If Not ds_Table.Tables.Contains("PNM_EmpType") Then
            dt.TableName = "PNM_EmpType"
            dt.Columns.Add(New DataColumn("CK", GetType(Boolean)))
            dt.Columns.Add(New DataColumn("C_Name", GetType(String)))
            dt.Columns.Add(New DataColumn("Where", GetType(String)))
            ds_Table.Tables.Add(dt)
        End If


        'Try
        '    ds_Table.Tables("PNM_EmpType").Clear()
        '    Reset()
        'Catch ex As Exception
        'End Try



     


        sqlstr = String.Format("select  EmpTypeID, EmpTypeName{0}  as C_Name, 0 as CK  from PNM_EmpType", Sys.LoginWeb.Lang)


        da_Table.GetDataset(ds_Table, sqlstr, "PNM_EmpType")

        Return ds_Table
    End Function



    Public Function COM_Company() As DataTable
        Dim sqlStr$ = "SELECT ID_Company,Company_Code,ISNULL(Company_Code,'') + ' - ' + Company_NameT as 'Company_NameTcode', ISNULL(Company_Code,'') + ' - ' + Company_NameE as 'Company_NameEcode' ,Company_NameT,Company_NameE "

        If CheckDB.COM_Company_SortNo = True Then
            sqlStr &= ",sortno FROM COM_Company order by sortno,Company_Code "
        Else
            sqlStr &= " FROM COM_Company order by Company_Code "
        End If


        Using da As New Mydata(adoconn)
            Return da.GetDataTable(sqlStr)
        End Using

    End Function

 

    Function TAM_Approver(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim V() As String = {"1", "2", "3", "4", "5", "6", "A", "N", "P"}
        Dim M() As String

        Try
            'If Sys.LoginWeb.Lang = "T" Then
            '    Dim M1() As String = {"รอคนที่ 1 อนุมัติ", "รอคนที่ 2 อนุมัติ", "รอคนที่ 3 อนุมัติ",
            '                          "รอคนที่ 4 อนุมัติ", "รอคนที่ 5 อนุมัติ", "รอคนที่ 6 อนุมัติ",
            '                          "อนุมัติแล้ว", "ไม่อนุมัติ", "รอ ฝ่ายบุคคลอนุมัติ"}
            '    M = M1
            'Else
            '    Dim M1() As String = {Sys.TMsg.รอคนที่1อนุมัติ, Sys.TMsg.รอคนที่2อนุมัติ, Sys.TMsg.รอคนที่3อนุมัติ,
            '                          Sys.TMsg.รอคนที่4อนุมัติ, Sys.TMsg.รอคนที่5อนุมัติ, Sys.TMsg.รอคนที่6อนุมัติ,
            '                          Sys.TMsg.อนุมัติแล้ว, Sys.TMsg.ไม่อนุมัติ, Sys.TMsg.รอฝ่ายบุคคลอนุมัติ}
            '    M = M1
            'End If

            Dim M1() As String = {Sys.TMsg.รอคนที่1อนุมัติ, Sys.TMsg.รอคนที่2อนุมัติ, Sys.TMsg.รอคนที่3อนุมัติ,
                                     Sys.TMsg.รอคนที่4อนุมัติ, Sys.TMsg.รอคนที่5อนุมัติ, Sys.TMsg.รอคนที่6อนุมัติ,
                                     Sys.TMsg.อนุมัติแล้ว, Sys.TMsg.ไม่อนุมัติ, Sys.TMsg.รอฝ่ายบุคคลอนุมัติ}
            M = M1


            dt.TableName = "TAM_Approver"
            dt.Columns.Add(New DataColumn("ID", GetType(String)))
            dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
            ds_Table.Tables.Add(dt)

            Try
                ds_Table.Tables("TAM_Approver").Clear()
                Reset()
            Catch ex As Exception
            End Try

            For i = 0 To 8
                dr = ds_Table.Tables("TAM_Approver").NewRow()
                dr("ID") = V(i)
                dr("P_Name") = M(i)
                ds_Table.Tables("TAM_Approver").Rows.Add(dr)
            Next

            Return ds_Table
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function TAM_ConfigProgramTime() As DataTable
        Using da As New Mydata(adoconn)
            Return da.GetDataTable("select * from TAM_ConfigProgramTime with(nolock)", "TAM_ConfigProgramTime")
        End Using
    End Function

    Function TAM_SETUPCompany(ByVal xIdCompany%) As DataTable
        Dim sqlStr$ = "select TAM_SETUPCompany.*,COM_Company.company_namet,COM_Company.company_namee,COM_Company.company_code from TAM_SETUPCompany with(nolock) inner join com_company with(nolock) on TAM_SETUPCompany.ID_Company = com_company.ID_Company where TAM_SETUPCompany.id_company = " & xIdCompany
        Using da As New Mydata(adoconn)
            Return da.GetDataTable(sqlStr, "TAM_SETUPCompany")
        End Using
    End Function

    ''' <summary>
    ''' ใช้กับ Tam_groupreport
    ''' </summary>
    ''' <param name="C"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetLabelCmb(ByVal C As String) As String
        Dim result = ""
        Select Case C
            Case "1" : result = Sys.LoginWeb.lblCmb1
            Case "2" : result = Sys.LoginWeb.lblCmb2
            Case "3" : result = Sys.LoginWeb.lblCmb3
            Case "4" : result = Sys.LoginWeb.lblCmb4
            Case "5" : result = Sys.LoginWeb.lblCmb5
            Case "6" : result = Sys.LoginWeb.lblCmb6
            Case "7" : result = Sys.LoginWeb.lblPosition
        End Select
        Return result
    End Function

    ''' <summary>
    ''' นำค่าจัดกรุ๊ปจาก combo ที่เลือก มาสร้างเป็น sql เพื่อส่งไป crysreport
    ''' </summary>
    ''' <param name="xIDGroupReport"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetGroupFomular(ByVal xIDGroupReport As Integer) As String()
        Dim g1 = ""
        Dim g2 = ""
        Dim g3 = ""
        Dim sqlStr$ = "Select TAM_GroupReport.* From TAM_GroupReport Where id_groupreport=" & Val(xIDGroupReport)
        Dim dt As DataTable
        Using da As New Mydata(adoconn)
            dt = da.GetDataTable(sqlStr)
        End Using
        If dt.Rows.Count > 0 Then
            g1 = GetGroupFomulareport(dt.Rows(0)("Group1") & "")
            g2 = GetGroupFomulareport(dt.Rows(0)("Group2") & "")
            g3 = GetGroupFomulareport(dt.Rows(0)("Group3") & "")
        End If
        Return New String() {g1, g2, g3}
    End Function


    ''' <summary>
    ''' ใช้คู่กับ GetGroupFomular
    ''' </summary>
    ''' <param name="C"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetGroupFomulareport(ByVal C As String) As String
        Dim tmpS As String
        Dim result As String = ""
        Dim a = CStr(C).Split(",")

        For i = 0 To a.Length - 1
            If Sys.LoginWeb.Lang = "E" Then
                Select Case a(i)
                    Case "1" : tmpS = " {PNM_Cmb1.Cmb1Code} & ' : " & Sys.LoginWeb.lblCmb1 & " : ' & {PNM_Cmb1.Cmb1NameE}"
                    Case "2" : tmpS = " {PNM_Cmb2.Cmb2Code} & ' : " & Sys.LoginWeb.lblCmb2 & " : ' & {PNM_Cmb2.Cmb2NameE}"
                    Case "3" : tmpS = " {PNM_Cmb3.Cmb3Code} & ' : " & Sys.LoginWeb.lblCmb3 & " : ' & {PNM_Cmb3.Cmb3NameE}"
                    Case "4" : tmpS = " {PNM_Cmb4.Cmb4Code} & ' : " & Sys.LoginWeb.lblCmb4 & " : ' & {PNM_Cmb4.Cmb4NameE}"
                    Case "5" : tmpS = " {PNM_Cmb5.Cmb5Code} & ' : " & Sys.LoginWeb.lblCmb5 & " : ' & {PNM_Cmb5.Cmb5NameE}"
                    Case "6" : tmpS = " {PNM_Cmb6.Cmb6Code} & ' : " & Sys.LoginWeb.lblCmb6 & " : ' & {PNM_Cmb6.Cmb6NameE}"
                    Case "7" : tmpS = " ' : ' &  {PNT_Person.CompanyID} "
                    Case Else
                        tmpS = ""
                End Select
            Else
                Select Case a(i)
                    Case "1" : tmpS = " {PNM_Cmb1.Cmb1Code} & ' : " & Sys.LoginWeb.lblCmb1 & " : ' & {PNM_Cmb1.Cmb1NameT}"
                    Case "2" : tmpS = " {PNM_Cmb2.Cmb2Code} & ' : " & Sys.LoginWeb.lblCmb2 & " : ' & {PNM_Cmb2.Cmb2NameT}"
                    Case "3" : tmpS = " {PNM_Cmb3.Cmb3Code} & ' : " & Sys.LoginWeb.lblCmb3 & " : ' & {PNM_Cmb3.Cmb3NameT}"
                    Case "4" : tmpS = " {PNM_Cmb4.Cmb4Code} & ' : " & Sys.LoginWeb.lblCmb4 & " : ' & {PNM_Cmb4.Cmb4NameT}"
                    Case "5" : tmpS = " {PNM_Cmb5.Cmb5Code} & ' : " & Sys.LoginWeb.lblCmb5 & " : ' & {PNM_Cmb5.Cmb5NameT}"
                    Case "6" : tmpS = " {PNM_Cmb6.Cmb6Code} & ' : " & Sys.LoginWeb.lblCmb6 & " : ' & {PNM_Cmb6.Cmb6NameT}"
                    Case "7" : tmpS = " ' : ' &  {PNT_Person.CompanyID} "
                    Case Else
                        tmpS = ""
                End Select
            End If
            If result = "" Then
                result = tmpS
            Else
                result &= " & " & tmpS
            End If
        Next
        Return result
    End Function

    Public Function TAM_GroupReport() As DataTable
        Dim dt As DataTable
        Dim sqlStr$ = "Select TAM_GroupReport.* From TAM_GroupReport Where ID_Company=" & Val(Sys.LoginWeb.CompanyID)
        Using da As New Mydata(adoconn)
            dt = da.GetDataTable(sqlStr)
            dt.Columns.Add("P_Name", GetType(String))
        End Using

        Dim st(3) As String
        For Each dr In dt.Rows
            Dim a() = CStr(dr("Group1") & "" & "").Split(",")
            st(1) = ""
            For i = 0 To a.Length - 1
                If st(1) = "" Then
                    st(1) = GetLabelCmb(a(i))
                Else
                    st(1) = st(1) & " -> " & GetLabelCmb(a(i))
                End If
            Next
            If st(1) <> "" Then st(0) = "1. " & st(1)
            a = Split(dr("Group2") & "", ",")
            st(2) = ""
            For i = 0 To a.Length - 1
                If st(2) = "" Then
                    st(2) = GetLabelCmb(a(i))
                Else
                    st(2) = st(2) & " -> " & GetLabelCmb(a(i))
                End If
            Next
            If st(2) <> "" Then st(0) = st(0) & "   || 2. " & st(2)
            a = Split(dr("Group3") & "", ",")
            st(3) = ""
            For i = 0 To a.Length - 1
                If st(3) = "" Then
                    st(3) = GetLabelCmb(a(i))
                Else
                    st(3) = st(3) & " -> " & GetLabelCmb(a(i))
                End If
            Next
            If st(3) <> "" Then st(0) = st(0) & "   || 3. " & st(3)
            dr("P_Name") = st(0)
        Next
        Dim drn As DataRow = dt.NewRow
        drn("id_groupreport") = 0
        drn("P_Name") = "-"
        dt.Rows.InsertAt(drn, 0)
        Return dt
    End Function

    Function TAM_SeleClass(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim M1() As String = {"-", Sys.LoginWeb.lblCmb1, Sys.LoginWeb.lblCmb2, Sys.LoginWeb.lblCmb3, Sys.LoginWeb.lblCmb4, Sys.LoginWeb.lblCmb5, Sys.LoginWeb.lblCmb6, TMsg.ประเภทพนักงาน, TMsg.ระดับพนักงาน, TMsg.ตำแหน่ง}
        Dim M2() As String = {"", "SELECT  PNM_Cmb1.Cmb1ID as ID, PNM_Cmb1.Cmb1NameT AS NName FROM  PNM_Cmb1", "SELECT  PNM_Cmb2.Cmb2ID as ID, PNM_Cmb2.Cmb2NameT AS NName FROM  PNM_Cmb2", "SELECT  PNM_Cmb3.Cmb3ID as ID, PNM_Cmb3.Cmb3NameT AS NName FROM  PNM_Cmb3", "SELECT  PNM_Cmb4.Cmb4ID as ID, PNM_Cmb4.Cmb4NameT AS NName FROM  PNM_Cmb4", "SELECT  PNM_Cmb5.Cmb5ID as ID, PNM_Cmb5.Cmb5NameT AS NName FROM  PNM_Cmb5", "SELECT  PNM_Cmb6.Cmb6ID as ID, PNM_Cmb6.Cmb6NameT AS NName FROM  PNM_Cmb6", "SELECT     PNM_EmpType.EmpTypeID as ID,  PNM_EmpType.EmpTypeNameT as NName  FROM  PNM_EmpType", "SELECT  PNM_Level.LevelID as ID, PNM_Level.LevelT as NName  FROM  PNM_Level ", "SELECT    PNM_Position.PositionID as ID, PNM_Position.PositionNameT as NName  FROM  PNM_Position "}

        dt.TableName = "TAM_SeleClass"
        dt.Columns.Add(New DataColumn("ID", GetType(Integer)))
        dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
        dt.Columns.Add(New DataColumn("P_Value", GetType(String)))
        ds_Table.Tables.Add(dt)
        Try
            ds_Table.Tables("TAM_SeleClass").Clear()
            Reset()
        Catch ex As Exception
        End Try
        For i = 0 To 9
            dr = ds_Table.Tables("TAM_SeleClass").NewRow()
            dr("ID") = i
            dr("P_Name") = M1(i)
            dr("P_Value") = M2(i)
            ds_Table.Tables("TAM_SeleClass").Rows.Add(dr)
        Next
        Return ds_Table
    End Function

    Function TAM_SelectGroup(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable

        Dim M1() As String = {Sys.LoginWeb.lblCmb1, Sys.LoginWeb.lblCmb2, Sys.LoginWeb.lblCmb3, Sys.LoginWeb.lblCmb4, Sys.LoginWeb.lblCmb5, Sys.LoginWeb.lblCmb6}

        Try
            dt.TableName = "TAM_SelectGroup"
            dt.Columns.Add(New DataColumn("ID", GetType(Integer)))
            dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
            ds_Table.Tables.Add(dt)
        Catch ex As Exception
        End Try

        Try
            ds_Table.Tables("TAM_SelectGroup").Clear()
            Reset()
        Catch ex As Exception
        End Try

        For i = 1 To 6
            dr = ds_Table.Tables("TAM_SelectGroup").NewRow()
            dr("ID") = i
            dr("P_Name") = M1(i - 1)
            ds_Table.Tables("TAM_SelectGroup").Rows.Add(dr)
        Next
        Return ds_Table
    End Function

    Function TAM_Year(ByVal ds_Table As DataSet, ByVal ds_Navigation As DataSet) As DataSet
        Dim dv As New DataView
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim dtTmp As New DataTable

        Dim Year As Integer = DateTime.Now.Year
        If (Year > 2500) Then Year = Year - 543 'Fixed christ's year 

        Dim PYear As Integer = Year - 10
        Dim NYear As Integer = Year + 5


        dtTmp.TableName = "TAM_Year"
        dtTmp.Columns.Add(New DataColumn("ID", GetType(Integer)))
        dtTmp.Columns.Add(New DataColumn("Y_Name", GetType(String)))

        dt = dtTmp.Copy()
        ds_Table.Tables.Add(dtTmp)

        Try
            ds_Table.Tables("TAM_Year").Clear()
            Reset()
        Catch ex As Exception
        End Try

        For i = PYear To NYear
            dr = dt.NewRow()
            dr("ID") = i 'value เป็น Christ เสมอ
            If Sys.LoginWeb.Lang = "T" Then
                If (i < 2500) Then
                    dr("Y_Name") = i + 543
                Else
                    dr("Y_Name") = i
                End If
            Else
                dr("Y_Name") = i
            End If
            dt.Rows.Add(dr)
        Next

        'check item in set
        Try
            For Each rowNavigation As DataRow In ds_Navigation.Tables("Navigation").Rows
                Dim row As DataRow() = dt.Select("ID=" & rowNavigation("Pay_Year") & "")
                If (row.Length = 0) Then
                    dr = dt.NewRow()
                    dr("ID") = rowNavigation("Pay_Year")

                    dr("Y_Name") = DataHelper.GetYearDisplayText(rowNavigation("Pay_Year"), Sys.LoginWeb.Lang)
                    dt.Rows.Add(dr)
                End If
            Next
        Catch ex As Exception
        End Try


        're-order item in datatable
        dv = dt.DefaultView
        dv.Sort = "ID, Y_Name"
        ds_Table.Tables("TAM_Year").Merge(dv.ToTable())

        Return ds_Table
    End Function

    ''' <summary>
    ''' เก็บ label OT1-6
    ''' </summary>
    ''' <param name="xIdCompany"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function PR_ConfigCompany(ByVal xIdCompany%) As DataTable
        Dim sqlStr$ = "SELECT * FROM PR_ConfigCompany with(nolock) Where ID_Company=" & Val(xIdCompany)
        Using da As New Mydata(adoconn)
            Return da.GetDataTable(sqlStr, "PR_ConfigCompany")
        End Using
    End Function

    Function TAM_Month(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim M() As String
        If Sys.LoginWeb.Lang = "T" Then
            Dim M1() As String = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฏาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}
            M = M1
        Else
            Dim M1() As String = {Sys.TMsg.มกราคม, Sys.TMsg.กุมภาพันธ์, Sys.TMsg.มีนาคม, Sys.TMsg.เมษายน, Sys.TMsg.พฤษภาคม, Sys.TMsg.มิถุนายน, _
                                  Sys.TMsg.กรกฎาคม, Sys.TMsg.สิงหาคม, Sys.TMsg.กันยายน, Sys.TMsg.ตุลาคม, Sys.TMsg.พฤศจิกายน, Sys.TMsg.ธันวาคม}
            M = M1
        End If

        dt.TableName = "TAM_Month"
        dt.Columns.Add(New DataColumn("ID", GetType(Integer)))
        dt.Columns.Add(New DataColumn("M_Name", GetType(String)))
        ds_Table.Tables.Add(dt)
        Try
            ds_Table.Tables("TAM_Month").Clear()
            Reset()
        Catch ex As Exception
        End Try
        For i = 1 To 12
            dr = ds_Table.Tables("TAM_Month").NewRow()
            dr("ID") = i
            dr("M_Name") = M(i - 1)
            ds_Table.Tables("TAM_Month").Rows.Add(dr)
        Next
        Return ds_Table
    End Function

    Function TAM_Logic(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim M1() As String = {"หรือ", "และ"}
        Dim M2() As String = {"OR", "AND"}

        Try
            dt.TableName = "TAM_Logic"
            dt.Columns.Add(New DataColumn("P_ID", GetType(String)))
            dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
            ds_Table.Tables.Add(dt)
        Catch ex As Exception
        End Try

        Try
            ds_Table.Tables("TAM_Logic").Clear()
            Reset()
        Catch ex As Exception
        End Try

        For i = 1 To M1.Count
            dr = ds_Table.Tables("TAM_Logic").NewRow()
            dr("P_ID") = M2(i - 1)
            dr("P_Name") = IIf(Sys.LoginWeb.Lang = "T", M1(i - 1), M2(i - 1))
            ds_Table.Tables("TAM_Logic").Rows.Add(dr)
        Next

        Return ds_Table
    End Function

    Function TAM_LogicalOperater(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim M1() As String = {"เท่ากับ", "น้อยกว่า", "มากกว่า", "น้อยกว่าหรือเท่ากับ", "มากกว่าหรือเท่ากับ", "ไม่เท่ากับ"}
        Dim M2() As String = {"=", "<", ">", "<=", ">=", "<>"}

        Try
            dt.TableName = "TAM_LogicalOperater"
            dt.Columns.Add(New DataColumn("P_ID", GetType(String)))
            dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
            ds_Table.Tables.Add(dt)
        Catch ex As Exception
        End Try

        Try
            ds_Table.Tables("TAM_LogicalOperater").Clear()
            Reset()
        Catch ex As Exception
        End Try

        For i = 1 To M1.Count
            dr = ds_Table.Tables("TAM_LogicalOperater").NewRow()
            dr("P_ID") = M2(i - 1)
            dr("P_Name") = IIf(Sys.LoginWeb.Lang = "T", M1(i - 1), M2(i - 1))
            ds_Table.Tables("TAM_LogicalOperater").Rows.Add(dr)
        Next

        Return ds_Table
    End Function

    Function CkWarringNew(ByRef ConfigMasterPerson_ID$, dtWarring As DataTable) As DataTable
        Dim SQL_LOG As String
        Dim dtWarringNew As New DataTable
        dtWarringNew.Columns.Add(New DataColumn("PersonID", GetType(String)))
        dtWarringNew.Columns.Add(New DataColumn("DataID", GetType(String)))
        '---- ฐานข้อมูล log  ------
        'SQL_LOG = "server=(Local);database=CyberHRM_Log;uid=sa;pwd=tiger"
        Dim cExecute As New connExecute(sqlconLog)

        CheckTable("LOG_WebNotify_" & Now.Year, "LOG_WebNotify")

        Dim dtLog As DataTable = cExecute.GetDataTable("select PersonID,DataID  from " & "LOG_WebNotify_" & Now.Year & " Where Web_Code = '" & ConfigMasterPerson_ID & "' and Create_By = '" & Sys.LoginWeb.UserID & "'")

        '== ถ้าใน dtWarring มีข้อมูลไม่เหมือนกับใน dtLog ให้แจ้งเตือน =='
        For Each dr As DataRow In dtWarring.Rows

            Dim ndr() As DataRow


            If Val(ConfigMasterPerson_ID) = 14 Then 'อนุมัติใบลา
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & " and DataID = " & dr("ID_LeaveForm") & " ")
            ElseIf Val(ConfigMasterPerson_ID) = 15 Then 'อนุมัติลงเวลา
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & " and DataID = " & dr("ID_TimeInOut") & " ")
            ElseIf Val(ConfigMasterPerson_ID) = 16 Then 'อนุมัติโอที
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & " and DataID = " & dr("ID_OTNormal") & " ")
            ElseIf Val(ConfigMasterPerson_ID) = 18 Then 'อนุมัติโอทีแบบพิเศษ
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & " and DataID = " & dr("ID_OTSpecial") & " ")
            ElseIf Val(ConfigMasterPerson_ID) = 19 Then 'อนุมัติเปลี่ยนกะงาน
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & " and DataID = " & dr("ID_ChangShift") & " ")
            ElseIf Val(ConfigMasterPerson_ID) = 20 Then 'อนุมัติเปลี่ยนวันหยุด
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & " and DataID = " & dr("ID_ChangHoliday") & " ")
            ElseIf Val(ConfigMasterPerson_ID) = 21 Then 'อนุมัติขอใช้/ไม่ใช้วันหยุดประจำปี
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & " and DataID = " & dr("ID_HolidayYear") & " ")
            Else
                ndr = dtLog.Select("PersonID = " & dr("PersonID") & "")
            End If

            '== ถ้า PersonID พนักงานใน dtWarring ไม่มีใน dtLog ให้เก็บลง dtWarringNew =='
            If ndr.Length = 0 Then
                Dim dr1 As DataRow = dtWarringNew.NewRow()
                dr1("PersonID") = dr("PersonID")
                If ConfigMasterPerson_ID$ = "14" Then dr1("DataID") = dr("ID_LeaveForm")
                If ConfigMasterPerson_ID$ = "15" Then dr1("DataID") = dr("ID_TimeInOut")
                If ConfigMasterPerson_ID$ = "16" Then dr1("DataID") = dr("ID_OTNormal")
                If ConfigMasterPerson_ID$ = "18" Then dr1("DataID") = dr("ID_OTSpecial")
                If ConfigMasterPerson_ID$ = "19" Then dr1("DataID") = dr("ID_ChangShift")
                If ConfigMasterPerson_ID$ = "20" Then dr1("DataID") = dr("ID_ChangHoliday")
                If ConfigMasterPerson_ID$ = "21" Then dr1("DataID") = dr("ID_HolidayYear")
                dtWarringNew.Rows.Add(dr1)
            End If
        Next

        Return dtWarringNew
    End Function

    Private Function whChkTrDel() As String
        Throw New NotImplementedException
    End Function

End Class
