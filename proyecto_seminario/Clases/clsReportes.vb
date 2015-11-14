Imports Ext.Net

Public Class clsReportes
    Public Sub fEnvio(ByVal Sale As String, ByVal tipo As String, ByVal idenvio As String, ByVal destino As String, ByVal version As String)
        Dim titulo As String = ""
        Dim queryString As String = ""
        titulo = "Formato Envio"
        queryString = ""
        queryString &= ("SALE=" & Sale)
        queryString &= ("&tipo=" & tipo)
        queryString &= ("&idenvio=" & idenvio)
        queryString &= ("&DESTINO=" & destino)
        queryString &= ("&VERSION=" & version)
        Dim win = New Window With {.ID = "Win_FormaEnvio",
                                    .Width = Unit.Pixel(800),
                                    .Height = Unit.Pixel(500),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New Ext.Net.ComponentLoader
        win.Loader.Url = "~/Reportes/frmReporteEnvio.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub

End Class
