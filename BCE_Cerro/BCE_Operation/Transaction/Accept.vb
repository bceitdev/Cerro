Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.Web.UI.WebControls

Public Class Accept
	Dim ComTypeId, LocationId, PickupSchedId, TQ, recid As Integer
	Dim decval, charwt As Double
	Dim Modify As Boolean
	Dim Dimension, account_number, company_name, code, loadingmode, paymode, servicemode, freightmode, orig_area, orig_code, dest_code As String

	Sub viewrec()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "EXEC vw_receive @pickupno = @pickupno"

			cmd.CommandText = strQuery
			cmd.Parameters.AddWithValue("pickupno", txt_PickupNo.Text)
			dt = GetData(cmd)

			dgv_Receive.DataSource = dt
			dgv_Receive.Columns(0).Visible = False
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub txt_TotalQty_KeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
	End Sub

	Private Sub txt_TotalWeight_KeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
	End Sub

	Private Sub ActualReceive_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		Me.Dispose()
	End Sub

	Sub CommodityType(ByVal u As String)

		Try
			strQuery = "SELECT name FROM tbl_commoditytype"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If (u = "CommodityTypeItem") Then
				Me.cbo_Type.Items.Clear()
			End If

			Dim ant As Integer = dt.Rows.Count()
			Dim a As Integer = 0

			While (ant > a)
				If (u = "CommodityTypeItem") Then
					cbo_Type.Items.Add(dt.Rows(a).Item(0))
				End If

				a = a + 1
			End While
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub

	Sub clear()
		txt_PickupNo.Text = Nothing
		txt_pur.Text = Nothing
		lbl_PlateNo.Text = Nothing
		lbl_Shipper.Text = Nothing
		txt_Commodity.Text = Nothing
		txt_weight.Text = Nothing
		cbo_Type.Text = Nothing
		account_number = Nothing
		company_name = Nothing
		code = Nothing
		loadingmode = Nothing
		paymode = Nothing
		servicemode = Nothing
		freightmode = Nothing
		orig_area = Nothing
		orig_code = Nothing
		decval = Nothing
		txt_Consignee.Text = Nothing
		cbo_Destination.Text = Nothing
		txt_address.Text = Nothing
		txt_phone.Text = Nothing
		txt_email.Text = Nothing
		dgv_DimensionDummy.Columns.Clear()
		dgv_DimensionDummy.Visible = False
		dgv_Dimension.Visible = True
		lbl_TotalVol.Text = Nothing
	End Sub
	Sub AddDummyDimension()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable
			Dim l, w, h, volwt, charwts As Decimal

			strQuery = "SELECT MAX(id) FROM tbl_receive"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				Dim ReceivedId As Integer = dt.Rows(dt.Rows.Count - 1).Item(0)
				For i = 0 To dgv_Dimension.Rows.Count - 1
					If dgv_Dimension.Item(0, i).Value <> Nothing Then
						l = dgv_Dimension.Item(0, i).Value
						w = dgv_Dimension.Item(1, i).Value
						h = dgv_Dimension.Item(2, i).Value
						volwt = dgv_Dimension.Item(4, i).Value
						charwts = charwt
						strQuery = "EXEC ins_dummydimension @accepted_date = '" & dtp_DateRec.Value.Date & "',
														@received_id = '" & ReceivedId & "',
														@pur_no = '" & txt_pur.Text & "',
														@origin = '" & orig_area & "',
														@origin_code = '" & orig_code & "',
														@destination = '" & cbo_Destination.Text & "',
														@destination_code = '" & dest_code & "',
														@loadingmode = '" & loadingmode & "',
														@consignee = '" & txt_Consignee.Text.ToUpper & "',
														@no_street_etc = '" & txt_address.Text.ToUpper & "',
														@account_number = '" & account_number & "',
														@company_name = '" & company_name & "',
														@actualqty = '" & dgv_Dimension.Item(3, i).Value & "',
														@code = '" & code & "',
														@commodity = '" & txt_Commodity.Text.ToUpper & "',
														@length = '" & l & "',
														@width = '" & w & "',
														@height = '" & h & "',
														@actualwt = '" & txt_weight.Text & "',
														@volwt = '" & volwt & "',
														@charwt = '" & charwts & "',
														@decval = '" & decval & "',
														@paymode = '" & paymode & "',
														@servicemode = '" & servicemode & "',
														@freightmode = '" & freightmode & "',
														@phone = '" & txt_phone.Text & "',
														@status = 'OPEN',
														@totalqty = '" & TQ & "'"

						cmd.CommandText = strQuery
						dt = GetData(cmd)
					End If
				Next
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub AddDimension()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "SELECT MAX(id) FROM tbl_receive"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				Dim RecId As Integer = dt.Rows(dt.Rows.Count - 1).Item(0)

				For i = 0 To dgv_Dimension.Rows.Count - 1
					If dgv_Dimension.Item(0, i).Value <> Nothing Then
						strQuery = "EXEC ins_dimension_act @type = 'ACTUAL',
												   @rec_id = '" & RecId & "',
												   @pur_no = '" & txt_pur.Text & "',
												   @length = '" & dgv_Dimension.Item(0, i).Value & "',
												   @width = '" & dgv_Dimension.Item(1, i).Value & "',
												   @height = '" & dgv_Dimension.Item(2, i).Value & "',
												   @quantity = '" & dgv_Dimension.Item(3, i).Value & "',
												   @volume = '" & dgv_Dimension.Item(4, i).Value & "'"

						cmd.CommandText = strQuery
						dt = GetData(cmd)
					End If
				Next

			End If

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub upd_DimensionDummy()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			For i = 0 To dgv_DimensionDummy.Rows.Count - 1
				If dgv_DimensionDummy.Item(0, i).Value <> Nothing Then
					strQuery = "EXEC upd_dimension_act  @rec_id = '" & recid & "',
														@pur_no = '" & txt_pur.Text & "',
														@length = '" & dgv_DimensionDummy.Item(0, i).Value & "',
														@width = '" & dgv_DimensionDummy.Item(1, i).Value & "',
														@height = '" & dgv_DimensionDummy.Item(2, i).Value & "',
														@quantity = '" & dgv_DimensionDummy.Item(3, i).Value & "',
														@volume = '" & dgv_DimensionDummy.Item(4, i).Value & "'"

					cmd.CommandText = strQuery
					dt = GetData(cmd)
				End If
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			If txt_pur.Text = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have PUR No.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			ElseIf TQ = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have Actual Quantity", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			ElseIf txt_weight.Text = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have Actual Weight", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				'ElseIf dgv_Dimension.Rows.Count = 1 Then
				'    MetroMessageBox.Show(BCEParent, "Must have Dimension", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			ElseIf ComTypeId = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have Commodity", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			ElseIf txt_Consignee.Text = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have Consignee", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			ElseIf txt_address.Text = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have No., Street, Building, Floor, Unit, etc.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Else
				If Modify = True Then
					strQuery = "EXEC upd_receive @id = @id,
												 @pur_no = @pur_no,
												 @daterec = @daterec,
												 @actualqty = @actualqty,
												 @actualwt = @actualwt,
												 @charwt = @charwt,
												 @com_id = @com_id,
												 @commodity = @commodity,
												 @location_id = @location_id,
												 @consignee = @consignee,
												 @no_street_etc = @no_street_etc,
												 @phone = @phone,
												 @email = @email"
					cmd.CommandText = strQuery
					cmd.Parameters.AddWithValue("id", recid)
					cmd.Parameters.AddWithValue("pur_no", txt_pur.Text)
					cmd.Parameters.AddWithValue("daterec", dtp_DateRec.Value.Date)
					cmd.Parameters.AddWithValue("actualqty", TQ)
					cmd.Parameters.AddWithValue("actualwt", txt_weight.Text)

					If txt_weight.Text > lbl_TotalVol.Text Then
						charwt = txt_weight.Text
					ElseIf lbl_TotalVol.Text > txt_weight.Text Then
						charwt = lbl_TotalVol.Text
					End If

					cmd.Parameters.AddWithValue("charwt", charwt)
					cmd.Parameters.AddWithValue("com_id", ComTypeId)
					cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text.ToUpper)
					cmd.Parameters.AddWithValue("location_id", LocationId)
					cmd.Parameters.AddWithValue("consignee", txt_Consignee.Text.ToUpper)
					cmd.Parameters.AddWithValue("no_street_etc", txt_address.Text.ToUpper)
					cmd.Parameters.AddWithValue("phone", txt_phone.Text)
					cmd.Parameters.AddWithValue("email", txt_email.Text)
					dt = GetData(cmd)

					upd_DimensionDummy()

					MetroMessageBox.Show(BCEParent, "Pickup has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
				ElseIf Modify = False Then
					strQuery = "EXEC ins_receive @pickupdispatchid = @pickupdispatchid,
										 @pur_no = @pur_no,
										 @daterec = @daterec,
										 @actualqty = @actualqty,
										 @actualwt = @actualwt,
										 @charwt = @charwt,
										 @com_id = @com_id,
										 @commodity = @commodity,
										 @location_id = @location_id,
										 @consignee = @consignee,
										 @no_street_etc = @no_street_etc,
										 @phone = @phone,
										 @email = @email,
										 @status = @status,
										 @employeeid = @employeeid,
										 @datecreated = @datecreated"
					cmd.CommandText = strQuery
					cmd.Parameters.AddWithValue("pickupdispatchid", PickupSchedId)
					cmd.Parameters.AddWithValue("pur_no", txt_pur.Text)
					cmd.Parameters.AddWithValue("daterec", dtp_DateRec.Value.Date)
					cmd.Parameters.AddWithValue("actualqty", TQ)
					cmd.Parameters.AddWithValue("actualwt", txt_weight.Text)

					If txt_weight.Text > lbl_TotalVol.Text Then
						charwt = txt_weight.Text
					ElseIf lbl_TotalVol.Text > txt_weight.Text Then
						charwt = lbl_TotalVol.Text
					End If

					cmd.Parameters.AddWithValue("charwt", charwt)
					cmd.Parameters.AddWithValue("com_id", ComTypeId)
					cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text.ToUpper)
					cmd.Parameters.AddWithValue("location_id", LocationId)
					cmd.Parameters.AddWithValue("consignee", txt_Consignee.Text.ToUpper)
					cmd.Parameters.AddWithValue("no_street_etc", txt_address.Text.ToUpper)
					cmd.Parameters.AddWithValue("phone", txt_phone.Text)
					cmd.Parameters.AddWithValue("email", txt_email.Text)
					cmd.Parameters.AddWithValue("status", "OPEN")
					cmd.Parameters.AddWithValue("employeeid", emplid)
					cmd.Parameters.AddWithValue("datecreated", Date.Now)
					dt = GetData(cmd)

					AddDimension()
					AddDummyDimension()

					strQuery = "UPDATE tbl_ops_pickupdispatch SET status = 'CLOSED'
								WHERE pickupschedid LIKE '" & txt_PickupNo.Text & "'"
					cmd.CommandText = strQuery
					dt = GetData(cmd)

					strQuery = "UPDATE tbl_cs_pickupsched SET status = 'CLOSED'
								WHERE id LIKE '" & txt_PickupNo.Text & "'"
					cmd.CommandText = strQuery
					dt = GetData(cmd)

					MetroMessageBox.Show(BCEParent, "Pickup has been successfully received", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
				dgv_Dimension.Visible = True
				dgv_DimensionDummy.Visible = False
				AddRowsDimension()
				viewrec()
				clear()
				txt_pur.Focus()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
	End Sub

	Private Sub txt_weight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_weight.KeyPress
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
	End Sub

	Private Sub txt_L_KeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
	End Sub

	Private Sub txt_W_KeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
	End Sub

	Private Sub txt_H_KeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
	End Sub
	Sub Computation4DimDum()
		Try
			Dim TotalPc As Integer = 0
			Dim TotalDim As Double = 0
			Dim servicedivisor As Integer

			strQuery = "SELECT servicedivisor 
						FROM tbl_servicemode
						WHERE servicemode LIKE '" & servicemode & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If dt.Rows.Count > 0 Then
				servicedivisor = dt.Rows(dt.Rows.Count - 1).Item(0)
			End If

			For index As Integer = 0 To dgv_DimensionDummy.Rows.Count - 1
				dgv_DimensionDummy.Item(4, index).Value = (dgv_DimensionDummy(0, index).Value * dgv_DimensionDummy(1, index).Value * dgv_DimensionDummy(2, index).Value) / servicedivisor * dgv_DimensionDummy(3, index).Value
				TotalPc += dgv_DimensionDummy.Item(3, index).Value
				TotalDim += dgv_DimensionDummy.Item(4, index).Value
			Next
			TQ = TotalPc
			lbl_TotalVol.Text = TotalDim.ToString("0.000")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub Computation()
		Try
			Dim TotalPc As Integer = 0
			Dim TotalDim As Double = 0
			Dim servicedivisor As Integer

			strQuery = "SELECT servicedivisor 
						FROM tbl_servicemode
						WHERE servicemode LIKE '" & servicemode & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If dt.Rows.Count > 0 Then
				servicedivisor = dt.Rows(dt.Rows.Count - 1).Item(0)
			End If

			For index As Integer = 0 To dgv_Dimension.Rows.Count - 1
				dgv_Dimension.Item(4, index).Value = (dgv_Dimension(0, index).Value * dgv_Dimension(1, index).Value * dgv_Dimension(2, index).Value) / servicedivisor * dgv_Dimension(3, index).Value
				TotalPc += dgv_Dimension.Item(3, index).Value
				TotalDim += dgv_Dimension.Item(4, index).Value
			Next
			TQ = TotalPc
			lbl_TotalVol.Text = TotalDim.ToString("0.00")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub AddRowsDimension()
		Try
			dgv_Dimension.Rows.Clear()
			dgv_Dimension.Rows.Add(25)
			dgv_Dimension.Columns(4).ReadOnly = True
			For x = 0 To 4
				For i = 0 To dgv_Dimension.Rows.Count - 1
					dgv_Dimension.Item(x, i).Style.Alignment = DataGridViewContentAlignment.MiddleRight
				Next
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub InboundRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		viewrec()
		AddRowsDimension()
		TypeAutoCom()
		DestAutoCom()
		txt_PickupNo.Focus()
	End Sub

	Private Sub dgv_Receive_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Receive.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Receive.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Receive.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_Receive.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_pur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pur.KeyPress
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
	End Sub

	Private Sub Ml_other_Click(sender As Object, e As EventArgs) Handles ml_other.Click
		Try
			clear()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_PickupNo_Click(sender As Object, e As EventArgs) Handles txt_PickupNo.Click

	End Sub

	Private Sub dgv_Receive_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Receive.CellContentClick

	End Sub

	Sub TypeAutoCom()
		Try
			strQuery = "SELECT name FROM tbl_commoditytype
						WHERE name LIKE '%" & cbo_Type.Text & "%'"
			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			cbo_Type.AutoCompleteMode = AutoCompleteMode.Suggest
			cbo_Type.AutoCompleteSource = AutoCompleteSource.CustomSource
			cbo_Type.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("name"))).ToArray())

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_Dimension_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellContentClick

	End Sub

	Private Sub dgv_DimensionDummy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DimensionDummy.CellContentClick

	End Sub

	Sub SelectType()
		Try
			strQuery = "SELECT * FROM tbl_commoditytype
						WHERE name LIKE '" & cbo_Type.Text & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If dt.Rows.Count > 0 Then
				ComTypeId = dt.Rows(dt.Rows.Count - 1).Item(0)
				cbo_Type.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
			Else
				ComTypeId = Nothing
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Type.SelectedIndexChanged
		SelectType()
	End Sub

	Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
		Try
			clear()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_weight_Click(sender As Object, e As EventArgs) Handles txt_weight.Click

	End Sub

	Sub Destination(ByVal u As String)
		Try
			strQuery = "SELECT location_area
						FROM location_list"
			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)
			If (u = "DestinationItem") Then
				cbo_Destination.Items.Clear()
			End If
			Dim ant As Integer = dt.Rows.Count()
			Dim a As Integer = 0
			While (ant > a)
				If (u = "DestinationItem") Then
					cbo_Destination.Items.Add(dt.Rows(a).Item(0))
				End If
				a = a + 1
			End While
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub lbl_TotalVol_Click(sender As Object, e As EventArgs) Handles lbl_TotalVol.Click

	End Sub

	Sub DestAutoCom()
		Try
			strQuery = "SELECT location_area FROM location_list 
						WHERE location_area LIKE '%" & cbo_Destination.Text & "%'"
			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			cbo_Destination.AutoCompleteMode = AutoCompleteMode.Suggest
			cbo_Destination.AutoCompleteSource = AutoCompleteSource.CustomSource
			cbo_Destination.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("location_area"))).ToArray())

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub SelectDest()
		Try
			strQuery = "SELECT id, location_area, location_code FROM location_list 
						WHERE location_area LIKE '" & cbo_Destination.Text & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If dt.Rows.Count > 0 Then
				LocationId = dt.Rows(dt.Rows.Count - 1).Item(0)
				cbo_Destination.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
				dest_code = dt.Rows(dt.Rows.Count - 1).Item(2)
			Else
				LocationId = Nothing
				dest_code = Nothing
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub cbo_Destination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Destination.SelectedIndexChanged
		SelectDest()
	End Sub

	Private Sub txt_PickupNo_TextChanged(sender As Object, e As EventArgs) Handles txt_PickupNo.TextChanged
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "SELECT * FROM vw_ops_pickupdispatch
						WHERE pickupschedid LIKE '" & txt_PickupNo.Text & "'"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				Modify = False
				PickupSchedId = dt.Rows(dt.Rows.Count - 1).Item(0)
				lbl_PlateNo.Text = dt.Rows(dt.Rows.Count - 1).Item(2)
				lbl_Shipper.Text = dt.Rows(dt.Rows.Count - 1).Item(4)
				txt_Commodity.Text = dt.Rows(dt.Rows.Count - 1).Item(5)
				txt_weight.Text = dt.Rows(dt.Rows.Count - 1).Item(6)
				cbo_Type.Text = dt.Rows(dt.Rows.Count - 1).Item(11)
				account_number = dt.Rows(dt.Rows.Count - 1).Item(3)
				company_name = dt.Rows(dt.Rows.Count - 1).Item(4)
				code = dt.Rows(dt.Rows.Count - 1).Item(13)
				loadingmode = dt.Rows(dt.Rows.Count - 1).Item(14)
				paymode = dt.Rows(dt.Rows.Count - 1).Item(15)
				servicemode = dt.Rows(dt.Rows.Count - 1).Item(16)
				freightmode = dt.Rows(dt.Rows.Count - 1).Item(17)
				orig_area = dt.Rows(dt.Rows.Count - 1).Item(18)
				orig_code = dt.Rows(dt.Rows.Count - 1).Item(19)
				decval = dt.Rows(dt.Rows.Count - 1).Item(20)
			Else
				lbl_PlateNo.Text = Nothing
				lbl_Shipper.Text = Nothing
				txt_Commodity.Text = Nothing
				txt_weight.Text = Nothing
				cbo_Type.Text = Nothing
				account_number = Nothing
				company_name = Nothing
				code = Nothing
				loadingmode = Nothing
				paymode = Nothing
				servicemode = Nothing
				freightmode = Nothing
				orig_area = Nothing
				orig_code = Nothing
				decval = Nothing
				txt_Consignee.Text = Nothing
				cbo_Destination.Text = Nothing
				txt_address.Text = Nothing
				txt_phone.Text = Nothing
				txt_email.Text = Nothing
				dgv_DimensionDummy.Columns.Clear()
				dgv_Dimension.Visible = False
				dgv_Dimension.Visible = True
				lbl_TotalVol.Text = Nothing
			End If
			viewrec()
			SelectType()
			SelectDest()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub cbo_Loading_DropDown(sender As Object, e As EventArgs) Handles cbo_Type.DropDown
		CommodityType("CommodityTypeItem")
	End Sub

	Private Sub cbo_Destination_DropDown(sender As Object, e As EventArgs) Handles cbo_Destination.DropDown
		Destination("DestinationItem")
	End Sub

	Private Sub dgv_Dimension_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellEndEdit
		Computation()
	End Sub

	Private Sub dgv_Dimension_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Dimension.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Dimension.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Dimension.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_Dimension.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub cbo_Destination_TextChanged(sender As Object, e As EventArgs) Handles cbo_Destination.TextChanged
		SelectDest()
	End Sub

	Private Sub cbo_Type_TextChanged(sender As Object, e As EventArgs) Handles cbo_Type.TextChanged
		SelectType()
	End Sub
	Sub SearchDim()
		Try
			strQuery = "SELECT length as 'L', 
							   width as 'W', 
							   height as 'H', 
							   quantity as 'Qty', 
							   volume as 'Vol'
						FROM tbl_dimension
						WHERE rec_id = '" & recid & "'
							AND pur_no = '" & txt_pur.Text & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_DimensionDummy.DataSource = dt
			dgv_Dimension.Visible = False
			dgv_DimensionDummy.Visible = True
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_Receive_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Receive.CellDoubleClick
		Try
			Dim i As Integer = e.RowIndex

			recid = dgv_Receive.Item(0, i).Value
			txt_pur.Text = dgv_Receive.Item(1, i).Value
			dtp_DateRec.Value = dgv_Receive.Item(2, i).Value
			cbo_Type.Text = dgv_Receive.Item(3, i).Value
			txt_Commodity.Text = dgv_Receive.Item(4, i).Value
			SelectType()
			txt_weight.Text = dgv_Receive.Item(5, i).Value
			cbo_Destination.Text = dgv_Receive.Item(7, i).Value
			SelectDest()
			txt_Consignee.Text = dgv_Receive.Item(8, i).Value
			txt_address.Text = dgv_Receive.Item(9, i).Value
			txt_phone.Text = dgv_Receive.Item(10, i).Value
			txt_email.Text = dgv_Receive.Item(11, i).Value
			SearchDim()
			Modify = True
			Computation4DimDum()

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_DimensionDummy_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_DimensionDummy.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_DimensionDummy.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_DimensionDummy.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_Dimension.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_DimensionDummy_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DimensionDummy.CellEndEdit
		Computation4DimDum()
	End Sub

	Private Sub txt_PickupNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PickupNo.KeyPress
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
	End Sub

End Class