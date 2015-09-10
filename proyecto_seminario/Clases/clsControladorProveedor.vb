
Public Class clsControladorProveedor
#Region "Funciones Publicas"
    Public Function fIngresarProveedor(ByVal p_Agente As String, ByVal p_NombreEmpresa As String, ByVal p_DireccionEmpresa As String,
                                       ByVal p_EmpNit As String, ByVal p_TelAgente As String, ByVal p_TelEmp1 As String, ByVal p_TelEmp2 As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spInsertarProveedor]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_Agente", SqlDbType.VarChar).Value = p_Agente
                .Parameters.Add("p_EmpNombre", SqlDbType.VarChar).Value = p_NombreEmpresa
                .Parameters.Add("p_EmpDireccion", SqlDbType.VarChar).Value = p_DireccionEmpresa
                .Parameters.Add("p_EmpNit", SqlDbType.VarChar).Value = p_EmpNit
                .Parameters.Add("p_TelAgente", SqlDbType.VarChar).Value = p_TelAgente
                .Parameters.Add("p_TelEmpresa1", SqlDbType.VarChar).Value = p_TelEmp1
                .Parameters.Add("p_TelEmpresa2", SqlDbType.VarChar).Value = p_TelEmp2
                .Parameters.Add("p_IdEmpleado", SqlDbType.VarChar).Value = 1
                .Parameters.Add("v_estado", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue
            End With
            bd._Cmd.ExecuteNonQuery()
            If bd._Cmd.Parameters("v_estado").Value > 0 Then
                v_respuesta = clsComunes.Respuesta_Operacion.Exito
            End If
        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fModificarProveedor(ByVal p_idproveedor As Long, ByVal p_Agente As String, ByVal p_NombreEmpresa As String, ByVal p_DireccionEmpresa As String,
                                       ByVal p_EmpNit As String, ByVal p_TelAgente As String, ByVal p_TelEmp1 As String, ByVal p_TelEmp2 As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spModificarProveedor]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_idproveedor", SqlDbType.BigInt).Value = p_idproveedor
                .Parameters.Add("p_Agente", SqlDbType.VarChar).Value = p_Agente
                .Parameters.Add("p_EmpNombre", SqlDbType.VarChar).Value = p_NombreEmpresa
                .Parameters.Add("p_EmpDireccion", SqlDbType.VarChar).Value = p_DireccionEmpresa
                .Parameters.Add("p_EmpNit", SqlDbType.VarChar).Value = p_EmpNit
                .Parameters.Add("p_TelAgente", SqlDbType.VarChar).Value = p_TelAgente
                .Parameters.Add("p_Telempresa", SqlDbType.VarChar).Value = p_TelEmp1
                .Parameters.Add("p_Telempresa2", SqlDbType.VarChar).Value = p_TelEmp2
                .Parameters.Add("p_IdEmpleado", SqlDbType.VarChar).Value = 1
            End With
            bd._Cmd.ExecuteNonQuery()

            v_respuesta = clsComunes.Respuesta_Operacion.Exito

        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fListarProveedores() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spListarProveedores]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fObtenerProveedor(ByVal p_codigo As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spObtenerProveedor]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_idProveedor", SqlDbType.BigInt).Value = p_codigo
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
#End Region

End Class
