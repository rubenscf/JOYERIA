<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmCatalogoProveedor.aspx.vb" Inherits="proyecto_seminario.frmCatalogoProveedor" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="Scripts/jsCatalogoProveedores.js"></script>
    <title></title>


</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rsCatalogoProveedor" runat="server" />
        <ext:Viewport runat="server" ID="vpCatalogoProveedor" Layout="AbsoluteLayout">
            <Items>
                <ext:GridPanel runat="server" ID="dg" AnchorHorizontal="100%" Layout="AnchorLayout"
                    AnchorVertical="100%" Scroll="Both" AutoScroll="true" StripeRows="true">
                    <Store>
                        <ext:Store ID="stCatalogoProveedor" runat="server">
                            <Model>
                                <ext:Model ID="ModelCatalogoProveedor" runat="server">
                                    <Fields>
                                        <ext:ModelField Name="idproveedor" />
                                        <ext:ModelField Name="agente" />
                                        <ext:ModelField Name="emp_nombre" Type="String" />
                                        <ext:ModelField Name="emp_direccion" />
                                        <ext:ModelField Name="emp_nit" />
                                        <ext:ModelField Name="tel_agente" />
                                        <ext:ModelField Name="tel_empresa1" />
                                        <ext:ModelField Name="tel_empresa2" />
                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                    <TopBar>
                        <ext:Toolbar ID="Toolbar1" runat="server">
                            <Items>
                                <ext:ToolbarFill ID="ToolbarFill2" runat="server" />
                                <ext:TextField ID="FiltroProveedor" runat="server" FieldLabel="Buscar Proveedor">
                                    <Listeners>
                                        <Change Handler="Filtrar(this);" Buffer="250" />
                                    </Listeners>
                                    <Plugins>
                                        <ext:ClearButton ID="Btx" runat="server" />
                                    </Plugins>
                                </ext:TextField>
                                <ext:ToolbarSeparator />
                                <ext:Button ID="btnNuevoProveedor" runat="server" Width="160" Text="Nuevo Proveedor" Icon="Add">
                                    <Listeners>
                                        <Click Handler="fCrearVentanaProveedor(1,0)"></Click>
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
                            <ext:Column ID="Column1" runat="server" DataIndex="idproveedor" Visible="true" Width="40" />
                            <ext:Column ID="Column2" runat="server" DataIndex="agente" Text="Agente" Width="180" />
                            <ext:Column ID="Column3" runat="server" DataIndex="emp_nombre" Text="Empresa" Width="180" />
                            <ext:Column ID="Column4" runat="server" DataIndex="emp_direccion" Text="Direccion" Width="230" />
                            <ext:Column ID="Column5" runat="server" DataIndex="emp_nit" Text="NIT" Flex="1" />
                            <ext:Column ID="Column6" runat="server" DataIndex="tel_agente" Text="Tel Agente" Flex="1" />
                            <ext:Column ID="Column7" runat="server" DataIndex="tel_empresa1" Text="Tel Empresa" Flex="1" />
                            <ext:Column ID="Column8" runat="server" DataIndex="tel_empresa2" Text="Tel Empresa1" Flex="1" />
                            <ext:CommandColumn ID="CommandColumn4" runat="server" Flex="1" Text="Tareas" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="Pencil" CommandName="editarProveedor" ToolTip-Text="Editar" />
                                </Commands>
                                <Listeners>
                                    <Command Handler="fCrearVentanaProveedor(command, record);" />
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
