Partial Class rpt_TNR1_006_03

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_TNR1_006_03))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.Rpt_sub_professor1 = New CLB_Training.rpt_sub_professor()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.rpt_sub_professor = New Telerik.Reporting.SubReport()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.lbl_1 = New Telerik.Reporting.TextBox()
        Me.TextBox58 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox57 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me.Rpt_sub_professor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Rpt_sub_professor1
        '
        Me.Rpt_sub_professor1.Name = "rpt_sub_professor"
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.Visible = False
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.3R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox7, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox2, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.344R), Telerik.Reporting.Drawing.Unit.Inch(0.573R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox7.Value = "จำนวนหลักสูตรที่ดำเนินการฝึกอบรมเอง"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.042R), Telerik.Reporting.Drawing.Unit.Inch(0.219R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox3.Value = "เดือน"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.438R), Telerik.Reporting.Drawing.Unit.Inch(0.219R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox4.Value = "ปี"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.542R), Telerik.Reporting.Drawing.Unit.Inch(0.219R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox5.Value = "=GetMonth(Fields.MONTH_PaterbDate, 'T')"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.677R), Telerik.Reporting.Drawing.Unit.Inch(0.219R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.308R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox2.Value = "รายงานหลักสตูรการอบรมแบบสรุปจำนวนพนักงาน"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.344R), Telerik.Reporting.Drawing.Unit.Inch(0.875R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox8.Value = "จำนวนหลักสูตรที่ส่งไปรับการฝึกภายนอก"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.885R), Telerik.Reporting.Drawing.Unit.Inch(0.573R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox9.Value = "inHouse"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.885R), Telerik.Reporting.Drawing.Unit.Inch(0.875R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox10.Value = "Public"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.844R), Telerik.Reporting.Drawing.Unit.Inch(0.573R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox11.Value = "หลักสูตร"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.844R), Telerik.Reporting.Drawing.Unit.Inch(0.875R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox12.Value = "หลักสูตร"
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.groupFooterSection1.Name = "groupFooterSection1"
        Me.groupFooterSection1.Style.Visible = False
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1R)
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        Me.groupHeaderSection1.Style.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.6R), Telerik.Reporting.Drawing.Unit.Inch(0.067R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.26R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox6.Value = "= Fields.Patern_N"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(5.667R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.rpt_sub_professor, Me.Shape1, Me.lbl_1, Me.TextBox58, Me.TextBox55, Me.TextBox56, Me.TextBox51, Me.TextBox57, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox25, Me.TextBox36, Me.TextBox37, Me.TextBox38, Me.TextBox28, Me.TextBox26, Me.TextBox29, Me.TextBox27, Me.TextBox31, Me.TextBox30, Me.TextBox32, Me.TextBox33, Me.TextBox35, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.Panel1})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.Visible = True
        '
        'rpt_sub_professor
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Fields.GUID_Patern", Telerik.Reporting.FilterOperator.Equal, ""))
        Me.rpt_sub_professor.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.rpt_sub_professor.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.319R), Telerik.Reporting.Drawing.Unit.Inch(3.167R))
        Me.rpt_sub_professor.Name = "rpt_sub_professor"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("GUID_Patern", "= Fields.GUID_Patern"))
        InstanceReportSource1.ReportDocument = Me.Rpt_sub_professor1
        Me.rpt_sub_professor.ReportSource = InstanceReportSource1
        Me.rpt_sub_professor.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.826R), Telerik.Reporting.Drawing.Unit.Inch(0.573R))
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(2.844R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9R), Telerik.Reporting.Drawing.Unit.Cm(0.132R))
        Me.Shape1.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed
        '
        'lbl_1
        '
        Me.lbl_1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.319R), Telerik.Reporting.Drawing.Unit.Inch(3.967R))
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_1.Value = "รวมพนักงานที่อบรม"
        '
        'TextBox58
        '
        Me.TextBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.173R), Telerik.Reporting.Drawing.Unit.Inch(4.269R))
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox58.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox58.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox58.Value = "บาท"
        '
        'TextBox55
        '
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.319R), Telerik.Reporting.Drawing.Unit.Inch(4.56R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox55.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox55.Value = "จำนวนชั่วโมง"
        '
        'TextBox56
        '
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.319R), Telerik.Reporting.Drawing.Unit.Inch(4.269R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox56.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox56.Value = "รวมค่าใช้จ่ายทั้งหมด"
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.173R), Telerik.Reporting.Drawing.Unit.Inch(4.56R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox51.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox51.Value = "ชม."
        '
        'TextBox57
        '
        Me.TextBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.173R), Telerik.Reporting.Drawing.Unit.Inch(3.967R))
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox57.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox57.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox57.Value = "คน"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.831R), Telerik.Reporting.Drawing.Unit.Inch(0.669R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox18.Value = "วันที่อบรม"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.831R), Telerik.Reporting.Drawing.Unit.Inch(0.971R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox19.Value = "เวลา"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.831R), Telerik.Reporting.Drawing.Unit.Inch(1.273R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox20.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox20.Value = "สถานที่"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.831R), Telerik.Reporting.Drawing.Unit.Inch(1.565R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox21.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox21.Value = "หน่วยงานที่จัดอบรม"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.831R), Telerik.Reporting.Drawing.Unit.Inch(1.867R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox22.Value = "ค่าใช้จ่ายหลักสูตร/คน"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.831R), Telerik.Reporting.Drawing.Unit.Inch(2.169R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox23.Value = "Type of Training"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.831R), Telerik.Reporting.Drawing.Unit.Inch(2.471R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox24.Value = "Type of Training"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.423R), Telerik.Reporting.Drawing.Unit.Inch(3.167R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox25.Value = "ชื่อวิทยากร"
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.373R), Telerik.Reporting.Drawing.Unit.Inch(0.669R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox36.Value = "ถึง"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.373R), Telerik.Reporting.Drawing.Unit.Inch(0.971R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox37.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox37.Value = "ถึง"
        '
        'TextBox38
        '
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.217R), Telerik.Reporting.Drawing.Unit.Inch(1.867R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.448R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox38.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox38.Value = "บาท"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.717R), Telerik.Reporting.Drawing.Unit.Inch(0.669R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox28.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox28.Value = "=dateFormat(Fields.Patern_End, 'T')"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.31R), Telerik.Reporting.Drawing.Unit.Inch(0.669R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.992R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox26.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox26.Value = "=dateFormat(Fields.Patern_Date, 'T')"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.717R), Telerik.Reporting.Drawing.Unit.Inch(0.971R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox29.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox29.Value = "=dateFormat2(Fields.TrainDay_EndTime, 'T')"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.31R), Telerik.Reporting.Drawing.Unit.Inch(0.971R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.992R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox27.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox27.Value = "=dateFormat2(Fields.TrainDay_Time, 'T')"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.31R), Telerik.Reporting.Drawing.Unit.Inch(1.273R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox31.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox31.Value = "= Fields.InstitueTrainName"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.31R), Telerik.Reporting.Drawing.Unit.Inch(1.565R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox30.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox30.Value = "= Fields.OrganizeName"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.31R), Telerik.Reporting.Drawing.Unit.Inch(2.169R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox32.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox32.Value = "= Fields.TypeCourseName"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.31R), Telerik.Reporting.Drawing.Unit.Inch(2.471R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox33.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox33.Value = "= Fields.TypePaternName"
        '
        'TextBox35
        '
        Me.TextBox35.Format = "{0:N2}"
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.215R), Telerik.Reporting.Drawing.Unit.Inch(4.269R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.776R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox35.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox35.Value = "= Fields.Budget"
        '
        'TextBox40
        '
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.965R), Telerik.Reporting.Drawing.Unit.Inch(4.571R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.033R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox40.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox40.Value = "= Fields.TotalHour"
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.808R), Telerik.Reporting.Drawing.Unit.Inch(3.967R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.18R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox41.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox41.Value = "= Fields.CountPerson"
        '
        'TextBox42
        '
        Me.TextBox42.Format = "{0:N2}"
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.31R), Telerik.Reporting.Drawing.Unit.Inch(1.867R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.874R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox42.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox42.Value = "= Fields.BudgetPerson"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.373R), Telerik.Reporting.Drawing.Unit.Inch(0.669R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox43.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox43.Value = "ถึง"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox6})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9R), Telerik.Reporting.Drawing.Unit.Inch(0.351R))
        Me.Panel1.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.Panel1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.Panel1.Style.Font.Name = "BrowalliaUPC"
        Me.Panel1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.067R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox14.Value = "หลักสูตรการฝึกอบรม"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.406R), Telerik.Reporting.Drawing.Unit.Inch(0.067R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.194R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox15.Value = "= Fields.PaternRefName"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.1R), Telerik.Reporting.Drawing.Unit.Inch(0.067R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox16.Value = "ครั้งที่"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.533R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.896R), Telerik.Reporting.Drawing.Unit.Inch(0.167R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Value = "= Fields.CompanyName"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11508\TGS_EXPRESS;Initial Catalog=dbTraining;Integrated Security=Tr" &
    "ue"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_TNR1_006_03
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Patern_Date"))
        Group1.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        Group1.Name = "group"
        Group2.GroupFooter = Me.groupFooterSection1
        Group2.GroupHeader = Me.groupHeaderSection1
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PaternRefName"))
        Group2.Name = "group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.groupHeaderSection1, Me.groupFooterSection1, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "TNR1_006_03"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.9R)
        CType(Me.Rpt_sub_professor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents rpt_sub_professor As Telerik.Reporting.SubReport
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents lbl_1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox58 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox57 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents Rpt_sub_professor1 As CLB_Training.rpt_sub_professor
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
End Class