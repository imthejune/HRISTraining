Imports Microsoft.VisualBasic
Imports System.Runtime.CompilerServices
Imports Telerik.Web.UI
Imports System

Public Module Extension

    Private RND As New Random()

    '<Extension()> _
    'Public Sub xMessageBox(ByVal Page As System.Web.UI.Page, ByVal message As String)
    '    message &= ""
    '    Page.ClientScript.RegisterStartupScript(Page.GetType, "error" & RND.Next(100), _
    '    "$(function() {" & _
    '        "alert('" & message.Trim.Replace("'", "").Replace(vbCrLf, "") & "'); });", _
    '        True)


    '    'Me.ClientScript.RegisterStartupScript(Me.GetType(), "hideheaderfooter", "$(function() { $('#personList,.header,.footer').hide();});", True)

    'End Sub
    <Extension()> _
    Public Sub xMessageBox(ByVal Page As System.Web.UI.Page, ByVal message As String, Optional xRadManager As Object = Nothing, Optional xTitle As String = "Alert")
        message &= ""
        message = message.Trim.Replace("'", "\'").Replace(vbCrLf, "").Replace("""", "").Replace("/", "").Replace("\", "")

        If xRadManager IsNot Nothing Then
            If TypeOf (xRadManager) Is RadWindowManager Then
                xRadManager.RadAlert(message, 330, 180, xTitle, Nothing)
                'xRadManager.RadAlert(message, 330, 180, xTitle, "alertCallBackFn")
            Else
                xRadManager.Alert(message)

            End If
        Else
            Page.ClientScript.RegisterStartupScript(Page.GetType, "error" & (New Random).Next(1000), _
            "alert('" & message.Trim.Replace("'", "").Replace(vbCrLf, "") & "');", _
            True)
        End If
    End Sub

    'FOR SET HEIGHT/WIDHT RADWINDOW
    Public Sub FormatRWM(RM As RadWindowManager, ByVal message As String, ByRef xWidth As Integer, xHeight As Integer)
        If message <> "" Then
            If Sys.LoginWeb.Lang = "T" Then
                If (message.Length < 30) Then
                    xHeight = 120
                    xWidth = 220
                ElseIf (message.Length < 50) Then
                    xHeight = 120
                    xWidth = 340
                End If
            ElseIf Sys.LoginWeb.Lang = "E" Then

            End If
        End If
    End Sub

    Public Sub xMessageBoxRWM2(RM As RadWindowManager, ByVal message As String)
        Dim width As Integer = 400, height As Integer = 120, xTitle As String = Sys.TMsg.Warning
        message &= ""
        'FormatRWM(RM, message, width, height)
        RM.RadAlert(message, width, height, xTitle, Nothing, "")
        RM.AutoSize = True
    End Sub
    Public Sub xMessageBoxRWM(RM As RadWindowManager, ByVal message As String)
        Dim width As Integer = 400, height As Integer = 120, xTitle As String = Sys.TMsg.Warning
        message &= ""
        message = message.Trim.Replace("'", "|").Replace(vbCrLf, "").Replace("""", "").Replace("/", "").Replace("\", "")
        'FormatRWM(RM, message, width, height)
        RM.RadAlert(message, width, height, xTitle, Nothing, "")
        RM.AutoSize = True
    End Sub

    Public Sub xMessageBoxRWM(RM As RadWindowManager, width As Integer, height As Integer, ByVal message As String, Optional xTitle As String = "Alert")
        message &= ""
        message = message.Trim.Replace("'", "|").Replace(vbCrLf, "").Replace("""", "").Replace("/", "").Replace("\", "")
        'FormatRWM(RM, message, width, height) '600426,CHAT ADD
        RM.RadAlert(message, width, height, xTitle, Nothing, "")
    End Sub

    '600412,CHAT สำหรับรับ event หลังจาก postback
    Public Sub xMessageBoxRWM_WithCallBackFunc(RM As RadWindowManager, width As Integer, height As Integer, ByVal message As String, ByVal CallBackFunc As String, Optional xTitle As String = "Alert")
        message &= ""
        message = message.Trim.Replace("'", "|").Replace(vbCrLf, "").Replace("""", "").Replace("/", "").Replace("\", "")
        RM.RadAlert(message, width, height, xTitle, CallBackFunc, "")
    End Sub

    Public Sub xMessageBoxRWM_ลบข้อมูลสำเร็จ(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.deleteComplete, 210, 100, Sys.TMsg.ข้อความ, Nothing, "")
    End Sub
    Public Sub xMessageBoxRWM_วันที่ไม่ถูกต้อง(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.วันที่ไม่ถูกต้อง, 210, 100, Sys.TMsg.ข้อความ, Nothing, "")
    End Sub
    Public Sub xMessageBoxRWM_ค้นหาไม่พบ(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ค้นหาไม่พบ, 210, 100, Sys.TMsg.ข้อความ, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_บันทึกสำเร็จ(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.บันทึกสำเร็จ, 210, 100, Sys.TMsg.ข้อความ, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_ส่งสำเร็จ(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ส่งสำเร็จ, 210, 100, Sys.TMsg.ข้อความ, Nothing, "")
    End Sub
    Public Sub xMessageBoxRWM_ลบข้อมูลเสร็จเรียบร้อย(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ลบข้อมูลเสร็จเรียบร้อย, 210, 100, Sys.TMsg.ข้อความ, "", "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาเลือกหมวด(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาเลือกหมวด, 210, 100, Sys.TMsg.Alert, "", "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาเลือกหลักสูตร(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาเลือกหลักสูตร, 210, 100, Sys.TMsg.Alert, "", "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาระบุรหัสหลักสูตร(RM As RadWindowManager, Optional ByVal callBackFunc As String = "")
        RM.RadAlert(Sys.TMsg.กรุณาระบุรหัสหลักสูตร, 230, 100, Sys.TMsg.Alert, callBackFunc, "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาระบุชื่อหลักสูตร(RM As RadWindowManager, Optional ByVal callBackFunc As String = "")
        RM.RadAlert(Sys.TMsg.กรุณาระบุชื่อหลักสูตร, 210, 100, Sys.TMsg.Alert, callBackFunc, "")
    End Sub

    Public Sub xMessageBoxRWM_บันทึกไม่สำเร็จ(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.บันทึกไม่สำเร็จ, 210, 100, Sys.TMsg.Alert, "", "")
    End Sub

    Public Sub xMessageBoxRWM_ถูกใช้งานอยู่(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ถูกใช้งานอยู่, 210, 100, Sys.TMsg.Alert, "", "")
    End Sub

    Public Sub xMessageBoxRWM_ไม่พบไฟล์(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ไม่พบไฟล์, 210, 100, Sys.TMsg.Alert, "", "")
    End Sub
    Public Sub xMessageBoxRWM_มีไฟล์นี้ในระบบแล้ว(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.มีไฟล์นี้ในระบบแล้ว, 210, 100, Sys.TMsg.Alert, "", "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาบันทึกลำดับก่อนหน้า(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาบันทึกลำดับก่อนหน้า, 290, 100, Sys.TMsg.Alert, "", "")
    End Sub
    <Extension()> _
    Public Sub xMessageBoxRWM_ลบเสร็จเรียบร้อย(RM As RadWindowManager, ByVal Page As System.Web.UI.Page)
        Dim AlertMessage As String = "AlertMessage('" + Sys.TMsg.ลบข้อมูลเสร็จเรียบร้อย + "', 260, 100,'" + Sys.TMsg.ข้อความ + "');"
        ' Page.ClientScript.RegisterStartupScript(Page.GetType, "SetStyle", AlertMessage, True)


        ScriptManager.RegisterStartupScript(Page, Page.GetType, "myKey", AlertMessage, True)
    End Sub

    Public Sub xMessageBoxRWM_คุณต้องการที่จะบันทึกการเพิ่มข้อมูลใช่หรือไม่(RM As RadWindowManager)
        RM.RadConfirm(Sys.TMsg.คุณต้องการที่จะบันทึกการเพิ่มข้อมูลใช่หรือไม่, "confirmCallBackFn", 390, 100, Nothing, Sys.TMsg.คำเตือน)
    End Sub

    Public Sub xMessageBoxRWM_คุณต้องการที่จะบันทึกการแก้ไขข้อมูลใช่หรือไม่(RM As RadWindowManager)
        RM.RadConfirm(Sys.TMsg.คุณต้องการที่จะบันทึกการแก้ไขข้อมูลใช่หรือไม่, "confirmCallBackFn", 390, 100, Nothing, Sys.TMsg.คำเตือน)
    End Sub

    Public Sub xMessageBoxRWM_คุณต้องการที่จะประมวลผลใช่หรือไม่(RM As RadWindowManager)
        RM.RadConfirm(Sys.TMsg.คุณต้องการที่จะประมวลผลใช่หรือไม่, "confirmCallBackFn", 290, 100, Nothing, Sys.TMsg.คำเตือน)
    End Sub

    Public Sub xMessageBoxRWM_คุณต้องการที่จะลบข้อมูลใช่หรือไม่(RM As RadWindowManager)
        RM.RadConfirm(Sys.TMsg.คุณต้องการที่จะลบข้อมูลใช่หรือไม่, "confirmCallBackFn", 290, 100, Nothing, Sys.TMsg.คำเตือน)
    End Sub

    Public Sub xMessageBoxRWM_คุณต้องการที่จะประมวลผล(RM As RadWindowManager)
        RM.RadConfirm(Sys.TMsg.คุณต้องการที่จะประมวลผล, "confirmCallBackFn", 290, 100, Nothing, Sys.TMsg.คำเตือน)
        'RM.RadConfirm(If(Sys.LoginWeb.Lang = "T", "คุณต้องการที่จะลบข้อมูลใช่หรือไม่", "Are you sure want to Delete Data ?"), "confirmCallBackFn", 290, 100, Nothing, Sys.TMsg.Warning)
    End Sub

    Public Sub xMessageBoxRWM_ไฟล์ที่จะ_upload_ต้องเป็น_txt_หรือ_csv_เท่านั้น(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ไฟล์ที่จะ_upload_ต้องเป็น_txt_หรือ_csv_เท่านั้น, 300, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_ตรวจสอบการตั้งค่าตำแหน่งของข้อมูลก่อน(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ตรวจสอบการตั้งค่าตำแหน่งของข้อมูลก่อน, 300, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้ได้กรุณาติดต่อผู้ดูแลระบบ, 400, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub
    Public Sub xMessageBoxRWM_Pwdผู้ใช้นี้ไม่สามารถเข้าโปรแกรมนี้(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.รหัสผ่านไม่ถูกต้อง, 400, 200, Sys.TMsg.Alert, Nothing, "")
    End Sub
    Public Sub xMessageBoxRWM_คุณไม่มีสิทธิใช้งานบริษัทนี้(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.PermissionCompany, 280, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาเลือกรหัสพนักงาน(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาเลือกรหัสพนักงาน, 220, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาเลือกColumns(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาเลือกColumns, 230, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_กรุณาใส่ชื่อไฟล์(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาใส่ชื่อไฟล์, 220, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_ไม่พบพนักงาน(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.ไม่พบพนักงาน, 210, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub
    Public Sub xMessageBoxRWM_กรุณาระบุคะแนนหลักสูตร(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาระบุคะแนนหลักสูตร, 240, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub
    Public Sub xMessageBoxRWM_กรุณาระบุเกรดหลักสูตร(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.กรุณาระบุเกรดหลักสูตร, 240, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub

    Public Sub xMessageBoxRWM_จำนวนชั่วโมงรวมน้อยกว่า6ชั่วโมง(RM As RadWindowManager)
        RM.RadAlert(Sys.TMsg.จำนวนชั่วโมงรวมน้อยกว่า6ชั่วโมง, 240, 100, Sys.TMsg.Alert, Nothing, "")
    End Sub
End Module

