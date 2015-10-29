Public Class clsControladorPeriodo
#Region "Funciones Publicas"
    Public Function fIngresarPeriodo(ByVal p_anio As Int16, ByVal p_inicio As Date, ByVal p_fin As Date) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarPeriodo]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("anio", SqlDbType.SmallInt).Value = p_anio
                .Parameters.Add("fechainicio", SqlDbType.Date).Value = p_inicio
                .Parameters.Add("fechafin", SqlDbType.Date).Value = p_fin

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
    Public Function fModificarPeriodo(ByVal p_anio As Int16, ByVal p_mes As Int16, ByVal p_desde As Date, ByVal p_hasta As Date, ByVal p_inicio As Date, ByVal p_fin As Date) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarPeriodo]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("anio", SqlDbType.SmallInt).Value = p_anio
                .Parameters.Add("mes", SqlDbType.SmallInt).Value = p_mes
                .Parameters.Add("inicio", SqlDbType.Date).Value = p_inicio
                .Parameters.Add("fin", SqlDbType.Date).Value = p_fin
                .Parameters.Add("desde", SqlDbType.Date).Value = p_desde
                .Parameters.Add("hasta", SqlDbType.Date).Value = p_hasta

            End With
            bd._Cmd.ExecuteNonQuery()
            If bd._Cmd.Parameters("v_estado").Value > 0 Then
                v_respuesta = clsComunes.Respuesta_Operacion.Modificado
            End If


        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fListarMes() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarMes]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
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


#End Region
End Class
