Imports System.Data.SqlClient
Public Class clsGestorBaseDatos
    Private _CadenaConexion As String = "Data Source=hazel.arvixe.com;Initial Catalog=seminario_joyeria;Persist Security Info=True;User ID=seminario_umg;Password=umg123"
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
