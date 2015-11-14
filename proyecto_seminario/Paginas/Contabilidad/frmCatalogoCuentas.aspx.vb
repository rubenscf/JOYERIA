Imports Ext.Net
Public Class frmCatalogoCuentas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fLlenarGrid()
      
    End Sub



#Region "Metodos Directos"
    <DirectMethod> _
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorCuentas
        stCuenta.DataSource = v_datos.fListarCuenta
        stCuenta.DataBind()
    End Sub
    <DirectMethod> _
    Public Sub fcrearVentanaCuentas(ByVal p_accion As Int16, ByVal p_id As Int16)
        Dim titulo As String = ""
        Dim queryString As String = ""
        Select Case p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Crear Nueva Cuenta Contable "
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar
                titulo = "Modificar Cuenta Contable "
                queryString = ""
                queryString &= ("&codigo=" & p_id)
                queryString &= ("&accion=" & p_accion)
        End Select
        Dim win = New Window With {.ID = "Win_EditarCuentas",
                                    .Width = Unit.Pixel(575),
                                    .Height = Unit.Pixel(300),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmEditarCuentas.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
#End Region


End Class