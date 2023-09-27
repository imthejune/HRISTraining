Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_TNR1_007_08
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = "TNR1_007_08"  ' ������§ҹ
    Public ShowDetail As Boolean = True   ' �ʴ���������´
    Public ShowGroupCm1 As Boolean = True  ' ����Ѻ�ʴ� Group ��§ҹ
    Public ShowTxtReport As String = ""  ' �ʴ���ͤ�����ͷ��� ��§ҹ 
    Public ConfigReport As New CLB_Function '����Ѻ��� ��駤�� �����ҹ��ҧ�
    Public GroupNameTree As String = " "  '�Ѵ�������§ҹ Tree ��ҹ����
    Public GroupCm1_NewPageAfter As Boolean = False ' ����Ѻ ��â���˹�������������������
    Public Sub New()
        InitializeComponent()
        ' ShowGroupReport()
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
    Sub ShowGroupReport()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''����

        If ShowGroupCm1 = False Then
            Me.groupHeaderSection.Visible = False
            Me.groupHeaderSection.Height = New Telerik.Reporting.Drawing.Unit(0)
            Me.groupFooterSection.Height = New Telerik.Reporting.Drawing.Unit(0)
        Else
            Me.groupHeaderSection.Visible = True
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
            Me.Groups(0).Groupings.Add(GroupNameTree)
            Me.Groups(0).DocumentMapText = GroupNameTree
        End If

        'Me.Txt_GroupCM1.Value = GroupNameTree

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

    Private Sub rpt_TNR1_007_08_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection


        ShowGroupReport()
        Lang()  ' ����¹����
    End Sub
    Sub Lang()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''����
        '' ��õ�駪��� ����ŷ���繢�ͤ��� ��͵�駪��͢�鹵鹴���  Lbl ��������к��ŧ��ŧ�ҹ
        If ConfigReport.ShowLang <> "T" Then
            '��Ŵ���� �������¹����
            'SetLabel(Me.pageFooterSection1)
            'SetLabel(Me.pageHeaderSection1)
            'SetLabel(Me.groupHeaderSection)
            'SetLabel(Me.groupFooterSection)
            'SetLabel(Me.detail)
            '-- ����Ѻ�������¹ ���� - ���ʡ�����������
            'If txtHeader1.Name = "txtHeader1" Then txtHeader1.Value = String.Format("=Fields.Group{0}", ConfigReport.ShowLang)
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