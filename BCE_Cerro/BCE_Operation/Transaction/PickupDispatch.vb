Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class PickupDispatch
    Dim AssignedTo As String
    Dim driver_id, vehicle_id, employee_id, datecreated As Integer
    Dim tablocked As Boolean = True

    Private Sub Vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtc_Dispatch.SelectedIndex = 0
        AssignedToItems("AssignedToItem")
        DriverAutoCom()
    End Sub
    Sub DriverAutoCom()
        Try
            strQuery = "SELECT fullname FROM tbl_employeemaster
                        WHERE fullname LIKE '%" & txt_Driver.Text & "%'
                            AND department = 'Operations'"
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
                        WHERE department = 'Operations'
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

    Private Sub Clb_AssignedTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_Driver.SelectedIndexChanged
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

    Private Sub Vehicle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Try
            tablocked = False
            mtc_Dispatch.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        Try
            If txt_Driver.Text = Nothing Then
                MetroMessageBox.Show(Me, "Must have Driver", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf AssignedTo = Nothing Then
                MetroMessageBox.Show(Me, "Must have Cargo Associate", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                tablocked = False
                mtc_Dispatch.SelectedIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_Driver_Click(sender As Object, e As EventArgs) Handles txt_Driver.Click

    End Sub

    Private Sub Mt_NHR_Click(sender As Object, e As EventArgs) Handles mt_Motor.Click
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

    Private Sub Mt_6W_Click(sender As Object, e As EventArgs)
        Try
            strQuery = "SELECT * FROM tbl_vehicle
                        WHERE plateno LIKE 'ABC7573'"

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

    Private Sub Mt_L300_Click(sender As Object, e As EventArgs) Handles mt_Van.Click
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

    Private Sub Mt_awaiting_Click(sender As Object, e As EventArgs)
        Try
            strQuery = "SELECT * FROM tbl_vehicle
                        WHERE plateno LIKE 'DIM125'"

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

    Private Sub MetroTabPage3_Click(sender As Object, e As EventArgs) Handles MetroTabPage3.Click

    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim PickupDispatchId As Integer

            If vehicle_id = Nothing Then
                MetroMessageBox.Show(Me, "Must have Vehicle", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "SELECT * FROM tbl_dpickupdispatch"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                For Each data As DataRow In dt.Rows
                    PickupDispatchId = data.Item(0)
                    strQuery = "EXEC ins_ops_pickupdispatch @pickupschedid = '" & PickupDispatchId & "',
                                                        @driverid = '" & driver_id & "',
                                                        @cargoassoc = '" & AssignedTo & "',
                                                        @vehicleid = '" & vehicle_id & "',
                                                        @status = 'OPEN',
                                                        @employeeid = '" & emplid & "',
                                                        @datecreated = '" & Date.Now & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    strQuery = "UPDATE tbl_cs_pickupsched SET status = 'IN TRANSIT'
                            WHERE id = '" & PickupDispatchId & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                Next

                MetroMessageBox.Show(BCEParent, "Pickup has been successfully dispatched", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

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

    Private Sub MetroTabPage3_Enter(sender As Object, e As EventArgs) Handles MetroTabPage3.Enter
        Try
            tablocked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MetroTabPage2_Enter(sender As Object, e As EventArgs) Handles MetroTabPage2.Enter
        Try
            tablocked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class