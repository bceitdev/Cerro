Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class CS_PickUpList

	Sub ViewPickupList()
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
								   weight as 'Weight (Kg)',
								   qty as 'Quantity (Pc)',
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
				strQuery = "EXEC vw_cs_pickuplist"
			End If

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("id", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("status", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("pickup", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("company_name", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("zipcode", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("contactperson", "%" + txt_Search.Text + "%")
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

	Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
		ViewPickupList()
	End Sub

	Private Sub PickUpList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ViewPickupList()
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

	Private Sub CS_PickUpList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

		Try
			Me.Dispose()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub

	Private Sub CS_PickUpList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
		'ViewPickupList()
	End Sub

	Private Sub Dgv_Pickuplist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pickuplist.CellContentClick
		Try
			Dim mbox As String
			Dim i As Integer = e.RowIndex

			If e.ColumnIndex = 0 Then
				mbox = MetroMessageBox.Show(BCEParent, "Are you sure you want to cancel?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If mbox = vbYes Then
					strQuery = "UPDATE tbl_cs_pickupsched SET status = 'CANCELLED'
							WHERE id = '" & dgv_Pickuplist.Item(2, i).Value & "'"
					Dim cmd As New SqlCommand(strQuery)
					Dim dt As DataTable = GetData(cmd)
				End If
			ElseIf e.ColumnIndex = 1 Then
				Dim obb As New PickUpSched_Mod
				obb.lbl_PickupNo.Text = dgv_Pickuplist.Item(2, i).Value
				obb.ShowDialog()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub Txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

	End Sub
End Class