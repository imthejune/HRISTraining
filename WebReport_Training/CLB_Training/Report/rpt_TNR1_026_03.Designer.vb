Partial Class rpt_TNR1_026_03
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_TNR1_026_03))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.lbl_C4 = New Telerik.Reporting.TextBox()
        Me.lbl_C2 = New Telerik.Reporting.TextBox()
        Me.lbl_C1 = New Telerik.Reporting.TextBox()
        Me.lbl_C3 = New Telerik.Reporting.TextBox()
        Me.lbl_C5 = New Telerik.Reporting.TextBox()
        Me.lbl_C6 = New Telerik.Reporting.TextBox()
        Me.lbl_Header = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.lbl_To2 = New Telerik.Reporting.TextBox()
        Me.lbl_To1 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000003576278687R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Shape2, Me.Shape1, Me.lbl_C4, Me.lbl_C2, Me.lbl_C1, Me.lbl_C3, Me.lbl_C5, Me.lbl_C6})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.29999995231628418R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.74918270111084R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.000000013245476715439963R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.74918270111084R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'lbl_C4
        '
        Me.lbl_C4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7395832538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.091666698455810547R))
        Me.lbl_C4.Name = "lbl_C4"
        Me.lbl_C4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39999958872795105R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C4.Style.Font.Bold = True
        Me.lbl_C4.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C4.Value = "ครั้งที่"
        '
        'lbl_C2
        '
        Me.lbl_C2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84375R), Telerik.Reporting.Drawing.Unit.Inch(0.091666698455810547R))
        Me.lbl_C2.Name = "lbl_C2"
        Me.lbl_C2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000019073486328R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C2.Style.Font.Bold = True
        Me.lbl_C2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C2.Value = "รหัสหลักสูตร"
        '
        'lbl_C1
        '
        Me.lbl_C1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1458333283662796R), Telerik.Reporting.Drawing.Unit.Inch(0.091666698455810547R))
        Me.lbl_C1.Name = "lbl_C1"
        Me.lbl_C1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.50833350419998169R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C1.Style.Font.Bold = True
        Me.lbl_C1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C1.Value = "ลำดับที่"
        '
        'lbl_C3
        '
        Me.lbl_C3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7395833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.091666698455810547R))
        Me.lbl_C3.Name = "lbl_C3"
        Me.lbl_C3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999999523162842R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C3.Style.Font.Bold = True
        Me.lbl_C3.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C3.Value = "ชื่อหลักสูตร"
        '
        'lbl_C5
        '
        Me.lbl_C5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.84375R), Telerik.Reporting.Drawing.Unit.Inch(0.091666698455810547R))
        Me.lbl_C5.Name = "lbl_C5"
        Me.lbl_C5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C5.Style.Font.Bold = True
        Me.lbl_C5.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C5.Value = "วันที่อบรม"
        '
        'lbl_C6
        '
        Me.lbl_C6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5416665077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.10208328813314438R))
        Me.lbl_C6.Name = "lbl_C6"
        Me.lbl_C6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80625098943710327R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C6.Style.Font.Bold = True
        Me.lbl_C6.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C6.Value = "เวลาอบรม"
        '
        'lbl_Header
        '
        Me.lbl_Header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.29999998211860657R))
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7854169607162476R), Telerik.Reporting.Drawing.Unit.Inch(0.2520831823348999R))
        Me.lbl_Header.Style.Font.Bold = True
        Me.lbl_Header.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.lbl_Header.Value = "รายงานหลักสูตรการอบรม"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.25R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox17, Me.lbl_To2, Me.lbl_To1, Me.TextBox14, Me.TextBox13, Me.TextBox12, Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox8})
        Me.detail.Name = "detail"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.0416665077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47704845666885376R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox17.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox17.Value = "= Format('{0:HH:mm}', Fields.TrainDay_EndTime)"
        '
        'lbl_To2
        '
        Me.lbl_To2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.84375R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.lbl_To2.Name = "lbl_To2"
        Me.lbl_To2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.19992212951183319R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.lbl_To2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_To2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_To2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.lbl_To2.Value = "ถึง"
        '
        'lbl_To1
        '
        Me.lbl_To1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1458334922790527R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.lbl_To1.Name = "lbl_To1"
        Me.lbl_To1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.19999970495700836R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.lbl_To1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_To1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_To1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.lbl_To1.Value = "ถึง"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000030994415283R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox14.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.Value = "=dateFormat(Fields.TrainDay_End, Fields.lang) "
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4375R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.40000051259994507R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox13.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.Value = "= Format('{0:HH:mm}', Fields.TrainDay_Time) "
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.34375R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7999998927116394R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox12.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.Value = "=dateFormat(Fields.TrainDay_Date, Fields.lang)"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7395832538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.299999862909317R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox11.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox11.Value = "= Fields.Patern_N"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7395833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999999761581421R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox10.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.Value = "= Fields.RefName"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.84375R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.80000013113021851R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox9.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Value = "= Fields.Patern_Code"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1458333283662796R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.39999997615814209R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox8.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.Value = "= Fields.r"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-UVBOUBQ\SQLEXPRESS;Initial Catalog=dbTraining;Integrated Secu" & _
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R)
        Me.PageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_Header})
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'rpt_TNR1_026_03
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.detail, Me.PageHeaderSection1})
        Me.Name = "rpt_TNR1_026_03"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.682924270629883R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents lbl_C4 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C2 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Header As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C3 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C5 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_To2 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_To1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
End Class