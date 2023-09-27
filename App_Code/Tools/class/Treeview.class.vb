Imports System.Data
Imports Telerik.Web.UI


Public Class Treeviews
    Public nodeValue As String
    Public nodeText As String
    Public nodeCount As Integer = 0
    Public dataSoruce As DataTable


    Dim _CountNode As Integer = 0
    Public Property CountNode As Integer
        Get
            Return _CountNode
        End Get
        Set(value As Integer)
            _CountNode = value
        End Set
    End Property

    Public Enum Ordinal
        _First = 0
        _Second = 1
        _Third = 2
        _Fourth = 3
        _Fifth = 4
        _Start = 0
        _End = 1
        _next = 5
        _image = 10
        _comment = 11
    End Enum

    Sub _Bind(obj_ As RadTreeView, data_ As DataTable, listCol As ArrayList)
        Try

            Dim data_items As DataTable = Nothing

            If IsNothing(data_) And IsNothing(obj_) Then
                Exit Sub
            Else
                dataSoruce = data_.Copy

            End If


            obj_.Nodes.Clear()

            For i As Integer = 0 To listCol.Count - 1

                Dim LevelProps As New Level_node()

                If listCol(i).id <> "" Then
                    LevelProps.keynode = listCol(i).id
                End If

                If listCol(i).ref <> "" Then
                    LevelProps.ref = listCol(i).ref
                Else
                    LevelProps.ref = ""
                End If

                If listCol(i).text <> "" Then
                    LevelProps.text = listCol(i).text
                Else
                    LevelProps.text = ""
                End If

                If listCol(i).image <> "" Then
                    LevelProps.image = listCol(i).image
                Else
                    LevelProps.image = ""
                End If

                If listCol(i).comment <> "" Then
                    LevelProps.comment = listCol(i).comment
                Else
                    LevelProps.comment = ""
                End If

                ':// Commit iSit 09092020
                If listCol(i).sort <> "" Then
                    LevelProps.sort = listCol(i).sort
                End If
                data_items = dataSoruce.Copy()

                If obj_.Nodes.Count = Ordinal._Start Then

                    If listCol.Count = 1 Then
                        If LevelProps.image <> "" Then
                            data_items = item_node(Column_table(data_items, listCol(i)), LevelProps, Ordinal._image)
                        ElseIf LevelProps.comment <> "" Then
                            data_items = item_node(Column_table(data_items, listCol(i)), LevelProps, Ordinal._comment)
                        Else
                            data_items = item_node(Column_table(data_items, listCol(i)), LevelProps)
                        End If
                    Else
                        data_items = item_node(Column_table(data_items, listCol(i)), LevelProps, True)
                    End If

                    Call Process_node(obj_, data_items, Ordinal._Start)

                ElseIf i = listCol.Count - Ordinal._End Then

                    If LevelProps.comment <> "" Then
                        data_items = item_node(Column_table(data_items, listCol(i)), LevelProps, Ordinal._comment)
                        Call Process_node(obj_, data_items, Ordinal._End)
                    ElseIf LevelProps.image <> "" Then
                        data_items = item_node(Column_table(data_items, listCol(i)), LevelProps, Ordinal._image)
                        Call Process_node(obj_, data_items, Ordinal._image)
                    Else
                        data_items = item_node(Column_table(data_items, listCol(i)), LevelProps)
                        Call Process_node(obj_, data_items, Ordinal._End)
                    End If
                Else

                    data_items = item_node(Column_table(data_items, listCol(i)), LevelProps, True)
                    Call Process_node(obj_, data_items, Ordinal._next)

                End If
            Next

            nodeCount = Val(data_items.Rows.Count & "")

            _First(obj_)

        Catch ex As Exception
            Throw New Exception("_Bind : " & ex.Message)
        End Try
    End Sub

    Sub _Binding(obj As RadTreeView, dt_ As DataTable, ar_list As ArrayList)

        Dim data_items As DataTable = Nothing
        nodeCount = dt_.Rows.Count

        obj.Nodes.Clear()

        For i As Integer = 0 To ar_list.Count - 1
            Dim arrNodes As arrNode = ar_list(i)
            Dim node__ As New Level_node()
            node__.keynode = arrNodes.id
            node__.ref = arrNodes.ref
            node__.text = arrNodes.text
            data_items = dt_.Copy()
            If obj.Nodes.Count = Ordinal._Start Then

                data_items = item_node(Column_table(data_items, arrNodes), node__, True)

                Dim IRadTreeNode As IRadTreeNodeContainer = obj
                Call Process_node(obj, data_items, Ordinal._Start)

            ElseIf i = ar_list.Count - Ordinal._End Then
                If (Trim(arrNodes.comment & "") <> "") Then
                    node__.comment = arrNodes.comment
                End If

                data_items = item_node(Column_table(data_items, arrNodes), node__)
                Call Process_node(obj, data_items, Ordinal._End)
            Else

                data_items = item_node(Column_table(data_items, arrNodes), node__, True)
                Call Process_node(obj, data_items, Ordinal._next)
            End If
        Next

        _First(obj)

    End Sub

    Sub _Search(obj As RadTreeView, Search As String, Text_ As String)

        If Search <> "" Then
            Dim XNode = New RadTreeNode()
            Dim target As IRadTreeNodeContainer = obj
            Dim targetNode As RadTreeNode = New RadTreeNode()

            If Text_ <> "" Then

                XNode.Text = "Search (1)"
                XNode.Value = "Search"
                XNode.ExpandParentNodes()
                XNode.Expanded = True
                target.Nodes.Add(XNode)
                CountNode += 1
                targetNode = New RadTreeNode()

                targetNode = DirectCast(obj, RadTreeView).FindNodeByValue("Search")

                XNode = New RadTreeNode()
                If Not IsNothing(targetNode) Then
                    XNode.Text = Text_
                    XNode.Value = Search
                    XNode.Selected = True
                    nodeValue = Search
                    XNode.ExpandParentNodes()
                    targetNode.Nodes.Add(XNode)
                End If
            End If
        End If
    End Sub

    Sub _First(obj As RadTreeView)

        Dim nodeSelect As RadTreeNode = New RadTreeNode()
        nodeSelect = GetFirstLeafNode(obj.Nodes)

        If nodeSelect IsNot Nothing Then
            nodeSelect.Selected = True
            nodeValue = nodeSelect.Value
            nodeSelect.Expanded = True
            nodeSelect.ExpandParentNodes()
        End If

    End Sub

    Sub _Select(obj As RadTreeView, value As String)

        Dim node As New RadTreeNode()

        If Not IsNothing(obj) Then

            node = obj.FindNodeByValue(value)
            If node IsNot Nothing Then
                node.Selected = True
            End If

            Dim target As IRadTreeNodeContainer = obj
            Dim targetNode As RadTreeNode = New RadTreeNode()

            'targetNode = DirectCast(obj, RadTreeView).FindNodeByValue(value)

            'targetNode.Selected = True
            'targetNode.Expanded = True
            'targetNode.ExpandParentNodes()

            'target.Nodes.Add(targetNode)
        End If
    End Sub
    Function Column_table(dataold_ As DataTable, arrNode__ As arrNode) As DataTable
        Dim data_items As DataTable = Nothing

        If IsNothing(dataold_) Then
            Exit Function
        End If
        ':// Commit iSit 09092020
        data_items = dataold_.Copy()

        If arrNode__.sort <> "" Then
            data_items.DefaultView.Sort = arrNode__.sort

            data_items = data_items.DefaultView.ToTable
        End If

        For i As Integer = 0 To dataold_.Columns.Count - 1
            If arrNode__.id <> dataold_.Columns(i).ColumnName And arrNode__.ref <> dataold_.Columns(i).ColumnName And arrNode__.text <> dataold_.Columns(i).ColumnName And arrNode__.image <> dataold_.Columns(i).ColumnName Then
                data_items.Columns.Remove(dataold_.Columns(i).ColumnName)
            End If
        Next

        Column_table = data_items

    End Function
    Sub Process_node(_target As RadTreeView, _dtreture As DataTable, _Group As Ordinal)
        ':// Commit iSit 09092020-s
        For Each Items As DataRow In _dtreture.Rows
            Dim _targetObject As Object = New Object()
            Dim targetNode As RadTreeNode = New RadTreeNode()
            If Trim(Items("ref") & "") <> "" Then
                Select Case _Group
                    Case Ordinal._Start
                        Call TreeView_Add(_target, Trim(Items("text") & ""), Trim(Items("keynode") & ""), Trim(Items("image") & ""))
                    Case Ordinal._next, Ordinal._End
                        _targetObject = _target.FindNodeByValue(Items("ref"))
                        Call TreeView_Add(_targetObject, Trim(Items("text") & ""), Trim(Items("keynode") & ""))
                    Case Ordinal._image

                        _targetObject = _target.FindNodeByValue(Items("ref"))
                        Call TreeView_Add(_targetObject, Trim(Items("text") & ""), Trim(Items("keynode") & ""), Trim(Items("image") & ""))

                End Select
            End If
        Next
        ':// Commit iSit 09092020-E


    End Sub
    Sub TreeView_Add(target As Object, text As String, keynode As String, Optional image As String = "")

        Dim Nodes = New RadTreeNode()
        Nodes.Text = text
        Nodes.Value = keynode
        If image <> "" Then
            Nodes.ImageUrl = "../Main/picOrg.ashx?image=" & image & "&type=person&for=" & dataSoruce.TableName & "&time= " & Now & ""
        End If

        target.Nodes.Add(Nodes)

    End Sub
    Private Shared Function item_node(dt_groupby As DataTable, list_event As Level_node, cases As Ordinal) As DataTable

        Dim dtReture As DataTable = _temptable()

        Select Case cases
            Case Ordinal._image
                Dim query = From Row In dt_groupby.AsEnumerable
                            Select New With {
                                        .keynode = Row(list_event.keynode),
                                        .ref = Row(list_event.ref),
                                        .text = Row(list_event.text),
                                        .image = Row(list_event.image)
                            }
                For Each plus In query
                    dtReture.Rows.Add(plus.keynode, plus.ref, plus.text, plus.image)
                Next
            Case Ordinal._comment

                Dim query = From Row In dt_groupby.AsEnumerable
                            Select New With {
                                        .keynode = Row(list_event.keynode),
                                        .ref = Row(list_event.ref),
                                        .text = list_event.comment & Row(list_event.text)
                            }

                For Each plus In query
                    dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
                Next
            Case Else
                Dim query = From Row In dt_groupby.AsEnumerable
                            Select New With {
                                        .keynode = Row(list_event.keynode),
                                        .ref = Row(list_event.ref),
                                        .text = Row(list_event.text)
                            }
                For Each plus In query
                    dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
                Next
        End Select


        item_node = dtReture

    End Function
    Private Shared Function item_node(dt_groupby As DataTable, list_event As Level_node) As DataTable

        Dim dtReture As DataTable = _temptable()

        If list_event.comment <> "" Then

            Dim query = From Row In dt_groupby.AsEnumerable
                        Select New With {
                                    .keynode = Row(list_event.keynode),
                                    .ref = Row(list_event.ref),
                                    .text = list_event.comment & Row(list_event.text)
                        }

            For Each plus In query
                dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
            Next

        Else

            Dim query = From row In dt_groupby.AsEnumerable
                        Group row
                    By _keynode_ = row(list_event.keynode),
                        _ref_ = row(list_event.ref),
                        _text_ = row(list_event.text)
                    Into CountRow = Group
                        Select New With {
                                        .keynode = _keynode_,
                                        .ref = _ref_,
                                        .text = _text_
                                     }
            For Each plus In query
                dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
            Next
        End If


        item_node = dtReture

    End Function
    Private Shared Function item_node(dt_groupby As DataTable, list_event As Level_node, _count As Boolean) As DataTable

        If _count = False Then
            item_node = Nothing
            Exit Function
        End If

        Dim dtReture As DataTable = _temptable()

        Dim query = From row In dt_groupby.AsEnumerable
                    Group row
                    By _keynode_ = row(list_event.keynode),
                        _ref_ = row(list_event.ref),
                        _text_ = row(list_event.text)
                    Into CountRow = Group
                    Select New With {
                                        .keynode = _keynode_,
                                        .ref = _ref_,
                                        .text = _text_ & " (" & CountRow.Count & ") "
                                     }

        For Each plus In query
            dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
        Next

        item_node = dtReture

    End Function
    Private Shared Function item_node(dt_groupby As DataTable, _keynode As String, _ref As String, _text As String, Optional _comment As String = "") As DataTable

        Dim dtReture As DataTable = _temptable()

        Dim query = From p In dt_groupby.AsEnumerable
                    Select New With {
                                .keynode = p.Field(Of String)(_keynode),
                                .ref = p.Field(Of String)(_ref),
                                .text = p.Field(Of String)(_text) & p.Field(Of String)(_comment)
                    }

        For Each plus In query
            dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
        Next

        item_node = dtReture

    End Function
    Private Shared Function item_node(dt_groupby As DataTable, _keynode As String, _ref As String, _text As String, _count As Boolean) As DataTable

        If _count = False Then
            item_node = Nothing
            Exit Function
        End If

        Dim dtReture As DataTable = _temptable()

        Dim query = From row In dt_groupby.AsEnumerable
                    Group row
                    By _keynode_ = row.Field(Of String)(_keynode),
                        _ref_ = row.Field(Of String)(_ref),
                        _text_ = row.Field(Of String)(_text)
                    Into CountRow = Group
                    Select New With {
                                        .keynode = _keynode_,
                                        .ref = _ref_,
                                        .text = _text_ & " (" & CountRow.Count & ") "
                                     }
        For Each plus In query
            dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
        Next

        item_node = dtReture


    End Function
    Private Shared Function _temptable() As DataTable

        Dim temptable = New DataTable
        temptable.Columns.Add("keynode", GetType(String))
        temptable.Columns.Add("ref", GetType(String))
        temptable.Columns.Add("text", GetType(String))
        temptable.Columns.Add("image", GetType(String))
        _temptable = temptable
    End Function


    Function GetFirstLeafNode(ByVal nodes As RadTreeNodeCollection, Optional xNodeVal As Integer = 0) As RadTreeNode
        Dim firstLeafNode As RadTreeNode = Nothing
        If xNodeVal = 0 Then
            If nodes.Count > 0 Then
                If nodes(0).Nodes.Count = 0 Then
                    firstLeafNode = nodes(0)
                Else
                    firstLeafNode = GetFirstLeafNode(nodes(0).Nodes)
                End If
            End If
        End If
        Return firstLeafNode
    End Function
    Private Structure Level_node
        Public keynode As String
        Public ref As String
        Public text As String
        Public image As String
        Public count As String
        Public comment As String
        ':// Commit iSit 09092020
        Public sort As String

        Public Sub New(_keynode As String, _ref As String, _text As String, Optional _comment As String = "")
            Me.keynode = _keynode
            Me.ref = _ref
            Me.text = _text
            Me.comment = _comment
            Me.image = ""
        End Sub
        Public Sub New(_keynode As String, _ref As String, _text As String, Optional _comment As String = "", Optional _image As String = "")
            Me.keynode = _keynode
            Me.ref = _ref
            Me.text = _text
            Me.comment = _comment
            Me.image = _image
        End Sub
    End Structure

