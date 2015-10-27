
Public Class ctrlBuscarModelo
    Inherits System.Web.UI.UserControl

#Region "Variables Globales"

    Private _Proveedor As String = "%%"
    Private _Familia As String = "%%"
    Private _Material As String = "%%"
    Private _idModelo As String = "%%"
    Private _Producto As String = "%%"
    Private _estado As String
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fobtenerValoresQuerystring()
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fLlenarGrid()
        End If
    End Sub

    Public Sub fLlenarGrid()
        Try
            Dim v As New clsControladorProcedimientos
            stProductos.DataSource = v.fListarProductos(_Proveedor, _Familia, _Material, _Producto)
            stProductos.DataBind()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
    End Sub

    Private Sub fobtenerValoresQuerystring()
        If Request.QueryString.AllKeys.Contains("proveedor") Then
            _Proveedor = "%" + CStr(Request.QueryString("proveedor").ToString) + "%"
        End If
        If Request.QueryString.AllKeys.Contains("familia") Then
            _Familia = "%" + CStr(Request.QueryString("familia").ToString) + "%"
        End If
        If Request.QueryString.AllKeys.Contains("material") Then
            _Material = "%" + CStr(Request.QueryString("material").ToString) + "%"
        End If
        If Request.QueryString.AllKeys.Contains("idmodelo") Then
            _idModelo = "%" + CStr(Request.QueryString("idmodelo").ToString) + "%"
        End If
        If Request.QueryString.AllKeys.Contains("producto") Then
            _Producto = "%" + CStr(Request.QueryString("producto").ToString) + "%"
        End If
        If Request.QueryString.AllKeys.Contains("estado") Then
            _estado = CStr(Request.QueryString("estado").ToString)
        End If
    End Sub
End Class