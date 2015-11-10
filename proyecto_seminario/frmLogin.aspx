<%@ Page Language="VB" %>
<%@ Import Namespace="System.Security.Cryptography" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ import Namespace="proyecto_seminario.Encriptacion" %>
<%@ import Namespace="proyecto_seminario.Funciones" %>


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
  <title>Forms Authentication - Login</title>
</head>
<body>
  <form id="form1" runat="server">
    <h3>
      Logon Page</h3>
    <table>
      <tr>
        <td>
          Usuario:</td>
        <td>
          <asp:TextBox ID="Usuario" runat="server" /></td>
        <td>
             </td>
      </tr>
      <tr>
        <td>
          Contrasenia:</td>
        <td>
          <asp:TextBox ID="Pass" TextMode="Password" 
            runat="server" />
        </td>
        <td>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            ControlToValidate="Pass"
            ErrorMessage="No Puede estar vacio." 
            runat="server" />
        </td>
      </tr>
      <tr>
        <td>
          Remember me?</td>
        <td>
          <asp:CheckBox ID="Persist" runat="server" /></td>
      </tr>
    </table>
    <asp:Button ID="Submit1" OnClick="Logon_Click" Text="Log On"  
       runat="server" />
    <p>
      <asp:Label ID="Msg" ForeColor="red" runat="server" />
    </p>
  </form>
</body>
</html>