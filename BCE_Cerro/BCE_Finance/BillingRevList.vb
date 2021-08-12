Imports System.Data
Imports System.Data.SqlClient
Public Class BillingRevList
    Private Sub BillingRevList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppList()
    End Sub
    Sub AppList()
        Try
            strQuery = "SELECT id,
		                        billingid,
		                        costingid,
	                           controlno as 'Control No.',
	                           outboundid as 'Tracking No.',
	                           hwb_no_carb as 'HWB No.',
	                           sysremarks as 'Remarks',
	                           reason as 'Reason',
	                           status as 'Status',
	                           fullname as 'Requester',
	                           datecreated as 'Date Request'
                        FROM vw_billingapp"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_AcctReq.DataSource = dt
            dgv_AcctReq.Columns(0).Visible = False
            dgv_AcctReq.Columns(1).Visible = False
            dgv_AcctReq.Columns(2).Visible = False
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

    Private Sub BillingRevList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class