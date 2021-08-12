Imports System.Configuration
Imports System.IO
Imports System
Imports System.Net
Imports System.Net.Mail
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.Web
Imports EASendMail
Public Class AcctApp
    Sub view()

        Try
            strQuery = "SELECT acctreqid, 
                                fullname as 'Fullname', 
                                department as 'Department', 
                                position as 'Position', 
                                immediateSuperior as 'Immediate Superior', 
                                daterequest as 'Date Request',
                                firstname,
                                email
                        FROM vw_acctrequest 
                        WHERE status = 'Pending'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_AcctReq.DataSource = dt
            dgv_AcctReq.Columns(1).Visible = False
            dgv_AcctReq.Columns(7).Visible = False
            dgv_AcctReq.Columns(8).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub AcctApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
    End Sub

    <Obsolete>
    Private Sub Dgv_AcctReq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AcctReq.CellContentClick

        Try

            Dim defaultPW As String = randPW()
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim i As Integer = e.RowIndex

            FirstName = dgv_AcctReq.Item(7, i).Value
            Dim email As String = dgv_AcctReq.Item(8, i).Value

            Dim oMail As New SmtpMail("TryIt")
            oMail.From = New EASendMail.MailAddress("Cerro", ConfigurationSettings.AppSettings("Username"))
            oMail.To = email
            oMail.Subject = "Account Request Approved"
            oMail.HtmlBody = "<h1 style=text-align:center>Welcome to Cerro</h1> 
                              <p style=text-align:left>Your account request has been successfully approved by your immediate superior.
                              <br>
                              <br>You're about to experience a simplified and upgraded Logistics Management System embracing standards and updates of the future industry.
                              <br>
                              <br>To be officially on-board, we're giving you a system generated password by default and can be change once you logged.  
                              <br>
                              <br>Here is your password: " & defaultPW & "
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

            'Insert Account
            strQuery = "EXEC ins_acctmaster @acctreqid = @acctreqid, @password = @password"
            cmd.CommandText = strQuery
            cmd.Parameters.AddWithValue("acctreqid", dgv_AcctReq.Item(1, i).Value)
            cmd.Parameters.AddWithValue("password", defaultPW)
            dt = GetData(cmd)

            'Update Status
            strQuery = "UPDATE tbl_acctrequest SET status = 'Approved', dateapprove = @dateapprove
                        WHERE acctreqid = @acctreqid"
            cmd.CommandText = strQuery
            cmd.Parameters.AddWithValue("dateapprove", Date.Now)
            dt = GetData(cmd)

            view()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgv_AcctReq_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_AcctReq.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_AcctReq.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_AcctReq.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_AcctReq.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AcctApp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class