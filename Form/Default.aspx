<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../Scripts/JavaScriptRadWindowManager.js"></script>
    <link href="../Styles/Site.css" rel="stylesheet" />
    <title>Grid & ComboBox</title>
    <style>
        .divContent {
            width: 96%;
            /*width:100%;*/
            height: auto;
            display: block;
            margin: auto;
            /*padding-top: 1em;*/
        }

        .styleHeaderText {
            font-variant: small-caps !important;
            font-weight: 700;
            font-family: 'Pridi', serif;
            margin-right: 0px;
        }

        .StyDiv1 {
            width: 679px;
            height: 100px;
            background-color: #aadcff;
            /*background-color: #8dcffd;*/
            /*border: solid;*/
            /* สไตล์สำหรับจัดให้อยู่กึ่งกลาง */
            position: absolute;
            top: 50%;
            left: 50%;
            margin-top: -118px; /* -(height/2) */
            margin-left: -355px; /* -(width/2) */
            border-style: groove;
        }

        #example .demo-container {
            float: left;
            margin-right: 50px;
        }

        .demo-container .comparison {
            float: left;
            margin-left: 4%;
        }

        .textbox {
            width: 250px !important;
            height: 20px !important;
            font-size: 10pt !important;
        }

        legend {
            font-size: 10pt;
            color: black;
        }

        fieldset {
            display: block;
            /*margin-left: 2px;
            margin-right: 2px;
            padding-top: 0.35em;
            padding-bottom: 0.625em;
            padding-left: 1.75em;
            padding-right: 0.75em;*/
            /*border: 2px groove (internal value);*/
            /*width: 600px; */
            width: auto;
            /* border-color: #000000;*/
            /*border-color: #cccccc;*/
            /*border-color: #808080;*/
            border-color: #b1b1b1;
        }

        body {
            /*background-size: cover;
            width: 99vw;
            height: 96vh;
            background: #FFCCFF;
            background: -webkit-linear-gradient(left top, #FFCCFF, #FF3366);
            background: -o-linear-gradient(bottom right, #FFCCFF, #FF3366);
            background: -moz-linear-gradient(bottom right, #FFCCFF, #FF3366);
            background: linear-gradient(to bottom right, #FFCCFF, #FF3366);*/
            /*background-image: url("Images/bG.jpg") !important;*/ /* ใช่อยู่*/
            background-color: #B8E8FC;
            background-attachment: fixed !important;
            display: block;
            background-size: cover;
            width: 99vw;
            height: 96vh;
            text-shadow: 0px 0px 0px black;
        }

        .label {
            /*font-size: 10pt !important;*/
            font: 12px "segoe ui",arial,sans-serif !important;
        }

        dropdown {
            position: relative;
            display: inline-block;
        }

        .dropdown-content {
            display: none;
            position: absolute;
            /*top: 22em;*/
            background-color: #f9f9f9;
            min-width: 200px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            z-index: 5;
        }

        .dropdown:hover .dropdown-content {
            display: block;
        }

        .MyImageButton {
        }

        .hov {
            font-size: 10pt;
            color: black;
            text-transform: none;
            font-style: normal;
        }

        .textgrid {
            font: 12px "segoe ui",arial,sans-serif !important;
            color: black !important;
        }

        .styleHeaderText {
            /*font-variant: small-caps !important;*/
            /*font-weight: 700;*/
            font-family: 'Pridi', serif;
            font-size: 25px;
        }

        .textheader {
            text-decoration: underline;
        }

        .product {
            /*border:1px dotted black;*/
            /*border:1px solid red;*/
            display: table-cell;
            text-align: center;
            vertical-align: middle;
        }

            .product :hover {
                /*background-color:rgba(0,0,0,0.2);*/
            }

        .productname {
            list-style-type: none;
        }

            .productname :hover {
                /*display: inline-block;
                width: 100px;
                height: 100px;
                z-index: 7;*/
            }

        .photo_product :hover {
            /*display: block;
            position: absolute;
            background-color: #f9f9f9;
            min-width: 200px;           
            z-index: 5;

            display: compact;            
            width:100px;
            height:100px;*/
        }

        .style_product {
            /*border: 1px solid black;*/
            border-width: 0px 0px 1px 0px;
            border-style: solid;
            border-color: black;
        }

        #Label18 {
            color: #ff0000;
        }

        .sty_asterisk {
            color: #ff0000;
        }

        .auto-style1 {
            width: 163px;
        }

        html.RadForm_Black,
        html.RadForm_BlackMetroTouch {
            background-color: #fff;
        }

        
    </style>
    <link href="https://fonts.googleapis.com/css?family=Pridi" rel="stylesheet" />

    <script type="text/javascript">

        function ClosePage() {

        }

        var displays = "";
        var NumItem = 0;


        //function OnClientBtnAdd(e) {
        //    //  GridTest
        //    // alert("asdfasd");
        //    var _grid = $find("GridTest");
        //    document.getElementById("HDFType").value = "Add";
        //    _grid.get_batchEditingManager().saveChanges(_grid.get_masterTableView());
        //}
        //function OnClientClicking(e) {
        //    // alert("TESTJava");
        //    var _grid = $find("GridTest");
        //    document.getElementById("HDFType").value = "Save";
        //    _grid.get_batchEditingManager().saveChanges(_grid.get_masterTableView());
        //}

        //function CheckRep() {
        //    var DivRep = document.getElementById("DivRepair");
        //    NumItem = document.getElementById("ItemNum").value;
        //    displays = document.getElementById("ItemDisplay").value;
        //    if (NumItem == 1) {
        //        DivRep.style.display = displays;
        //    }
        //}


        //function DivShow(sender, eventArgs) {
        //    var item = eventArgs.get_item();
        //    var DivRep = document.getElementById("DivRepair");
        //    NumItem = item.get_value();
        //    document.getElementById("ItemNum").value = item.get_value();

        //    //if (item.get_value() == "1") {

        //    //if (NumItem == "1") {
        //    if (item.get_value() == "1") {
        //        displays = "block";
        //    }
        //    else {
        //        displays = "none";
        //    }

        //    DivRep.style.display = displays;
        //    document.getElementById("ItemDisplay").value = DivRep.style.display;
        //}
        //function checknum(values) {
        //    var vchar = String.fromCharCode(event.keyCode);
        //    if ((vchar < '0' || vchar > '9')) return false;
        //    values.onKeyPress = vchar;
        //}

        function MyClientBlur(sender, eventArgs) {
            // false ใช้ในกรณี Clear item ตอน แก้ไข ////
            sender.requestItems("", false);
        }

        //Modal
        //function openWin(e, val) {
        //    var oWnd = radopen("Default2.aspx?ticket=" + val, "QsfWindow");
        //    oWnd.setSize(1200, 300);
        //    // oWnd.set_title("");
        //    oWnd.set_behaviors(Telerik.Web.UI.WindowBehaviors.Move + Telerik.Web.UI.WindowBehaviors.Close);
        //    oWnd.center();
        //    oWnd.set_modal(true);
        //    // oWnd.add_close(OnClientClose);
        //    //var gvID = $find("RadGrid1");
        //    //var masterTableView = gvID.get_masterTableView();
        //    //var firstDataItem = masterTableView.get_dataItems()[0];
        //    //alert(firstDataItem.getDataKeyValue("ticket"));
        //    // alert(CanvasGradient.toString) 
        //}

        //function openWinO(e, val) {
        //    var oWnd = radopen("Information_Repair2.aspx?IDRepair=" + val, "QsfWindow");
        //    oWnd.setSize(1200, 300);
        //    // oWnd.set_title("");
        //    oWnd.set_behaviors(Telerik.Web.UI.WindowBehaviors.Move + Telerik.Web.UI.WindowBehaviors.Close);
        //    oWnd.center();
        //    oWnd.set_modal(true);
        //    // oWnd.add_close(OnClientClose);
        //    //var gvID = $find("RadGrid1");
        //    //var masterTableView = gvID.get_masterTableView();
        //    //var firstDataItem = masterTableView.get_dataItems()[0];
        //    //alert(firstDataItem.getDataKeyValue("ticket"));
        //    // alert(CanvasGradient.toString) 
        //}

        function OpenModal(sender, args) {
            //alert("OpenModal Send Value : " + ticket)

            var ticket = sender.get_value(args);
            var modal = radopen("Default2.aspx?ticket=" + ticket, "QsfWindow");
            modal.setSize(1200, 300);
            modal.set_behaviors(Telerik.Web.UI.WindowBehaviors.Move + Telerik.Web.UI.WindowBehaviors.Close);
            modal.center();
            modal.set_modal(true);
        }


        var confirmWindow = null;
        var btnCustomRadWindowConfirm = null;
        var btnYes = null;

        // RadConfirm
        function RadConfirm(sender, args) {
            var callBackFunction = function (shouldSubmit) {
                if (shouldSubmit) {
                    // initiate the original postback again
                    sender.click();

                    if (Telerik.Web.Browser.ff) {
                        sender.get_element().click();
                    }
                }
            };

            var text = 'คุณต้องการลบหรือไม่?';

            radconfirm(text, callBackFunction, 300, 100, null, 'ลบผู้ใช้งาน');
            // always prevent the original postback so the RadConfirm can work, it will be initiated again with code in the callback function
            args.set_cancel(true);
        }

        function OnlyNumbers(sender, args) {
            var text = sender.get_value() + args.get_keyCharacter() ;
            if (!text.match('^[0-9]+$'))
                args.set_cancel(true);
        }

        function TrimIt(sender, args) {
            var value = args.get_newValue();
            var trimmed = value.replace(/^\s+|\s+$/g, '');
            args.set_newValue(trimmed);
        }


    </script>
