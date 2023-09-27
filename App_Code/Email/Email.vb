Option Compare Text

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Linq.Expressions
Imports System.Web.Mail
Imports System.Linq
Imports System.Text.RegularExpressions

Public Class Email
    Dim _strError, _memoTimeInOut, _addTimeInOutTemplate, _approveTimeInOutTemplate, _approveOtTemplate, _addOtTemplate, _addLeaveTemplate, _cancelLeaveTemplate, _approveLeaveTemplate, _changeHolidayMemo, _changeShiftMemo, _memoLeave, _memoOT, smtpHost, smtpUserName, smtpPassword, smtpPort, smtpFrom As String
    Dim _smtpSendEmailForTimeInOut, _smtpSendEmailForLeave, _smtpSendEmailForOt, _useWebservice As Boolean
    Dim _smtpSsl, _encodingThai, _useApproveTimeInOutTemplate, _useCancelLeaveTemplate, _useApproveOtTemplate, _useAddTimeInOutTemplate, _useApproveLeaveTemplate, _useAddLeaveTemplate, _useAddOtTemplate As Boolean

    ''' <summary>
    ''' note_leave ว่าเริ่มต้นด้วย tag Template หรือไม่ และมีข้อมูลใน tag AddLeave หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UseAddLeaveTemplate() As Boolean
        Get
            Return _useAddLeaveTemplate
        End Get
    End Property

    ''' <summary>
    ''' note_leave ว่าเริ่มต้นด้วย tag Template หรือไม่ และมีข้อมูลใน tag ApproveLeave หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UseApproveLeaveTemplate() As Boolean
        Get
            Return _useApproveLeaveTemplate
        End Get
    End Property
    Public ReadOnly Property ApproveLeaveTemplate() As String
        Get
            Return _approveLeaveTemplate
        End Get
    End Property



    ''' <summary>
    ''' note_OT ว่าเริ่มต้นด้วย tag Template หรือไม่ และมีข้อมูลใน tag ApproveOT หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UseApproveOtTemplate() As Boolean
        Get
            Return _useApproveOtTemplate
        End Get
    End Property
    Public ReadOnly Property ApproveOtTemplate() As String
        Get
            Return _approveOtTemplate
        End Get
    End Property


    ''' <summary>
    ''' note_OT ว่าเริ่มต้นด้วย tag Template หรือไม่ และมีข้อมูลใน tag AddOT หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UseAddOtTemplate() As Boolean
        Get
            Return _useAddOtTemplate
        End Get
    End Property
    Public ReadOnly Property AddOtTemplate() As String
        Get
            Return _addOtTemplate
        End Get
    End Property


    ''' <summary>
    ''' note_timeinout ว่าเริ่มต้นด้วย tag Template หรือไม่ และมีข้อมูลใน tag AddTimeInOut หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UseAddTimeInOutTemplate() As Boolean
        Get
            Return _useAddTimeInOutTemplate
        End Get
    End Property
    Public ReadOnly Property AddTimeInOutTemplate() As String
        Get
            Return _addTimeInOutTemplate
        End Get
    End Property


    ''' <summary>
    ''' note_timeinout ว่าเริ่มต้นด้วย tag Template หรือไม่ และมีข้อมูลใน tag ApproveTimeInOut หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UseApproveTimeInOutTemplate() As Boolean
        Get
            Return _useApproveTimeInOutTemplate
        End Get
    End Property
    Public ReadOnly Property ApproveTimeInOutTemplate() As String
        Get
            Return _approveTimeInOutTemplate
        End Get
    End Property

    ''' <summary>
    ''' note_leave ว่าเริ่มต้นด้วย tag Template หรือไม่ และมีข้อมูลใน tag CancelLeave หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UseCancelLeaveTemplate() As Boolean
        Get
            Return _useCancelLeaveTemplate
        End Get
    End Property
    Public ReadOnly Property CancelLeaveTemplate() As String
        Get
            Return _cancelLeaveTemplate
        End Get
    End Property

    Public ReadOnly Property IsSendEmailForTimeInOut() As Boolean
        Get
            Return _smtpSendEmailForTimeInOut
        End Get
    End Property

    ''' <summary>
    ''' ให้ส่ง email เมื่อมีการลาหรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsSendEmailForLeave() As Boolean
        Get
            Return _smtpSendEmailForLeave
        End Get
    End Property

    ''' <summary>
    ''' ให้ส่ง email เมื่อมีการขอ OT หรือไม่
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsSendEmailForOT() As Boolean
        Get
            Return _smtpSendEmailForOt
        End Get
    End Property

    Public ReadOnly Property UseWebservice() As Boolean
        Get
            Return _useWebservice
        End Get
    End Property

    Public ReadOnly Property StrError$()
        Get
            Return _strError
        End Get
    End Property

    Public ReadOnly Property AddLeaveTemplate$()
        Get
            Return _addLeaveTemplate
        End Get
    End Property

    Public ReadOnly Property OtMemo$()
        Get
            Return _memoOT
        End Get
    End Property


    ''' <summary>
    ''' งาน โม ล้ำยุค / กระทิงแดง แนบ link ท้าย email 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ChangeShiftMemo() As String
        Get
            Return _changeShiftMemo
        End Get
    End Property


    ''' <summary>
    ''' งาน โม ล้ำยุค / กระทิงแดง แนบ link ท้าย email 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ChangeHolidayMemo$()
        Get
            Return _changeHolidayMemo
        End Get
    End Property

    Public ReadOnly Property LeaveMemo$()
        Get
            Return _memoLeave
        End Get
    End Property

    Public ReadOnly Property TimeInOutMemo$()
        Get
            Return _memoTimeInOut
        End Get
    End Property

    'Public Function GetMailMsg() As MailMessage
    '    Dim mailMsg As New MailMessage

    '    With mailMsg
    '        .BodyFormat = MailFormat.Html
    '        SmtpMail.SmtpServer = smtpHost

    '        If smtpPort = "" Then
    '            'ให้เป็นค่า Default คือ 25
    '            'strStatus = "ส่งไม่สำเร็จ เนื่องจาก : ตั้งค่า smtpPort ไม่ถูกต้อง ดูใน web.config"
    '            .Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", "25")
    '        Else 'smtp.gmail.com use port 465 or 587
    '            .Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", smtpPort)
    '        End If

    '        If smtpUserName <> "" Then
    '            .Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", 2)
    '            .Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
    '            .Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", smtpUserName)
    '            .Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", smtpPassword)
    '        End If

    '        If smtpSsl = True Then
    '            .Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true")
    '        End If

    '        .From = smtpFrom
    '        '.To = strEmail '.Cc = '"""Jane Doe""" & txtTo.Text.Trim '.Bcc = txtBCC.Text.Trim
    '        .Subject = ""
    '        '.Body = sb.ToString'
    '        '.BodyFormat = MailFormat.Html
    '        '.Priority = CType(cboPriority.SelectedIndex, MailPriority)
    '    End With
    '    Return mailMsg
    'End Function

    ''' <summary>
    ''' อ่านการตั้งค่า Smtp จาก Company ปัจจุบัน ถ้า ได้ค่า != "" คือมี error
    ''' </summary>
    ''' <param name="xCompanyID">ID ของ Comany ที่ต้องการอ่าน</param>
    ''' <returns>ถ้ามี ไม่มี Error จะส่งค่า "" ออกไป ถ้ามี Error จะส่ง Ex.Message ออกไป</returns>
    ''' <remarks></remarks>
    Public Function GetSmtp(Optional ByVal xCompanyID% = 0) As String
        Dim companyid%
        If xCompanyID <> 0 Then
            companyid = xCompanyID
        Else
            companyid = CType(System.Web.HttpContext.Current.Session("DrPerson"), DataRow)("companyid")
        End If

        Dim dt1 As DataTable = Sys.LoadTableMasterWeb.TAM_SETUPCompany(companyid)
        Dim dr1 As DataRow = dt1.Rows(0)
        Try
            Try
                If Convert.IsDBNull(dr1("smtpSendEmailForTimeInOut")) Then
                    _smtpSendEmailForTimeInOut = False
                Else
                    _smtpSendEmailForTimeInOut = CBool(dr1("smtpSendEmailForTimeInOut"))
                End If
            Catch ex As Exception
                _smtpSendEmailForTimeInOut = False
            End Try

            Try
                If Convert.IsDBNull(dr1("smtpSendEmailForLeave")) Then
                    _smtpSendEmailForLeave = False
                Else
                    _smtpSendEmailForLeave = CBool(dr1("smtpSendEmailForLeave"))
                End If
            Catch ex As Exception
                _smtpSendEmailForLeave = False
            End Try

            Try
                If Convert.IsDBNull(dr1("smtpSendEmailForOT")) Then
                    _smtpSendEmailForOt = False
                Else
                    _smtpSendEmailForOt = CBool(dr1("smtpSendEmailForOT"))
                End If
            Catch ex As Exception
                _smtpSendEmailForOt = False
            End Try

            Try
                'ck_webservice กรณีที่ส่ง เมล์แบบ1.1 ไม่ได้ให้เลี่ยงไปใช้ webservice 2.0 ส่ง
                'WebPersonMailWebService
                If Convert.IsDBNull(dr1("ck_webservice")) Then
                    _useWebservice = False
                Else
                    _useWebservice = CBool(dr1("ck_webservice"))
                End If
            Catch ex As Exception
                _useWebservice = False
            End Try

            Try
                If Convert.IsDBNull(dr1("smtpUsessl")) Then
                    _smtpSsl = False
                Else
                    _smtpSsl = CBool(dr1("smtpUsessl"))
                End If
            Catch ex As Exception
                _smtpSsl = False
            End Try

            Try
                If Convert.IsDBNull(dr1("smtpEncodingThai")) Then
                    _encodingThai = False
                Else
                    _encodingThai = CBool(dr1("smtpEncodingThai"))
                End If
            Catch ex As Exception
                _encodingThai = False
            End Try

            smtpHost = CStr(dr1("smtpHost") & "").Trim
            smtpPort = CStr(dr1("smtpPort") & "").Trim
            smtpUserName = CStr(dr1("smtpUserName") & "").Trim
            smtpPassword = CStr(dr1("smtppassword") & "").Trim
            smtpFrom = CStr(dr1("smtpFrom") & "").Trim


            'check ว่าใช้ template หรือไม่
            Dim UseEmailTemplate As Boolean
            Try
                UseEmailTemplate = dr1("UseEmailTemplate")
            Catch ex As Exception
                'ดักค่า null
                UseEmailTemplate = False
            End Try

            'Template add leave
            Dim txt$ = CStr(dr1("Note_Leave") & "").Trim
            If UseEmailTemplate = True Then
                Try
                    If txt.StartsWith("<Template>") = True Then
                        _addLeaveTemplate = Regex.Match(txt, "(?<=<AddLeave>)(.|\n)*(?=<\/AddLeave>)", System.Text.RegularExpressions.RegexOptions.Multiline).Value
                        If _addLeaveTemplate.Trim <> "" Then
                            Me._useAddLeaveTemplate = True
                        End If
                    End If
                Catch ex As Exception
                    _addLeaveTemplate = ""
                    Me._useAddLeaveTemplate = False
                End Try
            Else
                _addLeaveTemplate = ""
                Me._useAddLeaveTemplate = False
            End If


            'Template cancel leave
            If UseEmailTemplate = True Then
                Try
                    If txt.StartsWith("<Template>") = True Then
                        _cancelLeaveTemplate = Regex.Match(txt, "(?<=<CancelLeave>)(.|\n)*(?=<\/CancelLeave>)", System.Text.RegularExpressions.RegexOptions.Multiline).Value
                        If _cancelLeaveTemplate.Trim <> "" Then
                            Me._useCancelLeaveTemplate = True
                        End If
                    End If
                Catch ex As Exception
                    _cancelLeaveTemplate = ""
                    Me._useCancelLeaveTemplate = False
                End Try
            Else
                _cancelLeaveTemplate = ""
                Me._useCancelLeaveTemplate = False
            End If

            'Template approve leave
            If UseEmailTemplate = True Then
                Try
                    If txt.StartsWith("<Template>") = True Then
                        _approveLeaveTemplate = Regex.Match(txt, "(?<=<ApproveLeave>)(.|\n)*(?=<\/ApproveLeave>)", System.Text.RegularExpressions.RegexOptions.Multiline).Value
                        If _approveLeaveTemplate.Trim <> "" Then
                            Me._useApproveLeaveTemplate = True
                        End If
                    End If
                Catch ex As Exception
                    _approveLeaveTemplate = ""
                    Me._useApproveLeaveTemplate = False
                End Try
            Else
                _approveLeaveTemplate = ""
                Me._useApproveLeaveTemplate = False
            End If


            'Template Add OT
            txt = CStr(dr1("note_ot") & "").Trim
            If UseEmailTemplate = True Then
                Try
                    If txt.StartsWith("<Template>") = True Then
                        _addOtTemplate = Regex.Match(txt, "(?<=<AddOT>)(.|\n)*(?=<\/AddOT>)", System.Text.RegularExpressions.RegexOptions.Multiline).Value
                        If _addOtTemplate.Trim <> "" Then
                            Me._useAddOtTemplate = True
                        End If
                    End If
                Catch ex As Exception
                    _addOtTemplate = ""
                    Me._useAddOtTemplate = False
                End Try
            Else
                _addOtTemplate = ""
                Me._useAddOtTemplate = False
            End If


            'Template Approve OT
            If UseEmailTemplate = True Then
                Try
                    If txt.StartsWith("<Template>") = True Then
                        _approveOtTemplate = Regex.Match(txt, "(?<=<ApproveOT>)(.|\n)*(?=<\/ApproveOT>)", System.Text.RegularExpressions.RegexOptions.Multiline).Value
                        If _approveOtTemplate.Trim <> "" Then
                            Me._useApproveOtTemplate = True
                        End If
                    End If
                Catch ex As Exception
                    _approveOtTemplate = ""
                    Me._useApproveOtTemplate = False
                End Try
            Else
                _approveOtTemplate = ""
                Me._useApproveOtTemplate = False
            End If

            Try
                txt$ = CStr(dr1("Note_TimeInOut") & "").Trim
            Catch ex As Exception
            End Try

            'Template Add TimeInOut
            If UseEmailTemplate = True Then
                Try
                    If txt.StartsWith("<Template>") = True Then
                        _addTimeInOutTemplate = Regex.Match(txt, "(?<=<AddTimeInOut>)(.|\n)*(?=<\/AddTimeInOut>)", System.Text.RegularExpressions.RegexOptions.Multiline).Value
                        If _addTimeInOutTemplate.Trim <> "" Then
                            Me._useAddTimeInOutTemplate = True
                        End If
                    End If
                Catch ex As Exception
                    _addTimeInOutTemplate = ""
                    Me._useAddTimeInOutTemplate = False
                End Try
            Else
                _addTimeInOutTemplate = ""
                Me._useAddTimeInOutTemplate = False
            End If

            'Template Approve TimeInOut
            If UseEmailTemplate = True Then
                Try
                    If txt.StartsWith("<Template>") = True Then
                        _approveTimeInOutTemplate = Regex.Match(txt, "(?<=<ApproveTimeInOut>)(.|\n)*(?=<\/ApproveTimeInOut>)", System.Text.RegularExpressions.RegexOptions.Multiline).Value
                        If _approveTimeInOutTemplate.Trim <> "" Then
                            Me._useApproveTimeInOutTemplate = True
                        End If
                    End If
                Catch ex As Exception
                    _approveTimeInOutTemplate = ""
                    Me._useApproveTimeInOutTemplate = False
                End Try
            Else
                _approveTimeInOutTemplate = ""
                Me._useApproveTimeInOutTemplate = False
            End If



            Try
                _memoTimeInOut = CStr(dr1("note_TimeInOut") & "").Trim
            Catch ex As Exception
                _memoTimeInOut = ""
            End Try

            Try
                _memoOT = CStr(dr1("note_ot") & "").Trim
            Catch ex As Exception
                _memoOT = ""
            End Try

            Try
                _memoLeave = CStr(dr1("Note_Leave") & "").Trim
            Catch ex As Exception
                _memoLeave = ""
            End Try


        Catch ex As Exception
            _strError = Sys.TMsg.คุณยังไม่ได้ตั้งค่าระบบส่งEMail
            Return _strError
        End Try
        If Not dt1 Is Nothing Then dt1.Dispose()
        dr1 = Nothing
        If _smtpSendEmailForOt = True OrElse _smtpSendEmailForTimeInOut = True OrElse _smtpSendEmailForLeave = True Then
            If smtpHost = "" Then
                _strError = Sys.TMsg.คุณยังไม่ได้ตั้งค่าHostระบบส่งEMail
                Return _strError
            End If
        End If
        Return ""
    End Function

    Private Function GetSmtpWebService() As SMTP
        Dim Smtp As New SMTP
        If smtpPort.Trim = "" Then
            Smtp.Port = 25
        Else
            Smtp.Port = smtpPort
        End If

        If _smtpSsl = True Then
            Smtp.SSL = True
        Else
            Smtp.SSL = False
        End If

        Smtp.Host = smtpHost
        Smtp.UserName = smtpUserName
        Smtp.PassWord = smtpPassword
        Return Smtp
    End Function

    'สำหรับส่ง Email หลายคน
    'onSendMail ใช้แบบนี้
    'Dim [Delegate] As New Func(Of String, Boolean)(AddressOf onSendMail)
    'Dim dtResult As DataTable = Mail.SendMail(emailList, personCodeList, emailBody, personIdList, subject,[Delegate])
    'Public Function onSendMail(ByVal xID$) As Boolean
    '    Using cExecute As New connExecute
    '        cExecute.ExecuteNonQuery(String.Format("delete tap_emailtemp where id in ({0})", xID))
    '    End Using
    'End Function
    Public Function SendMail(ByVal xEmailAddress() As String, ByVal xPersoncode() As String, ByVal xBody() As String, ByVal xPersonID() As String, ByVal xSubject() As String, Optional ByVal onSendmail As Func(Of String, Boolean) = Nothing) As DataTable
        If StrError <> "" Then
            Return Nothing
        End If
        'set smtp---------------------------
        Dim Smtp As New SMTP
        If smtpPort.Trim = "" Then
            Smtp.Port = 25
        Else
            Smtp.Port = smtpPort
        End If
        If _smtpSsl = True Then
            Smtp.SSL = True
        Else
            Smtp.SSL = False
        End If
        Smtp.Host = smtpHost
        Smtp.UserName = smtpUserName
        Smtp.PassWord = smtpPassword

        'set mail message---------------------------
        Dim MailMsg As New MailMsg
        MailMsg.From = smtpFrom
        MailMsg.IsBodyHtml = True
        MailMsg.IsEncoding874 = _encodingThai
        MailMsg.IsBodyHtml = True

        'เป็น datable สำหรับเก็บผลการส่ง Email
        Dim dtResult As New DataTable
        dtResult.Columns.Add("person", GetType(String))
        dtResult.Columns.Add("email", GetType(String))
        dtResult.Columns.Add("status", GetType(String))
        Dim strStatus$
        Dim drResult As DataRow
        Dim strX, emailAddress As String
        Dim i% = 0
        For Each strX In xPersonID
            strX = strX & ""

            strStatus = ""
            emailAddress = xEmailAddress(i) & ""
            emailAddress = emailAddress.Trim
            If strX = "" AndAlso emailAddress = "" Then
                i += 1
                Continue For
            End If
            'ตรวจสอบรูปแบบ E-mail------------------
            If emailAddress = "" Then
                If Sys.LoginWeb.Lang = "E" Then
                    strStatus = "Can not send : e-mail not set."
                Else
                    strStatus = "ส่งไม่สำเร็จ เนื่องจาก : ไม่ได้ตั้งค่า E-mail ของพนักงานคนนี้"
                End If
            Else
                Dim emailValid$ = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                Dim m As System.Text.RegularExpressions.MatchCollection
                m = System.Text.RegularExpressions.Regex.Matches(emailAddress, emailValid)
                If m.Count = 0 Then
                    If Sys.LoginWeb.Lang = "E" Then
                        strStatus = "Can not send : invalid E-mail format."
                    Else
                        strStatus = "ส่งไม่สำเร็จ เนื่องจาก : รูปแบบ E-mail ไม่ถูกต้อง"
                    End If
                    strStatus &= " : " & emailAddress
                Else
                    'ส่ง Email----------------------------------
                    MailMsg.body = xBody(i) & ""
                    MailMsg.To = emailAddress
                    MailMsg.Subject = xSubject(i) & ""

                    Try
                        SendMail(Smtp, MailMsg)
                        strStatus = Sys.TMsg.SendMailCompleted
                    Catch exp As Exception
                        strStatus = Sys.TMsg.SendMailError & " : "
                        strStatus &= exp.Message.Replace("'", "")
                    Finally
                    End Try
                End If
            End If

            If onSendmail IsNot Nothing Then
                onSendmail.Invoke(strX)
            End If

            drResult = dtResult.NewRow
            drResult("person") = xPersoncode(i)
            drResult("email") = emailAddress
            drResult("status") = strStatus
            dtResult.Rows.Add(drResult)
            i += 1
        Next
        Return dtResult
    End Function

    Public Function SendMail(ByVal xSmtp As SMTP, ByVal xMailMsg As MailMsg) As String
        Dim result$ = ""
        Try
            Dim smtp As New System.Net.Mail.SmtpClient()
            smtp.Host = xSmtp.Host
            smtp.EnableSsl = xSmtp.SSL

            If xSmtp.UserName.Trim <> "" Then
                smtp.Credentials = New System.Net.NetworkCredential(xSmtp.UserName, xSmtp.PassWord)
            End If
            If xSmtp.Port = 0 Then
                smtp.Port = 25
            Else
                smtp.Port = xSmtp.Port
            End If
            'กรณีส่งด้วย smtpclient mailaddress ต้องตรง กับ host แต่ถ้าส่งผ่าน smtp server จะเป็นอะไรก็ได้
            Using msg As New System.Net.Mail.MailMessage
                'Dim addrFrom As New System.Net.Mail.MailAddress("admin@ibpmail.co.th", "torchat")
                'Dim addrFrom As New System.Net.Mail.MailAddress("admin@tigersoft.com")
                'Dim addrTo As New System.Net.Mail.MailAddress("torchatp@gmail.com") '
                'Dim addrTo As New System.Net.Mail.MailAddress("torchatp@hotmail.com", "torja") '
                'msg.From = addrFrom
                'msg.To.Add(addrTo)
                'msg.To.Add("admin@tigersoft.co.th")

                If xMailMsg.IsEncoding874 = True Then
                    msg.BodyEncoding = System.Text.Encoding.GetEncoding(874)
                End If

                msg.IsBodyHtml = xMailMsg.IsBodyHtml
                msg.To.Add(xMailMsg.To)
                msg.From = New System.Net.Mail.MailAddress(xMailMsg.From)
                msg.Subject = xMailMsg.Subject
                msg.Body = xMailMsg.body

                'msg.Priority = Net.Mail.MailPriority.High
                msg.Priority = xMailMsg.Priority

                smtp.Send(msg)
            End Using
        Catch exp As Exception
            Throw exp
        End Try
        result = "send complete"
        Return result
    End Function

End Class

Public Class SMTP
    Public Host As String
    Public SSL As Boolean
    Public Port As Integer
    Public UserName As String
    Public PassWord As String

    Sub New()
        UserName = ""
        PassWord = ""
        Host = ""
        Port = 25
        SSL = False
    End Sub

End Class

Public Class MailMsg
    Public From As String
    Public [To] As String
    Public IsBodyHtml As Boolean
    Public IsEncoding874 As Boolean
    Public Subject As String
    Public body As String
    Public Priority As Integer = 3

    Sub New()
        From = ""
        [To] = ""
        Subject = ""
        body = ""
        IsBodyHtml = False
        IsEncoding874 = False
    End Sub

End Class


