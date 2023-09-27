Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_TNR1_007_14
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_007_14"  ' รหัสรายงาน
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
                ret = CType(dateF, DateTime).ToString("dd/MM/yyyy", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("dd/MM/yyyy", New CultureInfo("en-US"))
            End If
            Return ret
        Catch ex As Exception
            Return ""
        End Try

    End Function

    'Private Sub rpt_TNR1_007_14_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
    '    '---- โหลดครั้งแรก
    '    DataSource.ConnectionString = ConfigReport.SQL_Connection

    '    ShowGroupReport()
    '    'Lang()  ' เปลี่ยนภาษา
    'End Sub
    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา

        If ShowGroupCm1 = False Then
            Me.groupHeaderSection.Visible = False
            Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
            Me.groupFooterSection.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            ' Me.groupHeaderSection.Visible = True
        End If

        If GroupCm1_NewPageAfter = True Then
            Me.groupFooterSection.PageBreak = PageBreak.After
        End If

        'Me.Groups(0).Groupings.RemoveAt(0)
        'Me.Groups(0).Groupings.Add("= Fields.Patern_Date ")
        'Me.Groups(0).DocumentMapText = "= Fields.Patern_Date "


        '    Me.Groups(1).Groupings.RemoveAt(0)
        '    Me.Groups(1).Groupings.Add(" = Fields.cmb2Name ")

        ' GroupNameTree = "= Fields.Cmb2Code"
        'Me.Groups(0).Groupings.Add(GroupNameTree)
        'Me.Groups(0).DocumentMapText = GroupNameTree


        If Not String.IsNullOrEmpty(GroupNameTree.Trim()) Then
            Me.Groups(0).Groupings.Add(GroupNameTree)
            Me.Groups(0).DocumentMapText = GroupNameTree
            '  Me.TextBox21.Value = GroupNameTree
        End If

        'Me.Txt_GroupCM1.Value = GroupNameTree


        '----------------------------big บังไว้ Error ต้องกลับมาเองออก Start
        ConfigReport.detailPerson_DocumentMapText(Me.detail)   ' จัดกลุ่ม พนักงาน

        ''== 20181218 เพิ่มขึ้นหน้าใหม่รหัสพนักงาน
        'If GroupPersonID_NewPageAfter = True Then
        '    Me.groupHeaderSection.PageBreak = PageBreak.After
        '    Me.groupFooterSection2.PageBreak = PageBreak.After
        '    Me.groupHeaderSection.KeepTogether = False
        '    Me.groupHeaderSection2.KeepTogether = False
        '    Me.detail.KeepTogether = False
        'Else
        '    Me.groupFooterSection2.PageBreak = PageBreak.None
        'End If

        If ShowDetail = False Then
            '++++++++++ ไม่แสดงรายละเอียด
            Me.detail.Visible = False
            Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            Me.detail.Visible = True
        End If
        '----------------------------big บังไว้ Error ต้องกลับมาเองออก End
    End Sub

    Private Sub rpt_TNR1_007_14_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- โหลดครั้งแรก
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        Call ShowGroupReport()  ' แสดง Group รายงาน
    End Sub
End Class