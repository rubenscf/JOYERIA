Imports Ext.Net
Public Class frmParametros
    Inherits System.Web.UI.Page

#Region "Variables Globales"
    Private _id As Long
    Private _accion As Int16
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If

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
        Try
            If Me.txtDescripcion.Text <> "" Then
                If Me.txtPorcentaje.Text <> "" Then

                    Dim v_acceso As New clsControladorParametros

                    v_respuesta = v_acceso.fIngresarParametro(txtDescripcion.Text, txtPorcentaje.Value)
                    Ext.Net.X.Msg.Notify("Guardando Información", "EXITOSO!! El registro fue Modificado.").Show()
                    txtDescripcion.Clear()
                    txtPorcentaje.Clear()
                    Call fLlenarGrid()

                End If
            Else

            End If


        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error", "Error al Guardar Información...").Show()
        End Try

        

        Return v_respuesta
    End Function


    <DirectMethod> _
    Public Function fModificarParametro(ByVal CODIGO As Integer, ByVal NOMBRE As String, ByVal PORCENTAJE As Decimal) As Integer
        Dim v_respuesta As Int16


        Dim v_acceso As New clsControladorParametros

        v_respuesta = v_acceso.fModificarParametro(CODIGO, NOMBRE, PORCENTAJE)
        Ext.Net.X.Msg.Notify("Guardando Información", "EXITOSO!! El registro fue guardado.").Show()
        Call fLlenarGrid()

        Return v_respuesta
    End Function

#End Region

End Class