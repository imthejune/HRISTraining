Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Security.Cryptography
Imports System.Web.Routing
Imports Microsoft.Win32


Public Module Controls

    Public Property callbacks As New CallBack()
    Public Property Clients As New Client
    Public Property StartupScript As StartupScript
    Public Property Change As Change
    'Public Property myBody As New propt.parse
    Public Property Mains As New Main

    Public Property stream As SortedList = New SortedList

    Public Combo As Manage_Combo = New Manage_Combo



    Public Crypt As New Crypts

    Public Key As New Keys

    Public Enum IS_
        Rental = 0
        Outsource = 1
        License = 2
        Cyber = 0
        HRIS = 1
        Insert = 1
        Update = 2
        Delete = 3
        Begin = 0
        Undifined = 99
    End Enum








End Module

Public Class Main

    Sub New()
        Me.this = New SortedList
    End Sub
    Dim _listitems As SortedList
    Public Property listitems As SortedList
        Get
            Return _listitems
        End Get
        Set(value As SortedList)
            _listitems = value
        End Set
    End Property
    Public Sub RouteConfig(routes As RouteCollection)

        routes.MapPageRoute("Resources-data", "data/{key}", "~/setting/res/data.res.aspx", True)
        '  routes.MapPageRoute("Resources-table", "table/{key}", "~/setting/components/table.component.aspx", True)

        'routes.MapPageRoute("location-data", "location/{key}", "~/Location/location.data.aspx", True)

        'routes.MapPageRoute("res", "res/{var}/{key}", "~/master/render/res/render.res.aspx", True)
        'routes.MapPageRoute("approve-key", "approve/{key}", "~/Mobile/Company/WebApprov-outsource.aspx", True)
        'routes.MapPageRoute("approve-Master", "Master/{key}", "~/Mobile/Company/FormPopup/MasterApprovCmb.aspx", True)

        'routes.MapPageRoute("res-signalr", "log/{data}", "~/Mobile/Company/res/signalr.res.aspx", True)
        'routes.MapPageRoute("res-dashboard", "dashboard/{key}", "~/dashboard/res/dashboard.res.aspx", True)

        'routes.MapPageRoute("res-checkin", "checkin/{key}", "~/Mobile/CheckIn/checkin.data.aspx", True)

        'routes.MapPageRoute("res-module", "module/{key}", "~/master/render/render.endpoint.aspx", True)
    End Sub


    Private ReadOnly SizeSuffixes As String() = {"bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
    Public Function SizeSuffix(ByVal value As Long, ByVal Optional decimalPlaces As Integer = 2) As String
        If decimalPlaces < 0 Then
            Throw New ArgumentOutOfRangeException("decimalPlaces")
        End If

        If value < 0 Then
            Return "-" & SizeSuffix(-value)
        End If

        If value = 0 Then
            Return String.Format("{0:n" & decimalPlaces & "} bytes", 0)
        End If

        ' mag is 0 for bytes, 1 for KB, 2, for MB, etc.
        Dim mag As Integer = Math.Log(value, 1024)

        ' 1L << (mag * 10) == 2 ^ (10 * mag) 
        ' [i.e. the number of bytes in the unit corresponding to mag]
        Dim adjustedSize As Decimal = CDec(value) / (1L << mag * 10)

        ' make adjustment when the value is large enough that
        ' it would round up to 1000 or more
        If Math.Round(adjustedSize, decimalPlaces) >= 1000 Then
            mag += 1
            adjustedSize /= 1024
        End If

        Return String.Format("{0:n" & decimalPlaces & "} {1}", adjustedSize, SizeSuffixes(mag))
    End Function

    Public Function GetDates(ByVal d As Date) As String
        ' 1.
        ' Get time span elapsed since the date.
        Dim s As TimeSpan = Date.Now.Subtract(d)
        ' 2.
        ' Get total number of days elapsed.
        Dim dayDiff As Integer = s.TotalDays
        ' 3.
        ' Get total number of seconds elapsed.
        Dim secDiff As Integer = s.TotalSeconds
        ' 4.
        ' Don't allow out of range values.
        If dayDiff < 0 OrElse dayDiff >= 31 Then
            Return Nothing
        End If
        ' 5.
        ' Handle same-day times.
        If dayDiff = 0 Then
            ' A.
            ' Less than one minute ago.
            If secDiff < 60 Then
                Return "just now"
                'Return 0
            End If
            ' B.
            ' Less than 2 minutes ago.
            If secDiff < 120 Then
                Return "1 minute ago"
                'Return 0
            End If
            ' C.
            ' Less than one hour ago.
            If secDiff < 3600 Then
                Return 0
                ' Return Math.Floor(secDiff / 60)
                Return String.Format("{0} minutes ago", Math.Floor(secDiff / 60))
            End If
            ' D.
            ' Less than 2 hours ago.
            If secDiff < 7200 Then
                Return "1 hour ago"
                ' Return 1
            End If
            ' E.
            ' Less than one day ago.
            If secDiff < 86400 Then
                ' Return 1
                'Return Math.Floor(secDiff / 3600)
                Return String.Format("{0} hours ago", Math.Floor(secDiff / 3600))
            End If
        End If
        ' 6.
        ' Handle previous days.
        If dayDiff = 1 Then
            Return dayDiff & " day ago"
        End If

        If dayDiff < 7 Then
            Return dayDiff & " day ago"
        End If

        If dayDiff < 31 Then
            Return dayDiff & " day ago"
        End If

        Return Nothing
    End Function


    Public Property this() As SortedList

    Sub plus(key As String, val As Object)
        If IsNothing(this) Then
            this = New SortedList
        End If

        If Not this.Contains(key) Then
            this.Add(key, val)
        Else
            this(key) = val
        End If
    End Sub

    Public Function Create() As SortedList

        Dim st As New Generic.Dictionary(Of String, SortedList)
        Dim b As New SortedList
        Dim res = HttpContext.Current.Request.Url
        Dim tempPath = res.Segments(res.Segments.Length - 1)
        Dim g As String = CType(HttpContext.Current.Session(tempPath), String)
        Try

            st = CType(HttpContext.Current.Session("this_"), Generic.Dictionary(Of String, SortedList))

            If IsNothing(st) Then
                st = New Generic.Dictionary(Of String, SortedList)
                st.Add(g, New SortedList)
                HttpContext.Current.Session("this_") = st
            End If

            If st.ContainsKey(g) Then

                For Each item In st
                    If item.Key = g Then
                        b = CType(item.Value, SortedList)
                    End If
                Next
            Else
                st.Add(g, New SortedList)
                For Each item In st
                    If item.Key = g Then
                        b = CType(item.Value, SortedList)
                    End If
                Next
                HttpContext.Current.Session("this_") = st
            End If
        Catch ex As Exception
            Create = Nothing
        End Try
        Create = b
    End Function
    Public Function Dictionary() As SortedList

        Dim st As New Generic.Dictionary(Of String, SortedList)
        Dim b As New SortedList
        Dim res = HttpContext.Current.Request.Url
        Dim tempPath = res.Segments(res.Segments.Length - 1)
        Dim g As String = CType(HttpContext.Current.Session(tempPath), String)
        Try
            If Trim(g & "") = "" Then
                b = Nothing
                Exit Try
            End If
            st = CType(HttpContext.Current.Session("this_"), Generic.Dictionary(Of String, SortedList))

            If IsNothing(st) Then
                b = Nothing
            End If
            If st.ContainsKey(g) Then
                For Each item In st
                    If item.Key = g Then
                        b = CType(item.Value, SortedList)
                    End If
                Next
            End If

        Catch ex As Exception
            b = Nothing
        End Try
        Dictionary = b
    End Function

    Public Function Duplicate(ByVal dTable As DataTable, ByVal colName As String) As DataTable
        Dim hTable As Hashtable = New Hashtable()
        Dim duplicateList As ArrayList = New ArrayList()

        For Each drow As DataRow In dTable.Rows

            If hTable.Contains(drow(colName)) Then
                duplicateList.Add(drow)
            Else
                hTable.Add(drow(colName), String.Empty)
            End If

        Next
        For Each dRow As DataRow In duplicateList
            dTable.Rows.Remove(dRow)
        Next

        Return dTable
    End Function

    Public Shared Function Duplicate(ByVal dTable As DataTable, ByVal colName As String, ByVal fil As String) As DataTable
        Dim arryFil As Array = Nothing
        Dim hTable As Hashtable = New Hashtable()
        Dim duplicateList As ArrayList = New ArrayList()

        If fil.Length > 0 Then
            arryFil = fil.Split(",")
        End If

        For Each drow As DataRow In dTable.Rows

            If hTable.Contains(drow(colName)) Then
                duplicateList.Add(drow)
            Else
                If arryFil.Length = 2 Then
                    hTable.Add(drow(colName), drow(arryFil(0)))
                Else
                    hTable.Add(drow(colName), String.Empty)
                End If
            End If

            If arryFil.Length = 2 Then

                If hTable.Contains(drow(colName)) Then
                    If drow(arryFil(1)).ToString <> "" And hTable.Item(drow(colName)).ToString <> "" Then
                        If drow(arryFil(1)) > hTable.Item(drow(colName)) Then
                            hTable.Item(drow(colName)) = drow(arryFil(1))
                        End If
                    End If
                End If

            End If
        Next

        For Each dRow As DataRow In duplicateList
            dTable.Rows.Remove(dRow)
        Next

        For Each drow As DataRow In dTable.Rows
            If hTable.Contains(drow(colName)) And arryFil.Length = 2 Then
                If hTable.Item(drow(colName)).ToString <> "" Then
                    drow(arryFil(1)) = hTable.Item(drow(colName))
                End If
            End If
        Next


        Return dTable
    End Function


    ':// Commit iSit 09092020-E
    Public Function CreateDateSuffix(ByVal [date] As Date) As String
        ' Get day...
        Dim day = [date].Day

        ' Get day modulo...
        Dim dayModulo = day Mod 10

        ' Convert day to string...
        Dim suffix = day.ToString(CultureInfo.InvariantCulture)

        ' Combine day with correct suffix...
        suffix += If(day = 11 OrElse day = 12 OrElse day = 13, "th", If(dayModulo = 1, "st", If(dayModulo = 2, "nd", If(dayModulo = 3, "rd", "th"))))

        ' Return result...
        Return suffix
    End Function
End Class
