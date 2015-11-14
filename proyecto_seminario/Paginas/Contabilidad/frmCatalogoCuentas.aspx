<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmCatalogoCuentas.aspx.vb" Inherits="proyecto_seminario.frmCatalogoCuentas" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
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
                                        <ext:ModelField Name="CODIGO" Type="string" />
                                        <ext:ModelField Name="NOMBRE" Type="string" />
                                        <ext:ModelField Name="MAY" Type="string" />
                                        <ext:ModelField Name="DESCRIPCION" Type="string" />
                                        <ext:ModelField Name="NIVEL" Type="int" />
                                        <ext:ModelField Name="SUMARIZA" Type="string" />
                                        <ext:ModelField Name="MOV" Type="string" />
                                        <ext:ModelField Name="AJUSTE" Type="string" />
                                        <ext:ModelField Name="TIPO" Type="string" />
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
                                <ext:Button ID="btnAgregar" runat="server" Width="160" Text="Agregar Cuenta" Icon="Add" >
                                    <Listeners>
                                        <Click Handler="App.direct.fcrearVentanaCuentas(1,0,0)"></Click>
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
                    
                    <ColumnModel>
                        <Columns>


                            <ext:Column runat="server" ID="ColumnCodigo" Text="Código" Width="90" Alig="Right" DataIndex="CODIGO"/>
                            <ext:Column runat="server" ID="ColumnNombre" Text="Nombre de Cuenta" Flex="1" Align="left" DataIndex="NOMBRE"/>                                                                                
                            <ext:Column runat="server" ID="ColumnMay" Text="Mayoriza" Width="90" Alig="Right" DataIndex="MAY"/>
                            <ext:Column runat="server" ID="ColumnMayoriza" Text="Nombre de Cuenta Mayoriza" Flex="1" Align="left" DataIndex="DESCRIPCION" />
                            <ext:Column runat="server" ID="ColumnNivel" Text="Niv" Width="65" Alig="Center" DataIndex="NIVEL"/>                              
                            <ext:Column runat="server" ID="ColumnSumariza" Text="Sum" width="65" Align="Center" DataIndex="SUMARIZA"/>                         
                            <ext:Column runat="server" ID="ColumnMon" Text="Mov" Width="65" Alig="Center" DataIndex="MOV"/>                       
                            <ext:Column runat="server" ID="ColumnAjuste" Text="Ajuste" width="75" Align="Center" DataIndex="AJUSTE"/>                            
                            <ext:Column  runat="server" ID="ColumnTipo" Text="Tipo de Cuenta" Flex="1" Align="Left" DataIndex="TIPO"/>
                       
                           

                        </Columns>
                    </ColumnModel>

                      <SelectionModel>
                          <ext:CellSelectionModel runat="server" />
                     </SelectionModel>
                  

                </ext:GridPanel>


            </Items>

        </ext:Viewport>

 </form>









</body>
</html>
