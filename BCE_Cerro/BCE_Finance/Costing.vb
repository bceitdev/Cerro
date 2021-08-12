Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Public Class Costing
	Dim rptdoc As ReportDocument
	Dim UpsertCost As Boolean
	Dim HWBs As String
	Dim hwb_no, acctid, addid, acctno, comp, orig, dest, comdty, datecreated, paymode, fr, val, ins, way, per, han, pic, del, cra, pac, oth, subt, vat, gra, com, ship As String

	Private Sub Costing_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub btn_BillingList_Click(sender As Object, e As EventArgs) Handles btn_BillingList.Click
		Try
			CostingView.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub mt_Setting_Click(sender As Object, e As EventArgs) Handles mt_Setting.Click
		ExpCol_Setting()
	End Sub

	Sub AddRow()
		Try
			dgv_Charges.Rows.Clear()
			dgv_Charges.Rows.Add(15)
			dgv_Charges.Rows(0).Cells(0).Value = "FREIGHT"
			dgv_Charges.Rows(1).Cells(0).Value = "VALUATION"
			dgv_Charges.Rows(2).Cells(0).Value = "INSURANCE"
			dgv_Charges.Rows(3).Cells(0).Value = "WAYBILL FEE"
			dgv_Charges.Rows(4).Cells(0).Value = "PERMITS"
			dgv_Charges.Rows(5).Cells(0).Value = "HANDLING"
			dgv_Charges.Rows(6).Cells(0).Value = "PICKUP"
			dgv_Charges.Rows(7).Cells(0).Value = "DELIVERY/ODA"
			dgv_Charges.Rows(8).Cells(0).Value = "CRATING"
			dgv_Charges.Rows(9).Cells(0).Value = "PACKING"
			dgv_Charges.Rows(10).Cells(0).Value = "OTHERS VAT"
			dgv_Charges.Rows(11).Cells(0).Value = "OTHERS non-VAT"
			dgv_Charges.Rows(12).Cells(0).Value = "SUB TOTAL"
			dgv_Charges.Rows(13).Cells(0).Value = "12% VAT"
			dgv_Charges.Rows(14).Cells(0).Value = "GRAND TOTAL"

			For i = 0 To dgv_Charges.Rows.Count - 1
				dgv_Charges.Rows(i).Cells(1).Value = 0
				dgv_Charges.Rows(i).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleRight
			Next

			For i = 12 To 14
				dgv_Charges.Rows(i).Cells(0).Style.ForeColor = Color.Red
				dgv_Charges.Rows(i).Cells(1).Style.ForeColor = Color.Red
				dgv_Charges.Rows(i).Cells(1).ReadOnly = True
			Next

			dgv_Charges.Columns(0).ReadOnly = True
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub computation()
		Try
			Dim subtotal As Double = 0
			Dim vatfactor As Double = 0
			Dim vat As Double = 0.12

			If cb_vat.Checked = True Then
				For index As Integer = 0 To 11
					subtotal += dgv_Charges.Item(1, index).Value
				Next
				dgv_Charges.Rows(12).Cells(1).Value = subtotal

				For indexvat As Integer = 0 To 10
					vatfactor += dgv_Charges.Item(1, indexvat).Value
				Next
				dgv_Charges.Rows(13).Cells(1).Value = (vatfactor * vat)
				dgv_Charges.Rows(14).Cells(1).Value = dgv_Charges.Rows(12).Cells(1).Value + dgv_Charges.Rows(13).Cells(1).Value
			ElseIf cb_vat.Checked = False Then
				For index As Integer = 0 To 11
					subtotal += dgv_Charges.Item(1, index).Value
				Next
				dgv_Charges.Rows(12).Cells(1).Value = subtotal

				For indexvat As Integer = 0 To 10
					vatfactor += dgv_Charges.Item(1, indexvat).Value
				Next
				dgv_Charges.Rows(13).Cells(1).Value = 0
				dgv_Charges.Rows(14).Cells(1).Value = dgv_Charges.Rows(12).Cells(1).Value + dgv_Charges.Rows(13).Cells(1).Value
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_Charges_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Charges.CellEndEdit
		computation()
	End Sub
	Private Sub Costing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AddRow()
		cb_vat.Checked = True
	End Sub
	Sub ExpCol_Setting()
		If pnl_Setting.Height = 0 Then
			While (pnl_Setting.Height < 68)
				pnl_Setting.Height += 8
			End While
		Else
			While (pnl_Setting.Height > 0)
				pnl_Setting.Height -= 8
			End While
		End If
	End Sub
	Private Sub Dgv_Charges_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Charges.CellContentClick

	End Sub

	Private Sub dgv_Charges_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Charges.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Charges.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Charges.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_Charges.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub Txt_hwbno_Click(sender As Object, e As EventArgs) Handles txt_hwbno.Click

	End Sub

	Sub GetCost()
		Try
			strQuery = "SELECT freight,
								valuation,
								insurance,
								waybillfee,
								permits,
								handling,
								pickup,
								deliveryoda,
								crafting,
								packing,
								others_vat,
								others_nvat,
								subtotal,
								vat,
								grandtotal
						FROM tbl_costing
						WHERE outboundid = '" & HWBs & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If dt.Rows.Count > 0 Then
				dgv_Charges.Item(1, 0).Value = dt.Rows(dt.Rows.Count - 1).Item(0)
				dgv_Charges.Item(1, 1).Value = dt.Rows(dt.Rows.Count - 1).Item(1)
				dgv_Charges.Item(1, 2).Value = dt.Rows(dt.Rows.Count - 1).Item(2)
				dgv_Charges.Item(1, 3).Value = dt.Rows(dt.Rows.Count - 1).Item(3)
				dgv_Charges.Item(1, 4).Value = dt.Rows(dt.Rows.Count - 1).Item(4)
				dgv_Charges.Item(1, 5).Value = dt.Rows(dt.Rows.Count - 1).Item(5)
				dgv_Charges.Item(1, 6).Value = dt.Rows(dt.Rows.Count - 1).Item(6)
				dgv_Charges.Item(1, 7).Value = dt.Rows(dt.Rows.Count - 1).Item(7)
				dgv_Charges.Item(1, 8).Value = dt.Rows(dt.Rows.Count - 1).Item(8)
				dgv_Charges.Item(1, 9).Value = dt.Rows(dt.Rows.Count - 1).Item(9)
				dgv_Charges.Item(1, 10).Value = dt.Rows(dt.Rows.Count - 1).Item(10)
				dgv_Charges.Item(1, 11).Value = dt.Rows(dt.Rows.Count - 1).Item(11)
				dgv_Charges.Item(1, 12).Value = dt.Rows(dt.Rows.Count - 1).Item(12)
				dgv_Charges.Item(1, 13).Value = dt.Rows(dt.Rows.Count - 1).Item(13)
				dgv_Charges.Item(1, 14).Value = dt.Rows(dt.Rows.Count - 1).Item(14)
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub ForReprint()
		Try
			strQuery = "SELECT hwb_no, shipdate 
						FROM tbl_dummydimension
						WHERE hwb_no LIKE '" & HWBs & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If dt.Rows.Count > 0 Then
				HWBReprint = dt.Rows(dt.Rows.Count - 1).Item(0)
				shipdateReprint = dt.Rows(dt.Rows.Count - 1).Item(1)
			Else
				HWBReprint = Nothing
				shipdateReprint = Nothing
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub GetItem()
		Try
			conn("SELECT ISNULL(pur_no, '') as 'pur_no',
						 ISNULL(hwb_no_carb, '') as 'hwb_no_carb',
						 CONCAT(origin, + char(10) + origin_code) as 'Origin',
						 CONCAT(destination, + char(10) + destination_code) as 'Destination',
								 loadingmode,
								 consignee,
								 no_street_etc as 'address',
								 account_number,
								 company_name,
								 actualqty,
								 code,
								 commodity,
								 length,
								 width,
								 height,
								 actualwt,
								 volwt,
								 charwt,
								 decval,
								 paymode,
								 servicemode,
								 freightmode,
								 phone
						  FROM tbl_dummydimension
						  WHERE hwb_no LIKE '" & HWBs & "'", "tbl_dummydimension")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub HWBSheetReprint()
		Try
			Dim txt_CtrlNo, txt_ShipDate As TextObject
			dssearch = New dsreport
			dasearch.Fill(dssearch, "dtHWB")
			rptdoc = New cr_HWB
			rptdoc.SetDataSource(dssearch)
			txt_CtrlNo = rptdoc.ReportDefinition.ReportObjects("txt_CtrlNo")
			txt_CtrlNo.Text = HWBReprint
			'txt_ShipDate = rptdoc.ReportDefinition.ReportObjects("txt_ShipDate")
			'txt_ShipDate.Text = shipdateReprint

			crv_HWB.ReportSource = rptdoc
			crv_HWB.Zoom(75)
			crv_HWB.Refresh()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub txt_hwbno_TextChanged(sender As Object, e As EventArgs) Handles txt_hwbno.TextChanged

	End Sub
	Sub upd_cost()
		Dim cmd As New SqlCommand(strQuery)
		cmd.Parameters.AddWithValue("outboundid", HWBs.ToUpper)
		cmd.Parameters.AddWithValue("freight", dgv_Charges.Rows(0).Cells(1).Value)
		cmd.Parameters.AddWithValue("valuation", dgv_Charges.Rows(1).Cells(1).Value)
		cmd.Parameters.AddWithValue("insurance", dgv_Charges.Rows(2).Cells(1).Value)
		cmd.Parameters.AddWithValue("waybillfee", dgv_Charges.Rows(3).Cells(1).Value)
		cmd.Parameters.AddWithValue("permits", dgv_Charges.Rows(4).Cells(1).Value)
		cmd.Parameters.AddWithValue("handling", dgv_Charges.Rows(5).Cells(1).Value)
		cmd.Parameters.AddWithValue("pickup", dgv_Charges.Rows(6).Cells(1).Value)
		cmd.Parameters.AddWithValue("deliveryoda", dgv_Charges.Rows(7).Cells(1).Value)
		cmd.Parameters.AddWithValue("crafting", dgv_Charges.Rows(8).Cells(1).Value)
		cmd.Parameters.AddWithValue("packing", dgv_Charges.Rows(9).Cells(1).Value)
		cmd.Parameters.AddWithValue("others_vat", dgv_Charges.Rows(10).Cells(1).Value)
		cmd.Parameters.AddWithValue("others_nvat", dgv_Charges.Rows(11).Cells(1).Value)
		cmd.Parameters.AddWithValue("subtotal", dgv_Charges.Rows(12).Cells(1).Value)
		cmd.Parameters.AddWithValue("vat", dgv_Charges.Rows(13).Cells(1).Value)
		cmd.Parameters.AddWithValue("grandtotal", dgv_Charges.Rows(14).Cells(1).Value)
		cmd.Parameters.AddWithValue("employeeid", emplid)
		cmd.Parameters.AddWithValue("datecreated", Date.Now)
		Dim dt As DataTable = GetData(cmd)
	End Sub
	Sub ins_cost_acct()
		Dim cmd As New SqlCommand(strQuery)
		cmd.Parameters.AddWithValue("outboundid", HWBs.ToUpper)
		cmd.Parameters.AddWithValue("shipdate", ship)
		cmd.Parameters.AddWithValue("acctid", acctid)
		cmd.Parameters.AddWithValue("addid", addid)
		cmd.Parameters.AddWithValue("acctno", acctno)
		cmd.Parameters.AddWithValue("compname", comp)
		cmd.Parameters.AddWithValue("orig", orig)
		cmd.Parameters.AddWithValue("dest", dest)
		cmd.Parameters.AddWithValue("commodity", comdty)
		cmd.Parameters.AddWithValue("clientstatus", "OPEN")
		cmd.Parameters.AddWithValue("hwbstatus", "OPEN")
		cmd.Parameters.AddWithValue("freight", dgv_Charges.Rows(0).Cells(1).Value)
		cmd.Parameters.AddWithValue("valuation", dgv_Charges.Rows(1).Cells(1).Value)
		cmd.Parameters.AddWithValue("insurance", dgv_Charges.Rows(2).Cells(1).Value)
		cmd.Parameters.AddWithValue("waybillfee", dgv_Charges.Rows(3).Cells(1).Value)
		cmd.Parameters.AddWithValue("permits", dgv_Charges.Rows(4).Cells(1).Value)
		cmd.Parameters.AddWithValue("handling", dgv_Charges.Rows(5).Cells(1).Value)
		cmd.Parameters.AddWithValue("pickup", dgv_Charges.Rows(6).Cells(1).Value)
		cmd.Parameters.AddWithValue("deliveryoda", dgv_Charges.Rows(7).Cells(1).Value)
		cmd.Parameters.AddWithValue("crafting", dgv_Charges.Rows(8).Cells(1).Value)
		cmd.Parameters.AddWithValue("packing", dgv_Charges.Rows(9).Cells(1).Value)
		cmd.Parameters.AddWithValue("others_vat", dgv_Charges.Rows(10).Cells(1).Value)
		cmd.Parameters.AddWithValue("others_nvat", dgv_Charges.Rows(11).Cells(1).Value)
		cmd.Parameters.AddWithValue("subtotal", dgv_Charges.Rows(12).Cells(1).Value)
		cmd.Parameters.AddWithValue("vat", dgv_Charges.Rows(13).Cells(1).Value)
		cmd.Parameters.AddWithValue("grandtotal", dgv_Charges.Rows(14).Cells(1).Value)
		cmd.Parameters.AddWithValue("employeeid", emplid)
		cmd.Parameters.AddWithValue("datecreated", Date.Now)
		Dim dt As DataTable = GetData(cmd)
	End Sub
	Sub ins_cost_unacct()
		Dim cmd As New SqlCommand(strQuery)
		cmd.Parameters.AddWithValue("outboundid", HWBs.ToUpper)
		cmd.Parameters.AddWithValue("shipdate", ship)
		cmd.Parameters.AddWithValue("acctno", acctno)
		cmd.Parameters.AddWithValue("compname", comp)
		cmd.Parameters.AddWithValue("orig", orig)
		cmd.Parameters.AddWithValue("dest", dest)
		cmd.Parameters.AddWithValue("commodity", comdty)
		cmd.Parameters.AddWithValue("clientstatus", "CLOSED")
		cmd.Parameters.AddWithValue("hwbstatus", "CLOSED")
		cmd.Parameters.AddWithValue("freight", dgv_Charges.Rows(0).Cells(1).Value)
		cmd.Parameters.AddWithValue("valuation", dgv_Charges.Rows(1).Cells(1).Value)
		cmd.Parameters.AddWithValue("insurance", dgv_Charges.Rows(2).Cells(1).Value)
		cmd.Parameters.AddWithValue("waybillfee", dgv_Charges.Rows(3).Cells(1).Value)
		cmd.Parameters.AddWithValue("permits", dgv_Charges.Rows(4).Cells(1).Value)
		cmd.Parameters.AddWithValue("handling", dgv_Charges.Rows(5).Cells(1).Value)
		cmd.Parameters.AddWithValue("pickup", dgv_Charges.Rows(6).Cells(1).Value)
		cmd.Parameters.AddWithValue("deliveryoda", dgv_Charges.Rows(7).Cells(1).Value)
		cmd.Parameters.AddWithValue("crafting", dgv_Charges.Rows(8).Cells(1).Value)
		cmd.Parameters.AddWithValue("packing", dgv_Charges.Rows(9).Cells(1).Value)
		cmd.Parameters.AddWithValue("others_vat", dgv_Charges.Rows(10).Cells(1).Value)
		cmd.Parameters.AddWithValue("others_nvat", dgv_Charges.Rows(11).Cells(1).Value)
		cmd.Parameters.AddWithValue("subtotal", dgv_Charges.Rows(12).Cells(1).Value)
		cmd.Parameters.AddWithValue("vat", dgv_Charges.Rows(13).Cells(1).Value)
		cmd.Parameters.AddWithValue("grandtotal", dgv_Charges.Rows(14).Cells(1).Value)
		cmd.Parameters.AddWithValue("employeeid", emplid)
		cmd.Parameters.AddWithValue("datecreated", Date.Now)
		Dim dt As DataTable = GetData(cmd)
	End Sub
	Sub upd_billingamt()
		Try
			Dim controlno As String
			Dim grandtotal As Double
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "SELECT controlno 
						FROM vw_billedlist
						WHERE outboundid LIKE '" & HWBs & "'"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				controlno = dt.Rows(dt.Rows.Count - 1).Item(0)

				strQuery = "SELECT FORMAT(SUM(grandtotal), N'N2')
							FROM vw_billingupdamt
							WHERE controlno LIKE '" & controlno & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)

				If dt.Rows.Count > 0 Then
					grandtotal = dt.Rows(dt.Rows.Count - 1).Item(0)

					strQuery = "UPDATE tbl_billing SET totaldue = '" & grandtotal & "',
													   dueforcoll = '" & grandtotal & "'
								WHERE controlno LIKE '" & controlno & "'
									AND status LIKE 'OPEN'"

					cmd.CommandText = strQuery
					dt = GetData(cmd)
				End If
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click

		Try
			If UpsertCost = True Then
				strQuery = "EXEC upd_costing @outboundid = @outboundid,
											 @freight = @freight,
											 @valuation = @valuation,
											 @insurance = @insurance,
											 @waybillfee = @waybillfee,
											 @permits = @permits,
											 @handling = @handling,
											 @pickup = @pickup,
											 @deliveryoda = @deliveryoda,
											 @crafting = @crafting,
											 @packing = @packing,
											 @others_vat = @others_vat,
											 @others_nvat = @others_nvat,
											 @subtotal = @subtotal,
											 @vat = @vat,
											 @grandtotal = @grandtotal,
											 @employeeid = @employeeid,
											 @datecreated = @datecreated"
				upd_cost()
				upd_billingamt()
				MetroMessageBox.Show(BCEParent, "Cost has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

			ElseIf UpsertCost = False Then

				Dim mbox As String
				mbox = MetroMessageBox.Show(BCEParent, "Are you sure?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If mbox = vbYes Then
					Dim cmd As New SqlCommand
					Dim dt As DataTable

					strQuery = "SELECT shipdate,
									   account_number,
									   company_name,
									   origin_code,
									   destination_code,
									   commodity
								FROM tbl_dummydimension
								where hwb_no = '" & HWBs & "'"
					cmd.CommandText = strQuery
					dt = GetData(cmd)

					If dt.Rows.Count > 0 Then
						ship = dt.Rows(dt.Rows.Count - 1).Item(0)
						acctno = dt.Rows(dt.Rows.Count - 1).Item(1)
						comp = dt.Rows(dt.Rows.Count - 1).Item(2)
						orig = dt.Rows(dt.Rows.Count - 1).Item(3)
						dest = dt.Rows(dt.Rows.Count - 1).Item(4)
						comdty = dt.Rows(dt.Rows.Count - 1).Item(5)

						strQuery = "SELECT id FROM bp_general
									WHERE account_number = '" & acctno & "'"
						cmd.CommandText = strQuery
						dt = GetData(cmd)

						If dt.Rows.Count > 0 Then
							acctid = dt.Rows(dt.Rows.Count - 1).Item(0)
						End If

						strQuery = "SELECT id FROM bp_addresses
									WHERE account_number = '" & acctno & "'
										AND address_type = 'BILL TO'"
						cmd.CommandText = strQuery
						dt = GetData(cmd)

						If dt.Rows.Count > 0 Then
							addid = dt.Rows(dt.Rows.Count - 1).Item(0)
						End If

						If acctid <> Nothing And addid <> Nothing Then
							strQuery = "EXEC ins_costing @outboundid = @outboundid,
													 @shipdate = @shipdate,
													 @acctid = @acctid,
													 @addid = @addid,
													 @acctno = @acctno,
													 @compname = @compname,
													 @orig = @orig,
													 @dest = @dest,
													 @commodity = @commodity,
													 @clientstatus = @clientstatus,
													 @hwbstatus = @hwbstatus,
													 @freight = @freight,
													 @valuation = @valuation,
													 @insurance = @insurance,
													 @waybillfee = @waybillfee,
													 @permits = @permits,
													 @handling = @handling,
													 @pickup = @pickup,
													 @deliveryoda = @deliveryoda,
													 @crafting = @crafting,
													 @packing = @packing,
													 @others_vat = @others_vat,
													 @others_nvat = @others_nvat,
													 @subtotal = @subtotal,
													 @vat = @vat,
													 @grandtotal = @grandtotal,
													 @employeeid = @employeeid,
													 @datecreated = @datecreated"
							ins_cost_acct()
						Else
							strQuery = "EXEC ins_costing @outboundid = @outboundid,
													 @shipdate = @shipdate,
													 @acctid = NULL,
													 @addid = NULL,
													 @acctno = @acctno,
													 @compname = @compname,
													 @orig = @orig,
													 @dest = @dest,
													 @commodity = @commodity,
													 @clientstatus = @clientstatus,
													 @hwbstatus = @hwbstatus,
													 @freight = @freight,
													 @valuation = @valuation,
													 @insurance = @insurance,
													 @waybillfee = @waybillfee,
													 @permits = @permits,
													 @handling = @handling,
													 @pickup = @pickup,
													 @deliveryoda = @deliveryoda,
													 @crafting = @crafting,
													 @packing = @packing,
													 @others_vat = @others_vat,
													 @others_nvat = @others_nvat,
													 @subtotal = @subtotal,
													 @vat = @vat,
													 @grandtotal = @grandtotal,
													 @employeeid = @employeeid,
													 @datecreated = @datecreated"
							ins_cost_unacct()
						End If
					End If
					MetroMessageBox.Show(BCEParent, "Cost has been successfully set", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			End If
			clear()
			AddRow()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub clear()
		txt_hwbno.Text = Nothing
		ship = Nothing
		acctno = Nothing
		comp = Nothing
		orig = Nothing
		dest = Nothing
		acctid = Nothing
		addid = Nothing
		crv_HWB.ReportSource = Nothing
	End Sub
	Private Sub Cb_vat_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vat.CheckedChanged
		computation()
	End Sub

	Private Sub txt_hwbno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_hwbno.KeyDown

		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable
			Dim letter As String

			If e.KeyCode = Keys.Enter Then

				letter = txt_hwbno.Text.Substring(0, 3)
				HWBs = letter + txt_hwbno.Text.Remove(0, 3).PadLeft(10, "0")

				strQuery = "SELECT outboundid
							FROM tbl_costing
							WHERE outboundid = '" & HWBs & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)

				If dt.Rows.Count > 0 Then
					lbl_status.Text = Nothing
					UpsertCost = True
					GetCost()
					ForReprint()
					GetItem()
					HWBSheetReprint()
				Else
					strQuery = "SELECT hwb_no,
									   status
								FROM tbl_dummydimension
								WHERE hwb_no = '" & HWBs & "'"

					cmd.CommandText = strQuery
					dt = GetData(cmd)

					If dt.Rows.Count > 0 Then
						lbl_status.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
						UpsertCost = False
						ForReprint()
						GetItem()
						HWBSheetReprint()
					Else
						MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
						crv_HWB.ReportSource = Nothing
						lbl_status.Text = Nothing
					End If
				End If
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub mt_Setting_MouseHover(sender As Object, e As EventArgs) Handles mt_Setting.MouseHover
		ExpCol_Setting()
	End Sub
End Class