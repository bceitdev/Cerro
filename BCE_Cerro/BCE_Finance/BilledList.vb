Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Imports System.ComponentModel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports System.IO
Public Class BilledList
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
            For i As Integer = 1 To dgv_TrackList.Columns.Count
                xlWorkSheet.Cells(1, i) = dgv_TrackList.Columns(i - 1).HeaderText
            Next
            For i As Integer = 0 To dgv_TrackList.Rows.Count - 2
                For j As Integer = 0 To dgv_TrackList.Columns.Count - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = (dgv_TrackList(j, i).Value & "").ToString
                Next
            Next

            Dim SaveFileDialog As New SaveFileDialog
            SaveFileDialog.Filter = "Excel File |*.xlsx"
            SaveFileDialog.Title = "Export Tracking List"
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
    Private Sub dgv_genbill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_TrackList.CellContentClick

    End Sub

    Private Sub dgv_genbill_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_TrackList.CellPainting
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
    Sub autoterms()
        Try
            Dim pastdue As Integer
            Dim ctrlno As String
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT controlno, duedate FROM tbl_billing 
                        WHERE dueforcoll > 0"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            For Each row As DataRow In dt.Rows
                If Not IsDBNull(row.Item(1)) Then
                    ctrlno = row.Item(0)
                    If row.Item(1) > Date.Today Then
                        pastdue = 0
                    Else
                        pastdue = DateDiff(DateInterval.Day, row.Item(1), Date.Today)
                    End If

                    strQuery = "UPDATE tbl_billing SET pastdue = '" & pastdue & "'
                                WHERE dueforcoll > 0
                                    AND controlno = '" & ctrlno & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BillingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoterms()
        list()
    End Sub
    Sub list()
        Try
            If txt_TrackList.Text <> Nothing Then
                strQuery = "EXEC vw_billtracklist_sh @controlno = '%" & txt_TrackList.Text & "%',
                                                     @outboundid = '%" & txt_TrackList.Text & "%',
                                                     @hwb_no_carb = '%" & txt_TrackList.Text & "%'"
            Else
                strQuery = "EXEC vw_billtracklist"
            End If

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_TrackList.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BillingList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_TrackList_Click(sender As Object, e As EventArgs) Handles txt_TrackList.Click

    End Sub

    Private Sub txt_TrackList_TextChanged(sender As Object, e As EventArgs) Handles txt_TrackList.TextChanged
        list()
    End Sub

    Private Sub lbl_Export_Click(sender As Object, e As EventArgs) Handles lbl_Export.Click
        export()
    End Sub
End Class