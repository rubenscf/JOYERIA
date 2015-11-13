Imports Ext.Net
Public Class frmInventario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 6 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then

            fLlenarGrid()
        End If


    End Sub
#Region "Metodo Directos"
    <DirectMethod>
    Public Sub fLlenarGrid()

        Try
            Titulo.Text = "Inventario de  " + CStr(Session("lugar"))

            Dim v_datos As New clsControladorProcedimientos
            stInventario.DataSource = v_datos.fListarInventario(CStr(Session("idlugar")), cmbTipo.SelectedItem.Value)
            stInventario.DataBind()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try


    End Sub
#End Region


End Class