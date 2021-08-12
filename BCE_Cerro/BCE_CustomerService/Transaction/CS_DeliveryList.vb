Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class CS_DeliveryList
	Private Sub CS_DeliveryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ViewDeliveryList()
	End Sub
	Sub ViewDeliveryList()
		Try
			If txt_Search.Text <> Nothing Then
				strQuery = "SELECT DISTINCT(hwb_no) as 'Tracking No.',
								hwb_no_carb as 'HWB No.',
								accepted_date as 'Accepted Date',
								shipdate as 'Ship Date',
								company_name as 'Shipper',
								consignee as 'Consignee',
								origin as 'Origin',
								destination as 'Destination',
								status as 'Status',
								reason as 'Reason',
								rec_date as 'Received Date',
								rec_by as 'Received By',
								pod_date as 'POD Transmitted Date',
								doctype as 'Doc Type',
								docref as 'Doc Ref. No.'
						FROM vw_dummydimension
						WHERE hwb_no LIKE '%" & txt_Search.Text & "%'
							OR hwb_no_carb LIKE '%" & txt_Search.Text & "%'"
			Else
				strQuery = "EXEC vw_cs_deliverylist"
			End If

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_Deliverylist.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_Deliverylist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Deliverylist.CellContentClick

	End Sub

	Private Sub dgv_Deliverylist_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Deliverylist.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Deliverylist.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Deliverylist.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_Deliverylist.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
		ViewDeliveryList()
	End Sub

	Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown

	End Sub

	Sub forreplace()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable
			Dim letter, sertcode As String
			Dim HWBs As String
			Dim recid, serid As Object

			'If e.KeyCode = Keys.Enter Then
			letter = txt_Search.Text.Substring(0, 3)
				HWBs = letter + txt_Search.Text.Remove(0, 3).PadLeft(10, "0")

				strQuery = "SELECT recid, serid, tcode FROM vw_shipmentstatus_final
							WHERE hwb_no = '" & HWBs & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)

				If dt.Rows.Count > 0 Then
					recid = dt.Rows(dt.Rows.Count - 1).Item(0)
					serid = dt.Rows(dt.Rows.Count - 1).Item(1)
					sertcode = dt.Rows(dt.Rows.Count - 1).Item(2).ToString

					If Not IsDBNull(recid) Then
						strQuery = "SELECT hwb_no as 'Tracking No.',
										   hwb_no_carb as 'HWB No.',
										   shipdate as 'Ship Date',
										   rec_company_name as 'Shipper',
										   rec_consignee as 'Consignee',
										   rec_orig as 'Origin',
										   rec_dest as 'Destination',
										   status as 'Status',
										   rec_date as 'Received Date',
										   rec_by as 'Received by',
										   pod_date as 'POD Transmitted Date',
										   doctype as 'Doc Type',
										   docref as 'Doc Ref No.'
									FROM vw_shipmentstatus_final
									WHERE hwb_no = '" & HWBs & "'"
					ElseIf Not IsDBNull(serid) And sertcode = "0001" Then
						strQuery = "SELECT hwb_no as 'Tracking No.',
										   hwb_no_carb as 'HWB No.',
										   shipdate as 'Ship Date',
										   ser_company_name as 'Shipper',
										   ser_consignee as 'Consignee',
										   ser_orig as 'Origin',
										   ser_dest as 'Destination',
										   status as 'Status',
										   rec_date as 'Received Date',
										   rec_by as 'Received by',
										   pod_date as 'POD Transmitted Date',
										   doctype as 'Doc Type',
										   docref as 'Doc Ref No.'
									FROM vw_shipmentstatus_final
									WHERE hwb_no = '" & HWBs & "'"
					ElseIf Not IsDBNull(serid) And sertcode = "0002" Then
						strQuery = "SELECT hwb_no as 'Tracking No.',
										   hwb_no_carb as 'HWB No.',
										   shipdate as 'Ship Date',
										   ser_shipper as 'Shipper',
										   ser_consignee as 'Consignee',
										   ser_orig as 'Origin',
										   ser_dest as 'Destination',
										   status as 'Status',
										   rec_date as 'Received Date',
										   rec_by as 'Received by',
										   pod_date as 'POD Transmitted Date',
										   doctype as 'Doc Type',
										   docref as 'Doc Ref No.'	   
									FROM vw_shipmentstatus_final
									WHERE hwb_no = '" & HWBs & "'"
					ElseIf Not IsDBNull(recid) And Not IsDBNull(serid) Then
						'strQuery = "SELECT hwb_no as 'HWB No.',
						'				   shipdate as 'Ship Date',
						'				   ser_company_name as 'Shipper',
						'				   ser_consignee as 'Consignee',
						'				   ser_orig as 'Origin',
						'				   ser_dest as 'Destination',
						'				   status as 'Status'	   
						'			FROM vw_shipmentstatus_final
						'			WHERE hwb_no = '" & HWBs & "'"
						MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
					End If
					cmd.CommandText = strQuery
					dt = GetData(cmd)
					dgv_Deliverylist.DataSource = dt
				Else
					MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If
			'End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

	End Sub

	Private Sub dgv_Deliverylist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Deliverylist.CellClick
		Try
			Dim i As Integer = e.RowIndex
			If e.ColumnIndex = 0 Then
				Dim obb As New Receive
				obb.lbl_hwbno.Text = dgv_Deliverylist.Item(3, i).Value
				obb.ShowDialog()
			ElseIf e.ColumnIndex = 1 Then
				Dim obb As New POD
				obb.lbl_hwbno.Text = dgv_Deliverylist.Item(3, i).Value
				obb.ShowDialog()
			ElseIf e.ColumnIndex = 2 Then
				Dim obb As New Status
				obb.lbl_hwbno.Text = dgv_Deliverylist.Item(3, i).Value
				obb.ShowDialog()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
		Try
			txt_Search.Text = Nothing

			strQuery = "EXEC vw_cs_deliverylist"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_Deliverylist.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
End Class