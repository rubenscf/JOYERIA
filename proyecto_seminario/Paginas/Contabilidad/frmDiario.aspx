<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmDiario.aspx.vb" Inherits="proyecto_seminario.frmDiario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
 
 
</head>
<body>


    <form runat="server">
        <ext:ResourceManager runat="server" />
        <ext:Viewport ID="vpctl" runat="server" Layout="AbsoluteLayout" AnchorVertical="100%">
            <Items>
 
                        <ext:GridPanel ID="gridDiario" runat="server" AnchorHorizontal="100%" AnchorVertical="100%" Scroll="Both" AutoScroll="true" Region="West"   MarginSpec="5 5 5 5">

                       <Store>
                        <ext:Store runat="server" ID="stDiario">
                            <Model>
                                <ext:Model runat="server" ID="mgDiario">
                                    <Fields>
                                        <ext:ModelField Name="NOMBRE" Type="string" />
                                        <ext:ModelField Name="CODIGO" Type="string" />                    
                                        <ext:ModelField Name="DEBE"   Type="Float" />
                                        <ext:ModelField Name="HABER" Type="Float" />
                                 
                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                            <TopBar>
                        <ext:Toolbar ID="Toolbar5" runat="server">
                            <Items>
                                <ext:ToolbarFill ID="ToolbarFill2" runat="server" />
                                
                                

                                  <ext:ComboBox FieldLabel="Año" LabelAlign="Top" AllowBlank="false"   ID="ComboAnio" LabelWidth="50" runat="server" DisplayField="CODIGO" ValueField="CODIGO" Width="80" >
                                    <Store>
                                      <ext:Store ID="stAnio" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="Int" />
                                              <ext:ModelField Name="CODIGO"  Type="Int"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>      
                                 </ext:ComboBox>


                                
                              <ext:ComboBox FieldLabel="Mes" LabelAlign="Top"  AllowBlank="false" LabelWidth="30"  ID="ComboMes" runat="server" DisplayField="NOMBRE" ValueField="CODIGO" Width="150" >
                                    <Store>
                                      <ext:Store ID="stMes" runat="server" >
                                        <Model>
                                          <ext:Model runat="server" >
                                             <Fields>
                                                 <ext:ModelField Name="CODIGO" Type="String" />
                                              <ext:ModelField Name="NOMBRE"  Type="String"/>
                                          </Fields>
                                         </ext:Model>
                                       </Model>            
                                      </ext:Store>
                                    </Store>      
                                 </ext:ComboBox>
                                      

                                        <ext:Button MarginSpec="0 5 0 5" AutoLoadingState="true"   ID="btnAgregar" Text="Ver" runat="server" Icon="ApplicationViewDetail" Width="95">
                                            <Listeners>
                                                <Click Handler="App.direct.fVerDiario()"></Click>
                                            </Listeners>
                                         </ext:Button> 




                               <ext:TextField MaxLength="100" LabelAlign="Top" FieldLabel="Total Debe" LabelWidth="40" runat="server" ID="txtDeber" AllowBlank="false" MarginSpec="5 5 5 5" Width="190" />
                       
                               <ext:TextField MaxLength="100" LabelAlign="Top" FieldLabel="Total Haber" LabelWidth="40" runat="server" ID="txtHaber" AllowBlank="false" MarginSpec="5 5 5 5" Width="190" />
                       


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

                               <ext:Column runat="server" ID="ColumnNombre" Text="Nombre de la Cuenta" Flex="1" Align="Left" DataIndex="NOMBRE"/>

                               <ext:Column runat="server" ID="ColumnCodigo" Text="Código" Flex="1" Align="Left" DataIndex="CODIGO"/>

                               <ext:Column runat="server" ID="ColumnDebe" Text="Debe" Width="200" Align="Right" DataIndex="DEBE">
                                 <Renderer Format="UsMoney" />                                 
                               </ext:Column>
                                
                               <ext:Column runat="server" ID="ColumnHaber" Text="Haber" Width="200" Align="Right" DataIndex="HABER">
                                   <Renderer Format="UsMoney" />  
                               </ext:Column>
                                   
                                                                          
                               </Columns>
                            </ColumnModel>

                       
                        </ext:GridPanel>


                    </Items>

        </ext:Viewport> 

      
    </form>







</body>
</html>
