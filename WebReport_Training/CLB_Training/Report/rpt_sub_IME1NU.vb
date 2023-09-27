Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports System.Globalization

Partial Public Class rpt_sub_IME1NU
    Inherits Telerik.Reporting.Report


    Const CodeReport As String = "rpt_sub_IME1NU"  ' ������§ҹ
    Public ShowDetail As Boolean = True   ' �ʴ���������´
    Public ShowGroupCm1 As Boolean = True  ' ����Ѻ�ʴ� Group ��§ҹ
    Public ShowTxtReport As String = ""  ' �ʴ���ͤ�����ͷ��� ��§ҹ 
    Public ConfigReport As New CLB_Function '����Ѻ��� ��駤�� �����ҹ��ҧ�
    Public GroupNameTree As String = " "  '�Ѵ�������§ҹ Tree ��ҹ����
    Public GroupCm1_NewPageAfter As Boolean = False ' ����Ѻ ��â���˹�������������������

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rpt_sub_IME1NU_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        '---- ��Ŵ�����á
        DataSource.ConnectionString = ConfigReport.SQL_Connection

    End Sub

    Public Shared Function dateFormat(ByVal dateF, ByVal T) As String '����¹ �� �� ��
        Try
            If IsNothing(dateF) Then
                Return ""
                Exit Function
            End If
            Dim ret As String = ""
            If T = "T" Then
                ret = CType(dateF, DateTime).ToString("dd-MM-yyyy", New CultureInfo("th-TH"))
            Else
                ret = CType(dateF, DateTime).ToString("dd-MM-yyyy", New CultureInfo("en-US"))
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

    Public Shared Function CourePublic(ByVal Course) As String
        Try
            Dim tempStr As String = Course
           
            If Course = "Public" Then
                tempStr = "/"
            Else
                tempStr = ""
            End If

            Return tempStr
        Catch ex As Exception
            Return "0"
        End Try
    End Function
    Public Shared Function CoureinHouse(ByVal Course) As String
        Try
            Dim tempStr As String = Course

           If Course = "inHouse" Then

                tempStr = "/"
            Else
                tempStr = ""
            End If

            Return tempStr
        Catch ex As Exception
            Return "0"
        End Try
    End Function
    Public Shared Function CoureOJT(ByVal Course) As String
        Try
            Dim tempStr As String = Course

            If Course = "OJT" Then
                tempStr = "/"
            Else
                tempStr = ""
            End If

            Return tempStr
        Catch ex As Exception
            Return "0"
        End Try
    End Function


End Class