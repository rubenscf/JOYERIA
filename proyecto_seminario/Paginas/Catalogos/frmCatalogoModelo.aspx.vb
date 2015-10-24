Imports Ext.Net
Public Class frmCatalogoModelo
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarGrid()
    End Sub
    <DirectMethod>_
    Public Sub fLlenarGrid()
        Dim vacceso As New clsControladorProductos
        Try
            stProductos.DataSource = vacceso.fListarProductos()
            stProductos.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()
        End Try
    End Sub

End Class