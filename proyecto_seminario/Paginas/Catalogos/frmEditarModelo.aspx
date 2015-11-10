<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarModelo.aspx.vb" Inherits="proyecto_seminario.frmEditarModelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript" src="Scripts/jsCatalogoModelo.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager runat="server" />
        <ext:FormPanel ID="frmeditarmodelo" runat="server">
            <FieldDefaults AllowBlank="false" />
            <Items>
                <ext:FieldContainer runat="server" Layout="HBoxLayout">
                    <Items>
                        <ext:ComboBox runat="server" ID="cmbProveedor" MarginSpec="5 5 5 5" FieldLabel="Seleccione un proveedor" DisplayField="emp_nombre" ValueField="idproveedor" LabelAlign="Top" Editable="false" Flex="1">
                            <Store>
                                <ext:Store ID="stProveedores" runat="server">
                                    <Model>
                                        <ext:Model ID="mdProveedores" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="idproveedor" />
                                                <ext:ModelField Name="emp_nombre" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>
                        <ext:ComboBox runat="server" ID="cmbFamila" MarginSpec="5 5 5 5" FieldLabel="Seleccione un proveedor" DisplayField="nombre" ValueField="idpr_familia" LabelAlign="Top" Editable="false" Flex="1">
                            <Store>
                                <ext:Store ID="stFamilia" runat="server">
                                    <Model>
                                        <ext:Model ID="Model1" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="idpr_familia" />
                                                <ext:ModelField Name="nombre" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>
                        <ext:ComboBox runat="server" ID="cmbMaterial" MarginSpec="5 5 5 5" FieldLabel="Seleccione un Material" DisplayField="nombre" ValueField="idmaterial" LabelAlign="Top" Editable="false" Flex="1">
                            <Store>
                                <ext:Store ID="stMaterial" runat="server">
                                    <Model>
                                        <ext:Model ID="Model2" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="idmaterial" />
                                                <ext:ModelField Name="nombre" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>
                    </Items>
                </ext:FieldContainer>
                <ext:FieldContainer runat="server" Layout="HBoxLayout">
                    <Items>
                        <ext:TextField MaxLength="100" FieldLabel="Codigo" LabelAlign="Top" runat="server" ID="txtCodigo" AllowBlank="false" MarginSpec="5 5 5 5" Width="100" />
                        <ext:TextField MaxLength="200" FieldLabel="Descripcion del Producto" LabelAlign="Top" runat="server" ID="txtModelo" AllowBlank="false" MarginSpec="5 5 5 5" Flex="1" />
                        <ext:NumberField FieldLabel="Precio Compra" LabelAlign="Top" runat="server" ID="txtPrecioC" DecimalSeparator="." AllowDecimals="true" DecimalPrecision="2" AllowBlank="false" MarginSpec="5 5 5 5" Width="100" />
                        <ext:NumberField FieldLabel="Precio Venta" LabelAlign="Top" runat="server" ID="txtPrecioV" DecimalSeparator="." AllowDecimals="true" DecimalPrecision="2" AllowBlank="false" MarginSpec="5 5 5 5" Width="100" />

                    </Items>
                </ext:FieldContainer>
            </Items>
            <Buttons>
                <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaModelo();" />
                            </Listeners>
                        </ext:Button>
            </Buttons>
        </ext:FormPanel>
    </form>
</body>
</html>
