<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickupCancel
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
        Me.rb_Charge = New MetroFramework.Controls.MetroRadioButton()
        Me.rb_Free = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_Reason = New MetroFramework.Controls.MetroTextBox()
        Me.btn_Submit = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'rb_Charge
        '
        Me.rb_Charge.AutoSize = True
        Me.rb_Charge.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rb_Charge.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.rb_Charge.Location = New System.Drawing.Point(23, 63)
        Me.rb_Charge.Name = "rb_Charge"
        Me.rb_Charge.Size = New System.Drawing.Size(118, 19)
        Me.rb_Charge.Style = MetroFramework.MetroColorStyle.Teal
        Me.rb_Charge.TabIndex = 0
        Me.rb_Charge.Text = "Charge to client"
        Me.rb_Charge.UseSelectable = True
        '
        'rb_Free
        '
        Me.rb_Free.AutoSize = True
        Me.rb_Free.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rb_Free.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.rb_Free.Location = New System.Drawing.Point(147, 63)
        Me.rb_Free.Name = "rb_Free"
        Me.rb_Free.Size = New System.Drawing.Size(111, 19)
        Me.rb_Free.Style = MetroFramework.MetroColorStyle.Teal
        Me.rb_Free.TabIndex = 1
        Me.rb_Free.Text = "Free of charge"
        Me.rb_Free.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 306)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(291, 40)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Pickup cancellation request will be send to your Immediate Superior for Approval"
        Me.MetroLabel1.WrapToLine = True
        '
        'txt_Reason
        '
        '
        '
        '
        Me.txt_Reason.CustomButton.Image = Nothing
        Me.txt_Reason.CustomButton.Location = New System.Drawing.Point(105, 1)
        Me.txt_Reason.CustomButton.Name = ""
        Me.txt_Reason.CustomButton.Size = New System.Drawing.Size(185, 185)
        Me.txt_Reason.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_Reason.CustomButton.TabIndex = 1
        Me.txt_Reason.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_Reason.CustomButton.UseSelectable = True
        Me.txt_Reason.CustomButton.Visible = False
        Me.txt_Reason.Lines = New String(-1) {}
        Me.txt_Reason.Location = New System.Drawing.Point(23, 116)
        Me.txt_Reason.MaxLength = 32767
        Me.txt_Reason.Multiline = True
        Me.txt_Reason.Name = "txt_Reason"
        Me.txt_Reason.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Reason.PromptText = "Input reason or comment here"
        Me.txt_Reason.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Reason.SelectedText = ""
        Me.txt_Reason.SelectionLength = 0
        Me.txt_Reason.SelectionStart = 0
        Me.txt_Reason.ShortcutsEnabled = True
        Me.txt_Reason.Size = New System.Drawing.Size(291, 187)
        Me.txt_Reason.TabIndex = 4
        Me.txt_Reason.UseSelectable = True
        Me.txt_Reason.WaterMark = "Input reason or comment here"
        Me.txt_Reason.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_Reason.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_Submit
        '
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btn_Submit.Location = New System.Drawing.Point(207, 360)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(107, 31)
        Me.btn_Submit.TabIndex = 40
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btn_Submit.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 94)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(131, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Reason or comment:"
        Me.MetroLabel2.WrapToLine = True
        '
        'PickupCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 398)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_Reason)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.rb_Free)
        Me.Controls.Add(Me.rb_Charge)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "PickupCancel"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Pickup Cancellation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_Charge As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rb_Free As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_Reason As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_Submit As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
