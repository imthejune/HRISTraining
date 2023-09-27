Imports System.Data


Public Module Bases

    Public Enum Cases
        Update = 1
        Statics = 0
        First = 1
        Dynamic = 1
        Application = 1
        Sessions = 2
        Rows = 3
    End Enum

    Public Apps As New Applications
    Public Secs As New Sessions

    Public Adapter As Object
    Public xConnect As String = ""


    Sub ControlProps()
        If xConnect <> "" Then
            Adapter = New Mydata(adoconn, xConnect)
            xConnect = ""
        Else
            Adapter = New Mydata(adoconn, "")
        End If

    End Sub

    Sub Start()

        HttpContext.Current.Application("Applicaton_data") = New DataSet()
        HttpContext.Current.Session("Session_data") = New DataSet()

    End Sub

    Public Function DataSet(Optional tableLang As String = "") As DataSet
        Dim ds As DataSet = New DataSet
        Try

            If tableLang <> "" Then
                tableLang = String.Format(tableLang, Sys.LoginWeb.Lang)
            End If

            If Not IsNothing(Currs("Session")) Then
                ds = Currs("Session")
            Else
                ds = Nothing
            End If

        Catch ex As Exception
            ds = Nothing
        End Try

        DataSet = ds

    End Function

    Public Function read(tableLang As String) As DataTable
        Dim dt As DataTable = New DataTable
        Try

            Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)

            If Not IsNothing(Currs("Applicaton")) Then
                If Currs("Applicaton").Tables.IndexOf(tableName) > -1 Then
                    dt = Currs("Applicaton").Tables(tableName)
                Else
                    If Not IsNothing(Currs("Session")) Then
                        If Currs("Session").Tables.IndexOf(tableName) > -1 Then
                            dt = Currs("Session").Tables(tableName)
                        Else
                            dt = Nothing
                        End If
                    Else
                        dt = Nothing
                    End If
                End If
            ElseIf Not IsNothing(Currs("Session")) Then
                If Currs("Session").Tables.IndexOf(tableName) > -1 Then
                    dt = Currs("Session").Tables(tableName)
                Else
                    dt = Nothing
                End If
            Else
                dt = Nothing
            End If
        Catch ex As Exception
            Throw New Exception("read : " & ex.Message)
        End Try

        read = dt
    End Function

    Public Function list(table_ As String, value_ As String, Optional type As Integer = 0) As SortedList
        Dim srl As SortedList = New SortedList
        Try

            Dim dr() As DataRow = read(table_).Copy.Select(value_)

            If dr.Length > 0 Then
                srl = Change._ToList(dr.CopyToDataTable, type)
            Else
                srl = Nothing
            End If

        Catch ex As Exception
            Throw New Exception("list : " & ex.Message)
        End Try

        list = srl
    End Function


    ''' <summary>
    ''' ค้นหาแบบมีเงื่อยไข โดยทำงานตัด Row ที่มี ID ซ้ำกัน
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns>SortedList</returns>
    ''' <remarks>@value param 2 of type string "Fields{:}condition"</remarks>
    Public Function findIndex(table As String, value As String, Optional typeGet As Integer = 0) As SortedList

        Dim tempSort As SortedList = Nothing
        Dim opt As String = ""
        Try

            Dim arrValue() As String = value.ToString().Split(":")

            If arrValue.Length <> 2 Then Exit Try

            Dim temp As DataTable = read(table)

            If IsNothing(temp) Then Exit Try

            If arrValue(1).ToString.IndexOf("=") < 0 Then
                arrValue(1) = "=" & arrValue(1)
            End If

            Dim dr() As DataRow = temp.Select(arrValue(0) & " " & arrValue(1))

            If dr.Length > 1 Then
                temp = duplicate(dr.CopyToDataTable, arrValue(0))
                tempSort = Change._ToSorted(temp, typeGet)
            Else
                If dr.Length = 0 Then
                    Exit Try
                End If
                tempSort = Change._ToSorted(dr.CopyToDataTable, typeGet)
            End If

        Catch ex As Exception
            tempSort = Nothing
            Throw New Exception("findIndex : " & ex.Message)
        End Try

        findIndex = tempSort

    End Function
    ''' <summary>
    ''' ค้นหาแบบมีเงื่อยไข โดยทำงานตัด Row ที่มี ID ซ้ำกัน
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns>SortedList</returns>
    ''' <remarks>@value param 2 of type string "Fields{:}condition"</remarks>
    Public Function findIndex(table As DataTable, value As String, Optional typeGet As Integer = 0) As SortedList

        Dim tempSort As SortedList = Nothing
        Dim opt As String = ""

        Try

            Dim arrValue() As String = value.ToString().Split(":")

            If arrValue.Length <> 2 Then
                tempSort = Nothing
                Exit Try
            End If

            Dim temp As DataTable = New DataTable

            temp = table

            If IsNothing(temp) Then
                tempSort = Nothing
                Exit Try
            End If

            If arrValue(1).ToString.IndexOf("=") < 0 Then
                arrValue(1) = "=" & arrValue(1)
            End If

            Dim dr() As DataRow = temp.Select(arrValue(0) & " " & arrValue(1))

            If dr.Length > 1 Then
                temp = duplicate(dr.CopyToDataTable, arrValue(0))
                tempSort = Change._ToSorted(temp, typeGet)
            Else
                If dr.Length = 0 Then
                    tempSort = Nothing
                End If
                ' tempSort = dr.CopyToDataTable
            End If

        Catch ex As Exception
            tempSort = Nothing
            Throw New Exception("findIndex : " & ex.Message)
        End Try

        findIndex = tempSort



    End Function

    Public Function selects(table_ As String, value_ As String, Optional typeGet As Integer = 0) As SortedList

        Try

            Dim dr() As DataRow = read(table_).Copy.Select(value_)

            If dr.Length = 0 Then
                selects = Nothing
                Exit Function
            End If

            selects = Change._ToSorted(dr.CopyToDataTable, typeGet)

        Catch ex As Exception
            Throw New Exception("selects : " & ex.Message)
        End Try

    End Function

    Public Function duplicate(tempTb As DataTable, colName As String) As DataTable

        Dim hTable As Hashtable = New Hashtable()
        Dim duplicateList As ArrayList = New ArrayList()
        Dim dt As DataTable = New DataTable
        Try

            If IsNothing(tempTb) Then
                dt = tempTb
                Exit Try
            End If

            dt = tempTb
            For Each drow As DataRow In tempTb.Rows
                If hTable.Contains(drow(colName)) Then
                    duplicateList.Add(drow)
                Else
                    hTable.Add(drow(colName), String.Empty)
                End If
            Next
            For Each dRow As DataRow In duplicateList
                dt.Rows.Remove(dRow)
            Next

            dt = dt

        Catch ex As Exception
            dt = Nothing
            Throw New Exception("Duplicate : " & ex.Message)
        End Try

        duplicate = dt

    End Function

    Public Function rows(table_ As String, value_ As String, Optional typeGet As Integer = 0) As DataRow()

        Try

            Dim dr() As DataRow = read(table_).Copy.Select(value_)


            If dr.Length > 0 Then
                rows = dr
            Else
                rows = Nothing
            End If

        Catch ex As Exception
            Throw New Exception("rows : " & ex.Message)
        End Try

    End Function
    Public Function clear(tableName As String) As DataTable

        Try
            If Not IsNothing(Currs("Applicaton")) Then
                If Currs("Applicaton").Tables.IndexOf(tableName) > -1 Then
                    Currs("Applicaton").Tables(tableName).Rows.Clear()
                Else
                    If Not IsNothing(Currs("Session")) Then
                        If Currs("Session").Tables.IndexOf(tableName) > -1 Then
                            Currs("Session").Tables(tableName).Rows.Clear()
                        End If
                    End If
                End If
            ElseIf Not IsNothing(Currs("Session")) Then
                If Currs("Session").Tables.IndexOf(tableName) > -1 Then
                    Currs("Session").Tables(tableName).Rows.Clear()
                End If
            End If

            clear = read(tableName)
        Catch ex As Exception
            Throw New Exception("clear : " & ex.Message)
        End Try
    End Function
    Public Sub remove(tableName As String)

        Try
            If Not IsNothing(Currs("Applicaton")) Then
                If Currs("Applicaton").Tables.IndexOf(tableName) > -1 Then
                    Currs("Applicaton").Tables.Remove(tableName)
                End If
            ElseIf Not IsNothing(Currs("Session")) Then
                If Currs("Session").Tables.IndexOf(tableName) > -1 Then
                    Currs("Session").Tables.Remove(tableName)
                End If
            End If
        Catch ex As Exception
            Throw New Exception("remove : " & ex.Message)
        End Try

    End Sub

    Public Function merge(tableLang As String, dt As DataTable, Optional Current As Cases = Cases.Sessions) As DataTable

        Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)

        Try

            Dim dsWrite As DataSet = New DataSet
            Dim Curr$ = IIf(Current = Cases.Sessions, "Session", "Applicaton")

            If IsNothing(dsWrite) Then
                dsWrite = New DataSet
            End If

            dsWrite = Currs(Curr)

            If dt.TableName = "" Then
                dt.TableName = tableName
            Else
                If dt.TableName <> tableName Then
                    dt.TableName = tableName
                End If
            End If


            merge = Currs(Curr, 1, ControlMergeTable(tableName, Currs(Curr), dt)).Tables(tableName)

        Catch ex As Exception
            Throw New Exception("merge : " & ex.Message)
        End Try

    End Function

    Public Function ControlMergeTable(tableName As String, ds_ As DataSet, dt_ As DataTable, Optional Cases As Cases = Cases.Statics) As DataSet

        Try

            If Not ds_.Tables.Contains(tableName) Then
                ds_.Tables.Add(dt_)
            Else

                If Cases = 10 Then
                    ds_.Tables.Remove(tableName)
                Else
                    ds_.Tables(tableName).Merge(dt_)
                End If
            End If
        Catch ex As Exception
            Throw New Exception("ControlMergeTable : " & ex.Message)
        End Try

        ControlMergeTable = ds_

    End Function

    Public Function copy(tableLang As String, key As String, Optional str As String = "", Optional Current As Cases = Cases.Sessions) As DataTable

        Try
            Call ControlProps()
            Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)

            Dim dsWrite As DataSet = New DataSet
            Dim Curr$ = IIf(Current = Cases.Application, "Applicaton", "Session")

            dsWrite = Currs(Curr)

            If IsNothing(dsWrite) Then
                dsWrite = New DataSet
            End If

            If str <> "" Then
                dsWrite = ControlGet(dsWrite, tableName, str, Cases.Statics)
            End If

            Dim dt As DataTable = New DataTable

            dt = dsWrite.Tables(tableName).Copy()

            key = tableName & "_" & key

            dt.TableName = key

            copy = Currs(Curr, 1, ControlCopy(dsWrite, dt)).Tables(key).Copy()

        Catch ex As Exception
            copy = Nothing
            Throw New Exception("ControlGet : " & ex.Message)
        End Try

    End Function

    Public Function ControlCopy(ds_ As DataSet, dtCopy As DataTable) As DataSet
        Try
            If Not ds_.Tables.Contains(dtCopy.TableName) Then
                ds_.Tables.Add(dtCopy.Copy)
            ElseIf ds_.Tables(dtCopy.TableName).Rows.Count = 0 Then
                ds_.Tables.Remove(dtCopy.TableName)
                ds_.Tables.Add(dtCopy.Copy())
            End If
        Catch ex As Exception
            Throw New Exception("ControlCopy : " & ex.Message)
        End Try

        ControlCopy = ds_
    End Function
    Dim CheckOut As Boolean = False
    Public Function ControlGet(ds_ As DataSet, tableLang As String, str As String, Optional Cases As Cases = Cases.Statics) As DataSet

        Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)

        Try
            If Not ds_.Tables.Contains(tableName) Then
                Adapter.GetDataset(ds_, String.Format(str, Sys.LoginWeb.Lang), tableName)
            Else
                If Cases = Cases.Update Then
                    ds_.Tables.Remove(tableName)
                    Adapter.GetDataset(ds_, String.Format(str, Sys.LoginWeb.Lang), tableName)
                Else
                    If ds_.Tables(tableName).Rows.Count = 0 Then
                        Adapter.GetDataset(ds_, String.Format(str, Sys.LoginWeb.Lang), tableName)
                    End If
                End If
            End If
            ControlGet = ds_
        Catch ex As Exception

            If InvalidObject(ex.Message) Then
                If CheckOut <> True Then
                    ControlGet(ds_, tableName, str, Cases)
                    ControlGet = ds_
                    CheckOut = False
                Else
                    ControlGet = Nothing
                    Throw New Exception("ControlGet : " & ex.Message)
                End If
            Else
                ControlGet = Nothing
                Throw New Exception("ControlGet : " & ex.Message)
            End If

        End Try

    End Function

    Public Function ControlPlus(ds_ As DataSet, dtPlus As DataTable, Optional Cases As Cases = Cases.Statics) As DataSet
        Try
            If Not ds_.Tables.Contains(dtPlus.TableName) Then

                ds_.Tables.Add(dtPlus.Copy)
            Else
                If Cases = Cases.Update Then
                    ds_.Tables.Remove(dtPlus.TableName)
                    ds_.Tables.Add(dtPlus.Copy())
                Else
                    If ds_.Tables(dtPlus.TableName).Rows.Count = 0 Then
                        ds_.Tables.Remove(dtPlus.TableName)
                        ds_.Tables.Add(dtPlus.Copy())

                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception("ControlPlus : " & ex.Message)
        End Try

        ControlPlus = ds_

    End Function

    Public Function ControlMerge(str As String, tableLang As String, ds_ As DataSet, Optional Cases As Cases = Cases.Statics) As DataSet

        Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)

        Try

            Dim dt_ As DataTable = New DataTable

            If Not IsNothing(ds_) Then
                Adapter.GetDataset(ds_, String.Format(str, Sys.LoginWeb.Lang), tableName)
            Else

                If Cases = Cases.Update Then

                    ds_.Tables.Remove(tableName)
                    Adapter.GetDataset(ds_, String.Format(str, Sys.LoginWeb.Lang), tableName)
                Else
                    dt_ = Adapter.GetDataTable(String.Format(str, Sys.LoginWeb.Lang), tableName)
                    ds_.Tables(tableName).Merge(dt_)
                End If

            End If

        Catch ex As Exception

            If InvalidObject(ex.Message) Then
                If CheckOut <> True Then
                    ControlMerge(str, tableName, ds_, Cases)
                    CheckOut = False
                Else
                    ds_ = Nothing
                    Throw New Exception("ControlMerge : " & ex.Message)
                End If
            Else
                ds_ = Nothing
                Throw New Exception("ControlMerge : " & ex.Message)
            End If
        End Try

        ControlMerge = ds_

    End Function

    Public Function ControlUpdate(ds_ As DataSet, dtPlus As DataTable, column As String) As DataSet

        Try

            If Not ds_.Tables.Contains(dtPlus.TableName) Then
                ds_.Tables.Add(dtPlus)
            Else

                For Each drCheck As DataRow In dtPlus.Rows

                    Dim drUpdate() As DataRow = ds_.Tables(dtPlus.TableName).Copy.Select(column & "='" & drCheck(column) & "'")

                    If drUpdate.Length = 0 Then

                        ds_.Tables(dtPlus.TableName).ImportRow(drCheck)

                    End If
                Next
            End If

        Catch ex As Exception
            Throw New Exception("ControlPlus : " & ex.Message)
        End Try

        ControlUpdate = ds_

    End Function

    Public Function Currs(typeCurr As String, Optional typeCase As Integer = 0, Optional dsCurrs As DataSet = Nothing) As DataSet
        Dim ds As DataSet

        Try
            If typeCase = 0 Then
                Select Case typeCurr
                    Case "Applicaton"
                        ds = DirectCast(HttpContext.Current.Application("Applicaton_data"), DataSet)
                    Case "Session"
                        ds = DirectCast(HttpContext.Current.Session("Session_data"), DataSet)
                End Select
            ElseIf typeCase = 1 Then
                ds = dsCurrs
                If IsNothing(ds) Then
                    ds = New DataSet()
                Else
                    Select Case typeCurr
                        Case "Applicaton"
                            HttpContext.Current.Application("Applicaton_data") = ds ' Currs = DirectCast(HttpContext.Current.Session("Applicaton_data"), DataSet)
                        Case "Session"
                            HttpContext.Current.Session("Session_data") = ds
                    End Select
                End If
            End If

        Catch ex As Exception
            ds = Nothing
            Throw New Exception("Currs : " & ex.Message)
        End Try
        Currs = ds
    End Function

    Public Function InvalidObject(st As String) As Boolean
        '    Dim Count_Invali As Integer = 0
        '    Dim exe As New connExecute
        '    Try
        '        Dim str$ = ""

        '        If st.IndexOf("Invalid object name") > -1 Then
        '            st = st.Replace("Invalid object name", "")

        '            If st.IndexOf("DVM_Register") > -1 Then
        '                exe.ExecuteNonQuery(table.DVM_Register)
        '                exe.ExecuteNonQuery(after.DVM_Register_CreateDate)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("DVT_EventLog") > -1 Then
        '                exe.ExecuteNonQuery(table.DVT_EventLog)
        '                exe.ExecuteNonQuery(after.DVM_EventLog_CreateDate)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("COM_Organization") > -1 Then
        '                exe.ExecuteNonQuery(table.COM_Organization)
        '                exe.ExecuteNonQuery(after.COM_Organization_CreateDate)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("COT_Orgsub") > -1 Then
        '                exe.ExecuteNonQuery(table.COT_Orgsub)
        '                exe.ExecuteNonQuery(after.COT_Orgsub_CreateDate)
        '                Count_Invali += 1
        '            End If


        '        ElseIf st.IndexOf("Invalid column name") > -1 Then

        '            st = st.Replace("Invalid column name", "")

        '            If st.IndexOf("Company_AddE") > -1 Then
        '                exe.ExecuteNonQuery(after.COMCompany_AddE)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("Company_SoiE") > -1 Then
        '                exe.ExecuteNonQuery(after.COMCompany_SoiE)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("Company_StreeE") > -1 Then
        '                exe.ExecuteNonQuery(after.COMCompany_StreeE)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("RegisterGuid") > -1 Then
        '                exe.ExecuteNonQuery(after.ADM_User_RegisterGuid)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("RegisterStatus") > -1 Then
        '                exe.ExecuteNonQuery(after.ADM_User_RegisterStatus)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("RegisterGeo") > -1 Then
        '                exe.ExecuteNonQuery(after.ADM_User_RegisterGeo)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("Version") > -1 Then
        '                exe.ExecuteNonQuery(after.ComTemplate_version)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("PRT_TmpPayment3") > -1 Then
        '                exe.ExecuteNonQuery(table.PRT_TmpPayment3)
        '                Count_Invali += 1
        '            End If


        '            If st.IndexOf("PRT_TmpReportTax3") > -1 Then
        '                exe.ExecuteNonQuery(table.PRT_TmpReportTax3)
        '                Count_Invali += 1
        '            End If

        '            If st.IndexOf("PRM_Tax3List") > -1 Then
        '                exe.ExecuteNonQuery(table.PRM_Tax3List)
        '                Count_Invali += 1
        '            End If

        '        End If

        '        If Count_Invali <> 0 Then
        '            InvalidObject = True
        '        Else
        '            InvalidObject = False
        '        End If
        '    Catch ex As Exception
        '        InvalidObject = False
        '        Throw New Exception("InvalidObject  :" & ex.Message)
        '    End Try

    End Function

    'Public Function InsertItems(type_ As String) As Boolean
    '    Dim status As Boolean = False
    '    Dim exe As New connExecute

    '    Try

    '        If type_ <> "" Then
    '            Select Case type_
    '                Case "DH01"
    '                    exe.ExecuteNonQuery(insert.AdmProgram.DH01)
    '                Case "DH02"
    '                    exe.ExecuteNonQuery(insert.AdmProgram.DH02)
    '                Case "DH03"
    '                    exe.ExecuteNonQuery(insert.AdmProgram.DH03)
    '            End Select
    '            'Next
    '            status = True
    '        End If
    '    Catch ex As Exception
    '        Throw New Exception("InsertItems  :" & ex.Message)
    '        Exit Function
    '    End Try

    '    InsertItems = status

    'End Function

    Public Class Transacion

        Function Create() As DataTable

            Dim dtCreate As DataTable = New DataTable
            dtCreate.TableName = "Transacion"
            dtCreate.Columns.Add("ID", GetType(String))
            dtCreate.Columns.Add("StrSql", GetType(String))
            dtCreate.Columns.Add("For", GetType(String))
            dtCreate.Columns.Add("Rows", GetType(Integer))
            dtCreate.Columns.Add("Column", GetType(Integer))
            dtCreate.Columns.Add("Size", GetType(Double))
            dtCreate.Columns.Add("Table", GetType(String))
            dtCreate.Columns.Add("Status", GetType(Integer))
            dtCreate.Columns.Add("Types", GetType(Integer))
            dtCreate.Columns.Add("Count", GetType(Integer))
            Create = dtCreate

        End Function

        Sub Read()


        End Sub

        Sub reset()



        End Sub

        Sub write()

            Dim dsWrite As DataSet
            dsWrite = Currs("Session")

            If IsNothing(dsWrite) Then
                dsWrite = New DataSet
            End If


        End Sub

    End Class

    Class Applications

        Function write(str As String, tableLang As String, Optional cs As Cases = Cases.Statics) As DataTable
            Try
                Call ControlProps()
                Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)
                Dim dsWrite As DataSet

                dsWrite = Currs("Applicaton")

                If IsNothing(dsWrite) Then
                    dsWrite = New DataSet
                End If

                write = Currs("Applicaton", 1, ControlGet(dsWrite, tableName, str, cs)).Tables(tableName)

            Catch ex As Exception
                Throw New Exception("Applications-write : " & ex.Message)
            End Try
        End Function

        Function plus(dt_ As DataTable, Optional tableLang As String = "", Optional cs As Cases = Cases.Statics) As DataTable
            Try
                Call ControlProps()
                Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)
                Dim dsWrite As DataSet

                dsWrite = Currs("Applicaton")

                If IsNothing(dsWrite) Then
                    dsWrite = New DataSet
                End If

                If dt_.TableName <> "" Then
                    dt_.TableName = tableName
                Else
                    If dt_.TableName = "" And tableName = "" Then
                        tableName = "Plus_" & dsWrite.Tables.Count + 1
                        dt_.TableName = tableName
                    ElseIf tableName <> "" Then
                        dt_.TableName = tableName
                    End If
                End If

                plus = Currs("Applicaton", 1, ControlPlus(dsWrite, dt_, cs)).Tables(tableName).Copy()
            Catch ex As Exception
                Throw New Exception("Applicaton-plus : " & ex.Message)
            End Try
        End Function

        Sub New()

        End Sub
    End Class

    Class Sessions

        Public data As DataTable = New DataTable()

        Function write(str As String, tableLang As String, Optional cs As Cases = Cases.Statics) As DataTable
            Try
                Call ControlProps()


                Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)


                Dim dsWrite As DataSet

                dsWrite = Currs("Session")

                If IsNothing(dsWrite) Then
                    dsWrite = New DataSet
                End If

                write = Currs("Session", 1, ControlGet(dsWrite, tableName, str, cs)).Tables(tableName).Copy()

            Catch ex As Exception
                Throw New Exception("Sessions-write : " & ex.Message)
            End Try

        End Function

        Function plus(dt_ As DataTable, Optional tableLang As String = "", Optional cs As Cases = Cases.Statics) As DataTable
            Try
                Call ControlProps()
                Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)

                Dim dsWrite As DataSet

                dsWrite = Currs("Session")

                If IsNothing(dsWrite) Then
                    dsWrite = New DataSet
                End If

                If dt_.TableName <> "" Then
                    dt_ = dt_.Copy
                    dt_.TableName = tableName
                Else
                    If dt_.TableName = "" And tableName = "" Then
                        tableName = "Plus_" & dsWrite.Tables.Count + 1
                        dt_.TableName = tableName
                    ElseIf tableName <> "" Then
                        dt_.TableName = tableName
                    End If
                End If


                plus = Currs("Session", 1, ControlPlus(dsWrite, dt_, cs)).Tables(tableName).Copy()
            Catch ex As Exception
                Throw New Exception("Sessions-plus : " & ex.Message)
            End Try
        End Function

        Function merge(str As String, tableLang As String, Optional cs As Cases = Cases.Statics) As DataTable
            Try
                Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)

                Call ControlProps()

                Dim dsWrite As DataSet

                dsWrite = Currs("Session")

                If IsNothing(dsWrite) Then
                    dsWrite = New DataSet
                End If

                merge = Currs("Session", 1, ControlMerge(str, tableName, dsWrite, cs)).Tables(tableName)

            Catch ex As Exception
                Throw New Exception("Sessions-merge : " & ex.Message)
            End Try

        End Function

        Function update(dt_ As DataTable, Column As String, Optional tableLang As String = "") As DataTable
            Call ControlProps()

            Dim dsWrite As DataSet

            Dim tableName As String = String.Format(tableLang, Sys.LoginWeb.Lang)
            dsWrite = Currs("Session")

            If IsNothing(dsWrite) Then
                dsWrite = New DataSet
            End If

            If dt_.TableName <> "" Then
                dt_.TableName = tableName
            End If

            update = Currs("Session", 1, ControlUpdate(dsWrite, dt_, Column)).Tables(tableName)

        End Function

        Sub New()
        End Sub
    End Class


End Module
