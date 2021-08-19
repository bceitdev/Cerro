Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class Receive
    Dim updPOD As String
    Dim recdate As Date
    Private Sub POD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim stat As String

            If txt_recby.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Receiver's Name", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                strQuery = "SELECT status FROM tbl_outbound
                            WHERE hwb_no LIKE '" & lbl_hwbno.Text & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)

                stat = dt.Rows(dt.Rows.Count - 1).Item(0)

                If stat = "IN TRANSIT" Then
                    strQuery = "EXEC upd_outbound @hwb_no = @hwb_no,
                                          @status = 'DELIVERED',
                                          @rec_date = @rec_date,
                                          @rec_by = @rec_by"
                    cmd.CommandText = strQuery
                    cmd.Parameters.AddWithValue("hwb_no", lbl_hwbno.Text.ToUpper)
                    cmd.Parameters.AddWithValue("rec_date", recdate)
                    cmd.Parameters.AddWithValue("rec_by", txt_recby.Text)
                    dt = GetData(cmd)

                    MetroMessageBox.Show(BCEParent, "Delivery has been successfully received", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                ElseIf stat = "OPEN" Then
                    MetroMessageBox.Show(BCEParent, "Updating status while the cargo is undispatch is not allowed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_recdate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_recdate.ValueChanged
        Try
            recdate = dtp_recdate.Value.Date
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class