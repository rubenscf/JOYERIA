Public Class clsControladorAsientoCuenta


    Public Function fIngresarAsientoTemporal(ByVal codigo_cta As String, ByVal debe As Decimal, ByVal haber As Decimal) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarAsientoTemporal]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("codigo", SqlDbType.VarChar).Value = codigo_cta
                .Parameters.Add("debe", SqlDbType.Decimal).Value = debe
                .Parameters.Add("haber", SqlDbType.Decimal).Value = haber
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


    Public Function fIngresarAsiento(ByVal anio As Int16, ByVal mes As Int16, ByVal idempleado As Int16, ByVal fecha As DateTime, ByVal tipo As String, ByVal monto As Decimal, ByVal documento As String, ByVal concepto As String, ByVal idtran As Int16) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarAsientoTemporal]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("anio", SqlDbType.SmallInt).Value = anio
                .Parameters.Add("idmes", SqlDbType.SmallInt).Value = mes
                .Parameters.Add("idempleado", SqlDbType.BigInt).Value = idempleado
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("tipo", SqlDbType.SmallInt).Value = tipo
                .Parameters.Add("monto", SqlDbType.Decimal).Value = monto
                .Parameters.Add("documento", SqlDbType.VarChar).Value = documento
                .Parameters.Add("concepto", SqlDbType.VarChar).Value = concepto
                .Parameters.Add("idtran", SqlDbType.SmallInt).Value = idtran


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

    Public Function fVerDiario(ByVal p_anio As Int16, ByVal p_mes As Int16) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spDiario]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("anio", SqlDbType.SmallInt).Value = p_anio
                .Parameters.Add("mes", SqlDbType.SmallInt).Value = p_mes

            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function


    Public Function fListarAsientoComprobante() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarAsientoComprobante]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function



    Public Function fllenarTablaTemporal() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarTablaTemp]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function


    Public Function fListarAsientoAnio() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarAsientoAnio]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function


    Public Function fListarMes() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarAsientoMes]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function








    Public Function fListarAsientoCuenta() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarAsientoCuenta]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function





End Class
