<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pagina_principal.aspx.vb" Inherits="proyecto_seminario.pagina_principal" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Proyecto Seminario Joyeria</title>
   
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

    <link rel="shortcut icon" type="image/ico" href="Images/favicon.png" />
    <ext:ResourcePlaceHolder ID="ResourcePlaceHolder1" runat="server" Mode="ScriptFiles" />
</head>
<body >
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
                                                 </ext:MenuItem>
                                                <ext:MenuItem runat="server" ID="mnulogOut" Text="Salir del Sistema" Icon="UserGo">
                                                  <Listeners>
                                                      <Click Handler="App.direct.Salir()"></Click>
                                                  </Listeners>
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
                            Icon="ApplicationDouble" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu2" runat="server">
                                <Items>
                                    <ext:MenuItem ID="miTipoLugar" runat="server" Text="Tipo Lugar" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id11', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miProveedores" runat="server" Text="Proveedores" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id12', 'Paginas/Catalogos/frmCatalogoProveedor.aspx','Catálogo Proveedor',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miFamilia" runat="server" Text="Familia de Productos" Icon="Box">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id13', 'Paginas/Catalogos/frmCatalogoFamilia.aspx','Catálogo Familias',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miMaterial" runat="server" Text="Materiales de productos" Icon="Box">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id14', 'Paginas/Catalogos/frmCatalogoMaterial.aspx','Catálogo Material',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miModelo" runat="server" Text="Productos" Icon="Box">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id15', 'Paginas/Catalogos/frmCatalogoModelo.aspx','Catálogo Productos',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                     <ext:MenuItem ID="MiInventario" runat="server" Text="Inventario" Icon="Box">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id16', 'Paginas/Catalogos/frmInventario.aspx','Catálogo Inventario',  this);" />
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
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id21', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Catálogo Tipo Lugar',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                         <ext:MenuItem ID="MenuItem5" runat="server" Text="Ingreso Factura Compra" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id22', 'Paginas/Compras/frmInsertarFacturaCompra.aspx','IngresoFacturaCompra',  this);" />
                                        </Listeners>

                                        </ext:MenuItem>
                                         <ext:MenuItem ID="MenuItem6" runat="server" Text="Solicitud Compra" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id23', 'Paginas/Compras/frmSolicitudCompra.aspx','SolicitudCompra',  this);" />
                                        </Listeners>
                                        </ext:MenuItem>
                                        
                                                                        
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpVentas3" runat="server"
                            Title="Venta" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu4" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem2" runat="server" Text="Nueva Venta" Icon="CoinsAdd">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id31', 'Paginas/Ventas/frmVentaContado.aspx','Nueva Venta Contado',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpContabilidad4" runat="server"
                            Title="Contabilidad" Collapsed="true"
                            Icon="Bricks" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu8" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem46" runat="server" Text="Parametros" Icon="Hourglass">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id46', 'Paginas/Contabilidad/frmParametros.aspx','Parametros',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="menuConta41" runat="server" Text="Periodo Contable" Icon="Date">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id41', 'Paginas/Contabilidad/frmPeriodoContable.aspx','Periodo Contable',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="MenuItem43" runat="server" Text="Tipo de Cuenta" Icon="Note">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id43', 'Paginas/Contabilidad/frmTipoCuenta.aspx','Tipos de Cuentas',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="menuConta42" runat="server" Text="Catalogo de Cuentas" Icon="Book">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id42', 'Paginas/Contabilidad/frmCatalogoCuentas.aspx','Cuentas Contables',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="MenuItem45" runat="server" Text="Asiento" Icon="Cmy">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id45', 'Paginas/Contabilidad/frmAsiento.aspx','Asiento Contable',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="menuConta44" runat="server" Text="Libro de Diario" Icon="ChartOrganisation">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id44', 'Paginas/Contabilidad/frmDiario.aspx','Libro de Diario',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpsCliente5" runat="server"
                            Title="Servicio al cliente" Collapsed="true"
                            Icon="userbrown" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu9" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem7" runat="server" Text="Mis Tickets" Icon="Vcard">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id51', 'Paginas/ServicioCliente/frmAdministrarServicioCliente.aspx','Administracion de Casos',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="MenuItem4" runat="server" Text="Asignación" Icon="GroupLink">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id52', 'Paginas/ServicioCliente/frmAsignacion.aspx','Asignación de Casos',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                 <%--   <ext:MenuItem ID="MenuItem3" runat="server" Text="Nuevo Ticket" Icon="GroupGear">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id53', 'Paginas/ServicioCliente/frmNuevoCaso.aspx','Nuevo Ticket',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>--%>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpAdministracion6" runat="server"
                            Title="Administrativo" Collapsed="true"
                            Icon="BookKey" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu10" runat="server">
                                <Items>
                                    <ext:MenuItem ID="MenuItem8" runat="server" Text="Usuarios" Icon="UserGrayCool">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Administracion Usuarios',  this);" />
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

