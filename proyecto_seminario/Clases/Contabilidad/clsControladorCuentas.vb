Public Class clsControladorCuentas
#Region "Funciones Publicas"
    Public Function fIngresarCuenta(ByVal p_nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spInsertarCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_nombre

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
    Public Function fModificarCuenta(ByVal p_idcuenta As Long, ByVal p_nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[CONT].[spModificarCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_IdCuenta", SqlDbType.BigInt).Value = p_idcuenta
                .Parameters.Add("p_nombre", SqlDbType.VarChar).Value = p_nombre

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
    Public Function fListarCuenta() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spListarCuenta]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fObtenerCuenta(ByVal p_codigo As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spObtenerCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_IdCuenta", SqlDbType.BigInt).Value = p_codigo
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
