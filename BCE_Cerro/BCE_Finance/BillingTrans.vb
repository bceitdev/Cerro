Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Public Class BillingTrans
    Public acctno As String
    Dim duedate As Date
    Private Sub BillingTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trans()
    End Sub

    Private Sub BillingTrans_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Sub trans()
        Try
            duedate = DateAdd(DateInterval.Day, Val(lbl_Terms.Text), dtp_Transmit.Value.Date)
            lbl_Duedate.Text = duedate

            If duedate > Date.Today Then
                lbl_pastdue.Text = 0
            Else
                lbl_pastdue.Text = DateDiff(DateInterval.Day, duedate, Date.Today)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            strQuery = "UPDATE tbl_billing SET transmittaldate = @transmittaldate,
                                               duedate = @duedate,
                                               pastdue = @pastdue
                        WHERE controlno = @controlno"

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("transmittaldate", dtp_Transmit.Value.Date)
            cmd.Parameters.AddWithValue("duedate", lbl_Duedate.Text)
            cmd.Parameters.AddWithValue("pastdue", lbl_pastdue.Text)
            cmd.Parameters.AddWithValue("controlno", lbl_ControlNo.Text)
            Dim dt As DataTable = GetData(cmd)

            Me.Dispose()
            BillingView.SOAList()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_Transmit_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Transmit.ValueChanged
        trans()
    End Sub
End Class