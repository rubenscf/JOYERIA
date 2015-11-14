Imports Ext.Net
Public Class frmCatalogoModelo
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 6 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fLlenarGrid()
    End Sub
    <DirectMethod>
    Public Sub fLlenarGrid()
        Dim vacceso As New clsControladorProcedimientos
        Try
            stProductos.DataSource = vacceso.fListarProductos()
            stProductos.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Sub fcrearVentanaProveedor(ByVal p_accion As Int16, ByVal p_proveedor As Long, ByVal p_familia As Long, ByVal p_material As Long, ByVal p_modelo As String,
                                      ByVal p_producto As String, ByVal p_compra As String, ByVal p_venta As String, ByVal p_estado As String)
        Dim titulo As String = ""
        Dim queryString As String = ""
        Select Case p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Crear nuevo producto"
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar

                titulo = "Modificar Producto " & p_producto
                queryString = ""
                queryString &= ("&proveedor=" & p_proveedor)
                queryString &= ("&familia=" & p_familia)
                queryString &= ("&material=" & p_material)
                queryString &= ("&modelo=" & p_modelo)
                queryString &= ("&producto=" & p_producto)
                queryString &= ("&pcompra=" & p_compra)
                queryString &= ("&pventa=" & p_venta)
                queryString &= ("&estado=" & p_estado)
                queryString &= ("&accion=" & p_accion)
        End Select
        Dim win = New Window With {.ID = "Win_EditarProducto",
                                    .Width = Unit.Pixel(700),
                                    .Height = Unit.Pixel(200),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmEditarModelo.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub

End Class