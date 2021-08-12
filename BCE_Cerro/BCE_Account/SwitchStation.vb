Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class SwitchStation
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            stationcode = cbo_BranchCode.SelectedItem
            For Each ChildForm As Form In BCEParent.MdiChildren
                ChildForm.Close()
            Next
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_BranchCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_BranchCode.SelectedIndexChanged

    End Sub

    Private Sub cbo_BranchCode_DropDown(sender As Object, e As EventArgs) Handles cbo_BranchCode.DropDown

    End Sub

    Sub BranchCode(ByVal u As String)

        Try

            strQuery = "SELECT branchcode FROM vw_branch 
                        WHERE employeeid =  @employeeid"

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("employeeid", emplid)
            Dim dt As DataTable = GetData(cmd)

            If (u = "BranchCodeItem") Then
                cbo_BranchCode.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "BranchCodeItem") Then
                    cbo_BranchCode.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SwitchStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BranchCode("BranchCodeItem")
        cbo_BranchCode.SelectedIndex = 0
    End Sub

    Private Sub SwitchStation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
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