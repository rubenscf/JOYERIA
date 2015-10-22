Imports Ext.Net
Public Class frmParametros
    Inherits System.Web.UI.Page

#Region "Variables Globales"
    Private _id As Long
    Private _accion As Int16
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        fLlenarGrid()


    End Sub


    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorParametros
        stParametro.DataSource = v_datos.fListarParametro
        stParametro.DataBind()
    End Sub


#Region "Metodos Directos"
    <DirectMethod> _
    Public Function fGuardar() As Integer

        Dim v_respuesta As Int16
        Dim v_acceso As New clsControladorParametros
        Select Case _accion
            Case clsComunes.Operacion_Registro.Nuevo
                v_respuesta = v_acceso.fIngresarParametro(txtDescripcion.Text, txtPorcentaje.Text)
            Case clsComunes.Operacion_Registro.Editar
                v_respuesta = v_acceso.fModificarParametro(_id, txtDescripcion.Text, txtPorcentaje.Text)
        End Select
        Return v_respuesta
    End Function
#End Region

End Class