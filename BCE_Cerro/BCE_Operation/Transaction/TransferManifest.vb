Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class TransferManifest
    Dim Count As Integer
    Dim dest_cat As String
        Dim rptdoc As ReportDocument

    Private Sub TransferManifest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub TMNo()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT ISNULL(MAX(tm_no), 0) + 1
                        FROM tbl_tm"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            Count = dt.Rows(dt.Rows.Count - 1).Item(0)
            TMCtrlNo = Count.ToString("0000")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub GetItem()
        Try
            Dim dt As New DataTable
            With dt
                .Columns.Add("hwb_no")
                .Columns.Add("company_name")
                .Columns.Add("consignee")
                .Columns.Add("phone")
                .Columns.Add("freightmode")
                .Columns.Add("paymode")
                .Columns.Add("commodity")
                .Columns.Add("actualqty")
                .Columns.Add("actualwt")
            End With
            For Each dgr As DataGridViewRow In dgv_TM.Rows
                dt.Rows.Add(dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value, dgr.Cells(6).Value, dgr.Cells(7).Value, dgr.Cells(8).Value, dgr.Cells(9).Value)
            Next

            Dim txt_CtrlNo, txt_Station, txt_ServicePartner, txt_Contact, txt_Dest As TextObject
            rptdoc = New cr_TM
            rptdoc.SetDataSource(dt)
            txt_CtrlNo = rptdoc.ReportDefinition.ReportObjects("txt_CtrlNo")
            txt_CtrlNo.Text = TMCtrlNo
            txt_Station = rptdoc.ReportDefinition.ReportObjects("txt_Station")
            txt_Station.Text = cbo_Station.Text
            txt_ServicePartner = rptdoc.ReportDefinition.ReportObjects("txt_ServicePartner")
            txt_ServicePartner.Text = txt_SP.Text
            txt_Contact = rptdoc.ReportDefinition.ReportObjects("txt_Contact")
            txt_Contact.Text = txt_phone.Text
            txt_Dest = rptdoc.ReportDefinition.ReportObjects("txt_Dest")
            txt_Dest.Text = TMDest

            Dim obb As New TM

            TM.crv_TM.ReportSource = rptdoc
            TM.crv_TM.Refresh()
            TM.dgv_TM.DataSource = TMdt
            TM.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Contact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_phone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub
    Sub Station(ByVal u As String)
        Try
            strQuery = "SELECT DISTINCT branchname FROM tbl_branch"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)
            If (u = "Item") Then
                cbo_Station.Items.Clear()
            End If
            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0
            While (ant > a)
                If (u = "Item") Then
                    cbo_Station.Items.Add(dt.Rows(a).Item(0))
                End If
                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Destination(ByVal u As String)
        Try
            strQuery = "SELECT DISTINCT(destination) 
                        FROM vw_manifest
                        WHERE manifeststatus LIKE 'OPEN'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)
            If (u = "Item") Then
                cbo_Dest.Items.Clear()
            End If
            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0
            While (ant > a)
                If (u = "Item") Then
                    cbo_Dest.Items.Add(dt.Rows(a).Item(0))
                End If
                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Dest_DropDown(sender As Object, e As EventArgs) Handles cbo_Dest.DropDown
        Destination("Item")
    End Sub

    Private Sub Cbo_Dest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Dest.SelectedIndexChanged
        Try
            strQuery = "EXEC manifest @destination = '" & cbo_Dest.SelectedItem & "'"

            Dim cmd As New SqlCommand(strQuery)
            TMdt = GetData(cmd)

            dgv_TM.DataSource = TMdt

            TMDest = cbo_Dest.SelectedItem
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_TM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_TM.CellContentClick
        Try
            Dim i As Integer

            If e.ColumnIndex = 0 Then
                i = dgv_TM.CurrentCell.RowIndex
                dgv_TM.Rows.RemoveAt(i)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_TM_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_TM.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_TM.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_TM.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_TM.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TransferManifest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cbo_Station_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Station.SelectedIndexChanged
        Try
            strQuery = "SELECT branchid FROM tbl_branch
                        WHERE branchname LIKE '" & cbo_Station.SelectedItem & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                StationId = dt.Rows(dt.Rows.Count - 1).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Station_DropDown(sender As Object, e As EventArgs) Handles cbo_Station.DropDown
        Station("Item")
    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Gen_Click(sender As Object, e As EventArgs) Handles btn_Gen.Click
        Try
            If txt_SP.Text = Nothing Then
                MetroMessageBox.Show(Me, "Must have Service Partner Name", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_phone.Text = Nothing Then
                MetroMessageBox.Show(Me, "Must have Phone No.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf cbo_Station.SelectedItem = Nothing Then
                MetroMessageBox.Show(Me, "Must have Station", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                TMNo()
                GetItem()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class