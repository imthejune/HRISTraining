Partial Class rpt_PaternpersonAbsen
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource2 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_PaternpersonAbsen))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.Rpt_sub_professor1 = New CLB_Training.rpt_sub_professor()
        Me.Rpt_sub_TrainPerson1 = New CLB_Training.rpt_sub_TrainPerson()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.lbl_1 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.Shape3 = New Telerik.Reporting.Shape()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.SubProfessor = New Telerik.Reporting.SubReport()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.SubTrainCourse = New Telerik.Reporting.SubReport()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me.Rpt_sub_professor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt_sub_TrainPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Rpt_sub_professor1
        '
        Me.Rpt_sub_professor1.Name = "rpt_sub_professor"
        '
        'Rpt_sub_TrainPerson1
        '
        Me.Rpt_sub_TrainPerson1.Name = "rpt_sub_TrainPerson"
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.groupFooterSection1.Name = "groupFooterSection1"
        Me.groupFooterSection1.Style.Visible = False
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.448R)
        Me.groupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1, Me.TextBox1, Me.TextBox3, Me.TextBox2, Me.TextBox4, Me.TextBox7, Me.TextBox19, Me.TextBox41, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox50, Me.TextBox51, Me.TextBox52, Me.TextBox53})
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        Me.groupHeaderSection1.Style.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.848R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.106R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
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
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox3.Value = ")"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox2.Value = "รายงานชื่อพนักงานในหลักสูตรอบรม ("
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox4.Value = "จำแนกพนักงานที่ (ไม่) เข้าอบรม"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.606R), Telerik.Reporting.Drawing.Unit.Inch(0.969R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.602R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.Value = "วันที่อบรม"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.126R), Telerik.Reporting.Drawing.Unit.Inch(0.958R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox19.Value = "ถึง"
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.106R), Telerik.Reporting.Drawing.Unit.Inch(0.958R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox41.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox41.Value = "ถึง"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.106R), Telerik.Reporting.Drawing.Unit.Inch(0.958R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox43.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox43.Value = "เวลา"
        '
        'TextBox44
        '
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.408R), Telerik.Reporting.Drawing.Unit.Inch(0.958R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.507R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox44.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox44.Value = "=dateFormat2(Fields.TrainDay_EndTime, 'T')"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.512R), Telerik.Reporting.Drawing.Unit.Inch(0.958R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.54R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox45.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox45.Value = "=dateFormat2(Fields.TrainDay_Time, 'T')"
        '
        'TextBox50
        '
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.272R), Telerik.Reporting.Drawing.Unit.Inch(0.958R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.838R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox50.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox50.Value = "= dateFormat(Fields.Patern_Date, 'T')"
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.335R), Telerik.Reporting.Drawing.Unit.Inch(0.958R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.731R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox51.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox51.Value = "=dateFormat(Fields.Patern_End, 'T')"
        '
        'TextBox52
        '
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.085R), Telerik.Reporting.Drawing.Unit.Inch(0.948R))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox52.Style.Font.Bold = True
        Me.TextBox52.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox52.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox52.Value = "หลักสูตรการศึกอบรม"
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.106R), Telerik.Reporting.Drawing.Unit.Inch(1.177R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.726R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox53.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox53.Value = "= Fields.PaternRefName"
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(3.286R)
        Me.groupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox37, Me.TextBox25, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox34, Me.TextBox35, Me.TextBox36, Me.lbl_1, Me.TextBox39, Me.TextBox40, Me.TextBox46, Me.TextBox47, Me.Shape3, Me.TextBox5, Me.Panel4})
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.896R), Telerik.Reporting.Drawing.Unit.Inch(0.126R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox37.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox37.Value = "= Fields.NoJoinTrain"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.196R), Telerik.Reporting.Drawing.Unit.Inch(0.426R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox25.Value = "คนที่เข้าอบรมแล้ว"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.196R), Telerik.Reporting.Drawing.Unit.Inch(0.426R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox27.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox27.Value = "รวมทั้งหมด"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.196R), Telerik.Reporting.Drawing.Unit.Inch(0.124R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox28.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox28.Value = "งบประมาณรวม"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.796R), Telerik.Reporting.Drawing.Unit.Inch(0.124R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.768R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox29.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox29.Value = "จำนวนชั่วโมง"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.796R), Telerik.Reporting.Drawing.Unit.Inch(0.124R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.333R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox30.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox30.Value = "คน"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.796R), Telerik.Reporting.Drawing.Unit.Inch(0.426R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.333R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox31.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox31.Value = "คน"
        '
        'TextBox34
        '
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.324R), Telerik.Reporting.Drawing.Unit.Inch(0.426R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.333R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox34.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox34.Value = "คน"
        '
        'TextBox35
        '
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.324R), Telerik.Reporting.Drawing.Unit.Inch(0.126R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.333R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox35.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox35.Value = "บาท"
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.396R), Telerik.Reporting.Drawing.Unit.Inch(0.126R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.333R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox36.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox36.Value = "ชม."
        '
        'lbl_1
        '
        Me.lbl_1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.196R), Telerik.Reporting.Drawing.Unit.Inch(0.126R))
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.526R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.lbl_1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_1.Value = "คนที่มีรายชื่อยังไม่เข้าอบรม"
        '
        'TextBox39
        '
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.896R), Telerik.Reporting.Drawing.Unit.Inch(0.426R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox39.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox39.Value = "= Fields.JoinTrain"
        '
        'TextBox40
        '
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.396R), Telerik.Reporting.Drawing.Unit.Inch(0.126R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox40.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox40.Value = "= Fields.Budget"
        '
        'TextBox46
        '
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.396R), Telerik.Reporting.Drawing.Unit.Inch(0.426R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox46.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox46.Value = "= Fields.TotalJoinTrain"
        '
        'TextBox47
        '
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.596R), Telerik.Reporting.Drawing.Unit.Inch(0.124R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox47.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox47.Value = "= Fields.TotalHour"
        '
        'Shape3
        '
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.001R), Telerik.Reporting.Drawing.Unit.Inch(0.786R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.995R), Telerik.Reporting.Drawing.Unit.Cm(0.132R))
        Me.Shape3.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.085R), Telerik.Reporting.Drawing.Unit.Inch(2.197R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox5.Value = " [  ]   เป็นพนักงานทีมีรายชื่อในหลักสูตรแต่ไม่ได้เข้าอบรม "
        '
        'Panel4
        '
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.106R), Telerik.Reporting.Drawing.Unit.Inch(1.997R))
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.5R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel2, Me.TextBox32, Me.TextBox15, Me.TextBox20, Me.TextBox22, Me.TextBox23, Me.TextBox24, Me.TextBox38, Me.TextBox18, Me.TextBox33, Me.TextBox42, Me.TextBox21, Me.TextBox16, Me.TextBox17, Me.SubProfessor, Me.TextBox48})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel3})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.106R), Telerik.Reporting.Drawing.Unit.Inch(1.5R))
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'Panel3
        '
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.196R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.719R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.693R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox32.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox32.Value = "= Fields.TypeCourseName"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.744R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.869R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox15.Value = "หน่วยงาน"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.263R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.685R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox20.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox20.Value = "= Fields.InstitueTrainName"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.204R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox22.Value = "ค่าใช้จ่ายหลักสูตร/คน"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.744R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.869R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox23.Value = "Type of Training"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.327R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox24.Value = "Type of Training"
        '
        'TextBox38
        '
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.331R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.341R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox38.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox38.Value = "บาท"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.691R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox18.Value = "= Fields.OrganizeName"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.263R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.685R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox33.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox33.Value = "= Fields.TypePaternName"
        '
        'TextBox42
        '
        Me.TextBox42.Format = "{0:N2}"
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.396R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.874R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox42.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox42.Value = "= Fields.BudgetPerson"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.211R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.093R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox21.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.Value = "ครั้งที่"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.396R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.874R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox16.Value = "= Fields.Patern_N"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.327R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox17.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.Value = "สถานที่"
        '
        'SubProfessor
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Fields.GUID_Patern", Telerik.Reporting.FilterOperator.Equal, ""))
        Me.SubProfessor.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.SubProfessor.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.7R))
        Me.SubProfessor.Name = "SubProfessor"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("GUID_Patern", "= Fields.GUID_Patern"))
        InstanceReportSource1.ReportDocument = Me.Rpt_sub_professor1
        Me.SubProfessor.ReportSource = InstanceReportSource1
        Me.SubProfessor.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.7R), Telerik.Reporting.Drawing.Unit.Inch(0.643R))
        Me.SubProfessor.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox48
        '
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.7R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.693R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox48.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox48.Value = "ชื่อวิทยากร"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.SubTrainCourse})
        Me.detail.Name = "detail"
        '
        'SubTrainCourse
        '
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("= Fields.GUID_Patern", Telerik.Reporting.FilterOperator.Equal, ""))
        Me.SubTrainCourse.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.SubTrainCourse.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.SubTrainCourse.Name = "SubTrainCourse"
        InstanceReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("GUID_Patern", "= Fields.GUID_Patern"))
        InstanceReportSource2.ReportDocument = Me.Rpt_sub_TrainPerson1
        Me.SubTrainCourse.ReportSource = InstanceReportSource2
        Me.SubTrainCourse.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.106R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.SubTrainCourse.Style.Visible = True
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.052R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11508\TGS_EXPRESS;Initial Catalog=dbTraining;Integrated Security=Tr" &
    "ue"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_PaternpersonAbsen
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.BookmarkId = "= Fields.GuidJoinTrain"
        Group1.GroupFooter = Me.groupFooterSection1
        Group1.GroupHeader = Me.groupHeaderSection1
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.GUID_Patern"))
        Group1.Name = "group1"
        Group2.BookmarkId = "= Fields.GUID_Patern"
        Group2.GroupFooter = Me.groupFooterSection
        Group2.GroupHeader = Me.groupHeaderSection
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.GuidJoinTrain"))
        Group2.Name = "group2"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection1, Me.groupFooterSection1, Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_PaternpersonAbsen"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.106R)
        CType(Me.Rpt_sub_professor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt_sub_TrainPerson1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents SubTrainCourse As Telerik.Reporting.SubReport
    Friend WithEvents Rpt_sub_TrainPerson1 As CLB_Training.rpt_sub_TrainPerson
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents SubProfessor As Telerik.Reporting.SubReport
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox52 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents Rpt_sub_professor1 As CLB_Training.rpt_sub_professor
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
End Class