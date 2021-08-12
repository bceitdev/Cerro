Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Public Class TrackingList
	Dim rptdoc As ReportDocument
	Dim i, trackid As Integer
	Dim HWBs, letter As String

	Sub getsearch()
		Try
			letter = txt_Search.Text.Substring(0, 3)
			HWBs = letter + txt_Search.Text.Remove(0, 3).PadLeft(10, "0")

			tracklistsearch()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub tracklistsearch()
		Try
			strQuery = "SELECT DISTINCT (hwb_no) as 'Tracking No.',
							   hwb_no_carb as 'HWB No.',
							   pur_no as 'PUR No.',
							   shipdate as 'Ship Date',
							   origin_code as 'Origin',
							   destination_code as 'Destination',
							   company_name as 'Shipper',
							   consignee as 'Consignee',
							   commodity as 'Commodity',
							   freightmode as 'Freight Mode',
							   servicemode as 'Service Mode',
							   paymode as 'Paymode',
							   loadingmode as 'Loading Mode'
						FROM tbl_dummydimension
						WHERE hwb_no LIKE '" & HWBs & "'"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_TrackList.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub tracklist()
		Try
			strQuery = "SELECT DISTINCT (hwb_no) as 'Tracking No.',
							   hwb_no_carb as 'HWB No.',
							   pur_no as 'PUR No.',
							   shipdate as 'Ship Date',
							   origin_code as 'Origin',
							   destination_code as 'Destination',
							   company_name as 'Shipper',
							   consignee as 'Consignee',
							   commodity as 'Commodity',
							   freightmode as 'Freight Mode',
							   servicemode as 'Service Mode',
							   paymode as 'Paymode',
							   loadingmode as 'Loading Mode'
						FROM tbl_dummydimension
						WHERE hwb_no IS NOT NULL"

			Dim cmd As New SqlCommand(strQuery)
			Dim dt As DataTable = GetData(cmd)

			dgv_TrackList.DataSource = dt
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub TrackingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		tracklist()
	End Sub

	Sub updforaccepted()
		Try
			Dim recid, servid As Integer
			Dim cmd As New SqlCommand
			Dim dt As DataTable

			strQuery = "SELECT received_id, serviceorder_id
						FROM tbl_dummydimension"

			cmd.CommandText = strQuery
			dt = GetData(cmd)

			If Not IsDBNull(recid) Then

				recid = dt.Rows(dt.Rows.Count - 1).Item(0)

				strQuery = "SELECT daterec 
							FROM tbl_receive
							WHERE id = '" & recid & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)

				Dim daterec As Date = dt.Rows(dt.Rows.Count - 1).Item(0)

				strQuery = "UPDATE tbl_dummydimension
							SET accepted_date = '" & daterec & "'
							WHERE received_id = '" & recid & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)
			ElseIf Not IsDBNull(servid) Then

				servid = dt.Rows(dt.Rows.Count - 1).Item(1)

				strQuery = "SELECT date 
							FROM tbl_serviceorder
							WHERE id = '" & servid & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)

				Dim dateserv As Date = dt.Rows(dt.Rows.Count - 1).Item(0)

				strQuery = "UPDATE tbl_dummydimension
							SET accepted_date = '" & dateserv & "'
							WHERE serviceorder_id = '" & servid & "'"

				cmd.CommandText = strQuery
				dt = GetData(cmd)
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Sub GetItem()
		Try
			'updforaccepted()

			conn("SELECT accepted_date,
					     pur_no,
                         hwb_no_carb,
                         hwb_no, 
	                     shipdate,
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
                  WHERE hwb_no LIKE '" & dgv_TrackList.Item(2, i).Value & "'", "tbl_dummydimension")

			If dtsearch.Rows.Count > 0 Then
				HWBReprint = dtsearch.Rows(dtsearch.Rows.Count - 1).Item(3)
				'shipdateReprint = dtsearch.Rows(dtsearch.Rows.Count - 1).Item(4)
				HWBSheetReprint()
			Else
				MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Sub HWBSheetReprint()
		Try
			Dim txt_CtrlNo, txt_ShipDate As TextObject
			dssearch = New dsreport
			dasearch.Fill(dssearch, "dtHWB")
			rptdocreprint = New cr_HWB
			rptdocreprint.SetDataSource(dssearch)
			txt_CtrlNo = rptdocreprint.ReportDefinition.ReportObjects("txt_CtrlNo")
			txt_CtrlNo.Text = HWBReprint
			'txt_ShipDate = rptdocreprint.ReportDefinition.ReportObjects("txt_ShipDate")
			'txt_ShipDate.Text = shipdateReprint

			TrackingReprint.crv_HWB.ReportSource = rptdocreprint
			TrackingReprint.crv_HWB.Refresh()

			TrackingReprint.ShowDialog()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub dgv_Receive_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_TrackList.CellContentClick

	End Sub

	Private Sub dgv_Receive_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_TrackList.CellPainting
		Try
			If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_TrackList.Rows.Count Then
				Dim indexString As String = (e.RowIndex + 1).ToString
				Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_TrackList.Font)
				Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
				e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
				e.Graphics.DrawString(indexString, dgv_TrackList.Font, Brushes.Black, pt)
				e.Handled = True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txt_hwbno_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

	End Sub

	Private Sub txt_hwbno_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged

	End Sub

	Private Sub dgv_TrackList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_TrackList.CellClick
		Try
			i = e.RowIndex
			If e.ColumnIndex = 0 Then
				GetItem()
			ElseIf e.ColumnIndex = 1 Then
				reasonreq = "Ops"
				Dim obb As New Reason
				obb.trackidrea = dgv_TrackList.Item(2, i).Value
				obb.trackingcontrolno = dgv_TrackList.Item(2, i).Value
				obb.ShowDialog()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
		If e.KeyCode = Keys.Enter Then
			getsearch()
		End If
	End Sub
End Class