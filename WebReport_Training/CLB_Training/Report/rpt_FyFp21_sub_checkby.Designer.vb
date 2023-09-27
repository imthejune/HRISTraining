Partial Class rpt_FyFp21_sub_checkby

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_FyFp21_sub_checkby))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Shape10 = New Telerik.Reporting.Shape()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.lbl_Position = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        Me.detail.DocumentMapText = ""
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.81166666746139526R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape10, Me.TextBox2, Me.lbl_Position, Me.Shape1, Me.TextBox3, Me.TextBox11, Me.TextBox4, Me.TextBox5})
        Me.detail.KeepTogether = False
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = True
        '
        'Shape10
        '
        Me.Shape10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4517993927001953R), Telerik.Reporting.Drawing.Unit.Cm(0.5379863977432251R))
        Me.Shape10.Name = "Shape10"
        Me.Shape10.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.3366308212280273R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape10.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'TextBox2
        '
        Me.TextBox2.Format = "{0}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.65321236848831177R), Telerik.Reporting.Drawing.Unit.Inch(0.038194440305233R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.34950515627861023R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "= Fields.Patern_N"
        '
        'lbl_Position
        '
        Me.lbl_Position.Format = "{0}"
        Me.lbl_Position.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2916667461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.038194440305233R))
        Me.lbl_Position.Name = "lbl_Position"
        Me.lbl_Position.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_Position.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Position.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Position.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Position.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Position.Value = "ตำแหน่ง"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.9086523056030273R), Telerik.Reporting.Drawing.Unit.Cm(0.52034711837768555R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.0642352104187012R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'TextBox3
        '
        Me.TextBox3.Format = "{0}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.578125R), Telerik.Reporting.Drawing.Unit.Inch(0.027777768671512604R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.34950515627861023R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.TextBox3.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "("
        '
        'TextBox11
        '
        Me.TextBox11.Format = "{0}"
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.73958331346511841R), Telerik.Reporting.Drawing.Unit.Inch(0.027777768671512604R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.34950515627861023R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.TextBox11.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = ")"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.6919441223144531R), Telerik.Reporting.Drawing.Unit.Cm(0.15875016152858734R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.84125018119812R), Telerik.Reporting.Drawing.Unit.Cm(0.47652775049209595R))
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox4.Value = "= Fields.Professor_Name"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.650485992431641R), Telerik.Reporting.Drawing.Unit.Cm(0.15875016152858734R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.84125018119812R), Telerik.Reporting.Drawing.Unit.Cm(0.47652775049209595R))
        Me.TextBox5.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox5.Value = "= Fields.Professor_Position"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-UVBOUBQ\SQLEXPRESS;Initial Catalog=dbTraining;Integrated Secu" & _
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@GUID_Ref", System.Data.DbType.[String], "= Parameters.GUID_Ref.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_FyFp21_sub_checkby
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_FyFp21_sub_checkby"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "GUID_Ref"
        Me.ReportParameters.Add(ReportParameter1)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(17.415384292602539R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents Shape10 As Telerik.Reporting.Shape
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Position As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
End Class