Imports Ext.Net
Public Class frmPeriodoContable
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarGrid()

    End Sub


#Region "Metodos Directos"
    <DirectMethod> _
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorPeriodo
        stPeriodoConta.DataSource = v_datos.fListarPeriodoConta
        stPeriodoConta.DataBind()
    End Sub


    <DirectMethod> _
    Public Function fGuardar() As Integer
        Dim v_respuesta As Int16
        Try
            If Me.fechaInicio.Text <> "" Then

                Dim v_acceso As New clsControladorPeriodo
                v_respuesta = v_acceso.fIngresarPeriodo(Aniotxt.Value, fechaInicio.Value, fechaFinal.Value)
                Ext.Net.X.Msg.Notify("Guardando Información", "EXITOSO!! El registro fue guardado.").Show()
                fLlenarGrid()

            Else
                Ext.Net.X.Msg.Notify("Error", "Error al Guardar Información...").Show()
            End If

        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error", "Error al Guardar Información...").Show()
        End Try
        Return v_respuesta
    End Function


    <DirectMethod> _
    Public Function fModificarPeriodo(ByVal ANIO As Int16, ByVal IDMES As Int16, ByVal DESDE As Date, ByVal HASTA As Date, ByVal INICIO As Date, ByVal FIN As Date) As Integer


        Dim v_respuesta As Int16
        Try
            Dim v_acceso As New clsControladorPeriodo
            v_respuesta = v_acceso.fModificarPeriodo(ANIO, IDMES, DESDE, HASTA, INICIO, FIN)
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