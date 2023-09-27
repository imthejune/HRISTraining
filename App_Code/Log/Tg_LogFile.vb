Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Module TG_LogFile

    'Dim SQL_LOG As String = "server=Nena;database=CyberHRM_Log;uid=sa;pwd=tiger"


    Function InsertLogMenu(Web_Program As String, Web_Code As String, Type_Menu As String, Create_By As String)
        Dim nameTableLog As String
        Dim cExecute As New connExecute(sqlconLog)

        nameTableLog = "LOG_Menu_" & Now.Year

        '---- ฐานข้อมูล log  ------
        'SQL_LOG = "server=(Local);database=CyberHRM_Log;uid=sa;pwd=tiger"

        CheckTable(nameTableLog, "LOG_Menu")  ' ตรวจสอบฐาน

        ''---------------------------- เก็บลงฐาน
        Try

            cExecute.BeginTransaction()
            cExecute.sqlStr = "Insert into " & nameTableLog & "  ( [Web_Program], [Web_Code], [Type_Menu],[Create_By] ) values(?,?,?,?)"
            cExecute.cmdConnection()
            cExecute.Transaction()
            cExecute.sqlParameter_Value("@p1", "NV", Web_Program)  ' Program
            cExecute.sqlParameter_Value("@p2", "NV", Web_Code)     ' Menu code
            cExecute.sqlParameter_Value("@p3", "NV", Type_Menu)    ' M = หน้าจอ  R= หน้าจอรายงาน  ,I= Import ,E = Export ,P=Print
            cExecute.sqlParameter_Value("@p4", "NV", Sys.LoginWeb.UserID)    ' UserID
            cExecute.ExecuteNonQuery()
            cExecute.Commit()
        Catch ex As Exception
            cExecute.Rollback()
        End Try

    End Function

    Sub CheckTable(nameTableLog As String, ckTableLog As String)
        '------------ ตรวจสอบมี  Table หรือไม่ -------------
        '----------------------------------------------
        '----------  กรณีที่ไม่มี สร้างฐานใหม่ ---------------- 
        Dim cExecute As New connExecute(sqlconLog)
        Dim CkTB$ = cExecute.ExecuteScalar("select Name from  sys.tables Where Name='" & nameTableLog & "'")

        If CkTB = "" Then

            Try
                cExecute.BeginTransaction()
                If ckTableLog = "LOG_File" Then
                    cExecute.sqlStr = " CREATE TABLE  [" & nameTableLog & "]( [ID_Log] [numeric](18, 0) IDENTITY(1,1) NOT NULL,[Web_Program] [nvarchar](10) NULL,[Web_Code] [nvarchar](50) NULL,[PersonCode] [nvarchar](50),[EditType] [nvarchar](1000) NULL,[OldValue] [nvarchar](1000) NULL,[NewValue] [nvarchar](1000) NULL,[OldSalary] [varbinary](200) NULL,[NewSalary] [varbinary](200) NULL,[Create_By] [nvarchar](50) NULL,[CompanyID] [numeric](18, 0) NULL,[Create_Time] [datetime] NULL,[ComName] [nvarchar](200) NULL,	CONSTRAINT [PK_" & nameTableLog & "] PRIMARY KEY CLUSTERED ([ID_Log] ASC )) ON [PRIMARY] "
                ElseIf ckTableLog = "LOG_WebNotify" Then
                    cExecute.sqlStr = " CREATE TABLE  [" & nameTableLog & "]( [ID_Log] [numeric](18, 0) IDENTITY(1,1) NOT NULL,  [Create_Time] [datetime] NULL,  [Create_By] [nvarchar](50) NULL,  [Web_Program] [nvarchar](10) NULL, 	[Web_Code] [nvarchar](50) NULL,  [Type_Menu] [nvarchar](1) NULL ,[PersonID] [numeric](18, 0) NULL, [DataID] [varchar](50) NULL ,  CONSTRAINT [PK_" & nameTableLog & "] PRIMARY KEY CLUSTERED  ( [ID_Log] ASC )  ) ON [PRIMARY] "
                Else
                    cExecute.sqlStr = " CREATE TABLE  [" & nameTableLog & "]( [ID_Log] [numeric](18, 0) IDENTITY(1,1) NOT NULL,  [Create_Time] [datetime] NULL,  [Create_By] [nvarchar](50) NULL,  [Web_Program] [nvarchar](10) NULL, 	[Web_Code] [nvarchar](50) NULL,  [Type_Menu] [nvarchar](1) NULL ,   CONSTRAINT [PK_" & nameTableLog & "] PRIMARY KEY CLUSTERED  ( [ID_Log] ASC )  ) ON [PRIMARY] "
                End If
                cExecute.cmdConnection()
                cExecute.Transaction()
                cExecute.ExecuteNonQuery()
                cExecute.Commit()
            Catch ex As Exception
                cExecute.Rollback()
            End Try

            Try
                cExecute.BeginTransaction()
                cExecute.sqlStr = "  ALTER TABLE [" & nameTableLog & "] ADD  CONSTRAINT [DF_" & nameTableLog & "_Create_Time]  DEFAULT (getdate()) FOR [Create_Time]"
                cExecute.cmdConnection()
                cExecute.Transaction()
                cExecute.ExecuteNonQuery()
                cExecute.Commit()
            Catch ex As Exception
                cExecute.Rollback()
            End Try

        End If

    End Sub

    Function InsertLogNotify(Web_Program As String, Type_Menu As String, Web_Code As String, dtPersonID As DataTable, Create_By As String)
        Dim nameTableLog As String
        Dim cExecute As New connExecute(sqlconLog)

        nameTableLog = "LOG_WebNotify_" & Now.Year

        '---- ฐานข้อมูล log  ------
        'SQL_LOG = "server=(Local);database=CyberHRM_Log;uid=sa;pwd=tiger"

        CheckTable(nameTableLog, "LOG_WebNotify")  ' ตรวจสอบฐาน

        ''---------------------------- เก็บลงฐาน

        For Each ndr As DataRow In dtPersonID.Rows
            Try
                cExecute.BeginTransaction()
                cExecute.sqlStr = "Insert into " & nameTableLog & "  ( [Web_Program], [Type_Menu], [Web_Code], [PersonID],[Create_By],[DataID] ) values(?,?,?,?,?,?)"
                cExecute.cmdConnection()
                cExecute.Transaction()
                cExecute.sqlParameter_Value("@p1", "NV", Web_Program)  ' Program = HRISLogin
                cExecute.sqlParameter_Value("@p2", "NV", Type_Menu)    ' M = หน้าจอ  R= หน้าจอรายงาน  ,I= Import ,E = Export ,P=Print
                cExecute.sqlParameter_Value("@p3", "NV", Web_Code)     ' Menu code = หัวข้อการแจ้งเตือน,หัวข้อข่าวประกาศ
                cExecute.sqlParameter_Value("@p4", "NM", Val(ndr("PersonID") & ""))     ' PersonID = ที่คลิกเข้ามาแล้วเห็นใครบ้าง
                cExecute.sqlParameter_Value("@p5", "NV", Create_By)    ' UserID
                cExecute.sqlParameter_Value("@p6", "NV", Trim(ndr("DataID") & ""))
                cExecute.ExecuteNonQuery()
                cExecute.Commit()
            Catch ex As Exception
                cExecute.Rollback()
            End Try
        Next

    End Function

    Function InsertLogfile(Web_Code As String, PersonCode As String, EditType As String, OldValue As String, NewValue As String, OldSalary As String, NewSalary As String)
        Dim nameTableLog As String
        Dim cExecute As New connExecute(sqlconLog)

        nameTableLog = "LOG_File_" & Now.Year

        '---- ฐานข้อมูล log  ------
        'SQL_LOG = "server=(Local);database=CyberHRM_Log;uid=sa;pwd=tiger"

        CheckTable(nameTableLog, "LOG_File")  ' ตรวจสอบฐาน

        ''---------------------------- เก็บลงฐาน
        Try

            cExecute.BeginTransaction()
            cExecute.sqlStr = "Insert into " & nameTableLog & "  ( [Web_Program],[Web_Code],[PersonCode],[EditType],[OldValue],[NewValue],[Create_By],[CompanyID],[ComName],[OldSalary],[NewSalary] ) values(?,?,?,?,?,?,?,?,?,EncryptByPassPhrase('1984',?),EncryptByPassPhrase('1984',?))"
            cExecute.cmdConnection()
            cExecute.Transaction()
            cExecute.sqlParameter_Value("@p1", "NV", Sys.LoginWeb.SystemName)  ' Program ชื่อระบบ
            cExecute.sqlParameter_Value("@p2", "NV", Web_Code) ' Menu code
            cExecute.sqlParameter_Value("@p3", "NV", PersonCode) 'PersonCode nvarchar รหัสพนักงานที่ถูกทำรายการ
            cExecute.sqlParameter_Value("@p4", "NV", EditType) 'EditType nvarchar
            cExecute.sqlParameter_Value("@p5", "NV", OldValue) 'OldValue nvarchar
            cExecute.sqlParameter_Value("@p6", "NV", NewValue) 'NewValue nvarchar
            cExecute.sqlParameter_Value("@p7", "NV", Sys.LoginWeb.UserName)  ' Create_By numeric ไอดีของพนักงานที่ Login 
            cExecute.sqlParameter_Value("@p8", "NV", Sys.LoginWeb.CompanyID)  'CompanyID numeric บริษัทที่เข้ามาใช้งาน
            cExecute.sqlParameter_Value("@p9", "NV", System.Environment.MachineName) 'ComName   nvarchar

            If OldSalary = "" Then
                cExecute.sqlParameter_Value("@p10", "C", DBNull.Value) 'เงินเดือนเก่า   <OldValue, varbinary 200,>
            Else
                cExecute.sqlParameter_Value("@p10", "C", Trim(OldSalary & ""))
            End If

            If NewSalary = "" Then
                cExecute.sqlParameter_Value("@p11", "C", DBNull.Value) 'เงินเดือนใหม่   <NewValue, varbinary 200,>
            Else
                cExecute.sqlParameter_Value("@p11", "C", Trim(NewSalary & ""))
            End If

            cExecute.ExecuteNonQuery()
            cExecute.Commit()
            cExecute.Parameters.Clear()
        Catch ex As Exception
            cExecute.Rollback()
        End Try

    End Function

    Function UpdateLogfile(ByVal Edittype As String, ByVal OldValue As String, ByVal NewValue As String, ByVal PersonCode As String) As Boolean
        Try
            'Dim Con As SqlConnection
            'Dim Cmd As SqlCommand
            'Dim Log_SyncStatus = "T"   'ชื่อโปรแกรม
            'If Con Is Nothing Then
            '    Con = New SqlConnection(sqlcon)
            '    Cmd = Con.CreateCommand
            'End If
            'Try
            '    If Con.State = ConnectionState.Closed Then
            '        Con.Open()
            '    End If


            '    Cmd.CommandText = "Insert Into TAP_Logfile(EditType,OldValue,NewValue,PersonCode,UserName,ComName,SyncStatus,IDCompany) values ('" & Edittype & "','" & OldValue & "','" & NewValue & "','" & PersonCode & "','" & Sys.LoginWeb.UserName & "','" & System.Environment.MachineName & "','" & Log_SyncStatus & "'," & Sys.LoginWeb.CompanyID & ")"
            '    Cmd.ExecuteNonQuery()
            'Catch ex As Exception
            '    Return False
            'Finally
            '    Con.Close()
            'End Try
            Return True

        Catch ex As Exception
        End Try
    End Function
End Module
