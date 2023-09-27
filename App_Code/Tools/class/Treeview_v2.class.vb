Imports System.Data
Imports Telerik.Web.UI


Public Class treeview_v2

    Dim ele As Object = Nothing
    Dim data As DataTable = New DataTable
    Public Property totals As Integer = 0
    Public Property sort As String
    Public Property NodesValue As String
    Public Property NodesText As String
    Public Property NodeGroup As String


    Sub New(e As RadTreeView)
        Me.ele = e
        Me.Nodes = New List(Of Node)
        Me.sort = ""
    End Sub


    Public Sub Binding(data As DataTable)

        Dim dts As DataTable = New DataTable

        Try

            ele.Nodes.Clear()

            If IsNothing(data) Then Exit Sub

            data = NodesSort(data)

            For Each item In Nodes

                dts = GroupData(data, item)

                For Each dr In dts.Rows
                    NodesItems(dr, item, data.TableName)
                Next
            Next

            totals = dts.Rows.Count

            NodesFirst()

        Catch ex As Exception
            Throw New Exception("Binding : " & ex.Message)
        End Try

    End Sub


    Sub Empty()
        Try
            ele.Nodes.Clear()
        Catch ex As Exception
            Throw New Exception()
        End Try
    End Sub

    Function NodesSort(data As DataTable) As DataTable

        Dim dt As DataTable = New DataTable

        Try

            If IsNothing(data) Then NodesSort = Nothing

            data.DefaultView.Sort = Me.sort

            dt = data.DefaultView.ToTable

        Catch ex As Exception
            dt = Nothing
            Throw New Exception("NodesSort : " & ex.Message)
        End Try

        NodesSort = dt

    End Function

    Sub NodesFirst()

        Try

            Dim nodeSelect As RadTreeNode = New RadTreeNode()

            nodeSelect = GetFirstLeafNode(ele.Nodes)

            If nodeSelect IsNot Nothing Then
                NodesValue = nodeSelect.Value
                NodesText = nodeSelect.Text

                nodeSelect.Selected = True
                nodeSelect.Expanded = True
                nodeSelect.ExpandParentNodes()
            End If

        Catch ex As Exception
            Throw New Exception("NodesFirst : " & ex.Message)
        End Try

    End Sub

    Sub NodesItems(data As DataRow, nodes As Node, name As String)

        Try

            Dim item = New RadTreeNode()
            Dim targetObject As Object = New Object()
            item.Value = data(nodes.id)



            If Not IsNothing(nodes.image) And nodes.image <> "image_o" Then
                
                item.ImageUrl = "~/data/image?image=" & data(nodes.image) & "&type=person&field=PersonPic&for=" & name & "&time= " & Now & ""
            End If

            Select Case nodes.level
                Case 0
                    If nodes.count Then
                        item.Text = Trim(data(nodes.text) & "") & " (" & IIf(nodes.count, data("count"), "") & ") "
                    Else
                        item.Text = Trim(data(nodes.text) & "")
                    End If

                    ele.Nodes.Add(item)
                Case 1
                    targetObject = ele.FindNodeByValue(Val(nodes.level & "") - 1 & "_" & data(nodes.ref))
                    item.Text = Trim(data(nodes.text) & "")
                    targetObject.Nodes.Add(item)
            End Select

        Catch ex As Exception
            Throw New Exception("NodesItems : " & ex.Message)
        End Try

    End Sub


    Function GroupData(data As DataTable, item As Object) As DataTable

        Dim dt As DataTable = New DataTable

        Try

            data = ClearOther(data, item)

            If IsNothing(item.image) Then
                If data.Columns.Contains("image_o") Then
                    item.image = "image_o"
                End If
            End If

            Dim query = From Row In data.AsEnumerable
                        Group Row
                        By _keynode_ = Row(item.id),
                           _text_ = Row(item.text),
                            _ref_ = IIf(item.id <> item.ref, Row(item.ref), ""),
                            _image_ = Row(item.image)
                        Into CountRow = Group
                        Select New With {
                                            .keynode = _keynode_,
                                            .text = _text_,
                                            .ref = _ref_,
                                            .image = _image_,
                                            .count = IIf(item.count, CountRow.Count, "")
                                         }


            If dt.Columns.Count = 0 Then

                If Not dt.Columns.Contains(item.id) Then
                    dt.Columns.Add(item.id, GetType(String))
                End If

                If Not dt.Columns.Contains(item.text) Then
                    dt.Columns.Add(item.text, GetType(String))
                End If

                If Not IsNothing(item.ref) Then

                    If item.id = item.ref Then
                        If Not dt.Columns.Contains(item.ref & "_ref") Then
                            dt.Columns.Add(item.ref & "_ref", GetType(String))
                        End If
                    Else
                        If Not dt.Columns.Contains(item.ref) Then
                            dt.Columns.Add(item.ref, GetType(String))
                        End If
                    End If
                End If

                If item.count Then
                    dt.Columns.Add("count", GetType(Integer))
                End If

                If Not IsNothing(item.image) Then
                    dt.Columns.Add(item.image, GetType(String))
                End If

            End If

            For Each plus In query

                Dim dtClone = dt.NewRow()

                If plus.ToString.Contains("keynode") Then

                    If Val(Nodes.Count & "") - 1 <> item.level Then
                        dtClone(item.id) = item.level & "_" & plus.keynode
                    Else
                        dtClone(item.id) = plus.keynode
                    End If

                End If

                If plus.ToString.Contains("text") Then
                    dtClone(item.text) = plus.text
                End If

                If Not IsNothing(item.ref) Then

                    If plus.ToString.Contains("ref") Then
                        If item.id = item.ref Then
                            dtClone(item.ref & "_ref") = plus.keynode
                        Else
                            dtClone(item.ref) = plus.ref
                        End If
                    Else

                    End If
                End If

                If plus.ToString.Contains("image") Then
                    If item.image <> "image_o" Then
                        dtClone(item.image) = plus.image
                    End If
                    
                End If

                If plus.ToString.Contains("count") Then
                    If item.count Then
                        dtClone("count") = plus.count
                    End If
                End If

                dt.Rows.Add(dtClone)

            Next

        Catch ex As Exception
            Throw New Exception("GroupData : " & ex.Message)
        End Try

        GroupData = dt

    End Function

    Function ClearOther(data As DataTable, item As Object) As DataTable

        Dim dts As DataTable = New DataTable

        Try

            If IsNothing(data) Then Exit Function

            dts = data.Copy

            If IsNothing(item.image) Then
                item.image = "image_o"
                dts.Columns.Add("image_o", GetType(String))
            End If

            For Each rm In data.Copy.Columns
                If rm.ColumnName <> item.id And rm.ColumnName <> item.text And rm.ColumnName <> item.ref And rm.ColumnName <> item.ref And rm.ColumnName <> item.image Then
                    dts.Columns.Remove(rm.ColumnName)
                End If
            Next


        Catch ex As Exception
            dts = Nothing
            Throw New Exception("Clear Other :" & ex.Message)
        End Try

        ClearOther = dts

    End Function

    Function GetFirstLeafNode(ByVal nodes As RadTreeNodeCollection, Optional xNodeVal As Integer = 0) As RadTreeNode
        Dim firstLeafNode As RadTreeNode = Nothing

        Try

            If xNodeVal = 0 Then
                If nodes.Count > 0 Then
                    If nodes(0).Nodes.Count = 0 Then
                        firstLeafNode = nodes(0)
                    Else
                        firstLeafNode = GetFirstLeafNode(nodes(0).Nodes)
                    End If
                End If
            End If

        Catch ex As Exception
            Throw New Exception("GetFirstLeafNode : " & ex.Message)
        End Try
        Return firstLeafNode

    End Function

    Sub Selecting(Optional group As String = "")

        ele = CType(ele, RadTreeView)

        Dim targetObject As Object = New Object()
        Dim newNode As New RadTreeNode()

        newNode.Text = NodesText
        newNode.Value = NodesValue
        newNode.Selected = True

        Select Case NodeGroup
            Case 0
                If group <> "" Then
                    targetObject = ele.FindNodeByValue(NodeGroup & "_" & group)
                    If Not IsNothing(targetObject) Then
                        targetObject.Nodes.Add(newNode)
                    Else
                        ele.Nodes.Add(newNode)
                    End If
                Else
                    ele.Nodes.Add(newNode)
                End If

        End Select

    End Sub

    Sub Selected(Optional group As String = "")
        ele = CType(ele, RadTreeView)

        Dim node As New RadTreeNode()

        If Not IsNothing(ele) Then

            node = ele.FindNodeByValue(group)
            If node IsNot Nothing Then
                node.Selected = True
            End If
        End If
    End Sub

    Public Property Nodes As List(Of Node)
    Public Class Node
        Public Property level As Integer
        Public Property id As String
        Public Property ref As String
        Public Property text As String
        Public Property image As String
        Public Property count As Boolean = False
        Public Property comment As String
        Public Property sort As String

    End Class

End Class
