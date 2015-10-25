Imports Ext.Net
Public Class frmMaterial

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarGrid()
    End Sub
    <DirectMethod>
    Public Sub fLlenarGrid()
        Try
            Dim acceso As New clsControladorProcedimientos
            stCatalogoMaterial.DataSource = acceso.fListarMaterial()
            stCatalogoMaterial.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Function fNuevoMaterial() As Integer
        Dim r As Integer
        Try
            Dim acceso As New clsControladorProcedimientos
            If txtMaterial.Text <> "" Then
                If acceso.fInsertarMaterial(txtMaterial.Text) = clsComunes.Respuesta_Operacion.Guardado Then
                    txtMaterial.Text = ""
                    r = clsComunes.Respuesta_Operacion.Guardado
                End If
            End If
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()
            r = clsComunes.Respuesta_Operacion.Erronea
        End Try
        Return r
    End Function
    <DirectMethod>
    Public Function fModificarMaterial(ByVal id As Long, ByVal nombre As String) As String
        Dim r As Integer
        Try
            Dim acceso As New clsControladorProcedimientos
            If acceso.fActualizarMaterial(id, nombre) = clsComunes.Respuesta_Operacion.Modificado Then
                r = clsComunes.Respuesta_Operacion.Modificado
                fLlenarGrid()
            End If

        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()

        End Try
        Return r
    End Function

End Class