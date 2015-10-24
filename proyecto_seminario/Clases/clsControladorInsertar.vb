Public Class clsControladorInsertar
#Region "Funciones Publicas"
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

End Class

