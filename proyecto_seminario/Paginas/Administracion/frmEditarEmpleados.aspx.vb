Imports Ext.Net
Public Class frmEditarEmpleados
    Inherits System.Web.UI.Page

#Region "Variables Globales"
    Private _idempleado As Long
    Private _accion As Int16
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        fobtenerValoresQuerystring()

        Select Case _accion
            Case clsComunes.Operacion_Registro.Editar
                If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
                    'fObtenerEmpleado()
                End If
        End Select

    End Sub

#Region "Metodos Privados"
    'Private Sub fObtenerEmpleado()
    '    Dim v_acceso As New clsControladorProcedimientos
    '    Dim dt As New DataTable
    '    dt = v_acceso.fObtenerEmpleado(_idempleado)
    '    For Each r As DataRow In dt.Rows
    '        txtidempleado.Text = r(0).ToString
    '        txtp_IDLUGAR.Text = r(1).ToString
    '        txtp_IDLU_PUESTO.Text = r(2).ToString
    '        txtp_DPI.Text = r(3).ToString
    '        txtP_NOMBRE.Text = r(4).ToString
    '        txtP_NOMBRE1.Text = r(5).ToString
    '        txtP_APELLIDO.Text = r(6).ToString
    '        txtP_APELLIDO1.Text = r(7).ToString

    '        txtP_EXTENDIDA.Text = r(8).ToString
    '        txtP_NIT.Text = r(9).ToString
    '        txtP_SEXO.Text = r(10).ToString
    '        txtP_DIRECCION.Text = r(11).ToString
    '        txtP_TELEFONO.Text = r(12).ToString
    '        txtP_CONYUGUE.Text = r(13).ToString
    '        txtP_FECHANAC.Text = r(14).ToString
    '        txtP_ESTADO.Text = r(15).ToString

    '        txtP_ESTADO_CIVIL.Text = r(16).ToString
    '        txtP_NACIONALIDAD.Text = r(17).ToString
    '        txtP_VECINDAD.Text = r(18).ToString
    '        txtP_SUELDO_BASE.Text = r(19).ToString



    '    Next
    'End Sub

    Private Sub fobtenerValoresQuerystring()
        Try
            If Request.QueryString.AllKeys.Contains("idempleado") Then
                _idempleado = Long.Parse(Request.QueryString("idempleado").ToString)
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
    '  <DirectMethod> _
    'Public Function fGuardar() As Integer
    '    Dim v_respuesta As Int16
    '    Dim v_acceso As New clsControladorProcedimientos
    '    Select Case _accion
    '        Case clsComunes.Operacion_Registro.Nuevo
    '            v_respuesta = v_acceso.fInsertarEmpleado(txtp_IDLUGAR.Text, txtp_IDLU_PUESTO.Text, txtp_DPI.Text, txtP_NOMBRE.Text, txtP_NOMBRE1.Text, txtP_APELLIDO.Text, txtP_APELLIDO1.Text, txtP_EXTENDIDA.Text, txtP_NIT.Text, txtP_SEXO.Text, txtP_DIRECCION.Text,
    '            txtP_TELEFONO.Text, txtP_CONYUGUE.Text, txtP_FECHANAC.Text, txtP_ESTADO.Text, txtP_ESTADO_CIVIL.Text, txtP_NACIONALIDAD.Text, txtP_VECINDAD.Text, txtP_SUELDO_BASE.Text)

    '        Case clsComunes.Operacion_Registro.Editar
    '            v_respuesta = v_acceso.fActualizaEmpleado(_idempleado, txtp_IDLUGAR.Text, txtp_IDLU_PUESTO.Text, txtp_DPI.Text, txtP_NOMBRE.Text, txtP_NOMBRE1.Text, txtP_APELLIDO.Text, txtP_APELLIDO1.Text, txtP_EXTENDIDA.Text, txtP_NIT.Text, txtP_SEXO.Text, txtP_DIRECCION.Text,
    '            txtP_TELEFONO.Text, txtP_CONYUGUE.Text, txtP_FECHANAC.Text, txtP_ESTADO.Text, txtP_ESTADO_CIVIL.Text, txtP_NACIONALIDAD.Text, txtP_VECINDAD.Text, txtP_SUELDO_BASE.Text)
    '    End Select
    '    Return v_respuesta
    'End Function
#End Region

End Class