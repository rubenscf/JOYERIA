<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmInsertarFacturaCompra.aspx.vb" Inherits="proyecto_seminario.frmInsertarFacturaCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="Scripts/jsComprasInsertarFacturaCompra.js"></script>
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rsInsertarFacturaCompra" runat="server" />
        <ext:Viewport runat="server" ID="vpInsertarFacturacompra" Layout="AbsoluteLayout">
            <Items>
               <ext:GridPanel 
                runat="server" 
                Title="Facturas de Compra" 
                Frame="true"
                anchorhorizontal="100%"
                anchorvertical="100%">
                    <Store>
                        <ext:Store ID="stInsertarFacturaCompra" runat="server">
                            <Model>
                                <ext:Model ID="ModelInsertarFacturaCompra" runat="server">
                                    <Fields>
                                        <ext:ModelField Name="idproveedor" />
                                        <ext:ModelField Name="idpr_fact_compra" />
                                        <ext:ModelField Name="fecha" />
                                        <ext:ModelField Name="idempleado" />
                                        <ext:ModelField Name="total" />
                                        <ext:ModelField Name="documento" />
                                        <ext:ModelField Name="estado" />
                                        <ext:ModelField Name="observaciones" />
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
                                <ext:Button ID="btnNuevaFacturaCompra" runat="server" Width="160" Text="Nuevo FacturaCompra" Icon="Add">
                                    <Listeners>
                                        <Click Handler="App.direct.fcrearVentanaInsertarFacturaCompra(1,0)"></Click>
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
                            <ext:Column ID="Column1" runat="server" DataIndex="idproveedor" Visible="true" Flex="1" />
                            <ext:Column ID="Column2" runat="server" DataIndex="idpr_fact_compra" Text="factura" Flex="1" />
                            <ext:Column ID="Column3" runat="server" DataIndex="fecha" Text="fecha" Flex="1" />
                            <ext:Column ID="Column4" runat="server" DataIndex="idempleado" Text="empleado" Flex="1" />
                            <ext:Column ID="Column5" runat="server" DataIndex="total" Text="total" Flex="1" />
                            <ext:Column ID="Column6" runat="server" DataIndex="documento" Text="documento" Flex="1" />
                            <ext:Column ID="Column7" runat="server" DataIndex="estado" Text="estado" Flex="1" />
                            <ext:Column ID="Column8" runat="server" DataIndex="observaciones" Text="observaciones" Flex="1" />
                            <ext:CommandColumn ID="CommandColumn4" runat="server" Flex="1" Text="Tareas" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="Pencil" CommandName="editarFacturaProveedor" ToolTip-Text="Editar" />
                                </Commands>
                                <Listeners>
                                    <Command Handler="fCrearVentanaInsertarFActuraCompra(command, record);" />
                                </Listeners>
                            </ext:CommandColumn>
                        </Columns>
                    </ColumnModel>
                   
                    <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" RefreshHandler="fLlenarGrid()" />
                    </BottomBar>
                </ext:GridPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
