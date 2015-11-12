
Imports Ext.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmEnvio
    Inherits System.Web.UI.Page
#Region "Variables Globales"
    Private _accion As Int16
    Private _idProveedor As Long
    Private _idFamilia As Long
    Private _idMaterial As Long
    Private _idModelo As String
    Private _Producto As String
    Private _idtipo As String
    Private _precioCompra As Decimal
    Private _precioVenta As Decimal
    Private _estado As String
#End Region




    Private Sub fEstablecerValoresIniciales()
        fllenartipo()
        cmbTipo.SelectedItem.Value = _idtipo

    End Sub

    Public Sub fllenartipo()

        Try
            Dim v_datos As New clsControladorProcedimientos
            stTipo.DataSource = v_datos.fListartipo
            stTipo.DataBind()
        Catch ex As Exception
            Ext.Net.X.Msg.Alert("ERROR", ex.Message).Show()
        End Try

    End Sub
    Private Sub fobtenerValoresQuerystring()

        If Request.QueryString.AllKeys.Contains("lu_tipo") Then
            _idtipo = Long.Parse(Request.QueryString("lu_tipo").ToString)
        End If


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            btnAgregar.Enable(False)
            txtCant.Value = 1
            fllenartipo()

            fllenarGrid()
        End If
    End Sub

#Region "Metodos Directo"
    <DirectMethod>
    Public Sub fQuitar()

        txtModelo.ReadOnly = False
        txtFamilia.ReadOnly = False
        txtMaterial.ReadOnly = False
        txtProducto.ReadOnly = False
        txtModelo.Text = ""
        txtFamilia.Text = ""
        txtMaterial.Text = ""
        txtProducto.Text = ""
        txtPercio.Text = ""

    End Sub
    <DirectMethod>
    Public Sub BuscarInventario(ByVal p_modelo As String, ByVal p_famila As String, ByVal p_material As String, ByVal producto As String)
        Dim titulo As String = "Buscar Modelos"
        Dim queryString As String = ""
        queryString &= ("&lugar=" & CStr(Session("idlugar")))
        queryString &= ("&modelo=" & p_modelo)
        queryString &= ("&familia=" & p_famila)
        queryString &= ("&material=" & p_material)
        queryString &= ("&producto=" & producto)

        Dim win = New Window With {.ID = "Win_BuscarInvetario",
                                    .Width = Unit.Pixel(830),
                                    .Height = Unit.Pixel(450),
                                    .Title = titulo,
                                    .Modal = True,
                                    .AutoRender = False,
                                    .Collapsible = False,
                                    .Maximizable = False}
        win.Loader = New ComponentLoader
        win.Loader.Url = "../Buscar/frmInventarios.aspx?" & queryString
        win.Loader.Mode = LoadMode.Frame
        win.Loader.LoadMask.ShowMask = True
        win.Loader.LoadMask.Msg = "Espere un momento..."
        win.Render(True)
        win.Show()
    End Sub
    <DirectMethod>
    Public Sub fSeleccionar(ByVal fila As String)
        Dim p As New JObject

        Try
            p = JsonConvert.DeserializeObject(Of Object)(fila)
            ' Dim dt As New DataTable
            txtPercio.Text = p.Item("PRECIO_VENTA").ToString
            txtModelo.Text = p.Item("IDPR_MODELO").ToString
            txtFamilia.Text = p.Item("FAMILIA").ToString
            txtMaterial.Text = p.Item("MATERIAL").ToString
            txtProducto.Text = p.Item("PRODUCTO").ToString
            txtCant.MaxValue = CInt(p.Item("STOCK").ToString)
            txtModelo.ReadOnly = True
            txtFamilia.ReadOnly = True
            txtMaterial.ReadOnly = True
            txtProducto.ReadOnly = True
            btnAgregar.Enable(True)
            Ext.Net.X.MessageBox.Notify("Operacion", "Producto Agregado").Show()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Sub fllenarGrid()
        Dim acceso As New clsDetallesTemporales
        Try
            Dim dt As New DataTable
            Dim SUBT As Decimal = 0
            dt = acceso.fListar("ventas", Session("idempleado"))
            stDG.DataSource = dt
            stDG.DataBind()
            For Each f As DataRow In dt.Rows
                SUBT += CDec(f("SUBTOTAL"))
            Next
            txtTotal.Value = SUBT
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
    End Sub
    <DirectMethod>
    Public Function fInsertar() As Integer
        Dim acceso As New clsDetallesTemporales
        Try
            acceso.fInsertar("ventas", Session("idempleado"), txtModelo.Text, CDbl(txtCant.Value), CDec(txtPercio.Text))
            Ext.Net.X.MessageBox.Notify("Operacion", "Producto Insertado").Show()
            fQuitar()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
        Return 1
    End Function
    <DirectMethod>
    Public Function fEliminar(ByVal modelo As String) As Integer
        Dim acceso As New clsDetallesTemporales
        Try
            acceso.fElimina("ventas", Session("idempleado"), modelo)
            Ext.Net.X.MessageBox.Notify("Operacion", "Producto Eliminado").Show()
            fQuitar()
        Catch ex As Exception
            Ext.Net.X.MessageBox.Notify("Error", ex.Message).Show()
        End Try
        Return 1
    End Function

#End Region




End Class