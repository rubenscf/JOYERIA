Imports System.Net.Mail

Public Class clsControladorCorreo
    Public Function Enviar_Correo(ByVal CorreoDestino As String, ByVal Asunto As String, ByVal Cuerpo As String) As String
        Dim Respuesta As String = ""
        Try
            Dim oMsg As MailMessage = New MailMessage("soporte@lanchoa.com", CorreoDestino, Asunto, Cuerpo)
            Dim SmtpMail As New SmtpClient
            ' TODO: Replace with sender e-mail address.


            ' ADD AN ATTACHMENT.
            ' TODO: Replace with path to attachment.
            '    Dim sFile As String = "C:\temp\Hello.txt"
            '   Dim oAttch As MailAttachment = New MailAttachment(sFile, MailEncoding.Base64)

            '    oMsg.Attachments.Add(oAttch)

            ' TODO: Replace with the name of your remote SMTP server.
            SmtpMail.Host = "smpt.ioguate.com"
            SmtpMail.Send(oMsg)
            Respuesta = "Mensaje Enviado"
        Catch ex As Exception
            Respuesta = ex.Message
        End Try
        Return Respuesta
    End Function

End Class
