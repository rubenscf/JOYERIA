Imports Ext.Net
Public Class frmPeriodoContable
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarGrid()
    End Sub


#Region "Metodos Directos"
    <DirectMethod> _
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorPeriodo
        stPeriodoConta.DataSource = v_datos.fListarPeriodoConta
        stPeriodoConta.DataBind()
    End Sub
    <DirectMethod> _
    Public Sub fcrearVentanaPeriodo(ByVal p_accion As Int16, ByVal p_id As Int16)
        Dim titulo As String = ""
        Dim queryString As String = ""
        Select Case p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Crear Nuevo Periodo Contable "
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar
                titulo = "Modificar Periodo Contable"
                queryString = ""
                queryString &= ("&codigo=" & p_id)
                queryString &= ("&accion=" & p_accion)
        End Select
        Dim win = New Window With {.ID = "Win_EditarPeriodo", _
                                    .Width = Unit.Pixel(305), _
                                    .Height = Unit.Pixel(215), _
                                    .Title = titulo, _
                                    .Modal = True, _
                                    .AutoRender = False, _
                                    .Collapsible = False, _
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmEditarPeriodo.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
#End Region

End Class