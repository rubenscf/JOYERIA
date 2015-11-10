<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmCatalogoCuentas.aspx.vb" Inherits="proyecto_seminario.frmCatalogoCuentas" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>


    <script type="text/javascript" src="Scripts/jsCatalogoCuentas.js"></script>

      <script>


          var fEditar = function (editor, e) {
              if (!(e.value === e.originalValue)) {
                  App.direct.fModificarPlanCuenta(e.record.data.CODIGO, e.record.data.NOMBRE, e.record.data.MAY, e.record.data.DESCRIPCION, e.record.data.NIVEL, e.record.data.SUMARIZA, e.record.data.MOV, e.record.data.AJUSTE, e.record.data.TIPO,
                     {
                         success: function (result) {
                             if (result == 2) {
                                 Ext.net.Notification.show({
                                     iconCls: 'icon-information', pinEvent: 'click', html: '<h3>MODIFICADO</h3>'
                                 });
                                 App.direct.fLlenarGrid();
                             } else {
                                 msgBoxA('ERROR!!!', 'El Registro no fue procesado!');
                             };
                         }

                     });

              }
          };
    </script>





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

                            <ext:Column runat="server" ID="ColumnNombre" Text="Nombre de Cuenta" Flex="1" Align="left" DataIndex="NOMBRE">
                                <Editor>
                                    <ext:TextField runat="server" />
                                </Editor>
                            </ext:Column>
                            
                           

                            <ext:Column runat="server" ID="ColumnMay" Text="Mayoriza" Width="90" Alig="Right" DataIndex="MAY">
                                <Editor>
                                     <ext:ComboBox  ID="cboMayoriza" runat="server" DisplayField="NOMBRE" ValueField="CODIGO" Width="315" >
                                    <Store>
                                      <ext:Store ID="stMayoriza" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="Int" />
                                              <ext:ModelField Name="NOMBRE"  Type="String"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>      
                                 </ext:ComboBox>

                                </Editor>
                            </ext:Column>

                            


                            <ext:Column runat="server" ID="ColumnMayoriza" Text="Nombre de Cuenta Mayoriza" Flex="1" Align="left" DataIndex="DESCRIPCION" />


                            <ext:Column runat="server" ID="ColumnNivel" Text="Niv" Width="65" Alig="Center" DataIndex="NIVEL">
                                <Editor>
                                    <ext:NumberField ID="txtNivel"  runat="server"  MinValue="1" MaxValue="5" Width="165" AllowBlank="false">
                                       </ext:NumberField>
                                </Editor>
                            </ext:Column>

                          

                            <ext:Column runat="server" ID="ColumnSumariza" Text="Sum" width="65" Align="Center" DataIndex="SUMARIZA">
                                <Editor>
                                     <ext:ComboBox ID="cboSumariza_cta" runat="server" Editable="false" Visible="true" AllowBlank="false" Width="150">                    
                                              <Items>
                                                <ext:ListItem Text="NO"  />
                                                <ext:ListItem Text="SI" />
                                              </Items>
                                           </ext:ComboBox>
                                </Editor>
                            </ext:Column>


                            <ext:Column runat="server" ID="ColumnMon" Text="Mov" Width="65" Alig="Center" DataIndex="MOV">
                                <Editor>
                                     <ext:ComboBox ID="cboMovimiento" runat="server" Editable="false" Visible="true"   Width="165">                    
                                              <Items>
                                                <ext:ListItem Text="NO"  />
                                                <ext:ListItem Text="SI" />
                                              </Items>
                                           </ext:ComboBox>
                                </Editor>
                            </ext:Column>

                            <ext:Column runat="server" ID="ColumnAjuste" Text="Ajuste" width="75" Align="Center" DataIndex="AJUSTE">
                                <Editor>
                                     <ext:ComboBox ID="cboAjusta" runat="server" Editable="false" Visible="true"   Width="150">                    
                                              <Items>
                                                <ext:ListItem Text="NO"  />
                                                <ext:ListItem Text="SI" />
                                              </Items>
                                      </ext:ComboBox>
                                </Editor>
                            </ext:Column>

                            <ext:Column  runat="server" ID="ColumnTipo" Text="Tipo de Cuenta" Width="125" Align="Left" DataIndex="TIPO">
                                <Editor>
                                    <ext:ComboBox ID="cboTipo_cta" runat="server"  Visible="true" AllowBlank="false" Width="315" ValueField="IdTipo_cta" DisplayField="descripcion">
                                     <Store>
                                        <ext:Store ID="stTipoCuenta" runat="server">
                                           <Fields>
                                              <ext:ModelField Name="IdTipo_cta" Type="Int"  />
                                              <ext:ModelField Name="descripcion" Type="String"/>
                                           </Fields>
                                        </ext:Store>
                                     </Store>
                                   </ext:ComboBox>
                                </Editor>
                            </ext:Column>

                          


                            <ext:CommandColumn ID="CommandColumn1" runat="server" Width="180" Text="Tareas" Align="Center">
                                <Commands>
                                       <ext:GridCommand Icon="Delete" CommandName="Eliminar" Text="Borrar" ToolTip-Text="Borrar" />
                                </Commands>
                                <Listeners>
                                      <Command Handler="fCrearVentanaCuentas(command,record);" />
                                </Listeners>
                            </ext:CommandColumn>

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
