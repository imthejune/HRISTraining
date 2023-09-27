Partial Class rpt_TimeTAM_Holiday

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_TimeTAM_Holiday))
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.Txt_ReportName = New Telerik.Reporting.TextBox()
        Me.Txt_CompanyName = New Telerik.Reporting.TextBox()
        Me.pic_Logo = New Telerik.Reporting.PictureBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.txt_Holiday_Date = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.Txt_ISO = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TxtDatePrint = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.9076459407806396R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Txt_ReportName, Me.Txt_CompanyName, Me.pic_Logo, Me.Shape1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'Txt_ReportName
        '
        Me.Txt_ReportName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0000000055630975381859571R), Telerik.Reporting.Drawing.Unit.Cm(0.76770830154418945R))
        Me.Txt_ReportName.Name = "Txt_ReportName"
        Me.Txt_ReportName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.426460266113281R), Telerik.Reporting.Drawing.Unit.Cm(0.65604156255722046R))
        Me.Txt_ReportName.Style.Font.Bold = False
        Me.Txt_ReportName.Style.Font.Name = "BrowalliaUPC"
        Me.Txt_ReportName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.Txt_ReportName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.Txt_ReportName.Value = "รายงาน สรุปวันทำงาน ระหว่างวันที่ 1/2/2558 ถึง 31/2/2558"
        '
        'Txt_CompanyName
        '
        Me.Txt_CompanyName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.Txt_CompanyName.Name = "Txt_CompanyName"
        Me.Txt_CompanyName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.458755493164063R), Telerik.Reporting.Drawing.Unit.Cm(0.79999995231628418R))
        Me.Txt_CompanyName.Style.Font.Bold = True
        Me.Txt_CompanyName.Style.Font.Name = "BrowalliaUPC"
        Me.Txt_CompanyName.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        Me.Txt_CompanyName.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.Txt_CompanyName.Value = "TIGER SOFT (1998) CO., LTD."
        '
        'pic_Logo
        '
        Me.pic_Logo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.026458332315087318R), Telerik.Reporting.Drawing.Unit.Cm(0.1354166716337204R))
        Me.pic_Logo.MimeType = "image/png"
        Me.pic_Logo.Name = "pic_Logo"
        Me.pic_Logo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(1.2058333158493042R))
        Me.pic_Logo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.pic_Logo.Style.BackgroundImage.MimeType = ""
        Me.pic_Logo.Style.Visible = True
        Me.pic_Logo.Value = CType(resources.GetObject("pic_Logo.Value"), Object)
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0793749988079071R), Telerik.Reporting.Drawing.Unit.Cm(1.6139585971832275R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.317775726318359R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        Me.Shape1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        '
        'detail
        '
        Me.detail.DocumentMapText = ""
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.81173640489578247R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txt_Holiday_Date, Me.TextBox1})
        Me.detail.Name = "detail"
        Me.detail.Style.Visible = True
        '
        'txt_Holiday_Date
        '
        Me.txt_Holiday_Date.Format = "{0:d}"
        Me.txt_Holiday_Date.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2777776718139648R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.txt_Holiday_Date.Name = "txt_Holiday_Date"
        Me.txt_Holiday_Date.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5630468130111694R), Telerik.Reporting.Drawing.Unit.Inch(0.24786747992038727R))
        Me.txt_Holiday_Date.Style.Font.Name = "BrowalliaUPC"
        Me.txt_Holiday_Date.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.txt_Holiday_Date.Value = "= Fields.Group_NameT"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.90595149993896484R)
        Me.pageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Txt_ISO, Me.TextBox4, Me.TxtDatePrint})
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'Txt_ISO
        '
        Me.Txt_ISO.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.1382635235786438R), Telerik.Reporting.Drawing.Unit.Cm(0.30595120787620544R))
        Me.Txt_ISO.Name = "Txt_ISO"
        Me.Txt_ISO.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(11.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.60000008344650269R))
        Me.Txt_ISO.Style.Font.Bold = False
        Me.Txt_ISO.Style.Font.Name = "BrowalliaUPC"
        Me.Txt_ISO.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.Txt_ISO.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.Txt_ISO.Value = "ISO Number"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.864580154418945R), Telerik.Reporting.Drawing.Unit.Cm(0.30595120787620544R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4999990463256836R), Telerik.Reporting.Drawing.Unit.Cm(0.60000032186508179R))
        Me.TextBox4.Style.Font.Name = "BrowalliaUPC"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox4.Value = "= PageNumber + '/' + PageCount"
        '
        'TxtDatePrint
        '
        Me.TxtDatePrint.Format = "{0:dd/MMM/yyyy HH:mm:ss}"
        Me.TxtDatePrint.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.997156143188477R), Telerik.Reporting.Drawing.Unit.Cm(0.30595120787620544R))
        Me.TxtDatePrint.Name = "TxtDatePrint"
        Me.TxtDatePrint.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7116656303405762R), Telerik.Reporting.Drawing.Unit.Cm(0.60000032186508179R))
        Me.TxtDatePrint.Style.Font.Name = "BrowalliaUPC"
        Me.TxtDatePrint.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TxtDatePrint.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TxtDatePrint.Value = "= Now()"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "CLB_Training.My.MySettings.CyberHRM"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.SelectCommand = "SELECT * FROM TNM_GroupCourse"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.948957443237305R), Telerik.Reporting.Drawing.Unit.Cm(0.12964567542076111R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox1.Value = "TextBox1"
        '
        'rpt_TimeTAM_Holiday
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rpt_TimeTAM_Holiday"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.25R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.488054275512695R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents Txt_ReportName As Telerik.Reporting.TextBox
    Friend WithEvents Txt_ISO As Telerik.Reporting.TextBox
    Friend WithEvents Txt_CompanyName As Telerik.Reporting.TextBox
    Friend WithEvents TxtDatePrint As Telerik.Reporting.TextBox
    Friend WithEvents pic_Logo As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents txt_Holiday_Date As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class