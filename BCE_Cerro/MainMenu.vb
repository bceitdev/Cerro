Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class MainMenu
    Private Sub mt_CS_Click(sender As Object, e As EventArgs) Handles mt_CS.Click
        Try
            MainMenuId = 2
            StartupForm.Main()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mt_Ops_Click(sender As Object, e As EventArgs) Handles mt_Ops.Click
        Try
            MainMenuId = 3
            StartupForm.Main()
            BCEParent.tc_PISM.TabPages.RemoveByKey("tp_CS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class