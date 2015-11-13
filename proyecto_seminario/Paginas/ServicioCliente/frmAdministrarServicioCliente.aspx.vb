Imports Ext.Net
Public Class frmAdministrarServicioCliente
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 And CInt(Session("idpuesto")) < 11 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fLlenarGrid()
    End Sub
#Region "Metodos Directos"
    <DirectMethod>
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorProcedimientos
        stTickets.DataSource = v_datos.fListarCasos(1)
        stTickets.DataBind()
    End Sub
    <DirectMethod>
    Public Sub fcrearVentanaTicket(ByVal p_accion As Int16, ByVal p_id As String)
        Dim titulo As String = ""
        Dim queryString As String = ""
        Select Case p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Nuevo Ticket "
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar
                titulo = "Modificar Proveedor "
                queryString = ""
                queryString &= ("&codigo=" & p_id)
                queryString &= ("&accion=" & p_accion)

        End Select
        Dim win = New Window With {.ID = "Win_CrearTicket",
                                    .Width = Unit.Pixel(570),
                                    .Height = Unit.Pixel(420),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmNuevoCaso.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
#End Region
End Class
