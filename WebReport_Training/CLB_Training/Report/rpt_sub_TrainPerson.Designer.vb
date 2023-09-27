Partial Class rpt_sub_TrainPerson
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_sub_TrainPerson))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.18R)
        Me.groupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1})
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Inch(0.18R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.26R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox45, Me.TextBox5, Me.TextBox43, Me.TextBox19, Me.TextBox44, Me.Panel3})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        Me.groupHeaderSection.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.974R), Telerik.Reporting.Drawing.Unit.Inch(0.026R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.652R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox45.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox45.Value = "ชั่วโมง"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.307R), Telerik.Reporting.Drawing.Unit.Inch(0.026R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox5.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox5.Value = "รหัสพนักงาน"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9R), Telerik.Reporting.Drawing.Unit.Inch(0.026R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox43.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox43.Value = "ตำแหน่ง"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.026R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox19.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox19.Value = "ชื่อ-นามสกุล"
        '
        'TextBox44
        '
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6R), Telerik.Reporting.Drawing.Unit.Inch(0.026R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.492R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox44.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox44.Value = "แผนก"
        '
        'Panel3
        '
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Inch(0.26R))
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.26R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox41, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.Panel2})
        Me.detail.Name = "detail"
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.307R), Telerik.Reporting.Drawing.Unit.Inch(0.04R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox41.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox41.Value = "= Fields.PersonCode"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.035R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox1.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox1.Value = "= Fields.SubTrainName"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.604R), Telerik.Reporting.Drawing.Unit.Inch(0.035R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Value = "= Fields.PrositionName"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.24R), Telerik.Reporting.Drawing.Unit.Inch(0.035R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox3.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox3.Value = "= Fields.departName"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.0R), Telerik.Reporting.Drawing.Unit.Inch(0.04R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Value = "= Fields.TotalHour"
        '
        'Panel2
        '
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Inch(0.26R))
        Me.Panel2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11508\SQLEXPRESS01;Initial Catalog=HrisTraining;Integrated Security" &
    "=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@GUID_Patern", System.Data.DbType.[String], "= Parameters.GUID_Patern.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_sub_TrainPerson
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.GUID_Patern"))
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_sub_TrainPerson"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "GUID_Patern"
        ReportParameter1.Text = "GUID_Patern"
        Me.ReportParameters.Add(ReportParameter1)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.1R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
End Class