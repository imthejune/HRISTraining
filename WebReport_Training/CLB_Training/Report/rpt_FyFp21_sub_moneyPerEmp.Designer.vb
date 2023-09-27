Partial Class rpt_FyFp21_sub_moneyPerEmp

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.lbl_N = New Telerik.Reporting.TextBox()
        Me.txtN = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.lbl_BathperEmp = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.873125433921814R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        Me.detail.DocumentMapText = ""
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.62958353757858276R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_N, Me.txtN, Me.Shape1, Me.TextBox3, Me.lbl_BathperEmp})
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = True
        '
        'lbl_N
        '
        Me.lbl_N.Format = "{0}"
        Me.lbl_N.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.52430582046508789R), Telerik.Reporting.Drawing.Unit.Inch(0.0000000521540641784668R))
        Me.lbl_N.Name = "lbl_N"
        Me.lbl_N.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47624126076698303R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_N.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_N.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_N.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_N.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_N.Value = "รุ่นที่"
        '
        'txtN
        '
        Me.txtN.Format = "{0}"
        Me.txtN.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2135417461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.28179681301116943R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.txtN.Style.Font.Name = "BrowalliaUPC"
        Me.txtN.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.txtN.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.txtN.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtN.Value = "= Fields.Patern_N"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9114232063293457R), Telerik.Reporting.Drawing.Unit.Cm(0.46743068099021912R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.488957405090332R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'TextBox3
        '
        Me.TextBox3.Format = "{0:N2}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.2465629577636719R), Telerik.Reporting.Drawing.Unit.Cm(0.026458332315087318R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1421170234680176R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox3.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= Fields.b18"
        '
        'lbl_BathperEmp
        '
        Me.lbl_BathperEmp.Format = "{0}"
        Me.lbl_BathperEmp.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.3420138359069824R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.lbl_BathperEmp.Name = "lbl_BathperEmp"
        Me.lbl_BathperEmp.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.58040791749954224R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_BathperEmp.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_BathperEmp.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_BathperEmp.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_BathperEmp.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_BathperEmp.Value = "บาท/คน"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.90595149993896484R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-UVBOUBQ\SQLEXPRESS;Initial Catalog=dbTraining;Integrated Secu" & _
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@GUID_Ref", System.Data.DbType.[String], "= Parameters.GUID_Ref.Value"), New Telerik.Reporting.SqlDataSourceParameter("@GUID_Fyfp", System.Data.DbType.[String], "= Parameters.GUID_Fyfp.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "SELECT Patern_N,b18 from TNT_SubFyfp " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where CONVERT(VARCHAR(50),GUID_Ref)= CONVE" & _
    "RT(VARCHAR(50),@GUID_Ref)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and CONVERT(VARCHAR(50),GUID_fyfp)= CONVERT(VARCHAR(5" & _
    "0),@GUID_Fyfp)"
        '
        'rpt_FyFp21_sub_moneyPerEmp
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_FyFp21_sub_moneyPerEmp"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "GUID_Ref"
        ReportParameter2.Name = "GUID_Fyfp"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(11.341666221618652R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents txtN As Telerik.Reporting.TextBox
    Friend WithEvents lbl_N As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_BathperEmp As Telerik.Reporting.TextBox
End Class