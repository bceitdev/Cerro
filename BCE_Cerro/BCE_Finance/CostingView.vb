Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class CostingView

    Dim HWBs As String
    Private Sub CostingView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewcost()
    End Sub

    Sub viewcost()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "SELECT outboundid as 'HWB No.',
	                               freight as 'Freight',
	                               valuation as 'Valuation',
	                               insurance as 'Insurance',
	                               waybillfee as 'Waybill Fee',
	                               permits as 'Permits',
	                               handling as 'Handling',
	                               pickup as 'Pickup',
	                               deliveryoda as 'Delivery/ODA',
	                               crafting as 'Crating',
	                               packing as 'Packing',
	                               others_vat as 'Others VAT',
                                   others_nvat as 'Others Non-VAT',
	                               subtotal as 'Sub Total',
	                               vat as 'VAT',
	                               grandtotal as 'Grand Total'
                            FROM tbl_costing
                            WHERE outboundid LIKE '%" & HWBs & "%'"
            Else
                strQuery = "EXEC costing_view"
            End If

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_Cost.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Cost_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Cost.CellContentClick

    End Sub

    Private Sub dgv_Cost_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Cost.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Cost.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Cost.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Cost.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CostingView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        Try
            Dim letter As String

            If e.KeyCode = Keys.Enter Then
                letter = txt_Search.Text.Substring(0, 3)
                HWBs = letter + txt_Search.Text.Remove(0, 3).PadLeft(10, "0")
                viewcost()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        Try
            viewcost()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class