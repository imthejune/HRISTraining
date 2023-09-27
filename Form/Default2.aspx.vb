Imports System.Web.Services
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports Telerik.Web.UI
Imports System.Data.SqlClient
Imports System
Imports System.Web.UI.WebControls
Imports System.Web.Configuration
Imports Telerik.Windows
Partial Class Default2
    Inherits System.Web.UI.Page
    Public conDB As String = sqlcon
    Dim da_tmp As New Mydata(1, conDB)
    Dim sqlstr As String = ""
    Dim ds_tmp As New DataSet
    Dim dt As DataTable
    Dim da As New Mydata(adoconn)
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then

            If Request.QueryString("ticket") Then
                Lable2.Text = "Ticket Number: " & Request.QueryString("ticket")
                Session("ticket") = Request.QueryString("ticket")
            End If

            '  Call SelectRepair()
            'GridRepair.DataSource = New String() {}
            'GridRepair.DataBind()
        End If
        Call SelectPerson()
    End Sub
    Sub SelectPerson()
        Dim idPerson As String = Session("ticket")
        Try
            'ds_tmp.Tables("ticket").Clear()
        Catch ex As Exception
        End Try
        sqlstr = "SELECT ROW_NUMBER() OVER(ORDER BY T_Person.t_id) AS NumberRow, T_Person.t_id, T_Person.t_name, T_Person.t_address, T_Person.t_email, T_Person.t_company, T_Person.t_tel, SCM_Product.productName, T_Person.t_ticket "
        sqlstr += " FROM T_Person LEFT JOIN SCM_Product ON T_Person.t_product_id = SCM_Product.id_product WHERE T_Person.t_ticket = '" & idPerson & "' "

        'da_tmp.GetDataset(ds_tmp, sqlstr, "Person")

        dt = New DataTable
        dt = da.GetDataTable(sqlstr)

        Session("DataPerson") = dt

        Call GetDataTable()

    End Sub
    Sub GetDataTable()
        If Not IsNothing(Session("DataPerson")) Then
            GridPerson.DataSource = Session("DataPerson")
            GridPerson.DataBind()
        Else
            GridPerson.DataSource = New String() {}
            GridPerson.DataBind()
        End If
    End Sub
    Protected Sub GridPerson_BatchEditCommand(sender As Object, e As GridBatchEditingEventArgs) Handles GridPerson.BatchEditCommand
        If e.Commands.Count > 0 Then

            Dim cExecute As New connExecute

            cExecute.BeginTransaction()
            Try
                For Each item As GridBatchEditingCommand In e.Commands
                    Dim newValues As Hashtable = item.NewValues
                    Dim OldValues As Hashtable = item.OldValues


                    If item.Type = GridBatchEditingCommandType.Insert Then

                    ElseIf item.Type = GridBatchEditingCommandType.Update Then
                        Dim Ticket As String = OldValues("t_ticket")
                        Dim Name As String = newValues("Name")
                        Dim Address As String = newValues("Address")
                        Dim Email As String = newValues("Email")
                        Dim Company As String = newValues("Company")
                        Dim Tel As String = newValues("Tel")

                        ClientScript.RegisterStartupScript(Me.GetType(), "myclose", "CheckRep();", True)
                        If Name = "" Then
                            WinMessageBox.RadAlert("ตรวจสอบ ชื่อ-นามสกุล", 220, 1, "แจ้งเตือน", Nothing)
                            Exit Sub
                        End If

                        If Company = "" Then
                            WinMessageBox.RadAlert("ตรวจสอบชื่อบริษัท", 200, 1, "แจ้งเตือน", Nothing)
                            Exit Sub
                        End If

                        If Address = "" Then
                            WinMessageBox.RadAlert("ตรวจสอบที่อยู่", 200, 1, "แจ้งเตือน", Nothing)
                            Exit Sub
                        End If

                        If Tel = "" Then
                            WinMessageBox.RadAlert("ตรวจสอบเบอร์โทรศัพท์", 200, 1, "แจ้งเตือน", Nothing)
                            Exit Sub
                        End If

                        If Email = "" Then
                            WinMessageBox.RadAlert("ตรวจสอบ E-mail", 200, 1, "แจ้งเตือน", Nothing)
                            Exit Sub
                        End If

                        Try
                            Dim cmdsqlStr As String

                            cmdsqlStr = "UPDATE T_Person SET t_name = (?), t_address = (?), t_email = (?), t_company = (?), t_tel = (?) WHERE t_ticket = (?) "
                            cExecute.sqlStr = cmdsqlStr
                            cExecute.cmdConnection()
                            cExecute.sqlParameter_Value("@p1", "NV", Name)
                            cExecute.sqlParameter_Value("@p2", "NV", Address)
                            cExecute.sqlParameter_Value("@p3", "NV", Email)
                            cExecute.sqlParameter_Value("@p4", "NV", Company)
                            cExecute.sqlParameter_Value("@p5", "NV", Tel)
                            cExecute.sqlParameter_Value("@p6", "NV", Ticket)
                            cExecute.Transaction()
                            cExecute.ExecuteNonQuery()

                        Catch ex As Exception
                            cExecute.Rollback()
                        End Try

                        Exit For

                    Else
                    End If

                Next
                cExecute.Commit()
                WinMessageBox.RadAlert("แก้ไขข้อมูลสำเร็จ", 200, 1, "แจ้งเตือน", Nothing)
                Call SelectPerson()
                Call GetDataTable()
            Catch ex As Exception
                cExecute.Rollback()
                WinMessageBox.RadAlert("แก้ไขข้อมูลไม่สำเร็จ", 200, 1, "แจ้งเตือน", Nothing)
            End Try

        End If

        'If Expire = "" Then
        '    Expire = OldValues("Expire")
        'End If
    End Sub

End Class