Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class POD
    Dim poddate As Date
    Private Sub POD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            If cbo_Type.SelectedItem = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Document Type", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_DocRef.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Document Reference No.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "UPDATE tbl_outbound SET status = 'CLOSED',
                                                pod_date = '" & poddate & "',
                                                doctype = '" & cbo_Type.SelectedItem & "',
                                                docref = '" & txt_DocRef.Text & "'
                            WHERE hwb_no LIKE '" & lbl_hwbno.Text & "'"
                Dim cmd As New SqlCommand(strQuery)
                Dim dt As DataTable = GetData(cmd)

                MetroMessageBox.Show(BCEParent, "POD has been successfully received", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Type.SelectedIndexChanged

    End Sub

    Sub DocType(ByVal u As String)

        Try
            strQuery = "SELECT doctype FROM tbl_doctype"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "Item") Then
                Me.cbo_Type.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "Item") Then
                    cbo_Type.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbo_Type_DropDown(sender As Object, e As EventArgs) Handles cbo_Type.DropDown
        DocType("Item")
    End Sub

    Private Sub lbl_force_Click(sender As Object, e As EventArgs) Handles lbl_force.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim stat As String

            'strQuery = "UPDATE tbl_outbound 
            '            SET status = CASE
            '                WHEN status LIKE 'IN TRANSIT' THEN 'CLEARED'
            '                            ELSE '" & MetroMessageBox.Show(BCEParent, "Closing and/or clearing POD while the cargo is undispatch is not allowed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error) & "'
            '                         END
            '            WHERE hwb_no LIKE '" & lbl_hwbno.Text & "'"
            'cmd.CommandText = strQuery
            'dt = GetData(cmd)

            strQuery = "SELECT status FROM tbl_outbound
                        WHERE hwb_no LIKE '" & lbl_hwbno.Text & "'"
            cmd.CommandText = strQuery
            dt = GetData(cmd)

            stat = dt.Rows(dt.Rows.Count - 1).Item(0)

            If stat = "IN TRANSIT" Then
                strQuery = "UPDATE tbl_outbound SET status = 'CLEARED'
                        WHERE hwb_no LIKE '" & lbl_hwbno.Text & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)
            ElseIf stat = "OPEN" Then
                MetroMessageBox.Show(BCEParent, "Closing and/or clearing POD while the cargo is undispatch is not allowed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_poddate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_poddate.ValueChanged
        Try
            poddate = dtp_poddate.Value.Date
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class