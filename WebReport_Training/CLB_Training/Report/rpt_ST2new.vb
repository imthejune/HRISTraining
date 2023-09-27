Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
'Imports CLB_Training

Partial Public Class rpt_ST2new
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_026_01"  ' รหัสรายงาน
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
        TextBox26.Value = ConfigReport.GET_TEXT1
        TextBox27.Value = ConfigReport.GET_TEXT2

        TextBox236.Value = ConfigReport.GET_TEXT1
        TextBox235.Value = ConfigReport.GET_TEXT2

        TextBox79.Value = ConfigReport.GET_TEXT11
        TextBox80.Value = ConfigReport.GET_TEXT12
        TextBox81.Value = ConfigReport.GET_TEXT13
        TextBox82.Value = ConfigReport.GET_TEXT14
        TextBox83.Value = ConfigReport.GET_TEXT15
        TextBox84.Value = ConfigReport.GET_TEXT16
        TextBox85.Value = ConfigReport.GET_TEXT17
        TextBox86.Value = ConfigReport.GET_TEXT18
        TextBox87.Value = ConfigReport.GET_TEXT19
        TextBox88.Value = ConfigReport.GET_TEXT20
        If ConfigReport.GET_TEXT3 <> "" Then
            TextBox30.Value = ConfigReport.GET_TEXT3.ToString.Split("/")(0)
            TextBox32.Value = ConfigReport.GET_TEXT3.ToString.Split("/")(1)
            TextBox31.Value = ConfigReport.GET_TEXT3.ToString.Split("/")(2)
            TextBox232.Value = ConfigReport.GET_TEXT3.ToString.Split("/")(0)
            TextBox230.Value = ConfigReport.GET_TEXT3.ToString.Split("/")(1)
            TextBox231.Value = ConfigReport.GET_TEXT3.ToString.Split("/")(2)
        End If

        HtmlTextBox8.Visible = ConfigReport.GET_CHECK1
        HtmlTextBox9.Visible = ConfigReport.GET_CHECK2
        HtmlTextBox7.Visible = ConfigReport.GET_CHECK3

        'If ShowDetail = False Then
        '    '++++++++++ ไม่แสดงรายละเอียด
        '    Me.detail.Visible = False
        '    Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0)
        'Else
        '    Me.detail.Visible = True
        'End If

    End Sub


    Private Sub rpt_Config_Group_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- โหลดครั้งแรก
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        ShowGroupReport()
        Lang()  ' เปลี่ยนภาษา

    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    Sub Lang()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา
        '' การตั้งชื่อ ตัวแปลที่เป็นข้อความ คือตั้งชื่อขึ้นต้นด้วย  Lbl เพื่อให้ระบบแปลงเก็บลงฐาน
        If ConfigReport.ShowLang <> "T" Then
            'โหลดภาษา และเปลี่ยนภาษา
            'SetLabel(Me.pageFooterSection1)
            'SetLabel(Me.pageHeaderSection1)
            'SetLabel(Me.groupHeaderSection)
            'SetLabel(Me.groupFooterSection)
            'SetLabel(Me.detail)
            '-- สำหรับการเปลี่ยน ชื่อ - นามสกุลเป็นภาษาอื่น
            'If txtHeader1.Name = "txtHeader1" Then txtHeader1.Value = String.Format("=Fields.Group{0}", ConfigReport.ShowLang)
            'onfigReport.ChangNamePerson(txt_SurName)

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
