<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmVentaContado.aspx.vb" Inherits="proyecto_seminario.frm_VentaContado" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        var insertar = function () {
            App.direct.fInsertar(
                 {
                     success: function (result) {
                         llenarGrid();
                     }
                 });
        },
        eliminar = function (modelo) {
            App.direct.fEliminar(modelo,
                {
                    success: function (result) {
                        llenarGrid();
                    }
                });
        };
        guardar = function () {
            App.direct.fGuardar(
                {
                    success: function (result) {
                        if (result = 1)
                            llenarGrid();
                        else alert('Error');
                    }
                });
        };
        llenarGrid = function () {
            App.direct.fllenarGrid();
        };
        var change = function (value) {
            return Ext.String.format(template, (value > 0) ? "green" : "red", value);
        };
    </script>
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
                                
                                <ext:TextField runat="server" ID="txtSerie" FieldLabel="Factura serie" LabelAlign="Top" LabelStyle="font-size:20px" FieldStyle="font-size:20px" ReadOnly="true" />
                            </Items>
                        </ext:Container>
                        <ext:Container runat="server">
                            <Items>
                                
                                <ext:NumberField runat="server" ID="txtTotal" DecimalPrecision="2" DecimalSeparator="." FieldLabel="Total Venta (Q)" LabelAlign="Top" LabelStyle="font-size:20px" FieldStyle="font-size:20px" ReadOnly="true" />
                            </Items>
                        </ext:Container>
                      

                    </Items>

                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Width="120" Text="Guardar" Disabled="true" FormBind="true" Icon="Disk" StandOut="true">
                            <Listeners>
                                <Click Handler="guardar();" />
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
                                                <ext:ModelField Name="CANTIDAD" Type="Int" />
                                                <ext:ModelField Name="PROVEEDOR" Type="String" />
                                                <ext:ModelField Name="FAMILIA" Type="STRING" />
                                                <ext:ModelField Name="MATERIAL" Type="String" />
                                                <ext:ModelField Name="PRODUCTO" Type="String" />
                                                <ext:ModelField Name="PRECIO" />
                                 
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
                                        <ext:TextField runat="server" ID="txtModelo" EmptyText="Buscar Modelo" MaxLengthText="100" Width="100" />
                                        <ext:TextField runat="server" ID="txtFamilia" EmptyText="Buscar Familia" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtMaterial" EmptyText="Buscar Material" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtProducto" EmptyText="Buscar Producto" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtPrecio" EmptyText="Precio Venta" MaxLengthText="100"  />
                                        <ext:ToolbarSeparator />

                                        <ext:Button ID="btnBuscar1" runat="server" ToolTip="Buscar" Icon="Zoom">
                                            <Listeners>
                                                <Click Handler="App.direct.BuscarInventario(App.txtModelo.value, App.txtFamilia.value, App.txtMaterial.value, App.txtProducto.value)"></Click>
                                            </Listeners>
                                        </ext:Button>

                                        <ext:NumberField runat="server" ID="txtCant" MinValue="1" Width="50" />
                                        <ext:Button runat="server" ID="btnAgregar" Icon="Add" ToolTip="Producto">
                                            <Listeners>
                                                <Click Handler="insertar();" />

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
                                    <ext:Column runat="server" ID="Column2" Text="CANTIDAD" Width="100" Alig="Right" DataIndex="CANTIDAD" />
                                    <ext:Column runat="server" ID="Column1" Text="MODELO" Flex="1" Align="Left" DataIndex="IDPR_MODELO" />
                                    <ext:Column runat="server" ID="Column3" Text="FAMILIA" Flex="1" Align="Center" DataIndex="FAMILIA" />
                                    <ext:Column runat="server" ID="Column4" Text="MATERIAL" Flex="1" Align="Center" DataIndex="MATERIAL" />
                                    <ext:Column runat="server" ID="Column5" Text="PRECIO (Q)" Flex="1" Align="Center" DataIndex="PRECIO"   >
                                        <Renderer Format="UsMoney"></Renderer>
                                    </ext:Column>
                                    <ext:Column runat="server" ID="Column7" Text="SUB TOTAL" Flex="1" Align="Center" DataIndex="SUBTOTAL"  >
                                        <Renderer Format="UsMoney"></Renderer>
                                    </ext:Column>
                                    <ext:CommandColumn ID="CommandColumn4" runat="server" Flex="1" Text="Tareas" Align="Center">
                                        <Commands>
                                            <ext:GridCommand Icon="Delete" CommandName="editarProveedor" ToolTip-Text="Eliminar" />
                                        </Commands>
                                        <Listeners>
                                            <Command Handler="eliminar(record.data.IDPR_MODELO);" />
                                        </Listeners>
                                    </ext:CommandColumn>
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
