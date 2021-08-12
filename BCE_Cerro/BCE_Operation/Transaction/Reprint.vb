Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.Web.UI.WebControls
Imports CrystalDecisions.CrystalReports.Engine
Public Class Reprint
    'Dim rptdoc As ReportDocument
    Dim HWBs As String

    Private Sub Reprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Reprint_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Reprint()
        Try
            Dim letter As String

            letter = txt_Search.Text.Substring(0, 3)
            HWBs = letter + txt_Search.Text.Remove(0, 3).PadLeft(10, "0")

            GetItem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Reprint()
    End Sub
    Sub GetItem()
        Try
            conn("SELECT pur_no,
                         hwb_no_carb,
                         hwb_no, 
	                     shipdate,
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
                  WHERE hwb_no LIKE '" & HWBs & "'", "tbl_dummydimension")

            If dtsearch.Rows.Count > 0 Then
                HWBReprint = dtsearch.Rows(dtsearch.Rows.Count - 1).Item(2)
                shipdateReprint = dtsearch.Rows(dtsearch.Rows.Count - 1).Item(3)
                HWBSheetReprint()
            Else
                MetroMessageBox.Show(BCEParent, "No record found", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            rptdocreprint = New cr_HWB
            rptdocreprint.SetDataSource(dssearch)
            txt_CtrlNo = rptdocreprint.ReportDefinition.ReportObjects("txt_CtrlNo")
            txt_CtrlNo.Text = HWBReprint
            txt_ShipDate = rptdocreprint.ReportDefinition.ReportObjects("txt_ShipDate")
            txt_ShipDate.Text = shipdateReprint

            TrackingReprint.crv_HWB.ReportSource = rptdocreprint
            TrackingReprint.crv_HWB.Refresh()

            TrackingReprint.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Search_Click(sender As Object, e As EventArgs) Handles txt_Search.Click

    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown

        If e.KeyCode = Keys.Enter Then
            Reprint()
        End If

    End Sub
End Class