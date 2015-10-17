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
                                   <ext:ComboBox ID="cboTipo_cta" runat="server"  Visible="true" AllowBlank="false" FieldLabel="Tipo" EmptyText="Seleccione" Width="250" ValueField="IdTipo_cta" DisplayField="descripcion">
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
                                   <ext:ComboBox ID="cboNivel_cta" runat="server" Editable="false" Visible="true" AllowBlank="false" FieldLabel="Nivel" EmptyText="Seleccione" Width="250" DefaultAlign="default">
                                                                      
                                      <Items>
                                          <ext:ListItem Text="01" Value="1" />
                                          <ext:ListItem Text="02" Value="2" />
                                          <ext:ListItem Text="03" Value="3" />
                                          <ext:ListItem Text="04" Value="4" />
                                          <ext:ListItem Text="05" Value="5" />
                                      </Items>
                         </ext:ComboBox>

                            </Items>


                                             <Items>
                                                  <ext:ComboBox ID="cboSumariza_cta" runat="server" Editable="false" Visible="true" AllowBlank="false" FieldLabel="Sumariza" EmptyText="Seleccione" Width="250">                    
                                                     <Items>
                                                       <ext:ListItem Text="NO"  />
                                                       <ext:ListItem Text="SI" />
                                                     </Items>
                                                  </ext:ComboBox>
                                              </Items>

                                 </ext:FieldSet>
                    
                        
                        
                        <ext:TextField runat="server" ID="txtCodigo_cta" FieldLabel="Codigo:"  AllowBlank="false" Width="250" EmptyText="111" RegexText="0-9" />
                        <ext:TextField runat="server" ID="txtNombre_cta" FieldLabel="Nombre:" AllowBlank="false" Width="300"  EmptyText="CAJA"/>
                       
                                         

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
