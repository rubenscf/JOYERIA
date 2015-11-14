<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEmpleados.aspx.vb" Inherits="proyecto_seminario.frmEmpleados" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="Scripts/jsEmpleados.js"></script>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
       <ext:ResourceManager ID="rsEmpleados" runat="server" />
        <ext:Viewport runat="server" ID="vpEmpleados" Layout="AbsoluteLayout">
            <Items>
                <ext:GridPanel runat="server" ID="dg" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true">
                    <Store>
                        <ext:Store ID="stCatalogoEmpleado" runat="server">
                            <Model>
                                <ext:Model ID="mpEmpleado" runat="server">
                                    <Fields>

                                        <ext:ModelField Name="CODIGO" />
                                        <ext:ModelField Name="USUARIO" />
                                        <ext:ModelField Name="PUESTO" />
                                        <ext:ModelField Name="TIENDA" />
                                        <ext:ModelField Name="ESTABLECIMIENTO" />
                                        <ext:ModelField Name="NOMBRE" />
                                        <ext:ModelField Name="APELLIDO" />
                                        <ext:ModelField Name="DIRECCION" />
                                        <ext:ModelField Name="TELEFONO" />
                                        <ext:ModelField Name="DPI" />
                                        <ext:ModelField Name="EXTENDIDA" />
                                        <ext:ModelField Name="SEXO" />
                                        <ext:ModelField Name="ESTADO" />
                                        <ext:ModelField Name="FECHA_REGISTRO" />
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
                  
                                <ext:Button ID="btnNuevoEmpleado" runat="server" Width="160" Text="Agregar Empleado" Icon="Add">
                                    <Listeners>
                                        <Click Handler="fCrearEmpleado(1,0)"></Click>
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
                            <ext:Column ID="Column1" runat="server" DataIndex="CODIGO" Text="Codigo" Visible="true" Width="80" />
                            <ext:Column ID="Column3" runat="server" DataIndex="USUARIO" Text="Usuario" Flex="1" />
                            <ext:Column ID="Column4" runat="server" DataIndex="PUESTO" Text="Puesto" Flex="1" />
                            <ext:Column ID="Column5" runat="server" DataIndex="TIENDA" Text="Tienda" Flex="1" />
                            <ext:Column ID="Column6" runat="server" DataIndex="ESTABLECIMIENTO" Text="Establecimiento" Flex="1" />
                            <ext:Column ID="Column2" runat="server" DataIndex="NOMBRE" Text="Nombre" Flex="1" />
                            <ext:Column ID="Column7" runat="server" DataIndex="APELLIDO" Text="Apellido" Flex="1" />
                            <ext:Column ID="Column8" runat="server" DataIndex="DIRECCION" Text="Direccion" Flex="1" />
                            <ext:Column ID="Column9" runat="server" DataIndex="TELEFONO" Text="Telefono" Flex="1" />
                            <ext:Column ID="Column10" runat="server" DataIndex="DPI" Text="DPI" Flex="1" />
                            <ext:Column ID="Column11" runat="server" DataIndex="EXTENDIDA" Text="Extendida" Flex="1" />
                            <ext:Column ID="Column12" runat="server" DataIndex="SEXO" Text="Sexo" Flex="1" />
                            <ext:Column ID="Column13" runat="server" DataIndex="ESTADO" Text="Estado" Flex="1" />
                            <ext:Column ID="Column14" runat="server" DataIndex="FECHA_REGISTRO" Text="Fecha Registro" Flex="1" />
                            <ext:CommandColumn ID="CommandColumn4" runat="server" Flex="1" Text="Tareas" Align="Center">
                        
                              <Commands>
                                  <%----%>  
                                  <ext:GridCommand Icon="Pencil" CommandName="editarEmpleado" ToolTip-Text="Editar" />
                                  
                                </Commands>

                             <Listeners>
                                    <Command Handler="fCrearEmpleado(command, record);" />
                             </Listeners>

                              </ext:CommandColumn>
                        </Columns>

                    </ColumnModel>

                     <Plugins>
                        <ext:FilterHeader runat="server" Remote="false" />
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