Partial Class rpt_Alert1

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_Alert1))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim Group2 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource = New Telerik.Reporting.SqlDataSource()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1R)
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.236R)
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1R)
        Me.groupFooterSection1.Name = "groupFooterSection1"
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.505R)
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.7R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2.359R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1})
        Me.detail.Name = "detail"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel2, Me.TextBox1})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.16R), Telerik.Reporting.Drawing.Unit.Inch(0.155R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.498R), Telerik.Reporting.Drawing.Unit.Inch(2.004R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'Panel2
        '
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.24R), Telerik.Reporting.Drawing.Unit.Inch(1.804R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.1R), Telerik.Reporting.Drawing.Unit.Inch(0.052R))
        Me.Panel2.Style.BackgroundColor = System.Drawing.Color.Black
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.1R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'SqlDataSource
        '
        Me.SqlDataSource.ConnectionString = "CLB_Training.My.MySettings.repair"
        Me.SqlDataSource.Name = "SqlDataSource"
        Me.SqlDataSource.SelectCommand = resources.GetString("SqlDataSource.SelectCommand")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.54R), Telerik.Reporting.Drawing.Unit.Inch(0.304R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Value = "TextBox1"
        '
        'rpt_Alert1
        '
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.PrositionName"))
        Group1.Name = "group"
        Group2.GroupFooter = Me.groupFooterSection1
        Group2.GroupHeader = Me.groupHeaderSection1
        Group2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.GUID_Train"))
        Group2.Name = "group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1, Group2})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.groupHeaderSection1, Me.groupFooterSection1, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "RptAlert1"
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
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents SqlDataSource As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class