Public Class clsControladorParametros
#Region "Funciones Publicas"
    Public Function fIngresarParametro(ByVal p_descripcion As String, ByVal p_porcentaje As Decimal) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarParametro]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = p_descripcion
                .Parameters.Add("@porcentaje", SqlDbType.Decimal).Value = p_porcentaje
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
    Public Function fModificarParametro(ByVal p_IdParametro As Int16, ByVal p_descripcion As String, ByVal p_porcentaje As Decimal) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarParametro]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdParametro", SqlDbType.Int).Value = p_IdParametro
                .Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = p_descripcion
                .Parameters.Add("@Porcentaje", SqlDbType.Decimal).Value = p_porcentaje
                .Parameters.Add("v_estado", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue

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
    Public Function fListarParametro() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarParametro]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fObtenerTipoCuenta(ByVal p_id As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spObtenerParametro"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_IdParametro", SqlDbType.Int).Value = p_id
                .Parameters.Add("v_estado", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue
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