End Class

Public Class Treelist

    Sub New()
    End Sub

    Public Enum Ordinal
        _First = 0
        _Second = 1
        _Third = 2
        _Fourth = 3
        _Fifth = 4
        _Start = 0
        _End = 1
        _next = 5
        _image = 10
        _comment = 11
    End Enum

    Public Sub _Binding(obj_ As RadTreeView, data_ As DataTable, Colus_ As ArrayList)


        Dim data_items As DataTable = Nothing

        If IsNothing(data_) And IsNothing(obj_) Then
            Exit Sub
        End If

        obj_.Nodes.Clear()

        Dim Props As New Props()

        For i As Integer = 0 To Colus_.Count - 1


            If Colus_(i).id <> "" Then Props.keynode = Colus_(i).id
            If Colus_(i).ref <> "" Then Props.ref = Colus_(i).ref
            If Colus_(i).text <> "" Then Props.text = Colus_(i).text
            If Colus_(i).image <> "" Then Props.image = Colus_(i).image
            If Colus_(i).comment <> "" Then Props.comment = Colus_(i).comment


            data_items = data_.Copy()

            If obj_.Nodes.Count = Ordinal._Start Then

                data_items = item_node(Column_table(data_items, Colus_(i)), Props)


            ElseIf i = Colus_.Count - Ordinal._End Then


            Else


            End If

        Next
    End Sub

    Private Shared Function item_node(dt_groupby As DataTable, listProps As Props) As DataTable
        Try

            Dim dtReture As DataTable = _temptable()


            If listProps.comment <> "" And listProps.image = "" Then
                Dim query = From Row In dt_groupby.AsEnumerable
                            Select New With {
                                        .keynode = Row(listProps.keynode),
                                        .ref = Row(listProps.ref),
                                        .text = listProps.comment & Row(listProps.text)
                            }

                For Each plus In query
                    dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
                Next
            ElseIf listProps.comment = "" And listProps.image <> "" Then


            ElseIf listProps.comment <> "" And listProps.image <> "" Then


            Else

                Dim query = From Row In dt_groupby.AsEnumerable
                            Select New With {
                                        .keynode = Row(listProps.keynode),
                                        .ref = Row(listProps.ref),
                                        .text = Row(listProps.text)
                            }
                For Each plus In query
                    dtReture.Rows.Add(plus.keynode, plus.ref, plus.text)
                Next

            End If



            item_node = dtReture
        Catch ex As Exception
            Throw New Exception("item_node (DataTable,Props,Ordinal) : " & ex.Message)
        End Try
    End Function
    Private Shared Function _temptable() As DataTable
        Try

            Dim temptable = New DataTable
            temptable.Columns.Add("keynode", GetType(String))
            temptable.Columns.Add("ref", GetType(String))
            temptable.Columns.Add("text", GetType(String))
            temptable.Columns.Add("comment", GetType(String))
            temptable.Columns.Add("image", GetType(String))
            _temptable = temptable

        Catch ex As Exception
            Throw New Exception("Temptable : " & ex.Message)
        End Try

    End Function
    Public Sub AddItems(target As Object, Items As DataRow)
        Try

            Dim Nodes = New RadTreeNode()

            If Items("text") <> "" Then
                Nodes.Text = Items("text")
            End If

            If Items("keynode") <> "" Then
                Nodes.Value = Items("keynode")
            End If

            If Items("image") <> "" Then
                Nodes.ImageUrl = Items("image")
            End If

            target.Nodes.Add(Nodes)

        Catch ex As Exception
            Throw New Exception("AddItems : " & ex.Message)
        End Try
    End Sub
    Function Column_table(dataold_ As DataTable, arrNode__ As arrNode) As DataTable
        Dim data_items As DataTable = Nothing

        If IsNothing(dataold_) Then
            Exit Function
        End If
        data_items = dataold_.Copy()
        For i As Integer = 0 To dataold_.Columns.Count - 1
            If arrNode__.id <> dataold_.Columns(i).ColumnName And arrNode__.ref <> dataold_.Columns(i).ColumnName And arrNode__.text <> dataold_.Columns(i).ColumnName And arrNode__.image <> dataold_.Columns(i).ColumnName Then
                data_items.Columns.Remove(dataold_.Columns(i).ColumnName)
            End If
        Next

        Column_table = data_items

    End Function

    Private Structure Props
        Public keynode As String
        Public ref As String
        Public text As String
        Public image As String
        Public count As String
        Public comment As String
        Public Sub New(_keynode As String, _ref As String, _text As String, Optional _comment As String = "")
            Me.keynode = _keynode
            Me.ref = _ref
            Me.text = _text
            Me.comment = _comment
            Me.image = ""
        End Sub
        Public Sub New(_keynode As String, _ref As String, _text As String, Optional _comment As String = "", Optional _image As String = "")
            Me.keynode = _keynode
            Me.ref = _ref
            Me.text = _text
            Me.comment = _comment
            Me.image = _image
        End Sub
    End Structure
End Class


Public Class arrNode
    Public id As String
    Public ref As String
    Public text As String
    Public image As String
    Public count As String
    Public comment As String
    Public sort As String

    Public Sub New(_id As String, _ref As String, _text As String, Optional _comment As String = "", Optional _sort As String = "")
        Me.id = _id
        Me.ref = _ref
        Me.text = _text
        Me.comment = _comment
        Me.sort = _sort
    End Sub

    Public Sub New()

    End Sub
End Class