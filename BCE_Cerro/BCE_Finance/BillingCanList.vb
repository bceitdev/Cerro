Imports System.Data
Imports System.Data.SqlClient
Public Class BillingCanList
    Private Sub BillingCanList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelledList()
    End Sub
    Sub CancelledList()
        Try
            strQuery = "SELECT controlno as 'Control No.',
	                           reason as 'Reason',
	                           status as 'Status',
	                           fullname as 'Requester',
	                           datecreated as 'Date Request'
                        FROM vw_billingcancel"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_AcctReq.DataSource = dt
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
End Class