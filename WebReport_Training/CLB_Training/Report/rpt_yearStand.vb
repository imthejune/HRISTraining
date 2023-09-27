Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_yearStand
    Inherits Telerik.Reporting.Report

    Const CodeReport As String = "rpt_yearStand"  ' รหัสรายงาน
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
    Public Shared Function dateFormat2(ByVal dateF, ByVal T) As String 'เปลี่ยน คศ เป็น พศ
        Try
            If IsNothing(dateF) Then
                Return ""
                Exit Function
            End If
            Dim ret As String = ""
            If T = "T" Then
                ret = CType(dateF, DateTime).ToString("HH:mm", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("HH:mm", New CultureInfo("en-US"))
            End If
            Return ret
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Shared Function GetMonth(ByVal m, ByVal T) As String 'get ชื่อเดือน  
        Try
            If IsNothing(m) Then
                Return ""
                Exit Function
            End If
            Dim ret As String = ""
            If T = "T" Then
                Select Case m
                    Case "1"
                        ret = "มกราคม"
                    Case "2"
                        ret = "กุมภาพันธ์"
                    Case "3"
                        ret = "มีนาคม"
                    Case "4"
                        ret = "เมษายน"
                    Case "5"
                        ret = "พฤษภาคม"
                    Case "6"
                        ret = "มิถุนายน"
                    Case "7"
                        ret = "กรกฎาคม"
                    Case "8"
                        ret = "สิงหาคม"
                    Case "9"
                        ret = "กันยายน"
                    Case "10"
                        ret = "ตุลาคม"
                    Case "11"
                        ret = "พฤศจิกายน"
                    Case "12"
                        ret = "ธันวาคม"
                End Select
            Else
                Select Case m
                    Case "1"
                        ret = "January"
                    Case "2"
                        ret = "February"
                    Case "3"
                        ret = "March"
                    Case "4"
                        ret = "April"
                    Case "5"
                        ret = "May"
                    Case "6"
                        ret = "June"
                    Case "7"
                        ret = "July"
                    Case "8"
                        ret = "August"
                    Case "9"
                        ret = "September"
                    Case "10"
                        ret = "October"
                    Case "11"
                        ret = "November"
                    Case "12"
                        ret = "December"
                End Select
            End If
            Return ret
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub rpt_yearStand_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        'Dim Parameter_YearNu2Stand As New Telerik.Reporting.Parameter
        'Parameter_YearNu2Stand.Name = "GUID_Patern"
        'Parameter_YearNu2Stand.Value = "=Fields.GUID_Patern"


        'Dim CL_sub_YearNu2Stand As New rpt_sub_yearNu2Stand
        'CL_sub_YearNu2Stand.ConfigReport = ConfigReport
        'SubYearNuStand.ReportSource = CL_sub_YearNu2Stand
        'SubYearNuStand.Parameters.Add(Parameter_YearNu2Stand)


        ShowGroupReport()
    End Sub
    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา
        If ShowGroupCm1 = False Then
            Me.groupHeaderSection.Visible = False
            Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
            Me.pageFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            Me.groupHeaderSection.Visible = True
        End If

        If GroupCm1_NewPageAfter = True Then
            Me.groupFooterSection.PageBreak = PageBreak.After
        End If

        Me.Groups(0).Groupings.RemoveAt(0)
        Me.Groups(0).Groupings.Add("= Fields.Year_Date ")
        Me.Groups(0).DocumentMapText = "= Fields.Year_Date "

     
        Me.Groups(1).Groupings.RemoveAt(0)
        Me.Groups(1).Groupings.Add("= Fields.Month_Date ")
        Me.Groups(1).DocumentMapText = "= GetMonth(Fields.Month_Date, 'T')"

        detail.DocumentMapText = "= Fields.PaternRefName  "


    End Sub
End Class