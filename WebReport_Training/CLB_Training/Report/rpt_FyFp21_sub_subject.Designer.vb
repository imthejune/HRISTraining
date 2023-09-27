Partial Class rpt_FyFp21_sub_subject

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_FyFp21_sub_subject))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.lbl_num = New Telerik.Reporting.TextBox()
        Me.Shape10 = New Telerik.Reporting.Shape()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.lbl_Header = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.lbl_Time = New Telerik.Reporting.TextBox()
        Me.lbl_Hour = New Telerik.Reporting.TextBox()
        Me.lbl_Detail = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
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
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.5644444227218628R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_num, Me.Shape10, Me.TextBox2, Me.lbl_Header, Me.Shape1, Me.TextBox8, Me.Shape2, Me.lbl_Time, Me.lbl_Hour, Me.lbl_Detail, Me.TextBox1, Me.TextBox4})
        Me.detail.KeepTogether = False
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = True
        '
        'lbl_num
        '
        Me.lbl_num.Format = "{0}"
        Me.lbl_num.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.083333194255828857R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.50922739505767822R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.lbl_num.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_num.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_num.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_num.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_num.Value = "หัวข้อที่"
        '
        'Shape10
        '
        Me.Shape10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.3758219480514526R), Telerik.Reporting.Drawing.Unit.Cm(0.44097241759300232R))
        Me.Shape10.Name = "Shape10"
        Me.Shape10.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5609021186828613R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape10.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'TextBox2
        '
        Me.TextBox2.Format = "{0}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.65321236848831177R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.34950515627861023R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "= IIf(Fields.Vt_N = Null, ""1"",Fields.Vt_N)"
        '
        'lbl_Header
        '
        Me.lbl_Header.Format = "{0}"
        Me.lbl_Header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0920119285583496R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.lbl_Header.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Header.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Header.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Header.Value = "หัวข้อวิชา"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.6037664413452148R), Telerik.Reporting.Drawing.Unit.Cm(0.42333337664604187R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5360755920410156R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.599582672119141R), Telerik.Reporting.Drawing.Unit.Cm(-0.0000000013141996380028331R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2977499961853027R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox8.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "= Fields.Vt_Hour"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.599582672119141R), Telerik.Reporting.Drawing.Unit.Cm(0.39687502384185791R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3017354011535645R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape2.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'lbl_Time
        '
        Me.lbl_Time.Format = "{0}"
        Me.lbl_Time.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.671875R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.lbl_Time.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Time.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Time.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Time.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Time.Value = "ระยะเวลา"
        '
        'lbl_Hour
        '
        Me.lbl_Hour.Format = "{0}"
        Me.lbl_Hour.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1770834922790527R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Hour.Name = "lbl_Hour"
        Me.lbl_Hour.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.55436629056930542R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.lbl_Hour.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Hour.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Hour.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Hour.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Hour.Value = "ชั่วโมง"
        '
        'lbl_Detail
        '
        Me.lbl_Detail.Format = "{0}"
        Me.lbl_Detail.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1180555820465088R), Telerik.Reporting.Drawing.Unit.Inch(0.23958329856395721R))
        Me.lbl_Detail.Name = "lbl_Detail"
        Me.lbl_Detail.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.lbl_Detail.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Detail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Detail.Value = "เนื้อหาวิชา"
        '
        'TextBox1
        '
        Me.TextBox1.Format = "{0}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.6037497520446777R), Telerik.Reporting.Drawing.Unit.Cm(-0.0000000013141996380028331R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.1484441757202148R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox1.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.Vt_Header"
        '
        'TextBox4
        '
        Me.TextBox4.Format = "{0}"
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.6037497520446777R), Telerik.Reporting.Drawing.Unit.Cm(0.60854160785675049R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.1484441757202148R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "= Fields.Vt_Name"
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
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@GUID_Ref", System.Data.DbType.[String], "= Parameters.GUID_Ref.Value"), New Telerik.Reporting.SqlDataSourceParameter("@GUID_Fyfp", System.Data.DbType.[String], "= Parameters.GUID_Fyfp.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_FyFp21_sub_subject
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_FyFp21_sub_subject"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(17.415384292602539R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents lbl_num As Telerik.Reporting.TextBox
    Friend WithEvents Shape10 As Telerik.Reporting.Shape
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Header As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents lbl_Time As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Hour As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Detail As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
End Class