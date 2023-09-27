<%@ Control Language="VB" AutoEventWireup="false" CodeFile="PersonDetail.ascx.vb" Inherits="UserControl_PersonDetail" %>
<table runat="server" id="ProductWrapper" border="0" cellpadding="0"
    cellspacing="0">
    <tr>
        <td style="width: 400px; text-align: left;" valign="top">
            <table style="width: 100%;" border="0">
                <tr valign="top">
                    <td rowspan="9"  style="width: 90px;">
                        <div style="border: 1px solid; border-color: #ada9a9; width: 80px;">
                            <asp:Image ID="image" runat="server" Width="80" Height="100" BorderColor="Gray" />
                        </div>
                    </td>
                    <td>
                        <asp:Label ID="lblNameEmp" runat="server" Text="ชื่อ - สกุล :" Font-Bold="True"></asp:Label>
                    <%--</td>
                    <td style=" style="width: 170px;"/width: 270px;">--%>
                        <asp:Label ID="Txtname" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcmb1" runat="server" Text="cmb1 :" Font-Bold="True"></asp:Label>
                    <%--</td>
                    <td>--%>
                        <asp:Label ID="Txtcmb1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcmb2" runat="server" Text="cmb2 :" Font-Bold="True"></asp:Label>
                    <%--</td>
                    <td>--%>
                        <asp:Label ID="Txtcmb2" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcmb3" runat="server" Text="cmb3 :" Font-Bold="True"></asp:Label>
                    <%--</td>
                    <td>--%>
                        <asp:Label ID="Txtcmb3" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcmb4" runat="server" Text="cmb4 :" Font-Bold="True"></asp:Label>
                    <%--</td>
                    <td>--%>
                        <asp:Label ID="Txtcmb4" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcmb5" runat="server" Text="cmb5 :" Font-Bold="True"></asp:Label>
                    <%--</td>
                    <td>--%>
                        <asp:Label ID="Txtcmb5" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcmb6" runat="server" Text="cmb6 :" Font-Bold="True"></asp:Label>
                    <%--</td>
                    <td>--%>
                        <asp:Label ID="Txtcmb6" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPosition" runat="server" Text="ตำแหน่ง :" Font-Bold="True"></asp:Label>
                        <%--</td><td>--%>
                            <asp:Label ID="TxtPosition" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

<link href="../Styles/Site.css" rel="stylesheet" />
