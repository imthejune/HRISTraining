Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rpt_trainyearakane
    Inherits Telerik.Reporting.Report

    Const CodeReport As String = "rpt_trainyearakane"  ' ������§ҹ
    Public ShowDetail As Boolean = True   ' �ʴ���������´
    Public ShowGroupCm1 As Boolean = True  ' ����Ѻ�ʴ� Group ��§ҹ
    Public ShowTxtReport As String = ""  ' �ʴ���ͤ�����ͷ��� ��§ҹ 
    Public ConfigReport As New CLB_Function '����Ѻ��� ��駤�� �����ҹ��ҧ�
    Public GroupNameTree As String = " "  '�Ѵ�������§ҹ Tree ��ҹ����
    Public GroupCm1_NewPageAfter As Boolean = False ' ����Ѻ ��â���˹�������������������

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rpt_trainyearakane_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding

        DataSource.ConnectionString = ConfigReport.SQL_Connection

        'ShowGroupReport()

    End Sub
    'Sub ShowGroupReport()
    '    Me.Culture = New System.Globalization.CultureInfo("en-US") ''����

    '    detail.DocumentMapText = "= Fields.PersonCode + ' ' +  Fields.InitialName + ' ' + Fields.FnameT + ' ' + Fields.LnameT "


    'End Sub
End Class