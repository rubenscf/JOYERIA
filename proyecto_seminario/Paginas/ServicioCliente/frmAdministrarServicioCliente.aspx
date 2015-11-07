<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmAdministrarServicioCliente.aspx.vb" Inherits="proyecto_seminario.frmAdministrarServicioCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="Scripts/jsServicioCliente.js"></script>
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
                    AnchorHorizontal="100%"
                    AnchorVertical="100%">
                    <Store>
                        <ext:Store ID="stTickets" runat="server">
                            <Model>
                                <ext:Model runat="server">
                                    <Fields>
                                        <ext:ModelField Name="IDCL_CASO" />
                                        <ext:ModelField Name="IDCL_TIPO_CASO" />
                                        <ext:ModelField Name="IDEMPLEADO" />
                                        <ext:ModelField Name="CLIENTE" />
                                        <ext:ModelField Name="EMPLEADO" />
                                        <ext:ModelField Name="PUESTO" />
                                        <ext:ModelField Name="EMAIL" />
                                        <ext:ModelField Name="FECHA" />
                                        <ext:ModelField Name="ASUNTO" />
                                        <ext:ModelField Name="TIPO_CASO" />
                                        <ext:ModelField Name="ESTADO" />
                                        <ext:ModelField Name="CALIFICACION" />
                                        <ext:ModelField Name="ASIGNADO" />
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
                                <ext:Button ID="btnnuevo" runat="server" Width="160" Text="Nuevo Ticket" Icon="Add">
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
                         
                            <ext:Column runat="server" Text="TICKET NO." Width="100" DataIndex="IDCL_CASO" Align="Center" />
                            <ext:Column runat="server" Text="Fecha" Flex="1" DataIndex="FECHA" />
                            <ext:Column runat="server" Text="Asunto" Flex="1" DataIndex="ASUNTO" />
                            <ext:Column runat="server" Text="Departamento" Width="180" DataIndex="TIPO_CASO" />
                            <ext:Column runat="server" Text="Estado" Flex="1" DataIndex="ESTADO" />
                            <ext:Column runat="server" Text="Calificacion" Flex="1" DataIndex="CALIFICACION" />
                            <ext:Column runat="server" Text="Encargado" Flex="1" DataIndex="EMPLEADO" />
                        


                            <ext:CommandColumn ID="CommandColumn1" runat="server" Width="75" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="Note" CommandName="Historial"  ToolTip-Text="Ver Conversacion"  />
                                    <ext:GridCommand Icon="bulleterror" CommandName="Prioridad" ToolTip-Text="Priorizar" />
                                    <ext:GridCommand Icon="Star" CommandName="Calificar" ToolTip-Text="Calificar" />
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
