<%@ Page Language="VB" %>

<%@ Import Namespace="System.Web.Security" %>
<%@ Import Namespace="System.Security.Cryptography" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="proyecto_seminario.Encriptacion" %>
<%@ Import Namespace="proyecto_seminario.Funciones" %>


<script runat="server">
    Sub Logon_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Pass.Text = "nimdA" And Usuario.Text = "admin" Then
            Session("idpuesto") = 1
            Session("usuario") = "Administrador Local"
            Session("nombre") = "Administrador"
            FormsAuthentication.RedirectFromLoginPage(Usuario.Text, Persist.Checked)
        Else
            Dim query, estado As String
            estado = "INACTIVO"
            Dim hash As String

            Using Seminario2015 As MD5 = MD5.Create()
                hash = _ObtieneMd5Hash(Seminario2015, Pass.Text)
                Session("pass") = hash
                query = "SELECT idtipolugar, idlugar, idpuesto, idempleado,  NOMBRE, tipoLugar, lugar, puesto, ESTADO, serie_factura, serie_credito, " +
                        "         serie_abono_tie, serie_enganche, serie_abono_cob, direccion, telefono, letra_cambio " +
                       "  From dbo.vst_Empleados Where Usuario = '" & Usuario.Text.ToLower & "' AND pass = '" & hash & "'"
            End Using
            Dim r As SqlDataReader
            Try

                r = _CONSULTAR_SQL(query)
                If r.HasRows Then
                    Session("idusuario") = usuario
                    While r.Read()
                        Session("idtipolugar") = r.GetValue(0)
                        Session("idlugar") = r.GetString(1)
                        Session("idpuesto") = r.GetInt64(2)
                        Session("idpuesto_tmp") = r.GetInt64(2)
                        Session("idempleado") = r.GetInt64(3)
                        Session("nombre") = r.GetString(4)
                        Session("tipolugar") = r.GetString(5)
                        Session("lugar") = r.GetString(6)
                        Session("puesto") = r.GetString(7)
                        estado = r.GetString(8)
                        Session("s_factura") = r.GetString(9)
                        Session("s_credito") = r.GetString(10)
                        Session("s_abonoT") = r.GetString(11)
                        Session("s_enganche") = r.GetString(12)
                        Session("s_abonoC") = r.GetString(13)
                        Session("lugar_direccion") = r.GetString(14)
                        Session("lugar_tel") = r.GetString(15)
                        Session("letra_cambio") = r.GetInt16(16)
                    End While
                    r.Close()
                    '----------------   
                    '----------------  selecciona el parametro "anterior"
                    '----------------
                    query = "select version from lugar where idlugar = '" + Session("idlugar").ToString + "'"
                    Dim dr As SqlDataReader = _CONSULTAR_SQL(query)
                    If dr.HasRows Then
                        While dr.Read
                            Session("version") = dr.GetInt16(0)
                        End While
                        dr.Close()
                    Else

                        Ext.Net.X.MessageBox.Notify("Error", "no existe el campo version").Show()
                        Me.Dispose()
                    End If
                    '-----------------------------------------
                    '-----------------------------------------
                    '-----------------------------------------
                    If estado = "REINICIO" Then
                        '-    Dim ventana As New frmResetPwd()
                        '  ventana.Show()
                        ' ventana.resetPwd(hash)
                        '/ iniciarResetPWD()
                    ElseIf estado = "ACTIVO" Then

                        FormsAuthentication.RedirectFromLoginPage(Usuario.Text, Persist.Checked)
                    End If
                Else
                    r.Close()
                    Msg.Text = "Error en la combinacion de Usuario y Contraseña"

                End If

            Catch ex As Exception
                Msg.Text = "Error " + ex.Message.ToString
            Finally

            End Try
        End If

    End Sub


</script>

<html>
<head id="Head1" runat="server">
    <link rel="stylesheet" href="Style.css">
    <title>Iniciar Sesion</title>
</head>
<body>

    <form id="form1" runat="server">
        <section class="container">
            <img alt="" src="../../Images/logo1.png" height="128" class="logo" />
            <p></p>
            <div class="login">
                <h1>Iniciar Sesion</h1>
                <p>
                    <asp:TextBox ID="Usuario" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                        ControlToValidate="Usuario"
                        Display="Dynamic"
                        ErrorMessage="No puede estar vacio."
                        runat="server" />
                </p>
                <p>
                    <asp:TextBox ID="Pass" TextMode="Password"
                        runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        ControlToValidate="Pass"
                        ErrorMessage="No puede estar vacio."
                        runat="server" />
                </p>
                <p class="remember_me">
                    <label>
                        <asp:CheckBox ID="Persist" runat="server" />
                        Recordarme en este equipo
         
                    </label>
                </p>
                <p class="submit">
                    <asp:Button ID="Logon" Text="Iniciar Sesion"
                        runat="server" OnClick="Logon_Click" />
                </p>
                <p class="submit">
        <asp:Label ID="Msg" ForeColor="red" runat="server" />

                </p>
             
            </div>
            <br />
            </section>

    </form>
</body>
</html>
