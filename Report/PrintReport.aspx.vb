Imports System.Data

Partial Class Report_PrintReport
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Dim menuId As String = Request.QueryString("menuId") & ""
            ' ReportViewer1.ReportSource = Session("PrintReport")
            ReportViewer1.Dispose()
            ReportViewer1.ReportSource = CType(Session("PrintReport" & menuId), Telerik.Reporting.Report)
            ReportViewer1.RefreshReport()

            '== 20150508 Na เช็คสิทธิ์ปุ่มพิมพ์ ที่ตั้งค่าจาก Company >> กำหนดสิทธิ์การใช้ระบบ >> เมนูรายงาน
            Call ckReport(Me.ReportViewer1, Session("MenuReport"), "P")

            '== 20150508 Na เช็คสิทธิ์ปุ่มส่งออกข้อมูล ที่ตั้งค่าจาก Company >> กำหนดสิทธิ์การใช้ระบบ >> เมนูรายงาน
            Call ckReport(Me.ReportViewer1, Session("MenuReport"), "E")



        End If

    End Sub

End Class
