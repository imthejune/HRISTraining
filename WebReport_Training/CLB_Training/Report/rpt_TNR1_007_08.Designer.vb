Partial Class rpt_TNR1_007_08

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_TNR1_007_08))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.Shape3 = New Telerik.Reporting.Shape()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.lbl_Colunm1 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm9 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm8 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm7 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm6 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm4 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm5 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm3 = New Telerik.Reporting.TextBox()
        Me.lbl_Colunm2 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.lbl_Cmb2 = New Telerik.Reporting.TextBox()
        Me.lbl_Cmb1 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.lbl_Header = New Telerik.Reporting.TextBox()
        Me.lbl_PersonCode = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.lbl_Position = New Telerik.Reporting.TextBox()
        Me.lbl_PersonName = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.073R)
        Me.groupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape3})
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.PageBreak = Telerik.Reporting.PageBreak.After
        '
        'Shape3
        '
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.021R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.693R), Telerik.Reporting.Drawing.Unit.Cm(0.132R))
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.32R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_Colunm1, Me.lbl_Colunm9, Me.lbl_Colunm8, Me.lbl_Colunm7, Me.lbl_Colunm6, Me.lbl_Colunm4, Me.lbl_Colunm5, Me.lbl_Colunm3, Me.lbl_Colunm2, Me.Shape2, Me.Shape1})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'lbl_Colunm1
        '
        Me.lbl_Colunm1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm1.Name = "lbl_Colunm1"
        Me.lbl_Colunm1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm1.Style.Font.Bold = False
        Me.lbl_Colunm1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm1.Value = "รหัสหลักสูตร"
        '
        'lbl_Colunm9
        '
        Me.lbl_Colunm9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.798R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm9.Name = "lbl_Colunm9"
        Me.lbl_Colunm9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm9.Style.Font.Bold = False
        Me.lbl_Colunm9.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm9.Value = "รายละเอียด"
        '
        'lbl_Colunm8
        '
        Me.lbl_Colunm8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.965R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm8.Name = "lbl_Colunm8"
        Me.lbl_Colunm8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm8.Style.Font.Bold = False
        Me.lbl_Colunm8.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm8.Value = "วิทยากร"
        '
        'lbl_Colunm7
        '
        Me.lbl_Colunm7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.163R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm7.Name = "lbl_Colunm7"
        Me.lbl_Colunm7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm7.Style.Font.Bold = False
        Me.lbl_Colunm7.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm7.Value = "สถานที่อบรม"
        '
        'lbl_Colunm6
        '
        Me.lbl_Colunm6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.423R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm6.Name = "lbl_Colunm6"
        Me.lbl_Colunm6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm6.Style.Font.Bold = False
        Me.lbl_Colunm6.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.lbl_Colunm6.Value = "ค่าใช้จ่าย"
        '
        'lbl_Colunm4
        '
        Me.lbl_Colunm4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.798R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm4.Name = "lbl_Colunm4"
        Me.lbl_Colunm4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm4.Style.Font.Bold = False
        Me.lbl_Colunm4.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm4.Value = "วันที่สิ้นสุด"
        '
        'lbl_Colunm5
        '
        Me.lbl_Colunm5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm5.Name = "lbl_Colunm5"
        Me.lbl_Colunm5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm5.Style.Font.Bold = False
        Me.lbl_Colunm5.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.lbl_Colunm5.Value = "จำนวน ชม."
        '
        'lbl_Colunm3
        '
        Me.lbl_Colunm3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.162R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm3.Name = "lbl_Colunm3"
        Me.lbl_Colunm3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm3.Style.Font.Bold = False
        Me.lbl_Colunm3.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm3.Value = "วันที่อบรม"
        '
        'lbl_Colunm2
        '
        Me.lbl_Colunm2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.829R), Telerik.Reporting.Drawing.Unit.Inch(0.062R))
        Me.lbl_Colunm2.Name = "lbl_Colunm2"
        Me.lbl_Colunm2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Colunm2.Style.Font.Bold = False
        Me.lbl_Colunm2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Colunm2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Colunm2.Value = "ชื่อหลักสูตร"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.006R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.693R), Telerik.Reporting.Drawing.Unit.Cm(0.05R))
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.006R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.693R), Telerik.Reporting.Drawing.Unit.Cm(0.05R))
        '
        'lbl_Cmb2
        '
        Me.lbl_Cmb2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.lbl_Cmb2.Name = "lbl_Cmb2"
        Me.lbl_Cmb2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Cmb2.Style.Font.Bold = True
        Me.lbl_Cmb2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Cmb2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Cmb2.Value = "แผนก :"
        '
        'lbl_Cmb1
        '
        Me.lbl_Cmb1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.lbl_Cmb1.Name = "lbl_Cmb1"
        Me.lbl_Cmb1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Cmb1.Style.Font.Bold = True
        Me.lbl_Cmb1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Cmb1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Cmb1.Value = "ฝ่าย :"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox6.Value = "= Fields.Cmb1Name"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(1.1R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox7.Value = "= Fields.Cmb2Name"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.8R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.lbl_Header, Me.lbl_Cmb1, Me.lbl_Cmb2, Me.TextBox6, Me.TextBox7, Me.lbl_PersonCode, Me.TextBox11, Me.lbl_Position, Me.lbl_PersonName, Me.TextBox8, Me.TextBox12})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Value = "= Fields.CompanyName"
        '
        'lbl_Header
        '
        Me.lbl_Header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Header.Style.Font.Bold = True
        Me.lbl_Header.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Header.Value = "รายงานประวัติการฝึกอบรม"
        '
        'lbl_PersonCode
        '
        Me.lbl_PersonCode.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.lbl_PersonCode.Name = "lbl_PersonCode"
        Me.lbl_PersonCode.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_PersonCode.Style.Font.Bold = True
        Me.lbl_PersonCode.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_PersonCode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_PersonCode.Value = "รหัสพนักงาน :"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.14R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox11.Value = "= Fields.Fname + ' ' + Fields.Lname"
        '
        'lbl_Position
        '
        Me.lbl_Position.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.467R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.lbl_Position.Name = "lbl_Position"
        Me.lbl_Position.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_Position.Style.Font.Bold = True
        Me.lbl_Position.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Position.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Position.Value = "ตำแหน่ง :"
        '
        'lbl_PersonName
        '
        Me.lbl_PersonName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.533R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.lbl_PersonName.Name = "lbl_PersonName"
        Me.lbl_PersonName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.567R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_PersonName.Style.Font.Bold = True
        Me.lbl_PersonName.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_PersonName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_PersonName.Value = "ชื่อ-สกุล :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.14R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox8.Value = "= Fields.PersonCode"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox12.Value = "= Fields.PositionName"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.2R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox30, Me.TextBox29, Me.TextBox28, Me.TextBox27, Me.TextBox26, Me.TextBox25, Me.TextBox24, Me.TextBox23, Me.TextBox22})
        Me.detail.Name = "detail"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.798R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox30.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox30.Value = "= Fields.TrainDay_Note"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.965R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.74R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox29.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox29.Value = "= Fields.Professor_Name"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.163R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox28.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox28.Value = "= Fields.OrganizeName"
        '
        'TextBox27
        '
        Me.TextBox27.Format = "{0:N2}"
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.423R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox27.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.Value = "= Fields.b18"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox26.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox26.Value = "= (Fields.TrainDay_TotalHour / 60) + "":"" + (Fields.TrainDay_TotalHour Mod 60)"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.965R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox25.Value = "=dateFormat(Fields.TrainDay_Date, Fields.lang)"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.798R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox24.Value = "=dateFormat(Fields.TrainDay_End, Fields.lang)"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.829R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.974R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox23.Value = "= Fields.RefName"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox22.Value = "= Fields.Patern_Code"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "CLB_Training.My.MySettings.testDatabase5"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_TNR1_007_08
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PersonCode"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detail})
        Me.Name = "rpt_TNR1_007_08"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.556R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Cmb1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Header As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Cmb2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents lbl_Colunm1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm9 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm8 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm7 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm6 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm4 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm5 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm3 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Colunm2 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents lbl_PersonCode As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Position As Telerik.Reporting.TextBox
    Friend WithEvents lbl_PersonName As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
End Class