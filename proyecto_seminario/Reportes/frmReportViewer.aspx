<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmReportViewer.aspx.vb" Inherits="proyecto_seminario.frmReportViewer"  Debug="true"%>


<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div>
    
        
       
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="449px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1105px">
           
        </rsweb:ReportViewer>
      

    </div>
    </form>
</body>
</html>
