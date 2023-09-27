Imports Microsoft.VisualBasic
Imports System.Data
Imports System

Public Class Msg
    Public dT_Lang As New DataTable
    Public dT_Title As New DataTable
    Sub New()
        LoadLang("MSG")
        If dT_Lang.Rows.Count > 0 Then

            _Insert = Label_Text("_Insert")
            _Update = Label_Text("_Update")
            _Delete = Label_Text("_Delete")
            _Save = Label_Text("_Save")
            _Cancel = Label_Text("_Cancel")
            _Search = Label_Text("_Search")
            _Previous = Label_Text("_Previous")
            _Next = Label_Text("_Next")
            _Exit = Label_Text("_Exit")

            _หมวด = Label_Text("_หมวด")
            _หลักสูตร = Label_Text("_หลักสูตร")
            _ชื่อหลักสูตร = Label_Text("_ชื่อหลักสูตร")
            _ครั้งที่นำส่ง = Label_Text("_ครั้งที่นำส่ง")
            _ปีที่นำส่ง = Label_Text("_ปีที่นำส่ง")
            _ครั้งที่ = Label_Text("_ครั้งที่")


            _คุณต้องการที่จะลบข้อมูลใช่หรือไม่ = Label_Text("_คุณต้องการที่จะลบข้อมูลใช่หรือไม่")
            _กรุณาเลือกหมวด = Label_Text("_กรุณาเลือกหมวด")
            _กรุณาเลือกหลักสูตร = Label_Text("_กรุณาเลือกหลักสูตร")
            _กรุณาระบุรหัสหลักสูตร = Label_Text("_กรุณาระบุรหัสหลักสูตร")
            _กรุณาระบุชื่อหลักสูตร = Label_Text("_กรุณาระบุชื่อหลักสูตร")
            _บันทึกไม่สำเร็จ = Label_Text("_SaveNotComplete")
            _กรุณาบันทึกลำดับก่อนหน้า = Label_Text("_กรุณาบันทึกลำดับก่อนหน้า")
            _คนในลำดับอบรมไม่เท่ากัน = Label_Text("_คนในลำดับอบรมไม่เท่ากัน")
            _กรุณาระบุคะแนนหลักสูตร = Label_Text("_กรุณาระบุคะแนนหลักสูตร")
            _กรุณาระบุเกรดหลักสูตร = Label_Text("_กรุณาระบุเกรดหลักสูตร")
            _คุณต้องการยืนยันการนำส่งข้อมูลใช่หรือไม่ = Label_Text("_คุณต้องการยืนยันการนำส่งข้อมูลใช่หรือไม่")
            _ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ = Label_Text("_ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ")
            _จำนวน = Label_Text("_จำนวน")
            _บันทึกสำเร็จ = Label_Text("_บันทึกสำเร็จ")
            _ส่งสำเร็จ = Label_Text("_ส่งสำเร็จ")
            _ลบข้อมูลเสร็จเรียบร้อย = Label_Text("_ลบข้อมูลเสร็จเรียบร้อย")
            _ถูกใช้งานอยู่ = Label_Text("_ถูกใช้งานอยู่")
            _คำเตือน = Label_Text("_คำเตือน")
            _แสดง = Label_Text("_แสดง")
            _รายการหน้า = Label_Text("_รายการหน้า")
            _ข้อความ = Label_Text("_ข้อความ")
            _Alert = Label_Text("_Alert")
            _ไม่สามารถมีค่าว่างเปล่า = Label_Text("_ไม่สามารถมีค่าว่างเปล่า")
            _ไม่สามารถมีค่าซ้ำ = Label_Text("_ไม่สามารถมีค่าซ้ำ")
            _ไม่พบไฟล์ = Label_Text("_ไม่พบไฟล์")
            _มีไฟล์นี้ในระบบแล้ว = Label_Text("_มีไฟล์นี้ในระบบแล้ว")
            _ค้นหาไม่พบ = Label_Text("_ค้นหาไม่พบ")
            _วันที่ไม่ถูกต้อง = Label_Text("_วันที่ไม่ถูกต้อง")
            _รหัสผ่านไม่ถูกต้อง = Label_Text("_รหัสผ่านไม่ถูกต้อง")
            _นามสกุล = Label_Text("_นามสกุล")

            _กรุณารอสักครู่ = Label_Text("_กรุณารอสักครู่")
            _สาย = Label_Text("_สาย")
            _ออกก่อน = Label_Text("_ออกก่อน")
            _เฉพาะที่ไม่บันทึกเข้าและออก = Label_Text("_เฉพาะที่ไม่บันทึกเข้าและออก")
            _ฐานชั่วโมง_จากระบบเงินเดือน = Label_Text("_ฐานชั่วโมง_จากระบบเงินเดือน")
            _เลือกงวดเบี้ยขยัน = Label_Text("_เลือกงวดเบี้ยขยัน")
            _เลือกโอทีตกเบิก = Label_Text("_เลือกโอทีตกเบิก")
            _ลาไม่หักเงิน = Label_Text("_ลาไม่หักเงิน")
            _วันที่ขอโอที = Label_Text("_วันที่ขอโอที")
            _เลือกปี = Label_Text("_เลือกปี")
            _แสดงยอดรวมกลุ่ม = Label_Text("_แสดงยอดรวมกลุ่ม")
            _เฉพาะโอทีสะสมเป็นลา_การใช้ลาโอทีสะสม = Label_Text("_เฉพาะโอทีสะสมเป็นลา_การใช้ลาโอทีสะสม")
            _สถานะใบลา = Label_Text("_สถานะใบลา")
            _แสดงวัน = Label_Text("_แสดงวัน")
            _สถานะการลงเวลา = Label_Text("_สถานะการลงเวลา")
            _รายวัน = Label_Text("_รายวัน")
            _รายเดือน = Label_Text("_รายเดือน")
            _ระหว่างวันที่ = Label_Text("_ระหว่างวันที่")
            _ปี = Label_Text("_ปี")
            _ถึง = Label_Text("_ถึง")
            _ช่วงเวลาประเมินผล = Label_Text("_ช่วงเวลาประเมินผล")
            _เพิ่มเวลา = Label_Text("_เพิ่มเวลา")
            _จำนวนชั่วโมงรวมน้อยกว่า6ชั่วโมง = Label_Text("_HourIsLessThen6")
        End If
    End Sub


    Public Sub LoadTitle(webName As String, formType As String, Optional Lang As String = "")
        If Mem_TitleforDB.ContainsKey(webName) = False Then
            Dim da As New Mydata(DatabaseType.SQLServer)
            If (formType = "Form") Then
                dT_Title = da.GetDataTable("select * from ADM_Menu where Menu_Prog = 'TN' and FormName = '" & webName & "' ")
            Else
                dT_Title = da.GetDataTable("select * from ADM_Report where Report_Prog = 'TN' and FormName = '" & webName & "' ")
            End If

            Mem_TitleforDB.Add(webName, dT_Title)
        Else
            dT_Title = Mem_TitleforDB(webName)
        End If
    End Sub

    Public Function Title_Text(ByVal LText As String) As String
        Title_Text = ""
        Dim dv As New DataView(dT_Title)
        dv.RowFilter = "FormName='" & LText & "'"
        If dv.Count > 0 Then
            Try
                If Sys.LoginWeb.Lang = "T" Then Title_Text = dv(0)("Menu_NameT") & ""
                If Sys.LoginWeb.Lang = "E" Then Title_Text = dv(0)("Menu_NameE") & ""
                If Sys.LoginWeb.Lang = "O" Then Title_Text = dv(0)("Menu_NameO") & ""
            Catch ex As Exception
            End Try
        End If
    End Function

    Public Function Program_Code(ByVal LText As String) As String
        Program_Code = ""
        Dim dv As New DataView(dT_Title)
        dv.RowFilter = "FormName='" & LText & "'"
        If dv.Count > 0 Then
            Try
                Program_Code = dv(0)("Menu_Code") & ""
            Catch ex As Exception
            End Try
        End If
    End Function

    Public Sub LoadLang(webName As String, Optional Lang As String = "")
        If Sys.LoginWeb.Lang <> "T" Or Lang = "" Then
            If Mem_LangforDB.ContainsKey(webName) = False Then
                Dim da As New Mydata(DatabaseType.SQLServer)
                dT_Lang = da.GetDataTable("select * from PNM_ChangeLanguage where SystemName = '" & Sys.LoginWeb.SystemName & "' and FormName = '" & webName & "' ")
                Mem_LangforDB.Add(webName, dT_Lang)
            Else
                dT_Lang = Mem_LangforDB(webName)
            End If
        End If
    End Sub




    Public Sub SetDaymemoTextE(ByVal xDt As DataTable)
        Dim strMemo$, strRes$, strar$()
        For Each dr As DataRow In xDt.Rows
            strMemo = (dr("day_memo") & "")
            strMemo = strMemo.Trim
            If strMemo <> "" Then
                strar = strMemo.Split(" ")
                strRes = Sys.TMsg.getTextE(strar(0))
                If strRes <> strar(0) Then
                    dr("day_memo") = strMemo.Replace(strar(0), strRes)
                End If
                If strar.Length > 1 Then
                    strMemo = dr("day_memo")
                    strRes = Sys.TMsg.getTextE(strar(1))
                    If strRes <> strar(1) Then
                        dr("day_memo") = strMemo.Replace(strar(1), strRes)
                    End If
                End If
            End If
        Next
    End Sub

    'สำหรับ ดึงชื่อ ภาษาอังกฤษ
    Public Function getTextE(ByVal xObj$) As String
        If Sys.LoginWeb.Lang = "T" Then
            Return xObj
        End If
        Dim strChk$ = xObj.Trim.Replace(" ", "")
        strChk = strChk.Replace("-", "")
        strChk = strChk.Replace(":", "")
        strChk = strChk.Replace("(", "")
        strChk = strChk.Replace(")", "")
        strChk = strChk.Replace("<br>", "")


        'Dim result$ = htText(strChk)
        Dim result$ = strChk 'wait
        If result = "" Then
            Return xObj
        Else
            Return result
        End If
    End Function


    'สำหรับดึงชื่อ สถานะการ Apporve (ใบลา) ภาษาอังกฤษ
    Public Function getApporveOtTextE(ByVal xStatus$) As String
        Dim result$ = ""
        If Sys.LoginWeb.Lang = "E" Then
            If xStatus = "A" Then
                result = "Approved"
            ElseIf xStatus = "N" Then
                result = "Not Approved"
            ElseIf xStatus = "R" Then
                result = "Waiting"
            ElseIf xStatus = "P" Then
                'If Sys.TypeCaseProcess = TypeCaseProcess.SPC_Group_163 Then
                '    result = "Manager Approved"
                'Else
                result = "Waiting for HR"
                'End If
            ElseIf xStatus = "1" Then
                result = "Waiting no.1"
            ElseIf xStatus = "2" Then
                result = "Waiting no.2"
            ElseIf xStatus = "3" Then
                result = "Waiting no.3"
            ElseIf xStatus = "4" Then
                result = "Waiting no.4"
            ElseIf xStatus = "5" Then
                result = "Waiting no.5"
            ElseIf xStatus = "6" Then
                result = "Waiting no.6"
                'If Sys.TypeCaseProcess = TypeCaseProcess.SEACON_133 Then
                '    result = "Waiting last approver"
                'End If
            ElseIf xStatus = "B" Then
                result = "Wait for Leader"
            End If
        Else
            If xStatus = "A" Then
                result = "อนุมัติ"
            ElseIf xStatus = "R" Then
                result = "รออนุมัติ"
            ElseIf xStatus = "N" Then
                result = "ไม่อนุมัติ"
            ElseIf xStatus = "1" Then
                result = "รอผู้อนุมัติ คนที่ 1"
            ElseIf xStatus = "2" Then
                result = "รอผู้อนุมัติ คนที่ 2"
            ElseIf xStatus = "3" Then
                result = "รอผู้อนุมัติ คนที่ 3"
            ElseIf xStatus = "4" Then
                result = "รอผู้อนุมัติ คนที่ 4"
            ElseIf xStatus = "5" Then
                result = "รอผู้อนุมัติ คนที่ 5"
            ElseIf xStatus = "6" Then
                result = "รอผู้อนุมัติ คนที่ 6"
                'If Sys.TypeCaseProcess = TypeCaseProcess.SEACON_133 Then
                '    result = "รอผู้อนุมัติคนสุดท้าย"
                'End If
            ElseIf xStatus = "P" Then
                'If Sys.TypeCaseProcess = TypeCaseProcess.SPC_Group_163 Then
                '    result = "ผู้บังคับบัญชาได้อนุมัติแล้ว"
                'Else
                result = "รออนุมัติจากฝ่ายบุคคล"
                'End If
            ElseIf xStatus = "B" Then
                result = "รออนุมัติจากประธาน"
            End If
        End If
        Return result
    End Function

    'สำหรับดึงชื่อ สถานะการ Apporve  
    Public Function getApporveLeaveTextE(ByVal xStatus$) As String
        Dim result$ = ""

        If Sys.LoginWeb.Lang <> "T" Then
            If xStatus = "A" Then
                result = "Approved"
            ElseIf xStatus = "N" Then
                result = "Not Approved"
            ElseIf xStatus = "R" Then
                result = "Waiting"
            ElseIf xStatus = "P" Then
                result = "Waiting for HR"
            ElseIf xStatus = "1" Then
                result = "Waiting no.1"
            ElseIf xStatus = "2" Then
                result = "Waiting no.2"
            ElseIf xStatus = "3" Then
                result = "Waiting no.3"
            ElseIf xStatus = "4" Then
                result = "Waiting no.4"
            ElseIf xStatus = "5" Then
                result = "Waiting no.5"
            ElseIf xStatus = "6" Then
                result = "Waiting no.6"
            End If
        Else
            If xStatus = "A" Then
                result = "อนุมัติ"
            ElseIf xStatus = "N" Then
                result = "ไม่อนุมัติ"
            ElseIf xStatus = "R" Then
                result = "รออนุมัติ"
            ElseIf xStatus = "P" Then
                result = "รออนุมัติจากฝ่ายบุคคล"
            ElseIf xStatus = "1" Then
                result = "รอผู้อนุมัติ คนที่ 1"
            ElseIf xStatus = "2" Then
                result = "รอผู้อนุมัติ คนที่ 2"
            ElseIf xStatus = "3" Then
                result = "รอผู้อนุมัติ คนที่ 3"
            ElseIf xStatus = "4" Then
                result = "รอผู้อนุมัติ คนที่ 4"
            ElseIf xStatus = "5" Then
                result = "รอผู้อนุมัติ คนที่ 5"
            ElseIf xStatus = "6" Then
                result = "รอผู้อนุมัติ คนที่ 6"
            End If
        End If
        Return result
    End Function


    Public Function Label_Text(ByVal LText As String) As String
        Label_Text = ""
        Dim dv As New DataView(dT_Lang)
        dv.RowFilter = "LabelName='" & LText & "'"
        If dv.Count > 0 Then
            Try
                If Sys.LoginWeb.Lang = "T" Then Label_Text = dv(0)("NameT") & ""
                If Sys.LoginWeb.Lang = "E" Then Label_Text = dv(0)("NameE") & ""
                If Sys.LoginWeb.Lang = "O" Then Label_Text = dv(0)("NameO") & ""
            Catch ex As Exception
            End Try
        End If
    End Function

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

    Public Function DayofMountTostring(ByVal i As Byte) As String
        Dim result$ = ""
        If Sys.LoginWeb.Lang = "T" Then
            Select Case i
                Case 1 : result = "มกราคม"
                Case 2 : result = "กุมภาพันธ์"
                Case 3 : result = "มีนาคม"
                Case 4 : result = "เมษายน"
                Case 5 : result = "พฤษภาคม"
                Case 6 : result = "มิถุนายน"
                Case 7 : result = "กรกฎาคม"
                Case 8 : result = "สิงหาคม"
                Case 9 : result = "กันยายน"
                Case 10 : result = "ตุลาคม"
                Case 11 : result = "พฤศจิกายน"
                Case 12 : result = "ธันวาคม"
            End Select
        Else
            Select Case i
                Case 1 : result = Sys.TMsg.มกราคม
                Case 2 : result = Sys.TMsg.กุมภาพันธ์
                Case 3 : result = Sys.TMsg.มีนาคม
                Case 4 : result = Sys.TMsg.เมษายน
                Case 5 : result = Sys.TMsg.พฤษภาคม
                Case 6 : result = Sys.TMsg.มิถุนายน
                Case 7 : result = Sys.TMsg.กรกฎาคม
                Case 8 : result = Sys.TMsg.สิงหาคม
                Case 9 : result = Sys.TMsg.กันยายน
                Case 10 : result = Sys.TMsg.ตุลาคม
                Case 11 : result = Sys.TMsg.พฤศจิกายน
                Case 12 : result = Sys.TMsg.ธันวาคม
            End Select
        End If
        Return result
    End Function


