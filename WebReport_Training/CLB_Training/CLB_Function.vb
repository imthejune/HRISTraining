Imports Microsoft.Win32
Imports System.IO
Imports System.Security.Cryptography
Imports System.Globalization

Public Class CLB_Function
    '------------------------------------
    ' สำหรับติดต่อฐานข้อมูล   
    Dim da_table As New Mydata
    Dim ds_table As New DataSet

    Public Sqlstr As String = ""
    '------------------------------------
    '---------------------------------------------------------------------
    Public ShowLang As String = "T"    ' เปลี่ยนภาษา
    Public ID_Company As Double = 1 ' สำหรับโหลดข้อมูลของบริษัท  
    Public SQL_Connection As String = LoadConnection() ' SQL Connection 
    'Public SQL_Connection As String = "server=TG11521\SQLEXPRESS;Initial Catalog=HRISTraining;User ID=sa;Password=tiger"  ' SQL Connection ' LoadConnection() 'ไวทำรายงาน
    'Public GroupNameTree As String = " "  'จัดกลุ่มรายงาน Tree ด้านซ้าย
    Public LogoCompany As System.Drawing.Image  ' ไว้สำหรับแสดง Logo บริษัท
    Public ReportName As String = ""  'ไว้แสดงชื่อ หัวรายงาน
    '---------------------------------------------------------------------
    Dim ProgramName As String = "TN" 'รหัสของ โปรแกรม สำหรับรายงาน
    Dim FormName As String ' สำหรับ รหัสของรายงาน ไว้สำหรับการเปลี่ยนภาษา

    Dim ciEN As New System.Globalization.CultureInfo("en-US")
    Public CustomCodeReport As String = ""
    Public GET_CASE As String = ""


    Public CHK_GROUP As String = ""    '0: no group , 1: with group


    Public GET_TEXT1 As String = ""
    Public GET_TEXT2 As String = ""
    Public GET_TEXT3 As String = ""
    Public GET_TEXT4 As String = ""
    Public GET_TEXT5 As String = ""
    Public GET_TEXT6 As String = ""
    Public GET_TEXT7 As String = ""
    Public GET_TEXT8 As String = ""
    Public GET_TEXT9 As String = ""
    Public GET_TEXT10 As String = ""
    Public GET_TEXT11 As String = ""
    Public GET_TEXT12 As String = ""
    Public GET_TEXT13 As String = ""
    Public GET_TEXT14 As String = ""
    Public GET_TEXT15 As String = ""
    Public GET_TEXT16 As String = ""
    Public GET_TEXT17 As String = ""
    Public GET_TEXT18 As String = ""
    Public GET_TEXT19 As String = ""
    Public GET_TEXT20 As String = ""
    Public GET_TEXT21 As String = ""
    Public GET_TEXT22 As String = ""
    Public GET_TEXT23 As String = ""
    Public GET_TEXT24 As String = ""
    Public GET_TEXT25 As String = ""
    Public GET_TEXT26 As String = ""
    Public GET_TEXT27 As String = ""
    Public GET_TEXT28 As String = ""
    Public GET_TEXT29 As String = ""
    Public GET_TEXT30 As String = ""
    Public GET_TEXT31 As String = ""
    Public GET_TEXT32 As String = ""
    Public GET_TEXT33 As String = ""
    Public GET_TEXT34 As String = ""
    Public GET_TEXT35 As String = ""
    Public GET_TEXT36 As String = ""
    Public GET_TEXT37 As String = ""
    Public GET_TEXT38 As String = ""
    Public GET_TEXT39 As String = ""
    Public GET_TEXT40 As String = ""
    Public GET_TEXT41 As String = ""
    Public GET_TEXT42 As String = ""
    Public GET_TEXT43 As String = ""
    Public GET_TEXT44 As String = ""
    Public GET_TEXT45 As String = ""
    Public GET_TEXT46 As String = ""
    Public GET_TEXT47 As String = ""
    Public GET_TEXT48 As String = ""
    Public GET_TEXT49 As String = ""
    Public GET_TEXT50 As String = ""
    Public GET_TEXT51 As String = ""
    Public GET_TEXT52 As String = ""
    Public GET_TEXT53 As String = ""
    Public GET_TEXT54 As String = ""
    Public GET_TEXT55 As String = ""
    Public GET_TEXT56 As String = ""
    Public GET_TEXT57 As String = ""
    Public GET_TEXT58 As String = ""
    Public GET_TEXT59 As String = ""
    Public GET_TEXT60 As String = ""

    Public GET_DAY1 As String = "1"
    Public GET_DAY2 As String = "2"
    Public GET_DAY3 As String = "3"
    Public GET_DAY4 As String = "4"
    Public GET_DAY5 As String = "5"
    Public GET_DAY6 As String = "6"
    Public GET_DAY7 As String = "7"
    Public GET_DAY8 As String = "8"
    Public GET_DAY9 As String = "9"
    Public GET_DAY10 As String = "10"
    Public GET_DAY11 As String = "11"
    Public GET_DAY12 As String = "12"
    Public GET_DAY13 As String = "13"
    Public GET_DAY14 As String = "14"
    Public GET_DAY15 As String = "15"
    Public GET_DAY16 As String = "16"
    Public GET_DAY17 As String = "17"
    Public GET_DAY18 As String = "18"
    Public GET_DAY19 As String = "19"
    Public GET_DAY20 As String = "20"
    Public GET_DAY21 As String = "21"
    Public GET_DAY22 As String = "22"
    Public GET_DAY23 As String = "23"
    Public GET_DAY24 As String = "24"
    Public GET_DAY25 As String = "25"
    Public GET_DAY26 As String = "26"
    Public GET_DAY27 As String = "27"
    Public GET_DAY28 As String = "28"
    Public GET_DAY29 As String = "29"
    Public GET_DAY30 As String = "30"
    Public GET_DAY31 As String = "31"

    Public GET_CHECK1 As Boolean
    Public GET_CHECK2 As Boolean
    Public GET_CHECK3 As Boolean
    Public GET_CHECK4 As Boolean
    Public GET_CHECK5 As Boolean
    Public GET_CHECK6 As Boolean
    Public GET_CHECK7 As Boolean
    Public GET_CHECK8 As Boolean
    Public GET_CHECK9 As Boolean
    Public GET_CHECK10 As Boolean
    Public GET_CHECK11 As Boolean
    Public GET_CHECK12 As Boolean
    Public GET_CHECK13 As Boolean
    Public GET_CHECK14 As Boolean
    Public GET_CHECK15 As Boolean
    Public GET_CHECK16 As Boolean
    Public GET_CHECK17 As Boolean
    Public GET_CHECK18 As Boolean
    Public GET_CHECK19 As Boolean
    Public GET_CHECK20 As Boolean

    '----- ต้องสร้างหน้าตั้งค่า
    Public Shared strFormat As String = "dd/MM/" 'อ่านจากการตั้งค่า
    Public Shared NowFormat As String = "EN"  'อ่านจากการตั้งค่า TH EN

    '----------------------------------------------------------------------------------------------------
    Public SQL_Person_Select2 As String = "Select  PNT_Person.PersonCode, PNT_Person.FnameT, PNT_Person.LnameT, PNT_Person.FnameE, PNT_Person.LnameE, " & _
                                         "          PNT_Person.PersonCode+'  '+PNM_Initial.InitialT+ PNT_Person.FnameT+'  '+ PNT_Person.LnameT as NameT, " & _
                                         "          PNT_Person.PersonCode+'  '+PNM_Initial.InitialE+ PNT_Person.FnameE+'  '+ PNT_Person.LnameE as NameE, " & _
                                         "          PNM_Initial.InitialCode, PNM_Initial.InitialT, PNM_Initial.InitialE, PNM_Cmb1.Cmb1Code, PNM_Cmb1.Cmb1NameT, PNM_Cmb1.Cmb1NameE, PNM_Cmb2.Cmb2Code, PNM_Cmb2.Cmb2NameT, PNM_Cmb2.Cmb2NameE, PNM_Cmb3.Cmb3Code, PNM_Cmb3.Cmb3NameT, PNM_Cmb3.Cmb3NameE, PNM_Cmb4.Cmb4Code, PNM_Cmb4.Cmb4NameT, PNM_Cmb4.Cmb4NameE, PNM_Cmb5.Cmb5Code, PNM_Cmb5.Cmb5NameT, PNM_Cmb5.Cmb5NameE, PNM_Cmb6.Cmb6Code, PNM_Cmb6.Cmb6NameT, PNM_Cmb6.Cmb6NameE, PNM_Position.PositionCode, PNM_Position.PositionNameT, PNM_Position.PositionNameE, PNM_EmpType.EmpTypeCode, PNM_EmpType.EmpTypeNameT, PNM_EmpType.EmpTypeNameE "
    Public SQL_Person_FROM2 As String = "FROM  PNT_Person INNER JOIN  PNM_Initial ON PNT_Person.InitialID = PNM_Initial.InitialID INNER JOIN  PNM_Cmb1 ON PNT_Person.Cmb1ID = PNM_Cmb1.Cmb1ID INNER JOIN PNM_Cmb2 ON PNT_Person.Cmb2ID = PNM_Cmb2.Cmb2ID INNER JOIN PNM_Cmb3 ON PNT_Person.Cmb3ID = PNM_Cmb3.Cmb3ID INNER JOIN  PNM_Cmb4 ON PNT_Person.Cmb4ID = PNM_Cmb4.Cmb4ID INNER JOIN PNM_Cmb5 ON PNT_Person.Cmb5ID = PNM_Cmb5.Cmb5ID INNER JOIN PNM_Cmb6 ON PNT_Person.cmb6ID = PNM_Cmb6.cmb6ID INNER JOIN PNM_Position ON PNT_Person.PositionID = PNM_Position.PositionID INNER JOIN  PNM_EmpType ON PNT_Person.EmpTypeID = PNM_EmpType.EmpTypeID "


    Public SQL_Person_Select As String = " Select PNT_Person.PersonID, PNT_Person.PersonCode, PNT_Person.PersonCardID," & _
                                     " PNT_Person.FnameT, PNT_Person.LnameT, PNT_Person.FnameE,   PNT_Person.LnameE, PNT_Person.CompanyID , " & _
                                     " PNT_Person.PersonCode+'  '+PNM_Initial.InitialT+ PNT_Person.FnameT+'  '+ PNT_Person.LnameT as NameT, " & _
                                     " PNT_Person.PersonCode+'  '+PNM_Initial.InitialE+ PNT_Person.FnameE+'  '+ PNT_Person.LnameE as NameE, " & _
                                     " PNM_Initial.InitialCode, PNM_Initial.InitialT, PNM_Initial.InitialE, PNM_Initial.InitialO, " & _
                                     " PNM_Cmb1.Cmb1Code, PNM_Cmb1.Cmb1NameT, PNM_Cmb1.Cmb1NameE, PNM_Cmb1.Cmb1NameO, " & _
                                     " PNM_Cmb2.Cmb2Code, PNM_Cmb2.Cmb2NameT, PNM_Cmb2.Cmb2NameE, PNM_Cmb2.Cmb2NameO, " & _
                                     " PNM_Cmb3.Cmb3Code, PNM_Cmb3.Cmb3NameT, PNM_Cmb3.Cmb3NameE, PNM_Cmb3.Cmb3NameO, " & _
                                     " PNM_Cmb4.Cmb4Code, PNM_Cmb4.Cmb4NameT, PNM_Cmb4.Cmb4NameE, PNM_Cmb4.Cmb4NameO, " & _
                                     " PNM_Cmb5.Cmb5Code, PNM_Cmb5.Cmb5NameT, PNM_Cmb5.Cmb5NameE, PNM_Cmb5.Cmb5NameO, " & _
                                     " PNM_Cmb6.Cmb6Code, PNM_Cmb6.Cmb6NameT, PNM_Cmb6.Cmb6NameE, PNM_Cmb6.Cmb6NameO, " & _
                                     " PNM_Cmb7.Cmb7Code, PNM_Cmb7.Cmb7NameT, PNM_Cmb7.Cmb7NameE, PNM_Cmb7.Cmb7NameO, " & _
                                     " PNM_Cmb8.Cmb8Code, PNM_Cmb8.Cmb8NameT, PNM_Cmb8.Cmb8NameE, PNM_Cmb8.Cmb8NameO, " & _
                                     " PNM_Cmb9.Cmb9Code, PNM_Cmb9.Cmb9NameT, PNM_Cmb9.Cmb9NameE, PNM_Cmb9.Cmb9NameO, " & _
                                     " PNM_Cmb10.Cmb10Code, PNM_Cmb10.Cmb10NameT, PNM_Cmb10.Cmb10NameE, PNM_Cmb10.Cmb10NameO, " & _
                                     " PNM_Position.PositionCode, PNM_Position.PositionNameT, PNM_Position.PositionNameE, PNM_Position.PositionNameO, " & _
                                     " PNM_EmpType.EmpTypeCode, PNM_EmpType.EmpTypeNameT, PNM_EmpType.EmpTypeNameE, PNM_EmpType.EmpTypeNameO, " & _
                                     " PNM_Sex.SexT, PNM_Sex.SexE, PNM_Sex.SexO," & _
                                     " PNM_Level.LevelT,PNM_Level.LevelE,PNM_Level.LevelO "

    Public SQL_Person_FROM As String = " FROM  PNT_Person LEFT JOIN  PNM_Initial ON PNT_Person.InitialID = PNM_Initial.InitialID " & _
                                       " LEFT JOIN PNM_Cmb1 ON PNT_Person.Cmb1ID = PNM_Cmb1.Cmb1ID " & _
                                       " LEFT JOIN PNM_Cmb2 ON PNT_Person.Cmb2ID = PNM_Cmb2.Cmb2ID " & _
                                       " LEFT JOIN PNM_Cmb3 ON PNT_Person.Cmb3ID = PNM_Cmb3.Cmb3ID " & _
                                       " LEFT JOIN PNM_Cmb4 ON PNT_Person.Cmb4ID = PNM_Cmb4.Cmb4ID " & _
                                       " LEFT JOIN PNM_Cmb5 ON PNT_Person.Cmb5ID = PNM_Cmb5.Cmb5ID " & _
                                       " LEFT JOIN PNM_Cmb6 ON PNT_Person.cmb6ID = PNM_Cmb6.cmb6ID " & _
                                       " LEFT JOIN PNM_Cmb7 ON PNT_Person.Cmb7ID = PNM_Cmb7.Cmb7ID " & _
                                       " LEFT JOIN PNM_Cmb8 ON PNT_Person.Cmb8ID = PNM_Cmb8.Cmb8ID " & _
                                       " LEFT JOIN PNM_Cmb9 ON PNT_Person.Cmb9ID = PNM_Cmb9.Cmb9ID " & _
                                       " LEFT JOIN PNM_Cmb10 ON PNT_Person.cmb10ID = PNM_Cmb10.cmb10ID " & _
                                       " LEFT JOIN PNM_Position ON PNT_Person.PositionID = PNM_Position.PositionID " & _
                                       " LEFT JOIN PNM_EmpType ON PNT_Person.EmpTypeID = PNM_EmpType.EmpTypeID " & _
                                       " LEFT JOIN PNM_Sex ON PNT_Person.SexID = PNM_Sex.SexID " & _
                                       " LEFT JOIN PNM_Amphur ON PNT_Person.CurrentAmphur = PNM_Amphur.AmphurID " & _
                                       " LEFT JOIN PNM_Province ON PNT_Person.CurrentProvince = PNM_Province.ProvID  " & _
                                       " LEFT JOIN PNM_Level ON PNT_Person.LevelID = PNM_Level.LevelID "

    '----------------------------------------------------------------------------------------------------

    Function LoadConnection() As String

        Dim serverName As String ' server Name
        Dim TPassword As String ' password
        Dim UserID As String ' password
        Dim Password1 As String ' password
        Dim Password2 As String ' password
        Dim rk As RegistryKey

        Try
            Dim pa$ = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") & ""
            If pa = "" Then
                pa$ = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") & ""
            End If

            If pa.IndexOf("86") > -1 Then
                rk = Registry.LocalMachine.OpenSubKey("Software\Tiger\HR")

            ElseIf pa.IndexOf("64") > -1 Then
                rk = Registry.LocalMachine.OpenSubKey("Software\Wow6432Node\Tiger\HR")
            End If

            serverName = rk.GetValue("ServerName")
            UserID = rk.GetValue("UserID")
            Password1 = rk.GetValue("Password")
            Password2 = rk.GetValue("Password2")

            Dim des As New MyCrypt
            If Password2 <> "" Then
                TPassword = Password2
            ElseIf Password1 <> "" Then
                TPassword = Password1
            Else
                TPassword = ""
            End If
            If TPassword.StartsWith("#") AndAlso TPassword.Length > 0 Then
                TPassword = TPassword.Substring(1)
                TPassword = des.Decrypt(TPassword)
            End If

            LoadConnection = "server=" & rk.GetValue("ServerName") & ";database=" & rk.GetValue("DatabaseNameHRiS") & ";uid=" & rk.GetValue("UserID") & ";pwd=" & TPassword
            ' LoadConnection = "server=192.168.8.142\sqlserver2017;database=dbTraining2017;uid=sa;pwd=tiger"
            ' LoadConnection = "server=TG11512\;Initial Catalog=dbTrainningHRIS;User ID=sa;Password=tiger"

        Catch ex As Exception

        End Try
    End Function

    Function LoadCompanyName() As String
        LoadCompanyName = ""
        Try
            Try
                ds_table.Tables("COM_Company").Clear()
            Catch ex As Exception
            End Try
            Sqlstr = "select Company_NameT,Company_NameE ,Logo_Pic  from COM_Company Where ID_Company = " & ID_Company
            da_table.Tmpsqlcon = SQL_Connection
            da_table.GetDataset(ds_table, Sqlstr, "COM_Company")

            If ds_table.Tables("COM_Company").Rows.Count > 0 Then
                If ShowLang = "T" Then LoadCompanyName = ds_table.Tables("COM_Company").Rows(0)("Company_NameT") & ""
                If ShowLang = "E" Then LoadCompanyName = ds_table.Tables("COM_Company").Rows(0)("Company_NameE") & ""
                If IsDBNull(ds_table.Tables("COM_Company").Rows(0)("Logo_Pic")) = False Then
                    Dim b() As Byte
                    Try
                        b = ds_table.Tables("COM_Company").Rows(0)("Logo_Pic")
                    Catch ex As Exception
                    End Try
                    Dim ms As New IO.MemoryStream(b)
                    LogoCompany = System.Drawing.Image.FromStream(ms)
                End If
            End If
        Catch ex As Exception
        End Try

    End Function


    Function GET_DatePrint() As String
        GET_DatePrint = Date.Now.ToString("dd/MMM/yyyy HH:mm:ss", ciEN)  'แปลงวันที่สำหรับออกท้ายกระดาษ
    End Function

    Function GET_ISO(Report_Code As String) As String
        ' สำหรับ การหาชื่อรายงาน จากการตั้งค่า
        ' การหาเลข ISO 

        GET_ISO = ""
        Try
            Try
                ds_table.Tables("ADM_Report").Clear()
            Catch ex As Exception
            End Try
            Sqlstr = "select *  from ADM_Report Where Report_Prog ='" & ProgramName & "' and Report_Code='" & Report_Code & "'"
            da_table.Tmpsqlcon = SQL_Connection
            da_table.GetDataset(ds_table, Sqlstr, "ADM_Report")

            If ds_table.Tables("ADM_Report").Rows.Count > 0 Then
                GET_ISO = ds_table.Tables("ADM_Report").Rows(0)("ISOCode") & ""
                If ShowLang = "T" Then ReportName = ds_table.Tables("ADM_Report").Rows(0)("Report_NameT") & ""
                If ShowLang = "E" Then ReportName = ds_table.Tables("0000000000000000000000000000000000000000000000000").Rows(0)("Report_NameE") & ""
                If ShowLang = "O" Then ReportName = ds_table.Tables("ADM_Report").Rows(0)("Report_NameO") & ""
            End If
        Catch ex As Exception
        End Try

        'โหลดข้อมูลสำหรับการเปลี่ยนแปลงภาษา
        LoadLang(Report_Code)
        FormName = Report_Code

    End Function

    '***********************************************************************************************************************************************************
    '***  สำหรับเปลี่ยน ภาษา    
    '***********************************************************************************************************************************************************
    Public Sub LoadLang(ReportName As String)
        If ShowLang <> "T" Or ShowLang = "" Then
            Try
                ds_table.Tables("PNM_ChangeLanguage").Clear()
            Catch ex As Exception
            End Try
            Sqlstr = "select * from PNM_ChangeLanguage where SystemName = '" & ProgramName & "' and FormName = '" & ReportName & "' "
            da_table.Tmpsqlcon = SQL_Connection
            da_table.GetDataset(ds_table, Sqlstr, "PNM_ChangeLanguage")
        End If
    End Sub

    Public Function Label_Text(ByVal LText As Telerik.Reporting.TextBox) As String
        Label_Text = ""
        Dim dv As New DataView(ds_table.Tables("PNM_ChangeLanguage"))
        dv.RowFilter = "LabelName='" & LText.Name & "'"
        If dv.Count > 0 Then
            Try
                If ShowLang = "T" Then Label_Text = dv(0)("NameT") & ""
                If ShowLang = "E" Then Label_Text = dv(0)("NameE") & ""
                If ShowLang = "O" Then Label_Text = dv(0)("NameO") & ""
            Catch ex As Exception
            End Try
        Else
            ''''+
            '--- เก็บลงฐานข้อมูล กรณีที่ยังไม่มี  +++++ 
            Insert(LText.Value, "E" & LText.Value, LText.Name)
        End If
    End Function

    Public Sub ChangNamePerson(ByVal LText As Telerik.Reporting.TextBox)
        Try
            If LText.Name = "TXT_Initial" Then LText.Value = "=Fields.InitialE"
            If LText.Name = "Txt_Name" Then LText.Value = "=Fields.FnameE"
            If LText.Name = "TxT_SurName" Then LText.Value = "=Fields.LnameE"
            If LText.Name = "txt_InitialName" Then LText.Value = "=Fields.InitialE + ' ' +Fields.FnameE"
            'If LText.Name = "txt_NameMate" Then LText.Value = "=Fields.InitialT_Mate+ Fields.MateFname+' '+ Fields.MateLname"

            If LText.Name = "txt_PositionName" Then LText.Value = "= Fields.PositionNameE"

            '========Time
            If LText.Name = "txt_CodeName" Then LText.Value = "= Fields.PersonCode+' ' +Fields.InitialE + Fields.FnameE+'  '+ Fields.LnameE"
            If LText.Name = "txt_NameSur" Then LText.Value = "= Fields.InitialE + Fields.FnameE+'  '+ Fields.LnameE"
            If LText.Name = "txt_FullName" Then LText.Value = "= Fields.FnameE+'  '+ Fields.LnameE"
            If LText.Name = "txt_Cmb2Name" Then LText.Value = "= Fields.Cmb2NameE"
            If LText.Name = "txt_Cmb1Name" Then LText.Value = "= Fields.Cmb1NameE"

            If LText.Name = "txt_Leave_Name" Then LText.Value = "= Fields.Leave_NameE"
            If LText.Name = "txt_TypeLeave" Then LText.Value = "= Fields.Leave_NameE"
            If LText.Name = "txt_CKK_ShiftType" Then LText.Value = "= Fields.CKK_ShiftTypeE"



            ''=======29-25-2015 ใหม่เพิ่มเช็คภาษา
            'If LText.Name = "txt_Sex" Then LText.Value = "=Fields.SexE"
            'If LText.Name = "txt_Cmb1Name" Then LText.Value = "=Fields.Cmb1NameE"
            'If LText.Name = "txt_Cmb2Name" Then LText.Value = "=Fields.Cmb2NameE"
            'If LText.Name = "txt_Cmb3Name" Then LText.Value = "=Fields.Cmb3NameE"
            'If LText.Name = "txt_Cmb4Name" Then LText.Value = "=Fields.Cmb4NameE"
            'If LText.Name = "txt_Cmb5Name" Then LText.Value = "=Fields.Cmb5NameE"
            'If LText.Name = "txt_Cmb6Name" Then LText.Value = "=Fields.Cmb6NameE"
            'If LText.Name = "txt_HospitalName" Then LText.Value = "=Fields.HospitalNameE"
            'If LText.Name = "txt_EmpTypeName" Then LText.Value = "=Fields.EmpTypeNameE"
            'If LText.Name = "txt_Acctype" Then LText.Value = "=Fields.AcctypeE"
            'If LText.Name = "txt_Part" Then LText.Value = "=Fields.PartE"
            'If LText.Name = "txt_PositionName" Then LText.Value = "=Fields.PositionNameE"
            'If LText.Name = "txt_BehaveName" Then LText.Value = "=Fields.BehaveNameE"
            'If LText.Name = "txt_BehaveDetail" Then LText.Value = "=Fields.BehaveDetailE"
            'If LText.Name = "txt_BehaveCategoryName" Then LText.Value = "=Fields.BehaveCategoryNameE"
            'If LText.Name = "txt_BehaveNoteName" Then LText.Value = "=Fields.BehaveNoteNameE"
            'If LText.Name = "txt_BehaveTitleName" Then LText.Value = "=Fields.BehaveTitleNameE"
            'If LText.Name = "txt_BlackListSubjectName" Then LText.Value = "=Fields.BlackListSubjectNameE"
            'If LText.Name = "txt_CerType" Then LText.Value = "=Fields.CerTypeE"
            ''If LText.Name = "txt_ContractT" Then LText.Value = "=Fields.ContractE"
            'If LText.Name = "txt_Contract" Then LText.Value = "=Fields.ContractE"
            'If LText.Name = "txt_CrimeType" Then LText.Value = "=Fields.CrimeTypeE"
            'If LText.Name = "txt_CrippleTypeName" Then LText.Value = "=Fields.CrippleTypeNameE"
            'If LText.Name = "txt_Degree" Then LText.Value = "=Fields.DegreeE"
            'If LText.Name = "txt_Major" Then LText.Value = "=Fields.MajorE"
            'If LText.Name = "txt_NationalityName" Then LText.Value = "=Fields.NationalityNameE"
            'If LText.Name = "txt_InstituteName" Then LText.Value = "=Fields.InstituteNameE"

            'If LText.Name = "txt_Occupation" Then LText.Value = "=Fields.OccupationE"
            'If LText.Name = "txt_Occupation_Mother" Then LText.Value = "=Fields.OccupationE_Mother"
            'If LText.Name = "txt_Occupation_Father" Then LText.Value = "=Fields.OccupationE_Father"
            'If LText.Name = "txt_Occupation_Guarantor" Then LText.Value = "=Fields.OccupationE_Guarantor"
            'If LText.Name = "txt_OccupationT_Mate" Then LText.Value = "= Fields.OccupationE_Mate"



            'If LText.Name = "txt_PositionName_Emergency" Then LText.Value = "=Fields.PositionNameE_EmergencyPerson"
            'If LText.Name = "txt_PositionName_Guarantor" Then LText.Value = "=Fields.PositionNameE_Guarantor"


            'If LText.Name = "txt_Marital" Then LText.Value = "=Fields.MaritalE"
            'If LText.Name = "txt_WelfareType" Then LText.Value = "=Fields.WelfareTypeE"
            'If LText.Name = "txt_HealthResult" Then LText.Value = "=Fields.HealthResultE"
            'If LText.Name = "txt_HealthType" Then LText.Value = "=Fields.HealthTypeE"
            'If LText.Name = "txt_Memo" Then LText.Value = "=Fields.MemoE"
            'If LText.Name = "txt_Cmb1Name" Then LText.Value = "=Fields.Cmb1NameE"
            'If LText.Name = "txt_Cmb2Name" Then LText.Value = "=Fields.Cmb2NameE"
            'If LText.Name = "txt_Level" Then LText.Value = "=Fields.LevelE"
            'If LText.Name = "txt_EmpTypeName" Then LText.Value = "=Fields.EmpTypeNameE"
            'If LText.Name = "txt_NationalityName" Then LText.Value = "=Fields.NationalityNameE"
            'If LText.Name = "txt_District" Then LText.Value = "=Fields.DistrictE"
            'If LText.Name = "txt_Amphur" Then LText.Value = "=Fields.AmphurE"
            'If LText.Name = "txt_ProveName" Then LText.Value = "=Fields.ProveNameE"
            'If LText.Name = "txt_SkillSpecName" Then LText.Value = "=Fields.SkiillSpecNameE"
            'If LText.Name = "txt_SkillComName" Then LText.Value = "=Fields.SkillComNameE"
            'If LText.Name = "txt_LangName" Then LText.Value = "=Fields.LangNameE"
            'If LText.Name = "txt_Train" Then LText.Value = "=Fields.TrainE"
            'If LText.Name = "txt_WelfareType" Then LText.Value = "=Fields.WelfareTypeE"
            'If LText.Name = "txt_Company_Name" Then LText.Value = "=Fields.Company_NameE"
            'If LText.Name = "txt_Amphur" Then LText.Value = "=Fields.AmphurE"
            'If LText.Name = "txt_ProveName" Then LText.Value = "=Fields.ProveNameE"
            'If LText.Name = "txt_Acctype" Then LText.Value = "=Fields.AcctypeE"
            'If LText.Name = "txt_Resign" Then LText.Value = "=Fields.ResignE"
            'If LText.Name = "txt_MResign" Then LText.Value = "=Fields.MResignE"
            'If LText.Name = "txt_OldPositionName" Then LText.Value = "=Fields.OldPositionNameE"
            'If LText.Name = "txt_CitizenName" Then LText.Value = "=Fields.CitizenNameE"
            'If LText.Name = "txt_ReligionName" Then LText.Value = "=Fields.ReligionNameE"
            'If LText.Name = "txt_LangName" Then LText.Value = "=Fields.LangNameE"
            'If LText.Name = "txt_Speak" Then LText.Value = "=Fields.SpeakE"
            'If LText.Name = "txt_read" Then LText.Value = "=Fields.readE"
            'If LText.Name = "txt_Write" Then LText.Value = "=Fields.WriteE"


            'If LText.Name = "txt_CardAddress" Then LText.Value = "=Fields.CardAddress+'  Building  ' +Fields.CardBuilding+'  Soi   '+ Fields.CardSoi+'  Street '+ Fields.CardRoad+'  Sub District '+ Fields.CardDistrictE+'  District '+ Fields.CardAmpnurE+'  Province '+ Fields.CardProveNameE+'  Nationlity '+ Fields.CardNationlityNameE+' Postcode  '+ Fields.CardPostID+'  Tel '+ Fields.CardTel"
            'If LText.Name = "txt_CurrentAddress" Then LText.Value = "=Fields.CurrentAddress+'  Building  ' +Fields.CurrentBuilding+'  Soi   '+ Fields.CurrentSoi+'  Street '+ Fields.CurrentRoad+'  Sub District '+ Fields.CurrentDistrictE+'  District '+ Fields.CurrentAmphurE+'  Province '+ Fields.CurrentProveNameE+'  Nationlity '+ Fields.CurrentNationalityNameE+' Postcode  '+ Fields.CurrentPostID+'  Tel '+ Fields.CurrentTel"

            'If LText.Name = "txt_District" Then LText.Value = "=Fields.DistrictE"
            'If LText.Name = "txt_Amphur" Then LText.Value = "=Fields.AmphurE"
            'If LText.Name = "txt_ProveName" Then LText.Value = "=Fields.ProveNameE"
            'If LText.Name = "txt_Shirt_name" Then LText.Value = "=Fields.Shirt_nameE"
            'If LText.Name = "txt_Size_name" Then LText.Value = "=Fields.Size_nameE"
            'If LText.Name = "txt_Color_name" Then LText.Value = "=Fields.Color_nameE"
            'If LText.Name = "txt_SpeakSkillLevel" Then LText.Value = "=Fields.SpeakSkillLevelE"
            'If LText.Name = "txt_ReadSkillLevel" Then LText.Value = "= Fields.ReadSkillLevelE"
            'If LText.Name = "txt_WriteSkillLevel" Then LText.Value = "= Fields.WriteSkillLevelE"






        Catch ex As Exception
        End Try
    End Sub

    Public Sub ChangName_TimeInOut(ByVal LText As Telerik.Reporting.TextBox)
        Try
            If LText.Name = "txt_DetailT" OrElse LText.Name = "txt_DetailT2" Then LText.Value = "=Fields.DetailE"

        Catch ex As Exception
        End Try
    End Sub


    Public Sub groupPerson_DocumentMapText(ByVal LDocumentMapText As Telerik.Reporting.Group)
        Select Case ShowLang
            Case "T" : LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.InitialT + Fields.FnameT +' ' + Fields.LnameT"
            Case "E" : LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.InitialE  + Fields.FnameE +' ' + Fields.LnameE"
        End Select
    End Sub

    ''==========Mai 2015-02-25 เพิ่ม Group สายรถ
    'Public Sub groupbBus_DocumentMapText(ByVal LDocumentMapText As Telerik.Reporting.Group)
    '    Select Case ShowLang
    '        Case "T" : LDocumentMapText.DocumentMapText = "= Fields.distance"
    '        Case "E" : LDocumentMapText.DocumentMapText = "= Fields.distance"
    '    End Select
    'End Sub
    ''==========
    ''==========Mai 2015-08-25 เพิ่ม Group สายรถ
    'Public Sub groupcodeCompany_DocumentMapText(ByVal LDocumentMapText As Telerik.Reporting.Group)
    '    Select Case ShowLang
    '        Case "T" : LDocumentMapText.DocumentMapText = "= Fields.groupcode"
    '        Case "E" : LDocumentMapText.DocumentMapText = "= Fields.groupcode"
    '    End Select
    'End Sub
    ''==========


    Public Sub detailPerson_DocumentMapText(ByVal LDocumentMapText As Telerik.Reporting.DetailSection)
        LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.Initial + Fields.Fname +' ' + Fields.Lname"
        'Select Case ShowLang  'ภาษาเปลี่ยนจากใน query แล้ว
        '    Case "T" : LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.InitialT + Fields.FnameT +' ' + Fields.LnameT"
        '    Case "E" : LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.InitialE  + Fields.FnameE +' ' + Fields.LnameE"
        'End Select
    End Sub


    Public Sub GroupHeaderSectionPerson_DocumentMapText(ByVal LDocumentMapText As Telerik.Reporting.GroupHeaderSection)
        LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.Initial + Fields.Fname +' ' + Fields.Lname"
        'Select Case ShowLang  'ภาษาเปลี่ยนจากใน query แล้ว
        '    Case "T" : LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.InitialT + Fields.FnameT +' ' + Fields.LnameT"
        '    Case "E" : LDocumentMapText.DocumentMapText = "= Fields.PersonCode + ' ' + Fields.InitialE  + Fields.FnameE +' ' + Fields.LnameE"
        'End Select
    End Sub

    '==========Mai 2015-10-01 เพิ่ม Group แม่แบบกะงาน              ************************รอแก้ไข   Public SQL_Person_Select
    Public Sub groupSName_DocumentMapText(ByVal LDocumentMapText As Telerik.Reporting.Group)
        Select Case ShowLang
            Case "T" : LDocumentMapText.DocumentMapText = "= Fields.SName"
            Case "E" : LDocumentMapText.DocumentMapText = "= Fields.SName"
        End Select
    End Sub
    '==========


    '==========Mai 2015-10-05 เพิ่ม Group สายรถ              ************************รอแก้ไข   Public SQL_Person_Select
    Public Sub groupBusTime_DocumentMapText(ByVal LDocumentMapText As Telerik.Reporting.DetailSection)
        Select Case ShowLang
            'Case "T" : LDocumentMapText.DocumentMapText = "= Fields.BusCode+'-'+ Fields.distance"
            'Case "E" : LDocumentMapText.DocumentMapText = "= Fields.BusCode+'-'+ Fields.distance"


            Case "T" : LDocumentMapText.DocumentMapText = "=Fields.BusStop+'-'+ Fields.StationT"
            Case "E" : LDocumentMapText.DocumentMapText = "=Fields.BusStop+'-'+ Fields.StationE"




        End Select

    End Sub
    '==========

    Sub Insert(NameT As String, NameE As String, LabelName As String)
        Dim NameO As String
        If NameE = "" Then
            NameE = "E" & NameT
        End If
        NameO = "O" & NameT
        Dim dt As DataTable = da_table.GetDataTable("SELECT * FROM PNM_ChangeLanguage  Where SystemName='" & ProgramName & "' and  LabelName='" & LabelName & "' and FormName ='" & FormName & "' ")
        If dt.Rows.Count > 0 Then
        Else
            Dim cExecute As New connExecute(SQL_Connection)
            cExecute.BeginTransaction()
            cExecute.sqlStr = " Insert into PNM_ChangeLanguage ( SystemName, FormName, NameT, NameE, NameO, LabelName) values(?,?,?,?,?,?)"
            cExecute.cmdConnection()
            cExecute.Transaction()
            cExecute.sqlParameter_Value("@p1", "NV", ProgramName)
            cExecute.sqlParameter_Value("@p2", "NV", FormName)
            cExecute.sqlParameter_Value("@p3", "NV", NameT)
            cExecute.sqlParameter_Value("@p4", "NV", NameE)
            cExecute.sqlParameter_Value("@p5", "NV", NameO)
            cExecute.sqlParameter_Value("@p6", "NV", LabelName)
            Try
                cExecute.ExecuteNonQuery()
                cExecute.Commit()
            Catch ex As Exception
                cExecute.Rollback()
            End Try
        End If

    End Sub

    Public Shared Function ConvertDateReport(d As Object) As String
        Dim yy As String = ""
        If d = Nothing Then
            Return "-"
        Else
            Dim d1 As Date = d
            If CLB_Function.NowFormat = "TH" Then
                yy = d1.Year + 543
            Else
                yy = d1.Year
            End If
            Return d1.ToString(CLB_Function.strFormat) & yy
        End If
        '   Return "aaaaaa"
    End Function

    '***********************************************************************************************************************************************************
    Public Shared Function dateFormat2(ByVal dateF, ByVal T) As String 'เปลี่ยน คศ เป็น พศ 
        ' Public Shared Function dateFormat2(dateF As Object, T As String) As String 'เปลี่ยน คศ เป็น พศ
        Try
            If IsNothing(dateF) Then
                Return ""
                Exit Function
            End If
            Dim ret As String = ""
            If T = "T" Then
                ret = CType(dateF, DateTime).ToString("dd/MM/yyyy", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("dd/MM/yyyy", New CultureInfo("en-US"))
            End If
            Return ret
        Catch ex As Exception
            Return ""
        End Try

    End Function


End Class


Public Class MyCrypt
    Dim EncKey As String = "tigersoft"
    Dim B1() As Byte = System.Text.Encoding.UTF8.GetBytes(EncKey.Substring(0, 8))
    Dim IV() As Byte = {&H12, &H43, &HCD, &HAA, &HBA, &H10, &H99, &HAC}
    Dim des As New DESCryptoServiceProvider

    Dim enc As ICryptoTransform
    Dim desc As ICryptoTransform

    Public Function Encrypt(ByVal strText As String) As String
        Dim BA() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)

        If enc Is Nothing Then
            enc = des.CreateEncryptor(B1, IV)
        End If
        Using M1 As New MemoryStream
            Dim cs As New CryptoStream(M1, enc, CryptoStreamMode.Write)
            cs.Write(BA, 0, BA.Length)
            cs.Close()
            Return Convert.ToBase64String(M1.ToArray())
        End Using

    End Function


    Public Function Decrypt(ByVal strText As String, Optional ByVal EncKey As String = "tigersoft") As String
        Dim BA() As Byte = Convert.FromBase64String(strText)
        If desc Is Nothing Then
            desc = des.CreateDecryptor(B1, IV)
        End If
        Using M1 As New MemoryStream
            Dim cs As New CryptoStream(M1, desc, CryptoStreamMode.Write)
            cs.Write(BA, 0, BA.Length)
            cs.Close()
            Return System.Text.Encoding.UTF8.GetString(M1.ToArray)
        End Using

    End Function


    Public Shared Function dateFormat(ByVal dateF, ByVal T) As String 'เปลี่ยน คศ เป็น พศ
        Try
            If IsNothing(dateF) Then
                Return ""
                Exit Function
            End If
            Dim ret As String = ""
            If T = "T" Then
                ret = CType(dateF, DateTime).ToString("dd-MMM-yyyy", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("dd-MMM-yyyy", New CultureInfo("en-US"))
            End If
            Return ret
        Catch ex As Exception
            Return ""
        End Try

    End Function



End Class

