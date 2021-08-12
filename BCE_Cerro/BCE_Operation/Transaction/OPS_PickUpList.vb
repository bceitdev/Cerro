Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class OPS_PickUpList
	Dim Dispatch As Boolean

	Sub vwopslist()
		Try
			If txt_Search.Text <> Nothing Then
				strQuery = "SELECT DISTINCT (id) as 'Pickup No.',
									status as 'Status',
									Pickup as 'Pickup Date/Time',
							CONCAT(char(10) + company_name, + char(10) + CHAR(10) +
									no_street_etc, ' ',
									zipcode, + CHAR(10) + CHAR(10) +
									contactperson, + CHAR(10) +
									phone, + CHAR(10) +
									email + char(10)) as 'Shipper Information',
							CONCAT(loadingmode, + CHAR(10) +
								   servicemode, + CHAR(10) +
								   paymode, + CHAR(10) +
								   freightmode, + CHAR(10) +
								   name, + CHAR(10) +
								   commodity, + CHAR(10) +
								   specialinstruction) as 'Shipment Information',
								   qty as 'Quantity',
								   weight as 'Weight (Kg)',
								   volume as 'Volume Metric'
							FROM vw_cs_pickupsched
							WHERE id LIKE @id 
								OR status LIKE @status
								OR pickup LIKE @pickup
								OR company_name LIKE @company_name
								OR zipcode LIKE @zipcode
								OR contactperson LIKE @contactperson
								OR loadingmode LIKE @loadingmode
								OR servicemode LIKE @servicemode
								OR paymode LIKE @paymode
								OR freightmode LIKE @freightmode
								OR qty LIKE @qty
								OR weight LIKE @weight
								OR name LIKE @name
								OR commodity LIKE @commodity"
			Else
				strQuery = "EXEC vw_ops_pickuplist @status = @status"
			End If

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("status", cbo_Status.SelectedItem)
			cmd.Parameters.AddWithValue("id", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("pickup", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("company_name", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("zipcode", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("contactperson", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("consignee", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("barangay_con", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("city_con", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("province_con", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("region_con", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("zipcode_con", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("contactperson_con", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("loadingmode", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("servicemode", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("paymode", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("freightmode", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("qty", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("weight", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("name", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("commodity", "%" + txt_Search.Text + "%")
			Dim dt As DataTable = GetData(cmd)

			dgv_Pickuplist.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub CboViewPickupList()
		Try
			strQuery = "EXEC vw_ops_pickuplist @status = '" & cbo_Status.SelectedItem & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_Pickuplist.DataSource = dt

			For i = 2 To 8
				dgv_Pickuplist.Columns(i).ReadOnly = True
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub OPS_PickUpList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cbo_Status.SelectedIndex = 0
	End Sub

	Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
		vwopslist()
	End Sub

	Private Sub OPS_PickUpList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Try
			Me.Dispose()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub Dgv_Pickuplist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pickuplist.CellContentClick
		Try
			If e.ColumnIndex = 1 Then
				CancelId = dgv_Pickuplist.Item(2, e.RowIndex).Value
				PickupCancel.ShowDialog()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_Pickuplist_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Pickuplist.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Pickuplist.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Pickuplist.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_Pickuplist.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub Btn_Dispatch_Click(sender As Object, e As EventArgs) Handles btn_Dispatch.Click
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "DELETE FROM tbl_dpickupdispatch"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			For Each row As DataGridViewRow In dgv_Pickuplist.Rows
				If row.Cells(0).Value = True Then
					strQuery = "INSERT INTO tbl_dpickupdispatch (pickupno) VALUES ('" & row.Cells(2).Value & "')"

					cmd.CommandText = strQuery
					dt = GetData(cmd)
				End If
			Next
			PickupDispatch.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub OPS_PickUpList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Try
			Me.Dispose()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub Cbo_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Status.SelectedIndexChanged
		Try
			CboViewPickupList()
			If cbo_Status.SelectedIndex = 0 Then
				dgv_Pickuplist.Columns(0).Visible = True
				dgv_Pickuplist.Columns(1).Visible = False
				btn_Dispatch.Enabled = True
			ElseIf cbo_Status.SelectedIndex = 1 Then
				dgv_Pickuplist.Columns(0).Visible = False
				dgv_Pickuplist.Columns(1).Visible = True
				btn_Dispatch.Enabled = False
			ElseIf cbo_Status.SelectedIndex = 2 Then
				dgv_Pickuplist.Columns(0).Visible = False
				dgv_Pickuplist.Columns(1).Visible = False
				btn_Dispatch.Enabled = False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub Txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

	End Sub

	Private Sub OPS_PickUpList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
		CboViewPickupList()
	End Sub

	Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel1.Paint

	End Sub
End Class