#Region "check"
    Dim _ParameterInCompleted As String
    Public ReadOnly Property ParameterInCompleted() As String
        Get
            Return _ParameterInCompleted
        End Get
    End Property

    Dim _DateNotNull As String
    Public ReadOnly Property DateNotNull() As String
        Get
            Return _DateNotNull
        End Get
    End Property

    Dim _TimeNotNull As String
    Public ReadOnly Property TimeNotNull() As String
        Get
            Return _TimeNotNull
        End Get
    End Property

    Dim _NotAllowDelete As String
    Public ReadOnly Property NotAllowDelete() As String
        Get
            Return _NotAllowDelete
        End Get
    End Property

    Dim _NoRecord As String
    Public ReadOnly Property NoRecord() As String
        Get
            Return _NoRecord
        End Get
    End Property

    Dim _DateIncorrect As String
    Public ReadOnly Property DateIncorrect() As String
        Get
            Return _DateIncorrect
        End Get
    End Property

    Dim _DateRangError As String
    Public ReadOnly Property DateRangError() As String
        Get
            Return _DateRangError
        End Get
    End Property

    Dim _PersonNotNull As String
    Public ReadOnly Property PersonNotNull() As String
        Get
            Return _PersonNotNull
        End Get
    End Property

    Dim _TimeError As String
    Public ReadOnly Property TimeError() As String
        Get
            Return _TimeError
        End Get
    End Property

    Dim _InsertPersonCode As String
    Public ReadOnly Property InsertPersonCode() As String
        Get
            Return _InsertPersonCode
        End Get
    End Property

    Dim _InsertPersonCard As String
    Public ReadOnly Property InsertPersonCard() As String
        Get
            Return _InsertPersonCard
        End Get
    End Property

    Dim _DuplicatePersonCode As String
    Public ReadOnly Property DuplicatePersonCode() As String
        Get
            Return _DuplicatePersonCode
        End Get
    End Property

    Dim _DuplicatePersonCard As String
    Public ReadOnly Property DuplicatePersonCard() As String
        Get
            Return _DuplicatePersonCard
        End Get
    End Property

    Dim _SaveComplete As String
    Public ReadOnly Property SaveComplete() As String
        Get
            Return _SaveComplete
        End Get
    End Property

    Dim _SaveNotComplete As String
    Public ReadOnly Property SaveNotComplete() As String
        Get
            Return _SaveNotComplete
        End Get
    End Property

    Dim _InsertUser As String
    Public ReadOnly Property InsertUser() As String
        Get
            Return _InsertUser
        End Get
    End Property

    Dim _DuplicateUser As String
    Public ReadOnly Property DuplicateUser() As String
        Get
            Return _DuplicateUser
        End Get
    End Property

    Dim _deleteComplete As String
    Public ReadOnly Property deleteComplete() As String
        Get
            Return _deleteComplete
        End Get
    End Property


    Dim _CreatDB As String
    Public ReadOnly Property CreatDB() As String
        Get
            Return _CreatDB
        End Get
    End Property

    Dim _CreatDBConplete As String
    Public ReadOnly Property CreatDBConplete() As String
        Get
            Return _CreatDBConplete
        End Get
    End Property

    Dim _headline As String
    Public ReadOnly Property headline() As String
        Get
            Return _headline
        End Get
    End Property


    Dim _FilenameError As String
    Public ReadOnly Property FilenameError() As String
        Get
            Return _FilenameError
        End Get
    End Property

    Dim _selectperson As String
    Public ReadOnly Property selectperson() As String
        Get
            Return _selectperson
        End Get
    End Property

    Dim _selectMach As String
    Public ReadOnly Property selectMach() As String
        Get
            Return _selectMach
        End Get
    End Property

    Dim _selectFile As String
    Public ReadOnly Property selectFile() As String
        Get
            Return _selectFile
        End Get
    End Property

    Dim _TimeIncorrect As String
    Public ReadOnly Property TimeIncorrect() As String
        Get
            Return _TimeIncorrect
        End Get
    End Property

    Dim _insertTimeS As String
    Public ReadOnly Property insertTimeS() As String
        Get
            Return _insertTimeS
        End Get
    End Property

    Dim _insertTimeE As String
    Public ReadOnly Property insertTimeE() As String
        Get
            Return _insertTimeE
        End Get
    End Property

    Dim _selectyear As String
    Public ReadOnly Property selectyear() As String
        Get
            Return _selectyear
        End Get
    End Property

    Dim _insertInsure As String
    Public ReadOnly Property insertInsure() As String
        Get
            Return _insertInsure
        End Get
    End Property

    Dim _SelectAssignation As String
    Public ReadOnly Property SelectAssignation() As String
        Get
            Return _SelectAssignation
        End Get
    End Property

    Dim _Alert As String
    Public ReadOnly Property Alert() As String
        Get
            Return _Alert
        End Get
    End Property

    Dim _Warning As String
    Public ReadOnly Property Warning() As String
        Get
            Return _Warning
        End Get
    End Property

    Dim _Total As String
    Public ReadOnly Property Total() As String
        Get
            Return _Total
        End Get
    End Property

    Dim _รวม As String
    Public ReadOnly Property รวม() As String
        Get
            Return _รวม
        End Get
    End Property




