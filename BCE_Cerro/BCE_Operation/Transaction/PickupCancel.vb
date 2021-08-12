Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports EASendMail
Public Class PickupCancel

    Dim charge As String

    Private Sub PickupCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_Charge.Checked = True
    End Sub

    Private Sub PickupCancel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    <Obsolete>
    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim mbox As String

            If txt_Reason.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Reason or Comment", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_Reason.Focus()
            Else
                mbox = MetroMessageBox.Show(BCEParent, "Are you sure you want to cancel?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If mbox = vbYes Then

                    strQuery = "UPDATE tbl_ops_pickupdispatch SET status = 'FOR CANCELLATION',
                                                              [ischargetoclient?] = '" & charge & "',
                                                              reason = @reason
                                WHERE pickupschedid = '" & CancelId & "'"
                    cmd.CommandText = strQuery
                    cmd.Parameters.AddWithValue("reason", txt_Reason.Text)
                    dt = GetData(cmd)

                    'Dim email As String = ""

                    'Dim oMail As New SmtpMail("TryIt")
                    'oMail.From = New EASendMail.MailAddress("Cerro", ConfigurationSettings.AppSettings("Username"))
                    'oMail.To = email
                    'oMail.Subject = "Account Request Approved"
                    'oMail.HtmlBody = ""

                    'Dim oServer As New SmtpServer(ConfigurationSettings.AppSettings("Host"))
                    'oServer.User = ConfigurationSettings.AppSettings("Username")
                    'oServer.Password = ConfigurationSettings.AppSettings("Password")
                    'oServer.ConnectType = SmtpConnectType.ConnectTryTLS
                    'oServer.Port = 587
                    'oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

                    'Dim oSmtp As New EASendMail.SmtpClient()
                    'oSmtp.SendMail(oServer, oMail)

                    OPS_PickUpList.CboViewPickupList()
                    Me.Close()
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Rb_Charge_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Charge.CheckedChanged
        If rb_Charge.Checked = True Then
            charge = "YES"
        End If
    End Sub

    Private Sub Rb_Free_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Free.CheckedChanged
        If rb_Free.Checked = True Then
            charge = "NO"
        End If
    End Sub
End Class