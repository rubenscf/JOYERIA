<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmTipoCuenta.aspx.vb" Inherits="proyecto_seminario.frmTipoCuenta" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="Scripts/jsTipoCuenta.js"> </script>
</head>
<body>
    <form id="form1" runat="server">
   




        

        
         <ext:ResourceManager ID="rmTipoCuenta" runat="server" />
        <ext:Viewport ID="vpctl" runat="server" Layout="AbsoluteLayout" AnchorVertical="100%">
            <Items>
                <ext:GridPanel ID="GridMaquinaria" runat="server" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true" StripeRows="true" Resizable="true">
                    <Store>
                        <ext:Store runat="server" ID="stTipoCuenta" >
                            <Model>
                                <ext:Model runat="server" ID="mgTipoCuenta">
                                    <Fields>
                                        <ext:ModelField Name="IdTipo_cta" Type="Int"  />
                                        <ext:ModelField Name="descripcion" Type="String"/>
                                       

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
                                <ext:Button ID="btnAgregar" runat="server" Width="200" Text="Agregar Tipo de Cuenta" Icon="Add" >
                                    <Listeners>
                                        <Click Handler="App.direct.fcrearVentanaTipoCuenta(1,0,0)"></Click>
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
                            <ext:Column runat="server" ID="ColumnIdTipoCuenta" Text="Correlativo" Width="150" Align="Center"  DataIndex="IdTipo_cta" Visible="true"/>
                            <ext:Column runat="server" ID="ColumnNombre" Text="Tipo de Cuenta" Width="600" Align="Center" DataIndex="descripcion" />
                            
                            
                            <ext:CommandColumn ID="CommandColumn1" runat="server" Width="100" Text="Tareas" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Editar" Text="Editar" ToolTip-Text="Editar datos" />
                                </Commands>
                               <Listeners>
                                    <Command Handler="fCrearVentanaTipoCuenta(command, record);" />
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
