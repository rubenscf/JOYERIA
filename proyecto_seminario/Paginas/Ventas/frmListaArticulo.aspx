<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmListaArticulo.aspx.vb" Inherits="proyecto_seminario.frmListaArticulo" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title></title>

    <script type="text/javascript" src="Script/jsVentaContado.js">  </script>






</head>
<body>
    <form id="form1" runat="server">



        <ext:ResourceManager ID="rsListaArticulo" runat="server" />
        <ext:Viewport runat="server" ID="vpListaArticulo" MarginSpec="0 0 10 0">
            <LayoutConfig>
                <ext:VBoxLayoutConfig Align="Center" Pack="Center" />
            </LayoutConfig>
            <Items>
                <ext:GridPanel runat="server" ID="dgListaArticulo" Title="LISTA DE JOYAS"  Frame="true"  Width="800"   Height="295">
                    <Store>
                        <ext:Store
                            runat="server" ID="stListaArticulo">
                            <Model>
                                <ext:Model ID="ModelListaArticulo"  runat="server">
                                    <Fields>
                                        <ext:ModelField Name="idpr_modelo" />
                                        <ext:ModelField Name="detalle" Type="String" />
                                        <ext:ModelField Name="preciov" Type="Float" />

                                    </Fields>
                                </ext:Model>
                            </Model>

                        </ext:Store>
                    </Store>
                    <SelectionModel>
                        <ext:RowSelectionModel ID="rowSelectionModel1" runat="server" />
                    </SelectionModel>

                    <ColumnModel runat="server" ID="ColumnMo">



                        <Columns>
                            <ext:Column ID="Col1" runat="server" Text="CODIGO" DataIndex="idpr_modelo" Width="150" />
                            <ext:Column ID="Col2" runat="server" Text="DETALLE" Flex="1" DataIndex="detalle" />
                            <ext:Column ID="Col3" runat="server" Text="PRECIO" DataIndex="preciov" Width="150" />

                            <ext:CommandColumn ID="Col4" runat="server"  Text="Tareas" Align="Center">
                                <Commands>
                                    <ext:GridCommand Icon="Pencil" CommandName="selecionaArticulo" ToolTip-Text="Accion" />
                                </Commands>
                                <Listeners>
                                    <Command Handler="fSeleccionar(command,record);" />


                                </Listeners>
                            </ext:CommandColumn>
                        </Columns>
                    </ColumnModel>
                </ext:GridPanel>
            </Items>
        </ext:Viewport>



    </form>
</body>
</html>
