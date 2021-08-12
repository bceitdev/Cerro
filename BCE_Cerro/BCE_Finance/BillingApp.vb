Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports EASendMail
Imports System.Configuration

Public Class BillingApp
    Private Sub dgv_AcctReq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Rev.CellContentClick

    End Sub

    Private Sub dgv_AcctReq_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Rev.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Rev.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Rev.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Rev.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BillingApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppList()
        CancelList()
    End Sub
    <Obsolete>
    Private Sub dgv_AcctReq_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Rev.CellClick
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim i As Integer = e.RowIndex
            Dim revcount As Integer

            If e.ColumnIndex = 0 Then
                strQuery = "SELECT ISNULL(MAX(rev), 0) + 1
                            FROM vw_billingapp
                            WHERE billingid = '" & dgv_Rev.Item(3, i).Value & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)
                revcount = dt.Rows(dt.Rows.Count - 1).Item(0)

                If dgv_Rev.Item(8, i).Value = "Removal of existing Tracking No." Then
                    strQuery = "UPDATE vw_billingapp SET clientstatus = 'OPEN',
					                               hwbstatus = 'OPEN'
                            WHERE costingid = '" & dgv_Rev.Item(4, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE vw_billingapp SET status = 'APPROVED',
                                                          rev = '" & revcount & "'
                                WHERE id = '" & dgv_Rev.Item(2, i).Value & "'
                                    AND billingid = '" & dgv_Rev.Item(3, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                ElseIf dgv_Rev.Item(8, i).Value = "Addition of other Tracking No." Then
                    strQuery = "UPDATE vw_billingapp SET clientstatus = 'CLOSED',
					                               hwbstatus = 'CLOSED'
                            WHERE costingid = '" & dgv_Rev.Item(4, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE vw_billingapp SET status = 'APPROVED',
                                                          rev = '" & revcount & "'
                                WHERE id = '" & dgv_Rev.Item(2, i).Value & "'
                                    AND billingid = '" & dgv_Rev.Item(3, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If

                strQuery = "SELECT employeeid, controlno, reason FROM vw_billingapp
                            WHERE controlno LIKE '" & dgv_Rev.Item(5, i).Value & "'
	                            AND id LIKE '" & dgv_Rev.Item(2, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim emp As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim billingcontrolno As String = dt.Rows(dt.Rows.Count - 1).Item(1)
                Dim rsn As String = dt.Rows(dt.Rows.Count - 1).Item(2)

                strQuery = "SELECT email, firstname FROM tbl_employeemaster
                            WHERE employeeid LIKE '" & emp & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim fn As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                Dim oMail As New SmtpMail("TryIt")
                oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
                oMail.To = email
                oMail.Subject = "SOA Revision Request Status"
                oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & fn & ",
                                          <br>
                                          <br>Your requested revision of SOA has been successfully APPROVED by your Immediate Superior with the following details below:
                                          <br>
                                          <br>Control no.: " & billingcontrolno & "
                                          <br>Reason     : " & rsn & "
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
            ElseIf e.ColumnIndex = 1 Then
                If dgv_Rev.Item(8, i).Value = "Removal of existing Tracking No." Then
                    strQuery = "UPDATE vw_billingapp SET clientstatus = 'CLOSED',
					                               hwbstatus = 'CLOSED'
                            WHERE costingid = '" & dgv_Rev.Item(4, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE vw_billingapp SET status = 'DECLINE',
                                                          rev = 0
                                WHERE id = '" & dgv_Rev.Item(2, i).Value & "'
                                    AND billingid = '" & dgv_Rev.Item(3, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                ElseIf dgv_Rev.Item(8, i).Value = "Addition of other Tracking No." Then
                    strQuery = "UPDATE vw_billingapp SET clientstatus = 'OPEN',
					                               hwbstatus = 'OPEN'
                            WHERE costingid = '" & dgv_Rev.Item(4, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE vw_billingapp SET status = 'DECLINE',
                                                          rev = 0
                                WHERE id = '" & dgv_Rev.Item(2, i).Value & "'
                                    AND billingid = '" & dgv_Rev.Item(3, i).Value & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If

                strQuery = "SELECT employeeid, controlno, reason FROM vw_billingapp
                            WHERE controlno LIKE '" & dgv_Rev.Item(5, i).Value & "'
	                            AND id LIKE '" & dgv_Rev.Item(2, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim emp As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim billingcontrolno As String = dt.Rows(dt.Rows.Count - 1).Item(1)
                Dim rsn As String = dt.Rows(dt.Rows.Count - 1).Item(2)

                strQuery = "SELECT email, firstname FROM tbl_employeemaster
                            WHERE employeeid LIKE '" & emp & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim fn As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                Dim oMail As New SmtpMail("TryIt")
                oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
                oMail.To = email
                oMail.Subject = "SOA Revision Request Status"
                oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & fn & ",
                                          <br>
                                          <br>We regret to inform that your requested revision of SOA has been DECLINED by your Immediate Superior with the following details below:
                                          <br>
                                          <br>Control no.: " & billingcontrolno & "
                                          <br>Reason     : " & rsn & "
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
            End If
            AppList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AppList()
        Try
            strQuery = "EXEC vw_billingappinfo @status = 'FOR REVISION'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_Rev.DataSource = dt
            dgv_Rev.Columns(2).Visible = False
            dgv_Rev.Columns(3).Visible = False
            dgv_Rev.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CancelList()
        Try
            strQuery = "EXEC sp_vw_billingcancel @status = 'FOR CANCELLATION'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_Can.DataSource = dt
            dgv_Can.Columns(2).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BillingApp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub dgv_Can_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Can.CellContentClick

    End Sub

    Private Sub dgv_Can_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Can.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Can.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Can.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Can.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    <Obsolete>
    Private Sub dgv_Can_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Can.CellClick
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim i As Integer = e.RowIndex

            If e.ColumnIndex = 0 Then
                strQuery = "UPDATE tbl_billing SET status = 'CANCELLED'
                            WHERE controlno LIKE '" & dgv_Can.Item(3, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "UPDATE tbl_billingcancel SET status = 'APPROVED'
                            WHERE controlno LIKE '" & dgv_Can.Item(3, i).Value & "'
                                AND id LIKE '" & dgv_Can.Item(2, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "UPDATE vw_soalist SET clientstatus = 'OPEN',
					                              hwbstatus = 'OPEN'
                            WHERE controlno LIKE '" & dgv_Can.Item(3, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "SELECT employeeid, controlno, reason FROM vw_billingcancel
                            WHERE controlno LIKE '" & dgv_Can.Item(3, i).Value & "'
	                            AND id LIKE '" & dgv_Can.Item(2, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim emp As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim billingcontrolno As String = dt.Rows(dt.Rows.Count - 1).Item(1)
                Dim rsn As String = dt.Rows(dt.Rows.Count - 1).Item(2)

                strQuery = "SELECT email, firstname FROM tbl_employeemaster
                            WHERE employeeid LIKE '" & emp & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim fn As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                Dim oMail As New SmtpMail("TryIt")
                oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
                oMail.To = email
                oMail.Subject = "SOA Cancellation Request Status"
                oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & fn & ",
                                          <br>
                                          <br>Your requested cancellation of SOA has been successfully APPROVED by your Immediate Superior with the following details below:
                                          <br>
                                          <br>Control no.: " & billingcontrolno & "
                                          <br>Reason     : " & rsn & "
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
            ElseIf e.ColumnIndex = 1 Then
                strQuery = "UPDATE tbl_billing SET status = 'OPEN'
                            WHERE controlno LIKE '" & dgv_Can.Item(3, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "UPDATE tbl_billingcancel SET status = 'DECLINE'
                            WHERE controlno LIKE '" & dgv_Can.Item(3, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "SELECT employeeid, controlno, reason FROM vw_billingcancel
                            WHERE controlno LIKE '" & dgv_Can.Item(3, i).Value & "'
	                            AND id LIKE '" & dgv_Can.Item(2, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim emp As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim billingcontrolno As String = dt.Rows(dt.Rows.Count - 1).Item(1)
                Dim rsn As String = dt.Rows(dt.Rows.Count - 1).Item(2)

                strQuery = "SELECT email, firstname FROM tbl_employeemaster
                            WHERE employeeid LIKE '" & emp & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(0)
                Dim fn As String = dt.Rows(dt.Rows.Count - 1).Item(1)

                Dim oMail As New SmtpMail("TryIt")
                oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
                oMail.To = email
                oMail.Subject = "SOA Cancellation Request Status"
                oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & fn & ",
                                          <br>
                                          <br>We regret to inform that your requested cancellation of SOA has been DECLINED by your Immediate Superior with the following details below:
                                          <br>
                                          <br>Control no.: " & billingcontrolno & "
                                          <br>Reason     : " & rsn & "
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
            End If
            CancelList()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class