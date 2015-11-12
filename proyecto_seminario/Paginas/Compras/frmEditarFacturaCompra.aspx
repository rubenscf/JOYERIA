<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarFacturaCompra.aspx.vb" Inherits="proyecto_seminario.frmEditarFacturaCompra" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rmEFacturaCompra" runat="server" />
        <ext:Panel ID="Pane12" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Frame="false" BodyPadding="8">
                    <FieldDefaults LabelAlign="Right" LabelWidth="120" MsgTarget="Qtip" />
                     <Items>
                        <ext:TextField runat="server" ID="txtidproveedor" Flex="1" Visible="false" />
                        <ext:TextField runat="server" ID="txtidprfactcompra" FieldLabel="Factura :" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtfecha" FieldLabel="Fecha:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtidempleado" FieldLabel="Empleado:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txttotal" FieldLabel="Total:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtdocumento" FieldLabel="No.Documento:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtestado" FieldLabel="estado:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtobservaciones" FieldLabel="observaciones:" Flex="1" Width="330" />

                    </Items>
                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaInsertarFacturaCompra();" />
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:FormPanel>
            </Items>
        </ext:Panel>
    </form>
</body>
</html>
