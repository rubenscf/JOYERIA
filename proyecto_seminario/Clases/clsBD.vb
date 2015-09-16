Imports System.Data.SqlClient
Public Class clsGestorBaseDatos
    Private _CadenaConexion As String = "Data Source=23.91.123.136;Initial Catalog=Umg_prueba;Persist Security Info=True;User ID=desarrollo;Password=Des@rr0ll0"

    ' Private _CadenaConexion As String = "Data Source=ALEX\SQLEXPRESS;Initial Catalog=contabilidad;Persist Security Info=True"
    Private _Cnn As SqlConnection
    Public _Cmd As SqlCommand


    Public Sub fAbrir()
        _Cnn = New SqlConnection(_CadenaConexion)
        _Cnn.Open()
        _Cmd = New SqlCommand
        _Cmd.Connection = _Cnn
    End Sub
    Public Sub fCerrar()
        _Cnn.Close()
    End Sub

End Class
