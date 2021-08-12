Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Public Class CollectionView
    Private Sub CollectionView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'collectlistsh()
    End Sub

    Private Sub CollectionView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_collection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_collection.CellContentClick

    End Sub

    Private Sub dgv_collection_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_collection.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_collection.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_collection.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_collection.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Sub oldcollectlistsh()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "SELECT * FROM tbl_oldar
                            WHERE soa LIKE '%" & txt_Search.Text & "%'
                                OR account LIKE '%" & txt_Search.Text & "%'
                                OR customername LIKE '%" & txt_Search.Text & "%'"
            Else
                strQuery = "SELECT * FROM tbl_oldar"
            End If

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_collection.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub collectlistsh()
        Try
            If txt_Search.Text <> Nothing Then
                strQuery = "EXEC vw_collectinfosh @controlno = @controlno,
                                              @acctno = @acctno,
                                              @compname = @compname"
            Else
                strQuery = "EXEC vw_collectinfo"
            End If

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("controlno", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("acctno", "%" + txt_Search.Text + "%")
            cmd.Parameters.AddWithValue("compname", "%" + txt_Search.Text + "%")
            Dim dt As DataTable = GetData(cmd)

            dgv_collection.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        If enabledoldar = True Then
            oldcollectlistsh()
        Else
            collectlistsh()
        End If
    End Sub
End Class