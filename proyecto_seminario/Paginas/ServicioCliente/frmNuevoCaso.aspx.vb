Imports Ext.Net

Public Class frmNuevoCaso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fListarTipoCaso()
        End If

    End Sub

#Region "Metodos Privados"

    Private Sub fListarTipoCaso()
        Dim v_acceso As New clsControladorProcedimientos

        stListarTipoCaso.DataSource = v_acceso.fListarTipoCaso
        stListarTipoCaso.DataBind()

    End Sub

#End Region

#Region "Metodos Directos"
    <DirectMethod>
    Public Function fGuardar() As Integer
        Dim v_respuesta As Int16
        Dim v_acceso As New clsControladorProcedimientos
        Dim v_correo As New clsControladorCorreo
        v_respuesta = v_acceso.fInsertarNuevoCaso(cmbDepartamento.SelectedItem.Value, 1, txttiluto.Text, txtdetalle.Text)
        v_correo.Enviar_Correo("j-maldonado91@hotmail.com", txttiluto.Text, txtdetalle.Text)
        Return v_respuesta
    End Function
#End Region
End Class