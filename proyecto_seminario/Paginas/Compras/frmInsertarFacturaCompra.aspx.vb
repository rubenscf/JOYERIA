Imports Ext.Net
Public Class frmInsertarFacturaCompra
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarGrid()
    End Sub
#Region "Metodos Directos"
    <DirectMethod>
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorProcedimientos
        stInsertarFacturaCompra.DataSource = v_datos.fListarFacturaCompra
        stInsertarFacturaCompra.DataBind()
    End Sub
    <DirectMethod>
    Public Sub fcrearVentanaInsertarFacturaCompra(ByVal p_accion As Int16, ByVal p_id As Int16)
        Dim titulo As String = ""
        Dim queryString As String = ""
        Select Case p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Insertar Factura Compra "
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar
                titulo = "Modificar Factura Compra "
                queryString = ""
                queryString &= ("&codigo=" & p_id)
                queryString &= ("&accion=" & p_accion)

        End Select
        Dim win = New Window With {.ID = "Win_EditarFacturaCompra",
        .Width = Unit.Pixel(430),
        .Height = Unit.Pixel(350),
        .Title = titulo,
        .Modal = True,
        .AutoRender = False,
        .Collapsible = False,
        .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmEditarFacturaCompra.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
#End Region
End Class