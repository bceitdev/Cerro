Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Public Class UOM
    Dim uomid As Integer
    Private Sub UOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewservice()
    End Sub
    Sub viewservice()
        Try
            strQuery = "SELECT id, 
                               code as 'Code',
                               description as 'Description'
                        FROM tbl_uom"

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

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        Try
            Dim mbox As String
            mbox = MetroMessageBox.Show(BCEParent, "Are you sure?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mbox = vbYes Then
                strQuery = "DELETE FROM tbl_uom
                            WHERE id = '" & uomid & "'"
                Dim cmd As New SqlCommand(strQuery)
                Dim dt As DataTable = GetData(cmd)

                MetroMessageBox.Show(BCEParent, "UOM has been successfully remove", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewservice()
                txt_service.Text = Nothing
                txt_divisor.Text = Nothing
                btn_Remove.Enabled = False
                btn_Submit.Enabled = True
                btn_Submit.Text = "Submit"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_loading_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_loading.CellDoubleClick
        Try
            Dim i As Integer = e.RowIndex

            uomid = dgv_loading.Item(0, i).Value
            txt_service.Text = dgv_loading.Item(1, i).Value
            txt_divisor.Text = dgv_loading.Item(2, i).Value

            btn_Remove.Enabled = True
            btn_Submit.Text = "New"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            If btn_Submit.Text = "New" Then
                uomid = Nothing
                txt_service.Text = Nothing
                txt_divisor.Text = Nothing
                btn_Submit.Text = "Submit"
                btn_Submit.Enabled = True
                btn_Remove.Enabled = False
                viewservice()
            ElseIf btn_Submit.Text = "Submit" Then
                If uomid <> Nothing Then
                    If txt_service.Text = Nothing Then
                        MetroMessageBox.Show(BCEParent, "Must have UOM Code", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf txt_divisor.Text = Nothing Then
                        MetroMessageBox.Show(BCEParent, "Must have UOM Description", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        strQuery = "UPDATE tbl_uom SET code = '" & txt_service.Text & "',
                                                       description = '" & txt_divisor.Text & "'
                                    WHERE id = '" & uomid & "'"
                        Dim cmd As New SqlCommand(strQuery)
                        Dim dt As DataTable = GetData(cmd)

                        MetroMessageBox.Show(BCEParent, "UOM has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If txt_service.Text = Nothing Then
                        MetroMessageBox.Show(BCEParent, "Must have UOM Code", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf txt_divisor.Text = Nothing Then
                        MetroMessageBox.Show(BCEParent, "Must have UOM Description", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        strQuery = "INSERT INTO tbl_uom (code,
                                                         description) 
                                                 VALUES 
                                                        ('" & txt_service.Text & "',
                                                         '" & txt_divisor.Text & "')"
                        Dim cmd As New SqlCommand(strQuery)
                        Dim dt As DataTable = GetData(cmd)

                        MetroMessageBox.Show(BCEParent, "UOM has been successfully register", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                uomid = Nothing
                txt_service.Text = Nothing
                txt_divisor.Text = Nothing
                viewservice()
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