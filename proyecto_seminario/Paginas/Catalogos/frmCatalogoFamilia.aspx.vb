Imports Ext.Net
Public Class frmFamilia

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idtipolugar")) > 2 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
    End Sub
    <DirectMethod>
    Public Sub fLlenarGrid()
        Try
            Dim acceso As New clsControladorProcedimientos
            stCatalogoFamilia.DataSource = acceso.fListarFamiliaes()
            stCatalogoFamilia.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Notify(" ThenError Inesperado", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Function fNuevaFamilia() As Integer
        Dim r As Integer
        Try
            Dim acceso As New clsControladorProcedimientos
            If txtFamilia.Text <> "" Then
                If acceso.fInsertarFamilia(txtFamilia.Text) = clsComunes.Respuesta_Operacion.Guardado Then
                    txtFamilia.Text = ""
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
    Public Function fModificarFamilia(ByVal id As Long, ByVal nombre As String) As String
        Dim r As Integer
        Try
            Dim acceso As New clsControladorProcedimientos
            If acceso.fActualizarFamilia(id, nombre) = clsComunes.Respuesta_Operacion.Modificado Then
                r = clsComunes.Respuesta_Operacion.Modificado
                fLlenarGrid()
            End If

        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()

        End Try
        Return r
    End Function

End Class