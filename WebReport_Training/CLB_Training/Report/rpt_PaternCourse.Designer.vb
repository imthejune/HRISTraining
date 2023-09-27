Partial Class rpt_PaternCourse

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource2 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_PaternCourse))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox57 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox58 = New Telerik.Reporting.TextBox()
        Me.lbl_1 = New Telerik.Reporting.TextBox()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.Shape4 = New Telerik.Reporting.Shape()
        Me.Shape3 = New Telerik.Reporting.Shape()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.sub_professor = New Telerik.Reporting.SubReport()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.SubReportTrain = New Telerik.Reporting.SubReport()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1R)
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.Visible = True
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.2R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox8, Me.TextBox12, Me.TextBox6, Me.TextBox5, Me.TextBox4, Me.TextBox3, Me.TextBox7, Me.TextBox2})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.067R), Telerik.Reporting.Drawing.Unit.Inch(0.756R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox12.Value = "หลักสูตร"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.067R), Telerik.Reporting.Drawing.Unit.Inch(0.454R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox11.Value = "หลักสูตร"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.108R), Telerik.Reporting.Drawing.Unit.Inch(0.756R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox10.Value = "= Fields.inp"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.108R), Telerik.Reporting.Drawing.Unit.Inch(0.454R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox9.Value = "= Fields.inH"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.567R), Telerik.Reporting.Drawing.Unit.Inch(0.756R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox8.Value = "จำนวนหลักสูตรที่ส่งไปรับการฝึกภายนอก"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.965R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox2.Value = "รายงานรายชื่อพนักงานในหลักสูตรการอบรมประจำปีแบบตาราง"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.046R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox6.Value = "=Fields.Year_PaterbDate"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.765R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox5.Value = "=GetMonth(Fields.MONTH_PaterbDate, 'T')"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.66R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox4.Value = "ปี"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.265R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox3.Value = "เดือน"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.567R), Telerik.Reporting.Drawing.Unit.Inch(0.454R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox7.Value = "จำนวนหลักสูตรที่ดำเนินการฝึกอบรมเอง"
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.002R)
        Me.groupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox41, Me.TextBox40, Me.TextBox35, Me.TextBox57, Me.TextBox51, Me.TextBox56, Me.TextBox55, Me.TextBox58, Me.lbl_1})
        Me.groupFooterSection1.Name = "groupFooterSection1"
        Me.groupFooterSection1.Style.Visible = True
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.413R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.18R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox41.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox41.Value = "= Fields.CountPerson"
        '
        'TextBox40
        '
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.57R), Telerik.Reporting.Drawing.Unit.Inch(0.704R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.033R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox40.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox40.Value = "= Fields.TotalHour"
        '
        'TextBox35
        '
        Me.TextBox35.Format = "{0:N2}"
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.82R), Telerik.Reporting.Drawing.Unit.Inch(0.402R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.776R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox35.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox35.Value = "= Fields.Budget"
        '
        'TextBox57
        '
        Me.TextBox57.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.778R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox57.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox57.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox57.Value = "คน"
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.778R), Telerik.Reporting.Drawing.Unit.Inch(0.694R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox51.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox51.Value = "ชม."
        '
        'TextBox56
        '
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.924R), Telerik.Reporting.Drawing.Unit.Inch(0.402R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox56.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox56.Value = "รวมค่าใช้จ่ายทั้งหมด"
        '
        'TextBox55
        '
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.924R), Telerik.Reporting.Drawing.Unit.Inch(0.694R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox55.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox55.Value = "จำนวนชั่วโมง"
        '
        'TextBox58
        '
        Me.TextBox58.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.778R), Telerik.Reporting.Drawing.Unit.Inch(0.402R))
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox58.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox58.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox58.Value = "บาท"
        '
        'lbl_1
        '
        Me.lbl_1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.924R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_1.Value = "รวมพนักงานที่อบรม"
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(3.5R)
        Me.groupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox13, Me.TextBox43, Me.TextBox42, Me.TextBox33, Me.TextBox32, Me.TextBox30, Me.TextBox31, Me.TextBox27, Me.TextBox29, Me.TextBox26, Me.TextBox28, Me.TextBox17, Me.TextBox38, Me.TextBox37, Me.TextBox36, Me.TextBox25, Me.Shape4, Me.Shape3, Me.TextBox24, Me.TextBox23, Me.TextBox22, Me.TextBox21, Me.TextBox20, Me.TextBox19, Me.TextBox16, Me.TextBox14, Me.TextBox18, Me.TextBox15, Me.sub_professor, Me.Shape1})
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        Me.groupHeaderSection1.Style.Visible = True
        '
        'TextBox13
        '
        Me.TextBox13.Format = "{0}"
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.458R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.708R), Telerik.Reporting.Drawing.Unit.Inch(0.351R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox13.Style.Color = System.Drawing.Color.Black
        Me.TextBox13.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox13.Value = " "
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.25R), Telerik.Reporting.Drawing.Unit.Inch(0.51R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox43.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox43.Value = "ถึง"
        '
        'TextBox42
        '
        Me.TextBox42.Format = "{0:N2}"
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.188R), Telerik.Reporting.Drawing.Unit.Inch(1.708R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.874R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox42.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox42.Value = "= Fields.BudgetPerson"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.188R), Telerik.Reporting.Drawing.Unit.Inch(2.312R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox33.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox33.Value = "= Fields.TypePaternName"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.188R), Telerik.Reporting.Drawing.Unit.Inch(2.01R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox32.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox32.Value = "= Fields.TypeCourseName"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.188R), Telerik.Reporting.Drawing.Unit.Inch(1.406R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox30.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox30.Value = "= Fields.OrganizeName"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.188R), Telerik.Reporting.Drawing.Unit.Inch(1.115R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.421R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox31.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox31.Value = "= Fields.InstitueTrainName"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.188R), Telerik.Reporting.Drawing.Unit.Inch(0.812R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.992R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox27.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox27.Value = "=dateFormat2(Fields.TrainDay_Time, 'T')"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.594R), Telerik.Reporting.Drawing.Unit.Inch(0.812R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox29.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox29.Value = "=dateFormat2(Fields.TrainDay_EndTime, 'T')"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.188R), Telerik.Reporting.Drawing.Unit.Inch(0.51R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.992R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox26.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox26.Value = "=dateFormat(Fields.Patern_Date, 'T')"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.594R), Telerik.Reporting.Drawing.Unit.Inch(0.51R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox28.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox28.Value = "=dateFormat(Fields.Patern_End, 'T')"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.458R), Telerik.Reporting.Drawing.Unit.Inch(0.115R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox17.Style.Font.Bold = True
        Me.TextBox17.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox17.Value = "= Fields.Patern_N"
        '
        'TextBox38
        '
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.094R), Telerik.Reporting.Drawing.Unit.Inch(1.708R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.448R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox38.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox38.Value = "บาท"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.25R), Telerik.Reporting.Drawing.Unit.Inch(0.812R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox37.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox37.Value = "ถึง"
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.25R), Telerik.Reporting.Drawing.Unit.Inch(0.51R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox36.Value = "ถึง"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(2.838R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox25.Value = "ชื่อวิทยากร"
        '
        'Shape4
        '
        Me.Shape4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.146R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.Shape4.Name = "Shape4"
        Me.Shape4.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.056R), Telerik.Reporting.Drawing.Unit.Inch(2.677R))
        '
        'Shape3
        '
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.429R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.053R), Telerik.Reporting.Drawing.Unit.Inch(2.677R))
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(2.312R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox24.Value = "Type of Training"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(2.01R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox23.Value = "Type of Training"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(1.708R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox22.Value = "ค่าใช้จ่ายหลักสูตร/คน"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(1.406R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox21.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox21.Value = "หน่วยงานที่จัดอบรม"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(1.115R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox20.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox20.Value = "สถานที่"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(0.812R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox19.Value = "เวลา"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.99R), Telerik.Reporting.Drawing.Unit.Inch(0.115R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.44R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox16.Value = "ครั้งที่"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.115R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.227R))
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox14.Value = "หลักสูตรการฝึกอบรม"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.719R), Telerik.Reporting.Drawing.Unit.Inch(0.51R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox18.Value = "วันที่อบรม"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.917R), Telerik.Reporting.Drawing.Unit.Inch(0.115R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.008R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox15.Value = "= Fields.PaternRefName"
        '
        'sub_professor
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Fields.GUID_Patern", Telerik.Reporting.FilterOperator.Equal, ""))
        Me.sub_professor.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.sub_professor.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.567R), Telerik.Reporting.Drawing.Unit.Inch(2.838R))
        Me.sub_professor.Name = "sub_professor"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("GUID_Patern", "= Fields.GUID_Patern"))
        InstanceReportSource1.ReportDocument = Nothing
        Me.sub_professor.ReportSource = InstanceReportSource1
        Me.sub_professor.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6R), Telerik.Reporting.Drawing.Unit.Inch(0.363R))
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.458R), Telerik.Reporting.Drawing.Unit.Inch(2.64R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.726R), Telerik.Reporting.Drawing.Unit.Cm(0.132R))
        Me.Shape1.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        '
        'SubReportTrain
        '
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("= Fields.GUID_Patern", Telerik.Reporting.FilterOperator.Equal, ""))
        Me.SubReportTrain.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.SubReportTrain.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.175R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.SubReportTrain.Name = "SubReportTrain"
        InstanceReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("GUID_Patern", "= Fields.GUID_Patern"))
        InstanceReportSource2.ReportDocument = Nothing
        Me.SubReportTrain.ReportSource = InstanceReportSource2
        Me.SubReportTrain.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.771R), Telerik.Reporting.Drawing.Unit.Inch(0.363R))
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.SubReportTrain})
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = True
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = True
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4R)
        Me.PageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1})
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11521\SQLEXPRESS;Initial Catalog=testDatabase;User ID=sa;Password=t" &
    "iger"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Value = "= Fields.CompanyName"
        '
        'rpt_PaternCourse
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Patern_Date"))
        Group1.Name = "group_header1"
        Group2.GroupFooter = Me.groupFooterSection1
        Group2.GroupHeader = Me.groupHeaderSection1
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PaternRefName"))
        Group2.Name = "group_header2"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.groupHeaderSection1, Me.groupFooterSection1, Me.detail, Me.pageFooterSection1, Me.PageHeaderSection1})
        Me.Name = "rpt_PaternCourse"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.909R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents Shape4 As Telerik.Reporting.Shape
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox57 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox58 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_1 As Telerik.Reporting.TextBox
    Friend WithEvents sub_professor As Telerik.Reporting.SubReport
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents SubReportTrain As Telerik.Reporting.SubReport
    Public WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class