#End Region


#Region "แมน"

    Dim _จำนวน As String
    Public ReadOnly Property จำนวน() As String
        Get
            Return _จำนวน
        End Get
    End Property

    Dim _ถูกใช้งานอยู่ As String
    Public ReadOnly Property ถูกใช้งานอยู่() As String
        Get
            Return _ถูกใช้งานอยู่
        End Get
    End Property

    Dim _ไม่พบไฟล์ As String
    Public ReadOnly Property ไม่พบไฟล์() As String
        Get
            Return _ไม่พบไฟล์
        End Get
    End Property

    Dim _มีไฟล์นี้ในระบบแล้ว As String
    Public ReadOnly Property มีไฟล์นี้ในระบบแล้ว() As String
        Get
            Return _มีไฟล์นี้ในระบบแล้ว
        End Get
    End Property

    Dim _กรุณาบันทึกลำดับก่อนหน้า As String
    Public ReadOnly Property กรุณาบันทึกลำดับก่อนหน้า() As String
        Get
            Return _กรุณาบันทึกลำดับก่อนหน้า
        End Get
    End Property

    Dim _ค้นหาไม่พบ As String
    Public ReadOnly Property ค้นหาไม่พบ() As String
        Get
            Return _ค้นหาไม่พบ
        End Get
    End Property

    Dim _คนในลำดับอบรมไม่เท่ากัน As String
    Public ReadOnly Property คนในลำดับอบรมไม่เท่ากัน() As String
        Get
            Return _คนในลำดับอบรมไม่เท่ากัน
        End Get
    End Property
    Dim _กรุณาระบุคะแนนหลักสูตร As String
    Public ReadOnly Property กรุณาระบุคะแนนหลักสูตร() As String
        Get
            Return _กรุณาระบุคะแนนหลักสูตร
        End Get
    End Property
    Dim _กรุณาระบุเกรดหลักสูตร As String
    Public ReadOnly Property กรุณาระบุเกรดหลักสูตร() As String
        Get
            Return _กรุณาระบุเกรดหลักสูตร
        End Get
    End Property
    Dim _คุณต้องการยืนยันการนำส่งข้อมูลใช่หรือไม่ As String
    Public ReadOnly Property คุณต้องการยืนยันการนำส่งข้อมูลใช่หรือไม่() As String
        Get
            Return _คุณต้องการยืนยันการนำส่งข้อมูลใช่หรือไม่
        End Get
    End Property
    Dim _กรุณารอสักครู่ As String
    Public ReadOnly Property กรุณารอสักครู่() As String
        Get
            Return _กรุณารอสักครู่
        End Get
    End Property
    Dim _สาย As String
    Public ReadOnly Property สาย() As String
        Get
            Return _สาย
        End Get
    End Property
    Dim _ออกก่อน As String
    Public ReadOnly Property ออกก่อน() As String
        Get
            Return _ออกก่อน
        End Get
    End Property
    Dim _เฉพาะที่ไม่บันทึกเข้าและออก As String
    Public ReadOnly Property เฉพาะที่ไม่บันทึกเข้าและออก() As String
        Get
            Return _เฉพาะที่ไม่บันทึกเข้าและออก
        End Get
    End Property
    Dim _ฐานชั่วโมง_จากระบบเงินเดือน As String
    Public ReadOnly Property ฐานชั่วโมง_จากระบบเงินเดือน() As String
        Get
            Return _ฐานชั่วโมง_จากระบบเงินเดือน
        End Get
    End Property
    Dim _เลือกงวดเบี้ยขยัน As String
    Public ReadOnly Property เลือกงวดเบี้ยขยัน() As String
        Get
            Return _เลือกงวดเบี้ยขยัน
        End Get
    End Property
    Dim _เลือกโอทีตกเบิก As String
    Public ReadOnly Property เลือกโอทีตกเบิก() As String
        Get
            Return _เลือกโอทีตกเบิก
        End Get
    End Property
    Dim _ลาไม่หักเงิน As String
    Public ReadOnly Property ลาไม่หักเงิน() As String
        Get
            Return _ลาไม่หักเงิน
        End Get
    End Property
    Dim _วันที่ขอโอที As String
    Public ReadOnly Property วันที่ขอโอที() As String
        Get
            Return _วันที่ขอโอที
        End Get
    End Property
    Dim _เลือกปี As String
    Public ReadOnly Property เลือกปี() As String
        Get
            Return _เลือกปี
        End Get
    End Property
    Dim _แสดงยอดรวมกลุ่ม As String
    Public ReadOnly Property แสดงยอดรวมกลุ่ม() As String
        Get
            Return _แสดงยอดรวมกลุ่ม
        End Get
    End Property
    Dim _เฉพาะโอทีสะสมเป็นลา_การใช้ลาโอทีสะสม As String
    Public ReadOnly Property เฉพาะโอทีสะสมเป็นลา_การใช้ลาโอทีสะสม() As String
        Get
            Return _เฉพาะโอทีสะสมเป็นลา_การใช้ลาโอทีสะสม
        End Get
    End Property
    Dim _สถานะใบลา As String
    Public ReadOnly Property สถานะใบลา() As String
        Get
            Return _สถานะใบลา
        End Get
    End Property
    Dim _แสดงวัน As String
    Public ReadOnly Property แสดงวัน() As String
        Get
            Return _แสดงวัน
        End Get
    End Property
    Dim _สถานะการลงเวลา As String
    Public ReadOnly Property สถานะการลงเวลา() As String
        Get
            Return _สถานะการลงเวลา
        End Get
    End Property
    Dim _รายวัน As String
    Public ReadOnly Property รายวัน() As String
        Get
            Return _รายวัน
        End Get
    End Property
    Dim _รายเดือน As String
    Public ReadOnly Property รายเดือน() As String
        Get
            Return _รายเดือน
        End Get
    End Property
    Dim _ระหว่างวันที่ As String
    Public ReadOnly Property ระหว่างวันที่() As String
        Get
            Return _ระหว่างวันที่
        End Get
    End Property
    Dim _ปี As String
    Public ReadOnly Property ปี() As String
        Get
            Return _ปี
        End Get
    End Property
    Dim _ถึง As String
    Public ReadOnly Property ถึง() As String
        Get
            Return _ถึง
        End Get
    End Property
    Dim _ช่วงเวลาประเมินผล As String
    Public ReadOnly Property ช่วงเวลาประเมินผล() As String
        Get
            Return _ช่วงเวลาประเมินผล
        End Get
    End Property
    Dim _เพิ่มเวลา As String
    Public ReadOnly Property เพิ่มเวลา() As String
        Get
            Return _เพิ่มเวลา
        End Get
    End Property
