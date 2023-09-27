<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PrintReport.aspx.vb" Inherits="Report_PrintReport" EnableViewState="false"  %>


<%----%>
<%@ Register Assembly="Telerik.ReportViewer.WebForms" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>
<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=13.1.19.618, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" id="html">
<head runat="server">
    <meta http-equiv='cache-control' content='no-cache'>
    <meta http-equiv='expires' content='0'>
    <meta http-equiv='pragma' content='no-cache'>
  <%--  <link rel="shortcut icon" href="../Image/icon/time_attendance_small_NAr_icon.ico" />--%>
    <title>Print Preview</title>
 
    <style type="text/css">   
    html#html, body#body, form#form1, div#content
    { 
        height: 99.8%;
    }

    </style>
</head>
<body id="body" style="margin-top: 1px; margin-bottom: 1px; margin-left: 5px; margin-right: 5px;">
    <form id="form1" runat="server">
    <div id="content">  
        <telerik:ReportViewer ID="ReportViewer1" runat="server" height="100%" Width="100%"     ViewStateMode="Disabled" >
        </telerik:ReportViewer>
    </div>     
    </form>
  
</body>
</html>
