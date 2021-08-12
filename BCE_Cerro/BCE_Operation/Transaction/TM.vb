Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class TM
    Dim rptdoc As ReportDocument
    Private Sub TM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Dim obb0 As New TransferManifest
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
            txt_Station.Text = obb0.cbo_Station.Text
            txt_ServicePartner = rptdoc.ReportDefinition.ReportObjects("txt_ServicePartner")
            txt_ServicePartner.Text = obb0.txt_SP.Text
            txt_Contact = rptdoc.ReportDefinition.ReportObjects("txt_Contact")
            txt_Contact.Text = obb0.txt_phone.Text
            txt_Dest = rptdoc.ReportDefinition.ReportObjects("txt_Dest")
            txt_Dest.Text = TMDest

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Try
            TMNo()
            GetItem()
            rptdoc.PrintToPrinter(1, False, 0, 0)
            Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Print()
        Try
            Dim obb As New TransferManifest
            For Each row As DataGridViewRow In dgv_TM.Rows
                strQuery = "EXEC ins_transfermanifest @tm_no = @tm_no,
                                                      @outboundid = @outboundid,
                                                      @spname = @spname,
                                                      @phone = @phone,
                                                      @branchid = @branchid,
                                                      @status = @status,
                                                      @employeeid = @employeeid,
                                                      @datecreated = @datecreated"

                Dim cmd As New SqlCommand(strQuery)
                cmd.Parameters.AddWithValue("tm_no", TMCtrlNo)
                cmd.Parameters.AddWithValue("outboundid", row.Cells(1).Value)
                cmd.Parameters.AddWithValue("spname", obb.txt_SP.Text)
                cmd.Parameters.AddWithValue("phone", obb.txt_phone.Text)
                cmd.Parameters.AddWithValue("branchid", StationId)
                cmd.Parameters.AddWithValue("status", "OPEN")
                cmd.Parameters.AddWithValue("employeeid", emplid)
                cmd.Parameters.AddWithValue("datecreated", Date.Now)
                Dim dt As DataTable = GetData(cmd)
            Next

            For Each row As DataGridViewRow In dgv_TM.Rows
                strQuery = "UPDATE tbl_outbound SET manifeststatus = 'CLOSED'
                            WHERE hwb_no = '" & row.Cells(1).Value & "'"
                Dim cmd As New SqlCommand(strQuery)
                Dim dt As DataTable = GetData(cmd)
            Next
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class