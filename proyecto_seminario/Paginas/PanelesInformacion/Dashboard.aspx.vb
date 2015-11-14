Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("idpuesto") > 10 Then
            Response.Redirect("../ServicioCliente/frmAdministrarServicioCliente.aspx")
        End If
    End Sub

End Class