</head>
<body>

    <form id="form1" runat="server">
        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Default"></telerik:RadAjaxLoadingPanel>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>

                <%--<telerik:AjaxSetting AjaxControlID="Btn_sTest">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="Btn_sTest" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="LinkButton2">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="GridTest" LoadingPanelID="RadAjaxLoadingPanel1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="Btn_Save">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="radwindowPopup" />
                        <telerik:AjaxUpdatedControl ControlID="Btn_Save" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="GridTest">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="Panel1" />
                        <telerik:AjaxUpdatedControl ControlID="GridTest" />
                    </UpdatedControls>
                </telerik:AjaxSetting>--%>

                <telerik:AjaxSetting AjaxControlID="BtnSave">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="RadGrid2" />

                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="RadTextSearch2">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="Panel1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="RadCom_search">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="RadTextSearch2" LoadingPanelID="RadAjaxLoadingPanel1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
                <telerik:AjaxSetting AjaxControlID="combo_choice">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="Panel1" LoadingPanelID="RadAjaxLoadingPanel1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>

                <%--New Grid--%>
                <telerik:AjaxSetting AjaxControlID="RadGrid1">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="RadGrid1" LoadingPanelID="RadAjaxLoadingPanel1"></telerik:AjaxUpdatedControl>
                    </UpdatedControls>
                </telerik:AjaxSetting>

            </AjaxSettings>
        </telerik:RadAjaxManager>


        <telerik:RadAjaxLoadingPanel runat="server" ID="gridLoadingPanel"></telerik:RadAjaxLoadingPanel>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" VisibleStatusbar="false" Skin="Default">
        </telerik:RadWindowManager>
        <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
        </telerik:RadStyleSheetManager>
        <telerik:RadScriptManager ID="RadScriptManager2" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        <script src="../Scripts/java.js"></script>
        <telerik:RadWindowManager ID="WinMessageBox" runat="server" VisibleStatusbar="false" Skin="Office2010Blue">
            <Windows>
                <telerik:RadWindow ID="QsfWindow" runat="server" ReloadOnShow="true" ShowContentDuringLoad="false" OnClientClose="ClosePage" Behaviors="Close" Height="204px" Width="176px" Modal="true"></telerik:RadWindow>
            </Windows>
        </telerik:RadWindowManager>

       
            <div class="divContent">
                <h3>insert</h3>
                <fieldset style="background-color: #EAEAEA;">
                    <table border="0">
                        <tr>
                            <th style="width: 90px"></th>
                            <th style="width: 250px"></th>
                            <th style="width: 10px"></th>
                            <th style="width: 70px"></th>
                            <th style="width: 250px"></th>
                            <th style="width: 10px"></th>
                            <th style="width: 50px"></th>
                            <th style="width: 300px"></th>
                        </tr>
                        <tr>
                            <td colspan="1">
                                <asp:Label ID="LabelName" runat="server" Text="ชื่อ-นามสกุล :" CssClass="label"></asp:Label><span class="sty_asterisk">*</span></td>
                            <td colspan="1">
                                <telerik:RadTextBox ID="txt_name" runat="server" CssClass="textbox"></telerik:RadTextBox></td>
                            <td colspan="1"></td>
                            <td colspan="1">
                                <asp:Label ID="LabelCompany" runat="server" Text="บริษัท :" CssClass="label"></asp:Label><span class="sty_asterisk">*</span></td>
                            <td colspan="1">
                                <telerik:RadTextBox ID="txt_company" runat="server" Width="250px" Height="20px" Font-Size="10pt"></telerik:RadTextBox></td>
                            <td colspan="1"></td>
                            <td colspan="1" style="vertical-align: top;">
                                <asp:Label ID="LabelAddress" runat="server" Text="ที่อยู่ :" CssClass="label"></asp:Label><span class="sty_asterisk">*</span>
                            </td>
                            <td colspan="1" rowspan="4" style="vertical-align: top;">
                                <telerik:RadTextBox ID="txt_address" runat="server" Width="300px" Height="90px" Font-Size="10pt" TextMode="MultiLine"></telerik:RadTextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">
                                <asp:Label ID="LabelTel" runat="server" Text="เบอร์ติดต่อ :" CssClass="label"></asp:Label><span class="sty_asterisk">*</span></td>
                            <td colspan="1">
                                <telerik:RadTextBox ID="txt_tel" runat="server" CssClass="textbox" MaxLength="10" ClientEvents-OnKeyPress="OnlyNumbers"></telerik:RadTextBox></td>
                            <td colspan="1"></td>
                            <td colspan="1">
                                <asp:Label ID="LabelEmail" runat="server" Text="E-mail :" CssClass="label"></asp:Label><span class="sty_asterisk">*</span></td>
                            <td colspan="1">
                                <telerik:RadTextBox ID="txt_email" runat="server" CssClass="textbox">
                                    <ClientEvents OnValueChanging="TrimIt" />
                                </telerik:RadTextBox><br />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">
                                <asp:Label ID="LabelProduct" runat="server" Text="เครื่องสินค้า :" CssClass="label"></asp:Label><span class="sty_asterisk">*</span></td>
                            <td>
                                <telerik:RadComboBox ID="combo_product" runat="server" AllowCustomText="True" AutoPostBack="false" EnableLoadOnDemand="True"
                                    HighlightTemplatedItems="true" OnClientDropDownOpening="MyClientBlur" DropDownWidth="300px" Width="250" Height="250px" Skin="Telerik"
                                    EnableVirtualScrolling="true" Filter="Contains" DataTextField="productName" DataValueField="id_product" OnItemsRequested="combo_product_ItemsRequested">
                                    <ItemTemplate>
                                        <div class="style_product">
                                            <ul class="product">
                                                <li class="productname">
                                                    <div style="width: auto;">
                                                        <div style="width: 50px; float: left;" class="photo_product">
                                                            <img src='<%# DataBinder.Eval(Container, "Attributes['productImages']")%>' width="45" height="45" />
                                                        </div>
                                                        <div style="width: 140px; padding-top: 1em;">
                                                            <%# DataBinder.Eval(Container, "Attributes['productName']")%>
                                                        </div>
                                                    </div>
                                                </li>
                                            </ul>
                                        </div>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                    </table>
                </fieldset>
                <div style="display: block; margin: auto; padding-top: 0.5em; width: 218px;">
                    <table border="0">
                        <tr>
                            <td>
                                <telerik:RadButton RenderMode="Lightweight" ID="BtnSave" runat="server"
                                    Text="บันทึก" Width="100px" Font-Size="10pt" Height="35px">
                                </telerik:RadButton>
                            </td>
                            <td></td>
                            <td style="width: 10px"></td>
                        </tr>
                    </table>
                </div>
            </div>

        <div class="divContent">
            <h1>Grid Grid Grid</h1>
           
            <%--<telerik:RadGrid ID="RadGrid1" runat="server" AllowMultiRowEdit="True"
                AutoGenerateColumns="False" AllowPaging="true" AllowSorting="true"
                CellSpacing="0" GridLines="None" Skin="Telerik" ShowFooter="false"
                PageSize="500" Height="465px" OnItemDataBound="grid_ItemDataBound"
                MasterTableView-PagerStyle-AlwaysVisible="true">--%>

            <telerik:RadGrid RenderMode="Lightweight" ID="RadGrid1" runat="server" AllowMultiRowEdit="True"
                AutoGenerateColumns="False" AllowPaging="true" AllowSorting="true"
                CellSpacing="0" GridLines="None" Skin="Telerik" ShowFooter="false"
                PageSize="10" Height="465px"
                MasterTableView-PagerStyle-AlwaysVisible="true">

                <%--<MasterTableView CommandItemDisplay="Top" CommandItemSettings-ShowRefreshButton="false" EditItemStyle-Width="100px"
                    CommandItemSettings-AddNewRecordText="เพิ่มข้อมูล"
                    CommandItemSettings-SaveChangesText="บันทึก"
                    CommandItemSettings-CancelChangesText="ยกเลิก"
                    InsertItemPageIndexAction="ShowItemOnCurrentPage"
                    EditMode="Batch" EnableNoRecordsTemplate="true">--%>

                <MasterTableView CommandItemDisplay="Top" CommandItemSettings-ShowRefreshButton="false" EditItemStyle-Width="100px"
                    CommandItemSettings-AddNewRecordText="เพิ่มข้อมูล"
                    CommandItemSettings-SaveChangesText="บันทึก"
                    CommandItemSettings-CancelChangesText="ยกเลิก"
                    InsertItemPageIndexAction="ShowItemOnCurrentPage"
                    EditMode="Batch" EnableNoRecordsTemplate="true">
                    <BatchEditingSettings EditType="Cell" OpenEditingEvent="Click" />
                    <%--<ItemStyle Height="30px" />
                    <AlternatingItemStyle Height="30px" />--%>
                    <NoRecordsTemplate></NoRecordsTemplate>
                    <Columns>
                         <telerik:GridTemplateColumn HeaderText="#" UniqueName="RowNumber">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblRowNumber" Width="5px" Text='<%# Container.DataSetIndex+1 %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                        <telerik:GridBoundColumn UniqueName="Ticket" DataField="t_ticket" HeaderText="Ticket" AllowSorting="true" ReadOnly="true" />
                        <telerik:GridBoundColumn UniqueName="ProductName" DataField="productName" HeaderText="Product Name" AllowSorting="true" ReadOnly="true" />
                        <telerik:GridBoundColumn UniqueName="f1" DataField="t_name" HeaderText="Name" AllowSorting="true" />
                        <telerik:GridBoundColumn UniqueName="f2" DataField="t_company" HeaderText="Company" AllowSorting="true" />
                        <telerik:GridBoundColumn UniqueName="f3" DataField="t_address" HeaderText="Address" AllowSorting="true" />
                        <telerik:GridBoundColumn UniqueName="f4" DataField="t_email" HeaderText="Email" AllowSorting="true" />
                        <telerik:GridBoundColumn UniqueName="f5" DataField="t_tel" HeaderText="Tel" AllowSorting="true" />

                        <%--<telerik:GridTemplateColumn HeaderText="" UniqueName="">
                            <ItemTemplate>
                                <telerik:RadButton ID="btnRadConfirm" runat="server" Text="ลบ" OnClientClicking="RadConfirm"
                                    OnClick="BtnDel_Click" CommandArgument='<%# Eval("t_ticket")%>'>
                                </telerik:RadButton>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>--%>

                        <telerik:GridButtonColumn UniqueName="DeleteColumn" ConfirmText="Delete this record ?" ConfirmDialogType="RadWindow" HeaderText="ลบ"
                            ConfirmTitle="Confirm" ButtonType="ImageButton" CommandName="Delete" HeaderStyle-Width="40" />
                        

                    </Columns>
                    <EditFormSettings>
                        <EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
                    </EditFormSettings>

                </MasterTableView>
                <%--ป้องกันการกด Enter แล้วขึ้น popup Confirm Delete--%>
                <ClientSettings AllowKeyboardNavigation="true" ReorderColumnsOnClient="true" AllowColumnsReorder="true" ColumnsReorderMethod="Reorder">
                    <%--ป้องกันตอนกด Ctrl+C ตอนกดเพิ่มแล้วมัน Reload หายไปจาก Grid--%>
                    <KeyboardNavigationSettings EnableKeyboardShortcuts="false" />
                    <Scrolling AllowScroll="true" UseStaticHeaders="true" ScrollHeight="500px" />
                </ClientSettings>
                <FilterMenu EnableImageSprites="False"></FilterMenu>
            </telerik:RadGrid>
            <asp:Label id="lblNote" runat="server" Text="" ></asp:Label>

        </div>

        <telerik:RadInputManager runat="server" ID="RadInputManager1" Enabled="true">

            <telerik:TextBoxSetting BehaviorID="TextBoxSetting1" Validation-IsRequired="true" InitializeOnClient="true">
            </telerik:TextBoxSetting>

            <telerik:NumericTextBoxSetting BehaviorID="NumericTextBoxSetting1" Type="Currency"
                AllowRounding="true" DecimalDigits="2">
            </telerik:NumericTextBoxSetting>

            <telerik:NumericTextBoxSetting BehaviorID="NumericTextBoxSetting2" Type="Number"
                AllowRounding="true" DecimalDigits="0" MinValue="0">
            </telerik:NumericTextBoxSetting>

            <telerik:RegExpTextBoxSetting BehaviorID="RegExpBehavior1" InitializeOnClient="false"
                ErrorMessage="Invalid ShipPostalCode">
                <Validation IsRequired="true"></Validation>
            </telerik:RegExpTextBoxSetting>
        </telerik:RadInputManager>
       
            <div class="divContent" id="demoContainer">

               <%-- <h3>Grid</h3>

                <asp:Label ID="Label12" runat="server" EnableViewState="false" ForeColor="Green"></asp:Label>

                <div>
                    <table border="0" style="padding-top: 1em;">
                        <tr>
                            <th style="width: 250px"></th>
                            <th class="auto-style1"></th>
                            <th style="width: 100px"></th>
                            <th style="width: 100px"></th>
                            <th style="width: 400px"></th>
                        </tr>
                        <tr>
                            <td colspan="1">
                                <telerik:RadComboBox ID="RadCom_search" runat="server" Width="250px" AutoPostBack="true">
                                    <Items>
                                        <telerik:RadComboBoxItem runat="server" Text="Ticket Code" Value="1" />
                                        <telerik:RadComboBoxItem runat="server" Text="Product Name" Value="2" />
                                        <telerik:RadComboBoxItem runat="server" Text="Company Name" Value="3" />
                                    </Items>
                                </telerik:RadComboBox>
                            </td>
                            <td colspan="1">
                                <telerik:RadTextBox ID="RadTextSearch2" Width="300px" runat="server" LabelWidth="120px" Resize="None" EmptyMessage=" -- โปรดกรอก Ticket Code -- "></telerik:RadTextBox></td>
                            <td colspan="1" class="auto-style1">
                                <telerik:RadButton ID="RadBtnSearch2" runat="server" Text="ค้นหา" Width="150px" Font-Size="13pt">
                                </telerik:RadButton>
                            </td>
                            <td colspan="1">
                                <telerik:RadButton ID="btntestreportall" runat="server" Font-Size="13pt" Text="ReportAll" Width="150px" Style="top: 0px; left: 1px"
                                    OnClick="btntestreportall_Click" CommandArgument='<%# Eval("t_ticket")%>'>
                                </telerik:RadButton>
                            </td>
                            <td colspan="1">
                                <asp:Label ID="Label2" runat="server" ForeColor="#3333FF"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>

                <telerik:RadGrid RenderMode="Lightweight" ID="RadGrid2" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RadGrid2_NeedDataSource"
                    AllowSorting="True" AllowPaging="True" PageSize="10" Skin="Metro" Width="100%" Height="500px">
                    <ClientSettings>
                        <Scrolling AllowScroll="True" UseStaticHeaders="True" SaveScrollPosition="true" FrozenColumnsCount="2"></Scrolling>
                    </ClientSettings>
                    <MasterTableView EnableNoRecordsTemplate="true" DataKeyNames="t_company,productName,t_ticket">
                        <HeaderStyle HorizontalAlign="Center" Font-Size="12pt" />
                        <Columns>
                            <telerik:GridTemplateColumn HeaderText="ลำดับ" UniqueName="RowNumber" HeaderStyle-Width="8">
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblRowNumberM" Text='<%# Container.DataSetIndex + 1 %>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="ชื่อ-นามสกุล" HeaderStyle-Width="20px">
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <asp:Label ID="lal_name" runat="server" Text='<%# Eval("t_name")%>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="ที่อยู่" HeaderStyle-Width="25px">
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <asp:Label ID="lal_address" runat="server" Text='<%# Eval("t_address")%>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="Email" HeaderStyle-Width="25px">
                                <ItemTemplate>
                                    <asp:Label ID="lal_email" runat="server" Text='<%# Eval("t_email")%>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="บริษัท" HeaderStyle-Width="20px">
                                <ItemTemplate>
                                    <asp:Label ID="lal_company" runat="server" Text='<%# Eval("t_company")%>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="เบอร์โทร" HeaderStyle-Width="15px">
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <asp:Label ID="lal_tel" runat="server" Text='<%# Eval("t_tel")%>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="ชื่อสินค้า" HeaderStyle-Width="15px">
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <asp:Label ID="lal_product" runat="server" Text='<%# Eval("productName")%>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="ticket" HeaderStyle-Width="15px">
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <asp:Label ID="lal_ticket" runat="server" Text='<%# Eval("t_ticket")%>'></asp:Label>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="แก้ไข" HeaderStyle-Width="10px">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <telerik:RadButton RenderMode="Lightweight" runat="server" Text="แก้ไข" OnClientClicking="OpenModal" Value='<%# Eval("t_ticket")%>'
                                        Width="45px" Height="25px" AutoPostBack="false">
                                    </telerik:RadButton>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="ลบ" HeaderStyle-Width="10px">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <telerik:RadButton RenderMode="Lightweight" ID="btnRadConfirm" runat="server" Text="ลบ" OnClientClicking="RadConfirm" Width="40px" Height="25px"
                                        OnClick="BtnDel_Click" CommandArgument='<%# Eval("t_ticket")%>'>
                                    </telerik:RadButton>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                            <telerik:GridTemplateColumn HeaderText="Report" HeaderStyle-Width="10px">
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <telerik:RadButton RenderMode="Lightweight" ID="btntestreport" runat="server" Text="Report" Width="60px" Font-Size="10pt" Height="25px"
                                        OnClick="btntestreport_Click" CommandArgument='<%# Eval("t_ticket")%>'>
                                    </telerik:RadButton>
                                </ItemTemplate>
                            </telerik:GridTemplateColumn>

                        </Columns>
                    </MasterTableView>
                    <PagerStyle Mode="NextPrevAndNumeric" />
                </telerik:RadGrid>--%>
            </div>
    

        
    </form>
</body>
</html>
