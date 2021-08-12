Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Public Class CSDashboard
    Private Sub CSDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CountPickOpen()
        CountPickInTransit()
        CountPickClosed()
        CountDelOpen()
        CountDelIntransit()
        CountDelClosed()
        test()
    End Sub
    Private Sub CSDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub test()
        Try
            Cht_Column.Series(0).Points(0).SetValueXY("Jan", 69)
            Cht_Column.Series(1).Points(0).SetValueXY("Jan", 89)

            Cht_Column.Series(0).Points(1).SetValueXY("Feb", 43)
            Cht_Column.Series(1).Points(1).SetValueXY("Feb", 56)

            Cht_Column.Series(0).Points(2).SetValueXY("Mar", 18)
            Cht_Column.Series(1).Points(2).SetValueXY("Mar", 11)

            Cht_Column.Series(0).Points(3).SetValueXY("Apr", 19)
            Cht_Column.Series(1).Points(3).SetValueXY("Apr", 78)

            Cht_Column.Series(0).Points(3).SetValueXY("May", 19)
            Cht_Column.Series(1).Points(3).SetValueXY("May", 78)

            Cht_Column.Series(0).Points(3).SetValueXY("June", 19)
            Cht_Column.Series(1).Points(3).SetValueXY("June", 78)

            '--------

            Cht_Line.Series(0).Points(0).SetValueXY("19WK51", 69)
            Cht_Line.Series(1).Points(0).SetValueXY("19WK51", 89)

            Cht_Line.Series(0).Points(1).SetValueXY("19WK52", 43)
            Cht_Line.Series(1).Points(1).SetValueXY("19WK52", 56)

            Cht_Line.Series(0).Points(2).SetValueXY("19WK53", 18)
            Cht_Line.Series(1).Points(2).SetValueXY("19WK53", 11)

            Cht_Line.Series(0).Points(3).SetValueXY("19WK54", 19)
            Cht_Line.Series(1).Points(3).SetValueXY("19WK54", 78)

            '--------

            cht_bar.Series(0).Points(0).SetValueXY("19WK51", 69)
            cht_bar.Series(1).Points(0).SetValueXY("19WK51", 89)

            cht_bar.Series(0).Points(1).SetValueXY("19WK52", 43)
            cht_bar.Series(1).Points(1).SetValueXY("19WK52", 56)

            cht_bar.Series(0).Points(2).SetValueXY("19WK53", 18)
            cht_bar.Series(1).Points(2).SetValueXY("19WK53", 11)

            cht_bar.Series(0).Points(3).SetValueXY("19WK54", 19)
            cht_bar.Series(1).Points(3).SetValueXY("19WK54", 78)

            '--------

            Cht_Pie.Series(0).Points(0).SetValueXY("69%", 69%)
            Cht_Pie.Series(0).Points(1).SetValueXY("89%", 89%)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CountPickOpen()
        Try
            strQuery = "EXEC ct_pickopen"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_PickOpen.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                mt_PickOpen.TileCount = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CountPickInTransit()
        Try
            strQuery = "EXEC ct_pickintransit"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_PickIntransit.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                mt_PickIntransit.TileCount = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CountPickClosed()
        Try
            strQuery = "EXEC ct_pickclosed"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_PickClosed.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                mt_PickClosed.TileCount = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CountDelOpen()
        Try
            strQuery = "EXEC ct_delopen"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_DelOpen.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                mt_DelOpen.TileCount = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CountDelIntransit()
        Try
            strQuery = "EXEC ct_delintransit"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_DelIntransit.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                mt_DelIntransit.TileCount = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CountDelClosed()
        Try
            strQuery = "EXEC ct_delclosed"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_DelClosed.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
            Else
                mt_DelClosed.TileCount = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class