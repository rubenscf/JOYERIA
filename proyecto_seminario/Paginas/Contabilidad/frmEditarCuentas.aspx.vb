Imports Ext.Net
Public Class frmEditarCuentas
    Inherits System.Web.UI.Page



#Region "Variables Globales"
    Private _idCuenta As Long
    Private _accion As Int16
#End Region





    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        fobtenerValoresQuerystring()
        fLlenarTipoCuenta()

        Select Case _accion
            Case clsComunes.Operacion_Registro.Editar
                If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
                    fObtenerCuenta()
                End If
        End Select
    End Sub

    Private Sub fLlenarTipoCuenta()
        Try
            Dim accesoDatos As New clsControladorTipoCuenta

            stTipoCuenta.DataSource = accesoDatos.fListarTipoCuenta
            stTipoCuenta.DataBind()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub
#Region "Metodos Privados"
    Private Sub fObtenerCuenta()
        Dim v_acceso As New clsControladorCuentas
        Dim dt As New DataTable
        dt = v_acceso.fObtenerCuenta(_idCuenta)
        For Each r As DataRow In dt.Rows
            cboTipo_cta.Text = r(0).ToString
            txtCodigo_cta.Text = r(1).ToString
            txtNombre_cta.Text = r(2).ToString
            cboNivel_cta.Text = r(3).ToString
            cboSumariza_cta.Text = r(4).ToString

        Next
    End Sub

    Private Sub fprobar()
        Dim v_acceso As New clsControladorCuentas
        Dim dt As New DataTable
        dt = v_acceso._COMBO
        cboTipo_cta.DisplayField = "idtipo_cta"
        cboTipo_cta.ValueField = "nombre"
        cboTipo_cta.Data = dt
        cboTipo_cta.DataBind()
        MsgBox(cboTipo_cta.Value)


    End Sub


    Private Sub fobtenerValoresQuerystring()
        Try
            If Request.QueryString.AllKeys.Contains("codigo_cta") Then
                _idCuenta = Long.Parse(Request.QueryString("codigo_cta").ToString)
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
                v_respuesta = v_acceso.fIngresarCuenta(txtCodigo_cta.Text, cboTipo_cta.Value, txtNombre_cta.Text, cboNivel_cta.Value, cboSumariza_cta.Text)
            Case clsComunes.Operacion_Registro.Editar
                ' v_respuesta = v_acceso.fModificarCuenta(_idCuenta, txtCodigo.Text)
        End Select
        Return v_respuesta
    End Function
#End Region


 




End Class