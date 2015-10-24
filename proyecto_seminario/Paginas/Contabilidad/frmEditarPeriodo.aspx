<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarPeriodo.aspx.vb" Inherits="proyecto_seminario.frmEditarPeriodo" %>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="Scripts/jsPeriodoContable.js"></script>
</head>
<body>
    <form id="form1" runat="server" >
 


        <ext:ResourceManager ID="rmEPeriodo" runat="server" />
        <ext:Panel ID="Panel1" runat="server" Layout="FormLayout"  >
            <Items>
                <ext:FormPanel ID="FormPanel2" runat="server" Frame="false" BodyPadding="8" >
                    <FieldDefaults LabelAlign="Right" LabelWidth="90" MsgTarget="Qtip" />
                    <Items>
                                                                                                 
                       
                       <ext:NumberField ID="Aniotxt" FieldLabel="Año" runat="server"  AutoDataBind="true" Width="200" Number="<%# DateTime.Now.Year %>"  MinValue="<%# DateTime.Now.Year %>"  AllowBlank="false" Icon="Date">
                       <CustomConfig>
                       <ext:ConfigItem Name="numberanio" Value="Aniotxt" Mode="Value"  />
                       </CustomConfig>
                       </ext:NumberField>
                        
                         <ext:DateField ID="fechaInicio" runat="server" Vtype="daterange" AllowBlank="false" FieldLabel="Desde" EmptyText="01/01/2015" Editable="false" Icon="Date" >
                       <CustomConfig>
                       <ext:ConfigItem Name="endDateField" Value="fechaInicio" Mode="Value"  />
                       </CustomConfig>
                       </ext:DateField>

                       <ext:DateField ID="fechaFinal" runat="server" Vtype="daterange" AllowBlank="false" FieldLabel="Hasta" EmptyText="31/12/2015" Editable="false" Icon="Date" >
                       <CustomConfig>
                       <ext:ConfigItem Name="fechaFinal" Value="fechaFinal" Mode="Value" />
                       </CustomConfig>
                       </ext:DateField>
                       
                    </Items>
                    <Buttons>
                        <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaPeriodo();" />
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:FormPanel>
            </Items>
        </ext:Panel>










    </form>
</body>
</html>
