<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>
<%@ Register Namespace="Telerik.QuickStart" TagPrefix="qsf" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet.css" />
    <title>รายละเอียด</title>
    <style type="text/css">
        .styleHeaderText {
            /*font-variant: small-caps !important;*/
            /*font-weight: 700;*/
            font-family: 'Pridi', serif !important;
            /*font-size: 25px;*/
        }
    </style>

    <script type="text/javascript">
        function ClosePage() {
            
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
        </telerik:RadStyleSheetManager>
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
            </Scripts>
        </telerik:RadScriptManager>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        </telerik:RadAjaxManager>
        <telerik:RadWindowManager ID="WinMessageBox" runat="server" VisibleStatusbar="false" Skin="Office2010Blue">
            <Windows>
                <telerik:RadWindow ID="QsfWindow" runat="server" ReloadOnShow="true" ShowContentDuringLoad="false" OnClientClose="ClosePage" Behaviors="Close" Height="204px" Width="176px" Modal="true"></telerik:RadWindow>
            </Windows>
        </telerik:RadWindowManager>
        <div style="background-color: #e4e4e4; height: 70px; width: 100%">     <%-- #82e8bf--%>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Lable1" runat="server" CssClass="styleHeaderText" Text="รายละเอียด" Font-Size="16pt" Font-Bold="true"></asp:Label><br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lable2" runat="server" Text=""></asp:Label><br />
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding-top: 1em;">
            <telerik:RadGrid ID="GridPerson" runat="server" AutoGenerateColumns="False" GroupPanelPosition="Top" Width="100%"
                ExportSettings-IgnorePaging="true" AllowPaging="True"
                AllowSorting="False" Skin="Metro"
                AllowMultiRowSelection="False">
                <HeaderStyle HorizontalAlign="Center" />
                <MasterTableView EnableNoRecordsTemplate="true" DataKeyNames="t_id,t_ticket" EditMode="Batch" CommandItemDisplay="Top" CommandItemSettings-ShowAddNewRecordButton="false" CommandItemSettings-ShowRefreshButton="false" CommandItemSettings-SaveChangesText="บันทึก" CommandItemSettings-CancelChangesText="ยกเลิก">
                    <Columns>
                        <telerik:GridTemplateColumn HeaderText="ลำดับ" DataField="" SortExpression="" HeaderStyle-Width="10px">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbl_order" Text='<%#Container.ItemIndex + 1%>'></asp:Label>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>

                        <telerik:GridTemplateColumn HeaderText="เครื่องสินค้า" DataField="product" HeaderStyle-Width="20px" SortExpression="product" >
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbl_product" Text='<%# Eval("productName")%>'></asp:Label>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>

                        <telerik:GridTemplateColumn HeaderText="Ticket" DataField="ticket" HeaderStyle-Width="20px" SortExpression="ticket" >
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbl_ticket" Text='<%# Eval("t_ticket")%>'></asp:Label>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>

                        <telerik:GridTemplateColumn HeaderText="ชื่อ-นามสกุล" DataField="Name" SortExpression="Name" HeaderStyle-Width="20px">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbl_Name" Text='<%# Eval("t_name")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextName" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>                                
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>

                        <telerik:GridTemplateColumn HeaderText="ที่อยู่" DataField="Address" SortExpression="Address" HeaderStyle-Width="40px">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbl_Address" Text='<%# Eval("t_address")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextAddress" runat="server" Height="70px" Width="155px" TextMode="MultiLine" Text='<%# Eval("Address") %>'></asp:TextBox>                                
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>

                        <telerik:GridTemplateColumn HeaderText="Email" DataField="Email" HeaderStyle-Width="30px" SortExpression="Email">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbl_Email" Text='<%# Eval("t_email")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextEmail" runat="server" Text='<%# Eval("Email") %>'></asp:TextBox>                                
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>                       

                        <telerik:GridTemplateColumn HeaderText="บริษัท" HeaderStyle-Width="20px" DataField="Company" SortExpression="Company" >
                            <ItemTemplate>
                               <asp:Label runat="server" ID="lbl_company" Text='<%# Eval("t_company")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextCompany" runat="server" Text='<%# Eval("Company") %>'></asp:TextBox>                                
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>

                        <telerik:GridTemplateColumn HeaderText="เบอร์โทร" DataField="Tel" HeaderStyle-Width="20px" SortExpression="Tel">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lbl_tel" Text='<%# Eval("t_tel")%>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextTel" runat="server" Text='<%# Eval("Tel") %>'></asp:TextBox>                                
                            </EditItemTemplate>
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
        </div>
    </form>
</body>
</html>
