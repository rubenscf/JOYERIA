<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmParametros.aspx.vb" Inherits="proyecto_seminario.frmParametros" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="Scripts/jsParametro.js"></script>
    
</head>
<body>
  




   <form id="form1" runat="server">
   
         <ext:ResourceManager ID="rmAParametro" runat="server" />
         <ext:Viewport ID="vpctl" runat="server" Layout="AbsoluteLayout" AnchorVertical="100%">
            <Items>
                <ext:GridPanel ID="GridParametro" runat="server" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true" StripeRows="true" Resizable="true">
                    <Store>
                        <ext:Store runat="server" ID="stParametro">
                            <Model>
                                <ext:Model runat="server" ID="mgParametro">
                                    <Fields>
                                        <ext:ModelField Name="CODIGO" Type="Int" />
                                        <ext:ModelField Name="NOMBRE" Type="string" />
                                        <ext:ModelField Name="PORCENTAJE" Type="Float" />
                                      
                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                     
                    <TopBar>

                        <ext:Toolbar ID="Toolbar5" runat="server">

                            <Items>

                                <ext:ToolbarFill ID="ToolbarFill2" runat="server" />
                               

                                <ext:ToolbarSeparator />
                                     <ext:TextField runat="server" ID="txtDescripcion" EmptyText="Impuesto al Valor Agregado" AllowBlank="false" Width="300" Regex="[A-Z]" MaxLengthText="100" FieldLabel="Descripción" />
                                <ext:ToolbarSeparator />
                                     <ext:NumberField FieldLabel="Porcentaje" ID="txtPorcentaje" runat="server" AllowBlank="false"  EmptyText="12" Width="150" MarginSpec="0 3 0 0" HideTrigger="true"  MaxText="2"/>

                                <ext:Button ID="btnAgregar" runat="server" Width="120" Text="Guardar" Icon="Disk" >
                                    <Listeners>
                                        <Click Handler="App.direct.fGuardar()"></Click>
                                    </Listeners>
                                </ext:Button>


                                

                                <ext:ToolbarSeparator />
                            </Items>
                        </ext:Toolbar>
                    </TopBar>
                    <BottomBar>
                        <ext:PagingToolbar ID="PagingToolbar1" runat="server" DisplayInfo="true" DisplayMsg="Mostrando {0} - {1} of {2}"
                            EmptyMsg="No hay datos que mostrar" />
                    </BottomBar>
                    

                    <ColumnModel>
                        <Columns>
                            
                            <ext:Column  runat="server" ID="ColumnCodigo" Text="CORRELATIVO" Width="125" Align="Left" DataIndex="CODIGO" />
                            <ext:Column runat="server" ID="ColumnNombre" Text="NOMBRE DEL PARAMETRO" Flex="1" Alig="Right" DataIndex="NOMBRE" />
                            <ext:Column runat="server" ID="ColumnPorcentaje" Text=" % "  Width="125" Align="Center" DataIndex="PORCENTAJE" />
                            

                          <ext:Column ID="ColumnProfilo" runat="server" DataIndex="Profilo" Text="Profilo">
                            <Renderer Handler="return StatusRenderer(value, #{StoreProfilo});" />
                            <Editor>      
                                <ext:ComboBox ID="ComboBoxProfilo" SelectOnFocus="true" EmptyText="Select a Class"  TriggerAction="All" QueryMode="Local" runat="server" DisplayField="Text" ValueField="Value">
                                    <Store>
                                        <ext:Store ID="StoreProfilo" runat="server" AutoLoad="true" >
                                            <Model>
                                                <ext:Model ID="ModelProfilo" runat="server" IDProperty="Value">
                                                    <Fields>
                                                        <ext:ModelField Name="Text" />
                                                        <ext:ModelField Name="Value" />
                                                    </Fields>
                                                </ext:Model>
                                            </Model>            
                                        </ext:Store>
                                    </Store>
                                    <Listeners>
                                     
                                    </Listeners>
                                </ext:ComboBox>
                            </Editor>
                        </ext:Column>
                        </Columns>

                    </ColumnModel>
                </ext:GridPanel>


            </Items>

        </ext:Viewport>

 </form>





</body>
</html>
