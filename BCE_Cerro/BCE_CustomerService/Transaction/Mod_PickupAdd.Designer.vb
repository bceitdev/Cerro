<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mod_PickupAdd
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_ConPer = New MetroFramework.Controls.MetroTextBox()
        Me.txt_Add = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_Phone = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt_Email = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Update = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Contact Person"
        '
        'txt_ConPer
        '
        '
        '
        '
        Me.txt_ConPer.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_ConPer.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_ConPer.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_ConPer.CustomButton.Image = Nothing
        Me.txt_ConPer.CustomButton.Location = New System.Drawing.Point(243, 1)
        Me.txt_ConPer.CustomButton.Name = ""
        Me.txt_ConPer.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_ConPer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_ConPer.CustomButton.TabIndex = 1
        Me.txt_ConPer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_ConPer.CustomButton.UseSelectable = True
        Me.txt_ConPer.CustomButton.Visible = False
        Me.txt_ConPer.Lines = New String(-1) {}
        Me.txt_ConPer.Location = New System.Drawing.Point(23, 84)
        Me.txt_ConPer.MaxLength = 32767
        Me.txt_ConPer.Name = "txt_ConPer"
        Me.txt_ConPer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ConPer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ConPer.SelectedText = ""
        Me.txt_ConPer.SelectionLength = 0
        Me.txt_ConPer.SelectionStart = 0
        Me.txt_ConPer.ShortcutsEnabled = True
        Me.txt_ConPer.ShowClearButton = True
        Me.txt_ConPer.Size = New System.Drawing.Size(265, 23)
        Me.txt_ConPer.TabIndex = 1
        Me.txt_ConPer.UseSelectable = True
        Me.txt_ConPer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_ConPer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_Add
        '
        '
        '
        '
        Me.txt_Add.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Add.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_Add.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_Add.CustomButton.Image = Nothing
        Me.txt_Add.CustomButton.Location = New System.Drawing.Point(243, 1)
        Me.txt_Add.CustomButton.Name = ""
        Me.txt_Add.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Add.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Add.CustomButton.TabIndex = 1
        Me.txt_Add.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Add.CustomButton.UseSelectable = True
        Me.txt_Add.CustomButton.Visible = False
        Me.txt_Add.Lines = New String(-1) {}
        Me.txt_Add.Location = New System.Drawing.Point(23, 132)
        Me.txt_Add.MaxLength = 32767
        Me.txt_Add.Name = "txt_Add"
        Me.txt_Add.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Add.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Add.SelectedText = ""
        Me.txt_Add.SelectionLength = 0
        Me.txt_Add.SelectionStart = 0
        Me.txt_Add.ShortcutsEnabled = True
        Me.txt_Add.ShowClearButton = True
        Me.txt_Add.Size = New System.Drawing.Size(265, 23)
        Me.txt_Add.TabIndex = 3
        Me.txt_Add.UseSelectable = True
        Me.txt_Add.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Add.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 108)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Address"
        '
        'txt_Phone
        '
        '
        '
        '
        Me.txt_Phone.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Phone.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_Phone.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_Phone.CustomButton.Image = Nothing
        Me.txt_Phone.CustomButton.Location = New System.Drawing.Point(243, 1)
        Me.txt_Phone.CustomButton.Name = ""
        Me.txt_Phone.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Phone.CustomButton.TabIndex = 1
        Me.txt_Phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Phone.CustomButton.UseSelectable = True
        Me.txt_Phone.CustomButton.Visible = False
        Me.txt_Phone.Lines = New String(-1) {}
        Me.txt_Phone.Location = New System.Drawing.Point(23, 180)
        Me.txt_Phone.MaxLength = 32767
        Me.txt_Phone.Name = "txt_Phone"
        Me.txt_Phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Phone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Phone.SelectedText = ""
        Me.txt_Phone.SelectionLength = 0
        Me.txt_Phone.SelectionStart = 0
        Me.txt_Phone.ShortcutsEnabled = True
        Me.txt_Phone.ShowClearButton = True
        Me.txt_Phone.Size = New System.Drawing.Size(265, 23)
        Me.txt_Phone.TabIndex = 5
        Me.txt_Phone.UseSelectable = True
        Me.txt_Phone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Phone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 156)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Phone"
        '
        'txt_Email
        '
        '
        '
        '
        Me.txt_Email.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txt_Email.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txt_Email.CustomButton.FlatAppearance.BorderSize = 10
        Me.txt_Email.CustomButton.Image = Nothing
        Me.txt_Email.CustomButton.Location = New System.Drawing.Point(243, 1)
        Me.txt_Email.CustomButton.Name = ""
        Me.txt_Email.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Email.CustomButton.TabIndex = 1
        Me.txt_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Email.CustomButton.UseSelectable = True
        Me.txt_Email.CustomButton.Visible = False
        Me.txt_Email.Lines = New String(-1) {}
        Me.txt_Email.Location = New System.Drawing.Point(23, 228)
        Me.txt_Email.MaxLength = 32767
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Email.SelectedText = ""
        Me.txt_Email.SelectionLength = 0
        Me.txt_Email.SelectionStart = 0
        Me.txt_Email.ShortcutsEnabled = True
        Me.txt_Email.ShowClearButton = True
        Me.txt_Email.Size = New System.Drawing.Size(265, 23)
        Me.txt_Email.TabIndex = 7
        Me.txt_Email.UseSelectable = True
        Me.txt_Email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 204)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Email"
        '
        'btn_Update
        '
        Me.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Update.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Update.Location = New System.Drawing.Point(181, 275)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(107, 31)
        Me.btn_Update.TabIndex = 12
        Me.btn_Update.Text = "Update"
        Me.btn_Update.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Update.UseSelectable = True
        '
        'Mod_PickupAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 321)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txt_Phone)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt_Add)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txt_ConPer)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mod_PickupAdd"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Modify Pickup Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_ConPer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_Add As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_Phone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_Email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Update As MetroFramework.Controls.MetroButton
End Class
