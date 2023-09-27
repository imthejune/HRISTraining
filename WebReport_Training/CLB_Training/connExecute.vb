Option Compare Text

Imports System.Data.SqlClient    'for sql server
Imports System.Data.OleDb        'for asscess 
Imports System.Data
Imports System.Data.Common

Public Enum DatabaseType
    Access = 0
    SQLServer = 1
    Sybase = 2
    ODBC = 3
End Enum
Public Class connExecute
    Implements IDisposable

    'Dim strCon As String
    Public sqlStr As String
    Private me_DBType As DatabaseType = DatabaseType.SQLServer
    Private m_ErrorMessage As String

    Private cnOle As OleDbConnection
    Dim TROle As OleDbTransaction
    Private cmdOle As OleDbCommand         'For Access

    Private cmdsql As SqlCommand         'For sql
    Private cnsql As SqlConnection
    Dim TRsql As SqlTransaction


#Region " IDisposable Finalize "
    Private disposedValue As Boolean = False        ' To detect redundant calls
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If Not cmdsql Is Nothing Then
                    cmdsql.Dispose()
                End If
                If Not cnsql Is Nothing Then
                    cnsql.Dispose()
                End If
                If TRsql IsNot Nothing Then
                    TRsql.Dispose()
                End If
                cmdsql = Nothing
                cnsql = Nothing
                TRsql = Nothing
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
        Dispose(False) 'ต้อง false เท่านั้น แด๋วจะ error
        MyBase.Finalize()
    End Sub
#End Region

#Region " Sub New "
    'constructure ประโชน์คือไว้กำหนดค่าเริ่มต้นให้กับโปรแกรม
    Public Sub New(sqlcon As String)
        'me_DBType = x_DbType   'เลือกชนิด  ฐานข้อมูล
        'Select Case me_DBType
        '    Case DatabaseType.Access
        '        Throw New NotImplementedException
        '    Case DatabaseType.Sybase
        '        Throw New NotImplementedException
        '    Case DatabaseType.SQLServer
        cnsql = New SqlConnection(sqlcon)
        ' End Select
    End Sub
