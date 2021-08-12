Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports Excel = Microsoft.Office.Interop.Excel
Public Class CVList

    Dim icontrolno As Integer
    Private Sub CheckVoucherList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewcheck()
    End Sub
    Sub viewdate()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "SELECT DISTINCT controlno as 'Control No.',
                                   datecreated as 'Date Generated',
                                   bank as 'Bank',
                                   date as 'Date',
                                   checkseries as 'Check No.',
                                   payee as 'Payee',
	                               particulars as 'Particulars',
                            REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','') as 'Amount in Figure',
                                   code as 'Code',
                                   description as 'Description',
                                   debit as 'Debit',
	                               credit as 'Credit',                                         
                                   status as 'Status',
                                   remarks as 'Remarks'
                            FROM vw_CVPrint
                            WHERE controlno LIKE '%" & txt_Search.Text & "%'
                                AND date BETWEEN '" & dtp_From.Value.Date & "'
                                    AND '" & dtp_To.Value.Date & "'
                            ORDER BY datecreated ASC"
            Else
                strQuery = "SELECT DISTINCT controlno as 'Control No.',
                                   datecreated as 'Date Generated',
                                   bank as 'Bank',
                                   date as 'Date',
                                   checkseries as 'Check No.',
                                   payee as 'Payee',
	                               particulars as 'Particulars',
                            REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','') as 'Amount in Figure',
                                   code as 'Code',
                                   description as 'Description',
                                   debit as 'Debit',
	                               credit as 'Credit',                                         
                                   status as 'Status',
                                   remarks as 'Remarks'
                            FROM vw_CVPrint
                            WHERE date BETWEEN '" & dtp_From.Value.Date & "'
                                    AND '" & dtp_To.Value.Date & "'
                            ORDER BY datecreated ASC"
            End If

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_CVList.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub viewcheck()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "SELECT DISTINCT controlno as 'Control No.',
                                   datecreated as 'Date Generated',
                                   bank as 'Bank',
                                   date as 'Date',
                                   checkseries as 'Check No.',
                                   payee as 'Payee',
	                               particulars as 'Particulars',
                            REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','') as 'Amount in Figure',
                                   code as 'Code',
                                   description as 'Description',
                                   debit as 'Debit',
	                               credit as 'Credit',
                                   status as 'Status',
                                   remarks as 'Remarks'
                            FROM vw_CVPrint
                            WHERE controlno LIKE '%" & txt_Search.Text & "%'
                            ORDER BY datecreated ASC"

                strQuery = "SELECT DISTINCT controlno as 'Control No.',
                                   datecreated as 'Date Generated',
                                   bank as 'Bank',
                                   date as 'Date',
                                   checkseries as 'Check No.',
                                   payee as 'Payee',
	                               particulars as 'Particulars',
                            REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','') as 'Amount in Figure',
                                   code as 'Code',
                                   description as 'Description',
                                   debit as 'Debit',
	                               credit as 'Credit',                                         
                                   status as 'Status',
                                   remarks as 'Remarks'
                            FROM vw_CVPrint
                            WHERE controlno LIKE '%" & txt_Search.Text & "%'
                            ORDER BY datecreated ASC"
            Else
                strQuery = "SELECT DISTINCT controlno as 'Control No.',
                                   datecreated as 'Date Generated',
                                   bank as 'Bank',
                                   date as 'Date',
                                   checkseries as 'Check No.',
                                   payee as 'Payee',
	                               particulars as 'Particulars',
                            REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','') as 'Amount in Figure',
                                   code as 'Code',
                                   description as 'Description',
                                   debit as 'Debit',
	                               credit as 'Credit',                                         
                                   status as 'Status',
                                   remarks as 'Remarks'
                            FROM vw_CVPrint
                            ORDER BY datecreated ASC"
            End If

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_CVList.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        viewcheck()
    End Sub

    Private Sub dgv_CVList_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_CVList.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_CVList.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_CVList.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_CVList.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_From_ValueChanged(sender As Object, e As EventArgs) Handles dtp_From.ValueChanged
        viewdate()
    End Sub

    Private Sub dtp_To_ValueChanged(sender As Object, e As EventArgs) Handles dtp_To.ValueChanged
        viewdate()
    End Sub

    Private Sub CVList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Private Sub lbl_Export_Click(sender As Object, e As EventArgs) Handles lbl_Export.Click
        export()
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

            'With xlWorkSheet
            '    .Range("A1", misValue).EntireRow.Font.Bold = True
            '    .Range("A1").Value = "brancode"
            '    .Range("B1").Value = "branchanalysisId"
            '    .Range("C1").Value = "occurrence"
            '    .Range("D1").Value = "eventcode"
            '    .Range("D:D").NumberFormat = "@"
            '    .Range("E1").Value = "create_by"
            '    .Range("F1").Value = "targetvalue"
            '    .Range("G1").Value = "actualvalue"
            '    .Range("H1").Value = "remarks"
            'End With
            For i As Integer = 1 To dgv_CVList.Columns.Count
                xlWorkSheet.Cells(1, i) = dgv_CVList.Columns(i - 1).HeaderText
            Next
            For i As Integer = 0 To dgv_CVList.Rows.Count - 2
                For j As Integer = 0 To dgv_CVList.Columns.Count - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = (dgv_CVList(j, i).Value & "").ToString
                Next
            Next

            Dim SaveFileDialog As New SaveFileDialog
            SaveFileDialog.Filter = "Excel File |*.xlsx"
            SaveFileDialog.Title = "Export Check Voucher List"
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
        Finally
            'btn_ToExcel.Text = "Export to Excel"
            'btn_ToExcel.Enabled = True
            'Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class