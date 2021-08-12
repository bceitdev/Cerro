Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Public Class Billing
	Dim tablocked As Boolean = True
	Dim acctno, HControlNo, hwbno, selhwbno, fn, fnpos, imm, immpos As String
	Dim HCount As Integer
	Dim grandtotal As Double
	Dim rptdoc As ReportDocument
	Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ClientList()
	End Sub

	Sub ClientList()
		Try
			strQuery = "EXEC vw_clientinfo @clientstatus = 'OPEN'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_ClientList.DataSource = dt
			dgv_ClientList.Columns(0).ReadOnly = False
			lbl_ClientCount.Text = dgv_ClientList.Rows.Count
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub BillingList()
		Try
			strQuery = "EXEC vw_billinginfo @hwbstatus = 'OPEN',
											@account_number = @acctno"

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("acctno", acctno)
			Dim dt As DataTable = GetData(cmd)

			dgv_BillingList.DataSource = dt
			lbl_BillingCount.Text = dgv_BillingList.Rows.Count

			For i As Integer = 1 To 9
				dgv_BillingList.Columns(i).ReadOnly = True
			Next

			ControlNo()
			BillingDetails()

			tablocked = False
			MetroTabControl1.SelectedIndex = 1
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub BillingDetails()
		Try
			Dim amount As Double

			lbl_BillingDate.Text = Date.Now.Date

			For i As Integer = 0 To dgv_BillingList.Rows.Count - 1
				amount += dgv_BillingList.Item(8, i).Value
			Next
			lbl_Balance.Text = amount
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub GetItem()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			selhwbno = selhwbno.TrimEnd(",")
			conn("SELECT DISTINCT (account_number),
						 company_name,
				  CONCAT(unit_no_floor, ' ',
						 building_name, ' ',
						 street_name, ' ',
						 subdivision_village, ' ',
						 city, ' ',
						 province, ' ',
						 zip_code) as 'Address',
						 shipdate,
				 	     outboundid,
						 hwb_no_carb,
				 	     commodity,
				 	     orig,
				 	     dest,
				   FORMAT(freight, N'N2') as 'freight',
				   FORMAT(valuation, N'N2') as 'valuation',
				   FORMAT(insurance, N'N2') as 'insurance',
				   FORMAT(waybillfee, N'N2') as 'waybillfee',
				   FORMAT(permits, N'N2') as 'permits',
				   FORMAT(handling, N'N2') as 'handling',
				   FORMAT(pickup, N'N2') as 'pickup',
				   FORMAT(deliveryoda, N'N2') as 'deliveryoda',
				   FORMAT(crafting, N'N2') as 'crafting',
				   FORMAT(packing, N'N2') as 'packing',
				   FORMAT(others_vat, N'N2') as 'others_vat',
				   FORMAT(others_nvat, N'N2') as 'others_nvat',
				   FORMAT(subtotal, N'N2') as 'subtotal',
				   FORMAT(vat, N'N2') as 'vat',
				   FORMAT(grandtotal, N'N2') as 'grandtotal',
						 hwb_no_carb
				 FROM vw_billing
				 WHERE outboundid IN(" & selhwbno & ")", "vw_billing")

			strQuery = "SELECT FORMAT(SUM(grandtotal), N'N2')
						FROM tbl_costing
						WHERE outboundid IN(" & selhwbno & ")"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				grandtotal = dt.Rows(dt.Rows.Count - 1).Item(0)
			End If

			strQuery = "SELECT fullname,
							   position,
							   immediatesuperior
						FROM vw_acctmaster
						WHERE employeeid = " & emplid & "
"
			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				fn = dt.Rows(dt.Rows.Count - 1).Item(0)
				fnpos = dt.Rows(dt.Rows.Count - 1).Item(1)
				imm = dt.Rows(dt.Rows.Count - 1).Item(2)
			End If

			strQuery = "SELECT position 
						FROM vw_acctmaster
						WHERE fullname = @fullname
"
			cmd.CommandText = strQuery
			cmd.Parameters.AddWithValue("fullname", imm)
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				immpos = dt.Rows(dt.Rows.Count - 1).Item(0)
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub SOASheet()
		Try
			Dim txt_billingdate, txt_amtdue, txt_amtdue1, txt_controlno, txt_prename, txt_prepos, txt_appname, txt_apppos As TextObject
			dssearch = New dsreport
			dasearch.Fill(dssearch, "dtSOA")
			rptdoc = New cr_SOA
			rptdoc.SetDataSource(dssearch)

			txt_controlno = rptdoc.ReportDefinition.ReportObjects("txt_controlno")
			txt_controlno.Text = HControlNo
			txt_billingdate = rptdoc.ReportDefinition.ReportObjects("txt_billingdate")
			txt_billingdate.Text = lbl_BillingDate.Text
			txt_amtdue = rptdoc.ReportDefinition.ReportObjects("txt_amtdue")
			txt_amtdue.Text = grandtotal.ToString("N2")
			txt_amtdue1 = rptdoc.ReportDefinition.ReportObjects("txt_amtdue1")
			txt_amtdue1.Text = grandtotal.ToString("N2")


			txt_prename = rptdoc.ReportDefinition.ReportObjects("txt_prename")
			txt_prename.Text = fn
			txt_prepos = rptdoc.ReportDefinition.ReportObjects("txt_prepos")
			txt_prepos.Text = fnpos
			txt_appname = rptdoc.ReportDefinition.ReportObjects("txt_appname")
			txt_appname.Text = imm
			txt_apppos = rptdoc.ReportDefinition.ReportObjects("txt_apppos")
			txt_apppos.Text = immpos

			crv_SOA.ReportSource = rptdoc
			crv_SOA.Refresh()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
		Try
			If acctno = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have Client", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Else
				BillingList()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub ClientListSh()
		Try
			If txt_ClientSearch.Text <> Nothing Then
				strQuery = "EXEC vw_clientinfo_sh @account_number = @acctno,
												  @company_name = @compname,
												  @clientstatus = 'OPEN'"
			Else
				strQuery = "EXEC vw_clientinfo @clientstatus = 'OPEN'"
			End If

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("acctno", "%" + txt_ClientSearch.Text + "%")
			cmd.Parameters.AddWithValue("compname", "%" + txt_ClientSearch.Text + "%")
			Dim dt As DataTable = GetData(cmd)

			dgv_ClientList.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub BillingListSh()
		Try
			If txt_BillingSearch.Text <> Nothing Then
				strQuery = "EXEC vw_billinginfo_sh @hwbstatus = 'OPEN',
												   @outboundid = @outboundid"
			Else
				strQuery = "EXEC vw_billinginfo @hwbstatus = 'OPEN',
												@account_number = @acctno"
			End If

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("acctno", acctno)
			cmd.Parameters.AddWithValue("outboundid", "%" + txt_BillingSearch.Text + "%")
			Dim dt As DataTable = GetData(cmd)

			dgv_BillingList.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_ClientSearch.TextChanged
		ClientListSh()
	End Sub

	Private Sub MetroTabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles MetroTabControl1.Selecting
		Try
			If tablocked = True Then
				e.Cancel = True
			ElseIf tablocked = False Then
				e.Cancel = False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub MetroTabPage1_Enter(sender As Object, e As EventArgs) Handles MetroTabPage1.Enter
		Try
			tablocked = True
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub MetroTabPage2_Enter(sender As Object, e As EventArgs) Handles MetroTabPage2.Enter
		Try
			tablocked = True
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub MetroTabPage3_Enter(sender As Object, e As EventArgs) Handles MetroTabPage3.Enter
		Try
			tablocked = True
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
		Try
			tablocked = False
			MetroTabControl1.SelectedIndex = 0
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub InsertBilling()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable
			Dim costingid As Integer

			For Each row As DataGridViewRow In dgv_BillingList.Rows
				If row.Cells(0).Value = True Then

					strQuery = "SELECT id FROM tbl_costing
								WHERE outboundid = '" & row.Cells(1).Value & "'"
					cmd.CommandText = strQuery
					dt = GetData(cmd)

					If dt.Rows.Count > 0 Then
						costingid = dt.Rows(dt.Rows.Count - 1).Item(0)

						strQuery = "EXEC ins_billing @count = '" & HCount & "',
												 @controlno = '" & HControlNo & "',
												 @billingdate = '" & Date.Now.Date & "',
												 @totaldue = '" & grandtotal & "',
												 @dueforcoll = '" & grandtotal & "',
												 @costingid = '" & costingid & "',
												 @status = 'OPEN',
												 @employeeid = '" & emplid & "',
												 @datecreated = '" & Date.Now & "'"
						cmd.CommandText = strQuery
						dt = GetData(cmd)

						strQuery = "EXEC upd_clienthwbstat @id = '" & costingid & "'"
						cmd.CommandText = strQuery
						dt = GetData(cmd)

					End If
				End If
			Next
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_Next1_Click(sender As Object, e As EventArgs) Handles btn_Next1.Click
		Try
			If hwbno = Nothing Then
				MetroMessageBox.Show(BCEParent, "Must have HWB", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Else
				GetItem()
				SOASheet()
				ControlNo()

				tablocked = False
				MetroTabControl1.SelectedIndex = 2
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_Back1_Click(sender As Object, e As EventArgs) Handles btn_Back1.Click
		Try
			selhwbno = selhwbno & ","

			tablocked = False
			MetroTabControl1.SelectedIndex = 1
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_ForBilling_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_BillingList.CellContentClick

	End Sub

	Private Sub dgv_ForBilling_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_BillingList.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_BillingList.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_BillingList.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_BillingList.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_ClientList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ClientList.CellContentClick

	End Sub

	Private Sub dgv_ClientList_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_ClientList.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_ClientList.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_ClientList.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_ClientList.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_ClientList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ClientList.CellClick
		Try
			If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
				For Each row As DataGridViewRow In dgv_ClientList.Rows
					If row.Index = e.RowIndex Then
						row.Cells(0).Value = Not Convert.ToBoolean(row.Cells(0).EditedFormattedValue)
					Else
						row.Cells(0).Value = False
					End If
				Next
			End If

			If e.ColumnIndex = 0 Then
				acctno = dgv_ClientList.Item(1, e.RowIndex).Value
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_BillingList_Click(sender As Object, e As EventArgs) Handles btn_BillingList.Click
		Try
			BillingView.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_StaApp_Click(sender As Object, e As EventArgs) Handles btn_StaApp.Click
		Try
			BillingApp.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub ExpCol_Setting()
		If pnl_Setting.Height = 0 Then
			While (pnl_Setting.Height < 204)
				pnl_Setting.Height += 8
			End While
		Else
			While (pnl_Setting.Height > 0)
				pnl_Setting.Height -= 8
			End While
		End If
	End Sub

	Private Sub btn_RevBillList_Click(sender As Object, e As EventArgs) Handles btn_RevBillList.Click
		Try
			BillingRevList.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_TrackingList_Click(sender As Object, e As EventArgs) Handles btn_TrackingList.Click
		Try
			BilledList.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_CanBillList_Click(sender As Object, e As EventArgs) Handles btn_CanBillList.Click
		Try
			BillingCanList.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub btn_unbilled_Click(sender As Object, e As EventArgs) Handles btn_unbilled.Click
		Try
			Unbilled.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

	End Sub

	Private Sub mt_Setting_Click(sender As Object, e As EventArgs) Handles mt_Setting.Click
		ExpCol_Setting()
	End Sub

	Sub clear()
		acctno = Nothing
		hwbno = Nothing
		selhwbno = Nothing
	End Sub
	Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
		Try
			Dim mbox As String = MetroMessageBox.Show(BCEParent, "Are you sure?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If mbox = vbYes Then
				rptdoc.PrintToPrinter(2, False, 0, 0)
				InsertBilling()
				ClientList()
				clear()
				tablocked = False
				MetroTabControl1.SelectedIndex = 0
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_BillingList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_BillingList.CellClick
		Try

			If e.ColumnIndex = 0 Then
				hwbno = dgv_BillingList.Item(1, e.RowIndex).Value

				For Each row As DataGridViewRow In dgv_BillingList.SelectedRows
					If Not InStr(selhwbno, row.Cells.Item(1).Value.ToString.Trim) Then
						selhwbno &= "'" & row.Cells.Item(1).Value.ToString.Trim & "',"
					End If
				Next
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub ControlNo()
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "SELECT count FROM tbl_billing"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				strQuery = "SELECT ISNULL(MAX(count), 0) + 1
							FROM tbl_billing"
			Else
				strQuery = "SELECT ISNULL(MAX(billing_number01), 0) + 1
							FROM hwb_billing"
			End If
			cmd.CommandText = strQuery
			dt = GetData(cmd)

			HCount = dt.Rows(dt.Rows.Count - 1).Item(0)
			HControlNo = "BCESOA" + Date.Now.ToString("yy") + HCount.ToString("000000")
			lbl_ControlNo.Text = HControlNo
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub


	Private Sub txt_BillingSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_BillingSearch.TextChanged
		BillingListSh()
	End Sub

	Private Sub mt_Setting_MouseHover(sender As Object, e As EventArgs) Handles mt_Setting.MouseHover
		ExpCol_Setting()
	End Sub
End Class