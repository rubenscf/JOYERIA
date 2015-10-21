Public Class clsControladorCompras
#Region "Funciones Publicas"
    Public Function fIngresarFacturaCompra(ByVal p_idlugar As String, ByVal p_IDPROVEEDOR As Long, ByVal p_IDPR_FACT_COMPRA As String, ByVal p_FECHA As Date,
                                           ByVal p_IDEMPLEADO As Long, ByVal p_TOTAL As Decimal, ByVal p_DOCUMENTO As String,
                                           ByVal p_OBSERVACIONES As String, ByVal p_DETALLEFACT As DataTable) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarFacturaCompra]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idlugar", SqlDbType.VarChar).Value = p_idlugar
                .Parameters.Add("@idproveedor", SqlDbType.BigInt).Value = p_IDPROVEEDOR
                .Parameters.Add("@IDPR_FACT_COMPRA", SqlDbType.VarChar).Value = p_IDPR_FACT_COMPRA
                .Parameters.Add("@FECHA", SqlDbType.DateTime).Value = p_FECHA
                .Parameters.Add("@idempleado", SqlDbType.BigInt).Value = p_IDEMPLEADO
                .Parameters.Add("@total", SqlDbType.Decimal).Value = p_TOTAL
                .Parameters.AddWithValue("@datos", SqlDbType.Structured).Value = p_DETALLEFACT
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
    Public Function fModificarFacturaCompra(ByVal p_idlugar As String, ByVal p_IDPROVEEDOR As Long, ByVal p_IDPR_FACT_COMPRA As String, ByVal p_FECHA As Date,
                                       ByVal p_IDEMPLEADO As Long, ByVal p_TOTAL As Decimal, ByVal p_DOCUMENTO As String, ByVal p_ESTADO As String,
                                       ByVal p_OBSERVACIONES As String, ByVal p_DETALLEFACT As DataTable) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarFacturaCompra]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idlugar", SqlDbType.VarChar).Value = p_idlugar
                .Parameters.Add("@idproveedor", SqlDbType.BigInt).Value = p_IDPROVEEDOR
                .Parameters.Add("@IDPR_FACT_COMPRA", SqlDbType.VarChar).Value = p_IDPR_FACT_COMPRA
                .Parameters.Add("@FECHA", SqlDbType.DateTime).Value = p_FECHA
                .Parameters.Add("@idempleado", SqlDbType.BigInt).Value = p_IDEMPLEADO
                .Parameters.Add("@total", SqlDbType.Decimal).Value = p_TOTAL
                .Parameters.AddWithValue("@datos", SqlDbType.Structured).Value = p_DETALLEFACT
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
    Public Function fListarFacturaCompra(ByVal P_IDPROVEEDOR As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarFacturaCompra]"
                .Parameters.Add("p_IDPROVEEDOR", SqlDbType.BigInt).Value = p_IDPROVEEDOR
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fSolcitudCompra(ByVal p_IDSOLICITUD As Long, ByVal p_IDPROVEEDOR As Long, ByVal p_FECHA As Date,
                                        ByVal p_IDEMPLEADO As Long, ByVal p_ESTADO As String, ByVal p_OBSERVACIONES As String,
                                        ByVal p_DETALLESOL As DataTable) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spSolicitudCompra]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_IDSOLICITUD", SqlDbType.BigInt).Value = p_IDSOLICITUD
                .Parameters.Add("p_IDPROVEEDOR", SqlDbType.VarChar).Value = p_IDPROVEEDOR
                .Parameters.Add("p_FECHA", SqlDbType.DateTime).Value = p_FECHA
                .Parameters.Add("p_IDEMPLEADO", SqlDbType.BigInt).Value = p_IDEMPLEADO
                .Parameters.Add("p_ESTADO", SqlDbType.VarChar).Value = p_ESTADO
                .Parameters.Add("p_OBSERVACIONES", SqlDbType.VarChar).Value = 1
                .Parameters.AddWithValue("p_DETALLESOL", SqlDbType.Structured).Value = p_DETALLESOL
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
    Public Function fModificarSolicitudCompra(ByVal p_IDSOLICITUD As Long, ByVal p_IDPROVEEDOR As Long, ByVal p_FECHA As Date,
                                        ByVal p_IDEMPLEADO As Long, ByVal p_ESTADO As String, ByVal p_OBSERVACIONES As String,
                                        ByVal p_DETALLESOL As DataTable) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spModificarFacturaCompra]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_IDSOLICITUD", SqlDbType.BigInt).Value = p_IDSOLICITUD
                .Parameters.Add("p_IDPROVEEDOR", SqlDbType.VarChar).Value = p_IDPROVEEDOR
                .Parameters.Add("p_FECHA", SqlDbType.DateTime).Value = p_FECHA
                .Parameters.Add("p_IDEMPLEADO", SqlDbType.BigInt).Value = p_IDEMPLEADO
                .Parameters.Add("p_ESTADO", SqlDbType.VarChar).Value = p_ESTADO
                .Parameters.Add("p_OBSERVACIONES", SqlDbType.VarChar).Value = 1
                .Parameters.AddWithValue("p_DETALLESOL", SqlDbType.Structured).Value = p_DETALLESOL
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
    Public Function fListarSolicitudcompra() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[COMP].[spListarFacturaCompra]"
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
