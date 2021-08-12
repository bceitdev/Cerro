Imports System.Data
Imports System.Data.SqlClient
Public Class Unbilled
    Private Sub billedun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppList()
    End Sub
    Sub AppList()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "EXEC sp_vw_billedlist @controlno = @controlno,
                                              @outboundid = @outboundid,
                                              @hwb_no_carb = @hwb_no_carb,
                                              @company_name = @company_name"
            Else
                strQuery = "SELECT DISTINCT(controlno) as 'Control No.',
				                            outboundid as 'Tracking No.',
				                            hwb_no_carb as 'HWB No.',
				                            shipdate as 'Ship Date',
				                            company_name as 'Shipper',
				                            consignee as 'Consignee',
				                            orig as 'Origin',
				                            dest as 'Destination',
				                            commodity as 'Commodity'
                            FROM vw_billedlist"
            End If

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("controlno", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("outboundid", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("hwb_no_carb", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("company_name", "%" + txt_Search.Text + "%")
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

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        AppList()
    End Sub

    Private Sub billedun_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class