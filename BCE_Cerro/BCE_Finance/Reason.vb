Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports EASendMail
Imports System.Configuration

Public Class Reason
    Public billingidrea As Integer
    Public obidcur, obidoth, trackidrea, billingcontrolno, trackingcontrolno, soacancelctrlno, disbcontrolno As String
    <Obsolete>
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If reasonreq = "Fin" Then
                If txt_Reason.Text = Nothing Then
                    MetroMessageBox.Show(BCEParent, "Must have Reason", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim mbox As String = MetroMessageBox.Show(BCEParent, "Are you sure?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If mbox = vbYes Then
                        strQuery = "EXEC ins_billingrev @billingid = @billingid,
												@sysremarks = @sysremarks,
												@reason = @reason,
												@status = @status,
												@employeeid = @employeeid,
												@datecreated = @datecreated"

                        cmd.CommandText = strQuery
                        cmd.Parameters.AddWithValue("billingid", billingidrea)
                        If BillRev = True Then
                            cmd.Parameters.AddWithValue("sysremarks", "Removal of existing Tracking No.")
                        ElseIf BillRev = False Then
                            cmd.Parameters.AddWithValue("sysremarks", "Addition of other Tracking No.")
                        End If
                        cmd.Parameters.AddWithValue("reason", txt_Reason.Text)
                        cmd.Parameters.AddWithValue("status", "FOR REVISION")
                        cmd.Parameters.AddWithValue("employeeid", emplid)
                        cmd.Parameters.AddWithValue("datecreated", Date.Now)
                        dt = GetData(cmd)

                        strQuery = "SELECT immediatesuperior FROM tbl_employeemaster
                                    WHERE employeeid = '" & emplid & "'"

                        cmd.CommandText = strQuery
                        dt = GetData(cmd)

                        Dim fn As String = dt.Rows(dt.Rows.Count - 1).Item(0)

                        strQuery = "SELECT firstname, email FROM tbl_employeemaster
                                    WHERE fullname = '" & fn & "'"

                        cmd.CommandText = strQuery
                        dt = GetData(cmd)

                        Dim fn1 As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                        Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                        Dim oMail As New SmtpMail("TryIt")
                        oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
                        oMail.To = email
                        oMail.Subject = "SOA Revision Request"
                        oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & fn1 & ",
                                          <br>
                                          <br>" & FirstName & " is requesting for a revision of SOA with the following details:
                                          <br>
                                          <br>Control no.: " & billingcontrolno & "
                                          <br>Reason     : " & txt_Reason.Text & "
                                          <br>
                                          <br>You may approved/decline this request by using Cerro.
                                          <br>
                                          <br>This is a system generated message. Do not reply.
                                          <br>
                                          <br>—The Cerro Development Team </p>"

                        Dim oServer As New SmtpServer(ConfigurationSettings.AppSettings("Host"))
                        oServer.User = ConfigurationSettings.AppSettings("Username")
                        oServer.Password = ConfigurationSettings.AppSettings("Password")
                        oServer.ConnectType = SmtpConnectType.ConnectTryTLS
                        oServer.Port = 587
                        oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

                        Dim oSmtp As New EASendMail.SmtpClient()
                        oSmtp.SendMail(oServer, oMail)

                        If BillRev = True Then
                            strQuery = "EXEC upd_billingcurrenthwb @outboundid = @outboundid"
                            cmd.CommandText = strQuery
                            cmd.Parameters.AddWithValue("outboundid", obidcur)
                            dt = GetData(cmd)
                        ElseIf BillRev = False Then
                            strQuery = "EXEC upd_billingotherhwb @outboundid = @outboundid"
                            cmd.CommandText = strQuery
                            cmd.Parameters.AddWithValue("outboundid", obidoth)
                            dt = GetData(cmd)
                        End If
                        Me.Dispose()
                    End If
                End If
            ElseIf reasonreq = "FinSOACancel" Then
                If txt_Reason.Text = Nothing Then
                    MetroMessageBox.Show(BCEParent, "Must have Reason", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    strQuery = "UPDATE tbl_billing SET status = 'FOR CANCELLATION'
                                WHERE controlno = '" & soacancelctrlno & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "EXEC ins_billingcancel @controlno = @controlno,
												       @reason = @reason,
												       @status = @status,
												       @employeeid = @employeeid,
												       @datecreated = @datecreated"

                    cmd.CommandText = strQuery
                    cmd.Parameters.AddWithValue("controlno", soacancelctrlno)
                    cmd.Parameters.AddWithValue("reason", txt_Reason.Text)
                    cmd.Parameters.AddWithValue("status", "FOR CANCELLATION")
                    cmd.Parameters.AddWithValue("employeeid", emplid)
                    cmd.Parameters.AddWithValue("datecreated", Date.Now)
                    dt = GetData(cmd)

                    strQuery = "SELECT immediatesuperior FROM tbl_employeemaster
                                    WHERE employeeid = '" & emplid & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    Dim fn As String = dt.Rows(dt.Rows.Count - 1).Item(0)

                    strQuery = "SELECT firstname, email FROM tbl_employeemaster
                                WHERE fullname = '" & fn & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    Dim fn1 As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                    Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                    Dim oMail As New SmtpMail("TryIt")
                    oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
                    oMail.To = email
                    oMail.Subject = "SOA Cancellation Request"
                    oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & fn1 & ",
                                          <br>
                                          <br>" & FirstName & " is requesting for a cancellation of SOA with the following details:
                                          <br>
                                          <br>SOA Control No.: " & soacancelctrlno & "
                                          <br>Reason         : " & txt_Reason.Text & "
                                          <br>
                                          <br>You may approved/decline this request by using Cerro.
                                          <br>
                                          <br>This is a system generated message. Do not reply.
                                          <br>
                                          <br>—The Cerro Development Team </p>"

                    Dim oServer As New SmtpServer(ConfigurationSettings.AppSettings("Host"))
                    oServer.User = ConfigurationSettings.AppSettings("Username")
                    oServer.Password = ConfigurationSettings.AppSettings("Password")
                    oServer.ConnectType = SmtpConnectType.ConnectTryTLS
                    oServer.Port = 587
                    oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

                    Dim oSmtp As New EASendMail.SmtpClient()
                    oSmtp.SendMail(oServer, oMail)
                    Me.Dispose()
                End If
            ElseIf reasonreq = "Ops" Then
                If txt_Reason.Text = Nothing Then
                    MetroMessageBox.Show(BCEParent, "Must have Reason", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    strQuery = "UPDATE tbl_outbound SET status = 'FOR CANCELLATION',
                                      reason = '" & txt_Reason.Text & "'
                                WHERE hwb_no = '" & trackidrea & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "SELECT immediatesuperior FROM tbl_employeemaster
                                WHERE employeeid = '" & emplid & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    Dim fn As String = dt.Rows(dt.Rows.Count - 1).Item(0)

                    strQuery = "SELECT firstname, email FROM tbl_employeemaster
                                WHERE fullname = '" & fn & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    Dim fn1 As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                    Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                    Dim oMail As New SmtpMail("TryIt")
                    oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
                    oMail.To = email
                    oMail.Subject = "Tracking Cancellation Request"
                    oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & fn1 & ",
                                          <br>
                                          <br>" & FirstName & " is requesting for a cancellation of Tracking No. with the following details:
                                          <br>
                                          <br>Tracking No.: " & trackingcontrolno & "
                                          <br>Reason      : " & txt_Reason.Text & "
                                          <br>
                                          <br>You may approved/decline this request by using Cerro.
                                          <br>
                                          <br>This is a system generated message. Do not reply.
                                          <br>
                                          <br>—The Cerro Development Team </p>"

                    Dim oServer As New SmtpServer(ConfigurationSettings.AppSettings("Host"))
                    oServer.User = ConfigurationSettings.AppSettings("Username")
                    oServer.Password = ConfigurationSettings.AppSettings("Password")
                    oServer.ConnectType = SmtpConnectType.ConnectTryTLS
                    oServer.Port = 587
                    oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

                    Dim oSmtp As New EASendMail.SmtpClient()
                    oSmtp.SendMail(oServer, oMail)

                    Me.Dispose()
                End If
            ElseIf reasonreq = "disb" Then
                If txt_Reason.Text = Nothing Then
                    MetroMessageBox.Show(BCEParent, "Must have Reason", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    strQuery = "UPDATE tbl_header SET status = 'Cancelled',
                                                      remarks = '" & txt_Reason.Text & "'
                                WHERE controlno LIKE '" & disbcontrolno & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE vw_CVPrint SET debit = 0,
                                       credit = 0
                                WHERE controlno LIKE '" & disbcontrolno & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                    Me.Dispose()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BillingReason_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class