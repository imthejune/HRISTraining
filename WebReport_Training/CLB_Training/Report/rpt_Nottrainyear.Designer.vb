Partial Class rpt_Nottrainyear

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_Nottrainyear))
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
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
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.4095498323440552R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox24, Me.Panel1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6979166269302368R), Telerik.Reporting.Drawing.Unit.Inch(0.54166668653488159R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.6000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "รายงานพนักงานไม่ได้เข้าฝึกอบรม"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.39060786366462708R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel5})
        Me.detail.Name = "detail"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.19999991357326508R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Data Source=TG11508\SQLEXPRESS01;Initial Catalog=HrisTraining;Integrated Security" & _
    "=True"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.09375R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0986123085021973R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "= Fields.CompanyName"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox2, Me.Panel2, Me.Panel3, Me.Panel4, Me.TextBox3, Me.TextBox4, Me.TextBox5})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0001578330993652R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9999604225158691R), Telerik.Reporting.Drawing.Unit.Inch(0.409352570772171R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Inch(0.099960647523403168R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90000015497207642R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "รหัสพนักงาน"
        '
        'Panel2
        '
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.426389217376709R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R), Telerik.Reporting.Drawing.Unit.Inch(0.40927380323410034R))
        Me.Panel2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel3
        '
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.293055534362793R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R), Telerik.Reporting.Drawing.Unit.Inch(0.40931311249732971R))
        Me.Panel3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel4
        '
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R), Telerik.Reporting.Drawing.Unit.Inch(0.4091554582118988R))
        Me.Panel4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel4.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.099960751831531525R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8402776718139648R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "พนักงานที่ไม่ได้เข้าอบรม"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0999608039855957R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7805556058883667R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "ตำแหน่ง"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.90000057220459R), Telerik.Reporting.Drawing.Unit.Inch(0.0999608039855957R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7805556058883667R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "แผนก"
        '
        'Panel5
        '
        Me.Panel5.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.Panel6, Me.Panel8, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.Panel7, Me.TextBox11, Me.TextBox12})
        Me.Panel5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(-0.0000000130385160446167R), Telerik.Reporting.Drawing.Unit.Inch(0.000078943041444290429R))
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.9999604225158691R), Telerik.Reporting.Drawing.Unit.Inch(0.39052891731262207R))
        Me.Panel5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.50933563709259033R), Telerik.Reporting.Drawing.Unit.Inch(0.086362630128860474R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89066445827484131R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "= Fields.PersonCode"
        '
        'Panel6
        '
        Me.Panel6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.426389217376709R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R), Telerik.Reporting.Drawing.Unit.Inch(0.39045000076293945R))
        Me.Panel6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel8
        '
        Me.Panel8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492R))
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R), Telerik.Reporting.Drawing.Unit.Inch(0.39033174514770508R))
        Me.Panel8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5R), Telerik.Reporting.Drawing.Unit.Inch(0.086362689733505249R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "= Fields.InitialName"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.5R), Telerik.Reporting.Drawing.Unit.Inch(0.086362689733505249R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7979166507720947R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "= Fields.PrositionName"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.5202183723449707R), Telerik.Reporting.Drawing.Unit.Inch(0.086362689733505249R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4478380680084229R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "= Fields.departName"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.019405100494623184R), Telerik.Reporting.Drawing.Unit.Inch(0.0863625779747963R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.3999607264995575R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "=RowNumber() + '.'"
        '
        'Panel7
        '
        Me.Panel7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2930560111999512R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R), Telerik.Reporting.Drawing.Unit.Inch(0.39048942923545837R))
        Me.Panel7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel7.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.086362689733505249R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "= Fields.FnameT"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1562521457672119R), Telerik.Reporting.Drawing.Unit.Inch(0.086362689733505249R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "= Fields.LnameT"
        '
        'rpt_Nottrainyear
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "rptnottrainyear"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.17000000178813934R), Telerik.Reporting.Drawing.Unit.Inch(0.17000000178813934R), Telerik.Reporting.Drawing.Unit.Inch(0.17000000178813934R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.0093355178833R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents Panel5 As Telerik.Reporting.Panel
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents Panel6 As Telerik.Reporting.Panel
    Friend WithEvents Panel8 As Telerik.Reporting.Panel
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents Panel7 As Telerik.Reporting.Panel
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
End Class