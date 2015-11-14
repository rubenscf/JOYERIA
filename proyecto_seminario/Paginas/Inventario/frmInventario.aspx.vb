Imports Ext.Net
Public Class frmInventario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 10 Then
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


    <DirectMethod>
    Public Sub fHistorial(ByVal idlugar As String, ByVal idpr_modelo As String)
        Dim titulo As String = "Historial Producto"
        Dim queryString As String = ""
        queryString &= ("lugar=" & idlugar)
        queryString &= ("&modelo=" & idpr_modelo)

        Dim win = New Window With {.ID = "Win_EditarProducto",
                                    .Width = Unit.Pixel(1100),
                                    .Height = Unit.Pixel(500),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "fmHistorial.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub


End Class