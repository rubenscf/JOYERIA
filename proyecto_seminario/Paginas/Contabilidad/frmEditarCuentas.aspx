<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarCuentas.aspx.vb" Inherits="proyecto_seminario.frmEditarCuentas" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="Scripts/jsCatalogoCuentas.js">    </script>
</head>
<body>
    <form id="form1" runat="server">
   




        
        <ext:ResourceManager ID="rmECuenta" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Frame="false" BodyPadding="8">
                    <FieldDefaults LabelAlign="Right" LabelWidth="90" MsgTarget="Qtip" />
                    <Items>
                        

                        <ext:FieldSet runat="server" Title="Seleccione Tipo de Cuenta" Collapsible="true" >  
                                <Items>
                                   <ext:ComboBox ID="cboTipo_cta" runat="server"  Visible="true" AllowBlank="false" FieldLabel="Tipo" EmptyText="Seleccione" Width="315" ValueField="IdTipo_cta" DisplayField="descripcion">
                                     <Store>
                                        <ext:Store ID="stTipoCuenta" runat="server">
                                           <Fields>
                                              <ext:ModelField Name="IdTipo_cta" Type="Int"  />
                                              <ext:ModelField Name="descripcion" Type="String"/>
                                           </Fields>
                                        </ext:Store>
                                     </Store>
                                   </ext:ComboBox>
                                 </Items>

                            <Items>
                                 <ext:Container runat="server" Layout="HBoxLayout" MarginSpec="0 0 5 0">
                                    <Items>
                                       <ext:NumberField ID="txtNivel" EmptyText="Nivel" runat="server" FieldLabel="Nivel" MinValue="1" MaxValue="5" Width="165" AllowBlank="false">
                                       </ext:NumberField>
                                           <ext:ComboBox ID="cboSumariza_cta" runat="server" Editable="false" Visible="true" AllowBlank="false" FieldLabel="Sumariza" EmptyText="NO" Width="150">                    
                                              <Items>
                                                <ext:ListItem Text="NO"  />
                                                <ext:ListItem Text="SI" />
                                              </Items>
                                           </ext:ComboBox>
                                    </Items>
                                 </ext:Container>
                            </Items>

                            <Items>
                                <ext:Container runat="server">
                                    <Items>
                                        <ext:RadioGroup runat="server" FieldLabel="Mayoriza">
                                            <Items>
                                               <ext:Radio ID="rdNinguno" runat="server" InputValue="0" Checked="true" BoxLabel="Ninguno"/>                                                                
                                               <ext:Radio ID="rdCuenta" runat="server" InputValue="1" BoxLabel="Cuenta"/>
                                            </Items>                
                                        </ext:RadioGroup>
                                    </Items>
                                </ext:Container>
                            </Items>

                            <Items>
                               <ext:ComboBox FieldLabel="Seleccione" ID="cboMayoriza" runat="server" EmptyText="Nombre de Cuenta" DisplayField="NOMBRE" ValueField="CODIGO" Width="315" >
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
                            </Items>

                                       


                            <Items>                            
                                 <ext:Container runat="server" Layout="HBoxLayout" MarginSpec="0 0 5 0">
                                    <Items>
                                       <ext:ComboBox ID="cboMovimiento" runat="server" Editable="false" Visible="true" AllowBlank="false" FieldLabel="Movim." EmptyText="NO" Width="165">                    
                                              <Items>
                                                <ext:ListItem Text="NO"  />
                                                <ext:ListItem Text="SI" />
                                              </Items>
                                           </ext:ComboBox>

                                           <ext:ComboBox ID="cboAjusta" runat="server" Editable="false" Visible="true" AllowBlank="false" FieldLabel="Ajust." EmptyText="NO" Width="150">                    
                                              <Items>
                                                <ext:ListItem Text="NO"  />
                                                <ext:ListItem Text="SI" />
                                              </Items>
                                           </ext:ComboBox>
                                    </Items>
                                 </ext:Container>
                            </Items>


                            <Items>                                                                 
                                     <ext:TextField runat="server" FieldLabel="Código" ID="txtCodigoCuenta" Width="200" AllowBlank="false" EmptyText="111"  MaxLength="15" >
                                     </ext:TextField>                                                          
                            </Items>
                                <Items>
                                      <ext:TextField ID="txtNombreCuenta" runat="server" FieldLabel="Nombre" LabelWidth="100" AllowBlank="false" Width="315" EmptyText="CAJA" Regex="[A-Z]" MaxLength="150">                                      
                                     </ext:TextField>
                                   </Items>                                                                         
                            </ext:FieldSet>               

                   
                        
                         </Items>
                             <Buttons>
                                <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                                     <Listeners>
                                        <Click Handler="fGuardar();" />
                                     </Listeners>
                               </ext:Button>
                                 <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                                     <Listeners>
                                        <Click Handler="fCerrarVentanaCuentas();" />
                                     </Listeners>
                                 </ext:Button>
                             </Buttons>

                </ext:FormPanel>
            </Items>
        </ext:Panel>








    </form>
</body>
</html>
