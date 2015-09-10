Imports Ext.Net
Public Class frmCatalogoTipoLugar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <DirectMethod> _
    Public Sub fcrearVentanaConvocatoria(ByVal p_accion As Int16, ByVal p_id As Int16, ByVal p_detalle As String)
        Dim titulo As String = ""
        Dim queryString As String = ""
       Select p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Crear nuevo Tipo Lugar "
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar
                titulo = "Modificar Tipo Lugar [" + p_detalle + "]"
                queryString = ""
                queryString &= ("&idlu_tipo=" & p_id)
                queryString &= ("&detalle=" & p_detalle)
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Eliminar
                titulo = "Eliminar Tipo Lugar [" + p_detalle + "]"
                queryString = ""
                queryString &= ("&idlu_tipo=" & p_id)
                queryString &= ("&detalle=" & p_detalle)
                queryString &= ("&accion=" & p_accion)
        End Select
        Dim win = New Window With {.ID = "Win_EditarTipoLugar", _
                                    .Width = Unit.Pixel(330), _
                                    .Height = Unit.Pixel(160), _
                                    .Title = titulo, _
                                    .Modal = True, _
                                    .AutoRender = False, _
                                    .Collapsible = False, _
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmEditarTipoLugar.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
End Class