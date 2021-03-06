﻿Imports Ext.Net
Public Class frmEditarCuentas
    Inherits System.Web.UI.Page



#Region "Variables Globales"
    Private _idCuenta As Long
    Private _accion As Int16
    Private _mayoriza As String
#End Region





    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cls As New clsComunes
        If CInt(Session("idpuesto")) > 4 Then
            Response.Redirect(cls.Pagina_Acceso_Denegado)

        End If

        fLlenarTipoCuenta()
        fLlenarCuentaMayorizar()
        Select Case _accion
            Case clsComunes.Operacion_Registro.Editar
                If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then

                End If
        End Select
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
    Public Function fGuardar() As Integer

        If Me.chkMayor.Checked = False Then
            _mayoriza = Me.txtCodigo.Text
        ElseIf Me.chkMayor.Checked = True Then
            _mayoriza = Me.cboMayoriza.Value

        End If
        Dim v_respuesta As Int16
        Dim v_acceso As New clsControladorCuentas

        v_respuesta = v_acceso.fIngresarCuenta(txtCodigo.Text, cboTipo_cta.Value, txtNombreCTA.Text, _mayoriza, txtNivel.Text, cboSumariza_cta.Text, cboMovimiento.Text, cboAjusta.Text)
        Return v_respuesta
    End Function
#End Region


 




End Class