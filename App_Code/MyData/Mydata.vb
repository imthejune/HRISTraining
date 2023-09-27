Option Compare Text

Imports System.Data.SqlClient    'for sql server
Imports System.Data.OleDb        'for asscess 
'Imports iAnywhere.Data.AsaClient  'for sybase
Imports System.Data
Imports System.Data.Common
Imports System

'Public Enum DatabaseType
'    Access = 0
'    SQLServer = 1
'    Sybase = 2
'    Orlacle = 3
'End Enum
'Public Enum DBChoice
'    Bibilio = 0
'    Nwind = 1
'    NorthWind = 2
'End Enum
Public Class Mydata
    Implements IDisposable

    Private strCon As String
    Private me_DBType As DatabaseType = DatabaseType.SQLServer
    Dim _ErrorMessage As String
    Dim SqlParam As New Generic.Dictionary(Of String, SqlParameter)       'For sql
    Dim IsForTest As Boolean = False 'ForTest
    'For sql Access 
    'Dim CTROle As OleDbTransaction
    'For sql server   
    'Dim CTR As SqlTransaction
    Dim _CCn As SqlConnection

#Region " IDisposable Finalize "
    Private disposedValue As Boolean = False        ' To detect redundant calls
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If Not _CCn Is Nothing Then
                    _CCn.Dispose()
                End If
                If Not _da Is Nothing Then
                    _da.Dispose()
                End If
                _CCn = Nothing
                _da = Nothing
            End If
            '--free shared unmanaged resources
        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        'MyBase.Finalize() 'ไม่ต้องเรียกเพราะใน object finalize ไม่มีอะไรอยู่แล้ว
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Do not re-create Dispose clean-up code here.
        ' Calling Dispose(false) is optimal in terms of
        ' readability and maintainability.
        Dispose(False) 'ต้อง false เท่านั้น ถ้าใส่ true แด๋วจะ error
        MyBase.Finalize()
    End Sub
#End Region

    Public ReadOnly Property Connection() As SqlConnection
        Get
            Return _CCn
        End Get
    End Property

    Dim _da As SqlDataAdapter
    Private ReadOnly Property Da() As SqlDataAdapter
        Get
            Return _da
        End Get
    End Property

    Public ReadOnly Property ErrorMessage() As String
        Get
            Return _ErrorMessage
        End Get
    End Property

#Region " Sub New "
    'Public Sub New(ByVal x_DbType As DatabaseType)  'constructure
    '    me_DBType = x_DbType   'เลือกชนิด  ฐานข้อมูล
    '    Select Case me_DBType
    '        Case DatabaseType.Access
    '            Throw New NotImplementedException
    '        Case DatabaseType.Sybase
    '            'strCon = sycon
    '            Throw New NotImplementedException
    '        Case DatabaseType.SQLServer
    '            strCon = sqlcon
    '            _CCn = New SqlConnection(sqlcon)
    '            _da = New SqlDataAdapter("", _CCn)
    '    End Select
    'End Sub
    Public Sub New(ByVal x_DbType As DatabaseType, Optional xConnectionString$ = "")  'constructure
        me_DBType = x_DbType   'เลือกชนิด  ฐานข้อมูล
        Select Case me_DBType
            Case DatabaseType.Access
                Throw New NotImplementedException
            Case DatabaseType.Sybase
                'strCon = sycon
                Throw New NotImplementedException
            Case DatabaseType.SQLServer
                ' ''strCon = sqlcon
                ' ''_CCn = New SqlConnection(sqlcon)
                ' ''_da = New SqlDataAdapter("", _CCn)

                If xConnectionString = "" Then
                    strCon = sqlcon
                    _CCn = New SqlConnection(sqlcon)
                Else
                    strCon = xConnectionString
                    _CCn = New SqlConnection(xConnectionString)
                End If
                _da = New SqlDataAdapter("", _CCn)

        End Select
    End Sub
