Partial Class rpt_TNR1_026_08
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_TNR1_026_08))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.lbl_Header = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.lbl_C2 = New Telerik.Reporting.TextBox()
        Me.lbl_C6 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.lbl_C7 = New Telerik.Reporting.TextBox()
        Me.lbl_C5 = New Telerik.Reporting.TextBox()
        Me.lbl_C1 = New Telerik.Reporting.TextBox()
        Me.lbl_C3 = New Telerik.Reporting.TextBox()
        Me.lbl_C4 = New Telerik.Reporting.TextBox()
        Me.lbl_C9 = New Telerik.Reporting.TextBox()
        Me.lbl_C8 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.lbl_C10 = New Telerik.Reporting.TextBox()
        Me.lbl_C11 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.Shape3 = New Telerik.Reporting.Shape()
        Me.HtmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.8118056058883667R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_Header, Me.Shape1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'lbl_Header
        '
        Me.lbl_Header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R))
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2062501907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_Header.Style.Font.Bold = True
        Me.lbl_Header.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.lbl_Header.Value = "รายงานวิทยากร"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.015747705474495888R), Telerik.Reporting.Drawing.Unit.Inch(0.69305562973022461R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.677126407623291R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(3.0881946086883545R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox8, Me.TextBox7, Me.lbl_C2, Me.lbl_C6, Me.Shape2, Me.lbl_C7, Me.lbl_C5, Me.lbl_C1, Me.lbl_C3, Me.lbl_C4, Me.lbl_C9, Me.lbl_C8, Me.TextBox16, Me.TextBox17, Me.lbl_C10, Me.lbl_C11, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.Shape3, Me.HtmlTextBox1})
        Me.detail.Name = "detail"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7604165077209473R), Telerik.Reporting.Drawing.Unit.Inch(1.4000002145767212R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox11.Value = "= Fields.Professor_Fax"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.75R), Telerik.Reporting.Drawing.Unit.Inch(0.205810546875R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox10.Value = "= Fields.Professor_NameE"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.4183107614517212R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3541665077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox9.Value = "= Fields.Professor_Tel"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.0183106660842896R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1499996185302734R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox8.Value = "= Fields.Professor_Address"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.205810546875R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3541665077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox7.Value = "= Fields.Professor_NameT"
        '
        'lbl_C2
        '
        Me.lbl_C2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.75R), Telerik.Reporting.Drawing.Unit.Inch(0.1875R))
        Me.lbl_C2.Name = "lbl_C2"
        Me.lbl_C2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.65000009536743164R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C2.Style.Font.Bold = True
        Me.lbl_C2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C2.Value = "ชื่ออังกฤษ"
        '
        'lbl_C6
        '
        Me.lbl_C6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1458333283662796R), Telerik.Reporting.Drawing.Unit.Inch(1.4000002145767212R))
        Me.lbl_C6.Name = "lbl_C6"
        Me.lbl_C6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.85416668653488159R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C6.Style.Font.Bold = True
        Me.lbl_C6.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C6.Value = "เบอร์โทรศัพท์"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(3.0R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6771259307861328R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'lbl_C7
        '
        Me.lbl_C7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7604167461395264R), Telerik.Reporting.Drawing.Unit.Inch(1.4000002145767212R))
        Me.lbl_C7.Name = "lbl_C7"
        Me.lbl_C7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.45000007748603821R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C7.Style.Font.Bold = True
        Me.lbl_C7.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C7.Value = "แฟกซ์"
        '
        'lbl_C5
        '
        Me.lbl_C5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.14583341777324677R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.lbl_C5.Name = "lbl_C5"
        Me.lbl_C5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C5.Style.Font.Bold = True
        Me.lbl_C5.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C5.Value = "ที่อยู่"
        '
        'lbl_C1
        '
        Me.lbl_C1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1458333283662796R), Telerik.Reporting.Drawing.Unit.Inch(0.1875R))
        Me.lbl_C1.Name = "lbl_C1"
        Me.lbl_C1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C1.Style.Font.Bold = True
        Me.lbl_C1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C1.Value = "ชื่อวิทยากร"
        '
        'lbl_C3
        '
        Me.lbl_C3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.14583341777324677R), Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269R))
        Me.lbl_C3.Name = "lbl_C3"
        Me.lbl_C3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69999986886978149R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C3.Style.Font.Bold = True
        Me.lbl_C3.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C3.Value = "รายละเอียด"
        '
        'lbl_C4
        '
        Me.lbl_C4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7604167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269R))
        Me.lbl_C4.Name = "lbl_C4"
        Me.lbl_C4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79999995231628418R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C4.Style.Font.Bold = True
        Me.lbl_C4.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C4.Value = "วุฒิการศึกษา"
        '
        'lbl_C9
        '
        Me.lbl_C9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7604167461395264R), Telerik.Reporting.Drawing.Unit.Inch(1.8000001907348633R))
        Me.lbl_C9.Name = "lbl_C9"
        Me.lbl_C9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.53958350419998169R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C9.Style.Font.Bold = True
        Me.lbl_C9.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C9.Value = "ตำแหน่ง"
        '
        'lbl_C8
        '
        Me.lbl_C8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1458333283662796R), Telerik.Reporting.Drawing.Unit.Inch(1.8000001907348633R))
        Me.lbl_C8.Name = "lbl_C8"
        Me.lbl_C8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C8.Style.Font.Bold = True
        Me.lbl_C8.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C8.Value = "บุคคลติดต่อ"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(1.8183107376098633R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3541665077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox16.Value = "= Fields.Professor_ConPerson"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7604165077209473R), Telerik.Reporting.Drawing.Unit.Inch(1.8183107376098633R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5895833969116211R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox17.Value = "= Fields.Professor_Position"
        '
        'lbl_C10
        '
        Me.lbl_C10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164R), Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R))
        Me.lbl_C10.Name = "lbl_C10"
        Me.lbl_C10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89999991655349731R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C10.Style.Font.Bold = True
        Me.lbl_C10.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C10.Value = "วิทยากรภายใน"
        '
        'lbl_C11
        '
        Me.lbl_C11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1458333283662796R), Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R))
        Me.lbl_C11.Name = "lbl_C11"
        Me.lbl_C11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.69375020265579224R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C11.Style.Font.Bold = True
        Me.lbl_C11.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C11.Value = "อื่นๆ Other"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.61831063032150269R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3541665077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox20.Value = "= Fields.Professor_Detail"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7604165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.61831063032150269R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox21.Value = "= Fields.Professor_Education"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(2.6183106899261475R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.1499996185302734R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox22.Value = "= Fields.Professor_Reason"
        '
        'Shape3
        '
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45.0R, 0)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        '
        'HtmlTextBox1
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Fields.Professor_Institue", Telerik.Reporting.FilterOperator.Equal, "= False"))
        FormattingRule1.Style.Visible = False
        Me.HtmlTextBox1.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.HtmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(2.25R))
        Me.HtmlTextBox1.Name = "HtmlTextBox1"
        Me.HtmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R), Telerik.Reporting.Drawing.Unit.Inch(0.20577812194824219R))
        Me.HtmlTextBox1.Value = resources.GetString("HtmlTextBox1.Value")
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-UVBOUBQ\SQLEXPRESS;Initial Catalog=dbTraining;Integrated Secu" & _
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_TNR1_026_08
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detail})
        Me.Name = "rpt_TNR1_026_08"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.540000915527344R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents lbl_Header As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C2 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C6 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents lbl_C7 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C5 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C3 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C4 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C9 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C10 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents HtmlTextBox1 As Telerik.Reporting.HtmlTextBox
End Class