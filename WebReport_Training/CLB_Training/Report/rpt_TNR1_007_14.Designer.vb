Partial Class rpt_TNR1_007_14

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_TNR1_007_14))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Shape13 = New Telerik.Reporting.Shape()
        Me.Shape14 = New Telerik.Reporting.Shape()
        Me.Shape15 = New Telerik.Reporting.Shape()
        Me.Shape16 = New Telerik.Reporting.Shape()
        Me.Shape17 = New Telerik.Reporting.Shape()
        Me.Shape18 = New Telerik.Reporting.Shape()
        Me.Shape19 = New Telerik.Reporting.Shape()
        Me.Shape20 = New Telerik.Reporting.Shape()
        Me.Shape21 = New Telerik.Reporting.Shape()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.Shape22 = New Telerik.Reporting.Shape()
        Me.Shape23 = New Telerik.Reporting.Shape()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.Shape12 = New Telerik.Reporting.Shape()
        Me.Shape11 = New Telerik.Reporting.Shape()
        Me.Shape10 = New Telerik.Reporting.Shape()
        Me.Shape9 = New Telerik.Reporting.Shape()
        Me.Shape8 = New Telerik.Reporting.Shape()
        Me.Shape7 = New Telerik.Reporting.Shape()
        Me.Shape6 = New Telerik.Reporting.Shape()
        Me.Shape5 = New Telerik.Reporting.Shape()
        Me.Shape4 = New Telerik.Reporting.Shape()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.Shape3 = New Telerik.Reporting.Shape()
        Me.Shape1 = New Telerik.Reporting.Shape()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.PageBreak = Telerik.Reporting.PageBreak.None
        Me.groupFooterSection.Style.Visible = True
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox22, Me.TextBox23})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        Me.groupHeaderSection.PageBreak = Telerik.Reporting.PageBreak.Before
        Me.groupHeaderSection.Style.Visible = False
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.104R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.052R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox22.Value = "= Fields.Cmb2Name"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.156R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.852R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox23.Value = "= Fields.PersonCode"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(1.354R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.9R), Telerik.Reporting.Drawing.Unit.Cm(0.05R))
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.552R), Telerik.Reporting.Drawing.Unit.Inch(0.24R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Value = "= Fields.CompanyName"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1R), Telerik.Reporting.Drawing.Unit.Inch(0.512R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox2.Value = "รายงานสรุปจำนวนชั่วโมงรายบุคคล"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.3R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape13, Me.Shape14, Me.Shape15, Me.Shape16, Me.Shape17, Me.Shape18, Me.Shape19, Me.Shape20, Me.Shape21, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.Shape22, Me.Shape23})
        Me.detail.Name = "detail"
        Me.detail.PageBreak = Telerik.Reporting.PageBreak.None
        Me.detail.Style.Visible = True
        '
        'Shape13
        '
        Me.Shape13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.968R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape13.Name = "Shape13"
        Me.Shape13.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape14
        '
        Me.Shape14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.104R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape14.Name = "Shape14"
        Me.Shape14.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape15
        '
        Me.Shape15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.2R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape15.Name = "Shape15"
        Me.Shape15.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape16
        '
        Me.Shape16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape16.Name = "Shape16"
        Me.Shape16.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape17
        '
        Me.Shape17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.104R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape17.Name = "Shape17"
        Me.Shape17.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape18
        '
        Me.Shape18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape18.Name = "Shape18"
        Me.Shape18.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape19
        '
        Me.Shape19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.041R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape19.Name = "Shape19"
        Me.Shape19.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape20
        '
        Me.Shape20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.104R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape20.Name = "Shape20"
        Me.Shape20.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape21
        '
        Me.Shape21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.802R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape21.Name = "Shape21"
        Me.Shape21.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.302R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox12.Value = "= (Fields.TrainDay_TotalHour  / 60) + '.' + (Fields.TrainDay_TotalHour  Mod 60)"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.51R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox13.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox13.Value = "0.00"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.406R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox14.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox14.Value = "= IIf(Fields.Type_CourseID = 2,((Fields.TrainDay_TotalHour  / 60) + '.' + (Fields" &
    ".TrainDay_TotalHour  Mod 60)), 0.00 )"
        '
        'TextBox15
        '
        Me.TextBox15.Format = "{0}"
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.302R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox15.Value = "= IIf(Fields.Type_CourseID = 1,((Fields.TrainDay_TotalHour  / 60) + '.' + (Fields" &
    ".TrainDay_TotalHour  Mod 60)), 0.00 )"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.302R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox16.Value = "=dateFormat(Fields.StartDate, Fields.Lang)"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.01R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox17.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox17.Value = "= Fields.PositionName"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.104R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox18.Value = "= Fields.Fname + ' ' + Fields.Lname"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.208R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox19.Value = "= Fields.PersonCode"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.93R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox20.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox20.Value = "= Fields.Cmb2Name"
        '
        'Shape22
        '
        Me.Shape22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.083R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape22.Name = "Shape22"
        Me.Shape22.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape23
        '
        Me.Shape23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0.28R))
        Me.Shape23.Name = "Shape23"
        Me.Shape23.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.9R), Telerik.Reporting.Drawing.Unit.Cm(0.05R))
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11521\SQLEXPRESS;Initial Catalog=HRISTraining;User ID=sa;Password=t" &
    "iger"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.428R)
        Me.PageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox7, Me.Shape12, Me.Shape11, Me.Shape10, Me.Shape9, Me.Shape8, Me.Shape7, Me.Shape6, Me.Shape5, Me.Shape4, Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox8, Me.Shape2, Me.TextBox6, Me.TextBox5, Me.TextBox4, Me.TextBox3, Me.Shape3, Me.Shape1})
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.304R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox7.Value = "วันที่เริ่มงาน"
        '
        'Shape12
        '
        Me.Shape12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.968R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape12.Name = "Shape12"
        Me.Shape12.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape11
        '
        Me.Shape11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.104R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape11.Name = "Shape11"
        Me.Shape11.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape10
        '
        Me.Shape10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.2R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape10.Name = "Shape10"
        Me.Shape10.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape9
        '
        Me.Shape9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape9.Name = "Shape9"
        Me.Shape9.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape8
        '
        Me.Shape8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.104R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape8.Name = "Shape8"
        Me.Shape8.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape7
        '
        Me.Shape7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape7.Name = "Shape7"
        Me.Shape7.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape6
        '
        Me.Shape6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.041R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape6.Name = "Shape6"
        Me.Shape6.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape5
        '
        Me.Shape5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.104R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape5.Name = "Shape5"
        Me.Shape5.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape4
        '
        Me.Shape4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.802R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape4.Name = "Shape4"
        Me.Shape4.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.304R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox11.Value = "รวม"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.504R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox10.Value = "OJT"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.404R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox9.Value = "อบรมภายนอก"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.304R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox8.Value = "อบรมภายใน"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.004R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox6.Value = "ตำแหน่ง"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.104R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox5.Value = "ชื่อ-นามสกุล"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.204R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox4.Value = "รหัสพนักงาน"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.304R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox3.Value = "แผนก"
        '
        'Shape3
        '
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.083R), Telerik.Reporting.Drawing.Unit.Inch(1.054R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.104R), Telerik.Reporting.Drawing.Unit.Inch(1.037R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.9R), Telerik.Reporting.Drawing.Unit.Cm(0.05R))
        '
        'rpt_TNR1_007_14
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Cmb2Code"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.detail, Me.pageFooterSection1, Me.PageHeaderSection1})
        Me.Name = "rpt_TNR1_007_14"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(28.231R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents Shape13 As Telerik.Reporting.Shape
    Friend WithEvents Shape14 As Telerik.Reporting.Shape
    Friend WithEvents Shape15 As Telerik.Reporting.Shape
    Friend WithEvents Shape16 As Telerik.Reporting.Shape
    Friend WithEvents Shape17 As Telerik.Reporting.Shape
    Friend WithEvents Shape18 As Telerik.Reporting.Shape
    Friend WithEvents Shape19 As Telerik.Reporting.Shape
    Friend WithEvents Shape20 As Telerik.Reporting.Shape
    Friend WithEvents Shape21 As Telerik.Reporting.Shape
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents Shape22 As Telerik.Reporting.Shape
    Friend WithEvents Shape23 As Telerik.Reporting.Shape
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents Shape4 As Telerik.Reporting.Shape
    Friend WithEvents Shape5 As Telerik.Reporting.Shape
    Friend WithEvents Shape6 As Telerik.Reporting.Shape
    Friend WithEvents Shape7 As Telerik.Reporting.Shape
    Friend WithEvents Shape8 As Telerik.Reporting.Shape
    Friend WithEvents Shape9 As Telerik.Reporting.Shape
    Friend WithEvents Shape10 As Telerik.Reporting.Shape
    Friend WithEvents Shape11 As Telerik.Reporting.Shape
    Friend WithEvents Shape12 As Telerik.Reporting.Shape
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
End Class