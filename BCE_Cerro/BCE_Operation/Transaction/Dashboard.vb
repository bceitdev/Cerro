Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports MetroFramework
Imports System.Web.UI.WebControls
Imports Syncfusion.Windows.Forms.Tools

Public Class Dashboard


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim unused = Screen.PrimaryScreen.Bounds
    End Sub

    Sub pickup()
        Try
            strQuery = "EXEC dshbrd_pickupdata"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_pickup.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PUOpen()
        Try
            strQuery = "EXEC dshbrd_puopen"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_PUOpen.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
                mt_PUOpen.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PUInTransit()
        Try
            strQuery = "EXEC dshbrd_puintransit"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_PUIntransit.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
                mt_PUIntransit.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub StatusHighlight()
        Try
            For Each row As DataGridViewRow In dgv_pickup.Rows
                If row.Cells(3).Value = "OPEN" Then
                    row.Cells(3).Style.BackColor = Color.Firebrick
                    row.Cells(3).Style.ForeColor = Color.White
                ElseIf row.Cells(3).Value = "IN TRANSIT" Then
                    row.Cells(3).Style.BackColor = Color.Gold
                    row.Cells(3).Style.ForeColor = Color.White
                End If
            Next

            For Each row As DataGridViewRow In dgv_delivery.Rows
                If row.Cells(4).Value = "OPEN" Then
                    row.Cells(4).Style.BackColor = Color.Firebrick
                    row.Cells(4).Style.ForeColor = Color.White
                ElseIf row.Cells(4).Value = "IN TRANSIT" Then
                    row.Cells(4).Style.BackColor = Color.Gold
                    row.Cells(4).Style.ForeColor = Color.White
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Delivery()
        Try
            strQuery = "EXEC dshbrd_deliverydata"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            dgv_delivery.DataSource = dt
            dgv_delivery.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub DelOpen()
        Try
            strQuery = "EXEC dshbrd_delopen"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_DelOpen.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
                mt_DelOpen.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub DelInTransit()
        Try
            strQuery = "EXEC dshbrd_delintransit"
            Dim cmd As New SqlCommand(strQuery)
            Dim dt As DataTable = GetData(cmd)

            If dt.Rows.Count > 0 Then
                mt_DelIntransit.TileCount = dt.Rows(dt.Rows.Count - 1).Item(0)
                mt_DelIntransit.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_datetime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy" & vbCrLf & "               hh:mm:ss tt")

        pickup()
        PUOpen()
        PUInTransit()
        Delivery()
        DelOpen()
        DelInTransit()
        StatusHighlight()
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PUOpen()
        PUInTransit()
        DelOpen()
        DelInTransit()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If MetroLabel3.Text = "P1" Then
            PictureBox3.BackgroundImage = My.Resources.airasia
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P2"
        ElseIf MetroLabel3.Text = "P2" Then
            PictureBox3.BackgroundImage = My.Resources.Cebu_Pacific_logo_2017_10_14_03_23_23
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P3"
        ElseIf MetroLabel3.Text = "P3" Then
            PictureBox3.BackgroundImage = My.Resources.pal
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P4"
        ElseIf MetroLabel3.Text = "P4" Then
            PictureBox3.BackgroundImage = My.Resources._2go1
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P5"
        ElseIf MetroLabel3.Text = "P5" Then
            PictureBox3.BackgroundImage = My.Resources.airswift
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P6"
        ElseIf MetroLabel3.Text = "P6" Then
            PictureBox3.BackgroundImage = My.Resources.gothongline
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P7"
        ElseIf MetroLabel3.Text = "P7" Then
            PictureBox3.BackgroundImage = My.Resources.malvar
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P8"
        ElseIf MetroLabel3.Text = "P8" Then
            PictureBox3.BackgroundImage = My.Resources.moreta
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P9"
        ElseIf MetroLabel3.Text = "P9" Then
            PictureBox3.BackgroundImage = My.Resources.panpacific3
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P10"
        ElseIf MetroLabel3.Text = "P10" Then
            PictureBox3.BackgroundImage = My.Resources.SKYJET_Airlines_Logo
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P11"
        ElseIf MetroLabel3.Text = "P11" Then
            PictureBox3.BackgroundImage = My.Resources.solidshippingline
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P12"
        ElseIf MetroLabel3.Text = "P12" Then
            PictureBox3.BackgroundImage = My.Resources.transasia
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            MetroLabel3.Text = "P1"
        End If
    End Sub
End Class