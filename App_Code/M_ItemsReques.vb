#Region "Imports"
Imports System.Data
Imports System.Web.Services
Imports Telerik.Web.UI
Imports Telerik.Web.UI.RadAsyncUpload
Imports Telerik.Web.UI.UploadedFileCollection
Imports Telerik.Web.UI.RadListViewSortExpressionCollection
Imports Telerik.Web.UI.RadComboBoxItem
Imports System.Data.SqlClient
Imports System.Web.Script.Serialization
Imports System.Web.UI.WebControls
Imports System.Drawing.Drawing2D
Imports System.Threading
Imports System.Globalization
Imports System.ComponentModel
Imports System.Collections
Imports System.Drawing
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.IO
Imports System.IO.IOException
Imports Telerik.Web.UI.Upload
Imports System
Imports System.Collections.Generic
Imports Microsoft.Win32
Imports System.Net

#End Region

Public Class M_ItemsReques
    Dim da As New Mydata(adoconn)
    Public OjbCombo As Object = Nothing
    Public OjbEventArgs As Object = Nothing
    Public SqlRequested As String = ""
    Public ColumnItems As String = ""
    Public ColumnID As String = ""
    Public QryWhere As String = ""
    Public QryOrder As String = ""
    Public QryFrom As String = ""
    Public CountItems As Integer = 5
    Public DataRequested As DataTable = Nothing
    Public Sqls As String = ""
    Public defaults As Boolean = False
    Public defaults_Text As String = ""

    Public Sub CheckType(Ojb As Object)
        OjbCombo = Ojb
    End Sub
    Public Function GetQuerry() As DataTable


        If IsNothing(DataRequested) Then


            If SqlRequested = "" Then

                Sqls = "SELECT "

                If ColumnID <> "" Then
                    Sqls &= ColumnID & ","
                End If

                If ColumnItems <> "" Then
                    Sqls &= ColumnItems
                End If

                If QryFrom <> "" Then
                    Sqls &= " FROM " & QryFrom
                End If

                If QryWhere <> "" Then
                    Sqls &= " WHERE " & QryWhere
                End If

                If QryOrder <> "" Then
                    Sqls &= " " & QryOrder
                End If

            Else
                Sqls = SqlRequested
            End If

            If Sqls <> "" Then
                DataRequested = da.GetDataTable(Sqls)
            End If
        End If

        GetQuerry = DataRequested

    End Function
    Public Sub ItemsRequests(Optional sender As Object = Nothing, Optional eArgs As Object = Nothing)

        Dim dra() As DataRow

        If IsNothing(DataRequested) Then
            If SqlRequested <> "" Then
                DataRequested = da.GetDataTable(SqlRequested)
            End If
        End If

        'DataRequested = GetQuerry()
        If IsNothing(eArgs) Then
            eArgs = OjbEventArgs
        End If

        If Not IsNothing(sender) Then
            OjbCombo = DirectCast(sender, System.Web.UI.Control)
        End If



        OjbCombo.Items.Clear()
        OjbCombo.Text = ""

        Try
            Dim arrField As Array = ColumnItems.Split(",")

            If eArgs.Text & "" = "" Then
                dra = DataRequested.Select
            Else
                Dim TextSelect As String = ""
                If arrField.Length > 1 Then
                    For x As Integer = 0 To arrField.Length - 1
                        TextSelect &= arrField(x) & " like '%" & eArgs.Text.Replace("'", "''") & "%' "

                        If x + 1 < arrField.Length Then
                            TextSelect &= " OR "
                        End If
                    Next
                Else
                    TextSelect = ColumnItems & " like '%" & eArgs.Text.Replace("'", "''") & "%'"
                End If

                dra = DataRequested.Select(TextSelect)
            End If

            Dim itemOffset As Integer = eArgs.NumberOfItems
            Dim endOffset As Integer = Math.Min(itemOffset + CountItems, dra.Length)
            eArgs.EndOfItems = endOffset = dra.Length

            If defaults = True And endOffset = CountItems Then

                Dim item As New RadComboBoxItem()

                item.Value = "0"
                Dim texts As String = "-"
                If defaults_Text <> "" Then
                    texts = defaults_Text
                End If

                If arrField.Length > 1 Then
                    For x As Integer = 0 To arrField.Length - 1
                        item.Text = texts
                        item.Attributes.Add(arrField(1), texts)
                    Next
                Else
                    item.Text = texts
                    item.Attributes.Add(ColumnItems, texts)

                End If

                OjbCombo.Items.Add(item)
                OjbCombo.DataBind()
            End If


            For i As Integer = itemOffset To endOffset - 1

                Dim item As New RadComboBoxItem()
                If arrField.Length > 1 Then
                    item.Value = dra(i)(ColumnID).ToString()

                    For x As Integer = 0 To arrField.Length - 1
                        item.Text = dra(i)(arrField(x)).ToString()
                        item.Attributes.Add(arrField(x), dra(i)(arrField(x)) & "")
                    Next

                Else
                    item.Value = dra(i)(ColumnID).ToString()
                    item.Text = dra(i)(ColumnItems).ToString()
                    item.Attributes.Add(ColumnItems, dra(i)(ColumnItems) & "")
                End If


                OjbCombo.Items.Add(item)
                OjbCombo.DataBind()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SelectdItems(_OjbCombo As RadComboBox, _id As String, _value As String)

        Dim _items As New RadComboBoxItem()

        _OjbCombo.Items.Clear()
        _OjbCombo.Text = ""

        If _value <> "" Then
            _items.Text = _value
            _items.Value = _id
            _OjbCombo.Items.Add(_items)
            _OjbCombo.DataBind()
            _OjbCombo.SelectedIndex = 0

        End If

    End Sub

End Class
