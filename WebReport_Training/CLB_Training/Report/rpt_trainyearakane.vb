Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rpt_trainyearakane
    Inherits Telerik.Reporting.Report

    Const CodeReport As String = "rpt_trainyearakane"  ' รหัสรายงาน
    Public ShowDetail As Boolean = True   ' แสดงรายละเอียด
    Public ShowGroupCm1 As Boolean = True  ' สำหรับแสดง Group รายงาน
    Public ShowTxtReport As String = ""  ' แสดงข้อความต่อท้าย รายงาน 
    Public ConfigReport As New CLB_Function 'สำหรับการ ตั้งค่า การใช้งานต่างๆ
    Public GroupNameTree As String = " "  'จัดกลุ่มรายงาน Tree ด้านซ้าย
    Public GroupCm1_NewPageAfter As Boolean = False ' สำหรับ การขขึ้นหน้าใหม่เมื่อหมดกลุ่ม

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rpt_trainyearakane_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding

        DataSource.ConnectionString = ConfigReport.SQL_Connection

        'ShowGroupReport()

    End Sub
    'Sub ShowGroupReport()
    '    Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา

    '    detail.DocumentMapText = "= Fields.PersonCode + ' ' +  Fields.InitialName + ' ' + Fields.FnameT + ' ' + Fields.LnameT "


    'End Sub
End Class