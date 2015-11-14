<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarEmpleados.aspx.vb" Inherits="proyecto_seminario.frmEditarEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript" src="Scripts/jsEmpleados.js"></script>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rmEEmpleado" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Frame="false" BodyPadding="8">
                    <FieldDefaults LabelAlign="Right" LabelWidth="120" MsgTarget="Qtip" />
                    <Items>
                        <ext:TextField runat="server" ID="txtidempleado" Flex="1" Visible="false" />
                        <ext:TextField runat="server" ID="txtp_IDLUGAR" FieldLabel="IDLUGAR:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtp_IDLU_PUESTO" FieldLabel="PUESTO:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtp_DPI" FieldLabel="DPI:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_NOMBRE" FieldLabel="NOMBRE:" Flex="1" AllowBlank="false" Width="330" />
                        
                        <ext:TextField runat="server" ID="txtP_NOMBRE1" FieldLabel="SEGUNDO NOMBRE:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_APELLIDO" FieldLabel="APELLIDO:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_APELLIDO1" FieldLabel="SEGUNDO APELLIDO:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_EXTENDIDA" FieldLabel="EXTENDIDA:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_NIT" FieldLabel="NIT:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_SEXO" FieldLabel="SEXO:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_DIRECCION" FieldLabel="DIRECCION:" Flex="1" Width="330" />



                        <ext:TextField runat="server" ID="txtP_TELEFONO" FieldLabel="TELEFONO:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_CONYUGUE" FieldLabel="CONYUGUE:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_FECHANAC" FieldLabel="NACIMIENTO:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_ESTADO" FieldLabel="ESTADO:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_ESTADO_CIVIL" FieldLabel="ESTADO CIVIL:" Flex="1" Width="330" />

                        <ext:TextField runat="server" ID="txtP_NACIONALIDAD" FieldLabel="NACIONALIDAD:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_VECINDAD" FieldLabel="VECINDAD:" Flex="1" AllowBlank="false" Width="330" />
                        <ext:TextField runat="server" ID="txtP_SUELDO_BASE" FieldLabel="SUELDO BASE:" Flex="1" AllowBlank="false" Width="330" />
                        
       

                    </Items>
                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaEmpleado();" />
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:FormPanel>
            </Items>
        </ext:Panel>
    </form>
</body>
</html>
