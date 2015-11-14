Public Class clsDetallesTemporales
    Public Sub fInsertar(ByVal modulo As String, ByVal empleado As Long, ByVal idpr_modelo As String,
                               ByVal cantidad As Integer, ByVal precio As Decimal)

        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarDetalleTemporal]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("modulo", SqlDbType.VarChar).Value = modulo
                .Parameters.Add("usuario", SqlDbType.BigInt).Value = empleado
                .Parameters.Add("idpr_modelo", SqlDbType.VarChar).Value = idpr_modelo
                .Parameters.Add("cantidad", SqlDbType.Int).Value = cantidad
                .Parameters.Add("precio", SqlDbType.Decimal).Value = precio
            End With
            bd._Cmd.ExecuteNonQuery()

        Catch ex As Exception

        Finally
            bd.fCerrar()
        End Try
    End Sub
    Public Sub fElimina(ByVal modulo As String, ByVal empleado As Long, ByVal idpr_modelo As String)

        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spEliminaDetalleTemporal]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("modulo", SqlDbType.VarChar).Value = modulo
                .Parameters.Add("usuario", SqlDbType.BigInt).Value = empleado
                .Parameters.Add("idpr_modelo", SqlDbType.VarChar).Value = idpr_modelo

            End With
            bd._Cmd.ExecuteNonQuery()

        Catch ex As Exception

        Finally
            bd.fCerrar()
        End Try
    End Sub
    Public Sub fLimpiar(ByVal modulo As String, ByVal empleado As Long)

        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spLimpiaDetalleTemporal]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("modulo", SqlDbType.VarChar).Value = modulo
                .Parameters.Add("usuario", SqlDbType.BigInt).Value = empleado

            End With
            bd._Cmd.ExecuteNonQuery()

        Catch ex As Exception

        Finally
            bd.fCerrar()
        End Try
    End Sub
    Public Function fListar(ByVal modulo As String, ByVal usuario As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarDetalleTemporal]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("modulo", SqlDbType.VarChar).Value = modulo
                .Parameters.Add("usuario", SqlDbType.BigInt).Value = usuario
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
End Class
