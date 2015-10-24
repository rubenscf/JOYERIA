<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPeriodoContable.aspx.vb" Inherits="proyecto_seminario.frmPeriodoContable" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
               
        <ext:Panel runat="server" Flex="1" Height="500" Layout="BorderLayout">
            <Items>
                <ext:GridPanel ID="GridPanel1" runat="server" Region="West" Width="875" Title="Información de los Períodos Activos"   MarginSpec="5 5 5 5">                
                    <Store>
                        <ext:Store ID="stPeriodoConta" runat="server">
                            <Model>
                                <ext:Model runat="server">
                                    <Fields>
                                        <ext:ModelField Name="ANIO" Type="Int" />
                                        <ext:ModelField Name="INICIO" Type="Date"/>
                                        <ext:ModelField Name="FIN" Type="Date"  />
                                        <ext:ModelField Name="MES" Type="String" />
                                        <ext:ModelField Name="DESDE" Type="Date"/>
                                        <ext:ModelField Name="HASTA" Type="Date"  />
                                        <ext:ModelField Name="ESTADO_MES" Type="string" />
                                        <ext:ModelField Name="ESTADO_PERIODO" Type="string" />


                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                    <ColumnModel>
                        <Columns>

                             <ext:Column runat="server" ID="ColumnAnio" Text="Año" Width="100" Align="Center" DataIndex="ANIO"/>
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Inicio"  Align="Center" DataIndex="INICIO" />
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Fin"  Align="Center" DataIndex="FIN" />
                            <ext:Column runat="server" ID="mes" Text="Mes" Width="125" Align="Center" DataIndex="MES"/>
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Desde"  Align="Center" DataIndex="DESDE" />
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Hasta"  Align="Center" DataIndex="HASTA" />
                            <ext:Column runat="server" ID="EstadoMes" Text="Estado Mes" Width="125"  Align="Center" DataIndex="ESTADO_MES" />
                            <ext:Column runat="server" ID="EstadoPeriodo" Text="Estado Periodo" Width="125" Align="Center" DataIndex="ESTADO_PERIODO" />


                        </Columns>
                    </ColumnModel>
                    <SelectionModel>
                        <ext:RowSelectionModel runat="server" Mode="Single" />
                    </SelectionModel>  

                    <View>
                        <ext:GridView runat="server">
                            <Plugins>
                                <ext:GridDragDrop runat="server" EnableDrop="false" DDGroup="gridDDGroup" />
                            </Plugins>
                        </ext:GridView>
                    </View>                 
                </ext:GridPanel>
                <ext:FormPanel ID="FormPanel1" runat="server"  Region="Center" Title="Ingrese Nuevo Período" BodyStyle="background-color: #DFE8F6" BodyPadding="10" MarginSpec="5 5 5 0">
                   
                    
                     <Items>
                          <ext:NumberField ID="Aniotxt" FieldLabel="Año" LabelWidth="20" runat="server"  AutoDataBind="true" Width="135" Number="<%# DateTime.Now.Year %>"  MinValue="<%# DateTime.Now.Year %>"  AllowBlank="false" Icon="Date">
                       <CustomConfig>
                       <ext:ConfigItem Name="numberanio" Value="Aniotxt" Mode="Value"  />
                       </CustomConfig>
                       </ext:NumberField>

                       
                      
                        
                       <ext:DateField ID="fechaInicio" Width="135" runat="server" LabelWidth="15"  Vtype="daterange" AllowBlank="false" FieldLabel="Del" EmptyText="01/01/2015" Editable="false" Icon="Date" >
                       <CustomConfig>
                       <ext:ConfigItem Name="endDateField" Value="fechaInicio" Mode="Value"  />
                       </CustomConfig>
                       </ext:DateField>

                      <ext:DateField ID="fechaFinal" runat="server" Width="135" Vtype="daterange" LabelWidth="15"  AllowBlank="false" FieldLabel="Al" EmptyText="31/12/2015" Editable="false" Icon="Date" >
                       <CustomConfig>
                       <ext:ConfigItem Name="fechaFinal" Value="fechaFinal" Mode="Value" />
                       </CustomConfig>
                       </ext:DateField>

                    
                        
                    </Items>
                    

                    <Items>
                        <ext:FieldSet runat="server" Title="Detalle de Período Mensual" Collapsible="true">

                              <Items>
                                   <ext:ComboBox ID="cboMes" runat="server" LabelWidth="20"  Visible="true" AllowBlank="false" FieldLabel="Mes" EmptyText="Seleccione" Width="175" ValueField="IDMES" DisplayField="NOMBRE">
                                     <Store>
                                        <ext:Store ID="stMesPeriodo" runat="server">
                                           <Fields>
                                              <ext:ModelField Name="IDMES" Type="Int"  />
                                              <ext:ModelField Name="NOMBRE" Type="String"/>
                                           </Fields>
                                        </ext:Store>
                                     </Store>
                                   </ext:ComboBox>
                                 </Items>

                            <Items>

                                             <ext:DateField ID="txtFechaInicio" Width="140" runat="server" LabelWidth="20"  Vtype="daterange" AllowBlank="false" FieldLabel="Del" EmptyText="01/01/2015" Editable="false" Icon="Date" >
                                                  <CustomConfig>
                                                  <ext:ConfigItem Name="endDateField" Value="fechaInicio" Mode="Value"  />
                                                  </CustomConfig>
                                              </ext:DateField>

                                           <ext:DateField ID="txtFechaFin" runat="server" Width="140" Vtype="daterange" LabelWidth="20"  AllowBlank="false" FieldLabel="Al" EmptyText="31/12/2015" Editable="false" Icon="Date" >
                                                    <CustomConfig>
                                                     <ext:ConfigItem Name="fechaFinal" Value="fechaFinal" Mode="Value" />
                                                    </CustomConfig>
                                           </ext:DateField>


                              



                            </Items>

                           </ext:FieldSet>

                    </Items>
                       <Buttons>
                                <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                                     <Listeners>
                                        <Click Handler="fGuardar();" />
                                     </Listeners>
                               </ext:Button>
                                 <ext:Button ID="btnCancelar" runat="server" Text="Agregar" Icon="Cancel" Width="110">
                                     <Listeners>
                                        <Click Handler="fModificar();" />
                                     </Listeners>
                                 </ext:Button>
                             </Buttons>

                </ext:FormPanel>
            </Items>
            
      
        </ext:Panel> 
      
    </form>
</body>
</html>
