Imports System.Data
Imports System.Data.SqlClient
Imports MetroFramework
Imports System.Configuration
Imports System.Windows.Forms.DataVisualization.Charting

Public Class KPI
    Dim jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec, tgt As Integer
    Dim p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12 As Double
    Dim cht_title As String
    Dim cmd As New SqlCommand
    Dim dt As DataTable


    Private Sub KPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectDept()
    End Sub

    Sub SelectDept()
        Try
            strQuery = "SELECT kpino FROM tbl_KPI
                        WHERE dept_id = '" & Dept_Id & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ct_cskpi1()
        Try
            strQuery = "SELECT MONTH(shipdate) MONTH, COUNT(*) COUNT
                        FROM tbl_outbound
                        WHERE YEAR(shipdate)= '" & cbo_Year.Text & "'
                        GROUP BY MONTH(shipdate)
                        ORDER BY MONTH"

            dts()
            cht_series()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ct_cskpi2()
        Try
            strQuery = "SELECT MONTH(shipdate) MONTH, COUNT(*) COUNT
                        FROM vw_shipmentstatus
                        WHERE YEAR(shipdate)= '" & cbo_Year.Text & "'
                            AND status LIKE 'DELIVERED'
                        GROUP BY MONTH(shipdate)
                        ORDER BY MONTH"

            dts()
            cht_series()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ct_cskpi3()
        Try
            strQuery = "SELECT MONTH(shipdate) MONTH, COUNT(*) COUNT
                        FROM vw_shipmentstatus
                        WHERE YEAR(shipdate)= '" & cbo_Year.Text & "'
                            AND status LIKE 'IN TRANSIT'
                        GROUP BY MONTH(shipdate)
                        ORDER BY MONTH"

            dts()
            cht_series()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ct_cskpi4()
        Try
            strQuery = "SELECT MONTH(shipdate) MONTH, COUNT(*) COUNT
                        FROM vw_shipmentstatus
                        WHERE YEAR(shipdate)= '" & cbo_Year.Text & "'
                            AND status LIKE 'CLOSED'
                        GROUP BY MONTH(shipdate)
                        ORDER BY MONTH"

            dts()
            cht_series()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub dts()
        Try
            cmd.CommandText = strQuery
            dt = GetData(cmd)

            If dt.Rows.Count = 1 Then
                jan = dt.Rows(0).Item(1)
            ElseIf dt.Rows.Count = 2 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
            ElseIf dt.Rows.Count = 3 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
            ElseIf dt.Rows.Count = 4 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
            ElseIf dt.Rows.Count = 5 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
            ElseIf dt.Rows.Count = 6 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
                jun = dt.Rows(5).Item(1)
            ElseIf dt.Rows.Count = 7 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
                jun = dt.Rows(5).Item(1)
                jul = dt.Rows(6).Item(1)
            ElseIf dt.Rows.Count = 8 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
                jun = dt.Rows(5).Item(1)
                jul = dt.Rows(6).Item(1)
                aug = dt.Rows(7).Item(1)
            ElseIf dt.Rows.Count = 9 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
                jun = dt.Rows(5).Item(1)
                jul = dt.Rows(6).Item(1)
                aug = dt.Rows(7).Item(1)
                sep = dt.Rows(8).Item(1)
            ElseIf dt.Rows.Count = 10 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
                jun = dt.Rows(5).Item(1)
                jul = dt.Rows(6).Item(1)
                aug = dt.Rows(7).Item(1)
                sep = dt.Rows(8).Item(1)
                oct = dt.Rows(9).Item(1)
            ElseIf dt.Rows.Count = 11 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
                jun = dt.Rows(5).Item(1)
                jul = dt.Rows(6).Item(1)
                aug = dt.Rows(7).Item(1)
                sep = dt.Rows(8).Item(1)
                oct = dt.Rows(9).Item(1)
                nov = dt.Rows(10).Item(1)
            ElseIf dt.Rows.Count = 12 Then
                jan = dt.Rows(0).Item(1)
                feb = dt.Rows(1).Item(1)
                mar = dt.Rows(2).Item(1)
                apr = dt.Rows(3).Item(1)
                may = dt.Rows(4).Item(1)
                jun = dt.Rows(5).Item(1)
                jul = dt.Rows(6).Item(1)
                aug = dt.Rows(7).Item(1)
                sep = dt.Rows(8).Item(1)
                oct = dt.Rows(9).Item(1)
                nov = dt.Rows(10).Item(1)
                dec = dt.Rows(11).Item(1)
            Else
                jan = 0
                feb = 0
                mar = 0
                apr = 0
                may = 0
                jun = 0
                jul = 0
                aug = 0
                sep = 0
                oct = 0
                nov = 0
                dec = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cht_series()
        Try
            Dim ctp As Integer = 100

            cht_kpi.Titles(0).Text = cht_title

            cht_kpi.Series(0).Points(0).SetValueXY("Jan", jan)
            cht_kpi.Series(1).Points(0).SetValueXY("Jan", tgt)
            p1 = (jan / tgt) * (ctp)
            cht_kpi.Series(2).Points(0).SetValueXY("Jan", p1.ToString("00.00"))

            cht_kpi.Series(0).Points(1).SetValueXY("Feb", feb)
            cht_kpi.Series(1).Points(1).SetValueXY("Feb", tgt)
            p2 = (feb / tgt) * (ctp)
            cht_kpi.Series(2).Points(1).SetValueXY("Feb", p2.ToString("00.00"))

            cht_kpi.Series(0).Points(2).SetValueXY("Mar", mar)
            cht_kpi.Series(1).Points(2).SetValueXY("Mar", tgt)
            p3 = (mar / tgt) * (ctp)
            cht_kpi.Series(2).Points(2).SetValueXY("Mar", p3.ToString("00.00"))

            cht_kpi.Series(0).Points(3).SetValueXY("Apr", apr)
            cht_kpi.Series(1).Points(3).SetValueXY("Apr", tgt)
            p4 = (apr / tgt) * (ctp)
            cht_kpi.Series(2).Points(3).SetValueXY("Apr", p4.ToString("00.00"))

            cht_kpi.Series(0).Points(4).SetValueXY("May", may)
            cht_kpi.Series(1).Points(4).SetValueXY("May", tgt)
            p5 = (may / tgt) * (ctp)
            cht_kpi.Series(2).Points(4).SetValueXY("May", p5.ToString("00.00"))

            cht_kpi.Series(0).Points(5).SetValueXY("Jun", jun)
            cht_kpi.Series(1).Points(5).SetValueXY("Jun", tgt)
            p6 = (jun / tgt) * (ctp)
            cht_kpi.Series(2).Points(5).SetValueXY("Jun", p6.ToString("00.00"))

            cht_kpi.Series(0).Points(6).SetValueXY("Jul", jul)
            cht_kpi.Series(1).Points(6).SetValueXY("Jul", tgt)
            p7 = (jul / tgt) * (ctp)
            cht_kpi.Series(2).Points(6).SetValueXY("Jul", p7.ToString("00.00"))

            cht_kpi.Series(0).Points(7).SetValueXY("Aug", aug)
            cht_kpi.Series(1).Points(7).SetValueXY("Aug", tgt)
            p8 = (aug / tgt) * (ctp)
            cht_kpi.Series(2).Points(7).SetValueXY("Aug", p8.ToString("00.00"))

            cht_kpi.Series(0).Points(8).SetValueXY("Sep", sep)
            cht_kpi.Series(1).Points(8).SetValueXY("Sep", tgt)
            p9 = (sep / tgt) * (ctp)
            cht_kpi.Series(2).Points(8).SetValueXY("Sep", p9.ToString("00.00"))

            cht_kpi.Series(0).Points(9).SetValueXY("Oct", oct)
            cht_kpi.Series(1).Points(9).SetValueXY("Oct", tgt)
            p10 = (oct / tgt) * (ctp)
            cht_kpi.Series(2).Points(9).SetValueXY("Oct", p10.ToString("00.00"))

            cht_kpi.Series(0).Points(10).SetValueXY("Nov", nov)
            cht_kpi.Series(1).Points(10).SetValueXY("Nov", tgt)
            p11 = (nov / tgt) * (ctp)
            cht_kpi.Series(2).Points(10).SetValueXY("Nov", p11.ToString("00.00"))

            cht_kpi.Series(0).Points(11).SetValueXY("Dec", dec)
            cht_kpi.Series(1).Points(11).SetValueXY("Dec", tgt)
            p12 = (dec / tgt) * (ctp)
            cht_kpi.Series(2).Points(11).SetValueXY("Dec", p12.ToString("00.00"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub KPINo(ByVal u As String)
        Try
            strQuery = "SELECT kpino FROM tbl_KPI
                        WHERE dept_id = '" & Dept_Id & "'"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "Item") Then
                cbo_KPI.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "Item") Then
                    cbo_KPI.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_KPI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_KPI.SelectedIndexChanged
        SelectKPI()
    End Sub
    Sub SelectKPI()
        Try
            Dim cmd As New SqlCommand
            Dim dt As DataTable

            If cbo_Year.Text = Nothing Then
                MetroMessageBox.Show(BCEParent, "Must have Year", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                strQuery = "SELECT description, target FROM tbl_KPI
                            WHERE dept_id = '" & Dept_Id & "'
                                AND kpino LIKE '" & cbo_KPI.Text & "'"

                cmd.CommandText = strQuery
                dt = GetData(cmd)

                If dt.Rows.Count > 0 Then
                    cht_title = dt.Rows(dt.Rows.Count - 1).Item(0)
                    tgt = dt.Rows(dt.Rows.Count - 1).Item(1)

                    Select Case cbo_KPI.Text
                        Case Is = 1
                            ct_cskpi1()
                        Case Is = 2
                            ct_cskpi2()
                        Case Is = 3
                            ct_cskpi3()
                        Case Is = 4
                            ct_cskpi4()
                    End Select

                    cmd.CommandText = strQuery
                    dt = GetData(cmd)
                Else
                    cht_title = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_KPI_DropDown(sender As Object, e As EventArgs) Handles cbo_KPI.DropDown
        KPINo("Item")
    End Sub

    Sub Year(ByVal u As String)
        Try
            strQuery = "SELECT year FROM tbl_monthyear"

            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If (u = "Item") Then
                cbo_Year.Items.Clear()
            End If

            Dim ant As Integer = dt.Rows.Count()
            Dim a As Integer = 0

            While (ant > a)
                If (u = "Item") Then
                    cbo_Year.Items.Add(dt.Rows(a).Item(0))
                End If

                a = a + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbo_Year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Year.SelectedIndexChanged

    End Sub

    Private Sub cbo_Year_DropDown(sender As Object, e As EventArgs) Handles cbo_Year.DropDown
        Year("Item")
    End Sub
End Class