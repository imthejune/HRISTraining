Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Imports System.Globalization

Partial Public Class rptpersonintrain
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_006_07"  ' รหัสรายงาน
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


    Private Sub rptpersonintrain_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        DataSource.ConnectionString = ConfigReport.SQL_Connection
        ShowGroupReport()
    End Sub

    Sub ShowGroupReport()    ' big 20211005 เพิ่มฟังก์ชั่นเพิ่มการจัดกลุ่ม
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา
        If ShowGroupCm1 = False Then
            Me.groupHeaderSection.Visible = False
            Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
            Me.PageFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            Me.groupHeaderSection.Visible = True
        End If

        If GroupCm1_NewPageAfter = True Then
            Me.groupFooterSection1.PageBreak = PageBreak.After
        End If

        Me.Groups(0).Groupings.RemoveAt(0)
        Me.Groups(0).Groupings.Add("= Fields.SubTrainName")
        Me.Groups(0).DocumentMapText = "= 'ชื่อ-นามสกุล: ' + Fields.SubTrainName + '  ' + 'ตำแหน่ง: ' +  Fields.PrositionName"



        'detail.DocumentMapText = "= Fields.TotalHour + '  ' + Fields.PaternRefName + '  (' + Fields.Patern_N + ')' "

        ' detail.DocumentMapText = "= 'ชื่อ-นามสกุล: ' +  Fields.SubTrainName + '  ' + 'ตำแหน่ง: ' +  Fields.PrositionName "
    End Sub

End Class