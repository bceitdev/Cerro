Imports System.Threading
Imports System.Data.OleDb
Imports System.Globalization
Imports System.Data.SqlClient
Imports MetroFramework
Public Class FileUpload
    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        Try
            Dim OpenFileDialog As New OpenFileDialog

            OpenFileDialog.Filter = "Excel Files |*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*.xml;*.xlam;*.xla;*.xlw;*.xlr;*.csv;"
            OpenFileDialog.Title = "File Upload"
            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                Dim fp As String = OpenFileDialog.FileName
                txt_FileName.Text = fp
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If txt_FileName.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must need a file to upload", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "BULK INSERT bce_system_hwb.dbo.tbl_jfcdataupload
                            FROM '" & txt_FileName.Text & "'
                            WITH
                            (
	                            FIELDTERMINATOR=',',
	                            ROWTERMINATOR='\n',
	                            FIRSTROW=2
                            )"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "SELECT * FROM tbl_jfcdataupload"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                dgv_FileUpload.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_FileUpload_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_FileUpload.CellContentClick

    End Sub

    Private Sub dgv_FileUpload_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_FileUpload.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_FileUpload.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_FileUpload.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_FileUpload.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FileUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class