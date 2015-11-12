 <%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarProveedor.aspx.vb" Inherits="proyecto_seminario.frmEditarProveedor" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript" src="Scripts/jsCatalogoProveedores.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rmEProveedor" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Frame="false" BodyPadding="8">
                    <FieldDefaults LabelAlign="Right" LabelWidth="120" MsgTarget="Qtip" />
                    <Items>
                        <ext:TextField runat="server" ID="txtidproveedor" Flex="1" Visible="false" />
                        <ext:TextField runat="server" ID="txtAgente" FieldLabel="Agente de ventas:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtEmpNombre" FieldLabel="Empresa:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtEmpDireccion" FieldLabel="Direccion:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtNit" FieldLabel="NIT:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtTelAgente" FieldLabel="Telefono Agente:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtTelEmp1" FieldLabel="Telefono Empresa:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtTelEmp2" FieldLabel="Otro telefono:" Flex="1" Width="330" />

                    </Items>
                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaProveedor();" />
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:FormPanel>
            </Items>
        </ext:Panel>
    </form>
</body>
</html>
