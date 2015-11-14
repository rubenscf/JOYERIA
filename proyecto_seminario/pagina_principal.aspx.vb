Imports Ext.Net
Public Class pagina_principal
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session.Count = 0 Then
            FormsAuthentication.RedirectToLoginPage()
        End If
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fMostrarValoresInicales()
            lbllutipo.Text = "Area: " + Session("tipolugar")
            lbllunombre.Text = "Ubicacion: " + Session("lugar")
            lblpuesto.Text = "Puesto: " + Session("puesto")
        End If


    End Sub

    Private Sub fMostrarValoresInicales()
        BtnSesionCnfg.Text = "Bienvenido " + Session("nombre")
        mostrarMenu()
    End Sub
    Private Sub ocultarMenu()
        miTipoLugar.Visible = False
        miProveedores.Visible = False
        miFamilia.Visible = False
        miMaterial.Visible = False
        miModelo.Visible = False
        miEnvios.Visible = False
        MiRecepcionEnvio.Visible = False
        MiInventario.Visible = False
        miVentas.Visible = False
        miParametros.Visible = False
        miPeriodoConta.Visible = False
        miTipoCuenta.Visible = False
        miCatalogoCuenta.Visible = False
        miAsientoCOntable.Visible = False
        miLibroDiario.Visible = False
        miTickets.Visible = False
        miAsignacion.Visible = False
        miUsuarios.Visible = False
        MiIngresoFActura.Visible = False
    End Sub
    Protected Sub mostrarMenu()
        Select Case CInt(Session("idtipolugar"))
            Case 1 'tipo adminsitracion
                Select Case CInt(Session("idpuesto"))
                    Case 1
                        miFamilia.Visible = True
                        miMaterial.Visible = True
                        miProveedores.Visible = True
                        MiInventario.Visible = True
                        miModelo.Visible = True
                        miPeriodoConta.Visible = True
                        miLibroDiario.Visible = True
                        miAsientoCOntable.Visible = True
                        miAsignacion.Visible = True

                    Case 2
                        miFamilia.Visible = True
                        miProveedores.Visible = True
                        MiInventario.Visible = True
                        miModelo.Visible = True
                        miPeriodoConta.Visible = True
                        miLibroDiario.Visible = True
                        miAsientoCOntable.Visible = True


                    Case 3

                        miParametros.Visible = True
                        miPeriodoConta.Visible = True
                        miTipoCuenta.Visible = True
                        miCatalogoCuenta.Visible = True
                        miAsientoCOntable.Visible = True
                        miLibroDiario.Visible = True

                    Case 4
                        miTipoLugar.Visible = True
                        miProveedores.Visible = True
                        miFamilia.Visible = True
                        miMaterial.Visible = True
                        miModelo.Visible = True
                        miEnvios.Visible = True
                        MiRecepcionEnvio.Visible = True
                        MiInventario.Visible = True
                        miVentas.Visible = True
                        miParametros.Visible = True
                        miPeriodoConta.Visible = True
                        miTipoCuenta.Visible = True
                        miCatalogoCuenta.Visible = True
                        miAsientoCOntable.Visible = True
                        miLibroDiario.Visible = True
                        miTickets.Visible = True
                        miAsignacion.Visible = True
                        miUsuarios.Visible = True
                        MiIngresoFActura.Visible = True

                End Select
            Case 2 'tipo bodega

                Select Case CInt(Session("idpuesto"))
                    Case 5
                        miProveedores.Visible = True
                        miFamilia.Visible = True
                        miMaterial.Visible = True
                        miModelo.Visible = True
                        miEnvios.Visible = True
                        MiRecepcionEnvio.Visible = True
                        MiInventario.Visible = True
                        MiIngresoFActura.Visible = True

                    Case 6
                        miProveedores.Visible = True
                        miFamilia.Visible = True
                        miMaterial.Visible = True
                        miModelo.Visible = True
                        miEnvios.Visible = True
                        MiRecepcionEnvio.Visible = True
                        MiInventario.Visible = True
                        MiIngresoFActura.Visible = True
                End Select
            Case 3 'tipo tienda

                Select Case CInt(Session("idpuesto"))
                    Case 7
                        miFamilia.Visible = True
                        miMaterial.Visible = True
                        miModelo.Visible = True
                        miVentas.Visible = True


                    Case 8
                        miFamilia.Visible = True
                        miMaterial.Visible = True
                        miModelo.Visible = True


                    Case 9

                        miTickets.Visible = True


                    Case 10
                        miVentas.Visible = True
                        miEnvios.Visible = True
                        MiInventario.Visible = True
                        miFamilia.Visible = True
                        miMaterial.Visible = True
                        miModelo.Visible = True


                End Select
            Case 4 'publico
                Select Case CInt(Session("idpuesto"))
                    Case 11
                        miTickets.Visible = True
                End Select


        End Select




    End Sub
#Region "Metodos Directos"
    <DirectMethod>
    Public Sub Salir()
        Session.Abandon()
        Session.Remove("nombre")
        FormsAuthentication.SignOut()

        Response.Redirect(Request.UrlReferrer.ToString())
    End Sub
#End Region
End Class