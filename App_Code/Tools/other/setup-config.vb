Imports Microsoft.VisualBasic

Public Class SetupConfig

    Dim app As HttpContext

    Dim sortData As SortedList
    Dim conn As connections
    Dim LocalJson As CallBack

    Sub New(context As HttpContext)

        app = context
        conn = New connections
        sortData = New SortedList()
        LocalJson = New CallBack()
        LocalJson.context = app
    End Sub

    Public Sub Load()
        Try


            sortData = Change.context(app)

            Select Case sortData("process")
                Case "InitLoad"
                    InitLoad()
                Case "Update"
                    Update()
                Case "cleardatabase"
                    cleardatabase()

            End Select

        Catch ex As Exception
            LocalJson.exception(ex)
            LocalJson.response()
        End Try

    End Sub
    Sub cleardatabase()

        Try

            sortData = Change.context(app)

            Dim arrayTruncate As New ArrayList()

            arrayTruncate.Add("truncate table TNM_Course")
            arrayTruncate.Add("truncate table TNM_Expenses")
            arrayTruncate.Add("truncate table TNM_FileType")
            arrayTruncate.Add("truncate table TNM_GroupCourse")
            arrayTruncate.Add("truncate table TNM_InstitueTrain")
            arrayTruncate.Add("truncate table TNM_Organize")
            arrayTruncate.Add("truncate table TNM_Patern_ReF")
            arrayTruncate.Add("truncate table TNM_Professor")
            arrayTruncate.Add("truncate table TNM_TmpPass")
            arrayTruncate.Add("truncate table TNM_Type_Patern")
            arrayTruncate.Add("truncate table TNM_TypeCourse")
            arrayTruncate.Add("truncate table TNT_ftfy1text")
            arrayTruncate.Add("truncate table TNT_Fyfp22")
            arrayTruncate.Add("truncate table TNT_FyfpPerson")
            arrayTruncate.Add("truncate table TNT_FyfpProfessor")
            arrayTruncate.Add("truncate table TNT_FyfpQualification")
            arrayTruncate.Add("truncate table TNT_FyfpSendPerson")
            arrayTruncate.Add("truncate table TNT_FyfpTrain")
            arrayTruncate.Add("truncate table TNT_FyfpTrainPerson")
            arrayTruncate.Add("truncate table TNT_FyfpVt")
            arrayTruncate.Add("truncate table TNT_FyfpVttopic")
            arrayTruncate.Add("truncate table TNT_Patern_Course")
            arrayTruncate.Add("truncate table TNT_Patern_Professor")
            arrayTruncate.Add("truncate table TNT_PercentGrade")
            arrayTruncate.Add("truncate table TNT_ProcessFyfp")
            arrayTruncate.Add("truncate table TNT_ProcessSt")
            arrayTruncate.Add("truncate table TNT_Qualifications")
            arrayTruncate.Add("truncate table TNT_St22Cert")
            arrayTruncate.Add("truncate table TNT_St22Person")
            arrayTruncate.Add("truncate table TNT_stText")
            arrayTruncate.Add("truncate table TNT_SubFyfp")
            arrayTruncate.Add("truncate table TNT_TrainDay")
            arrayTruncate.Add("truncate table TNT_TrainExpenses")
            arrayTruncate.Add("truncate table TNT_TrainPerson")
            arrayTruncate.Add("truncate table TNT_TrainPersonEvaluation")
            arrayTruncate.Add("truncate table TNT_Vt")
            arrayTruncate.Add("truncate table TNT_Vttopic")


            Using exe As New connExecute(conn.BaseTo)

                exe.BeginTransaction()

                Try

                    Dim str As String = String.Join(" ", arrayTruncate.ToArray())

                    exe.sqlStr = str
                    exe.cmdConnection()
                    exe.Transaction()
                    exe.ExecuteNonQuery()

                    exe.Commit()

                    LocalJson.data("ok")
                Catch ex As Exception
                    exe.Rollback()
                    Throw New Exception(ex.Message.ToString)
                End Try


            End Using


        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()

    End Sub


    Sub Update()

        Try

            sortData = Change.context(app)

            If sortData.Contains("store") Then
                conn.update(sortData("store"))
                LocalJson.data("ok")
            End If


        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()

    End Sub

    Sub InitLoad()

        Try

            Dim indata = conn.info()

            LocalJson.data(Change._Tojson(indata))

        Catch ex As Exception
            LocalJson.exception(ex)
        End Try

        LocalJson.response()

    End Sub

End Class
