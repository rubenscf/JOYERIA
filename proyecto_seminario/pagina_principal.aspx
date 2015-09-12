<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pagina_principal.aspx.vb" Inherits="proyecto_seminario.pagina_principal" %>
<<<<<<< HEAD
=======

>>>>>>> origin/master
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Proyecto Seminario Joyeria</title>

    <%--<link rel="stylesheet" type="text/css" href="Css/generales.css" />--%>

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
                                        </div>
                                    </Content>
                                </ext:Panel>
                                <ext:ToolbarFill />
                                <ext:Button ID="BtnSesionCnfg" runat="server" Icon="UserGray" Text="Sesión">
                                    <Menu>
                                        <ext:Menu ID="Menu1" runat="server">
                                            <Items>
                                                <ext:MenuItem runat="server" ID="mnuPerfil" Text="Perfil" Icon="User" />
                                                <ext:MenuItem runat="server" ID="mnuchangePass" Text="Cambiar Contraseña" Icon="UserKey">
                                                    <Listeners>
                                                    </Listeners>
                                                </ext:MenuItem>
                                                <ext:MenuItem runat="server" ID="mnulogOut" Text="Salir del Sistema" Icon="UserGo">
                                                    <DirectEvents>
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
                        <ext:MenuPanel ID="mpCatalogos1" runat="server"
                            Title="Catalogos" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu2" runat="server">
                                <Items>
                                    <ext:MenuItem ID="miTipoLugar" runat="server" Text="Tipo Lugar" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpCompras2" runat="server"
                            Title="Compras" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu3" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem1" runat="server" Text="Tipo Lugar" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
<<<<<<< HEAD
                                  

                                    
=======
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpVentas3" runat="server"
                            Title="Ventas" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu4" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem2" runat="server" Text="Tipo Lugar" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
>>>>>>> origin/master
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpContabilidad4" runat="server"
                            Title="Contabilidad" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu8" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem6" runat="server" Text="Tipo Lugar" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpsCliente5" runat="server"
                            Title="Servicio al cliente" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu9" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem7" runat="server" Text="Tipo Lugar" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpAdministracion6" runat="server"
                            Title="Administrativo" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu10" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem8" runat="server" Text="Usuarios" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
<<<<<<< HEAD

=======
>>>>>>> origin/master
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                    </Items>

<<<<<<< HEAD
                     <Items>
                        <ext:MenuPanel ID="mpContabilidad" runat="server"
                            Title="Contabilidad" Collapsed="true"
=======
<<<<<<< HEAD







                          <Items>
                        <ext:MenuPanel ID="mpVentas" runat="server"
                            Title="Ventas" Collapsed="true"
>>>>>>> origin/master
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu4" runat="server">
                                <Items>
                                    <ext:MenuItem ID="miVentas1" runat="server" Text="Vent" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatVentas.aspx','Ventas',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                  


                                   



                                </Items>
                              
                            </Menu>
                        </ext:MenuPanel>
              
                    </Items>

<<<<<<< HEAD
=======




=======
>>>>>>> origin/master
>>>>>>> origin/master
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>

