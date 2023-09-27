<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MasterFileType.aspx.vb" Inherits="Master_MasterFileType" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%--<%@ Register TagPrefix="telerik" Namespace="Telerik.QuickStart" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../Scripts/JavaScriptRadWindowManager.js"></script>
    <link href="../Styles/Site.css" rel="stylesheet" />
    <title></title>

    <style type="text/css">
        .rwTable {
            height: 120px !important;
        }
        .s{
            color:red;
        }

    </style>
    <script type ="text/javascript" >
       
    </script>
</head>
<body>
    <form id="form1" runat="server">

        <telerik:RadScriptManager ID="QsfScriptManager" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
            </Scripts>
        </telerik:RadScriptManager>
        <%--ต้องอยู่ตรงนี้ ถ้าอยู่ข้างบนจะ Error $ บนไอดี--%>
        <script src="../Scripts/java.js"></script>

        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" EnablePageHeadUpdate="False">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="GridShowdata">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="GridShowdata" LoadingPanelID="RadAjaxLoadingPanel1"></telerik:AjaxUpdatedControl>
                    </UpdatedControls>
                </telerik:AjaxSetting>
  
            </AjaxSettings>
        </telerik:RadAjaxManager>
        <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
            <script type="text/javascript">


                function OnClientClose(oWnd, name) {

                }

                function GetRadWindow() {
                    var oWindow = null;
                    if (window.radWindow)
                        oWindow = window.radWindow;
                    else if (window.frameElement && window.frameElement.radWindow)
                        oWindow = window.frameElement.radWindow;
                    return oWindow;
                }

                function CloseModal(name) {
                    var oWnd = GetRadWindow();
                    if (oWnd) oWnd.close(name);
                    if (name == 'BtnGroup') {
                        __doPostBack('ctl00$ContentPlaceHolder1$HiddFiel', '')
                    }
                }

                function confirmCallBackFnSave(arg) {
                    if (arg == true) {
                        $find('<%=RadAjaxManager1.ClientID %>').ajaxRequest('SAVE');
                    }
                }

                function gridCommand(sender, args) {
                    if (args.get_commandName() == "BatchEdit") {
                        var validationFails = false;
                        var masterTable = sender.get_masterTableView();
                        var batchManager = sender.get_batchEditingManager();
                        var dataItems = masterTable.get_dataItems();
                        var dateIndexes = [];
                        var msg = "";
                        for (var i = 0; i < dataItems.length; i++) {
                            var idCellGUID = dataItems[i].get_cell("TnameT"); //get reference to the cells you want to validate

                            var idGUID = batchManager.getCellValue(idCellGUID); //retrieve the value from the cell using the BatchEditingManager 

                            if (idGUID == "") {
                                if (idGUID == "") msg += "<%= Me.GridShowdata.MasterTableView.GetColumn("TnameT").HeaderText%>" + " " + "<%=Sys.TMsg.ไม่สามารถมีค่าว่างเปล่า%>" + "<br/>";
                                validationFails = true;
                                break;
                            }
                            //else if (idDate != "") {
                            <%--if (idDate.length != 10) {
                                msg += "<%= Me.GridShowdata.MasterTableView.GetColumn("GUID_Group").HeaderText%>" + " " + "<%=Sys.TMsg.มีรูปแบบไม่ถูกต้อง %>" + "<br/>";
                                validationFails = true;
                                break;
                            }--%>
                        }
                        var itemCNT = dateIndexes.indexOf(idGUID);
                        if (itemCNT >= 0) {
                            msg += "<%= Me.GridShowdata.MasterTableView.GetColumn("TnameT").HeaderText%>" + " " + "<%=Sys.TMsg.ไม่สามารถมีค่าซ้ำ%>" + "<br/>";
                            validationFails = true;
                        }
                        else {
                            dateIndexes.push(idGUID);
                        }
                    }

                    if (validationFails) {
                        args.set_cancel(true);
                        radalert(msg, 350, 150, "<%=Sys.TMsg.คำเตือน%>");
                    }
                }

                function changeEditor(sender, args) {
                    var RGrid = $find("<%=GridShowdata.ClientID%>");
                    var batchManager = RGrid.get_batchEditingManager();
                    RGrid.get_batchEditingManager().openCellForEdit(sender.parentElement.parentElement);
                    sender.checked = !sender.checked;
                }

                function OnClientButtonClicking(sender, commandName) {
                    var button = commandName;
                    var grid = $find("<%=GridShowdata.ClientID%>");
                    ckToolBarCmd = button;

                    //เช็คตอนกดปุ่มบันทึก อีกครั้ง เพราะปุ่มบันทึก ใช้ร่วมกับการ เพิ่มพนักงานและแก้ไขพนักงาน
                    switch (button) {
                        case "Insert":
                            __doPostBack('AddItem', '');
                            break;
                        case "Edit": break;
                        case "Update": break;
                        case "Save":
                            grid.get_batchEditingManager().saveChanges(grid.get_masterTableView());
                            break;
                        case "Cancel":
                            grid.get_batchEditingManager().cancelChanges(grid.get_masterTableView());
                            ckToolBarCmd = "";
                            break;
                        case "Master":
                            PopupSetMemo();
                            break;
                    }
                }

                function GetCellValue(sender, args) {

                    var FindColumn = false;
                    var idx = 0;
                    var UniqueName = ["TnameT", "TnameE", "TnameO"];
                    var ControlName1 = ["lblTnameT", "lblTnameE", "lblTnameO"];

                    if (args.get_columnUniqueName() != "") {
                        idx = UniqueName.indexOf((args.get_columnUniqueName()));
                        if (idx >= 0) { FindColumn = true; }
                    }

                    if (FindColumn == true) {
                        args.set_cancel(true);
                        var container = args.get_container();
                        var firstName = "";
                        var lastName = "";

                        if ($telerik.findElement(container, ControlName1[idx]) != null) firstName = $telerik.findElement(container, ControlName1[idx]).innerHTML;
                        if ($telerik.findElement(container, ControlName2[idx]) != null) lastName = $telerik.findElement(container, ControlName2[idx]).innerHTML;

                        args.set_value(new Person(firstName, lastName));
                    }
                }


                function SetCellValue(sender, args) {
                    var FindColumn = false;
                    var idx = 0;
                    var UniqueName = ["TnameT", "TnameE", "TnameO"];
                    var ControlName1 = ["lblTnameT", "lblTnameE", "lblTnameO"];

                    if (args.get_columnUniqueName() != "") {
                        idx = UniqueName.indexOf((args.get_columnUniqueName()));
                        if (idx >= 0) { FindColumn = true; }
                    }

                    if (FindColumn == true) {
                        args.set_cancel(true);
                        var container = args.get_container(),
                        value = args.get_value(),
                        firstName = value.firstName,
                        lastName = value.lastName;

                        if ($telerik.findControl(container, ControlName1[idx]) == null) {
                            if ($telerik.findElement(container, ControlName1[idx]) != null) $telerik.findElement(container, ControlName1[idx]).innerHTML = firstName;
                            if ($telerik.findElement(container, ControlName2[idx]) != null) $telerik.findElement(container, ControlName2[idx]).innerHTML = lastName;
                        }
                        else {

                            if ($telerik.findElement(container, ControlName1[idx]) != null) $telerik.findElement(container, ControlName1[idx]).innerHTML = firstName;
                            if ($telerik.findElement(container, ControlName2[idx]) != null) $telerik.findElement(container, ControlName2[idx]).innerHTML = lastName;
                        }


                    }
                }

                function GetEditorValue(sender, args) {
                    var FindColumn = false;
                    var idx = 0;
                    var UniqueName = ["TnameT", "TnameE", "TnameO"];
                    var ControlName1 = ["txtTnameT", "txtTnameE", "txtTnameO"];
                    var ControlName1I = ["txtTnameTI", "txtTnameEI", "txtTnameOI"];


                    if (args.get_columnUniqueName() != "") {
                        idx = UniqueName.indexOf((args.get_columnUniqueName()));
                        if (idx >= 0) { FindColumn = true; }
                    }


                    if (FindColumn == true) {
                        args.set_cancel(true);

                        var container2 = args.get_container();
                        firstName = $telerik.findControl(container2, ControlName1[idx]).get_value(),
                        lastName = $telerik.findControl(container2, ControlName2[idx]).get_value();

                        if ($telerik.findControl(container2, ControlName1[idx]) == null) {
                            var container = args.get_container(),
                            firstName = $telerik.findElement(container, ControlName1I[idx]).value,
                            lastName = $telerik.findElement(container, ControlName2I[idx]).value;
                        }
                        else {
                            var container = args.get_container(),
                           firstName = $telerik.findElement(container, ControlName1[idx]).value,
                           lastName = $telerik.findElement(container, ControlName2[idx]).value;
                        }

                        args.set_value(new Person(firstName, lastName));
                    }
                }

                function SetEditorValue(sender, args) {
                    var FindColumn = false;
                    var idx = 0;
                    var UniqueName = ["TnameT", "TnameE", "TnameO"];
                    var ControlName1 = ["txtTnameT", "txtTnameE", "txtTnameO"];
                    var ControlName1I = ["txtTnameTI", "txtTnameEI", "txtTnameOI"];


                    if (args.get_columnUniqueName() != "") {
                        idx = UniqueName.indexOf((args.get_columnUniqueName()));
                        if (idx >= 0) { FindColumn = true; }
                    }


                    if (FindColumn == true) {
                        args.set_cancel(true);
                        var container = args.get_container(),
                        value = args.get_value(),
                        firstName = value.firstName,
                        lastName = value.lastName;


                        if ($telerik.findControl(container, ControlName1[idx]) == null) {
                            if ($telerik.findControl(container, ControlName1[idx]) != null) $telerik.findControl(container, ControlName1[idx]).set_value(firstName);
                            if ($telerik.findControl(container, ControlName2[idx]) != null) $telerik.findControl(container, ControlName2[idx]).set_value(lastName);
                        }
                        else {
                            if ($telerik.findControl(container, ControlName1[idx]) != null) $telerik.findControl(container, ControlName1[idx]).set_value(firstName);
                            if ($telerik.findControl(container, ControlName2[idx]) != null) $telerik.findControl(container, ControlName2[idx]).set_value(lastName);
                        }
                        $telerik.findElement(container, ControlName1[idx]).value = firstName;
                        $telerik.findElement(container, ControlName2[idx]).value = lastName;
                    }
                }


                function OnClientButtonClicking(sender, commandName) {
                    var button = commandName;
                    var grid = $find("<%=GridShowdata.ClientID%>");
                    ckToolBarCmd = button;

                    //เช็คตอนกดปุ่มบันทึก อีกครั้ง เพราะปุ่มบันทึก ใช้ร่วมกับการ เพิ่มพนักงานและแก้ไขพนักงาน
                    switch (button) {
                        case "Insert":
                            __doPostBack('AddItem', '');
                            break;
                        case "Edit": break;
                        case "Update": break;
                        case "Save":
                            grid.get_batchEditingManager().saveChanges(grid.get_masterTableView());
                            break;
                        case "Cancel":
                            grid.get_batchEditingManager().cancelChanges(grid.get_masterTableView());
                            ckToolBarCmd = "";
                            break;
                        case "Master":
                            PopupSetMemo();
                            break;
                    }
                }
            </script>
        </telerik:RadScriptBlock>

        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Height="50px" Width="50px" Transparency="60" Skin="Metro" ForeColor="#006600" HorizontalAlign="Center">
        </telerik:RadAjaxLoadingPanel>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" VisibleStatusbar="false" Skin="Default">
            <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" Title="" ShowContentDuringLoad="false" EnableShadow="false" Width="800px"
                Height="500px" OnClientClose="OnClientClose" Behaviors="Close" Modal="true">
            </telerik:RadWindow>
            <telerik:RadWindow ID="RadWindow2" runat="server" ReloadOnShow="true" ShowContentDuringLoad="false" OnClientClose="OnClientClose" Width="535px" Height="480px" Modal="true" Behaviors="Move,Close"></telerik:RadWindow>

        </Windows>
        </telerik:RadWindowManager>
        <div>

            <telerik:RadGrid ID="GridShowdata" runat="server" AllowMultiRowEdit="True"
                AutoGenerateColumns="False" AllowPaging="true" AllowSorting="true"
                CellSpacing="0" GridLines="None" Skin="Telerik" ShowFooter="false"
                PageSize="500" Height="368px" OnItemDataBound="grid_ItemDataBound"
                MasterTableView-PagerStyle-AlwaysVisible="true">
                <MasterTableView CommandItemDisplay="Top" CommandItemSettings-ShowRefreshButton="false"
                    CommandItemSettings-ShowAddNewRecordButton="false"
                    CommandItemSettings-ShowSaveChangesButton="false"
                    CommandItemSettings-ShowCancelChangesButton="false"
                    EditMode="Batch" EnableNoRecordsTemplate="true" DataKeyNames="GUID_FileType,ins,ID">
                   <BatchEditingSettings EditType="Cell" />
                     <NoRecordsTemplate>
                        </NoRecordsTemplate>
                       <%-- <ItemStyle HorizontalAlign="Left" Height="52px" />--%>
                        <%--<AlternatingItemStyle HorizontalAlign="Left" Height="52px" />--%>
                         <CommandItemTemplate>
                            <div style="padding:5px 0px 5px 5px;">
                                <table cellpadding="0" cellspacing="0" width="100%" >
                                    <tr valign ="middle">
                                        <td width="550px" valign="middle" >
                                            <asp:LinkButton ID="LinkButton2" runat="server" style="font-size:12px; padding-left:25px" Text="เพิ่มข้อมูล" height="18px" Width="60px" CommandName="Insert" CssClass="rgAdd" OnClientClick="OnClientButtonClicking(this,'Insert'); return false;">
                                                </asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton3" runat="server" style="font-size:12px; padding-left:25px" Text="บันทึก" height="18px"  Width="30px" CommandName="Save" CssClass="rgSave" OnClientClick="OnClientButtonClicking(this,'Save'); return false;" >
                                                </asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton1" runat="server" style="font-size:12px; padding-left:25px" Text="ยกเลิก" height="18px"  Width="70px" CommandName="Cancel" CssClass="rgCancel" OnClientClick="OnClientButtonClicking(this,'Cancel');" >
                                                </asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </CommandItemTemplate>
                    <Columns>

                       <telerik:GridBoundColumn UniqueName="GUID_FileType" DataField="GUID_FileType" HeaderText="ID"  Visible="false"/>
                         <telerik:GridTemplateColumn HeaderText='ชื่อประเภท' DataField="TnameT" SortExpression="TnameT" UniqueName="TnameT" >
                            <HeaderStyle HorizontalAlign="Left" Width="120px" />
                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"    />
                            <ItemTemplate >
                                <asp:Label ID="lblTnameT" Text='<%# Eval("TnameT")%>' runat="server" Height="22px"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <telerik:RadTextBox  ID="txtTnameT" runat="server" Width="90px"   Text='<%# Eval("TnameT")%>' ></telerik:RadTextBox><br />
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <telerik:RadTextBox  ID="txtTnameTI" runat="server" Text="" Width="90px" ></telerik:RadTextBox>
                            </InsertItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn HeaderText='ชื่อประเภท(อังกฤษ)' DataField="TnameE" SortExpression="TnameE" UniqueName="TnameE" >
                            <HeaderStyle HorizontalAlign="Left" Width="120px" />
                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"    />
                            <ItemTemplate >
                                <asp:Label ID="lblTnameE" Text='<%# Eval("TnameE")%>' runat="server" Height="22px"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <telerik:RadTextBox  ID="txtTnameE" runat="server" Width="90px"   Text='<%# Eval("TnameE")%>' ></telerik:RadTextBox><br />
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <telerik:RadTextBox  ID="txtTnameEI" runat="server" Text="" Width="90px" ></telerik:RadTextBox>
                            </InsertItemTemplate>
                        </telerik:GridTemplateColumn>
                         <telerik:GridTemplateColumn HeaderText='ชื่อประเภท(อื่นๆ)' DataField="TnameO" SortExpression="TnameO" UniqueName="TnameO" >
                            <HeaderStyle HorizontalAlign="Left" Width="120px" />
                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"    />
                            <ItemTemplate >
                                <asp:Label ID="lblTnameO" Text='<%# Eval("TnameO")%>' runat="server" Height="22px"></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <telerik:RadTextBox  ID="txtTnameO" runat="server" Width="90px"   Text='<%# Eval("TnameO")%>' ></telerik:RadTextBox><br />
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <telerik:RadTextBox  ID="txtTnameOI" runat="server" Text="" Width="90px" ></telerik:RadTextBox>
                            </InsertItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn HeaderStyle-Width="50px" UniqueName="chkCourse" HeaderText="Training">
                            <ItemStyle VerticalAlign="Top" />
                            <ItemTemplate>
                                <asp:CheckBox runat="server" ID="chkCourse1" Enabled="true" Checked='<%# Eval("chkCourse")%>' onclick="changeEditor(this);" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:CheckBox runat="server" ID="chkCourse2" />
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn HeaderStyle-Width="50px" UniqueName="chkPerson" HeaderText="Person">
                            <ItemStyle VerticalAlign="Top" />
                           <ItemTemplate>
                                <asp:CheckBox runat="server" ID="chkPerson1" Enabled="true" Checked='<%# Eval("chkPerson")%>' onclick="changeEditor(this);" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:CheckBox runat="server" ID="chkPerson2" />
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridButtonColumn UniqueName="DeleteColumn" ConfirmText="คุณต้องการลบข้อมูลหรือไม่" ConfirmDialogType="RadWindow" HeaderText="ลบ"
                            ConfirmTitle="คำเตือน" ButtonType="ImageButton" CommandName="Delete" HeaderStyle-Width="40">
                             <ItemStyle VerticalAlign="Top" />
                        </telerik:GridButtonColumn>
                    </Columns>
                    <EditFormSettings>
                        <EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
                    </EditFormSettings>
                </MasterTableView>
                <%--ป้องกันการกด Enter แล้วขึ้น popup Confirm Delete--%>
                <ClientSettings AllowKeyboardNavigation="true" ReorderColumnsOnClient="true" AllowColumnsReorder="true" ColumnsReorderMethod="Reorder">
                    <ClientEvents  OnCommand="gridCommand" />
                    
                    <%--ป้องกันตอนกด Ctrl+C ตอนกดเพิ่มแล้วมัน Reload หายไปจาก Grid --%>
                    <%--20160715 น๊ะบังไว้ก่อนเพราะใช้งานบน FireFox แล้วพิมพ์อักขระ ว บ ม ง (ตัวที่มีอักขระพิเศษ) พิมพ์แล้วมัน Reload หายไปจาก Grid--%>
                    <%--<KeyboardNavigationSettings EnableKeyboardShortcuts="false" />--%>
                    <Scrolling AllowScroll="true" UseStaticHeaders="true" ScrollHeight="500px" />
                </ClientSettings>
                <FilterMenu EnableImageSprites="False"></FilterMenu>

            </telerik:RadGrid>
            <telerik:GridTextBoxColumnEditor ID="txtEditor1"  runat="server" TextBoxStyle-Width ="109px" ></telerik:GridTextBoxColumnEditor>                

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
    </form>
</body>
</html>