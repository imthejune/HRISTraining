Option Compare Text
Option Infer On

Imports System.Globalization
Imports System.Data
Imports Microsoft.Win32
Imports System.Configuration.ConfigurationManager
Imports System.Diagnostics
Imports Telerik.Web.UI
Imports System.Threading
Imports System.Web.UI
Imports System.Web
Imports System
Imports System.Web.UI.WebControls
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Net

Public Enum UserType
    HR = 0
    User = 1 'เฉพาะตัวเอง
    Supervisor = 2 'หัวหน้าแผนก
    Admin = 3 'ผู้ดูแลระบบ
End Enum

Public Enum ShowPage
    None = 0
    ApproveLeave = 2
    ApproveTimeInTimeOut = 3
    ApproveOvertime = 4
    ApproveChangeShift = 5
End Enum

Public Enum VariableType
    varText = 0
    varNumeric = 1
    varDate = 2
    varTime = 3
    varDateTime = 4
    varBoolean = 5
End Enum

Public Enum DatabaseType
    Access = 0
    SQLServer = 1
    Sybase = 2
    ODBC = 3
End Enum

Public Enum E_TigerTypeCase
    Normal_1 = 1
End Enum

Public Enum TypeCaseProcess
    Normal_1 = 1
End Enum

Public Module Connection
    Public Const adoconn As DatabaseType = DatabaseType.SQLServer
    'Dim _sqlcon As String = "server=Nena;database=dbweb;uid=sa;pwd=tiger"
    Dim _sqlcon As String = ""
    Dim _sqlconLog As String = ""

    Public Property sqlcon As String
        Get
            ' Return "server=203.154.162.117;database=HRISDB;uid=sa;pwd=Tigersoft1998"
            'Return "server=192.168.8.134;database=HRISDB_Test;uid=sa;pwd=Tigersoft1998"
            ' Return "server=192.168.8.145\nena;database=dbwebTest;uid=sa;pwd=tiger"

            'Return "server=192.168.8.142\sqlserver2017;database=dbTraining2017;uid=sa;pwd=tiger"
            'Return _sqlcon 'เขียนโค๊ตเอง เปิดตัวนี้
            'Return "server=TG11511;database=Repair;uid=sa;pwd=tiger"
            Return "server=TG11511;database=repair;uid=sa;pwd=tiger"
            ' Return "server=Nena;database=dbweb;uid=sa;pwd=tiger" 'บิ้วโค๊ตให้พี่บัติ เปิดตัวนี้
            'Return "server=localhost;database=dbweb_Nena;uid=sa;pwd=tiger"
            ' Return "server=localhost;database=dbweb_Production;uid=sa;pwd=tiger"
        End Get

        Set(value As String)
            _sqlcon = value
        End Set
    End Property

    Public Property sqlconLog As String
        Get
            Return _sqlconLog 'เขียนโค๊ตเอง เปิดตัวนี้
            'Return "server=203.154.162.117;database=HRISLog;uid=sa;pwd=Tigersoft1998"
        End Get

        Set(value As String)
            _sqlconLog = value
        End Set
    End Property
    Public sycon As String '= "eng=ERP; uid=dba;pwd=sql;DBN=ERP;CommLinks=tcpip;Charset=CP874"
    Public sqlstr As String
    Public DatabaseName$ = ""
    Public DatabaseNameLog$ = ""
    Public UserID$ = ""
    Public pass$
    Public Password1$ = ""
    Public Password2$ = ""
    Public UrlPicture$ = "http://localhost:17221/2012/"

    Public UrlThumbnail$ = "http://61.90.204.93:8081/iclock/accounts/login/?next=/iclock/data/iclock/"

    Public UrlWebiClock$ = "http://61.90.204.93:8081/iclock/accounts/login/?next=/iclock/data/iclock/"

End Module

'ใช้กับ update database
Public Module CheckDB
    Public TAP_LeaveForm_Remark_Holiday As Boolean = False
    Public TAP_LeaveForm_CreateBy As Boolean = False
    Public TAM_Leave_Ckweb As Boolean = False
    Public TAM_SETUPCompany_LockOTinHour As Boolean = False
    Public TAM_SETUPCompany_LockOTinHour_Type As Boolean = False
    Public TAP_TmpSpecial_OT1_Family As Boolean = False 'Add on 58-07-06
    Public COM_Company_SortNo As Boolean = False
End Module

