Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Public Class TrackingReprint
    Private Sub HWBReprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Gen_Click(sender As Object, e As EventArgs) Handles btn_Gen.Click
        Try
            rptdocreprint.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TrackingReprint_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class