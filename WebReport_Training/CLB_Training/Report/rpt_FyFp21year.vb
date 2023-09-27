Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rpt_FyFp21year
    Inherits Telerik.Reporting.Report
    Const CodeReport As String = ""  ' ������§ҹ
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


    Private Sub rpt_FyFp21year_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        ' Me.ReportParameters("Guid_Ref").Value = "=Fields.GUID_Ref"
        '20190301 peaw
        'Dim rpt As New Report1
        'rpt.ConfigReport = ConfigReport
        'SubReport1.ReportSource = rpt
        'Dim P1 As New Telerik.Reporting.Parameter
        'P1.Name = "Guid_Ref"
        'P1.Value = "=Fields.GUID_Ref"
        'SubReport1.Parameters.Add(P1)


        'Dim rpt2 As New Report2
        'rpt2.ConfigReport = ConfigReport
        'SubReport2.ReportSource = rpt2
        'Dim P2 As New Telerik.Reporting.Parameter
        'P2.Name = "Guid_Ref"
        'P2.Value = "=Fields.GUID_Ref"
        'SubReport2.Parameters.Add(P2)

        '---- ��Ŵ�����á
        ShowGroupReport()
        DataSource.ConnectionString = ConfigReport.SQL_Connection
        '---------------------------------------------

        Dim P1 As New Telerik.Reporting.Parameter
        Dim P2 As New Telerik.Reporting.Parameter
        'Dim P3 As New Telerik.Reporting.Parameter

        P1.Name = "GUID_Ref"
        P1.Value = "=Fields.GUID_Ref"

        P2.Name = "GUID_Fyfp"
        P2.Value = "=Fields.GUID_Fyfp"

        '===========�ѵ�ػ��ʧ��
        Dim rpt_FyFp21_sub_vut As New rpt_FyFp21_sub_vut
        rpt_FyFp21_sub_vut.ConfigReport = ConfigReport
        SubReport1.ReportSource = rpt_FyFp21_sub_vut
        SubReport1.Parameters.Add(P1)
        SubReport1.Parameters.Add(P2)

        '===========��������㹡�ý֡ͺ��
        Dim FyFp21_sub_time As New rpt_FyFp21_sub_time
        FyFp21_sub_time.ConfigReport = ConfigReport
        SubReport2.ReportSource = FyFp21_sub_time
        SubReport2.Parameters.Add(P1)
        SubReport2.Parameters.Add(P2)
        SubReport2.Parameters.Add("t", ConfigReport.ShowLang)

        '===========ʶҹ���֡ͺ��
        Dim FyFp21_sub_place As New rpt_FyFp21_sub_place
        FyFp21_sub_place.ConfigReport = ConfigReport
        SubReport3.ReportSource = FyFp21_sub_place
        SubReport3.Parameters.Add(P1)
        SubReport3.Parameters.Add(P2)

        '===========�ӹǹ�١��ҧ������ͺ��
        Dim FyFp21_sub_totalEmp As New rpt_FyFp21_sub_totalEmp
        FyFp21_sub_totalEmp.ConfigReport = ConfigReport
        SubReport4.ReportSource = FyFp21_sub_totalEmp
        SubReport4.Parameters.Add(P1)
        SubReport4.Parameters.Add(P2)

        '===========�س���ѵԢͧ�������Ѻ��ý֡
        Dim rpt_FyFp21_sub_qualification As New rpt_FyFp21_sub_qualification
        rpt_FyFp21_sub_qualification.ConfigReport = ConfigReport
        SubReport5.ReportSource = rpt_FyFp21_sub_qualification
        SubReport5.Parameters.Add(P1)
        SubReport5.Parameters.Add(P2)

        '===========�Է�ҡ�
        Dim FyFp21_sub_professor As New rpt_FyFp21_sub_professor
        FyFp21_sub_professor.ConfigReport = ConfigReport
        SubReport6.ReportSource = FyFp21_sub_professor
        SubReport6.Parameters.Add(P1)
        SubReport6.Parameters.Add(P2)

        '===========���Ѵ��ý֡ͺ��
        Dim rpt_FyFp21_sub_trainee As New rpt_FyFp21_sub_trainee
        rpt_FyFp21_sub_trainee.ConfigReport = ConfigReport
        SubReport7.ReportSource = rpt_FyFp21_sub_trainee
        SubReport7.Parameters.Add(P1)
        SubReport7.Parameters.Add(P2)

        '===========��Ǣ�����������
        Dim FyFp21_sub_subject As New rpt_FyFp21_sub_subject
        FyFp21_sub_subject.ConfigReport = ConfigReport
        If ConfigReport.GET_CHECK1 = True Then
            FyFp21_sub_subject.SqlDataSource1.SelectCommand = "select distinct Vt_N,Vt_Header,Vt_Name,Vt_Hour from TNT_FyfpVttopic"
            FyFp21_sub_subject.SqlDataSource1.SelectCommand += " where CONVERT(VARCHAR(50),GUID_Ref)= CONVERT(VARCHAR(50),@GUID_Ref)"
            FyFp21_sub_subject.SqlDataSource1.SelectCommand += " and CONVERT(VARCHAR(50),GUID_fyfp)= CONVERT(VARCHAR(50),@GUID_fyfp) and Add_Status = 0"
        ElseIf ConfigReport.GET_CHECK1 = False Then
            FyFp21_sub_subject.SqlDataSource1.SelectCommand = "select distinct Vt_N,Vt_Header,Vt_Name,Vt_Hour from TNT_FyfpVttopic"
            FyFp21_sub_subject.SqlDataSource1.SelectCommand += " where CONVERT(VARCHAR(50),GUID_Ref)= CONVERT(VARCHAR(50),@GUID_Ref)"
            FyFp21_sub_subject.SqlDataSource1.SelectCommand += " and CONVERT(VARCHAR(50),GUID_fyfp)= CONVERT(VARCHAR(50),@GUID_fyfp)"
        End If
        SubReport8.ReportSource = FyFp21_sub_subject
        SubReport8.Parameters.Add(P1)
        SubReport8.Parameters.Add(P2)

        '===========��ҵͺ᷹�Է�ҡ�
        Dim FyFp21_sub_money1 As New rpt_FyFp21_sub_money
        FyFp21_sub_money1.ConfigReport = ConfigReport
        SubReport9.ReportSource = FyFp21_sub_money1
        SubReport9.Parameters.Add(P1)
        SubReport9.Parameters.Add(P2)
        SubReport9.Parameters.Add("m", "1")

        '===========����Ԣ�Է���
        Dim FyFp21_sub_money2 As New rpt_FyFp21_sub_money
        FyFp21_sub_money2.ConfigReport = ConfigReport
        SubReport10.ReportSource = FyFp21_sub_money2
        SubReport10.Parameters.Add(P1)
        SubReport10.Parameters.Add(P2)
        SubReport10.Parameters.Add("m", "2")

        '===========��Ҩ�ҧ����
        Dim FyFp21_sub_money3 As New rpt_FyFp21_sub_money
        FyFp21_sub_money3.ConfigReport = ConfigReport
        SubReport11.ReportSource = FyFp21_sub_money3
        SubReport11.Parameters.Add(P1)
        SubReport11.Parameters.Add(P2)
        SubReport11.Parameters.Add("m", "3")

        '===========������͡���
        Dim FyFp21_sub_money4 As New rpt_FyFp21_sub_money
        FyFp21_sub_money4.ConfigReport = ConfigReport
        SubReport12.ReportSource = FyFp21_sub_money4
        SubReport12.Parameters.Add(P1)
        SubReport12.Parameters.Add(P2)
        SubReport12.Parameters.Add("m", "4")

        '===========����͡��û�Сͺ
        Dim FyFp21_sub_money5 As New rpt_FyFp21_sub_money
        FyFp21_sub_money5.ConfigReport = ConfigReport
        SubReport13.ReportSource = FyFp21_sub_money5
        SubReport13.Parameters.Add(P1)
        SubReport13.Parameters.Add(P2)
        SubReport13.Parameters.Add("m", "5")

        '===========��Ҩ�ҧ�����͡���
        Dim FyFp21_sub_money6 As New rpt_FyFp21_sub_money
        FyFp21_sub_money6.ConfigReport = ConfigReport
        SubReport14.ReportSource = FyFp21_sub_money6
        SubReport14.Parameters.Add(P1)
        SubReport14.Parameters.Add(P2)
        SubReport14.Parameters.Add("m", "6")

        '===========��Һѹ�֡�Ҿ������§
        Dim FyFp21_sub_money7 As New rpt_FyFp21_sub_money
        FyFp21_sub_money7.ConfigReport = ConfigReport
        SubReport15.ReportSource = FyFp21_sub_money7
        SubReport15.Parameters.Add(P1)
        SubReport15.Parameters.Add(P2)
        SubReport15.Parameters.Add("m", "7")

        '===========���������͡�ý֡ͺ��
        Dim FyFp21_sub_money8 As New rpt_FyFp21_sub_money
        FyFp21_sub_money8.ConfigReport = ConfigReport
        SubReport16.ReportSource = FyFp21_sub_money8
        SubReport16.Parameters.Add(P1)
        SubReport16.Parameters.Add(P2)
        SubReport16.Parameters.Add("m", "8")

        '===========�����ʴ� ����ͧ���
        Dim FyFp21_sub_money9 As New rpt_FyFp21_sub_money
        FyFp21_sub_money9.ConfigReport = ConfigReport
        SubReport17.ReportSource = FyFp21_sub_money9
        SubReport17.Parameters.Add(P1)
        SubReport17.Parameters.Add(P2)
        SubReport17.Parameters.Add("m", "9")

        '===========����������ͧ���
        Dim FyFp21_sub_money10 As New rpt_FyFp21_sub_money
        FyFp21_sub_money10.ConfigReport = ConfigReport
        SubReport18.ReportSource = FyFp21_sub_money10
        SubReport18.Parameters.Add(P1)
        SubReport18.Parameters.Add(P2)
        SubReport18.Parameters.Add("m", "10")

        '===========������ʶҹ���
        Dim FyFp21_sub_money11 As New rpt_FyFp21_sub_money
        FyFp21_sub_money11.ConfigReport = ConfigReport
        SubReport19.ReportSource = FyFp21_sub_money11
        SubReport19.Parameters.Add(P1)
        SubReport19.Parameters.Add(P2)
        SubReport19.Parameters.Add("m", "11")

        '===========�����ҷ��ѡ
        Dim FyFp21_sub_money12 As New rpt_FyFp21_sub_money
        FyFp21_sub_money12.ConfigReport = ConfigReport
        SubReport20.ReportSource = FyFp21_sub_money12
        SubReport20.Parameters.Add(P1)
        SubReport20.Parameters.Add(P2)
        SubReport20.Parameters.Add("m", "12")

        '===========��Ҩ�ҧ��˹�
        Dim FyFp21_sub_money13 As New rpt_FyFp21_sub_money
        FyFp21_sub_money13.ConfigReport = ConfigReport
        SubReport21.ReportSource = FyFp21_sub_money13
        SubReport21.Parameters.Add(P1)
        SubReport21.Parameters.Add(P2)
        SubReport21.Parameters.Add("m", "13")

        '===========��Ҩ�ҧ���Ҿ�˹�
        Dim FyFp21_sub_money14 As New rpt_FyFp21_sub_money
        FyFp21_sub_money14.ConfigReport = ConfigReport
        SubReport22.ReportSource = FyFp21_sub_money14
        SubReport22.Parameters.Add(P1)
        SubReport22.Parameters.Add(P2)
        SubReport22.Parameters.Add("m", "14")

        '===========��Ҩ�ҧ���Ҿ�˹�仴٧ҹ
        Dim FyFp21_sub_money15 As New rpt_FyFp21_sub_money
        FyFp21_sub_money15.ConfigReport = ConfigReport
        SubReport23.ReportSource = FyFp21_sub_money15
        SubReport23.Parameters.Add(P1)
        SubReport23.Parameters.Add(P2)
        SubReport23.Parameters.Add("m", "15")

        '===========��Ҿ�˹��Թ�ҧ���㹻���Ȣͧ�Է�ҡ�
        Dim FyFp21_sub_money16 As New rpt_FyFp21_sub_money
        FyFp21_sub_money16.ConfigReport = ConfigReport
        SubReport24.ReportSource = FyFp21_sub_money16
        SubReport24.Parameters.Add(P1)
        SubReport24.Parameters.Add(P2)
        SubReport24.Parameters.Add("m", "16")

        '===========����������·�����
        Dim FyFp21_sub_money17 As New rpt_FyFp21_sub_money
        FyFp21_sub_money17.ConfigReport = ConfigReport
        SubReport25.ReportSource = FyFp21_sub_money17
        SubReport25.Parameters.Add(P1)
        SubReport25.Parameters.Add(P2)
        SubReport25.Parameters.Add("m", "17")

        Dim FyFp21_sub_money18 As New rpt_FyFp21_sub_moneyPerEmp
        FyFp21_sub_money18.ConfigReport = ConfigReport
        SubReport26.ReportSource = FyFp21_sub_money18
        SubReport26.Parameters.Add(P1)
        SubReport26.Parameters.Add(P2)
        'SubReport25.Parameters.Add("m", "18")



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
