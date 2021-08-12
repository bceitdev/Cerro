Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class ShipmentStatus
    Private Sub Shipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_Status.SelectedIndex = 0
        'ViewReceivedList()
    End Sub

    Sub viewoutbound()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "SELECT pur_no as 'PUR No.',
		                            Origin,
		                            Destination,
		                            loadingmode as 'Loading Mode',
		                            consignee as 'Consignee',
                            CONCAT(no_street_etc, ' ',
		                            barangay, ' ',
		                            city, ' ',
		                            province, ' ',
		                            region) as 'Address',
		                            account_number as 'Shipper Account No.',
		                            actualqty as 'Qty',
		                            commodity as 'Description',
		                            actualwt as 'Weight'
                            FROM vw_outbound
                            WHERE pur_no LIKE '%" & txt_Search.Text & "%'
                                AND status LIKE @status"
            Else
                strQuery = "EXEC outbound"
            End If

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("pur_no", txt_Search.Text)
            cmd.Parameters.AddWithValue("status", "OPEN")
            Dim dt As DataTable = GetData(cmd)

            dgv_Outbound.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ViewReceivedList()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "SELECT hwb_no as 'HWB No.',
		                            status as 'Status',
		                            servicemode as 'Service Mode',
		                            shipdate as 'Ship Date',
		                            company_name as 'Shipper',
		                            consignee as 'Consignee',
		                            carrier as 'Carrier',
		                            Origin,
		                            Destination,
		                            commodity as 'Commodity',
		                            actualqty as 'Qty (pc)',
		                            actualwt as 'Weight (kg)'
                            FROM vw_shipmentstatus
                            WHERE status LIKE @status
                                AND hwb_no LIKE @hwb_no
                                OR servicemode LIKE @servicemode
                                OR company_name LIKE @company_name
                                OR carrier LIKE @carrier
                                OR Origin LIKE @Origin
                                OR Destination LIKE @Destination"
            Else
                strQuery = "EXEC shipmentstatus @status = @status"
            End If

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("status", cbo_Status.SelectedItem)
            cmd.Parameters.AddWithValue("hwb_no", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("servicemode", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("company_name", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("carrier", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("Origin", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("Destination", "%" + txt_Search.Text + "%")
            Dim dt As DataTable = GetData(cmd)

            dgv_Outbound.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cbo_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Status.SelectedIndexChanged
        CboViewOutbound()
    End Sub
    Sub CboViewOutbound()
        Try
            strQuery = "EXEC shipmentstatus @status = '" & cbo_Status.SelectedItem & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_Outbound.DataSource = dt

            'For i = 2 To 8
            '    dgv_Outbound.Columns(i).ReadOnly = True
            'Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_Pickuplist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.ColumnIndex = 0 Then
                Outbound.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Pickuplist_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Outbound.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Outbound.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Outbound.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Outbound_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Outbound.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Outbound.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Outbound.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Outbound.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShipmentStatus_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_Outbound_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Outbound.CellContentClick

    End Sub

    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        ViewReceivedList()
    End Sub
End Class