<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmEditarCuentas.aspx.vb" Inherits="proyecto_seminario.frmEditarCuentas" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="Scripts/jsCatalogoCuentas.js">    </script>
</head>
<body>
    
     <form id="form1" runat="server">
        <ext:ResourceManager runat="server" />
        <ext:FormPanel ID="frmeditarmodelo" runat="server">
            <FieldDefaults  />
            <Items>



                 <ext:FieldContainer runat="server" Layout="HBoxLayout">
                    <Items>
                        <ext:TextField MaxLength="100" FieldLabel="Código" LabelAlign="Top" runat="server" ID="txtCodigo" AllowBlank="false" MarginSpec="5 5 5 5" Width="125" />
                        <ext:TextField MaxLength="200" FieldLabel="Descripcion de la Cuenta" LabelAlign="Top" runat="server" ID="txtNombreCTA" AllowBlank="false" MarginSpec="5 5 5 5" Width="425" />
                    </Items>
                </ext:FieldContainer>


                <ext:FieldContainer runat="server" Layout="HBoxLayout">
                    <Items>

                        <ext:ComboBox runat="server" ID="cboTipo_cta" MarginSpec="5 5 5 5"  AllowBlank="false" LabelWidth="100" FieldLabel="Tipo Cuenta" EmptyText="Seleccione" DisplayField="descripcion" Editable="true" ValueField="IdTipo_cta" LabelAlign="Top" Width="250" >
                            <Store>
                                <ext:Store  ID="stTipoCuenta" runat="server">
                                    <Model>
                                        <ext:Model ID="mdTipoCuenta" runat="server">
                                            <Fields>
                                               <ext:ModelField Name="IdTipo_cta" Type="Int"  />
                                              <ext:ModelField Name="descripcion" Type="String"/>
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>

                         <ext:ComboBox runat="server" ID="cboMayoriza" MarginSpec="5 5 5 5" LabelWidth="100" FieldLabel="Cuenta a Mayorizar" EmptyText="Seleccione" DisplayField="NOMBRE" Editable="false" ValueField="CODIGO" LabelAlign="Top" Width="300" >
                            <Store>
                                <ext:Store  ID="stMayoriza" runat="server">
                                    <Model>
                                        <ext:Model ID="Model1" runat="server">
                                            <Fields>
                                               <ext:ModelField Name="CODIGO" Type="String"  />
                                              <ext:ModelField Name="NOMBRE" Type="String"/>
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>
                         
                    </Items>

                </ext:FieldContainer>



                <ext:FieldContainer runat="server" Layout="HBoxLayout">
                    <Items>
                       
                         <ext:NumberField ID="txtNivel" runat="server" MarginSpec="5 5 5 5" FieldLabel="Nivel de Cuenta" LabelAlign="Top" MinValue="1" MaxValue="5" Width="125" AllowBlank="false"/>

                        <ext:ComboBox ID="cboSumariza_cta" runat="server" AllowBlank="false"  MarginSpec="5 5 5 5" FieldLabel="Sumariza" Editable="false" Visible="true" LabelAlign="Top" EmptyText="Seleccione" Width="115">                    
                              <Items>
                                 <ext:ListItem Text="No"  />
                                 <ext:ListItem Text="Si" />
                              </Items>
                          </ext:ComboBox>  

                         <ext:ComboBox ID="cboMovimiento" runat="server" AllowBlank="false" MarginSpec="5 5 5 5" FieldLabel="Movimiento" Editable="false" Visible="true" LabelAlign="Top" EmptyText="Seleccione" Width="125">                    
                              <Items>
                                 <ext:ListItem Text="No"  />
                                 <ext:ListItem Text="Si" />
                              </Items>
                          </ext:ComboBox>
                         

                         <ext:ComboBox ID="cboAjusta" runat="server" AllowBlank="false" MarginSpec="5 5 5 5" FieldLabel="Ajusta" Editable="false" Visible="true" LabelAlign="Top"  EmptyText="Seleccione" Width="125">                    
                              <Items>
                                 <ext:ListItem Text="No"  />
                                 <ext:ListItem Text="Si" />
                              </Items>
                          </ext:ComboBox>

                    </Items>
                </ext:FieldContainer>


               
            </Items>



            <Buttons>
                <ext:Button ID="btnGuardar" runat="server" Text="Guardar" FormBind="true" Icon="Disk" Width="110" AutoLoadingState="true">
                            <Listeners>
                                <Click Handler="fGuardar();" />
                            </Listeners>
                        </ext:Button>
                        <ext:Button ID="btnCancelar" runat="server" Text="Cancelar" Icon="Cancel" Width="110">
                            <Listeners>
                                <Click Handler="fCerrarVentanaCuentas();" />
                            </Listeners>
                        </ext:Button>
            </Buttons>

        </ext:FormPanel>
    </form>


</body>
</html>
