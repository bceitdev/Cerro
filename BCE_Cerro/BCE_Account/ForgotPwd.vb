Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports EASendMail
Public Class ForgotPwd
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ForgotPwd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    <Obsolete>
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            strQuery = "SELECT password, email FROM vw_acctmaster
                        WHERE employeeid = @emplid"
            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("emplid", txt_emplid.Text.Trim)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                Dim pw As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                Dim oMail As New SmtpMail("TryIt")
                oMail.From = New EASendMail.MailAddress("Cerro", ConfigurationSettings.AppSettings("Username"))
                oMail.To = email
                oMail.Subject = "Forgot Password"
                oMail.HtmlBody = "Your password is " & pw

                Dim oServer As New SmtpServer(ConfigurationSettings.AppSettings("Host"))
                oServer.User = ConfigurationSettings.AppSettings("Username")
                oServer.Password = ConfigurationSettings.AppSettings("Password")
                oServer.ConnectType = SmtpConnectType.ConnectTryTLS
                oServer.Port = 587
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

                Dim oSmtp As New EASendMail.SmtpClient()
                oSmtp.SendMail(oServer, oMail)

                MetroMessageBox.Show(BCEParent, "Your password has been sent to your email", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_emplid_Click(sender As Object, e As EventArgs) Handles txt_emplid.Click

    End Sub

    Private Sub txt_emplid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_emplid.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub ForgotPwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class