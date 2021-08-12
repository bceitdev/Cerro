Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Imports System.ComponentModel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports System.IO
Public Class CSReport

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'ViewDeliveryList()
	End Sub
	Sub ViewDeliveryList()
		Try
			strQuery = "EXEC vw_cs_report @date1 = @date1,
										  @date2 = @date2"

			Dim cmd As New SqlCommand(strQuery)
			cmd.Parameters.AddWithValue("date1", dtp_From.Value.Date)
			cmd.Parameters.AddWithValue("date2", dtp_To.Value.Date)
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

	Private Sub dtp_From_ValueChanged(sender As Object, e As EventArgs) Handles dtp_From.ValueChanged
		ViewDeliveryList()
	End Sub

	Private Sub dtp_To_ValueChanged(sender As Object, e As EventArgs) Handles dtp_To.ValueChanged
		ViewDeliveryList()
	End Sub

    Sub export()
        Try
            Dim FileName As String
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")

            For i As Integer = 1 To dgv_Deliverylist.Columns.Count
                xlWorkSheet.Cells(1, i) = dgv_Deliverylist.Columns(i - 1).HeaderText
            Next
            For i As Integer = 0 To dgv_Deliverylist.Rows.Count - 2
                For j As Integer = 0 To dgv_Deliverylist.Columns.Count - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = (dgv_Deliverylist(j, i).Value & "").ToString
                Next
            Next

            Dim SaveFileDialog As New SaveFileDialog
            SaveFileDialog.Filter = "Excel File |*.xlsx"
            SaveFileDialog.Title = "Save KPI Result"
            If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                FileName = SaveFileDialog.FileName
                xlWorkBook.SaveAs(FileName)
                xlWorkSheet = Nothing
                xlWorkBook.Close()
                xlWorkBook = Nothing
                xlApp.Quit()
                xlApp = Nothing
                MsgBox("Export Success", MsgBoxStyle.Information, "Success")
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbl_Export_Click(sender As Object, e As EventArgs) Handles lbl_Export.Click
        export()
    End Sub
End Class