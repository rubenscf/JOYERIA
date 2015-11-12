<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInventarios.aspx.vb" Inherits="proyecto_seminario.frmInventarios" %>

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
                                    <ext:GridCommand Icon="Accept" CommandName="btnAceptar" ToolTip-Text="Seleccionar" />
                                </Commands>
                                <Listeners>
                                    <Command Handler="parent.App.direct.fSeleccionar(record.data); parent.App.Win_BuscarInvetario.close();" />
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
