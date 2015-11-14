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
    Protected Sub mostrarMenu()
        Select Case CInt(Session("idtipolugar"))
            Case 1 'tipo adminsitracion
                Select Case CInt(Session("idpuesto"))
                    Case 1
                        mpCatalogos1.Visible = True
                        mpCompras2.Visible = True
                        mpVentas3.Visible = True
                        mpContabilidad4.Visible = True
                        mpsCliente5.Visible = True
                        mpAdministracion6.Visible = True
                    Case 2
                        mpCatalogos1.Visible = False
                        mpCompras2.Visible = False
                        mpVentas3.Visible = True
                        mpContabilidad4.Visible = False
                        mpsCliente5.Visible = True
                        mpAdministracion6.Visible = False

                    Case 3

                        mpCatalogos1.Visible = False
                        mpCompras2.Visible = False
                        mpVentas3.Visible = False
                        mpContabilidad4.Visible = True
                        mpsCliente5.Visible = False
                        mpAdministracion6.Visible = False

                    Case 4
                        mpCatalogos1.Visible = True
                        mpCompras2.Visible = True
                        mpVentas3.Visible = True
                        mpContabilidad4.Visible = True
                        mpsCliente5.Visible = True
                        mpAdministracion6.Visible = False

                End Select
            Case 2 'tipo bodega

                Select Case CInt(Session("idpuesto"))
                    Case 5

                        mpCatalogos1.Visible = True
                        mpCompras2.Visible = True
                        mpVentas3.Visible = False
                        mpContabilidad4.Visible = False
                        mpsCliente5.Visible = False
                        mpAdministracion6.Visible = True

                    Case 6
                        mpCatalogos1.Visible = True
                        mpCompras2.Visible = True
                        mpVentas3.Visible = False
                        mpContabilidad4.Visible = False
                        mpsCliente5.Visible = False
                        mpAdministracion6.Visible = False
                End Select
            Case 3 'tipo tienda

                Select Case CInt(Session("idpuesto"))
                    Case 7
                        mpCatalogos1.Visible = False
                        mpCompras2.Visible = False
                        mpVentas3.Visible = True
                        mpContabilidad4.Visible = False
                        mpsCliente5.Visible = False
                        mpAdministracion6.Visible = False

                    Case 8
                        mpCatalogos1.Visible = False
                        mpCompras2.Visible = False
                        mpVentas3.Visible = True
                        mpContabilidad4.Visible = False
                        mpsCliente5.Visible = False
                        mpAdministracion6.Visible = False

                    Case 9

                        mpCatalogos1.Visible = True
                        mpCompras2.Visible = False
                        mpVentas3.Visible = False
                        mpContabilidad4.Visible = False
                        mpsCliente5.Visible = True
                        mpAdministracion6.Visible = False

                    Case 10
                        mpCatalogos1.Visible = False
                        mpCompras2.Visible = False
                        mpVentas3.Visible = True
                        mpContabilidad4.Visible = False
                        mpsCliente5.Visible = True
                        mpAdministracion6.Visible = False
                End Select
            Case 4 'publico
                Select Case CInt(Session("idpuesto"))
                    Case 11
                        mpCatalogos1.Visible = False
                        mpCompras2.Visible = False
                        mpVentas3.Visible = False
                        mpContabilidad4.Visible = False
                        mpAdministracion6.Visible = False
                        mpsCliente5.Visible = True
                        MenuItem7.Visible = True
                        MenuItem4.Visible = False
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