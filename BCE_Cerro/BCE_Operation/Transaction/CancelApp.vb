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
Public Class CancelApp
    Sub view()
        Try
            strQuery = "EXEC ops_pickupcancel"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_PickupCancelReq.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
    End Sub

    Private Sub Dgv_AcctReq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_PickupCancelReq.CellContentClick
        Try
            Dim i As Integer = e.RowIndex
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If e.ColumnIndex = 0 Then
                strQuery = "UPDATE tbl_ops_pickupdispatch SET status = 'CANCELLED'
                            WHERE pickupschedid LIKE '" & dgv_PickupCancelReq.Item(1, i).Value & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "UPDATE tbl_cs_pickupsched SET status = 'OPEN'
                            WHERE id = '" & dgv_PickupCancelReq.Item(1, i).Value & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)

                view()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_AcctReq_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_PickupCancelReq.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_PickupCancelReq.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_PickupCancelReq.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_PickupCancelReq.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class