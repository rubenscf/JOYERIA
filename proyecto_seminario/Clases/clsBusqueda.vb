Public Class clsBusqueda
    Public Function fBuscarProductos(ByVal p_proveedor As String, ByVal p_familia As String,
                                     ByVal p_material As String, ByVal p_modelo As String) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spBuscarProducto]"
                .Parameters.Add("p_proveedor", SqlDbType.VarChar).Value = p_proveedor
                .Parameters.Add("p_familia", SqlDbType.VarChar).Value = p_familia
                .Parameters.Add("p_marca", SqlDbType.VarChar).Value = p_material
                .Parameters.Add("p_modelo", SqlDbType.VarChar).Value = p_modelo
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function

    Public Function fBuscarInventario(ByVal p_idlugar As String, ByVal p_familia As String,
                                    ByVal p_material As String, ByVal p_modelo As String,
                                      ByVal p_estado As String) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spBuscarInventario]"
                .Parameters.Add("p_lugar", SqlDbType.VarChar).Value = p_idlugar
                .Parameters.Add("p_familia", SqlDbType.VarChar).Value = p_familia
                .Parameters.Add("p_marca", SqlDbType.VarChar).Value = p_material
                .Parameters.Add("p_modelo", SqlDbType.VarChar).Value = p_modelo
                .Parameters.Add("p_estado", SqlDbType.VarChar).Value = p_estado
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
End Class
