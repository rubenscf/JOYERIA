Imports Ext.Net
Public Class frmEditarTipoLugar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 6 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If

    End Sub

End Class