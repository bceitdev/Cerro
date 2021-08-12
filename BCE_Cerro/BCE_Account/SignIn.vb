Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class SignIn

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub SignIn()

        Try
            strQuery = "SELECT * FROM vw_acctmaster 
                        WHERE employeeid = @emplid AND password = @pwd"
            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("emplid", txt_EMPLID.Text.Trim)
            cmd.Parameters.AddWithValue("pwd", txt_Pwd.Text.Trim)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                emplid = dt.Rows(dt.Rows.Count - 1).Item(1)
                Pass = dt.Rows(dt.Rows.Count - 1).Item(4)
                FirstName = dt.Rows(dt.Rows.Count - 1).Item(5)
                Me.Hide()
                BCEParent.Show()
            Else
                MetroMessageBox.Show(Me, "Invalid Employee ID or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_SignIn_Click(sender As Object, e As EventArgs) Handles btn_SignIn.Click

        Try
            If txt_EMPLID.Text = Nothing Then
                MetroMessageBox.Show(Me, "Must need to input Employee ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Pwd.Text = Nothing Then
                MetroMessageBox.Show(Me, "Must need to input Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                SignIn()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lbl_Req_Click(sender As Object, e As EventArgs) Handles lbl_Req.Click

        Try
            Me.Hide()
            AcctReq.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Lbl_ForgotPwd_Click(sender As Object, e As EventArgs) Handles lbl_ForgotPwd.Click

        Try
            Me.Hide()
            ForgotPwd.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Txt_Pwd_Click(sender As Object, e As EventArgs) Handles txt_Pwd.Click

    End Sub

    Private Sub txt_Pwd_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Pwd.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                SignIn()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_EMPLID_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_EMPLID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SignIn()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SignIn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_EMPLID_Click(sender As Object, e As EventArgs) Handles txt_EMPLID.Click

    End Sub

    Private Sub txt_EMPLID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_EMPLID.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub
End Class