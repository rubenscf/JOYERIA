Public Class clsControladorAsientoCuenta



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
