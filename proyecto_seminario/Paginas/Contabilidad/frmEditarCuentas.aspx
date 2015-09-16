<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarCuentas.aspx.vb" Inherits="proyecto_seminario.frmEditarCuentas" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   




        
        <ext:ResourceManager ID="rmECuenta" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Frame="false" BodyPadding="8">
                    <FieldDefaults LabelAlign="Right" LabelWidth="90" MsgTarget="Qtip" />
                    <Items>
                        

                        <ext:FieldSet runat="server" Title="Seleccione Grupo de Cuenta" Layout="AnchorLayout"  Collapsible="true" DefaultAnchor="100%">  

                             <Items>


                            <ext:RadioGroup ID="RadioGroup2" runat="server"  Cls="x-check-group-alt" >
                            <Items>
                                <ext:Radio ID="optCuenta" runat="server" BoxLabel="Cuenta"  Width="60">
                                    
                                    </ext:Radio>
                                <ext:Radio ID="optSubCuenta" runat="server" BoxLabel="Sub-Cuenta" Width="60" >

                                    </ext:Radio>
                                                                          
                               
                                
                                  
                            </Items>
                            </ext:RadioGroup> 
               
                                  <ext:ComboBox ID="cboCuentaGrupo" runat="server" Editable="false" Visible="true" EmptyText="Seleccione Cuenta" Width="75">
                                     
                                           
                                      <Items>
                                          
                                          <ext:ListItem Text="CAJA" Value="BE" />
                                          <ext:ListItem Text="BANCOS" Value="BR" />
                                          <ext:ListItem Text="PROVEEDORES" Value="BG" />
                                      </Items>
                               </ext:ComboBox>


                                 </Items>
                                 </ext:FieldSet>



                        <ext:FieldSet runat="server" Title="Seleccione Tipo Cuenta" Layout="AnchorLayout"  Collapsible="true" DefaultAnchor="100%">  

                             <Items>
                            <ext:RadioGroup ID="RadioGroup1" runat="server"  Cls="x-check-group-alt" >
                            <Items>
                                <ext:Radio ID="optActivo" runat="server" BoxLabel="Activo" Width="60"/>
                                <ext:Radio ID="optPasivo" runat="server" BoxLabel="Pasivo" Width="60" />
                                <ext:Radio ID="optCapital" runat="server" BoxLabel="Capital" Width="65"/>
                                <ext:Radio ID="optIngreso" runat="server" BoxLabel="Ingreso" Width="65"/>
                                <ext:Radio ID="optGasto" runat="server" BoxLabel="Egreso" Width="65"/>
                            </Items>
                        </ext:RadioGroup> 
                           


                                 </Items>
                               </ext:FieldSet>

                    
                      
                      
                        
                        <ext:TextField runat="server" ID="txtidCuenta" Flex="1" Visible="false" />
                        <ext:TextField runat="server" ID="txtCodCuenta" FieldLabel="Codigo:" Flex="1" AllowBlank="false" Width="350" />
                      
                        <ext:TextField runat="server" ID="txtCodigo" FieldLabel="Nombre:" Flex="1" AllowBlank="false" Width="350"  EmptyText="Ingrese el Nombre de la cuenta"/>
                      
                    </Items>
                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaCuenta();" />
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:FormPanel>
            </Items>
        </ext:Panel>








    </form>
</body>
</html>
