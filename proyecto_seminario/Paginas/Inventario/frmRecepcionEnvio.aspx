<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmRecepcionEnvio.aspx.vb" Inherits="proyecto_seminario.frmRecepcionEnvio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script>
        var foperar = function (command, record) {
            if (command == 'btnAceptar') {
                App.direct.fAceptar(record.data.SALE, record.data.IDEN_TIPO, record.data.CODIGO, record.data.VERSION, {
                    success: function (result) {
                        llenarGrid();
                    }
                });
            }
            else if (command == 'btnAnular') {
                App.direct.fAnular(record.data.SALE, record.data.IDEN_TIPO, record.data.CODIGO, record.data.VERSION, {
                    success: function (result) {
                        llenarGrid();
                    }
                });
            }
        },
        llenarGrid = function () {
            App.direct.fllenarGrid();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rmgFases" runat="server" />
        <ext:Store ID="stTipoMenu" runat="server">
            <Model>
                <ext:Model ID="mdTipoMenu" runat="server">
                    <Fields>
                        <ext:ModelField Name="idtipo_menu" />
                        <ext:ModelField Name="nombre" />
                    </Fields>
                </ext:Model>
            </Model>
        </ext:Store>
        <ext:Viewport runat="server" Layout="HBoxLayout">

            <LayoutConfig>
                <ext:HBoxLayoutConfig Align="Stretch"></ext:HBoxLayoutConfig>
            </LayoutConfig>
            <Defaults>
                <ext:Parameter Name="Border" Value="false" />
                <ext:Parameter Name="Flex" Value="1" />
                <ext:Parameter Name="Layout" Value="anchor" />
            </Defaults>

            <Items>



                <ext:Panel runat="server" Layout="FitLayout" Border="true">
                    <Items>
                        <ext:GridPanel runat="server" ID="gpMenu" Title="Recepcion de envios" Scroll="Both" AutoScroll="true" StripeRows="true">
                            <Store>
                                <ext:Store ID="stEnvio" runat="server" ItemID="id_menu">
                                    <Model>
                                        <ext:Model ID="mdCatalogoMenu" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="SALE" />
                                                <ext:ModelField Name="IDEN_TIPO" />
                                                <ext:ModelField Name="CODIGO" />
                                                <ext:ModelField Name="ORIGEN" />
                                                <ext:ModelField Name="FECHA" />
                                                <ext:ModelField Name="EMISOR" />
                                                <ext:ModelField Name="VERSION" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>

                            <ColumnModel ID="ColumnModel1" runat="server">
                                <Columns>
                                    <ext:Column ID="Column6" runat="server" Text="Fecha" DataIndex="FECHA" />
                                    <ext:Column ID="Column1" runat="server" Text="Origen" DataIndex="ORIGEN" Flex="1" />
                                    <ext:Column ID="Column2" runat="server" Text="Codigo" DataIndex="CODIGO" />
                                    <ext:Column ID="Column3" runat="server" Text="Emisor" DataIndex="EMISOR" />
                                    <ext:CommandColumn runat="server">
                                        <Commands>
                                            <ext:GridCommand CommandName="btnAceptar" Text="Aceptar" Icon="Accept"></ext:GridCommand>
                                            <ext:GridCommand CommandName="btnAnular" ToolTip-Text="Anular" Icon="Delete" />
                                        </Commands>
                                        <Listeners>
                                           <Command Handler="foperar(command, record);" />
                                        </Listeners>
                                    </ext:CommandColumn>

                                </Columns>
                            </ColumnModel>
                            <Listeners>
                                <SelectionChange Handler="App.direct.fllenarDetalle(selected[0].data.SALE,selected[0].data.IDEN_TIPO,selected[0].data.CODIGO,selected[0].data.VERSION); "></SelectionChange>
                            </Listeners>

                            <SelectionModel>
                                <ext:RowSelectionModel runat="server" Mode="Single" />
                            </SelectionModel>

                            <BottomBar>
                                <ext:PagingToolbar ID="PagingToolbar1" runat="server" RefreshHandler="App.direct.fConsultarMenu();" />
                            </BottomBar>
                        </ext:GridPanel>

                    </Items>
                </ext:Panel>
                <ext:Panel runat="server" Layout="FitLayout" Border="true">
                    <Defaults>
                    </Defaults>

                    <Items>
                        <ext:GridPanel runat="server" ID="gpDetalleMenu" Title="Detalle Envio" Scroll="Both" AutoScroll="true" StripeRows="true">
                            <Store>
                                <ext:Store ID="stDetalleEnvio" runat="server">
                                    <Model>
                                        <ext:Model ID="Model2" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="CANTIDAD" />
                                                <ext:ModelField Name="MODELO" />
                                                <ext:ModelField Name="ARTICULO" />
                                                <ext:ModelField Name="MATERIAL" />
                                                <ext:ModelField Name="DETALLE" />

                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>

                            <ColumnModel ID="ColumnModel2" runat="server">
                                <Columns>

                                    <ext:Column ID="Column7" runat="server" Text="Cantidad" DataIndex="CANTIDAD" Width="50" />
                                    <ext:Column ID="Column8" runat="server" Text="Modelo" DataIndex="MODELO" Flex="1" />
                                    <ext:Column ID="Column5" runat="server" Text="Articulo" DataIndex="ARTICULO" Flex="1" />
                                    <ext:Column ID="Column4" runat="server" Text="Material" DataIndex="MATERIAL" Flex="1" />
                                    <ext:Column ID="Column9" runat="server" Text="Producto" DataIndex="DETALLE" Flex="1" />


                                </Columns>
                            </ColumnModel>
                            <BottomBar>
                                <ext:PagingToolbar ID="PagingToolbar3" runat="server" RefreshHandler="" />
                            </BottomBar>
                        </ext:GridPanel>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>

</body>
</html>
