Public Class clsControladorPeriodo
#Region "Funciones Publicas"
    Public Function fIngresarPeriodoConta(ByVal p_anio As Integer, p_inicio As Date, p_fin As Date) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarPeriodoCont]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@p_anio", SqlDbType.SmallInt).Value = p_anio
                .Parameters.Add("@p_inicio", SqlDbType.Date).Value = p_anio
                .Parameters.Add("@p_fin", SqlDbType.Date).Value = p_anio
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
    Public Function fModificarPeriodoConta(ByVal p_anio As Int16, ByVal p_inicio As Date, ByVal p_fin As Date) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarPeriodoCont]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_anio", SqlDbType.Int).Value = p_anio
                .Parameters.Add("p_inicio", SqlDbType.Date).Value = p_inicio
                .Parameters.Add("p_fin", SqlDbType.Date).Value = p_fin

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
    Public Function fListarPeriodoConta() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarPeriodoCont]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fObtenerPeriodoConta(ByVal p_anio As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spObtenerPeriodoCont"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_anio", SqlDbType.BigInt).Value = p_anio
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
