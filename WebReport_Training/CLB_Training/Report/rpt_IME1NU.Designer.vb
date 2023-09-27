Partial Class rpt_IME1NU
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_IME1NU))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.Rpt_sub_IME1NU1 = New CLB_Training.rpt_sub_IME1NU()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.Panel11 = New Telerik.Reporting.Panel()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.Panel6 = New Telerik.Reporting.Panel()
        Me.Panel7 = New Telerik.Reporting.Panel()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.Panel8 = New Telerik.Reporting.Panel()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.Panel9 = New Telerik.Reporting.Panel()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.Panel10 = New Telerik.Reporting.Panel()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.Panel5 = New Telerik.Reporting.Panel()
        Me.SubIME1Nu = New Telerik.Reporting.SubReport()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me.Rpt_sub_IME1NU1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Rpt_sub_IME1NU1
        '
        Me.Rpt_sub_IME1NU1.Name = "rpt_sub_IME1NU"
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.948R)
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.Visible = True
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.502R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox20, Me.TextBox4, Me.TextBox5, Me.TextBox3, Me.TextBox18, Me.TextBox19, Me.TextBox6, Me.TextBox21, Me.TextBox22, Me.TextBox23})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.794R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "= Fields.PrositionName"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.106R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "ชื่อ - นามสกุล :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.106R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.679R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "ตำแหน่ง :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.185R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "รหัสพนักงาน :"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.125R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.Value = "= Fields.PersonCode"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.106R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.979R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "= Fields.SubTrainName"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.816R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "ฝ่าย :"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.327R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "= Fields.departName"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.385R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "แผนก :"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.985R), Telerik.Reporting.Drawing.Unit.Inch(0.136R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "= Fields.departName"
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.452R)
        Me.groupFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel11, Me.TextBox17, Me.TextBox1})
        Me.groupFooterSection1.Name = "groupFooterSection1"
        '
        'Panel11
        '
        Me.Panel11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(1.4R))
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.6R), Telerik.Reporting.Drawing.Unit.Inch(0.052R))
        Me.Panel11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel11.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.1R), Telerik.Reporting.Drawing.Unit.Inch(1.026R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.374R))
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "รวมจำนวน ชม."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.11R), Telerik.Reporting.Drawing.Unit.Inch(1.026R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.374R))
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.SumTotalHour"
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.502R)
        Me.groupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1})
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox12, Me.Panel6, Me.Panel7, Me.TextBox13, Me.Panel8, Me.TextBox14, Me.Panel9, Me.TextBox15, Me.Panel10, Me.TextBox16, Me.Panel2, Me.TextBox7, Me.TextBox9, Me.TextBox10, Me.Panel3, Me.Panel5})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.6R), Telerik.Reporting.Drawing.Unit.Inch(0.502R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.026R), Telerik.Reporting.Drawing.Unit.Inch(0.14R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "ลำดับ"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.14R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.44R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "หลักสูตรการฝึกอบรม"
        '
        'Panel6
        '
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.493R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.487R))
        Me.Panel6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel7
        '
        Me.Panel7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.72R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.487R))
        Me.Panel7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.795R), Telerik.Reporting.Drawing.Unit.Inch(0.14R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.758R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "วันที่ฝึกอบรม"
        '
        'Panel8
        '
        Me.Panel8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.62R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.487R))
        Me.Panel8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.695R), Telerik.Reporting.Drawing.Unit.Inch(0.04R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.905R), Telerik.Reporting.Drawing.Unit.Inch(0.374R))
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "จำนวนอบรม(ชม.)"
        '
        'Panel9
        '
        Me.Panel9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.642R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.487R))
        Me.Panel9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel9.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.242R), Telerik.Reporting.Drawing.Unit.Inch(0.04R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.374R))
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "วิทยากร"
        '
        'Panel10
        '
        Me.Panel10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.742R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.487R))
        Me.Panel10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.16R), Telerik.Reporting.Drawing.Unit.Inch(0.04R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1R), Telerik.Reporting.Drawing.Unit.Inch(0.374R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "สถานที่อบรม"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel4, Me.TextBox8})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4R), Telerik.Reporting.Drawing.Unit.Inch(0.248R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.Panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'Panel4
        '
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.66R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.Panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7R), Telerik.Reporting.Drawing.Unit.Inch(0.031R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Public"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.043R), Telerik.Reporting.Drawing.Unit.Inch(0.04R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.157R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "Type of Training"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.2R), Telerik.Reporting.Drawing.Unit.Inch(0.279R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "In-house"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.51R), Telerik.Reporting.Drawing.Unit.Inch(0.279R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "OJT"
        '
        'Panel3
        '
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.Panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel5
        '
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.96R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.Panel5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'SubIME1Nu
        '
        Me.SubIME1Nu.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.SubIME1Nu.Name = "SubIME1Nu"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("PersonID", "= Fields.SubPersonID"))
        InstanceReportSource1.ReportDocument = Me.Rpt_sub_IME1NU1
        Me.SubIME1Nu.ReportSource = InstanceReportSource1
        Me.SubIME1Nu.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.6R), Telerik.Reporting.Drawing.Unit.Inch(1.396R))
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "Individual Training Record"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.1R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox24, Me.TextBox2})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.099R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "= Fields.CompanyName"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.396R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.SubIME1Nu})
        Me.detail.Name = "detail"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11508\SQLEXPRESS01;Initial Catalog=HrisTraining;Integrated Security" &
    "=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_IME1NU
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.SubPersonID"))
        Group1.Name = "group"
        Group2.GroupFooter = Me.groupFooterSection1
        Group2.GroupHeader = Me.groupHeaderSection1
        Group2.Name = "group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.groupHeaderSection1, Me.groupFooterSection1, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_IME1NU"
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.6R)
        CType(Me.Rpt_sub_IME1NU1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents Panel7 As Telerik.Reporting.Panel
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents Panel8 As Telerik.Reporting.Panel
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents Panel9 As Telerik.Reporting.Panel
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents Panel10 As Telerik.Reporting.Panel
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents Panel11 As Telerik.Reporting.Panel
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents SubIME1Nu As Telerik.Reporting.SubReport
    Friend WithEvents Rpt_sub_IME1NU1 As CLB_Training.rpt_sub_IME1NU
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class