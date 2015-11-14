<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="proyecto_seminario.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <!--[if IE]>
<object classid="clsid:25336920-03F9-11CF-8FD0-00AA00686F13" data="http://localhost:8085/pentaho/api/repos/%3Ahome%3Aopastor%3Aprueba.wcdf/generatedContent">
<p>backup content</p>
</object>
<![endif]-->

<!--[if !IE]> <-->
<object type="text/html" data="second.html">
<p>backup content</p>
</object>
<!--> <![endif]-->

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    
    form1.Attributes["src"] = "http://localhost:8085/pentaho/api/repos/%3Ahome%3Aopastor%3Aprueba.wcdf/generatedContent";
</body>
</html>