#End Region
    '####################################################################################################
    'สิทธิ์ msg
#Region "สิทธิ์ "
    Dim _ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ As String  ' 2019/007/02
    Public ReadOnly Property ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ As String
        Get
            Return _ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ
        End Get
    End Property
#End Region

    '####################################################################################################
    'ชัช msg

#Region "ชัช2"
    Dim _นามสกุล As String
    Public ReadOnly Property นามสกุล As String
        Get
            Return _นามสกุล
        End Get
    End Property

    Dim _รหัสผ่านไม่ถูกต้อง As String
    Public ReadOnly Property รหัสผ่านไม่ถูกต้อง As String
        Get
            Return _รหัสผ่านไม่ถูกต้อง
        End Get
    End Property
    Dim _ชื่อพนักงาน As String
    Public ReadOnly Property ชื่อพนักงาน As String
        Get
            Return _ชื่อพนักงาน
        End Get
    End Property

    Dim _แสดงรายละเอียด As String
    Public ReadOnly Property แสดงรายละเอียด As String
        Get
            Return _แสดงรายละเอียด
        End Get
    End Property


    Dim _ผู้อนุมัติตามลำดับขั้น As String
    Public ReadOnly Property ผู้อนุมัติตามลำดับขั้น As String
        Get
            Return _ผู้อนุมัติตามลำดับขั้น
        End Get
    End Property



    Dim _กรุณาใส่ชื่อไฟล์ As String
    Public ReadOnly Property กรุณาใส่ชื่อไฟล์() As String
        Get
            Return _กรุณาใส่ชื่อไฟล์
        End Get
    End Property



    Dim _ผู้อนุมัติแทน As String
    Public ReadOnly Property ผู้อนุมัติแทน() As String
        Get
            Return _ผู้อนุมัติแทน
        End Get
    End Property

    Dim _ความเห็นผู้อนุมัติคนที่ As String
    Public ReadOnly Property ความเห็นผู้อนุมัติคนที่() As String
        Get
            Return _ความเห็นผู้อนุมัติคนที่
        End Get
    End Property





    Dim _วันที่ไม่ถูกต้อง As String
    Public ReadOnly Property วันที่ไม่ถูกต้อง() As String
        Get
            Return _วันที่ไม่ถูกต้อง
        End Get
    End Property

    Dim _แสดงรายละเอียดแต่ละวัน As String
    Public ReadOnly Property แสดงรายละเอียดแต่ละวัน() As String
        Get
            Return _แสดงรายละเอียดแต่ละวัน
        End Get
    End Property


    Dim _แสดงรายละเอียดแต่ละเดือน As String
    Public ReadOnly Property แสดงรายละเอียดแต่ละเดือน() As String
        Get
            Return _แสดงรายละเอียดแต่ละเดือน
        End Get
    End Property





    Dim _ตรวจสอบข้อมูล As String
    Public ReadOnly Property ตรวจสอบข้อมูล() As String
        Get
            Return _ตรวจสอบข้อมูล
        End Get
    End Property

    Dim _สำเร็จ As String
    Public ReadOnly Property สำเร็จ() As String
        Get
            Return _สำเร็จ
        End Get
    End Property


    Dim _Insert As String
    Public ReadOnly Property Insert() As String
        Get
            Return _Insert
        End Get
    End Property

    Dim _Update As String
    Public ReadOnly Property Update() As String
        Get
            Return _Update
        End Get
    End Property

    Dim _Delete As String
    Public ReadOnly Property Delete() As String
        Get
            Return _Delete
        End Get
    End Property

    Dim _Save As String
    Public ReadOnly Property Save() As String
        Get
            Return _Save
        End Get
    End Property

    Dim _Cancel As String
    Public ReadOnly Property Cancel() As String
        Get
            Return _Cancel
        End Get
    End Property

    Dim _Search As String
    Public ReadOnly Property Search() As String
        Get
            Return _Search
        End Get
    End Property

    Dim _Previous As String
    Public ReadOnly Property Previous() As String
        Get
            Return _Previous
        End Get
    End Property

    Dim _Next As String
    Public ReadOnly Property Nexts() As String
        Get
            Return _Next
        End Get
    End Property

    Dim _Exit As String
    Public ReadOnly Property Exits() As String
        Get
            Return _Exit
        End Get
    End Property

    Dim _มกราคม As String
    Public ReadOnly Property มกราคม() As String
        Get
            Return _มกราคม
        End Get
    End Property

    Dim _กุมภาพันธ์ As String
    Public ReadOnly Property กุมภาพันธ์() As String
        Get
            Return _กุมภาพันธ์
        End Get
    End Property

    Dim _มีนาคม As String
    Public ReadOnly Property มีนาคม() As String
        Get
            Return _มีนาคม
        End Get
    End Property

    Dim _เมษายน As String
    Public ReadOnly Property เมษายน() As String
        Get
            Return _เมษายน
        End Get
    End Property

    Dim _พฤษภาคม As String
    Public ReadOnly Property พฤษภาคม() As String
        Get
            Return _พฤษภาคม
        End Get
    End Property

    Dim _มิถุนายน As String
    Public ReadOnly Property มิถุนายน() As String
        Get
            Return _มิถุนายน
        End Get
    End Property

    Dim _กรกฎาคม As String
    Public ReadOnly Property กรกฎาคม() As String
        Get
            Return _กรกฎาคม
        End Get
    End Property

    Dim _สิงหาคม As String
    Public ReadOnly Property สิงหาคม() As String
        Get
            Return _สิงหาคม
        End Get
    End Property

    Dim _กันยายน As String
    Public ReadOnly Property กันยายน() As String
        Get
            Return _กันยายน
        End Get
    End Property

    Dim _ตุลาคม As String
    Public ReadOnly Property ตุลาคม() As String
        Get
            Return _ตุลาคม
        End Get
    End Property

    Dim _พฤศจิกายน As String
    Public ReadOnly Property พฤศจิกายน() As String
        Get
            Return _พฤศจิกายน
        End Get
    End Property

    Dim _ธันวาคม As String
    Public ReadOnly Property ธันวาคม() As String
        Get
            Return _ธันวาคม
        End Get
    End Property


    Dim _คุณยังไม่ได้ตั้งค่าระบบส่งEMail As String
    Public ReadOnly Property คุณยังไม่ได้ตั้งค่าระบบส่งEMail() As String
        Get
            Return _คุณยังไม่ได้ตั้งค่าระบบส่งEMail
        End Get
    End Property

    Dim _คุณยังไม่ได้ตั้งค่าHostระบบส่งEMail As String
    Public ReadOnly Property คุณยังไม่ได้ตั้งค่าHostระบบส่งEMail() As String
        Get
            Return _คุณยังไม่ได้ตั้งค่าHostระบบส่งEMail
        End Get
    End Property


    Dim _กรุณาเลือกColumns As String
    Public ReadOnly Property กรุณาเลือกColumns() As String
        Get
            Return _กรุณาเลือกColumns
        End Get
    End Property



    Dim _คนอนุมัติที่1 As String
    Public ReadOnly Property คนอนุมัติที่1() As String
        Get
            Return _คนอนุมัติที่1
        End Get
    End Property

    Dim _คนอนุมัติที่2 As String
    Public ReadOnly Property คนอนุมัติที่2() As String
        Get
            Return _คนอนุมัติที่2
        End Get
    End Property

    Dim _คนอนุมัติที่3 As String
    Public ReadOnly Property คนอนุมัติที่3() As String
        Get
            Return _คนอนุมัติที่3
        End Get
    End Property

    Dim _คนอนุมัติที่4 As String
    Public ReadOnly Property คนอนุมัติที่4() As String
        Get
            Return _คนอนุมัติที่4
        End Get
    End Property

    Dim _คนอนุมัติที่5 As String
    Public ReadOnly Property คนอนุมัติที่5() As String
        Get
            Return _คนอนุมัติที่5
        End Get
    End Property

    Dim _คนอนุมัติที่6 As String
    Public ReadOnly Property คนอนุมัติที่6() As String
        Get
            Return _คนอนุมัติที่6
        End Get
    End Property



    Dim _รอคนที่1อนุมัติ As String
    Public ReadOnly Property รอคนที่1อนุมัติ() As String
        Get
            Return _รอคนที่1อนุมัติ
        End Get
    End Property

    Dim _รอคนที่2อนุมัติ As String
    Public ReadOnly Property รอคนที่2อนุมัติ() As String
        Get
            Return _รอคนที่2อนุมัติ
        End Get
    End Property

    Dim _รอคนที่3อนุมัติ As String
    Public ReadOnly Property รอคนที่3อนุมัติ() As String
        Get
            Return _รอคนที่3อนุมัติ
        End Get
    End Property

    Dim _รอคนที่4อนุมัติ As String
    Public ReadOnly Property รอคนที่4อนุมัติ() As String
        Get
            Return _รอคนที่4อนุมัติ
        End Get
    End Property

    Dim _รอคนที่5อนุมัติ As String
    Public ReadOnly Property รอคนที่5อนุมัติ() As String
        Get
            Return _รอคนที่5อนุมัติ
        End Get
    End Property

    Dim _รอคนที่6อนุมัติ As String
    Public ReadOnly Property รอคนที่6อนุมัติ() As String
        Get
            Return _รอคนที่6อนุมัติ
        End Get
    End Property

    Dim _อนุมัติแล้ว As String
    Public ReadOnly Property อนุมัติแล้ว() As String
        Get
            Return _อนุมัติแล้ว
        End Get
    End Property


    Dim _อนุมัติ As String
    Public ReadOnly Property อนุมัติ() As String
        Get
            Return _อนุมัติ
        End Get
    End Property


    Dim _ไม่อนุมัติ As String
    Public ReadOnly Property ไม่อนุมัติ() As String
        Get
            Return _ไม่อนุมัติ
        End Get
    End Property

    Dim _รออนุมัติ As String
    Public ReadOnly Property รออนุมัติ() As String
        Get
            Return _รออนุมัติ
        End Get
    End Property

    Dim _รอหัวหน้าอนุมัติ As String
    Public ReadOnly Property รอหัวหน้าอนุมัติ() As String
        Get
            Return _รอหัวหน้าอนุมัติ
        End Get
    End Property


    Dim _รอฝ่ายบุคคลอนุมัติ As String
    Public ReadOnly Property รอฝ่ายบุคคลอนุมัติ() As String
        Get
            Return _รอฝ่ายบุคคลอนุมัติ
        End Get
    End Property


    Dim _อยู่ระหว่างรอการอนุมัติ As String
    Public ReadOnly Property อยู่ระหว่างรอการอนุมัติ() As String
        Get
            Return _อยู่ระหว่างรอการอนุมัติ
        End Get
    End Property



    Dim _เพิ่ม As String
    Public ReadOnly Property เพิ่ม() As String
        Get
            Return _เพิ่ม
        End Get
    End Property

    Dim _แก้ไข As String
    Public ReadOnly Property แก้ไข() As String
        Get
            Return _แก้ไข
        End Get
    End Property

    Dim _ลบ As String
    Public ReadOnly Property ลบ() As String
        Get
            Return _ลบ
        End Get
    End Property


    Dim _ดำเนินการเสร็จสิ้น As String
    Public ReadOnly Property ดำเนินการเสร็จสิ้น() As String
        Get
            Return _ดำเนินการเสร็จสิ้น
        End Get
    End Property


    Dim _กรุณาเพิ่มข้อมูล As String
    Public ReadOnly Property กรุณาเพิ่มข้อมูล() As String
        Get
            Return _กรุณาเพิ่มข้อมูล
        End Get
    End Property


    Dim _รายละเอียดการอนุมัติ As String
    Public ReadOnly Property รายละเอียดการอนุมัติ() As String
        Get
            Return _รายละเอียดการอนุมัติ
        End Get
    End Property

    Dim _สถานะการส่งEmail As String
    Public ReadOnly Property สถานะการส่งEmail() As String
        Get
            Return _สถานะการส่งEmail
        End Get
    End Property



    Dim _ทั้งหมด As String
    Public ReadOnly Property ทั้งหมด() As String
        Get
            Return _ทั้งหมด
        End Get
    End Property

    Dim _หัวหน้างาน_ผู้อนุมัติลำดับที่_1_เป็นผู้บันทึกรายการ As String
    Public ReadOnly Property หัวหน้างาน_ผู้อนุมัติลำดับที่_1_เป็นผู้บันทึกรายการ() As String
        Get
            Return _หัวหน้างาน_ผู้อนุมัติลำดับที่_1_เป็นผู้บันทึกรายการ
        End Get
    End Property

    Dim _พนักงานรหัสดังกล่าวยังไม่ได้กำหนดกลุ่มผู้อนุมัติ As String
    Public ReadOnly Property พนักงานรหัสดังกล่าวยังไม่ได้กำหนดกลุ่มผู้อนุมัติ() As String
        Get
            Return _พนักงานรหัสดังกล่าวยังไม่ได้กำหนดกลุ่มผู้อนุมัติ
        End Get
    End Property


    Dim _SendMailCompleted As String
    Public ReadOnly Property SendMailCompleted() As String
        Get
            Return _SendMailCompleted
        End Get
    End Property

    Dim _SendMailError As String
    Public ReadOnly Property SendMailError() As String
        Get
            Return _SendMailError
        End Get
    End Property

    Dim _EmailNotSet As String
    Public ReadOnly Property EmailNotSet() As String
        Get
            Return _EmailNotSet
        End Get
    End Property

    Dim _SaveError As String
    Public ReadOnly Property SaveError() As String
        Get
            Return _SaveError
        End Get
    End Property



    Dim _ไม่พบพนักงาน As String
    Public ReadOnly Property ไม่พบพนักงาน() As String
        Get
            Return _ไม่พบพนักงาน
        End Get
    End Property

    Dim _ผ่าน As String
    Public ReadOnly Property ผ่าน() As String
        Get
            Return _ผ่าน
        End Get
    End Property

    Dim _ไม่ผ่าน As String
    Public ReadOnly Property ไม่ผ่าน() As String
        Get
            Return _ไม่ผ่าน
        End Get
    End Property



    Dim _ไม่พบรหัสพนักงานดังกล่าว As String
    Public ReadOnly Property ไม่พบรหัสพนักงานดังกล่าว() As String
        Get
            Return _ไม่พบรหัสพนักงานดังกล่าว
        End Get
    End Property

    Dim _ไม่สามารถมีค่าว่างเปล่า As String
    Public ReadOnly Property ไม่สามารถมีค่าว่างเปล่า() As String
        Get
            Return _ไม่สามารถมีค่าว่างเปล่า
        End Get
    End Property



    Dim _กรุณาเลือกรายการ As String
    Public ReadOnly Property กรุณาเลือกรายการ() As String
        Get
            Return _กรุณาเลือกรายการ
        End Get
    End Property

    Dim _รหัส As String
    Public ReadOnly Property รหัส() As String
        Get
            Return _รหัส
        End Get
    End Property

    Dim _กลุ่มข้อมูล As String
    Public ReadOnly Property กลุ่มข้อมูล() As String
        Get
            Return _กลุ่มข้อมูล
        End Get
    End Property


    Dim _แสดง As String
    Public ReadOnly Property แสดง() As String
        Get
            Return _แสดง
        End Get
    End Property

    Dim _รายการหน้า As String
    Public ReadOnly Property รายการหน้า() As String
        Get
            Return _รายการหน้า
        End Get
    End Property

    Dim _หมายเหตุ As String
    Public ReadOnly Property หมายเหตุ() As String
        Get
            Return _หมายเหตุ
        End Get
    End Property

    Dim _พบข้อมูล As String
    Public ReadOnly Property พบข้อมูล() As String
        Get
            Return _พบข้อมูล
        End Get
    End Property

    Dim _รายการ As String
    Public ReadOnly Property รายการ() As String
        Get
            Return _รายการ
        End Get
    End Property

    Dim _พนักงาน As String
    Public ReadOnly Property พนักงาน() As String
        Get
            Return _พนักงาน
        End Get
    End Property


    Dim _ไม่สามารถมีมากกว่า As String
    Public ReadOnly Property ไม่สามารถมีมากกว่า() As String
        Get
            Return _ไม่สามารถมีมากกว่า
        End Get
    End Property

    Dim _ไม่สามารถมีค่าซ้ำ As String
    Public ReadOnly Property ไม่สามารถมีค่าซ้ำ() As String
        Get
            Return _ไม่สามารถมีค่าซ้ำ
        End Get
    End Property

    Dim _มีรูปแบบไม่ถูกต้อง As String
    Public ReadOnly Property มีรูปแบบไม่ถูกต้อง() As String
        Get
            Return _มีรูปแบบไม่ถูกต้อง
        End Get
    End Property

    Dim _สถานะ As String
    Public ReadOnly Property สถานะ() As String
        Get
            Return _สถานะ
        End Get
    End Property

    Dim _สามารถกำหนดได้_10_รายการ As String
    Public ReadOnly Property สามารถกำหนดได้_10_รายการ() As String
        Get
            Return _สามารถกำหนดได้_10_รายการ
        End Get
    End Property

    Dim _มีการใช้ข้อมูลอยู่ As String
    Public ReadOnly Property มีการใช้ข้อมูลอยู่() As String
        Get
            Return _มีการใช้ข้อมูลอยู่
        End Get
    End Property

    Dim _ประเภท As String
    Public ReadOnly Property ประเภท() As String
        Get
            Return _ประเภท
        End Get
    End Property

    Dim _ประเภทพนักงาน As String
    Public ReadOnly Property ประเภทพนักงาน() As String
        Get
            Return _ประเภทพนักงาน
        End Get
    End Property

    Dim _ระดับพนักงาน As String
    Public ReadOnly Property ระดับพนักงาน() As String
        Get
            Return _ระดับพนักงาน
        End Get
    End Property

    Dim _ตำแหน่ง As String
    Public ReadOnly Property ตำแหน่ง() As String
        Get
            Return _ตำแหน่ง
        End Get
    End Property

    Dim _ไม่พบข้อมูลที่ค้นหา As String
    Public ReadOnly Property ไม่พบข้อมูลที่ค้นหา() As String
        Get
            Return _ไม่พบข้อมูลที่ค้นหา
        End Get
    End Property

    Dim _เดือน As String
    Public ReadOnly Property เดือน() As String
        Get
            Return _เดือน
        End Get
    End Property


    Dim _มีข้อมูลซ้ำ As String
    Public ReadOnly Property มีข้อมูลซ้ำ() As String
        Get
            Return _มีข้อมูลซ้ำ
        End Get
    End Property

    Dim _ไม่สามารถบันทึกได้ As String
    Public ReadOnly Property ไม่สามารถบันทึกได้() As String
        Get
            Return _ไม่สามารถบันทึกได้
        End Get
    End Property

    Dim _ไม่สามารถแก้ไขข้อมูลได้ As String
    Public ReadOnly Property ไม่สามารถแก้ไขข้อมูลได้() As String
        Get
            Return _ไม่สามารถแก้ไขข้อมูลได้
        End Get
    End Property

    Dim _ไม่สามารถลบข้อมูลได้ As String
    Public ReadOnly Property ไม่สามารถลบข้อมูลได้() As String
        Get
            Return _ไม่สามารถลบข้อมูลได้
        End Get
    End Property


    Dim _คุณไม่มีสิทธิ์ใช้งานหน้าจอนี้ As String
    Public ReadOnly Property คุณไม่มีสิทธิ์ใช้งานหน้าจอนี้() As String
        Get
            Return _คุณไม่มีสิทธิ์ใช้งานหน้าจอนี้
        End Get
    End Property

    Dim _PermissionProgram As String
    Public ReadOnly Property PermissionProgram() As String
        Get
            Return _PermissionProgram
        End Get
    End Property

    Dim _PermissionCompany As String
    Public ReadOnly Property PermissionCompany() As String
        Get
            Return _PermissionCompany
        End Get
    End Property


    Dim _รหัสพนักงาน As String = "รหัสพนักงาน"
    Public ReadOnly Property รหัสพนักงาน() As String
        Get
            Return _รหัสพนักงาน
        End Get
    End Property

    Dim _คำเตือน As String = "คำเตือน"
    Public ReadOnly Property คำเตือน() As String
        Get
            Return _คำเตือน
        End Get
    End Property

    Dim _ข้อความ As String = "ข้อความ"
    Public ReadOnly Property ข้อความ() As String
        Get
            Return _ข้อความ
        End Get
    End Property


    Dim _คุณต้องการที่จะบันทึกการเพิ่มข้อมูลใช่หรือไม่ As String = "คุณต้องการที่จะบันทึกการเพิ่มข้อมูลใช่หรือไม่"
    Public ReadOnly Property คุณต้องการที่จะบันทึกการเพิ่มข้อมูลใช่หรือไม่() As String
        Get
            Return _คุณต้องการที่จะบันทึกการเพิ่มข้อมูลใช่หรือไม่
        End Get
    End Property


    Dim _คุณต้องการที่จะบันทึกการแก้ไขข้อมูลใช่หรือไม่ As String = "คุณต้องการที่จะบันทึกการแก้ไขข้อมูลใช่หรือไม่"
    Public ReadOnly Property คุณต้องการที่จะบันทึกการแก้ไขข้อมูลใช่หรือไม่() As String
        Get
            Return _คุณต้องการที่จะบันทึกการแก้ไขข้อมูลใช่หรือไม่
        End Get
    End Property


    Dim _คุณต้องการที่จะประมวลผลใช่หรือไม่ As String = "คุณต้องการที่จะประมวลผลใช่หรือไม่"
    Public ReadOnly Property คุณต้องการที่จะประมวลผลใช่หรือไม่() As String
        Get
            Return _คุณต้องการที่จะประมวลผลใช่หรือไม่
        End Get
    End Property

    Dim _บริษัทที่เข้าใช้งาน As String = "บริษัทที่เข้าใช้งาน"
    Public ReadOnly Property บริษัทที่เข้าใช้งาน() As String
        Get
            Return _บริษัทที่เข้าใช้งาน
        End Get
    End Property

    Dim _ลบเสร็จเรียบร้อย As String = "ลบเสร็จเรียบร้อย"
    Public ReadOnly Property ลบเสร็จเรียบร้อย() As String
        Get
            Return _ลบเสร็จเรียบร้อย
        End Get
    End Property

