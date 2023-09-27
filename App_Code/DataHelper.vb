Imports System.Data
Imports System
Imports System.Globalization
Imports System.Threading

Public Class DataHelper

    Public Shared Function ToBoolean(obj As Object, defaultValue As Boolean) As Boolean
        Try
            If (obj.ToString = "" OrElse Object.ReferenceEquals(obj, DBNull.Value)) Then
                Return defaultValue
            End If

            Return (obj.ToString().ToUpper() = "TRUE" OrElse obj.ToString() = "1")
        Catch
            Return defaultValue
        End Try
    End Function

    Public Shared Function ToInt(obj As Object) As Integer
        Try
            Dim i As Integer = Convert.ToInt32(obj.ToString().Replace(",", ""))
            Return i
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function ToString(obj As Object) As Object
        Dim txt As String = ""
        Try
            If (obj.ToString = "") Then
                Return ""
            Else
                Return obj.ToString().Trim()
            End If
        Catch
            Return txt
        End Try
    End Function

    Public Shared Function ToCharacter(obj As Object) As Object
        Dim txt As String = ""
        Try
            If (obj.ToString = "") Then
                Return DBNull.Value
            Else
                Return obj.ToString().Trim()
            End If
        Catch
            Return txt
        End Try
    End Function

    Public Shared Function ToDateTime(str As String) As DateTime
        Dim arrStr As String()
        Dim strDay As String = ""
        Dim strMonth As String = ""
        Dim strYear As String = ""
        Try

            If (Sys.LoginWeb.Lang <> "T") Then
                arrStr = str.Split("/")
                strDay = arrStr(0)
                strMonth = arrStr(1)
                strYear = arrStr(2)
                str = strDay + "/" + strMonth + "/" + strYear
            End If

            Dim obj = Convert.ToDateTime(str)
            Dim yearINT As Integer = obj.Year

            If (yearINT < 1900) Then
                obj = obj.AddYears(543)
            ElseIf (yearINT > 3000) Then
                obj = obj.AddYears(-543)
            End If

            Return obj
        Catch ex As Exception
            Throw New Exception(Sys.TMsg.DateIncorrect)
        End Try
    End Function

    Public Shared Function ToDateTime(obj As DateTime) As DateTime
        Try

            Dim yearINT As Integer = obj.Year
            If (yearINT < 1900) Then
                obj = obj.AddYears(543)
            ElseIf (yearINT > 3000) Then
                obj = obj.AddYears(-543)
            End If

            Return obj
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function ValidateTime(strTime As String) As Boolean
        Dim Msg As String = ""
        Dim arrTime As String()
        Dim canProcess As Boolean = False
        Dim Hour As Integer = 0
        Dim Minute As Integer = 0
        Dim Second As Integer = 0
        Try
            If (strTime.IndexOf(":") >= 0) Then
                arrTime = strTime.Split(":")

                Hour = arrTime(0)
                Minute = arrTime(1)
                If (arrTime.Length > 2) Then Second = arrTime(2)

                If (Hour >= 24) Then Hour = 0
                If (Minute >= 60) Then Minute = 0
                If (Second >= 60) Then Second = 0

                If Hour >= 24 OrElse Minute >= 60 OrElse Second >= 60 Then
                    canProcess = False
                Else
                    canProcess = True
                End If
            End If

            Return canProcess

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function GetCalendar(ByVal xstring As String) As Date

        Dim spllit() As String = xstring.Replace(" ", "").Split("/")

        Try
            If spllit(2) < 1900 Then
                Return Nothing
            End If
            If spllit(2) < 2500 Then
                Return New Date(spllit(2), spllit(1), spllit(0))
            Else
                Return New Date(spllit(2) - 543, spllit(1), spllit(0))
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetDateReportText([date] As DateTime) As String
        Try
            'Fixed report date ENG

            Dim dateSTR As String = [date].ToString("dd/MM/yyyy")
            Dim dateArr() As String = dateSTR.Split("/")
            Dim yearSTR As Integer = ToInt(dateArr(2))

            If (yearSTR < 1900) Then yearSTR = yearSTR + 543
            If (yearSTR > 2500) Then yearSTR = yearSTR - 543


            Return yearSTR.ToString() + "-" + dateArr(1) + "-" + dateArr(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetDateDisplayText([date] As DateTime, CultureText As String) As String
        Try
            Dim dateSTR As String = [date].ToString("dd/MM/yyyy")
            Dim dateArr() As String = dateSTR.Split("/")
            Dim yearSTR As Integer = ToInt(dateArr(2))

            Select Case CultureText
                Case "T" : If (yearSTR < 2500) Then yearSTR = yearSTR + 543
                Case "E" : If (yearSTR > 2500) Then yearSTR = yearSTR - 543
            End Select

            Return dateArr(0) + "/" + dateArr(1) + "/" + yearSTR.ToString()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetYearDisplayText(yearSTR As Integer, CultureText As String) As String
        Try
            Select Case CultureText
                Case "T"
                    If (yearSTR < 2500) Then yearSTR = yearSTR + 543
                    If (yearSTR > 3000) Then yearSTR = yearSTR - 543
                Case Else
                    If (yearSTR > 2500) Then yearSTR = yearSTR - 543
                    If (yearSTR < 1500) Then yearSTR = yearSTR + 543
            End Select

            Return yearSTR.ToString()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function GetDateTimeDisplayText([date] As DateTime, CultureText As String) As String
        Try
            Dim datetimeSTR As String = [date].ToString("dd/MM/yyyy HH:mm")
            Dim datetimeArr() As String = datetimeSTR.Split(" ")
            Dim dateArr() As String = datetimeArr(0).Split("/")
            Dim yearSTR As Integer = ToInt(dateArr(2))

            Select Case CultureText
                Case "T" : If (yearSTR < 2500) Then yearSTR = yearSTR + 543
                Case "E" : If (yearSTR > 2500) Then yearSTR = yearSTR - 543
            End Select

            Return dateArr(0) + "/" + dateArr(1) + "/" + yearSTR.ToString() + " " + datetimeArr(1)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Compare_Date(ByVal d1 As Date, ByVal d2 As Date) As Integer
        d1 = d1.ToShortDateString
        d2 = d2.ToShortDateString
        Compare_Date = DateDiff(DateInterval.Day, d1, d2) + 1
    End Function

    Public Shared Function CDateTime(ByVal Tdate As Date, ByVal d2 As String) As DateTime
        Dim a() As String
        d2 = d2.Replace(".", ":")
        a = Split(d2, ":")
        CDateTime = New DateTime(Tdate.Year, Tdate.Month, Tdate.Day, Val(a(0)), Val(a(1)), 0)
    End Function

    Public Shared Function CkTimeString(ByVal TStr As String) As String
        Dim T() As String
        If TStr.Trim = "" Then TStr = ":"
        T = Split(TStr, ":")
        If T.Length = 1 Then
            If Val(T(0)) >= 24 Then T(0) = "00"
            CkTimeString = Format(Val(T(0)), "00") & ":" & "00"
        Else
            If Val(T(0)) >= 24 Then T(0) = "00"
            If Val(T(1)) >= 60 Then T(1) = "00"
            CkTimeString = Format(Val(T(0)), "00") & ":" & Format(Val(T(1)), "00")
        End If
    End Function

    Public Shared Function CkTimeString1(ByVal TStr As String) As String
        Dim T() As String
        T = Split(TStr, ":")
        ' If Val(T(0)) >= 24 Then T(0) = "00"
        If Val(T(1)) >= 60 Then T(1) = "00"
        CkTimeString1 = Format(Val(T(0)), "00") & ":" & Format(Val(T(1)), "00")
    End Function

    Public Shared Function ckTE() As String
        Dim TmpFormat As String = CultureInfo.CurrentCulture.Name
        If TmpFormat = "th-TH" Then Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        '+++++++++++++++++++++
        Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortTimePattern = "HH:mm:ss"
        Thread.CurrentThread.CurrentCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss"
    End Function

    Public Shared Function ckTh() As String
        Dim TmpFormat As String = CultureInfo.CurrentCulture.Name
        If TmpFormat = "th-TH" Then Thread.CurrentThread.CurrentCulture = New CultureInfo("th-TH")
        '++++++++++++++++++++
        Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortTimePattern = "HH:mm:ss"
        Thread.CurrentThread.CurrentCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss"
    End Function


  
End Class
