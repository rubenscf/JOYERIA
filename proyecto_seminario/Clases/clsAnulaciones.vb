Public Class clsAnulaciones
    Public Function fAnularNotaSalida(ByVal p_lugar As String, ByVal p_id_nota As Int64, ByVal p_version As Int16,
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

End Class
