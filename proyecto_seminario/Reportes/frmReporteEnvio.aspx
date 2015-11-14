<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmReporteEnvio.aspx.vb" Inherits="proyecto_seminario.frmReportViewer"  Debug="true"%>


<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div>
    
        
       
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%" ZoomMode="PageWidth" ZoomPercent="80"  >
            <LocalReport ReportPath="Reportes\FORMAS\FormaEnvio.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="vstEnvios" Name="DataSet1" />
                    <rsweb:ReportDataSource DataSourceId="lugar" Name="LUGAR_DS" />
                </DataSources>
            </LocalReport>
           
        </rsweb:ReportViewer>
      

        <asp:ObjectDataSource ID="lugar" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="proyecto_seminario.DSTableAdapters.LUGAR_REPORTTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_IDLUGAR" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="NOMBRE" Type="String" />
                <asp:Parameter Name="DIRECCION" Type="String" />
                <asp:Parameter Name="TELEFONO" Type="String" />
                <asp:Parameter Name="TELEFONO1" Type="String" />
                <asp:Parameter Name="SERIE_FACTURA" Type="String" />
                <asp:Parameter Name="SERIE_CREDITO" Type="String" />
                <asp:Parameter Name="SERIE_ABONO_TIE" Type="String" />
                <asp:Parameter Name="SERIE_ENGANCHE" Type="String" />
                <asp:Parameter Name="SERIE_ABONO_COB" Type="String" />
                <asp:Parameter Name="FACT_MIN" Type="Int64" />
                <asp:Parameter Name="FACT_MAX" Type="Int64" />
                <asp:Parameter Name="VERSION" Type="Int16" />
                <asp:Parameter Name="LETRA_CAMBIO" Type="Int16" />
                <asp:Parameter Name="LOGO" Type="Object" />
                <asp:Parameter Name="IDLUGAR" Type="String" />
                <asp:Parameter Name="IDLU_TIPO" Type="Int16" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="idlugar" QueryStringField="SALE" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="NOMBRE" Type="String" />
                <asp:Parameter Name="DIRECCION" Type="String" />
                <asp:Parameter Name="TELEFONO" Type="String" />
                <asp:Parameter Name="TELEFONO1" Type="String" />
                <asp:Parameter Name="SERIE_FACTURA" Type="String" />
                <asp:Parameter Name="SERIE_CREDITO" Type="String" />
                <asp:Parameter Name="SERIE_ABONO_TIE" Type="String" />
                <asp:Parameter Name="SERIE_ENGANCHE" Type="String" />
                <asp:Parameter Name="SERIE_ABONO_COB" Type="String" />
                <asp:Parameter Name="FACT_MIN" Type="Int64" />
                <asp:Parameter Name="FACT_MAX" Type="Int64" />
                <asp:Parameter Name="VERSION" Type="Int16" />
                <asp:Parameter Name="LETRA_CAMBIO" Type="Int16" />
                <asp:Parameter Name="LOGO" Type="Object" />
                <asp:Parameter Name="IDLU_TIPO" Type="Int16" />
                <asp:Parameter Name="Original_IDLUGAR" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="vstEnvios" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="proyecto_seminario.DSTableAdapters.vst_ENVIOSTableAdapter">
            <SelectParameters>
                <asp:QueryStringParameter Name="SALE" QueryStringField="sale" Type="String" />
                <asp:QueryStringParameter DefaultValue="tipo" Name="TIPO" QueryStringField="tipo" Type="Int64" />
                <asp:QueryStringParameter DefaultValue="" Name="ENVIO" QueryStringField="idenvio" Type="Int64" />
                <asp:QueryStringParameter DefaultValue="" Name="DESTINO" QueryStringField="destino" Type="String" />
                <asp:QueryStringParameter DefaultValue="" Name="VERSION" QueryStringField="version" Type="Int16" />
            </SelectParameters>
        </asp:ObjectDataSource>
      

    </div>
    </form>
</body>
</html>
