Imports Ext.Net
Public Class frmInventario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 6 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fLlenarLugar()
            If Session("idtipolugar") > 1 And Session("idtipolugar") < 4 Then
                cmbLugar.SelectedItem.Value = Session("idlugar")
                cmbLugar.ReadOnly = True
            Else
                cmbLugar.SelectedItem.Index = 0
            End If
            cmbTipo.SelectedItem.Index = 0
                fLlenarGrid()
            End If


    End Sub
#Region "Metodo Directos"
    <DirectMethod>
    Public Sub fLlenarGrid()

        Try
            Titulo.Text = "Inventario de  " + CStr(Session("lugar"))

            Dim v_datos As New clsControladorProcedimientos
            stInventario.DataSource = v_datos.fListarInventario(cmbLugar.SelectedItem.Value, cmbTipo.SelectedItem.Value)
            stInventario.DataBind()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try


    End Sub
    Private Sub fLlenarLugar()

        Try

            Dim v_datos As New clsControladorProcedimientos
            stLugar.DataSource = v_datos.fListarLugarInventario()
            stLugar.DataBind()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try


    End Sub
#End Region


End Class