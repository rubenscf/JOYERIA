<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmAsignacion.aspx.vb" Inherits="proyecto_seminario.frmAsignacion" %>

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
        <ext:Viewport runat="server" ID="vpServicio" Layout="AbsoluteLayout">
            <Items>
                <ext:GridPanel
                    runat="server" TitleAlign="Center"
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


                    <ColumnModel runat="server">
                        <Columns>

                            <ext:Column runat="server" Text="TICKET NO." Width="100" DataIndex="IDCL_CASO" Align="Center" />
                            <ext:Column runat="server" Text="Fecha" Flex="1" DataIndex="FECHA" />
                            <ext:Column runat="server" Text="Asunto" Flex="1" DataIndex="ASUNTO" />
                            <ext:Column runat="server" Text="Departamento" Width="180" DataIndex="TIPO_CASO" />
                            <ext:Column runat="server" Text="Cliente" Flex="1" DataIndex="CLIENTE" />
                            <ext:Column runat="server" Text="Estado" Flex="1" DataIndex="ESTADO" />

                            <ext:Column runat="server" Text="Encargado" Flex="1" DataIndex="EMPLEADO" />
                            <ext:CommandColumn ID="CommandColumn1" runat="server" Width="80" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="Link" CommandName="Asignar" Text="Asignar" />
                                </Commands>
                                <Listeners>
                                    <Command Handler="App.direct.fcrearVentanaAsignar(record.data.IDCL_CASO);" />
                                </Listeners>
                            </ext:CommandColumn>
                        </Columns>
                    </ColumnModel>
                    <Plugins>
                        <ext:FilterHeader runat="server" Remote="false" />
                        
                    </Plugins>
                </ext:GridPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
