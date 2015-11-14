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
                                <ext:FieldContainer runat="server" ID="InformacionSesion" Layout="VBoxLayout" Padding="5">
                                    <Items>
                                        <ext:Label runat="server" Icon="Tag" ID="lbllutipo" />
                                        <ext:Label runat="server" Icon="ApplicationHome" ID="lbllunombre" />
                                        <ext:Label runat="server" Icon="MedalGold1" ID="lblpuesto" />
                                    </Items>
                                </ext:FieldContainer>
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
                                  
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpCompras2" runat="server"
                            Title="Compras" Collapsed="true"
                            Icon="Note" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu3" runat="server">
                                <Items>
                                 
                                    <ext:MenuItem ID="MiIngresoFActura" runat="server" Text="Ingreso Factura Compra" Icon="BookEdit">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id22', 'Paginas/Compras/frmInsertarFacturaCompra.aspx','IngresoFacturaCompra',  this);" />
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
                                    <ext:MenuItem ID="miVentas" runat="server" Text="Nueva Venta" Icon="CoinsAdd">
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
                                    <ext:MenuItem ID="miParametros" runat="server" Text="Parametros" Icon="Hourglass">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id46', 'Paginas/Contabilidad/frmParametros.aspx','Parametros',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="miPeriodoConta" runat="server" Text="Periodo Contable" Icon="Date">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id41', 'Paginas/Contabilidad/frmPeriodoContable.aspx','Periodo Contable',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="miTipoCuenta" runat="server" Text="Tipo de Cuenta" Icon="Note">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id43', 'Paginas/Contabilidad/frmTipoCuenta.aspx','Tipos de Cuentas',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="miCatalogoCuenta" runat="server" Text="Catalogo de Cuentas" Icon="Book">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id42', 'Paginas/Contabilidad/frmCatalogoCuentas.aspx','Cuentas Contables',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="miAsientoCOntable" runat="server" Text="Asiento Contable" Icon="Cmy">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id45', 'Paginas/Contabilidad/frmAsiento.aspx','Asiento Contable',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                                <Items>
                                    <ext:MenuItem ID="miLibroDiario" runat="server" Text="Libro de Diario" Icon="ChartOrganisation">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id44', 'Paginas/Contabilidad/frmDiario.aspx','Libro de Diario',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                        <ext:MenuPanel ID="mpsCliente5" runat="server"
                            Title="Servicio Al Cliente" Collapsed="true"
                            Icon="userbrown" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu9" runat="server">
                                <Items>
                                    <ext:MenuItem ID="miTickets" runat="server" Text="Mis Tickets" Icon="Vcard">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id51', 'Paginas/ServicioCliente/frmAdministrarServicioCliente.aspx','Administracion de Casos',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    <ext:MenuItem ID="miAsignacion" runat="server" Text="Asignación" Icon="GroupLink">
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
                                    <ext:MenuItem ID="miUsuarios" runat="server" Text="Usuarios" Icon="UserGrayCool">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id1', 'Paginas/Catalogos/frmCatalogoTipoLugar.aspx','Administracion Usuarios',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>

                        <ext:MenuPanel ID="mpInventario7" runat="server"
                            Title="Inventario" Collapsed="true"
                            Icon="BookKey" AutoScroll="true" BodyPadding="5" Border="false">
                            <Menu ID="Menu11" runat="server">
                                <Items>
                                    <ext:MenuItem ID="miEnvios" runat="server" Text="Envios" Icon="ShapeMoveBack">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id71', 'Paginas/Inventario/frmEnvio.aspx','Envios',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                     <ext:MenuItem ID="MiRecepcionEnvio" runat="server" Text="Recepcion de Envios" Icon="ShapeMoveBack">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id72', 'Paginas/Inventario/frmRecepcionEnvio.aspx','Recepcion de Envios',  this);" />
                                        </Listeners>
                                    </ext:MenuItem>
                                      <ext:MenuItem ID="MiInventario" runat="server" Text="Inventario" Icon="ChartBar">
                                        <Listeners>
                                            <Click Handler="addTab(#{tabPanelPrincipal}, 'id73', 'Paginas/Inventario/frmInventario.aspx','Inventario',  this);" />
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

