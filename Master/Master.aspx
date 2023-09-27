<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Master.aspx.vb" Inherits="Master_Master" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%--<%@ Register TagPrefix="telerik" Namespace="Telerik.QuickStart" %>--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../Scripts/JavaScriptRadWindowManager.js"></script>
    <%--    <script src="../Scripts/jquery-1.10.2.js"></script>
    <script src="../Scripts/jquery-ui.js" type="text/javascript"></script>--%>
    <link href="../Styles/SiteMaster.css" rel="stylesheet" />
    <link href="../Styles/Site.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        /*.RadWindow .rwDialogPopup {
            background-repeat: no-repeat !important;
            background-image: url('../Image/info.png') !important;
        }*/

        .rwTable {
            height: 120px !important;
        }

              /*พื้นหลัง*/
        
    </style>
    <script type ="text/javascript" >

    </script>
</head>
<body >
    <form id="form1" runat="server">

        <telerik:RadScriptManager ID="QsfScriptManager" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
            </Scripts>
        </telerik:RadScriptManager>

        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" EnablePageHeadUpdate="False">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="RadGrid1">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="RadGrid1" LoadingPanelID="RadAjaxLoadingPanel1"></telerik:AjaxUpdatedControl>
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>

        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Height="50px" Width="50px" Transparency="60" Skin="Metro" ForeColor="#006600" HorizontalAlign="Center">
        </telerik:RadAjaxLoadingPanel>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" VisibleStatusbar="false" Skin="Default">
        </telerik:RadWindowManager>
        <div class="color2"  >
            <telerik:RadGrid ID="RadGrid1" runat="server" AllowMultiRowEdit="True" 
                AutoGenerateColumns="False" AllowPaging="true" AllowSorting="true"
                CellSpacing="0" GridLines="None" Skin="Telerik" ShowFooter="false" 
                PageSize="500" Height="465px" OnItemDataBound="grid_ItemDataBound"
                MasterTableView-PagerStyle-AlwaysVisible="true">
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
                        <telerik:GridBoundColumn UniqueName="f1" DataField="" HeaderText="" AllowSorting="true">
                            <ColumnValidationSettings EnableRequiredFieldValidation="true">
                                <RequiredFieldValidator ForeColor="Red" Text="*กรุณาใส่ข้อมูล" Display="Dynamic">
                                </RequiredFieldValidator>
                            </ColumnValidationSettings>
                        </telerik:GridBoundColumn>

                        <telerik:GridBoundColumn UniqueName="f2" DataField="" HeaderText="" AllowSorting="true" />
                        <telerik:GridBoundColumn UniqueName="f3" DataField="xx" HeaderText="" AllowSorting="true" />
                        <telerik:GridBoundColumn UniqueName="f4" DataField="xx" HeaderText="" AllowSorting="true" />

                        <telerik:GridCheckBoxColumn UniqueName="f5" FilterControlWidth="50px" HeaderStyle-Width="50px" DataField="xx" HeaderText="" DataType="System.Boolean" Visible="false">
                        </telerik:GridCheckBoxColumn>
                        <telerik:GridCheckBoxColumn UniqueName="f6" FilterControlWidth="50px" HeaderStyle-Width="50px" DataField="xx" HeaderText="" DataType="System.Boolean" Visible="false">
                        </telerik:GridCheckBoxColumn>

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
    </form>
</body>
</html>
