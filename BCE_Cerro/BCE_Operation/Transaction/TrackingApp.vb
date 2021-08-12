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
Public Class TrackingApp
    Private Sub TrackingApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
    End Sub
    Sub view()
        Try
            strQuery = "SELECT hwb_no as 'Tracking No.',
	                       hwb_no_carb as 'HWB No.',
	                       shipdate as 'Ship Date',
	                       company_name as 'Shipper',
	                       consignee as 'Consignee',
	                       commodity as 'Commodity',
	                       origin as 'Origin',
	                       destination as 'Destination',
	                       status as 'Status',
	                       reason as 'Reason'
                    FROM vw_dummydimension
                    WHERE status = 'FOR CANCELLATION'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_AcctReq.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TrackingApp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_AcctReq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AcctReq.CellContentClick

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

    Private Sub dgv_AcctReq_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_AcctReq.CellClick
        Try
            Dim i As Integer = e.RowIndex
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If e.ColumnIndex = 0 Then
                strQuery = "UPDATE tbl_outbound SET status = 'CANCELLED'
                            WHERE hwb_no = '" & dgv_AcctReq.Item(1, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "UPDATE tbl_dummydimension SET status = 'CANCELLED'
                            WHERE hwb_no = '" & dgv_AcctReq.Item(1, i).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "UPDATE tbl_costing SET clientstatus = 'CANCELLED',
                                                   hwbstatus = 'CANCELLED',
                            WHERE hwb_no = '" & dgv_AcctReq.Item(1, i).Value & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)

                view()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class