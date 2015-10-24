Imports Ext.Net
Public Class frmEditarProveedor
    Inherits System.Web.UI.Page
#Region "Variables Globales"
    Private _idProveedor As Long
    Private _accion As Int16
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fobtenerValoresQuerystring()

        Select Case _accion
            Case clsComunes.Operacion_Registro.Editar
                If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
                    fObtenerProveedor()
                End If
        End Select
    End Sub

#Region "Metodos Privados"
    Private Sub fObtenerProveedor()
        Dim v_acceso As New clsControladorProveedor
        Dim dt As New DataTable
        dt = v_acceso.fObtenerProveedor(_idProveedor)
        For Each r As DataRow In dt.Rows
            txtidproveedor.Text = r(0).ToString
            txtAgente.Text = r(1).ToString
            txtEmpNombre.Text = r(2).ToString
            txtEmpDireccion.Text = r(3).ToString
            txtNit.Text = r(4).ToString
            txtTelAgente.Text = r(5).ToString()
            txtTelEmp1.Text = r(6).ToString
            txtTelEmp2.Text = r(7).ToString

        Next
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
    <DirectMethod> _
    Public Function fGuardar() As Integer
        Dim v_respuesta As Int16
        Dim v_acceso As New clsControladorProveedor
        Select Case _accion
            Case clsComunes.Operacion_Registro.Nuevo
                v_respuesta = v_acceso.fIngresarProveedor(txtAgente.Text, txtEmpNombre.Text, txtEmpDireccion.Text, txtNit.Text, txtTelAgente.Text, txtTelEmp1.Text, txtTelEmp2.Text)
            Case clsComunes.Operacion_Registro.Editar
                v_respuesta = v_acceso.fModificarProveedor(_idProveedor, txtAgente.Text, txtEmpNombre.Text, txtEmpDireccion.Text, txtNit.Text, txtTelAgente.Text, txtTelEmp1.Text, txtTelEmp2.Text)
        End Select
        Return v_respuesta
    End Function
#End Region
End Class