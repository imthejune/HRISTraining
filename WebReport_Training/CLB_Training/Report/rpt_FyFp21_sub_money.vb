Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rpt_FyFp21_sub_money
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_026_02"  ' รหัสรายงาน
    Public ShowDetail As Boolean = True   ' แสดงรายละเอียด
    Public ShowGroupCm1 As Boolean = True  ' สำหรับแสดง Group รายงาน
    Public ShowTxtReport As String = ""  ' แสดงข้อความต่อท้าย รายงาน 
    Public ConfigReport As New CLB_Function 'สำหรับการ ตั้งค่า การใช้งานต่างๆ
    Public GroupNameTree As String = " "  'จัดกลุ่มรายงาน Tree ด้านซ้าย
    Public GroupCm1_NewPageAfter As Boolean = False ' สำหรับ การขขึ้นหน้าใหม่เมื่อหมดกลุ่ม


    Public Sub New()
        InitializeComponent()
    End Sub

    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา





    End Sub


    Private Sub rpt_FyFp21_sub_money_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- โหลดครั้งแรก
        DataSource.ConnectionString = ConfigReport.SQL_Connection
        Lang()  ' เปลี่ยนภาษา
        Select Case Me.ReportParameters("m").Value
            Case "1"
                TextBox3.Value = "= Fields.b1"
            Case "2"
                TextBox3.Value = "= Fields.b2"
            Case "3"
                TextBox3.Value = "= Fields.b3"
            Case "4"
                TextBox3.Value = "= Fields.b4"
            Case "5"
                TextBox3.Value = "= Fields.b5"
            Case "6"
                TextBox3.Value = "= Fields.b6"
            Case "7"
                TextBox3.Value = "= Fields.b7"
            Case "8"
                TextBox3.Value = "= Fields.b8"
            Case "9"
                TextBox3.Value = "= Fields.b9"
            Case "10"
                TextBox3.Value = "= Fields.b10"
            Case "11"
                TextBox3.Value = "= Fields.b11"
            Case "12"
                TextBox3.Value = "= Fields.b12"
            Case "13"
                TextBox3.Value = "= Fields.b13"
            Case "14"
                TextBox3.Value = "= Fields.b14"
            Case "15"
                TextBox3.Value = "= Fields.b15"
            Case "16"
                TextBox3.Value = "= Fields.b16"
            Case "17"
                TextBox3.Value = "= Fields.PaternExp"
        End Select
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    Sub Lang()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา
        '' การตั้งชื่อ ตัวแปลที่เป็นข้อความ คือตั้งชื่อขึ้นต้นด้วย  Lbl เพื่อให้ระบบแปลงเก็บลงฐาน
        If ConfigReport.ShowLang <> "T" Then
            'โหลดภาษา และเปลี่ยนภาษา
            SetLabel(Me.pageFooterSection1)
            SetLabel(Me.pageHeaderSection1)
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
