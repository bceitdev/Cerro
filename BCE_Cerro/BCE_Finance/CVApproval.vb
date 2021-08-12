Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class CVApproval
    Dim icontrolno As Integer
    Private Sub CVApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewcheck()
    End Sub

    Private Sub CVApproval_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Sub viewcheck()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "SELECT DISTINCT controlno as 'Control No.',
                                   bank as 'Bank',
                                   checkseries as 'Check No.',
                                   date as 'Date',
                                   payee as 'Payee',
                            REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','') as 'Amount in Figure',
                                   particulars as 'Particulars'
                            FROM vw_CVPrint
                            WHERE controlno LIKE '%" & txt_Search.Text & "%'
                                AND status LIKE 'Save'"
            Else
                strQuery = "SELECT DISTINCT controlno as 'Control No.',
                                   bank as 'Bank',
                                   checkseries as 'Check No.',
                                   date as 'Date',
                                   payee as 'Payee',
                            REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','') as 'Amount in Figure',
                                   particulars as 'Particulars'
                            FROM vw_CVPrint
                            WHERE status LIKE 'Save'"
            End If

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_CVList.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_CVList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CVList.CellContentClick

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

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        viewcheck()
    End Sub

    Private Sub dgv_CVList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CVList.CellClick
        Try
            Dim i As Integer = e.RowIndex

            If e.ColumnIndex = 0 Then
                strQuery = "UPDATE tbl_header SET status = 'Posted'
                            WHERE controlno LIKE '" & dgv_CVList.Item(3, i).Value & "'"

                Dim cmd As New SqlCommand(strQuery)
                Dim dt As DataTable = GetData(cmd)
            ElseIf e.ColumnIndex = 1 Then
                strQuery = "UPDATE tbl_header SET status = 'Denied'
                            WHERE controlno LIKE '" & dgv_CVList.Item(3, i).Value & "'"

                Dim cmd As New SqlCommand(strQuery)
                Dim dt As DataTable = GetData(cmd)
            ElseIf e.ColumnIndex = 2 Then
                reasonreq = "disb"
                icontrolno = e.RowIndex
                Dim obb As New Reason
                obb.disbcontrolno = dgv_CVList.Item(3, icontrolno).Value
                obb.ShowDialog()
            End If
            viewcheck()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class