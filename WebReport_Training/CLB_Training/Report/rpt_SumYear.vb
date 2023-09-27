Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization
Partial Public Class rpt_SumYear
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "rpt_SumYear"  ' รหัสรายงาน
    Public ShowDetail As Boolean = True   ' แสดงรายละเอียด
    Public ShowGroupCm1 As Boolean = True  ' สำหรับแสดง Group รายงาน
    Public ShowTxtReport As String = ""  ' แสดงข้อความต่อท้าย รายงาน 
    Public ConfigReport As New CLB_Function 'สำหรับการ ตั้งค่า การใช้งานต่างๆ
    Public GroupNameTree As String = " "  'จัดกลุ่มรายงาน Tree ด้านซ้าย
    Public GroupCm1_NewPageAfter As Boolean = False ' สำหรับ การขขึ้นหน้าใหม่เมื่อหมดกลุ่ม

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rpt_SumYear_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        ShowGroupReport()


    End Sub
    Public Shared Function dateFormatTT(ByVal dateF, ByVal T) As String 'เปลี่ยน คศ เป็น พศ
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

    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา

        ' txtYear.Value = ConfigReport.GET_TEXT1

    End Sub

End Class