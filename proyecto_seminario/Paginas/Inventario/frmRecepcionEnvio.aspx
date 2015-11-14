<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmRecepcionEnvio.aspx.vb" Inherits="proyecto_seminario.frmRecepcionEnvio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="rmgFases" runat="server" />
        <ext:Store ID="stTipoMenu" runat="server">
            <Model>
                <ext:Model ID="mdTipoMenu" runat="server">
                    <Fields>
                        <ext:ModelField Name="idtipo_menu" />
                        <ext:ModelField Name="nombre" />
                    </Fields>
                </ext:Model>
            </Model>
        </ext:Store>
        <ext:Viewport runat="server" Layout="HBoxLayout">

            <LayoutConfig>
                <ext:HBoxLayoutConfig Align="Stretch"></ext:HBoxLayoutConfig>
            </LayoutConfig>
            <Defaults>
                <ext:Parameter Name="Border" Value="false" />
                <ext:Parameter Name="Flex" Value="1" />
                <ext:Parameter Name="Layout" Value="anchor" />
            </Defaults>

            <Items>



                <ext:Panel runat="server" Layout="FitLayout" Border="true">
                    <Items>
                        <ext:GridPanel runat="server" ID="gpMenu" Title="Recepcion de envios" Scroll="Both" AutoScroll="true" StripeRows="true">
                            <Store>
                                <ext:Store ID="stMenu" runat="server" ItemID="id_menu">
                                    <Model>
                                        <ext:Model ID="mdCatalogoMenu" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="id_institucion" />
                                                <ext:ModelField Name="id_menu" />
                                                <ext:ModelField Name="id_tipo_menu" />
                                                <ext:ModelField Name="nombre" />
                                                <ext:ModelField Name="activo" Type="Boolean" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                           
                            <ColumnModel ID="ColumnModel1" runat="server">
                                <Columns>

                                    <ext:Column ID="Column1" runat="server" DataIndex="id_institucion" Visible="false" />
                                    <ext:Column ID="Column2" runat="server" Text="Codigo" DataIndex="id_menu" Flex="1" />
                                    <ext:Column ID="Column3" runat="server" Text="Tipo Menu" DataIndex="id_tipo_menu" Flex="1">
                                        <Editor>
                                            <ext:ComboBox ID="combo" runat="server" StoreID="stTipoMenu" QueryMode="Local" TriggerAction="All"
                                                ValueField="idtipo_menu" DisplayField="nombre" ForceSelection="True" />
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column ID="Column4" runat="server" Text="Menu" DataIndex="nombre" Flex="1">
                                        <Editor>
                                            <ext:TextField runat="server"></ext:TextField>
                                        </Editor>
                                    </ext:Column>
                                    <ext:BooleanColumn runat="server" ID="BooleanColumn1" Text="Activo" DataIndex="activo" Flex="1" TrueText="Si" FalseText="No">
                                        <Editor>
                                            <ext:Checkbox runat="server"></ext:Checkbox>
                                        </Editor>
                                    </ext:BooleanColumn>
                                </Columns>
                            </ColumnModel>
                            <Listeners>
                                <%--<SelectionChange Handler="App.direct.fllenarDetalle(selected[0].data.id_menu); #{gpDetalleMenu}.setTitle('Detalle Menu '+selected[0].data.nombre); "></SelectionChange>--%>
                            </Listeners>

                            <SelectionModel>
                                <ext:RowSelectionModel runat="server" Mode="Single" />
                            </SelectionModel>
                           
                            <BottomBar>
                                <ext:PagingToolbar ID="PagingToolbar1" runat="server" RefreshHandler="App.direct.fConsultarMenu();" />
                            </BottomBar>
                        </ext:GridPanel>

                    </Items>
                </ext:Panel>
                <ext:Panel runat="server" Layout="FitLayout" Border="true">
                    <Defaults>
                    </Defaults>

                    <Items>
                        <ext:GridPanel runat="server" ID="gpDetalleMenu" Title="Detalle Envio" Scroll="Both" AutoScroll="true" StripeRows="true">
                            <Store>
                                <ext:Store ID="stDetalleMenu" runat="server">
                                    <Model>
                                        <ext:Model ID="Model2" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="id_institucion" />
                                                <ext:ModelField Name="idtipo_menu" />
                                                <ext:ModelField Name="id_menu" />
                                                <ext:ModelField Name="id_elemento" />
                                                <ext:ModelField Name="cantidad" />
                                                <ext:ModelField Name="tipo_elemento" />
                                                <ext:ModelField Name="elemento" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                         
                            <ColumnModel ID="ColumnModel2" runat="server">
                                <Columns>

                                    <ext:Column ID="Column7" runat="server" Text="Cantidad" DataIndex="cantidad" Flex="1" />
                                    <ext:Column ID="Column8" runat="server" Text="Tipo" DataIndex="tipo_elemento" Flex="1" />
                                    <ext:Column ID="Column5" runat="server" Text="Elemento" DataIndex="elemento" Flex="1" />

                                    <ext:CommandColumn ID="CommandColumn1" runat="server" Flex="1" Text="Acciones">
                                        <Commands>
                                            <ext:GridCommand Icon="Delete" CommandName="eliminarFase" Text="Eliminar" />
                                        </Commands>
                                        <Listeners>
                                            <Command Handler="feliminarDetalle(record);" />
                                        </Listeners>
                                    </ext:CommandColumn>
                                </Columns>
                            </ColumnModel>
                            <BottomBar>
                                <ext:PagingToolbar ID="PagingToolbar3" runat="server" RefreshHandler="" />
                            </BottomBar>
                        </ext:GridPanel>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>

</body>
</html>
