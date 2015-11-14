Imports Ext.Net
Public Class frmDiario
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fLlenarAnio()
        fLlenarMes()


        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If

    End Sub

    <DirectMethod>
    Public Sub fVerDiario()



        If ComboAnio.Text <> "" And ComboMes.Text <> "" Then

            Dim v_datos As New clsControladorAsientoCuenta
            stDiario.DataSource = v_datos.fVerDiario(ComboAnio.Value, ComboMes.Value)
            stDiario.DataBind()


        Else

        End If


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