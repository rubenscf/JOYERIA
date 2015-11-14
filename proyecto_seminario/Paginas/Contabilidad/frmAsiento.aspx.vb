Imports Ext.Net
Public Class frmAsiento
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        fLlenarCuenta()
        fLlenarComprobante()
        fLlenarAnio()
        fLlenarMes()


    End Sub






    Private Sub fLlenarCuenta()
        Try
            Dim accesoDatos As New clsControladorAsientoCuenta
            stCuenta.DataSource = accesoDatos.fListarAsientoCuenta
            stCuenta.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Private Sub fLlenarComprobante()
        Try
            Dim accesoDatos As New clsControladorAsientoCuenta
            stComprobante.DataSource = accesoDatos.fListarAsientoComprobante
            stComprobante.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Private Sub fLlenarAnio()
        Try
            Dim accesoDatos As New clsControladorAsientoCuenta
            stAnio.DataSource = accesoDatos.fListarAsientoAnio
            stAnio.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub fLlenarMes()
        Try
            Dim accesoDatos As New clsControladorAsientoCuenta
            stMes.DataSource = accesoDatos.fListarMes
            stMes.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



End Class