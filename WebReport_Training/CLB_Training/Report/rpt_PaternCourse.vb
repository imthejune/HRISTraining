Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization
Partial Public Class rpt_PaternCourse
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "rpt_PaternCourse"  ' ������§ҹ
    Public ShowDetail As Boolean = True   ' �ʴ���������´
    Public ShowGroupCm1 As Boolean = True  ' ����Ѻ�ʴ� Group ��§ҹ
    Public ShowTxtReport As String = ""  ' �ʴ���ͤ�����ͷ��� ��§ҹ 
    Public ConfigReport As New CLB_Function '����Ѻ��� ��駤�� �����ҹ��ҧ�
    Public GroupNameTree As String = " "  '�Ѵ�������§ҹ Tree ��ҹ����
    Public GroupCm1_NewPageAfter As Boolean = False ' ����Ѻ ��â���˹�������������������

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Shared Function dateFormat(ByVal dateF, ByVal T) As String '����¹ �� �� ��
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
    Public Shared Function dateFormat2(ByVal dateF, ByVal T) As String '����¹ �� �� ��
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

    Public Shared Function GetMonth(ByVal m, ByVal T) As String 'get ������͹  
        Try
            If IsNothing(m) Then
                Return ""
                Exit Function
            End If
            Dim ret As String = ""
            If T = "T" Then
                Select Case m
                    Case "1"
                        ret = "���Ҥ�"
                    Case "2"
                        ret = "����Ҿѹ��"
                    Case "3"
                        ret = "�չҤ�"
                    Case "4"
                        ret = "����¹"
                    Case "5"
                        ret = "����Ҥ�"
                    Case "6"
                        ret = "�Զع�¹"
                    Case "7"
                        ret = "�á�Ҥ�"
                    Case "8"
                        ret = "�ԧ�Ҥ�"
                    Case "9"
                        ret = "�ѹ��¹"
                    Case "10"
                        ret = "���Ҥ�"
                    Case "11"
                        ret = "��Ȩԡ�¹"
                    Case "12"
                        ret = "�ѹ�Ҥ�"
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

    Private Sub rpt_PaternCourse_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        Dim Parameter_Professor As New Telerik.Reporting.Parameter
        Parameter_Professor.Name = "GUID_Patern"
        Parameter_Professor.Value = "=Fields.GUID_Patern"

        Dim CL_sub_professor As New rpt_sub_professor
        CL_sub_professor.ConfigReport = ConfigReport
        sub_professor.ReportSource = CL_sub_professor
        sub_professor.Parameters.Add(Parameter_Professor)


        Dim Parameter_Person As New Telerik.Reporting.Parameter
        Parameter_Person.Name = "GUID_Patern"
        Parameter_Person.Value = "=Fields.GUID_Patern"

        Dim CL_sub_Person As New rpt_sub_TrainCourse
        CL_sub_Person.ConfigReport = ConfigReport
        SubReportTrain.ReportSource = CL_sub_Person
        SubReportTrain.Parameters.Add(Parameter_Person)


        'Dim Parameter_Person As New Telerik.Reporting.Parameter
        'Parameter_Person.Name = "GUID_Patern"
        'Parameter_Person.Value = "=Fields.GUID_Patern"

        'Dim CL_sub_Person As New rpt_sub_PersonCourse
        'CL_sub_Person.ConfigReport = ConfigReport
        'sub_professor.ReportSource = CL_sub_Person
        'sub_professor.Parameters.Add(Parameter_Professor)




        'Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        'Me.SubReport.Name = "SubReport"
        'InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("GUID_Patern", "= Fields.GUID_Patern"))
        'InstanceReportSource1.ReportDocument = Me.Rpt_sub_PersonCourse1
        'Me.SubReport.ReportSource = InstanceReportSource1



        'Dim Parameter_Person As New Telerik.Reporting.Parameter
        'Parameter_Person.Name = "GUID_Patern"
        'Parameter_Person.Value = "=Fields.GUID_Patern"
        'Dim CL_sub_PersonCourse As New rpt_sub_PersonCourse

        'CL_sub_PersonCourse.ConfigReport = ConfigReport
        'SubReport.Parameters.Add(Parameter_Person)
        'SubReport.ReportSource = CL_sub_PersonCourse
        ShowGroupReport()

    End Sub
    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''����
        If ShowGroupCm1 = False Then
            Me.groupHeaderSection.Visible = False
            Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
            Me.pageFooterSection1.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            Me.groupHeaderSection.Visible = True
        End If

        If GroupCm1_NewPageAfter = True Then
            Me.groupFooterSection1.PageBreak = PageBreak.After
        End If

        Me.Groups(0).Groupings.RemoveAt(0)
        Me.Groups(0).Groupings.Add("= Fields.Patern_Date ")
        Me.Groups(0).DocumentMapText = "= Fields.Patern_Date "


        detail.DocumentMapText = "= Fields.TotalHour + '  ' + Fields.PaternRefName + '  (' + Fields.Patern_N + ')' "


    End Sub


End Class