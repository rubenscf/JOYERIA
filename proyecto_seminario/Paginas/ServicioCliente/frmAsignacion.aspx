<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmAsignacion.aspx.vb" Inherits="proyecto_seminario.frmAsignacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <ext:ResourceManager ID="rsServicioAlCliente" runat="server" />
        <ext:Viewport runat="server" ID="vpServicioAlCliente" Layout="AbsoluteLayout">
            <Items>
                <ext:GridPanel 
                runat="server" 
                Title="ASIGNACION DE  TICKET" 
                Frame="true"
                anchorhorizontal="100%"
                anchorvertical="100%">
                <Store>
                    <ext:Store ID="dd"  runat="server">
                          <Model>
                            <ext:Model runat="server">
                                <Fields>
                                    <ext:ModelField Name="Id_Ticket" />
                                    <ext:ModelField Name="Descripcion" />
                                    <ext:ModelField Name="Fecha_Creacion" />
                                    <ext:ModelField Name="Estado" />
                                                                       
                                </Fields>
                            </ext:Model>
                        </Model>
                        
                    </ext:Store>
                </Store>


                   <TopBar>
                        <ext:Toolbar ID="Toolbar5" runat="server">
                            <Items>
                                <ext:ToolbarFill ID="ToolbarFill2" runat="server" />
                                <%--<ext:ToolbarSeparator />
                                <ext:Button ID="btnnuevo" runat="server" Width="160" Text="Nuevo Ticket" Icon="Add" >
                                    <Listeners>
                                        <Click Handler="App.direct.fcrearVentanaCuentas(1,0,0)"></Click>
                                    </Listeners>
                                </ext:Button>
                                <ext:ToolbarSeparator />--%>
                            </Items>
                        </ext:Toolbar>
                    </TopBar>


                <ColumnModel runat="server">
                    <Columns>
                        <ext:Column runat="server" Text="Id Ticket" Flex="1" DataIndex="Id_Ticket" />
                        <ext:Column runat="server" Text="Descripción" Flex="1" DataIndex="Descripcion" />
                        <ext:Column runat="server" Text="Fecha Creación" Width="180" DataIndex="Fecha_Creacion" />
                        <ext:Column runat="server" Text="Estado" Flex="1" DataIndex="Estado" />
                        

                       <ext:CommandColumn ID="CommandColumn1" runat="server" Width="180" Text="Acciones" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Asignar" Text="Asignar"  ToolTip-Text="Asignar" />
                                </Commands>
                                <Listeners>
                                      
                                </Listeners>
                            </ext:CommandColumn>

                    </Columns>
                </ColumnModel>
            </ext:GridPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
