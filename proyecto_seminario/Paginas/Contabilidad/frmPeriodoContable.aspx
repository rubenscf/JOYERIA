<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmPeriodoContable.aspx.vb" Inherits="proyecto_seminario.frmPeriodoContable" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        
        <h1>Información de Periodos Activos</h1>
        
        <p>Tiempo que corresponde al ejercicio</p>    
        
        <ext:Panel runat="server" Flex="1" Height="400" Layout="BorderLayout">
            <Items>
                <ext:GridPanel ID="GridPanel1" runat="server" Region="West" Width="850" Title="Left"   MarginSpec="5 5 5 5">                
                    <Store>
                        <ext:Store ID="stPeriodoConta" runat="server">
                            <Model>
                                <ext:Model runat="server">
                                    <Fields>
                                        <ext:ModelField Name="ANIO" Type="Int" />
                                        <ext:ModelField Name="INICIO" Type="Date"/>
                                        <ext:ModelField Name="FIN" Type="Date"  />
                                        <ext:ModelField Name="MES" Type="String" />
                                        <ext:ModelField Name="DESDE" Type="Date"/>
                                        <ext:ModelField Name="HASTA" Type="Date"  />
                                        <ext:ModelField Name="ESTADO_MES" Type="string" />
                                        <ext:ModelField Name="ESTADO_PERIODO" Type="string" />


                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                    <ColumnModel>
                        <Columns>

                             <ext:Column runat="server" ID="ColumnAnio" Text="Año" Width="100" Align="Center" DataIndex="ANIO"/>
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Inicio"  Align="Center" DataIndex="INICIO" />
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Fecha Fin"  Align="Center" DataIndex="FIN" />
                            <ext:Column runat="server" ID="mes" Text="Mes" Width="125" Align="Center" DataIndex="MES"/>
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Desde"  Align="Center" DataIndex="DESDE" />
                            <ext:DateColumn runat="server" Format="dd/MM/yyyy" Text="Hasta"  Align="Center" DataIndex="HASTA" />
                            <ext:Column runat="server" ID="EstadoMes" Text="Estado Mes" Width="125"  Align="Center" DataIndex="ESTADO_MES" />
                            <ext:Column runat="server" ID="EstadoPeriodo" Text="Estado Periodo" Width="125" Align="Center" DataIndex="ESTADO_PERIODO" />


                        </Columns>
                    </ColumnModel>
                    <SelectionModel>
                        <ext:RowSelectionModel runat="server" Mode="Single" />
                    </SelectionModel>  
                    <View>
                        <ext:GridView runat="server">
                            <Plugins>
                                <ext:GridDragDrop runat="server" EnableDrop="false" DDGroup="gridDDGroup" />
                            </Plugins>
                        </ext:GridView>
                    </View>                 
                </ext:GridPanel>
                <ext:FormPanel ID="FormPanel1" runat="server"  Region="Center" Title="Ingrese Nuevo Período" BodyStyle="background-color: #DFE8F6" BodyPadding="10" MarginSpec="5 5 5 0">
                    <Items>


                        <ext:NumberField ID="Aniotxt" FieldLabel="Año" LabelWidth="80" runat="server"  AutoDataBind="true" Width="200" Number="<%# DateTime.Now.Year %>"  MinValue="<%# DateTime.Now.Year %>"  AllowBlank="false" Icon="Date">
                       <CustomConfig>
                       <ext:ConfigItem Name="numberanio" Value="Aniotxt" Mode="Value"  />
                       </CustomConfig>
                       </ext:NumberField>
                        
                       <ext:DateField ID="fechaInicio" runat="server" LabelWidth="80"  Vtype="daterange" AllowBlank="false" FieldLabel="Desde" EmptyText="01/01/2015" Editable="false" Icon="Date" >
                       <CustomConfig>
                       <ext:ConfigItem Name="endDateField" Value="fechaInicio" Mode="Value"  />
                       </CustomConfig>
                       </ext:DateField>

                       <ext:DateField ID="fechaFinal" runat="server" Vtype="daterange" LabelWidth="80"  AllowBlank="false" FieldLabel="Hasta" EmptyText="31/12/2015" Editable="false" Icon="Date" >
                       <CustomConfig>
                       <ext:ConfigItem Name="fechaFinal" Value="fechaFinal" Mode="Value" />
                       </CustomConfig>
                       </ext:DateField>
                        
                    </Items>
                </ext:FormPanel>
            </Items>
            
            <BottomBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:ToolbarFill runat="server" />
                        <ext:Button runat="server" Text="Reset">
                            <Listeners>
                                <Click Handler="#{Store1}.loadData(#{Store1}.proxy.data); #{FormPanel1}.getForm().reset();" />
                            </Listeners>
                        </ext:Button>
                    </Items>
                </ext:Toolbar>
            </BottomBar>
        </ext:Panel> 
        
        <ext:DropTarget runat="server" Target="={#{FormPanel1}.body}" Group="gridDDGroup">
            <NotifyEnter Fn="notifyEnter" /> 
            <NotifyDrop Fn="notifyDrop" />
        </ext:DropTarget>
    </form>
</body>
</html>
