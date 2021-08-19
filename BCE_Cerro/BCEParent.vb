Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class BCEParent

    Sub ExpCol_Shipment()
        Timer1.Start()
        If pnl_Shipment.Height = 54 Then
            pnl_Shipment.Height = 327
        Else
            pnl_Shipment.Height = 54
        End If
    End Sub
    Sub ExpCol_Pickup()
        Timer1.Start()
        If pnl_Pickup.Height = 54 Then
            pnl_Pickup.Height = 162
        Else
            pnl_Pickup.Height = 54
        End If
    End Sub
    Sub ExpCol_Setting()
        Timer1.Start()
        If pnl_Setting.Height = 0 Then
            pnl_Setting.Height = 275
        Else
            pnl_Setting.Height = 0
        End If
    End Sub

    Private Sub Btn_PickupSched_Click(sender As Object, e As EventArgs) Handles btn_PickupSched.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is PickUpSched Then
                    f.Activate()
                    Return
                End If
            Next

            Dim PickUp As New PickUpSched
            PickUp.MdiParent = Me
            PickUp.Dock = DockStyle.Fill
            PickUp.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_CS_PickUpList_Click(sender As Object, e As EventArgs) Handles btn_CS_PickUpList.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is CS_PickUpList Then
                    f.Activate()
                    Return
                End If
            Next

            Dim PickUp As New CS_PickUpList
            PickUp.MdiParent = Me
            PickUp.Dock = DockStyle.Fill
            PickUp.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Ops_PickUpList_Click(sender As Object, e As EventArgs) Handles btn_Ops_PickUpList.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is OPS_PickUpList Then
                    f.Activate()
                    Return
                End If
            Next

            Dim PickUp As New OPS_PickUpList
            PickUp.MdiParent = Me
            PickUp.Dock = DockStyle.Fill
            PickUp.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BCEParent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SelectBranchCodeToolStripMenuItem_Click(sender As Object, e As EventArgs)

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
    Private Sub BCEParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Name.Text = "Hi " & FirstName
        'tc_PISM.TabPages.RemoveByKey("tp_Ops")
        'tc_PISM.TabPages.RemoveByKey("tp_Fin")
        BranchCode("BranchCodeItem")
        cbo_BranchCode.SelectedIndex = 0
    End Sub

    Private Sub Btn_Receiving_Click(sender As Object, e As EventArgs) Handles btn_Inbound.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is Accept Then
                    f.Activate()
                    Return
                End If
            Next

            Dim ReceiveRec As New Accept
            ReceiveRec.MdiParent = Me
            ReceiveRec.Dock = DockStyle.Fill
            ReceiveRec.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Shipment_Click(sender As Object, e As EventArgs) Handles btn_Shipment.Click
        Try
            ExpCol_Shipment()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'If pnl_Shipment.Height < 162 Then
            '    pnl_Shipment.Height = pnl_Shipment.Height + 1
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_OutBound_Click(sender As Object, e As EventArgs) Handles btn_OutBound.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is Outbound Then
                    f.Activate()
                    Return
                End If
            Next

            Dim OutBound As New Outbound
            OutBound.MdiParent = Me
            OutBound.Dock = DockStyle.Fill
            OutBound.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Pickup_Click(sender As Object, e As EventArgs) Handles btn_Pickup.Click
        Try
            ExpCol_Pickup()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_CSDashboard_Click(sender As Object, e As EventArgs) Handles btn_CSDashboard.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is CSDashboard Then
                    f.Activate()
                    Return
                End If
            Next

            Dim CSDash As New CSDashboard
            CSDash.MdiParent = Me
            CSDash.Dock = DockStyle.Fill
            CSDash.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_OPSDashboard_Click(sender As Object, e As EventArgs) Handles btn_OPSDashboard.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is CSDashboard Then
                    f.Activate()
                    Return
                End If
            Next

            Dim CSDash As New CSDashboard
            CSDash.MdiParent = Me
            CSDash.Dock = DockStyle.Fill
            CSDash.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mt_Setting_Click(sender As Object, e As EventArgs) Handles mt_Setting.Click
        Try
            ExpCol_Setting()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Delivery_Click(sender As Object, e As EventArgs) Handles btn_Delivery.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is CS_DeliveryList Then
                    f.Activate()
                    Return
                End If
            Next

            Dim deliverylist As New CS_DeliveryList
            deliverylist.MdiParent = Me
            deliverylist.Dock = DockStyle.Fill
            deliverylist.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_AcctApp_Click(sender As Object, e As EventArgs) Handles btn_AcctApp.Click
        Try
            pnl_Setting.Size = New Size(162, 0)
            AcctApp.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ChangePass_Click(sender As Object, e As EventArgs) Handles btn_ChangePass.Click
        Try
            pnl_Setting.Size = New Size(162, 0)
            ChangePass.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_SignOut_Click(sender As Object, e As EventArgs) Handles btn_FAQ.Click
        Try
            pnl_Setting.Size = New Size(162, 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BCEParent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dim mbox As String = MetroMessageBox.Show(Me, "Are you sure?", "Think Before You Click", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If mbox = vbYes Then
                Process.GetCurrentProcess().Kill()
            ElseIf mbox = vbNo Then
                e.Cancel = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Switch_Click(sender As Object, e As EventArgs) Handles btn_Switch.Click
        Try
            pnl_Setting.Size = New Size(162, 0)
            SwitchStation.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_SignOut_Click_1(sender As Object, e As EventArgs) Handles btn_SignOut.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ReleaseNote_Click(sender As Object, e As EventArgs) Handles btn_ReleaseNote.Click
        Try
            pnl_Setting.Size = New Size(162, 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mt_Setting_MouseHover(sender As Object, e As EventArgs) Handles mt_Setting.MouseHover
        Try
            ExpCol_Setting()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_BranchCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_BranchCode.SelectedIndexChanged
        Try
            stationcode = cbo_BranchCode.SelectedItem
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_CSReport_Click(sender As Object, e As EventArgs) Handles btn_CSReport.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is KPI Then
                    f.Activate()
                    Return
                End If
            Next

            Dim KPI As New KPI
            KPI.MdiParent = Me
            KPI.Dock = DockStyle.Fill
            KPI.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_SerOrd_Click(sender As Object, e As EventArgs) Handles btn_SerOrd.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is ServiceOrder Then
                    f.Activate()
                    Return
                End If
            Next

            Dim PickUp As New ServiceOrder
            PickUp.MdiParent = Me
            PickUp.Dock = DockStyle.Fill
            PickUp.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Disbursement_Click(sender As Object, e As EventArgs) Handles btn_Disbursement.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is Disbursement Then
                    f.Activate()
                    Return
                End If
            Next

            Dim disburse As New Disbursement
            disburse.MdiParent = Me
            disburse.Dock = DockStyle.Fill
            disburse.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Costing_Click(sender As Object, e As EventArgs) Handles btn_Costing.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is Costing Then
                    f.Activate()
                    Return
                End If
            Next

            Dim Cost As New Costing
            Cost.MdiParent = Me
            Cost.Dock = DockStyle.Fill
            Cost.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Billing_Click(sender As Object, e As EventArgs) Handles btn_Billing.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is Billing Then
                    f.Activate()
                    Return
                End If
            Next

            Dim Bill As New Billing
            Bill.MdiParent = Me
            Bill.Dock = DockStyle.Fill
            Bill.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Collection_Click(sender As Object, e As EventArgs) Handles btn_Collection.Click
        Try
            Try
                For Each f As Form In Application.OpenForms
                    If TypeOf f Is Collection Then
                        f.Activate()
                        Return
                    End If
                Next

                Dim Collect As New Collection
                Collect.MdiParent = Me
                Collect.Dock = DockStyle.Fill
                Collect.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_TrackingList_Click(sender As Object, e As EventArgs) Handles btn_TrackingList.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is TrackingList Then
                    f.Activate()
                    Return
                End If
            Next

            Dim tracking As New TrackingList
            tracking.MdiParent = Me
            tracking.Dock = DockStyle.Fill
            tracking.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_TrackingApp_Click(sender As Object, e As EventArgs) Handles btn_TrackingApp.Click
        Try
            pnl_Setting.Size = New Size(162, 0)
            TrackingApp.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Manifest_Click(sender As Object, e As EventArgs) Handles btn_Manifest.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is TransferManifest Then
                    f.Activate()
                    Return
                End If
            Next

            Dim TManifest As New TransferManifest
            TManifest.MdiParent = Me
            TManifest.Dock = DockStyle.Fill
            TManifest.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try
        '    For Each f As Form In Application.OpenForms
        '        If TypeOf f Is CS_DeliveryList Then
        '            f.Activate()
        '            Return
        '        End If
        '    Next

        '    Dim deliverylist As New CS_DeliveryList
        '    deliverylist.MdiParent = Me
        '    deliverylist.Dock = DockStyle.Fill
        '    deliverylist.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub btn_Dispatch_Click(sender As Object, e As EventArgs) Handles btn_Dispatch.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is DeliveryDispatch Then
                    f.Activate()
                    Return
                End If
            Next

            Dim DeliveryDispatch As New DeliveryDispatch
            DeliveryDispatch.MdiParent = Me
            DeliveryDispatch.Dock = DockStyle.Fill
            DeliveryDispatch.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Status_Click(sender As Object, e As EventArgs) Handles btn_Status.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is ShipmentStatus Then
                    f.Activate()
                    Return
                End If
            Next

            Dim ShipmentStatus As New ShipmentStatus
            ShipmentStatus.MdiParent = Me
            ShipmentStatus.Dock = DockStyle.Fill
            ShipmentStatus.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_FileUpload_Click(sender As Object, e As EventArgs) Handles btn_FileUpload.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is FileUpload Then
                    f.Activate()
                    Return
                End If
            Next

            Dim FileUpload As New FileUpload
            FileUpload.MdiParent = Me
            FileUpload.Dock = DockStyle.Fill
            FileUpload.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ReportCS_Click(sender As Object, e As EventArgs) Handles btn_ReportCS.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is CSReport Then
                    f.Activate()
                    Return
                End If
            Next

            Dim Report As New CSReport
            Report.MdiParent = Me
            Report.Dock = DockStyle.Fill
            Report.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ReportOps_Click(sender As Object, e As EventArgs) Handles btn_ReportOps.Click
        Try
            For Each f As Form In Application.OpenForms
                If TypeOf f Is OpsReport Then
                    f.Activate()
                    Return
                End If
            Next

            Dim Report As New OpsReport
            Report.MdiParent = Me
            Report.Dock = DockStyle.Fill
            Report.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
