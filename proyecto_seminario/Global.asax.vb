Imports System.Web.Optimization
Imports System.Web.Security
Imports System.Security.Principal

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Session.Add("idtipolugar", 0)
            Session.Add("idlugar", 0)
            Session.Add("idpuesto", 0)
            Session.Add("idpuesto_tmp", 0)
            Session.Add("idempleado", 0)
            Session.Add("usuario", 0)
            Session.Add("pass", 0)
            Session.Add("nombre", 0)
            Session.Add("tipolugar", 0)
            Session.Add("lugar", 0)
            Session.Add("puesto", 0)
            Session.Add("estado", 0)
            Session.Add("s_factura", 0)
            Session.Add("s_credito", 0)
            Session.Add("s_enganche", 0)
            Session.Add("s_abonoT", 0)
            Session.Add("s_abonoC", 0)
            Session.Add("version", 0)
            Session.Add("direccion", 0)
            Session.Add("telefono", 0)
            Session.Add("letra_cambio", 0)
        Catch ex As Exception

        End Try

    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use


    End Sub


    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        '   Session.Abandon()
        '  Session.Clear()

    End Sub
End Class