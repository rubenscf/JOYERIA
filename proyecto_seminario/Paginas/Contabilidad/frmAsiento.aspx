<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmAsiento.aspx.vb" Inherits="proyecto_seminario.frmAsiento" %>

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
               
        <ext:Panel runat="server" Flex="1" Height="210" Layout="BorderLayout">
            <Items>
                <ext:Container runat="server">
                    
                    <Items>                    
                         <ext:FormPanel ID="FormPanel1" runat="server" Height="120" Width="1100"  Region="Center" Title="Ingrese un Asiento Contable" BodyStyle="background-color: #DFE8F6" BodyPadding="10" MarginSpec="5 5 5 0">                   
                             <Items>
                                 <ext:FieldContainer runat="server" Layout="HBoxLayout">
                                     <Items>

                               <ext:ComboBox FieldLabel="Año" LabelAlign="Right"  ID="ComboAnio" LabelWidth="50" runat="server" DisplayField="CODIGO" ValueField="CODIGO" Width="150" >
                                    <Store>
                                      <ext:Store ID="stAnio" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="Int" />
                                              <ext:ModelField Name="CODIGO"  Type="Int"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>      
                                 </ext:ComboBox>


                              <ext:ComboBox FieldLabel="Mes" LabelAlign="Right"  LabelWidth="40"  ID="ComboMes" runat="server" DisplayField="NOMBRE" ValueField="CODIGO" Width="200" >
                                    <Store>
                                      <ext:Store ID="stMes" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="String" />
                                              <ext:ModelField Name="NOMBRE"  Type="String"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>      
                                 </ext:ComboBox>


                                         <ext:DateField ID="fechaInicio" Width="180" runat="server" LabelAlign="Right" LabelWidth="55"  Vtype="daterange" AllowBlank="false" FieldLabel=" Fecha" EmptyText="Seleccione" Editable="false" Icon="Date" >
                                              <CustomConfig>
                                                   <ext:ConfigItem Name="endDateField" Value="fechaInicio" Mode="Value"  />
                                              </CustomConfig>
                                           </ext:DateField>


                                 <ext:ComboBox FieldLabel="Comprobante" LabelAlign="Right"  LabelWidth="80"  ID="ComboComprobante" runat="server" DisplayField="NOMBRE" ValueField="CODIGO" Width="300" >
                                    <Store>
                                      <ext:Store ID="stComprobante" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="String" />
                                              <ext:ModelField Name="NOMBRE"  Type="String"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>      
                                 </ext:ComboBox>



                                <ext:TextField ID="txtDocumento" runat="server" FieldLabel="Documento" LabelAlign="Right" Align="Center" LabelWidth="85" Width="230"/>
                                         

                                     </Items>

                                 </ext:FieldContainer>
                                        
                                  
                        
                    </Items>
                             <Items>
                                 <ext:FieldContainer runat="server" Layout="HBoxLayout">
                                     <Items>

                                          <ext:ComboBox FieldLabel="Cuenta" LabelWidth="50"  ID="ComboCuenta" runat="server" DisplayField="NOMBRE" ValueField="CODIGO" Width="350" >
                                    <Store>
                                      <ext:Store ID="stCuenta" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="String" />
                                              <ext:ModelField Name="NOMBRE"  Type="String"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>      
                                 </ext:ComboBox>


                                         <ext:TextField ID="txtDebe" runat="server" FieldLabel="Debe" LabelAlign="Right" Text="0.00" LabelWidth="55" Width="180">
                                            
                                         </ext:TextField>

                                         <ext:TextField ID="txtHaber" runat="server" FieldLabel="Haber" LabelAlign="Right" Text="0.00" LabelWidth="80" Width="205" />

                                         <ext:Button ID="btnAgregar" Text="Agregar" runat="server" Icon="Add" Width="95">
                                             <Listeners>
                                             
                                                  <Click Handler="App.direct.fGuardar();" />

                                                 
                                             </Listeners>
                                         </ext:Button> 

                                         <ext:TextField ID="txtMonto" runat="server" FieldLabel="Total Monto" LabelAlign="Right" LabelWidth="85" Width="230"/>

                                     </Items>                                  
                                 </ext:FieldContainer>
                             </Items>
                           
                </ext:FormPanel>

                    </Items>






                    






                       <Items>                    
                         <ext:FormPanel ID="FormPanel2" runat="server" Height="50" Width="1100"  Region="Center"  BodyStyle="background-color: #DFE8F6" BodyPadding="10" MarginSpec="5 5 5 0">                                               
                             
                             <Items>
                                 <ext:FieldContainer runat="server" Layout="HBoxLayout">
                                     <Items>
                                         <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="100" AutoLoadingState="true">
                                     <Listeners>
                                        <Click Handler="App.direct.fGuardar2();" />
                                     </Listeners>                              
                                     </ext:Button>

                                         <ext:TextField ID="txtConcepto" runat="server"  FieldLabel="Concepto" LabelAlign="Right" LabelWidth="70" Width="450"/>

                                         <ext:TextField ID="txtTotalDebe" runat="server" Editable="false" Enabled="false" FieldLabel="Totales" LabelAlign="Right" LabelWidth="250" Width="400"/>

                                         <ext:TextField ID="txtTotalHaber" Editable="false" runat="server" Enabled="false" LabelAlign="Right" LabelWidth="70" Width="210"/>
                                     


                                     </Items>                                  
                                 </ext:FieldContainer>
                             </Items>

                           
                </ext:FormPanel>

                    </Items>




                </ext:Container>
            

            </Items>




            
      
        </ext:Panel> 
<Items>
                        <ext:GridPanel ID="GridPanel1" runat="server" Flex="1" Height="270" Scroll="Both" AutoScroll="true" Region="West"   MarginSpec="5 5 5 5">


                            <Store>
                                      <ext:Store ID="stTemporal" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="String" />
                                              <ext:ModelField Name="NOMBRE"  Type="String"/>
                                                 <ext:ModelField Name="DEBE" Type="Float" />
                                              <ext:ModelField Name="HABER"  Type="Float"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>

                             <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" DisplayInfo="true" DisplayMsg="Mostrando {0} - {1} of {2}"
                            EmptyMsg="No hay datos que mostrar" />
                    </BottomBar>

                             <ColumnModel>
                               <Columns>
                               <ext:Column runat="server" ID="ColumnCodigo" Text="CODIGO" Width="135" Align="Center" DataIndex="CODIGO">
                              
                                    </ext:Column>

                               <ext:Column runat="server" ID="ColumnNombre" Text="NOMBRE CUENTA" Flex="1" Align="Center" DataIndex="NOMBRE"/>

                               <ext:Column runat="server" ID="ColumnDebe" Text="DEBE" Width="140" Align="Right" DataIndex="DEBE">                     
                               </ext:Column>

                               <ext:Column runat="server" ID="ColumnHaber" Text="HABER" Width="140" Align="Right" DataIndex="HABER">
                                  
                               </ext:Column>


                            
                        </Columns>
                    </ColumnModel>

                       
                        </ext:GridPanel>


                    </Items>

    </form>




</body>
</html>
