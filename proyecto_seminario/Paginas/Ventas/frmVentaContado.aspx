﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmVentaContado.aspx.vb" Inherits="proyecto_seminario.frm_VentaContado" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="Script/jsVentaContado.js">  </script>
    <style>
        .red-text div {
            color: red;
        }

        .font-size div {
            font-size: 14px;
        }

        .blue-text div {
            color: green;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rmVentaContado" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Layout="HBoxLayout" Flex="1">
                    <FieldDefaults LabelWidth="120" />
                    <Items>
                        <ext:Container runat="server">
                            <Items>
                                <ext:TextField runat="server" ID="txtNit" Flex="1" FieldLabel="Escriba NIT:" Visible="true" AllowBlank="false" LabelStyle="font-size:18px" />
                                <ext:TextField runat="server" ID="txtNombre" FieldLabel="A nombre de:" Flex="1" AllowBlank="false" LabelStyle="font-size:18px" />
                                <ext:TextField runat="server" ID="txtDireccion" FieldLabel="Direccion:" Flex="1" AllowBlank="false" LabelStyle="font-size:18px" />
                            </Items>
                        </ext:Container>
                        <ext:Container runat="server">
                            <Items>
                                <ext:NumberField runat="server" ID="txtTotal" DecimalPrecision="2" DecimalSeparator="." FieldLabel="Total" LabelAlign="Top" LabelStyle="font-size:20px" FieldStyle="font-size:20px" ReadOnly="true" />
                            </Items>
                        </ext:Container>

                    </Items>

                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Width="120" Text="Guardar" Disabled="true" FormBind="true" Icon="Disk" StandOut="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCacelar" runat="server" Width="120" Text="Cancelar" Icon="Cancel">
                            <Listeners>
                                <Click Handler="ConvertMayusculas()"></Click>
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:FormPanel>
                <ext:FormPanel ID="FormPanel1" runat="server" Frame="false" BodyPadding="10">
                    <FieldDefaults LabelAlign="Right" LabelWidth="120" MsgTarget="Qtip" />
                    <Items>
                        <ext:GridPanel ID="dg" runat="server" Flex="1" Height="350" Scroll="Both" AutoScroll="true" StripeRows="true" Resizable="true">
                            <Store>
                                <ext:Store runat="server" ID="stDG">
                                    <Model>
                                        <ext:Model runat="server" ID="mgParametro">
                                            <Fields>
                                                <ext:ModelField Name="IDPR_MODELO" />
                                                <ext:ModelField Name="CANT" Type="Int" />
                                                <ext:ModelField Name="PROVEEDOR" Type="String" />
                                                <ext:ModelField Name="FAMILIA" Type="STRING" />
                                                <ext:ModelField Name="MATERIAL" Type="String" />
                                                <ext:ModelField Name="PRODUCTO" Type="String" />
                                                <ext:ModelField Name="P_COMPRA" />
                                                <ext:ModelField Name="P_VENTA" />
                                                <ext:ModelField Name="SUBTOTAL" />

                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                            <TopBar>
                                <ext:Toolbar ID="Toolbar5" runat="server">
                                    <Items>
                                        <ext:Button runat="server" ID="btnX" ToolTip="Quitar Prdoducto" Icon="Cross">
                                            <Listeners>
                                                <Click Handler="App.direct.fQuitar();"></Click>
                                            </Listeners>

                                        </ext:Button>
                                        <ext:TextField runat="server" ID="txtModelo" EmptyText="Buscar Modelo" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtFamilia" EmptyText="Buscar Familia" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtMaterial" EmptyText="Buscar Material" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtProducto" EmptyText="Buscar Producto" MaxLengthText="100" />
                                        <ext:ToolbarSeparator />

                                        <ext:Button ID="btnBuscar1" runat="server" ToolTip="Buscar" Icon="Zoom">
                                            <Listeners>
                                                <Click Handler="App.direct.BuscarInventario(App.txtModelo.value, App.txtFamilia.value, App.txtMaterial.value, App.txtProducto.value)"></Click>
                                            </Listeners>
                                        </ext:Button>
                                      
                                        <ext:NumberField runat="server" ID="txtCant" MinValue="1" Width="50" />
                                        <ext:Button runat="server" ID="btnAgregar" Icon="Add" ToolTip="Producto">
                                            <Listeners>
                                                <Click Handler="App.direct.fAgregar()" />
                                                    
                                            </Listeners>
                                        </ext:Button>
                                    </Items>
                                </ext:Toolbar>
                            </TopBar>
                            <BottomBar>
                                <ext:PagingToolbar ID="PagingToolbar1" runat="server" DisplayInfo="true" DisplayMsg="Mostrando {0} - {1} of {2}" EmptyMsg="No hay datos que mostrar" />
                            </BottomBar>
                            <ColumnModel>
                                <Columns>
                                    <ext:Column runat="server" ID="Column2" Text="CANTIDAD" Width="100" Alig="Right" DataIndex="CANT" />
                                    <ext:Column runat="server" ID="Column1" Text="MODELO" Flex="1" Align="Left" DataIndex="IDPR_MODELO" />
                                    <ext:Column runat="server" ID="Column3" Text="FAMILIA" Flex="1" Align="Center" DataIndex="FAMILIA" />
                                    <ext:Column runat="server" ID="Column4" Text="MATERIAL" Flex="1" Align="Center" DataIndex="MATERIAL" />
                                    <ext:Column runat="server" ID="Column5" Text="PRODUCTO" Flex="1" Align="Center" DataIndex="PRODUCTO" />
                                    <ext:Column runat="server" ID="Column7" Text="SUB TOTAL" Flex="1" Align="Center" DataIndex="SUBTOTAL" />

                                </Columns>
                            </ColumnModel>
                        </ext:GridPanel>
                    </Items>
                </ext:FormPanel>
            </Items>
        </ext:Panel>
    </form>
</body>
</html>
