Imports System.Data
Imports System
Imports Telerik.Web.UI

Public Class Utility

    Public Shared Sub ClearObject(ByRef obj As Object)
        Try
            obj.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Sub CloseObject(ByRef obj As Object)
        Try
            If Not IsNothing(obj) Then
                obj.Close()
                obj.Dispose()
            End If
        Catch ex As Exception
        Finally
            obj = Nothing
        End Try
    End Sub

    Public Shared Function GetMasterData(ByVal dt As DataTable, ByVal dt_column As String, ByVal dt_value As String, ByVal return_value As String) As String
        Dim dr As DataRow() = Nothing
        Dim result As String = ""
        Try
            If Not IsNothing(dt) AndAlso dt_column <> "" AndAlso dt_value <> "" AndAlso return_value <> "" Then
                If dt.Rows.Count > 0 Then
                    dr = dt.Select(dt_column & "= '" & dt_value & "'")
                    If (dr.Length > 0) Then
                        result = dr(0)(return_value) & ""
                    End If
                End If
            End If
            Return result
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Sub hasChange(FormName As String, PersonCode As String, OldValue As Object, NewValue As Object, DataType As VariableType, Msg As String)
        Try
            If IsNothing(NewValue) Then Exit Sub

            Select Case DataType
                Case VariableType.varDate, VariableType.varDateTime
                    Try
                        If String.IsNullOrEmpty(OldValue & "") Then
                            OldValue = ""
                        Else
                            OldValue = DataHelper.ToDateTime(OldValue & "")
                        End If

                    Catch ex As Exception
                        OldValue = ""
                    End Try

                    Try
                        If String.IsNullOrEmpty(NewValue & "") Then
                            NewValue = ""
                        Else
                            NewValue = DataHelper.ToDateTime(NewValue & "")
                        End If
                    Catch ex As Exception
                        NewValue = ""
                    End Try

                Case VariableType.varNumeric
                    OldValue = Val(OldValue.ToString().Trim() & "")
                    NewValue = Val(NewValue.ToString().Trim() & "")

                Case VariableType.varText
                    OldValue = OldValue.ToString().Trim() & ""
                    NewValue = NewValue.ToString().Trim() & ""

                Case VariableType.varTime
                    OldValue = TimeSpan.Parse(OldValue.ToString().Trim())
                    NewValue = TimeSpan.Parse(NewValue.ToString().Trim())

                Case VariableType.varBoolean
                    OldValue = DataHelper.ToBoolean(OldValue, False)
                    NewValue = DataHelper.ToBoolean(NewValue, True)
            End Select


            If OldValue.ToString() <> NewValue.ToString() Then
                InsertLogfile(FormName, Trim(PersonCode & ""), Msg, OldValue, NewValue, "", "")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
