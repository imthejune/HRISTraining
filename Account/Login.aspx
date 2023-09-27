<%@ Page Title="เข้าสู่ระบบ" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="resources/hmtl5demordfstyles.css" rel="stylesheet" type="text/css" />
 
          <style type="text/css">

            fieldset {
                height:auto !important;
            }

              .RadWindow .rwPopupButton {
                  margin:8px 8px 8px 100px !important;
              }
     
        </style>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" VisibleStatusbar="false" Skin="Default">
        <Windows>
            <telerik:RadWindow ID="RadWindow1" runat="server" Title="" ShowContentDuringLoad="false" EnableShadow="false" Width="590px"
                Height="510px" OnClientClose="OnClientClose" Behaviors="Close" Modal="true">
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <table align="center" width="400">
        <tr>
            <td>
                <%--<telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">--%>
		<telerik:RadFormDecorator ID="FormDecorator1" runat="server" DecoratedControls="All"
			DecorationZoneID="rfd-demo-zone"></telerik:RadFormDecorator>
		<div id="rfd-demo-zone">
			<div id="formWrap">
				<fieldset>
					<div class="profileImg">
					</div>
					<div class="profileData">
						<h3>
							เข้าสู่ระบบ</h3>
						<div class="inputWrapper">
							<asp:Label ID="searchInput" runat="server" Text="ชื่อผู้ใช้:" Width="50px"></asp:Label>
							<input type="text" id="txtUser" runat="server" tabindex="1" style="width:200px;" />
						</div>
						<div class="inputWrapper">
							<asp:Label ID="urlInput" runat="server" Text="รหัสผ่าน:" Width="50px"></asp:Label>
							<input type="password" id="txtPwd" runat="server" tabindex="2" style="width:200px;" />
						</div>
						<div class="inputWrapper">
							<asp:Label ID="Label1" runat="server" Text="บริษัท:" Width="50px"></asp:Label>
						<%--	<input type="tel" id="telephoneInput" />--%>
                            <asp:DropDownList ID="DDLCompany" runat="server" TabIndex="3" Width="210px" >
                            </asp:DropDownList>
                            <asp:Label ID="Label7" runat="server" ForeColor="Red" Text="ชื่อ หรือ รหัสผ่าน ไม่ถูกต้อง กรุณาลองอีกครั้ง"
                        Visible="False"></asp:Label>
						</div>
						<div class="inputWrapper"  >
						<%--	<label for="emailInput">
								ภาษา:</label>
							<input type="email" id="emailInput" style="width:200px;"  />--%>
                            <asp:Label ID="LangInput" runat="server" Text="ภาษา:" Width="50px"></asp:Label>
                           <%-- <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" GroupName="Addition" Text="ภาษาไทย" /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="Addition" Text="ภาษาอังกฤษ" />--%>
                            <telerik:RadComboBox ID="Combo_Lang" runat="server" AllowCustomText="True" DropDownWidth="150px" EmptyMessage="" Filter="Contains" Height="80px" HighlightTemplatedItems="true" Skin="Vista" Width="210px">
                            </telerik:RadComboBox>
						</div>
						<div class="inputWrapper">
                            <asp:Label ID="Label2" runat="server" Text="" Width="50px">
                            </asp:Label><asp:Button ID="sbmt" runat="server" Text="ตกลง" Height="22px" Width="60px"></asp:Button>&nbsp;&nbsp;
                            <asp:Button ID="Button2" runat="server" Text="ยกเลิก" Height="22px" Width="60px"></asp:Button>
						</div>
					</div>
				</fieldset>

                 <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
                            <script type="text/javascript">
                                $(function () {
                                    $("#header").hide();
                                });

                                function myclose() {
                                    alert('myclose');
                                    //setTimeout(function () {
                                    //    window.open('', '_self', '');
                                    //    window.close();
                                    //}, 100);

                                    //window.top.close();
                                    self.close();
                                }
                                $(function () {
                                    $("#LoginCompany").hide();
                                });
                            </script>
                </telerik:RadScriptBlock>
			
		</div>
            </div> 
		<br class="qsf-clear-float" />
	<%--</telerik:RadAjaxPanel>--%>
            </td>
        </tr>
        </table>
  
</asp:Content>

