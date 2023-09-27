Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Drawing
Imports System.IO
Imports System.Data

Partial Class UserControl_PersonDetail
    Inherits System.Web.UI.UserControl
    Dim da As New Mydata(DatabaseType.SQLServer)

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Call Setlbl()
            'If Sys.LoginWeb.UserGroupID <> 0 Then
            '    Me.GetData(Session("NodePersonID") & "")
            'Else

            'End If
        End If

    End Sub

    Sub Setlbl()

        If Sys.LoginWeb.Lang <> "T" Then
            Me.lblNameEmp.Text = "Name Emp :"
        End If
        Me.lblcmb1.Text = Sys.LoginWeb.lblCmb1 & " : "
        Me.lblcmb2.Text = Sys.LoginWeb.lblCmb2 & " : "
        Me.lblcmb3.Text = Sys.LoginWeb.lblCmb3 & " : "
        Me.lblcmb4.Text = Sys.LoginWeb.lblCmb4 & " : "
        Me.lblcmb5.Text = Sys.LoginWeb.lblCmb5 & " : "
        Me.lblcmb6.Text = Sys.LoginWeb.lblCmb6 & " : "
        Me.lblPosition.Text = Sys.LoginWeb.lblPosition & " : "
    End Sub
    Public Sub GetData(Optional ByVal ID As String = "")

        sqlstr = String.Format("select PersonID,PersonCode,Initial{0}+' '+Fname{0}+' '+Lname{0} as nname,Cmb1Name{0} as cmb1,Cmb2Name{0} as cmb2,Cmb3Name{0} as cmb3,Cmb4Name{0} as cmb4,Cmb5Name{0} as cmb5,Cmb6Name{0} as cmb6,PositionName{0} as position from PNT_Person Left join PNM_Initial on PNM_Initial.InitialID = PNT_Person.InitialID  Left join PNM_Cmb1 on PNM_Cmb1.Cmb1ID = PNT_Person.Cmb1ID Left join PNM_Cmb2 on PNM_Cmb2.Cmb2ID = PNT_Person.Cmb2ID Left join PNM_Cmb3 on PNM_Cmb3.Cmb3ID = PNT_Person.Cmb3ID Left join PNM_Cmb4 on PNM_Cmb4.Cmb4ID = PNT_Person.Cmb4ID Left join PNM_Cmb5 on PNM_Cmb5.Cmb5ID = PNT_Person.Cmb5ID Left join PNM_Cmb6 on PNM_Cmb6.Cmb6ID = PNT_Person.Cmb6ID Left join PNM_Position on PNM_Position.PositionID = PNT_Person.PositionID where PersonID = " & Val(ID) & " and PNT_Person.CompanyID = " & Sys.LoginWeb.CompanyID & " order by PNT_Person.personcode", IIf(Sys.LoginWeb.Lang = "T", "T", "E"))

        Dim dt = da.GetDataTable(sqlstr)

        If dt.Rows.Count > 0 Then
            Dim chkFile = Sys.LoginWeb.Url & "PersonPic/M/" & dt.Rows(0)("PersonID") & ".png"
            Me.image.ImageUrl = chkFile

            If Not File.Exists(Sys.LoginWeb.Pathweb & "PersonPic/M/" & dt.Rows(0)("PersonID") & ".png") Then
                Me.image.ImageUrl = "../Image/male.png"
            Else
                Me.image.ImageUrl = chkFile
            End If

            Me.Txtname.Text = dt.Rows(0)("nname") & ""
            Me.Txtcmb1.Text = dt.Rows(0)("cmb1") & ""
            Me.Txtcmb2.Text = dt.Rows(0)("cmb2") & ""
            Me.Txtcmb3.Text = dt.Rows(0)("cmb3") & ""
            Me.Txtcmb4.Text = dt.Rows(0)("cmb4") & ""
            Me.Txtcmb5.Text = dt.Rows(0)("cmb5") & ""
            Me.Txtcmb6.Text = dt.Rows(0)("cmb6") & ""
            Me.TxtPosition.Text = dt.Rows(0)("position") & ""
        Else
            Dim chkFile = "~/Image/nopics_E.jpg"
            Me.image.ImageUrl = chkFile

            Me.Txtname.Text = ""
            Me.Txtcmb1.Text = ""
            Me.Txtcmb2.Text = ""
            Me.Txtcmb3.Text = ""
            Me.Txtcmb4.Text = ""
            Me.Txtcmb5.Text = ""
            Me.Txtcmb6.Text = ""
            Me.TxtPosition.Text = ""
        End If
    End Sub

End Class
