Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class Report1
    Inherits Telerik.Reporting.Report
    Public ConfigReport As New CLB_Function '����Ѻ��� ��駤�� �����ҹ��ҧ�
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
    Private Sub Report1_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection
    End Sub
End Class