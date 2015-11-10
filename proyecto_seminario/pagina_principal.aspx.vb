Imports Ext.Net
Public Class pagina_principal
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Count = 0 Then
            FormsAuthentication.RedirectToLoginPage()
        End If
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fMostrarValoresInicales()
        End If
    End Sub

    Private Sub fMostrarValoresInicales()
        BtnSesionCnfg.Text = "Bienvenido " + Session("nombre")
        mostrarMenu()
    End Sub
    Protected Sub mostrarMenu()

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