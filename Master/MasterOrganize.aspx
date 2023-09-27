<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MasterOrganize.aspx.vb" Inherits="Master_MasterOrganize" %>

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

                function gridCommand(sender, args) {
                    if (args.get_commandName() == "BatchEdit") {
                        var validationFails = false;
                        var masterTable = sender.get_masterTableView();
                        var batchManager = sender.get_batchEditingManager();
                        var dataItems = masterTable.get_dataItems();
                        var dateIndexes = [];
                        var msg = "";
                        for (var i = 0; i < dataItems.length; i++) {
                            var idCellGUID = dataItems[i].get_cell("Organize_Code"); //get reference to the cells you want to validate
                            var idCellName = dataItems[i].get_cell("Organize_NameT"); //get reference to the cells you want to validate

                            var idGUID = batchManager.getCellValue(idCellGUID); //retrieve the value from the cell using the BatchEditingManager 
                            var idName = batchManager.getCellValue(idCellName); //retrieve the value from the cell using the BatchEditingManager 

                            if (idGUID == "" || idName == "") {
                                if (idGUID == "") msg += "<%= Me.GridShowdata.MasterTableView.GetColumn("Organize_Code").HeaderText%>" + " " + "<%=Sys.TMsg.ไม่สามารถมีค่าว่างเปล่า%>" + "<br/>";
                                if (idName == "") msg += "<%= Me.GridShowdata.MasterTableView.GetColumn("Organize_NameT").HeaderText%>" + " " + "<%=Sys.TMsg.ไม่สามารถมีค่าว่างเปล่า%>" + "<br/>";
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
                            msg += "<%= Me.GridShowdata.MasterTableView.GetColumn("Organize_Code").HeaderText%>" + " " + "<%=Sys.TMsg.ไม่สามารถมีค่าซ้ำ%>" + "<br/>";
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
                PageSize="50" Height="368px" OnItemDataBound="grid_ItemDataBound"
                MasterTableView-PagerStyle-AlwaysVisible="true">
                <MasterTableView CommandItemDisplay="Top" CommandItemSettings-ShowRefreshButton="false"
                    CommandItemSettings-AddNewRecordText="เพิ่มข้อมูล"
                    CommandItemSettings-SaveChangesText="บันทึก"
                    CommandItemSettings-CancelChangesText="ยกเลิก"
                    
                    InsertItemPageIndexAction="ShowItemOnCurrentPage" 
                    EditMode="Batch" EnableNoRecordsTemplate="true" DataKeyNames="GUID_Organize">
                    <BatchEditingSettings EditType="Cell" OpenEditingEvent="Click" />
                    <NoRecordsTemplate></NoRecordsTemplate>
                    <ItemStyle Height="28px" />
                    <AlternatingItemStyle Height="28px" />

                    <Columns>

                        <telerik:GridBoundColumn UniqueName="GUID_Organize" DataField="GUID_Organize" HeaderText="ID"  Visible="false"/>
                        <telerik:GridBoundColumn UniqueName="Organize_Code" SortExpression="Organize_Code" DataField="Organize_Code" HeaderText="รหัส" HeaderStyle-Width="80px" AllowSorting="true" ColumnEditorID="txtEditor3"/>
                        <telerik:GridBoundColumn UniqueName="Organize_NameT" SortExpression="Organize_NameT" DataField="Organize_NameT" HeaderText="ชื่อหน่วยงาน" HeaderStyle-Width="130px" AllowSorting="true" ColumnEditorID="txtEditor4" />
                        <telerik:GridBoundColumn UniqueName="Organize_NameE" SortExpression="Organize_NameE" DataField="Organize_NameE" HeaderText="ชื่อหน่วยงาน(อังกฤษ)" HeaderStyle-Width="130px" AllowSorting="true" ColumnEditorID="txtEditor4"/>
                        <telerik:GridBoundColumn UniqueName="Organize_NameO" SortExpression="Organize_NameO" DataField="Organize_NameO" HeaderText="ชื่อหน่วยงาน(อื่นๆ)" HeaderStyle-Width="130px" AllowSorting="true" ColumnEditorID="txtEditor4"/>
                        <telerik:GridBoundColumn UniqueName="Organize_Tel" DataField="Organize_Tel" HeaderText="เบอร์ติดต่อ" HeaderStyle-Width="80px" AllowSorting="true" ColumnEditorID="txtEditor3"/>
                        <telerik:GridBoundColumn UniqueName="Organize_Address" DataField="Organize_Address" HeaderText="ที่อยู่" HeaderStyle-Width="130px" AllowSorting="true" ColumnEditorID="txtEditor4"/>
                        <telerik:GridBoundColumn UniqueName="Organize_Detail" DataField="Organize_Detail" HeaderText="รายละเอียด" HeaderStyle-Width="120px" AllowSorting="true" ColumnEditorID="txtEditor2" />
                        <telerik:GridBoundColumn UniqueName="Organize_Reason" DataField="Organize_Reason" HeaderText="Reason" HeaderStyle-Width="100px" AllowSorting="true" ColumnEditorID="txtEditor1"/>
                        <telerik:GridBoundColumn UniqueName="Organize_Fax" DataField="Organize_Fax" HeaderText="FAX" HeaderStyle-Width="80px" AllowSorting="true" ColumnEditorID="txtEditor3"/>
                        <telerik:GridBoundColumn UniqueName="Organize_ConPerson" SortExpression="Organize_ConPerson" DataField="Organize_ConPerson" HeaderText="ผู้ติดต่อ" HeaderStyle-Width="100px" AllowSorting="true" ColumnEditorID="txtEditor1"/>
                        
                       <telerik:GridButtonColumn UniqueName="DeleteColumn" ConfirmText="คุณต้องการลบข้อมูลหรือไม่" ConfirmDialogType="RadWindow" HeaderText="ลบ"
                            ConfirmTitle="คำเตือน" ButtonType="ImageButton" CommandName="Delete" HeaderStyle-Width="40px" />
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
            <telerik:GridTextBoxColumnEditor ID="txtEditor1"  runat="server" TextBoxStyle-Width ="80px" ></telerik:GridTextBoxColumnEditor> 
            <telerik:GridTextBoxColumnEditor ID="txtEditor2"  runat="server" TextBoxStyle-Width ="100px" ></telerik:GridTextBoxColumnEditor>  
            <telerik:GridTextBoxColumnEditor ID="txtEditor3"  runat="server" TextBoxStyle-Width ="60px" ></telerik:GridTextBoxColumnEditor>  
            <telerik:GridTextBoxColumnEditor ID="txtEditor4"  runat="server" TextBoxStyle-Width ="110px" ></telerik:GridTextBoxColumnEditor>                  

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
