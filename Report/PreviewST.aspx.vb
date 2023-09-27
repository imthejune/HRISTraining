Imports Telerik.Web.UI
Imports System.Data
Partial Class PreviewST
    Inherits BasePage
    Dim dt As New DataTable()
    Dim da As New Mydata(adoconn)
    Dim cExecute As New connExecute
    Dim id_GUID As String
    Dim dra() As DataRow
    Dim FormName As String = "PreviewST"
    Property ProgramCode As String
        Get
            If ViewState("ProgramCode") Is Nothing Then
                Return Nothing
            End If
            Return ViewState("ProgramCode")
        End Get

        Set(ByVal Value As String)
            ViewState("ProgramCode") = Value
        End Set
    End Property
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' LoadTitle()
        If Not Page.IsPostBack Then
            Me.Title = "พิมพ์"
            '================ เก็บ Log ====================='
            InsertLogMenu("TN", FormName, "M", Sys.LoginWeb.UserName)
            '=============================================='

            Call Lang()
            Call LoadData(Request.QueryString("id") & "")
            Call ChkMenu()
            Me.HiddenField1.Value = Request.QueryString("id").ToString()
        Else

        End If
    End Sub
    Public Sub ChkMenu() 'กำหนดสิทธ์
        Dim dtCkMeun As DataTable = HttpContext.Current.Session("dtCkMenuPerson")
        Dim ndr() As DataRow
        If dtCkMeun.Rows.Count > 0 Then
            ndr = dtCkMeun.Select(" Menu_Code = '" & ProgramCode & "' ")
            If ndr.Count > 0 Then


            End If
        End If
    End Sub

    Sub LoadTitle()
        TMsg.LoadTitle("PreviewST", "Form", Sys.Lang)
        If TMsg.dT_Title.Rows.Count > 0 Then
            Me.Title = Sys.TMsg.Title_Text("PreviewST")
            Me.ProgramCode = Sys.TMsg.Program_Code("PreviewST")
            Sys.LoginWeb.MenuCode = ProgramCode
        End If
    End Sub
    Sub Lang()  'เปลี่ยนภาษา
        If Sys.LoginWeb.Lang <> "T" Then
            TMsg.LoadLang("PreviewST", Sys.Lang) ' โหลดภาษา และเปลี่ยนภาษา
            If TMsg.dT_Lang.Rows.Count > 0 Then
                Me.Title = Sys.TMsg.Label_Text("lblPrint")
                Me.Label1.Text = Sys.TMsg.Label_Text("lblHead")
                Me.lblYear.Text = Sys.TMsg.Label_Text("lblYear")
                Me.Label5.Text = Sys.TMsg.Label_Text("lblHead1")
                Me.Label32.Text = Sys.TMsg.Label_Text("lblHead2")
                Me.Label41.Text = Sys.TMsg.Label_Text("lblYearTrain")
                Me.Label38.Text = Sys.TMsg.Label_Text("lblLabel38")
                Me.Label59.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label3.Text = Sys.TMsg.Label_Text("lblLabel3")
                Me.Label6.Text = Sys.TMsg.Label_Text("lblMonth")
                Me.Label7.Text = Sys.TMsg.Label_Text("lblLabel7")
                Me.Label9.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label10.Text = Sys.TMsg.Label_Text("lblLabel10")
                Me.Label14.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label15.Text = Sys.TMsg.Label_Text("lblLabel15")
                Me.Label17.Text = Sys.TMsg.Label_Text("lblCourse")
                Me.Label18.Text = Sys.TMsg.Label_Text("lblLabel18")
                Me.Label20.Text = Sys.TMsg.Label_Text("lblPerson")
                'Me.Label21.Text = Sys.TMsg.Label_Text("lblLabel21")
                'Me.Label23.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label24.Text = Sys.TMsg.Label_Text("lblLabel24")
                Me.Label26.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label27.Text = Sys.TMsg.Label_Text("lblLabel27")
                Me.Label29.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label40.Text = Sys.TMsg.Label_Text("lblYearExpense")
                Me.Label48.Text = Sys.TMsg.Label_Text("lblLabel48")
                Me.Label46.Text = Sys.TMsg.Label_Text("lblBath")
                Me.Label30.Text = Sys.TMsg.Label_Text("lblLabel30")
                Me.Label50.Text = Sys.TMsg.Label_Text("lblBath")
                Me.Label31.Text = Sys.TMsg.Label_Text("lblLabel31")
                Me.Label53.Text = Sys.TMsg.Label_Text("lblBath")
                Me.Label33.Text = Sys.TMsg.Label_Text("lblCompany")
                Me.Label37.Text = Sys.TMsg.Label_Text("lblAddress")
                Me.Label81.Text = Sys.TMsg.Label_Text("lblLabel81")
                Me.Label83.Text = Sys.TMsg.Label_Text("lblM1")
                Me.Label85.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label43.Text = Sys.TMsg.Label_Text("lblM2")
                Me.Label47.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label51.Text = Sys.TMsg.Label_Text("lblM3")
                Me.Label55.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label56.Text = Sys.TMsg.Label_Text("lblM4")
                Me.Label60.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label61.Text = Sys.TMsg.Label_Text("lblM5")
                Me.Label63.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label64.Text = Sys.TMsg.Label_Text("lblM6")
                Me.Label66.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label67.Text = Sys.TMsg.Label_Text("lblM7")
                Me.Label69.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label70.Text = Sys.TMsg.Label_Text("lblM8")
                Me.Label72.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label73.Text = Sys.TMsg.Label_Text("lblM9")
                Me.Label75.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label12.Text = Sys.TMsg.Label_Text("lblM10")
                Me.Label34.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label35.Text = Sys.TMsg.Label_Text("lblM11")
                Me.Label77.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.Label78.Text = Sys.TMsg.Label_Text("lblM12")
                Me.Label80.Text = Sys.TMsg.Label_Text("lblPerson")
                Me.lblGroup1.Text = Sys.TMsg.Label_Text("lblGroup1")
                Me.lnkDetail.Text = Sys.TMsg.Label_Text("lblDetail")
                Me.LinkButton1.Text = Sys.TMsg.Label_Text("lblDetail2")
                Me.chk21.Text = Sys.TMsg.Label_Text("lblDetail21")
                Me.chk22.Text = Sys.TMsg.Label_Text("lblDetail22")

            End If
        End If
    End Sub

    Sub LoadData(id As String)  'โหลดข้อมูลวิทยากร
        Try

            sqlstr = "select * from TNT_ProcessSt where GUID_st = '" & id & "'"
            sqlstr = String.Format(sqlstr, Sys.LoginWeb.Lang)
            dt = da.GetDataTable(sqlstr)
            Call bindText()
        Catch ex As Exception
            xMessageBoxRWM(RadWindowManager1, 300, 120, ex.Message, Sys.TMsg.Warning)
        End Try
    End Sub
    Sub bindText()
        If Sys.LoginWeb.Lang = "T" Then
            Me.Label2.Text = dt(0)("ProcessYear") + 543
        Else
            Me.Label2.Text = dt(0)("ProcessYear").ToString()
        End If

        Me.Label36.Text = dt(0)("CompanyName").ToString()
        Me.Label58.Text = dt(0)("TotalEmp").ToString()
        Me.Label4.Text = dt(0)("TotalMonth").ToString()
        Me.Label8.Text = dt(0)("EmpAvg").ToString()
        Me.Label11.Text = dt(0)("Emp50").ToString()
        Me.Label16.Text = dt(0)("ApproveCourse").ToString()
        Me.Label19.Text = dt(0)("TrainPerson").ToString()
        Me.Label25.Text = dt(0)("ImproveSkill").ToString()
        Me.Label28.Text = dt(0)("ChangeCareer").ToString()
        Me.Label45.Text = dt(0)("MoneyFund").ToString()
        Me.Label49.Text = dt(0)("MoneyExtra").ToString()
        Me.Label52.Text = dt(0)("MoneyTotal").ToString()
        Me.Label39.Text = dt(0)("CompanyAdd") + " ซอย " + dt(0)("CompanySoi") + " ถนน " + dt(0)("CompanyStreet") + " ตำบล/แขวง" + dt(0)("CompanyDistrict") + " อำเภอ/เขต" + dt(0)("CompanyAmphur")
        Me.Label39.Text += " จังหวัด" + dt(0)("CompanyProvince") + " " + dt(0)("CompanyPostalCode")

        Me.Label84.Text = dt(0)("m1").ToString()
        Me.Label44.Text = dt(0)("m2").ToString()
        Me.Label54.Text = dt(0)("m3").ToString()
        Me.Label57.Text = dt(0)("m4").ToString()
        Me.Label62.Text = dt(0)("m5").ToString()
        Me.Label65.Text = dt(0)("m6").ToString()
        Me.Label68.Text = dt(0)("m7").ToString()
        Me.Label71.Text = dt(0)("m8").ToString()
        Me.Label74.Text = dt(0)("m9").ToString()
        Me.Label13.Text = dt(0)("m10").ToString()
        Me.Label76.Text = dt(0)("m11").ToString()
        Me.Label79.Text = dt(0)("m12").ToString()

    End Sub
    Protected Sub lnkDetail_Click(sender As Object, e As EventArgs) Handles lnkDetail.Click
        Try
            xMessageBoxRWM_บันทึกสำเร็จ(RadWindowManager1)



        Catch ex As Exception
            xMessageBoxRWM(RadWindowManager1, 300, 120, ex.Message, Sys.TMsg.Warning)
        End Try
    End Sub
End Class
