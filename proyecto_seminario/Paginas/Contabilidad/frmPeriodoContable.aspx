<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPeriodoContable.aspx.vb" Inherits="proyecto_seminario.frmPeriodoContable" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                                        <ext:ModelField Name="ANIO" Type="Int" />
                                        <ext:ModelField Name="INICIO" Type="Date"/>
                                        <ext:ModelField Name="FIN" Type="Date"  />
                                        <ext:ModelField Name="ESTADO_PERIODO" Type="string" />
                                        <ext:ModelField Name="MES" Type="String" />
                                        <ext:ModelField Name="DESDE" Type="Date"/>
                                        <ext:ModelField Name="HASTA" Type="Date"  />
                                        <ext:ModelField Name="ESTADO_MES" Type="string" />


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
                            
                            <ext:Column runat="server" ID="ColumnAnio" Text="Año" Width="125" Align="Center" DataIndex="ANIO"/>
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Inicio"  Align="Center" DataIndex="INICIO" />
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Fin"  Align="Center" DataIndex="FIN" />
                            <ext:Column runat="server" ID="EstadoPeriodo" Text="Estado" Width="100" Align="Center" DataIndex="ESTADO_PERIODO" />
                            <ext:Column runat="server" ID="mes" Text="mes" Width="125" Align="Center" DataIndex="MES"/>
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Desde"  Align="Center" DataIndex="DESDE" />
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Hasta"  Align="Center" DataIndex="HASTA" />
                            <ext:Column runat="server" ID="EstadoMes" Text="Estado" Width="100"  Align="Center" DataIndex="ESTADO_MES" />
                           
                            
                            
                            
                             <ext:CommandColumn ID="CommandColumn1" runat="server" Width="300" Text="Operaciones" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Editar" Text="Editar" ToolTip-Text="Editar datos" />
                                </Commands>
                              
                            </ext:CommandColumn>

                        </Columns>
                    </ColumnModel>
                </ext:GridPanel>


            </Items>

        </ext:Viewport>









    </form>
</body>
</html>
