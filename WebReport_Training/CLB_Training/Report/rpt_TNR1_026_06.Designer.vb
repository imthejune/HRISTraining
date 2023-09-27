Partial Class rpt_TNR1_026_06
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.lbl_C1 = New Telerik.Reporting.TextBox()
        Me.lbl_C3 = New Telerik.Reporting.TextBox()
        Me.lbl_C5 = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.lbl_C4 = New Telerik.Reporting.TextBox()
        Me.lbl_C2 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.lbl_Header = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R)
        Me.groupFooterSection.Name = "groupFooterSection"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0R)
        Me.groupHeaderSection.Name = "groupHeaderSection"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.3520833253860474R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_C1, Me.lbl_C3, Me.lbl_C5, Me.Shape1, Me.Shape2, Me.lbl_C4, Me.lbl_C2, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11})
        Me.detail.Name = "detail"
        '
        'lbl_C1
        '
        Me.lbl_C1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.29999998211860657R), Telerik.Reporting.Drawing.Unit.Inch(0.19999994337558746R))
        Me.lbl_C1.Name = "lbl_C1"
        Me.lbl_C1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C1.Style.Font.Bold = True
        Me.lbl_C1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C1.Value = "ชื่อสถานที่อบรม"
        '
        'lbl_C3
        '
        Me.lbl_C3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.29999998211860657R), Telerik.Reporting.Drawing.Unit.Inch(0.59999996423721313R))
        Me.lbl_C3.Name = "lbl_C3"
        Me.lbl_C3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C3.Style.Font.Bold = True
        Me.lbl_C3.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C3.Value = "ที่อยู่"
        '
        'lbl_C5
        '
        Me.lbl_C5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9000003337860107R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.lbl_C5.Name = "lbl_C5"
        Me.lbl_C5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79999983310699463R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C5.Style.Font.Bold = True
        Me.lbl_C5.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C5.Value = "เบอร์โทรศัพท์"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0000000033113691788599908R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.677126407623291R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.3000000715255737R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6771259307861328R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'lbl_C4
        '
        Me.lbl_C4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.30000007152557373R), Telerik.Reporting.Drawing.Unit.Inch(0.99999994039535522R))
        Me.lbl_C4.Name = "lbl_C4"
        Me.lbl_C4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C4.Style.Font.Bold = True
        Me.lbl_C4.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C4.Value = "บุคคลติดต่อ"
        '
        'lbl_C2
        '
        Me.lbl_C2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9000003337860107R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C2.Name = "lbl_C2"
        Me.lbl_C2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C2.Style.Font.Bold = True
        Me.lbl_C2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C2.Value = "ชื่ออังกฤษ"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.21831066906452179R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox7.Value = "= Fields.InstitueTrainNameT"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.61831063032150269R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.0999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox8.Value = "= Fields.InstitueTrainAddress"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(1.018310546875R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox9.Value = "= Fields.InstitueTrainConPerson"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox10.Value = "= Fields.InstitueTrainNameE"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(1.018310546875R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox11.Value = "= Fields.InstitueTrainTel"
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.60000008344650269R)
        Me.PageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_Header})
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'lbl_Header
        '
        Me.lbl_Header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0R), Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R))
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_Header.Style.Font.Bold = True
        Me.lbl_Header.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.lbl_Header.Value = "รายงานสถานที่อบรม"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-UVBOUBQ\SQLEXPRESS;Initial Catalog=dbTraining;Integrated Secu" & _
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "select ROW_NUMBER() OVER(ORDER BY InstitueTrainID ASC) AS r,InstitueTrainNameT,In" & _
    "stitueTrainNameE,InstitueTrainTel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ",InstitueTrainAddress,InstitueTrainConPerson " & _
    "from TNM_InstitueTrain"
        '
        'rpt_TNR1_026_06
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.detail, Me.PageHeaderSection1})
        Me.Name = "rpt_TNR1_026_06"
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
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents lbl_Header As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C3 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C5 As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents lbl_C4 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
End Class