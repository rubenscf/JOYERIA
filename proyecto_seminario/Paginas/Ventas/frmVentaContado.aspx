<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmVentaContado.aspx.vb" Inherits="proyecto_seminario.frm_VentaContado" %>

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
                                <ext:NumberField runat="server" ID="txtTotal" DecimalPrecision="2" DecimalSeparator="." FieldLabel="Total" LabelAlign="Top"  LabelStyle="font-size:20px" FieldStyle="font-size:20px" />
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
                        <ext:GridPanel ID="GridParametro" runat="server" Flex="1" Height="350" Scroll="Both" AutoScroll="true" StripeRows="true" Resizable="true">
                            <Store>
                                <ext:Store runat="server" ID="stParametro">
                                    <Model>
                                        <ext:Model runat="server" ID="mgParametro">
                                            <Fields>
                                                <ext:ModelField Name="codigo" />
                                                <ext:ModelField Name="cantidad" Type="Int" />
                                                <ext:ModelField Name="detalle" Type="String" />
                                                <ext:ModelField Name="preciou" Type="Float" />
                                                <ext:ModelField Name="subtotal" Type="Float" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                            <TopBar>
                                <ext:Toolbar ID="Toolbar5" runat="server">
                                    <Items>
                                        <ext:TextField runat="server" ID="txtBuscar1" EmptyText="Escriba descripcion de  Joya" Width="400" Regex="[A-Z]" MaxLengthText="100" FieldLabel="Descripción" LabelAlign="Top"/>
                                        <ext:ToolbarSeparator />
                                        <ext:Button ID="btnBuscar1" runat="server" Width="120" Text="Buscar" Icon="Zoom">
                                            <Listeners>
                                                <Click Handler="fMostrarListaArticulo()"></Click>
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
                                    <ext:Column runat="server" ID="Column1" Text="CODIGO" Width="125" Align="Left" DataIndex="codigo" />
                                    <ext:Column runat="server" ID="Column2" Text="CANTIDAD" widtch="125" Alig="Right" DataIndex="cantidad">
                                    </ext:Column>
                                    <ext:Column runat="server" ID="Column3" Text="DESCRIPCION" Width="600" Align="Center" DataIndex="detalle">
                                    </ext:Column>
                                    <ext:Column runat="server" ID="Column4" Text="PRECIO UNIT" Width="125" Align="Center" DataIndex="preciou">
                                    </ext:Column>
                                    <ext:Column runat="server" ID="Column5" Text="SUB TOTAL" Width="125" Align="Center" DataIndex="subtotal">
                                    </ext:Column>
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
