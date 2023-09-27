Partial Class rpt_FyFp21_sub_totalEmp

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_FyFp21_sub_totalEmp))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.lbl_N = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.Shape10 = New Telerik.Reporting.Shape()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.lbl_Num = New Telerik.Reporting.TextBox()
        Me.lbl_Person1 = New Telerik.Reporting.TextBox()
        Me.lbl_Person2 = New Telerik.Reporting.TextBox()
        Me.lbl_Male = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.lbl_Female = New Telerik.Reporting.TextBox()
        Me.lbl_Person3 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        Me.detail.DocumentMapText = ""
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.62958335876464844R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_N, Me.TextBox1, Me.Shape10, Me.TextBox2, Me.lbl_Num, Me.lbl_Person1, Me.lbl_Person2, Me.lbl_Male, Me.Shape1, Me.TextBox7, Me.TextBox8, Me.Shape2, Me.lbl_Female, Me.lbl_Person3})
        Me.detail.KeepTogether = False
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = True
        '
        'lbl_N
        '
        Me.lbl_N.Format = "{0}"
        Me.lbl_N.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.083333194255828857R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_N.Name = "lbl_N"
        Me.lbl_N.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.34950515627861023R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_N.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_N.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_N.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_N.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_N.Value = "รุ่นที่"
        '
        'TextBox1
        '
        Me.TextBox1.Format = "{0}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.8330492973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.026458330452442169R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2977499961853027R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox1.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.ApprovePerson"
        '
        'Shape10
        '
        Me.Shape10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.8330492973327637R), Telerik.Reporting.Drawing.Unit.Cm(0.44097241759300232R))
        Me.Shape10.Name = "Shape10"
        Me.Shape10.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3017354011535645R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape10.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'TextBox2
        '
        Me.TextBox2.Format = "{0}"
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.65321236848831177R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.34950515627861023R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.TextBox2.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "= Fields.Patern_N"
        '
        'lbl_Num
        '
        Me.lbl_Num.Format = "{0}"
        Me.lbl_Num.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2100683450698853R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Num.Name = "lbl_Num"
        Me.lbl_Num.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_Num.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Num.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Num.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Num.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Num.Value = "จำนวนรวม"
        '
        'lbl_Person1
        '
        Me.lbl_Person1.Format = "{0}"
        Me.lbl_Person1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5381989479064941R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Person1.Name = "lbl_Person1"
        Me.lbl_Person1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_Person1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Person1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Person1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Person1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Person1.Value = "คน"
        '
        'lbl_Person2
        '
        Me.lbl_Person2.Format = "{0}"
        Me.lbl_Person2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4444494247436523R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Person2.Name = "lbl_Person2"
        Me.lbl_Person2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37728294730186462R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_Person2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Person2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Person2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Person2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Person2.Value = "คน"
        '
        'lbl_Male
        '
        Me.lbl_Male.Format = "{0}"
        Me.lbl_Male.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.041670560836792R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Male.Name = "lbl_Male"
        Me.lbl_Male.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_Male.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Male.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Male.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Male.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Male.Value = "ชาย"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.1810579299926758R), Telerik.Reporting.Drawing.Unit.Cm(0.42333337664604187R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3017354011535645R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.1810579299926758R), Telerik.Reporting.Drawing.Unit.Cm(-0.0000000013141996380028331R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2977499961853027R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox7.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "= Fields.ApproveMale"
        '
        'TextBox8
        '
        Me.TextBox8.Format = "{0}"
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.599582672119141R), Telerik.Reporting.Drawing.Unit.Cm(-0.0000000013141996380028331R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2977499961853027R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox8.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "= Fields.ApproveFemale"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.599582672119141R), Telerik.Reporting.Drawing.Unit.Cm(0.39687502384185791R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3017354011535645R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape2.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.10000000149011612R)
        '
        'lbl_Female
        '
        Me.lbl_Female.Format = "{0}"
        Me.lbl_Female.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.78125R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Female.Name = "lbl_Female"
        Me.lbl_Female.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79394960403442383R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_Female.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Female.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Female.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Female.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Female.Value = "หญิง"
        '
        'lbl_Person3
        '
        Me.lbl_Person3.Format = "{0}"
        Me.lbl_Person3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.1770834922790527R), Telerik.Reporting.Drawing.Unit.Inch(-0.00000000051740145501355528R))
        Me.lbl_Person3.Name = "lbl_Person3"
        Me.lbl_Person3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.37728294730186462R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.lbl_Person3.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Person3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_Person3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.lbl_Person3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.lbl_Person3.Value = "คน"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-UVBOUBQ\SQLEXPRESS;Initial Catalog=dbTraining;Integrated Secu" & _
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@GUID_Ref", System.Data.DbType.[String], "= Parameters.GUID_Ref.Value"), New Telerik.Reporting.SqlDataSourceParameter("@GUID_Fyfp", System.Data.DbType.[String], "= Parameters.GUID_Fyfp.Value")})
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'rpt_FyFp21_sub_totalEmp
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_FyFp21_sub_totalEmp"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "GUID_Ref"
        ReportParameter2.Name = "GUID_Fyfp"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(17.415384292602539R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents lbl_N As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents Shape10 As Telerik.Reporting.Shape
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Num As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Person1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Person2 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Male As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents lbl_Female As Telerik.Reporting.TextBox
    Friend WithEvents lbl_Person3 As Telerik.Reporting.TextBox
End Class