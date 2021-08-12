
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class PickUpSched_Mod
    Dim ComTypeId, LoadingId, ServiceId, PayId, FreightId, LocationId, UomId, TotalQty, OrigId, ServiceDiv As Integer
    Dim AcctNo As String

    Sub Search_Dimension()
        Try
            strQuery = "SELECT length as 'L', 
                                width as 'W', 
                                height as 'H', 
                                quantity as 'Qty',
                                volume as 'Vol',
                                id
                        FROM tbl_dimension
                        WHERE pickupsched_id = '" & lbl_PickupNo.Text & "'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_Dimension.DataSource = dt

            dgv_Dimension.Columns(5).Visible = False

            For x = 0 To 4
                For i = 0 To dgv_Dimension.Rows.Count - 1
                    dgv_Dimension.Item(x, i).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Search_ship_add()
        Try
            strQuery = "SELECT contactperson as 'Contact Person',
                               no_street_etc as 'Address',
                               phone as 'Phone',
                               email as 'Email',
                               id
                               FROM vw_cs_pickuporig
                               WHERE account_number = '" & AcctNo & "'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_Origin.DataSource = dt
            dgv_Origin.Columns(6).Visible = False
            dgv_Origin.Columns(2).ReadOnly = True
            dgv_Origin.Columns(3).ReadOnly = True
            dgv_Origin.Columns(4).ReadOnly = True
            dgv_Origin.Columns(5).ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub GetModified()
        Try
            Dim pickupdate As String

            strQuery = "EXEC vw_cs_pickupmodify @id = '" & lbl_PickupNo.Text & "'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                pickupdate = dt.Rows(dt.Rows.Count - 1).Item(0).ToString
                dtp_pickupdate.Value = pickupdate
                cbo_Origin.Text = dt.Rows(dt.Rows.Count - 1).Item(2)
                txt_TotalWeight.Text = dt.Rows(dt.Rows.Count - 1).Item(3)
                cbo_Loading.Text = dt.Rows(dt.Rows.Count - 1).Item(4)
                cbo_Service.Text = dt.Rows(dt.Rows.Count - 1).Item(5)
                cbo_Pay.Text = dt.Rows(dt.Rows.Count - 1).Item(6)
                cbo_Freight.Text = dt.Rows(dt.Rows.Count - 1).Item(7)
                cbo_Type.Text = dt.Rows(dt.Rows.Count - 1).Item(8)
                txt_Commodity.Text = dt.Rows(dt.Rows.Count - 1).Item(9)
                txt_SpeIns.Text = dt.Rows(dt.Rows.Count - 1).Item(10)
                AcctNo = dt.Rows(dt.Rows.Count - 1).Item(11)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PickUpSched_Mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetModified()
        Search_Dimension()
        SelectLoading()
        SelectService()
        SelectPay()
        SelectFreight()
        SelectType()
        SelectOrigin()
        Search_ship_add()
        'Computation()
    End Sub
    Sub Computation()
        Try
            Dim TotalPc As Integer = 0
            Dim TotalDim As Double = 0
            For index As Integer = 0 To dgv_Dimension.Rows.Count - 1
                dgv_Dimension.Item(4, index).Value = (dgv_Dimension(0, index).Value * dgv_Dimension(1, index).Value * dgv_Dimension(2, index).Value) / ServiceDiv
                TotalPc += dgv_Dimension.Item(3, index).Value
                TotalDim += dgv_Dimension.Item(4, index).Value
            Next
            lbl_TotalQty.Text = TotalPc
            lbl_TotalVol.Text = TotalDim.ToString("0.000")
            dgv_Dimension.Columns(4).DefaultCellStyle.Format = "N3"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Origin(ByVal u As String)

        Try
            strQuery = "SELECT location_area
                        FROM location_list"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "OriginItem") Then
                cbo_Origin.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "OriginItem") Then
                    cbo_Origin.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Loading(ByVal u As String)
        Try
            strQuery = "SELECT loadingmode FROM tbl_loadingmode"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "LoadingItem") Then
                Me.cbo_Loading.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "LoadingItem") Then
                    cbo_Loading.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub SelectLoading()
        Try
            strQuery = "SELECT id FROM tbl_loadingmode
                        WHERE loadingmode LIKE '" & cbo_Loading.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                LoadingId = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                LoadingId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Loading_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Loading.SelectedIndexChanged
        SelectLoading()
    End Sub

    Sub SelectService()
        Try
            strQuery = "SELECT id, servicedivisor FROM tbl_servicemode
                        WHERE servicemode LIKE '" & cbo_Service.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                ServiceId = dt.Rows(dt.Rows.Count - 1).Item(0)
                ServiceDiv = dt.Rows(dt.Rows.Count - 1).Item(1)
            Else
                ServiceId = Nothing
                ServiceDiv = Nothing
            End If
            Computation()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Service.SelectedIndexChanged
        SelectService()
    End Sub

    Sub SelectPay()
        Try
            strQuery = "SELECT id FROM tbl_paymode
                        WHERE paymode LIKE '" & cbo_Pay.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                PayId = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                PayId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Pay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Pay.SelectedIndexChanged
        SelectPay()
    End Sub

    Sub SelectFreight()
        Try
            strQuery = "SELECT id FROM tbl_freightmode
                        WHERE freightmode LIKE '" & cbo_Freight.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                FreightId = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                FreightId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Freight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Freight.SelectedIndexChanged
        SelectFreight()
    End Sub

    Sub SelectType()
        Try
            strQuery = "SELECT id FROM tbl_commoditytype
                        WHERE name LIKE '" & cbo_Type.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                ComTypeId = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                ComTypeId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Type.SelectedIndexChanged
        SelectType()
    End Sub

    Sub Service(ByVal u As String)
        Try
            strQuery = "SELECT servicemode FROM tbl_servicemode"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "ServiceItem") Then
                Me.cbo_Service.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "ServiceItem") Then
                    cbo_Service.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Pay(ByVal u As String)

        Try
            strQuery = "SELECT paymode FROM tbl_paymode"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "PaymodeItem") Then
                cbo_Pay.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "PaymodeItem") Then
                    cbo_Pay.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub SelectOrigin()
        Try
            strQuery = "SELECT id, location_code 
                        FROM location_list 
                        WHERE location_area LIKE '" & cbo_Origin.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                LocationId = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                LocationId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Origin.SelectedIndexChanged

    End Sub

    Private Sub cbo_Origin_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Sub Freight(ByVal u As String)

        Try
            strQuery = "SELECT freightmode FROM tbl_freightmode"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "FreightItem") Then
                cbo_Freight.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "FreightItem") Then
                    cbo_Freight.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub CommodityType(ByVal u As String)

        Try
            strQuery = "SELECT name FROM tbl_commoditytype"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "CommodityTypeItem") Then
                Me.cbo_Type.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "CommodityTypeItem") Then
                    cbo_Type.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgv_Dimension_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellContentClick

    End Sub

    Sub SelectPickupAdd()
        Try
            For Each row As DataGridViewRow In dgv_Origin.Rows
                If row.Cells(0).Value = True Then
                    OrigId = row.Cells(6).Value
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ModifyDimension()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            For i = 0 To dgv_Dimension.Rows.Count - 1
                If dgv_Dimension.Item(0, i).Value <> Nothing Then
                    strQuery = "EXEC mod_cs_dimension @length = '" & dgv_Dimension.Item(0, i).Value & "',
                                                      @width = '" & dgv_Dimension.Item(1, i).Value & "',
                                                      @height = '" & dgv_Dimension.Item(2, i).Value & "',
                                                      @quantity = '" & dgv_Dimension.Item(3, i).Value & "',
                                                      @volume = '" & lbl_TotalVol.Text & "',
                                                      @id = '" & dgv_Dimension.Item(5, i).Value & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If
            Next
            strQuery = "UPDATE tbl_cs_pickupsched SET qty = '" & lbl_TotalQty.Text & "'
                        WHERE id = '" & lbl_PickupNo.Text & "'"

            cmd.CommandText = strQuery
            dt = GetData(cmd)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            SelectPickupAdd()
            If LoadingId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Loading Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf ServiceId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Service Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf PayId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Pay Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Freightid = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Freight Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf ComTypeId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Commodity Type", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Commodity.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Commodity Description", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_TotalWeight.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Total Weight", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf dgv_Dimension.Rows.Count = 0 Then
                MetroMessageBox.Show(BCEParent, "Must have Dimension", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf LocationId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Origin", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf OrigId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Pickup Address", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "EXEC mod_cs_pickupmodify @id = @id,
                                                     @pickup = @pickup,
                                                     @location_id = @location_id,
                                                     @orig_id = @orig_id,
                                                     @weight = @weight,
                                                     @loading_id = @loading_id,
                                                     @service_id = @service_id,
                                                     @pay_id = @pay_id,
                                                     @freight_id = @freight_id,
                                                     @com_id = @com_id,           
                                                     @commodity = @commodity,
                                                     @specialinstruction = @specialinstruction"
                cmd.CommandText = strQuery
                cmd.Parameters.AddWithValue("id", lbl_PickupNo.Text)
                cmd.Parameters.AddWithValue("pickup", dtp_pickupdate.Value.Date + dtp_pickuptime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("location_id", LocationId)
                cmd.Parameters.AddWithValue("orig_id", OrigId)
                cmd.Parameters.AddWithValue("weight", txt_TotalWeight.Text)
                cmd.Parameters.AddWithValue("loading_id", LoadingId)
                cmd.Parameters.AddWithValue("service_id", ServiceId)
                cmd.Parameters.AddWithValue("pay_id", PayId)
                cmd.Parameters.AddWithValue("freight_id", FreightId)
                cmd.Parameters.AddWithValue("com_id", ComTypeId)
                cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text.ToUpper)
                cmd.Parameters.AddWithValue("specialinstruction", txt_SpeIns.Text.ToUpper)
                dt = GetData(cmd)

                ModifyDimension()

                MetroMessageBox.Show(BCEParent, "Pickup schedule has been successfully modified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Pick up schedule failed to set due to" & ex.Message)
        End Try
    End Sub

    Private Sub cbo_Pay_DropDown(sender As Object, e As EventArgs) Handles cbo_Pay.DropDown
        Pay("PaymodeItem")
    End Sub

    Private Sub cbo_Loading_DropDown(sender As Object, e As EventArgs) Handles cbo_Loading.DropDown
        Loading("LoadingItem")
    End Sub

    Private Sub cbo_Service_DropDown(sender As Object, e As EventArgs) Handles cbo_Service.DropDown
        Service("ServiceItem")
    End Sub

    Private Sub cbo_Freight_DropDown(sender As Object, e As EventArgs) Handles cbo_Freight.DropDown
        Freight("FreightItem")
    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles cbo_Origin.DropDown
        Origin("OriginItem")
    End Sub

    Private Sub cbo_Type_DropDown(sender As Object, e As EventArgs) Handles cbo_Type.DropDown
        CommodityType("CommodityTypeItem")
    End Sub

    Private Sub dgv_Dimension_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellEndEdit
        Computation()
    End Sub
End Class