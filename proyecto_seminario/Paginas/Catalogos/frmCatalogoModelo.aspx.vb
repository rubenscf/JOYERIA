Imports Ext.Net
Public Class frmCatalogoModelo
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarGrid()
    End Sub
    <DirectMethod>
    Public Sub fLlenarGrid()
        Dim vacceso As New clsControladorProductos
        Try
            stProductos.DataSource = vacceso.fListarProductos()
            stProductos.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Sub fcrearVentanaProveedor(ByVal p_accion As Int16, ByVal p_proveedor As Long, ByVal p_familia As Long, ByVal p_material As Long
                                      )
        Dim titulo As String = ""
        Dim queryString As String = ""
        Select Case p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Crear nuevo producto"
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar

                titulo = "Modificar Producto "
                queryString = ""
                queryString &= ("&codigo=" & p_proveedor)

                queryString &= ("&accion=" & p_accion)

        End Select
        Dim win = New Window With {.ID = "Win_EditarProducto",
                                    .Width = Unit.Pixel(430),
                                    .Height = Unit.Pixel(350),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmEditarProveedor.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub

End Class