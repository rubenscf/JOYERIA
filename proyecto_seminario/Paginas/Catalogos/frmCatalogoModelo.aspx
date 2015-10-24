<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmCatalogoModelo.aspx.vb" Inherits="proyecto_seminario.frmCatalogoModelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <ext:ResourceManager runat="server" />
        <ext:Viewport runat="server" ID="vpCatalogoFamilia" Layout="AbsoluteLayout">
            <Items>
                <ext:GridPanel runat="server" ID="dg" AnchorHorizontal="100%" Layout="AnchorLayout" AnchorVertical="100%" Scroll="Both" AutoScroll="true">
                    <Store>
                        <ext:Store ID="stCatalogoFamilia" runat="server">
                            <Model>
                                <ext:Model ID="ModelCatalogoFamilia" runat="server">
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
                                <ext:Button ID="btnGuardarFamilia" runat="server" Width="160" Text="Guardar Nueva" Icon="Add">
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
                            <ext:Column ID="Column1" runat="server" DataIndex="idpr_familia" Text="Codigo" Visible="true" Width="150" />
                            <ext:Column ID="Column2" runat="server" DataIndex="nombre" Text="Familia" Flex="1">
                                <Editor>
                                    <ext:TextField runat="server"></ext:TextField>
                                </Editor>
                            </ext:Column>
                        </Columns>
                    </ColumnModel>
                   
                    <Plugins>
                        <ext:CellEditing runat="server">
                            <Listeners>
                                <Edit Fn="fEditar" />
                            </Listeners>
                        </ext:CellEditing>
                    </Plugins>
                    <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" RefreshHandler="fLlenarGrid()" />
                    </BottomBar>
                </ext:GridPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
