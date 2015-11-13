Imports Ext.Net
Public Class frmAsiento
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fLlenarCuenta()
    End Sub
    Private Sub fLlenarCuenta()
        Try
            Dim accesoDatos As New clsControladorAsientoCuenta


            '  stCuentasAsientoConta.DataSource = accesoDatos.fListarAsientoCuenta
            '  stCuentasAsientoConta.DataBind()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub
End Class