<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PreviewST.aspx.vb" Inherits="PreviewST" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="../Scripts/JavaScriptRadWindowManager.js"></script>
    <link href="../Styles/Site.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
    
        .auto-style1 {
            height: 18px;
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
                        <telerik:AjaxUpdatedControl ControlID="GridShowdata"></telerik:AjaxUpdatedControl>
                        <telerik:AjaxUpdatedControl ControlID="GridShowdata" LoadingPanelID="RadAjaxLoadingPanel1"></telerik:AjaxUpdatedControl>
                    
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
            <ClientEvents  />
        </telerik:RadAjaxManager>
        <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
            <script type="text/javascript">

                function windowOpen1(param, w, h) {
                    switch (param) {
                        case "21":
                            //if (window.screen) {
                            //    w = window.screen.availWidth;
                            //    h = window.screen.availHeight;
                            //}
                            window.open('PrintST.aspx?type=' + param, '_blank', "resizable=0,width=" + w + ",height=" + h + ",location=0,statusbar=0,scrollbars=1,directories=0,menubar=0,Left=5,Top=5");
                            break;
                        default:
                            window.open('PrintST.aspx?type=' + param, '_blank', "resizable=0,resize=no,width=" + w + ",height=" + h + ",location=0,statusbar=0,scrollbars=1,directories=0,menubar=0,Left=5,Top=5");
                            break;

                    }
                }

              
                function SetWindowPopup(name, id) {
                    var parentPage = GetRadWindow().BrowserWindow;
                    var st = document.getElementById("HiddenField1").value;
                    var parentRadWindowManager = parentPage.GetRadWindowManager();
                    switch (name) {
                        case "St":
                            var oWnd = parentRadWindowManager.open("../Report/PrintST.aspx?type=" + id + "&st=" + st + "&dd=" + Math.random(), "RadWindow1");
                            //var oWnd = parentRadWindowManager.open("../Report/PrintST.aspx?type=" + id + "&fy=" + fy + "&dd=" + Math.random(), "RadWindow1");
                            //var oWnd = radopen("PrintST.aspx?type=" + id, "RadWindow1");
                            switch(id)
                            {
                                case "2":
                                    oWnd.setSize(613, 452);
                                    break;
                                case "21":
                                    oWnd.setSize(613, 426);
                                    break;
                                case "22":
                                    oWnd.setSize(613, 376);
                                    break;
                                default:
                                    oWnd.setSize(800, 450);
                                    break;
                            }
                            
                            oWnd._name = 'PrintST'
                            oWnd.add_close(OnClientClosePreview);
                            oWnd.set_behaviors(Telerik.Web.UI.WindowBehaviors.Move + Telerik.Web.UI.WindowBehaviors.Close);
                            oWnd.center();
                            oWnd.set_modal(true);
                            break;
                    }
                }

                function OnClientClosePreview(oWnd, eventArgs) {
                    oWnd.setUrl("about:blank"); // Sets url to blank 
                    oWnd.remove_close(OnClientClosePreview);
                }


                function OnClientButtonClicking(sender, commandName) {
                    var button = commandName;
                    switch (button) {
                        case "Insert": break;
                        case "Edit": break;
                        case "Update": break;
                        case "Save":  break;
                        case "Cancel": break;
                    }
                }

                function responseEnd(sender, eventArgs) {

                }

                function GetRadWindow() {
                    var oWindow = null;
                    if (window.radWindow)
                        oWindow = window.radWindow;
                    else if (window.frameElement && window.frameElement.radWindow)
                        oWindow = window.frameElement.radWindow;
                    return oWindow;
                }

                function CloseModal() {
                    var oWnd = GetRadWindow(); //เรียกฟังก์ชั่นข้างบน -> GetRadWindow()
                    if (oWnd) oWnd.close();
                }
        
            </script>
        </telerik:RadScriptBlock>

        <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Height="50px" Width="50px" Transparency="60" Skin="Metro" ForeColor="#006600" HorizontalAlign="Center">
        </telerik:RadAjaxLoadingPanel>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server" VisibleStatusbar="false" Skin="Default">
        </telerik:RadWindowManager>
        <%----%>
         <asp:HiddenField ID="HiddenField1" runat="server" />
        <div class="color2" style="width:100%; height:570px; background-color:white;">
            <fieldset style="width: 99%;  float: left;margin-left:5px;margin-right:5px; ">
                <legend runat="server" id="legend2" align="left">
                    <asp:Label ID="Label1" runat="server" Text="รายละเอียดการนำส่ง สท. ประจำปี"></asp:Label>
                </legend>
                <table width="1050px" height="40px">
                   <tr>
                        <td width="45px">
                        </td>
                        <td width="30px" valign="top">
                           <asp:Label ID="lblYear"  runat="server"  Text="ปี"></asp:Label>&nbsp;:&nbsp;
                        </td>
                        <td width="100px" valign="top">
                           <asp:Label ID="Label2"  runat="server"  Text="2018"></asp:Label>
                        </td>
                       <td width="40px"></td>
                       <td></td>
                   </tr>
               </table>
               <table width="1050px">
                    <tr>
                       <td width="30px"></td>
                       <td width="510px">
                           <asp:Image ID="Image5" runat="server" ImageUrl ="~/Image/icon/book-open-text-image.png" />&nbsp;
                           <asp:Label ID="Label5"  runat="server"  Text="ข้อมูลการฝึกอบรมประจำปี และแจ้งการคำนวณเงินสมทบที่ขอนำส่งกรมพัฒนาฝีมือแรงงาน"></asp:Label>
                       </td>
                       <td>
                       </td>
                       <td width="400px">
                           <asp:Image ID="Image6" runat="server" ImageUrl ="~/Image/icon/book-open-text-image.png" />&nbsp;
                           <asp:Label ID="Label32"  runat="server"  Text="ข้อมูลบริษัทและจำนวนพนักงาน ที่ขอนำส่งกรมพัฒนาฝีมือแรงงาน"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td></td>
                       <td valign="top">
                           <table width="450px" style="margin-left:10px">
                               <tr height="10px">
                                   <td>&nbsp;</td>
                               </tr>
                               <tr >
                                   <td colspan="5">
                                        <asp:Label ID="Label41"  runat="server"  Text="การฝึกอบรมฝีมือแรงงาน ประจำปี"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label38"  runat="server"  Text="จำนวนรวมลูกจ้างทั้งหมดในปี"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label58"  runat="server"  Text="2,879"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label59"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label3"  runat="server"  Text="จำนวนเดือน"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label4"  runat="server"  Text="12"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label6"  runat="server"  Text="เดือน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label7"  runat="server"  Text="จำนวนลูกจ้างเฉลี่ยในรอบปี"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label8"  runat="server"  Text="239"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label9"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td colspan="2" style="padding-left:35px" >
                                       <asp:Label ID="Label10"  runat="server"  Text="สัดส่วนจำนวนลูกจ้างร้อยละ 50 ในรอบปี"></asp:Label>
                                   </td>
                                   <td  align="right"  >
                                       <asp:Label ID="Label11"  runat="server"  Text="119"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px" >
                                       <asp:Label ID="Label14"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label15"  runat="server"  Text="จำนวนหลักสูตรที่ได้รับความเห็นชอบ"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label16"  runat="server"  Text="1"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label17"  runat="server"  Text="หลักสูตร"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label18"  runat="server"  Text="จำนวนผู้รับการฝึก"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label19"  runat="server"  Text="10"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label20"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                             <%--  <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label21"  runat="server"  Text="ฝึกเตรียมเข้าทำงาน"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label22"  runat="server"  Text="0"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label23"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>--%>
                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label24"  runat="server"  Text="ฝึกยกระดับฝีมือแรงงาน"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label25"  runat="server"  Text="10"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label26"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label27"  runat="server"  Text="ฝึกเปลี่ยนสาขาอาชีพ"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label28"  runat="server"  Text="0"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label29"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr >
                                   <td></td>
                               </tr>
                               <tr >
                                   <td colspan="5">
                                        <asp:Label ID="Label40"  runat="server"  Text="การคำนวณเงินสมทบ ประจำปี"></asp:Label>
                                   </td>
                               </tr>
                                <tr>
                                   <td colspan="2" style="padding-left:35px" >
                                       <asp:Label ID="Label48"  runat="server"  Text="เงินสมทบเข้ากองทุน"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label45"  runat="server"  Text="5,400"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label46"  runat="server"  Text="บาท"></asp:Label>
                                   </td>
                               </tr>

                               <tr>
                                   <td colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label30"  runat="server"  Text="เงินเพิ่มตามกฏหมาย(ถ้ามี)"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label49"  runat="server"  Text="0"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label50"  runat="server"  Text="บาท"></asp:Label>
                                   </td>
                                </tr>
                               <tr>
                                   <td  colspan="2" style="padding-left:35px">
                                       <asp:Label ID="Label31"  runat="server"  Text="รวมเงินที่ต้องชำระ"></asp:Label>
                                   </td>
                                   <td   align="right" >
                                       <asp:Label ID="Label52"  runat="server"  Text="5,400"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label53"  runat="server"  Text="บาท"></asp:Label>
                                   </td>
                                </tr>
                               <tr>
                                   <td width="50px">
                                     
                                   </td>
                                   <td width="130px">
                                       
                                   </td>
                                   <td width="50px" align="right">
                                     
                                   </td>
                                   <td width="60px">
                                    
                                   </td>
                                   <td width="50px"></td>
                               </tr>
                           </table>
                       </td>
                       <td></td>
                       <td  valign="top">
                           <table width="450px" style="margin-left:10px">
                               <tr height="10px">
                                   <td>&nbsp;</td>
                               </tr>
                               <tr>
                                   <td >
                                       <asp:Label ID="Label33"  runat="server"  Text="บริษัท"></asp:Label>
                                   </td>
                                   <td colspan="4">
                                        <asp:Label ID="Label36"  runat="server"  Text="บริษัทไทเกอร์ซอฟท์ (1998) จำกัด"></asp:Label>
                                   </td>
                                   <td rowspan="8" align="center" valign="top">
                                       <asp:Image ID="Image7" runat="server" Width="90px" Height="100px" />
                                   </td>
                               </tr>
                               <tr  >
                                   <td  valign="top">
                                       <asp:Label ID="Label37"  runat="server"  Text="ที่อยู่"></asp:Label>
                                   </td>
                                   <td colspan="4"  valign="top">
                                      <asp:Label ID="Label39"  runat="server"  Text="7 อาคารวิชั่นบิสิเนสปาร์ค ชั้น 6-7 ตึกที่ 4 ซอยรามอินทรา 55/8 ถนนรามอินทรา แขวงท่าแร้ง เขตบางเขน กรุงเทพมหานคร 10230"></asp:Label>
                                   </td>
                               </tr>
                               <tr >
                                   <td></td>
                               </tr>
                               <tr>
                                   <td colspan="2">
                                       <asp:Label ID="Label81"  runat="server"  Text="จำนวนพนักงานแต่ละเดือน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label83"  runat="server"  Text="มกราคม"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label84"  runat="server"  Text="500"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label85"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label43"  runat="server"  Text="กุมภาพันธ์"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label44"  runat="server"  Text="239"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label47"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label51"  runat="server"  Text="มีนาคม"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label54"  runat="server"  Text="243"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label55"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label56"  runat="server"  Text="เมษายน"></asp:Label>
                                   </td>
                                   <td  align="right"  >
                                       <asp:Label ID="Label57"  runat="server"  Text="240"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px" >
                                       <asp:Label ID="Label60"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label61"  runat="server"  Text="พฤษภาคม"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label62"  runat="server"  Text="241"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label63"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label64"  runat="server"  Text="มิถุนายน"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label65"  runat="server"  Text="241"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label66"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label67"  runat="server"  Text="กรกฏาคม"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label68"  runat="server"  Text="238"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label69"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label70"  runat="server"  Text="สิงหาคม"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label71"  runat="server"  Text="240"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label72"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label73"  runat="server"  Text="กันยายน"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label74"  runat="server"  Text="240"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label75"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                              <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label12"  runat="server"  Text="ตุลาคม"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label13"  runat="server"  Text="240"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label34"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label35"  runat="server"  Text="พฤศจิกายน"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label76"  runat="server"  Text="240"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label77"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td ></td>
                                   <td>
                                       <asp:Label ID="Label78"  runat="server"  Text="ธันวาคม"></asp:Label>
                                   </td>
                                   <td  align="right" >
                                       <asp:Label ID="Label79"  runat="server"  Text="240"></asp:Label>
                                   </td>
                                   <td style="padding-left:10px">
                                       <asp:Label ID="Label80"  runat="server"  Text="คน"></asp:Label>
                                   </td>
                               </tr>
                               <tr>
                                   <td width="50px">
                                     
                                   </td>
                                   <td width="70px">
                                       
                                   </td>
                                   <td width="70px">
                                       
                                   </td>
                                   <td width="50px" align="right">
                                     
                                   </td>
                                   <td width="60px">
                                    
                                   </td>
                                   <td width="100px"></td>
                               </tr>
                           </table>
                       </td>
                   </tr>
               </table>
            </fieldset> 
             <fieldset style="width: 99%;  float: left;margin-left:5px;margin-right:5px; ">
                <legend runat="server" id="legend1" align="left">
                    <asp:Label ID="lblGroup1" runat="server" Text="รายงานเอกสารที่ต้องการนำส่ง สท "></asp:Label>
                </legend>
               <table width="600px">
                   <tr>
                       <td  ></td> 
                       <td  >
                           <asp:Image id="Image4" runat="server" ImageUrl ="~/Image/icon/reports.png"  />
                       </td> 
                       <td  >
                           <asp:LinkButton runat="server" ID="lnkDetail"    Text="รายละเอียดประกอบการยื่น สท.2"  ></asp:LinkButton>
                           <%--<asp:LinkButton runat="server" ID="chk21"    Text="ฝย/ผป 2-1" OnClientClick="SetWindowPopup('FyFp','21'); return false;"></asp:LinkButton>--%>
                       </td>
                   </tr>
                   <tr>
                        <td width="45px">
                        </td>
                        <td width="20px">
                            <asp:Image id="Image1" runat="server" ImageUrl ="~/Image/icon/reports.png"  />
                        </td>
                        <td>
                            <asp:LinkButton runat="server" ID="LinkButton1"   Text="สท. 2 การยื่นแบบแสดงการจ่ายเงินสมทบ กองทุนพัฒนาฝีมือแรงงาน ประจำปี" OnClientClick="SetWindowPopup('St','2'); return false;"></asp:LinkButton>
                            <%--<asp:LinkButton runat="server" ID="chk1"   Text="ฝย/ผป 1 (ฝึกยกระดับฝีมือแรงงาน/ฝึกเปลี่ยนสาขาอาชีพ)" OnClientClick="SetWindowPopup('FyFp','1'); return false;"></asp:LinkButton>--%>
                        </td>
                   </tr>
                   <tr>
                       <td  ></td> 
                       <td  >
                           <asp:Image id="Image2" runat="server" ImageUrl ="~/Image/icon/reports.png"  />
                       </td> 
                       <td  >
                           <asp:LinkButton runat="server" ID="chk21"    Text="สท. 2-1 (ประกอบการยื่น สท.2 ประจำปี) สรุปจำนวนตามเลขที่หนังสือรับรอง" OnClientClick="SetWindowPopup('St','21'); return false;" ></asp:LinkButton>
                           <%--<asp:LinkButton runat="server" ID="chk21"    Text="ฝย/ผป 2-1" OnClientClick="SetWindowPopup('FyFp','21'); return false;"></asp:LinkButton>--%>
                       </td>
                   </tr>
                   <tr>
                       <td  ></td> 
                        <td  >
                           <asp:Image id="Image3" runat="server" ImageUrl ="~/Image/icon/reports.png"  />
                       </td> 
                       <td  >
                           <asp:LinkButton runat="server" ID="chk22"    Text="สท. 2-2 (ประกอบการยื่น สท.2 ประจำปี) แสดงรายละเอียดการอบรม" OnClientClick="SetWindowPopup('St','22'); return false;" ></asp:LinkButton>
                           <%--<asp:LinkButton runat="server" ID="chk22"    Text="ฝย/ผป 2-2 เฉพาะประเภทการฝึกอบรมภายนอก (Public)" OnClientClick="SetWindowPopup('FyFp','22'); return false;"></asp:LinkButton>--%>
                       </td>
                   </tr>
                   <tr>
                       <td></td>
                   </tr>
               </table>
            </fieldset> 
        </div>
    </form>
</body>
</html>
