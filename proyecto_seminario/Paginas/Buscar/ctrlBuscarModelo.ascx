<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ctrlBuscarModelo.ascx.vb" Inherits="proyecto_seminario.ctrlBuscarModelo" %>
<ext:Window ID="ImgChooserDlg" runat="server"
    Height="400"
    Width="600"
    Cls="img-chooser-dlg"
    Title="Choose an Image"
    Layout="BorderLayout"
    BodyBorder="0">
    <Items>

        <ext:Viewport runat="server" ID="vpModelos" Layout="AbsoluteLayout">
            <Items>
                <ext:GridPanel runat="server" ID="dg" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true">
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

    </Items>
</ext:Window>
