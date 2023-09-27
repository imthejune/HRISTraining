Partial Class rpt_yearStand
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_yearStand))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.Rpt_sub_yearNu2Stand1 = New CLB_Training.rpt_sub_yearNu2Stand()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.Panel25 = New Telerik.Reporting.Panel()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.Panel6 = New Telerik.Reporting.Panel()
        Me.Panel15 = New Telerik.Reporting.Panel()
        Me.Panel14 = New Telerik.Reporting.Panel()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel5 = New Telerik.Reporting.Panel()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.Panel7 = New Telerik.Reporting.Panel()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.Panel11 = New Telerik.Reporting.Panel()
        Me.Panel10 = New Telerik.Reporting.Panel()
        Me.Panel9 = New Telerik.Reporting.Panel()
        Me.Panel8 = New Telerik.Reporting.Panel()
        Me.Panel12 = New Telerik.Reporting.Panel()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.Panel16 = New Telerik.Reporting.Panel()
        Me.Panel13 = New Telerik.Reporting.Panel()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.Panel21 = New Telerik.Reporting.Panel()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.Panel19 = New Telerik.Reporting.Panel()
        Me.Panel22 = New Telerik.Reporting.Panel()
        Me.Panel24 = New Telerik.Reporting.Panel()
        Me.Panel29 = New Telerik.Reporting.Panel()
        Me.Panel26 = New Telerik.Reporting.Panel()
        Me.Panel32 = New Telerik.Reporting.Panel()
        Me.Panel30 = New Telerik.Reporting.Panel()
        Me.Panel20 = New Telerik.Reporting.Panel()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.Panel31 = New Telerik.Reporting.Panel()
        Me.Panel18 = New Telerik.Reporting.Panel()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.Panel28 = New Telerik.Reporting.Panel()
        Me.Panel48 = New Telerik.Reporting.Panel()
        Me.Panel23 = New Telerik.Reporting.Panel()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.Panel17 = New Telerik.Reporting.Panel()
        Me.Panel27 = New Telerik.Reporting.Panel()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.SubYearNuStand = New Telerik.Reporting.SubReport()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me.Rpt_sub_yearNu2Stand1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Rpt_sub_yearNu2Stand1
        '
        Me.Rpt_sub_yearNu2Stand1.Name = "rpt_sub_yearNu2Stand"
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.1R)
        Me.groupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel25})
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'Panel25
        '
        Me.Panel25.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox33, Me.TextBox37, Me.TextBox38, Me.TextBox40, Me.TextBox41, Me.TextBox42, Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.TextBox47, Me.TextBox48, Me.TextBox49, Me.TextBox50, Me.TextBox39})
        Me.Panel25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(11.353R), Telerik.Reporting.Drawing.Unit.Inch(0.278R))
        Me.Panel25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.051R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox33.Value = "Year Total Summary"
        '
        'TextBox37
        '
        Me.TextBox37.Format = "{0:N2}"
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.837R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.Value = "=SUM(Fields.TotalHour * Fields.JoinTrain)"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.559R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox38.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox38.Value = "=COUNT(Fields.GUID_Patern) "
        '
        'TextBox40
        '
        Me.TextBox40.Format = "{0:N2}"
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.76R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox40.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox40.Value = "=SUM(Fields.Management) "
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.537R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.159R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.Value = "= SUM(Fields.Manager)"
        '
        'TextBox42
        '
        Me.TextBox42.Format = "{0:N2}"
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.755R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.404R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox42.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox42.Value = "= SUM(Fields.Manager)"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.222R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.159R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox43.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox43.Value = "= SUM(Fields.Supervisor)"
        '
        'TextBox44
        '
        Me.TextBox44.Format = "{0:N2}"
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.496R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.554R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox44.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox44.Value = "=SUM(Fields.Supervisor)"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.15R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.159R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox45.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox45.Value = "= SUM(Fields.Officer)"
        '
        'TextBox46
        '
        Me.TextBox46.Format = "{0:N2}"
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.347R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox46.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox46.Value = "= SUM(Fields.Officer)"
        '
        'TextBox47
        '
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.862R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox47.Value = "= SUM(Fields.Staff)"
        '
        'TextBox48
        '
        Me.TextBox48.Format = "{0:N2}"
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.064R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox48.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox48.Value = "= SUM(Fields.Staff)"
        '
        'TextBox49
        '
        Me.TextBox49.Format = "{0:N2}"
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.6R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.757R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox49.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox49.Value = "= SUM(Fields.Trainee)"
        '
        'TextBox50
        '
        Me.TextBox50.Format = "{0:N2}"
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.5R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox50.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox50.Value = "=SUM( Fields.Budget)"
        '
        'TextBox39
        '
        Me.TextBox39.Format = "{0}"
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.544R), Telerik.Reporting.Drawing.Unit.Inch(0.009R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox39.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox39.Value = "=SUM(Fields.Management) "
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1, Me.Panel4, Me.Panel2})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox3, Me.TextBox10, Me.Panel6, Me.Panel15, Me.Panel14, Me.TextBox9, Me.TextBox8})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(11.353R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.111R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Value = "Total"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.04R), Telerik.Reporting.Drawing.Unit.Inch(0.04R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.325R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Value = "Count of training & Expense"
        '
        'Panel6
        '
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.49R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel15
        '
        Me.Panel15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.34R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel15.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel15.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel15.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel14
        '
        Me.Panel14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.76R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel14.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel14.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel14.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.059R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Value = "Training Course :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.3R), Telerik.Reporting.Drawing.Unit.Inch(0.059R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Value = "= GetMonth(Fields.Month_Date, 'T')"
        '
        'Panel4
        '
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.476R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel5, Me.TextBox23, Me.Panel3, Me.TextBox22, Me.Panel7, Me.TextBox17, Me.TextBox20, Me.TextBox21, Me.TextBox18, Me.TextBox19, Me.Panel11, Me.Panel10, Me.Panel9, Me.Panel8, Me.Panel12, Me.TextBox16, Me.TextBox15, Me.TextBox14, Me.TextBox13, Me.TextBox12, Me.TextBox11, Me.Panel16, Me.Panel13})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(11.353R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'Panel5
        '
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.477R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.584R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.Value = "Expense"
        '
        'Panel3
        '
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.401R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.616R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.633R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Value = "Trainee"
        '
        'Panel7
        '
        Me.Panel7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.49R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.59R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.875R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox17.Value = "Management"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.175R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.509R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Value = "Officer"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.965R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.368R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Value = "Staff"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.55R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.609R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Value = "Manager"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.234R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Value = "Supervisor"
        '
        'Panel11
        '
        Me.Panel11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.48R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel10
        '
        Me.Panel10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.164R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel9
        '
        Me.Panel9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.075R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel8
        '
        Me.Panel8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.794R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel12
        '
        Me.Panel12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.181R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel12.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel12.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel12.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.24R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.22R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Value = "Hr"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.09R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.706R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Value = "Training course"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.39R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.634R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Value = "Name-Surname"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.488R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Value = "Code"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.319R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.381R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Value = "Date"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.053R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.265R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Value = "No"
        '
        'Panel16
        '
        Me.Panel16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.024R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel16.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel16.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel13
        '
        Me.Panel13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.265R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.Panel13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.291R)
        Me.groupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel21})
        Me.groupFooterSection1.Name = "groupFooterSection1"
        '
        'Panel21
        '
        Me.Panel21.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.Panel19, Me.Panel22, Me.Panel24, Me.Panel29, Me.Panel26, Me.Panel32, Me.Panel30, Me.Panel20, Me.TextBox34, Me.TextBox32, Me.Panel31, Me.Panel18, Me.TextBox28, Me.Panel28, Me.Panel48, Me.Panel23, Me.TextBox6, Me.TextBox25, Me.TextBox24, Me.TextBox7, Me.TextBox4, Me.TextBox26, Me.TextBox27, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox35})
        Me.Panel21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(11.353R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.055R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Value = "Total "
        '
        'Panel19
        '
        Me.Panel19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.49R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel19.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel19.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel19.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel22
        '
        Me.Panel22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.075R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel22.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel22.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel24
        '
        Me.Panel24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.794R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel24.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel24.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel24.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel29
        '
        Me.Panel29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.401R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel29.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel29.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel29.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel29.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel26
        '
        Me.Panel26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.693R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel26.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel26.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel26.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel32
        '
        Me.Panel32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.3R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel32.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel32.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel32.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel30
        '
        Me.Panel30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.165R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel30.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel30.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel30.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel20
        '
        Me.Panel20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.48R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel20.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel20.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox34
        '
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3R), Telerik.Reporting.Drawing.Unit.Inch(0.055R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.159R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.Value = "= COUNT(1)"
        '
        'TextBox32
        '
        Me.TextBox32.Format = "{0:N2}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6R), Telerik.Reporting.Drawing.Unit.Inch(0.055R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.837R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "= Fields.TotalHour * Fields.JoinTrain"
        '
        'Panel31
        '
        Me.Panel31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.398R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel31.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel31.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel31.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel31.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel18
        '
        Me.Panel18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.971R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel18.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel18.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.544R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox28.Value = "= Fields.Management"
        '
        'Panel28
        '
        Me.Panel28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.689R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel28.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel28.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel28.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel28.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel48
        '
        Me.Panel48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.999R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel48.Name = "Panel48"
        Me.Panel48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel48.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel48.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel48.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel48.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel23
        '
        Me.Panel23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.476R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.291R))
        Me.Panel23.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel23.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel23.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox6
        '
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.8R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "=Fields.Management "
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.846R), Telerik.Reporting.Drawing.Unit.Inch(0.056R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "= Fields.Staff"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.127R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "= Fields.Officer"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.234R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "= Fields.Supervisor"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.533R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "= Fields.Manager"
        '
        'TextBox26
        '
        Me.TextBox26.Format = "{0:N2}"
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.755R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.404R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "= Fields.Manager"
        '
        'TextBox27
        '
        Me.TextBox27.Format = "{0:N2}"
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.451R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.6R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "= Fields.Supervisor"
        '
        'TextBox29
        '
        Me.TextBox29.Format = "{0:N2}"
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.352R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.441R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox29.Value = "= Fields.Officer"
        '
        'TextBox30
        '
        Me.TextBox30.Format = "{0:N2}"
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.064R), Telerik.Reporting.Drawing.Unit.Inch(0.056R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.Value = "= Fields.Staff"
        '
        'TextBox31
        '
        Me.TextBox31.Format = "{0:N2}"
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.6R), Telerik.Reporting.Drawing.Unit.Inch(0.054R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.757R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = "= Fields.Trainee"
        '
        'TextBox35
        '
        Me.TextBox35.Format = "{0:N2}"
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.543R), Telerik.Reporting.Drawing.Unit.Inch(0.056R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.757R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.Value = "= Fields.BudgetPerson"
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.2R)
        Me.groupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel17})
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        '
        'Panel17
        '
        Me.Panel17.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel27, Me.TextBox36})
        Me.Panel17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(11.353R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.Panel17.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel17.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'Panel27
        '
        Me.Panel27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.265R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.Panel27.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel27.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel27.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel27.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox36.Value = "= GetMonth(Fields.Month_Date, 'T')"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.271R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Value = "= Fields.CompanyName"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.896R), Telerik.Reporting.Drawing.Unit.Inch(0.552R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.138R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Value = "รายงานหลักสูตรการอบรมประจำปี Yearly Total ( กรณี งานปรับเปลี่ยนตามความต้องการ )"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.6R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.SubYearNuStand})
        Me.detail.Name = "detail"
        '
        'SubYearNuStand
        '
        Me.SubYearNuStand.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.SubYearNuStand.Name = "SubYearNuStand"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("GUID_Paten", "= Fields.GUID_Patern"))
        InstanceReportSource1.ReportDocument = Me.Rpt_sub_yearNu2Stand1
        Me.SubYearNuStand.ReportSource = InstanceReportSource1
        Me.SubYearNuStand.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(11.353R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "CLB_Training.My.MySettings.dbTrainning2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_yearStand
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Month_Date"))
        Group1.Name = "group"
        Group2.GroupFooter = Me.groupFooterSection1
        Group2.GroupHeader = Me.groupHeaderSection1
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.GUID_Patern"))
        Group2.Name = "group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.groupHeaderSection1, Me.groupFooterSection1, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_yearStand"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(11.353R)
        CType(Me.Rpt_sub_yearNu2Stand1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents Panel7 As Telerik.Reporting.Panel
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents Panel11 As Telerik.Reporting.Panel
    Friend WithEvents Panel10 As Telerik.Reporting.Panel
    Friend WithEvents Panel9 As Telerik.Reporting.Panel
    Friend WithEvents Panel8 As Telerik.Reporting.Panel
    Friend WithEvents Panel12 As Telerik.Reporting.Panel
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents Panel15 As Telerik.Reporting.Panel
    Friend WithEvents Panel14 As Telerik.Reporting.Panel
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents Panel16 As Telerik.Reporting.Panel
    Friend WithEvents Panel13 As Telerik.Reporting.Panel
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents Panel17 As Telerik.Reporting.Panel
    Friend WithEvents Panel27 As Telerik.Reporting.Panel
    Friend WithEvents Panel21 As Telerik.Reporting.Panel
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents Panel19 As Telerik.Reporting.Panel
    Friend WithEvents Panel18 As Telerik.Reporting.Panel
    Friend WithEvents Panel20 As Telerik.Reporting.Panel
    Friend WithEvents Panel30 As Telerik.Reporting.Panel
    Friend WithEvents Panel22 As Telerik.Reporting.Panel
    Friend WithEvents Panel24 As Telerik.Reporting.Panel
    Friend WithEvents Panel29 As Telerik.Reporting.Panel
    Friend WithEvents Panel26 As Telerik.Reporting.Panel
    Friend WithEvents Panel28 As Telerik.Reporting.Panel
    Friend WithEvents Panel31 As Telerik.Reporting.Panel
    Friend WithEvents Panel32 As Telerik.Reporting.Panel
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents Panel25 As Telerik.Reporting.Panel
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents Panel48 As Telerik.Reporting.Panel
    Friend WithEvents Panel23 As Telerik.Reporting.Panel
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents SubYearNuStand As Telerik.Reporting.SubReport
    Friend WithEvents Rpt_sub_yearNu2Stand1 As rpt_sub_yearNu2Stand
End Class