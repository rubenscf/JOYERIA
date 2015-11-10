<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmDiario.aspx.vb" Inherits="proyecto_seminario.frmDiario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>


    <form id="form1" runat="server">
    
         <ext:ResourceManager ID="rmCatalogoCuentas" runat="server" />
        
                
             
         <ext:Viewport ID="vpctl" runat="server" Layout="AbsoluteLayout" AnchorVertical="100%">
             

            <Items>
                <ext:GridPanel ID="GridMaquinaria" runat="server" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true" StripeRows="true" Resizable="true">
                    <Store>
                        <ext:Store runat="server" ID="stCuenta">
                            <Model>
                                <ext:Model runat="server" ID="mgCatalogoCuentas">
                                    <Fields>
                                        <ext:ModelField Name="CODIGO_CTA" Type="string" />
                                        <ext:ModelField Name="DESCRIPCION" Type="string" />
                                        <ext:ModelField Name="NOMBRE" Type="string" />
                                        <ext:ModelField Name="NIVEL" Type="int" />
                                        <ext:ModelField Name="SUMARIZA" Type="string" />
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

                                <ext:ComboBox ID="cboAnio" runat="server" EmptyText="ej: 2015" Icon="Date" Width="100" >
                                   <Items>
                                   <ext:ListItem Text="2015" Value="2015" />
                                 
                                   </Items>
                                </ext:ComboBox>
                                
                                <ext:ComboBox ID="cboFecha" runat="server" EmptyText="ej: ENERO" Icon="Date" Width="135" >
                                   <Items>
                                   <ext:ListItem Text="ENERO" Value="1" />
                                   <ext:ListItem Text="FEBRERO" Value="2" />
                                   <ext:ListItem Text="MARZO" Value="3" />
                                   <ext:ListItem Text="ABRIL" Value="4" />
                                
                                   </Items>
                                </ext:ComboBox>

                             



                                <ext:Button ID="btnAgregar" runat="server" Width="120" Text="Ver Información" Icon="ApplicationViewColumns" >
                                    <Listeners>
                                        <Click Handler="App.direct.fVer()"></Click>
                                    </Listeners>
                                </ext:Button>
                               
                              
                               
                                         
                                                               
                            </Items>
                        </ext:Toolbar>
                    </TopBar>
                       <BottomBar>
                           
                           
                           <ext:PagingToolbar ID="PagingToolbar1" runat="server" DisplayInfo="true" DisplayMsg="Mostrando {0} - {1} of {2}" EmptyMsg="No hay datos que mostrar" />
                         
                       </BottomBar>
                  
                    <ColumnModel>
                        <Columns>
                            <ext:Column  runat="server" ID="ColumnTipo" Text="COD" Width="75" Align="left" DataIndex="DESCRIPCION" />
                            <ext:Column runat="server" ID="ColumnCodigo" Text="NOMBRE CUENTA" Flex="1" Alig="Right" DataIndex="CODIGO_CTA" />
                            <ext:Column runat="server" ID="ColumnNombre" Text="CODIGO"  Width="125" Align="Left" DataIndex="NOMBRE" />
                            <ext:Column runat="server" ID="ColumnDebe" Text="DEBE" Width="150" Align="Right" DataIndex="NIVEL"  />
                            <ext:Column runat="server" ID="ColumnHaber" Text="HABER"  width="150" Align="Right" DataIndex="SUMARIZA" />
                            <ext:Column runat="server" ID="ColumnSaldo" Text="SALDO"  width="150" Align="Right" DataIndex="SUMARIZA" />

                          
                        </Columns>
                    </ColumnModel>
                </ext:GridPanel>


            </Items>

                

        </ext:Viewport>
        

           
 </form>








</body>
</html>
