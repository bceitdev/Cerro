Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.Web.UI.WebControls
Imports CrystalDecisions.CrystalReports.Engine
Public Class ServiceOrder
    Dim rptdoc As ReportDocument
    Dim charwt As Double
    Dim Modify As Boolean
    Dim tcode, OrigCode, DestCode, ShipAcctNo, HWBs As String
    Dim ShipGenId, LoadingId, ServiceId, ServiceDiv, PayId, FreightId, UomId, ComTypeId, OrigId, DestId, DimId, SOId, HWB4Upd As Integer
    Sub clear()
        Modify = False
        txt_Search.Text = Nothing
        rb_01.Checked = True
        ShipGenId = Nothing
        txt_01.Text = Nothing
        txt_02.Text = Nothing
        txt_Ship_Phone.Text = Nothing
        txt_Consignee.Text = Nothing
        txt_Address.Text = Nothing
        txt_Con_Phone.Text = Nothing
        cbo_Carrier.Text = Nothing
        CarrierId = Nothing
        cbo_Orig.Text = Nothing
        OrigId = Nothing
        cbo_Dest.Text = Nothing
        DestId = Nothing
        cbo_Loading.Text = Nothing
        LoadingId = Nothing
        cbo_Service.Text = Nothing
        ServiceId = Nothing
        cbo_Pay.Text = Nothing
        PayId = Nothing
        cbo_Freight.Text = Nothing
        FreightId = Nothing
        cbo_Type.Text = Nothing
        ComTypeId = Nothing
        cbo_Uom.Text = Nothing
        UomId = Nothing
        txt_Commodity.Text = Nothing
        txt_DeclaredValue.Text = Nothing
        txt_Weight.Text = Nothing
        txt_SpeIns.Text = Nothing
        lbl_TotalQty.Text = Nothing
        lbl_TotalVol.Text = Nothing
        AddRowsDimension()
        dgv_DimensionDummy.Columns.Clear()
        dgv_Dimension.Visible = False
        dgv_Dimension.Visible = True
        txt_hwbno.Text = Nothing
    End Sub
    Sub AddDimension()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT MAX(id) FROM tbl_serviceorder"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            If dt.Rows.Count > 0 Then
                Dim SerOrdId As Integer = dt.Rows(dt.Rows.Count - 1).Item(0)
                For i = 0 To dgv_Dimension.Rows.Count - 1
                    If dgv_Dimension.Item(0, i).Value <> Nothing Then
                        strQuery = "EXEC ins_dimension_so @type = 'ACTUAL',
                                                          @serviceorder_id = '" & SerOrdId & "',
                                                          @length = '" & dgv_Dimension.Item(0, i).Value & "',
                                                          @width = '" & dgv_Dimension.Item(1, i).Value & "',
                                                          @height = '" & dgv_Dimension.Item(2, i).Value & "',
                                                          @quantity = '" & dgv_Dimension.Item(3, i).Value & "',
                                                          @volume = '" & dgv_Dimension.Item(4, i).Value & "'"

                        cmd.CommandText = strQuery
                        dt = GetData(cmd)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub UpdDummyDimension()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim l, w, h, volwt, charwts As Decimal


            For i = 0 To dgv_DimensionDummy.Rows.Count - 1
                If dgv_DimensionDummy.Item(0, i).Value <> Nothing Then
                    l = dgv_DimensionDummy.Item(0, i).Value
                    w = dgv_DimensionDummy.Item(1, i).Value
                    h = dgv_DimensionDummy.Item(2, i).Value
                    volwt = dgv_DimensionDummy.Item(4, i).Value
                    charwts = charwt

                    If tcode = rb_01.Text Then
                        strQuery = "UPDATE tbl_dummydimension SET accepted_date = '" & dtpShipDateWalkIn & "',
                                                          origin = '" & cbo_Orig.Text & "',
							                              origin_code = '" & OrigCode & "',
							                              destination = '" & cbo_Dest.Text & "',
							                              destination_code = '" & DestCode & "',
							                              loadingmode = '" & cbo_Loading.Text & "',
							                              consignee = '" & txt_Consignee.Text & "',
							                              no_street_etc = '" & txt_Address.Text & "',
							                              account_number = '" & ShipAcctNo & "',
							                              company_name = '" & txt_01.Text & "',
							                              actualqty = '" & dgv_DimensionDummy.Item(3, i).Value & "',
							                              code = '" & cbo_Uom.Text & "',
							                              commodity = '" & txt_Commodity.Text & "',
							                              length = '" & l & "',
							                              width = '" & w & "',
							                              height = '" & h & "',
							                              actualwt = '" & txt_Weight.Text & "',
							                              volwt = '" & volwt & "',
							                              charwt = '" & charwts & "',
							                              decval = '" & txt_DeclaredValue.Text & "',
							                              paymode = '" & cbo_Pay.Text & "',
							                              servicemode = '" & cbo_Service.Text & "',
							                              freightmode = '" & cbo_Freight.Text & "',
							                              phone = '" & txt_Con_Phone.Text & "',
							                              status = 'OPEN',
							                              hwb_no_carb = '" & txt_hwbno.Text & "',
                                                          totalqty = '" & lbl_TotalQty.Text & "'
                        WHERE hwb_no = '" & HWBs & "'"
                    ElseIf tcode = rb_02.Text Then
                        strQuery = "UPDATE tbl_dummydimension SET accepted_date = '" & dtpShipDateWalkIn & "',
                                                          origin = '" & cbo_Orig.Text & "',
							                              origin_code = '" & OrigCode & "',
							                              destination = '" & cbo_Dest.Text & "',
							                              destination_code = '" & DestCode & "',
							                              loadingmode = '" & cbo_Loading.Text & "',
							                              consignee = '" & txt_Consignee.Text & "',
							                              no_street_etc = '" & txt_Address.Text & "',
							                              account_number = '" & tcode & "',
							                              company_name = '" & txt_02.Text & "',
							                              actualqty = '" & dgv_DimensionDummy.Item(3, i).Value & "',
							                              code = '" & cbo_Uom.Text & "',
							                              commodity = '" & txt_Commodity.Text & "',
							                              length = '" & l & "',
							                              width = '" & w & "',
							                              height = '" & h & "',
							                              actualwt = '" & txt_Weight.Text & "',
							                              volwt = '" & volwt & "',
							                              charwt = '" & charwts & "',
							                              decval = '" & txt_DeclaredValue.Text & "',
							                              paymode = '" & cbo_Pay.Text & "',
							                              servicemode = '" & cbo_Service.Text & "',
							                              freightmode = '" & cbo_Freight.Text & "',
							                              phone = '" & txt_Con_Phone.Text & "',
							                              status = 'OPEN',
							                              hwb_no_carb = '" & txt_hwbno.Text & "',
                                                          totalqty = '" & lbl_TotalQty.Text & "'
                            WHERE hwb_no = '" & HWBs & "'"
                    End If
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub AddDummyDimension()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim l, w, h, volwt, charwts As Decimal

            strQuery = "SELECT MAX(id) FROM tbl_serviceorder"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            If dt.Rows.Count > 0 Then
                Dim SerOrdId As Integer = dt.Rows(dt.Rows.Count - 1).Item(0)
                For i = 0 To dgv_Dimension.Rows.Count - 1
                    If dgv_Dimension.Item(0, i).Value <> Nothing Then
                        l = dgv_Dimension.Item(0, i).Value
                        w = dgv_Dimension.Item(1, i).Value
                        h = dgv_Dimension.Item(2, i).Value
                        volwt = dgv_Dimension.Item(4, i).Value
                        charwts = charwt
                        If tcode = rb_01.Text Then
                            strQuery = "INSERT INTO tbl_dummydimension (accepted_date,
                                                                        serviceorder_id,
                                                                        origin,
                                                                        origin_code,
                                                                        destination,
                                                                        destination_code,
                                                                        loadingmode,
                                                                        consignee,
                                                                        no_street_etc,
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
                                                                        phone,
                                                                        status,
                                                                        hwb_no_carb,
                                                                        totalqty)
                                    VALUES
                                                                    ('" & dtp_Date.Value.Date & "',
                                                                    '" & SerOrdId & "',
                                                                     '" & cbo_Orig.Text & "',
                                                                    '" & OrigCode & "',
                                                                     '" & cbo_Dest.Text & "',
                                                                    '" & DestCode & "',
                                                                     '" & cbo_Loading.Text & "',
                                                                    '" & txt_Consignee.Text & "',
                                                                     '" & txt_Address.Text & "',
                                                                    '" & ShipAcctNo & "',
                                                                     '" & txt_01.Text & "',
                                                                    '" & dgv_Dimension.Item(3, i).Value & "',
                                                                     '" & cbo_Uom.Text & "',
                                                                    '" & txt_Commodity.Text & "',
                                                                     '" & l & "',
                                                                    '" & w & "',
                                                                     '" & h & "',
                                                                    '" & txt_Weight.Text & "',
                                                                     '" & volwt & "',
                                                                    '" & charwts & "',
                                                                     '" & txt_DeclaredValue.Text & "',
                                                                    '" & cbo_Pay.Text & "',
                                                                     '" & cbo_Service.Text & "',
                                                                    '" & cbo_Freight.Text & "',
                                                                     '" & txt_Con_Phone.Text & "',
                                                                    'OPEN',
                                                                    '" & txt_hwbno.Text & "',
                                                                    '" & lbl_TotalQty.Text & "')"
                        ElseIf tcode = rb_02.Text Then
                            strQuery = "INSERT INTO tbl_dummydimension (accepted_date,
                                                                    serviceorder_id,
                                                                    origin,
                                                                    origin_code,
                                                                    destination,
                                                                    destination_code,
                                                                    loadingmode,
                                                                    consignee,
                                                                    no_street_etc,
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
                                                                    phone,
                                                                    status,
                                                                    hwb_no_carb,
                                                                    totalqty)
                                    VALUES
                                                                    ('" & dtp_Date.Value.Date & "',
                                                                    '" & SerOrdId & "',
                                                                     '" & cbo_Orig.Text & "',
                                                                    '" & OrigCode & "',
                                                                     '" & cbo_Dest.Text & "',
                                                                    '" & DestCode & "',
                                                                     '" & cbo_Loading.Text & "',
                                                                    '" & txt_Consignee.Text & "',
                                                                     '" & txt_Address.Text & "',
                                                                    '" & tcode & "',
                                                                     '" & txt_02.Text & "',
                                                                    '" & dgv_Dimension.Item(3, i).Value & "',
                                                                     '" & cbo_Uom.Text & "',
                                                                    '" & txt_Commodity.Text & "',
                                                                     '" & l & "',
                                                                    '" & w & "',
                                                                     '" & h & "',
                                                                    '" & txt_Weight.Text & "',
                                                                     '" & volwt & "',
                                                                    '" & charwts & "',
                                                                     '" & txt_DeclaredValue.Text & "',
                                                                    '" & cbo_Pay.Text & "',
                                                                     '" & cbo_Service.Text & "',
                                                                    '" & cbo_Freight.Text & "',
                                                                     '" & txt_Con_Phone.Text & "',
                                                                    'OPEN',
                                                                    '" & txt_hwbno.Text & "',
                                                                    '" & lbl_TotalQty.Text & "')"
                        End If
                        cmd.CommandText = strQuery
                        dt = GetData(cmd)
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub HWBNo()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT ISNULL(MAX(count), 0) + 1
                        FROM tbl_outbound"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            CountWalkIn = dt.Rows(dt.Rows.Count - 1).Item(0)

            strQuery = "SELECT branchcode FROM vw_branch
                        WHERE branchcode LIKE '" & stationcode & "'"

            HWBCtrlNoWalkIn = stationcode + CountWalkIn.ToString("0000000000")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub GetItem()
        Try
            conn("SELECT pur_no,
                         hwb_no_carb,
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
                  WHERE serviceorder_id IS NOT NULL
                      AND hwb_no IS NULL", "tbl_dummydimension")
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
            txt_CtrlNo.Text = HWBCtrlNoWalkIn
            txt_ShipDate = rptdoc.ReportDefinition.ReportObjects("txt_ShipDate")
            txt_ShipDate.Text = dtpShipDateWalkIn.Date

            HWB.crv_HWB.ReportSource = rptdoc
            HWB.crv_HWB.Refresh()

            HWB.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub upd_DimensionDummy()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim DDId, DDSOId As Integer

            For i = 0 To dgv_DimensionDummy.Rows.Count - 1
                If dgv_DimensionDummy.Item(0, i).Value <> Nothing Then
                    strQuery = "SELECT id, serviceorder_id 
                            FROM tbl_dummydimension
                            WHERE hwb_no LIKE '" & HWBs & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    For Each row As DataRow In dt.Rows
                        DDId = row.Item(0)
                        DDSOId = row.Item(1)

                        strQuery = "UPDATE tbl_dummydimension SET length = '" & dgv_DimensionDummy.Item(2, i).Value & "',
                                                              width = '" & dgv_DimensionDummy.Item(3, i).Value & "',
                                                              height = '" & dgv_DimensionDummy.Item(4, i).Value & "',
                                                              actualqty = '" & dgv_DimensionDummy.Item(5, i).Value & "',
                                                              volwt = '" & dgv_DimensionDummy.Item(6, i).Value & "'
                                WHERE id = '" & DDId & "'
                                    AND serviceorder_id = '" & DDSOId & "'"

                        cmd.CommandText = strQuery
                        dt = GetData(cmd)
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub upd_Dimension()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            For i = 0 To dgv_DimensionDummy.Rows.Count - 1
                If dgv_DimensionDummy.Item(0, i).Value <> Nothing Then
                    strQuery = "EXEC upd_dimension_so @id = '" & dgv_DimensionDummy.Item(0, i).Value & "',
                                                      @serviceorder_id = '" & dgv_DimensionDummy.Item(1, i).Value & "',
                                                      @length = '" & dgv_DimensionDummy.Item(2, i).Value & "',
                                                      @width = '" & dgv_DimensionDummy.Item(3, i).Value & "',
                                                      @height = '" & dgv_DimensionDummy.Item(4, i).Value & "',
                                                      @quantity = '" & dgv_DimensionDummy.Item(5, i).Value & "',
                                                      @volume = '" & dgv_DimensionDummy.Item(6, i).Value & "'"

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub mod_costing01()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim addid As Integer

            strQuery = "SELECT id FROM bp_addresses
                        WHERE account_number = '" & ShipAcctNo & "'
	                        AND address_type = 'BILL TO' "
            cmd.CommandText = strQuery
            dt = GetData(cmd)

            addid = dt.Rows(dt.Rows.Count - 1).Item(0)

            strQuery = "UPDATE tbl_costing SET acctid = '" & ShipGenId & "',
                                               addid = '" & addid & "',
                                               acctno = '" & ShipAcctNo & "',
                                               compname = '" & txt_01.Text & "'
                        WHERE outboundid = '" & HWBs & "'"
            cmd.CommandText = strQuery
            dt = GetData(cmd)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub mod_costing02()
        Try
            strQuery = "UPDATE tbl_costing SET acctid = NULL,
                                               addid = NULL,
                                               acctno = '" & rb_02.Text & "',
                                               compname = '" & txt_02.Text & "'
                        WHERE outboundid = '" & HWBs & "'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub billingstatus()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If PayId = 3 Or PayId = 4 Then
                strQuery = "UPDATE tbl_costing SET clientstatus = 'OPEN',
                                                    hwbstatus = 'OPEN'
                            WHERE outboundid = '" & HWBs & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)
            Else
                strQuery = "UPDATE tbl_costing SET clientstatus = 'CLOSED',
                                                    hwbstatus = 'CLOSED'
                            WHERE outboundid = '" & HWBs & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If tcode = rb_01.Text And ShipGenId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Shipper", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf tcode = rb_02.Text And txt_02.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Shipper", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_hwbno.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have HWB No.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Ship_Phone.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Shipper Phone", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Consignee.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Consignee", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Address.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Consignee's Address", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Con_Phone.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Consignee's Phone", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf OrigId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Origin", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf DestId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Destination", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf dtpShipDateWalkIn = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Date", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf UomId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have UOM", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf LoadingId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Loading Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf ServiceId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Service Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf PayId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Pay Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf FreightId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Freight Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf ComTypeId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Commodity Type", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Commodity.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Commodity Description", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_DeclaredValue.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Declared Value must have atleast zero (0) if no amount", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Weight.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Weight", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If Modify = True Then

                    strQuery = "SELECT id FROM vw_serviceorder
                                WHERE hwb_no LIKE '" & HWBs & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    If dt.Rows.Count > 0 Then
                        HWB4Upd = dt.Rows(dt.Rows.Count - 1).Item(0)
                    End If

                    If tcode = rb_01.Text Then
                        strQuery = "EXEC upd_serviceorder @id = @id,
                                                      @tcode = @tcode,
                                                      @hwb_no_carb = @hwb_no_carb,
                                                      @date = @date,
                                                      @gen_id = @gen_id,
                                                      @shipper = NULL,
                                                      @ship_phone = @ship_phone,
                                                      @consignee = @consignee,
                                                      @address = @address,
                                                      @con_phone = @con_phone,
                                                      @orig_id = @orig_id,
                                                      @dest_id = @dest_id,
                                                      @loading_id = @loading_id,
                                                      @service_id = @service_id,
                                                      @pay_id = @pay_id,                                         
                                                      @freight_id = @freight_id,
                                                      @com_id = @com_id,
                                                      @commodity = @commodity,
                                                      @unit_id = @unit_id,
                                                      @declaredvalue = @declaredvalue,
                                                      @actualwt = @actualwt,	
                                                      @actualqty = @actualqty,
                                                      @charwt = @charwt,
                                                      @specialinstruction = @specialinstruction,
                                                      @status = @status,
                                                      @employeeid = @employeeid,
                                                      @datecreated = @datecreated"

                        cmd.CommandText = strQuery
                        cmd.Parameters.AddWithValue("id", HWB4Upd)
                        cmd.Parameters.AddWithValue("tcode", tcode)
                        cmd.Parameters.AddWithValue("hwb_no_carb", txt_hwbno.Text)
                        cmd.Parameters.AddWithValue("date", dtpShipDateWalkIn)
                        cmd.Parameters.AddWithValue("gen_id", ShipGenId)
                        cmd.Parameters.AddWithValue("ship_phone", txt_Ship_Phone.Text)
                        cmd.Parameters.AddWithValue("consignee", txt_Consignee.Text)
                        cmd.Parameters.AddWithValue("address", txt_Address.Text)
                        cmd.Parameters.AddWithValue("con_phone", txt_Con_Phone.Text)
                        cmd.Parameters.AddWithValue("orig_id", OrigId)
                        cmd.Parameters.AddWithValue("dest_id", DestId)
                        cmd.Parameters.AddWithValue("loading_id", LoadingId)
                        cmd.Parameters.AddWithValue("service_id", ServiceId)
                        cmd.Parameters.AddWithValue("pay_id", PayId)
                        cmd.Parameters.AddWithValue("freight_id", FreightId)
                        cmd.Parameters.AddWithValue("com_id", ComTypeId)
                        cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text)
                        cmd.Parameters.AddWithValue("unit_id", UomId)
                        cmd.Parameters.AddWithValue("declaredvalue", txt_DeclaredValue.Text)
                        cmd.Parameters.AddWithValue("actualwt", txt_Weight.Text)
                        cmd.Parameters.AddWithValue("actualqty", lbl_TotalQty.Text)

                        If txt_Weight.Text > lbl_TotalVol.Text Then
                            charwt = txt_Weight.Text
                        ElseIf lbl_TotalVol.Text > txt_Weight.Text Then
                            charwt = lbl_TotalVol.Text
                        End If

                        cmd.Parameters.AddWithValue("charwt", charwt)
                        cmd.Parameters.AddWithValue("specialinstruction", txt_SpeIns.Text)
                        cmd.Parameters.AddWithValue("status", "OPEN")
                        cmd.Parameters.AddWithValue("employeeid", emplid)
                        cmd.Parameters.AddWithValue("datecreated", Date.Now)
                        dt = GetData(cmd)

                        mod_costing01()
                    ElseIf tcode = rb_02.Text Then
                        strQuery = "EXEC upd_serviceorder @id = @id,
                                                      @tcode = @tcode,
                                                      @hwb_no_carb = @hwb_no_carb,
                                                      @date = @date,
                                                      @gen_id = NULL,
                                                      @shipper = @shipper,
                                                      @ship_phone = @ship_phone,
                                                      @consignee = @consignee,
                                                      @address = @address,
                                                      @con_phone = @con_phone,
                                                      @orig_id = @orig_id,
                                                      @dest_id = @dest_id,
                                                      @loading_id = @loading_id,
                                                      @service_id = @service_id,
                                                      @pay_id = @pay_id,                                         
                                                      @freight_id = @freight_id,
                                                      @com_id = @com_id,
                                                      @commodity = @commodity,
                                                      @unit_id = @unit_id,
                                                      @declaredvalue = @declaredvalue,
                                                      @actualwt = @actualwt,	
                                                      @actualqty = @actualqty,
                                                      @charwt = @charwt,
                                                      @specialinstruction = @specialinstruction,
                                                      @status = @status,
                                                      @employeeid = @employeeid,
                                                      @datecreated = @datecreated"

                        cmd.CommandText = strQuery
                        cmd.Parameters.AddWithValue("id", HWB4Upd)
                        cmd.Parameters.AddWithValue("tcode", tcode)
                        cmd.Parameters.AddWithValue("hwb_no_carb", txt_hwbno.Text)
                        cmd.Parameters.AddWithValue("date", dtpShipDateWalkIn)
                        cmd.Parameters.AddWithValue("shipper", txt_02.Text)
                        cmd.Parameters.AddWithValue("ship_phone", txt_Ship_Phone.Text)
                        cmd.Parameters.AddWithValue("consignee", txt_Consignee.Text)
                        cmd.Parameters.AddWithValue("address", txt_Address.Text)
                        cmd.Parameters.AddWithValue("con_phone", txt_Con_Phone.Text)
                        cmd.Parameters.AddWithValue("orig_id", OrigId)
                        cmd.Parameters.AddWithValue("dest_id", DestId)
                        cmd.Parameters.AddWithValue("loading_id", LoadingId)
                        cmd.Parameters.AddWithValue("service_id", ServiceId)
                        cmd.Parameters.AddWithValue("pay_id", PayId)
                        cmd.Parameters.AddWithValue("freight_id", FreightId)
                        cmd.Parameters.AddWithValue("com_id", ComTypeId)
                        cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text)
                        cmd.Parameters.AddWithValue("unit_id", UomId)
                        cmd.Parameters.AddWithValue("declaredvalue", txt_DeclaredValue.Text)
                        cmd.Parameters.AddWithValue("actualwt", txt_Weight.Text)
                        cmd.Parameters.AddWithValue("actualqty", lbl_TotalQty.Text)

                        If txt_Weight.Text > lbl_TotalVol.Text Then
                            charwt = txt_Weight.Text
                        ElseIf lbl_TotalVol.Text > txt_Weight.Text Then
                            charwt = lbl_TotalVol.Text
                        End If

                        cmd.Parameters.AddWithValue("charwt", charwt)
                        cmd.Parameters.AddWithValue("specialinstruction", txt_SpeIns.Text)
                        cmd.Parameters.AddWithValue("status", "OPEN")
                        cmd.Parameters.AddWithValue("employeeid", emplid)
                        cmd.Parameters.AddWithValue("datecreated", Date.Now)
                        dt = GetData(cmd)

                        mod_costing02()
                    End If
                    upd_Dimension()
                    UpdDummyDimension()
                    billingstatus()
                    MetroMessageBox.Show(BCEParent, "Walkin has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    strQuery = "SELECT hwb_no_carb 
                                FROM tbl_serviceorder
                                WHERE hwb_no_carb = '" & txt_hwbno.Text & "'"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)

                    If dt.Rows.Count > 0 Then
                        MetroMessageBox.Show(BCEParent, "HWB No. already exist", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        If tcode = rb_01.Text Then
                            strQuery = "EXEC ins_serviceorder @tcode = @tcode,
                                              @hwb_no_carb = @hwb_no_carb,
                                              @date = @date,
                                              @gen_id = @gen_id,
                                              @ship_phone = @ship_phone,
                                              @consignee = @consignee,
                                              @address = @address,
                                              @con_phone = @con_phone,
                                              @orig_id = @orig_id,
                                              @dest_id = @dest_id,
                                              @loading_id = @loading_id,
                                              @service_id = @service_id,
                                              @pay_id = @pay_id,                                         
                                              @freight_id = @freight_id,
                                              @com_id = @com_id,
                                              @commodity = @commodity,
                                              @unit_id = @unit_id,
                                              @declaredvalue = @declaredvalue,
                                              @actualwt = @actualwt,	
                                              @actualqty = @actualqty,
                                              @charwt = @charwt,
                                              @specialinstruction = @specialinstruction,
                                              @status = @status,
                                              @employeeid = @employeeid,
                                              @datecreated = @datecreated"

                            cmd.CommandText = strQuery
                            cmd.Parameters.AddWithValue("tcode", tcode)
                            cmd.Parameters.AddWithValue("hwb_no_carb", txt_hwbno.Text)
                            cmd.Parameters.AddWithValue("date", dtpShipDateWalkIn)
                            cmd.Parameters.AddWithValue("gen_id", ShipGenId)
                            cmd.Parameters.AddWithValue("ship_phone", txt_Ship_Phone.Text)
                            cmd.Parameters.AddWithValue("consignee", txt_Consignee.Text)
                            cmd.Parameters.AddWithValue("address", txt_Address.Text)
                            cmd.Parameters.AddWithValue("con_phone", txt_Con_Phone.Text)
                            cmd.Parameters.AddWithValue("orig_id", OrigId)
                            cmd.Parameters.AddWithValue("dest_id", DestId)
                            cmd.Parameters.AddWithValue("loading_id", LoadingId)
                            cmd.Parameters.AddWithValue("service_id", ServiceId)
                            cmd.Parameters.AddWithValue("pay_id", PayId)
                            cmd.Parameters.AddWithValue("freight_id", FreightId)
                            cmd.Parameters.AddWithValue("com_id", ComTypeId)
                            cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text)
                            cmd.Parameters.AddWithValue("unit_id", UomId)
                            cmd.Parameters.AddWithValue("declaredvalue", txt_DeclaredValue.Text)
                            cmd.Parameters.AddWithValue("actualwt", txt_Weight.Text)
                            cmd.Parameters.AddWithValue("actualqty", lbl_TotalQty.Text)

                            If txt_Weight.Text > lbl_TotalVol.Text Then
                                charwt = txt_Weight.Text
                            ElseIf lbl_TotalVol.Text > txt_Weight.Text Then
                                charwt = lbl_TotalVol.Text
                            End If

                            cmd.Parameters.AddWithValue("charwt", charwt)
                            cmd.Parameters.AddWithValue("specialinstruction", txt_SpeIns.Text)
                            cmd.Parameters.AddWithValue("status", "OPEN")
                            cmd.Parameters.AddWithValue("employeeid", emplid)
                            cmd.Parameters.AddWithValue("datecreated", Date.Now)
                            dt = GetData(cmd)
                        ElseIf tcode = rb_02.Text Then
                            strQuery = "EXEC ins_serviceorder02 @tcode = @tcode,
                                              @hwb_no_carb = @hwb_no_carb,
                                              @date = @date,
                                              @shipper = @shipper,
                                              @ship_phone = @ship_phone,
                                              @consignee = @consignee,
                                              @address = @address,
                                              @con_phone = @con_phone,
                                              @orig_id = @orig_id,
                                              @dest_id = @dest_id,
                                              @loading_id = @loading_id,
                                              @service_id = @service_id,
                                              @pay_id = @pay_id,                                         
                                              @freight_id = @freight_id,
                                              @com_id = @com_id,
                                              @commodity = @commodity,
                                              @unit_id = @unit_id,
                                              @declaredvalue = @declaredvalue,
                                              @actualwt = @actualwt,	
                                              @actualqty = @actualqty,
                                              @charwt = @charwt,
                                              @specialinstruction = @specialinstruction,
                                              @status = @status,
                                              @employeeid = @employeeid,
                                              @datecreated = @datecreated"

                            cmd.CommandText = strQuery
                            cmd.Parameters.AddWithValue("tcode", tcode)
                            cmd.Parameters.AddWithValue("hwb_no_carb", txt_hwbno.Text)
                            cmd.Parameters.AddWithValue("date", dtpShipDateWalkIn)
                            cmd.Parameters.AddWithValue("shipper", txt_02.Text)
                            cmd.Parameters.AddWithValue("ship_phone", txt_Ship_Phone.Text)
                            cmd.Parameters.AddWithValue("consignee", txt_Consignee.Text)
                            cmd.Parameters.AddWithValue("address", txt_Address.Text)
                            cmd.Parameters.AddWithValue("con_phone", txt_Con_Phone.Text)
                            cmd.Parameters.AddWithValue("orig_id", OrigId)
                            cmd.Parameters.AddWithValue("dest_id", DestId)
                            cmd.Parameters.AddWithValue("loading_id", LoadingId)
                            cmd.Parameters.AddWithValue("service_id", ServiceId)
                            cmd.Parameters.AddWithValue("pay_id", PayId)
                            cmd.Parameters.AddWithValue("freight_id", FreightId)
                            cmd.Parameters.AddWithValue("com_id", ComTypeId)
                            cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text)
                            cmd.Parameters.AddWithValue("unit_id", UomId)
                            cmd.Parameters.AddWithValue("declaredvalue", txt_DeclaredValue.Text)
                            cmd.Parameters.AddWithValue("actualwt", txt_Weight.Text)
                            cmd.Parameters.AddWithValue("actualqty", lbl_TotalQty.Text)

                            If txt_Weight.Text > lbl_TotalVol.Text Then
                                charwt = txt_Weight.Text
                            ElseIf lbl_TotalVol.Text > txt_Weight.Text Then
                                charwt = lbl_TotalVol.Text
                            End If

                            cmd.Parameters.AddWithValue("charwt", charwt)
                            cmd.Parameters.AddWithValue("specialinstruction", txt_SpeIns.Text)
                            cmd.Parameters.AddWithValue("status", "OPEN")
                            cmd.Parameters.AddWithValue("employeeid", emplid)
                            cmd.Parameters.AddWithValue("datecreated", Date.Now)
                            dt = GetData(cmd)
                        End If
                        AddDimension()
                        AddDummyDimension()
                        MetroMessageBox.Show(BCEParent, "Walkin has been successfully received", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clear()
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub OrigAutoCom()
        Try
            strQuery = "SELECT location_area FROM location_list 
                        WHERE location_area LIKE '%" & cbo_Orig.Text & "%'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Orig.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Orig.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Orig.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("location_area"))).ToArray())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ServiceAutoCom()
        Try
            strQuery = "SELECT servicemode FROM tbl_servicemode
                        WHERE servicemode LIKE '%" & cbo_Service.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Service.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Service.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Service.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("servicemode"))).ToArray())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PayAutoCom()
        Try
            strQuery = "SELECT paymode FROM tbl_paymode
                        WHERE paymode LIKE '%" & cbo_Pay.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Pay.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Pay.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Pay.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("paymode"))).ToArray())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub UnitAutoCom()
        Try
            strQuery = "SELECT code FROM tbl_uom
                        WHERE code LIKE '%" & cbo_Uom.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Uom.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Uom.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Uom.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("code"))).ToArray())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub TypeAutoCom()
        Try
            strQuery = "SELECT name FROM tbl_commoditytype
                        WHERE name LIKE '%" & cbo_Type.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Type.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Type.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Type.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("name"))).ToArray())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub FreightAutoCom()
        Try
            strQuery = "SELECT freightmode FROM tbl_freightmode
                        WHERE freightmode LIKE '%" & cbo_Freight.Text & "%'
                            AND cat LIKE 'OPS'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Freight.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Freight.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Freight.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("freightmode"))).ToArray())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub LoadingAutoCom()
        Try
            strQuery = "SELECT loadingmode FROM tbl_loadingmode
                        WHERE loadingmode LIKE '%" & cbo_Loading.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Loading.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Loading.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Loading.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("loadingmode"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub DestAutoCom()
        Try
            strQuery = "SELECT location_area FROM location_list 
                        WHERE location_area LIKE '%" & cbo_Dest.Text & "%'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Dest.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Dest.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Dest.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("location_area"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ServiceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_01.Checked = True
        ConShipCompAutoCom()
        CarrierAutoCom()
        OrigAutoCom()
        DestAutoCom()
        LoadingAutoCom()
        ServiceAutoCom()
        PayAutoCom()
        FreightAutoCom()
        TypeAutoCom()
        UnitAutoCom()
        AddRowsDimension()
    End Sub
    Sub AddRowsDimension()
        Try
            dgv_Dimension.Rows.Clear()
            dgv_Dimension.Rows.Add(25)
            dgv_Dimension.Columns(4).ReadOnly = True
            For x = 0 To 4
                For i = 0 To dgv_Dimension.Rows.Count - 1
                    dgv_Dimension.Item(x, i).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ConShipCompAutoCom()
        Try
            strQuery = "SELECT company_name FROM bp_general
                        WHERE company_name LIKE '%" & txt_01.Text & "%'
                            OR company_name LIKE '%" & txt_02.Text & "%'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            txt_01.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_01.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_01.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("company_name"))).ToArray())

            txt_02.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_02.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_02.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("company_name"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CarrierAutoCom()
        Try
            strQuery = "SELECT carrier FROM tbl_carrier
                        WHERE carrier LIKE '%" & cbo_Carrier.Text & "%'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            cbo_Carrier.AutoCompleteMode = AutoCompleteMode.Suggest
            cbo_Carrier.AutoCompleteSource = AutoCompleteSource.CustomSource
            cbo_Carrier.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("carrier"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Sub SelectCar()
        Try
            strQuery = "SELECT id FROM tbl_carrier
                        WHERE carrier LIKE '" & cbo_Carrier.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                CarId = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                CarId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Carrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Carrier.SelectedIndexChanged
        SelectCar()
    End Sub

    Private Sub cbo_Carrier_DropDown(sender As Object, e As EventArgs) Handles cbo_Carrier.DropDown
        carrier("CarrierItem")
    End Sub

    Private Sub txt_Ship_Company_TextChanged(sender As Object, e As EventArgs) Handles txt_01.TextChanged
        Try
            Search_ship_ComInd()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub OrigDest(ByVal u As String)
        Try
            strQuery = "SELECT location_area
                        FROM location_list"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "OrigDestItem") Then
                cbo_Orig.Items.Clear()
                cbo_Dest.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "OrigDestItem") Then
                    cbo_Orig.Items.Add(dt.Rows(a).Item(0))
                    cbo_Dest.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Search_ship_ComInd()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "EXEC vw_clientlist @company_name = @company_name"

            cmd.CommandText = strQuery
            cmd.Parameters.AddWithValue("company_name", txt_01.Text.Trim)
            dt = GetData(cmd)

            If dt.Rows.Count > 0 Then
                Dim i As Integer = dt.Rows.Count - 1
                ShipGenId = dt.Rows(i).Item(0)
                ShipAcctNo = dt.Rows(i).Item(1)
            Else
                ShipGenId = Nothing
                ShipAcctNo = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Orig_DropDown(sender As Object, e As EventArgs) Handles cbo_Orig.DropDown
        OrigDest("OrigDestItem")
    End Sub

    Private Sub cbo_Dest_DropDown(sender As Object, e As EventArgs) Handles cbo_Dest.DropDown
        OrigDest("OrigDestItem")
    End Sub

    Sub SelectLoad()
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
        SelectLoad()
    End Sub
    Sub Computation4DimDum()
        Try
            Dim TotalPc As Integer = 0
            Dim TotalDim As Double = 0
            For index As Integer = 0 To dgv_DimensionDummy.Rows.Count - 1
                dgv_DimensionDummy.Item(6, index).Value = (dgv_DimensionDummy(2, index).Value * dgv_DimensionDummy(3, index).Value * dgv_DimensionDummy(4, index).Value) / ServiceDiv * dgv_DimensionDummy(5, index).Value
                TotalPc += dgv_DimensionDummy.Item(4, index).Value
                TotalDim += dgv_DimensionDummy.Item(5, index).Value
            Next
            lbl_TotalQty.Text = TotalPc
            lbl_TotalVol.Text = TotalDim.ToString("0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Computation()
        Try
            Dim TotalPc As Integer = 0
            Dim TotalDim As Double = 0
            For index As Integer = 0 To dgv_Dimension.Rows.Count - 1
                dgv_Dimension.Item(4, index).Value = (dgv_Dimension(0, index).Value * dgv_Dimension(1, index).Value * dgv_Dimension(2, index).Value) / ServiceDiv * dgv_Dimension(3, index).Value
                TotalPc += dgv_Dimension.Item(3, index).Value
                TotalDim += dgv_Dimension.Item(4, index).Value
            Next
            lbl_TotalQty.Text = TotalPc
            lbl_TotalVol.Text = TotalDim.ToString("0.000")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub SelectServ()
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
        SelectServ()
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
    Sub SelectFr()
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
        SelectFr()
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
    Private Sub cbo_Loading_DropDown(sender As Object, e As EventArgs) Handles cbo_Loading.DropDown
        Loading("LoadingItem")
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

    Private Sub cbo_Service_DropDown(sender As Object, e As EventArgs) Handles cbo_Service.DropDown
        Service("ServiceItem")
    End Sub

    Private Sub cbo_Freight_DropDown(sender As Object, e As EventArgs) Handles cbo_Freight.DropDown
        Freight("FreightItem")
    End Sub

    Sub Freight(ByVal u As String)

        Try
            strQuery = "SELECT freightmode FROM tbl_freightmode
                        WHERE cat LIKE 'Ops'"

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

    Private Sub cbo_Pay_DropDown(sender As Object, e As EventArgs) Handles cbo_Pay.DropDown
        Pay("PaymodeItem")
    End Sub

    Sub SelectUnit()
        Try
            strQuery = "SELECT id, description FROM tbl_uom
                        WHERE code LIKE '" & cbo_Uom.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                UomId = dt.Rows(dt.Rows.Count - 1).Item(0)
                lbl_UomDesc.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
            Else
                UomId = Nothing
                lbl_UomDesc.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Uom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Uom.SelectedIndexChanged

    End Sub

    Private Sub dgv_Dimension_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellContentClick

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

    Private Sub dtp_Date_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Date.ValueChanged
        Try
            dtpShipDateWalkIn = dtp_Date.Value.Date
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Type_DropDown(sender As Object, e As EventArgs) Handles cbo_Type.DropDown
        CommodityType("CommodityTypeItem")
    End Sub

    Private Sub rb_01_CheckedChanged(sender As Object, e As EventArgs) Handles rb_01.CheckedChanged
        If rb_01.Checked = True Then
            tcode = rb_01.Text
            txt_02.Text = Nothing
            txt_01.Visible = True
            txt_02.Visible = False
        End If
    End Sub

    Private Sub MetroPanel9_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel9.Paint

    End Sub

    Private Sub txt_01_Click(sender As Object, e As EventArgs) Handles txt_01.Click

    End Sub

    Private Sub rb_02_CheckedChanged(sender As Object, e As EventArgs) Handles rb_02.CheckedChanged
        If rb_02.Checked = True Then
            tcode = rb_02.Text
            txt_01.Text = Nothing
            ShipGenId = Nothing
            txt_01.Visible = False
            txt_02.Visible = True
        End If
    End Sub

    Sub SelectDest()
        Try
            strQuery = "SELECT id, location_code 
                        FROM location_list 
                        WHERE location_area LIKE '" & cbo_Dest.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                DestId = dt.Rows(dt.Rows.Count - 1).Item(0)
                DestCode = dt.Rows(dt.Rows.Count - 1).Item(1)
            Else
                DestId = Nothing
                DestCode = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Dest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Dest.SelectedIndexChanged
        SelectDest()
    End Sub

    Sub SelectOrig()
        Try
            strQuery = "SELECT id, location_code 
                        FROM location_list 
                        WHERE location_area LIKE '" & cbo_Orig.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                OrigId = dt.Rows(dt.Rows.Count - 1).Item(0)
                OrigCode = dt.Rows(dt.Rows.Count - 1).Item(1)
            Else
                OrigId = Nothing
                OrigCode = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Orig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Orig.SelectedIndexChanged
        SelectOrig()
    End Sub

    Sub hwb_details()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            If cbo_Pay.Text = "PREPAID" Or cbo_Pay.Text = "COLLECT" Then
                If tcode = rb_01.Text Then
                    strQuery = "INSERT INTO hwb_details (hwb_no, 
                                                 account_number,
                                                 company_name,
                                                 origin, 
                                                 destination,
                                                 datecreated,
                                                 mode_of_payment,
                                                 freight,
                                                 valuation,
                                                 insurance,
                                                 waybillfee,
                                                 permits,
                                                 handling,
                                                 pickup,
                                                 deliveryoda,
                                                 crafting,
                                                 packing, 
                                                 others,
                                                 subtotal,
                                                 vat,
                                                 grandtotal,
                                                 billing_status,
                                                 collection_status,
                                                 commodity,
                                                 shipdate)
                                        VALUES
                                                ('" & HWBCtrlNoWalkIn & "',
                                                 '" & ShipAcctNo & "',
                                                 '" & txt_01.Text & "',
                                                 '" & OrigCode & "',
                                                 '" & DestCode & "',
                                                 '" & dtp_Date.Value.Date & "',
                                                 '" & cbo_Pay.Text & "',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 'CLOSED',
                                                 'OPEN',
                                                 '" & txt_Commodity.Text & "',
                                                 '" & dtp_Date.Value.Date & "')"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                ElseIf tcode = rb_02.Text Then
                    strQuery = "INSERT INTO hwb_details (hwb_no, 
                                                 account_number,
                                                 company_name,
                                                 origin, 
                                                 destination,
                                                 datecreated,
                                                 mode_of_payment,
                                                 freight,
                                                 valuation,
                                                 insurance,
                                                 waybillfee,
                                                 permits,
                                                 handling,
                                                 pickup,
                                                 deliveryoda,
                                                 crafting,
                                                 packing, 
                                                 others,
                                                 subtotal,
                                                 vat,
                                                 grandtotal,
                                                 billing_status,
                                                 collection_status,
                                                 commodity,
                                                 shipdate)
                                        VALUES
                                                ('" & HWBCtrlNoWalkIn & "',
                                                 '" & tcode & "',
                                                 '" & txt_02.Text & "',
                                                 '" & OrigCode & "',
                                                 '" & DestCode & "',
                                                 '" & dtp_Date.Value.Date & "',
                                                 '" & cbo_Pay.Text & "',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 'CLOSED',
                                                 'OPEN',
                                                 '" & txt_Commodity.Text & "',
                                                 '" & dtp_Date.Value.Date & "')"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If
            Else
                If tcode = rb_01.Text Then
                    strQuery = "INSERT INTO hwb_details (hwb_no, 
                                                 account_number,
                                                 company_name,
                                                 origin, 
                                                 destination,
                                                 datecreated,
                                                 mode_of_payment,
                                                 freight,
                                                 valuation,
                                                 insurance,
                                                 waybillfee,
                                                 permits,
                                                 handling,
                                                 pickup,
                                                 deliveryoda,
                                                 crafting,
                                                 packing, 
                                                 others,
                                                 subtotal,
                                                 vat,
                                                 grandtotal,
                                                 billing_status,
                                                 collection_status,
                                                 commodity,
                                                 shipdate)
                                        VALUES
                                                ('" & HWBCtrlNoWalkIn & "',
                                                 '" & ShipAcctNo & "',
                                                 '" & txt_01.Text & "',
                                                 '" & OrigCode & "',
                                                 '" & DestCode & "',
                                                 '" & dtp_Date.Value.Date & "',
                                                 '" & cbo_Pay.Text & "',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 'OPEN',
                                                 'OPEN',
                                                 '" & txt_Commodity.Text & "',
                                                 '" & dtp_Date.Value.Date & "')"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                ElseIf tcode = rb_02.Text Then
                    strQuery = "INSERT INTO hwb_details (hwb_no, 
                                                 account_number,
                                                 company_name,
                                                 origin, 
                                                 destination,
                                                 datecreated,
                                                 mode_of_payment,
                                                 freight,
                                                 valuation,
                                                 insurance,
                                                 waybillfee,
                                                 permits,
                                                 handling,
                                                 pickup,
                                                 deliveryoda,
                                                 crafting,
                                                 packing, 
                                                 others,
                                                 subtotal,
                                                 vat,
                                                 grandtotal,
                                                 billing_status,
                                                 collection_status,
                                                 commodity,
                                                 shipdate)
                                        VALUES
                                                ('" & HWBCtrlNoWalkIn & "',
                                                 '" & tcode & "',
                                                 '" & txt_02.Text & "',
                                                 '" & OrigCode & "',
                                                 '" & DestCode & "',
                                                 '" & dtp_Date.Value.Date & "',
                                                 '" & cbo_Pay.Text & "',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 '0.00',
                                                 'OPEN',
                                                 'OPEN',
                                                 '" & txt_Commodity.Text & "',
                                                 '" & dtp_Date.Value.Date & "')"
                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub txt_DeclaredValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_DeclaredValue.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub
    Private Sub txt_TotalWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Weight.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Sub Unit(ByVal u As String)

        Try
            strQuery = "SELECT code FROM tbl_uom"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "UnitItem") Then
                cbo_Uom.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "UnitItem") Then
                    cbo_Uom.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbo_Uom_DropDown(sender As Object, e As EventArgs) Handles cbo_Uom.DropDown
        Unit("UnitItem")
    End Sub

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Private Sub dgv_Dimension_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellEndEdit
        Computation()
    End Sub

    Private Sub dgv_DimensionDummy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DimensionDummy.CellContentClick

    End Sub

    Private Sub ReprintToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Try
            Reprint.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        upd_DimensionDummy()
    End Sub

    Private Sub txt_DeclaredValue_Click(sender As Object, e As EventArgs) Handles txt_DeclaredValue.Click

    End Sub

    Private Sub txt_hwbno_Click(sender As Object, e As EventArgs) Handles txt_hwbno.Click

    End Sub

    Private Sub dgv_Dimension_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Dimension.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Dimension.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Dimension.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Dimension.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Orig_TextChanged(sender As Object, e As EventArgs) Handles cbo_Orig.TextChanged
        SelectOrig()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Dest_TextChanged(sender As Object, e As EventArgs) Handles cbo_Dest.TextChanged
        SelectDest()
    End Sub

    Private Sub cbo_Carrier_TextChanged(sender As Object, e As EventArgs) Handles cbo_Carrier.TextChanged
        SelectCar()
    End Sub

    Private Sub cbo_Loading_TextChanged(sender As Object, e As EventArgs) Handles cbo_Loading.TextChanged
        SelectLoad()
    End Sub

    Private Sub cbo_Service_TextChanged(sender As Object, e As EventArgs) Handles cbo_Service.TextChanged
        SelectServ()
    End Sub

    Private Sub cbo_Pay_TextChanged(sender As Object, e As EventArgs) Handles cbo_Pay.TextChanged
        SelectPay()
    End Sub

    Private Sub cbo_Freight_TextChanged(sender As Object, e As EventArgs) Handles cbo_Freight.TextChanged
        SelectFr()
    End Sub

    Private Sub cbo_Type_TextChanged(sender As Object, e As EventArgs) Handles cbo_Type.TextChanged
        SelectType()
    End Sub

    Private Sub cbo_Uom_TextChanged(sender As Object, e As EventArgs) Handles cbo_Uom.TextChanged
        SelectUnit()
    End Sub

    Sub GetDimension()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT * FROM vw_dimension
                        WHERE hwb_no LIKE '" & HWBs & "'"
            cmd.CommandText = strQuery
            dt = GetData(cmd)

            dgv_Dimension.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub SearchDim()
        Try
            strQuery = "SELECT dim_id,
                               so_id,
                               length as 'L', 
                               width as 'W', 
                               height as 'H', 
                               quantity as 'Qty',
                               volume as 'Vol'
                        FROM vw_dimension_so
                        WHERE hwb_no LIKE '" & HWBs & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            DimId = dt.Rows(dt.Rows.Count - 1).Item(0)
            SOId = dt.Rows(dt.Rows.Count - 1).Item(1)
            dgv_DimensionDummy.DataSource = dt
            dgv_DimensionDummy.Columns(0).Visible = False
            dgv_DimensionDummy.Columns(1).Visible = False
            dgv_Dimension.Visible = False
            dgv_DimensionDummy.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable
            Dim letter As String

            If e.KeyCode = Keys.Enter Then
                letter = txt_Search.Text.Substring(0, 3)
                HWBs = letter + txt_Search.Text.Remove(0, 3).PadLeft(10, "0")

                strQuery = "SELECT * FROM vw_serviceorder
                            WHERE hwb_no LIKE '" & HWBs & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)

                If dt.Rows.Count > 0 Then
                    Modify = True
                    txt_hwbno.Text = dt.Rows(dt.Rows.Count - 1).Item(2)
                    tcode = dt.Rows(dt.Rows.Count - 1).Item(3)
                    If tcode = rb_01.Text Then
                        rb_01.Checked = True
                        txt_01.Visible = True
                        txt_02.Visible = False
                        ShipAcctNo = dt.Rows(dt.Rows.Count - 1).Item(5)
                        txt_01.Text = dt.Rows(dt.Rows.Count - 1).Item(6)
                    ElseIf tcode = rb_02.Text Then
                        rb_02.Checked = True
                        txt_01.Visible = False
                        txt_02.Visible = True
                        txt_02.Text = dt.Rows(dt.Rows.Count - 1).Item(7)
                    End If
                    dtp_Date.Value = dt.Rows(dt.Rows.Count - 1).Item(4)
                    txt_Ship_Phone.Text = dt.Rows(dt.Rows.Count - 1).Item(8)
                    txt_Consignee.Text = dt.Rows(dt.Rows.Count - 1).Item(9)
                    txt_Address.Text = dt.Rows(dt.Rows.Count - 1).Item(10)
                    txt_Con_Phone.Text = dt.Rows(dt.Rows.Count - 1).Item(11)
                    cbo_Orig.Text = dt.Rows(dt.Rows.Count - 1).Item(12)
                    cbo_Dest.Text = dt.Rows(dt.Rows.Count - 1).Item(13)
                    cbo_Loading.Text = dt.Rows(dt.Rows.Count - 1).Item(14)
                    cbo_Service.Text = dt.Rows(dt.Rows.Count - 1).Item(15)
                    cbo_Pay.Text = dt.Rows(dt.Rows.Count - 1).Item(16)
                    cbo_Freight.Text = dt.Rows(dt.Rows.Count - 1).Item(17)
                    cbo_Type.Text = dt.Rows(dt.Rows.Count - 1).Item(18)
                    cbo_Uom.Text = dt.Rows(dt.Rows.Count - 1).Item(19)
                    txt_Commodity.Text = dt.Rows(dt.Rows.Count - 1).Item(20)
                    txt_DeclaredValue.Text = dt.Rows(dt.Rows.Count - 1).Item(21)
                    txt_Weight.Text = dt.Rows(dt.Rows.Count - 1).Item(22)
                    txt_SpeIns.Text = dt.Rows(dt.Rows.Count - 1).Item(23)

                    SearchDim()
                    Computation4DimDum()
                Else
                    MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    clear()
                    Modify = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_DimensionDummy_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_DimensionDummy.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_DimensionDummy.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_DimensionDummy.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_DimensionDummy.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_DimensionDummy_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DimensionDummy.CellEndEdit
        Computation4DimDum()
    End Sub

    Private Sub txt_hwbno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_hwbno.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub
End Class