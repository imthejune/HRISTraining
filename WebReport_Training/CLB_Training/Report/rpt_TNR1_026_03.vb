Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_TNR1_026_03
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_026_03"  ' รหัสรายงาน
    Public ShowDetail As Boolean = True   ' แสดงรายละเอียด
    Public ShowGroupCm1 As Boolean = True  ' สำหรับแสดง Group รายงาน
    Public ShowTxtReport As String = ""  ' แสดงข้อความต่อท้าย รายงาน 
    Public ConfigReport As New CLB_Function 'สำหรับการ ตั้งค่า การใช้งานต่างๆ
    Public GroupNameTree As String = " "  'จัดกลุ่มรายงาน Tree ด้านซ้าย
    Public GroupCm1_NewPageAfter As Boolean = False ' สำหรับ การขขึ้นหน้าใหม่เมื่อหมดกลุ่ม
    Public Sub New()
        InitializeComponent()
    End Sub
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

    Private Sub rpt_TNR1_026_03_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        Lang()
    End Sub
    Sub Lang()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา
        '' การตั้งชื่อ ตัวแปลที่เป็นข้อความ คือตั้งชื่อขึ้นต้นด้วย  Lbl เพื่อให้ระบบแปลงเก็บลงฐาน
        If ConfigReport.ShowLang <> "T" Then
            'โหลดภาษา และเปลี่ยนภาษา
            'SetLabel(Me.pageFooterSection1)
            'SetLabel(Me.pageHeaderSection1)
            'SetLabel(Me.groupHeaderSection)

        End If
    End Sub

    Private Sub SetLabel(x As Telerik.Reporting.ReportItemBase)
        For Each obj_Text As ReportItemBase In x.Items
            If TypeOf (obj_Text) Is Telerik.Reporting.TextBox AndAlso CType(obj_Text, Telerik.Reporting.TextBox).Name.ToLower.StartsWith("lbl") = True Then
                Try
                    CType(obj_Text, Telerik.Reporting.TextBox).Value = ConfigReport.Label_Text(CType(obj_Text, Telerik.Reporting.TextBox))
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub
End Class