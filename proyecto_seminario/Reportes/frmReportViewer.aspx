<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmReportViewer.aspx.vb" Inherits="proyecto_seminario.frmReportViewer"  Debug="true"%>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <rsweb:ReportViewer ID="ReportViewer1" runat="server">
        </rsweb:ReportViewer>
        <br />
    
    </div>
    </form>
</body>
</html>
