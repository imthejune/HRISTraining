Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rpt_FyFp21_sub_money
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





    End Sub


    Private Sub rpt_FyFp21_sub_money_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection
        Lang()  ' ����¹����
        Select Case Me.ReportParameters("m").Value
            Case "1"
                TextBox3.Value = "= Fields.b1"
            Case "2"
                TextBox3.Value = "= Fields.b2"
            Case "3"
                TextBox3.Value = "= Fields.b3"
            Case "4"
                TextBox3.Value = "= Fields.b4"
            Case "5"
                TextBox3.Value = "= Fields.b5"
            Case "6"
                TextBox3.Value = "= Fields.b6"
            Case "7"
                TextBox3.Value = "= Fields.b7"
            Case "8"
                TextBox3.Value = "= Fields.b8"
            Case "9"
                TextBox3.Value = "= Fields.b9"
            Case "10"
                TextBox3.Value = "= Fields.b10"
            Case "11"
                TextBox3.Value = "= Fields.b11"
            Case "12"
                TextBox3.Value = "= Fields.b12"
            Case "13"
                TextBox3.Value = "= Fields.b13"
            Case "14"
                TextBox3.Value = "= Fields.b14"
            Case "15"
                TextBox3.Value = "= Fields.b15"
            Case "16"
                TextBox3.Value = "= Fields.b16"
            Case "17"
                TextBox3.Value = "= Fields.PaternExp"
        End Select
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    Sub Lang()
        Me.Culture = New System.Globalization.CultureInfo("en-US") ''����
        '' ��õ�駪��� ����ŷ���繢�ͤ��� ��͵�駪��͢�鹵鹴���  Lbl ��������к��ŧ��ŧ�ҹ
        If ConfigReport.ShowLang <> "T" Then
            '��Ŵ���� �������¹����
            SetLabel(Me.pageFooterSection1)
            SetLabel(Me.pageHeaderSection1)
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
