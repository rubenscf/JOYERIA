<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPeriodoContable.aspx.vb" Inherits="proyecto_seminario.frmPeriodoContable" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jsPeriodoContable.js" type="text/javascript">

    </script>
</head>
<body>
    <form id="form1" runat="server">
   


        
         <ext:ResourceManager ID="rmPeriodoContable" runat="server" />
        <ext:Viewport ID="vpctl" runat="server" Layout="AbsoluteLayout" AnchorVertical="100%">
            <Items>
                <ext:GridPanel ID="GridMaquinaria" runat="server" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true" StripeRows="true" Resizable="true">
                    <Store>
                        <ext:Store runat="server" ID="stPeriodoConta" >
                            <Model>
                                <ext:Model runat="server" ID="mgPeriodoConta">
                                    <Fields>
                                        <ext:ModelField Name="anio" Type="Int" />
                                        <ext:ModelField Name="fechaini" Type="Date"/>
                                        <ext:ModelField Name="fechafin" Type="Date"  />
                                        <ext:ModelField Name="estado" Type="string" />

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
                                <ext:Button ID="btnAgregar" runat="server" Width="160" Text="Agregar Asiento" Icon="Add" >
                                    <Listeners>
                                        <Click Handler="App.direct.fcrearVentanaPeriodo(1,0,0)"></Click>
                                    </Listeners>
                                </ext:Button>
                                <ext:ToolbarSeparator />
                            </Items>
                        </ext:Toolbar>
                    </TopBar>
                    <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" DisplayInfo="true" DisplayMsg="Mostrando {0} - {1} of {2}"
                            EmptyMsg="No hay datos que mostrar" />
                    </BottomBar>
                    <SelectionModel>
                        <ext:RowSelectionModel ID="rowSelectionModel1" runat="server">
                        </ext:RowSelectionModel>
                    </SelectionModel>
                    <ColumnModel>
                        <Columns>
                            <ext:Column runat="server" ID="ColumnAnio" Text="Año" Width="200" Align="Center"  DataIndex="anio"/>
                           
                             <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Inicio" Width="250" Align="Center" DataIndex="fechaini" />
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Fin"  Align="Center" Width="250" DataIndex="fechafin" />
                            
                            <ext:Column runat="server" ID="ColumnEstado" Text="Estado" Flex="1" Align="Center" Width="200" DataIndex="estado" />
                            <ext:CommandColumn ID="CommandColumn1" runat="server" Width="250" Text="Tareas" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Editar" Text="Editar" ToolTip-Text="Editar datos" />
                                </Commands>
                               <Listeners>
                                    <Command Handler="fCrearVentanaPeriodo(command, record);" />
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
