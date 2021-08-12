Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class ChangePass
    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_New.MaxLength = 8
        txt_Confirm.MaxLength = 8
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim mbox As String

            If txt_Current.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have current password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_New.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have new password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Confirm.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have confirm password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_New.Text <> txt_Confirm.Text Then
                MetroMessageBox.Show(BCEParent, "New Password and Confirm Password did not match", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Current.Text <> Pass Then
                MetroMessageBox.Show(BCEParent, "Current Password not match", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                mbox = MetroMessageBox.Show(BCEParent, "Are you sure?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If mbox = vbYes Then
                    strQuery = "EXEC changepass @password = @password,
                                            @employeeid = @employeeid"
                    Dim cmd As New SqlCommand(strQuery)
                    cmd.Parameters.AddWithValue("password", txt_New.Text)
                    cmd.Parameters.AddWithValue("employeeid", emplid)
                    Dim dt As DataTable = GetData(cmd)

                    MetroMessageBox.Show(BCEParent, "Password has been successfully changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_Current.Text = Nothing
                    txt_New.Text = Nothing
                    txt_Confirm.Text = Nothing
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChangePass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class