Public Module Sys
    '------------- ไว้สำหรับเก็บ ข้อมูล ตาราง การเปลี่ยนข้อความ
    Public Mem_LangforDB As New Generic.Dictionary(Of String, DataTable)
    Public Mem_TitleforDB As New Generic.Dictionary(Of String, DataTable)
    Public WebSetting As WebSetting = Nothing
    Public Const TempNodeName = "_TempNodeName"
    Public Const TimeOutPage$ = "~/Account/timeout.htm"
    Public Const ClosePage$ = "~/Account/closepage.htm"
    'Public LoginTime As Login_C 'ไปทำการ new ในหน้า default.aspx แทน เพราะ new ต้อง new หลัง load registy เรียก StartSystem
    Public TMsg As Msg 'ไปทำการ new ในหน้า default.aspx
    Public Lang$ = "T" 'ไปทำการ new ในหน้า default.aspx
    Public LoadTableMasterWeb As ConnLoadTableMaster 'ไปทำการ new ในหน้า default.aspx เรียก StartSystem
    Public Old_DaTA As String
    Public New_DaTA As String
    'Public LangI% = 1
    Public ev1 As New Generic.Dictionary(Of String, GetMasterData)
    ''' <summary>
    ''' ให้ Culture เป็น th-TH สถานเดียว
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly CIth As New CultureInfo("th-TH")

    ''' <summary>
    ''' ให้ Culture เป็น en-us สถานเดียว
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly CIen As New CultureInfo("en-US")

    '''' <summary>
    '''' จาก session จากตอนเลือกภาษา หน้า Login (default1)
    '''' </summary>
    '''' <value></value>
    '''' <returns></returns>
    '''' <remarks></remarks>
    'Public Property CIth() As CultureInfo
    '    Get
    '        Return CType(HttpContext.Current.Session("CIth"), CultureInfo)
    '    End Get
    '    Set(ByVal Value As CultureInfo)
    '        Dim Page As HttpContext = System.Web.HttpContext.Current
    '        Page.Session("CIth") = Value
    '        Page = Nothing
    '    End Set
    'End Property



    Dim _dateformat$ = "yyyy-MM-dd"
    Public Property DateFormat() As String
        Get
            Return _dateformat
        End Get
        Set(ByVal Value As String)
            _dateformat = Value
        End Set
    End Property

    Public Function DayofweekTostring(ByVal i As Byte) As String
        Dim result$ = ""
        If Sys.LoginWeb.Lang = "T" Then
            Select Case i
                Case 0 : result = "อา."
                Case 1 : result = "จ."
                Case 2 : result = "อ."
                Case 3 : result = "พ."
                Case 4 : result = "พฤ."
                Case 5 : result = "ศ."
                Case 6 : result = "ส."
            End Select
        Else
            Select Case i
                Case 0 : result = "Sun"
                Case 1 : result = "Mon"
                Case 2 : result = "Tue"
                Case 3 : result = "Wed"
                Case 4 : result = "Thu"
                Case 5 : result = "Fri"
                Case 6 : result = "Sat"
            End Select
        End If
        Return result

    End Function

    Public Function ConvertDate(ByVal d1 As Date, ByVal DateFmt As String) As String
        Return d1.ToString(DateFmt, CIen)
    End Function

    Public Function ConvertDate(ByVal d1 As Date) As String
        Return d1.ToString(DateFormat, CIen)
    End Function

    Function CurrentDate(ByVal d1 As Date) As String
        If Sys.LoginWeb.Lang = "T" Then
            Return d1.ToString("dd/MM/yyyy", CIth)
        Else
            Return d1.ToString("dd/MM/yyyy", CIen)
        End If
    End Function


    Public Function GetDisplayTreeNode(ByVal code As String, ByVal name As String, ByVal prefix As String) As String
        Dim str As String = String.Empty
        Select Case DataHelper.ToInt(Sys.LoginWeb.TreeNodeConfig)
            Case 0 'show name only
                str = name
            Case 1 'show code & name
                str = code & " - " & name
            Case 99 'show custom
                If String.IsNullOrEmpty(prefix) Then
                    str = name
                Else
                    str = prefix & " : " & name
                End If
        End Select
        Return str
    End Function

    Public Function GetDateFormat() As String
        Dim ds As New DataSet
        Dim da As New Mydata(adoconn)
        Dim result$
        Dim ds2 As New DataSet
        Dim cith As New System.Globalization.CultureInfo("en-US")
        Dim d1 As Date = New Date(Now.Year, 12, 30)

        Try
            sqlstr = "select getdate() where getdate() >= '" & d1.ToString("yyyy-MM-dd", cith) & "'"
            da.GetDataset(ds2, sqlstr)
            result = "yyyy-MMM-dd"
        Catch ex As Exception
            result = "dd-MM-yyyy"
        End Try
        Return result
    End Function
    '** ConvertDateFromString คือ เช็ค Formate Date ก่อน **'
    Public Function ConvertDateFromString(ByVal dd As String) As Date
        Dim d() As String = dd.Trim.Split("/")
        Return ConvertDateFromString(d(2), d(1), d(0))
    End Function

    Public Function ConvertDateFromString(ByVal yy As String, ByVal MM As String, ByVal dd As String) As Date
        If yy > 2500 Then
            yy = yy - 543
        End If

        Return New Date(yy, MM, dd)

    End Function

    Function ConvertDateTime(ByVal d1 As DateTime) As String
        Return d1.ToString(DateFormat & " HH:mm:00", CIen)
    End Function

    Public Function ConvertDateToDisplay(ByVal d As Date) As String
        '++++++++ พี่ตั้มเพิ่มให้ 25/8/2559 แก้เรื่องวันที่นอกกริดให้แสดงตามภาษาที่เลือก ถ้าไทยเป็น พ.ศ. ถ้าอื่นๆ แสดงเป็น ค.ศ.
        '++ ใช้กรณีดึงค่าวันที่มาใส่ใน Label
        Dim D1 As String = ""
        Dim CIEn As New System.Globalization.CultureInfo("en-US")
        Dim CITH As New System.Globalization.CultureInfo("th-TH")

        If Sys.LoginWeb.Lang = "T" Then
            D1 = CType(d, DateTime).ToString("dd/MM/yyyy", CITH)
        Else
            D1 = CType(d, DateTime).ToString("dd/MM/yyyy", CIEn)
        End If

        'If d.Year < 2500 Then
        '    D1 = Format(d, "dd") & "/" & Format(d, "MM") & "/" & d.Year + 543
        'Else
        '    D1 = Format(d, "dd") & "/" & Format(d, "MM") & "/" & d.Year
        'End If

        Return D1

    End Function
    Public Function ConvertDateToDisplay2(ByVal d As Date) As String
        '++++++++ พี่ตั้มเพิ่มให้ 25/8/2559 แก้เรื่องวันที่นอกกริดให้แสดงตามภาษาที่เลือก ถ้าไทยเป็น พ.ศ. ถ้าอื่นๆ แสดงเป็น ค.ศ.
        '++ ใช้กรณีดึงค่าวันที่มาใส่ใน Label
        Dim D1 As String = ""
        Dim CIEn As New System.Globalization.CultureInfo("en-US")
        Dim CITH As New System.Globalization.CultureInfo("th-TH")

        If Sys.LoginWeb.Lang = "T" Then
            D1 = CType(d, DateTime).ToString("yyyy-MM-dd", CIEn)
        Else
            D1 = CType(d, DateTime).ToString("yyyy-MM-dd", CITH)
        End If

        'If d.Year < 2500 Then
        '    D1 = Format(d, "dd") & "/" & Format(d, "MM") & "/" & d.Year + 543
        'Else
        '    D1 = Format(d, "dd") & "/" & Format(d, "MM") & "/" & d.Year
        'End If

        Return D1

    End Function

    ''' <summary>
    ''' แปลง 01:15 เป็น 75
    ''' </summary>
    ''' <param name="xHM"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TimeHM_ToInt(ByVal xHM$) As Integer
        If xHM = "" OrElse xHM = ":" Then
            Return 0
        End If
        Dim strAr() = xHM.Split(":")
        Return (CInt(strAr(0).Trim) * 60) + CInt(strAr(1).Trim)
    End Function

    ''' <summary>
    ''' แปลง 75 เป็น 01:15
    ''' </summary>
    ''' <param name="xInt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TimeInt_ToHM(ByVal xInt%) As String
        Return CInt(xInt \ 60).ToString("00") & ":" & CInt(xInt Mod 60).ToString("00")
    End Function

    'สำหรับทำ Pagging ของ Datagrid
    Public Sub CreatePager(ByVal xDataGrid As System.Web.UI.WebControls.DataGrid, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs, Optional ByVal xBgColor As Boolean = True)
        Dim lblTemp As UI.WebControls.Label
        Try
            For i As Integer = 0 To e.Item.Cells(0).Controls.Count - 1
                If TypeOf (e.Item.Cells(0).Controls(i)) Is Label Then
                    lblTemp = e.Item.Cells(0).Controls(i)
                    If xBgColor = True Then
                        lblTemp.CssClass = "curpage"
                    Else
                        lblTemp.CssClass = "setborder"
                    End If
                End If
            Next
        Catch ex As Exception
        Finally
            lblTemp = Nothing
        End Try
    End Sub

    'SetFocus ห้ามลบ
    Public Sub SetFocus(ByVal ctrl As System.Web.UI.Control)
        Dim s As String = "var obj=document.getElementById('" + ctrl.ID + "');if(obj!=null){try{obj.focus();}catch(ex){}};"
        ctrl.Page.ClientScript.RegisterStartupScript(GetType(String), "focus", s, True)
    End Sub

    Public Sub SetFocus(ByVal Page As Page, ByVal strClientID$)
        Dim s As String = "var obj=document.getElementById('" + strClientID + "');if(obj!=null){try{obj.focus();}catch(ex){}};"
        Page.ClientScript.RegisterStartupScript(GetType(String), "focus", s, True)
    End Sub

    Public Function UrlExists(ByVal url As String) As Boolean
        Try
            Dim request = TryCast(WebRequest.Create(url), HttpWebRequest)
            If request Is Nothing Then
                Return False
            End If
            request.Method = "HEAD"
            Using response = CType(request.GetResponse(), HttpWebResponse)
                Return response.StatusCode = HttpStatusCode.OK
            End Using
        Catch e1 As UriFormatException
            'Invalid Url
            Return False
        Catch e2 As WebException
            'Unable to access url
            Return False
        End Try
    End Function


    'Public Sub LoadCustomMenu(ByRef cMenu As RadMenu)

    '    cMenu.Items.Clear()
    '    Dim item1 As New RadMenuItem()
    '    item1.Text = "File"
    '    Dim item11 As New RadMenuItem()
    '    item11.Text = "Child 1"
    '    Dim item12 As New RadMenuItem()
    '    item12.Text = "Child 2"
    '    Dim item13 As New RadMenuItem()
    '    item13.Text = "Child 3"
    '    item13.NavigateUrl = "http://www.google.com"

    '    item1.Items.Add(item11)
    '    item1.Items.Add(item12)
    '    item1.Items.Add(item13)
    '    cMenu.Items.Add(item1)
    'End Sub

    'ชื่อเอกสาร ต่างๆ พวกใบรับรองแพทย์ ใช้ที่หน้าจอบันทึกใบลา

    Public Function TAM_SelectGroup(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim M1() As String = {Sys.LoginWeb.lblCmb1, Sys.LoginWeb.lblCmb2, Sys.LoginWeb.lblCmb3, Sys.LoginWeb.lblCmb4, Sys.LoginWeb.lblCmb5, Sys.LoginWeb.lblCmb6, Sys.LoginWeb.lblCmb7, Sys.LoginWeb.lblCmb8, Sys.LoginWeb.lblCmb9, Sys.LoginWeb.lblCmb10}

        dt.TableName = "TAM_SelectGroup"
        dt.Columns.Add(New DataColumn("ID", GetType(Integer)))
        dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
        ds_Table.Tables.Add(dt)
        Try
            ds_Table.Tables("TAM_SelectGroup").Clear()
        Catch ex As Exception
        End Try
        For i = 1 To 6
            dr = ds_Table.Tables("TAM_SelectGroup").NewRow()
            dr("ID") = i
            dr("P_Name") = i & "." & M1(i - 1)
            ds_Table.Tables("TAM_SelectGroup").Rows.Add(dr)
        Next
        Return ds_Table
    End Function

    '***************************************************************'


    Public Function TAM_LangReport() As DataTable
        Dim dt As New DataTable
        Try

            dt.Columns.Add("ID", GetType(String))
            dt.Columns.Add("L_Name", GetType(String))

            dt.Rows.Add("T", "ภาษาไทย")
            dt.Rows.Add("E", "ภาษาอังกฤษ")
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

    Function TAM_Case(ByVal ds_Table As DataSet) As DataSet
        Dim i As Integer
        Dim dr As DataRow
        Dim dt As New DataTable

        Dim M1() As String = {"=", ">", "<", "<>", "OR", "AND", "BETWEEN", "IN", "NOT IN", "(  )"}

        dt.TableName = "TAM_Case"
        dt.Columns.Add(New DataColumn("ID", GetType(Integer)))
        dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
        ds_Table.Tables.Add(dt)
        Try
            ds_Table.Tables("TAM_Case").Clear()
            Reset()
        Catch ex As Exception
        End Try
        For i = 1 To 10
            dr = ds_Table.Tables("TAM_Case").NewRow()
            dr("ID") = i
            dr("P_Name") = M1(i - 1)
            ds_Table.Tables("TAM_Case").Rows.Add(dr)
        Next
        Return ds_Table
    End Function

    '--- จัดกลุ่มรายงาน
    Public Function TAM_GroupReport(ByVal ds_Table As DataSet, ByVal da_Table As Object) As DataSet
        Dim dt As New DataTable
        Try
            dt.TableName = "TAM_GroupReport"
            dt.Columns.Add(New DataColumn("P_Name", GetType(String)))
            ds_Table.Tables.Add(dt)
        Catch ex As Exception
        End Try
        Try
            ds_Table.Tables("TAM_GroupReport").Clear()
            Reset()
        Catch ex As Exception
        End Try

        sqlstr = "Select TAM_GroupReport.* From TAM_GroupReport Where ID_Company=" & Sys.LoginWeb.CompanyID & " and SystemName = '" & Sys.LoginWeb.SystemName & "'"
        da_Table.GetDataset(ds_Table, sqlstr, "TAM_GroupReport")

        Dim dr As DataRow
        Dim i As Integer
        Dim st(3) As String
        For Each dr In ds_Table.Tables("TAM_GroupReport").Rows
            Dim a() As String
            a = Split(dr("Group1") & "", ",")
            st(1) = ""
            For i = 0 To a.Length - 1
                If st(1) = "" Then
                    st(1) = getStr(a(i))
                Else
                    st(1) = st(1) & " -> " & getStr(a(i))
                End If
            Next
            If st(1) <> "" Then st(0) = "1. " & st(1)
            dr("P_Name") = st(0)
        Next

        Return ds_Table
    End Function

    '----------- Report
    Public Function getStr(ByVal C As String) As String
        Select Case C
            Case "1" : getStr = Sys.LoginWeb.lblCmb1
            Case "2" : getStr = Sys.LoginWeb.lblCmb2
            Case "3" : getStr = Sys.LoginWeb.lblCmb3
            Case "4" : getStr = Sys.LoginWeb.lblCmb4
            Case "5" : getStr = Sys.LoginWeb.lblCmb5
            Case "6" : getStr = Sys.LoginWeb.lblCmb6
            Case "7" : getStr = Sys.LoginWeb.lblCmb7
            Case "8" : getStr = Sys.LoginWeb.lblCmb8
            Case "9" : getStr = Sys.LoginWeb.lblCmb9
            Case "10" : getStr = Sys.LoginWeb.lblCmb10
            Case "11" : getStr = Sys.LoginWeb.lblPosition
            Case "12" : getStr = Sys.LoginWeb.เรียงตามรหัสพนักงาน
        End Select
    End Function

    'Public RegexShiftCode As New Regex("(?:[^a-z0-9 ]|(?<=['])s)", RegexOptions.IgnoreCase AndAlso RegexOptions.CultureInvariant AndAlso RegexOptions.Compiled)
    Public Function RegexShiftCode(ByVal x$) As String
        'Return x.Replace("+", "").Replace("#", "").Replace("@", "").Replace("/", "").Replace("\", "").Replace("?", "").Replace("!", "")
        Return x.Replace("+", "").Replace("#", "").Replace("@", "").Replace("/", "").Replace("\", "").Replace("?", "").Replace("!", "").Replace("*", "").Replace("-", "")
    End Function

    Dim _TypeCaseProcess_ชุดเล็ก As E_TigerTypeCase
    Public Property TypeCaseProcess_ชุดเล็ก() As E_TigerTypeCase
        Get
            Return _TypeCaseProcess_ชุดเล็ก
        End Get
        Set(ByVal value As E_TigerTypeCase)
            _TypeCaseProcess_ชุดเล็ก = value
        End Set
    End Property

    Public ReadOnly Property TypeCaseProcess_Retail() As Boolean
        Get
            Return False
        End Get
    End Property


    ''' <summary>
    ''' พนักงานผู้ key
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetUserChange(ByVal xAction$, ByVal xLength%) As String
        Dim result = Sys.LoginWeb.PersonCode & "," & Date.Now.ToString("d/MMM/yy HH:mm", Sys.CIen) & "," & xAction & "," & Sys.LoginWeb.PersonNameT
        If result.Length > xLength Then
            result = result.Substring(0, xLength)
        End If
        Return result
    End Function

    Public Function GetCalendar(ByVal xstring As String) As Date
        Dim spllit() As String
        spllit = Split(xstring.Replace(" ", ""), "/")
        Try
            'If Sys.CIth.DateTimeFormat.Calendar.ToString = "System.Globalization.GregorianCalendar" AndAlso CInt(spllit(2)) > 2500 Then
            '    Return Nothing
            'ElseIf Sys.CIth.DateTimeFormat.Calendar.ToString = "System.Globalization.ThaiBuddhistCalendar" AndAlso CInt(spllit(2)) < 2500 Then 'กรณีไทย
            '    Return Nothing
            'End If
            If spllit(2).Length <> 4 Then
                Return Nothing
            End If
            If Val(spllit(2)) > 2500 Then
                spllit(2) = Val(spllit(2)) - 543
            End If
            'Return New Date(spllit(2), spllit(1), spllit(0), Sys.CIth.DateTimeFormat.Calendar)
            Return New Date(spllit(2), spllit(1), spllit(0))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub LoadRegisty()
        Dim serverName As String ' server Name
        'Dim databaseName As String ' Data base Name 
        'Dim userName As String ' User id
        Dim TPassword As String ' password
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
            DatabaseName = rk.GetValue("DatabaseNameHRiS")
            DatabaseNameLog = rk.GetValue("DatabaseNameLog")
            UserID = rk.GetValue("UserID")
            Password1 = rk.GetValue("Password")
            Password2 = rk.GetValue("Password2")

            Dim des As New MyCrypt
            If Password2 <> "" Then
                TPassword = Password2
            ElseIf Password1 <> "" Then
                TPassword = Password1
                '==== พี่เป๋งบังให้ ไม่ต้องสร้าง ===='
                'rk = Registry.LocalMachine.CreateSubKey("Software\Tiger\HR")
                'Dim t1$ = des.Encrypt(pass1)
                'rk.SetValue("Password2", "#" & t1)
            Else
                TPassword = ""
            End If
            If TPassword.StartsWith("#") AndAlso TPassword.Length > 0 Then
                TPassword = TPassword.Substring(1)
                TPassword = des.Decrypt(TPassword)
            End If

            'databaseName = rk.GetValue("DatabaseName")
            'UserID = rk.GetValue("UserID")
            pass = TPassword

            'rk.Close()

            'Dim Config As String = ConfigurationManager.ConnectionStrings("TrainingConnectionString").ConnectionString
            'Connection.sqlcon = Config
            Connection.sqlcon = "server=" & rk.GetValue("ServerName") & ";database=" & rk.GetValue("DatabaseNameHRiS") & ";uid=" & rk.GetValue("UserID") & ";pwd=" & TPassword
            Connection.sqlconLog = "server=" & rk.GetValue("ServerName") & ";database=" & rk.GetValue("DatabaseNameLog") & ";uid=" & rk.GetValue("UserID") & ";pwd=" & TPassword


            Sys.LoginWeb.ServerName = rk.GetValue("ServerName")
            Sys.LoginWeb.DatabaseName = rk.GetValue("DatabaseNameHRiS")
            Sys.LoginWeb.uid = rk.GetValue("UserID")
            Sys.LoginWeb.pwd = TPassword


            'Sys.LoginWeb.ServerName = "localhost"
            'Sys.LoginWeb.DatabaseName = "dbweb_Nena"
            'Sys.LoginWeb.uid = "sa"
            'Sys.LoginWeb.pwd = "tiger"


        Catch ex As Exception
            ' Throw New Exception("อ่าน registy ไม่ได้ เนื่องจาก " & ex.Message & " ModulClass line : 207 ", ex)
            'HttpContext.Current.Response.Redirect("~/From/ConfigDatabase.aspx")

            'Dim p As New Process()
            'p.StartInfo.FileName = HttpContext.Current.Server.MapPath("~/ConnectionDBTiger.exe")
            'p.Start()
        End Try
    End Sub

    Public Sub Insert(FormName As String, NameT As String, NameE As String, LabelName As String)
        Try
            Dim NameO As String
            If NameE = "" Then
                NameE = "E" & NameT
            End If
            NameO = "O" & NameT

            '600303,CHAT: ไม่รู้ทำไมของเดิมใช้ da เฉยๆ ซึ่งไม่เคย close  connection เลยจึงใช้ตัวใหม่นี้
            Dim da2 As New Mydata(adoconn)
            Dim dt As DataTable = da2.GetDataTable("SELECT * FROM PNM_ChangeLanguage  Where SystemName='TN' and  LabelName='" & LabelName & "' and FormName ='" & FormName & "' ")
            da2 = Nothing

            'Dim da As New Mydata(adoconn)
            'Dim dt As DataTable = da.GetDataTable("SELECT * FROM PNM_ChangeLanguage  Where SystemName='" & Sys.LoginWeb.SystemName & "' and LabelName='" & LabelName & "' and FormName ='" & FormName & "' ")
            If dt.Rows.Count > 0 Then

            Else
                Dim cExecute As New connExecute
                cExecute.sqlStr = " Insert into PNM_ChangeLanguage (SystemName, FormName, NameT, NameE, NameO, LabelName,UserChange) values(?,?,?,?,?,?,?)"
                cExecute.cmdConnection()
                cExecute.sqlParameter_Value("@p1", "NV", Sys.LoginWeb.SystemName)
                cExecute.sqlParameter_Value("@p2", "NV", FormName)
                cExecute.sqlParameter_Value("@p3", "NV", NameT)
                cExecute.sqlParameter_Value("@p4", "NV", NameE)
                cExecute.sqlParameter_Value("@p5", "NV", NameO)
                cExecute.sqlParameter_Value("@p6", "NV", LabelName)
                cExecute.sqlParameter_Value("@p7", "NV", Sys.LoginWeb.UserName)
                Try
                    cExecute.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Property LoginWeb() As User
        Get
            Return CType(HttpContext.Current.Session("SessionUser"), User)
        End Get
        Set(ByVal value As User)
            HttpContext.Current.Session("SessionUser") = value
        End Set
    End Property

    Public ReadOnly Property ApproveGroup() As Integer
        Get
            Dim Page As HttpContext = System.Web.HttpContext.Current
            Try
                Dim intResult As Byte
                If System.Convert.IsDBNull(CType(Page.Session("DrPerson"), DataRow)("ApproveOtGroup")) Then
                    intResult = 1 'ถ้าเป็น 0 จะ error
                Else
                    intResult = CType(Page.Session("DrPerson"), DataRow)("ApproveOtGroup")
                End If
                Return intResult
            Catch ex As Exception
                Throw ex
            End Try
        End Get
    End Property

    Private Toolbar As New SetToolBar
    Public ReadOnly Property SetToolBar() As SetToolBar
        Get
            Return Toolbar
        End Get
    End Property
    Public Sub ToolbarMenu(ByVal xRadToolBar As Object, ByVal Menu As String)
        Dim dtCkMeun As DataTable = HttpContext.Current.Session("dtCkMenuPerson")
        Dim ndr() As DataRow
        If dtCkMeun.Rows.Count > 0 Then
            ndr = dtCkMeun.Select(" Menu_Code = '" & Menu & "' ")
            If ndr.Length > 0 Then
                If xRadToolBar IsNot Nothing Then
                    If TypeOf (xRadToolBar) Is RadToolBar Then
                        '== ปุ่มเพิ่ม Toolbar =='
                        If (ndr(0)("ckAdd") & "") <> "" Then xRadToolBar.Items(0).Enabled = ndr(0)("ckAdd")
                        '== ปุ่มแก้ไข Toolbar =='
                        If (ndr(0)("ckEdit") & "") <> "" Then xRadToolBar.Items(1).Enabled = ndr(0)("ckEdit")
                        '== ปุ่มลบ Toolbar =='
                        If (ndr(0)("CkDel") & "") <> "" Then xRadToolBar.Items(2).Enabled = ndr(0)("CkDel")
                    End If
                End If
            End If
        End If
    End Sub

    Public Function ckReport(ByVal xReportViewer As Object, ByVal ReportName As String, ByVal ck As String) As Boolean
        ckReport = True
        Dim dtCkReport As DataTable = HttpContext.Current.Session("dtCkMenuReport")
        Dim ndr() As DataRow
        'If dtCkReport.Rows.Count > 0 Then
        ndr = dtCkReport.Select(" Report_Code='" & ReportName & "'")
        If ndr.Length > 0 Then
            If xReportViewer IsNot Nothing Then
                Select Case ck
                    Case "P"
                        xReportViewer.ShowPrintButton = ndr(0)("Print_Report")
                    Case "E"
                        xReportViewer.ShowExportGroup = ndr(0)("Export_Report")
                End Select
            End If
        End If
    End Function

    Public Function GenerateSearchJoinTable() As String
        Dim strJoin As String = ""
        Try
            Dim dtWhReport As DataTable = CType(HttpContext.Current.Session("WhReport"), DataTable) 'เก็บเงื่อนไขที่ค้นหา ที่แสดงใน grid 
            If Not IsNothing(dtWhReport) Then
                For Each dr As DataRow In dtWhReport.Rows
                    Select Case Val(dr("Col"))
                        Case 1 'รหัสพนักงาน PersonCode
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 'Cmb1 - 10
                            strJoin += "" ' มี่ Join อยู่แล้วใน sqlForm
                        Case 12 'ตำแหน่ง PNM_Position
                            strJoin += "" ' มี่ Join อยู่แล้วใน sqlForm
                        Case 13 '"ประเภทพนักงาน PNM_EmpType"
                            strJoin += " inner join PNM_EmpType on PNM_EmpType.EmpTypeID = PNT_Person.EmpTypeID "
                        Case 14 'อายุ
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 15 'อายุงาน
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 16 'เงินเดือน
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 17 'วันที่เริ่มงาน
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 18 'บัตรประชาชน
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 18 'บัตรประชาชน
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 18 'บัตรประชาชน
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                        Case 19 'Sex
                            strJoin += "" ' มี่ Join PNM_Sex อยู่แล้วใน sqlForm
                        Case 20 'ที่อยู่ปัจจุบัน อำเภอ
                            strJoin += " left join PNM_Amphur on PNM_Amphur.AmphurID = PNT_Person.CurrentAmphur "
                        Case 21 'ที่อยู่ปัจจุบัน จังหวัด
                            strJoin += " left join PNM_Province on PNM_Province.ProvID = PNT_Person.CurrentProvince "
                        Case 22 '"วุฒิการศึกษา
                            strJoin += " LEFT JOIN PNT_Education ON PNT_Person.PersonID = PNT_Education.PersonID  LEFT JOIN PNM_Degree ON PNT_Education.DegreeID = PNM_Degree.DegreeID "
                        Case 23 'ประเภทอายุงาน
                            strJoin += "" ' มี่ Join PNT_Person อยู่แล้วใน sqlForm
                    End Select
                Next
            End If


               

            Return strJoin
        Catch ex As Exception
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' ตรวจ TimeOut
    ''' </summary>
    ''' <param name="xPage"></param>
    ''' <remarks></remarks>
    Public Sub ChkTimeOut(ByVal xPage As Page)
        Try
           If xPage.Session("DrPerson") Is Nothing OrElse xPage.Session("SessionUser") Is Nothing Then
                'เช็คว่าเป็น MasterPage จากหน้าปกติ หรือ ป๊อปอัพ
                If IsNothing(xPage.MasterPageFile) Then
                    'Do Nothing 
                ElseIf xPage.MasterPageFile = "/Site.master" Then
                    If Sys.LoginWeb.HRISLogin = 1 Then
                        xPage.Response.Redirect(Sys.LoginWeb.URL_HRISLogin)
                    Else
                        xPage.Response.Redirect(Sys.TimeOutPage, True)
                    End If
                ElseIf xPage.MasterPageFile = "/Popup.master" Then
                    xPage.Response.Redirect(Sys.ClosePage, True)
                End If
            End If
        Catch ex As Exception
            xPage.Response.Redirect(Sys.TimeOutPage, True)
        End Try
    End Sub

    Public Function XMLParameter_Value(ByVal xmlname As String) As String
        Dim p1 As String = ""
        Select Case UCase(xmlname)
            Case " "
                p1 = "_x0020_"
            Case "!"
                p1 = "_x0021_"
            Case """"
                p1 = "_x0022_"
            Case "#"
                p1 = "_x0023_"
            Case "$"
                p1 = "_x0024_"
            Case "%"
                p1 = "_x0025_"
            Case "&"
                p1 = "_x0026_"
            Case "'"
                p1 = "_x0027_"
            Case "("
                p1 = "_x0028_"
            Case ")"
                p1 = "_x0029_"
            Case "*"
                p1 = "_x002A_"
            Case "+"
                p1 = "_x002B_"
            Case ","
                p1 = "_x002C_"
            Case "-"
                p1 = "_x002D_"
            Case "."
                p1 = "_x002E_"
            Case "/"
                p1 = "_x002F_"
            Case ":"
                p1 = "_x003A_"
            Case ";"
                p1 = "_x003B_"
            Case "<"
                p1 = "_x003C_"
            Case "="
                p1 = "_x003D_"
            Case ">"
                p1 = "_x003E_"
            Case "?"
                p1 = "_x003F_"
            Case "@"
                p1 = "_x0040_"
            Case "["
                p1 = "_x005B_"
            Case "\"
                p1 = "_x005C_"
            Case "]"
                p1 = "_x005D_"
            Case "^"
                p1 = "_x005E_"
            Case "_"
                p1 = "_x005F_"
            Case "`"
                p1 = "_x0060_"
            Case "{"
                p1 = "_x007B_"
            Case "|"
                p1 = "_x007C_"
            Case "}"
                p1 = "_x007D_"
            Case "~"
                p1 = "_x007E_"
            Case "‚"
                p1 = "_x0082_"
            Case "„"
                p1 = "_x0084_"
            Case "……"
                p1 = "_x0085_"
            Case "ˆ"
                p1 = "_x0088_"
            Case "‘"
                p1 = "_x0091_"
            Case "’"
                p1 = "_x0092_"
            Case Else
                p1 = xmlname
        End Select

        Return p1
        'cmdsql.Parameters.Add(p1)
    End Function

    Public Sub Getlbl(ByVal L As String)
        Dim da As New Mydata(DatabaseType.SQLServer)
        Dim dt As DataTable = da.GetDataTable("select * from ADM_tblLabel")
        If dt.Rows.Count > 0 Then
            Sys.LoginWeb.lblCmb1 = dt.Rows(0)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb2 = dt.Rows(1)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb3 = dt.Rows(2)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb4 = dt.Rows(3)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb5 = dt.Rows(4)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb6 = dt.Rows(5)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb7 = dt.Rows(6)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb8 = dt.Rows(7)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb9 = dt.Rows(8)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblCmb10 = dt.Rows(9)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblPosition = dt.Rows(10)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblLevel = dt.Rows(11)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblContract = dt.Rows(12)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblEmpType = dt.Rows(13)("tblLabel" & IIf(L = "T", "T", "E"))
            Sys.LoginWeb.lblTypeProcessSalary = dt.Rows(14)("tblLabel" & IIf(L = "T", "T", "E"))
        End If
    End Sub

    Public Function MessageBox(ByVal message As String) As String
        Return "<script type=""text/javascript"">alert('" & _
                    message.Replace("'", "").Replace(vbCrLf, "") & _
                "');</script>"
    End Function

    Public Function GetSkin() As DataTable
        Dim dtSkinTool As DataTable
        Dim da As New Mydata(DatabaseType.SQLServer)
        Dim draGrid(), draCombo(), draTreeView(), draTabStrip(), draToolBar(), draRadwindows(), draRadListBox(), draContextMenu(), draScheduler() As DataRow
        sqlstr = "Select * From ADM_SkinTool "
        dtSkinTool = da.GetDataTable(sqlstr)
        'Session("dtSkin") = dtSkinTool

        If Not IsNothing(dtSkinTool) AndAlso dtSkinTool.Rows.Count <> 0 Then
            draGrid = dtSkinTool.Select("SkinTool_Name = 'SkinGrid'")
            Sys.LoginWeb.SkinGrid = draGrid(0)("SkinTool_Config") & ""

            draCombo = dtSkinTool.Select("SkinTool_Name = 'SkinCombo'")
            Sys.LoginWeb.SkinCombo = draCombo(0)("SkinTool_Config") & ""

            draTreeView = dtSkinTool.Select("SkinTool_Name = 'SkinTreeView'")
            Sys.LoginWeb.SkinTreeView = draTreeView(0)("SkinTool_Config") & ""

            draTabStrip = dtSkinTool.Select("SkinTool_Name = 'SkinRadTabStrip'")
            Sys.LoginWeb.SkinRadTabStrip = draTabStrip(0)("SkinTool_Config") & ""

            draToolBar = dtSkinTool.Select("SkinTool_Name = 'SkinRadToolBar'")
            Sys.LoginWeb.SkinRadToolBar = draToolBar(0)("SkinTool_Config") & ""

            draRadwindows = dtSkinTool.Select("SkinTool_Name = 'SkinRadwindows'")
            Sys.LoginWeb.SkinRadwindows = draRadwindows(0)("SkinTool_Config") & ""

            draRadListBox = dtSkinTool.Select("SkinTool_Name = 'SkinRadListBox'")
            Sys.LoginWeb.SkinRadListBox = draRadListBox(0)("SkinTool_Config") & ""

            draContextMenu = dtSkinTool.Select("SkinTool_Name = 'SkinRadContextMenu'")
            Sys.LoginWeb.SkinRadContextMenu = draContextMenu(0)("SkinTool_Config") & ""

            draScheduler = dtSkinTool.Select("SkinTool_Name = 'SkinRadScheduler'")
            Sys.LoginWeb.SkinRadScheduler = draContextMenu(0)("SkinTool_Config") & ""

        End If
        Return dtSkinTool
    End Function


    ''' <summary>
    ''' เป็น checkbox ที่กำหนดว่า ตอนนับวันลา ให้หักวันหยุดด้วยหรือไม่เช่น ลาศุกร์-จันทร์
    ''' ปกติได้ 4 แต่ถ้าติ๊กถูกจะได้ 2 ตั้งค่าจากระบบ Time หน้าจอตั้งค่าบริษัทฯ
    ''' </summary>
    ''' <remarks></remarks>
    Public ReadOnly Property นับวันลาโดยหักวันหยุด() As Boolean
        Get
            If HttpContext.Current.Session("Ck_LeaveTotalNoHoliday") Is Nothing Then
                LoadAdminPolicy()
            End If
            Return HttpContext.Current.Session("Ck_LeaveTotalNoHoliday")
        End Get
    End Property

    Private Sub LoadAdminPolicy()
        Dim _AdminCanDeleteApproveOT As Object
        Dim _AdminCanEditApproveOT As Object

        Dim _AdminCanAddOtForEmployee As Object
        Dim _AdminCanAddLeaveForEmployee As Object

        Dim _Ck_LeaveTotalNoHoliday As Object

        Dim dt As DataTable
        Try

            dt = LoadTableMasterWeb.TAM_ConfigProgramTime()

            Try
                _AdminCanEditApproveOT = CBool(dt.Rows(0)("AdminCanEditApproveOT"))
                _AdminCanDeleteApproveOT = CBool(dt.Rows(0)("AdminCanDeleteApproveOT"))
            Catch ex As Exception
                _AdminCanEditApproveOT = True
                _AdminCanDeleteApproveOT = True
            End Try

            Try
                _AdminCanAddOtForEmployee = CBool(dt.Rows(0)("AdminCanAddOtForEmployee"))
                _AdminCanAddLeaveForEmployee = CBool(dt.Rows(0)("AdminCanAddLeaveForEmployee"))
            Catch ex As Exception
                _AdminCanAddOtForEmployee = True
                _AdminCanAddLeaveForEmployee = True
            End Try

            Try
                _Ck_LeaveTotalNoHoliday = CBool(dt.Rows(0)("Ck_LeaveTotalNoHoliday"))
            Catch ex As Exception
                _Ck_LeaveTotalNoHoliday = False
            End Try

        Catch ex As Exception
            _AdminCanEditApproveOT = True
            _AdminCanDeleteApproveOT = True

            _AdminCanAddOtForEmployee = True
            _AdminCanAddLeaveForEmployee = True

            _Ck_LeaveTotalNoHoliday = False
        End Try

        HttpContext.Current.Session("Ck_LeaveTotalNoHoliday") = _Ck_LeaveTotalNoHoliday

        HttpContext.Current.Session("AdminCanEditApproveOT") = _AdminCanEditApproveOT
        HttpContext.Current.Session("AdminCanDeleteApproveOT") = _AdminCanDeleteApproveOT

        HttpContext.Current.Session("AdminCanAddOtForEmployee") = _AdminCanAddOtForEmployee
        HttpContext.Current.Session("AdminCanAddLeaveForEmployee") = _AdminCanAddLeaveForEmployee
    End Sub
End Module

Public Class User
    Public EditShift_Day As Integer   ' กำหนดไม่ให้key กะ ย้อนหลัง กี่วัน family/standard [reference : web ka][Add on 58-07-07]
    Public Confirm_Day As Integer     ' กำหนดวัน ห้ามติ๊กช่อง ส่งตารางเวรของเดือนต่อไป เคสโรงพยาบาล Type_Process=1 งาน mo คามิเลียน เช่น ถ้าจะกำหนดเดือนมกรา จะกำหนดเป็น 5 กพ [reference : web ka][Add on 58-07-07]


    ''' <summary>
    ''' หัวหน้า/เห็นเฉพาะตัวเอง/HR
    ''' </summary>
    ''' <remarks></remarks>
    Public สิทธิ์ As UserType = UserType.User        'สิทธิ
    Public ShowPageHRIS As ShowPage = ShowPage.None    'สิทธิ

    ''' <summary>
    ''' เปิดเป็น std 
    ''' </summary>
    ''' <remarks></remarks>

    Public ServerName As String = ""
    Public DatabaseName As String = ""
    Public uid As String = ""
    Public pwd As String = ""
    Public MemoProcess As String = ""

    Public IsNewDataBase As Boolean = True   'True คือ ใช่  , No คือ ไม่    [Chat, สำหรับเช็คฐานข้อมูล กรณีที่มีการเพิ่มหรือแก้ไข โครงสร้างของ table เนื่องจากฐานเก่าไม่มีพวกที่เพิ่มใหม่ เช่นรองรับ 3 ภาษา]
    Public IsAdmin As Boolean         ' ถ้าเห็นได้หลายคนถือว่าเป็น admin ได้ค่ามาจากหน้า default1 
    Public PersonName As String = ""
    Public PersonNameT = "" 'คำนำหน้า,ชื่อ,สกุล Login
    Public PersonNameE = "" 'คำนำหน้า,ชื่อ,สกุล Login
    Public FNameLName$ = "" 'คำนำหน้า,ชื่อ,สกุล Login

    Public PositionName As String = ""
    Public PositionNameT As String = ""
    Public PositionNameE As String = ""

    Public CompanyIDUser As Integer   ' รหัสบริษัทที่พนักงานสังกัดอยู่
    Public CompanyID As Integer       ' รหัสบริษัท
    Public CkCompanyID As String      ' เคสกระทิงแดงต้อง กรณีดูคนข้ามบริษัทฯ จะเก็บสิทธิ์ว่าสามารถดูคนบริษัทฯไหนได้บ้าง
    Public CompanyName As String = "" ' ชื่อบริษัท
    Public CompanyCode As String = "" ' ชื่อบริษัท

    Public ID_User$
    Public UserID$                    ' รหัสผู้ใช้ Login
    Public UserName$ = ""             ' ชื่อผู้ใช้ Login
    Public Password$ = ""             ' รหัสผ่าน Login
    Public Lang$ = "T"                ' ภาษา
    Public PersonCode$ = ""           ' รหัสผู้ใช้ Login
    Public UserGroupID$ = ""          ' รหัสกรุ๊ป(สิทธิ์)ผู้ใช้ Login
    Public GroupID As Integer = 0   ' กลุ่มผู้ใช้ -,Admin,User,Supervisor


    Public ReadOnly Property HRISProcessPath() As String
        Get

            If (1 = 0) Then
                'ถ้าพบใน config 
                'รอทางด้าน P'ตั้มทำหน้า config ที่ติดตั้ง app
                Return ""
            Else
                'default path
                Return "C:\TigerSoft\HRISProcessTimeAttendance\TimeAtt.exe"
            End If
        End Get
    End Property

    Public VSA As Boolean = True ' [reference : Personnel][Add on 58-07-27]  เห็นเงินเดือน
    Public ESA As Boolean = True ' [reference : Personnel][Add on 58-07-27]  แก้ไขเงินเดือน
    Public HRISLogin As Integer = 1 ' 1 = มาจาก HRISLogin 
    ' Public FNameLName$ = "" 'คำนำหน้า,ชื่อ,สกุล Login

    Public MenuCode$ = "" 'เก็บชื่อเมนูไว้เช็คว่ามีสิทธิเข้าหน้านั้นๆหรือไม่
    Public HRApprove As Boolean = False 'CK '' HR อนุมัติ
    Public SeeYourSelf As Integer = 0 '0 = เห็นตัวเอง, 1 = ไม่เห็นตัวเอง
    Public UseTraining As Boolean = True 'Ck for login '''''' เช็คสิทธิการเข้าระบบ TimeAttendance
    Public DisplayToPopup As Integer = 0 'กำหนดค่าเริ่มต้นแจ้งการแจ้งเตือนเป็น Tab ก่อน


    Public sqlForm As String = "    FROM  PNT_Person LEFT JOIN PNM_Sex ON  PNT_Person.SexID = PNM_Sex.SexID INNER JOIN  " & _
                                    " PNM_Position ON  PNT_Person.PositionID = PNM_Position.PositionID INNER JOIN " & _
                                    " PNM_Cmb1 ON PNT_Person.Cmb1ID  =  PNM_Cmb1.Cmb1ID LEFT JOIN " & _
                                    " PNM_Cmb2 ON  PNT_Person.Cmb2ID =  PNM_Cmb2.Cmb2ID LEFT JOIN " & _
                                    " PNM_Cmb3 ON  PNT_Person.Cmb3ID =  PNM_Cmb3.Cmb3ID LEFT JOIN " & _
                                    " PNM_Cmb4 ON PNT_Person.Cmb4ID  =  PNM_Cmb4.Cmb4ID LEFT JOIN " & _
                                    " PNM_Cmb5 ON PNT_Person.Cmb5ID  =  PNM_Cmb5.Cmb5ID LEFT JOIN " & _
                                    " PNM_Cmb6 ON PNT_Person.cmb6ID  =  PNM_Cmb6.cmb6ID LEFT JOIN " & _
                                    " PNM_Cmb7 ON  PNT_Person.Cmb7ID =  PNM_Cmb7.Cmb7ID LEFT JOIN " & _
                                    " PNM_Cmb8 ON PNT_Person.Cmb8ID  =  PNM_Cmb8.Cmb8ID LEFT JOIN " & _
                                    " PNM_Cmb9 ON PNT_Person.Cmb9ID  =  PNM_Cmb9.Cmb9ID LEFT JOIN " & _
                                    " PNM_Cmb10 ON PNT_Person.cmb10ID  =  PNM_Cmb10.cmb10ID LEFT JOIN " & _
                                    " PNM_Initial ON PNT_Person.InitialID = PNM_Initial.InitialID "

    Public sqlPerson As String = " SELECT  PNT_Person.PersonCode + '  ' +  PNM_Initial.InitialT + ' ' +  PNT_Person.FnameT + ' ' +  PNT_Person.LnameT AS NName,PNT_Person.PersonID, PNT_Person.PersonCode,PNT_Person.PersonCardID,  PNT_Person.InitialID,  PNM_Initial.InitialCode,PNM_Initial.InitialT,  PNM_Initial.InitialE, PNT_Person.FnameT, PNT_Person.LnameT,  PNM_Sex.SexT, PNM_Position.PositionCode, PNM_Position.PositionCode +''+  PNM_Position.PositionNameT as PositionNameT,  PNM_Cmb1.Cmb1Code, PNM_Cmb1.Cmb1Code +''+  PNM_Cmb1.Cmb1NameT as Cmb1NameT, " & _
                            " PNM_Cmb6.Cmb6Code, PNM_Cmb6.Cmb6Code  + ''+ PNM_Cmb6.Cmb6NameT as Cmb6NameT, PNM_Cmb4.Cmb4Code,PNM_Cmb4.Cmb4Code +''+ PNM_Cmb4.Cmb4NameT as Cmb4NameT, PNM_Cmb3.Cmb3Code,PNM_Cmb3.Cmb3Code +''+ PNM_Cmb3.Cmb3NameT as Cmb3NameT,  PNM_Cmb2.Cmb2Code,PNM_Cmb2.Cmb2Code+ '' + PNM_Cmb2.Cmb2NameT as Cmb2NameT , PNM_Cmb5.Cmb5Code , PNM_Cmb5.Cmb5Code +''+ PNM_Cmb5.Cmb5NameT as Cmb5NameT,PNT_Person.SexID  "

    Public sqlPersonName As String = " SELECT  PNM_Initial.InitialT + ' ' +  PNT_Person.FnameT + ' ' +  PNT_Person.LnameT AS NName,     PNM_Initial.InitialE + ' ' +  PNT_Person.FnameE + ' ' +  PNT_Person.LnameE AS NNameE, PNT_Person.PersonID, PNT_Person.PersonCode,PNT_Person.PersonCardID,  PNT_Person.InitialID,  PNM_Initial.InitialCode,PNM_Initial.InitialT,  PNM_Initial.InitialE, PNT_Person.FnameT, PNT_Person.LnameT, PNT_Person.FnameE, PNT_Person.LnameE,  PNM_Sex.SexT, PNM_Position.PositionCode,  PNM_Position.PositionNameT,  " & _
                         "  PNM_Cmb1.Cmb1Code,  PNM_Cmb1.Cmb1NameT, PNM_Cmb1.Cmb1NameE, PNM_Cmb6.Cmb6Code,PNM_Cmb6.Cmb6NameT, PNM_Cmb4.Cmb4Code, PNM_Cmb4.Cmb4NameT, PNM_Cmb3.Cmb3Code, PNM_Cmb3.Cmb3NameT, PNM_Cmb3.Cmb3NameE,  PNM_Cmb2.Cmb2Code, PNM_Cmb2.Cmb2NameT, PNM_Cmb2.Cmb2NameE, PNM_Cmb5.Cmb5Code,PNM_Cmb5.Cmb5NameT,PNT_Person.SexID   "    'Fixed : [waiting]






    Public sqlPersonName_Only As String = "SELECT PNT_Person.FnameT,pnt_person.TypeProcessSalary,PNT_Person.FnameE,PNM_Initial.InitialT +  PNT_Person.FnameT + ' ' +  PNT_Person.LnameT AS NName,isnull(PNM_Initial.InitialE,'') + isnull(PNT_Person.FnameE,'') + ' ' +  isnull(PNT_Person.LnameE,'') AS NNameE,PNT_Person.PersonID, PNT_Person.PersonCode,PNT_Person.PersonCardID ,PNT_Person.CompanyID "

    Public sql_JoinCmb$ = " Left join PNM_Cmb1 with(nolock) ON PNT_Person.Cmb1ID = PNM_Cmb1.Cmb1ID Left JOIN PNM_Cmb2 with(nolock) ON  PNT_Person.Cmb2ID =  PNM_Cmb2.Cmb2ID Left JOIN PNM_Cmb3 with(nolock) ON  PNT_Person.Cmb3ID = PNM_Cmb3.Cmb3ID Left JOIN PNM_Cmb4 with(nolock) ON PNT_Person.Cmb4ID = PNM_Cmb4.Cmb4ID Left JOIN PNM_Cmb5 with(nolock) ON PNT_Person.Cmb5ID = PNM_Cmb5.Cmb5ID Left JOIN PNM_Cmb6 with(nolock) ON PNT_Person.cmb6ID =PNM_Cmb6.cmb6ID Left JOIN PNM_Cmb7 with(nolock) ON PNT_Person.cmb7ID =PNM_Cmb7.cmb7ID Left JOIN PNM_Cmb8 with(nolock) ON PNT_Person.cmb8ID =PNM_Cmb8.cmb8ID Left JOIN PNM_Cmb9 with(nolock) ON PNT_Person.cmb9ID =PNM_Cmb9.cmb9ID Left JOIN PNM_Cmb10 with(nolock) ON PNT_Person.cmb10ID =PNM_Cmb10.cmb10ID  " & _
                          " Left JOIN PNM_Initial with(nolock) ON PNT_Person.InitialID = PNM_Initial.InitialID "

    Public sqlDistinctCm1 As String = " SELECT DISTINCT PNM_Cmb1.Cmb1ID as ID, PNM_Cmb1.Cmb1Code as cmCode, PNM_Cmb1.Cmb1NameT as cmName , PNM_Cmb1.Cmb1Code + ' ' +  PNM_Cmb1.Cmb1NameT as CmCode_Name  " & sqlForm  'Fixed : [waiting]
    Public sqlDistinctCm2 As String = " SELECT DISTINCT PNM_Cmb2.Cmb2ID as ID, PNM_Cmb2.Cmb2Code as cmCode, PNM_Cmb2.Cmb2NameT as cmName , PNM_Cmb2.Cmb2Code + ' ' +  PNM_Cmb2.Cmb2NameT as CmCode_Name  " & sqlForm  'Fixed : [waiting]
    Public sqlDistinctCm3 As String = " SELECT DISTINCT PNM_Cmb3.Cmb3ID as ID, PNM_Cmb3.Cmb3Code as cmCode, PNM_Cmb3.Cmb3NameT as cmName , PNM_Cmb3.Cmb3Code + ' ' +  PNM_Cmb3.Cmb3NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]
    Public sqlDistinctCm4 As String = " SELECT DISTINCT PNM_Cmb4.Cmb4ID as ID, PNM_Cmb4.Cmb4Code as cmCode, PNM_Cmb4.Cmb4NameT as cmName , PNM_Cmb4.Cmb4Code + ' ' +  PNM_Cmb4.Cmb4NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]
    Public sqlDistinctCm5 As String = " SELECT DISTINCT PNM_Cmb5.Cmb5ID as ID, PNM_Cmb5.Cmb5Code as cmCode, PNM_Cmb5.Cmb5NameT as cmName , PNM_Cmb5.Cmb5Code + ' ' +  PNM_Cmb5.Cmb5NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]
    Public sqlDistinctCm6 As String = " SELECT DISTINCT PNM_Cmb6.Cmb6ID as ID, PNM_Cmb6.Cmb6Code as cmCode, PNM_Cmb6.Cmb6NameT as cmName , PNM_Cmb6.Cmb6Code + ' ' +  PNM_Cmb6.Cmb6NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]
    Public sqlDistinctCm7 As String = " SELECT DISTINCT PNM_Cmb7.Cmb7ID as ID, PNM_Cmb7.Cmb7Code as cmCode, PNM_Cmb7.Cmb7NameT as cmName , PNM_Cmb7.Cmb7Code + ' ' +  PNM_Cmb7.Cmb7NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]
    Public sqlDistinctCm8 As String = " SELECT DISTINCT PNM_Cmb8.Cmb8ID as ID, PNM_Cmb8.Cmb8Code as cmCode, PNM_Cmb8.Cmb8NameT as cmName , PNM_Cmb8.Cmb8Code + ' ' +  PNM_Cmb8.Cmb8NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]
    Public sqlDistinctCm9 As String = " SELECT DISTINCT PNM_Cmb9.Cmb9ID as ID, PNM_Cmb9.Cmb9Code as cmCode, PNM_Cmb9.Cmb9NameT as cmName , PNM_Cmb9.Cmb9Code + ' ' +  PNM_Cmb9.Cmb9NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]
    Public sqlDistinctCm10 As String = " SELECT DISTINCT PNM_Cmb10.Cmb10ID as ID, PNM_Cmb10.Cmb10Code as cmCode, PNM_Cmb10.Cmb10NameT as cmName , PNM_Cmb10.Cmb10Code + ' ' +  PNM_Cmb10.Cmb10NameT as CmCode_Name   " & sqlForm 'Fixed : [waiting]

    Public sqlPosition As String = " SELECT DISTINCT PNM_Position.PositionID  as ID, PNM_Position.PositionCode  as cmCode, PNM_Position.PositionNameT  as cmName ,PNM_Position.PositionCode + ' ' +  PNM_Position.PositionNameT as CmCode_Name   " & sqlForm    'Fixed : [waiting]


    'Chat, 601225 บางตัด filed ที่ไม่ได้ใช้แล้ว
    'Public sqlPerson_NoPic As String = "Select pnt_person.PersonID,PersonCode,PersonCardID,pnt_person.InitialID,FnameT,LnameT,FnameE,LnameE,pnt_person.Cmb1ID,pnt_person.Cmb2ID,pnt_person.Cmb3ID,pnt_person.Cmb4ID,pnt_person.Cmb5ID,pnt_person.cmb6ID,pnt_person.PositionID,EmpTypeID,ContractID,ContractBegin,ContractExpire,Age,BirthDate,StartDate,PassDate,numProof,EndDate,WorkOld,TaxID,SSFID,HospitalID,ContactNo,IdentityID,IdentityExpire,PFID,PassportID,PassportPlace,PassportStart,PassportExpire,PassportMemo,VisaID,VisaPlace,VisaStart,VisaExpire,VisaMemo,AwworkID,AwworkPlace,AwworkStart,AwworkExpire,AwworkMemo,CurrentAddress,CurrentBuilding,CurrentSoi,CurrentRoad,CurrentDistric,CurrentAmphur,CurrentProvince,CurrentPostID,CurrentTel,CurrentNation,CardAddress,CardBuilding,CardSoi,CardRoad,CardDistric,CardAmphur,CardProvince,CardPostID,CardTel,CardNation,MateName,MateAddress,MateAge,numChild,numSon,numDaughter,MateAlive,MateOccupation,MatePosition,MateTel,MateSSF,MateTax,MateIdentity,FatherName,FatherAddress,FatherOccupation,FatherTel,FatherAge,FatherAlive,MotherName,MotherAddress,MotherOccupation,MotherTel,MotherAge,MotherAlive,WedStatus,PosSon,numMen,numWomen,BureID,BureExpire,ChkDeletePerson,WorkStatusID,ResignStatus,Salary,Salary2,JGID,TypeProcessSalary,MateFname,MateLname,MateInitial,FatherIden,MotherIden,hour_train,PicPath,MateBirth,MotherBirth,FatherBirth,Salary_Encrypt,DateInPos,DateIn1,DateIn2,DateIn3,DateIn4,DateIn5,DateIn6 ,PNM_Initial.InitialT +  PNT_Person.FnameT + ' ' +  PNT_Person.LnameT AS NName,PNM_Initial.InitialE +  PNT_Person.FnameE + ' ' +  PNT_Person.LnameE AS NNameE "
    Public sqlPerson_NoPic As String = " Select pnt_person.PersonID, PersonCode,PersonCardID,pnt_person.InitialID,FnameT,LnameT,FnameE,LnameE,pnt_person.Cmb1ID,pnt_person.Cmb2ID,pnt_person.Cmb3ID,pnt_person.Cmb4ID,pnt_person.Cmb5ID,pnt_person.cmb6ID,pnt_person.PositionID, pnt_person.EmpTypeID,ContractID,ContractBegin,ContractExpire, BirthDate,StartDate,PassDate,numProof,EndDate,WorkOld,TaxID,SSFID,HospitalID,ContactNo,IdentityID,IdentityExpire,PFID,PassportID,PassportPlace,PassportStart,PassportExpire,PassportMemo,VisaID,VisaPlace,VisaStart,VisaExpire,VisaMemo,AwworkID,AwworkPlace,AwworkStart,AwworkExpire,AwworkMemo,CurrentAddress,CurrentBuilding,CurrentSoi,CurrentRoad,CurrentDistric,CurrentAmphur,CurrentProvince,CurrentPostID,CurrentTel,CurrentNation,CardAddress,CardBuilding,CardSoi,CardRoad,CardDistric,CardAmphur,CardProvince,CardPostID,CardTel,CardNation,MateFName + ' ' + MateLname as MateName,MateAddress,numChild,numSon,numDaughter,MateAlive,MateOccupation,MatePosition,MateTel,MateSSF,MateTax,MateIdentity,FatherName,FatherAddress,FatherOccupation,FatherTel,FatherAge,FatherAlive,MotherName,MotherAddress,MotherOccupation,MotherTel, MotherAlive,WedStatus,PosSon,numMen,numWomen,BureID,BureExpire,ChkDeletePerson, ResignStatus,Salary, JGID, pnt_person.TypeProcessSalary,MateFname,MateLname,MateInitial,FatherIden,MotherIden, MateBirth,MotherBirth,FatherBirth, DateInPos,DateIn1,DateIn2,DateIn3,DateIn4,DateIn5,DateIn6 ,PNM_Initial.InitialT +  PNT_Person.FnameT + ' ' +  PNT_Person.LnameT AS NName,PNM_Initial.InitialE +  PNT_Person.FnameE + ' ' +  PNT_Person.LnameE AS NNameE , CONVERT(VARCHAR(15),DECRYPTBYPASSPHRASE('1984', PNT_Person.Salary)) as Salary_Encrypt "

    Public SqlStatCondition As String = " COUNT(CASE WHEN TAM_TimeDay.Late_TimeIn > 0 THEN 1 END) AS L1, " & _
                " COUNT(CASE WHEN TAM_TimeDay.Beforce_Timeout > 0 THEN 1 END) AS L2, " & _
                " COUNT(CASE WHEN TAM_TimeDay.Day_Memo LIKE '%ลืมนำบัตรมา%' THEN 1 END) AS L3, " & _
                " COUNT(CASE WHEN TAM_TimeDay.Day_Memo LIKE '%ลืมลงเวลา%' THEN 1 END) AS L4, " & _
                " COUNT(CASE WHEN TAM_TimeDay.C_DayAbs_D > 0 THEN 1 END) AS L5 " & _
                " FROM TAM_TimeDay  Left join PNT_Person on TAM_TimeDay.PersonID = PNT_Person.personid  "



    '610419 By Na ให้เพิ่มสำหรับกรณีพนักงานโอนย้ายบริษัท เช่น A -> B  และ B ย้ายกลับมา A
    '   - ตาราง TAP_LeaveForm   = ใบลางาน 
    '   - ตาราง TAM_TimeDay   = ข้อมูลหลังการประมวลผล
    '   - ตาราง TAM_Work  = กะงาน
    '   คือ A โอนไป B พนักงานจะถูกเปลี่ยนรหัสไปเป็นรหัสใหม่ และข้อมูล Transcation ตอนอยู่บริษัท A ทั้งหมดจะถูก copy มาอีกชุดโดยเป็น personid ของบริษัทใหม่
    '      แต่เมื่ออยู่บริษัท B แล้ว ต้องการโอนกลับมาบริษัท A    ข้อมูล Transaction ตอนอยู่บริษัท B ทั้งหมดจะถูก copy มาเป็นบริษัท A เพื่อให้บริษัท B ยังดูข้อมูลเดิมได้ 
    '      ซึ่งข้อมูลเก่าก่อนที่ B โอนมา A นั้นจะถูกเปลี่ยนเป็นที่คอลัมน์ ChkTrDel = 'D'    (*กรณี A -> B = null  แต่ B -> A = 'D' )
    Public whChkTrDel_LeaveForm As String = " and (TAP_LeaveForm.ChkTrDel <> 'D' or TAP_LeaveForm.ChkTrdel is null or TAP_LeaveForm.ChkTrdel = null) "
    Public whChkTrDel_TimeDay As String = " and (TAM_TimeDay.ChkTrDel <> 'D' or TAM_TimeDay.ChkTrdel is null or TAM_TimeDay.ChkTrdel = null) "
    Public whChkTrDel_Work As String = " and (TAM_Work.ChkTrDel <> 'D' or TAM_Work.ChkTrdel is null or TAM_Work.ChkTrdel = null) "


    '' Set Skin Tools Telerik ''
    Public SkinGrid$ = ""
    Public SkinCombo$ = ""
    Public SkinTreeView$ = ""
    Public SkinRadTabStrip$ = ""
    Public SkinRadToolBar$ = ""
    Public SkinRadwindows$ = ""
    Public SkinRadListBox$ = ""
    Public SkinRadContextMenu$ = ""
    Public SkinRadScheduler$ = ""

    Public Ck_TypeProgram_Eco As Integer = 1        'Fixed : [waiting]  1 ปกติ   2 ชุด Eco 
    Public Ck_TypeProgram_Eco_Hotel As Integer = 0  'Fixed : [waiting]  ชุด  Hotel 0  eco/ปกติ  1 ชุด โรงแรม
    '  Ck_TypeProgram_Eco    Ck_TypeProgram_Eco_Hotel  
    '        1                       0                     = ปกติ CyberHRM
    '        2                       0                     = Eco
    '        2                       1                     = Hotel
    '-------------------------------------------------------------------------------------
    'โปรแกรม ชุด 3 ตัว เล็ก
    ' 0 ปกติ  
    ' 1 โรงพยาบาล
    ' 2 โรงแรม 
    Public Type_CalToPayrollHour As Integer = 0
    Public Type_CaseProgram3HR As Integer = 0   'Fixed : [waiting] 
    Public Type_OpenOTAutoBeforce_Holiday As Integer = 0   'Fixed : [waiting] แสดงการใช้งาน โอทีอัตโนมัติ
    Public Type_Shutdown75 As Integer = 0   'Fixed : [waiting] (Shutdown 75 %) 
    Public Type_PayselectOT As Integer = 0  'Fixed : [waiting] เปิดหรือ ปิด  การเลือก โอที ให้หรือไม่ให้ในแต่ละวัน 
    Public Type_OpenOTHoTel As Integer = 0  'Fixed : [waiting] เปิดหรือ ปิด  การเลือก โอที จ่าย หรือ ลา
    Public Type_OpenMenu As Integer = 0     'Fixed : [waiting] แสดงเมนู    0 = ไม่แสดง   1 = แสดงเปิดการใช้งาน
    Public Type_CaseProgram As Integer = 0  'Fixed : [waiting] เก็บข้อมูล ของโปรแกรมว่า สำหรับ 0.ปกติ หรือ 1.โรงพยาบาล เก็บข้อมูล ของโปรแกรมว่า สำหรับ 0.ปกติ หรือ 1.โรงพยาบาล

    Public Type_ckHreal As Integer = 0   'เปิดการการใช้งานนับชั่วโมงตามกะงาน
    Public Type_LeavesummerAuto As Integer = 0   'เปิดการโอนพักร้อนอัตโนมัติ

    Public TypeProcess As Integer           'Fixed : [waiting] เก็บเงือนไขการประมวลผลของแต่ละที
    Public Type_LeaveOT As Integer = 0      'Fixed : [waiting] เปิดการ การลาสะสมวันหยุด
    Public HP_M As Integer = 480            'Fixed : [waiting]
    Public HP_D As Integer = 480            'Fixed : [waiting]
    Public D_PM As Integer = 0
    Public OT1 As String = "1"              'Fixed : [waiting] 
    Public OT2 As String = "1.5"            'Fixed : [waiting] 
    Public OT3 As String = "2"              'Fixed : [waiting] 
    Public OT4 As String = "2.5"              'Fixed : [waiting] 
    Public OT5 As String = "3"            'Fixed : [waiting] 
    Public OT6 As String = "6"            'Fixed : [waiting] 

    Public Name_Special1 As String = "-"      'Fixed : [waiting] 
    Public Name_Special2 As String = "-"       'Fixed : [waiting] 
    Public Name_Special3 As String = "-"       'Fixed : [waiting] 


    Public STEXT1 As String = ""       'Fixed : [waiting] 
    Public STEXT2 As String = ""       'Fixed : [waiting] 


    Dim ds_conFig As New DataSet
    Dim da_conFig As New Mydata(adoconn)
    Public LeaveCode(30) As String          'Fixed : [waiting] 
    Public Leave(30) As String             'Fixed : [waiting] 
    Public LeaveE(30) As String             'Fixed : [waiting] 
    Public LeaveMini(30) As String          'Fixed : [waiting] 
    Public CLeave(30) As String             'Fixed : [waiting] 

    Public LeaveMsg(30) As Boolean          'Fixed : [waiting] 
    Public CkpayLeave(30) As Boolean        'Fixed : [waiting] 
    Public CkNopayLeave(30) As Boolean      'Fixed : [waiting] 
    Public Ck_ShowMoneyDiligent As Integer = 0
    Public S_ckMoney As Boolean             'Fixed : [waiting] ตรวจสอบการเห้นเงิน

    Public CodeFood(6) As String
    Public NameFood(6) As String
    Public ck_CountFood(6) As Boolean

    Public Number_Machine As String = ""    'Fixed : [waiting] 
    Public CaseLockprocessDM As Integer = 0 'Fixed : [waiting] 

    'chkDeletePerson=1 คือไม่ลบ   0 คือลบ
    'resignstatus=1 คือยังไม่ออก   0 คือออก
    Public ReadOnly Property Wh(Optional ByVal xNotAnd As Boolean = False) As String
        Get
            If xNotAnd Then
                Return " PNT_Person.ResignStatus = 1 and PNT_Person.chkDeletePerson = 1 "
            Else
                Return " and PNT_Person.ResignStatus = 1 and PNT_Person.chkDeletePerson = 1 "
            End If
        End Get
    End Property

    'Public Sub LoadLeave()
    '    Try
    '        ds_conFig.Tables("TAM_Leave").Clear()
    '    Catch ex As Exception
    '    End Try
    '    da_conFig.GetDataset(ds_conFig, "SELECT TAM_Leave.* FROM TAM_Leave order by id_leave", "TAM_Leave")
    '    Dim i%
    '    For Each dr As DataRow In ds_conFig.Tables("TAM_Leave").Rows
    '        i += 1
    '        Try
    '            'ภาษา
    '            Sys.LoginWeb.LeaveE(i) = dr("Leave_NameE") & ""
    '            Sys.LoginWeb.Leave(i) = dr("Leave_NameT") & ""
    '            Sys.LoginWeb.LeaveCode(dr("id_leave")) = dr("Leave_Code") & ""
    '            Try
    '                Sys.LoginWeb.CLeave(i) = dr("LCode") & ""
    '            Catch ex As Exception
    '                Sys.LoginWeb.CLeave(i) = ""
    '            End Try
    '        Catch ex As Exception
    '        End Try
    '    Next
    'End Sub

    Public ReadOnly Property อนุมัติข้ามบริษัท() As Boolean
        Get
            Dim result As Boolean = False
            If HttpContext.Current.Session("ShowAllCompany") Is Nothing Then
                Try
                    Using dt1 As DataTable = Sys.LoadTableMasterWeb.TAM_ConfigProgramTime
                        result = CBool(dt1.Rows(0)("ShowAllCompany"))
                    End Using
                Catch ex As Exception
                    result = False
                End Try
                HttpContext.Current.Session("ShowAllCompany") = result
            Else
                result = CBool(HttpContext.Current.Session("ShowAllCompany"))
            End If
            Return result
        End Get
    End Property

    Public ReadOnly Property รายงานข้ามบริษัท() As Boolean
        Get
            'If Sys.TypeCaseProcess = TypeCaseProcess.กระทิงแดง_91 Then
            '    Return True
            'ElseIf Sys.TypeCaseProcess = TypeCaseProcess.Cigma_139 Then
            '    Return True
            'ElseIf Sys.TypeCaseProcess = TypeCaseProcess.Hollywood_140 Then
            '    Return True
            'Else
            '    Return False
            'End If

            Return False
        End Get
    End Property
    Public ReadOnly Property ApproveOtTimeOut() As Integer
        Get
            Try
                Dim intResult As Byte
                intResult = Val(CType(System.Web.HttpContext.Current.Session("DrPerson"), DataRow)("ApproveOtTimeOut") & "")
                Return intResult
            Catch ex As Exception
                Throw ex
            End Try
        End Get
    End Property

    Public ReadOnly Property ApproveLeaveTimeOut() As Integer
        Get
            Dim Page As HttpContext = System.Web.HttpContext.Current
            Try
                Dim intResult As Byte
                intResult = Val(CType(Page.Session("DrPerson"), DataRow)("ApproveLeaveTimeOut") & "")
                Return intResult
                'If intResult = 0 Then
                '    Throw New Exception("กรุณาตั้งค่ากลุ่มการอนุมัติ TAM_SETUPCompany.ApproveLeaveTimeOut")
                'End If
                'Return CType(Page.Session("DrPerson"), DataRow)("ApproveLeaveTimeOut")
            Catch ex As Exception
                Throw ex
            End Try
        End Get
    End Property

    Public ReadOnly Property ApproveTimeInOutTimeOut() As Integer
        Get
            Dim Page As HttpContext = System.Web.HttpContext.Current
            Try
                Dim intResult As Byte
                intResult = Val(CType(Page.Session("DrPerson"), DataRow)("ApproveTimeInOutTimeOut") & "")
                Return intResult
            Catch ex As Exception
                Throw ex
            End Try
        End Get
    End Property

    ''' <summary>
    ''' ตรวจสอบว่า ลูกค้าใช้อนุมัติเป็นขั้นๆ หรือไม่ เพราะบางที่ไม่ใช้เป็นขั้นๆแน่ๆเช่น MPO และ MFEC ที่สั่ง Mo เรื่องการอนุมัติเป็นพิเศษ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>โดย check ว่ามี table tam_approveleavegroup หรือป่าว จากตอน login ที่ default1.aspx</remarks>
    Public ReadOnly Property UseApproveLevel() As Boolean
        Get
            Dim Page As HttpContext = System.Web.HttpContext.Current
            Try
                If System.Convert.IsDBNull(CType(Page.Session("DrPerson"), DataRow)("UseApproveLevel")) Then
                    Return False
                Else
                    Return CType(Page.Session("DrPerson"), DataRow)("UseApproveLevel")
                End If
            Catch ex As Exception
                Throw ex
            Finally
                Page = Nothing
            End Try
        End Get
    End Property


    'ckhr_alert / ckhr_alertOT
    'ckhr_alert ไว้สำหรับ check การอนุมัติใบลาว่า หลังการ approve 1 2 3 แล้วถ้าอนุมัติให้ใบลามีสถานะเป็น A หรือ P ซึ่งจะมีผลต่อการแสดงในหน้าจอ App
    'True = P หรือ False = P 
    ''' <summary>
    ''' ต้องส่งให้ HR อนุมัติก่อนหรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CkHrAlertLeave() As Boolean
        Get
            Dim Page As HttpContext = System.Web.HttpContext.Current
            Try
                If System.Convert.IsDBNull(CType(Page.Session("DrPerson"), DataRow)("ckhr_alert")) Then
                    Return False
                Else
                    Return CType(Page.Session("DrPerson"), DataRow)("ckhr_alert")
                End If
            Catch ex As Exception
                Throw ex
            Finally
                Page = Nothing
            End Try
        End Get
    End Property

    ''' <summary>
    ''' ใช้กับ OT หลังจากอนุมัติครบแล้ว ให้ไป HR ก่อนหรือไม่ ถ้าใช่ สถานะจะถูกเปลี่ยนเป็น P ถ้าไม่จะเป็น A
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CkHrAlertOT() As Boolean
        Get
            Dim Page As HttpContext = System.Web.HttpContext.Current
            Try
                If System.Convert.IsDBNull(CType(Page.Session("DrPerson"), DataRow)("ckhr_alertot")) Then
                    Return False
                Else
                    Return CType(Page.Session("DrPerson"), DataRow)("ckhr_alertot")
                End If
            Catch ex As Exception
                Throw ex
            Finally
                Page = Nothing
            End Try
        End Get
    End Property

    Public ReadOnly Property CkHR_AlertTimeInOut() As Boolean
        Get
            Dim Page As HttpContext = System.Web.HttpContext.Current
            Try
                If System.Convert.IsDBNull(CType(Page.Session("DrPerson"), DataRow)("ckhr_AlertTimeInOut")) Then
                    Return False
                Else
                    Return CType(Page.Session("DrPerson"), DataRow)("ckhr_AlertTimeInOut")
                End If
            Catch ex As Exception
                Throw ex
            Finally
                Page = Nothing
            End Try
        End Get
    End Property

    ''' <summary>
    ''' ห้าม OT TIME ย้อนหลัง ลาไปตั้งเอาเองที่ time -> ตั้งค่าบริษัทฯ -> สำหรับ web
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LockOTDay() As Integer
        Get
            Return CType(HttpContext.Current.Session("DrPerson"), DataRow)("LockOTDay")
        End Get
    End Property


    ''' <summary>
    ''' Daicel ห้าม OT TIME ย้อนหลัง ลาไปตั้งเอาเองที่ time -> ตั้งค่าบริษัทฯ -> สำหรับ web
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property LockOTSpecialDay() As Integer
        Get
            Return CType(HttpContext.Current.Session("DrPerson"), DataRow)("LockOTSpecialDay")
        End Get
    End Property


    ''' <summary>
    ''' Kraftfood + hollywood
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ส่งเมล์กลับหาผู้ขอ() As Boolean
        Get
            'If Sys.TypeCaseProcess = TypeCaseProcess.Kraftfood_134 Then
            '    Return True
            'ElseIf Sys.TypeCaseProcess = TypeCaseProcess.Hollywood_140 Then
            '    Return True
            'Else
            Return False
            'End If
        End Get
    End Property

    Public ReadOnly Property CanPrint() As Boolean
        Get
            Return Sys.LoginWeb.IsAdmin
        End Get
    End Property

    Public ReadOnly Property CanUploadFile() As Boolean
        Get
            ''If LoginTimeWeb.User.UploadFilePath <> "" OrElse Sys.TypeCaseProcess = TypeCaseProcess.โรงเรียน_ICS_101 OrElse Sys.TypeCaseProcess = TypeCaseProcess.CP_ค้าปลีก_65 OrElse Sys.TypeCaseProcess = TypeCaseProcess.ETDA_157 Then
            ''    Return True
            ''End If

            'If Sys.TypeCaseProcess = TypeCaseProcess.โรงเรียน_ICS_101 OrElse Sys.TypeCaseProcess = TypeCaseProcess.CP_ค้าปลีก_65 OrElse Sys.TypeCaseProcess = TypeCaseProcess.ETDA_157 Then
            '    Return True
            'End If


            Return True
        End Get
    End Property


    Public SearchTypeCriteria As String ' [reference : Personnel][Add on 58-07-27] 
    Public SearchDateCriteriaFrom As Date ' [reference : Personnel][Add on 58-07-27] 
    Public SearchDateCriteriaTo As Date ' [reference : Personnel][Add on 58-07-27] 
    Public SearchTimeCriteriaFrom As TimeSpan ' [reference : Personnel][Add on 58-07-27] 
    Public SearchTimeCriteriaTo As TimeSpan ' [reference : Personnel][Add on 58-07-27] 

    'Public SearchDateFrom As String = "" ' [reference : Personnel][Add on 58-07-27] 
    'Public SearchDateTo As String = "" ' [reference : Personnel][Add on 58-07-27] 

    Public SearchPerson2 As String = "" ' [reference : Personnel][Add on 58-07-27] 
    Public SearchPerson As String = "" ' [reference : Personnel][Add on 58-07-27] 
    Public SearchJoinTable As String = "" ' [reference : Personnel][Add on 58-07-27] 
    Public WH_Person As String = ""     ' [reference : Personnel][Add on 58-07-27]  กำหนดสิทธิ์การค้นหารายงาน 
    Public whPerson_Resign As String = "" ' [reference : Personnel][Add on 58-07-27] กำหนดสิทธิ์การค้นหาพนักงานลาออก


    Public SearchJoinTableg8 As String = ""

    Public SearchJoinTableg8notwhere As String = ""


    Public whPerson$ = ""                   ' กำหนดสิทธิ์ การมองเห็นพนักงาน
    Public whPersonDel$ = ""             ' กำหนดสิทธิ์ การมองเห็นพนักงานที่ถูกลบ
    Public whPerson_NoResig$ = ""           ' กำหนดสิทธิ์ การมองเห็นพนักงาน

    '==================================================
    'Export Excel
    Public SelectFile As String = ""
    Public WhereFile As String = ""
    Public ShowExcel As String = ""
    Public JoinTable As String = ""
    '==================================================

    Public CkConfigCompany As Boolean       ' กำหนดสิทธิ์ ตั้งค่าบริษัทได้หรือไม่
    Public CkConfigbyUserID As Boolean      ' กำหนดสิทธิ์ ตั้งค่าผู้ใช้ระบบของตนเองได้หรือไม่
    Public CkConfigWeb As Boolean           ' กำหนดสิทธิ์ใช้เมนู เกี่ยวกับ web
    Public SuperVisorID As Integer          ' ถ้าสามารถตั้งค่าลูกได้ จะมีค่ามากกว่า 0

    ''' <summary>
    ''' สิทธิ์การมองเห็น
    ''' </summary>
    ''' <remarks></remarks>
    Public whCompany$ = ""                  ' where สิทธิ์ company
    Public SystemName$ = "TN"               ' ชื่อระบบ ใส่ตัวย่อตามระบบเช่น Compnay = COM , Person = PN
    Public FormName$ = ""                   ' ชื่อฟอร์ม

    '--- Combo ที่อยู่ ---
    Public ProvCode As String
    Public AmphurCode As String
    Public districtCode As String

    '--- เก็บชื่อ 10 combo ---
    Public lblCmb1 As String = "CM1"
    Public lblCmb2 As String = "CM2"
    Public lblCmb3 As String = "CM3"
    Public lblCmb4 As String = "CM4"
    Public lblCmb5 As String = "CM5"
    Public lblCmb6 As String = "CM6"
    Public lblCmb7 As String = "CM7"
    Public lblCmb8 As String = "CM8"
    Public lblCmb9 As String = "CM9"
    Public lblCmb10 As String = "CM10"
    Public lblPosition As String = "Position"
    Public lblEmpType As String = "ประเภทพนักงาน"
    Public lblLevel As String = "ระดับพนักงาน"
    Public lblContract As String = "สัญญาจ้าง"
    Public lblTypeProcessSalary As String = "การคิดค่าจ้าง"


    Public lblCmb1E As String = "CM1E"
    Public lblCmb2E As String = "CM2E"
    Public lblCmb3E As String = "CM3E"
    Public lblCmb4E As String = "CM4E"
    Public lblCmb5E As String = "CM5E"
    Public lblCmb6E As String = "CM6E"
    Public lblCmb7E As String = "CM7E"
    Public lblCmb8E As String = "CM8E"
    Public lblCmb9E As String = "CM9E"
    Public lblCmb10E As String = "CM10E"
    Public lblPositionE As String = "PositionE"
    Public lblEmpTypeE As String = "ประเภทพนักงานE"
    Public lblLevelE As String = "ระดับพนักงานE"
    Public lblContractE As String = "สัญญาจ้างE"
    Public lblTypeProcessSalaryE As String = "การคิดค่าจ้างE"

    Public lblPersonCode As String = "รหัสพนักงาน"                ' [reference : Personnel][Add on 58-07-27] 
    Public lblAge As String = "อายุ"                             ' [reference : Personnel][Add on 58-07-27] 
    Public lblWorkOld As String = "อายุงาน"                      ' [reference : Personnel][Add on 58-07-27] 
    Public lblSalary As String = "เงินเดือน"                      ' [reference : Personnel][Add on 58-07-27] 
    Public lblStartDate As String = "วันที่เริ่มงาน"                 ' [reference : Personnel][Add on 58-07-27] 
    Public lblIDcard As String = "เลขที่บัตรประชาชน"               ' [reference : Personnel][Add on 58-07-27] 
    Public lblSex As String = "เพศ"                             ' [reference : Personnel][Add on 58-07-27] 
    Public lblAddressAmphur As String = "ที่อยู่ปัจจุบัน(อำเภอ/เขต)"    ' [reference : Personnel][Add on 58-07-27] 
    Public lblAddressProvince As String = "ที่อยู่ปัจจุบัน(จังหวัด)"     ' [reference : Personnel][Add on 58-07-27] 
    Public lblDegree As String = "วุฒิการศึกษา"                    ' [reference : Personnel][Add on 58-07-27] 
    Public lblTypeWorkold As String = "ประเภทอายุงาน"             ' [reference : Personnel][Add on 58-07-27] 
    Public ResignStatus As String = "สถานะพนักงาน"               ' [reference : Personnel][Add on 58-07-27] 

    '-------------------
    Public noCache As Boolean = True
    Public ckdateReport As String = "InitInsert" ' [reference : Personnel][Add on 58-07-27] 
    Public เรียงตามรหัสพนักงาน As String = "เรียงตามรหัสพนักงาน"
    Public ChkShowpic As Boolean = 1       ' เช็คการแสดงรูปพนักงานที่ Treeview
    Public Url As String                   ' เก็บ Url กลางที่ใช้ร่วมกัน Tiger_serviceweb 
    Public Pathweb As String               ' เก็บ path กลางที่ใช้ร่วมกัน Tiger_serviceweb
    Public URL_HRISLogin As String = "http://www.google.co.th"   ' URL หน้า Login ระบบ HRISLogin เพื่อใช้ในการเชื่อมเมนูบน Web
    Public URL_HRISCompany As String = "http://www.google.co.th"   ' URL หน้า Login ระบบ HRISCompany เพื่อใช้ในการเชื่อมเมนูบน Web
    Public URL_HRISPerson As String = "http://www.google.co.th"  ' URL หน้า Login ระบบ HRISPerson เพื่อใช้ในการเชื่อมเมนูบน Web
    Public URL_HRISTime As String = "http://www.google.co.th"    ' URL หน้า Login ระบบ HRISTime เพื่อใช้ในการเชื่อมเมนูบน Web
    Public URL_HRISPayroll As String = "http://www.google.co.th" ' URL หน้า Login ระบบ Payroll เพื่อใช้ในการเชื่อมเมนูบน Web

    '----เก็บฟอร์มการอนุมติ----
    Public ApprovForm As String            ' ชื่อฟอร์ม

    Public WhApproveCmb As String = ""     ' เก็บค่า where หน้าเลือกข้อมูลอนุมัติ

    Public SelectPerson As String = ""     ' เก็บค่าการเลือกพนักงาน


    Public TreeNodeConfig As String = "99" 'สำหรับแสดงข้อความบน Tree -> "0" แสดงเฉพาะชื่อ , "1" แสดงรหัสและชื่อ , "99" ไม่กำหนดตายตัว

    Public Sub New()

    End Sub
End Class

Public Class WebSetting ' referrence by web ka,  Add on 58-07-06

    Dim DA As New Mydata(adoconn)
    Dim DT As DataTable

    Dim _isCompress As Boolean = False
    ''' <summary>
    ''' เปิดการใช้งาน compression (บีบขนาดข้อมูล)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsCompress() As Boolean
        Get
            Return _isCompress
        End Get
    End Property

    Dim _exceptIP As String = ""
    ''' <summary>
    ''' ใส่ ip ภายในสามตำแหน่งแรก เพื่อให้บีบข้อมูลเฉพาะการคุยกับภายนอกเท่านั้น
    ''' </summary>
    ''' <value>192.168.2</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ExceptIP() As String
        Get
            Return _exceptIP.Trim
        End Get
    End Property

    Dim _editKaInDay_ForFuji As Integer = -7
    ''' <summary>
    ''' เป็นค่าติดลบ ตำแหน่ง Supervisor และ manager สามารถแก้ไขกะบนเว็บได้ภายใน กี่วัน นอกนั้นต้อง zone manager แก้ให้
    ''' </summary>
    ''' <value>เป็นค่า ติดลบ เพราะต้องใช้กับ addday</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EditKaInDay_ForFuji() As Integer
        Get
            Return _editKaInDay_ForFuji
        End Get
        Set(ByVal value As Integer)
            _editKaInDay_ForFuji = value
        End Set
    End Property


    ''' <summary>
    ''' 18 พค 2554 คุณเตยขอเพิ่มเคส 3 super/226 manager/ 381 ass. MANAGER /482 ass.super ไม่สามารถแก้ไข/เพิ่ม กะของตัวเองได้
    ''' </summary>
    ''' <value>'Dim StrictPosition$ = "[3][226][482][381]"</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property StrictPosition_ForFuji() As String
        Get
            Return "[3][226][482][381]"
        End Get
    End Property


    Dim _webTrainningURL As String = "http://www.google.co.th"
    ''' <summary>
    ''' CP Url หน้า Login ของ Web Trainning เพื่อใช้ในการ เชื่อมจาก ระบบ Web Person
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property WebTrainningURL() As String
        Get
            Return _webTrainningURL.Trim
        End Get
        Set(ByVal value As String)
            _webTrainningURL = value.Trim
        End Set
    End Property


    Dim _ETDA_URL_WEBPERSON As String = "http://www.google.co.th"
    ''' <summary>
    ''' ETDA Url หน้า Login ของ Web Trainning เพื่อใช้ในการ เชื่อมจาก ระบบ Web Person
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ETDA_URL_WEBPERSON() As String
        Get
            Return _ETDA_URL_WEBPERSON.Trim
        End Get
        Set(ByVal value As String)
            _ETDA_URL_WEBPERSON = value.Trim
        End Set
    End Property


    Dim _ETDA_URL_ESS As String = "http://www.google.co.th"
    ''' <summary>
    ''' ETDA Url หน้า Login ของ Web Trainning เพื่อใช้ในการ เชื่อมจาก ระบบ Web Person
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ETDA_URL_ESS() As String
        Get
            Return _ETDA_URL_ESS.Trim
        End Get
        Set(ByVal value As String)
            _ETDA_URL_ESS = value.Trim
        End Set
    End Property

    Dim _ETDA_URL_TRAINING As String = "http://www.google.co.th"
    ''' <summary>
    ''' ETDA Url หน้า Login ของ Web Trainning เพื่อใช้ในการ เชื่อมจาก ระบบ Web Person
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ETDA_URL_TRAINING() As String
        Get
            Return _ETDA_URL_TRAINING.Trim
        End Get
        Set(ByVal value As String)
            _ETDA_URL_TRAINING = value.Trim
        End Set
    End Property


    Dim _ETDA_URL_FIXASSET As String = "http://www.google.co.th"
    ''' <summary>
    ''' ETDA Url หน้า Login ของ Web Trainning เพื่อใช้ในการ เชื่อมจาก ระบบ Web Person
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ETDA_URL_FIXASSET() As String
        Get
            Return _ETDA_URL_FIXASSET.Trim
        End Get
        Set(ByVal value As String)
            _ETDA_URL_FIXASSET = value.Trim
        End Set
    End Property
    Public Sub New()
        Try
            DT = LoadTableMasterWeb.TAM_ConfigProgramTime
            Dim xml As String = CStr(DT.Rows(0)("WebSetting") & "").Trim
            If xml <> "" Then
                Dim doc = XDocument.Load(New IO.StringReader(xml))
                Dim item = From x In doc...<Web> Select x
                _isCompress = CBool(item(0).Element("IsCompress").Value)
                _exceptIP = item(0).Element("ExceptIP").Value & ""
                Try
                    EditKaInDay_ForFuji = item(0).Element("EditKaInDay_ForFuji").Value
                    EditKaInDay_ForFuji *= -1
                Catch ex As Exception
                End Try

                Try
                    _webTrainningURL = item(0).Element("WebTrainningURL").Value
                Catch ex As Exception
                End Try


                'ETDA------------------
                Try
                    _ETDA_URL_TRAINING = item(0).Element("ETDA_URL_TRAINING").Value
                Catch ex As Exception
                End Try
                Try
                    _ETDA_URL_WEBPERSON = item(0).Element("ETDA_URL_WEBPERSON").Value
                Catch ex As Exception
                End Try
                Try
                    _ETDA_URL_ESS = item(0).Element("ETDA_URL_ESS").Value
                Catch ex As Exception
                End Try
                Try
                    _ETDA_URL_FIXASSET = item(0).Element("ETDA_URL_FIXASSET").Value
                Catch ex As Exception
                End Try


            End If
        Catch ex As Exception
        End Try
    End Sub
End Class