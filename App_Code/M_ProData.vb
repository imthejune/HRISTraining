
Imports Microsoft.VisualBasic
Imports System.Globalization
Imports System.Data
Imports Microsoft.Win32
Imports System.Configuration.ConfigurationManager
Imports System.Diagnostics
Imports Telerik.Web.UI
Imports System.Threading
Imports System.Web.UI
Imports System.Web
Imports System
Imports System.Web.UI.WebControls
Imports System.Collections
Imports System.ComponentModel
Imports System.Runtime.InteropServices


Public Module prodata
    Dim _PageGuid As String = ""
    Dim _Setdata As DataSet = Nothing
    Dim _config As Object = Nothing
    Dim _connect As String = ""

    Public Property SetData As DataSet
        Get
            Return CType(HttpContext.Current.Session(pageGuid), DataSet)
        End Get
        Set(ByVal value As DataSet)
            HttpContext.Current.Session(pageGuid) = value
        End Set

    End Property
    Public Property config As Object
        Get
            Return _config
        End Get
        Set(ByVal value As Object)
            _config = value
        End Set

    End Property
    Public Property connect As String
        Get
            Return _connect
        End Get
        Set(ByVal value As String)
            _connect = value
        End Set

    End Property
    Public Property pageGuid As String
        Get
            Return _PageGuid
        End Get
        Set(ByVal value As String)
            _PageGuid = value
        End Set

    End Property

    Public Function _tempData(sql As String, tableName As String, Optional type As Integer = 0, Optional conn As String = "") As DataTable

        config = New Mydata(adoconn, IIf(conn <> "", conn, Connection.sqlcon))

        If IsNothing(SetData) Then
            SetData = New DataSet()
        End If

        If Not SetData.Tables.Contains(tableName) Then

            config.GetDataset(SetData, String.Format(sql, Sys.LoginWeb.Lang), tableName)
        Else

            If type = 1 Then

                If SetData.Tables.Contains(tableName) Then
                    SetData.Tables.Remove(tableName)
                End If
                config.GetDataset(SetData, String.Format(sql, Sys.LoginWeb.Lang), tableName)
            End If

        End If

        _tempData = SetData.Tables(tableName)

    End Function

    Public Function _tempLog(name As String) As String

        Try

            If IsNothing(SetData) Then
                SetData = New DataSet()
            End If

            If Not SetData.Tables.Contains(name) Then

                'Dim tempdt As DataTable = New DataTable

                'tempdt.TableName = name
                'tempdt.Columns.Add("ServerName", GetType(String))
                'tempdt.Columns.Add("Database", GetType(String))
                'tempdt.Columns.Add("User", GetType(String))
                'tempdt.Columns.Add("Password", GetType(String))


                'SetData.Tables.Add(tempdt)

            End If

            If SetData.Tables(name).Rows.Count > 0 Then

                'For Each ndr As DataRow In prodata.SetData.Tables(name).Rows

                '    connect = "server=" & ndr("ServerName") & ";database=" & ndr("Database") & ";uid=" & ndr("User") & ";pwd=" & ndr("Password")

                'Next
            Else

                SetData.Tables(name).Rows.Add("TG11508\SQLEXPRESS01", "dbCyberHRM", "sa", "tiger")
                SetData.Tables(name).Rows.Add("TG11508\SQLEXPRESS01", "HrisTraining", "sa", "tiger")
                '_tempConfig(name)

            End If

            _tempLog = connect
        Catch ex As Exception

        End Try
    End Function

    Sub _Binding(_Object As Object, _name As String, Optional _sort As String = "", Optional _value As String = "", Optional _text As String = "")
        'dt_ = New DataTable()

        Dim dt_ As DataTable = New DataTable()



        dt_ = SetData.Tables(_name)


        If Not IsNothing(dt_) AndAlso dt_.Rows.Count > 0 Then


            If _sort <> "" Then
                dt_.DefaultView.Sort = _sort
                _Object.DataSource = dt_.DefaultView
            Else
                _Object.DataSource = dt_
            End If


            Select Case _Object.GetType
                Case GetType(Telerik.Web.UI.RadGrid)
                    Dim ss As String = ""
                Case GetType(Telerik.Web.UI.RadComboBox)
                    '_Object.DataValueField = "PersonCode"
                    '_Object.DataTextField = "Sname"
            End Select

        Else
            _Object.DataSource = New String() {}

        End If

        _Object.DataBind()


    End Sub


    Public Function _tempConfig(name_ As String, type_ As String) As String

        Try
            If IsNothing(SetData) Then
                SetData = New DataSet()
            End If

            If SetData.Tables(name_).Rows.Count > 0 Then

                Dim dr_() As DataRow

                dr_ = SetData.Tables(name_).Select(" Type = '" & type_ & "'")

                If dr_.Length > 0 Then

                    connect = "server=" & dr_(0)("ServerName").Replace("\\", "\") & ";database=" & dr_(0)("Database") & ";uid=" & dr_(0)("User") & ";pwd=" & dr_(0)("Password")

                Else
                    connect = ""

                End If

                'For Each ndr As DataRow In prodata.SetData.Tables(name).Rows

                '    If ndr("Type") <> 0 Then

                '    Else
                '        connect = "server=" & ndr("ServerName").Replace("\\", "\") & ";database=" & ndr("Database") & ";uid=" & ndr("User") & ";pwd=" & ndr("Password")
                '    End If


                'Next
                ' Else

                ' SetData.Tables(name_).Rows.Add("Cyber", "TG11508\SQLEXPRESS01", "dbCyberHRM", "sa", "tiger")
                'SetData.Tables(name_).Rows.Add("Hris", "TG11508\SQLEXPRESS01", "HrisTraining", "sa", "tiger")


                'If connect = "" Then
                '_tempConfig(name_, type_)
                'End If

            End If

            _tempConfig = connect

        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Module
