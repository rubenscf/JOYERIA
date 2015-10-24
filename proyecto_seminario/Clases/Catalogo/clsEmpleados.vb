Public Class clsEmpleados
    Public Function fInscribirEmpleado(ByVal p_id_lugar As String, ByVal p_idlu_puesto As Int64, ByVal p_dpi As String, ByVal p_nombre As String,
                                       ByVal p_nombre1 As String, ByVal p_apellido As String, ByVal p_apellido1 As String, ByVal p_extendida As String,
                                       ByVal p_nit As String, ByVal p_sexo As String, ByVal p_direccion As String, p_telefono As String,
                                       ByVal p_conyuge As String, ByVal p_fecha_nac As Date, ByVal p_usuario As String, ByVal p_pass As String,
                                       ByVal p_estado_civil As String, ByVal p_nacionalidad As String, ByVal p_vecindad As String,
                                       ByVal p_finicio As Date, ByVal p_servicios As String, ByVal p_duracion_contrato As String,
                                       ByVal p_tipo_jornada As String, ByVal p_hr_inicio_ls As String, ByVal p_hr_fin_ls As String,
                                       ByVal p_hr_inicio_dm As String, ByVal p_hr_fin_dm As String, p_sueldo_base As Decimal, ByVal p_pago_cada As String,
                                       ByVal p_foto As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[SP_AnularNotaSalida]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("p_id_lugar", SqlDbType.VarChar).Value = p_id_lugar
                .Parameters.Add("p_idlu_puesto", SqlDbType.BigInt).Value = p_idlu_puesto
                .Parameters.Add("p_dpi", SqlDbType.SmallInt).Value = p_dpi
                .Parameters.Add("p_nombre", SqlDbType.BigInt).Value = p_nombre
                .Parameters.Add("p_nombre1", SqlDbType.BigInt).Value = p_nombre1
                .Parameters.Add("p_apellido", SqlDbType.BigInt).Value = p_apellido
                .Parameters.Add("p_apellido1", SqlDbType.BigInt).Value = p_apellido1
                .Parameters.Add("p_extendida", SqlDbType.BigInt).Value = p_extendida
                .Parameters.Add("p_nit", SqlDbType.BigInt).Value = p_nit
                .Parameters.Add("p_sexo", SqlDbType.BigInt).Value = p_sexo
                .Parameters.Add("p_direccion", SqlDbType.BigInt).Value = p_direccion
                .Parameters.Add("p_telefono", SqlDbType.BigInt).Value = p_telefono
                .Parameters.Add("p_conyuge", SqlDbType.BigInt).Value = p_conyuge
                .Parameters.Add("p_fecha_nac", SqlDbType.BigInt).Value = p_fecha_nac
                .Parameters.Add("p_usuario", SqlDbType.BigInt).Value = p_usuario
                .Parameters.Add("p_pass", SqlDbType.BigInt).Value = p_pass
                .Parameters.Add("p_estado_civil", SqlDbType.BigInt).Value = p_estado_civil
                .Parameters.Add("p_nacionalidad", SqlDbType.BigInt).Value = p_nacionalidad
                .Parameters.Add("p_vecindad", SqlDbType.BigInt).Value = p_vecindad
                .Parameters.Add("p_finicio", SqlDbType.BigInt).Value = p_finicio
                .Parameters.Add("p_servicios", SqlDbType.BigInt).Value = p_servicios
                .Parameters.Add("p_duracion_contrato", SqlDbType.BigInt).Value = p_duracion_contrato
                .Parameters.Add("p_tipo_jornada", SqlDbType.BigInt).Value = p_tipo_jornada
                .Parameters.Add("p_hr_inicio_ls", SqlDbType.BigInt).Value = p_hr_inicio_ls
                .Parameters.Add("p_hr_fin_ls", SqlDbType.BigInt).Value = p_hr_fin_ls
                .Parameters.Add("p_hr_inicio_dm", SqlDbType.BigInt).Value = p_hr_inicio_dm
                .Parameters.Add("p_hr_fin_dm", SqlDbType.BigInt).Value = p_hr_fin_dm
                .Parameters.Add("p_sueldo_base", SqlDbType.BigInt).Value = p_sueldo_base
                .Parameters.Add("p_pago_cada", SqlDbType.BigInt).Value = p_pago_cada
                .Parameters.Add("p_foto", SqlDbType.BigInt).Value = p_foto
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
End Class
