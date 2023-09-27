Imports System.Data
Imports System.IO
Imports Newtonsoft.Json

Public Class Change

    Public Shared ItemRows As Dictionary(Of String, Object)

    Public Shared Function _ToSortedList(str As String) As SortedList
        Try

            Dim lists As SortedList = New SortedList()
            If str.Length > 0 Then

                str = str.Replace("%2C", ",")
                Dim obj() As String = str.Replace("{", "").Replace("}", "").Split(",")

                If obj.Length > 0 Then
                    For i As Integer = 0 To obj.Length - 1
                        Dim items() As String = obj(i).Split(":")
                        lists.Add(items(0), items(1))
                    Next

                End If

                Return lists
            Else
                Return Nothing
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Shared Function context(ct As HttpContext) As SortedList

        If IsNothing(ct) Then Exit Function

        Dim lists As New SortedList()

        Dim str As String = ""
        Dim sr As StreamReader
        Dim Req = ct.Request
        Try


            ' : ส่งค่าผ่าน From
            If Not IsNothing(Req.Form("data")) Then

                str = Req.Form("data").Replace("%22", """")

                Dim temp As New SortedList()
                temp = Newtonsoft.Json.JsonConvert.DeserializeObject(Of SortedList)(str)
                If Not IsNothing(temp) Then

                    For Each item In temp
                        If Not lists.Contains(item.Key) Then
                            lists.Add(item.Key, item.Value)
                        End If
                    Next

                End If
            End If

            ' : ส่งค่าผ่าน Body
            If Not IsNothing(Req.InputStream) Then

                Dim data = Req.InputStream

                If data.Length > 0 Then

                    sr = New StreamReader(data)

                    str = sr.ReadToEnd()

                    Dim temp As New SortedList()

                    Try

                        temp = Newtonsoft.Json.JsonConvert.DeserializeObject(Of SortedList)(str)

                        If Not IsNothing(temp) Then

                            For Each item In temp
                                If Not lists.Contains(item.Key) Then
                                    lists.Add(item.Key, item.Value)
                                End If
                            Next

                        End If
                    Catch ex As Exception
                    End Try
                End If
            End If

            Dim queryStr = Req.QueryString.AllKeys

            ' : ส่งค่าผ่าน URL QueryString
            If queryStr.Length > 0 Then
                Dim AllKeys = Req.QueryString

                For Each item In queryStr
                    If Not lists.Contains(item) Then
                        lists.Add(item, AllKeys(item))
                    End If
                Next
            End If

            Dim fromKey = Req.Form.AllKeys

            ' : ส่งค่าผ่าน URL QueryString
            If fromKey.Length > 0 Then

                For item As Integer = 0 To fromKey.Length - 1
                    If Not lists.Contains(fromKey(item)) Then
                        lists.Add(fromKey(item), ct.Request.Form(item))
                    End If
                Next
            End If

        Catch ex As Exception
            lists = Nothing
            Throw New Exception(" Context : " & ex.Message)
        End Try

        Return lists

    End Function

    Public Shared Function _ToSorted(context As HttpContext) As SortedList

        If IsNothing(context) Then Exit Function
        Dim lists As New SortedList()
        Dim str As String = ""
        'Dim data As Object
        Dim sr As StreamReader
        Try

            If Not IsNothing(context.Request.Form("data")) Then
                str = context.Request.Form("data")
            Else
                Dim data = context.Request.InputStream
                If data.Length > 0 Then
                    sr = New StreamReader(data)
                    str = sr.ReadToEnd()
                Else
                    Dim key = context.Request.QueryString.AllKeys


                    key = context.Request.QueryString.AllKeys

                    For Each item In key
                        lists.Add(item, context.Request.QueryString(item))
                    Next

                    Return lists
                    Exit Function
                End If
            End If

            'If IsNothing(sr) Then Exit Function

            str = str.Replace("%22", """")

            Dim dt As DataTable = New DataTable()

            Try
                dt = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(str)

                If Not IsNothing(dt) Then
                    If dt.Rows.Count > 0 Then
                        For i As Integer = 0 To dt.Columns.Count - 1
                            lists.Add(dt.Columns(i).ColumnName, dt.Rows(0)(dt.Columns(i).ColumnName))
                        Next
                    End If
                Else
                    lists = Nothing
                End If

            Catch ex As Exception
                If ex.Message.IndexOf("Additional text found") > -1 Or ex.Message.IndexOf("JSON token when reading DataTable.") > -1 Then
                    str = str.Replace("modules", "module")

                    lists = New SortedList
                    lists = Newtonsoft.Json.JsonConvert.DeserializeObject(Of SortedList)(str)

                    'dt = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)("[" & str & "]")
                Else
                    Throw New Exception("_ToSorted-ConvertToTable: " & ex.Message)
                End If
            End Try

        Catch ex As Exception
            Throw New Exception("_ToSorted :" & ex.Message)
        End Try

        Return lists

    End Function

    Public Shared Function _TosortList(str As String) As SortedList
        Dim lists As New SortedList()

        Try

            str = str.Replace("%22", """")
            lists = New SortedList

            lists = Newtonsoft.Json.JsonConvert.DeserializeObject(Of SortedList)(str)

        Catch ex As Exception
            Throw New Exception("_TosortList :" & ex.Message)
        End Try

        Return lists
    End Function

    Public Shared Function _ToSorted(str As String) As SortedList
        Dim lists As New SortedList()
        Try

            str = str.Replace("%22", """")
            Dim dt As DataTable = New DataTable()

            dt = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(str)

            If dt.Rows.Count > 0 Then

                For i As Integer = 0 To dt.Columns.Count - 1

                    lists.Add(dt.Columns(i).ColumnName, dt.Rows(0)(dt.Columns(i).ColumnName))

                Next
            End If
        Catch ex As Exception
            Throw New Exception("_ToSorted :" & ex.Message)
        End Try

        Return lists


    End Function
    ':// Commit iSit 09092020-S
    Public Shared Function _Tojson(obj As Object) As String

        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()

        Return JsonConvert.SerializeObject(obj)

    End Function
    ':// Commit iSit 09092020-E
    Public Shared Function _ToString(stl As SortedList) As String

        Dim strs As String = ""

        If stl.Count > 0 Then

            For i As Integer = 0 To stl.Count - 1

                strs &= stl.Keys(i).ToString & ":" & stl.Values(i).ToString

                If i + 1 < stl.Count Then
                    strs &= ","
                End If

            Next
        End If

        Return strs

    End Function

    Public Shared Function _Tojson(_data As DataTable, _type As Integer) As String

        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim packet As New List(Of Dictionary(Of String, Object))()
        Dim row As Dictionary(Of String, Object) = Nothing
        For Each dr As DataRow In _data.Rows
            row = New Dictionary(Of String, Object)()
            For Each dc As DataColumn In _data.Columns
                row.Add(dc.ColumnName.Trim(), dr(dc))
            Next

            If _type = 1 Then
                packet.Add(row)
            End If

        Next


        Return serializer.Serialize(row)

    End Function

    Public Shared Function _Tojson(_data As List(Of Dictionary(Of String, Object))()) As String

        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()

        Return serializer.Serialize(_data)

    End Function

    Public Shared Function _Tojson(_data As DataTable, Optional cs As Cases = Cases.Statics) As String

        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim packet As New List(Of Dictionary(Of String, Object))()
        Dim row As Dictionary(Of String, Object) = Nothing
        For Each dr As DataRow In _data.Rows
            row = New Dictionary(Of String, Object)()
            For Each dc As DataColumn In _data.Columns
                row.Add(dc.ColumnName.Trim(), dr(dc))
            Next

            If _data.Rows.Count > 1 Or cs <> Cases.Rows Then
                packet.Add(row)
            End If
        Next

        Dim str$ = ""

        If _data.Rows.Count > 1 Or cs <> Cases.Rows Then
            str = serializer.Serialize(packet)
        Else
            str = serializer.Serialize(row)
        End If

        Return str
    End Function

    Public Shared Function _Tojson(_data As DataTable) As String

        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim packet As New List(Of Dictionary(Of String, Object))()
        Dim row As Dictionary(Of String, Object) = Nothing
        For Each dr As DataRow In _data.Rows
            row = New Dictionary(Of String, Object)()
            For Each dc As DataColumn In _data.Columns
                row.Add(dc.ColumnName.Trim(), dr(dc))
            Next

            If _data.Rows.Count > 1 Then
                packet.Add(row)
            End If
        Next

        Dim str$ = ""

        If _data.Rows.Count > 1 Then
            str = serializer.Serialize(packet)
        Else
            str = serializer.Serialize(row)
        End If

        Return str

    End Function
    Public Shared Function _Tojson(stl As Dictionary(Of String, SortedList)) As String
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Return serializer.Serialize(stl)
    End Function
    Public Shared Function _Tojson(stl As SortedList, Optional type As Integer = 0) As String

        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
        Dim packet As New List(Of Dictionary(Of String, Object))()
        Dim row As Dictionary(Of String, Object) = Nothing

        row = New Dictionary(Of String, Object)()
        For i As Integer = 0 To stl.Count - 1
            row.Add(stl.Keys(i), stl.Values(i).ToString)
        Next

        Dim str$ = ""

        If type = 0 Then
            packet.Add(row)
            str = serializer.Serialize(packet)
        Else
            str = serializer.Serialize(row)
        End If

        Return str

    End Function

    Public Shared Function _ToDatatable(ByVal json As String) As DataTable
        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json)
    End Function

    Public Shared Function _ToDatatable(obj As Object) As DataTable
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()

        Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(obj)
    End Function

    Public Shared Function _ToDatatable(ByVal stl As SortedList) As DataTable

        If IsNothing(stl) Then
            _ToDatatable = Nothing
        End If

        Dim dt As DataTable = New DataTable

        For i As Integer = 0 To stl.Count - 1
            dt.Columns.Add(stl.Keys(i))
        Next

        Dim row As DataRow = dt.NewRow

        For i As Integer = 0 To stl.Count - 1
            row(stl.Keys(i)) = stl.Values(i)
        Next

        dt.Rows.Add(row)


        Return dt
    End Function
    Public Shared Function _ToList(_data As DataTable, Optional type As Integer = 0) As SortedList
        If _data.Rows.Count > 0 Then


            Dim items As SortedList = New SortedList()


            For Each dr As DataRow In _data.Rows
                For Each dc As DataColumn In _data.Columns
                    items.Add(dc.ColumnName.Trim(), dr(dc))
                Next

                If type = 1 Then
                    Exit For
                End If
            Next

            Return items
        Else
            Return Nothing
        End If

    End Function

    Public Shared Function _ToSorted(_data As DataTable, Optional cs As Cases = Cases.Statics) As SortedList
        Try

            If Not IsNothing(_data) Then

                If _data.Rows.Count > 0 Then
                    Dim lists As SortedList = New SortedList()
                    For item As Integer = 0 To _data.Rows.Count - 1
                        For Each dc As DataColumn In _data.Columns
                            lists.Add(dc.ColumnName.Trim(), _data.Rows(item)(dc))
                        Next
                        If cs = Cases.First Then
                            Exit For
                        End If
                    Next
                    Return lists
                Else
                    Return New SortedList
                End If
            End If

        Catch ex As Exception
            Throw New Exception("_ToSorted : " & ex.Message)
        End Try



    End Function

    Public Shared Function _ToArry(_data As String) As String()


        Dim temps() As String
        Try
            temps = Newtonsoft.Json.JsonConvert.DeserializeObject(Of String())(_data)
            _ToArry = temps
        Catch ex As Exception
            Throw New Exception("_ToArry : " & ex.Message)
        End Try


    End Function

    Public Shared Function _ToArrlist(_data As String) As ArrayList
        Try

            Dim arl As ArrayList
            arl = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ArrayList)(_data)
            _ToArrlist = arl

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Function

    Public Shared Function _To(Of T As New)(str As String) As T
        Return JsonConvert.DeserializeObject(Of T)(str)
    End Function



End Class