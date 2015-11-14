<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="fmHistorial.aspx.vb" Inherits="proyecto_seminario.fmHistorial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager runat="server" />
        <ext:Viewport runat="server" ID="vpHistorial" Layout="AbsoluteLayout">
            <Items>
                 <ext:GridPanel runat="server" ID="dg" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="false">
                    <Store>
                        <ext:Store ID="stHistorial" runat="server">
                            <Model>
                                <ext:Model ID="Historial" runat="server">
                                    <Fields>
                                        <ext:ModelField Name="idlugar" />
                                        <ext:ModelField Name="idpr_modelo" />
                                        <ext:ModelField Name="no" />
                                        <ext:ModelField Name="fecha" />
                                        <ext:ModelField Name="proveedor" />
                                        <ext:ModelField Name="familia" />
                                        <ext:ModelField Name="material" />
                                        <ext:ModelField Name="producto" />
                                        <ext:ModelField Name="docto" />
                                        <ext:ModelField Name="movimiento" />
                                        <ext:ModelField Name="stock" />
                                        <ext:ModelField Name="empleado" />

                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                   
                    <SelectionModel>
                        <ext:RowSelectionModel ID="rowSelectionModel1" runat="server" />
                    </SelectionModel>
                    <ColumnModel ID="ColumnModel1" runat="server">
                        <Columns>
                            <ext:Column ID="Column1" runat="server" DataIndex="idpr_modelo" Text="Modelo" Visible="true" Width="80" />
                            <ext:Column ID="Column2" runat="server" DataIndex="no" Text="No." Visible="False" Width="30" />
                            <ext:Column ID="Column3" runat="server" DataIndex="fecha" Text="Fecha" Visible="true" Width="100" />
                            <ext:Column ID="Column4" runat="server" DataIndex="proveedor" Text="Proveedor" Visible="true" Width="100" />
                            <ext:Column ID="Column5" runat="server" DataIndex="familia" Text="Categoria" Visible="true" Width="100" />
                            <ext:Column ID="Column6" runat="server" DataIndex="material" Text="Material" Visible="true" Width="100" />
                            <ext:Column ID="Column7" runat="server" DataIndex="producto" Text="Producto" Visible="true" Width="150" />
                            <ext:Column ID="Column8" runat="server" DataIndex="docto" Text="Documento" Visible="true" Width="200" />
                            <ext:Column ID="Column9" runat="server" DataIndex="movimiento" Text="Movimiento" Visible="true" Width="100" />
                            <ext:Column ID="Column10" runat="server" DataIndex="stock" Text="Stock" Visible="true" Width="80" />
                            <ext:Column ID="Column11" runat="server" DataIndex="empleado" Text="Empleado" Visible="true" Width="100" >

                                 
                                <Editor>
                                    <ext:TextField runat="server"></ext:TextField>
                                </Editor>
                            </ext:Column>
                        </Columns>
                    </ColumnModel>
                   
                    
                    <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" RefreshHandler="fLlenarGrid()" />
                    </BottomBar>
                </ext:GridPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
