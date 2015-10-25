<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmAdministrarServicioCliente.aspx.vb" Inherits="proyecto_seminario.frmAdministrarServicioCliente" %>

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
                Title="ADMINISTRACIÓN DE TICKET" 
                Frame="true"
                anchorhorizontal="100%"
                anchorvertical="100%">
                <Store>
                    <ext:Store ID="stTickets"  runat="server">
                          <Model>
                            <ext:Model runat="server">
                                <Fields>
                                    <ext:ModelField Name="Id_Ticket" />
                                    <ext:ModelField Name="Descripcion" />
                                    <ext:ModelField Name="Ultima_Actualizacion" />
                                    <ext:ModelField Name="Operador" />
                                    <ext:ModelField Name="Departamento" />
                                    <ext:ModelField Name="Tipo" />
                                    <ext:ModelField Name="Estado" />
                                    <ext:ModelField Name="Prioridad" />
                                    
                                </Fields>
                            </ext:Model>
                        </Model>
                        
                    </ext:Store>
                </Store>


                    <TopBar>
                        <ext:Toolbar ID="Toolbar5" runat="server">
                            <Items>
                                <ext:ToolbarFill ID="ToolbarFill2" runat="server" />
                                <ext:ToolbarSeparator />
                                <ext:Button ID="btnnuevo" runat="server" Width="160" Text="Nuevo Ticket" Icon="Add" >
                                    <Listeners>
                                        <Click Handler="App.direct.fcrearVentanaTicket(1,0,0)"></Click>
                                   </Listeners>
                                </ext:Button>
                                <ext:ToolbarSeparator />
                            </Items>
                        </ext:Toolbar>
                    </TopBar>





                <ColumnModel runat="server">
                    <Columns>
                        <ext:Column runat="server" Text="Id Ticket" Flex="1" DataIndex="Id_Ticket" />
                        <ext:Column runat="server" Text="Descripción" Flex="1" DataIndex="Descripcion" />
                        <ext:Column runat="server" Text="Ultima Actualización" Width="180" DataIndex="Ultima_Actualización" />
                        <ext:Column runat="server" Text="Operador" Flex="1" DataIndex="Operador" />
                        <ext:Column runat="server" Text="Departamento" Flex="1" DataIndex="Departamento" />
                        <ext:Column runat="server" Text="Tipo" Flex="1" DataIndex="Tipo" />
                        <ext:Column runat="server" Text="Estado" Flex="1" DataIndex="Estado" />
                        <ext:Column runat="server" Text="Prioridad" Flex="1" DataIndex="Prioridad" />


                       <ext:CommandColumn ID="CommandColumn1" runat="server" Width="180" Text="Acciones" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Historial" Text="Historial"  ToolTip-Text="Historial" />
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Prioridad" Text="Cambiar Prioridad"  ToolTip-Text="Prioridad" />
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Calificar" Text="Calificar"  ToolTip-Text="Calificar" />
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
