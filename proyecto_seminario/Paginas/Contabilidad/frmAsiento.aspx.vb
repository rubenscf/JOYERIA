Imports Ext.Net
Public Class frmAsiento
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarCuenta()
    End Sub
    Private Sub fLlenarCuenta()
        Try
            Dim accesoDatos As New clsControladorAsientoCuenta


            stCuentaAsiento.DataSource = accesoDatos.fListarAsientoCuenta
            stCuentaAsiento.DataBind()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub
End Class