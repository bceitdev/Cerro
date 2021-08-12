Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class NewLogin
    Private Sub NewLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_EMPLID.Focus()
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
                Dept_Id = dt.Rows(dt.Rows.Count - 1).Item(9)
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
            ElseIf txt_pwd.Text = Nothing Then
                MetroMessageBox.Show(Me, "Must need to input Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                SignIn()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_pwd_Click(sender As Object, e As EventArgs) Handles txt_pwd.Click

    End Sub

    Private Sub txt_pwd_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pwd.KeyDown
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

    Private Sub lbl_Reg_Click(sender As Object, e As EventArgs) Handles lbl_Reg.Click
        AcctReq.ShowDialog()
    End Sub

    Private Sub lbl_RecPass_Click(sender As Object, e As EventArgs) Handles lbl_RecPass.Click
        Try
            ForgotPwd.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class