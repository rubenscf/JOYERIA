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
                                        <ext:ModelField Name="idproveedor" />
                                        <ext:ModelField Name="idpr_material" />
                                        <ext:ModelField Name="idpr_familia" />
                                        <ext:ModelField Name="idpr_modelo" />
                                        <ext:ModelField Name="proveedor" />
                                        <ext:ModelField Name="familia" />
                                        <ext:ModelField Name="material" />
                                        <ext:ModelField Name="producto" />
                                        <ext:ModelField Name="precio_compra" />
                                        <ext:ModelField Name="precio_venta" />
                                        <ext:ModelField Name="estado" />
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
                                <ext:TextField runat="server" ID="txtFamilia" Regex="[a-zA-Z]" AllowBlank="false"></ext:TextField>
                                <ext:Button ID="btnNuevoModelo" runat="server" Width="160" Text="Agregar Modelo" Icon="Add">
                                    <Listeners>
                                        <Click Handler="guardarNuevo()"></Click>
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
                            <ext:Column ID="Column1" runat="server" DataIndex="idpr_modelo" Text="Codigo" Visible="true" Width="150" />
                            <ext:Column ID="Column3" runat="server" DataIndex="proveedor" Text="Proveedor" Flex="1" />
                            <ext:Column ID="Column4" runat="server" DataIndex="familia" Text="Familia" Flex="1" />
                            <ext:Column ID="Column5" runat="server" DataIndex="material" Text="Material" Flex="1" />
                            <ext:Column ID="Column6" runat="server" DataIndex="producto" Text="Modelo" Flex="1" />
                            <ext:Column ID="Column2" runat="server" DataIndex="precio_compra" Text="Precio Compra" Flex="1" />
                            <ext:Column ID="Column7" runat="server" DataIndex="precio_venta" Text="Precio Venta" Flex="1" />
                            <ext:Column ID="Column8" runat="server" DataIndex="estado" Text="Familia" Flex="1" />
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
