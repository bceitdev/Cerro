Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class Outbound

    Dim rptdoc As ReportDocument

    Private Sub HWBAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewoutbound()
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

    Sub GetItemReprint()
        Try
            conn("SELECT CONCAT(OriginArea, OriginCode) as 'Origin',
                         CONCAT(DestArea, DestCode) as 'Destination',
                                 loadingmode,
                                 consignee,
                                 no_street_etc as 'address',
                                 account_number,
                                 company_name,
                                 actualqty,
                                 code,
                                 commodity,
                                 actualwt
                                 paymode,
                                 servicemode,
                                 freightmode,
                                 phone
                  FROM vw_ops_outbound
                  WHERE id = '" & dgv_Received.Item(1, rowindex).Value & "'
                    AND pur_no = '" & dgv_Received.Item(2, rowindex).Value & "'", "vw_ops_outbound")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub GetItem()
        Try
            'If IsDBNull(dgv_Received.Item(1, rowindex).Value) Then
            '    RecId = dgv_Received.Item(2, rowindex).Value
            '    pur_no = dgv_Received.Item(4, rowindex).Value

            '    strQuery = "SELECT status
            '                        FROM tbl_dummydimension
            '                        WHERE received_id = '" & RecId & "'
            '                            AND pur_no = '" & pur_no & "'"

            'ElseIf IsDBNull(dgv_Received.Item(2, rowindex).Value) Then
            '    SerId = dgv_Received.Item(1, rowindex).Value
            '    hwb_no = dgv_Received.Item(3, rowindex).Value

            '    strQuery = "SELECT status
            '                        FROM tbl_dummydimension
            '                        WHERE serviceorderid = '" & SerId & "'
            '                            AND hwb_no_carb = '" & hwb_no & "'"
            'End If
            If IsDBNull(dgv_Received.Item(1, rowindex).Value) Then
                conn("SELECT accepted_date,
                             hwb_no_carb,
                             pur_no,
                      CONCAT(origin, + char(10) + origin_code) as 'Origin',
                      CONCAT(destination, + char(10) + destination_code) as 'Destination',
                              loadingmode,
                              consignee,
                              no_street_etc as 'address',
                              account_number,
                              company_name,
                              actualqty,
                              code,
                              commodity,
                              length,
                              width,
                              height,
                              actualwt,
                              volwt,
                              charwt,
                              decval,
                              paymode,
                              servicemode,
                              freightmode,
                              phone
                       FROM tbl_dummydimension
                       WHERE received_id = '" & RecId & "'
                        AND pur_no = '" & pur_no & "'", "tbl_dummydimension")
            ElseIf IsDBNull(dgv_Received.Item(2, rowindex).Value) Then
                conn("SELECT accepted_date,
                             hwb_no_carb,
                             pur_no,
                      CONCAT(origin, + char(10) + origin_code) as 'Origin',
                      CONCAT(destination, + char(10) + destination_code) as 'Destination',
                              loadingmode,
                              consignee,
                              no_street_etc as 'address',
                              account_number,
                              company_name,
                              actualqty,
                              code,
                              commodity,
                              length,
                              width,
                              height,
                              actualwt,
                              volwt,
                              charwt,
                              decval,
                              paymode,
                              servicemode,
                              freightmode,
                              phone
                       FROM tbl_dummydimension
                       WHERE serviceorder_id = '" & SerId & "'
                        AND hwb_no_carb = '" & hwb_no & "'", "tbl_dummydimension")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ForReprint()
        Try
            strQuery = "SELECT hwb_no, shipdate 
                        FROM tbl_dummydimension
                        WHERE received_id = '" & dgv_Received.Item(1, rowindex).Value & "'
                            AND pur_no = '" & dgv_Received.Item(2, rowindex).Value & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                HWBReprint = dt.Rows(dt.Rows.Count - 1).Item(0)
                shipdateReprint = dt.Rows(dt.Rows.Count - 1).Item(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub HWBSheetReprint()
        Try
            Dim txt_CtrlNo, txt_ShipDate As TextObject
            dssearch = New dsreport
            dasearch.Fill(dssearch, "dtHWB")
            rptdoc = New cr_HWB
            rptdoc.SetDataSource(dssearch)
            txt_CtrlNo = rptdoc.ReportDefinition.ReportObjects("txt_CtrlNo")
            txt_CtrlNo.Text = HWBReprint
            txt_ShipDate = rptdoc.ReportDefinition.ReportObjects("txt_ShipDate")
            txt_ShipDate.Text = shipdateReprint

            HWB.crv_HWB.ReportSource = rptdoc
            HWB.crv_HWB.Refresh()

            HWB.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub HWBSheet()
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

            HWB.crv_HWB.ReportSource = rptdoc
            HWB.crv_HWB.Refresh()

            HWB.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub viewoutbound()
        Try
            If txt_pur.Text <> Nothing Then
                strQuery = "SELECT DISTINCT(serviceorder_id),
		                            received_id,
		                            hwb_no_carb as 'HWB No.',
		                            pur_no as 'PUR No.',
		                            company_name as 'Shipper',
		                            consignee as 'Consignee',	
                            CONCAT(origin, + CHAR(10) +
                                    origin_code) as 'Origin',
                            CONCAT(destination, + CHAR(10) +
                                    destination_code) as 'Destination',
		                            no_street_etc as 'Address',
		                            commodity as 'Commodity',
		                            loadingmode as 'Loading Mode',
		                            servicemode as 'Service Mode',
		                            freightmode as 'Freight Mode'
                            FROM tbl_dummydimension
                            WHERE hwb_no_carb LIKE '%" & txt_pur.Text & "%'
                                OR pur_no LIKE '%" & txt_pur.Text & "%'
                                AND status LIKE 'OPEN'"
            Else
                strQuery = "EXEC vw_outbound"
            End If

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("pur_no", txt_pur.Text)
            Dim dt As DataTable = GetData(cmd)

            dgv_Received.DataSource = dt
            dgv_Received.Columns(1).Visible = False
            dgv_Received.Columns(2).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub HWBAuto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub txt_pur_TextChanged(sender As Object, e As EventArgs) Handles txt_pur.TextChanged
        viewoutbound()
    End Sub


    Private Sub dgv_Received_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Received.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Received.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Received.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Received.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Received_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Received.CellClick
        Try
            If e.ColumnIndex = 0 Then
                rowindex = e.RowIndex
                If e.ColumnIndex = 0 Then
                    If IsDBNull(dgv_Received.Item(1, rowindex).Value) Then
                        D2DWalkIn = "D2D"
                        RecId = dgv_Received.Item(2, rowindex).Value
                        pur_no = dgv_Received.Item(4, rowindex).Value

                        strQuery = "SELECT status
                                    FROM tbl_dummydimension
                                    WHERE received_id = '" & RecId & "'
                                        AND pur_no = '" & pur_no & "'"

                    ElseIf IsDBNull(dgv_Received.Item(2, rowindex).Value) Then
                        D2DWalkIn = "WalkIn"
                        SerId = dgv_Received.Item(1, rowindex).Value
                        hwb_no = dgv_Received.Item(3, rowindex).Value

                        strQuery = "SELECT status
                                    FROM tbl_dummydimension
                                    WHERE serviceorder_id = '" & SerId & "'
                                        AND hwb_no_carb = '" & hwb_no & "'"
                    End If

                    Dim cmd As New SqlCommand(strQuery)
                    Dim dt As DataTable = GetData(cmd)

                    If dt.Rows.Count > 0 Then
                        stat = dt.Rows(dt.Rows.Count - 1).Item(0)

                        If stat = "OPEN" Then
                            HWBNo()
                            GetItem()
                            HWBSheet()
                            'ElseIf stat = "CLOSED" Then
                            '    ForReprint()
                            '    GetItem()
                            '    HWBSheetReprint()
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Received_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Received.CellContentClick

    End Sub
End Class