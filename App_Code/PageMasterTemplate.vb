Imports Microsoft.VisualBasic
Imports Telerik.Web.UI

'Public ev1 As New Generic.Dictionary(Of String, FormMasterTable)
Public Class GetMasterData

    'Implements ITemplate
    'Public invoke1 As Func(Of RadGrid, String)
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="xTableName">ชื่อTable เช่น COM_Company</param>
    ''' <param name="xPkID">ชื่อ PK เช่น CompanyID</param>
    ''' <remarks></remarks>
    'Sub New(xTableName$, xPkID$, xFormName$)
    '    PkID = xPkID
    '    TableName = xTableName
    '    FormName = xFormName
    'End Sub

    Public TableName$
    Public PkID$
    Public FormName$
    Public Remark$

    Public Field1$
    Public Field2$
    Public Field3$
    Public Field4$
    Public Field5$
    Public Field6$

    '== สร้างตัวแปรไว้รับค่า True หรือ False ของหน้า Popup เพิ่ม แก้ไข ข้อมูลมาสเตอร์กรณีมีเพิ่มฟิวส์น้อยกว่า 4 ฟิวส์ =='
    Public ReadOnly1 As Boolean = False
    Public ReadOnly2 As Boolean = False
    Public ReadOnly3 As Boolean = False
    Public ReadOnly4 As Boolean = False
    Public ReadOnly5 As Boolean = False
    Public ReadOnly6 As Boolean = False
    '=================================='

    'Public Require1 As Boolean = True
    Public IsRequire2 As Boolean = False
    Public IsRequire3 As Boolean = False
    Public IsRequire4 As Boolean = False
    Public IsRequire5 As Boolean = False
    Public IsRequire6 As Boolean = False

    Public HeaderText1, HeaderText2, HeaderText3, HeaderText4, HeaderText5, HeaderText6 As String

    Public CheckBeforeDeleteTable() As String
    Public CheckBeforeDeleteField() As String


    Public Sub Master_adm_tblLabel()

    End Sub

    Sub MasterSetMemo()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "TAM_memoName"
        GetMasterData.PkID = "SaveMemoID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "รหัสกลุ่มข้อมูล", "Memo ID")

        GetMasterData.Field1 = "NameMemo"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "กลุ่มข้อมูล", "Name Memo")

        GetMasterData.Field2 = ""
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 2 ไม่มี =='
        GetMasterData.ReadOnly2 = True     '

        GetMasterData.Field3 = ""
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True     '

        GetMasterData.Field4 = ""
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True     '


        GetMasterData.CheckBeforeDeleteTable = {"TAP_NoteMemo"}
        GetMasterData.CheckBeforeDeleteField = {"SaveMemoID"}

        
        Sys.ev1.Remove("TAM_memoName")
        If Sys.ev1.ContainsKey("TAM_memoName") = False Then
            Sys.ev1.Add("TAM_memoName", GetMasterData)
        End If
    End Sub


    Sub MasterSetNoteOT()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "TAM_NOTEOT"
        GetMasterData.PkID = "NOTE_OT"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "หมายเหตุ", "Note")

        GetMasterData.Field1 = "NOTE_OT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "หมายเหตุ", "Note")

        GetMasterData.Field2 = ""
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 2 ไม่มี =='
        GetMasterData.ReadOnly2 = True     '

        GetMasterData.Field3 = ""
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True     '

        GetMasterData.Field4 = ""
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True     '

        GetMasterData.Remark = ""

        'Not Used เนื่องจากเป็นแค่ข้้อมูลช่วยเหลือ
        GetMasterData.CheckBeforeDeleteTable = New String() {}
        GetMasterData.CheckBeforeDeleteField = New String() {}

        Sys.ev1.Remove("TAM_NOTEOT")
        If Sys.ev1.ContainsKey("TAM_NOTEOT") = False Then
            Sys.ev1.Add("TAM_NOTEOT", GetMasterData)
        End If
    End Sub


    Sub MasterSetOTSelect()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "TAM_ConfigOT"
        GetMasterData.PkID = "ID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ช่วงเวลาทำงานล่วงเวลา", "OT Select")

        GetMasterData.Field1 = "OTS"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "เริ่มเวลา", "Start Time")

        GetMasterData.Field2 = "OTE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ถึงเวลา", "End Time")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 2 ไม่มี =='
        GetMasterData.ReadOnly2 = False     '

        GetMasterData.Field3 = "Total_"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "รวมเวลา", "Total")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = False     '

        GetMasterData.Field4 = "Note_"
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "หมายเหตุ", "Note")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = False     '

        GetMasterData.Remark = "Ex  08:00 , 17:00 ...  ใส่ : คั่นเวลาด้วย"

        'Not Used เนื่องจากเป็นแค่ข้้อมูลช่วยเหลือ
        GetMasterData.CheckBeforeDeleteTable = New String() {}
        GetMasterData.CheckBeforeDeleteField = New String() {}

        Sys.ev1.Remove("TAM_ConfigOT")
        If Sys.ev1.ContainsKey("TAM_ConfigOT") = False Then
            Sys.ev1.Add("TAM_ConfigOT", GetMasterData)
        End If
    End Sub


    Sub MasterSetHoliday()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "TAM_PlateHoliday"
        GetMasterData.PkID = "ID_PlateHoliday"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "รหัสกลุ่มวันหยุด", "Plate Holiday ID")

        GetMasterData.Field1 = "NamePlateHoliday"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อกลุ่มวันหยุด", "Plate Holiday Name")

        GetMasterData.Field2 = ""
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 2 ไม่มี =='
        GetMasterData.ReadOnly2 = True     '

        GetMasterData.Field3 = ""
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True     '

        GetMasterData.Field4 = ""
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True     '

        GetMasterData.CheckBeforeDeleteTable = {"TAM_Holiday"}
        GetMasterData.CheckBeforeDeleteField = {"ID_PlateHoliday"}

        Sys.ev1.Remove("TAM_PlateHoliday")
        If Sys.ev1.ContainsKey("TAM_PlateHoliday") = False Then
            Sys.ev1.Add("TAM_PlateHoliday", GetMasterData)
        End If
    End Sub


    Sub MasterProvince()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_province"
        GetMasterData.PkID = "ProvID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "จังหวัด", "Province")

        GetMasterData.Field1 = "ProvCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสจังหวัด", "ProvCode")

        GetMasterData.Field2 = "ProveNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อจังหวัด(ไทย)", "Province(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "ProveNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อจังหวัด(อังกฤษ)", "Province(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = "ZoneCode"
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "รหัสภาค", "ZoneCode")
        GetMasterData.IsRequire4 = False

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"CurrentProvince"}

        Sys.ev1.Remove("pnm_province")
        If Sys.ev1.ContainsKey("pnm_province") = False Then
            Sys.ev1.Add("pnm_province", GetMasterData)
        End If
    End Sub

    Sub MasterAmphur()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_amphur"
        GetMasterData.PkID = "AmphurID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "อำเภอ", "Amphur")

        GetMasterData.Field1 = "AmphurCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสอำเภอ", "AmphurCode")

        GetMasterData.Field2 = "AmphurT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่ออำเภอ(ไทย)", "Amphur(Thai)")
        GetMasterData.IsRequire2 = True

        GetMasterData.Field3 = "AmphurE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ชื่ออำเภอ(อังกฤษ)", "Amphur(Eng)")
        GetMasterData.IsRequire3 = False

        GetMasterData.Field4 = "ProvCode"
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "รหัสจังหวัด", "ProvCode")
        GetMasterData.IsRequire4 = False

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"CurrentAmphur"}

        Sys.ev1.Remove("pnm_amphur")
        If Sys.ev1.ContainsKey("pnm_amphur") = False Then
            Sys.ev1.Add("pnm_amphur", GetMasterData)
        End If
    End Sub

    Sub MasterDistrict()
        'FormName = IIf(Sys.LoginWeb.Lang = "T", "ตำบล", "District")
        'Dim famUnit As New FormMasterTable("pnm_district", "DistrictID", FormName)

        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_district"
        GetMasterData.PkID = "DistrictID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ตำบล", "District")

        GetMasterData.Field1 = "DistrictCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสตำบล", "DistrictCode")

        GetMasterData.Field2 = "DistrictT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อตำบล(ไทย)", "District(Thai)")
        GetMasterData.IsRequire2 = True

        GetMasterData.Field3 = "DistrictE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อตำบล(อังกฤษ)", "District(Eng)")
        GetMasterData.IsRequire3 = False

        GetMasterData.Field4 = "AmphurCode"
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "รหัสอำเภอ", "AmphurCode")
        GetMasterData.IsRequire4 = False

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"CurrentDistrict"}

        Sys.ev1.Remove("pnm_district")
        If Sys.ev1.ContainsKey("pnm_district") = False Then
            Sys.ev1.Add("pnm_district", GetMasterData)
        End If
    End Sub

    Public Sub MasterInitial()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_Initial"
        GetMasterData.PkID = "InitialID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "คำนำหน้า", "Initial")

        GetMasterData.Field1 = "InitialCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสคำนำหน้าชื่อ", "InitialCode")

        GetMasterData.Field2 = "InitialT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "คำนำหน้าชื่อ(ไทย)", "Initial(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "InitialE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "คำนำหน้าชื่อ(อังกฤษ)", "Initial(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        GetMasterData.Field5 = "Status"
        GetMasterData.HeaderText5 = IIf(Sys.LoginWeb.Lang = "T", "สถานะใช้งาน", "Status")
        GetMasterData.IsRequire5 = False

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"InitialID"}

        Sys.ev1.Remove("pnm_Initial")
        If Sys.ev1.ContainsKey("pnm_Initial") = False Then
            Sys.ev1.Add("pnm_Initial", GetMasterData)
        End If
    End Sub

    Public Sub MasterCmb1()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb1"
        GetMasterData.PkID = "Cmb1ID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ฝ่าย", "Cmb1")
        GetMasterData.FormName = Sys.LoginWeb.lblCmb1

        GetMasterData.Field1 = "Cmb1Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb1, "Code" & Sys.LoginWeb.lblCmb1)

        GetMasterData.Field2 = "Cmb1NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb1 & "(ไทย)", Sys.LoginWeb.lblCmb1 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb1NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb1 & "(อังกฤษ)", Sys.LoginWeb.lblCmb1 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb1ID"}

        Sys.ev1.Remove("pnm_cmb1")
        If Sys.ev1.ContainsKey("pnm_cmb1") = False Then
            Sys.ev1.Add("pnm_cmb1", GetMasterData)
        End If
    End Sub

    Public Sub MasterCmb2()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb2"
        GetMasterData.PkID = "Cmb2ID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "แผนก", "Cmb2")
        GetMasterData.FormName = Sys.LoginWeb.lblCmb2

        GetMasterData.Field1 = "Cmb2Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb2, "Code" & Sys.LoginWeb.lblCmb2)

        GetMasterData.Field2 = "Cmb2NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb2 & "(ไทย)", Sys.LoginWeb.lblCmb2 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb2NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb2 & "(อังกฤษ)", Sys.LoginWeb.lblCmb2 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        'GetMasterData.Field4 = "Cm1Code"
        'GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb1, "Code" & Sys.LoginWeb.lblCmb1)
        'GetMasterData.IsRequire4 = False

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb2ID"}

        Sys.ev1.Remove("pnm_cmb2")
        If Sys.ev1.ContainsKey("pnm_cmb2") = False Then
            Sys.ev1.Add("pnm_cmb2", GetMasterData)
        End If
    End Sub

    Public Sub MasterCmb3()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb3"
        GetMasterData.PkID = "Cmb3ID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "แผนก", "Cmb3")
        GetMasterData.FormName = Sys.LoginWeb.lblCmb3

        GetMasterData.Field1 = "Cmb3Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb3, "Code" & Sys.LoginWeb.lblCmb3)

        GetMasterData.Field2 = "Cmb3NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb3 & "(ไทย)", Sys.LoginWeb.lblCmb3 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb3NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb3 & "(อังกฤษ)", Sys.LoginWeb.lblCmb3 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb3ID"}

        Sys.ev1.Remove("pnm_cmb3")
        If Sys.ev1.ContainsKey("pnm_cmb3") = False Then
            Sys.ev1.Add("pnm_cmb3", GetMasterData)
        End If
    End Sub

    Sub MasterCmb4()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb4"
        GetMasterData.PkID = "Cmb4ID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สถานที่ทำงาน", "Cmb4")
        GetMasterData.FormName = Sys.LoginWeb.lblCmb4

        GetMasterData.Field1 = "Cmb4Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb4, "Code" & Sys.LoginWeb.lblCmb4)

        GetMasterData.Field2 = "Cmb4NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb4 & "(ไทย)", Sys.LoginWeb.lblCmb4 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb4NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb4 & "(อังกฤษ)", Sys.LoginWeb.lblCmb4 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb4ID"}

        Sys.ev1.Remove("pnm_cmb4")
        If Sys.ev1.ContainsKey("pnm_cmb4") = False Then
            Sys.ev1.Add("pnm_cmb4", GetMasterData)
        End If
    End Sub

    Sub MasterCmb5()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb5"
        GetMasterData.PkID = "Cmb5ID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ขอบเขตการทำงาน", "Cmb5")
        GetMasterData.FormName = Sys.LoginWeb.lblCmb5


        GetMasterData.Field1 = "Cmb5Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb5, "Code" & Sys.LoginWeb.lblCmb5)

        GetMasterData.Field2 = "Cmb5NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb5 & "(ไทย)", Sys.LoginWeb.lblCmb5 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb5NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb5 & "(อังกฤษ)", Sys.LoginWeb.lblCmb5 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb5ID"}

        Sys.ev1.Remove("pnm_cmb5")
        If Sys.ev1.ContainsKey("pnm_cmb5") = False Then
            Sys.ev1.Add("pnm_cmb5", GetMasterData)
        End If
    End Sub

    Sub MasterCmb6()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb6"
        GetMasterData.PkID = "Cmb6ID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สถานะการทำงาน", "Cmb6")
        GetMasterData.FormName = Sys.LoginWeb.lblCmb6

        GetMasterData.Field1 = "Cmb6Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb6, "Code" & Sys.LoginWeb.lblCmb6)


        GetMasterData.Field2 = "Cmb6NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb6 & "(ไทย)", Sys.LoginWeb.lblCmb6 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb6NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb6 & "(อังกฤษ)", Sys.LoginWeb.lblCmb6 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb6ID"}

        Sys.ev1.Remove("pnm_cmb6")
        If Sys.ev1.ContainsKey("pnm_cmb6") = False Then
            Sys.ev1.Add("pnm_cmb6", GetMasterData)
        End If
    End Sub
    Sub MasterCmb7()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb7"
        GetMasterData.PkID = "Cmb7ID"
        GetMasterData.FormName = Sys.LoginWeb.lblCmb7

        GetMasterData.Field1 = "Cmb7Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส" & Sys.LoginWeb.lblCmb7, "Cmb7" & Sys.LoginWeb.lblCmb7)


        GetMasterData.Field2 = "Cmb7NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb7 & "(ไทย)", Sys.LoginWeb.lblCmb7 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb7NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb7 & "(อังกฤษ)", Sys.LoginWeb.lblCmb7 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb7ID"}

        Sys.ev1.Remove("pnm_cmb7")
        If Sys.ev1.ContainsKey("pnm_cmb7") = False Then
            Sys.ev1.Add("pnm_cmb7", GetMasterData)
        End If
    End Sub

    Sub MasterCmb8()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb8"
        GetMasterData.PkID = "Cmb8ID"
        GetMasterData.FormName = Sys.LoginWeb.lblCmb8

        GetMasterData.Field1 = "Cmb8Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "Cmb8" & Sys.LoginWeb.lblCmb8, "Cmb8" & Sys.LoginWeb.lblCmb8)


        GetMasterData.Field2 = "Cmb8NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb8 & "(ไทย)", Sys.LoginWeb.lblCmb8 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb8NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb8 & "(อังกฤษ)", Sys.LoginWeb.lblCmb8 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb8ID"}

        Sys.ev1.Remove("pnm_cmb8")
        If Sys.ev1.ContainsKey("pnm_cmb8") = False Then
            Sys.ev1.Add("pnm_cmb8", GetMasterData)
        End If

    End Sub

    Sub MasterCmb9()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb9"
        GetMasterData.PkID = "Cmb9ID"
        GetMasterData.FormName = Sys.LoginWeb.lblCmb9

        GetMasterData.Field1 = "Cmb9Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "Cmb9" & Sys.LoginWeb.lblCmb9, "Cmb9" & Sys.LoginWeb.lblCmb9)


        GetMasterData.Field2 = "Cmb9NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb9 & "(ไทย)", Sys.LoginWeb.lblCmb9 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb9NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb9 & "(อังกฤษ)", Sys.LoginWeb.lblCmb9 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb9ID"}

        Sys.ev1.Remove("pnm_cmb9")
        If Sys.ev1.ContainsKey("pnm_cmb9") = False Then
            Sys.ev1.Add("pnm_cmb9", GetMasterData)
        End If

    End Sub
    Sub MasterCmb10()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_cmb10"
        GetMasterData.PkID = "Cmb10ID"
        GetMasterData.FormName = Sys.LoginWeb.lblCmb10

        GetMasterData.Field1 = "Cmb10Code"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "Cmb10" & Sys.LoginWeb.lblCmb10, "Cmb10" & Sys.LoginWeb.lblCmb10)


        GetMasterData.Field2 = "Cmb10NameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb10 & "(ไทย)", Sys.LoginWeb.lblCmb10 & "(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "Cmb10NameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", Sys.LoginWeb.lblCmb10 & "(อังกฤษ)", Sys.LoginWeb.lblCmb10 & "(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"Cmb10ID"}

        Sys.ev1.Remove("pnm_cmb10")
        If Sys.ev1.ContainsKey("pnm_cmb10") = False Then
            Sys.ev1.Add("pnm_cmb10", GetMasterData)
        End If

    End Sub
    Sub MasterPosition()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_position"
        GetMasterData.PkID = "PositionID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ตำแหน่ง", "position")
        GetMasterData.FormName = Sys.LoginWeb.lblPosition

        GetMasterData.Field1 = "PositionCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสตำแหน่ง", "PositionCode")

        GetMasterData.Field2 = "PositionNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ตำแหน่ง(ไทย)", "Position(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "PositionNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ตำแหน่ง(อังกฤษ)", "Position(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = False

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"PositionID"}

        Sys.ev1.Remove("pnm_position")
        If Sys.ev1.ContainsKey("pnm_position") = False Then
            Sys.ev1.Add("pnm_position", GetMasterData)
        End If
    End Sub
    Sub MasterPositionWorkHis()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_position_workhis"
        GetMasterData.PkID = "PosWorkHisID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ตำแหน่ง", "position")
        GetMasterData.FormName = Sys.LoginWeb.lblPosition

        GetMasterData.Field1 = "PosWorkHisCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสตำแหน่ง", "PositionCode")

        GetMasterData.Field2 = "PosWorkHisNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ตำแหน่ง(ไทย)", "Position(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "PosWorkHisNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ตำแหน่ง(อังกฤษ)", "Position(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = False

        GetMasterData.CheckBeforeDeleteTable = {"pnt_workhistory"}
        GetMasterData.CheckBeforeDeleteField = {"PosWorkHisID"}

        Sys.ev1.Remove("pnm_position_workhis")
        If Sys.ev1.ContainsKey("pnm_position_workhis") = False Then
            Sys.ev1.Add("pnm_position_workhis", GetMasterData)
        End If
    End Sub

    Sub MasterEmpType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_emptype"
        GetMasterData.PkID = "EmpTypeID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทพนักงาน", "EmpTypeCode")
        GetMasterData.FormName = Sys.LoginWeb.lblEmpType

        GetMasterData.Field1 = "EmpTypeCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสประเภทพนักงาน", "EmpTypeCode")

        GetMasterData.Field2 = "EmpTypeNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทพนักงาน(ไทย)", "EmpType(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "EmpTypeNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทพนักงาน(อังกฤษ)", "EmpType(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"EmpTypeID"}

        Sys.ev1.Remove("pnm_emptype")
        If Sys.ev1.ContainsKey("pnm_emptype") = False Then
            Sys.ev1.Add("pnm_emptype", GetMasterData)
        End If
    End Sub


    Sub MasterLevel()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_level"
        GetMasterData.PkID = "LevelID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ระดับพนักงาน", "Level")
        GetMasterData.FormName = Sys.LoginWeb.lblLevel

        GetMasterData.Field1 = "LevelCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสระดับพนักงาน", "LevelCode")

        GetMasterData.Field2 = "LevelT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ระดับพนักงาน(ไทย)", "Level(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "LevelE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ระดับพนักงาน(อังกฤษ)", "Level(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"EmpTypeID"}

        Sys.ev1.Remove("pnm_level")
        If Sys.ev1.ContainsKey("pnm_level") = False Then
            Sys.ev1.Add("pnm_level", GetMasterData)
        End If
    End Sub

    Sub MasterJG()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_jg"
        GetMasterData.PkID = "JGID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "JGID", "JG")

        GetMasterData.Field1 = "JGCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสระดับ JG", "JGCode")

        GetMasterData.Field2 = "JGNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "JG(ไทย)", "JG(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "JGNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "JG(อังกฤษ)", "JG(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"JGID"}

        Sys.ev1.Remove("pnm_jg")
        If Sys.ev1.ContainsKey("pnm_jg") = False Then
            Sys.ev1.Add("pnm_jg", GetMasterData)
        End If
    End Sub

    Sub MasterHospital()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_hospital"
        GetMasterData.PkID = "HospitalID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "รพ.", "hospital")

        GetMasterData.Field1 = "HospitalCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส รพ.", "hospitalCode")

        GetMasterData.Field2 = "HospitalNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อ รพ.(ไทย)", "hospital(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "HospitalNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อ รพ.(อังกฤษ)", "hospital(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"HospitalID"}

        Sys.ev1.Remove("pnm_hospital")
        If Sys.ev1.ContainsKey("pnm_hospital") = False Then
            Sys.ev1.Add("pnm_hospital", GetMasterData)
        End If
    End Sub

    Sub MasterContract()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_contract"
        GetMasterData.PkID = "ContractID"
        'GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สัญญาจ้าง", "Contract")
        GetMasterData.FormName = Sys.LoginWeb.lblContract

        GetMasterData.Field1 = "ContractT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทสัญญา(ไทย)", "Contract(Thai)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field2 = "ContractE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทสัญญา(อังกฤษ)", "ContractT(Eng)")
        GetMasterData.IsRequire2 = False     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = ""
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"pnt_person"}
        GetMasterData.CheckBeforeDeleteField = {"ContractID"}

        Sys.ev1.Remove("pnm_contract")
        If Sys.ev1.ContainsKey("pnm_contract") = False Then
            Sys.ev1.Add("pnm_contract", GetMasterData)
        End If


    End Sub


    Sub MasterRace()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_citizen"
        GetMasterData.PkID = "CitizenID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "เชื้อชาติ", "Citizen")

        GetMasterData.Field1 = "CitizenNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "เชื้อชาติ(ไทย)", "Citizen(Thai)")

        GetMasterData.Field2 = "CitizenNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "เชื้อชาติ(อังกฤษ)", "Citizen(Eng)")
        GetMasterData.IsRequire2 = False     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = ""
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonDetail"}
        GetMasterData.CheckBeforeDeleteField = {"CitizenID"}

        Sys.ev1.Remove("pnm_citizen")
        If Sys.ev1.ContainsKey("pnm_citizen") = False Then
            Sys.ev1.Add("pnm_citizen", GetMasterData)
        End If
    End Sub

    Sub MasterNationality()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_nationality"
        GetMasterData.PkID = "NationalityID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเทศ", "Nationality")

        GetMasterData.Field1 = "NationalityCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสประเทศ", "Nationality Code")

        GetMasterData.Field2 = "NationalityNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเทศ(ไทย)", "Nationality(Thai)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = "NationalityNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ประเทศ(อังกฤษ)", "Nationality(Eng)")
        GetMasterData.IsRequire2 = False     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonDetail"}
        GetMasterData.CheckBeforeDeleteField = {"NationalityID"}

        Sys.ev1.Remove("pnm_nationality")
        If Sys.ev1.ContainsKey("pnm_nationality") = False Then
            Sys.ev1.Add("pnm_nationality", GetMasterData)
        End If
    End Sub


    Sub MasterReligion()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_religion"
        GetMasterData.PkID = "ReligionID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ศาสนา", "Religion")

        GetMasterData.Field1 = "ReligionNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ศาสนา(ไทย)", "Religion(Thai)")

        GetMasterData.Field2 = "ReligionNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ศาสนา(อังกฤษ)", "Religion(Eng)")
        GetMasterData.IsRequire2 = False     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonDetail"}
        GetMasterData.CheckBeforeDeleteField = {"ReligionID"}

        Sys.ev1.Remove("pnm_religion")
        If Sys.ev1.ContainsKey("pnm_religion") = False Then
            Sys.ev1.Add("pnm_religion", GetMasterData)
        End If
    End Sub

    Sub MasterBlood()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_blood"
        GetMasterData.PkID = "BloodID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "กรุ๊ปเลือด", "Blood")

        GetMasterData.Field1 = "BloodType"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "กรุ๊ปเลือด", "blood")

        GetMasterData.Field2 = ""  'หมายความว่า ไม่มี ช่องที่ 2
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 2 ไม่มี =='
        GetMasterData.ReadOnly2 = True

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonDetail"}
        GetMasterData.CheckBeforeDeleteField = {"BloodID"}

        Sys.ev1.Remove("pnm_blood")
        If Sys.ev1.ContainsKey("pnm_blood") = False Then
            Sys.ev1.Add("pnm_blood", GetMasterData)
        End If
    End Sub

    Sub MasterStatusMilitary()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_military"
        GetMasterData.PkID = "MilitaryID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สถานะทางทหาร", "StatusMilitary")

        GetMasterData.Field1 = "MilitaryStatusT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "สถานะภาพทางทหาร(ไทย)", "StatusMilitary(Thai)")

        GetMasterData.Field2 = "MilitaryStatusE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "สถานะภาพทางทหาร(อังกฤษ)", "StatusMilitary(Eng)")

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonDetail"}
        GetMasterData.CheckBeforeDeleteField = {"MilitaryID"}

        Sys.ev1.Remove("pnm_military")
        If Sys.ev1.ContainsKey("pnm_military") = False Then
            Sys.ev1.Add("pnm_military", GetMasterData)
        End If
    End Sub

    Sub MasterZone()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_zone"
        GetMasterData.PkID = "ZoneID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ภูมิภาค", "Zone")

        GetMasterData.Field1 = "ZoneCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสภูมิภาค", "ZoneCode")

        GetMasterData.Field2 = "ZoneNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อภูมิภาค(ไทย)", "Zone(Thai)")
        GetMasterData.IsRequire2 = True     'เช็คไม่ให้เกิดค่าว่าง

        GetMasterData.Field3 = "ZoneNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อภูมิภาค(อังกฤษ)", "Zone(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = "NationalityCode"
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "รหัสประเทศ", "NationalityCode")
        GetMasterData.IsRequire4 = False

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonDetail"}
        GetMasterData.CheckBeforeDeleteField = {"CurrentZone"}

        Sys.ev1.Remove("pnm_zone")
        If Sys.ev1.ContainsKey("pnm_zone") = False Then
            Sys.ev1.Add("pnm_zone", GetMasterData)
        End If
    End Sub

    Sub MasterZipcode()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_zipcode"
        GetMasterData.PkID = "ZipcodeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "รหัสไปรษณีย์", "Zipcode")

        GetMasterData.Field1 = "DistrictCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสตำบล", "DistrictCode")

        GetMasterData.Field2 = "ZipcodeCode"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "รหัสไปรษณีย์", "รหัสไปรษณีย์")

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonDetail"}
        GetMasterData.CheckBeforeDeleteField = {"MilitaryID"}

        Sys.ev1.Remove("pnm_zipcode")
        If Sys.ev1.ContainsKey("pnm_zipcode") = False Then
            Sys.ev1.Add("pnm_zipcode", GetMasterData)
        End If
    End Sub

    Sub MasterOccupation()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_occupation"
        GetMasterData.PkID = "OccupationID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "อาชีพ", "Occupation")

        GetMasterData.Field1 = "OccupationT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ชื่ออาชีพ(ไทย)", "Occupation(Thai)")

        GetMasterData.Field2 = "OccupationE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่ออาชีพ(อังกฤษ)", "Occupation(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Person"}
        GetMasterData.CheckBeforeDeleteField = {"FatherOccupation"}

        Sys.ev1.Remove("pnm_occupation")
        If Sys.ev1.ContainsKey("pnm_occupation") = False Then
            Sys.ev1.Add("pnm_occupation", GetMasterData)
        End If
    End Sub

    Sub MasterReSkillComputer()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "re_skillcomputer"
        GetMasterData.PkID = "SkillComID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ชื่อประเภทความสามารถทางคอมพิวเตอร์", "SkillComputer")

        GetMasterData.Field1 = "SkillComNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อประเภทความสามารถทางคอมพิวเตอร์(ไทย)", "SkillComputer(Thai)")

        GetMasterData.Field2 = "SkillComNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อประเภทความสามารถทางคอมพิวเตอร์(อังกฤษ)", "SkillComputer(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_SkillComputer"}
        GetMasterData.CheckBeforeDeleteField = {"SkillComID"}

        Sys.ev1.Remove("re_skillcomputer")
        If Sys.ev1.ContainsKey("re_skillcomputer") = False Then
            Sys.ev1.Add("re_skillcomputer", GetMasterData)
        End If
    End Sub
    Sub MasterSkillAdvance()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "re_skillspecifition"
        GetMasterData.PkID = "SkillSpecID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความสามารถพิเศษ", "SkillSpec")

        GetMasterData.Field1 = "SkillSpecNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความสามารถพิเศษ(ไทย)", "SkillSpec(Thai)")

        GetMasterData.Field2 = "SkiillSpecNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความสามารถพิเศษ(อังกฤษ)", "SkillSpec(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_SkillAdvance"}
        GetMasterData.CheckBeforeDeleteField = {"SkillSpecID"}

        Sys.ev1.Remove("re_skillspecifition")
        If Sys.ev1.ContainsKey("re_skillspecifition") = False Then
            Sys.ev1.Add("re_skillspecifition", GetMasterData)
        End If
    End Sub
    Sub MasterLanguage()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_language"
        GetMasterData.PkID = "LanguageID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ภาษา", "Language")

        GetMasterData.Field1 = "LangNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ภาษา(ไทย)", "Language(Thai)")

        GetMasterData.Field2 = "LangNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ภาษา(อังกฤษ)", "Language(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_LanguageSkill"}
        GetMasterData.CheckBeforeDeleteField = {"LanguageID"}

        Sys.ev1.Remove("pnm_language")
        If Sys.ev1.ContainsKey("pnm_language") = False Then
            Sys.ev1.Add("pnm_language", GetMasterData)
        End If
    End Sub
    Sub MasterSkillLevel()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_skilllevel"
        GetMasterData.PkID = "SkillLevelID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ทักษะภาษา", "SkillLevel")

        GetMasterData.Field1 = "SkillLevelT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ทักษะภาษา(ไทย)", "SkillLevel(Thai)")

        GetMasterData.Field2 = "SkillLevelE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ทักษะภาษา(อังกฤษ)", "SkillLevel(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_LanguageSkill"}
        GetMasterData.CheckBeforeDeleteField = {"LangID"}

        Sys.ev1.Remove("pnm_skilllevel")
        If Sys.ev1.ContainsKey("pnm_skilllevel") = False Then
            Sys.ev1.Add("pnm_skilllevel", GetMasterData)
        End If
    End Sub

    Sub MasterBureaucrat()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_bureaucrat"
        GetMasterData.PkID = "BureID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทข้าราชการ", "Bureaucrat")

        GetMasterData.Field1 = "BureT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทข้าราชการ(ไทย)", "Bureaucrat(Thai)")

        GetMasterData.Field2 = "BureE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทข้าราชการ(อังกฤษ)", "Bureaucrat(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Person"}
        GetMasterData.CheckBeforeDeleteField = {"BureID"}

        Sys.ev1.Remove("pnm_bureaucrat")
        If Sys.ev1.ContainsKey("pnm_bureaucrat") = False Then
            Sys.ev1.Add("pnm_bureaucrat", GetMasterData)
        End If
    End Sub

    Sub MasterMedal()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_medal"
        GetMasterData.PkID = "MedalID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ชื่อเครื่องราชฯ", "Medal")

        GetMasterData.Field1 = "MedalT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อเครื่องราชฯ(ไทย)", "Medal(Thai)")

        GetMasterData.Field2 = "MedalE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อเครื่องราชฯ(อังกฤษ)", "Medal(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_PersonMedal"}
        GetMasterData.CheckBeforeDeleteField = {"MedalID"}

        Sys.ev1.Remove("pnm_medal")
        If Sys.ev1.ContainsKey("pnm_medal") = False Then
            Sys.ev1.Add("pnm_medal", GetMasterData)
        End If
    End Sub

    Sub MasterBranchBank()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "prm_branchbank"
        GetMasterData.PkID = "BranchBankID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สาขาธนาคาร", "BranchBank")

        GetMasterData.Field1 = "BranchBankNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "สาขาธนาคาร(ไทย)", "BranchBank(Thai)")

        GetMasterData.Field2 = "BranchBankNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "สาขาธนาคาร(อังกฤษ)", "BranchBank(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PRT_DataPay"}
        GetMasterData.CheckBeforeDeleteField = {"BranchBankID"}

        Sys.ev1.Remove("prm_branchbank")
        If Sys.ev1.ContainsKey("prm_branchbank") = False Then
            Sys.ev1.Add("prm_branchbank", GetMasterData)
        End If
    End Sub

    Sub MasterDegree()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_degree"
        GetMasterData.PkID = "DegreeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "วุฒิการศึกษา", "Degree")

        GetMasterData.Field1 = "DegreeT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "วุฒิการศึกษา(ไทย)", "Degree(Thai)")

        GetMasterData.Field2 = "DegreeE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "วุฒิการศึกษา(อังกฤษ)", "Degree(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Education"}
        GetMasterData.CheckBeforeDeleteField = {"DegreeID"}

        Sys.ev1.Remove("pnm_degree")
        If Sys.ev1.ContainsKey("pnm_degree") = False Then
            Sys.ev1.Add("pnm_degree", GetMasterData)
        End If
    End Sub
    Sub MasterMajor()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_major"
        GetMasterData.PkID = "MajorID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สาขา", "Major")

        GetMasterData.Field1 = "MajorT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "สาขา(ไทย)", "Major(Thai)")

        GetMasterData.Field2 = "MajorE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "สาขา(อังกฤษ)", "Major(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Education"}
        GetMasterData.CheckBeforeDeleteField = {"MajorID"}

        Sys.ev1.Remove("pnm_major")
        If Sys.ev1.ContainsKey("pnm_major") = False Then
            Sys.ev1.Add("pnm_major", GetMasterData)
        End If
    End Sub

    Sub MasterInstitute()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_institute"
        GetMasterData.PkID = "InstituteID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สถาบัน", "Institute")

        GetMasterData.Field1 = "InstituteNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "สถาบัน(ไทย)", "Institute(Thai)")

        GetMasterData.Field2 = "InstituteNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "สถาบัน(อังกฤษ)", "Institute(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Education"}
        GetMasterData.CheckBeforeDeleteField = {"InstituteID"}

        Sys.ev1.Remove("pnm_institute")
        If Sys.ev1.ContainsKey("pnm_institute") = False Then
            Sys.ev1.Add("pnm_institute", GetMasterData)
        End If
    End Sub

    Sub MasterResignType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_resigntype"
        GetMasterData.PkID = "ResignTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทการลาออก", "ResignType")

        GetMasterData.Field1 = "ResignT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทการลาออก(ไทย)", "ResignType(Thai)")

        GetMasterData.Field2 = "ResignE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทการลาออก(อังกฤษ)", "ResignType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Resign"}
        GetMasterData.CheckBeforeDeleteField = {"ResignTypeID"}

        Sys.ev1.Remove("pnm_resigntype")
        If Sys.ev1.ContainsKey("pnm_resigntype") = False Then
            Sys.ev1.Add("pnm_resigntype", GetMasterData)
        End If
    End Sub

    Sub MasterMResign()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_mresign"
        GetMasterData.PkID = "MResignID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "สาเหตุการลาออก", "MResignType")

        GetMasterData.Field1 = "MResignT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "สาเหตุการลาออก(ไทย)", "MResignType(Thai)")

        GetMasterData.Field2 = "MResignE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "สาเหตุการลาออก(อังกฤษ)", "MResignType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Resign"}
        GetMasterData.CheckBeforeDeleteField = {"MResignID"}

        Sys.ev1.Remove("pnm_mresign")
        If Sys.ev1.ContainsKey("pnm_mresign") = False Then
            Sys.ev1.Add("pnm_mresign", GetMasterData)
        End If
    End Sub
    ''' ประเภทข้อมูล ในหน้าประวัติเพิ่มเติม
    Sub MasterMemoType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_memotype"
        GetMasterData.PkID = "MemoTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทข้อมูล", "MemoType")

        GetMasterData.Field1 = "MemoT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทข้อมูล(ไทย)", "MemoType(Thai)")

        GetMasterData.Field2 = "MemoE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทข้อมูล(อังกฤษ)", "MemoType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_MemoType"}
        GetMasterData.CheckBeforeDeleteField = {"MemoTypeID"}

        Sys.ev1.Remove("pnm_memotype")
        If Sys.ev1.ContainsKey("pnm_memotype") = False Then
            Sys.ev1.Add("pnm_memotype", GetMasterData)
        End If
    End Sub

    ''' <summary>
    ''' มาสเตอร์ที่ใช้หน้าประวัติการตรวจสุภาพ
    ''' </summary>
    ''' <remarks></remarks>
    Sub MasterHealthType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_healthtype"
        GetMasterData.PkID = "HealthTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทการตรวจ", "HealthType")

        GetMasterData.Field1 = "HealthTypeT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทการตรวจ(ไทย)", "HealthType(Thai)")

        GetMasterData.Field2 = "HealthTypeE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทการตรวจ(อังกฤษ)", "HealthType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_HealthType"}
        GetMasterData.CheckBeforeDeleteField = {"HealthTypeID"}

        Sys.ev1.Remove("pnm_healthtype")
        If Sys.ev1.ContainsKey("pnm_healthtype") = False Then
            Sys.ev1.Add("pnm_healthtype", GetMasterData)
        End If
    End Sub

    Sub MasterHealthResult()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_healthresult"
        GetMasterData.PkID = "HealthResultID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ผลการตรวจ", "HealthType")

        GetMasterData.Field1 = "HealthResultT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ผลการตรวจ(ไทย)", "HealthType(Thai)")

        GetMasterData.Field2 = "HealthResultE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ผลการตรวจ(อังกฤษ)", "HealthType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_HealthResult"}
        GetMasterData.CheckBeforeDeleteField = {"HealthTypeID"}

        Sys.ev1.Remove("pnm_healthresult")
        If Sys.ev1.ContainsKey("pnm_healthresult") = False Then
            Sys.ev1.Add("pnm_healthresult", GetMasterData)
        End If
    End Sub

    'มาสเตอร์ที่ใช้หน้าประวัติอาชญากรรม
    Sub MasterCrimeType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_crimetype"
        GetMasterData.PkID = "CrimeTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความผิด", "CrimeType")

        GetMasterData.Field1 = "CrimeTypeT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความผิด(ไทย)", "CrimeType(Thai)")

        GetMasterData.Field2 = "CrimeTypeE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความผิด(อังกฤษ)", "CrimeType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_CrimeType"}
        GetMasterData.CheckBeforeDeleteField = {"CrimeTypeID"}

        Sys.ev1.Remove("pnm_crimetype")
        If Sys.ev1.ContainsKey("pnm_crimetype") = False Then
            Sys.ev1.Add("pnm_crimetype", GetMasterData)
        End If
    End Sub

    '20150416 มาสเตอร์ที่ใช้ในหน้าประวัติการฝึกอบรม 
    Sub MasterTrainingType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_trainingtype"
        GetMasterData.PkID = "TrainID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อการอบรม", "TrainingType")

        GetMasterData.Field1 = "TrainT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อการอบรม(ไทย)", "TrainingType(Thai)")

        GetMasterData.Field2 = "TrainE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อการอบรม(อังกฤษ)", "TrainingType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_TrainingType"}
        GetMasterData.CheckBeforeDeleteField = {"TrainID"}

        Sys.ev1.Remove("pnm_trainingtype")
        If Sys.ev1.ContainsKey("pnm_trainingtype") = False Then
            Sys.ev1.Add("pnm_trainingtype", GetMasterData)
        End If
    End Sub

    '20150512 มาสเตอร์ที่ใช้เก็บข้อมูลประเภทใบอนุญาตประกอบวิชาชีพ 
    Sub MasterCerType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_certype"
        GetMasterData.PkID = "CerTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทใบอนุญาต", "CerType")

        GetMasterData.Field1 = "CerTypeT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทใบอนุญาต(ไทย)", "CerType(Thai)")

        GetMasterData.Field2 = "CerTypeE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทใบอนุญาต(อังกฤษ)", "CerType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_CerType"}
        GetMasterData.CheckBeforeDeleteField = {"CerTypeID"}

        Sys.ev1.Remove("pnm_certype")
        If Sys.ev1.ContainsKey("pnm_certype") = False Then
            Sys.ev1.Add("pnm_certype", GetMasterData)
        End If
    End Sub

    Sub MasterProperty()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_property"
        GetMasterData.PkID = "PropertyID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทวงเงินการเบิก", "CerType")

        GetMasterData.Field1 = "PropertyT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทวงเงินการเบิก(ไทย)", "CerType(Thai)")

        GetMasterData.Field2 = "PropertyE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทวงเงินการเบิก(อังกฤษ)", "CerType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = "PropertyO"  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทวงเงินการเบิก(อังกฤษ)", "CerType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_WelfareType"}
        GetMasterData.CheckBeforeDeleteField = {"PropertyID"}

        Sys.ev1.Remove("pnm_property")
        If Sys.ev1.ContainsKey("pnm_property") = False Then
            Sys.ev1.Add("pnm_property", GetMasterData)
        End If
    End Sub

    Sub MasterWelfareAgency()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_welfare_agency"
        GetMasterData.PkID = "AgencyID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "หน่วยงาน/ภาคส่วน", "Welfare Agency")

        GetMasterData.Field1 = "AgencyNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "หน่วยงาน/ภาคส่วน(ไทย)", "Welfare Agency(Thai)")

        GetMasterData.Field2 = "AgencyNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "หน่วยงาน/ภาคส่วน(อังกฤษ)", "Welfare Agency(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Welfare"}
        GetMasterData.CheckBeforeDeleteField = {"AgencyID"}

        Sys.ev1.Remove("pnm_welfare_agency")
        If Sys.ev1.ContainsKey("pnm_welfare_agency") = False Then
            Sys.ev1.Add("pnm_welfare_agency", GetMasterData)
        End If
    End Sub

    ''' ประเภทอุบัติเหตุ 
    Sub MasterAccType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_acctype"
        GetMasterData.PkID = "AccTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทอุบัติเหตุ", "AccType")

        GetMasterData.Field1 = "AcctypeT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทอุบัติเหตุ(ไทย)", "AccType(Thai)")

        GetMasterData.Field2 = "AcctypeE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทอุบัติเหตุ(อังกฤษ)", "AccType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Accident"}
        GetMasterData.CheckBeforeDeleteField = {"AccTypeID"}

        Sys.ev1.Remove("pnm_acctype")
        If Sys.ev1.ContainsKey("pnm_acctype") = False Then
            Sys.ev1.Add("pnm_acctype", GetMasterData)
        End If
    End Sub

    ''' ส่วนของร่างกาย 
    Sub MasterBodyPart()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_bodypart"
        GetMasterData.PkID = "PartID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ส่วนของร่างกาย", "BodyPart")

        GetMasterData.Field1 = "PartT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ส่วนของร่างกาย(ไทย)", "BodyPart(Thai)")

        GetMasterData.Field2 = "PartE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ส่วนของร่างกาย(อังกฤษ)", "BodyPart(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_AccPart"}
        GetMasterData.CheckBeforeDeleteField = {"PartID"}

        Sys.ev1.Remove("pnm_bodypart")
        If Sys.ev1.ContainsKey("pnm_bodypart") = False Then
            Sys.ev1.Add("pnm_bodypart", GetMasterData)
        End If
    End Sub
    ''' ประเภทความประพฤติ
    Sub MasterBehaveType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_behavetype"
        GetMasterData.PkID = "BehaveTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความประพฤติ", "BehaveType")

        GetMasterData.Field1 = "BehaveNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความประพฤติ(ไทย)", "BehaveType(Thai)")

        GetMasterData.Field2 = "BehaveNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ประเภทความประพฤติ(อังกฤษ)", "BehaveType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Behave"}
        GetMasterData.CheckBeforeDeleteField = {"BehaveTypeID"}

        Sys.ev1.Remove("pnm_behavetype")
        If Sys.ev1.ContainsKey("pnm_behavetype") = False Then
            Sys.ev1.Add("pnm_behavetype", GetMasterData)
        End If
    End Sub

    ''' หัวข้อความประพฤติ
    Sub MasterBehaveDetail()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_behavedetail"
        GetMasterData.PkID = "BehaveDetailID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อความประพฤติ", "BehaveDetail")

        GetMasterData.Field1 = "BehaveDetailT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อความประพฤติ(ไทย)", "BehaveDetail(Thai)")

        GetMasterData.Field2 = "BehaveDetailE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อความประพฤติ(อังกฤษ)", "BehaveDetail(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Behave"}
        GetMasterData.CheckBeforeDeleteField = {"BehaveDetailID"}

        Sys.ev1.Remove("pnm_behavedetail")
        If Sys.ev1.ContainsKey("pnm_behavedetail") = False Then
            Sys.ev1.Add("pnm_behavedetail", GetMasterData)
        End If
    End Sub

    ''' หมวดความประพฤติ
    Sub MasterBehaveCategory()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_behave_category"
        GetMasterData.PkID = "BehaveCategoryID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "หมวดความประพฤติ", "Behave Category")

        GetMasterData.Field1 = "BehaveCategoryNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "หมวดความประพฤติ(ไทย)", "Behave Category(Thai)")

        GetMasterData.Field2 = "BehaveCategoryNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "หมวดความประพฤติ(อังกฤษ)", "Behave Category(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Behave"}
        GetMasterData.CheckBeforeDeleteField = {"BehaveCategoryID"}

        Sys.ev1.Remove("pnm_behave_category")
        If Sys.ev1.ContainsKey("pnm_behave_category") = False Then
            Sys.ev1.Add("pnm_behave_category", GetMasterData)
        End If
    End Sub

    ''' เรื่องความประพฤติ
    Sub MasterBehaveTitle()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_behavetitle"
        GetMasterData.PkID = "BehaveTitleID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "เรื่องความประพฤติ", "Behave Title")

        GetMasterData.Field1 = "BehaveTitleNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "เรื่องความประพฤติ(ไทย)", "Behave Title(Thai)")

        GetMasterData.Field2 = "BehaveTitleNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "เรื่องความประพฤติ(อังกฤษ)", "Behave Title(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Behave"}
        GetMasterData.CheckBeforeDeleteField = {"BehaveTitleID"}

        Sys.ev1.Remove("pnm_behavetitle")
        If Sys.ev1.ContainsKey("pnm_behavetitle") = False Then
            Sys.ev1.Add("pnm_behavetitle", GetMasterData)
        End If
    End Sub

    ''' บทลงโทษความประพฤติ
    Sub MasterBehaveNote()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_behavenote"
        GetMasterData.PkID = "BehaveNoteID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "บทลงโทษความประพฤติ", "Behave Note")

        GetMasterData.Field1 = "BehaveNoteNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "บทลงโทษความประพฤติ(ไทย)", "Behave Note(Thai)")

        GetMasterData.Field2 = "BehaveNoteNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "บทลงโทษความประพฤติ(อังกฤษ)", "Behave Note(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_Behave"}
        GetMasterData.CheckBeforeDeleteField = {"BehaveNoteID"}

        Sys.ev1.Remove("pnm_behavenote")
        If Sys.ev1.ContainsKey("pnm_behavenote") = False Then
            Sys.ev1.Add("pnm_behavenote", GetMasterData)
        End If
    End Sub

    ''' หัวข้อการกระทำความผิด
    Sub MasterBlackListSubject()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_blacklistsubject"
        GetMasterData.PkID = "BlackListSubjectID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อการกระทำความผิด", "BlackListSubject")

        GetMasterData.Field1 = "BlackListSubjectNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อ(ไทย)", "BlackListSubject(Thai)")

        GetMasterData.Field2 = "BlackListSubjectNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "หัวข้อ(อังกฤษ)", "BlackListSubject(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNT_BlackList"}
        GetMasterData.CheckBeforeDeleteField = {"BlackListSubjectID"}

        Sys.ev1.Remove("pnm_blacklistsubject")
        If Sys.ev1.ContainsKey("pnm_blacklistsubject") = False Then
            Sys.ev1.Add("pnm_blacklistsubject", GetMasterData)
        End If
    End Sub

    ''' ประเภทข้อมูล ในหน้าประวัติคนพิการ
    Sub MasterCrippleType()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "pnm_crippletype"
        GetMasterData.PkID = "CrippleTypeID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ลักษณะความพิการ", "CrippleType")

        GetMasterData.Field1 = "CrippleTypeNameT"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "ลักษณะความพิการ(ไทย)", "CrippleType(Thai)")

        GetMasterData.Field2 = "CrippleTypeNameE"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ลักษณะความพิการ(อังกฤษ)", "CrippleType(Eng)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "", "")

        '== ส่งค่า True กรณีที่ฟิวส์ที่ 3 ไม่มี =='
        GetMasterData.ReadOnly3 = True

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PNM_CrippleType"}
        GetMasterData.CheckBeforeDeleteField = {"CrippleTypeID"}

        Sys.ev1.Remove("pnm_crippletype")
        If Sys.ev1.ContainsKey("pnm_crippletype") = False Then
            Sys.ev1.Add("pnm_crippletype", GetMasterData)
        End If
    End Sub
    '== ประเภทกองทุน =='
    Sub MasterBranchPF()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "prm_branchpf"
        GetMasterData.PkID = "BranchPFID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "ประเภทกองทุน", "BranchPF")

        GetMasterData.Field1 = "BranchPFID"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัส", "BranchPF(Code)")

        GetMasterData.Field2 = "BranchPFNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อ(ไทย)", "BranchPF(Thai)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = "BranchPFNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "ชื่อ(อังกฤษ)", "BranchPF(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PRT_DataPay"}
        GetMasterData.CheckBeforeDeleteField = {"BranchPFID"}

        Sys.ev1.Remove("prm_branchpf")
        If Sys.ev1.ContainsKey("prm_branchpf") = False Then
            Sys.ev1.Add("prm_branchpf", GetMasterData)
        End If
    End Sub

    '== กลุ่มค่าใช้จ่าย =='
    Sub MasterCostCenter()
        Dim GetMasterData = New GetMasterData()

        GetMasterData.TableName = "prm_costcenter"
        GetMasterData.PkID = "CostCenterID"
        GetMasterData.FormName = IIf(Sys.LoginWeb.Lang = "T", "กลุ่มค่าใช้จ่าย", "CostCenter")

        GetMasterData.Field1 = "CostCenterCode"
        GetMasterData.HeaderText1 = IIf(Sys.LoginWeb.Lang = "T", "รหัสกลุ่มค่าใช้จ่าย", "CostCenter(Code)")

        GetMasterData.Field2 = "CostCenterNameT"
        GetMasterData.HeaderText2 = IIf(Sys.LoginWeb.Lang = "T", "กลุ่มค่าใช้จ่าย(ไทย)", "CostCenter(Thai)")
        GetMasterData.IsRequire2 = False    'มีค่าว่างได้

        GetMasterData.Field3 = "CostCenterNameE"
        GetMasterData.HeaderText3 = IIf(Sys.LoginWeb.Lang = "T", "กลุ่มค่าใช้จ่าย(อังกฤษ)", "CostCenter(Eng)")
        GetMasterData.IsRequire3 = False    'มีค่าว่างได้

        GetMasterData.Field4 = ""  'หมายความว่า ไม่มี ช่องที่ 4
        GetMasterData.HeaderText4 = IIf(Sys.LoginWeb.Lang = "T", "", "")
        '== ส่งค่า True กรณีที่ฟิวส์ที่ 4 ไม่มี =='
        GetMasterData.ReadOnly4 = True

        GetMasterData.CheckBeforeDeleteTable = {"PRT_DataPay"}
        GetMasterData.CheckBeforeDeleteField = {"CostCenterID"}

        Sys.ev1.Remove("prm_costcenter")
        If Sys.ev1.ContainsKey("prm_costcenter") = False Then
            Sys.ev1.Add("prm_costcenter", GetMasterData)
        End If
    End Sub

End Class
