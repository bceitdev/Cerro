Imports System.Data
Imports System.Data.SqlClient
Public Class Mod_PickupAdd

    Public origid As Integer
    Private Sub Mod_PickupAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Try
            strQuery = "UPDATE tbl_cs_pickuporig SET contactperson = @contactperson,
                                                     no_street_etc = @no_street_etc,
                                                     phone = @phone,
                                                     email = @email
                        WHERE id = @id"
            Dim cmd As New SqlCommand(strQuery)
            cmd.Parameters.AddWithValue("id", origid)
            cmd.Parameters.AddWithValue("contactperson", txt_ConPer.Text)
            cmd.Parameters.AddWithValue("no_street_etc", txt_Add.Text)
            cmd.Parameters.AddWithValue("phone", txt_Phone.Text)
            cmd.Parameters.AddWithValue("email", txt_Email.Text)
            Dim dt As DataTable = GetData(cmd)

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class