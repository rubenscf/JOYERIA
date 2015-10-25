Public Class clsControladorProcedimientos
#Region "Anulaciones"

    Public Function fAnularNotaSalida(ByVal p_lugar As String,
                                      ByVal p_id_nota As Int64,
                                      ByVal p_version As Int16,
                                     ByVal p_id_usuario As Int64) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[SP_AnularNotaSalida]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_lugar", SqlDbType.VarChar).Value = p_lugar
                .Parameters.Add("p_id_nota", SqlDbType.BigInt).Value = p_id_nota
                .Parameters.Add("p_version", SqlDbType.SmallInt).Value = p_version
                .Parameters.Add("p_id_usuario", SqlDbType.BigInt).Value = p_id_usuario
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
    Public Function fAnularAbono(ByVal p_fecha As DateTime,
                            ByVal p_fechaapp As DateTime,
                            ByVal p_lugarCredito As String,
                            ByVal p_serieCredito As String,
                            ByVal p_idveCredito As Int64,
                            ByVal p_versCredito As Int16,
                            ByVal p_abonosPendien As Int16,
                            ByVal p_saldoPendiente As Decimal,
                            ByVal p_empleado As Int64,
                            ByVal p_abonos As DataTable,
                            ByVal p_letras As DataTable) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAnularAbono]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = p_fecha
                .Parameters.Add("fechaapp", SqlDbType.DateTime).Value = p_fechaapp
                .Parameters.Add("lugarCredito", SqlDbType.VarChar).Value = p_lugarCredito
                .Parameters.Add("serieCredito", SqlDbType.VarChar).Value = p_serieCredito
                .Parameters.Add("idveCredito", SqlDbType.BigInt).Value = p_idveCredito
                .Parameters.Add("versCredito", SqlDbType.SmallInt).Value = p_versCredito
                .Parameters.Add("abonosPendien", SqlDbType.SmallInt).Value = p_abonosPendien
                .Parameters.Add("saldoPendiente", SqlDbType.Decimal).Value = p_saldoPendiente
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = p_empleado
                .Parameters.Add("abonos", SqlDbType.Structured).Value = p_abonos
                .Parameters.Add("letras", SqlDbType.Structured).Value = p_letras
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
    Public Function fAnularCredito(ByVal p_lugar As String,
                               ByVal p_serie_credito As String,
                               ByVal p_idve_credito As Int64,
                               ByVal p_VERSION As Int16,
                               ByVal p_empleado As Int64,
                               ByVal p_U As Int16,
                               ByVal p_lugarR As String,
                               ByVal p_idRecogido As Int64,
                               ByVal p_VERSIONR As Int16) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAnularCredito]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("lugar", SqlDbType.VarChar).Value = p_lugar
                .Parameters.Add("serie_credito", SqlDbType.VarChar).Value = p_serie_credito
                .Parameters.Add("idve_credito", SqlDbType.BigInt).Value = p_idve_credito
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = p_VERSION
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = p_empleado
                .Parameters.Add("U", SqlDbType.SmallInt).Value = p_U
                .Parameters.Add("lugarR", SqlDbType.VarChar).Value = p_lugarR
                .Parameters.Add("idRecogido", SqlDbType.BigInt).Value = p_idRecogido
                .Parameters.Add("VERSIONR", SqlDbType.SmallInt).Value = p_VERSIONR
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
    Public Function fAnularDepositoBanco(ByVal p_lugar As String,
                                    ByVal p_fecha As DateTime,
                                    ByVal p_id As Int16,
                                    ByVal p_empleado As Int64) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAnularDepositoBanco]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("lugar", SqlDbType.VarChar).Value = p_lugar
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = p_fecha
                .Parameters.Add("id", SqlDbType.SmallInt).Value = p_id
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = p_empleado
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
    Public Function fAnularEnvio(ByVal p_sale As String,
                             ByVal p_iden_tipo As Int64,
                             ByVal p_idenvio As Int64,
                             ByVal p_idusuario As Int64,
                             ByVal p_destino As String,
                             ByVal p_VERSION As Int16) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAnularEnvio]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("sale", SqlDbType.VarChar).Value = p_sale
                .Parameters.Add("iden_tipo", SqlDbType.BigInt).Value = p_iden_tipo
                .Parameters.Add("idenvio", SqlDbType.BigInt).Value = p_idenvio
                .Parameters.Add("idusuario", SqlDbType.BigInt).Value = p_idusuario
                .Parameters.Add("destino", SqlDbType.VarChar).Value = p_destino
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = p_VERSION
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
    Public Function fAnularfactura(ByVal p_lugar As String,
                               ByVal p_serie_factura As String,
                               ByVal p_idfactura As Int64,
                               ByVal p_VERSION As Int16,
                               ByVal p_empleado As Int64,
                               ByVal p_fecha As DateTime) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAnularfactura]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("lugar", SqlDbType.VarChar).Value = p_lugar
                .Parameters.Add("serie_factura", SqlDbType.VarChar).Value = p_serie_factura
                .Parameters.Add("idfactura", SqlDbType.BigInt).Value = p_idfactura
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = p_VERSION
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = p_empleado
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = p_fecha
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
    Public Function fAnularGastoTienda(ByVal p_lugar As String,
                                   ByVal p_fecha As DateTime,
                                   ByVal p_id As Int16,
                                   ByVal p_empleado As Int64) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAnularGastoTienda]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("lugar", SqlDbType.VarChar).Value = p_lugar
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = p_fecha
                .Parameters.Add("id", SqlDbType.SmallInt).Value = p_id
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = p_empleado
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
#Region "Insertar"
    Public Function fInsertarInventarioFisico(ByVal p_IdLugar As String, ByVal p_Proveedor As Long, ByVal p_Material As Long,
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
    Public Function fInsetarTipoCuenta(ByVal p_descripcion As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarTipoCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_Descripcion", SqlDbType.VarChar).Value = p_descripcion
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
    Public Function fInsertarPeriodo(ByVal p_anio As Integer, p_inicio As Date, p_fin As Date) As Integer
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
    Public Function fInsertarCuenta(ByVal p_codigo As String, ByVal p_idtipo_cta As Int16, ByVal p_nombre As String, ByVal p_mayoriza As String, ByVal p_nivel As Int16, ByVal p_sumariza As String, ByVal p_mov As String, ByVal p_ajuste As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[CONT].[spInsertarPlanCuentas]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@codigo_cta", SqlDbType.VarChar).Value = p_codigo
                .Parameters.Add("@idtipo_cta", SqlDbType.SmallInt).Value = p_idtipo_cta
                .Parameters.Add("@nombre", SqlDbType.VarChar).Value = p_nombre
                .Parameters.Add("@mayoriza", SqlDbType.VarChar).Value = p_mayoriza
                .Parameters.Add("@nivel", SqlDbType.SmallInt).Value = p_nivel
                .Parameters.Add("@sumariza", SqlDbType.VarChar).Value = p_sumariza
                .Parameters.Add("@movimiento", SqlDbType.VarChar).Value = p_mov
                .Parameters.Add("@ajuste", SqlDbType.VarChar).Value = p_ajuste
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
    Public Function fInsertarSolcitudCompra(ByVal p_IDSOLICITUD As Long, ByVal p_IDPROVEEDOR As Long, ByVal p_FECHA As Date,
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
    Public Function fInsertarFacturaCompra(ByVal p_idlugar As String, ByVal p_IDPROVEEDOR As Long, ByVal p_IDPR_FACT_COMPRA As String, ByVal p_FECHA As Date,
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
    Public Function fInsertarProveedor(ByVal p_Agente As String, ByVal p_NombreEmpresa As String, ByVal p_DireccionEmpresa As String,
                                       ByVal p_EmpNit As String, ByVal p_TelAgente As String, ByVal p_TelEmp1 As String, ByVal p_TelEmp2 As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarProveedor]"
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
                v_respuesta = clsComunes.Respuesta_Operacion.Guardado
            End If
        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fInsertarAbono(ByVal idLugarAbono As String, ByVal idAbono As Long, ByVal tipoAbono As Long,
                                       ByVal fecha As Date, ByVal lugarCredito As String, ByVal serieCredito As String,
                                       ByVal idvCredito As Long, ByVal observaciones As String, ByVal abonosPendien As Int16, ByVal verCredito As Int16,
                                       ByVal total As Decimal, ByVal mora As Decimal, ByVal abono As Decimal, ByVal descuento As Decimal, ByVal saldoPendiente As Decimal,
                                       ByVal empleado As Long, ByVal cliente As Long, ByVal letras As DataTable) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarAbono]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugarAbono", SqlDbType.VarChar).Value = idLugarAbono
                .Parameters.Add("idAbono", SqlDbType.BigInt).Value = idAbono
                .Parameters.Add("tipoAbono", SqlDbType.BigInt).Value = tipoAbono
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("lugarCredito", SqlDbType.VarChar).Value = lugarCredito
                .Parameters.Add("serieCredito", SqlDbType.VarChar).Value = serieCredito
                .Parameters.Add("idvCredito", SqlDbType.BigInt).Value = idvCredito
                .Parameters.Add("observaciones", SqlDbType.VarChar).Value = observaciones
                .Parameters.Add("abonosPendie", SqlDbType.SmallInt).Value = abonosPendien
                .Parameters.Add("verCredito", SqlDbType.SmallInt).Value = verCredito
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("mora", SqlDbType.Decimal).Value = mora
                .Parameters.Add("abono", SqlDbType.Decimal).Value = abono
                .Parameters.Add("descuento", SqlDbType.Decimal).Value = descuento
                .Parameters.Add("saldoPendiente", SqlDbType.Decimal).Value = saldoPendiente
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = empleado
                .Parameters.Add("cliente", SqlDbType.BigInt).Value = cliente
                .Parameters.Add("letras", SqlDbType.Structured).Value = letras
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
    Public Function fInsertarCliente(ByVal IDCL_NIVEL As String, ByVal DPI As String, ByVal NOMBRE As String,
                                       ByVal APELLIDO As String, ByVal EXTENDIDA As String, ByVal BIENES As String,
                                       ByVal NIT As String, ByVal SEXO As String, ByVal NACIONAL As String, ByVal DIRECCION As String,
                                       ByVal TELEFONO As String, ByVal CONYUGUE As String, ByVal FECHANAC As Date, ByVal FECHA_REGISTRO As Date,
                                       ByVal INGRESO As Decimal, ByVal PUESTO As String, ByVal TELEFONO1 As String, ByVal TELEFONO2 As String,
                                       ByVal EMP_NOMBRE As String, ByVal EMP_DIRECCION As String, ByVal EMP_TELEFONO As String,
                                       ByVal IDEMPLEADO As Long, ByVal FECHA_EMPINICIO As Date, ByVal PADRE As String, ByVal MADRE As String,
                                       ByVal DIRECCIONPAPA As String, ByVal REFERENCIA_FAM As String, ByVal DIRECCION_RFAM As String,
                                       ByVal REFERENCIA_PERS As String, ByVal DIRECCION_RPER As String) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarcliente]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("IDCL_NIVEL", SqlDbType.VarChar).Value = IDCL_NIVEL
                .Parameters.Add("DPI", SqlDbType.VarChar).Value = DPI
                .Parameters.Add("NOMBRE", SqlDbType.VarChar).Value = NOMBRE
                .Parameters.Add("APELLIDO", SqlDbType.VarChar).Value = APELLIDO
                .Parameters.Add("EXTENDIDA", SqlDbType.VarChar).Value = EXTENDIDA
                .Parameters.Add("BIENES", SqlDbType.VarChar).Value = BIENES
                .Parameters.Add("NIT", SqlDbType.VarChar).Value = NIT
                .Parameters.Add("SEXO", SqlDbType.VarChar).Value = SEXO
                .Parameters.Add("NACIONAL", SqlDbType.VarChar).Value = NACIONAL
                .Parameters.Add("DIRECCION", SqlDbType.VarChar).Value = DIRECCION
                .Parameters.Add("TELEFONO", SqlDbType.VarChar).Value = TELEFONO
                .Parameters.Add("CONYUGUE", SqlDbType.VarChar).Value = CONYUGUE
                .Parameters.Add("FECHANAC", SqlDbType.Date).Value = FECHANAC
                .Parameters.Add("FECHA_REGISTRO", SqlDbType.DateTime).Value = FECHA_REGISTRO
                .Parameters.Add("INGRESO", SqlDbType.Decimal).Value = INGRESO
                .Parameters.Add("PUESTO", SqlDbType.VarChar).Value = PUESTO
                .Parameters.Add("TELEFONO1", SqlDbType.VarChar).Value = TELEFONO1
                .Parameters.Add("TELEFONO2", SqlDbType.VarChar).Value = TELEFONO2
                .Parameters.Add("EMP_NOMBRE", SqlDbType.VarChar).Value = EMP_NOMBRE
                .Parameters.Add("EMP_DIRECCION", SqlDbType.VarChar).Value = EMP_DIRECCION
                .Parameters.Add("EMP_TELEFONO", SqlDbType.VarChar).Value = EMP_TELEFONO
                .Parameters.Add("IDEMPLEADO", SqlDbType.BigInt).Value = IDEMPLEADO
                .Parameters.Add("FECHA_EMPINICIO", SqlDbType.Date).Value = FECHA_EMPINICIO
                .Parameters.Add("PADRE", SqlDbType.VarChar).Value = PADRE
                .Parameters.Add("MADRE", SqlDbType.VarChar).Value = MADRE
                .Parameters.Add("DIRECCIONPAPA", SqlDbType.VarChar).Value = DIRECCIONPAPA
                .Parameters.Add("REFERENCIA_FAM", SqlDbType.VarChar).Value = REFERENCIA_FAM
                .Parameters.Add("DIRECCION_RFAM", SqlDbType.VarChar).Value = DIRECCION_RFAM
                .Parameters.Add("REFERENCIA_PERS", SqlDbType.VarChar).Value = REFERENCIA_PERS
                .Parameters.Add("DIRECCION_RPER", SqlDbType.VarChar).Value = DIRECCION_RPER
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
    Public Function fInsertarDeposito(ByVal idlugar As String, ByVal documento As String, ByVal total As Decimal,
                                      ByVal banco As String, ByVal fecha As Date, ByVal idempleado As Long) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarDeposito]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("documento", SqlDbType.VarChar).Value = documento
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("idempleado", SqlDbType.BigInt).Value = idempleado
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
    Public Function fInsertarDepuradas(ByVal FECHA As Date, ByVal IDEMPLEANDO As Long, ByVal OBSERVACIONES As String,
                                      ByVal ESTADO As String, ByVal DETALLE As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarDepuradas]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("FECHA", SqlDbType.DateTime).Value = FECHA
                .Parameters.Add("IDEMPLEADO", SqlDbType.BigInt).Value = IDEMPLEANDO
                .Parameters.Add("OBSERVACIONES", SqlDbType.VarChar).Value = OBSERVACIONES
                .Parameters.Add("ESTADO", SqlDbType.VarChar).Value = ESTADO
                .Parameters.Add("DETALLE", SqlDbType.Structured).Value = DETALLE
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
    Public Function fInsertarEmpleado(ByVal IDLUGAR As String, ByVal IDLU_PUESTO As Int64, ByVal DPI As String, ByVal NOMBRE As String,
                                      ByVal NONBRE1 As String, ByVal APELLIDO As String, ByVal APELLIDO1 As String, ByVal EXTENDIDA As String,
                                      ByVal NIT As String, ByVal SEXO As String, ByVal DIRECCION As String, TELEFONO As String,
                                      ByVal CONYUGE As String, ByVal FECHANAC As Date, ByVal USUARIO As String, ByVal PASS As String,
                                      ByVal ESTADO_CIVIL As String, ByVal NACIONALIDAD As String, ByVal VECINDAD As String,
                                      ByVal finicio As Date, ByVal SERVICIOS As String, ByVal DURACION_CONTRATO As String,
                                      ByVal TIPO_JORNADA As String, ByVal hr_INICIO_LS As String, ByVal hr_fin_ls As String,
                                      ByVal hr_inicio_dm As String, ByVal hr_fin_dm As String, SUELDO_BASE As Decimal, ByVal pago_cada As String,
                                      ByVal foto As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarEmpleados]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("IDLUGAR", SqlDbType.VarChar).Value = IDLUGAR
                .Parameters.Add("IDLU_PUESTO", SqlDbType.BigInt).Value = IDLU_PUESTO
                .Parameters.Add("DPI", SqlDbType.SmallInt).Value = DPI
                .Parameters.Add("NOMBRE", SqlDbType.BigInt).Value = NOMBRE
                .Parameters.Add("NOMBRE1", SqlDbType.BigInt).Value = NONBRE1
                .Parameters.Add("APELLIDO", SqlDbType.BigInt).Value = APELLIDO
                .Parameters.Add("APELLIDO1", SqlDbType.BigInt).Value = APELLIDO1
                .Parameters.Add("EXTENDIDA", SqlDbType.BigInt).Value = EXTENDIDA
                .Parameters.Add("NIT", SqlDbType.BigInt).Value = NIT
                .Parameters.Add("SEXO", SqlDbType.BigInt).Value = SEXO
                .Parameters.Add("DIRECCION", SqlDbType.BigInt).Value = DIRECCION
                .Parameters.Add("TELEFONO", SqlDbType.BigInt).Value = TELEFONO
                .Parameters.Add("CONYUGE", SqlDbType.BigInt).Value = CONYUGE
                .Parameters.Add("FECHANAC", SqlDbType.BigInt).Value = FECHANAC
                .Parameters.Add("USUARIO", SqlDbType.BigInt).Value = USUARIO
                .Parameters.Add("PASS", SqlDbType.BigInt).Value = PASS
                .Parameters.Add("ESTADO_CIVIL", SqlDbType.BigInt).Value = ESTADO_CIVIL
                .Parameters.Add("NACIONALIDAD", SqlDbType.BigInt).Value = NACIONALIDAD
                .Parameters.Add("VECINDAD", SqlDbType.BigInt).Value = VECINDAD
                .Parameters.Add("finicio", SqlDbType.BigInt).Value = finicio
                .Parameters.Add("SERVICIOS", SqlDbType.BigInt).Value = SERVICIOS
                .Parameters.Add("DURACION_CONTRATO", SqlDbType.BigInt).Value = DURACION_CONTRATO
                .Parameters.Add("TIPO_JORNADA", SqlDbType.BigInt).Value = TIPO_JORNADA
                .Parameters.Add("hr_INICIO_LS", SqlDbType.BigInt).Value = hr_INICIO_LS
                .Parameters.Add("hr_fin_ls", SqlDbType.BigInt).Value = hr_fin_ls
                .Parameters.Add("hr_inicio_dm", SqlDbType.BigInt).Value = hr_inicio_dm
                .Parameters.Add("hr_fin_dm", SqlDbType.BigInt).Value = hr_fin_dm
                .Parameters.Add("SUELDO_BASE", SqlDbType.BigInt).Value = SUELDO_BASE
                .Parameters.Add("pago_cada", SqlDbType.BigInt).Value = pago_cada
                .Parameters.Add("foto", SqlDbType.BigInt).Value = foto
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
    Public Function fInsertarEnganche(ByVal idlugarEnganche As String, ByVal idEnganche As Long, ByVal fecha As Date,
                                     ByVal lugarCredito As String, ByVal serieCredito As String, ByVal idveCredito As Long,
                                     ByVal ant_credito As Int16, ByVal tmp As Int16, ByVal VERSION As Int16, ByVal engache As Decimal,
                                     ByVal saldoPendiente As Decimal, ByVal empleado As Long, ByVal cliente As Long) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarEnganche]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugarEnganche", SqlDbType.VarChar).Value = idlugarEnganche
                .Parameters.Add("idEnganche", SqlDbType.BigInt).Value = idEnganche
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("lugarCredito", SqlDbType.VarChar).Value = lugarCredito
                .Parameters.Add("serieCredito", SqlDbType.VarChar).Value = serieCredito
                .Parameters.Add("idveCredito", SqlDbType.BigInt).Value = idveCredito
                .Parameters.Add("ant_credito", SqlDbType.SmallInt).Value = ant_credito
                .Parameters.Add("tmp", SqlDbType.SmallInt).Value = tmp
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = VERSION
                .Parameters.Add("enganche", SqlDbType.Decimal).Value = engache
                .Parameters.Add("saldoPendiente", SqlDbType.Decimal).Value = saldoPendiente
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = empleado
                .Parameters.Add("cliente", SqlDbType.BigInt).Value = cliente
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
    Public Function fInsertarEnvio(ByVal SALE As String, ByVal FECHA As Date, ByVal IDEN_TIPO As Long,
                                     ByVal IDENVIO As Long, ByVal VERSION As Int16, ByVal IDEMISOR As Long,
                                     ByVal IDRECEPTOR As Long, ByVal DESTINO As String, ByVal DETALLES As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarEnvio]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("SALE", SqlDbType.VarChar).Value = SALE
                .Parameters.Add("FECHA", SqlDbType.DateTime).Value = FECHA
                .Parameters.Add("IDEN_TIPO", SqlDbType.BigInt).Value = IDEN_TIPO
                .Parameters.Add("IDENVIO", SqlDbType.BigInt).Value = IDENVIO
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = VERSION
                .Parameters.Add("IDEMISOR", SqlDbType.BigInt).Value = IDEMISOR
                .Parameters.Add("IDRECEPTOR", SqlDbType.BigInt).Value = IDRECEPTOR
                .Parameters.Add("DESTINO", SqlDbType.VarChar).Value = DESTINO
                .Parameters.Add("DETALLES", SqlDbType.Structured).Value = DETALLES
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
    Public Function fInsertarFacturaProveedor(ByVal idlugar As String, ByVal idproveerdor As Long, ByVal idpr_fact_compra As String,
                                     ByVal fecha As Date, ByVal idempleado As Long, ByVal total As Decimal,
                                     ByVal DATOS As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarFacturaProveedor]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("idproveedor", SqlDbType.BigInt).Value = idproveerdor
                .Parameters.Add("idpr_fact_compra", SqlDbType.VarChar).Value = idpr_fact_compra
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("idempleado", SqlDbType.BigInt).Value = idempleado
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("DATOS", SqlDbType.Structured).Value = DATOS
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
    Public Function fInsertarFacturarContado(ByVal idlugar As String, ByVal serie_f As String, ByVal id_f As Long,
                                     ByVal VERSION As Int16, ByVal nit As String, ByVal cnombre As String,
                                     ByVal cdireccion As String, ByVal idempleadoe As Long, ByVal idempleadoc As Long,
                                     ByVal fecha As Date, ByVal descuento As Decimal, ByVal total As Decimal, ByVal detalle As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarFacturarContado]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("serie_f", SqlDbType.VarChar).Value = serie_f
                .Parameters.Add("id_f", SqlDbType.BigInt).Value = id_f
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = VERSION
                .Parameters.Add("nit", SqlDbType.VarChar).Value = nit
                .Parameters.Add("cnombre", SqlDbType.VarChar).Value = cnombre
                .Parameters.Add("cdireccion", SqlDbType.VarChar).Value = cdireccion
                .Parameters.Add("idempleadoe", SqlDbType.BigInt).Value = idempleadoe
                .Parameters.Add("idempleadoc", SqlDbType.BigInt).Value = idempleadoc
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("descuento", SqlDbType.Decimal).Value = descuento
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("detalle", SqlDbType.Structured).Value = detalle
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
    Public Function fInsertarFacturarCreditoCancelado(ByVal idlugar As String, ByVal serie_f As String, ByVal id_f As Long,
                                     ByVal VERSION As Int16, ByVal serie_cred As String, ByVal idve_cred As Long,
                                     ByVal VERSION_cred As Int16, ByVal nit As String, ByVal cnombre As String,
                                     ByVal cdireccion As String, ByVal idempleadov As Long, ByVal idempleadof As Long,
                                     ByVal fecha As Date, ByVal descuento As Decimal, ByVal total As Decimal,
                                     ByVal A As Int16, ByVal detalle As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarFacturarContado]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("serie_f", SqlDbType.VarChar).Value = serie_f
                .Parameters.Add("id_f", SqlDbType.BigInt).Value = id_f
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = VERSION
                .Parameters.Add("serie_cred", SqlDbType.VarChar).Value = serie_cred
                .Parameters.Add("idve_cred", SqlDbType.BigInt).Value = idve_cred
                .Parameters.Add("nit", SqlDbType.VarChar).Value = nit
                .Parameters.Add("cnombre", SqlDbType.VarChar).Value = cnombre
                .Parameters.Add("cdireccion", SqlDbType.VarChar).Value = cdireccion
                .Parameters.Add("idempleadov", SqlDbType.BigInt).Value = idempleadov
                .Parameters.Add("idempleadof", SqlDbType.BigInt).Value = idempleadof
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("descuento", SqlDbType.Decimal).Value = descuento
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("A", SqlDbType.SmallInt).Value = A
                .Parameters.Add("detalle", SqlDbType.Structured).Value = detalle
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
    Public Function fInsertarFamilia(ByVal p_Nombre As String) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarFamilia]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
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
    Public Function fInsertarGasto(ByVal IDLUGAR As String, ByVal FECHA As Date, ByVal PROVEEDOR As String,
                                   ByVal FACTURA As String, ByVal TOTAL As Decimal, ByVal IDEMPLEADO As Long,
                                   ByVal IDTIPO_GASTO As Integer, ByVal DETALLE As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarGasto]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("IDLUGAR", SqlDbType.VarChar).Value = IDLUGAR
                .Parameters.Add("FECHA", SqlDbType.DateTime).Value = FECHA
                .Parameters.Add("PROVEEDOR", SqlDbType.VarChar).Value = PROVEEDOR
                .Parameters.Add("FACTURA", SqlDbType.VarChar).Value = FACTURA
                .Parameters.Add("TOTAL", SqlDbType.Decimal).Value = TOTAL
                .Parameters.Add("IDEMPLEADO", SqlDbType.BigInt).Value = IDEMPLEADO
                .Parameters.Add("IDTIPO_GASTO", SqlDbType.Int).Value = IDTIPO_GASTO
                .Parameters.Add("DETALLE", SqlDbType.Structured).Value = DETALLE
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
    Public Function fInsertarLetraCambio(ByVal IDLUGAR As String, ByVal SERIE_CREDITO As String, ByVal IDVE_CREDITO As Long,
                                   ByVal VERSION_CREDITO As Integer, ByVal VERSION As Integer) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarGasto]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("IDLUGAR", SqlDbType.VarChar).Value = IDLUGAR
                .Parameters.Add("SERIE_CREDITO", SqlDbType.VarChar).Value = SERIE_CREDITO
                .Parameters.Add("IDVE_CREDITO", SqlDbType.BigInt).Value = IDVE_CREDITO
                .Parameters.Add("VERSION_CREDITO", SqlDbType.Int).Value = VERSION_CREDITO
                .Parameters.Add("VERSION", SqlDbType.Int).Value = VERSION
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
    Public Function fInsertarLugar(ByVal idlugar As String, ByVal idlutipo As Long, ByVal nombre As String,
                                   ByVal direccion As String, ByVal tel1 As String, ByVal tel2 As String,
                                   ByVal serie_factura As String, ByVal serie_credito As String, ByVal serie_abono_tie As String,
                                   ByVal serie_abono_cob As String, ByVal serie_servicio As String, ByVal fact_min As Long,
                                   ByVal fact_max As Integer) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarLugar]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("idlutipo", SqlDbType.BigInt).Value = idlutipo
                .Parameters.Add("nombre", SqlDbType.VarChar).Value = nombre
                .Parameters.Add("direccion", SqlDbType.VarChar).Value = direccion
                .Parameters.Add("tel1", SqlDbType.VarChar).Value = tel1
                .Parameters.Add("tel2", SqlDbType.VarChar).Value = tel2
                .Parameters.Add("serie_factura", SqlDbType.VarChar).Value = serie_factura
                .Parameters.Add("serie_credito", SqlDbType.VarChar).Value = serie_credito
                .Parameters.Add("serie_abono_tie", SqlDbType.VarChar).Value = serie_abono_tie
                .Parameters.Add("serie_abono_cob", SqlDbType.VarChar).Value = serie_abono_cob
                .Parameters.Add("serie_servicio", SqlDbType.VarChar).Value = serie_servicio
                .Parameters.Add("fact_min", SqlDbType.BigInt).Value = fact_min
                .Parameters.Add("fac_max", SqlDbType.BigInt).Value = fact_max
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
    Public Function fInsertarMaterial(ByVal p_Nombre As String) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarMaterial]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
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
    Public Function fInsertarModelo(ByVal PROVEEDOR As Long, ByVal MATERIAL As Long, ByVal FAMILIA As Long,
                                    ByVal MODELO As String, ByVal DETALLE As String, ByVal PRECIOC As Decimal,
                                    ByVal PRECIOV As Decimal, ByVal ESTADO As String, ByVal IDEMPLEADO As Long) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarModelo]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("PROVEEDOR", SqlDbType.BigInt).Value = PROVEEDOR
                .Parameters.Add("MATERIAL", SqlDbType.BigInt).Value = MATERIAL
                .Parameters.Add("FAMILIA", SqlDbType.BigInt).Value = FAMILIA
                .Parameters.Add("MODELO", SqlDbType.VarChar).Value = MODELO
                .Parameters.Add("DETALLE", SqlDbType.VarChar).Value = DETALLE
                .Parameters.Add("PRECIOC", SqlDbType.Decimal).Value = PRECIOC
                .Parameters.Add("PRECIOV", SqlDbType.Decimal).Value = PRECIOV
                .Parameters.Add("ESTADO", SqlDbType.VarChar).Value = ESTADO
                .Parameters.Add("IDEMPLEADO", SqlDbType.BigInt).Value = IDEMPLEADO
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
    Public Function fInsertarNotaCredito(ByVal idlugar As String, ByVal idproveedor As Long, ByVal idnota_credito As String,
                                    ByVal fecha As Date, ByVal total As Decimal, ByVal descripcion As String,
                                    ByVal idempleado As Long, ByVal DATOS As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarNotaCredito]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("idproveedor", SqlDbType.BigInt).Value = idproveedor
                .Parameters.Add("idnota_credito", SqlDbType.VarChar).Value = idnota_credito
                .Parameters.Add("fecha", SqlDbType.Date).Value = fecha
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("descripcion", SqlDbType.VarChar).Value = descripcion
                .Parameters.Add("idempleado", SqlDbType.BigInt).Value = idempleado
                .Parameters.Add("DATOS", SqlDbType.Structured).Value = DATOS
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
    Public Function fInsertarNotaRecogido(ByVal idlugar As String, ByVal idrecogido As Long, ByVal VERSION As Int16,
                                    ByVal fecha As Date, ByVal cliente As Long, ByVal Lugarcredito As String,
                                    ByVal seriecredito As String, ByVal idve_credito As Long, ByVal ant_creidto As Int16,
                                    ByVal mesesA As Int16, ByVal deuda As Decimal, ByVal fechaV As Date, ByVal idempleado As Long,
                                    ByVal interes As Decimal, ByVal observacion As String, ByVal detalle As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarNotaRecogido]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("idrecogido", SqlDbType.BigInt).Value = idrecogido
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = VERSION
                .Parameters.Add("fecha", SqlDbType.Date).Value = fecha
                .Parameters.Add("cliente", SqlDbType.BigInt).Value = cliente
                .Parameters.Add("Lugarcredito", SqlDbType.VarChar).Value = Lugarcredito
                .Parameters.Add("seriecredito", SqlDbType.VarChar).Value = seriecredito
                .Parameters.Add("idve_credito", SqlDbType.BigInt).Value = idve_credito
                .Parameters.Add("ant_credito", SqlDbType.SmallInt).Value = ant_creidto
                .Parameters.Add("mesesA", SqlDbType.SmallInt).Value = mesesA
                .Parameters.Add("deuda", SqlDbType.Decimal).Value = deuda
                .Parameters.Add("fechaV", SqlDbType.Date).Value = fechaV
                .Parameters.Add("idempleado", SqlDbType.BigInt).Value = idempleado
                .Parameters.Add("interes", SqlDbType.Decimal).Value = interes
                .Parameters.Add("observancion", SqlDbType.VarChar).Value = observacion
                .Parameters.Add("detalle", SqlDbType.Structured).Value = detalle
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
    Public Function fInsertarNotaSalida(ByVal LUGAR As String, ByVal IDNOTA As Long, ByVal VERSION As Int16,
                                   ByVal FECHA As Date, ByVal IDEMPLEADO As Long, ByVal DETALLE As String,
                                   ByVal RECEPTOR As String, ByVal ARTICULOS As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarNotaSalida]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("LUGAR", SqlDbType.VarChar).Value = LUGAR
                .Parameters.Add("IDNOTA", SqlDbType.BigInt).Value = IDNOTA
                .Parameters.Add("VERSION", SqlDbType.SmallInt).Value = VERSION
                .Parameters.Add("FECHA", SqlDbType.Date).Value = FECHA
                .Parameters.Add("IDEMPLEADO", SqlDbType.BigInt).Value = IDEMPLEADO
                .Parameters.Add("DETALLE", SqlDbType.VarChar).Value = DETALLE
                .Parameters.Add("RECEPTOR", SqlDbType.VarChar).Value = RECEPTOR
                .Parameters.Add("ARTICULOS", SqlDbType.Structured).Value = ARTICULOS
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
    Public Function fInsertarNuevoCaso(ByVal p_ldcl_Tipo_Caso As Int16, ByVal p_ldCliente As String,
                                       ByVal p_Asunto As String, ByVal p_Mensaje As String) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarNuevoCaso]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_ldcl_Tipo_Caso", SqlDbType.SmallInt).Value = p_ldcl_Tipo_Caso
                .Parameters.Add("p_ldCLiente", SqlDbType.VarChar).Value = p_ldCliente
                .Parameters.Add("p_Asunto", SqlDbType.VarChar).Value = p_Asunto
                .Parameters.Add("p_Mensaje", SqlDbType.VarChar).Value = p_Mensaje
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
    Public Function fInsertarOrdenReparacion(ByVal IDLUGAR As String, ByVal IDORDEN As Long, ByVal FECHA As Date,
                                             ByVal CLIENTE As String, ByVal DIRECCION As String, ByVal TELEFONO As String,
                                             ByVal TIPO As Integer, ByVal DOCUMENTO As String, ByVal FECHA_COMPRA As Date,
                                             ByVal NO_GARANTIA As String, ByVal ESTADO_FISICO As String, ByVal DEFECTO As String,
                                             ByVal MODELO As String, ByVal SERIE As String, ByVal IDEMPLEADO As Long,
                                             ByVal ORDEN_REP As String, ByVal FECHA_REP As Date) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarOrdenReparacion"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("IDLUGAR", SqlDbType.VarChar).Value = IDLUGAR
                .Parameters.Add("IDORDEN", SqlDbType.BigInt).Value = IDORDEN
                .Parameters.Add("FECHA", SqlDbType.DateTime).Value = FECHA
                .Parameters.Add("CLIENTE", SqlDbType.VarChar).Value = CLIENTE
                .Parameters.Add("DIRECCION", SqlDbType.VarChar).Value = DIRECCION
                .Parameters.Add("TELEFONO", SqlDbType.VarChar).Value = TELEFONO
                .Parameters.Add("TIPO", SqlDbType.VarChar).Value = TIPO
                .Parameters.Add("DOCUMENTO", SqlDbType.VarChar).Value = DOCUMENTO
                .Parameters.Add("FECHA_COMPRA", SqlDbType.DateTime).Value = FECHA_COMPRA
                .Parameters.Add("NO_GARANTIA", SqlDbType.VarChar).Value = NO_GARANTIA
                .Parameters.Add("ESTADO_FISICO", SqlDbType.VarChar).Value = ESTADO_FISICO
                .Parameters.Add("DEFECTO", SqlDbType.VarChar).Value = DEFECTO
                .Parameters.Add("MODELO", SqlDbType.VarChar).Value = MODELO
                .Parameters.Add("SERIE", SqlDbType.VarChar).Value = SERIE
                .Parameters.Add("IDEMPLEADO", SqlDbType.BigInt).Value = IDEMPLEADO
                .Parameters.Add("ORDEN_REP", SqlDbType.VarChar).Value = ORDEN_REP
                .Parameters.Add("FECHA_REP", SqlDbType.Date).Value = FECHA_REP
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
    Public Function fInsertarParametro(ByVal descripcion As String, ByVal porcentaje As Decimal) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarParametro]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("descripcion", SqlDbType.VarChar).Value = descripcion
                .Parameters.Add("porcentaje", SqlDbType.Decimal).Value = porcentaje
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
    Public Function fInsertarSolicitudCredito(ByVal idlugar As String, ByVal s_credito As String, ByVal cliente As Long,
                                              ByVal empleado As Long, ByVal faidor As Long, ByVal idclPlan As Long,
                                              ByVal fecha As Date, ByVal enganche As Decimal, ByVal cuotas As Int16,
                                              ByVal vcuota As Decimal, ByVal ucuota As Decimal, ByVal modificacion As Decimal,
                                              ByVal total As Decimal, ByVal observacion As String, ByVal comp_engacnhe As Decimal,
                                              ByVal letra As DataTable, ByVal detalle As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarSolicitudCredito]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("s_credito", SqlDbType.VarChar).Value = s_credito
                .Parameters.Add("cliente", SqlDbType.BigInt).Value = cliente
                .Parameters.Add("empleado", SqlDbType.BigInt).Value = empleado
                .Parameters.Add("fiador", SqlDbType.BigInt).Value = faidor
                .Parameters.Add("idcPlan", SqlDbType.BigInt).Value = idclPlan
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("enganche", SqlDbType.Decimal).Value = enganche
                .Parameters.Add("cuotas", SqlDbType.SmallInt).Value = cuotas
                .Parameters.Add("vcuota", SqlDbType.Decimal).Value = vcuota
                .Parameters.Add("ucuota", SqlDbType.Decimal).Value = ucuota
                .Parameters.Add("modificacion", SqlDbType.Decimal).Value = modificacion
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("observacion", SqlDbType.VarChar).Value = observacion
                .Parameters.Add("comp_enganche", SqlDbType.Decimal).Value = comp_engacnhe
                .Parameters.Add("letra", SqlDbType.Structured).Value = letra
                .Parameters.Add("detalle", SqlDbType.Structured).Value = detalle
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
    Public Function fInsertarSolicitudFacturarContado(ByVal idlugar As String, ByVal nit As String, ByVal cnombre As String,
                                              ByVal cdireccion As String, ByVal idempleadoe As Long, ByVal fecha As Date,
                                              ByVal descuento As Decimal, ByVal total As Decimal, ByVal detalle As DataTable) As Integer

        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarSolicitudfacturarContado]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idlugar", SqlDbType.VarChar).Value = idlugar
                .Parameters.Add("nit", SqlDbType.VarChar).Value = nit
                .Parameters.Add("cnombre", SqlDbType.VarChar).Value = cnombre
                .Parameters.Add("cdireccion", SqlDbType.VarChar).Value = cdireccion
                .Parameters.Add("idempleadoe", SqlDbType.BigInt).Value = idempleadoe
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
                .Parameters.Add("descuento", SqlDbType.Decimal).Value = descuento
                .Parameters.Add("total", SqlDbType.Decimal).Value = total
                .Parameters.Add("detalle", SqlDbType.Structured).Value = detalle
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
#Region "Actualizar"
    Public Function fActualizarProveedor(ByVal p_idproveedor As Long, ByVal p_Agente As String, ByVal p_NombreEmpresa As String, ByVal p_DireccionEmpresa As String,
                                       ByVal p_EmpNit As String, ByVal p_TelAgente As String, ByVal p_TelEmp1 As String, ByVal p_TelEmp2 As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarProveedor]"
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
            v_respuesta = clsComunes.Respuesta_Operacion.Modificado
        Catch ex As Exception
            v_respuesta = clsComunes.Respuesta_Operacion.Erronea
        Finally
            bd.fCerrar()
        End Try
        Return v_respuesta
    End Function
    Public Function fActualizarTipoCuenta(ByVal p_IdTipoCuenta As Int16, ByVal p_descripcion As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarTipoCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_IdTipoCuenta", SqlDbType.Int).Value = p_IdTipoCuenta
                .Parameters.Add("p_Descripcion", SqlDbType.VarChar).Value = p_descripcion
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
    Public Function fActualizarPeriodo(ByVal p_anio As Int16, ByVal p_mes As Int16, ByVal p_desde As Date, ByVal p_hasta As Date, ByVal p_inicio As Date, ByVal p_fin As Date) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarPeriodoCont]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_anio", SqlDbType.Int).Value = p_anio
                .Parameters.Add("p_mes", SqlDbType.Int).Value = p_mes
                .Parameters.Add("p_inicio", SqlDbType.Date).Value = p_desde
                .Parameters.Add("p_fin", SqlDbType.Date).Value = p_hasta
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
    Public Function fActualizarParametro(ByVal p_IdParametro As Int16, ByVal p_descripcion As String, ByVal p_porcentaje As Decimal) As Integer
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
    Public Function fActualizarCuenta(ByVal p_codigo As String, ByVal p_idtipo_cta As Int16, ByVal p_nombre As String, ByVal p_nivel As Int16, ByVal p_sumariza As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[CONT].[spModificarPlanCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@codigo_cta", SqlDbType.VarChar).Value = p_codigo
                .Parameters.Add("@idtipo_cta", SqlDbType.SmallInt).Value = p_idtipo_cta
                .Parameters.Add("@nombre", SqlDbType.VarChar).Value = p_nombre
                .Parameters.Add("@nivel", SqlDbType.SmallInt).Value = p_nivel
                .Parameters.Add("@sumariza", SqlDbType.VarChar).Value = p_sumariza
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
    Public Function fActualizarSolicitudCompra(ByVal p_IDSOLICITUD As Long, ByVal p_IDPROVEEDOR As Long, ByVal p_FECHA As Date,
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
    Public Function fActualizaEmpleado(ByVal p_idempleado As Int64,
                                    ByVal p_IDLUGAR As String,
                                    ByVal p_IDLU_PUESTO As Int64,
                                    ByVal p_DPI As String,
                                    ByVal P_NOMBRE As String,
                                    ByVal P_NOMBRE1 As String,
                                    ByVal P_APELLIDO As String,
                                    ByVal P_APELLIDO1 As String,
                                    ByVal P_EXTENDIDA As String,
                                    ByVal P_NIT As String,
                                    ByVal P_SEXO As String,
                                    ByVal P_DIRECCION As String,
                                    ByVal P_TELEFONO As String,
                                    ByVal P_CONYUGUE As String,
                                    ByVal P_FECHANAC As DateTime,
                                    ByVal P_ESTADO As String,
                                    ByVal P_ESTADO_CIVIL As String,
                                    ByVal P_NACIONALIDAD As String,
                                    ByVal P_VECINDAD As String,
                                    ByVal P_SUELDO_BASE As Decimal,
                                    ByVal P_foto As Image) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spActualizaEmpleado]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idempleado", SqlDbType.BigInt).Value = p_idempleado
                .Parameters.Add("IDLUGAR", SqlDbType.VarChar).Value = p_IDLUGAR
                .Parameters.Add("IDLU_PUESTO", SqlDbType.BigInt).Value = p_IDLU_PUESTO
                .Parameters.Add("DPI", SqlDbType.VarChar).Value = p_DPI
                .Parameters.Add("NOMBRE", SqlDbType.VarChar).Value = P_NOMBRE
                .Parameters.Add("NOMBRE1", SqlDbType.VarChar).Value = P_NOMBRE1
                .Parameters.Add("APELLIDO", SqlDbType.VarChar).Value = P_APELLIDO
                .Parameters.Add("APELLIDO1", SqlDbType.VarChar).Value = P_APELLIDO1
                .Parameters.Add("EXTENDIDA", SqlDbType.VarChar).Value = P_EXTENDIDA
                .Parameters.Add("NIT", SqlDbType.VarChar).Value = P_NIT
                .Parameters.Add("SEXO", SqlDbType.VarChar).Value = P_SEXO
                .Parameters.Add("DIRECCION", SqlDbType.VarChar).Value = P_DIRECCION
                .Parameters.Add("TELEFONO", SqlDbType.VarChar).Value = P_TELEFONO
                .Parameters.Add("CONYUGUE", SqlDbType.VarChar).Value = P_CONYUGUE
                .Parameters.Add("FECHANAC", SqlDbType.Date).Value = P_FECHANAC
                .Parameters.Add("ESTADO", SqlDbType.VarChar).Value = P_ESTADO
                .Parameters.Add("ESTADO_CIVIL", SqlDbType.VarChar).Value = P_ESTADO_CIVIL
                .Parameters.Add("NACIONALIDAD", SqlDbType.VarChar).Value = P_NACIONALIDAD
                .Parameters.Add("VECINDAD", SqlDbType.VarChar).Value = P_VECINDAD
                .Parameters.Add("SUELDO_BASE", SqlDbType.Decimal).Value = P_SUELDO_BASE
                .Parameters.Add("foto", SqlDbType.Image).Value = P_foto
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
    Public Function fActualizaModelos(ByVal p_MODELOS As DataTable) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spActualizaModelos]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("MODELOS", SqlDbType.Structured).Value = p_MODELOS
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
    Public Function fActualizarMaterial(ByVal p_idmaterial As Long, ByVal p_Nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarMaterial]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_idFamilia", SqlDbType.BigInt).Value = p_idmaterial
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
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
    Public Function fActualizarFamilia(ByVal p_idFamilia As Long, ByVal p_Nombre As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarFamilia]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_idprfamilia", SqlDbType.BigInt).Value = p_idFamilia
                .Parameters.Add("p_Nombre", SqlDbType.VarChar).Value = p_Nombre
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
#End Region
#Region "Aceptar"
    Public Function fAceptarEnvioEntrante(ByVal p_sale As String,
                                    ByVal p_fecha As DateTime,
                                    ByVal p_iden_tipo As Int64,
                                    ByVal p_idenvio As Int64,
                                    ByVal p_idusuario As Int64,
                                    ByVal p_destino As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAceptarEnvioEntrante]"
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("sale", SqlDbType.VarChar).Value = p_sale
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = p_fecha
                .Parameters.Add("iden_tipo", SqlDbType.BigInt).Value = p_iden_tipo
                .Parameters.Add("idenvio", SqlDbType.BigInt).Value = p_idenvio
                .Parameters.Add("idusuario", SqlDbType.BigInt).Value = p_idusuario
                .Parameters.Add("destino", SqlDbType.VarChar).Value = p_destino
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
    Public Function fAceptarSolCreditoSinEng(ByVal p_idLugar As String,
                                        ByVal p_serieCredito As String,
                                        ByVal p_idCredito As Int64,
                                        ByVal p_idEmpleado As Int64,
                                        ByVal p_fecha As DateTime) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAceptarSolCreditoSinEng]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idLugar", SqlDbType.VarChar).Value = p_idLugar
                .Parameters.Add("serieCredito", SqlDbType.VarChar).Value = p_serieCredito
                .Parameters.Add("idCredito", SqlDbType.BigInt).Value = p_idCredito
                .Parameters.Add("idEmpleado", SqlDbType.BigInt).Value = p_idEmpleado
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = p_fecha
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
    Public Function fAceptarSolEnvio(ByVal p_sale As String,
                                 ByVal p_iden_tipo As Int64,
                                 ByVal p_idenvio As Int64,
                                 ByVal p_idusuario As Int64,
                                 ByVal p_destino As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAceptarSolEnvio]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("sale", SqlDbType.VarChar).Value = p_sale
                .Parameters.Add("iden_tipo", SqlDbType.BigInt).Value = p_iden_tipo
                .Parameters.Add("idenvio", SqlDbType.BigInt).Value = p_idenvio
                .Parameters.Add("idusuario", SqlDbType.BigInt).Value = p_idusuario
                .Parameters.Add("destino", SqlDbType.VarChar).Value = p_destino
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
    Public Function fAceptarSolVentaContado(ByVal p_idugar As String,
                                        ByVal p_serie_factura As String,
                                        ByVal p_idfactura_nueva As Int64,
                                        ByVal p_idfactura_temp As Int64,
                                        ByVal p_nit As String,
                                        ByVal p_cliente As String,
                                        ByVal p_direccion As String,
                                        ByVal p_idempleadoc As String,
                                        ByVal p_fecha As DateTime) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spAceptarSolVentaContado]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("idugar", SqlDbType.VarChar).Value = p_idugar
                .Parameters.Add("serie_factura", SqlDbType.VarChar).Value = p_serie_factura
                .Parameters.Add("idfactura_nueva", SqlDbType.BigInt).Value = p_idfactura_nueva
                .Parameters.Add("idfactura_temp", SqlDbType.BigInt).Value = p_idfactura_temp
                .Parameters.Add("nit", SqlDbType.VarChar).Value = p_nit
                .Parameters.Add("cliente", SqlDbType.VarChar).Value = p_cliente
                .Parameters.Add("direccion", SqlDbType.VarChar).Value = p_direccion
                .Parameters.Add("idempleadoc", SqlDbType.VarChar).Value = p_idempleadoc
                .Parameters.Add("fecha", SqlDbType.DateTime).Value = p_fecha
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
#Region "Listar"

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
    Public Function fListarCuenta() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[CONT].[spListarPlanCuenta]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarMayorizar() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarCuentaMayorizar]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarTipoCuenta() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarTipoCuenta]"
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
    Public Function fListarFacturaCompra(ByVal P_IDPROVEEDOR As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarFac_Compra]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarFamiliaes() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarFamilia]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarMaterial() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarMaterial]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarProductos() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spbuscarProducto]"
                .Parameters.Add("p_proveedor", SqlDbType.VarChar).Value = "%%"
                .Parameters.Add("p_familia", SqlDbType.VarChar).Value = "%%"
                .Parameters.Add("p_material", SqlDbType.VarChar).Value = "%%"
                .Parameters.Add("p_modelo", SqlDbType.VarChar).Value = "%%"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
            Ext.Net.X.Msg.Notify("Error Inesperado", ex.Message).Show()
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function

    Public Function fListarProductos(ByVal proveedor As String, ByVal familia As String,
                                     ByVal material As String, ByVal modelo As String) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spbuscarProducto]"
                .Parameters.Add("p_proveedor", SqlDbType.VarChar).Value = proveedor
                .Parameters.Add("p_familia", SqlDbType.VarChar).Value = familia
                .Parameters.Add("p_material", SqlDbType.VarChar).Value = material
                .Parameters.Add("p_modelo", SqlDbType.VarChar).Value = modelo
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarProveedores() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spListarProveedores]"
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fListarInventario(ByVal p_idlugar As String, ByVal p_familia As String,
                                    ByVal p_material As String, ByVal p_modelo As String,
                                      ByVal p_estado As String) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .Connection = bd.ObtenerConexion
                .CommandType = CommandType.StoredProcedure
                .CommandText = "[dbo].[spBuscarInventario]"
                .Parameters.Add("p_lugar", SqlDbType.VarChar).Value = p_idlugar
                .Parameters.Add("p_familia", SqlDbType.VarChar).Value = p_familia
                .Parameters.Add("p_marca", SqlDbType.VarChar).Value = p_material
                .Parameters.Add("p_modelo", SqlDbType.VarChar).Value = p_modelo
                .Parameters.Add("p_estado", SqlDbType.VarChar).Value = p_estado
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
#End Region
#Region "Obtener"
    Public Function fObtenerTipoCuenta(ByVal p_id As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spObtenerTipoCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_TipoCuenta", SqlDbType.Int).Value = p_id
                .Parameters.Add("v_estado", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue
            End With
            dt.Load(bd._Cmd.ExecuteReader())
        Catch ex As Exception
        Finally
            bd.fCerrar()
        End Try
        Return dt
    End Function
    Public Function fObtenerParametro(ByVal p_id As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spObtenerParametro]"
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
    Public Function fObtenerCuenta(ByVal p_codigo As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[CONT].[spObtenerCuenta]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@codigo_cta", SqlDbType.VarChar).Value = p_codigo
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
                .CommandText = "[dbo].[spObtenerProveedor]"
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
