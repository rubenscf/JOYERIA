Public Class clsControladorInventario
#Region "Funciones Publicas"
    Public Function fIngresarInventarioFisico(ByVal p_IdLugar As String, ByVal p_Proveedor As Long, ByVal p_Material As Long,
                                       ByVal p_Familia As Long, ByVal p_Modelo As String, ByVal p_Detalle As String, ByVal p_Observacion As String, ByVal p_Stock As Integer, ByVal p_IdEmpleado As Long) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarInventarioFisico]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_IdLugar", SqlDbType.VarChar).Value = p_IdLugar
                .Parameters.Add("p_Proveedor", SqlDbType.BigInt).Value = p_Proveedor
                .Parameters.Add("p_Material", SqlDbType.BigInt).Value = p_Material
                .Parameters.Add("p_Familia", SqlDbType.BigInt).Value = p_Familia
                .Parameters.Add("p_Modelo", SqlDbType.VarChar).Value = p_Modelo
                .Parameters.Add("p_Detalle", SqlDbType.VarChar).Value = p_Detalle
                .Parameters.Add("p_Observacion", SqlDbType.VarChar).Value = p_Observacion
                .Parameters.Add("p_Stock", SqlDbType.Int).Value = p_Stock
                .Parameters.Add("p_IdEmpleado", SqlDbType.BigInt).Value = p_IdEmpleado
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
   
#End Region

End Class
