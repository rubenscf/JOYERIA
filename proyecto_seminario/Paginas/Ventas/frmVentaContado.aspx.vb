
Imports Ext.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frm_VentaContado
    Inherits System.Web.UI.Page
    Dim _producto As New ArrayList
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack And Not Ext.Net.X.IsAjaxRequest Then
            btnAgregar.Enable(False)
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
        If _producto.Count > 0 Then
            _producto.Clear()
        End If
        Try
            p = JsonConvert.DeserializeObject(Of Object)(fila)
            ' Dim dt As New DataTable
            _producto.Add(p.Item("IDLUGAR").ToString)
            _producto.Add(p.Item("STOCK").ToString)
            _producto.Add(p.Item("IDPR_MODELO").ToString)
            _producto.Add(p.Item("FAMILIA").ToString)
            _producto.Add(p.Item("MATERIAL").ToString)
            _producto.Add(p.Item("PRODUCTO").ToString)
            _producto.Add(p.Item("PRECIO_COMPRA").ToString)
            _producto.Add(p.Item("PRECIO_VENTA").ToString)
            _producto.Add(p.Item("ESTADO").ToString)
            txtModelo.Text = _producto.Item(2)
            txtFamilia.Text = _producto.Item(3)
            txtMaterial.Text = _producto.Item(4)
            txtProducto.Text = _producto.Item(5)
            txtCant.MaxValue = CInt(_producto.Item(1))
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
    Public Sub fAgregar()
        'Dim NoExiste As Boolean = True
        'Dim dt As New DataTable
        'dt = stDG.DataSource
        'If IsNothing(dt) Then
        '    dt.Columns.Add("IDPR_MODELO")
        '    dt.Columns.Add("CANT")
        '    dt.Columns.Add("PROVEEDOR")
        '    dt.Columns.Add("FAMILIA")
        '    dt.Columns.Add("MATERIAL")
        '    dt.Columns.Add("PRODUCTO")
        '    dt.Columns.Add("P_COMPRA")
        '    dt.Columns.Add("P_VENTA")
        '    dt.Columns.Add("SUBTOTAL")

        '    dt.Rows.Add(j.Item("IDPR_MODELO").ToString, 1, j.Item("PROVEEDOR").ToString, j.Item("FAMILIA").ToString, j.Item("MATERIAL").ToString, j.Item("PRODUCTO").ToString, j.Item("PRECIO_COMPRA").ToString, j.Item("PRECIO_VENTA").ToString, 2)
        'Else
        '    For Each f As DataRow In dt.Rows
        '        If f(0).ToString = j(0).ToString Then
        '            NoExiste = False
        '            f(1) = CInt(f(1)) + CInt(j.Item(0).ToString)
        '            '   f(8) = CInt(f(1)) * CDec(fila(7))
        '        End If
        '    Next
        'End If

        'If NoExiste Then

        'End If

        'stDG.DataSource = dt
        'stDG.DataBind()
    End Sub
#End Region




End Class