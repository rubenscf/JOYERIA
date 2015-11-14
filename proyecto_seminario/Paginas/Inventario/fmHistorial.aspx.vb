Public Class fmHistorial
    Inherits System.Web.UI.Page
#Region "Variables Globales"
    Private idlugar As String
    Private idpr_modelo As String
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fobtenerValoresQuerystring()
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fllenargrid()
        End If
    End Sub



    Private Sub fobtenerValoresQuerystring()

        If Request.QueryString.AllKeys.Contains("lugar") Then
            idlugar = Request.QueryString("lugar").ToString
        End If
        If Request.QueryString.AllKeys.Contains("modelo") Then
            idpr_modelo = Request.QueryString("modelo").ToString
        End If

    End Sub





    Sub fllenargrid()

        Try
            Dim v As New clsControladorProcedimientos
            stHistorial.DataSource = v.fListarHistorialProducto(idlugar, idpr_modelo)
            stHistorial.DataBind()
            Dim dt As New DataTable
            dt = stHistorial.DataSource
            idpr_modelo = ""
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try

    End Sub

End Class