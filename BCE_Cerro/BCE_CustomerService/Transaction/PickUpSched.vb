
Imports System.Configuration
Imports System.IO
Imports System
Imports System.Net
Imports System.Net.Mail
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.Web
Imports EASendMail
Public Class PickUpSched
    Dim AddNew, ShipPickupEmail, PickupAddress, ConPer As String
    Dim ComTypeId, ShipBrgyId, ConBrgyId, ShipGenId, ConGenId, OrigId, LoadingId, ServiceId, PayId, FreightId, LocationId, UomId, ServiceDiv As Integer
    Dim StrPath As String = ""
    Dim tablocked As Boolean = True
    Dim rindex As Integer
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


    Private Sub txt_AssignedTo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Sub clear()
        txt_Ship_Company.Text = Nothing
        dgv_Origin.DataSource = Nothing
        cbo_Loading.SelectedItem = Nothing
        cbo_Service.SelectedItem = Nothing
        cbo_Pay.SelectedItem = Nothing
        cbo_Freight.SelectedItem = Nothing
        cbo_Origin.SelectedItem = Nothing
        cbo_Type.SelectedItem = Nothing
        txt_Commodity.Text = Nothing
        txt_DeclaredValue.Text = Nothing
        txt_SpeIns.Text = Nothing
        txt_TotalWeight.Text = Nothing
        pb_Cargo.Image = Nothing
        dgv_Dimension.Rows.Clear()
        lbl_TotalQty.Text = Nothing
        lbl_TotalVol.Text = Nothing
        tablocked = False
        mtc_Pickup.SelectedIndex = 0
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Address_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Origin.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Origin.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Origin.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AddRowsDimension()
        Try
            dgv_Dimension.Rows.Clear()
            dgv_Dimension.Rows.Add(10)
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

    Private Sub PickUpSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConShipCompAutoCom()
        AddRowsDimension()
    End Sub

    Sub ConShipCompAutoCom()
        Try
            strQuery = "SELECT company_name FROM bp_general
                        WHERE company_name LIKE '%" & txt_Ship_Company.Text & "%'"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            txt_Ship_Company.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_Ship_Company.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_Ship_Company.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("company_name"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function getImagePath() As String
        Dim dlg As New OpenFileDialog()
        Dim Img As Image
        dlg.Filter = "Jpeg Files|*.jpg|All Files|*.*"
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            StrPath = dlg.FileName.ToString
            Img = New Bitmap(Bitmap.FromFile(StrPath))
            pb_Cargo.Image = Img
        End If
        Return StrPath
    End Function

    Sub ShowImage(strPath As String)
        If System.IO.File.Exists(strPath) Then
            Dim Img As Image
            Img = New Bitmap(Bitmap.FromFile(strPath))
            pb_Cargo.Image = Img
        End If
    End Sub

    Private Sub Ml_attached_Click(sender As Object, e As EventArgs) Handles ml_attached.Click
        getImagePath()
    End Sub

    Private Sub cbo_Type_DropDown(sender As Object, e As EventArgs) Handles cbo_Type.DropDown
        CommodityType("CommodityTypeItem")
    End Sub

    Private Sub Cbo_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Type.SelectedIndexChanged
        Try
            strQuery = "SELECT id FROM tbl_commoditytype
                        WHERE name LIKE '" & cbo_Type.SelectedItem & "'"

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

    Sub Search_ship_ComInd()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "EXEC vw_clientlist @company_name = @company_name"

            cmd.CommandText = strQuery
            cmd.Parameters.AddWithValue("company_name", txt_Ship_Company.Text.Trim)
            dt = GetData(cmd)

            If dt.Rows.Count > 0 Then
                Dim i As Integer = dt.Rows.Count - 1
                ShipGenId = dt.Rows(i).Item(0)
            Else
                ShipGenId = Nothing
            End If
            Search_ship_add()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Search_ship_add()
        Try
            strQuery = "SELECT contactperson as 'Contact Person',
                            CONCAT(no_street_etc, ' ',
                                   zipcode) as 'Address',
                            phone as 'Phone',
                            email as 'Email',
                            id
                            FROM vw_cs_pickuporig
                            WHERE company_name LIKE '" & txt_Ship_Company.Text.Trim & "'"
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
    Private Sub txt_Ship_Company_TextChanged(sender As Object, e As EventArgs) Handles txt_Ship_Company.TextChanged
        Search_ship_ComInd()
    End Sub

    Private Sub txt_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ship_phone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Sub clear_ship_pickupadd()
        txt_ship_zip.Text = Nothing
        txt_ship_street.Text = Nothing
        txt_ship_contact.Text = Nothing
        txt_ship_phone.Text = Nothing
        txt_ship_email.Text = Nothing
        pnl_ship_selectadd.Visible = True
        pnl_ship_newadd.Visible = False
    End Sub

    Private Sub Btn_shipadd_submit_Click(sender As Object, e As EventArgs) Handles btn_shipadd_submit.Click
        Try
            If txt_ship_zip.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have ZIP Code", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_ship_street.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have No., Street, Building, Floor, Unit, etc.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_ship_contact.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Contact Person", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_ship_contact.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Phone", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf ShipGenId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Company or Individual", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "EXEC ins_cs_pickuporig @gen_id = @gen_id,
                                               @no_street_etc = @no_street_etc,
                                               @zipcode = @zipcode,
                                               @contactperson = @contactperson,
                                               @phone = @phone,
                                               @email = @email,
                                               @employeeid = @employeeid,
                                               @datecreated = @datecreated"
                Dim cmd As New SqlCommand(strQuery)
                cmd.Parameters.AddWithValue("gen_id", ShipGenId)
                cmd.Parameters.AddWithValue("no_street_etc", txt_ship_street.Text.ToUpper)
                cmd.Parameters.AddWithValue("zipcode", txt_ship_zip.Text)
                cmd.Parameters.AddWithValue("contactperson", txt_ship_contact.Text.ToUpper)
                cmd.Parameters.AddWithValue("phone", txt_ship_phone.Text)
                cmd.Parameters.AddWithValue("email", txt_ship_email.Text)
                cmd.Parameters.AddWithValue("employeeid", emplid)
                cmd.Parameters.AddWithValue("datecreated", Date.Today)
                Dim dt As DataTable = GetData(cmd)

                MetroMessageBox.Show(BCEParent, "Pickup Address has been successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear_ship_pickupadd()
                Search_ship_add()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Lbl_ship_newadd_Click(sender As Object, e As EventArgs) Handles lbl_ship_newadd.Click
        Try
            pnl_ship_selectadd.Visible = False
            pnl_ship_newadd.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dgv_Origin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Origin.CellContentClick

    End Sub

    Private Sub Btn_shipadd_cancel_Click(sender As Object, e As EventArgs) Handles btn_shipadd_cancel.Click
        Try
            pnl_ship_selectadd.Visible = True
            pnl_ship_newadd.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ml_clear_Click(sender As Object, e As EventArgs) Handles ml_clear.Click
        Try
            pb_Cargo.Image = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Origin_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Origin.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Origin.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Origin.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Origin.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Origin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Origin.CellClick
        Try
            rindex = e.RowIndex
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
                For Each row As DataGridViewRow In dgv_Origin.Rows
                    If row.Index = e.RowIndex Then
                        row.Cells(0).Value = Not Convert.ToBoolean(row.Cells(0).EditedFormattedValue)
                    Else
                        row.Cells(0).Value = False
                    End If
                Next
            End If

            If e.ColumnIndex = 1 Then
                Dim obb As New Mod_PickupAdd
                obb.origid = dgv_Origin.Item(6, rindex).Value
                obb.txt_ConPer.Text = dgv_Origin.Item(2, rindex).Value
                obb.txt_Add.Text = dgv_Origin.Item(3, rindex).Value
                obb.txt_Phone.Text = dgv_Origin.Item(4, rindex).Value
                obb.txt_Email.Text = dgv_Origin.Item(5, rindex).Value
                obb.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_ship_zip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ship_zip.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txt_con_zip_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txt_con_phone_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txt_DeclaredValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_DeclaredValue.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txt_TotalWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TotalWeight.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txt_length_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txt_width_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txt_height_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub Cbo_Loading_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Loading.SelectedIndexChanged
        Try
            strQuery = "SELECT id FROM tbl_loadingmode
                        WHERE loadingmode LIKE '" & cbo_Loading.SelectedItem & "'"

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

    <Obsolete>
    Sub ShipperEmailSend()

        '    SysLoading.MdiParent = BCEParent
        '    SysLoading.BringToFront()
        '    SysLoading.Show()

        '    Await Task.Run(Sub()
        Try
            Dim email As String = ShipPickupEmail

            Dim oMail As New SmtpMail("TryIt")
            oMail.From = New EASendMail.MailAddress("BossCargoExpress", ConfigurationSettings.AppSettings("Username"))
            oMail.To = email & ";" & "raffy.r@bosscargo.express; fernando.f@bosscargo.express"
            oMail.Subject = "Pickup Schedule"
            oMail.HtmlBody = "<p style=text-align:left>Hi Mr./Ms. " & ConPer & ",
                                          <br>
                                          <br>Your cargo has been successfully booked for pickup with the following details:
                                          <br>
                                          <br>Pickup Date/Time      : " & dtp_pickupdate.Value.Date + dtp_pickuptime.Value.TimeOfDay & "
                                          <br>
                                          <br>Loading Mode          : " & cbo_Loading.Text & "
                                          <br>Service Mode          : " & cbo_Service.Text & "
                                          <br>Pay Mode              : " & cbo_Pay.Text & "
                                          <br>Freight Mode          : " & cbo_Freight.Text & "
                                          <br>Commodity Type        : " & cbo_Type.Text & "
                                          <br>Declared Value        : " & txt_DeclaredValue.Text & "
                                          <br>UOM                   : " & cbo_Uom.Text & "
                                          <br>Weight                : " & txt_TotalWeight.Text & "
                                          <br>Special Instruction   : " & cbo_Uom.Text & "
                                          <br>
                                          <br>This is a system generated message. Do not reply.
                                          <br>
                                          <br>-Boss Cargo Express </p>"

            Dim oServer As New SmtpServer(ConfigurationSettings.AppSettings("Host"))
            oServer.User = ConfigurationSettings.AppSettings("Username")
            oServer.Password = ConfigurationSettings.AppSettings("Password")
            oServer.ConnectType = SmtpConnectType.ConnectTryTLS
            oServer.Port = 587
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

            Dim oSmtp As New EASendMail.SmtpClient()
            oSmtp.SendMail(oServer, oMail)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'End Sub)
    End Sub

    Sub AddDimension()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT MAX(id) FROM tbl_cs_pickupsched"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            If dt.Rows.Count > 0 Then
                Dim PickupschedId As Integer = dt.Rows(dt.Rows.Count - 1).Item(0)

                For i = 0 To dgv_Dimension.Rows.Count - 1
                    If dgv_Dimension.Item(0, i).Value <> Nothing Then
                        strQuery = "EXEC ins_dimension_est @type = 'ESTIMATED',
                                                       @pickupsched_id = '" & PickupschedId & "',
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

    Sub SelectPickupAdd()
        Try
            For Each row As DataGridViewRow In dgv_Origin.Rows
                If row.Cells(0).Value = True Then
                    PickupAddress = row.Cells(3).Value
                    'ShipPickupEmail = row.Cells(5).Value
                    OrigId = row.Cells(6).Value
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cbo_Service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Service.SelectedIndexChanged
        Try
            strQuery = "SELECT id, servicedivisor FROM tbl_servicemode
                        WHERE servicemode LIKE '" & cbo_Service.SelectedItem & "'"

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

    Private Sub cbo_Service_DropDown(sender As Object, e As EventArgs) Handles cbo_Service.DropDown
        Service("ServiceItem")
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

    Private Sub Btn_ShipmentBack_Click(sender As Object, e As EventArgs) Handles btn_ShipmentBack.Click
        Try
            tablocked = False
            mtc_Pickup.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cbo_Uom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Uom.SelectedIndexChanged
        Try
            strQuery = "SELECT id, description FROM tbl_uom
                        WHERE code LIKE '" & cbo_Uom.SelectedItem & "'"

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

    Private Sub Cbo_Pay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Pay.SelectedIndexChanged
        Try
            strQuery = "SELECT id FROM tbl_paymode
                        WHERE paymode LIKE '" & cbo_Pay.SelectedItem & "'"

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

    Private Sub Btn_ShipNext_Click(sender As Object, e As EventArgs) Handles btn_ShipperNext.Click
        Try
            SelectPickupAdd()
            If ShipGenId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Client", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf OrigId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Pickup Address", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                tablocked = False
                ConPer = dgv_Origin.Item(2, rindex).Value
                ShipPickupEmail = dgv_Origin.Item(5, rindex).Value
                mtc_Pickup.SelectedIndex = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cbo_Origin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Origin.SelectedIndexChanged
        Try
            strQuery = "SELECT id, location_code 
                        FROM location_list 
                        WHERE location_area LIKE '" & cbo_Origin.SelectedItem & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                LocationId = dt.Rows(dt.Rows.Count - 1).Item(0)
                lbl_Code.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
            Else
                LocationId = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_paymode_DropDown(sender As Object, e As EventArgs) Handles cbo_Pay.DropDown
        Pay("PaymodeItem")
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

    Private Sub Cbo_Freight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Freight.SelectedIndexChanged
        Try
            strQuery = "SELECT id FROM tbl_freightmode
                        WHERE freightmode LIKE '" & cbo_Freight.SelectedItem & "'"

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

    Private Sub btn_ReviewBack_Click(sender As Object, e As EventArgs)
        Try
            tablocked = False
            mtc_Pickup.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Dimension_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellContentClick

    End Sub

    Private Sub txt_Ship_Company_Click(sender As Object, e As EventArgs) Handles txt_Ship_Company.Click

    End Sub

    Private Sub txt_DeclaredValue_Click(sender As Object, e As EventArgs) Handles txt_DeclaredValue.Click

    End Sub

    <Obsolete>
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable


            If cbo_Loading.SelectedItem = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Loading Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf cbo_Service.SelectedItem = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Service Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf cbo_Pay.SelectedItem = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Pay Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf cbo_Freight.SelectedItem = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Freight Mode", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf cbo_Type.SelectedItem = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Commodity Type", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_Commodity.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Commodity Description", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_TotalWeight.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Total Weight", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf dgv_Dimension.Rows.Count = 1 Then
                MetroMessageBox.Show(BCEParent, "Must have Dimension", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf lbl_TotalQty.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Quantity", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf LocationId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Origin", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ShipperEmailSend()
                SelectPickupAdd()

                strQuery = "EXEC ins_cs_pickupsched @datereq = @datereq,
                                                @orig_id = @orig_id, 
                                                @loading_id = @loading_id,
                                                @service_id = @service_id,
                                                @pay_id = @pay_id,
                                                @freight_id = @freight_id,
                                                @location_id = @location_id,
                                                @pickup = @pickup,
                                                @unit_id = @unit_id,
                                                @qty = @qty,
                                                @weight = @weight,
                                                @com_id = @com_id,
                                                @commodity = @commodity,
                                                @com_image = @com_image,
                                                @declaredvalue = @declaredvalue,
                                                @specialinstruction = @specialinstruction,
                                                @status = @status,
                                                @employeeid = @employeeid,
                                                @datecreated = @datecreated"
                cmd.CommandText = strQuery
                cmd.Parameters.AddWithValue("datereq", Date.Now.Date)
                cmd.Parameters.AddWithValue("orig_id", OrigId)
                cmd.Parameters.AddWithValue("loading_id", LoadingId)
                cmd.Parameters.AddWithValue("service_id", ServiceId)
                cmd.Parameters.AddWithValue("pay_id", PayId)
                cmd.Parameters.AddWithValue("freight_id", FreightId)
                cmd.Parameters.AddWithValue("location_id", LocationId)
                cmd.Parameters.AddWithValue("pickup", dtp_pickupdate.Value.Date + dtp_pickuptime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("unit_id", UomId)
                cmd.Parameters.AddWithValue("qty", lbl_TotalQty.Text)
                cmd.Parameters.AddWithValue("weight", txt_TotalWeight.Text)
                cmd.Parameters.AddWithValue("com_id", ComTypeId)
                cmd.Parameters.AddWithValue("commodity", txt_Commodity.Text.ToUpper)
                cmd.Parameters.AddWithValue("com_image", StrPath)
                cmd.Parameters.AddWithValue("declaredvalue", txt_DeclaredValue.Text)
                cmd.Parameters.AddWithValue("specialinstruction", txt_SpeIns.Text.ToUpper)
                cmd.Parameters.AddWithValue("status", "OPEN")
                cmd.Parameters.AddWithValue("employeeid", emplid)
                cmd.Parameters.AddWithValue("datecreated", Date.Now)
                dt = GetData(cmd)

                AddDimension()
                SysLoading.Hide()
                MetroMessageBox.Show(BCEParent, "Pickup schedule has been successfully set", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                AddRowsDimension()
            End If
        Catch ex As Exception
            MsgBox("Pick up schedule failed to set due to" & ex.Message)
        End Try
    End Sub

    Private Sub cbo_Freight_DropDown(sender As Object, e As EventArgs) Handles cbo_Freight.DropDown
        Freight("FreightItem")
    End Sub

    Sub Freight(ByVal u As String)

        Try
            strQuery = "SELECT freightmode FROM tbl_freightmode
                        WHERE cat LIKE 'CS'"

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

    Private Sub dgv_Dimension_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Dimension.CellEndEdit
        Computation()
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

    Private Sub PickUpSched_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub cbo_Uom_DropDown(sender As Object, e As EventArgs) Handles cbo_Uom.DropDown
        Unit("UnitItem")
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

    Private Sub cbo_Origin_DropDown(sender As Object, e As EventArgs) Handles cbo_Origin.DropDown
        Origin("OriginItem")
    End Sub

    Sub mtc_Pickup_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles mtc_Pickup.Selecting
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

    Private Sub mtp_shipper_Enter(sender As Object, e As EventArgs) Handles mtp_shipper.Enter
        Try
            tablocked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mtp_shipment_Enter(sender As Object, e As EventArgs) Handles mtp_shipment.Enter
        Try
            tablocked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
