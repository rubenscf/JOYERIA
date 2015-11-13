Imports Ext.Net
Public Class frmCatalogoCuentas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If
        fLlenarGrid()
        fLlenarCuentaMayorizar()
        fLlenarTipoCuenta()
    End Sub
    Private Sub fLlenarTipoCuenta()
        Try
            Dim accesoDatos As New clsControladorTipoCuenta

            stTipoCuenta.DataSource = accesoDatos.fListarTipoCuenta
            stTipoCuenta.DataBind()

        Catch ex As Exception
            Throw ex
        End Try


    End Sub
    Private Sub fLlenarCuentaMayorizar()
        Try
            Dim accesoDatos As New clsControladorCuentas
            stMayoriza.DataSource = accesoDatos.fListarMayorizar
            stMayoriza.DataBind()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Metodos Directos"
    <DirectMethod> _
    Public Sub fLlenarGrid()
        Dim v_datos As New clsControladorCuentas
        stCuenta.DataSource = v_datos.fListarCuenta
        stCuenta.DataBind()
    End Sub
    <DirectMethod> _
    Public Sub fcrearVentanaCuentas(ByVal p_accion As Int16, ByVal p_id As Int16)
        Dim titulo As String = ""
        Dim queryString As String = ""
        Select Case p_accion
            Case clsComunes.Operacion_Registro.Nuevo
                titulo = "Crear nueva Cuenta "
                queryString = ""
                queryString &= ("&accion=" & p_accion)
            Case clsComunes.Operacion_Registro.Editar
                titulo = "Modificar Cuenta "
                queryString = ""
                queryString &= ("&codigo=" & p_id)
                queryString &= ("&accion=" & p_accion)
        End Select
        Dim win = New Window With {.ID = "Win_EditarCuentas", _
                                    .Width = Unit.Pixel(500), _
                                    .Height = Unit.Pixel(380), _
                                    .Title = titulo, _
                                    .Modal = True, _
                                    .AutoRender = False, _
                                    .Collapsible = False, _
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "frmEditarCuentas.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
#End Region

    <DirectMethod> _
    Public Function fModificarPlanCuenta(ByVal CODIGO As String, ByVal TIPO As Int16, ByVal NOMBRE As String, ByVal MAY As String, ByVal NIVEL As Int16, ByVal SUMARIZA As String, ByVal MOV As String, ByVal AJUSTE As String) As Integer


        Dim v_respuesta As Int16
        Try
            Dim v_acceso As New clsControladorCuentas
            v_respuesta = v_acceso.fModificarCuenta(CODIGO, TIPO, NOMBRE, MAY, NIVEL, SUMARIZA, MOV, AJUSTE)
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


End Class