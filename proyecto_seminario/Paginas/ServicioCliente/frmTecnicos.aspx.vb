Imports Ext.Net
Public Class frmTecnicos
    Inherits System.Web.UI.Page
    Dim _idcaso As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fobtenerValoresQuerystring()
        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            fllenarCombo()
        End If
    End Sub
    Private Sub fllenarCombo()
        Dim v As New clsControladorProcedimientos
        stTecnico.DataSource = v.fListarTecnicos()
        stTecnico.DataBind()
        cmbTecnico.SelectedItem.Index = 0
    End Sub
    Private Sub fobtenerValoresQuerystring()
        Try
            If Request.QueryString.AllKeys.Contains("caso") Then
                _idcaso = Request.QueryString("caso").ToString
            End If

        Catch ex As Exception
            Ext.Net.X.Msg.Alert("ERROR", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Function fGuardar() As Integer
        Dim v As New clsControladorProcedimientos
        Try
            v.fActualizarCaso(_idcaso, cmbTecnico.SelectedItem.Value)
            '       Ext.Net.X.Msg.Alert("Operacion", "Caso Asignado").Show()
        Catch ex As Exception
            Ext.Net.X.Msg.Alert("ERROR", ex.Message).Show()
        End Try
        Return 1

    End Function
End Class