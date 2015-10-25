<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmCatalogoModelo.aspx.vb" Inherits="proyecto_seminario.frmCatalogoModelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager runat="server" />
        <ext:Viewport runat="server" ID="vpCatalogoFamilia" Layout="AbsoluteLayout">
            <Items>
                <ext:GridPanel runat="server" ID="dg" AnchorHorizontal="100%" Layout="AnchorLayout" AnchorVertical="100%" Scroll="Both" AutoScroll="true">
                    <Store>
                        <ext:Store ID="stProductos" runat="server">
                            <Model>
                                <ext:Model ID="mdProductos" runat="server">
                                    <Fields>

                                        <ext:ModelField Name="IDPROVEEDOR" />
                                        <ext:ModelField Name="IDPR_MATERIAL" />
                                        <ext:ModelField Name="IDPR_FAMILIA" />
                                        <ext:ModelField Name="IDPR_MODELO" />
                                        <ext:ModelField Name="PROVEEDOR" />
                                        <ext:ModelField Name="FAMILIA" />
                                        <ext:ModelField Name="MATERIAL" />
                                        <ext:ModelField Name="PRODUCTO" />
                                        <ext:ModelField Name="PRECIO_COMPRA" />
                                        <ext:ModelField Name="PRECIO_VENTA" />
                                        <ext:ModelField Name="ESTADO" />
                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                    <TopBar>
                        <ext:Toolbar ID="Toolbar1" runat="server">
                            <Items>
                                <ext:ToolbarFill ID="ToolbarFill2" runat="server" />
                                <ext:ToolbarSeparator />
                  
                                <ext:Button ID="btnNuevoModelo" runat="server" Width="160" Text="Agregar Modelo" Icon="Add">
                                    <Listeners>
                                        <Click Handler="App.direct.fcrearVentanaProveedor(1, 0,0,0,'','','','','')"></Click>
                                    </Listeners>
                                </ext:Button>
                                <ext:ToolbarSeparator />
                            </Items>
                        </ext:Toolbar>
                    </TopBar>
                    <SelectionModel>
                        <ext:RowSelectionModel ID="rowSelectionModel1" runat="server" />
                    </SelectionModel>
                    <ColumnModel ID="ColumnModel1" runat="server">
                        <Columns>
                            <ext:Column ID="Column1" runat="server" DataIndex="IDPR_MODELO" Text="Codigo" Visible="true" Width="80" />
                            <ext:Column ID="Column3" runat="server" DataIndex="PROVEEDOR" Text="Proveedor" Flex="1" />
                            <ext:Column ID="Column4" runat="server" DataIndex="FAMILIA" Text="Familia" Flex="1" />
                            <ext:Column ID="Column5" runat="server" DataIndex="MATERIAL" Text="Material" Flex="1" />
                            <ext:Column ID="Column6" runat="server" DataIndex="PRODUCTO" Text="Descripcion" Flex="1" />
                            <ext:Column ID="Column2" runat="server" DataIndex="PRECIO_COMPRA" Text="Precio Compra" Flex="1" />
                            <ext:Column ID="Column7" runat="server" DataIndex="PRECIO_VENTA" Text="Precio Venta" Flex="1" />
                            <ext:Column ID="Column8" runat="server" DataIndex="ESTADO" Text="Estado" Flex="1" />
                            <ext:CommandColumn runat="server" Width="30">
                                <Commands>
                                    <ext:GridCommand Icon="Pencil" CommandName="btnEditar" ToolTip-Text="Editar Producto" />
                                </Commands>
                                <Listeners>
                                    <Command Handler="App.direct.fcrearVentanaProveedor(2, record.data.IDPROVEEDOR, record.data.IDPR_FAMILIA, record.data.IDPR_MATERIAL, record.data.IDPR_MODELO, record.data.PRODUCTO, record.data.PRECIO_COMPRA, record.data.PRECIO_VENTA, record.data.ESTADO);" />
                                </Listeners>
                            </ext:CommandColumn>
                        </Columns>
                    </ColumnModel>
                    <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" RefreshHandler="App.direct.fLlenarGrid()" />
                    </BottomBar>
                </ext:GridPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
