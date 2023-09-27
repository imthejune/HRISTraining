Imports System.Globalization
Imports Telerik.Reporting

Partial Public Class rpt_TNR1_007_03
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_007_03"  ' ������§ҹ
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
                ret = CType(dateF, DateTime).ToString("dd/MM/yyyy", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("dd/MM/yyyy", New CultureInfo("en-US"))
            End If
            Return ret
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''����

        If ShowGroupCm1 = False Then
            Me.groupHeaderSection.Visible = False
            Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
            Me.groupFooterSection.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            'big �ѧ�������� Visble ��ҹ˹������
            'Me.groupHeaderSection.Visible = True
            'Me.groupHeaderSection1.Visible = True
            'Me.groupHeaderSection1.Height = New Telerik.Reporting.Drawing.Unit(0)
        End If


        If GroupCm1_NewPageAfter = True Then
            Me.groupFooterSection.PageBreak = PageBreak.After
        End If

        'Me.Groups(0).Groupings.RemoveAt(0)
        'Me.Groups(0).Groupings.Add("= Fields.Patern_Date ")
        'Me.Groups(0).DocumentMapText = "= Fields.Patern_Date "


        '    Me.Groups(1).Groupings.RemoveAt(0)
        '    Me.Groups(1).Groupings.Add(" = Fields.cmb2Name ")

        If Not String.IsNullOrEmpty(GroupNameTree.Trim()) Then
            Me.Groups(0).Groupings.RemoveAt(0)
            Me.Groups(0).Groupings.Add(GroupNameTree)
            Me.Groups(0).DocumentMapText = GroupNameTree
            'Me.TextBox9.Visible = True
            'Me.TextBox9.Value = GroupNameTree
            'Me.Txt_GroupCM1.Value = ConfigReport.GroupNameTree
            '   Me.TextBox9.Value = GroupNameTree
            ''test
            'Me.Groups(0).Groupings.RemoveAt(0)
            'Me.Groups(0).Groupings.Add(GroupNameTree)
            'Me.Groups(0).DocumentMapText = GroupNameTree
            '' Me.Txt_GroupCM1.Value = GroupNameTree


        End If

        'Me.Groups(0).Groupings.RemoveAt(0)
        'Me.Groups(0).Groupings.Add(GroupNameTree)
        'Me.Groups(0).DocumentMapText = GroupNameTree
        'Me.TextBox9.Value = GroupNameTree

        'Me.Txt_GroupCM1.Value = GroupNameTree

        'Dim GroupNameTree_First = Split(ConfigReport.GroupNameTree & "", " + ' ' ")
        ' Me.Txt_CM2.Value = GroupNameTree_First(0) '�ʴ������á��� ���
        ConfigReport.detailPerson_DocumentMapText(Me.detail)   ' �Ѵ����� ��ѡ�ҹ

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

        If ShowDetail = False Then
            '++++++++++ ����ʴ���������´
            Me.detail.Visible = False
            Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            Me.detail.Visible = True
        End If

    End Sub
    'Sub ShowGroupReport()
    '    Me.Culture = New System.Globalization.CultureInfo("en-US") ''����

    '    If ShowGroupCm1 = False Then
    '        Me.groupHeaderSection.Visible = False
    '        Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
    '        Me.groupFooterSection.Height = New Telerik.Reporting.Drawing.Unit(0)
    '    Else
    '        Me.groupHeaderSection.Visible = True
    '    End If

    '    If GroupCm1_NewPageAfter = True Then
    '        Me.groupFooterSection.PageBreak = PageBreak.After
    '    End If

    '    Me.Groups(0).Groupings.RemoveAt(0)
    '    Me.Groups(0).Groupings.Add(ConfigReport.GroupNameTree)
    '    Me.Groups(0).DocumentMapText = ConfigReport.GroupNameTree
    '    'Me.Txt_GroupCM1.Value = ConfigReport.GroupNameTree
    '    Me.TextBox9.Value = ConfigReport.GroupNameTree
    '    Dim GroupNameTree_First = Split(ConfigReport.GroupNameTree & "", " + ' ' ")
    '    ' Me.Txt_CM2.Value = GroupNameTree_First(0) '�ʴ������á��� ���

    '    ConfigReport.detailPerson_DocumentMapText(Me.detail)   ' �Ѵ����� ��ѡ�ҹ

    '    'If ShowDetail = False Then
    '    '    '++++++++++ ����ʴ���������´
    '    '    Call ShowDetail_Check(False)

    '    'Else
    '    '    Call ShowDetail_Check(True)
    '    'End If
    'End Sub
    Private Sub rpt_TNR1_007_03_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection


        'Dim Parameter_Person As New Telerik.Reporting.Parameter
        'Parameter_Person.Name = "PersonID"
        'Parameter_Person.Value = "=Fields.PersonID"

        'Dim Sub_rptdetail As New Sub_rpt_007_03
        'Sub_rptdetail.ConfigReport = ConfigReport
        'Sub_rpt_007_03.ReportSource = Sub_rptdetail
        'Sub_rpt_007_03.Parameters.Add(Parameter_Person)


        Dim testOutSidersPerson As New rpt_007_03
        testOutSidersPerson.ConfigReport = ConfigReport
        SubReport1.ReportSource = testOutSidersPerson
        Dim P1 As New Telerik.Reporting.Parameter
        P1.Name = "PersonID"
        P1.Value = "= Fields.personid"
        SubReport1.Parameters.Add(P1)

        ShowGroupReport()
        'Lang()  ' ����¹����
    End Sub
End Class