Imports System.Data
Imports Telerik.Web.UI



Public Class Manage_Combo

    Public OjbCombo As Object = Nothing
    Public OjbEventArgs As Object = Nothing
    Public SqlRequested As String = ""
    Public ColumnItems As String = ""
    Public ColumnText As String = ""
    Public ColumnID As String = ""
    Public ColumnValue As String = ""
    Public sort As String = ""
    Public CountItems As Integer = 10
    Public DataRequested As DataTable = Nothing
    Public defaults As Boolean = False
    Public defaults_Text As String = ""

    Public Sub ItemsRequests(Optional sender As Object = Nothing, Optional eArgs As Object = Nothing)
        Dim da_ As New Mydata(adoconn)
        Dim dra() As DataRow

        If IsNothing(DataRequested) Then
            If SqlRequested <> "" Then
                DataRequested = da_.GetDataTable(SqlRequested)
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

            If sort <> "" And dra.Length > 0 Then
                dra = DataRequested.Select(sort)
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
            Throw New Exception("ItemsRequests :" & ex.Message)
        End Try
    End Sub

    Public Sub SelectdItems(_OjbCombo As RadComboBox, _id As String, _value As String, Optional c As Cases = Cases.Dynamic)

        Dim _items As New RadComboBoxItem()

        If c = Cases.Dynamic Then
            _OjbCombo.Items.Clear()
        End If
        _OjbCombo.Text = ""
        If _value <> "" Then
            _items.Text = _value
            _items.Value = _id
            _OjbCombo.Items.Add(_items)
            _OjbCombo.DataBind()
            _OjbCombo.SelectedIndex = 0
        End If

    End Sub

    Public Sub Clear(_OjbCombo As RadComboBox)

        Dim _items As New RadComboBoxItem()
        _OjbCombo.Items.Clear()
        _OjbCombo.Text = ""

    End Sub


    Public group As New Groups

    Public Class Groups

        Public Property DataSource As DataTable
        Public Property Header As New HeaderItems
        Public Property Children As New childrenItems

        Public Property sort As String

        Sub New()
            '  Me.GroupItem = New List(Of GroupItems)
            Me.DataSource = New DataTable
            Me.sort = ""
        End Sub

        Public Sub ItemGroup(ele As RadComboBox)

            If IsNothing(ele) Then
                Exit Sub
            End If

            If IsNothing(DataSource) Then
                Exit Sub
            End If

            Dim dt As DataTable = New DataTable

            Try


                If Not IsNothing(Header) Then

                    dt = DataSource.Copy
                    For Each l In GroupData(dt, Header).Rows

                        Dim lineItem As RadComboBoxItem = New RadComboBoxItem
                        lineItem.Text = l(Header.text)
                        lineItem.Value = l(Header.id)
                        lineItem.IsSeparator = True
                        ele.Items.Add(lineItem)


                        Dim dr() As DataRow

                        dr = dt.Select(Header.id & "='" & l(Header.id) & "' AND " & Header.text & "='" & l(Header.text) & "'")

                        If dr.Length > 0 Then

                            For Each c In dr
                                lineItem = New RadComboBoxItem
                                lineItem.Text = c(Children.text)
                                lineItem.Value = c(Children.id)
                                ele.Items.Add(lineItem)
                            Next
                        End If

                    Next

                End If




            Catch ex As Exception

            End Try


        End Sub

        Function ClearOther(data As DataTable, item As Object) As DataTable

            Dim dts As DataTable = New DataTable

            Try

                If IsNothing(data) Then Exit Function

                dts = data.Copy

                For Each rm In data.Copy.Columns
                    If rm.ColumnName <> item.id And rm.ColumnName <> item.text Then
                        dts.Columns.Remove(rm.ColumnName)
                    End If
                Next
            Catch ex As Exception
                dts = Nothing
                Throw New Exception("Clear Other :" & ex.Message)
            End Try

            ClearOther = dts

        End Function

        Function GroupData(data As DataTable, item As Object) As DataTable

            Dim dt As DataTable = New DataTable

            Try

                data = ClearOther(data, item)

                Dim query = From Row In data.AsEnumerable
                            Group Row
                            By _id_ = Row(item.id),
                                       _text_ = Row(item.text)
                            Into CountRow = Group
                            Select New With {
                                                 .id = _id_,
                                                 .text = _text_ & IIf(item.count, CountRow.Count, "")}

                If dt.Columns.Count = 0 Then

                    If Not dt.Columns.Contains(item.id) Then
                        dt.Columns.Add(item.id, GetType(String))
                    End If

                    If Not dt.Columns.Contains(item.text) Then
                        dt.Columns.Add(item.text, GetType(String))
                    End If

                End If

                For Each plus In query

                    Dim dtClone = dt.NewRow()

                    If plus.ToString.Contains("id") Then


                        dtClone(item.id) = plus.id

                    End If

                    If plus.ToString.Contains("text") Then
                        dtClone(item.text) = plus.text
                    End If


                    dt.Rows.Add(dtClone)

                Next

            Catch ex As Exception
                Throw New Exception("GroupData : " & ex.Message)
            End Try

            GroupData = dt

        End Function



        Public Class HeaderItems
            Public Property id As String
            Public Property text As String
            Public Property count As Boolean = False
        End Class

        Public Class childrenItems
            Public Property id As String
            Public Property text As String
            Public Property image As String
            Public Property comment As String
            Public Property sort As String
        End Class

    End Class

    Public Class Other


    End Class

End Class
