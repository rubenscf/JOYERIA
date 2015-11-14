<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInventario.aspx.vb" Inherits="proyecto_seminario.frmInventario" %>

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
                <ext:GridPanel runat="server" ID="dg" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true">
                    <Store>
                        <ext:Store ID="stInventario" runat="server">
                            <Model>
                                <ext:Model ID="mdProductos" runat="server">
                                    <Fields>
                                        <ext:ModelField Name="IDLUGAR" />
                                        <ext:ModelField Name="STOCK" />
                                        <ext:ModelField Name="IDPR_MODELO" />
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
                                <ext:Label ID="Titulo" runat="server" ></ext:Label>
                                <ext:ToolbarFill ID="ToolbarFill2" runat="server" />
                                 <ext:ComboBox runat="server" ID="cmbLugar" Width="400" FieldLabel="Inventario" DisplayField="nombre" ValueField="idlugar" Editable="false" Flex="1">
                                    <Store>
                                        <ext:Store ID="stLugar" runat="server">
                                            <Model>
                                                <ext:Model ID="mdProveedores" runat="server">
                                                    <Fields>
                                                        <ext:ModelField Name="idlugar" />
                                                        <ext:ModelField Name="nombre" />
                                                    </Fields>
                                                </ext:Model>
                                            </Model>
                                        </ext:Store>
                                    </Store>
                                </ext:ComboBox>
                                <ext:ToolbarSeparator />
                                <ext:ComboBox ID="cmbTipo" runat="server" Editable="false" >
                                    <Items>
                                        <ext:ListItem Text="ACTIVO" Value="ACTIVO" />
                                        <ext:ListItem Text="INACTIVO" Value="INACTIVO" />
                                        <ext:ListItem Text="RECOGIDO" Value="RECOGIDO" />


                                    </Items>
                                </ext:ComboBox>
                                <ext:Button ID="btnActualizar" runat="server" Width="160" ToolTip="Actualizar" Icon="Reload">
                                    <Listeners>
                                        <Click Handler="App.direct.fLlenarGrid()"></Click>
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
                            <ext:Column ID="Column1" runat="server" DataIndex="STOCK" Text="Stock" Visible="true" Width="80" Filterable="false" />
                            <ext:Column ID="Column3" runat="server" DataIndex="IDPR_MODELO" Text="CODIGO" Flex="1" />
                            <ext:Column ID="Column4" runat="server" DataIndex="FAMILIA" Text="Familia" Flex="1" />
                            <ext:Column ID="Column5" runat="server" DataIndex="MATERIAL" Text="Material" Flex="1" />
                            <ext:Column ID="Column6" runat="server" DataIndex="PRODUCTO" Text="Descripcion" Width="350" />
                            <ext:Column ID="Column7" runat="server" DataIndex="PRECIO_VENTA" Text="Precio Venta" Flex="1" />
                            <ext:Column ID="Column8" runat="server" DataIndex="ESTADO" Text="Estado" Flex="1" />
                            <ext:CommandColumn runat="server" Width="30">
                                <Commands>
                                    <ext:GridCommand Icon="PageRefresh" CommandName="btnEditar" ToolTip-Text="Kardex" />
                                </Commands>
                                <Listeners>
                                    <Command Handler="App.direct.fcrearVentanaProveedor(2, record.data.IDPROVEEDOR, record.data.IDPR_FAMILIA, record.data.IDPR_MATERIAL, record.data.IDPR_MODELO, record.data.PRODUCTO, record.data.PRECIO_COMPRA, record.data.PRECIO_VENTA, record.data.ESTADO);" />
                                </Listeners>
                            </ext:CommandColumn>
                        </Columns>
                    </ColumnModel>
                    <Plugins>
                        <ext:FilterHeader runat="server" Remote="false" />
                    </Plugins>

                    <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" RefreshHandler="App.direct.fLlenarGrid()" />
                    </BottomBar>
                </ext:GridPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
