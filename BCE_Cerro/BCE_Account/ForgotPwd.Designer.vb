<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPwd
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
        Me.txt_emplid = New MetroFramework.Controls.MetroTextBox()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 73)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Employee ID:"
        '
        'txt_emplid
        '
        '
        '
        '
        Me.txt_emplid.CustomButton.Image = Nothing
        Me.txt_emplid.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.txt_emplid.CustomButton.Name = ""
        Me.txt_emplid.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_emplid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_emplid.CustomButton.TabIndex = 1
        Me.txt_emplid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_emplid.CustomButton.UseSelectable = True
        Me.txt_emplid.CustomButton.Visible = False
        Me.txt_emplid.Lines = New String(-1) {}
        Me.txt_emplid.Location = New System.Drawing.Point(115, 69)
        Me.txt_emplid.MaxLength = 32767
        Me.txt_emplid.Name = "txt_emplid"
        Me.txt_emplid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_emplid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_emplid.SelectedText = ""
        Me.txt_emplid.SelectionLength = 0
        Me.txt_emplid.SelectionStart = 0
        Me.txt_emplid.ShortcutsEnabled = True
        Me.txt_emplid.Size = New System.Drawing.Size(240, 23)
        Me.txt_emplid.TabIndex = 1
        Me.txt_emplid.UseSelectable = True
        Me.txt_emplid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_emplid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(165, 112)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(92, 31)
        Me.btn_Submit.TabIndex = 21
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Cancel.Location = New System.Drawing.Point(263, 112)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(92, 31)
        Me.btn_Cancel.TabIndex = 22
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseSelectable = True
        '
        'ForgotPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 157)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_emplid)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ForgotPwd"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_emplid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancel As MetroFramework.Controls.MetroButton
End Class
