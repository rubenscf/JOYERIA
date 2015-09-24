<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarTipoCuenta.aspx.vb" Inherits="proyecto_seminario.frmEditarTipoCuenta" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script type="text/javascript" src="Scripts/jsTipoCuenta.js"> 

    </script>
</head>
<body>
    <form id="form1" runat="server">
    



          <ext:ResourceManager ID="rmETipoCuenta" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Frame="false" BodyPadding="8">
                    <FieldDefaults LabelAlign="Right" LabelWidth="90" MsgTarget="Qtip" />
                    <Items>
                                           
                    <ext:TextField runat="server" ID="txtDescripcion" FieldLabel="Descripción:" Flex="1" AllowBlank="false" Width="325"  EmptyText="Ingrese Nombre ej: ACTIVO " MaxLength="50"/>
                      
                    </Items>
                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaTipoCuenta();" />
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:FormPanel>
            </Items>
        </ext:Panel>




    </form>
</body>
</html>
