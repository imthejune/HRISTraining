Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization


Partial Public Class rpt_007_03


    Inherits Telerik.Reporting.Report
    Public ConfigReport As New CLB_Function 'สำหรับการ ตั้งค่า การใช้งานต่างๆ
    Public ckCom_ As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub rpt_ApplyForJobs_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''ภาษา
        '---- โหลดครั้งแรก
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        Lang()  ' เปลี่ยนภาษา

        'If ckCom_ = "Stonehenge" Then
        '    GroupHeaderSection.Visible = False
        '    detail.Visible = False
        '    GroupFooterSection.Visible = True
        'Else
        '    GroupHeaderSection.Visible = True
        '    detail.Visible = True
        '    GroupFooterSection.Visible = False
        'End If
    End Sub
    Sub Lang()
        '' การตั้งชื่อ ตัวแปลที่เป็นข้อความ คือตั้งชื่อขึ้นต้นด้วย  Lbl เพื่อให้ระบบแปลงเก็บลงฐาน
        If ConfigReport.ShowLang <> "T" Then
            'โหลดภาษา และเปลี่ยนภาษา
            SetLabel(Me.pageFooterSection1)
            SetLabel(Me.pageHeaderSection1)
            SetLabel(Me.groupHeaderSection)
            SetLabel(Me.groupFooterSection)
            SetLabel(Me.detail)
            Me.groupHeaderSection.Visible = True



            'ConfigReport.ChangNamePerson(txt_PositionJob2)
            'ConfigReport.ChangNamePerson(txt_Company_Name2)
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