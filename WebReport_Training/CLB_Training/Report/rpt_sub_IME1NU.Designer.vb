Partial Class rpt_sub_IME1NU
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_sub_IME1NU))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Panel2 = New Telerik.Reporting.Panel()
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
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.Panel5 = New Telerik.Reporting.Panel()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.Visible = False
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29999998211860657R)
        Me.groupHeaderSection.Name = "groupHeaderSection"
        Me.groupHeaderSection.Style.Visible = False
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.39999988675117493R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel2})
        Me.detail.Name = "detail"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox12, Me.Panel6, Me.Panel7, Me.TextBox13, Me.Panel8, Me.TextBox14, Me.Panel9, Me.TextBox15, Me.Panel10, Me.TextBox16, Me.TextBox10, Me.TextBox9, Me.TextBox8, Me.Panel4, Me.Panel5, Me.Panel3})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.599960327148437R), Telerik.Reporting.Drawing.Unit.Inch(0.39996048808097839R))
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.026349492371082306R), Telerik.Reporting.Drawing.Unit.Inch(0.089543856680393219R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3999212384223938R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "=RowNumber()"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.54517835378646851R), Telerik.Reporting.Drawing.Unit.Inch(0.020100215449929237R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1547822952270508R), Telerik.Reporting.Drawing.Unit.Inch(0.3611103892326355R))
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox12.Value = "= Fields.PaternRefName"
        '
        'Panel6
        '
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.49301615357398987R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39996048808097839R))
        Me.Panel6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel7
        '
        Me.Panel7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.719752311706543R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39996051788330078R))
        Me.Panel7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7719147205352783R), Telerik.Reporting.Drawing.Unit.Inch(0.016974607482552528R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.82804590463638306R), Telerik.Reporting.Drawing.Unit.Inch(0.364236056804657R))
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "= dateFormat(Fields.TrainDay_Date,'T') + '-' + dateFormat(Fields.TrainDay_End,'T'" & _
    ")"
        '
        'Panel8
        '
        Me.Panel8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6197521686553955R), Telerik.Reporting.Drawing.Unit.Inch(-0.000000019868215517249155R))
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39992102980613708R))
        Me.Panel8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.736339807510376R), Telerik.Reporting.Drawing.Unit.Inch(0.0895441398024559R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90520846843719482R), Telerik.Reporting.Drawing.Unit.Inch(0.18993018567562103R))
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "=0"
        '
        'Panel9
        '
        Me.Panel9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.641627311706543R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39996048808097839R))
        Me.Panel9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel9.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6937899589538574R), Telerik.Reporting.Drawing.Unit.Inch(0.08954397588968277R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0061709880828857R), Telerik.Reporting.Drawing.Unit.Inch(0.18993018567562103R))
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = "= Fields.ProfessorName"
        '
        'Panel10
        '
        Me.Panel10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7416272163391113R), Telerik.Reporting.Drawing.Unit.Inch(-0.000000019868215517249155R))
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39992102980613708R))
        Me.Panel10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel10.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7937140464782715R), Telerik.Reporting.Drawing.Unit.Inch(0.089543938636779785R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5062474012374878R), Telerik.Reporting.Drawing.Unit.Inch(0.18368013203144073R))
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "= Fields.InstitueTrainName"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.4999608993530273R), Telerik.Reporting.Drawing.Unit.Inch(0.0999605655670166R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.50000017881393433R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "=CoureOJT (Fields.TypeCourseName)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.21053695678711R), Telerik.Reporting.Drawing.Unit.Inch(0.0999605655670166R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.68958359956741333R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "= CourePublic(Fields.TypeCourseName)"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.060378074645996R), Telerik.Reporting.Drawing.Unit.Inch(0.0999605655670166R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.48958390951156616R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "= CoureinHouse(Fields.TypeCourseName)"
        '
        'Panel4
        '
        Me.Panel4.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1})
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.06053638458252R), Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39988172054290771R))
        Me.Panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel1
        '
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39988172054290771R))
        Me.Panel1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel5
        '
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.96053695678711R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.399960458278656R))
        Me.Panel5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel5.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel3
        '
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.3999605178833R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.052083518356084824R), Telerik.Reporting.Drawing.Unit.Inch(0.39988172054290771R))
        Me.Panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11508\SQLEXPRESS01;Initial Catalog=HrisTraining;Integrated Security" & _
    "=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@PersonID", System.Data.DbType.[String], "= Parameters.PersonID.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_sub_IME1NU
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PersonID"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_sub_IME1NU"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "PersonID"
        ReportParameter1.Text = "PersonID"
        Me.ReportParameters.Add(ReportParameter1)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.6000394821167R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents Panel7 As Telerik.Reporting.Panel
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents Panel8 As Telerik.Reporting.Panel
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents Panel9 As Telerik.Reporting.Panel
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents Panel10 As Telerik.Reporting.Panel
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
End Class