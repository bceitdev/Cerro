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

Public Class AcctReq

    Dim EmpId As Integer

    Private Sub AcctReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub Search_EmpDet()

        Try
            strQuery = "SELECT * FROM tbl_employeemaster WHERE employeeid = @employeeid"
            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("employeeid", txt_EMPLID.Text.Trim)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                EmpId = dt.Rows(dt.Rows.Count - 1).Item(1)
                lbl_Fullname.Text = dt.Rows(dt.Rows.Count - 1).Item(2) & ", " & dt.Rows(dt.Rows.Count - 1).Item(3) & " " & dt.Rows(dt.Rows.Count - 1).Item(4)
                FirstName = dt.Rows(dt.Rows.Count - 1).Item(2)
                lbl_Dep.Text = dt.Rows(dt.Rows.Count - 1).Item(7)
                lbl_Pos.Text = dt.Rows(dt.Rows.Count - 1).Item(9)
                lbl_ImmHead.Text = dt.Rows(dt.Rows.Count - 1).Item(10)
                lbl_EmailAdd.Text = dt.Rows(dt.Rows.Count - 1).Item(11)
                lbl_MobNo.Text = dt.Rows(dt.Rows.Count - 1).Item(12)
            Else
                MetroMessageBox.Show(Me, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Search_Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Search_Clear()
        lbl_Fullname.Text = Nothing
        lbl_Dep.Text = Nothing
        lbl_Pos.Text = Nothing
        lbl_ImmHead.Text = Nothing
        lbl_EmailAdd.Text = Nothing
        lbl_MobNo.Text = Nothing
    End Sub
    Private Sub txt_EMPLID_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_EMPLID.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                If txt_EMPLID.Text <> Nothing Then
                    Search_EmpDet()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    <Obsolete>
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click

        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT employeeid FROM vw_acctrequest
                        WHERE employeeid = '" & EmpId & "'"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            If dt.Rows.Count > 0 Then
                MetroMessageBox.Show(Me, "You have already an account or a pending account requistion. Duplication is not permitted.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Notification to Immediate Head for approval
                strQuery = "SELECT email FROM tbl_employeemaster 
                            WHERE employeeid IN(SELECT employeeid FROM tbl_employeemaster 
                                                WHERE fullname = @ImmHead)"
                cmd.CommandText = strQuery
                cmd.Parameters.AddWithValue("ImmHead", lbl_ImmHead.Text)
                dt = GetData(cmd)

                Dim email As String = dt.Rows(dt.Rows.Count - 1).Item(0)

                Dim oMail As New SmtpMail("TryIt")
                oMail.From = New EASendMail.MailAddress("Cerro", ConfigurationSettings.AppSettings("Username"))
                oMail.To = email
                oMail.Subject = "New Account Request"
                oMail.HtmlBody = ""

                Dim oServer As New SmtpServer(ConfigurationSettings.AppSettings("Host"))
                oServer.User = ConfigurationSettings.AppSettings("Username")
                oServer.Password = ConfigurationSettings.AppSettings("Password")
                oServer.ConnectType = SmtpConnectType.ConnectTryTLS
                oServer.Port = 587
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

                Dim oSmtp As New EASendMail.SmtpClient()
                oSmtp.SendMail(oServer, oMail)

                'Insert Request
                strQuery = "EXEC ins_acctrequest @employeeid = @employeeid, " &
                                               "@status = 'Pending', " &
                                               "@daterequest = @daterequest"
                cmd.CommandText = strQuery
                cmd.Parameters.AddWithValue("employeeid", EmpId)
                cmd.Parameters.AddWithValue("daterequest", Date.Now)
                dt = GetData(cmd)

                MetroMessageBox.Show(Me, "Account request has been successfully sent to your Immidiate Superior for approval", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                SignIn.Show()

            End If
        Catch ex As Exception
            MsgBox("Failure to request an account due to " & ex.Message)
        End Try

    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AcctReq_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class