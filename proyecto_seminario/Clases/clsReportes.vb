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
                                    .Height = Unit.Pixel(450),
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
    Public Sub fCredito(ByVal LUGAR As String, ByVal SERIE As String, ByVal id As String, ByVal VERSION As String)
        Dim titulo As String = ""
        Dim queryString As String = ""
        titulo = "Formato Credito"
        queryString = ""
        queryString &= ("LUGAR=" & LUGAR)
        queryString &= ("&SERIE=" & SERIE)
        queryString &= ("&ID=" & id)
        queryString &= ("&VERSION=" & VERSION)
        Dim win = New Window With {.ID = "Win_FormaCredito",
                                    .Width = Unit.Pixel(800),
                                    .Height = Unit.Pixel(450),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New Ext.Net.ComponentLoader
        win.Loader.Url = "~/Reportes/frmReporteCredito.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
End Class
