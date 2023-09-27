Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rpt_Config_Course
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_026_02"  ' ������§ҹ
    Public ShowDetail As Boolean = True   ' �ʴ���������´
    Public ShowGroupCm1 As Boolean = True  ' ����Ѻ�ʴ� Group ��§ҹ
    Public ShowTxtReport As String = ""  ' �ʴ���ͤ�����ͷ��� ��§ҹ 
    Public ConfigReport As New CLB_Function '����Ѻ��� ��駤�� �����ҹ��ҧ�
    Public GroupNameTree As String = " "  '�Ѵ�������§ҹ Tree ��ҹ����
    Public GroupCm1_NewPageAfter As Boolean = False ' ����Ѻ ��â���˹�������������������

    Public Sub New()
        InitializeComponent()
    End Sub

    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''����

        'If ShowGroupCm1 = False Then
        '    Me.groupHeaderSection.Visible = False
        '    Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
        '    Me.groupFooterSection.Height = New Telerik.Reporting.Drawing.Unit(0)
        'Else
        '    Me.groupHeaderSection.Visible = True
        'End If

        'If GroupCm1_NewPageAfter = True Then
        '    Me.groupFooterSection.PageBreak = PageBreak.After
        'End If

        'Me.Groups(0).Groupings.RemoveAt(0)
        'Me.Groups(0).Groupings.Add(GroupNameTree)
        'Me.Groups(0).DocumentMapText = GroupNameTree
        'Me.Txt_GroupCM1.Value = GroupNameTree

        'ConfigReport.detailPerson_DocumentMapText(Me.detail)   ' �Ѵ����� ��ѡ�ҹ

        If ShowDetail = False Then
            '++++++++++ ����ʴ���������´
            Me.detail.Visible = False
            Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            Me.detail.Visible = True
        End If

    End Sub


    Private Sub rpt_Config_Course_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        Me.Txt_CompanyName.Value = ConfigReport.LoadCompanyName() ' �����§ҹ ���ͺ���ѷ

        Try
            Me.pic_Logo.Value = ConfigReport.LogoCompany
        Catch ex As Exception
        End Try

        'ShowGroupReport()  ' �ʴ� Group ��§ҹ

        Me.Txt_ISO.Value = ConfigReport.GET_ISO(CodeReport)  ' ISO
        Me.TxtDatePrint.Value = ConfigReport.GET_DatePrint   ' �ѹ��� ���� ���¡�д��
        Me.Txt_ReportName.Value = ConfigReport.ReportName & " " & ShowTxtReport  ' �ʴ������§ҹ

        Lang()  ' ����¹����

    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    Sub Lang()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''����
        '' ��õ�駪��� ����ŷ���繢�ͤ��� ��͵�駪��͢�鹵鹴���  Lbl ��������к��ŧ��ŧ�ҹ
        If ConfigReport.ShowLang <> "T" Then
            '��Ŵ���� �������¹����
            SetLabel(Me.pageFooterSection1)
            SetLabel(Me.pageHeaderSection1)
            'SetLabel(Me.groupHeaderSection)
            'SetLabel(Me.groupFooterSection)
            'SetLabel(Me.detail)
            '-- ����Ѻ�������¹ ���� - ���ʡ�����������
            ' If txt_Holiday_Date.Name = "txt_Holiday_Date" Then txt_Holiday_Date.Value = String.Format("=Fields.Initial{0}", ConfigReport.ShowLang)
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