#End Region


    '####################################################################################################
    Dim _ครั้งที่ As String
    Public ReadOnly Property ครั้งที่() As String
        Get
            Return _ครั้งที่
        End Get
    End Property


    Dim _ครั้งที่นำส่ง As String
    Public ReadOnly Property ครั้งที่นำส่ง() As String
        Get
            Return _ครั้งที่นำส่ง
        End Get
    End Property

    Dim _ปีที่นำส่ง As String
    Public ReadOnly Property ปีที่นำส่ง() As String
        Get
            Return _ปีที่นำส่ง
        End Get
    End Property


    Dim _หมวด As String
    Public ReadOnly Property หมวด() As String
        Get
            Return _หมวด
        End Get
    End Property

    Dim _หลักสูตร As String
    Public ReadOnly Property หลักสูตร() As String
        Get
            Return _หลักสูตร
        End Get
    End Property

    Dim _ชื่อหลักสูตร As String
    Public ReadOnly Property ชื่อหลักสูตร() As String
        Get
            Return _ชื่อหลักสูตร
        End Get
    End Property


    Dim _คุณต้องการตั้งค่าใช่หรือไม่ As String
    Public ReadOnly Property คุณต้องการตั้งค่าใช่หรือไม่() As String
        Get
            Return _คุณต้องการตั้งค่าใช่หรือไม่
        End Get
    End Property


    Dim _คุณต้องการที่จะลบข้อมูลใช่หรือไม่ As String
    Public ReadOnly Property คุณต้องการที่จะลบข้อมูลใช่หรือไม่() As String
        Get
            Return _คุณต้องการที่จะลบข้อมูลใช่หรือไม่
        End Get
    End Property



    Dim _ลบข้อมูลเสร็จเรียบร้อย As String
    Public ReadOnly Property ลบข้อมูลเสร็จเรียบร้อย() As String
        Get
            Return _ลบข้อมูลเสร็จเรียบร้อย
        End Get
    End Property

    Dim _ไฟล์ที่จะ_upload_ต้องเป็น_txt_หรือ_csv_เท่านั้น As String
    Public ReadOnly Property ไฟล์ที่จะ_upload_ต้องเป็น_txt_หรือ_csv_เท่านั้น() As String
        Get
            Return _ไฟล์ที่จะ_upload_ต้องเป็น_txt_หรือ_csv_เท่านั้น
        End Get
    End Property

    Dim _ตรวจสอบการตั้งค่าตำแหน่งของข้อมูลก่อน As String
    Public ReadOnly Property ตรวจสอบการตั้งค่าตำแหน่งของข้อมูลก่อน() As String
        Get
            Return _ตรวจสอบการตั้งค่าตำแหน่งของข้อมูลก่อน
        End Get
    End Property
    '--------------------------- ------------------------------------------------------------------------------------

    Dim _ข้อผิดผลาด As String
    Public ReadOnly Property ข้อผิดผลาด() As String
        Get
            Return _ข้อผิดผลาด
        End Get
    End Property

    Dim _กรุณาเลือกรหัสพนักงาน As String
    Public ReadOnly Property กรุณาเลือกรหัสพนักงาน() As String
        Get
            Return _กรุณาเลือกรหัสพนักงาน
        End Get
    End Property
    '--------------------------- ------------------------------------------------------------------------------------

    Dim _คุณต้องการที่จะประมวลผล As String
    Public ReadOnly Property คุณต้องการที่จะประมวลผล() As String
        Get
            Return _คุณต้องการที่จะประมวลผล
        End Get
    End Property

    Dim _กรุณาตั้งค่าPathURLและPathServerในระบบCompany As String
    Public ReadOnly Property กรุณาตั้งค่าPathURLและPathServerในระบบCompany() As String
        Get
            Return _กรุณาตั้งค่าPathURLและPathServerในระบบCompany
        End Get
    End Property

    Dim _บันทึกสำเร็จ As String
    Public ReadOnly Property บันทึกสำเร็จ() As String
        Get
            Return _บันทึกสำเร็จ
        End Get
    End Property

    Dim _ส่งสำเร็จ As String
    Public ReadOnly Property ส่งสำเร็จ() As String
        Get
            Return _ส่งสำเร็จ
        End Get
    End Property

    Dim _กรุณาเลือกหมวด As String
    Public ReadOnly Property กรุณาเลือกหมวด() As String
        Get
            Return _กรุณาเลือกหมวด
        End Get
    End Property

    Dim _กรุณาเลือกหลักสูตร As String
    Public ReadOnly Property กรุณาเลือกหลักสูตร() As String
        Get
            Return _กรุณาเลือกหลักสูตร
        End Get
    End Property
    Dim _กรุณาระบุรหัสหลักสูตร As String
    Public ReadOnly Property กรุณาระบุรหัสหลักสูตร() As String
        Get
            Return _กรุณาระบุรหัสหลักสูตร
        End Get
    End Property
    Dim _กรุณาระบุชื่อหลักสูตร As String
    Public ReadOnly Property กรุณาระบุชื่อหลักสูตร() As String
        Get
            Return _กรุณาระบุชื่อหลักสูตร
        End Get
    End Property
    Dim _บันทึกไม่สำเร็จ As String
    Public ReadOnly Property บันทึกไม่สำเร็จ() As String
        Get
            Return _บันทึกไม่สำเร็จ
        End Get
    End Property
    Dim _จำนวนชั่วโมงรวมน้อยกว่า6ชั่วโมง As String
    Public ReadOnly Property จำนวนชั่วโมงรวมน้อยกว่า6ชั่วโมง() As String
        Get
            Return _จำนวนชั่วโมงรวมน้อยกว่า6ชั่วโมง
        End Get
    End Property
End Class
