<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.txt_Current = New MetroFramework.Controls.MetroTextBox()
        Me.txt_New = New MetroFramework.Controls.MetroTextBox()
        Me.txt_Confirm = New MetroFramework.Controls.MetroTextBox()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txt_Current
        '
        '
        '
        '
        Me.txt_Current.CustomButton.Image = Nothing
        Me.txt_Current.CustomButton.Location = New System.Drawing.Point(317, 1)
        Me.txt_Current.CustomButton.Name = ""
        Me.txt_Current.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Current.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Current.CustomButton.TabIndex = 1
        Me.txt_Current.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Current.CustomButton.UseSelectable = True
        Me.txt_Current.CustomButton.Visible = False
        Me.txt_Current.Lines = New String(-1) {}
        Me.txt_Current.Location = New System.Drawing.Point(23, 63)
        Me.txt_Current.MaxLength = 32767
        Me.txt_Current.Name = "txt_Current"
        Me.txt_Current.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_Current.PromptText = "Current Password"
        Me.txt_Current.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Current.SelectedText = ""
        Me.txt_Current.SelectionLength = 0
        Me.txt_Current.SelectionStart = 0
        Me.txt_Current.ShortcutsEnabled = True
        Me.txt_Current.Size = New System.Drawing.Size(339, 23)
        Me.txt_Current.TabIndex = 2
        Me.txt_Current.UseSelectable = True
        Me.txt_Current.UseSystemPasswordChar = True
        Me.txt_Current.WaterMark = "Current Password"
        Me.txt_Current.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Current.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_New
        '
        '
        '
        '
        Me.txt_New.CustomButton.Image = Nothing
        Me.txt_New.CustomButton.Location = New System.Drawing.Point(317, 1)
        Me.txt_New.CustomButton.Name = ""
        Me.txt_New.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_New.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_New.CustomButton.TabIndex = 1
        Me.txt_New.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_New.CustomButton.UseSelectable = True
        Me.txt_New.CustomButton.Visible = False
        Me.txt_New.Lines = New String(-1) {}
        Me.txt_New.Location = New System.Drawing.Point(23, 92)
        Me.txt_New.MaxLength = 32767
        Me.txt_New.Name = "txt_New"
        Me.txt_New.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_New.PromptText = "New Password"
        Me.txt_New.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_New.SelectedText = ""
        Me.txt_New.SelectionLength = 0
        Me.txt_New.SelectionStart = 0
        Me.txt_New.ShortcutsEnabled = True
        Me.txt_New.Size = New System.Drawing.Size(339, 23)
        Me.txt_New.TabIndex = 4
        Me.txt_New.UseSelectable = True
        Me.txt_New.UseSystemPasswordChar = True
        Me.txt_New.WaterMark = "New Password"
        Me.txt_New.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_New.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_Confirm
        '
        '
        '
        '
        Me.txt_Confirm.CustomButton.Image = Nothing
        Me.txt_Confirm.CustomButton.Location = New System.Drawing.Point(317, 1)
        Me.txt_Confirm.CustomButton.Name = ""
        Me.txt_Confirm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_Confirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Confirm.CustomButton.TabIndex = 1
        Me.txt_Confirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Confirm.CustomButton.UseSelectable = True
        Me.txt_Confirm.CustomButton.Visible = False
        Me.txt_Confirm.Lines = New String(-1) {}
        Me.txt_Confirm.Location = New System.Drawing.Point(23, 121)
        Me.txt_Confirm.MaxLength = 32767
        Me.txt_Confirm.Name = "txt_Confirm"
        Me.txt_Confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_Confirm.PromptText = "Confirm Password"
        Me.txt_Confirm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Confirm.SelectedText = ""
        Me.txt_Confirm.SelectionLength = 0
        Me.txt_Confirm.SelectionStart = 0
        Me.txt_Confirm.ShortcutsEnabled = True
        Me.txt_Confirm.Size = New System.Drawing.Size(339, 23)
        Me.txt_Confirm.TabIndex = 6
        Me.txt_Confirm.UseSelectable = True
        Me.txt_Confirm.UseSystemPasswordChar = True
        Me.txt_Confirm.WaterMark = "Confirm Password"
        Me.txt_Confirm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Confirm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(270, 159)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 31)
        Me.btn_Cancel.TabIndex = 24
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(172, 159)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(92, 31)
        Me.btn_Submit.TabIndex = 23
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 204)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_Confirm)
        Me.Controls.Add(Me.txt_New)
        Me.Controls.Add(Me.txt_Current)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePass"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Change Password"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Current As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_New As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_Confirm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
End Class
