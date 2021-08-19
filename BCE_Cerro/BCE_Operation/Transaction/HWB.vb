Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine
Public Class HWB
    Dim rptdoc As ReportDocument

    Private Sub HWB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub HWBNo()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT ISNULL(MAX(count), 0) + 1
                        FROM tbl_outbound"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            Count = dt.Rows(dt.Rows.Count - 1).Item(0)

            strQuery = "SELECT branchcode FROM vw_branch
                        WHERE branchcode LIKE '" & stationcode & "'"

            HWBCtrlNo = stationcode + Count.ToString("0000000000")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub obHWBSheet()
        Try
            Dim txt_CtrlNo, txt_ShipDate As TextObject
            dssearch = New dsreport
            dasearch.Fill(dssearch, "dtHWB")
            rptdoc = New cr_HWB
            rptdoc.SetDataSource(dssearch)
            txt_CtrlNo = rptdoc.ReportDefinition.ReportObjects("txt_CtrlNo")
            txt_CtrlNo.Text = HWBCtrlNo
            'txt_ShipDate = rptdoc.ReportDefinition.ReportObjects("txt_ShipDate")
            'txt_ShipDate.Text = dtpShipDate.Date

            crv_HWB.ReportSource = rptdoc
            crv_HWB.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Print()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If D2DWalkIn = "D2D" Then
                If stat = "OPEN" Then
                    strQuery = "EXEC ins_outbound @count = @count,
                                          @hwb_no = @hwb_no,
                                          @receivedid = @receivedid,
                                          @status = @status,
                                          @coststatus = @coststatus,
                                          @manifeststatus = @manifeststatus,
                                          @employeeid = @employeeid,
                                          @datecreated = @datecreated"

                    cmd.CommandText = strQuery
                    cmd.Parameters.AddWithValue("count", Count)
                    cmd.Parameters.AddWithValue("hwb_no", HWBCtrlNo)
                    cmd.Parameters.AddWithValue("receivedid", RecId)
                    cmd.Parameters.AddWithValue("status", "OPEN")
                    cmd.Parameters.AddWithValue("coststatus", "OPEN")
                    cmd.Parameters.AddWithValue("manifeststatus", "OPEN")
                    cmd.Parameters.AddWithValue("employeeid", emplid)
                    cmd.Parameters.AddWithValue("datecreated", Date.Now)
                    dt = GetData(cmd)

                    strQuery = "UPDATE tbl_dummydimension SET hwb_no = '" & HWBCtrlNo & "',
                                                              status = 'CLOSED'
                                WHERE received_id = '" & RecId & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE tbl_receive SET status = 'CLOSED'
                                WHERE id = '" & RecId & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If
            ElseIf D2DWalkIn = "WalkIn" Then
                strQuery = "EXEC ins_outbound_so @count = @count,
                                                 @hwb_no = @hwb_no,
                                                 @serviceorder_id = @serviceorder_id,
                                                 @status = @status,
                                                 @coststatus = @coststatus,
                                                 @manifeststatus = @manifeststatus,
                                                 @employeeid = @employeeid,
                                                 @datecreated = @datecreated"

                cmd.CommandText = strQuery
                cmd.Parameters.AddWithValue("count", Count)
                cmd.Parameters.AddWithValue("hwb_no", HWBCtrlNo)
                cmd.Parameters.AddWithValue("serviceorder_id", SerId)
                cmd.Parameters.AddWithValue("status", "OPEN")
                cmd.Parameters.AddWithValue("coststatus", "OPEN")
                cmd.Parameters.AddWithValue("manifeststatus", "OPEN")
                cmd.Parameters.AddWithValue("employeeid", emplid)
                cmd.Parameters.AddWithValue("datecreated", Date.Now)
                dt = GetData(cmd)

                strQuery = "UPDATE tbl_dummydimension SET hwb_no = '" & HWBCtrlNo & "',
                                                          status = 'CLOSED'
                            WHERE serviceorder_id = '" & SerId & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                strQuery = "UPDATE tbl_serviceorder SET status = 'CLOSED'
                            WHERE id = '" & SerId & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)
            End If
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub HWB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Gen_Click(sender As Object, e As EventArgs) Handles btn_Gen.Click
        HWBNo()
        obHWBSheet()
        rptdoc.PrintToPrinter(1, False, 0, 0)
        Print()
    End Sub

End Class