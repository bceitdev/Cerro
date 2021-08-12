Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class Status
    Private Sub cbo_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_status.SelectedIndexChanged

    End Sub

    Private Sub cbo_status_DropDown(sender As Object, e As EventArgs) Handles cbo_status.DropDown
        DocType("Item")
    End Sub

    Sub DocType(ByVal u As String)

        Try
            strQuery = "SELECT status FROM tbl_cargostatus"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "Item") Then
                Me.cbo_status.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "Item") Then
                    cbo_status.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            strQuery = "UPDATE tbl_outbound SET status = '" & cbo_status.SelectedItem & "'
                        WHERE hwb_no LIKE '" & lbl_hwbno.Text & "'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            MetroMessageBox.Show(BCEParent, "Status has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class