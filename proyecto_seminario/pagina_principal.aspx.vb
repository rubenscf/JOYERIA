Imports Ext.Net
Public Class pagina_principal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Count = 0 Then
            FormsAuthentication.RedirectToLoginPage()
        Else

            BtnSesionCnfg.Text = "Bienvenido " + Session("nombre")
        End If
    End Sub
    <DirectMethod>
    Public Sub Salir()
        Session.Abandon()
        FormsAuthentication.RedirectToLoginPage()
    End Sub

End Class