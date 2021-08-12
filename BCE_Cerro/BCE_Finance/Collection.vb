Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework

Public Class Collection
	Dim i, x, paymodeid As Integer
	Dim controlno As String

	Sub oldClientListsh()
		Try
			If txt_ClientSearch.Text <> Nothing Then
				strQuery = "SELECT DISTINCT (soa) as 'Control No.',
									   account as 'Account No.',
									   customername as 'Client No.',
									   transmitteddate as 'Transmittal Date',
									   terms as 'Terms',
									   duedate as 'Due Date',
									   pastdue as 'Past Due'
								FROM tbl_oldar
								WHERE status LIKE 'OPEN'
									AND soa LIKE '%" & txt_ClientSearch.Text & "%'
									OR account LIKE '%" & txt_ClientSearch.Text & "%'
									OR customername LIKE '%" & txt_ClientSearch.Text & "%'"
			Else
				strQuery = "SELECT DISTINCT (soa) as 'Control No.',
									   account as 'Account No.',
									   customername as 'Client No.',
									   transmitteddate as 'Transmittal Date',
									   terms as 'Terms',
									   duedate as 'Due Date',
									   pastdue as 'Past Due'
								FROM tbl_oldar
								WHERE status LIKE 'OPEN'"
			End If

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_bill.DataSource = dt
			lbl_BillingCount.Text = dgv_bill.Rows.Count

			For i As Integer = 1 To 7
				dgv_bill.Columns(i).ReadOnly = True
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub ClientListsh()
		Try
			If txt_ClientSearch.Text <> Nothing Then
				strQuery = "EXEC vw_soalistinfo_sh @status = 'OPEN',
											   @controlno = '%" & txt_ClientSearch.Text & "%',
											   @account_number = '%" & txt_ClientSearch.Text & "%',
											   @company_name = '%" & txt_ClientSearch.Text & "%'"
			Else
				strQuery = "EXEC vw_soalistinfo @status = 'OPEN'"
			End If

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_bill.DataSource = dt
			lbl_BillingCount.Text = dgv_bill.Rows.Count

			For i As Integer = 1 To 9
				dgv_bill.Columns(i).ReadOnly = True
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub oldar()
		Try
			strQuery = "SELECT DISTINCT (soa) as 'Control No.',
							   account as 'Account No.',
							   customername as 'Client No.',
							   transmitteddate as 'Transmittal Date',
							   terms as 'Terms',
							   duedate as 'Due Date',
							   pastdue as 'Past Due'
						FROM tbl_oldar
						WHERE status LIKE 'OPEN'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_bill.DataSource = dt
			lbl_BillingCount.Text = dgv_bill.Rows.Count

			For i As Integer = 1 To 6
				dgv_bill.Columns(i).ReadOnly = True
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub oldhwb()
		Try
			controlno = dgv_bill.Item(1, i).Value
			strQuery = "SELECT hwb as 'HWB No.',
							   hwbdate as 'HWB Date',
							   origin as 'Origin',
							   destination as 'Destination',
							   shipmentdetails as 'Commodity',
							   amountoutstanding as 'Total Due'
						FROM tbl_oldar
						WHERE soa LIKE '" & controlno & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_track.DataSource = dt
			lbl_TrackingNo.Text = dgv_track.Rows.Count
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		BilledList.autoterms()
		ClientListsh()
		paymode()
	End Sub
	Sub paymode()
		Try
			rb_cash.Checked = True
			pnl_check.Visible = False
			pnl_dirdep.Visible = False
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub TrakingList()
		Try
			controlno = dgv_bill.Item(1, i).Value
			strQuery = "EXEC vw_trackingnoinfo @controlno = @controlno,
											   @hwbstatus = 'CLOSED'"

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("controlno", controlno)
			Dim dt As DataTable = GetData(cmd)
			dgv_track.DataSource = dt
			lbl_TrackingNo.Text = dgv_track.Rows.Count
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub Bank(ByVal u As String)
		Try
			strQuery = "SELECT bank FROM tbl_bank"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			If (u = "Item") Then
				Me.cbo_ck_bank.Items.Clear()
				Me.cbo_dd_bank.Items.Clear()
			End If

			Dim ant As Integer = dt.Rows.Count()
			Dim a As Integer = 0

			While (ant > a)
				If (u = "Item") Then
					cbo_ck_bank.Items.Add(dt.Rows(a).Item(0))
					cbo_dd_bank.Items.Add(dt.Rows(a).Item(0))
				End If

				a = a + 1
			End While
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub GetTotalDue()
		Try
			Dim totaldue As Double
			If OldAccountReceivableToolStripMenuItem.Checked = True Then
				For Each row As DataGridViewRow In dgv_track.Rows
					If row.Cells(0).Value = True Then
						totaldue += row.Cells(5).Value
					End If
				Next
			Else
				For Each row As DataGridViewRow In dgv_bill.Rows
					If row.Cells(0).Value = True Then
						totaldue += row.Cells(5).Value
					End If
				Next
			End If
			lbl_TotalDue.Text = totaldue
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub totaltax()
		Try
			Dim tax As Double = 0
			If cb_2wt.Checked = True Then
				If OldAccountReceivableToolStripMenuItem.Checked = True Then
					For Each row As DataGridViewRow In dgv_track.Rows
						tax += row.Cells(6).Value
					Next
				Else
					For Each row As DataGridViewRow In dgv_track.Rows
						tax += row.Cells(9).Value
					Next
				End If
				lbl_withhold.Text = tax
			ElseIf cb_5wt.Checked = True Then
				If OldAccountReceivableToolStripMenuItem.Checked = True Then
					For Each row As DataGridViewRow In dgv_track.Rows
						tax += row.Cells(6).Value
					Next
				Else
					For Each row As DataGridViewRow In dgv_track.Rows
						tax += row.Cells(9).Value
					Next
				End If
				lbl_withhold.Text = tax
			Else
				lbl_withhold.Text = tax
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_bill_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_bill.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_bill.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_bill.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_bill.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_bill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_bill.CellClick
		Try
			i = e.RowIndex
			x = e.ColumnIndex

			If OldAccountReceivableToolStripMenuItem.Checked = True Then
				oldhwb()
			Else
				TrakingList()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_track_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_track.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_track.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_track.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_track.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_payment.KeyPress
		e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
	End Sub
	Sub computation()
		Try
			lbl_bal.Text = Val(Val(lbl_TotalDue.Text) - Val(txt_payment.Text)) - Val(lbl_withhold.Text)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub txt_payment_TextChanged(sender As Object, e As EventArgs) Handles txt_payment.TextChanged
		computation()
	End Sub

	Private Sub cbo_Bank_DropDown(sender As Object, e As EventArgs) Handles cbo_ck_bank.DropDown
		Bank("Item")
	End Sub
	Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
		Try
			ins_collect()
			clear()
			ClientListsh()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub oldupd_billingstat()
		Try
			If Val(lbl_bal.Text) = 0 Then
				For Each row As DataGridViewRow In dgv_bill.Rows
					If row.Cells(0).Value = True Then
						strQuery = "UPDATE tbl_oldar SET status = 'CLOSED'
									WHERE soa = @controlno"

						Dim cmd As New SqlCommand(strQuery)
						cmd.Parameters.AddWithValue("controlno", controlno)
						Dim dt As DataTable = GetData(cmd)
					End If
				Next
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub upd_billingstat()
		Try
			If Val(lbl_bal.Text) = 0 Then
				For Each row As DataGridViewRow In dgv_bill.Rows
					If row.Cells(0).Value = True Then
						strQuery = "UPDATE tbl_billing SET status = 'CLOSED'
									WHERE controlno = @controlno"

						Dim cmd As New SqlCommand(strQuery)
						cmd.Parameters.AddWithValue("controlno", controlno)
						Dim dt As DataTable = GetData(cmd)
					End If
				Next
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub oldupd_due()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "UPDATE tbl_oldar SET amountoutstanding = '" & lbl_bal.Text & "',
													 amountpaid = '" & txt_payment.Text & "',
													 datecollected = '" & Date.Now & "'
								WHERE soa = @controlno"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("controlno", controlno)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub upd_due()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "UPDATE tbl_billing SET dueforcoll = '" & lbl_bal.Text & "'
									WHERE controlno = @controlno"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("controlno", controlno)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub oldaddcash()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "INSERT INTO tbl_collect (collectamt,
														 totaldue,
														 withhold,
														 balance,
														 controlno,
														 paymodeid,
														 collectdate,
														 employeeid,
														 datecreated)
													VALUES
														(@collectamt,
														 @totaldue,
														 @withhold,
														 @balance,
														 @controlno,
														 @paymodeid,
														 @collectdate,
														 @employeeid,
														 @datecreated)"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("collectamt", txt_payment.Text)
					cmd.Parameters.AddWithValue("totaldue", lbl_TotalDue.Text)
					cmd.Parameters.AddWithValue("withhold", lbl_withhold.Text)
					cmd.Parameters.AddWithValue("balance", lbl_bal.Text)
					cmd.Parameters.AddWithValue("controlno", row.Cells(1).Value)
					cmd.Parameters.AddWithValue("paymodeid", paymodeid)
					cmd.Parameters.AddWithValue("collectdate", dtp_ck_colldate.Value.Date)
					cmd.Parameters.AddWithValue("checkdate", dtp_ck_checkdate.Value.Date)
					cmd.Parameters.AddWithValue("employeeid", emplid)
					cmd.Parameters.AddWithValue("datecreated", Date.Now)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next

			MetroMessageBox.Show(BCEParent, "Payment has been successfully collected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub addcash()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "EXEC ins_collectcash @collectamt = @collectamt,
											 @totaldue = @totaldue,
											 @withhold = @withhold,
											 @balance = @balance,
											 @controlno = @controlno,
											 @paymodeid = @paymodeid,
											 @collectdate = @collectdate,
											 @employeeid = @employeeid,
											 @datecreated = @datecreated"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("collectamt", txt_payment.Text)
					cmd.Parameters.AddWithValue("totaldue", lbl_TotalDue.Text)
					cmd.Parameters.AddWithValue("withhold", lbl_withhold.Text)
					cmd.Parameters.AddWithValue("balance", lbl_bal.Text)
					cmd.Parameters.AddWithValue("controlno", controlno)
					cmd.Parameters.AddWithValue("paymodeid", paymodeid)
					cmd.Parameters.AddWithValue("collectdate", dtp_ck_colldate.Value.Date)
					cmd.Parameters.AddWithValue("employeeid", emplid)
					cmd.Parameters.AddWithValue("datecreated", Date.Now)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next

			MetroMessageBox.Show(BCEParent, "Payment has been successfully collected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub oldaddcheck()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "INSERT INTO tbl_collect (collectamt,
														 totaldue,
														 withhold,
														 balance,
														 controlno,
														 paymodeid,
														 collectdate,
														 checkdate,
														 bank,
														 checkno,
														 orno,
														 employeeid,
														 datecreated)
													VALUES
														(@collectamt,
														 @totaldue,
														 @withhold,
														 @balance,
														 @controlno,
														 @paymodeid,
														 @collectdate,
														 @checkdate,
													     @bank,
														 @checkno,
														 @orno,
														 @employeeid,
														 @datecreated)"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("collectamt", txt_payment.Text)
					cmd.Parameters.AddWithValue("totaldue", lbl_TotalDue.Text)
					cmd.Parameters.AddWithValue("withhold", lbl_withhold.Text)
					cmd.Parameters.AddWithValue("balance", lbl_bal.Text)
					cmd.Parameters.AddWithValue("controlno", row.Cells(1).Value)
					cmd.Parameters.AddWithValue("paymodeid", paymodeid)
					cmd.Parameters.AddWithValue("collectdate", dtp_ck_colldate.Value.Date)
					cmd.Parameters.AddWithValue("checkdate", dtp_ck_checkdate.Value.Date)
					If paymodeid = 1 Then
						cmd.Parameters.AddWithValue("bank", "")
					ElseIf paymodeid = 2 Then
						cmd.Parameters.AddWithValue("bank", cbo_ck_bank.Text)
					ElseIf paymodeid = 3 Then
						cmd.Parameters.AddWithValue("bank", cbo_dd_bank.Text)
					End If
					cmd.Parameters.AddWithValue("checkno", txt_ck_check.Text)
					cmd.Parameters.AddWithValue("orno", txt_ck_orno.Text)
					cmd.Parameters.AddWithValue("employeeid", emplid)
					cmd.Parameters.AddWithValue("datecreated", Date.Now)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next

			MetroMessageBox.Show(BCEParent, "Payment has been successfully collected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub addcheck()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "EXEC ins_collectcheck @collectamt = @collectamt,
											 @totaldue = @totaldue,
											 @withhold = @withhold,
											 @balance = @balance,
											 @controlno = @controlno,
											 @paymodeid = @paymodeid,
											 @collectdate = @collectdate,
											 @checkdate = @checkdate,
											 @bank = @bank,
											 @checkno = @checkno,
											 @orno = @orno,
											 @employeeid = @employeeid,
											 @datecreated = @datecreated"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("collectamt", txt_payment.Text)
					cmd.Parameters.AddWithValue("totaldue", lbl_TotalDue.Text)
					cmd.Parameters.AddWithValue("withhold", lbl_withhold.Text)
					cmd.Parameters.AddWithValue("balance", lbl_bal.Text)
					cmd.Parameters.AddWithValue("controlno", row.Cells(1).Value)
					cmd.Parameters.AddWithValue("paymodeid", paymodeid)
					cmd.Parameters.AddWithValue("collectdate", dtp_ck_colldate.Value.Date)
					cmd.Parameters.AddWithValue("checkdate", dtp_ck_checkdate.Value.Date)
					If paymodeid = 1 Then
						cmd.Parameters.AddWithValue("bank", "")
					ElseIf paymodeid = 2 Then
						cmd.Parameters.AddWithValue("bank", cbo_ck_bank.Text)
					ElseIf paymodeid = 3 Then
						cmd.Parameters.AddWithValue("bank", cbo_dd_bank.Text)
					End If
					cmd.Parameters.AddWithValue("checkno", txt_ck_check.Text)
					cmd.Parameters.AddWithValue("orno", txt_ck_orno.Text)
					cmd.Parameters.AddWithValue("employeeid", emplid)
					cmd.Parameters.AddWithValue("datecreated", Date.Now)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next

			MetroMessageBox.Show(BCEParent, "Payment has been successfully collected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub oldadddep()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "INSERT INTO tbl_collect (collectamt,
														 totaldue,
														 withhold,
														 balance,
														 controlno,
														 paymodeid,
														 bank,
														 depositdate,
														 employeeid,
														 datecreated)
													VALUES
														(@collectamt,
														 @totaldue,
														 @withhold,
														 @balance,
														 @controlno,
														 @paymodeid,
														 @bank,
														 @depositdate,
													     @employeeid,
														 @datecreated)"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("collectamt", txt_payment.Text)
					cmd.Parameters.AddWithValue("totaldue", lbl_TotalDue.Text)
					cmd.Parameters.AddWithValue("withhold", lbl_withhold.Text)
					cmd.Parameters.AddWithValue("balance", lbl_bal.Text)
					cmd.Parameters.AddWithValue("controlno", row.Cells(1).Value)
					cmd.Parameters.AddWithValue("paymodeid", paymodeid)
					cmd.Parameters.AddWithValue("depositdate", dtp_dd_depdate.Value.Date)
					If paymodeid = 1 Then
						cmd.Parameters.AddWithValue("bank", "")
					ElseIf paymodeid = 2 Then
						cmd.Parameters.AddWithValue("bank", cbo_ck_bank.Text)
					ElseIf paymodeid = 3 Then
						cmd.Parameters.AddWithValue("bank", cbo_dd_bank.Text)
					End If
					cmd.Parameters.AddWithValue("employeeid", emplid)
					cmd.Parameters.AddWithValue("datecreated", Date.Now)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next

			MetroMessageBox.Show(BCEParent, "Payment has been successfully collected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub adddep()
		Try
			For Each row As DataGridViewRow In dgv_bill.Rows
				If row.Cells(0).Value = True Then
					strQuery = "EXEC ins_collectdep @collectamt = @collectamt,
											 @totaldue = @totaldue,
											 @withhold = @withhold,
											 @balance = @balance,
											 @controlno = @controlno,
											 @paymodeid = @paymodeid,
											 @depositdate = @depositdate,
											 @bank = @bank,
											 @employeeid = @employeeid,
											 @datecreated = @datecreated"

					Dim cmd As New SqlCommand(strQuery)
					cmd.Parameters.AddWithValue("collectamt", txt_payment.Text)
					cmd.Parameters.AddWithValue("totaldue", lbl_TotalDue.Text)
					cmd.Parameters.AddWithValue("withhold", lbl_withhold.Text)
					cmd.Parameters.AddWithValue("balance", lbl_bal.Text)
					cmd.Parameters.AddWithValue("controlno", row.Cells(1).Value)
					cmd.Parameters.AddWithValue("paymodeid", paymodeid)
					cmd.Parameters.AddWithValue("depositdate", dtp_dd_depdate.Value.Date)
					If paymodeid = 1 Then
						cmd.Parameters.AddWithValue("bank", "")
					ElseIf paymodeid = 2 Then
						cmd.Parameters.AddWithValue("bank", cbo_ck_bank.Text)
					ElseIf paymodeid = 3 Then
						cmd.Parameters.AddWithValue("bank", cbo_dd_bank.Text)
					End If
					cmd.Parameters.AddWithValue("employeeid", emplid)
					cmd.Parameters.AddWithValue("datecreated", Date.Now)
					Dim dt As DataTable = GetData(cmd)
				End If
			Next

			MetroMessageBox.Show(BCEParent, "Payment has been successfully collected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub ins_collect()
		Try
			If paymodeid = 1 Then
				If controlno = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have Billing Statement", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Else
					If OldAccountReceivableToolStripMenuItem.Checked = True Then
						oldaddcash()
						oldupd_billingstat()
						oldupd_due()
					Else
						addcash()
						upd_billingstat()
						upd_due()
					End If
				End If
			ElseIf paymodeid = 2 Then
				If controlno = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have Billing Statement", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				ElseIf txt_payment.Text = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have Payment", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				ElseIf cbo_ck_bank.Text = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have Bank", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				ElseIf txt_ck_check.Text = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have Check No.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				ElseIf txt_ck_orno.Text = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have OR No.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Else
					If OldAccountReceivableToolStripMenuItem.Checked = True Then
						oldaddcheck()
						oldupd_billingstat()
						oldupd_due()
					Else
						addcheck()
						upd_billingstat()
						upd_due()
					End If

				End If
			ElseIf paymodeid = 3 Then
				If controlno = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have Billing Statement", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				ElseIf cbo_dd_bank.Text = Nothing Then
					MetroMessageBox.Show(BCEParent, "Must have Bank", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
				Else
					If OldAccountReceivableToolStripMenuItem.Checked = True Then
						oldadddep()
						oldupd_billingstat()
						oldupd_due()
					Else
						adddep()
						upd_billingstat()
						upd_due()
					End If
				End If
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub clear()
		Try
			dgv_track.Columns.Clear()
			lbl_TotalDue.Text = Nothing
			txt_payment.Text = Nothing
			lbl_bal.Text = Nothing
			cbo_ck_bank.Text = Nothing
			cbo_dd_bank.Text = Nothing
			txt_ck_check.Text = Nothing
			txt_ClientSearch.Text = Nothing
			lbl_withhold.Text = Nothing
			cb_2wt.Checked = False
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
		Try
			Me.Dispose()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub rb_cash_CheckedChanged(sender As Object, e As EventArgs) Handles rb_cash.CheckedChanged
		Try
			If rb_cash.Checked = True Then
				paymodeid = 1
				pnl_cash.Visible = True
				pnl_check.Visible = False
				pnl_dirdep.Visible = False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub rb_check_CheckedChanged(sender As Object, e As EventArgs) Handles rb_check.CheckedChanged
		Try
			If rb_check.Checked = True Then
				paymodeid = 2
				pnl_cash.Visible = False
				pnl_check.Visible = True
				pnl_dirdep.Visible = False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_set_Click(sender As Object, e As EventArgs) Handles btn_set.Click
		GetTotalDue()
		totaltax()
		computation()
	End Sub

	Private Sub rb_dirdep_CheckedChanged(sender As Object, e As EventArgs) Handles rb_dirdep.CheckedChanged
		Try
			If rb_dirdep.Checked = True Then
				paymodeid = 3
				pnl_cash.Visible = False
				pnl_check.Visible = False
				pnl_dirdep.Visible = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_ClientSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_ClientSearch.TextChanged
		If OldAccountReceivableToolStripMenuItem.Checked = True Then
			oldClientListsh()
		Else
			ClientListsh()
		End If
	End Sub
	Sub wt2()
		Try
			If OldAccountReceivableToolStripMenuItem.Checked = True Then
				For Each row As DataGridViewRow In dgv_track.Rows
					row.Cells(6).Value = Val(row.Cells(5).Value) * 0.02
				Next
			Else
				For Each row As DataGridViewRow In dgv_track.Rows
					row.Cells(9).Value = Val(row.Cells(6).Value) * 0.02
				Next
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub wt5()
		Try
			If OldAccountReceivableToolStripMenuItem.Checked = True Then
				For Each row As DataGridViewRow In dgv_track.Rows
					row.Cells(6).Value = Val(row.Cells(5).Value) * 0.05
				Next
			Else
				For Each row As DataGridViewRow In dgv_track.Rows
					row.Cells(9).Value = Val(row.Cells(6).Value) * 0.05
				Next
			End If

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_bill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_bill.CellContentClick

	End Sub

	Private Sub txt_ClientSearch_Click(sender As Object, e As EventArgs) Handles txt_ClientSearch.Click

	End Sub

	Private Sub cb_5wt_CheckedChanged(sender As Object, e As EventArgs) Handles cb_5wt.CheckedChanged
		Try
			Dim col As New DataGridViewTextBoxColumn
			col.DataPropertyName = "withhold"
			col.HeaderText = "5% WT"
			col.Name = "withhold"
			If dgv_track.Columns.Count > 0 Then
				If cb_5wt.Checked = True Then
					cb_2wt.Checked = False
					dgv_track.Columns.Add(col)
					wt5()
				Else
					dgv_track.Columns.Remove("withhold")
				End If
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub CollectionListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionListToolStripMenuItem.Click
		Try
			If OldAccountReceivableToolStripMenuItem.Checked = True Then
				strQuery = "SELECT status as 'Status',
							   datecollected as 'Date Collected',
							   soa as 'Control No.',
							   hwbdate as 'HWB Date',
							   hwb as 'HWB No.',
							   account as 'Account No.',
							   customername as 'Client Name',
							   shipmentdetails as 'Commodity',
							   paymode as 'Pay Mode',
							   origin as 'Origin',
							   destination as 'Destination',
							   billingamount as 'Total Due',
							   amountpaid as 'Collection Amt.',
							   amountoutstanding as 'Balance',
							   duedate as 'Due Date',
							   transmitteddate as 'Transmitted Date',
							   terms as 'Terms',
							   pastdue as 'Past Due'
						FROM tbl_oldar"
			Else
				strQuery = "EXEC vw_collectinfo"
			End If

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			Dim obb As New CollectionView
			obb.dgv_collection.DataSource = dt
			obb.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub OldAccountReceivableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OldAccountReceivableToolStripMenuItem.Click
		Try
			If OldAccountReceivableToolStripMenuItem.Checked = True Then
				oldar()
				enabledoldar = True
			Else
				ClientListsh()
				enabledoldar = False
			End If
			dgv_track.Columns.Clear()
			lbl_TrackingNo.Text = 0
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub cb_withholding_CheckedChanged(sender As Object, e As EventArgs) Handles cb_2wt.CheckedChanged
		Try
			Dim col As New DataGridViewTextBoxColumn
			col.DataPropertyName = "withhold"
			col.HeaderText = "2% WT"
			col.Name = "withhold"
			If dgv_track.Columns.Count > 0 Then
				If cb_2wt.Checked = True Then
					cb_5wt.Checked = False
					dgv_track.Columns.Add(col)
					wt2()
				Else
					dgv_track.Columns.Remove("withhold")
				End If
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub cbo_dd_bank_DropDown(sender As Object, e As EventArgs) Handles cbo_dd_bank.DropDown
		Bank("Item")
	End Sub
End Class