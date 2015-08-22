<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pagina_principal.aspx.vb" Inherits="proyecto_seminario.pagina_principal" %>


<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Proyecto Seminario Joyeria</title>

    <link rel="stylesheet" type="text/css" href="Css/generales.css" />

    <style type="text/css">
        .x-menu-body {
            background-color: white !important;
        }

        img.displayed {
            display: block;
            margin: 0 auto;
            clear: right;
        }
    </style>

    <link rel="shortcut icon" type="image/ico" href="Images/favicon.ico" />
    <ext:ResourcePlaceHolder ID="ResourcePlaceHolder1" runat="server" Mode="ScriptFiles" />
</head>
<body>
    <form id="frmPanelPrincipal" runat="server">
        <script src="Scripts/panel_administracion.js" type="text/javascript"></script>
        <ext:ResourceManager ID="ResourceManager1" runat="server" InitScriptMode="Linked"
            DirectEventUrl="panel_principal.aspx" IDMode="Explicit" />
        <ext:Viewport ID="Viewport1" runat="server" Layout="BorderLayout">
            <Items>
                <ext:Panel ID="pnlToolbar" runat="server" Region="North" Height="95">
                    <Items>
                        <ext:Toolbar ID="Toolbar1" runat="server" Height="95">
                            <Items>
                                <ext:Panel ID="DisplayField12" runat="server">
                                    <Content>
                                        <div>
                                            <asp:Image runat="server" ImageUrl="~/Images/logo.png" ID="Image1" ImageAlign="AbsMiddle" />
                                            <%--<asp:Image runat="server" ImageUrl="~/Images/Gisystems Logo 100x23.jpg" ID="LogoGI" ImageAlign="AbsMiddle" />--%>
                                        </div>
                                    </Content>
                                </ext:Panel>
                                <ext:ToolbarFill />

                                  <ext:Button ID="BtnSesionCnfg" runat="server" Icon="UserGray" Text="Sesión">
                                    <Menu>
                                        <ext:Menu ID="Menu1" runat="server">
                                            <Items>
                                                <ext:MenuItem runat="server" ID="mnuPerfil" Text="Perfil" Icon="User"/>
                                                <ext:MenuItem runat="server" ID="mnuchangePass" Text="Cambiar Contraseña" Icon="UserKey">
                                                    <Listeners>
                                                      <%--  <Click Handler="#{WindowCambioPassword}.show()" />--%>
                                                    </Listeners>
                                                </ext:MenuItem>
                                                <ext:MenuItem runat="server" ID="mnulogOut" Text="Salir del Sistema" Icon="UserGo">
                                                    <DirectEvents>
                                                        <%--<Click OnEvent="SalirSistema"></Click>--%>
                                                    </DirectEvents>
                                                </ext:MenuItem>
                                            </Items>
                                        </ext:Menu>
                                    </Menu>
                                </ext:Button>
                            </Items>
                        </ext:Toolbar>
                    </Items>
                </ext:Panel>
                <ext:TabPanel ID="tabPanelPrincipal"
                    runat="server"
                    Region="Center"
                    MarginSpec="5 5 5 0">
                    <Items>
                        <ext:Panel ID="PanelInfo" runat="server" Title="Dashboard" AutoRender="false">
                            <Loader ID="Loader1" runat="server" Url="Paginas/PanelesInformacion/Dashboard.aspx" DisableCaching="true" Mode="Frame" AutoLoad="false">
                                <LoadMask ShowMask="true" Msg="Espere un momento..." />
                            </Loader>
                        </ext:Panel>
                    </Items>
                </ext:TabPanel>
                <ext:Panel ID="pnlOeste" runat="server" Region="West"
                    Width="210" Collapsible="true" Split="true"
                    MinWidth="175" MaxWidth="400" MarginSpec="5 0 5 5"
                    Layout="AccordionLayout">
                    <Items>
                        <ext:MenuPanel ID="mpCatalogos" runat="server"
                            Title="Catalogos" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu3" runat="server">
                                <Items>
                                    <ext:MenuItem ID="miProvevedores" runat="server" Text="Proveedores" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatProveedores.aspx','Catálogo Proveedores',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miClientes" runat="server" Text="Clientes" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id2', 'Paginas/Catalogos/frmCatClientes.aspx','Catálogo Clientes',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miEmpleados" runat="server" Text="Empleados" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id3', 'Paginas/Catalogos/frmCatEmpleados.aspx', 'Catálogo Empleados', this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miCatTiendas" runat="server" Text="Tiendas" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id4', 'Paginas/Catalogos/frmCatEmpleados.aspx','Catálogos Tiendas',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                              
                            </Menu>
                        </ext:MenuPanel>
              
                    </Items>
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>

