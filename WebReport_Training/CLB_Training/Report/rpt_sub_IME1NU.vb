Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_sub_IME1NU
    Inherits Telerik.Reporting.Report


    Const CodeReport As String = "rpt_sub_IME1NU"  ' รหัสรายงาน
    Public ShowDetail As Boolean = True   ' แสดงรายละเอียด
    Public ShowGroupCm1 As Boolean = True  ' สำหรับแสดง Group รายงาน
    Public ShowTxtReport As String = ""  ' แสดงข้อความต่อท้าย รายงาน 
    Public ConfigReport As New CLB_Function 'สำหรับการ ตั้งค่า การใช้งานต่างๆ
    Public GroupNameTree As String = " "  'จัดกลุ่มรายงาน Tree ด้านซ้าย
    Public GroupCm1_NewPageAfter As Boolean = False ' สำหรับ การขขึ้นหน้าใหม่เมื่อหมดกลุ่ม

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rpt_sub_IME1NU_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- โหลดครั้งแรก
        DataSource.ConnectionString = ConfigReport.SQL_Connection

    End Sub

    Public Shared Function dateFormat(ByVal dateF, ByVal T) As String 'เปลี่ยน คศ เป็น พศ
        Try
            If IsNothing(dateF) Then
                Return ""
                Exit Function
            End If
            Dim ret As String = ""
            If T = "T" Then
                ret = CType(dateF, DateTime).ToString("dd-MM-yyyy", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("dd-MM-yyyy", New CultureInfo("en-US"))
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

    Public Shared Function CourePublic(ByVal Course) As String
        Try
            Dim tempStr As String = Course
           
            If Course = "Public" Then
                tempStr = "/"
            Else
                tempStr = ""
            End If

            Return tempStr
        Catch ex As Exception
            Return "0"
        End Try
    End Function
    Public Shared Function CoureinHouse(ByVal Course) As String
        Try
            Dim tempStr As String = Course

           If Course = "inHouse" Then

                tempStr = "/"
            Else
                tempStr = ""
            End If

            Return tempStr
        Catch ex As Exception
            Return "0"
        End Try
    End Function
    Public Shared Function CoureOJT(ByVal Course) As String
        Try
            Dim tempStr As String = Course

            If Course = "OJT" Then
                tempStr = "/"
            Else
                tempStr = ""
            End If

            Return tempStr
        Catch ex As Exception
            Return "0"
        End Try
    End Function


End Class