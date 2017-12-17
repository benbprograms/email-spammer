Imports System.Net.Mail
Imports System.Net
Public Class Form1
    Public mail As New MailMessage
    Public smtp As New SmtpClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ToAddr, FromAddr As String
        'smtp setup
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New Net.NetworkCredential("example@gmail.com", "password") ' must be a gmail account
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Host = "smtp.gmail.com"
        'mail setup
        ToAddr = "example@example.com" ' who the email is to '
        FromAddr = "example@example.com" ' who the email i'
        mail.From = New MailAddress(FromAddr)
        mail.To.Add(ToAddr)
        mail.Subject = "email sending..."
        mail.IsBodyHtml = False
        mail.Body = "hello" & Environment.NewLine & "this is a test" & Environment.NewLine & "ignore this!"
        Dim emailSent As Integer = 0
        'send the email
        Do Until emailSent = 100
            smtp.Send(mail)
            emailSent += 1
            Label1.Text = "emails sent " & emailSent
        Loop
    End Sub
End Class