#End Region

    Public ReadOnly Property Connection() As IDbConnection
        Get
            Dim result As IDbConnection = Nothing
            Select Case me_DBType
                Case DatabaseType.SQLServer   'Connec Sql Server
                    result = cnsql
                Case DatabaseType.Access  'Connec Access
                    result = cnOle
            End Select
            Return result
        End Get
    End Property

    Public ReadOnly Property Parameters() As DbParameterCollection
        Get
            Select Case me_DBType
                Case DatabaseType.SQLServer   'Connec Sql Server
                    Return cmdsql.Parameters
                Case DatabaseType.Access  'Connec Access
                    Return cmdOle.Parameters
                Case Else
                    Throw New NotImplementedException
            End Select
        End Get
    End Property

    Public ReadOnly Property ErrorMessage() As String
        Get
            Return m_ErrorMessage
        End Get
    End Property

    Public Sub parameter(ByVal Fpara As String, ByVal Fvalue As Object)
        Select Case me_DBType
            Case DatabaseType.SQLServer   'Connec Sql Server
                cmdsql.Parameters(Fpara).Value = Fvalue
            Case DatabaseType.Access  'Connec Access
                cmdOle.Parameters(Fpara).Value = Fvalue
        End Select
    End Sub

    Public Sub sqlParameter_Value(ByVal xname As String, ByVal xtype2 As String, ByVal Fvalue As Object)
        ''ตัวอย่างการใช้ พารามิเตอร์
        '        'Dim command As New SqlCommand("INSERT INTO Datapic(nameP,typeP,DataP) Values (@nameP,@typeP,@dataP)", Conn)
        '        'Dim param0 As New SqlParameter("@nameP", SqlDbType.VarChar, 100)
        '        'param0.Value = name
        '        'command.Parameters.Add(param0)
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql Server
                If cmdsql.Parameters.Contains(xname) = False Then
                    Dim p1 As New SqlParameter
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
                            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        Case "DO"
                            p1.SqlDbType = SqlDbType.Float
                        Case "F"
                            p1.SqlDbType = SqlDbType.Float
                    End Select
                    cmdsql.Parameters.Add(p1)
                End If
                cmdsql.Parameters(xname).Value = Fvalue
            Case DatabaseType.Access  'Connec Sql Server
                If cmdOle.Parameters.Contains(xname) = False Then
                    Dim p3 As New OleDbParameter
                    p3.ParameterName = xname
                    Select Case UCase(xtype2)
                        Case "D"
                            p3.OleDbType = OleDbType.Date
                        Case "C"
                            p3.OleDbType = OleDbType.Char
                        Case "I"
                            p3.OleDbType = OleDbType.Integer
                        Case "NV"
                            p3.OleDbType = OleDbType.VarChar
                        Case "NM"
                            p3.OleDbType = OleDbType.Numeric
                        Case "NT"
                            p3.OleDbType = SqlDbType.NText
                        Case "B"
                            p3.OleDbType = OleDbType.Boolean
                        Case "T"
                            p3.OleDbType = OleDbType.LongVarChar
                        Case "V"
                            p3.OleDbType = OleDbType.VarChar
                    End Select
                    cmdOle.Parameters.Add(p3)
                End If
                cmdOle.Parameters(xname).Value = Fvalue
        End Select
    End Sub

    Public Sub cmdConnection()
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql Server
                sqlStrFormat()  'sqlclient ต้องใช้ @p1,@p2 แทน ? ดังนั้นต้องแปลงก่อน
                cmdsql = New SqlCommand(sqlStr, cnsql)
                If cnsql.State = ConnectionState.Closed Then cnsql.Open()
                'Case DatabaseType.Sybase  'Connec Sybase
                '    cmdsy = New AsaCommand(sqlStr, cnsy)
                '    If cnsy.State = ConnectionState.Closed Then cnsy.Open()
            Case DatabaseType.Access  'Connec Access
                cmdOle = New OleDbCommand(sqlStr, cnOle)
                If cnOle.State = ConnectionState.Closed Then cnOle.Open()
        End Select
    End Sub

    ''' <summary>
    ''' เปลี่ยน sql
    ''' </summary>
    ''' <param name="xSql"></param>
    ''' <remarks>
    ''' cExecute.sqlStr="update ADM_UserPws setPws=?"
    ''' cExecute.CommandText()
    ''' หรือ cExecute.CommandText("xxxxxx")
    ''' </remarks>
    Public Sub CommandText(Optional ByVal xSql$ = "")
        If xSql.Trim <> "" Then
            sqlStr = xSql
        End If
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql Server
                sqlStrFormat()
                If cnsql.State = ConnectionState.Closed Then cnsql.Open()
                If cmdsql Is Nothing Then
                    cmdsql = cnsql.CreateCommand
                End If
                cmdsql.CommandText = sqlStr
                'Case DatabaseType.Sybase   'Connec Sybase
            Case DatabaseType.Access  'Connec Sql Server
                If cnOle.State = ConnectionState.Closed Then cnOle.Open()
                If cmdOle Is Nothing Then
                    cmdOle = cnOle.CreateCommand
                End If
                cmdOle.CommandText = sqlStr
        End Select
    End Sub
    Public Sub BeginTransaction()
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql Server
                If cnsql.State = ConnectionState.Closed Then cnsql.Open()
                ' TRsql = cnsql.BeginTransaction(IsolationLevel.Serializable)
                ' TRsql = cnsql.BeginTransaction(IsolationLevel.ReadUncommitted)
                TRsql = cnsql.BeginTransaction(IsolationLevel.ReadCommitted)
                'Case DatabaseType.Sybase  'Connec Sybase
                '    If cnsy.State = ConnectionState.Closed Then cnsy.Open()
                '    TRSy = cnsy.BeginTransaction(IsolationLevel.Serializable)
            Case DatabaseType.Access  'Connec Access
                If cnOle.State = ConnectionState.Closed Then cnOle.Open()
                ' TROle = cnOle.BeginTransaction(IsolationLevel.Serializable)
                TROle = cnOle.BeginTransaction(IsolationLevel.Serializable)
        End Select
    End Sub



    Public Function Transaction() As IDbTransaction
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql Server
                cmdsql.Transaction = TRsql
                Return TRsql
            Case DatabaseType.Access  'Connec Access
                cmdOle.Transaction = TROle
                Return TROle
            Case Else
                Throw New NotImplementedException
        End Select
    End Function

    Public Sub Close()
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql
                cnsql.Close()
            Case DatabaseType.Access  'Connec Access
                cnOle.Close()
        End Select
    End Sub

    Public Sub Commit()
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql
                TRsql.Commit()
                cnsql.Close()
                'Case DatabaseType.Sybase  'Connec Sybase
                '    TRSy.Commit()
                '    cnsy.Close()
            Case DatabaseType.Access  'Connec Access
                TROle.Commit()
                cnOle.Close()
        End Select
    End Sub

    Public Sub Rollback()
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql
                TRsql.Rollback()
                cnsql.Close()
            Case DatabaseType.Access  'Connec Sql
                TROle.Rollback()
                cnOle.Close()
        End Select
    End Sub

    Private Function sqlStrFormat(Optional ByVal xSql$ = "") As String
        Dim i As Integer
        Dim xF As Integer = 1
        Dim st1 As String = ""
        If xSql <> "" Then
            sqlStr = xSql
        End If
        Do
            i = InStr(sqlStr, "?")
            If i > 0 Then
                st1 = st1 & Mid(sqlStr, 1, i - 1) & "@p" & xF
                sqlStr = Mid(sqlStr, i + 1, Len(sqlStr))
            Else
                sqlStr = st1 & sqlStr
                Exit Do
            End If
            xF = xF + 1
        Loop
        Return sqlStr
    End Function

    Public Sub ExecuteNonQuery(Optional ByVal xSql$ = "")
       'Connec Sql Server
                If cmdsql Is Nothing Then
                    cmdsql = New SqlCommand("", cnsql)
                End If
                If xSql <> "" Then
                    cmdsql.CommandText = xSql
                End If
                If cnsql.State = ConnectionState.Closed Then cnsql.Open()
                cmdsql.ExecuteNonQuery()
        

    End Sub

    Public Function ExecuteScalar(Optional ByVal xCommandText As String = "", Optional ByVal xParameter() As DbParameter = Nothing) As String
        Dim obj As Object = Nothing
        Select Case me_DBType
            Case DatabaseType.SQLServer 'Connec Sql Server
                Dim state = cnsql.State 'เก็บค่าเก่าไว้
                If cmdsql Is Nothing Then
                    cmdsql = New SqlCommand("", cnsql)
                End If
                If xCommandText <> "" Then
                    cmdsql.CommandText = xCommandText
                End If
                If xParameter IsNot Nothing Then
                    For Each p As System.Data.Common.DbParameter In xParameter
                        If Not cmdsql.Parameters.Contains(p.ParameterName) Then
                            cmdsql.Parameters.Add(p)
                        End If
                    Next
                End If
                If cnsql.State = ConnectionState.Closed Then cnsql.Open()
                obj = cmdsql.ExecuteScalar()
                If state = ConnectionState.Closed Then cnsql.Close()

            Case DatabaseType.Access  'Connec Access
                Throw New NotImplementedException
            Case DatabaseType.Sybase
                Throw New NotImplementedException

        End Select
        Return obj & ""
    End Function


    ''' <summary>
    ''' เหมือนใน mydatat
    ''' </summary>
    ''' <param name="xSql"></param>
    ''' <param name="xParameter"></param>
    ''' <param name="xBehavior"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' Dim pPersonID = da.CreateParameter("Personid", DbType.Decimal)
    ''' Dim pWorkDay = da.CreateParameter("WorkDay", DbType.DateTime, workday)
    ''' Dim param() As System.Data.Common.DbParameter = New System.Data.Common.DbParameter() { _
    ''' pPersonID, pWorkDay}
    ''' Dim dtCal = da.GetDataTable(Sql, xParameter:=param)
    ''' กรณีจะเปลี่ยน parameter-----------
    ''' pPersonID.Value = dr("PersonID")
    ''' </remarks>
    Public Function GetDataTable(Optional ByVal xSql$ = "", Optional ByVal xParameter() As DbParameter = Nothing, Optional ByVal xBehavior As CommandBehavior = CommandBehavior.Default) As DataTable
        Dim result As New DataTable
        Select Case me_DBType
            Case DatabaseType.SQLServer 'Connec Sql Server
                Using drd = Me.ExecuteReader(xSql, xParameter, xBehavior)
                    result.Load(drd)
                End Using
                If cnsql.State = ConnectionState.Open Then cnsql.Close()
            Case DatabaseType.Sybase
                Throw New NotImplementedException
            Case DatabaseType.Access 'Connec Sql Server
                Throw New NotImplementedException
        End Select
        Return result
    End Function


    'sql = "select personid,sum(OTH1) as sumoth1 ,sum(OTH2) as sumoth2 ,sum(OTH3) as sumoth3 ,sum(OTH4) as sumoth4 ,sum(OTH5) as sumoth5 ,sum(OTH6) as sumoth6 from tam_timeday " _
    '                     & " where PersonID in (" & xPersonList & ") " _
    '                     & " and WorkDay between @p1 and @p2 " _
    '                     & " group by PersonID "
    '            monDate.Value = monDay
    '            sunDate.Value = monDay.AddDays(6)
    'Dim param() As System.Data.Common.DbParameter = New System.Data.Common.DbParameter() { _
    '     monDate, sunDate}
    '            Using dr = exe.ExecuteReader(sql, param)
    'Dim sum% = 0
    '                Do While dr.Read
    '                    sum = dr("sumoth1") + dr("sumoth2") + dr("sumoth3") + dr("sumoth4") + dr("sumoth5") + dr("sumoth6")
    '                    sumotDic.Add(dr("personid") & monDay.ToString("YYMMDD"), sum)
    '                Loop
    '            End Using
    ''' <summary>
    ''' แบบ Advance เอา Command ไปสร้างเองดีกว่า
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteReader(Optional ByVal xSql$ = "", Optional ByVal xParameter() As DbParameter = Nothing, Optional ByVal xBehavior As CommandBehavior = CommandBehavior.Default) As IDataReader
        Dim result As IDataReader = Nothing
        Select Case me_DBType
            Case DatabaseType.SQLServer 'Connec Sql Server
                If cmdsql Is Nothing Then
                    cmdsql = New SqlCommand("", cnsql)
                End If
                If xSql.Trim <> "" Then
                    cmdsql.CommandText = xSql
                End If
                If xParameter IsNot Nothing Then
                    For Each p As System.Data.Common.DbParameter In xParameter
                        If Not cmdsql.Parameters.Contains(p.ParameterName) Then
                            cmdsql.Parameters.Add(p)
                        End If
                    Next
                End If
                If cnsql.State = ConnectionState.Closed Then cnsql.Open()
                result = cmdsql.ExecuteReader(xBehavior)
            Case DatabaseType.Sybase
                Throw New NotImplementedException

            Case DatabaseType.Access 'Connec Sql Server
                Throw New NotImplementedException
        End Select
        Return result
        'ตัวอย่าง  การใช้  executeReader
        'Dim myreader As Object  'สร้างตัวแปร object มารับ 1 ตัว
        'cExecute = New connExecute
        'cmdsqlStr = cmdsqlStr & " select CusCode from Som_customer"
        'cExecute.sqlStr = cmdsqlStr
        'cExecute.cmdConnection()
        'myreader = cExecute.ExecuteReader
        'Do While myreader.read
        '    MsgBox(myreader.item("cusCode"))
        'Loop
        'myreader.close


        'หรือจะใช้ แบบนี้ก็ได้
        'Using cmd = da_DataLoad.Connection.CreateCommand
        '    cmd.Connection.Open()
        '    For i = i2 To xIdLeave
        '        sqlStr = "SELECT sum(LeaveI" & i & ") as L" & i & ",sum(LeaveD" & i & ") as D" & i & "  FROM TAM_TimeDay Where WorkDay>='" & ConvertDate(T) & "' and  PersonID = " & xPersonID
        '        cmd.CommandText = sqlStr
        '        Using r = cmd.ExecuteReader
        '            r.Read()
        '            'dr1 = ds_DataLoad.Tables("Leave_Process").Rows(0)
        '            drI(i) = drI(i) + Val(r("L" & i) & "")
        '            drD(i) = drD(i) + Val(r("D" & i) & "")
        '        End Using
        '    Next
        '    cmd.Connection.Close()
        'End Using

        'แบบใช้ parameter วนลูป
        'Dim monDate = exe.CreateParameter("p1", DbType.DateTime)
        'Dim sunDate = exe.CreateParameter("p2", DbType.DateTime)
        'For Each monDay In weekList
        '    Sql = "select personid,sum(OTH1) as sumoth1 ,sum(OTH2) as sumoth2 ,sum(OTH3) as sumoth3 ,sum(OTH4) as sumoth4 ,sum(OTH5) as sumoth5 ,sum(OTH6) as sumoth6 from tam_timeday " _
        '             & " where PersonID in (" & xPersonList & ") " _
        '             & " and WorkDay between @p1 and @p2 " _
        '             & " group by PersonID "
        '    monDate.Value = monDay
        '    sunDate.Value = monDay.AddDays(6)
        '    Dim param() As System.Data.Common.DbParameter = New System.Data.Common.DbParameter() { _
        '         monDate, sunDate}
        '    Using dr = exe.ExecuteReader(Sql, param)
        '        Dim sum% = 0
        '        Do While dr.Read
        '            sum = dr("sumoth1") + dr("sumoth2") + dr("sumoth3") + dr("sumoth4") + dr("sumoth5") + dr("sumoth6")
        '            sumotDic.Add(dr("personid") & monDay.ToString("YYMMDD"), sum)
        '        Loop
        '    End Using
        'Next
    End Function

    'Dim param() As System.Data.Common.DbParameter = New System.Data.Common.DbParameter() { _
    'Da.CreateParameter("Personid", DbType.Decimal, 14) _
    ', Da.CreateParameter("WorkDay", DbType.DateTime, New Date(2010, 5, 5))}
    'Dim dt = Da.GetDataTable(sql, xParameter:=param)
    'Public Function CreateParameter(ByVal xName$, ByVal xType As DbType, Optional ByVal xValue As Object = Nothing) As System.Data.Common.DbParameter
    '    'Dim myProvider As DbProviderFactory = MyFactoy.Instance(me_DBType)
    '    'Dim result = MyFactoy.Instance(me_DBType).CreateParameter()
    '    Dim result As System.Data.Common.DbParameter = MyFactoy.Instance(me_DBType).CreateParameter()
    '    result.ParameterName = xName
    '    result.DbType = xType
    '    result.Value = xValue
    '    Return result
    'End Function

    ''' <summary>
    ''' dim cmd=exe.CreateCommand(sqlInsert)
    ''' cmd.parameter.add(exe.CreateParameter(  ))
    ''' </summary>
    ''' <param name="xSql"></param>
    ''' <param name="xCon"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' <code>
    '''Dim sqlInsert = "INSERT INTO TAP_OTNormal_DocNo(DocNo,Cmb2ID,isreprint)VALUES(?,?,0);select scope_identity()"
    '''Dim cmd = exe.CreateCommand(sqlInsert)
    '''cmd.Parameters.Add(exe.CreateParameter("@p1", DbType.String, newDocNo))
    '''cmd.Connection.Open()
    '''DocID = cmd.ExecuteScalar()
    ''' </code>
  

    ''' <summary>
    ''' cExecute.sqlParameter("NV;NM;B;NV;D;D;NV;NV")
    ''' </summary>
    ''' <param name="xtype"></param>
    ''' <remarks></remarks>
    Public Sub sqlParameter(ByVal xtype As String)
        Dim xtype2() As String
        xtype2 = Split(xtype, ";")
        Dim p1 As SqlParameter
        Dim p3 As OleDbParameter
        Dim i As Integer
        Select Case me_DBType
            Case DatabaseType.SQLServer  'Connec Sql Server
                For i = 0 To xtype2.Length - 1
                    Dim xname As String = "@p" & i + 1
                    p1 = New SqlParameter
                    p1.ParameterName = xname
                    Select Case UCase(xtype2(i))
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
                        Case "V"
                            p1.SqlDbType = SqlDbType.VarChar
                        Case "DO"
                            p1.SqlDbType = SqlDbType.Float
                        Case "F"
                            p1.SqlDbType = SqlDbType.Float
                    End Select
                    cmdsql.Parameters.Add(p1)
                Next
                'Case DatabaseType.Sybase  'Connec Sybase
                '    For i = 0 To xtype2.Length - 1
                '        Dim xname As String = "@p" & i + 1
                '        p2 = New AsaParameter
                '        p2.ParameterName = xname
                '        Select Case UCase(xtype2(i))
                '            Case "D"
                '                p2.AsaDbType = AsaDbType.TimeStamp
                '            Case "C"
                '                p2.AsaDbType = AsaDbType.VarChar
                '            Case "I"
                '                p2.AsaDbType = AsaDbType.Integer
                '            Case "NV"
                '                p2.AsaDbType = AsaDbType.VarChar
                '            Case "NM"
                '                p2.AsaDbType = AsaDbType.Integer
                '            Case "NT"
                '                p2.AsaDbType = AsaDbType.Text
                '            Case "T"
                '                p2.AsaDbType = AsaDbType.LongVarchar
                '            Case "B"
                '                p2.AsaDbType = AsaDbType.Bit
                '            Case "IM"
                '                p2.AsaDbType = AsaDbType.Image
                '            Case "V"
                '                p2.AsaDbType = AsaDbType.VarChar
                '        End Select
                '        cmdsy.Parameters.Add(p2)
                '    Next
            Case DatabaseType.Access 'Connec Sql Server
                For i = 0 To xtype2.Length - 1
                    Dim xname As String = "@p" & i + 1
                    p3 = New OleDbParameter
                    p3.ParameterName = xname
                    Select Case UCase(xtype2(i))
                        Case "D"
                            p3.OleDbType = OleDbType.Date
                        Case "C"
                            p3.OleDbType = OleDbType.Char
                        Case "I"
                            p3.OleDbType = OleDbType.Integer
                        Case "NV"
                            p3.OleDbType = OleDbType.VarChar
                        Case "NM"
                            p3.OleDbType = OleDbType.Numeric
                        Case "B"
                            p3.OleDbType = OleDbType.Boolean
                        Case "T"
                            p3.OleDbType = OleDbType.LongVarChar
                        Case "V"
                            p3.OleDbType = SqlDbType.VarChar
                    End Select
                    cmdsql.Parameters.Add(p3)
                Next
        End Select
    End Sub

End Class

 