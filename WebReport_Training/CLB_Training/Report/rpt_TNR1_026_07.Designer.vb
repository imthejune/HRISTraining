Partial Class rpt_TNR1_026_07
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.lbl_Header = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.lbl_C2 = New Telerik.Reporting.TextBox()
        Me.lbl_C5 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.lbl_C6 = New Telerik.Reporting.TextBox()
        Me.lbl_C3 = New Telerik.Reporting.TextBox()
        Me.lbl_C1 = New Telerik.Reporting.TextBox()
        Me.lbl_C4 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
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
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.85208344459533691R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.lbl_Header, Me.Shape1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'lbl_Header
        '
        Me.lbl_Header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R))
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.90625R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_Header.Style.Font.Bold = True
        Me.lbl_Header.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_Header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.lbl_Header.Value = "รายงานหน่วยงานที่จัดอบรม"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.3333333730697632R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11, Me.TextBox10, Me.TextBox9, Me.TextBox8, Me.TextBox7, Me.lbl_C2, Me.lbl_C5, Me.Shape2, Me.lbl_C6, Me.lbl_C3, Me.lbl_C1, Me.lbl_C4, Me.TextBox13})
        Me.detail.Name = "detail"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(1.0078939199447632R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox11.Value = "= Fields.Organize_Fax"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.1875R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox10.Value = "= Fields.Organize_Detail"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1000000238418579R), Telerik.Reporting.Drawing.Unit.Inch(0.99747723340988159R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8958332538604736R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox9.Value = "= Fields.Organize_Tel"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R), Telerik.Reporting.Drawing.Unit.Inch(0.60416668653488159R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5000002384185791R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox8.Value = "= Fields.Organize_Address"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5R), Telerik.Reporting.Drawing.Unit.Inch(0.1979166716337204R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox7.Value = "= Fields.Organize_Name"
        '
        'lbl_C2
        '
        Me.lbl_C2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0R), Telerik.Reporting.Drawing.Unit.Inch(0.1875R))
        Me.lbl_C2.Name = "lbl_C2"
        Me.lbl_C2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C2.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C2.Value = "รายละเอียด"
        '
        'lbl_C5
        '
        Me.lbl_C5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19583351910114288R), Telerik.Reporting.Drawing.Unit.Inch(0.97916668653488159R))
        Me.lbl_C5.Name = "lbl_C5"
        Me.lbl_C5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C5.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C5.Value = "เบอร์โทรศัพท์"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.28125R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.6771259307861328R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0157479178160429R), Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.677126407623291R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        '
        'lbl_C6
        '
        Me.lbl_C6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.98958331346511841R))
        Me.lbl_C6.Name = "lbl_C6"
        Me.lbl_C6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49999997019767761R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C6.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C6.Value = "แฟกซ์"
        '
        'lbl_C3
        '
        Me.lbl_C3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19583351910114288R), Telerik.Reporting.Drawing.Unit.Inch(0.58333331346511841R))
        Me.lbl_C3.Name = "lbl_C3"
        Me.lbl_C3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R), Telerik.Reporting.Drawing.Unit.Inch(0.19992120563983917R))
        Me.lbl_C3.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C3.Value = "ที่อยู่"
        '
        'lbl_C1
        '
        Me.lbl_C1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19583351910114288R), Telerik.Reporting.Drawing.Unit.Inch(0.1875R))
        Me.lbl_C1.Name = "lbl_C1"
        Me.lbl_C1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2082545757293701R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C1.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C1.Value = "ชื่อหน่วยงานที่จัดอบรม"
        '
        'lbl_C4
        '
        Me.lbl_C4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5000004768371582R), Telerik.Reporting.Drawing.Unit.Inch(0.58333331346511841R))
        Me.lbl_C4.Name = "lbl_C4"
        Me.lbl_C4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.lbl_C4.Style.Font.Name = "BrowalliaUPC"
        Me.lbl_C4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.lbl_C4.Value = "บุคคลติดต่อ"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.60416668653488159R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox13.Value = "= Fields.Organize_ConPerson"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=DESKTOP-UVBOUBQ\SQLEXPRESS;Initial Catalog=dbTraining;Integrated Secu" & _
    "rity=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = "select Organize_NameT as Organize_Name,Organize_Detail,Organize_Address,Organize_" & _
    "ConPerson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ",Organize_Tel,Organize_Fax from TNM_Organize"
        '
        'rpt_TNR1_026_07
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detail})
        Me.Name = "rpt_TNR1_026_07"
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
    Friend WithEvents lbl_C5 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents lbl_C6 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C3 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C1 As Telerik.Reporting.TextBox
    Friend WithEvents lbl_C4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
End Class