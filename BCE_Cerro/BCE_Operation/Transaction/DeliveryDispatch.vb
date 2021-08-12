Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class DeliveryDispatch
    Dim AssignedTo As String
    Dim driver_id, vehicle_id, employee_id, datecreated As Integer
    Dim tablocked As Boolean = True

    Private Sub Txt_Driver_Click(sender As Object, e As EventArgs) Handles txt_Driver.Click

    End Sub

    Sub vwdeldis()
        Try
            strQuery = "EXEC vw_fordeldispatch @status = 'OPEN'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_DelDis.DataSource = dt

            For i = 1 To 8
                dgv_DelDis.Columns(i).ReadOnly = True
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DeliveryDispatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtc_Dispatch.SelectedIndex = 0
        AssignedToItems("AssignedToItem")
        DriverAutoCom()
        vwdeldis()
    End Sub
    Sub DriverAutoCom()
        Try
            strQuery = "SELECT fullname FROM tbl_employeemaster
                        WHERE fullname LIKE '%" & txt_Driver.Text & "%'
                            AND department LIKE 'OPERATIONS'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            txt_Driver.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_Driver.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_Driver.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row(0))).ToArray())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub AssignedToItems(ByVal u As String)
        Try
            strQuery = "SELECT Fullname FROM tbl_employeemaster
                        WHERE department LIKE 'OPERATIONS'
                        ORDER BY Fullname ASC"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "AssignedToItem") Then
                Me.clb_Driver.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            clb_Driver.Items.Add("Select All")

            While (ant > a)
                If (u = "AssignedToItem") Then
                    clb_Driver.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clb_Driver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_Driver.SelectedIndexChanged
        Try
            AssignedTo = Nothing

            For Each item In clb_Driver.CheckedItems
                If clb_Driver.GetItemCheckState(clb_Driver.Items.IndexOf(item)) Then
                    AssignedTo = "" & item.ToString & "" & "," & AssignedTo
                    AssignedTo = AssignedTo.TrimEnd(",")
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_VehSubmit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim DeliveryDispatchId As String

            If vehicle_id = Nothing Then
                MetroMessageBox.Show(Me, "Must have Vehicle", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "SELECT * FROM tbl_ddeliverydispatch"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                For Each data As DataRow In dt.Rows
                    DeliveryDispatchId = data.Item(0)
                    strQuery = "EXEC ins_ops_deliverydispatch @outboundid = '" & DeliveryDispatchId & "',
                                                              @driverid = '" & driver_id & "',
                                                              @cargoassoc = '" & AssignedTo & "',
                                                              @vehicleid = '" & vehicle_id & "',
                                                              @status = 'OPEN',
                                                              @employeeid = '" & emplid & "',
                                                              @datecreated = '" & Date.Now & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE tbl_outbound SET status = 'IN TRANSIT',
                                                        shipdate = '" & dtpShipDate & "',
                                                        carrierid = '" & CarrierId & "'
                                WHERE hwb_no LIKE '" & DeliveryDispatchId & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE tbl_dummydimension SET shipdate = '" & dtpShipDate & "'
                                WHERE hwb_no LIKE '" & DeliveryDispatchId & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                Next

                MetroMessageBox.Show(BCEParent, "Delivery has been successfully dispatched", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tablocked = False
                mtc_Dispatch.SelectedIndex = 0
                vwdeldis()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles btn_VehBack.Click
        Try
            tablocked = False
            mtc_Dispatch.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mt_Motor_Click(sender As Object, e As EventArgs) Handles mt_Motor.Click
        Try
            strQuery = "SELECT * FROM tbl_vehicle
                        WHERE plateno LIKE 'ABF9889'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                vehicle_id = dt.Rows(dt.Rows.Count - 1).Item(0)
                lbl_PlateNo.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
                lbl_Length.Text = dt.Rows(dt.Rows.Count - 1).Item(3)
                lbl_Width.Text = dt.Rows(dt.Rows.Count - 1).Item(4)
                lbl_Height.Text = dt.Rows(dt.Rows.Count - 1).Item(5)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mt_Van_Click(sender As Object, e As EventArgs) Handles mt_Van.Click
        Try
            strQuery = "SELECT * FROM tbl_vehicle
                        WHERE plateno LIKE 'UMO649'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                vehicle_id = dt.Rows(dt.Rows.Count - 1).Item(0)
                lbl_PlateNo.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
                lbl_Length.Text = dt.Rows(dt.Rows.Count - 1).Item(3)
                lbl_Width.Text = dt.Rows(dt.Rows.Count - 1).Item(4)
                lbl_Height.Text = dt.Rows(dt.Rows.Count - 1).Item(5)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mt_ClosedVan_Click(sender As Object, e As EventArgs) Handles mt_ClosedVan.Click
        Try
            strQuery = "SELECT * FROM tbl_vehicle
                        WHERE plateno LIKE 'NS6456'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                vehicle_id = dt.Rows(dt.Rows.Count - 1).Item(0)
                lbl_PlateNo.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
                lbl_Length.Text = dt.Rows(dt.Rows.Count - 1).Item(3)
                lbl_Width.Text = dt.Rows(dt.Rows.Count - 1).Item(4)
                lbl_Height.Text = dt.Rows(dt.Rows.Count - 1).Item(5)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_Pickuplist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles btn_PerNext.Click
        Try
            If txt_Driver.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Driver", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf AssignedTo = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Cargo Associate", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                tablocked = False
                mtc_Dispatch.SelectedIndex = 2
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_ShipNext_Click(sender As Object, e As EventArgs) Handles btn_ShipNext.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If dtpShipDate = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have ship date", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf CarrierId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have carrier", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'ElseIf DeliveryDispatchId = Nothing Then
                '    MetroMessageBox.Show(BCEParent, "Must have carrier", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "DELETE FROM tbl_ddeliverydispatch"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                For Each row As DataGridViewRow In dgv_DelDis.Rows
                    If row.Cells(0).Value = True Then
                        strQuery = "INSERT INTO tbl_ddeliverydispatch (hwbno) VALUES ('" & row.Cells(1).Value & "')"

                        cmd.CommandText = strQuery
                        dt = GetData(cmd)
                    End If
                Next
                tablocked = False
                mtc_Dispatch.SelectedIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_PerBack_Click(sender As Object, e As EventArgs) Handles btn_PerBack.Click
        Try
            tablocked = False
            mtc_Dispatch.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_DelDis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txt_Driver_TextChanged(sender As Object, e As EventArgs) Handles txt_Driver.TextChanged
        Try
            strQuery = "SELECT employeeid FROM tbl_employeemaster
                        WHERE fullname LIKE @fullname"

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("fullname", txt_Driver.Text.Trim)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                driver_id = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                driver_id = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DeliveryDispatch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub mtc_Dispatch_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles mtc_Dispatch.Selecting
        Try
            If tablocked = True Then
                e.Cancel = True
            ElseIf tablocked = False Then
                e.Cancel = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Carrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Carrier.SelectedIndexChanged
        Try
            strQuery = "SELECT id FROM tbl_carrier
                        WHERE carrier LIKE '" & cbo_Carrier.SelectedItem & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                CarrierId = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                CarrierId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tp_Shipment_Enter(sender As Object, e As EventArgs) Handles tp_Shipment.Enter
        Try
            tablocked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tp_Personnel_Enter(sender As Object, e As EventArgs) Handles tp_Personnel.Enter
        Try
            tablocked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtp_Shipdate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Shipdate.ValueChanged
        Try
            dtpShipDate = dtp_Shipdate.Value.Date
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tp_Vehicle_Enter(sender As Object, e As EventArgs) Handles tp_Vehicle.Enter
        Try
            tablocked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_DelDis_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DelDis.CellContentClick

    End Sub

    Private Sub cbo_Carrier_DropDown(sender As Object, e As EventArgs) Handles cbo_Carrier.DropDown
        carrier("CarrierItem")
    End Sub

    Sub carrier(ByVal u As String)
        Try
            strQuery = "SELECT carrier FROM tbl_carrier"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "CarrierItem") Then
                Me.cbo_Carrier.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "CarrierItem") Then
                    cbo_Carrier.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_DelDis_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_DelDis.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_DelDis.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_DelDis.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_DelDis.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_DelDis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DelDis.CellClick

    End Sub
End Class