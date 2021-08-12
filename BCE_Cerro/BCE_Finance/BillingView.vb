Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Imports System.ComponentModel

Public Class BillingView
	Dim icontrolno, billingid, rev As Integer
	Dim rptdoc As ReportDocument
	Dim HControlNo, fn, fnpos, imm, immpos, billingcontrolno As String
	Dim billingdate As Date
	Dim grandtotal As Double
	Dim totaldue As Double

	Private Sub BillingView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SOAList()
	End Sub
	Sub SOAList()
		Try
			strQuery = "EXEC vw_soa"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_genbill.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub SOAListsh()
		Try
			If txt_Search.Text <> Nothing Then
				strQuery = "EXEC vw_soa_sh @controlno = @controlno,
										   @account_number = @acctno,
										   @company_name = @compname"
			Else
				strQuery = "EXEC vw_soa"
			End If

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("controlno", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("acctno", "%" + txt_Search.Text + "%")
			cmd.Parameters.AddWithValue("compname", "%" + txt_Search.Text + "%")
			Dim dt As DataTable = GetData(cmd)

			dgv_genbill.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_genbill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_genbill.CellContentClick

	End Sub

	Private Sub dgv_genbill_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_genbill.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_genbill.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_genbill.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_genbill.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

	End Sub

	Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
		SOAListsh()
	End Sub
	Sub getitem()
		Try
			conn("SELECT DISTINCT (controlno),
							 account_number,
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
				   FORMAT(grandtotal, N'N2') as 'grandtotal'
					FROM vw_soalist
					WHERE controlno LIKE '" & dgv_genbill.Item(4, icontrolno).Value & "'
						AND hwbstatus LIKE 'CLOSED'", "vw_soalist")

			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "SELECT FORMAT(SUM(grandtotal), N'N2')
						FROM vw_billingupdamt
						WHERE controlno LIKE '" & dgv_genbill.Item(4, icontrolno).Value & "'"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				grandtotal = dt.Rows(dt.Rows.Count - 1).Item(0)
			End If

			strQuery = "SELECT controlno, 
							   billingdate, 
							   totaldue
						FROM tbl_billing
						WHERE controlno LIKE '" & dgv_genbill.Item(4, icontrolno).Value & "'"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				HControlNo = dt.Rows(dt.Rows.Count - 1).Item(0)
				billingdate = dt.Rows(dt.Rows.Count - 1).Item(1)
				totaldue = dt.Rows(dt.Rows.Count - 1).Item(2)
			End If

			strQuery = "SELECT controlno FROM vw_billingapp
						WHERE controlno LIKE '" & dgv_genbill.Item(4, icontrolno).Value & "'"
			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If dt.Rows.Count > 0 Then
				strQuery = "SELECT MAX(rev) FROM vw_billingapp
						WHERE controlno LIKE '" & dgv_genbill.Item(4, icontrolno).Value & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)

				If IsDBNull(dt.Rows.Count) Then
					rev = dt.Rows(dt.Rows.Count - 1).Item(0)
				End If
			End If

			strQuery = "SELECT fullname,
							   position,
							   immediatesuperior
						FROM vw_acctmaster
						WHERE employeeid = '" & emplid & "'"

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
			Dim txt_billingdate, txt_amtdue, txt_amtdue1, txt_controlno, txt_rev, txt_prename, txt_prepos, txt_appname, txt_apppos As TextObject
			dssearch = New dsreport
			dasearch.Fill(dssearch, "dtSOA")
			rptdoc = New cr_SOA
			rptdoc.SetDataSource(dssearch)
			txt_controlno = rptdoc.ReportDefinition.ReportObjects("txt_controlno")
			txt_controlno.Text = HControlNo
			txt_billingdate = rptdoc.ReportDefinition.ReportObjects("txt_billingdate")
			txt_billingdate.Text = billingdate
			txt_amtdue = rptdoc.ReportDefinition.ReportObjects("txt_amtdue")
			txt_amtdue.Text = grandtotal.ToString("N2")
			txt_amtdue1 = rptdoc.ReportDefinition.ReportObjects("txt_amtdue1")
			txt_amtdue1.Text = grandtotal.ToString("N2")
			txt_rev = rptdoc.ReportDefinition.ReportObjects("txt_rev")
			txt_rev.Text = rev

			txt_prename = rptdoc.ReportDefinition.ReportObjects("txt_prename")
			txt_prename.Text = fn
			txt_prepos = rptdoc.ReportDefinition.ReportObjects("txt_prepos")
			txt_prepos.Text = fnpos
			txt_appname = rptdoc.ReportDefinition.ReportObjects("txt_appname")
			txt_appname.Text = imm
			txt_apppos = rptdoc.ReportDefinition.ReportObjects("txt_apppos")
			txt_apppos.Text = immpos

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_genbill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_genbill.CellClick
		Try
			If e.ColumnIndex = 0 Then
				While (MetroPanel1.Height > 184)
					MetroPanel1.Height -= 8
				End While
				dgv_genbill.Columns(1).Visible = False
				icontrolno = e.RowIndex
				billingcontrolno = dgv_genbill.Item(4, icontrolno).Value
				waybillclosed()
				waybillopen()
			ElseIf e.ColumnIndex = 1 Then
				icontrolno = e.RowIndex
				getitem()
				SOASheet()
				rptdoc.PrintToPrinter(1, False, 0, 0)
				Me.Dispose()
			ElseIf e.ColumnIndex = 2 Then
				icontrolno = e.RowIndex
				Dim obb As New BillingTrans
				obb.lbl_ControlNo.Text = dgv_genbill.Item(4, icontrolno).Value
				obb.acctno = dgv_genbill.Item(5, icontrolno).Value
				obb.lbl_Terms.Text = dgv_genbill.Item(9, icontrolno).Value
				obb.ShowDialog()
			ElseIf e.ColumnIndex = 3 Then
				reasonreq = "FinSOACancel"
				icontrolno = e.RowIndex
				Dim obb As New Reason
				obb.soacancelctrlno = dgv_genbill.Item(4, icontrolno).Value
				obb.ShowDialog()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub waybillclosed()
		Try
			strQuery = "EXEC vw_waybillclosed @controlno = @controlno"

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("controlno", dgv_genbill.Item(4, icontrolno).Value)
			Dim dt As DataTable = GetData(cmd)

			dgv_current.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub waybillclosedupd()
		Try
			strQuery = "EXEC vw_waybillclosed @controlno = @controlno"

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("controlno", dgv_genbill.Item(1, icontrolno).Value)
			Dim dt As DataTable = GetData(cmd)

			dgv_current.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub waybillopen()
		Try
			strQuery = "EXEC vw_waybillopen @controlno = @controlno"

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("controlno", dgv_genbill.Item(4, icontrolno).Value)
			Dim dt As DataTable = GetData(cmd)

			dgv_other.DataSource = dt

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub waybillopenupd()
		Try
			strQuery = "EXEC vw_waybillopen @controlno = @controlno"

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("controlno", dgv_genbill.Item(1, icontrolno).Value)
			Dim dt As DataTable = GetData(cmd)

			dgv_other.DataSource = dt

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_current_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_current.CellContentClick

	End Sub

	Private Sub dgv_current_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_current.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_current.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_current.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_current.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_other_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_other.CellContentClick

	End Sub

	Private Sub dgv_other_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_other.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_other.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_other.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_other.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub BillingView_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Try
			Me.Dispose()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub current()
		Try

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_current_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_current.CellClick
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			If e.ColumnIndex = 0 Then
				BillRev = True
				icontrolno = e.RowIndex

				strQuery = "SELECT id FROM vw_soalist
							WHERE outboundid = @outboundid"

				cmd.CommandText = strQuery
				cmd.Parameters.AddWithValue("outboundid", dgv_current.Item(1, icontrolno).Value)
				dt = GetData(cmd)

				billingid = dt.Rows(dt.Rows.Count - 1).Item(0)
				reasonreq = "Fin"

				Dim obb As New Reason
				obb.billingidrea = billingid
				obb.obidcur = dgv_current.Item(1, icontrolno).Value
				obb.billingcontrolno = billingcontrolno
				obb.ShowDialog()

				waybillopen()
				waybillclosed()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub TotalAmt()
		Try

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub btn_Done_Click(sender As Object, e As EventArgs) Handles btn_Done.Click
		Try
			While (MetroPanel1.Height < 404)
				MetroPanel1.Height += 8
			End While
			dgv_genbill.Columns(1).Visible = True
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub dgv_other_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_other.CellClick
		Try
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			If e.ColumnIndex = 0 Then
				BillRev = False
				icontrolno = e.RowIndex

				strQuery = "SELECT id FROM vw_soalist
							WHERE outboundid = @outboundid"

				cmd.CommandText = strQuery
				cmd.Parameters.AddWithValue("outboundid", dgv_other.Item(1, icontrolno).Value)
				dt = GetData(cmd)

				billingid = dt.Rows(dt.Rows.Count - 1).Item(0)
				reasonreq = "Fin"

				Dim obb As New Reason
				obb.billingidrea = billingid
				obb.obidoth = dgv_other.Item(1, icontrolno).Value
				obb.ShowDialog()

				waybillopen()
				waybillclosed()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub BillingView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Me.Dispose()
	End Sub

End Class