Imports Ext.Net
Public Class frmEditarModelo
    Inherits System.Web.UI.Page
#Region "Variables Globales"
    Private _accion As Int16
    Private _idProveedor As Long
    Private _idFamilia As Long
    Private _idMaterial As Long
    Private _idModelo As String
    Private _Producto As String
    Private _precioCompra As Decimal
    Private _precioVenta As Decimal
    Private _estado As String
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idtipolugar")) > 2 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fobtenerValoresQuerystring()

        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
                    fEstablecerValoresIniciales()
                End If

    End Sub
    Private Sub fobtenerValoresQuerystring()

        If Request.QueryString.AllKeys.Contains("proveedor") Then
            _idProveedor = Long.Parse(Request.QueryString("proveedor").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("familia") Then
            _idFamilia = Long.Parse(Request.QueryString("familia").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("material") Then
            _idMaterial = Long.Parse(Request.QueryString("material").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("modelo") Then
            _idModelo = CStr(Request.QueryString("modelo").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("producto") Then
            _Producto = CStr(Request.QueryString("producto").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("pcompra") Then
            _precioCompra = Decimal.Parse(Request.QueryString("pcompra").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("pventa") Then
            _precioVenta = Decimal.Parse(Request.QueryString("pventa").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("estado") Then
            _estado = CStr(Request.QueryString("estado").ToString)
        End If
        If Request.QueryString.AllKeys.Contains("accion") Then
            _accion = Int16.Parse(Request.QueryString("accion").ToString)
        End If

    End Sub
    Private Sub fEstablecerValoresIniciales()
        fllenarProveedor()
        fllenarFamilia()
        fllenarMaterial()
        cmbProveedor.SelectedItem.Value = _idProveedor
        cmbFamila.SelectedItem.Value = _idFamilia
        cmbMaterial.SelectedItem.Value = _idMaterial
        txtCodigo.Text = _idModelo
        txtModelo.Text = _Producto
        txtPrecioC.Value = _precioCompra
        txtPrecioV.Value = _precioVenta
    End Sub
    Private Sub fllenarProveedor()
        Try
            Dim v_datos As New clsControladorProcedimientos
            stProveedores.DataSource = v_datos.fListarProveedores
            stProveedores.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Alert("ERROR", ex.Message).Show()
        End Try

    End Sub
    Private Sub fllenarFamilia()
        Try
            Dim v_datos As New clsControladorProcedimientos
            stFamilia.DataSource = v_datos.fListarFamiliaes
            stFamilia.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Alert("ERROR", ex.Message).Show()
        End Try
    End Sub
    Private Sub fllenarMaterial()
        Try
            Dim v_datos As New clsControladorProcedimientos
            stMaterial.DataSource = v_datos.fListarMaterial
            stMaterial.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Alert("ERROR", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Function fGuardar() As Integer
        Dim v_respuesta As Integer
        Dim v_acceso As New clsControladorProcedimientos
        Select Case _accion
            Case clsComunes.Operacion_Registro.Nuevo
                v_respuesta = v_acceso.fInsertarModelo(cmbProveedor.SelectedItem.Value, cmbMaterial.SelectedItem.Value, cmbFamila.SelectedItem.Value, txtCodigo.Text, txtModelo.Text, txtPrecioC.Value, txtPrecioV.Value, "ACTIVO", 1)
            Case clsComunes.Operacion_Registro.Editar
                v_respuesta = v_acceso.fActualizarModelo(_idModelo, cmbProveedor.SelectedItem.Value, cmbFamila.SelectedItem.Value, cmbMaterial.SelectedItem.Value, txtModelo.Text, txtPrecioC.Value, txtPrecioV.Value, "ACTIVO", 1)
        End Select
        Return v_respuesta
    End Function
End Class