Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_FyFp1
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = ""  ' ������§ҹ
    Public ShowDetail As Boolean = True   ' �ʴ���������´
    Public ShowGroupCm1 As Boolean = True  ' ����Ѻ�ʴ� Group ��§ҹ
    Public ShowTxtReport As String = ""  ' �ʴ���ͤ�����ͷ��� ��§ҹ 
    Public ConfigReport As New CLB_Function '����Ѻ��� ��駤�� �����ҹ��ҧ�
    Public GroupNameTree As String = " "  '�Ѵ�������§ҹ Tree ��ҹ����
    Public GroupCm1_NewPageAfter As Boolean = False ' ����Ѻ ��â���˹�������������������
    Public txt_by As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Shared Function dateFormat(ByVal dateF, ByVal T) As String '����¹ �� �� ��
        Try
            Dim ret As String = ""
            If T = "T" Then
                ret = CType(dateF, DateTime).ToString("dd-MMMM-yyyy", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("dd-MMMM-yyyy", New CultureInfo("en-US"))
            End If
            Return ret
        Catch ex As Exception
            Return ""
        End Try

    End Function
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

        txt_From.Value = ConfigReport.GET_TEXT1 '��
        TextBox119.Value = ConfigReport.GET_TEXT2 '��������´�������ǡѺ��ѡ�ٵ���Ф�������㹡�ý֡ͺ��������ѡ�ٵ�
        TextBox120.Value = ConfigReport.GET_TEXT3 '��ª��ͼ���Ѻ��ý֡ͺ��
        TextBox121.Value = ConfigReport.GET_TEXT4 '������ѡ�ҹ��������㹡�ý֡ͺ��
        TextBox123.Value = ConfigReport.GET_TEXT5 '���˹�
        HtmlTextBox3.Visible = ConfigReport.GET_CHECK1
        HtmlTextBox5.Visible = ConfigReport.GET_CHECK2
        HtmlTextBox4.Visible = ConfigReport.GET_CHECK3
        HtmlTextBox6.Visible = ConfigReport.GET_CHECK4
        HtmlTextBox11.Visible = ConfigReport.GET_CHECK5
        HtmlTextBox10.Visible = ConfigReport.GET_CHECK6
        HtmlTextBox9.Visible = ConfigReport.GET_CHECK7
        HtmlTextBox8.Visible = ConfigReport.GET_CHECK8
        HtmlTextBox7.Visible = ConfigReport.GET_CHECK9
        HtmlTextBox13.Visible = ConfigReport.GET_CHECK10
        HtmlTextBox14.Visible = ConfigReport.GET_CHECK11
        HtmlTextBox12.Visible = ConfigReport.GET_CHECK12
        'HtmlTextBox2.Visible = ConfigReport.GET_CHECK13
        'HtmlTextBox1.Visible = ConfigReport.GET_CHECK14

        'If ShowDetail = False Then
        '    '++++++++++ ����ʴ���������´
        '    Me.detail.Visible = False
        '    Me.detail.Height = New Telerik.Reporting.Drawing.Unit(0)
        'Else
        '    Me.detail.Visible = True
        'End If

    End Sub


    Private Sub rpt_Config_Group_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection

        ShowGroupReport()
        Lang()  ' ����¹����

    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
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