#End Region

    Public Function CreateParameter(ByVal xName$, ByVal xType As DbType, Optional ByVal xValue As Object = Nothing) As System.Data.Common.DbParameter
        Dim cmd As New SqlCommand
        Dim result As System.Data.Common.DbParameter
        result = cmd.CreateParameter()
        result.ParameterName = xName
        result.DbType = xType
        result.Value = xValue
        cmd.Dispose()
        cmd = Nothing
        Return result
    End Function

    ''dt = da.GetDataTable(sql, "table1", startRowIndex, maximumRows)
    Public Function GetDataTable(ByVal strsql As String, Optional ByVal tbName As String = "table1", Optional ByVal xStartRecord% = 0, Optional ByVal xPageSize% = 0, Optional ByVal xParameter() As DbParameter = Nothing, Optional ByVal xGenerateAutoID As Boolean = False) As DataTable

        If strsql <> "" AndAlso IsForTest Then 'ForTest
            If strsql.IndexOf("select ") >= 0 Then
                If strsql.IndexOf(" DISTINCT ") >= 0 Then
                    strsql = strsql.Replace(" DISTINCT ", " select DISTINCT TOP(100) ")
                ElseIf strsql.IndexOf(" distinct ") >= 0 Then
                    strsql = strsql.Replace(" distinct ", " select distinct TOP(100) ")
                Else
                    strsql = strsql.Replace("select ", " select TOP(100) ")
                End If
            End If
            If strsql.IndexOf("SELECT ") >= 0 Then
                If strsql.IndexOf(" DISTINCT ") >= 0 Then
                    strsql = strsql.Replace(" DISTINCT ", " SELECT DISTINCT TOP(100) ")
                ElseIf strsql.IndexOf(" distinct ") >= 0 Then
                    strsql = strsql.Replace(" distinct ", " SELECT distinct TOP(100) ")
                Else
                    strsql = strsql.Replace("SELECT ", " SELECT TOP(100) ")
                End If
            End If
        End If

        Dim DT As New DataTable(tbName)
        If xGenerateAutoID Then
            DT.Columns.Add(New DataColumn("P_ID", GetType(Long)))
            DT.Columns(0).AutoIncrement = True
            DT.Columns(0).AutoIncrementStep = 1
            DT.Columns(0).AutoIncrementSeed = 1
        End If
      

        Select Case Me.me_DBType
            Case DatabaseType.Access
                Throw New NotImplementedException
            Case DatabaseType.SQLServer
                _da.SelectCommand.CommandText = strsql
                If xParameter IsNot Nothing Then
                    For Each p As System.Data.Common.DbParameter In xParameter
                        If Not Da.SelectCommand.Parameters.Contains(p) Then
                            Da.SelectCommand.Parameters.Add(p)
                        End If
                    Next
                End If
                Try
                    _ErrorMessage = ""
                    If xStartRecord <> 0 OrElse xPageSize <> 0 Then
                        _da.Fill(xStartRecord, xPageSize, DT)
                    Else
                        _da.Fill(DT)
                    End If

                Catch ex As Exception
                    _ErrorMessage = ex.Message
                    Return Nothing
                Finally
                End Try
        End Select
        Return DT
    End Function

    Public Function Executescalar(ByVal xCommandText$) As String
        Dim obj As Object = Nothing
        Dim state = _CCn.State
        Try
            If _CCn.State = ConnectionState.Closed Then _CCn.Open()
            _da.SelectCommand.CommandText = xCommandText
            obj = _da.SelectCommand.ExecuteScalar()
        Catch ex As Exception
            obj = ""
        Finally
            If state = ConnectionState.Closed Then _CCn.Close()
        End Try
        Return obj & ""
    End Function

    '********** Get DataSet ******************************]
    Public Sub GetDataset(ByVal dataDS As DataSet, ByVal strsql As String, Optional ByVal tbName As String = "table1")

        If strsql <> "" AndAlso IsForTest Then 'ForTest
            If strsql.IndexOf("select ") >= 0 Then
                If strsql.IndexOf(" DISTINCT ") >= 0 Then
                    strsql = strsql.Replace(" DISTINCT ", " DISTINCT TOP(100) ")
                ElseIf strsql.IndexOf(" distinct ") >= 0 Then
                    strsql = strsql.Replace(" distinct ", " distinct TOP(100) ")
                Else
                    strsql = strsql.Replace("select ", " select TOP(100) ")
                End If
            End If
            If strsql.IndexOf("SELECT ") >= 0 Then
                If strsql.IndexOf(" DISTINCT ") >= 0 Then
                    strsql = strsql.Replace(" DISTINCT ", " DISTINCT TOP(100) ")
                ElseIf strsql.IndexOf(" distinct ") >= 0 Then
                    strsql = strsql.Replace(" distinct ", " distinct TOP(100) ")
                Else
                    strsql = strsql.Replace("SELECT ", " SELECT TOP(100) ")
                End If
            End If
        End If

        'ห้ามสั่ง clear ข้างใน เพราะมีการใช้ getdataset ต่อข้อมูลกันอยู่ ใน webperson
        Try
            If Not dataDS.Tables.Contains(tbName) Then
                Dim dt As New DataTable
                dt.TableName = tbName
                dt.Columns.Add(New DataColumn("P_ID", GetType(Long)))
                dt.Columns(0).AutoIncrement = True
                dt.Columns(0).AutoIncrementStep = 1
                dt.Columns(0).AutoIncrementSeed = 1
                dataDS.Tables.Add(dt)
            End If
        Catch ex As Exception
        End Try
        Select Case me_DBType
            Case DatabaseType.SQLServer 'Connec SQL Server
                If _CCn.State = ConnectionState.Closed Then _CCn.Open()
                _da.SelectCommand.CommandText = strsql

                If _da.SelectCommand.CommandTimeout <= 60 Then
                    _da.SelectCommand.CommandTimeout = 180
                End If

                _da.Fill(dataDS, tbName)
                _CCn.Close()

                '_CCn = New SqlConnection(sqlcon)
                'If _CCn.State = ConnectionState.Closed Then _CCn.Open()
                '_da = New SqlDataAdapter(strsql, _CCn)
                ''If _GetID = True Then
                ''    Da.SelectCommand.Transaction = _CCn.BeginTransaction(IsolationLevel.ReadUncommitted)
                ''End If
                'If SqlParam.Count > 0 Then
                '    For Each p As String In SqlParam.Keys
                '        Da.SelectCommand.Parameters.Add(SqlParam(p))
                '    Next
                'End If
                'Try
                '    Da.Fill(dataDS, tbName)
                'Catch ex As Exception
                '    Throw ex
                'Finally
                '    Da.SelectCommand.Parameters.Clear()
                '    _CCn.Close()
                'End Try

            Case DatabaseType.Access ' Connec Sybase
                Throw New NotImplementedException
        End Select
    End Sub

    Public Function UpdateNoTry(ByVal ds As DataSet, Optional ByVal tbName As String = "table1") As Boolean
        Select Case adoconn
            Case 1 'Connec SQL Server
                If _CCn.State = ConnectionState.Closed Then _CCn.Open()
                Dim cbd As New SqlCommandBuilder(Da)
                _da.Update(ds, tbName)
                ds.AcceptChanges()
                _CCn.Close()
            Case 2 'Connec Sybase
                Throw New NotImplementedException

        End Select
    End Function

    Public Sub sqlParameter_Value(ByVal xname As String, ByVal xtype2 As String, ByVal Fvalue As Object)
        Dim p1 As SqlParameter
        Dim p3 As OleDbParameter
        Select Case adoconn
            Case 1  'Connec Sql Server
                If SqlParam.ContainsKey(xname) = False Then
                    p1 = New SqlParameter
                    p1.ParameterName = xname
                    Select Case UCase(xtype2)
                        Case "D"
                            p1.SqlDbType = SqlDbType.DateTime
                        Case "C"
                            p1.SqlDbType = SqlDbType.VarChar
                        Case "I"
                            p1.SqlDbType = SqlDbType.Int
                        Case "NV"
                            p1.SqlDbType = SqlDbType.NVarChar
                        Case "NM"
                            p1.SqlDbType = SqlDbType.Decimal
                        Case "NT"
                            p1.SqlDbType = SqlDbType.NText
                        Case "B"
                            p1.SqlDbType = SqlDbType.Bit
                        Case "T"
                            p1.SqlDbType = SqlDbType.Text
                        Case "IM"
                            p1.SqlDbType = SqlDbType.Image
                        Case "V"
                            p1.SqlDbType = SqlDbType.VarChar
                        Case "DO"
                            p1.SqlDbType = SqlDbType.Float
                        Case "F"
                            p1.SqlDbType = SqlDbType.Float
                    End Select
                    SqlParam.Add(xname, p1)
                End If
                SqlParam(xname).Value = Fvalue
            Case 3 'oledb

        End Select
    End Sub

End Class

