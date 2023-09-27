Partial Class rpt_trainyearakane

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_trainyearakane))
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Panel5 = New Telerik.Reporting.Panel()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.Panel6 = New Telerik.Reporting.Panel()
        Me.Panel8 = New Telerik.Reporting.Panel()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.Panel7 = New Telerik.Reporting.Panel()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.ReportFooterSection1 = New Telerik.Reporting.ReportFooterSection()
        Me.Panel9 = New Telerik.Reporting.Panel()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.Panel10 = New Telerik.Reporting.Panel()
        Me.Panel11 = New Telerik.Reporting.Panel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.41R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox24, Me.Panel1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.992R), Telerik.Reporting.Drawing.Unit.Inch(0.512R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.52R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "พนักงานส่งกรมพัฒนาฝีมือแรงงาน"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.913R), Telerik.Reporting.Drawing.Unit.Inch(0.079R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.717R), Telerik.Reporting.Drawing.Unit.Inch(0.276R))
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "= Fields.CompanyName"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.Panel2, Me.Panel3, Me.Panel4, Me.TextBox3, Me.TextBox4, Me.TextBox5})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.157R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.843R), Telerik.Reporting.Drawing.Unit.Inch(0.409R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "รหัสพนักงาน"
        '
        'Panel2
        '
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.426R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.409R))
        Me.Panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel3
        '
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.293R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.409R))
        Me.Panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel4
        '
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.409R))
        Me.Panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.89R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.84R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "พนักงานที่ข้าอบรม"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.781R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "ตำแหน่ง"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.9R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.781R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "แผนก"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.39R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel5})
        Me.detail.Name = "detail"
        '
        'Panel5
        '
        Me.Panel5.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.Panel6, Me.Panel8, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.Panel7, Me.TextBox11, Me.TextBox12})
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.157R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.843R), Telerik.Reporting.Drawing.Unit.Inch(0.39R))
        Me.Panel5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.392R), Telerik.Reporting.Drawing.Unit.Inch(0.086R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.816R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "= Fields.PersonCode"
        '
        'Panel6
        '
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.426R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.39R))
        Me.Panel6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel8
        '
        Me.Panel8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.39R))
        Me.Panel8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5R), Telerik.Reporting.Drawing.Unit.Inch(0.086R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.469R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "= Fields.InitialName"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5R), Telerik.Reporting.Drawing.Unit.Inch(0.086R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.798R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "= Fields.PersonPosition"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.52R), Telerik.Reporting.Drawing.Unit.Inch(0.086R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.286R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "= Fields.departName"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.086R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.392R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "=RowNumber() + '.'"
        '
        'Panel7
        '
        Me.Panel7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.293R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.39R))
        Me.Panel7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.988R), Telerik.Reporting.Drawing.Unit.Inch(0.086R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "= Fields.FnameT"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.988R), Telerik.Reporting.Drawing.Unit.Inch(0.086R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "= Fields.LnameT"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11521\SQLEXPRESS;Initial Catalog=HRISTraining;User ID=sa;Password=t" &
    "iger"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.pageFooterSection1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.pageFooterSection1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.528R)
        Me.ReportFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel9})
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        Me.ReportFooterSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.ReportFooterSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.ReportFooterSection1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel9
        '
        Me.Panel9.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox15, Me.TextBox14, Me.TextBox13, Me.Panel10, Me.Panel11})
        Me.Panel9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.4R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.92R), Telerik.Reporting.Drawing.Unit.Cm(0.528R))
        Me.Panel9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.156R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.626R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "คน"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.362R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.626R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "= Count(Fields.PersonID)"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5R), Telerik.Reporting.Drawing.Unit.Inch(0.001R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.626R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "รวม"
        '
        'Panel10
        '
        Me.Panel10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.293R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.Panel10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel11
        '
        Me.Panel11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.Panel11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel11.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'rpt_trainyearakane
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1, Me.ReportFooterSection1})
        Me.Name = "rpttrainyearakane"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(0.17R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents Panel8 As Telerik.Reporting.Panel
    Friend WithEvents Panel7 As Telerik.Reporting.Panel
    Friend WithEvents ReportFooterSection1 As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents Panel9 As Telerik.Reporting.Panel
    Friend WithEvents Panel11 As Telerik.Reporting.Panel
    Friend WithEvents Panel10 As Telerik.Reporting.Panel
End Class