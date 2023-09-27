Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_TNR1_006_03
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_006_03"  ' ������§ҹ
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
    Private Sub rpt_TNR1_006_03_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        'Dim rpt As rpt_TNR1_006_02 = New rpt_TNR1_006_02()
        'Dim directory As String = My.Application.Info.DirectoryPath


        Dim P1 As New Telerik.Reporting.Parameter
        Dim P2 As New Telerik.Reporting.Parameter
        'Dim P3 As New Telerik.Reporting.Parameter

        P1.Name = "GUID_Patern"
        P1.Value = "=Fields.GUID_Patern"


        Dim rpt_sub_professor1 As New rpt_sub_professor
        rpt_sub_professor1.ConfigReport = ConfigReport
        rpt_sub_professor.ReportSource = rpt_sub_professor1
        rpt_sub_professor.Parameters.Add(P1)



        ShowGroupReport()
        'Lang()  ' ����¹����
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
            Me.groupFooterSection.PageBreak = PageBreak.After
        End If



        TextBox9.Value = ConfigReport.GET_TEXT1
        TextBox10.Value = ConfigReport.GET_TEXT2


       

        Me.Groups(0).Groupings.RemoveAt(0)
        Me.Groups(0).Groupings.Add("= Fields.Patern_Date ")
        Me.Groups(0).DocumentMapText = "= Fields.Patern_Date "


        detail.DocumentMapText = "= Fields.TotalHour + '  ' + Fields.PaternRefName + '  (' + Fields.Patern_N + ')' "

        'Me.Groups(0).Groupings.RemoveAt(0)
        'Me.Groups(0).Groupings.Add("= Fields.OrganizeName ")
        'Me.Groups(0).DocumentMapText = "=  '˹��§ҹ ' +  Fields.OrganizeName "

        'Me.Groups(1).Groupings.RemoveAt(0)
        'Me.Groups(1).Groupings.Add(" = Fields.PaternRefName ")
        'Me.Groups(1).DocumentMapText = "=  'asdfasd ' +  Fields.PaternRefName "
        'If Not String.IsNullOrEmpty(GroupNameTree.Trim()) Then
        '    Me.Groups(1).Groupings.Add(GroupNameTree)
        '    Me.Groups(1).DocumentMapText = GroupNameTree
        'End If

        'Me.Txt_GroupCM1.Value = GroupNameTree




        ' ConfigReport.detailPerson_DocumentMapText(Me.detail)   ' �Ѵ����� ��ѡ�ҹ

        ''== 20181218 �������˹���������ʾ�ѡ�ҹ
        'If GroupPersonID_NewPageAfter = True Then
        '    Me.groupHeaderSection.PageBreak = PageBreak.After
        '    Me.groupFooterSection2.PageBreak = PageBreak.After
        '    Me.groupHeaderSection.KeepTogether = False
        '    Me.groupHeaderSection2.KeepTogether = False
        '    Me.detail.KeepTogether = False
        'Else
        '    Me.groupFooterSection2.PageBreak = PageBreak.None
        'End If

        'If ShowDetail = False Then
        '    '++++++++++ ����ʴ���������´
        '    Me.detail.Visible = False
        '    Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0)
        'Else
        '    Me.detail.Visible = True
        'End If

    End Sub
End Class