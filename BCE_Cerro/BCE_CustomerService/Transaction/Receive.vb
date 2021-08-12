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
            If txt_recby.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Receiver's Name", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "EXEC upd_outbound @hwb_no = @hwb_no,
                                          @status = 'DELIVERED',
                                          @rec_date = @rec_date,
                                          @rec_by = @rec_by"
                Dim cmd As New SqlCommand(strQuery)
                cmd.Parameters.AddWithValue("hwb_no", lbl_hwbno.Text.ToUpper)
                cmd.Parameters.AddWithValue("rec_date", recdate)
                cmd.Parameters.AddWithValue("rec_by", txt_recby.Text)
                Dim dt As DataTable = GetData(cmd)

                MetroMessageBox.Show(BCEParent, "Delivery has been successfully received", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
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