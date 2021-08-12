Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Public Class ForCosting
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
	Private Sub ForCosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		tracklist()
	End Sub

	Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

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

	Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
		Try
			If e.KeyCode = Keys.Enter Then
				getsearch()
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
End Class