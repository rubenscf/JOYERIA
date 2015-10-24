
Public Class clsControladorProductos
#Region "Funciones Publicas"
#Region "Familias"
    Public Function fInsertarFamilia(ByVal p_Nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarFamilia]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
                .Parameters.Add("v_estado", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue
            End With
            bd._Cmd.ExecuteNonQuery()
            If bd._Cmd.Parameters("v_estado").Value > 0 Then
                v_respuesta = clsComunes.Respuesta_Operacion.Guardado
            End If
        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fModificarFamilia(ByVal p_idFamilia As Long, ByVal p_Nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarFamilia]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_idprfamilia", SqlDbType.BigInt).Value = p_idFamilia
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
            End With
            bd._Cmd.ExecuteNonQuery()
            v_respuesta = clsComunes.Respuesta_Operacion.Modificado
        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fListarFamiliaes() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarFamilia]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
#End Region
#Region "Material"
    Public Function fInsertarMaterial(ByVal p_Nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarMaterial]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
                .Parameters.Add("v_estado", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue
            End With
            bd._Cmd.ExecuteNonQuery()
            If bd._Cmd.Parameters("v_estado").Value > 0 Then
                v_respuesta = clsComunes.Respuesta_Operacion.Guardado
            End If
        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fModificarMaterial(ByVal p_idmaterial As Long, ByVal p_Nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarMaterial]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_idFamilia", SqlDbType.BigInt).Value = p_idmaterial
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
            End With
            bd._Cmd.ExecuteNonQuery()
            v_respuesta = clsComunes.Respuesta_Operacion.Modificado
        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fListarMaterial() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarMaterial]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function

#End Region
#Region "Productos"
    Public Function fListarProductos() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spbuscarProducto]"
                .Parameters.Add("p_proveedor", SqlDbType.VarChar).Value = "%%"
                .Parameters.Add("p_familia", SqlDbType.VarChar).Value = "%%"
                .Parameters.Add("p_material", SqlDbType.VarChar).Value = "%%"
                .Parameters.Add("p_modelo", SqlDbType.VarChar).Value = "%%"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarProductos(ByVal proveedor As String, ByVal familia As String,
                                     ByVal material As String, ByVal modelo As String) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spbuscarProducto]"
                .Parameters.Add("p_proveedor", SqlDbType.VarChar).Value = proveedor
                .Parameters.Add("p_familia", SqlDbType.VarChar).Value = familia
                .Parameters.Add("p_material", SqlDbType.VarChar).Value = material
                .Parameters.Add("p_modelo", SqlDbType.VarChar).Value = modelo
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
#End Region

#End Region

End Class
