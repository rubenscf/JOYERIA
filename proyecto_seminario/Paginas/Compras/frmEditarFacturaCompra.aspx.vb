Imports Ext.Net
Public Class frmEditarFacturaCompra
    Inherits System.Web.UI.Page
#Region "Variables Globales"
    Private _idProveedor As Long
    Private _accion As Int16
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) < 7 And CInt(Session("idpuesto")) > 10 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fobtenerValoresQuerystring()

        Select Case _accion
            Case clsComunes.Operacion_Registro.Editar
                If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
                    fObtenerFacturaCompra()
                End If
        End Select
    End Sub

#Region "Metodos Privados"
    Private Sub fObtenerFacturaCompra()

    End Sub

    Private Sub fobtenerValoresQuerystring()
        Try
            If Request.QueryString.AllKeys.Contains("codigo") Then
                _idProveedor = Long.Parse(Request.QueryString("codigo").ToString)
            End If
            If Request.QueryString.AllKeys.Contains("accion") Then
                _accion = Int16.Parse(Request.QueryString("accion").ToString)
            End If
        Catch ex As Exception
            Ext.Net.X.Msg.Alert("ERROR", ex.Message).Show()
        End Try
    End Sub
#End Region

#Region "Metodos Directos"
    <DirectMethod>
    Public Function fGuardar() As Integer
        Dim v_respuesta As Int16
        Dim v_acceso As New clsControladorProcedimientos
        Select Case _accion
            '' Case clsComunes.Operacion_Registro.Nuevo
            ''  v_respuesta = v_acceso.fInsertarProveedor(txtAgente.Text, txtEmpNombre.Text, txtEmpDireccion.Text, txtNit.Text, txtTelAgente.Text, txtTelEmp1.Text, txtTelEmp2.Text)
            '  Case clsComunes.Operacion_Registro.Editar
            ' v_respuesta = v_acceso.fActualizarProveedor(_idProveedor, txtAgente.Text, txtEmpNombre.Text, txtEmpDireccion.Text, txtNit.Text, txtTelAgente.Text, txtTelEmp1.Text, txtTelEmp2.Text)
        End Select
        Return v_respuesta
    End Function
#End Region
End Class