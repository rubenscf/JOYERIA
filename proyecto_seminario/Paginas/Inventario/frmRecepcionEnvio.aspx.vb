Imports Ext.Net
Public Class frmRecepcionEnvio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) < 3 And CInt(Session("idpuesto")) > 10 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fllenarGrid()

        End If

    End Sub
    <DirectMethod>
    Public Function fAnular(ByVal sale As String, ByVal tipo As String, ByVal idenvio As String, ByVal version As String) As Integer

        Try
            Dim acceso As New clsControladorProcedimientos
            If clsComunes.Respuesta_Operacion.Guardado = acceso.fAnularEnvio(sale, tipo, idenvio, Session("idusuario"), ("idlugar"), version) Then
                Ext.Net.X.MessageBox.Alert("Operacion", "Envio Anulado").Show()
            End If


        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
        Return 1
    End Function
    <DirectMethod>
    Public Function fAceptar(ByVal sale As String, ByVal tipo As String, ByVal idenvio As String, ByVal version As String) As Integer
        Try
            Dim acceso As New clsControladorProcedimientos
            If clsComunes.Respuesta_Operacion.Guardado = acceso.fAceptarEnvioEntrante(sale, Now, tipo, idenvio, Session("idempleado"), Session("idlugar")) Then
                Ext.Net.X.MessageBox.Alert("Operacion", "Envio Recibido").Show()
            End If
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
        Return 1
    End Function
    <DirectMethod>
    Public Sub fllenarGrid()
        Try
            Dim acceso As New clsControladorProcedimientos
            stEnvio.DataSource = acceso.fListarEnviosEntrantes(Session("idlugar"))
            stEnvio.DataBind()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Sub fllenarDetalle(ByVal sale As String, ByVal tipo As String, ByVal idenvio As String, ByVal version As String)
        Try
            Dim acceso As New clsControladorProcedimientos
            stDetalleEnvio.DataSource = acceso.fListarDetalleEnvio(sale, tipo, Session("idlugar"), idenvio, version)
            stDetalleEnvio.DataBind()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
    End Sub

End Class