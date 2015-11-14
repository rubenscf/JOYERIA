Imports Ext.Net
Public Class frmAsignacion
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fLlenarGrid()
    End Sub
#Region "Metodos Directos"
    <DirectMethod>
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorProcedimientos
        stTickets.DataSource = v_datos.fListarCasosSinAsignar
        stTickets.DataBind()
    End Sub
    <DirectMethod>
    Public Sub fcrearVentanaAsignar(ByVal _idcaso As String)
        Dim titulo As String = ""
        Dim queryString As String = ""

        titulo = "Nuevo Ticket "
        queryString = ""
        queryString &= ("&caso=" & _idcaso)

        Dim win = New Window With {.ID = "Win_AsignarTicket",
                                    .Width = Unit.Pixel(300),
                                    .Height = Unit.Pixel(200),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmTecnicos.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
#End Region
End Class