Imports Ext.Net
Public Class frmAsiento
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        fLlenarCuenta()
        fLlenarComprobante()
        fLlenarAnio()
        fLlenarMes()
        fllenarTabla()


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


    <DirectMethod>
    Private Sub fllenarTabla()
        Try
            Dim accesoDatos As New clsControladorAsientoCuenta
            stTemporal.DataSource = accesoDatos.fllenarTablaTemporal
            stTemporal.DataBind()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    <DirectMethod>
    Public Function fGuardar() As Integer
        Dim v_respuesta As Int16
        Try
            If Me.ComboCuenta.Text <> "" Then

                Dim v_acceso As New clsControladorAsientoCuenta

                v_respuesta = v_acceso.fIngresarAsientoTemporal(Me.ComboCuenta.Value, txtDebe.Text, txtHaber.Text)
                Ext.Net.X.Msg.Notify("Guardando Información", "EXITOSO!! El registro fue guardado.").Show()

                Me.txtDebe.Text = "0.00"
                Me.txtHaber.Text = "0.00"

                Call fllenarTabla()

            End If



        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error", "Error al Guardar Información...").Show()
        End Try



        Return v_respuesta
    End Function


    <DirectMethod>
    Public Function fGuardar2() As Integer
        Dim v_respuesta As Int16
        Try
            If Me.ComboCuenta.Text <> "" Then

                Dim v_acceso As New clsControladorAsientoCuenta

                v_respuesta = v_acceso.fIngresarAsientoTemporal(Me.ComboAnio.Value, Me.ComboMes.Value, Session("idempleado"))
                Ext.Net.X.Msg.Notify("Guardando Información", "EXITOSO!! El registro fue guardado.").Show()

                Me.txtDebe.Text = "0.00"
                Me.txtHaber.Text = "0.00"

                Call fllenarTabla()

            End If



        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error", "Error al Guardar Información...").Show()
        End Try



        Return v_respuesta
    End Function






End Class