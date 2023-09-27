Imports System.Data.SqlClient    'for sql server
Imports System.Data.OleDb        'for asscess 
'Imports iAnywhere.Data.AsaClient 'for sybase
Imports System.Data
Imports System.Data.Common
Public Class Mydata
  
    '1.Connec Database+'+'+'+'+'+'+'+'+'+'+'+'+'
    Public adoConn As Byte = 1  ' select Data base   1 sql  2 sy
    '2.+++++++++++++++++++++++++++++++++++++++++
    'Public sqlcon As String                   'For  sql
    Public sycon As String                    'For  sybase    

    'For sql server   
    Dim da As SqlDataAdapter = New SqlDataAdapter
    '+++++++ Transaction
    Dim CCn As SqlConnection '= New SqlConnection(sqlcon)
    Dim Cmdbuilder As SqlCommandBuilder
    Dim CTR As SqlTransaction
    '+++++++ Transaction

    'For sybases
    'Dim dasy As AsaDataAdapter = New AsaDataAdapter
    'Dim CCnsy As AsaConnection = New AsaConnection(sycon)
    'Dim Cmdbuildersy As AsaCommandBuilder
    'Dim CTRsy As AsaTransaction

    Dim dv_Navigation As DataView   'ใช้กับการค้นหา
    Public Tmpsqlcon As String = ""


    'Public Sub New(ByVal xType As Byte, Optional ByVal strcon As String = "", Optional ByVal StrCon_String As String = "")
    '    Select Case xType
    '        Case 1 'Connec SQL Server
    '            Tmpsqlcon = sqlcon

    '            'If strcon <> "" Then
    '            '    Tmpsqlcon = "server=" & TSVName & ";database=" & strcon & ";uid=" & TUID & ";pwd=" & TPW & ";connect timeout = 5000"
    '            '    '  CCn = New SqlConnection(sqlcon)
    '            'End If

    '            'If StrCon_String <> "" Then   'กรณีที่ติดต่อ ฐาน อืนๆๆเลย 
    '            '    Tmpsqlcon = StrCon_String
    '            'End If
    '        Case 2 ' Connec Sybase
    '            If strcon <> "" Then
    '                sycon = strcon
    '                ' CCnsy = New AsaConnection(sycon)
    '            End If
    '    End Select
    'End Sub
    'Public Function BeginTransactionUpdate(ByVal ds As DataSet, Optional ByVal tbName As String = "table1") As Boolean
    '    Select Case adoConn
    '        Case 1  'Connec Sql Server
    '            CCn = New SqlConnection(Tmpsqlcon)
    '            If CCn.State = ConnectionState.Closed Then CCn.Open()
    '            Cmdbuilder = New SqlCommandBuilder(da)
    '            CTR = CCn.BeginTransaction(IsolationLevel.ReadCommitted)
    '            da.SelectCommand.Transaction = CTR
    '            Try
    '                da.Update(ds, tbName)
    '                BeginTransactionUpdate = False
    '            Catch ex As Exception
    '                'แสดงข้อความ Error
    '                MessageBox.Show(ex.Message & " " & ex.Message.GetHashCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                BeginTransactionUpdate = True
    '            End Try
    '        Case 2 ' Connec Sybase
    '            CCnsy = New AsaConnection(sycon)
    '            If CCnsy.State = ConnectionState.Closed Then CCnsy.Open()
    '            Cmdbuildersy = New AsaCommandBuilder(dasy)
    '            CTRsy = CCnsy.BeginTransaction(IsolationLevel.ReadCommitted)
    '            dasy.SelectCommand.Transaction = CTRsy
    '            Try
    '                dasy.Update(ds, tbName)
    '                BeginTransactionUpdate = False
    '            Catch ex As Exception
    '                'แสดงข้อความ Error
    '                MessageBox.Show(ex.Message & " " & ex.Message.GetHashCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                BeginTransactionUpdate = True
    '            End Try
    '    End Select
    'End Function

    Public Function BeginTransactionUpdate(ByVal ds As DataSet, Optional ByVal tbName As String = "table1") As Boolean
        Select Case adoConn
            Case 1  'Connec Sql Server
                If CCn.State = ConnectionState.Closed Then CCn.Open()
                CTR = CCn.BeginTransaction(IsolationLevel.ReadCommitted)
                da.SelectCommand.Transaction = CTR
                Cmdbuilder = New SqlCommandBuilder(da)
                Try
                    da.Update(ds, tbName)
                    BeginTransactionUpdate = False
                Catch ex As Exception
                    'แสดงข้อความ Error
                    ' MessageBox.Show(ex.Message & " " & ex.Message.GetHashCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BeginTransactionUpdate = True
                End Try
            Case 2 ' Connec Sybase
                'If CCnsy.State = ConnectionState.Closed Then CCnsy.Open()
                'Cmdbuildersy = New AsaCommandBuilder(dasy)
                'CTRsy = CCnsy.BeginTransaction(IsolationLevel.ReadCommitted)
                'dasy.SelectCommand.Transaction = CTRsy
                'Try
                '    dasy.Update(ds, tbName)
                '    BeginTransactionUpdate = False
                'Catch ex As Exception
                '    'แสดงข้อความ Error
                '    MessageBox.Show(ex.Message & " " & ex.Message.GetHashCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    BeginTransactionUpdate = True
                'End Try
        End Select
    End Function


    Public Function TransactionCommit() As Boolean
        Select Case adoConn
            Case 1  'Connec Sql Server
                Try
                    CTR.Commit()
                    CCn.Close()
                    TransactionCommit = False
                Catch ex As Exception
                    TransactionCommit = True
                End Try
            Case 2 ' Connec Sybase
                'Try
                '    CTRsy.Commit()
                '    CCnsy.Close()
                '    TransactionCommit = False
                'Catch ex As Exception
                '    TransactionCommit = True
                'End Try
        End Select
    End Function

    Public Function TransactionRollback() As Boolean
        Select Case adoConn
            Case 1  'Connec Sql Server
                Try
                    CTR.Rollback()
                    CCn.Close()
                    TransactionRollback = False
                Catch ex As Exception
                    TransactionRollback = True
                End Try
            Case 2 ' Connec Sybase
                'Try
                '    CTRsy.Rollback()
                '    CCnsy.Close()
                '    TransactionRollback = False
                'Catch ex As Exception
                '    TransactionRollback = True
                'End Try
        End Select
    End Function


    Public Function GetDataset(ByVal dataDS As DataSet, ByVal strsql As String, Optional ByVal tbName As String = "table1", Optional ByVal _GetID As Boolean = False) As DataSet
        '  _GetID = ใช้สำหรับ หา Auto ID คือ การ หาค่า ที่อยู่ใน  Transaction ด้วย  true คือหา  false ไม่หา
        Try
            Dim dt As New DataTable
            dt.TableName = tbName
            dt.Columns.Add(New DataColumn("P_ID", GetType(Long)))
            dt.Columns(0).AutoIncrement = True
            dt.Columns(0).AutoIncrementStep = 1
            dt.Columns(0).AutoIncrementSeed = 1
            dataDS.Tables.Add(dt)
        Catch ex As Exception
        End Try

        'Debug.WriteLine(strsql)
        Select Case adoConn
            Case 1 'Connec SQL Server
                '' sqlcon = "server=" & TSVName & ";database=" & TDBName & ";uid=" & TUID & ";pwd=" & TPW & ";connect timeout = 0"
                'Dim strcon As New SqlConnectionStringBuilder
                'strcon.DataSource = TSVName
                'strcon.UserID = TUID
                'strcon.Password = TPW
                'strcon.InitialCatalog = TDBName
                'strcon.IntegratedSecurity = False
                'strcon.ConnectTimeout = 0
                'CCn = New SqlConnection(strcon.ConnectionString)
                Try

                    If CCn Is Nothing Then  ' แก้ไขการเปิด Connection ค้าง
                        CCn = New SqlConnection(Tmpsqlcon)
                    End If

                    If CCn.State = ConnectionState.Closed Then CCn.Open()
                    da = New SqlDataAdapter(strsql, CCn)

                    If _GetID = True Then
                        da.SelectCommand.Transaction = CCn.BeginTransaction(IsolationLevel.ReadUncommitted)
                    End If

                    da.Fill(dataDS, tbName)

                Catch ex As Exception
                    If ex.Message.ToLower.Contains("paused") Then
                        Throw (New Exception("ติดต่อ Server ไม่ได้ กรุณาตรวจสอบ การเชื่อมต่อ ฐานข้อมูลอีกครั้ง [Paused]"))
                    ElseIf ex.Message.ToLower.Contains("transport-level error") Then
                        Throw (New Exception("ติดต่อ Server ไม่ได้ กรุณาตรวจสอบ การเชื่อมต่อ ฐานข้อมูลอีกครั้ง [Transport-level error]"))
                    Else
                        Throw (ex)
                    End If
                Finally
                    CCn.Close()
                End Try

                Return dataDS

            Case 2 ' Connec Sybase
                'CCnsy = New AsaConnection(sycon)
                'If CCnsy.State = ConnectionState.Closed Then CCnsy.Open()
                'dasy = New AsaDataAdapter(strsql, CCnsy)
                'If _GetID = True Then
                '    dasy.SelectCommand.Transaction = CCnsy.BeginTransaction(IsolationLevel.ReadUncommitted)
                'End If
                'Try
                '    dasy.Fill(dataDS, tbName)
                'Catch ex As Exception
                '    Throw ex
                'Finally
                '    CCnsy.Close()
                'End Try
                'Return dataDS
        End Select
    End Function



    Public Function Update(ByVal ds As DataSet, Optional ByVal tbName As String = "table1") As Boolean
        Select Case adoConn
            Case 1 'Connec SQL Server
                CCn = New SqlConnection(Tmpsqlcon)
                If CCn.State = ConnectionState.Closed Then CCn.Open()
                Dim cbd As New SqlCommandBuilder(da)
                Try
                    da.Update(ds, tbName)
                    ds.Tables(tbName).AcceptChanges()
                    Update = False
                Catch ex As Exception
                    Update = True
                Finally
                    CCn.Close()
                End Try
            Case 2 ' Connec Sybase
                'CCnsy = New AsaConnection(sycon)
                'If CCnsy.State = ConnectionState.Closed Then CCnsy.Open()
                'Dim cbd As New AsaCommandBuilder(dasy)
                'Try
                '    dasy.Update(ds, tbName)
                '    ds.Tables(tbName).AcceptChanges()
                '    Update = False
                'Catch ex As Exception
                '    Update = True
                'Finally
                '    CCnsy.Close()
                'End Try
        End Select
    End Function

    Public Function UpdateNoTry(ByVal ds As DataSet, Optional ByVal tbName As String = "table1") As Boolean
        Select Case adoConn
            Case 1 'Connec SQL Server
                CCn = New SqlConnection(Tmpsqlcon)
                If CCn.State = ConnectionState.Closed Then CCn.Open()
                Dim cbd As New SqlCommandBuilder(da)
                da.Update(ds, tbName)
                ds.AcceptChanges()
                CCn.Close()
            Case 2 'Connec Sybase
                'CCnsy = New AsaConnection(sycon)
                'If CCnsy.State = ConnectionState.Closed Then CCnsy.Open()
                'Dim cbd As New AsaCommandBuilder(dasy)
                'dasy.Update(ds, tbName)
                'ds.AcceptChanges()
                'CCnsy.Close()
        End Select
    End Function
    Public Function GetDataTable(ByVal strsql As String, Optional ByVal tbName As String = "table1", Optional ByVal xStartRecord% = 0, Optional ByVal xPageSize% = 0, Optional ByVal xParameter() As DbParameter = Nothing) As DataTable
        Dim DT As New DataTable(tbName)
        da.SelectCommand.CommandText = strsql
        'If xParameter IsNot Nothing Then
        '    For Each p As System.Data.Common.DbParameter In xParameter
        '        If Not Da.SelectCommand.Parameters.Contains(p) Then
        '            Da.SelectCommand.Parameters.Add(p)
        '        End If
        '    Next
        'End If
        Try
            '  _ErrorMessage = ""
            If xStartRecord <> 0 OrElse xPageSize <> 0 Then
                da.Fill(xStartRecord, xPageSize, DT)
            Else
                da.Fill(DT)
            End If
        Catch ex As Exception
            '    _ErrorMessage = ex.Message
            Return Nothing
        Finally
        End Try

        Return DT
    End Function

   


End Class



