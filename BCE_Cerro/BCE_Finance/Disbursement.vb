Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports CrystalDecisions.CrystalReports.Engine

Public Class Disbursement
    Dim cbocol As New DataGridViewComboBoxColumn
    Dim cbocell As DataGridViewComboBoxCell
    Dim BankId, HCount, ChartId As Integer
    Dim HControlNo As String
    Dim debit, credit, deb, cre, totalamt As Double
    Dim rptdoc As ReportDocument
    Dim UpsertCost As Boolean

    Private Sub dgv_Dimension_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Disbursement.CellContentClick
        Try
            Dim index As Integer
            index = dgv_Disbursement.CurrentCell.RowIndex
            dgv_Disbursement.Rows.RemoveAt(index)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_Dimension_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_Disbursement.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_Disbursement.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_Disbursement.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_Disbursement.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Disbursement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlNo()
        DescAutoCom()
        PayeeAutoCom()
        AmtAutoCom()
        PartAutoCom()
    End Sub
    Sub DescAutoCom()
        Try
            strQuery = "SELECT description FROM tbl_chart
                        WHERE description LIKE '%" & txt_Desc.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            txt_Desc.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_Desc.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_Desc.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("description"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PartAutoCom()
        Try
            strQuery = "SELECT particulars FROM tbl_header
                        WHERE particulars LIKE '%" & txt_particulars.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            txt_particulars.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_particulars.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_particulars.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("particulars"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub AmtAutoCom()
        Try
            strQuery = "SELECT amountno FROM tbl_header
                        WHERE amountno LIKE '%" & txt_amtno.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            txt_amtno.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_amtno.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_amtno.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("amountno"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PayeeAutoCom()
        Try
            strQuery = "SELECT payee FROM tbl_header
                        WHERE payee LIKE '%" & txt_Payee.Text & "%'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            txt_Payee.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_Payee.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_Payee.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)() Select CStr(row("payee"))).ToArray())

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub GetItem_Modified()
        Try
            conn("SELECT controlno,
                          bank,
                          checkseries,
                  FORMAT(date,'MM-dd-yyyy') as date,
                          payee,
                  REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','.00') as 'amountno',
                          amountwd,
                          particulars,
                          code,
                          description,
                  REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,debit),1), '.00','.00') as 'debit',
                  REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,credit),1), '.00','.00') as 'credit',
                          fullname,
                          immediatesuperior,
                  FORMAT(datecreated,'MM-dd-yyyy') as datecreated
                  FROM vw_CVPrint
                  WHERE controlno LIKE '" & txt_Search.Text & "'", "vw_CVPrint")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub GetItem()
        Try
            conn("SELECT controlno,
                          bank,
                          checkseries,
                  FORMAT(date,'MM-dd-yyyy') as date,
                          payee,
                  REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,amountno),1), '.00','.00') as 'amountno',
                          amountwd,
                          particulars,
                          code,
                          description,
                  REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,debit),1), '.00','.00') as 'debit',
                  REPLACE(CONVERT(VARCHAR,CONVERT(MONEY,credit),1), '.00','.00') as 'credit',
                          fullname,
                          immediatesuperior,
                  FORMAT(datecreated,'MM-dd-yyyy') as datecreated
                  FROM vw_CVPrint
                  WHERE count IN(SELECT MAX(count) FROM vw_CVPrint)", "vw_CVPrint")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub totaldebitcredit()
        Try
            Dim header As Integer

            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT header_id FROM tbl_details"
            cmd.CommandText = strQuery
            dt = GetData(cmd)

            If dt.Rows.Count > 0 Then
                header = dt.Rows(dt.Rows.Count - 1).Item(0)

                strQuery = "SELECT FORMAT(SUM(debit), N'N2') FROM tbl_details
                            WHERE header_id = '" & header & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)

                deb = dt.Rows(dt.Rows.Count - 1).Item(0)

                strQuery = "SELECT FORMAT(SUM(credit), N'N2') FROM tbl_details
                            WHERE header_id = '" & header & "'"
                cmd.CommandText = strQuery
                dt = GetData(cmd)

                cre = dt.Rows(dt.Rows.Count - 1).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CVSheet()
        Try
            Dim txt_deb, txt_cre As TextObject
            dssearch = New dsreport
            dasearch.Fill(dssearch, "dtCV")

            Select Case BankId
                Case Is = 1
                    rptdoc = New cr_BDO
                Case Is = 2
                    rptdoc = New cr_CB
            End Select

            rptdoc.SetDataSource(dssearch)
            txt_deb = rptdoc.ReportDefinition.ReportObjects("txt_deb")
            txt_deb.Text = deb.ToString("N2")
            txt_cre = rptdoc.ReportDefinition.ReportObjects("txt_cre")
            txt_cre.Text = cre.ToString("N2")

            crv_CV.ReportSource = rptdoc
            crv_CV.Zoom(75)
            crv_CV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CSheet()
        Try
            dssearch = New dsreport
            dasearch.Fill(dssearch, "dtCV")
            rptdoc = New cr_Check
            rptdoc.SetDataSource(dssearch)
            crv_C.ReportSource = rptdoc
            'crv_CV1.Zoom(75)
            crv_C.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clearP()
        UpsertCost = False
        txt_Search.Text = Nothing
        txt_Payee.Text = Nothing
        txt_amtno.Text = Nothing
        lbl_amtwd.Text = Nothing
        txt_particulars.Text = Nothing
        cbo_Bank.Text = Nothing
        BankId = Nothing
        lbl_Checkseries.Text = Nothing
        dgv_Disbursement.Rows.Clear()
        dgv_Disbursement.Visible = True
        dgv_dummy.Visible = False
        clearC()
    End Sub
    Sub clearC()
        cbo_Chart.Text = Nothing
        txt_Desc.Text = Nothing
        txt_Deb.Text = Nothing
        txt_Cre.Text = Nothing
    End Sub
    Sub ControlNo()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT ISNULL(MAX(count), 0) + 1
                        FROM tbl_header"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            HCount = dt.Rows(dt.Rows.Count - 1).Item(0)
            HControlNo = "BCEAP" + HCount.ToString("0000")
            lbl_ControlNo.Text = HControlNo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub BankSeries()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT bank_id FROM tbl_header
                        WHERE bank_id = '" & BankId & "'"

            cmd.CommandText = strQuery
            dt = GetData(cmd)
            If dt.Rows.Count > 0 Then
                strQuery = "SELECT ISNULL(MAX(checkseries), 0) + 1
                            FROM tbl_header
                            WHERE bank_id = '" & BankId & "'"
            Else
                strQuery = "SELECT ISNULL(MAX(checkseries), 0) + 1
                            FROM tbl_bank
                            WHERE id = '" & BankId & "'"
            End If

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            lbl_Checkseries.Text = dt.Rows(dt.Rows.Count - 1).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub AddChart(ByVal u As String)
        Try
            strQuery = "SELECT code FROM tbl_chart"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "Item") Then
                cbo_Chart.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "Item") Then
                    cbo_Chart.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Bank(ByVal u As String)
        Try
            strQuery = "SELECT bank FROM tbl_bank"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "Item") Then
                Me.cbo_Bank.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "Item") Then
                    cbo_Bank.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub test()
        Try
            With cbocol
                .HeaderText = "Chart"
            End With

            AddChart("Item")
            dgv_Disbursement.Columns.Clear()
            dgv_Disbursement.Columns.Insert(0, cbocol)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ttest(chart As String, desc As String, debit As String, credit As String)
        Dim row As String() = New String(3) {}
        row(0) = chart
        row(1) = desc
        row(2) = debit
        row(3) = credit
        dgv_Disbursement.Rows.Add(row)
    End Sub

    Private Sub lbl_Add_Click(sender As Object, e As EventArgs) Handles lbl_Add.Click
        Try
            If cbo_Chart.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Chart is not registered. Cannot add to the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txt_Deb.Text = Nothing And txt_Cre.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must need to have Debit or Credit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txt_Deb.Text = Nothing Then
                    txt_Deb.Text = 0
                ElseIf txt_Cre.Text = Nothing Then
                    txt_Cre.Text = 0
                End If
                Ttest(cbo_Chart.Text, txt_Desc.Text, txt_Deb.Text, txt_Cre.Text)
                clearC()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_Bank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Bank.SelectedIndexChanged
        If UpsertCost = True Then
            SelectBank()
            BankSeries_Modified()
        ElseIf UpsertCost = False Then
            SelectBank()
            BankSeries()
        End If
    End Sub

    Sub BankSeries_Modified()
        Try
            strQuery = "SELECT checkseries FROM vw_CVPrint
                        WHERE controlno LIKE '" & txt_Search.Text & "'
	                        AND bank LIKE '" & cbo_Bank.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                lbl_Checkseries.Text = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                lbl_Checkseries.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub SelectBank()
        Try
            strQuery = "SELECT id, checkseries FROM tbl_bank
                        WHERE bank LIKE '" & cbo_Bank.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                BankId = dt.Rows(dt.Rows.Count - 1).Item(0)
                lbl_Checkseries.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
            Else
                BankId = Nothing
                lbl_Checkseries.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Bank_DropDown(sender As Object, e As EventArgs) Handles cbo_Bank.DropDown
        Bank("Item")
    End Sub

    Private Sub dgv_Disbursement_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgv_Disbursement.DataError
        'Try
        '    If e.Exception.Message = "DatagridviewComboBoxCell value is not valid" Then
        '        Dim value As Object = dgv_Disbursement.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        '        If Not (CType(dgv_Disbursement.Columns(e.ColumnIndex), DataGridViewComboBoxColumn)).Items.Contains(value) Then
        '            CType(dgv_Disbursement.Columns(e.ColumnIndex), DataGridViewComboBoxColumn).Items.Add(value)
        '            e.ThrowException = False
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Sub SelectDesc()
        Try
            strQuery = "SELECT description FROM tbl_chart
                        WHERE code LIKE '" & cbo_Chart.Text & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                txt_Desc.Text = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                txt_Desc.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub AddDetails()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            strQuery = "SELECT MAX(id) FROM tbl_header"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            Dim HeaderId As Integer = dt.Rows(dt.Rows.Count - 1).Item(0)

            For Each row As DataGridViewRow In dgv_Disbursement.Rows
                strQuery = "SELECT id FROM tbl_chart
                            WHERE code = '" & row.Cells(0).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                Dim ChartId As Integer = dt.Rows(dt.Rows.Count - 1).Item(0)

                If row.Cells(2).Value = Nothing Then
                    row.Cells(2).Value = 0
                ElseIf row.Cells(3).Value = Nothing Then
                    row.Cells(3).Value = 0
                End If

                strQuery = "EXEC ins_details @header_id = '" & HeaderId & "',
                                             @chart_id = '" & ChartId & "',
                                             @debit = '" & row.Cells(2).Value & "',
                                             @credit = '" & row.Cells(3).Value & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_amtno_TextChanged(sender As Object, e As EventArgs) Handles txt_amtno.TextChanged
        Try
            If Val(txt_amtno.Text) > 0 Then
                lbl_amtwd.Text = ConvertCurrencyToEnglish(Val(txt_amtno.Text)) & " Only"
            Else
                lbl_amtwd.Text = Nothing
            End If
            totalamt = Val(txt_amtno.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_amtno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amtno.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub
    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Try
            CVList.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApprovalToolStripMenuItem.Click
        Try
            CVApproval.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Deb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Deb.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txt_Cre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cre.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ".") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txt_Desc_TextChanged(sender As Object, e As EventArgs) Handles txt_Desc.TextChanged
        SelectChart()
    End Sub

    Sub SelectChart()
        Try
            strQuery = "SELECT code FROM tbl_chart
                        WHERE description LIKE @description"

            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("description", txt_Desc.Text)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                cbo_Chart.SelectedItem = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                cbo_Chart.SelectedItem = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Chart.SelectedIndexChanged
        SelectDesc()
    End Sub
    Sub tally()
        Try
            Dim a As Double = 0
            Dim b As Double = 0

            For i As Integer = 0 To dgv_Disbursement.Rows.Count - 1
                deb += dgv_Disbursement.Item(2, i).Value
                cre += dgv_Disbursement.Item(3, i).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If txt_Payee.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Payee", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_amtno.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Amount in Figure", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txt_particulars.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have particulars", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'ElseIf cbo_Bank.Text = Nothing Then
                '    MetroMessageBox.Show(BCEParent, "Must have Bank", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf BankId = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Bank", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If UpsertCost = True Then
                    strQuery = "EXEC upd_disburseheader @controlno = @controlno,
                                                        @date = @date,
                                                        @payee = @payee,
                                                        @amountno = @amountno,
                                                        @amountwd = @amountwd,
                                                        @particulars = @particulars,
                                                        @status = @status"

                    cmd.CommandText = strQuery
                    cmd.Parameters.AddWithValue("controlno", txt_Search.Text)
                    cmd.Parameters.AddWithValue("date", dtp_date.Value.Date)
                    cmd.Parameters.AddWithValue("payee", txt_Payee.Text)
                    cmd.Parameters.AddWithValue("amountno", Val(txt_amtno.Text))
                    cmd.Parameters.AddWithValue("amountwd", lbl_amtwd.Text)
                    cmd.Parameters.AddWithValue("particulars", txt_particulars.Text)
                    cmd.Parameters.AddWithValue("status", "Save")
                    dt = GetData(cmd)

                    MetroMessageBox.Show(BCEParent, "Check Voucher has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetItem_Modified()
                    totaldebitcredit()
                    CVSheet()
                    ControlNo()
                    clearP()
                    dgv_Disbursement.Visible = True
                    dgv_dummy.Visible = False
                ElseIf UpsertCost = False Then
                    tally()
                    If deb <> cre Then
                        MetroMessageBox.Show(BCEParent, "Debit must be equal with Credit", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        strQuery = "EXEC ins_header @count = @count,
                                                    @controlno = @controlno,
                                                    @date = @date,
                                                    @payee = @payee,
                                                    @amountno = @amountno,
                                                    @amountwd = @amountwd,
                                                    @particulars = @particulars,
                                                    @bank_id = @bank_id,
                                                    @checkseries = @checkseries,
                                                    @status = @status,
                                                    @employeeid = @employeeid,
                                                    @datecreated = @datecreated"
                        cmd.CommandText = strQuery
                        cmd.Parameters.AddWithValue("count", HCount)
                        cmd.Parameters.AddWithValue("controlno", lbl_ControlNo.Text)
                        cmd.Parameters.AddWithValue("date", dtp_date.Value.Date)
                        cmd.Parameters.AddWithValue("payee", txt_Payee.Text)
                        cmd.Parameters.AddWithValue("amountno", Val(txt_amtno.Text))
                        cmd.Parameters.AddWithValue("amountwd", lbl_amtwd.Text)
                        cmd.Parameters.AddWithValue("particulars", txt_particulars.Text)
                        cmd.Parameters.AddWithValue("bank_id", BankId)
                        cmd.Parameters.AddWithValue("checkseries", lbl_Checkseries.Text)
                        cmd.Parameters.AddWithValue("status", "Save")
                        cmd.Parameters.AddWithValue("employeeid", emplid)
                        cmd.Parameters.AddWithValue("datecreated", Date.Now)
                        dt = GetData(cmd)

                        AddDetails()
                        MetroMessageBox.Show(BCEParent, "Check Voucher has been successfully save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetItem()
                        totaldebitcredit()
                        CVSheet()
                        ControlNo()
                        clearP()
                        dgv_Disbursement.Visible = True
                        dgv_dummy.Visible = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_dummy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dummy.CellContentClick
        Try
            Dim index As Integer
            index = dgv_dummy.CurrentCell.RowIndex
            dgv_dummy.Rows.RemoveAt(index)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub total()
        Try
            For i As Integer = 0 To dgv_Disbursement.Rows.Count - 1
                debit += dgv_Disbursement.Item(2, i).Value
                'credit += dgv_Disbursement.Item(3, i).Value
            Next
            MsgBox(debit)
            MsgBox(credit)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            clearP()
            ControlNo()
            readonlyfalse()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChartToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChartToolStripMenuItem1.Click
        Chart.ShowDialog()
    End Sub

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Private Sub MetroTabPage3_Click(sender As Object, e As EventArgs) Handles MetroTabPage3.Click

    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

    End Sub

    Private Sub MetroTabPage3_Enter(sender As Object, e As EventArgs) Handles MetroTabPage3.Enter
        CSheet()
    End Sub

    Private Sub ChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChartToolStripMenuItem.Click

    End Sub

    Private Sub txt_amtno_Click(sender As Object, e As EventArgs) Handles txt_amtno.Click

    End Sub

    Private Sub MetroTabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl2.SelectedIndexChanged

    End Sub

    Private Sub MetroComboBox1_DropDown(sender As Object, e As EventArgs) Handles cbo_Chart.DropDown
        AddChart("Item")
    End Sub

    Sub voucherdata()
        Dim cmd As New SqlCommand
        Dim dt As DataTable

        strQuery = "SELECT controlno,
	                       payee,
	                       amountno,
	                       amountwd,
	                       particulars,
	                       bank,
                           checkseries
                    FROM vw_CVPrint
                    WHERE controlno LIKE '" & txt_Search.Text & "'"

        cmd.CommandText = strQuery
        dt = GetData(cmd)

        If dt.Rows.Count > 0 Then
            UpsertCost = True
            lbl_ControlNo.Text = dt.Rows(dt.Rows.Count - 1).Item(0)
            txt_Payee.Text = dt.Rows(dt.Rows.Count - 1).Item(1)
            txt_amtno.Text = dt.Rows(dt.Rows.Count - 1).Item(2)
            lbl_amtwd.Text = dt.Rows(dt.Rows.Count - 1).Item(3)
            txt_particulars.Text = dt.Rows(dt.Rows.Count - 1).Item(4)
            Bank("Item")
            cbo_Bank.SelectedItem = dt.Rows(dt.Rows.Count - 1).Item(5)
            lbl_Checkseries.Text = dt.Rows(dt.Rows.Count - 1).Item(6)

            strQuery = "SELECT id,
                               code as 'Code',
                               description as 'Description',
                               debit as 'Debit',
                               credit as 'Credit'
                        FROM vw_CVPrint
                        WHERE controlno LIKE '" & txt_Search.Text & "'"

            cmd.CommandText = strQuery
            dt = GetData(cmd)

            dgv_dummy.DataSource = dt
            dgv_dummy.Columns(0).Visible = False

            Dim col As New DataGridViewLinkColumn
            col.Name = ""
            col.UseColumnTextForLinkValue = True
            col.Text = "Remove"
            dgv_dummy.Columns.Add(col)

            dgv_Disbursement.Visible = False
            dgv_dummy.Visible = True
        End If
    End Sub

    Sub readonlytrue()
        Try
            txt_Payee.ReadOnly = True
            txt_amtno.ReadOnly = True
            txt_particulars.ReadOnly = True
            cbo_Bank.Enabled = False
            cbo_Chart.Enabled = False
            txt_Desc.ReadOnly = True
            txt_Deb.ReadOnly = True
            txt_Cre.ReadOnly = True
            dgv_dummy.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub readonlyfalse()
        Try
            txt_Payee.ReadOnly = False
            txt_amtno.ReadOnly = False
            txt_particulars.ReadOnly = False
            cbo_Bank.Enabled = True
            cbo_Chart.Enabled = True
            txt_Desc.ReadOnly = False
            txt_Deb.ReadOnly = False
            txt_Cre.ReadOnly = False
            dgv_dummy.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim cmd As New SqlCommand
                Dim dt As DataTable
                Dim stat As String

                strQuery = "SELECT status FROM tbl_header
                            WHERE controlno LIKE '" & txt_Search.Text & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                If dt.Rows.Count > 0 Then
                    stat = dt.Rows(dt.Rows.Count - 1).Item(0)

                    If stat = "Save" Or stat = "Posted" Then
                        MetroMessageBox.Show(BCEParent, "Modification of check voucher subject for declaration or already posted is not allowed. Voucher is for viewing only.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        voucherdata()
                        readonlytrue()
                    ElseIf stat = "Denied" Then
                        voucherdata()
                        readonlyfalse()
                    End If
                Else
                    MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_dummy_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgv_dummy.CellPainting
        Try
            If e.ColumnIndex = -1 AndAlso e.RowIndex > -1 AndAlso e.RowIndex < dgv_dummy.Rows.Count Then
                Dim indexString As String = (e.RowIndex + 1).ToString
                Dim sz As SizeF = e.Graphics.MeasureString(indexString, dgv_dummy.Font)
                Dim pt As New PointF(e.CellBounds.Width - sz.Width, e.CellBounds.Y + (e.CellBounds.Height / 2 - sz.Height / 2))
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All)
                e.Graphics.DrawString(indexString, dgv_dummy.Font, Brushes.Black, pt)
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class