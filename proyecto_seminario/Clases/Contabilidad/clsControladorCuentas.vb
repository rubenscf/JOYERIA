﻿Public Class clsControladorCuentas
#Region "Funciones Publicas"
    Public Function fIngresarCuenta(ByVal p_codigo As String, ByVal p_idtipo_cta As Int16, ByVal p_nombre As String, ByVal p_mayoriza As String, ByVal p_nivel As Int16, ByVal p_sumariza As String, ByVal p_mov As String, ByVal p_ajuste As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spInsertarPlanCuentas]"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("codigo_cta", SqlDbType.VarChar).Value = p_codigo
                .Parameters.Add("idtipo_cta", SqlDbType.SmallInt).Value = p_idtipo_cta
                .Parameters.Add("nombre", SqlDbType.VarChar).Value = p_nombre
                .Parameters.Add("mayoriza", SqlDbType.VarChar).Value = p_mayoriza
                .Parameters.Add("nivel", SqlDbType.SmallInt).Value = p_nivel
                .Parameters.Add("sumariza", SqlDbType.VarChar).Value = p_sumariza
                .Parameters.Add("movimiento", SqlDbType.VarChar).Value = p_mov
                .Parameters.Add("ajuste", SqlDbType.VarChar).Value = p_ajuste
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
    Public Function fModificarCuenta(ByVal p_codigo As String, ByVal p_idtipo_cta As Int16, ByVal p_nombre As String, ByVal p_mayoriza As String, ByVal p_nivel As Int16, ByVal p_sumariza As String, ByVal p_mov As String, ByVal p_ajuste As String) As Integer
        Dim v_respuesta As Integer = 0
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spModificarPlanCuenta]"
                .CommandType = CommandType.StoredProcedure
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("codigo", SqlDbType.VarChar).Value = p_codigo
                .Parameters.Add("tipo", SqlDbType.SmallInt).Value = p_idtipo_cta
                .Parameters.Add("nombre", SqlDbType.VarChar).Value = p_nombre
                .Parameters.Add("mayoriza", SqlDbType.VarChar).Value = p_mayoriza
                .Parameters.Add("nivel", SqlDbType.SmallInt).Value = p_nivel
                .Parameters.Add("sumariza", SqlDbType.VarChar).Value = p_sumariza
                .Parameters.Add("mov", SqlDbType.VarChar).Value = p_mov
                .Parameters.Add("ajuste", SqlDbType.VarChar).Value = p_ajuste
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
    Public Function fListarCuenta() As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spListarPlanCuenta]"
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
    Public Function fObtenerCuenta(ByVal p_codigo As Long) As DataTable
        Dim dt As New DataTable
        Dim bd As New clsGestorBaseDatos
        Try
            bd.fAbrir()
            With bd._Cmd
                .CommandText = "[dbo].[spObtenerCuenta]"
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


    Public Function _COMBO() As DataTable
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




#End Region
End Class
