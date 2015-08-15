<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pagina_principal.aspx.vb" Inherits="proyecto_seminario.pagina_principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--<script src="Scripts/panel_administracion.js" type="text/javascript"></script>--%>
        <ext:ResourceManager ID="ResourceManager1" runat="server" InitScriptMode="Linked"
            DirectEventUrl="PanelPrincipal.aspx" IDMode="Explicit" />
        <ext:Viewport ID="Viewport1" runat="server" Layout="BorderLayout">
            <Items>
                <ext:Panel ID="pnlToolbar" runat="server" Region="North" Height="80">
                    <Items>
                        <ext:Toolbar ID="Toolbar1" runat="server" Height="80">
                            <Items>
                                <ext:Panel ID="DisplayField12" runat="server">
                                    <Content>
                                        <div>
                                            <%--<asp:Image runat="server" ImageUrl="~/Images/fedefutguate.jpg" ID="Image1" ImageAlign="AbsMiddle" />--%>
                                            <%--<asp:Image runat="server" ImageUrl="~/Images/Gisystems Logo 100x23.jpg" ID="LogoGI" ImageAlign="AbsMiddle" />--%>
                                        </div>
                                    </Content>
                                </ext:Panel>
                            </Items>
                        </ext:Toolbar>
                    </Items>
                    </ext:Panel>
                </Items>
                    </ext:Viewport>





                    <%--                                <ext:Label runat="server" ID="lblUsuariosEtiqueta" Text="Usuarios en Linea"  />
                               <ext:Label runat="server" ID="lblUsuariosOnline" EmptyText="sin conexión" />--%>
    </form>
</body>
</html>
