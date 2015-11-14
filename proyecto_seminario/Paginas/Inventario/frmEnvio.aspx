<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEnvio.aspx.vb" Inherits="proyecto_seminario.frmEnvio" %>

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
        }
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
        <ext:ResourceManager ID="rmEnvio" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout">
            <Items>
                <ext:FormPanel ID="FormPanel1" runat="server" Frame="false" BodyPadding="10">
                    <FieldDefaults LabelAlign="Right" LabelWidth="120" MsgTarget="Qtip" />
                    <Items>
                        <ext:Container runat="server" Layout="HBoxLayout">
                            <Items>
                                <ext:ToolbarFill></ext:ToolbarFill>
                                <ext:ComboBox runat="server" ID="cmbLugar" Width="400" FieldLabel="Destino" DisplayField="nombre" ValueField="idlugar" Editable="false" Flex="1">
                                    <Store>
                                        <ext:Store ID="stLugar" runat="server">
                                            <Model>
                                                <ext:Model ID="mdProveedores" runat="server">
                                                    <Fields>
                                                        <ext:ModelField Name="idlugar" />
                                                        <ext:ModelField Name="nombre" />
                                                    </Fields>
                                                </ext:Model>
                                            </Model>
                                        </ext:Store>
                                    </Store>
                                </ext:ComboBox>
                                <ext:Button ID="btnGuardar" runat="server" Width="120" MarginSpec="0 5 2 20" Text="Guardar" Disabled="true" FormBind="true" Icon="Disk" StandOut="true">
                                    <Listeners>
                                        <Click Handler="guardar();" />
                                    </Listeners>
                                </ext:Button>
                            </Items>
                        </ext:Container>

                        <ext:GridPanel ID="dg" runat="server" Flex="1" Height="440" Scroll="Both" AutoScroll="true" StripeRows="true" Resizable="true">
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
                                        <ext:TextField runat="server" ID="txtModelo" EmptyText="Buscar Modelo" MaxLengthText="100" Width="100" />
                                        <ext:TextField runat="server" ID="txtFamilia" EmptyText="Buscar Familia" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtMaterial" EmptyText="Buscar Material" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtProducto" EmptyText="Buscar Producto" MaxLengthText="100" />
                                        <ext:TextField runat="server" ID="txtPercio" EmptyText="Precio Venta" MaxLengthText="100" />
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
                                    <ext:Column runat="server" ID="Column5" Text="PRODUCTO" Flex="1" Align="Center" DataIndex="PRODUCTO" />
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
