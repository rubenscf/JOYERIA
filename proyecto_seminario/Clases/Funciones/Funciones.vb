Imports System.Data.SqlClient

Namespace Funciones
    Public Module Funciones

        Public Function _Num2Text(ByVal value As Double) As String
            Select Case value
                Case 0 : _Num2Text = "CERO"
                Case 1 : _Num2Text = "UN"
                Case 2 : _Num2Text = "DOS"
                Case 3 : _Num2Text = "TRES"
                Case 4 : _Num2Text = "CUATRO"
                Case 5 : _Num2Text = "CINCO"
                Case 6 : _Num2Text = "SEIS"
                Case 7 : _Num2Text = "SIETE"
                Case 8 : _Num2Text = "OCHO"
                Case 9 : _Num2Text = "NUEVE"
                Case 10 : _Num2Text = "DIEZ"
                Case 11 : _Num2Text = "ONCE"
                Case 12 : _Num2Text = "DOCE"
                Case 13 : _Num2Text = "TRECE"
                Case 14 : _Num2Text = "CATORCE"
                Case 15 : _Num2Text = "QUINCE"
                Case Is < 20 : _Num2Text = "DIECI" & _Num2Text(value - 10)
                Case 20 : _Num2Text = "VEINTE"
                Case Is < 30 : _Num2Text = "VEINTI" & _Num2Text(value - 20)
                Case 30 : _Num2Text = "TREINTA"
                Case 40 : _Num2Text = "CUARENTA"
                Case 50 : _Num2Text = "CINCUENTA"
                Case 60 : _Num2Text = "SESENTA"
                Case 70 : _Num2Text = "SETENTA"
                Case 80 : _Num2Text = "OCHENTA"
                Case 90 : _Num2Text = "NOVENTA"
                Case Is < 100 : _Num2Text = _Num2Text(Int(value \ 10) * 10) & " Y " & _Num2Text(value Mod 10)
                Case 100 : _Num2Text = "CIEN"
                Case Is < 200 : _Num2Text = "CIENTO " & _Num2Text(value - 100)
                Case 200, 300, 400, 600, 800 : _Num2Text = _Num2Text(Int(value \ 100)) & "CIENTOS"
                Case 500 : _Num2Text = "QUINIENTOS"
                Case 700 : _Num2Text = "SETECIENTOS"
                Case 900 : _Num2Text = "NOVECIENTOS"
                Case Is < 1000 : _Num2Text = _Num2Text(Int(value \ 100) * 100) & " " & _Num2Text(value Mod 100)
                Case 1000 : _Num2Text = "MIL"
                Case Is < 2000 : _Num2Text = "MIL " & _Num2Text(value Mod 1000)
                Case Is < 1000000 : _Num2Text = _Num2Text(Int(value \ 1000)) & " MIL"
                    If value Mod 1000 Then _Num2Text = _Num2Text & " " & _Num2Text(value Mod 1000)
                Case 1000000 : _Num2Text = "UN MILLON"
                Case Is < 2000000 : _Num2Text = "UN MILLON " & _Num2Text(value Mod 1000000)
                Case Is < 1000000000000.0# : _Num2Text = _Num2Text(Int(value / 1000000)) & " MILLONES "
                    If (value - Int(value / 1000000) * 1000000) Then _Num2Text = _Num2Text & " " & _Num2Text(value - Int(value / 1000000) * 1000000)
                Case 1000000000000.0# : _Num2Text = "UN BILLON"
                Case Is < 2000000000000.0# : _Num2Text = "UN BILLON " & _Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
                Case Else : _Num2Text = _Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                    If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then _Num2Text = _Num2Text & " " & _Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            End Select
        End Function


        Public Function _NITvalido(ByVal Nit As String) As Boolean
            If Nit = "c/f" Or Nit = "C/F" Then
                Return True
            Else
                Try
                    Dim pos As Integer = Nit.IndexOf("-")
                    Dim Correlativo As String = Nit.Substring(0, pos)
                    Dim DigitoVerificador As String = Nit.Substring(pos + 1)
                    Dim Factor As Integer = Correlativo.Length + 1
                    Dim Suma As Integer = 0
                    Dim Valor As Integer = 0
                    For x As Integer = 0 To Nit.IndexOf("-") - 1
                        Valor = CInt(Nit.Substring(x, 1))
                        Suma = Suma + (Valor * Factor)
                        Factor = Factor - 1
                    Next

                    Dim xMOd11 As Double
                    xMOd11 = (11 - (Suma Mod 11)) Mod 11
                    Dim s As String = Str(xMOd11)

                    If (xMOd11 = 10 And DigitoVerificador = "K") Or (s.Trim = DigitoVerificador) Then

                        Return True
                    End If
                    Return False
                Catch ex As Exception
                    Return False
                End Try
            End If
        End Function
        Function _EXISTE_EN_DB(ByVal query As String) As Boolean
            Dim r As SqlDataReader
            Dim bd As New clsGestorBaseDatos
            Dim resp As Boolean
            Try
                bd.fAbrir()
                r = _CONSULTAR_SQL(query)
                If r.HasRows Then
                    resp = True
                Else
                    resp = False
                End If
            Catch ex As SqlException
                ' _estado(ex.Message, -1)
            Finally
                bd.fCerrar()
            End Try
            Return resp
        End Function
        Function _VerAnterior() As Int16
            Dim query As String = "SELECT TOP 1 anterior from GEN_PARAMETRO"
            Dim valor As Int16
            Dim bd As New clsGestorBaseDatos
            Try
                bd.fAbrir()
                Dim r As SqlDataReader = _CONSULTAR_SQL(query)
                If r.HasRows Then
                    While r.Read()
                        valor = r.GetInt16(0)
                    End While
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                bd.fCerrar()
            End Try
            Return valor
        End Function



        Function _CONSULTAR_SQL(ByVal query As String) As SqlDataReader
            Dim bd As New clsGestorBaseDatos
            bd.fAbrir()
            bd._Cmd = New SqlCommand(query, bd.ObtenerConexion)
            Dim r As SqlDataReader = bd._Cmd.ExecuteReader()
            Return r
        End Function

        Function _EJECUTAR_SQL(ByVal query As String) As Integer
            Try
                Dim bd As New clsGestorBaseDatos
                bd._Cmd = New SqlCommand(query, bd.ObtenerConexion())
                bd._Cmd.ExecuteNonQuery()
                Return 1
            Catch ex As Exception
                '    _estado(ex.Message, -1)
                Return -1
            End Try
        End Function

    End Module
End Namespace