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
                        <ext:TextField runat="server" ID="txtCodigo" FieldLabel="Nombre:" Flex="1" AllowBlank="false" Width="350" />
                      
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
