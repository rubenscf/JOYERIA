
Imports Ext.Net

Public Class frm_VentaContado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

#Region "Metodos Directo"
    <DirectMethod> _
    Public Sub fmostrarListaArticulo()
        Dim titulo As String = ""
        Dim queryString As String = ""

        Dim win = New Window With {.ID = "Win_ListaArcitulo", _
                                    .Width = Unit.Pixel(800), _
                                    .Height = Unit.Pixel(350), _
                                    .Title = titulo, _
                                    .Modal = True, _
                                    .AutoRender = False, _
                                    .Collapsible = False, _
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmListaArticulo.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub




#End Region




End Class