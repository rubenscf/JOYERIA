<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPeriodoContable.aspx.vb" Inherits="proyecto_seminario.frmPeriodoContable" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
<title></title>

    <script>


        var fEditar = function (editor, e) {
            if (!(e.value === e.originalValue)) {
                App.direct.fModificarPeriodo(e.record.data.ANIO, e.record.data.IDMES, e.record.data.DESDE, e.record.data.HASTA, e.record.data.INICIO, e.record.data.FIN,
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
    


      <form runat="server">
        <ext:ResourceManager runat="server" />
               
        <ext:Panel runat="server" Flex="1" Height="490" Layout="BorderLayout">
            <Items>
                <ext:Container runat="server">
                    
                    <Items>                    
                         <ext:FormPanel ID="FormPanel1" runat="server" Height="90" Width="1100"  Region="Center" Title="Ingrese un Nuevo Período Contable" BodyStyle="background-color: #DFE8F6" BodyPadding="10" MarginSpec="5 5 5 0">                   
                             <Items>
                                 <ext:FieldContainer runat="server" Layout="HBoxLayout">
                                     <Items>

                                            <ext:NumberField ID="Aniotxt" FieldLabel="Año" LabelWidth="40" runat="server"  AutoDataBind="true" Width="135" Number="<%# DateTime.Now.Year %>"  MinValue="<%# DateTime.Now.Year %>"  AllowBlank="false" Icon="Date">
                                              <CustomConfig>
                                                      <ext:ConfigItem Name="numberanio" Value="Aniotxt" Mode="Value"  />
                                              </CustomConfig>
                                            </ext:NumberField>                 
                        
                                            <ext:DateField ID="fechaInicio" Width="170" runat="server" LabelWidth="40"  Vtype="daterange" AllowBlank="false" FieldLabel="Desde" EmptyText="Seleccione" Editable="false" Icon="Date" >
                                                <CustomConfig>
                                                              <ext:ConfigItem Name="endDateField" Value="fechaInicio" Mode="Value"  />
                                                </CustomConfig>
                                           </ext:DateField>

                                           <ext:DateField ID="fechaFinal" runat="server" Width="170" Vtype="daterange" LabelWidth="40"  AllowBlank="false" FieldLabel="Hasta" EmptyText="Seleccione" Editable="false" Icon="Date" >
                                                <CustomConfig>
                                                     <ext:ConfigItem Name="fechaFinal" Value="fechaFinal" Mode="Value" />
                                                </CustomConfig>
                                           </ext:DateField>

                                          <ext:Button ID="Button1"  runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110"  AutoLoadingState="true">
                                                    <Listeners>
                                                             <Click Handler="App.direct.fGuardar();" />
                                                    </Listeners>
                                           </ext:Button>
                      
                                     </Items>
                                     
                                      
                                      

                                 </ext:FieldContainer>
                                        
                                          
                        
                    </Items>
                          
                                      
                </ext:FormPanel>



                    </Items>



                    <Items>
                          <ext:FormPanel ID="FormPanel2" runat="server" Height="400" Width="1100"  Region="Center" Title="Información de Períodos Contables" BodyStyle="background-color: #DFE8F6" BodyPadding="10" MarginSpec="5 5 5 0">                   
                             <Items>
                         <ext:GridPanel ID="GridPanel1" runat="server" Region="West" Height="390" Flex="1"   MarginSpec="5 5 5 5">                
                    <Store>
                        <ext:Store ID="stPeriodoConta" runat="server">
                            <Model>
                                <ext:Model runat="server">
                                    <Fields>
                                        <ext:ModelField Name="ANIO" Type="Int" />
                                        <ext:ModelField Name="IDMES" Type="Int" />
                                        <ext:ModelField Name="INICIO" Type="Date"/>
                                        <ext:ModelField Name="FIN" Type="Date"  />
                                        <ext:ModelField Name="MES" Type="String" />
                                        <ext:ModelField Name="DESDE" Type="Date"/>
                                        <ext:ModelField Name="HASTA" Type="Date"  />
                                        
                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                    <ColumnModel>
                        <Columns>

                             <ext:Column runat="server" ID="ColumnAnio" Text="Año" Width="100" Align="Center" DataIndex="ANIO"/>
                            <ext:Column runat="server" ID="Column1" Text="ID MES" Visible="false" Width="100" Align="Center" DataIndex="IDMES"/>

                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Inicio"  Align="Center" DataIndex="INICIO">
                                <Editor>
                                    <ext:DateField runat="server" />
                                </Editor>
                            </ext:DateColumn>

                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Fin"  Align="Center" DataIndex="FIN">
                                <Editor>
                                    <ext:DateField runat="server" />
                                </Editor>
                            </ext:DateColumn>
                             
                            <ext:Column runat="server" ID="mes" Text="Mes" flex="1" Align="Center" DataIndex="MES"/>
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Desde"  Align="Center" DataIndex="DESDE">
                                <Editor>
                                    <ext:DateField runat="server"/>
                                </Editor>
                            </ext:DateColumn>
                            <ext:DateColumn ID="txtfechaInicio" runat="server" Format="dd/MM/yyyy"   Text="Hasta"  Align="Center" DataIndex="HASTA">
                                <CustomConfig>
                                   <ext:ConfigItem Name="endDateField" Value="txtfechaInicio" Mode="Value"  />
                                 </CustomConfig>
                                <Editor>
                                      <ext:DateField runat="server" />
                                </Editor>
                                  
                            </ext:DateColumn>
                           

                                <ext:CommandColumn ID="CommandColumn1" runat="server" Width="75" Text="Tareas" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="PageWhiteEdit" CommandName="Cerrar"  ToolTip-Text="Abrir Periodo" />
                                </Commands>
                                    <Commands>
                                    <ext:GridCommand Icon="Delete" CommandName="Cerrar"   ToolTip-Text="Cerrar Periodo" />
                                </Commands>
                                <Listeners>
                                      <Command Handler="fModificarEstado(command,record);" />
                                </Listeners>
                                </ext:CommandColumn>

                            
                        </Columns>
                    </ColumnModel>

                     <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" DisplayInfo="true" DisplayMsg="Mostrando {0} - {1} of {2}"
                            EmptyMsg="No hay datos que mostrar" />
                    </BottomBar>

                                    
                    
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
                       </ext:FormPanel>
                    </Items>




                </ext:Container>
            

            </Items>




            
      
        </ext:Panel> 
      
    </form>



</body>
</html>
