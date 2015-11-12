Imports Ext.Net
Public Class frmListaArticulo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarGrid()

    End Sub
#Region "Metodo Directos"
    <DirectMethod>
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorProcedimientos
    End Sub
#End Region


End Class