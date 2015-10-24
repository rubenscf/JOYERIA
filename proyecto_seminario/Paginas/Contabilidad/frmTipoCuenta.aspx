<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmTipoCuenta.aspx.vb" Inherits="proyecto_seminario.frmTipoCuenta" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>


        var fEditar = function (editor, e) {
            if (!(e.value === e.originalValue)) {
                App.direct.fModificarTipoCuenta(e.record.data.IdTipo_cta, e.record.data.descripcion,
                   {
                       success: function (result) {
                           if (result == 2) {
                               Ext.net.Notification.show({
                                   iconCls: 'icon-information', pinEvent: 'click', html: '<h3>MODIFICADO</h3>'
                               });
                               App.direct.fLlenarGrid();
                           } else {
                               //msgBoxA('ERROR!!!', 'El Registro no fue procesado!');
                           };
                       }

                   });

            }
        };
    </script>
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
                                
                                
                                <ext:TextField runat="server" ID="txtDescripcion" EmptyText="INGRESE NOMBRE CUENTA" AllowBlank="false" Width="300" Regex="[A-Z]" MaxLengthText="100" FieldLabel="NOMBRE" />
                                <ext:ToolbarSeparator />


                                <ext:Button ID="btnGuardar" runat="server" Width="150" Text="Guardar" Icon="Disk" >
                                    <Listeners>

                                     <Click Handler="App.direct.fGuardar();" />
                                      

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

                            <ext:Column runat="server" ID="ColumnIdTipoCuenta" Text="Correlativo" Width="150" Align="Center"  DataIndex="IdTipo_cta" Visible="true"/>
                            <ext:Column runat="server" ID="ColumnNombre" Text="Tipo de Cuenta" Flex="1" Align="Left" DataIndex="descripcion">
                                <Editor>
                                    <ext:TextField runat="server" />
                                </Editor>

                            </ext:Column>
                             
                            
                           


                        </Columns>
                    </ColumnModel>

                    <SelectionModel>
                          <ext:CellSelectionModel runat="server" />
                     </SelectionModel>
                      <Plugins>
                          <ext:CellEditing runat="server">
                             <Listeners>
                        
                            <Edit Fn="fEditar"></Edit>

                            </Listeners>
                         </ext:CellEditing>
                     </Plugins>

                </ext:GridPanel>







            </Items>

        </ext:Viewport>







    </form>
</body>
</html>
