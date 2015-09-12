Imports Ext.Net
Public Class frmEditarCuentas
    Inherits System.Web.UI.Page



#Region "Variables Globales"
    Private _idCuenta As Long
    Private _accion As Int16
#End Region





    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fobtenerValoresQuerystring()

        Select Case _accion
            Case clsComunes.Operacion_Registro.Editar
                If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
                    fObtenerCuenta()
                End If
        End Select
    End Sub


#Region "Metodos Privados"
    Private Sub fObtenerCuenta()
        Dim v_acceso As New clsControladorCuentas
        Dim dt As New DataTable
        dt = v_acceso.fObtenerCuenta(_idCuenta)
        For Each r As DataRow In dt.Rows
            txtidCuenta.Text = r(0).ToString
            txtCodigo.Text = r(1).ToString

        Next
    End Sub

    Private Sub fobtenerValoresQuerystring()
        Try
            If Request.QueryString.AllKeys.Contains("codigo") Then
                _idCuenta = Long.Parse(Request.QueryString("codigo").ToString)
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
    <DirectMethod> _
    Public Function fGuardar() As Integer
        Dim v_respuesta As Int16
        Dim v_acceso As New clsControladorCuentas
        Select Case _accion
            Case clsComunes.Operacion_Registro.Nuevo
                v_respuesta = v_acceso.fIngresarCuenta(txtCodigo.Text)
            Case clsComunes.Operacion_Registro.Editar
                v_respuesta = v_acceso.fModificarCuenta(_idCuenta, txtCodigo.Text)
        End Select
        Return v_respuesta
    End Function
#End Region



End Class