Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Public Class Pay
    Dim payid As Integer
    Private Sub Pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewload()
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            If btn_Submit.Text = "New" Then
                payid = Nothing
                txt_loading.Text = Nothing
                btn_Submit.Text = "Submit"
                btn_Submit.Enabled = True
                btn_Remove.Enabled = False
                viewload()
            ElseIf btn_Submit.Text = "Submit" Then
                If payid <> Nothing Then
                    If txt_loading.Text = Nothing Then
                        MetroMessageBox.Show(BCEParent, "Must have Pay Description", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        strQuery = "UPDATE tbl_paymode SET paymode = '" & txt_loading.Text & "'
                                    WHERE id = '" & payid & "'"
                        Dim cmd As New SqlCommand(strQuery)
                        Dim dt As DataTable = GetData(cmd)

                        MetroMessageBox.Show(BCEParent, "Pay Mode has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If txt_loading.Text = Nothing Then
                        MetroMessageBox.Show(BCEParent, "Must have Pay Description", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        strQuery = "INSERT INTO tbl_paymode (paymode) 
                                             VALUES 
                                                    ('" & txt_loading.Text & "')"
                        Dim cmd As New SqlCommand(strQuery)
                        Dim dt As DataTable = GetData(cmd)

                        MetroMessageBox.Show(BCEParent, "Pay Mode has been successfully register", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                payid = Nothing
                txt_loading.Text = Nothing
                viewload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub viewload()
        Try
            strQuery = "SELECT id, paymode as 'Pay Mode' FROM tbl_paymode"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_loading.DataSource = dt
            dgv_loading.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_loading_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_loading.CellContentClick

    End Sub

    Private Sub dgv_loading_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_loading.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_loading.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_loading.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_loading.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_loading_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_loading.CellDoubleClick
        Try
            Dim i As Integer = e.RowIndex

            payid = dgv_loading.Item(0, i).Value
            txt_loading.Text = dgv_loading.Item(1, i).Value

            btn_Remove.Enabled = True
            btn_Submit.Text = "New"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        Try
            Dim mbox As String
            mbox = MetroMessageBox.Show(BCEParent, "Are you sure?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mbox = vbYes Then
                strQuery = "DELETE FROM tbl_paymode
                        WHERE id = '" & payid & "'"
                Dim cmd As New SqlCommand(strQuery)
                Dim dt As DataTable = GetData(cmd)

                MetroMessageBox.Show(BCEParent, "Pay Mode has been successfully remove", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewload()
                txt_loading.Text = Nothing
                btn_Remove.Enabled = False
                btn_Submit.Enabled = True
                btn_Submit.Text = "Submit"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class