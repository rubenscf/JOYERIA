<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmTecnicos.aspx.vb" Inherits="proyecto_seminario.frmTecnicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
         guardar = function () {
                App.direct.fGuardar(
                    {
                        success: function (result) {
                            if (result == 1)
                                cerrar();
                            else alert('Error');
                        }
                    });
            };
         cerrar = function () {
             parent.App.direct.fLlenarGrid();
             App.parent.Win_AsignarTicket.close();
         };
    </script>
</head>
<body>
    <form id="form1" runat="server">
      <ext:ResourceManager runat="server"></ext:ResourceManager>
        <ext:FormPanel Layout="FormLayout" runat="server">
            <Items>
                
                 <ext:ComboBox runat="server" ID="cmbTecnico" MarginSpec="5 5 5 5" FieldLabel="Seleccione un Tecnico" DisplayField="nombre" ValueField="idempleado" LabelAlign="Top" Editable="false" Flex="1">
                            <Store>
                                <ext:Store ID="stTecnico" runat="server">
                                    <Model>
                                        <ext:Model ID="mdProveedores" runat="server">
                                            <Fields>
                                                <ext:ModelField Name="idempleado" />
                                                <ext:ModelField Name="nombre" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                 </ext:ComboBox>
            </Items>
            <Buttons>
                <ext:Button ID="guardar" runat="server" Text="Asignar" Icon="Link">
                    <Listeners>
                        <Click Handler="App.direct.fGuardar(); " />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:FormPanel>
    <div>
    
    </div>
    </form>
</body>
</html>
