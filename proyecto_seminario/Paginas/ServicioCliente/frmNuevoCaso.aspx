<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmNuevoCaso.aspx.vb" Inherits="proyecto_seminario.frmNuevoCaso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <ext:ResourceManager ID="rsServicioAlCliente" runat="server" />
       
       
       <h1>DETALLE SU TICKET</h1>
        <p> Si esta informando de un problema en el producto, recuenda poder proporcionar tanta información relevante como sea prosible.  </p>
        
        <ext:FormPanel
            runat="server" 
            Width="550"
            Height="270"            
            Title="Detalle Ticket"            
            Closable="false"
            Layout="Form"
            BodyPadding="5">           
            <Defaults>
                <ext:Parameter Name="LabelWidth" Value="200" />
            </Defaults>
            <Items>


                <ext:ComboBox runat="server" ID="cmbDepartamento" MarginSpec="5 5 5 5" FieldLabel="Seleccione un Departamenteo" DisplayField="DETALLE" ValueField="IDCL_TIPO_CASO" LabelAlign="Top" Editable="false" Flex="1">
                            <Store>
                                <ext:Store ID="stListarTipoCaso" runat="server">
                                    <Model>
                                        <ext:Model ID="mdCaso" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="IDCL_TIPO_CASO" />
                                                <ext:ModelField Name="DETALLE" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>

               
                   <ext:TextField runat="server" ID="txttiluto" Note="Titulo del Ticket" FieldLabel="Asunto">
                  </ext:TextField>

                 <ext:TextArea runat="server" ID="txtdetalle" Note="Detalle Caso" FieldLabel="Descripcion">
                  </ext:TextArea>
       
                  
                    </Items>   
            <Buttons> 
                <ext:Button ID="btncrear" runat="server" Width="160" Text="Crear Ticket" Icon="Add" >
                                   <Listeners>
                                     <Click Handler ="App.direct.fGuardar()" />
                                   </Listeners>
                                </ext:Button>
                  <ext:Button ID="btncancelar" runat="server" Width="160" Text="Cancelar" Icon="Cancel" >
                                   
                                  <Listeners> 
                                      <Click Handler="fCancelar();" />
                                  </Listeners>

                                </ext:Button>
                                         
                </Buttons>                  
               
        </ext:FormPanel>           






    </form>
</body>
</html>
