Imports Ext.Net
Public Class frmTipoCuenta
    Inherits System.Web.UI.Page


#Region "Variables Globales"
    Private _id As Long
    Private _accion As Int16
    Private _descripcion As String
#End Region


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        fLlenarGrid()


    End Sub
#Region "Metodos Directos"
 

    <DirectMethod> _
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorTipoCuenta
        stTipoCuenta.DataSource = v_datos.fListarTipoCuenta
        stTipoCuenta.DataBind()
    End Sub


    <DirectMethod> _
    Public Function fGuardar() As Integer
        Dim v_respuesta As Int16
        Try
            If Me.txtDescripcion.Text <> "" Then


                Dim v_acceso As New clsControladorTipoCuenta

                v_respuesta = v_acceso.fIngresarTipoCuenta(txtDescripcion.Text)
                Ext.Net.X.Msg.Notify("Guardando Información", "EXITOSO!! El registro fue guardado.").Show()

                txtDescripcion.Clear()

                Call fLlenarGrid()

            End If
           


        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error", "Error al Guardar Información...").Show()
        End Try



        Return v_respuesta
    End Function


    <DirectMethod> _
    Public Function fModificarTipoCuenta(ByVal CODIGO As Integer, ByVal NOMBRE As String) As Integer


        Dim v_respuesta As Int16
        Try
            Dim v_acceso As New clsControladorTipoCuenta
            v_respuesta = v_acceso.fModificarTipoCuenta(CODIGO, NOMBRE)
            If v_respuesta = 2 Then
                Ext.Net.X.Msg.Notify("Guardando Información", "EXITOSO!! El registro fue Modificado.").Show()
                If v_respuesta <> 2 Then
                    Ext.Net.X.Msg.Notify("Error", "Error Información no Procesada...").Show()
                End If
            End If

            Call fLlenarGrid()
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error", "Error Información no Procesada...").Show()
        End Try


       

        Return v_respuesta
    End Function

#End Region


   

End Class